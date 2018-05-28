using MarathonProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;
using static MarathonProject.INF_TOOLS.WinAPI;

namespace MarathonProject.Forms
{
    public partial class CharityList : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        public CharityList()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void CharityList_Load(object sender, EventArgs e)
        {
            pnl_CharityList.VerticalScroll.Visible = true;
            this.DoubleBuffered = true;

            int AutoYImgBox = 33;

            using (var isqldat = new SqlDataAdapter("SELECT [CharityName], [CharityDescription], [CharityLogo] FROM [Charity]", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                {
                    PictureBox tmpImgBox = new PictureBox();
                    tmpImgBox.Size = new Size(154, 152);
                    tmpImgBox.Location = new Point(21, AutoYImgBox);

                    var tmppath = string.Concat(g_PathCharityFolder, @"\\", m_DataTable.Rows[i][2].ToString());
                    tmpImgBox.BackgroundImage = (File.Exists(tmppath)) ? Image.FromFile(tmppath) : Resources.defaultAvatar;
                    tmpImgBox.BackgroundImageLayout = ImageLayout.Stretch;

                    SetWindowRgn(tmpImgBox.Handle, CreateEllipticRgn(0, 0, tmpImgBox.Width, tmpImgBox.Height), true);

                    pnl_CharityList.Controls.Add(tmpImgBox);

                    Label tmpLbCharityHead = new Label();
                    tmpLbCharityHead.AutoSize = true;
                    tmpLbCharityHead.Font = new Font("Tahoma", 16f);
                    tmpLbCharityHead.Location = new Point(190, AutoYImgBox);
                    tmpLbCharityHead.Text = m_DataTable.Rows[i][0].ToString();

                    pnl_CharityList.Controls.Add(tmpLbCharityHead);

                    Label tmpLbCharityDesc = new Label();
                    tmpLbCharityDesc.AutoSize = false;
                    tmpLbCharityDesc.Size = new Size(702, 240);
                    tmpLbCharityDesc.Font = new Font("Tahoma", 10f);
                    tmpLbCharityDesc.Location = new Point(190, AutoYImgBox + 30);
                    tmpLbCharityDesc.Text = m_DataTable.Rows[i][1].ToString();

                    pnl_CharityList.Controls.Add(tmpLbCharityDesc);

                    AutoYImgBox += 280;
                }
            }

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

            this.Dispose();
            this.Close();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MoreInfo>().Single().Show();

            this.Dispose();
            this.Close();
        }
        private void CharityList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        private void butback_2_Click(object sender, EventArgs e)
        {
            methodExit();
        }
    }
}

