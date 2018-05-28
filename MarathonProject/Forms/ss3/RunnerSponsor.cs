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
    public partial class RunnerSponsor : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        String m_pRunnerId = String.Empty;

        public RunnerSponsor(String RunnerId)
        {
            InitializeComponent();
            m_pRunnerId = RunnerId;
            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        public class CustomPanel : Panel
        {
            public CustomPanel()
                : base()
            {
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            }

            protected override void OnScroll(ScrollEventArgs se)
            {
                this.Invalidate();

                base.OnScroll(se);
            }
            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle &= ~0x02000000; // WS_CLIPCHILDREN
                    return cp;
                }
            }
        }

        private void RunnerSponsor_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

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

            if (string.IsNullOrEmpty(m_pRunnerId))
            {
                MessageBox.Show(this, "Fatal Error", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new Thread(() =>
            {
                using (var m_mainISqlDat = new SqlDataAdapter($@"SELECT dbo.Charity.CharityName, dbo.Charity.CharityLogo, dbo.Charity.CharityDescription, dbo.Sponsorship.SponsorName, dbo.Sponsorship.Amount, dbo.Runner.Email
                         FROM dbo.Event INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Event.EventId = dbo.RegistrationEvent.EventId INNER JOIN
                         dbo.Sponsorship INNER JOIN
                         dbo.Registration ON dbo.Sponsorship.RegistrationId = dbo.Registration.RegistrationId INNER JOIN
                         dbo.Charity ON dbo.Registration.CharityId = dbo.Charity.CharityId INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email ON dbo.RegistrationEvent.RegistrationId = dbo.Registration.RegistrationId
                         WHERE (dbo.Marathon.MarathonName = '{s_GlobalMarathonName}') AND (dbo.Runner.Email = '{m_pRunnerId}')", sqlConnection))
                {
                    var dt = new DataTable();
                    m_mainISqlDat.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            lbCharityName.Visible = imgCharity.Visible = lbdesc.Visible = label1.Visible = label4.Visible = splitter.Visible = lbAmount.Visible = false;
                            MessageBox.Show(this, "Спонсоры отсутствуют!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }));
                        return;
                    }

                    CustomPanel cPanel = new CustomPanel();
                    cPanel.Location = new Point(564, 275);
                    cPanel.AutoScroll = true;
                    cPanel.Size = new Size(359, 235);
                    this.Invoke(new MethodInvoker(() => this.Controls.Add(cPanel)));

                    lbCharityName.Invoke(new MethodInvoker(() =>
                    {
                        lbCharityName.Text = dt.Rows[0][0].ToString();
                        lbCharityName.Location = new Point((imgCharity.Size.Width / 2) - (lbCharityName.Size.Width / 2) + 65, 230);
                    }));

                    imgCharity.Invoke(new MethodInvoker(() =>
                    {
                        imgCharity.BackgroundImage = Image.FromFile(string.Concat(g_PathCharityFolder, @"\\", dt.Rows[0][1].ToString()));
                        WinAPI.SetWindowRgn(imgCharity.Handle, WinAPI.CreateEllipticRgn(0, 0, imgCharity.Width, imgCharity.Height), true);
                    }));

                    lbdesc.Invoke(new MethodInvoker(() =>
                    {
                        lbdesc.Location = new Point(36, 520);
                        lbdesc.Size = new Size(323, 145);
                        lbdesc.Text = dt.Rows[0][2].ToString().Length > 170 ? dt.Rows[0][2].ToString().Remove(170) + "..." : dt.Rows[0][2].ToString();
                    }));

                    int AutoYReserveLabel = 16;
                    cPanel.Invoke(new MethodInvoker(() =>
                    {
                        cPanel.AutoScrollMinSize = new Size(0, dt.Rows.Count * 20);

                        cPanel.Scroll += (__o, __p) => cPanel.Invalidate();
                        cPanel.Paint += (__o, __p) =>
                        {
                            AutoYReserveLabel = 16;

                            decimal i_amountref = 0;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                __p.Graphics.DrawString(dt.Rows[i][3].ToString().Length > 25 ? dt.Rows[i][3].ToString().Remove(22) + "..." : dt.Rows[i][3].ToString(), new Font("Arial", 12), Brushes.Black, 9, AutoYReserveLabel);
                                __p.Graphics.DrawString(string.Concat("$", dt.Rows[i][4].ToString()), new Font("Arial", 12), Brushes.Black, 260, AutoYReserveLabel);

                                AutoYReserveLabel += 38;
                                i_amountref += Convert.ToDecimal(dt.Rows[i][4].ToString());
                            }

                            lbAmount.Invoke(new MethodInvoker(() =>
                            {
                                lbAmount.Visible = true;
                                lbAmount.Text = string.Concat("Всего $", i_amountref.ToString());
                                lbAmount.Location = new Point(splitter.Location.X + (splitter.Size.Width - lbAmount.Size.Width), 537);
                            }));
                        };
                        cPanel.Invalidate();
                    }));
                }
                Thread.CurrentThread.Abort();
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Highest
            }.Start();
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

            Application.OpenForms.OfType<RunnerMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();

        private void RunnerSponsor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }
    }
}

