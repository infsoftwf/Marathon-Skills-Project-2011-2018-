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
    public partial class SponsorRunner : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        String lpCharityName = null,
            lpCharityDescription = null,
            lpCharityLogo = null;

        public SponsorRunner()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void SponsorRunner_Load(object sender, EventArgs e)
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

            CRunner.KeyPress += (o, args) => args.Handled = true;

            EventHandler drop = null;

            CRunner.DropDown += drop = (o, args) =>
            {
                new Thread(() =>
                {
                    paybut.Invoke(new MethodInvoker(() => paybut.Enabled = false));
                    CRunner.Invoke(new MethodInvoker(() =>
                    {
                        CRunner.Text = "Загрузка";
                        CRunner.Enabled = false;
                    }));

                    using (var isqldat = new SqlDataAdapter("SELECT Email, FirstName, LastName FROM [User]", sqlConnection))
                    {
                        var m_DataTable = new DataTable();
                        isqldat.Fill(m_DataTable);

                        for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        {
                            var iCountry = MyAttributeExists<String>($"SELECT CountryCode FROM [Runner] WHERE Email = '{m_DataTable.Rows[i][0]}'", sqlConnection);
                            CRunner.Invoke(new MethodInvoker(() => CRunner.Items.Add(string.Concat(m_DataTable.Rows[i][1].ToString(), " ", m_DataTable.Rows[i][2].ToString(), " - (", iCountry, ")"))));
                        }
                    }
                    CRunner.DropDown -= drop;
                    paybut.Invoke(new MethodInvoker(() => paybut.Enabled = true));
                    CRunner.Invoke(new MethodInvoker(() =>
                    {
                        CRunner.Text = null;
                        CRunner.Enabled = true;
                    }));
                }).Start();
            };

            CRunner.SelectedIndexChanged += (o, args) =>
            {
                if (string.IsNullOrEmpty(CRunner.Text))
                    return;

                using (var isqldat = new SqlDataAdapter($@"SELECT dbo.Charity.CharityName, dbo.Charity.CharityDescription, dbo.Charity.CharityLogo
                    FROM dbo.[User] INNER JOIN
                         dbo.Runner ON dbo.[User].Email = dbo.Runner.Email INNER JOIN
                         dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN
                         dbo.Charity ON dbo.Registration.CharityId = dbo.Charity.CharityId 
                         WHERE(dbo.[User].FirstName = '{CRunner.Text.Split(' ')[0]}') AND (dbo.[User].LastName = '{CRunner.Text.Split(' ')[1]}')", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    lbCharityName.Text = lpCharityName = m_DataTable.Rows[0][0].ToString();
                    lpCharityDescription = m_DataTable.Rows[0][1].ToString();
                    lpCharityLogo = string.Concat(g_PathCharityFolder, @"\\", m_DataTable.Rows[0][2].ToString());

                    //for (int i = 0; i < m_DataTable.Rows.Count; i++)
                    //{
                    //    var iCountry = MyAttributeExists<String>($"SELECT CountryCode FROM [Runner] WHERE Email = '{m_DataTable.Rows[i][0]}'", sqlConnection);
                    //    CRunner.Items.Add(string.Concat(m_DataTable.Rows[i][1].ToString(), " ", m_DataTable.Rows[i][2].ToString(), " - (", iCountry, ")"));
                    //}
                }

                //var sRunnerEmail = MyAttributeExists<String>($"SELECT [Email] FROM [User] WHERE FirstName = '{CRunner.Text.Split(' ')[0]}' AND LastName = '{CRunner.Text.Split(' ')[1]}'", sqlConnection);
                //if (string.IsNullOrEmpty(sRunnerEmail))
                //{
                //    MessageBox.Show(this, "Internal error [!sRunnerEmail]");
                //    return;
                //}

                //var iRunnerId = MyAttributeExists<int>($"SELECT [RunnerId] FROM [Runner] WHERE [Email] = '{sRunnerEmail}'", sqlConnection);
                //if (iRunnerId <= 0)
                //{
                //    MessageBox.Show(this, "Internal error [!iRunnerId]");
                //    return;
                //}

                //var iCharityId = MyAttributeExists<int>($"SELECT [CharityId] FROM [Registration] WHERE [RunnerId] = '{iRunnerId}'", sqlConnection);
                //if (iRunnerId <= 0)
                //{
                //    MessageBox.Show(this, "Internal error [!iRegistrationId]");
                //    return;
                //}

                //using (var isqldat = new SqlDataAdapter($"SELECT [CharityName], [CharityDescription], [CharityLogo] FROM [Charity] WHERE [CharityId] = '{iCharityId}'", sqlConnection))
                //{
                //    var m_DataTable = new DataTable();
                //    isqldat.Fill(m_DataTable);

                //    lbCharityName.Text = lpCharityName = m_DataTable.Rows[0][0].ToString();
                //    lpCharityDescription = m_DataTable.Rows[0][1].ToString();
                //    lpCharityLogo = string.Concat(g_CharityFolder, @"\\", m_DataTable.Rows[0][2].ToString());

                //    //for (int i = 0; i < m_DataTable.Rows.Count; i++)
                //    //{
                //    //    var iCountry = MyAttributeExists<String>($"SELECT CountryCode FROM [Runner] WHERE Email = '{m_DataTable.Rows[i][0]}'", sqlConnection);
                //    //    CRunner.Items.Add(string.Concat(m_DataTable.Rows[i][1].ToString(), " ", m_DataTable.Rows[i][2].ToString(), " - (", iCountry, ")"));
                //    //}
                //}
            };

            lbprice.Location = new Point(this.Size.Width - (label11.Size.Width - ((label11.Size.Width - lbprice.Size.Width) / 2)) - 35, 427);
        }

        private void TPrice_TextChanged(object sender, EventArgs e)
        {
            if (TPrice.Text.Any(x => !char.IsDigit(x)))
            {
                TPrice.Text = string.Concat(TPrice.Text.Where(char.IsDigit));
                TPrice.Select(TPrice.Text.Length, 0);
            }

            lbprice.Text = string.Concat("$", TPrice.Text);

            if (string.IsNullOrEmpty(TPrice.Text))
                lbprice.Text = string.Concat("0$", TPrice.Text);

            lbprice.Location = new Point(this.Size.Width - (label11.Size.Width - ((label11.Size.Width - lbprice.Size.Width) / 2)) - 35, 427);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var tmp = Convert.ToInt32(lbprice.Text.Replace("$", ""));

            tmp += 10;

            if (tmp > 99999)
                tmp = 99999;

            lbprice.Text = string.Concat("$", tmp.ToString());
            TPrice.Text = tmp.ToString();
            lbprice.Location = new Point(this.Size.Width - (label11.Size.Width - ((label11.Size.Width - lbprice.Size.Width) / 2)) - 35, 427);
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            var tmp = Convert.ToInt32(lbprice.Text.Replace("$", ""));

            tmp -= 10;

            if (tmp < 0)
                tmp = 0;

            lbprice.Text = string.Concat("$", tmp.ToString());
            TPrice.Text = tmp.ToString();
            lbprice.Location = new Point(this.Size.Width - (label11.Size.Width - ((label11.Size.Width - lbprice.Size.Width) / 2)) - 35, 427);
        }

        private void TName_MouseEnter(object sender, EventArgs e)
        {
            if (TName.Text.Equals("Ваше имя"))
                TName.Text = null;
        }

        private void TName_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TName.Text))
                TName.Text = "Ваше имя";
        }

        private void TNameCard_MouseEnter(object sender, EventArgs e)
        {
            if (TNameCard.Text.Equals("Владелец карты"))
                TNameCard.Text = null;
        }

        private void TNameCard_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TNameCard.Text) || TNameCard.Text.Where(char.IsLetter).Count() == 0)
                TNameCard.Text = "Владелец карты";
        }

        private void TNameCard_TextChanged(object sender, EventArgs e)
        {
            if (!TNameCard.Text.Equals("Владелец карты"))
                TNameCard.Text = Regex.Replace(TNameCard.Text, @"[^A-Z ]", "");
        }

        private void TMonth_MouseEnter(object sender, EventArgs e)
        {
            if (TMonth.Text.Equals("01"))
                TMonth.Text = null;
        }

        private void TMonth_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TMonth.Text))
                TMonth.Text = "01";
        }

        private void TYear_MouseEnter(object sender, EventArgs e)
        {
            if (TYear.Text.Equals("2018"))
                TYear.Text = null;
        }

        private void TYear_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TYear.Text))
                TYear.Text = "2018";
        }

        private void TCVC_MouseEnter(object sender, EventArgs e)
        {
            if (TCVC.Text.Equals("123"))
                TCVC.Text = null;
        }

        private void TCVC_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TCVC.Text))
                TCVC.Text = "123";
        }

        private void TMonth_TextChanged(object sender, EventArgs e)
        {
            if (TMonth.Text.Any(x => !char.IsDigit(x)))
            {
                TMonth.Text = string.Concat(TMonth.Text.Where(char.IsDigit));
                TMonth.Select(TMonth.Text.Length, 0);
            }
        }

        private void TYear_TextChanged(object sender, EventArgs e)
        {
            if (TYear.Text.Any(x => !char.IsDigit(x)))
            {
                TYear.Text = string.Concat(TYear.Text.Where(char.IsDigit));
                TYear.Select(TYear.Text.Length, 0);
            }
        }

        private void TCVC_TextChanged(object sender, EventArgs e)
        {
            if (TCVC.Text.Any(x => !char.IsDigit(x)))
            {
                TCVC.Text = string.Concat(TCVC.Text.Where(char.IsDigit));
                TCVC.Select(TCVC.Text.Length, 0);
            }
        }

        private void methodExit()
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MainMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            methodExit();
        }

        private void SponsorRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void cancelbut_Click(object sender, EventArgs e)
        {
            methodExit();
        }

        private void imgCharity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lpCharityName)
                || string.IsNullOrEmpty(lpCharityDescription)
                || string.IsNullOrEmpty(lpCharityLogo))
            {
                MessageBox.Show(this, "Не удалось получить информацию о благотворительной организации.", "CharityInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new CharityInfo(lpCharityName, lpCharityDescription, lpCharityLogo).ShowDialog();
        }

        private void paybut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TName.Text)
                || string.IsNullOrEmpty(TNameCard.Text)
                || string.IsNullOrEmpty(TCard.Text)
                || string.IsNullOrEmpty(TMonth.Text)
                || string.IsNullOrEmpty(TYear.Text)
                || string.IsNullOrEmpty(TCVC.Text))
            {
                MessageBox.Show(this, "Введенные данные некорректны!");
                return;
            }

            if (!Regex.IsMatch(TName.Text, @"^[A-Z]+\s{1}[A-Z]*$"))
            {
                MessageBox.Show(this, "Данные владельца карты некорректны!");
                return;
            }

            if (!TCard.MaskCompleted)
            {
                MessageBox.Show(this, "Номер карты некорректен!");
                return;
            }

            if (!Regex.IsMatch(TNameCard.Text, @"^[A-Z]+\s{1}[A-Z]*$"))
            {
                MessageBox.Show(this, "Данные владельца карты некорректны!");
                return;
            }

            if (CRunner.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(this, "Выберите бегуна!");
                return;
            }

            //var sRunnerEmail = MyAttributeExists<String>($"SELECT [Email] FROM [User] WHERE FirstName = '{CRunner.Text.Split(' ')[0]}' AND LastName = '{CRunner.Text.Split(' ')[1]}'", sqlConnection);
            //if (string.IsNullOrEmpty(sRunnerEmail))
            //{
            //    MessageBox.Show(this, "Internal error [!sRunnerEmail]");
            //    return;
            //}

            //var iRunnerId = MyAttributeExists<int>($"SELECT [RunnerId] FROM [Runner] WHERE [Email] = '{sRunnerEmail}'", sqlConnection);
            //if (iRunnerId <= 0)
            //{
            //    MessageBox.Show(this, "Internal error [!iRunnerId]");
            //    return;
            //}

            //var iRegistrationId = MyAttributeExists<int>($"SELECT [RegistrationId] FROM [Registration] WHERE [RunnerId] = '{iRunnerId}'", sqlConnection);
            //if (iRegistrationId <= 0)
            //{
            //    MessageBox.Show(this, "Internal error [!iRegistrationId]");
            //    return;
            //}

            //using (var sqlcm = new SqlCommand($"INSERT INTO Sponsorship (SponsorName,RegistrationId,Amount) VALUES ('{TName.Text}', '{iRegistrationId}', '{Convert.ToDecimal(TPrice.Text)}') SELECT * FROM Sponsorship WHERE SponsorshipId = SCOPE_IDENTITY()", sqlConnection))
            //{
            //    using (SqlDataReader m_DataRead = sqlcm.ExecuteReader())
            //    {
            //        if (m_DataRead != null)
            //            if (m_DataRead.Read())
            //            {
            //                if (m_DataRead[0] != null)
            //                {
            //                    new SponsorshipConfirmation().Show();
            //                    this.Hide();
            //                }
            //                else
            //                {
            //                    MessageBox.Show(this, "Internal error!", "SQL [Sponsorship Ins]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    return;
            //                }
            //            }
            //    }
            //}

            var iRegistrationId = MyAttributeExists<int>($@"SELECT dbo.Registration.RegistrationId
                     FROM dbo.[User] INNER JOIN
                     dbo.Runner ON dbo.[User].Email = dbo.Runner.Email INNER JOIN
                     dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId
                     WHERE(dbo.[User].FirstName = '{CRunner.Text.Split(' ')[0]}') AND (dbo.[User].LastName = '{CRunner.Text.Split(' ')[1]}')", sqlConnection);

            if (iRegistrationId <= 0)
            {
                MessageBox.Show(this, "Internal error [!iRegistrationId]");
                return;
            }

            using (var sqlcm = new SqlCommand($"INSERT INTO Sponsorship (SponsorName,RegistrationId,Amount) VALUES ('{TName.Text}', '{iRegistrationId}', '{Convert.ToDecimal(TPrice.Text)}') SELECT * FROM Sponsorship WHERE SponsorshipId = SCOPE_IDENTITY()", sqlConnection))
            {
                using (SqlDataReader m_DataRead = sqlcm.ExecuteReader())
                {
                    if (m_DataRead != null)
                        if (m_DataRead.Read())
                        {
                            if (m_DataRead[0] != null)
                            {
                                new SponsorshipConfirmation(lbprice.Text, CRunner.Text).Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(this, "Internal error!", "SQL [Sponsorship Ins]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                }
            }
        }
    }
}

