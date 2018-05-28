using MarathonProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;

namespace MarathonProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                while (true)
                {
                    DateTime eTime;
                    DateTime.TryParse(s_GlobalMarathonDate, out eTime);
                    var resultTime = eTime.Subtract(DateTime.Now);

                    if (resultTime > TimeSpan.Zero)
                        lbEndTime.BeginInvoke((MethodInvoker)(() => lbEndTime.Text = getTime(resultTime)));

                    lbEndTime.BeginInvoke((MethodInvoker)(() => lbEndTime.Location = new Point((this.Size.Width - lbEndTime.Size.Width) / 2, 16)));

                    Thread.Sleep(1000);
                }
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Lowest
            }.Start();
        }

        private void bGetSponsorRunner_Click(object sender, EventArgs e)
        {
            new SponsorRunner().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MoreInfo().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Login(true).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginRunner().Show();
            this.Hide();
        }
    }
}
