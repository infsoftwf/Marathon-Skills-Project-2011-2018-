using MarathonProject.INF_TOOLS;
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
    public partial class MarathonRegister : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        String m_pRunnerId = String.Empty;
        Dictionary<String, List<String>> _data = new Dictionary<String, List<String>>();
        Char RaceKitOption = default(Char);

        public MarathonRegister(String RunnerId)
        {
            m_pRunnerId = RunnerId;

            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void MarathonRegister_Load(object sender, EventArgs e)
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

            CCharity.KeyPress += (o, args) => args.Handled = true;

            lbprice.Location = new Point(this.Size.Width - (label8.Size.Width - ((label8.Size.Width - lbprice.Size.Width) / 2)) - 55, 583);

            EventHandler drop = null;

            CCharity.DropDown += drop = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter($@"SELECT CharityId, dbo.Charity.CharityName, dbo.Charity.CharityDescription, dbo.Charity.CharityLogo FROM dbo.[Charity]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);
         
                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                    {
                        if (_data.ContainsKey(m_DataTable.Rows[i][1].ToString()))
                            continue;

                        _data.Add(m_DataTable.Rows[i][1].ToString(), new List<string> { m_DataTable.Rows[i][0].ToString(), m_DataTable.Rows[i][2].ToString(), m_DataTable.Rows[i][3].ToString() });
                        CCharity.Items.Add(m_DataTable.Rows[i][1].ToString());
                    }
                }
                CCharity.DropDown -= drop;
            };

            CCharity.SelectedIndexChanged += (o, args) =>
            {
                if (CCharity.Text != null)
                    imgCharity.Visible = true;
            };
        }

        private void txPrice_TextChanged(object sender, EventArgs e)
        {
            txPrice.Text = (txPrice.Text.Where(x => char.IsDigit(x)).Count() == 0) ? "" : string.Concat("$", Regex.Replace(txPrice.Text, @"[^0-9$]", "").Replace("$", null));
            txPrice.Select(txPrice.Text.Length, 0);
        }

        private void imgCharity_Click(object sender, EventArgs e) =>
            new CharityInfo(CCharity.Text, _data[CCharity.Text][1], string.Concat(g_PathCharityFolder, @"\\", _data[CCharity.Text][2])).ShowDialog();


        private void chk42km_CheckedChanged(object sender, EventArgs e)
        {
            if (chk42km.Checked)
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) + 145).ToString());
            else
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) - 145).ToString());

            lbprice.Location = new Point(this.Size.Width - (label8.Size.Width - ((label8.Size.Width - lbprice.Size.Width) / 2)) - 55, 583);
        }

        private void chk21km_CheckedChanged(object sender, EventArgs e)
        {
            if (chk21km.Checked)
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) + 75).ToString());
            else
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) - 75).ToString());

            lbprice.Location = new Point(this.Size.Width - (label8.Size.Width - ((label8.Size.Width - lbprice.Size.Width) / 2)) - 55, 583);
        }

        private void chk5km_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5km.Checked)
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) + 20).ToString());
            else
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) - 20).ToString());

            lbprice.Location = new Point(this.Size.Width - (label8.Size.Width - ((label8.Size.Width - lbprice.Size.Width) / 2)) - 55, 583);
        }

        private void rbA_CheckedChanged(object sender, EventArgs e) => RaceKitOption = 'A';//Reserved

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbB.Checked)
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) + 20).ToString());
            else
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) - 20).ToString());

            lbprice.Location = new Point(this.Size.Width - (label8.Size.Width - ((label8.Size.Width - lbprice.Size.Width) / 2)) - 55, 583);

            RaceKitOption = 'B';
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbC.Checked)
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) + 45).ToString());
            else
                lbprice.Text = string.Concat("$", (Convert.ToInt32(lbprice.Text.Replace("$", null)) - 45).ToString());

            lbprice.Location = new Point(this.Size.Width - (label8.Size.Width - ((label8.Size.Width - lbprice.Size.Width) / 2)) - 55, 583);

            RaceKitOption = 'C';
        }

        private void paybut_Click(object sender, EventArgs e)
        {
            if (CCharity.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(this, "Выберите благотворительную компанию!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txPrice.Text))
            {
                MessageBox.Show(this, "Сумма взноса отсутствует!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chk42km.Checked && !chk21km.Checked && !chk5km.Checked)
            {
                MessageBox.Show(this, "Вид марафона не выбран!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rbA.Checked && !rbB.Checked && !rbC.Checked)
            {
                MessageBox.Show(this, "Вариант комплектов не выбран!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var iRunnerId = MyAttributeExists<int>($"SELECT RunnerId FROM Runner WHERE Email = '{m_pRunnerId}'", sqlConnection);
            if (iRunnerId == 0)
            {
                MessageBox.Show(this, "Internal get id error!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var isqldat = new SqlDataAdapter($@"SELECT RunnerId FROM Registration WHERE RunnerId = '{iRunnerId}'", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                if (m_DataTable.Rows.Count != 0)
                {
                    m_DataTable.Dispose();

                    MessageBox.Show(this, "Пользователь уже зарегистрировался на марафон!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                m_DataTable.Dispose();
            }

            var preRegCheck = MyAttributeExists<int>($"SELECT RunnerId FROM Registration WHERE Email = '{iRunnerId}'", sqlConnection);
            if (preRegCheck == 0)
            {
                MessageBox.Show(this, "Internal get id error!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var sqlcmRunner = new SqlCommand($@"INSERT INTO [Registration] (RunnerId,RegistrationDateTime,RaceKitOptionId,RegistrationStatusId,Cost,CharityId,SponsorshipTarget) VALUES 
                  ('{iRunnerId}', 
                  '{DateTime.Now/*.ToString("yyyy.MM.dd HH:mm:ss.FFF")*/}', 
                  '{RaceKitOption}', 
                  '1', 
                  '{Convert.ToDecimal(lbprice.Text.Replace("$", null))}', 
                  '{_data[CCharity.Text][0]}', 
                  '{Convert.ToDecimal(txPrice.Text.Replace("$", null))}')
                  SELECT * FROM [Registration] WHERE RegistrationId = SCOPE_IDENTITY()",
                  sqlConnection))
            {
                using (SqlDataReader m_DataRead = sqlcmRunner.ExecuteReader())
                {
                    if (m_DataRead != null)
                        if (m_DataRead.Read())
                        {
                            if (m_DataRead[0] != null)
                            {
                                new RunnerConfirmation().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(this, "Internal error!", "SQL [Runner Ins]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                }
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

            Application.OpenForms.OfType<RunnerMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void MarathonRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void cancelbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<RunnerMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();
    }
}

