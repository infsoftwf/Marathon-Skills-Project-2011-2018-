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
    public partial class ASetInventory : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        Dictionary<Char, List<String>> _dataTypes = new Dictionary<Char, List<String>>();

        public ASetInventory()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void ASetInventory_Load(object sender, EventArgs e)
        {
            _dataTypes.Add('A', new List<string> { "Номер", "RFID бр-т" });
            _dataTypes.Add('B', new List<string> { "Бейсболка", "Бут.Воды" });
            _dataTypes.Add('C', new List<string> { "Футболка", "Сув.букл" });

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

            var m_DataTable = new DataTable();

            DataInventory.Rows.Add(_dataTypes['A'][0]);//0
            DataInventory.Rows.Add(_dataTypes['A'][1]);//1
            DataInventory.Rows.Add(_dataTypes['B'][0]);//2
            DataInventory.Rows.Add(_dataTypes['B'][1]);//3
            DataInventory.Rows.Add(_dataTypes['C'][0]);//4
            DataInventory.Rows.Add(_dataTypes['C'][1]);//5

            DataInventory.ClearSelection();
            DataInventory.CurrentCell = null;

            DataInventory[0, 1].ReadOnly = 
             DataInventory[0, 2].ReadOnly = 
                 DataInventory[0, 3].ReadOnly =
                  DataInventory[0, 4].ReadOnly =
                   DataInventory[0, 5].ReadOnly = true;


            DataInventory.ClearSelection();
            DataInventory.CurrentCell = null;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            bool IsEndPoint = false;

            using (var isqldat = new SqlDataAdapter("SELECT KitName, iCount FROM [KitStock]", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                {
                    if (DataInventory[1, i].Value != null)
                    {
                        if (!string.IsNullOrEmpty(DataInventory[1, i].Value.ToString()))
                        {
                            if (!Regex.IsMatch(DataInventory[1, i].Value.ToString(), @"^(-[0-9]|[0-9])+$"))
                            {
                                MessageBox.Show(this, $"Поле '{DataInventory[0, i].Value.ToString()}' имеет неверный формат!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var val = Convert.ToInt32(m_DataTable.Rows[i][1]) + Convert.ToInt32(DataInventory[1, i].Value);
                            if (val < 0)
                            {
                                MessageBox.Show(this, "Index out of range!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            using (var sql_update = new SqlCommand($"UPDATE [KitStock] SET iCount = '{val}' WHERE KitName = '{m_DataTable.Rows[i][0]}'", sqlConnection))
                            {
                                if (sql_update.ExecuteNonQuery() > 0)
                                    IsEndPoint = true;
                            }
                        }
                    }
                }
                if (IsEndPoint)
                    MessageBox.Show(this, "Информация обновлена!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            Application.OpenForms.OfType<AInventory>().Single().Show();

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

        private void cancelbut_Click(object sender, EventArgs e) => methodExit();
    }
}

