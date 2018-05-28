using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;

namespace MarathonProject.Forms
{
    public partial class MoreInfo : Form
    {
        Thread mainThread = null;

        public MoreInfo()
        {
            InitializeComponent();
        }

        private void MoreInfoRunner_Load(object sender, EventArgs e)
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
        }

        private void methodExit()
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MainMenu>().Single().Show();

            this.Dispose(true);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            this.Close();
        }

        private void backbut_Click(object sender, EventArgs e) => methodExit();

        private void MoreInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void btGetCharityList_Click(object sender, EventArgs e)
        {
            new CharityList().Show();
            this.Hide();
        }

        private void btLongMarathon_Click(object sender, EventArgs e)
        {
            new MarathonLong().Show();
            this.Hide();
        }

        private void btGetInfoMarathon_Click(object sender, EventArgs e)
        {
            new MarathonInfo().Show();
            this.Hide();
        }

        private void btPostResult_Click(object sender, EventArgs e)
        {
            new PostResultMarathon().Show();
            this.Hide();
        }

        private void btBmi_Click(object sender, EventArgs e)
        {
            new BMI().Show();
            this.Hide();
        }

        private void btBmr_Click(object sender, EventArgs e)
        {
            new BMR().Show();
            this.Hide();
        }
    }
}

