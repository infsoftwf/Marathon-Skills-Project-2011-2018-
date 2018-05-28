using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
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
    public partial class Login : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;
        bool isMainLog = false;

        public Login(bool isMain = false, bool bIsLogRunner = false)
        {
            isMainLog = isMain;

            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();

            if (bIsLogRunner)
            {
                CRole.SelectedIndex = 0;
                CRole.Enabled = false;

                CRole.EnabledChanged += (o, args) => ((ComboBox)o).Enabled = false;
            }



            /*TEST*/

            //TEmail.Text = "r.dilello@gmail.com";//Runner
            //TPass.Text = "oTsMa3Ld";

            TEmail.Text = "r.dilello1@gmail.com";//Coord
            TPass.Text = "oTsMa3Ld";

            //CRole.SelectedIndex = 2;
            //TEmail.Text = "m1n3@gmail. com";//Admin
            //TPass.Text = "oTsMa3Ld";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CRole.KeyPress += (o, args) => args.Handled = true;

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
              
        private void methodBack()
        {
            if (mainThread != null)
                mainThread.Abort();

            if (isMainLog)
                Application.OpenForms.OfType<MainMenu>().Single().Show();
            else
                Application.OpenForms.OfType<LoginRunner>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            methodBack();
        }

        private void paybut_Click(object sender, EventArgs e)
        {
            TEmail.Enabled = TPass.Enabled = CRole.Enabled = false;

            if (string.IsNullOrEmpty(TEmail.Text)
                || Regex.IsMatch(TEmail.Text, @"[а-яА-Я]")
                || string.IsNullOrEmpty(TPass.Text)
                || Regex.IsMatch(TPass.Text, @"[а-яА-Я]"))
            {
                TEmail.Enabled = TPass.Enabled = CRole.Enabled = true;
                MessageBox.Show(this, "Данные не корректны!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (!m_isPresentEx(TPass.Text, true, false, true, true) || TPass.Text.Length < 6)//if (!m_isPresentEx(TPass.Text, true, true, false, false, true, 8))
            //{
            //    TEmail.Enabled = TPass.Enabled = CRole.Enabled = true;
            //    MessageBox.Show(this, "Пароль имеет неверный формат!", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (CRole.SelectedIndex.Equals(-1))
            {
                TEmail.Enabled = TPass.Enabled = CRole.Enabled = true;
                MessageBox.Show(this, "Не выбрана роль!", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sqlConnection.State != ConnectionState.Open)
            {
                TEmail.Enabled = TPass.Enabled = CRole.Enabled = true;
                MessageBox.Show(this, "CONNECT ERROR", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String m_Role = String.Empty;
            switch (CRole.SelectedIndex)
            {
                case 0:
                    m_Role = "R";
                    break;

                case 1:
                    m_Role = "C";
                    break;

                case 2:
                    m_Role = "A";
                    break;
            }

            var m_mainISqlDat = new SqlDataAdapter($"SELECT [RoleId] FROM [User] WHERE Email = '{TEmail.Text}' AND [Password] = '{TPass.Text}' AND [RoleId] = '{m_Role}'", sqlConnection);

            var m_mainISqlDataTable = new DataTable();
            m_mainISqlDat.Fill(m_mainISqlDataTable);

            if (m_mainISqlDataTable.Rows.Count == 0)
            {
                TEmail.Enabled = TPass.Enabled = CRole.Enabled = true;
                MessageBox.Show(this, "Неправильно указан email и/или пароль", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (m_mainISqlDataTable.Rows[0][0].ToString())
            {
                case "R":
                    new RunnerMenu(TEmail.Text).Show();
                    break;

                case "C":
                    new CoordinatorMenu().Show();
                    break;

                case "A":
                    new AdminMenu().Show();
                    break;
            }
            TEmail.Enabled = TPass.Enabled = CRole.Enabled = true;
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void dispSelectAll(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.Equals(Keys.A))
                if (sender != null)
                    ((TextBox)sender).SelectAll();
        }

        private void TEmail_MouseEnter(object sender, EventArgs e)
        {
            if (TEmail.Text.Equals("Введите ваш Email"))
                TEmail.Text = null;
        }

        private void TEmail_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TEmail.Text))
                TEmail.Text = "Введите ваш Email";
        }

        private void TEmail_TextChanged(object sender, EventArgs e)
        {
            if (!TEmail.Text.Equals("Введите ваш Email"))
                TEmail.Text = Regex.Replace(TEmail.Text, @"[^a-zA-Z0-9.@]", "");
        }

        private void TPass_MouseEnter(object sender, EventArgs e)
        {
            if (TPass.Text.Equals("Введите ваш пароль"))
                TPass.Text = null;
        }

        private void TPass_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TPass.Text))
                TPass.Text = "Введите ваш пароль";
        }

        private void TPass_TextChanged(object sender, EventArgs e)
        {
            if (!TPass.Text.Equals("Введите ваш пароль"))
                TPass.Text = Regex.Replace(TPass.Text, @"[а-яА-Я]", "");
        }

        private void cancelbut_Click(object sender, EventArgs e)
        {
            methodBack();
        }
    }
}

