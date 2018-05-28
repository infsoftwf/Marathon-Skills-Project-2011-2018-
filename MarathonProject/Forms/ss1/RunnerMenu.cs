using MarathonProject.INF_TOOLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;

namespace MarathonProject.Forms
{
    public partial class RunnerMenu : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        String m_pRunnerId = String.Empty;

        public RunnerMenu(String RunnerId)
        {
            m_pRunnerId = RunnerId;
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void RunnerMenu_Load(object sender, EventArgs e)
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

            Application.OpenForms.OfType<Login>().Single().Show();
        }

        private void RunnerMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void butlogout_Click(object sender, EventArgs e)
        {
            methodExit();
        }

        private void butContacts_Click(object sender, EventArgs e)
        {
            new Contacts().ShowDialog();
        }

        private void btGetRegisterMarathon_Click(object sender, EventArgs e)
        {
            new MarathonRegister(m_pRunnerId).Show();
            this.Hide();
        }

        private void btGetEditProfile_Click(object sender, EventArgs e)
        {
            new RunnerEdit(m_pRunnerId).Show();
            this.Hide();
        }

        private void btGetResult_Click(object sender, EventArgs e)
        {
            using (var m_mainISqlDat = new SqlDataAdapter($@"SELECT dbo.RegistrationEvent.RegistrationEventId
                         FROM dbo.Registration INNER JOIN
                         dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId WHERE Email = '{m_pRunnerId}'", sqlConnection))
            {
                var m_mainISqlDataTable = new DataTable();
                m_mainISqlDat.Fill(m_mainISqlDataTable);

                if (m_mainISqlDataTable.Rows.Count == 0)
                {
                    MessageBox.Show(this, "Результаты отсутствуют!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                new RunnerResult(m_pRunnerId).Show();
                this.Hide();
            }       
        }

        private void btSponsor_Click(object sender, EventArgs e)
        {
            new RunnerSponsor(m_pRunnerId).Show();
            this.Hide();
        }
    }
}

