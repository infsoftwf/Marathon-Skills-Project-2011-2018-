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
    public partial class AddEditCharity : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        Dictionary<String, List<String>> mapCharity = null;

        public AddEditCharity(Dictionary<String, List<String>> m_map = null)
        {
            InitializeComponent();

            if (m_map != null)
                mapCharity = m_map;

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void AddEditCharity_Load(object sender, EventArgs e)
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

            if (mapCharity != null)
            {
                txName.Text = mapCharity.FirstOrDefault().Key;
                txDesc.Text = mapCharity[txName.Text][1];
                txFileImgChar.Text = mapCharity[txName.Text][0];
                imgChar.BackgroundImage = Image.FromFile(string.Concat(g_PathCharityFolder, @"\\", mapCharity[txName.Text][0]));
            }
        }

        private void txName_MouseEnter(object sender, EventArgs e)
        {
            if (txName.Text.Equals("Наименование"))
                txName.Text = null;
        }

        private void txName_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txName.Text))
                txName.Text = "Наименование";
        }

        private void txDesc_MouseEnter(object sender, EventArgs e)
        {
            if (txDesc.Text.Equals("Описание благотворительной организации"))
                txDesc.Text = null;
        }

        private void txDesc_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDesc.Text))
                txDesc.Text = "Описание благотворительной организации";
        }

        private void butimgload_Click(object sender, EventArgs e)
        {
            using (var m_ofd = new OpenFileDialog() { Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp, *.gif) | *.jpg; *.jpeg; *.png; *.bmp; *.gif", ValidateNames = true })
            {
                if (m_ofd.ShowDialog().Equals(DialogResult.OK))
                {
                    txFileImgChar.Text = Path.GetFileName(m_ofd.FileName);
                    imgChar.BackgroundImage = Image.FromFile(m_ofd.FileName);
                }
            }
        }

        private void paybut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txName.Text)
                || string.IsNullOrEmpty(txDesc.Text))
            {
                MessageBox.Show(this, "Введенные данные некорректны!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tmpCharLogo = txFileImgChar.Text.Contains('.') ? txFileImgChar.Text : String.Empty;
            if (mapCharity != null)
            {
                using (var sqlchar = new SqlCommand($"UPDATE [Charity] SET CharityName = '{txName.Text}', CharityDescription = '{txDesc.Text}', CharityLogo = '{tmpCharLogo}' WHERE CharityName = '{mapCharity.FirstOrDefault().Key}'", sqlConnection))
                {
                    if (sqlchar.ExecuteNonQuery() > 0)
                        MessageBox.Show(this, "Данные организации успешно редактированы!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Internal error!", "SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                using (var sqlchar = new SqlCommand($"INSERT INTO [Charity] (CharityName,CharityDescription,CharityLogo) VALUES ('{txName.Text}','{txDesc.Text}','{tmpCharLogo}')", sqlConnection))
                {
                    if (sqlchar.ExecuteNonQuery() > 0)
                        MessageBox.Show(this, "Организация успешно внесена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Internal error!", "SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Application.OpenForms.OfType<ManageCharities>().Single().Show();

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

