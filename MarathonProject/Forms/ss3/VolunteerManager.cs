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
    public partial class VolunteerManager : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        DataTable m_DataTable = new DataTable();
        Dictionary<int, string> mapVol = new Dictionary<int, string>();

        public VolunteerManager()
        {
            InitializeComponent();
            mapVol.Add(0, "Имя");
            mapVol.Add(1, "Фамилия");
            mapVol.Add(2, "Страна");
            mapVol.Add(3, "Пол");
            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void VolunteerManager_Load(object sender, EventArgs e)
        {
            CSort.KeyPress += (o, args) => args.Handled = true;
            this.Activated += (o, args) => Reload();
            //var enumerator = mapVol.GetEnumerator();
            //while (enumerator.MoveNext())
            //    CSort.Items.Add(enumerator.Current.Key);

            CSort.SelectedIndex = 0;

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

            m_DataTable.Clear();

            Reload();
        }

        private void Reload()
        {
            using (var isqldat = new SqlDataAdapter($"SELECT dbo.Volunteer.FirstName AS 'Имя', dbo.Volunteer.LastName AS 'Фамилия', dbo.Country.CountryName AS 'Страна', dbo.Volunteer.Gender AS 'Пол' FROM dbo.Volunteer INNER JOIN dbo.Country ON dbo.Volunteer.CountryCode = dbo.Country.CountryCode", sqlConnection))
            {
                isqldat.Fill(m_DataTable);

                lbCountVol.Text = m_DataTable.Rows.Count.ToString();

                DataTable dv = m_DataTable;

                DataCharity.DataSource = dv;
            }

            DataCharity.CurrentCell = null;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            DataCharity.DataSource = null;
            m_DataTable.Columns[mapVol[CSort.SelectedIndex]].SetOrdinal(0);
            DataCharity.DataSource = m_DataTable;
            DataCharity.Sort(DataCharity.Columns[mapVol[CSort.SelectedIndex]], ListSortDirection.Ascending);
            DataCharity.CurrentCell = null;
        }

        private void btLoadVol_Click(object sender, EventArgs e)
        {
            new ImportVolunteers().Show();
            this.Hide();
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

            Application.OpenForms.OfType<AdminMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();

        private void VolunteerManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }
    }
}

