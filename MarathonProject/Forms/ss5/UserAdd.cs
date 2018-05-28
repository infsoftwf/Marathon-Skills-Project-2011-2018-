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
    public partial class UserAdd : Form
    {
        private Thread mainThread = null;

        private SqlConnection sqlConnection = null;

        private Tuple<ComboBox.ObjectCollection> m_params = null;
        private Dictionary<String, Char> map_Role = new Dictionary<String, Char>();

        public UserAdd(Tuple<ComboBox.ObjectCollection> va_arg)
        {
            if (va_arg == null)
            {
                MessageBox.Show(this, "Fatal Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (mainThread != null)
                    mainThread.Abort();

                Application.OpenForms.OfType<RunnerManagement>().Single().Show();

                this.Dispose();
                this.Close();

                return;
            }

            m_params = va_arg;

            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void UserAdd_Load(object sender, EventArgs e)
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

            map_Role.Add("Administrator", 'A');
            map_Role.Add("Coordinator", 'C');
            map_Role.Add("Runner", 'R');

            CRole.KeyPress += (o, args) => args.Handled = true;

            txPass.PasswordChar = '*';
            txPassR.PasswordChar = '*';

            var enumerator = m_params.Item1.GetEnumerator();
            if (enumerator == null)
            {
                MessageBox.Show(this, "Internal error!", "IQuery [m_params]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                methodExit();
            }

            while (enumerator.MoveNext())
                CRole.Items.Add(enumerator.Current);

            CRole.Items.RemoveAt(CRole.Items.Count - 1);

            CRole.SelectedIndex = 0;
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            if (!((TextBox)sender).Text.Equals("Пароль") && !((TextBox)sender).Text.Equals("Повторите пароль"))
                txPass.Text = Regex.Replace(Regex.Replace(txPass.Text, @"[^A-z0-9!@$%^&.]", ""), "_", "");
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

        private void bSaveEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txName.Text)
                || string.IsNullOrEmpty(txFam.Text))
            {
                MessageBox.Show(this, "Введенные данные некорректны!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txEmail.Text, @"^([a-z]|[0-9]|.{1})+@{1}[a-z]+.{1}[a-z]+$"))
            {
                MessageBox.Show(this, "Email имеет некорректный адрес!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            using (var sqlcmUser = new SqlCommand($"INSERT INTO [User] (Email,Password,FirstName,LastName,RoleId) VALUES ('{txEmail.Text}', '{txPass.Text}', '{txName.Text}', '{txFam.Text}', '{map_Role[CRole.Text]}')", sqlConnection))
            {
                if (sqlcmUser.ExecuteNonQuery() > 0)
                    MessageBox.Show(this, "Пользователь добавлен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Internal error!", "SQL [User Ins]", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Application.OpenForms.OfType<UsersManagement>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<UsersManagement>().Single().Show();

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

