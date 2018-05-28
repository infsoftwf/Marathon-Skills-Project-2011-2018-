using MarathonProject.Forms.ss4;
using MarathonProject.INF_TOOLS;
using MarathonProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;

namespace MarathonProject.Forms
{
    public partial class BMR : Form
    {
        Thread mainThread = null;

        enum Gender
        {
            Male,
            Female
        }

        Gender pGender = Gender.Male;

        public BMR()
        {
            InitializeComponent();
        }

        private void BMR_Load(object sender, EventArgs e)
        {
            mainThread = new Thread(() =>
            {
                while (true)
                {
                    DateTime eTime;
                    DateTime.TryParse(s_GlobalMarathonDate, out eTime);
                    var resultTime = eTime.Subtract(DateTime.Now);
                    if (lbEndTime.InvokeRequired && !lbEndTime.IsDisposed)
                    {
                        if (resultTime > TimeSpan.Zero)
                            lbEndTime.BeginInvoke((MethodInvoker)(() => lbEndTime.Text = getTime(resultTime)));

                        lbEndTime.BeginInvoke((MethodInvoker)(() => lbEndTime.Location = new Point((this.Size.Width - lbEndTime.Size.Width) / 2, 16)));
                    }
                    Thread.Sleep(1000);
                }
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Lowest
            };
            mainThread.Start();

            bool bInit = true;

            imgMan.Paint += (_o, _e) =>
            {
                if (bInit)
                {
                    _e.Graphics.DrawRectangle(new Pen(Color.Gray, 2.0f), new Rectangle(new Point(0, 0), new Size(imgMan.Width - 2, imgMan.Height - 2)));
                    bInit = false;
                }
                _e.Graphics.DrawImage(Image.FromFile(string.Concat(g_PathGenderIcons, @"\", "male-icon.png")), new Rectangle(((_o as PictureBox).Width - 35) / 2, 10, 35, 70));

                using (Font myFont = new Font("Arial", 14))
                    _e.Graphics.DrawString("Male", myFont, new SolidBrush(Color.FromArgb(255, 64, 64, 64)), new Point(((_o as PictureBox).Width - _e.Graphics.MeasureString("Male", myFont).ToSize().Width) / 2, 90));
            };

            imgFem.Paint += (_o, _e) =>
            {
                _e.Graphics.DrawImage(Image.FromFile(string.Concat(g_PathGenderIcons, @"\", "female-icon.png")), new Rectangle(((_o as PictureBox).Width - 35) / 2, 10, 35, 70));

                using (Font myFont = new Font("Arial", 14))
                    _e.Graphics.DrawString("Female", myFont, new SolidBrush(Color.FromArgb(255, 64, 64, 64)), new Point(((_o as PictureBox).Width - _e.Graphics.MeasureString("Female", myFont).ToSize().Width) / 2, 90));
            };

            btResult_Click(null, null);
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txRise.Text) 
                || string.IsNullOrEmpty(txWeight.Text)
                || string.IsNullOrEmpty(txYear.Text)
                || txRise.Text.Equals("0") 
                || txWeight.Text.Equals("0")
                || txYear.Text.Equals("0"))
            {
                MessageBox.Show(this, "Недопустимое значение!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lblow.Text = lblow.Text.Remove(lblow.Text.IndexOf(':'));
            lbsmall.Text = lbsmall.Text.Remove(lbsmall.Text.IndexOf(':'));
            lbav.Text = lbav.Text.Remove(lbav.Text.IndexOf(':'));
            lbhigh.Text = lbhigh.Text.Remove(lbhigh.Text.IndexOf(':'));
            lbultra.Text = lbultra.Text.Remove(lbultra.Text.IndexOf(':'));

            switch (pGender)
            {
                case Gender.Male:
                    lbBMR.Text = string.Format("{0}", Math.Truncate((66.47f + (13.75f * Convert.ToDouble(txWeight.Text)) + (5.003f * Convert.ToDouble(txRise.Text)) - (6.755f * Convert.ToDouble(txYear.Text)))) / 1000);
                    break;

                case Gender.Female:
                    lbBMR.Text = string.Format("{0}", Math.Truncate((655.1f + (9.563f * Convert.ToDouble(txWeight.Text)) + (1.85f * Convert.ToDouble(txRise.Text)) - (4.676f * Convert.ToDouble(txYear.Text)))) / 1000);
                    break;
            }

            lblow.Text = string.Concat(lblow.Text, ":   ", Math.Round(Convert.ToDouble(lbBMR.Text) * 1.2f, 3));
            lbsmall.Text = string.Concat(lbsmall.Text, ":   ", Math.Round(Convert.ToDouble(lbBMR.Text) * 1.375f, 3));
            lbav.Text = string.Concat(lbav.Text, ":   ", Math.Round(Convert.ToDouble(lbBMR.Text) * 1.55f, 3));
            lbhigh.Text = string.Concat(lbhigh.Text, ":   ", Math.Round(Convert.ToDouble(lbBMR.Text) * 1.725f, 3));
            lbultra.Text = string.Concat(lbultra.Text, ":   ", Math.Round(Convert.ToDouble(lbBMR.Text) * 1.9f, 3));
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MoreInfo>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void BMR_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MoreInfo>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void imgMan_Click(object sender, EventArgs e)
        {
            pGender = Gender.Male;

            imgFem.Invalidate();

            imgMan.CreateGraphics().DrawRectangle(new Pen(Color.Gray, 2.0f), new Rectangle(new Point(0, 0),
                new Size(imgMan.Width - 2, imgMan.Height - 2)));
        }

        private void imgFem_Click(object sender, EventArgs e)
        {
            pGender = Gender.Female;

            imgMan.Invalidate();

            imgFem.CreateGraphics().DrawRectangle(new Pen(Color.Gray, 2.0f), new Rectangle(new Point(0, 0),
                new Size(imgFem.Width - 2, imgFem.Height - 2)));
        }

        private void OnlyNum(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Any(x => !char.IsDigit(x)))
            {
                (sender as TextBox).Text = string.Concat((sender as TextBox).Text.Where(char.IsDigit));
                (sender as TextBox).Select((sender as TextBox).Text.Length, 0);
            }
        }

        private void imgDesc_Click(object sender, EventArgs e)
        {
            new BMRDetermine().ShowDialog();
        }
    }
}

