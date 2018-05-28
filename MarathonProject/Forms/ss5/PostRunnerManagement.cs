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
using System.IO;
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
    public partial class PostRunnerManagement : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        String g_Email = null;
        private bool bStatusReg = false;

        public PostRunnerManagement(String m_Email)
        {
            InitializeComponent();

            g_Email = m_Email;

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void UsersManagement_Load(object sender, EventArgs e)
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

            lbEmail.Text = g_Email;

            new Thread(() =>
            {
                if (MyAttributeExists<int>($"SELECT COUNT(dbo.Registration.RegistrationId) AS Expr1 FROM dbo.Registration INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId WHERE(dbo.Runner.Email = '{g_Email}')", sqlConnection) > 0)
                {
                    bStatusReg = true;

                    imgReg.BackgroundImage = Image.FromFile(string.Concat(g_PathStatus, @"\\", "tick-icon.png"));

                    imgConf.BackgroundImage = Image.FromFile(string.Concat(g_PathStatus, @"\\", "cross-icon.png"));
                    imgSetKit.BackgroundImage = Image.FromFile(string.Concat(g_PathStatus, @"\\", "cross-icon.png"));
                    imgSetStart.BackgroundImage = Image.FromFile(string.Concat(g_PathStatus, @"\\", "cross-icon.png"));

                    var statusID = MyAttributeExists<Byte>($@"SELECT dbo.RegistrationStatus.RegistrationStatusId
                         FROM dbo.Runner INNER JOIN
                         dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN
                         dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId = dbo.RegistrationStatus.RegistrationStatusId
                         WHERE (dbo.Runner.Email = '{g_Email}')", sqlConnection);

                    switch (statusID)
                    {
                        case 2:
                            imgConf.BackgroundImage = Image.FromFile(string.Concat(g_PathStatus, @"\\", "tick-icon.png"));
                            break;

                        case 3:
                            imgSetKit.BackgroundImage = Image.FromFile(string.Concat(g_PathStatus, @"\\", "tick-icon.png"));
                            break;

                        case 4:
                            imgSetStart.BackgroundImage = Image.FromFile(string.Concat(g_PathStatus, @"\\", "tick-icon.png"));
                            break;
                    }

                    using (var isqldat = new SqlDataAdapter($@"SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Gender, dbo.Runner.DateOfBirth, dbo.Country.CountryName, dbo.Charity.CharityName, dbo.Registration.RaceKitOptionId, dbo.EventType.EventTypeName, SUM(Sponsorship.Amount) AS exp
                         FROM dbo.Runner INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN
                         dbo.Charity ON dbo.Registration.CharityId = dbo.Charity.CharityId INNER JOIN
                         dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Sponsorship ON dbo.Registration.RegistrationId = Sponsorship.RegistrationId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId
                         WHERE(dbo.Runner.Email = '{g_Email}') AND (dbo.Marathon.MarathonName = '{s_GlobalMarathonName}')
                         GROUP BY dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Gender, dbo.Runner.DateOfBirth, dbo.Country.CountryName, dbo.Charity.CharityName, dbo.Registration.RaceKitOptionId, dbo.EventType.EventTypeName", sqlConnection))
                    {
                        var m_DataTable = new DataTable();
                        isqldat.Fill(m_DataTable);

                        if (m_DataTable.Rows.Count == 0)
                        {
                            this.Invoke(new MethodInvoker(() =>
                            {
                                this.Hide();
                                Application.OpenForms.OfType<RunnerManagement>().Single().Show();

                                MessageBox.Show(this, "Internal error!", "SQL [Email]", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                this.Dispose();
                                this.Close();
                            }));

                            return;
                        }
                        this.Invoke(new MethodInvoker(() =>
                        {
                            lbName.Text = m_DataTable.Rows[0][0].ToString();
                            lbFam.Text = m_DataTable.Rows[0][1].ToString();
                            lbGender.Text = m_DataTable.Rows[0][2].ToString();
                            lbDate.Text = m_DataTable.Rows[0][3].ToString().Remove(m_DataTable.Rows[0][3].ToString().IndexOf(' '));
                            lbCountry.Text = m_DataTable.Rows[0][4].ToString();
                            lbChar.Text = m_DataTable.Rows[0][5].ToString().Length > 14 ? m_DataTable.Rows[0][5].ToString().Remove(14) + "..." : m_DataTable.Rows[0][5].ToString();
                            lbKit.Text = m_DataTable.Rows[0][6].ToString();
                            lbVictim.Text = m_DataTable.Rows[0][8].ToString();
                            lbDistance.Text = m_DataTable.Rows[0][7].ToString();
                        }));
                    }
                }
                else
                {
                    imgReg.Invoke(new MethodInvoker(() => imgReg.BackgroundImage = Image.FromFile(string.Concat(g_PathStatus, @"\\", "cross-icon.png"))));

                    using (var isqldat = new SqlDataAdapter($@"SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Gender, dbo.Runner.DateOfBirth, dbo.Country.CountryName FROM 
                         dbo.Runner INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode
                         WHERE  (dbo.Runner.Email = '{g_Email}')", sqlConnection))
                    {
                        var m_DataTable = new DataTable();
                        isqldat.Fill(m_DataTable);

                        if (m_DataTable.Rows.Count == 0)
                        {
                            this.Invoke(new MethodInvoker(() =>
                            {
                                this.Hide();
                                Application.OpenForms.OfType<RunnerManagement>().Single().Show();

                                MessageBox.Show(this, "Internal error!", "SQL [Email]", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                this.Dispose();
                                this.Close();
                            }));

                            return;
                        }
                        this.Invoke(new MethodInvoker(() =>
                        {
                            lbName.Text = m_DataTable.Rows[0][0].ToString();
                            lbFam.Text = m_DataTable.Rows[0][1].ToString();
                            lbGender.Text = m_DataTable.Rows[0][2].ToString();
                            lbDate.Text = m_DataTable.Rows[0][3].ToString().Remove(m_DataTable.Rows[0][3].ToString().IndexOf(' '));
                            lbCountry.Text = m_DataTable.Rows[0][4].ToString();
                            lbChar.Text = lbKit.Text = lbVictim.Text = lbDistance.Text = "...";
                        }));
                    }
                }
                this.Invoke(new MethodInvoker(() =>
                {
                    var buffimg = MyAttributeExists<byte[]>($@"SELECT Image FROM dbo.Runner WHERE (Email = '{g_Email}') AND Image IS NOT NULL", sqlConnection);
                    imgMain.BackgroundImage = (buffimg != null && buffimg.Length > 10) ? Image.FromStream(new MemoryStream(buffimg)) : Properties.Resources.defaultAvatar;
                }));
            }).Start();
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

            Application.OpenForms.OfType<RunnerManagement>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void MarathonRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();

        private void btGetCert_Click(object sender, EventArgs e)
        {
            if (bStatusReg)
            {
                new Certificate(g_Email).Show();
                this.Hide();
            }
            else
                MessageBox.Show(this, "Вы не зарегистрированы!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btPrintBad_Click(object sender, EventArgs e)
        {
            new Token(g_Email).ShowDialog();
        }

        private void btEditProfile_Click(object sender, EventArgs e)
        {
            new RunnerEdit(g_Email, true).Show();
            this.Hide();
        }
    }
}

