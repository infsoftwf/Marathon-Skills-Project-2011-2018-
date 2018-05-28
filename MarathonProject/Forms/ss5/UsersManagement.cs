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
    public partial class UsersManagement : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        public UsersManagement()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void Reload()
        {
            bool bIsCmp = !string.IsNullOrEmpty(txCmp.Text);
            bool bIsFilter = !CRole.Text.Equals("Any");

            var s_Filter = string.Concat(bIsFilter ? $"AND(dbo.Role.RoleName = '{CRole.Text}')" : "");

            using (var isqldat = new SqlDataAdapter($@"SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.[User].Email, dbo.Role.RoleName
                         FROM dbo.[User] INNER JOIN
                         dbo.Role ON dbo.[User].RoleId = dbo.Role.RoleId"
                         + string.Concat((bIsCmp || bIsFilter) ? " WHERE "
                         + string.Concat(bIsCmp ?
                         $@"(dbo.[User].FirstName LIKE '%{txCmp.Text}%') {s_Filter} 
                         OR (dbo.[User].LastName LIKE '%{txCmp.Text}%') {s_Filter} 
                         OR (dbo.[User].Email LIKE '%{txCmp.Text}%') {s_Filter}" : $"(dbo.Role.RoleName = '{CRole.Text}')")
                         : ""), sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                lbCountUsers.Text = m_DataTable.Rows.Count.ToString();
                DataGrid.RowCount = m_DataTable.Rows.Count;

                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                {
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Имя")).Single().Index, i].Value = m_DataTable.Rows[i][0];
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Фамилия")).Single().Index, i].Value = m_DataTable.Rows[i][1];
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Email")).Single().Index, i].Value = m_DataTable.Rows[i][2];
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Роль")).Single().Index, i].Value = m_DataTable.Rows[i][3];

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

            CRole.KeyPress += (o, args) => args.Handled = true;
            CSort.KeyPress += (o, args) => args.Handled = true;
 
            EventHandler dropRole = null;

            CRole.DropDown += dropRole = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter("SELECT [RoleName] FROM[marathon].[dbo].[Role]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    CRole.Items.Clear();

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        CRole.Items.Add(m_DataTable.Rows[i][0].ToString());

                    CRole.Items.Add("Any");
                }
                CRole.DropDown -= dropRole;
            };

            dropRole(null, null);

            CRole.SelectedIndex = CSort.SelectedIndex = 0;

            Reload();

            DataGrid.CurrentCell = null;
        }

        private void btRefresh_Click(object sender, EventArgs e) => Reload();

        private void btAdd_Click(object sender, EventArgs e)
        {
            new UserAdd(new Tuple<ComboBox.ObjectCollection>(CRole.Items)).Show();
            this.Hide();
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                new UserEdit(new Tuple<String, String, String, int, ComboBox.ObjectCollection>(
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Имя")).Single().Index, e.RowIndex].Value.ToString(),
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Фамилия")).Single().Index, e.RowIndex].Value.ToString(),
                    DataGrid[DataGrid.Columns.Cast<DataGridViewColumn>().Where(x => x.HeaderText.Equals("Email")).Single().Index, e.RowIndex].Value.ToString(),
                    CRole.SelectedIndex,
                    CRole.Items
                    )).Show();
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

            Application.OpenForms.OfType<AdminMenu>().Single().Show();

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

