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
    public partial class RunnerEdit : Form
    {
        private Thread mainThread = null;

        private SqlConnection sqlConnection = null;

        private Dictionary<String, String> mapCountry = new Dictionary<String, String>();
        private String m_pRunnerId = String.Empty;

        private bool bCoord = false;

        public RunnerEdit(String RunnerId, bool isCoord = false)
        {
            m_pRunnerId = RunnerId;
            InitializeComponent();

            bCoord = isCoord;

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void RunnerEdit_Load(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(m_pRunnerId))
            {
                MessageBox.Show(this, "Internal error!", "SQL [Email]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                methodExit();
            }

            CGender.KeyPress += (o, args) => args.Handled = true;
            CCountry.KeyPress += (o, args) => args.Handled = true;

            txPass.PasswordChar = '*';
            txPassR.PasswordChar = '*';

            lbEmail.Text = m_pRunnerId;

            using (var isqldat = new SqlDataAdapter("SELECT * FROM [Gender]", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                    CGender.Items.Add(m_DataTable.Rows[i][0].ToString());
            }

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

            using (var isqldat = new SqlDataAdapter($"SELECT FirstName, LastName FROM [User] WHERE Email = '{m_pRunnerId}'", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                txName.Text = m_DataTable.Rows[0][0].ToString();
                txFam.Text = m_DataTable.Rows[0][1].ToString();

                m_DataTable.Clear();
                m_DataTable.Dispose();
            }

            using (var isqldat = new SqlDataAdapter($"SELECT Gender, DateOfBirth, CountryCode, Image FROM [Runner] WHERE Email = '{m_pRunnerId}'", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                if (m_DataTable.Rows.Count > 0)
                {
                    CGender.Text = m_DataTable.Rows[0][0].ToString();
                    dateRunner.Text = m_DataTable.Rows[0][1].ToString();
                    CCountry.Text = mapCountry.FirstOrDefault(x => x.Value.Equals(m_DataTable.Rows[0][2].ToString())).Key;

                    if (m_DataTable.Rows[0][3].ToString().Length != 0)
                        if ((imgAvatar.BackgroundImage = Image.FromStream(new MemoryStream((byte[])m_DataTable.Rows[0][3]))) != null)
                            lbForAvatar.Visible = false;

                }
                m_DataTable.Clear();
                m_DataTable.Dispose();
            }
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            if (!((TextBox)sender).Text.Equals("Пароль") && !((TextBox)sender).Text.Equals("Повторите пароль"))
                txPass.Text = Regex.Replace(Regex.Replace(txPass.Text, @"[^A-z0-9!@$%^&.]", ""), "_", "");
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
            using (var m_ofd = new OpenFileDialog() { Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png", ValidateNames = true })
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
            if (string.IsNullOrEmpty(txName.Text)
                || string.IsNullOrEmpty(txFam.Text))
            {
                MessageBox.Show(this, "Введенные данные некорректны!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(CGender.Text))
            {
                MessageBox.Show(this, "Не выбран пол!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txFileAvatar.Text == null || imgAvatar.BackgroundImage == null)
            {
                MessageBox.Show(this, "Не выбрано фото!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(CCountry.Text))
            {
                MessageBox.Show(this, "Не выбрана страна!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.Now.Subtract(dateRunner.Value).Days < 3650)
            {
                MessageBox.Show(this, "Ваш возраст не соответствует требованию!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txPass.Text) && (!m_isPresentEx(txPass.Text, true, false, true, true) || txPass.Text.Length < 6))
            {
                MessageBox.Show(this, "Пароль имеет неверный формат!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txPass.Text.Equals(txPassR.Text))
            {
                MessageBox.Show(this, "Пароли не совпадают!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            using (var sqlcmUser = new SqlCommand(string.Concat("UPDATE [User] SET ", !string.IsNullOrEmpty(txPass.Text) ? $"Password = '{txPass.Text}', " : "", $"FirstName = '{txName.Text}', LastName = '{txFam.Text}' WHERE Email = '{lbEmail.Text}'"), sqlConnection))
            {
                if (sqlcmUser.ExecuteNonQuery() > 0)
                {
                    using (var sqlcmRunner = new SqlCommand($"UPDATE [Runner] SET Gender = '{CGender.Text}', DateOfBirth = '{dateRunner.Value.ToString("yyyy.MM.dd HH:mm:ss.FFF")}', CountryCode = '{mapCountry[CCountry.Text]}', Image = @ImgBuff WHERE Email = '{lbEmail.Text}'", sqlConnection))
                    {
                        sqlcmRunner.Parameters.AddWithValue("@ImgBuff", (byte[])(new ImageConverter().ConvertTo(imgAvatar.BackgroundImage, typeof(byte[]))));

                        if (sqlcmRunner.ExecuteNonQuery() > 0)
                            MessageBox.Show(this, "Данные профиля успешно редактированы!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(this, "Internal error!", "SQL [Runner Ins]", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            if (bCoord)
                Application.OpenForms.OfType<PostRunnerManagement>().Single().Show();
            else
                Application.OpenForms.OfType<RunnerMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            if (bCoord)
                Application.OpenForms.OfType<PostRunnerManagement>().Single().Show();
            else
                Application.OpenForms.OfType<RunnerMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void RunnerRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void butlogout_Click(object sender, EventArgs e) => methodExit();
    }
}

