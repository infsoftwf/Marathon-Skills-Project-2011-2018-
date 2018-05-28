using MarathonProject.INF_TOOLS;
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
using static MarathonProject.INF_TOOLS.INFAPI;

namespace MarathonProject.Forms
{
    public partial class RunnerRegister : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        Dictionary<String, String> mapCountry = new Dictionary<String, String>();

        public RunnerRegister()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void RunnerRegister_Load(object sender, EventArgs e)
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

            CGender.KeyPress += (o, args) => args.Handled = true;
            CCountry.KeyPress += (o, args) => args.Handled = true;

            txPass.PasswordChar = '*';
            txPassR.PasswordChar = '*';

            EventHandler drop = null, dropcnt = null;

            CGender.DropDown += drop = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter("SELECT * FROM [Gender]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                        CGender.Items.Add(m_DataTable.Rows[i][0].ToString());
                }
                CGender.DropDown -= drop;
                drop = null;
            };

            CCountry.DropDown += dropcnt = (o, args) =>
            {
                using (var isqldat = new SqlDataAdapter("SELECT CountryCode, CountryName FROM [Country]", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    for (int i = 0; i < m_DataTable.Rows.Count; i++)
                    {
                        mapCountry.Add(m_DataTable.Rows[i][1].ToString(), m_DataTable.Rows[i][0].ToString());
                        CCountry.Items.Add(m_DataTable.Rows[i][1].ToString());
                    }
                }
                CCountry.DropDown -= dropcnt;
                dropcnt = null;
            };
        }

        private void txEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txEmail.Text.Equals("Email"))
                txEmail.Text = Regex.Replace(Regex.Replace(txEmail.Text, @"[^a-z0-9!@$%^&.]", ""), "_", "");
        }

        private void txEmail_MouseEnter(object sender, EventArgs e)
        {
            if (txEmail.Text.Equals("Email"))
                txEmail.Text = null;
        }

        private void txEmail_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txEmail.Text))
                txEmail.Text = "Email";
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            if (!((TextBox)sender).Text.Equals("Пароль") && !((TextBox)sender).Text.Equals("Повторите пароль"))
                txPass.Text = Regex.Replace(Regex.Replace(txPass.Text, @"[^A-z0-9!@$%^&.]", ""), "_", "");
        }

        private void txPass_MouseEnter(object sender, EventArgs e)
        {
            if (txPass.Text.Equals("Пароль"))
                txPass.Text = null;
        }

        private void txPass_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txPass.Text))
                txPass.Text = "Пароль";
        }

        private void txPassR_MouseEnter(object sender, EventArgs e)
        {
            if (txPassR.Text.Equals("Повторите пароль"))
                txPassR.Text = null;
        }

        private void txPassR_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txPassR.Text))
                txPassR.Text = "Повторите пароль";
        }

        private void txName_MouseEnter(object sender, EventArgs e)
        {
            if (txName.Text.Equals("Имя"))
                txName.Text = null;
        }

        private void txName_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txName.Text))
                txName.Text = "Имя";
        }

        private void txFam_MouseEnter(object sender, EventArgs e)
        {
            if (txFam.Text.Equals("Фамилия"))
                txFam.Text = null;
        }

        private void txFam_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txFam.Text))
                txFam.Text = "Фамилия";
        }

        private void butimgload_Click(object sender, EventArgs e)
        {
            using (var m_ofd = new OpenFileDialog() { Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png" })
            {
                if (m_ofd.ShowDialog().Equals(DialogResult.OK))
                {
                    txFileAvatar.Text = Path.GetFileName(m_ofd.FileName);
                    imgAvatar.BackgroundImage = Image.FromFile(m_ofd.FileName);

                    if (imgAvatar.BackgroundImage != null)
                        lbForAvatar.Visible = false;
                }
            }
        }

        private void paybut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txEmail.Text)
                || string.IsNullOrEmpty(txPass.Text)
                || string.IsNullOrEmpty(txPassR.Text)
                || string.IsNullOrEmpty(txName.Text)
                || string.IsNullOrEmpty(txFam.Text))
            {
                MessageBox.Show(this, "Введенные данные некорректны!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CGender.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(this, "Не выбран пол!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txFileAvatar.Text == null || imgAvatar.BackgroundImage == null)
            {
                MessageBox.Show(this, "Не выбрано фото!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CCountry.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(this, "Не выбрана страна!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            if (DateTime.Now.Subtract(dateRunner.Value).Days < 3650)
            {
                MessageBox.Show(this, "Ваш возраст не соответствует требованию!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txEmail.Text, @"^([a-z]|[0-9]|.{1})+@{1}[a-z]+.{1}[a-z]+$"))
            {
                MessageBox.Show(this, "Email имеет некорректный адрес!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!m_isPresentEx(txPass.Text, true, false, true, true) || txPass.Text.Length < 6)
            {
                MessageBox.Show(this, "Пароль имеет неверный формат!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txPass.Text.Equals(txPassR.Text))
            {
                MessageBox.Show(this, "Пароли не совпадают!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MyAttributeExists<String>($"SELECT Email FROM [User] WHERE Email = '{txEmail.Text}'", sqlConnection) != null)
            {
                MessageBox.Show(this, "Email уже используется!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var sqlcmUser = new SqlCommand($"INSERT INTO [User] (Email,Password,FirstName,LastName,RoleId) VALUES ('{txEmail.Text}', '{txPass.Text}', '{txName.Text}', '{txFam.Text}', 'R')", sqlConnection))
            {
                if (sqlcmUser.ExecuteNonQuery() > 0)
                {
                    using (var sqlcmRunner = new SqlCommand($"INSERT INTO [Runner] (Email,Gender,DateOfBirth,CountryCode,Image) VALUES ('{txEmail.Text}', '{CGender.Text}', '{dateRunner.Value.ToString("yyyy.MM.dd HH:mm:ss.FFF")}', '{mapCountry[CCountry.Text]}', @ImgBuff) SELECT * FROM [Runner] WHERE RunnerId = SCOPE_IDENTITY()", sqlConnection))
                    {
                        sqlcmRunner.Parameters.AddWithValue("@ImgBuff", (byte[])(new ImageConverter().ConvertTo(imgAvatar.BackgroundImage, typeof(byte[]))));

                        using (SqlDataReader m_DataRead = sqlcmRunner.ExecuteReader())
                        {
                            if (m_DataRead != null)
                                if (m_DataRead.Read())
                                {
                                    if (m_DataRead[0] != null)
                                        MessageBox.Show(this, "Регистрация прошла успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    else
                                    {
                                        MessageBox.Show(this, "Internal error!", "SQL [Runner Ins]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                        }
                    }
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<LoginRunner>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<LoginRunner>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void RunnerRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }
    }
}

