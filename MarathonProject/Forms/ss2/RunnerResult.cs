using MarathonProject.INF_TOOLS;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;
using static MarathonProject.INF_TOOLS.WinAPI;

namespace MarathonProject.Forms
{
    public partial class RunnerResult : Form
    {
        Thread mainThread = null, hInitialize = null;

        SqlConnection sqlConnection = null;

        String[] AgeArray = {
            "18", "18-29", "30-39", "40-55", "56-70", "70"
        };

        String[] kmArray = {
            "42km Full Marathon", "5km Fun Run", "21km Half Marathon"
        };

        String m_pRunnerId = String.Empty;

        Dictionary<string, int> _dataAge = new Dictionary<string, int>();
        Dictionary<string, string> _dataTypeEvent = new Dictionary<string, string>();

        public RunnerResult(String RunnerId)
        {
            m_pRunnerId = RunnerId;

            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();

            this.DoubleBuffered = true;
        }

        private void ResultList_Load(object sender, EventArgs e)
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

            int iloc = 40;

            lbHeadMarathon.Location = new Point(iloc, 305);
            iloc += 180;
            lbHeadDistance.Location = new Point(iloc, 305);
            iloc += 180;
            lbHeadTime.Location = new Point(iloc, 305);
            iloc += 130;
            lbHeadSharedNum.Location = new Point(iloc, 305);
            iloc += 190;
            lbHeadCat.Location = new Point(iloc, 305);

