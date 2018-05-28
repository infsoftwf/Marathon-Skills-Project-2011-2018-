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
    public partial class ManageCharities : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        DataTable m_DataTable = new DataTable();

        public ManageCharities()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void Reload()
        {
            m_DataTable.Clear();

            using (var isqldat = new SqlDataAdapter("SELECT [CharityLogo], [CharityName], [CharityDescription] FROM [Charity]", sqlConnection))
            {
                isqldat.Fill(m_DataTable);

                DataCharity.RowCount = m_DataTable.Rows.Count;
                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(m_DataTable.Rows[i][0].ToString()))
                    {
                        DataCharity[0, i] = new DataGridViewImageCell()
                        {
                            ImageLayout = DataGridViewImageCellLayout.Zoom,
                            Value = Image.FromFile(string.Concat(g_PathCharityFolder, @"\\", m_DataTable.Rows[i][0].ToString()))
                        };
                    }
                    DataCharity[1, i].Value = m_DataTable.Rows[i][1].ToString();
                    DataCharity[2, i].Value = (m_DataTable.Rows[i][2].ToString().Length > 20) ? (m_DataTable.Rows[i][2].ToString().Remove(20) + "...") : m_DataTable.Rows[i][2].ToString();

                    DataCharity[3, i] = new DataGridViewButtonCell()
                    {
                        Value = "Edit",
                        FlatStyle = FlatStyle.Flat,
                        Style = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
                    };

                }
            }

            DataCharity.CurrentCell = null;
        }

        private void ManageCharities_Load(object sender, EventArgs e)
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

        private void btGetInventory_Click(object sender, EventArgs e)
        {
            new ASetInventory().Show();
            this.Hide();
        }

        private void DataCharity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 3)
            {
                new AddEditCharity(new Dictionary<string, List<string>> { {
                    m_DataTable.Rows[e.RowIndex][1].ToString(), new List<string> {
                        m_DataTable.Rows[e.RowIndex][0].ToString(),
                        m_DataTable.Rows[e.RowIndex][2].ToString()
                    }
                    }
                }).Show();

                this.Hide();
            }
        }

        private void btAddCharity_Click(object sender, EventArgs e)
        {
            new AddEditCharity().Show();
            this.Hide();
        }

        private void ManageCharities_Activated(object sender, EventArgs e) => Reload();
    }
}

