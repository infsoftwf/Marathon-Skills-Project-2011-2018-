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
    public partial class RunnerManagement : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        public RunnerManagement()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void Reload()
        {
            using (var isqldat = new SqlDataAdapter($@"SELECT dbo.[User].FirstName AS 'Имя', dbo.[User].LastName AS 'Фамилия', dbo.Runner.Email AS 'Email', dbo.RegistrationStatus.RegistrationStatus AS 'Статус'
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId = dbo.RegistrationStatus.RegistrationStatusId 
                         WHERE MarathonName = '{s_GlobalMarathonName}' AND (dbo.RegistrationStatus.RegistrationStatus = '{CStatus.Text}') AND (dbo.EventType.EventTypeName = '{CDistance.Text}')", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                lbCountRunners.Text = m_DataTable.Rows.Count.ToString();
                DataGrid.RowCount = m_DataTable.Rows.Count;

                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                {
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Имя")).Single().Index, i].Value = m_DataTable.Rows[i][0];
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Фамилия")).Single().Index, i].Value = m_DataTable.Rows[i][1];
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Email")).Single().Index, i].Value = m_DataTable.Rows[i][2];
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Статус")).Single().Index, i].Value = m_DataTable.Rows[i][3];

                    DataGrid[4, i] = new DataGridViewButtonCell()
                    {
                        Value = "Edit",
                        FlatStyle = FlatStyle.Flat,
                        Style = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
                    };
                }
                DataGrid.Columns[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals(CSort.Text)).Single().Index].DisplayIndex = 0;
            }
        }

        private void RunnerManagement_Load(object sender, EventArgs e)
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

            CStatus.KeyPress += (o, args) => args.Handled = true;
            CDistance.KeyPress += (o, args) => args.Handled = true;
            CSort.KeyPress += (o, args) => args.Handled = true;

            EventHandler dropStatus = null, dropDistance = null;

            CStatus.DropDown += dropStatus = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter("SELECT [RegistrationStatus] FROM[marathon].[dbo].[RegistrationStatus]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    CStatus.Items.Clear();

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        CStatus.Items.Add(m_DataTable.Rows[i][0].ToString());
                }
            };

            dropStatus(null, null);

            CDistance.DropDown += dropDistance = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter("SELECT [EventTypeName] FROM[marathon].[dbo].[EventType]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    CDistance.Items.Clear();

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        CDistance.Items.Add(m_DataTable.Rows[i][0].ToString());
                }
            };

            dropDistance(null, null);

            CStatus.SelectedIndex = CDistance.SelectedIndex = CSort.SelectedIndex = 0;

            Reload();

            DataGrid.CurrentCell = null;
        }

        private void btFind_Click(object sender, EventArgs e) => Reload();

        private void btDetailtCSV_Click(object sender, EventArgs e)
        {
            if (DataGrid.Rows.Count < 1)
            {
                MessageBox.Show(this, "Список пуст!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            StringBuilder Build = new StringBuilder();

            Build.Append("FirstName,LastName,Email,Gender,CountryName,DateOfBirth,RegistrationStatus,RaceKitOptionId,EventTypeName");
            Build.AppendLine();

            for (int i = 0; i < DataGrid.Rows.Count; i++)
            {
                using (var sqlcm_select = new SqlCommand($@"SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Email, dbo.Gender.Gender, dbo.Country.CountryName, dbo.Runner.DateOfBirth, dbo.RegistrationStatus.RegistrationStatus, dbo.RaceKitOption.RaceKitOptionId, dbo.EventType.EventTypeName
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId = dbo.RegistrationStatus.RegistrationStatusId INNER JOIN
                         dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode INNER JOIN
                         dbo.RaceKitOption ON dbo.Registration.RaceKitOptionId = dbo.RaceKitOption.RaceKitOptionId
                         WHERE MarathonName = '{s_GlobalMarathonName}' AND (dbo.Runner.Email = '{DataGrid.Rows[i].Cells[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Email")).Single().Index].Value}') AND (dbo.RegistrationStatus.RegistrationStatus = '{CStatus.Text}') AND (dbo.EventType.EventTypeName = '{CDistance.Text}')", sqlConnection))
                {
                    using (SqlDataReader m_DataRead = sqlcm_select.ExecuteReader())
                    {
                        if (m_DataRead != null)
                        {
                            while (m_DataRead.HasRows && m_DataRead.Read())
                            {
                                Build.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                                    m_DataRead[0],
                                    m_DataRead[1],
                                    m_DataRead[2],
                                    m_DataRead[3],
                                    m_DataRead[4],
                                    m_DataRead[5],
                                    m_DataRead[6],
                                    m_DataRead[7],
                                    m_DataRead[8]);

                                Build.AppendLine();
                            }
                        }
                    }
                }
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV files (*.csv) | *.csv", DefaultExt = "csv", FileName = "details" })
            {
                sfd.FileOk += (_o, _a) =>
                {
                    File.WriteAllText(sfd.FileName, Build.ToString());

                    MessageBox.Show(this, "Данные выгружены!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                sfd.ShowDialog();
            }

            Build.Clear();
        }

        private void btEmailList_Click(object sender, EventArgs e)
        {
            if (DataGrid.Rows.Count < 1)
            {
                MessageBox.Show(this, "Список пуст!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (var isqldat = new SqlDataAdapter($@"SELECT CONCAT (dbo.[User].FirstName, ' ', dbo.[User].LastName, ' ', dbo.Runner.Email) AS 'LastName/FirstName/Email'
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId INNER JOIN
                         dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId = dbo.RegistrationStatus.RegistrationStatusId INNER JOIN
                         dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode INNER JOIN
                         dbo.RaceKitOption ON dbo.Registration.RaceKitOptionId = dbo.RaceKitOption.RaceKitOptionId
                         WHERE MarathonName = '{s_GlobalMarathonName}' AND (dbo.RegistrationStatus.RegistrationStatus = '{CStatus.Text}') AND (dbo.EventType.EventTypeName = '{CDistance.Text}')", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                new REmailDetermine(m_DataTable).ShowDialog();
            }
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                new PostRunnerManagement(DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Email")).Single().Index, e.RowIndex].Value.ToString()).Show();
                this.Hide();
            }
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

            Application.OpenForms.OfType<CoordinatorMenu>().Single().Show();

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
    }
}