            hInitialize = new Thread(() =>
            {
                int AutoYReserve = 13;
                var m_DataTable = new DataTable();
                pnl_MarathonList.VerticalScroll.Visible = true;

                using (var isqldat = new SqlDataAdapter($"SELECT [EventTypeName] FROM [EventType]", sqlConnection))
                {
                    isqldat.Fill(m_DataTable);

                    if (m_DataTable.Rows.Count == 0)
                        return;

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        _dataTypeEvent.Add(m_DataTable.Rows[i][0].ToString(), kmArray[i]);
                }

                using (var isqldat = new SqlDataAdapter($"SELECT Gender, DateOfBirth FROM [Runner] WHERE Email = '{m_pRunnerId}'", sqlConnection))
                {
                    m_DataTable.Dispose();
                    m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    if (m_DataTable.Rows.Count == 0)
                        return;

                    this.Invoke(new MethodInvoker(delegate
                    {
                        lbGender.Text = m_DataTable.Rows[0][0].ToString().Equals("Male") ? "Male" : "Female";

                        DateTime result;
                        if (!DateTime.TryParse(m_DataTable.Rows[0][1].ToString(), out result))
                            return;

                        var tmpAge = DateTime.Now.Subtract(result).Days;

                        if (tmpAge >= 3650 && tmpAge <= 6570)
                            _dataAge.Add("18", 3650);
                        else if (tmpAge >= 6570 && tmpAge <= 10585)
                            _dataAge.Add("18-29", 10585);
                        else if (tmpAge >= 10585 && tmpAge <= 14235)
                            _dataAge.Add("29-39", 14235);
                        else if (tmpAge >= 14600 && tmpAge <= 20075)
                            _dataAge.Add("40-55", 20075);
                        else if (tmpAge >= 20440 && tmpAge <= 25550)
                            _dataAge.Add("56-70", 25550);
                        else if (tmpAge > 25550)
                            _dataAge.Add("70", 25550);

                        if (_dataAge.Count == 0)
                        {
                            MessageBox.Show(this, "Error with Age!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        lbAge.Text = _dataAge.FirstOrDefault().Key;
                    }));
                }

                new Thread(() =>
                {
                    List<Dictionary<string, int>> _myList = new List<Dictionary<string, int>>();
                    List<Dictionary<string, List<String>>> myList = new List<Dictionary<string, List<String>>>();

                    this.Invoke(new MethodInvoker(delegate
                    {
                        using (var isqldat = new SqlDataAdapter($@"SELECT TOP (100) PERCENT dbo.Marathon.YearHeld, dbo.Country.CountryName, dbo.EventType.EventTypeName, dbo.RegistrationEvent.RaceTime, dbo.Runner.Email, dbo.Runner.Gender, dbo.Runner.DateOfBirth
                                           FROM dbo.Runner INNER JOIN
                                           dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN
                                           dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                                           dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                                           dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                                           dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode AND dbo.Marathon.CountryCode = dbo.Country.CountryCode INNER JOIN
                                           dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId
                                           ORDER BY dbo.RegistrationEvent.RaceTime", sqlConnection))
                        {
                            var m_SharedDataTable = new DataTable();
                            isqldat.Fill(m_SharedDataTable);

                            if (m_SharedDataTable.Rows.Count == 0)
                            {
                                MessageBox.Show(this, "Internal Error!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            using (var isqldatUnique = new SqlDataAdapter($@"SELECT TOP (100) PERCENT dbo.Runner.Email
                                          FROM dbo.Runner INNER JOIN
                                          dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN
                                          dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                                          dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                                          dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                                          dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode AND dbo.Marathon.CountryCode = dbo.Country.CountryCode INNER JOIN
                                          dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId
                                          WHERE (Gender = '{lbGender.Text}') AND (DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) >= '{_dataAge[lbAge.Text]}') ORDER BY dbo.RegistrationEvent.RaceTime", sqlConnection))
                            {
                                var m_uDataTable = new DataTable();
                                isqldatUnique.Fill(m_uDataTable);

                                if (m_uDataTable.Rows.Count == 0)
                                {
                                    MessageBox.Show(this, "Internal Error!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                for (int i = 0; i < m_uDataTable.Rows.Count; i++)
                                {
                                    if (m_uDataTable.Rows[i][0].ToString().Equals(m_pRunnerId))
                                        _myList.Add(new Dictionary<string, int> { { m_uDataTable.Rows[i][0].ToString(), i } });
                                }

                                for (int i = 0; i < m_SharedDataTable.Rows.Count; i++)
                                {                                  
                                    if (m_SharedDataTable.Rows[i][4].ToString().Equals(m_pRunnerId))
                                        myList.Add(new Dictionary<string, List<String>> { { m_SharedDataTable.Rows[i][4].ToString(), new List<String>
                                        {
                                            string.Concat(m_SharedDataTable.Rows[i][0].ToString(), " ", m_SharedDataTable.Rows[i][1].ToString()),
                                            m_SharedDataTable.Rows[i][2].ToString(),
                                            m_SharedDataTable.Rows[i][3].ToString(),
                                            i.ToString() } }
                                        });
                                }
                            }
                        }
                        if (myList.Count != _myList.Count)
                        {
                            MessageBox.Show(this, "Error with Age!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        for (int i = 0; i < myList.Count; i++)
                        {
                            Label tmpLb = new Label();
                            tmpLb.AutoSize = true;
                            tmpLb.Font = new Font("Tahoma", 12f);
                            tmpLb.Location = new Point(5, AutoYReserve);
                            tmpLb.Text = myList[i][m_pRunnerId][0];
                            pnl_MarathonList.Controls.Add(tmpLb);

                            Label tmpLbEvType = new Label();
                            tmpLbEvType.AutoSize = true;
                            tmpLbEvType.Font = new Font("Tahoma", 12f);
                            tmpLbEvType.Location = new Point(lbHeadDistance.Location.X - 10, AutoYReserve);
                            tmpLbEvType.Text = myList[i][m_pRunnerId][1];
                            pnl_MarathonList.Controls.Add(tmpLbEvType);

                            Label tmpLbRaceTime = new Label();
                            tmpLbRaceTime.AutoSize = true;
                            tmpLbRaceTime.Font = new Font("Tahoma", 12f);
                            tmpLbRaceTime.Location = new Point(lbHeadTime.Location.X - 15, AutoYReserve);
                            var time = TimeSpan.FromSeconds(Convert.ToDouble(myList[i][m_pRunnerId][2]));
                            tmpLbRaceTime.Text = string.Format("{0}h {1}m {2}s", time.Hours, time.Minutes, time.Seconds);
                            pnl_MarathonList.Controls.Add(tmpLbRaceTime);

                            Label tmpLbShared = new Label();
                            tmpLbShared.AutoSize = true;
                            tmpLbShared.Font = new Font("Tahoma", 12f);
                            tmpLbShared.Location = new Point(lbHeadSharedNum.Location.X + (lbHeadSharedNum.Size.Width / 2) - 30, AutoYReserve);
                            tmpLbShared.Text = string.Concat("#", myList[i][m_pRunnerId][3]);
                            pnl_MarathonList.Controls.Add(tmpLbShared);

                            Label tmpLbUnique= new Label();
                            tmpLbUnique.AutoSize = true;
                            tmpLbUnique.Font = new Font("Tahoma", 12f);
                            tmpLbUnique.Location = new Point(lbHeadCat.Location.X + (lbHeadCat.Size.Width / 2) - 30, AutoYReserve);
                            tmpLbUnique.Text = string.Concat("#", _myList[i][m_pRunnerId].ToString());
                            pnl_MarathonList.Controls.Add(tmpLbUnique);

                            pnl_MarathonList.Invalidate();
                            pnl_MarathonList.Refresh();

                            AutoYReserve += 40;
                            //MessageBox.Show(this, string.Concat(myList[i][m_pRunnerId][0], " ", myList[i][m_pRunnerId][1], " ", myList[i][m_pRunnerId][2], " ", myList[i][m_pRunnerId][3], " ", _myList[i][m_pRunnerId]), m_pRunnerId);
                        }
                    }));
                    Thread.CurrentThread.Abort();//r.dilello@gmail.com

                }).Start();
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Highest
            };
            hInitialize.Start();
        }

        private void methodExit()
        {
            if (hInitialize != null)
                hInitialize.Abort();

            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MainMenu>().Single().Show();

            INFAPI.__forceExit(typeof(MainMenu));
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (hInitialize != null)
                hInitialize.Abort();

            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<RunnerMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void RunnerResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void btGetAllResults_Click(object sender, EventArgs e)
        {
            new PostResultMarathon(true).Show();
            this.Hide();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();
    }
}

