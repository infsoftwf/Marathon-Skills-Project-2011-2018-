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
    public partial class SponsorshipOverview : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        public SponsorshipOverview()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void SponsorshipOverview_Load(object sender, EventArgs e)
        {
            CSort.KeyPress += (o, args) => args.Handled = true;

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

            lbCountChar.Text = MyAttributeExists<Int32>("SELECT COUNT(*) FROM [marathon].[dbo].[Charity]", sqlConnection).ToString();
            lbCountDep.Text = "$" + MyAttributeExists<Decimal>("SELECT SUM([Amount]) FROM [marathon].[dbo].[Sponsorship]", sqlConnection).ToString();

            using (var isqldat = new SqlDataAdapter($@"SELECT dbo.Charity.CharityName, dbo.Charity.CharityLogo, SUM(dbo.Sponsorship.Amount) AS exp
                         FROM dbo.Charity INNER JOIN
                         dbo.Registration ON dbo.Charity.CharityId = dbo.Registration.CharityId INNER JOIN
                         dbo.Sponsorship ON dbo.Registration.RegistrationId = dbo.Sponsorship.RegistrationId
                         GROUP BY dbo.Charity.CharityName, dbo.Charity.CharityLogo", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                DataGrid.RowCount = m_DataTable.Rows.Count;

                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                {
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Наименование")).Single().Index, i].Value = m_DataTable.Rows[i][0];

                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Логотип")).Single().Index, i] = new DataGridViewImageCell()
                    {
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Value = Image.FromFile(string.Concat(g_PathCharityFolder, @"\\", m_DataTable.Rows[i][1]))
                    };

                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Сумма")).Single().Index, i].Value = "$" + m_DataTable.Rows[i][2].ToString();
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e) 
            => DataGrid.Columns[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals(CSort.Text)).Single().Index].DisplayIndex = 0;

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

            Application.OpenForms.OfType<CoordinatorMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();

        private void SponsorshipOverview_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }
    }
}

