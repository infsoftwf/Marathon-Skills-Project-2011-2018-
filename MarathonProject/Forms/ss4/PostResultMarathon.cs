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
    public partial class PostResultMarathon : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        Dictionary<string, List<int>> _dataAge = new Dictionary<string, List<int>>();

        bool isRunner = false;
        public PostResultMarathon(bool m_isRunner = false)
        {
            isRunner = m_isRunner;
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void Reload()
        {
            bool IsMarathon = !CMarathon.Text.Equals("Any");
            bool IsDistance = !CDistance.Text.Equals("Any");
            bool IsGender = !CGender.Text.Equals("Any");
            bool IsCategories = !CCategories.Text.Equals("Any");

            lbCountRunners.Text = MyAttributeExists<int>($@"SELECT COUNT(*) AS Expr1
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender"
                         + string.Concat((IsMarathon || IsDistance || IsGender || IsCategories) ? " WHERE"
                         + string.Concat(IsMarathon ? $"(dbo.Marathon.MarathonName = '{CMarathon.Text}')" : "")
                         + string.Concat(IsDistance ? ((IsMarathon ? "AND" : "") + $"(dbo.EventType.EventTypeName = '{CDistance.Text}')") : "")
                         + string.Concat(IsGender ? (((IsMarathon || IsDistance) ? "AND" : "") + $"(dbo.Runner.Gender = '{CGender.Text}')") : "")
                         + string.Concat(IsCategories ? (((IsMarathon || IsDistance || IsGender) ? "AND" : "") + $@"(DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) >= '{_dataAge[CCategories.Text][/*start*/0]}') 
                         AND(DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) <= '{_dataAge[CCategories.Text][/*end*/1]}')") : "") : ""), sqlConnection).ToString();

            lbCountFinish.Text = MyAttributeExists<int>($@"SELECT COUNT(*) AS Expr1
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender
                         WHERE (dbo.RegistrationEvent.RaceTime <> '')"
                         + string.Concat(IsMarathon ? $"AND(dbo.Marathon.MarathonName = '{CMarathon.Text}')" : "")
                         + string.Concat(IsDistance ? $"AND(dbo.EventType.EventTypeName = '{CDistance.Text}')" : "")
                         + string.Concat(IsGender ? $"AND(dbo.Runner.Gender = '{CGender.Text}')" : "")
                         + string.Concat(IsCategories ? $@"AND(DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) >= '{_dataAge[CCategories.Text][/*start*/0]}') 
                         AND(DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) <= '{_dataAge[CCategories.Text][/*end*/1]}')" : ""), sqlConnection).ToString();

            using (var isqldat = new SqlDataAdapter($@"SELECT dbo.RegistrationEvent.RaceTime
                        FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender"
                         + string.Concat((IsMarathon || IsDistance || IsGender || IsCategories) ? " WHERE"
                         + string.Concat(IsMarathon ? $"(dbo.Marathon.MarathonName = '{CMarathon.Text}')" : "")
                         + string.Concat(IsDistance ? ((IsMarathon ? "AND" : "") + $"(dbo.EventType.EventTypeName = '{CDistance.Text}')") : "")
                         + string.Concat(IsGender ? (((IsMarathon || IsDistance) ? "AND" : "") + $"(dbo.Runner.Gender = '{CGender.Text}')") : "")
                         + string.Concat(IsCategories ? (((IsMarathon || IsDistance || IsGender) ? "AND" : "") + $@"(DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) >= '{_dataAge[CCategories.Text][/*start*/0]}') 
                         AND(DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) <= '{_dataAge[CCategories.Text][/*end*/1]}')") : "") : ""), sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                int iref = 0;
                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                    if (m_DataTable.Rows[i][0] != null && !string.IsNullOrEmpty(m_DataTable.Rows[i][0].ToString()))
                        iref += (int)(m_DataTable.Rows[i][0]);

                if (!lbCountFinish.Text.Equals("0"))
                {
                    var time = TimeSpan.FromSeconds(iref / Convert.ToInt32(lbCountFinish.Text));
                    lbCountAvTime.Text = string.Format("{0}h {1}m {2}s", time.Hours, time.Minutes, time.Seconds);
                }
                else
                    lbCountAvTime.Text = "00h 00m 00s";
            }

            using (var isqldat = new SqlDataAdapter($@"SELECT TOP (100) PERCENT dbo.RegistrationEvent.RaceTime, dbo.[User].FirstName, dbo.[User].LastName, dbo.Marathon.CountryCode
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender
                         WHERE(dbo.RegistrationEvent.RaceTime <> '')"
                         + string.Concat(IsMarathon ? $"AND(dbo.Marathon.MarathonName = '{CMarathon.Text}')" : "")
                         + string.Concat(IsDistance ? $"AND(dbo.EventType.EventTypeName = '{CDistance.Text}')" : "")
                         + string.Concat(IsGender ? $"AND(dbo.Runner.Gender = '{CGender.Text}')" : "")
                         + string.Concat(IsCategories ? $@"AND(DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) >= '{_dataAge[CCategories.Text][/*start*/0]}') 
                         AND(DATEDIFF(Day, dbo.Runner.DateOfBirth, GETDATE()) <= '{_dataAge[CCategories.Text][/*end*/1]}')" : "")
                         + "ORDER BY dbo.RegistrationEvent.RaceTime", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                DataGrid.RowCount = m_DataTable.Rows.Count;
                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                {
                    DataGrid[0, i].Value = i;

                    var time = TimeSpan.FromSeconds(Convert.ToInt32(m_DataTable.Rows[i][0]));
                    DataGrid[1, i].Value = string.Format("{0}h {1}m {2}s", time.Hours, time.Minutes, time.Seconds);

                    DataGrid[2, i].Value = string.Format("{0} {1}", m_DataTable.Rows[i][1], m_DataTable.Rows[i][2]);
                    DataGrid[3, i].Value = m_DataTable.Rows[i][3];
                }
            }
        }

        private void PostResultMarathon_Load(object sender, EventArgs e)
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
                                               /*Days*/
            _dataAge.Add("18", new List<int> { 3650, 6570 });
            _dataAge.Add("18-29", new List<int> { 6570, 10585 });
            _dataAge.Add("30-39", new List<int> { 10585, 14235 });
            _dataAge.Add("40-55", new List<int> { 14600, 20075 });
            _dataAge.Add("56-70", new List<int> { 20440, 25550 });
            _dataAge.Add("70", new List<int> { 25550, 29200 });

            CMarathon.KeyPress += (o, args) => args.Handled = true;
            CDistance.KeyPress += (o, args) => args.Handled = true;
            CGender.KeyPress += (o, args) => args.Handled = true;
            CCategories.KeyPress += (o, args) => args.Handled = true;

            EventHandler dropMarathon = null, dropRace = null, dropGender = null;

            CMarathon.DropDown += dropMarathon = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter("SELECT [MarathonName] FROM[marathon].[dbo].[Marathon]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    CMarathon.Items.Clear();

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        CMarathon.Items.Add(m_DataTable.Rows[i][0].ToString());

                    CMarathon.Items.Add("Any");
                }
            };

            dropMarathon(null, null);

            CDistance.DropDown += dropRace = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter("SELECT [EventTypeName] FROM[marathon].[dbo].[EventType]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    CDistance.Items.Clear();

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        CDistance.Items.Add(m_DataTable.Rows[i][0].ToString());

                    CDistance.Items.Add("Any");
                }
            };

            dropRace(null, null);

            CGender.DropDown += dropGender = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter("SELECT [Gender] FROM[marathon].[dbo].[Gender]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    CGender.Items.Clear();

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        CGender.Items.Add(m_DataTable.Rows[i][0].ToString());

                    CGender.Items.Add("Any");
                }
            };

            dropGender(null, null);

            CMarathon.SelectedIndex = CDistance.SelectedIndex = CGender.SelectedIndex = CCategories.SelectedIndex = 0;

            Reload();

            DataGrid.CurrentCell = null;
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                new RunnerDetermine(new Tuple<string, string>(DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString().Split(' ')[0], DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString().Split(' ')[1])).ShowDialog();
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

            if (isRunner)
                Application.OpenForms.OfType<RunnerResult>().Single().Show();
            else
                Application.OpenForms.OfType<MoreInfo>().Single().Show();

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

        private void btGetInventory_Click(object sender, EventArgs e)
        {
            new ASetInventory().Show();
            this.Hide();
        }

        private void btAddCharity_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void PostResultMarathon_Activated(object sender, EventArgs e) {}
    }
}

