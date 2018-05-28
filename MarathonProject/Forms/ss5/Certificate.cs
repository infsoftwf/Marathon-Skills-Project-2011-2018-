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
    public partial class Certificate : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;
        private String m_pRunnerId = String.Empty;
        Dictionary<String, String> map_Type = new Dictionary<String, String>();

        public Certificate(String RunnerId)
        {
            InitializeComponent();

            m_pRunnerId = RunnerId;

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void Certificate_Load(object sender, EventArgs e)
        {
            map_Type.Add("Full Marathon", "42km полном марафоне");
            map_Type.Add("Half Marathon", "21km полумарафоне");
            map_Type.Add("5km Fun Run", "5km малом марафоне");

            CEvent.KeyPress += (o, args) => args.Handled = true;

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

            new Thread(() =>
            {
                using (var isqldat = new SqlDataAdapter($@"SELECT dbo.EventType.EventTypeName
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId
                         WHERE(dbo.Runner.Email = '{m_pRunnerId}') AND (dbo.RegistrationEvent.RaceTime <> '') AND (dbo.Marathon.MarathonName = '{s_GlobalMarathonName}')", sqlConnection))//{m_pRunnerId}
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    if (m_DataTable.Rows.Count == 0)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            this.Hide();
                            Application.OpenForms.OfType<PostRunnerManagement>().Single().Show();

                            MessageBox.Show(this, "Бегун ни разу не финишировал!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (mainThread != null)
                                mainThread.Abort();

                            this.Dispose();
                            this.Close();
                        }));
                        return;
                    }

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        CEvent.Invoke(new MethodInvoker(() => CEvent.Items.Add(m_DataTable.Rows[i][0])));
                }

                CEvent.Invoke(new MethodInvoker(() => CEvent.SelectedIndex = 0));
                this.Invoke(new MethodInvoker(() =>
                {
                    var buffimg = MyAttributeExists<byte[]>($@"SELECT Image FROM dbo.Runner WHERE (Email = '{m_pRunnerId}') AND Image IS NOT NULL", sqlConnection);
                    imgAvatar.BackgroundImage = (buffimg != null && buffimg.Length > 10) ? Image.FromStream(new MemoryStream(buffimg)) : Properties.Resources.defaultAvatar;
                }));
                var SumOnChar = MyAttributeExists<Decimal>($@"SELECT SUM(dbo.Sponsorship.Amount) AS exp
                         FROM dbo.Runner INNER JOIN
                         dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN
                         dbo.Charity ON dbo.Registration.CharityId = dbo.Charity.CharityId INNER JOIN
                         dbo.Sponsorship ON dbo.Registration.RegistrationId = dbo.Sponsorship.RegistrationId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId
                         WHERE(dbo.Runner.Email = '{m_pRunnerId}') AND (dbo.Marathon.MarathonName = '{s_GlobalMarathonName}')", sqlConnection);

                lbChar.Invoke(new MethodInvoker(() => lbChar.Text = string.Concat("Вы также заработали $", SumOnChar, "\n", "для вашей благотворительной организации!")));
                lbChar.Invoke(new MethodInvoker(() => lbChar.Location = new Point((this.Width - lbChar.Size.Width) / 2, 617)));

                EventHandler InlineCEvent = null;

                CEvent.SelectedIndexChanged += InlineCEvent = (_o, _e) =>
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        using (var isqldat = new SqlDataAdapter($@"SELECT * FROM (SELECT dbo.Runner.Email AS em,  dbo.[User].FirstName, dbo.[User].LastName, dbo.EventType.EventTypeName, dbo.RegistrationEvent.RaceTime, ROW_NUMBER() OVER(ORDER BY RaceTime ASC) AS _Rank, dbo.Marathon.CityName, dbo.Country.CountryName
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.Country ON dbo.Marathon.CountryCode = dbo.Country.CountryCode
                         WHERE RaceTime <> '' AND dbo.EventType.EventTypeName = '{CEvent.Text}' AND (dbo.Marathon.MarathonName = '{s_GlobalMarathonName}')) AS tmp
                         WHERE em = '{m_pRunnerId}'", sqlConnection))
                        {
                            var m_DataTable = new DataTable();
                            isqldat.Fill(m_DataTable);

                            if (m_DataTable.Rows.Count == 0)
                            {
                                this.Hide();
                                Application.OpenForms.OfType<PostRunnerManagement>().Single().Show();

                                MessageBox.Show(this, "Fatal Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                if (mainThread != null)
                                    mainThread.Abort();

                                this.Dispose();
                                this.Close();

                                return;
                            }

                            var time = TimeSpan.FromSeconds(Convert.ToDouble(m_DataTable.Rows[0][4]));

                            lbDesc.Text = string.Concat("Поздравляем ", m_DataTable.Rows[0][1], " ", m_DataTable.Rows[0][2], " ", "с участием в ", map_Type[m_DataTable.Rows[0][3].ToString()], ".\n",
                                "Ваши результаты: время ", string.Format("{0}:{1}:{2}", time.Hours, time.Minutes, time.Seconds), " и занятое место ", m_DataTable.Rows[0][5], "!");
                            lbDesc.Location = new Point((this.Width - lbDesc.Size.Width) / 2, 335);

                            lbType.Text = string.Concat(m_DataTable.Rows[0][6], ", ", m_DataTable.Rows[0][7]);
                            lbType.Location = new Point((this.Width - lbType.Size.Width) / 2, 545);
                        }
                    }));
                };
                InlineCEvent(null, null);
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

            Application.OpenForms.OfType<PostRunnerManagement>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();

        private void Certificate_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }
    }
}

