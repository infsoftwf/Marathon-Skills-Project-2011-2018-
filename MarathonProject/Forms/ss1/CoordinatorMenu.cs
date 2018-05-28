using MarathonProject.INF_TOOLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;

namespace MarathonProject.Forms
{
    public partial class CoordinatorMenu : Form
    {
        Thread mainThread = null;

        public CoordinatorMenu()
        {
            InitializeComponent();
        }

        private void CoordinatorMenu_Load(object sender, EventArgs e)
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

            INFAPI.__forceExit(typeof(MainMenu));           
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<Login>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void CoordinatorMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new CharityList().Show();
            this.Hide();
        }

        private void butlogout_Click(object sender, EventArgs e)
        {
            methodExit();
        }

        private void butRunner_Click(object sender, EventArgs e)
        {
            new RunnerManagement().Show();
            this.Hide();
        }

        private void butSponsor_Click(object sender, EventArgs e)
        {
            new SponsorshipOverview().Show();
            this.Hide();
        }
    }
}

