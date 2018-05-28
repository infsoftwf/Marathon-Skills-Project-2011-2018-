using MarathonProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;
using static MarathonProject.INF_TOOLS.WinAPI;

namespace MarathonProject.Forms
{
    public partial class MarathonInfo : Form
    {
        Thread mainThread = null, hInitialize = null;

        SqlConnection sqlConnection = null;

        public MarathonInfo()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();

            this.DoubleBuffered = true;
        }

        private void MarathonInfo_Load(object sender, EventArgs e)
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

            MainImgBox.Paint += (_o, _e) =>
            {
                using (Font myFont = new Font("Arial", 14))
                    _e.Graphics.DrawString("      Карта марафона\n(Нажмите чтобы открыть\n   интерактивную карту)", myFont, new SolidBrush(Color.FromArgb(255, 64, 64, 64)), new Point(25, 55));
            };
            MainImgBox.BackgroundImage = Image.FromFile(string.Concat(g_PathMarathonInfo, @"\\", "marathon-skills-2016-marathon-map.jpg"));
            img1.BackgroundImage       = Image.FromFile(string.Concat(g_PathMarathonInfo, @"\\", "banco-banespa.jpg"));
            img2.BackgroundImage       = Image.FromFile(string.Concat(g_PathMarathonInfo, @"\\", "ibirapuera-park-lake.jpg"));
            img3.BackgroundImage       = Image.FromFile(string.Concat(g_PathMarathonInfo, @"\\", "marathon-image.jpg"));
            img4.BackgroundImage       = Image.FromFile(string.Concat(g_PathMarathonInfo, @"\\", "teatro-municipal.jpg"));
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MoreInfo>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void MainImgBox_Click(object sender, EventArgs e)
        {
            new MarathonMap().Show();
            this.Hide();
        }

        private void RunnerResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }
    }
}

