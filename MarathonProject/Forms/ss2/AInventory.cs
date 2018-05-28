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
    public partial class AInventory : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        Dictionary<Char, List<String>> _dataTypes = new Dictionary<Char, List<String>>();
        Dictionary<String, List<int>> map_kitForward = new Dictionary<String, List<int>>();

        public AInventory()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void AInventory_Load(object sender, EventArgs e)
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

            using (var isqldat = new SqlDataAdapter("SELECT COUNT(*) FROM [marathon].[dbo].[RegistrationEvent]", sqlConnection))
            {
                isqldat.Fill(m_DataTable);

                lbruncount.Text = m_DataTable.Rows[0][0].ToString();
                m_DataTable.Clear();
            }

            DataInventory.Rows.Add("Выбрало данный комплект");//0
            DataInventory.Rows.Add("Состав комплекта");//1
            ((DataGridViewTextBoxCellEx)DataInventory[0, 1]).ColumnSpan = 6;
            DataInventory.Rows.Add(_dataTypes['A'][0]);//2
            DataInventory.Rows.Add(_dataTypes['A'][1]);//3
            DataInventory.Rows.Add(_dataTypes['B'][0]);//4
            DataInventory.Rows.Add(_dataTypes['B'][1]);//5
            DataInventory.Rows.Add(_dataTypes['C'][0]);//6
            DataInventory.Rows.Add(_dataTypes['C'][1]);//7

            using (var isqldat = new SqlDataAdapter("SELECT COUNT(*) FROM [Registration] WHERE RaceKitOptionId = 'A'", sqlConnection))
            {
                isqldat.Fill(m_DataTable);

                DataInventory[1, 2].Value = DataInventory[2, 2].Value = DataInventory[3, 2].Value/*...Номер*/ = 
                    DataInventory[1, 3].Value = DataInventory[2, 3].Value = DataInventory[3, 3].Value/*...RFID бр-т*/  =
                    DataInventory.Rows[0].Cells[1].Value = m_DataTable.Rows[0][0].ToString();

                var m_SumTypeA = Convert.ToInt32(m_DataTable.Rows[0][0].ToString()) * 3;
                DataInventory[4, 2].Value = DataInventory[4, 3].Value = m_SumTypeA;

                var m_rem_1 = MyAttributeExists<int>($"SELECT [iCount] FROM [KitStock] WHERE [KitName] = '{_dataTypes['A'][0]}'", sqlConnection);
                DataInventory[5, 2].Value = m_rem_1 - m_SumTypeA;

                /*'Необходимо'->Отчёт*/
                map_kitForward.Add(_dataTypes['A'][0], new List<int>
                {
                    (Int32)DataInventory[4, 2].Value,
                    (Int32)DataInventory[5, 2].Value,
                   ((Int32)DataInventory[5, 2].Value < 0) ?
                    Math.Abs((Int32)DataInventory[5, 2].Value) :
                    0
                });

                var m_rem_2 = MyAttributeExists<int>($"SELECT [iCount] FROM [KitStock] WHERE [KitName] = '{_dataTypes['A'][1]}'", sqlConnection);
                DataInventory[5, 3].Value = m_rem_2 - m_SumTypeA;

                /*'Остаток'->Отчёт*/
                map_kitForward.Add(_dataTypes['A'][1], new List<int>
                {
                    Convert.ToInt32(DataInventory[4, 3].Value),
                    Convert.ToInt32(DataInventory[5, 3].Value),
                     ((Int32)DataInventory[5, 3].Value < 0) ?
                     Math.Abs((Int32)DataInventory[5, 3].Value) :
                    0
                });

                for (int i = 4; i <= 7; i++)
                {
                    DataInventory[1, i] = new DataGridViewImageCell()
                    {
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Value = Resources.cross_icon
                    };
                }
                m_DataTable.Clear();
            }

            using (var isqldat = new SqlDataAdapter("SELECT COUNT(*) FROM [Registration] WHERE RaceKitOptionId = 'B'", sqlConnection))
            {
                isqldat.Fill(m_DataTable);

                DataInventory[2, 4].Value = DataInventory[3, 4].Value = /*...Бейсболка*/
                 DataInventory[2, 5].Value = DataInventory[3, 5].Value =   /*...Бут.Воды*/
                   DataInventory.Rows[0].Cells[2].Value = m_DataTable.Rows[0][0].ToString();

                var m_SumTypeB = Convert.ToInt32(m_DataTable.Rows[0][0].ToString()) * 2;
                DataInventory[4, 4].Value = DataInventory[4, 5].Value = m_SumTypeB;

                var m_rem_1 = MyAttributeExists<int>($"SELECT [iCount] FROM [KitStock] WHERE [KitName] = '{_dataTypes['B'][0]}'", sqlConnection);
                DataInventory[5, 4].Value = m_rem_1 - m_SumTypeB;

                /*'Необходимо'->Отчёт*/
                map_kitForward.Add(_dataTypes['B'][0], new List<int>
                {
                    (Int32)DataInventory[4, 4].Value,
                    (Int32)DataInventory[5, 4].Value,
                   ((Int32)DataInventory[5, 4].Value < 0) ?
                    Math.Abs((Int32)DataInventory[5, 4].Value) :
                    0
                });

                var m_rem_2 = MyAttributeExists<int>($"SELECT [iCount] FROM [KitStock] WHERE [KitName] = '{_dataTypes['B'][1]}'", sqlConnection);
                DataInventory[5, 5].Value = m_rem_2 - m_SumTypeB;

                /*'Остаток'->Отчёт*/
                map_kitForward.Add(_dataTypes['B'][1], new List<int>
                {
                    Convert.ToInt32(DataInventory[4, 5].Value),
                    Convert.ToInt32(DataInventory[5, 5].Value),
                     ((Int32)DataInventory[5, 5].Value < 0) ?
                     Math.Abs((Int32)DataInventory[5, 5].Value) :
                    0
                });

                for (int i = 6; i <= 7; i++)
                {
                    DataInventory[2, i] = new DataGridViewImageCell()
                    {
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Value = Resources.cross_icon
                    };
                }
                m_DataTable.Clear();
            }

            using (var isqldat = new SqlDataAdapter("SELECT COUNT(*) FROM [Registration] WHERE RaceKitOptionId = 'C'", sqlConnection))
            {
                isqldat.Fill(m_DataTable);

                DataInventory[3, 6].Value = /*...Футболка*/
                DataInventory[3, 7].Value =  /*...Сув.букл*/
                DataInventory.Rows[0].Cells[3].Value = m_DataTable.Rows[0][0].ToString();

                var m_SumTypeC = Convert.ToInt32(m_DataTable.Rows[0][0].ToString());
                DataInventory[4, 6].Value = DataInventory[4, 7].Value = m_SumTypeC;

                var m_rem_1 = MyAttributeExists<int>($"SELECT [iCount] FROM [KitStock] WHERE [KitName] = '{_dataTypes['C'][0]}'", sqlConnection);
                DataInventory[5, 6].Value = m_rem_1 - m_SumTypeC;

                /*'Необходимо'->Отчёт*/
                map_kitForward.Add(_dataTypes['C'][0], new List<int>
                {
                    (Int32)DataInventory[4, 6].Value,
                    (Int32)DataInventory[5, 6].Value,
                   ((Int32)DataInventory[5, 6].Value < 0) ?
                    Math.Abs((Int32)DataInventory[5, 6].Value) :
                    0
                });

                var m_rem_2 = MyAttributeExists<int>($"SELECT [iCount] FROM [KitStock] WHERE [KitName] = '{_dataTypes['C'][1]}'", sqlConnection);
                DataInventory[5, 7].Value = m_rem_2 - m_SumTypeC;

                /*'Остаток'->Отчёт*/
                map_kitForward.Add(_dataTypes['C'][1], new List<int>
                {
                    Convert.ToInt32(DataInventory[4, 7].Value),
                    Convert.ToInt32(DataInventory[5, 7].Value),
                     ((Int32)DataInventory[5, 7].Value < 0) ?
                     Math.Abs((Int32)DataInventory[5, 7].Value) :
                    0
                });

                m_DataTable.Clear();
            }

            DataInventory.Rows[0].Cells[4].Value = "Сумма";

            DataInventory.Rows[0].Cells[5].Value = "Остаток";

            DataInventory.CurrentCell = null;
            _dataTypes.Clear();
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

        private void cancelbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<AdminMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void btGetInventory_Click(object sender, EventArgs e)
        {
            new ASetInventory().Show();
            this.Hide();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            new PrintInventory(map_kitForward).ShowDialog();
        }
    }
}

