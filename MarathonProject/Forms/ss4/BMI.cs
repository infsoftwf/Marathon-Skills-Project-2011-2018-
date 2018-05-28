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
    public partial class BMI : Form
    {
        Thread mainThread = null;

        Dictionary<String, String> m_map = new Dictionary<String, String>();

        public BMI()
        {
            InitializeComponent();
        }

        private void BMI_Load(object sender, EventArgs e)
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

            m_map.Add("Недостаточный", "bmi-underweight-icon.png");
            m_map.Add("Здоровый", "bmi-healthy-icon.png");
            m_map.Add("Избыточный", "bmi-overweight-icon.png");
            m_map.Add("Ожирение", "bmi-obese-icon.png");

            imgMain.Tag = "Здоровый";

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

            imgMain.Paint += (_o, _e) =>
            {
                _e.Graphics.DrawImage(Image.FromFile(string.Concat(g_PathBMIIcons, @"\", m_map[(_o as PictureBox).Tag.ToString()])), new Rectangle(((_o as PictureBox).Width - 135) / 2, 40, 135, 200));

                using (Font myFont = new Font("Arial", 14))
                    _e.Graphics.DrawString((_o as PictureBox).Tag.ToString(), myFont, new SolidBrush(Color.FromArgb(255, 64, 64, 64)), new Point(((_o as PictureBox).Width - _e.Graphics.MeasureString((_o as PictureBox).Tag.ToString(), myFont).ToSize().Width) / 2, 270));
            };
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txRise.Text) 
                || string.IsNullOrEmpty(txWeight.Text) 
                || txRise.Text.Equals("0") 
                || txWeight.Text.Equals("0"))
            {
                MessageBox.Show(this, "Недопустимое значение!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var m_NormalizeWeight = Math.Pow(Convert.ToDouble(txRise.Text) / 100, 2);
      
            lbresbmi.Text = string.Format("{0:f}", Convert.ToDouble(txWeight.Text) / m_NormalizeWeight);
            var m_ResultBMI = Convert.ToDouble(txWeight.Text) / m_NormalizeWeight;

            if (m_ResultBMI < 18.5f)
            {
                imgMain.Tag = "Недостаточный";
                imgMain.Invalidate();

                refBmi.Location = new Point(h_underweight.Location.X + ((h_underweight.Size.Width / 2) - 17), refBmi.Location.Y);
            }
            else if (m_ResultBMI >= 18.5f && m_ResultBMI <= 24.9f)
            {
                imgMain.Tag = "Здоровый";
                imgMain.Invalidate();

                refBmi.Location = new Point(h_healthy.Location.X + ((h_healthy.Size.Width / 2) - 17), refBmi.Location.Y);
            }
            else if (m_ResultBMI >= 25f && m_ResultBMI <= 29.9f)
            {
                imgMain.Tag = "Избыточный";
                imgMain.Invalidate();

                refBmi.Location = new Point(h_overweight.Location.X + ((h_overweight.Size.Width / 2) - 17), refBmi.Location.Y);
            }
            else if (m_ResultBMI >= 30f)
            {
                imgMain.Tag = "Ожирение";
                imgMain.Invalidate();

                refBmi.Location = new Point(h_obese.Location.X + ((h_obese.Size.Width / 2) - 17), refBmi.Location.Y);
            }

            lbresbmi.Location = new Point((lbresbmi.Text.Length > 4 ? -16 : -5) + refBmi.Location.X + (lbresbmi.Size.Width - (lbresbmi.Text.Length > 5 ? 13 : 0) - refBmi.Size.Width), lbresbmi.Location.Y);
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MoreInfo>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void BMI_FormClosed(object sender, FormClosedEventArgs e)
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
            imgFem.Invalidate();

            imgMan.CreateGraphics().DrawRectangle(new Pen(Color.Gray, 2.0f), new Rectangle(new Point(0, 0),
                new Size(imgMan.Width - 2, imgMan.Height - 2)));
        }

        private void imgFem_Click(object sender, EventArgs e)
        {
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
    }
}

