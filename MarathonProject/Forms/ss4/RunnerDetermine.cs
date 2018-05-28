using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;

namespace MarathonProject.Forms.ss4
{
    public partial class RunnerDetermine : Form
    {
        SqlConnection sqlConnection = null;

        Tuple<string, string> g_tRunner = null;

        public RunnerDetermine(Tuple<string, string> m_Runner)
        {
            InitializeComponent();

            if (m_Runner == null)
            {
                MessageBox.Show(this, "UnknownData<string, string>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Dispose();
                this.Close();
            }

            g_tRunner = m_Runner;

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void RunnerDetermine_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.TopMost = true;

            this.Paint += (__o, __p) =>
            {
                __p.Graphics.DrawString(g_tRunner.Item1, new Font("Arial", 12), Brushes.Black, (sName.Location.X + sName.Width), sName.Location.Y + 4);
                __p.Graphics.DrawString(g_tRunner.Item2, new Font("Arial", 12), Brushes.Black, (SLast.Location.X + SLast.Width), SLast.Location.Y + 4);

                using (var isqldat = new SqlDataAdapter($@"SELECT dbo.Runner.Gender, dbo.Runner.DateOfBirth, dbo.Country.CountryName, dbo.Runner.Image
                         FROM dbo.Runner INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode
                         WHERE (dbo.[User].FirstName = '{g_tRunner.Item1}') AND (dbo.[User].LastName = '{g_tRunner.Item2}')", sqlConnection))
                {
                    var m_DataTable = new DataTable();
                    isqldat.Fill(m_DataTable);

                    if (m_DataTable.Rows.Count == 0)
                        return;

                    __p.Graphics.DrawString(m_DataTable.Rows[0][0].ToString(), new Font("Arial", 12), Brushes.Black, (SGender.Location.X + SGender.Width), SGender.Location.Y + 4);
                    __p.Graphics.DrawString(m_DataTable.Rows[0][1].ToString(), new Font("Arial", 12), Brushes.Black, (SBirth.Location.X + SBirth.Width), SBirth.Location.Y + 4);
                    __p.Graphics.DrawString(m_DataTable.Rows[0][2].ToString(), new Font("Arial", 12), Brushes.Black, (SCountry.Location.X + SCountry.Width), SCountry.Location.Y + 4);

                    if (m_DataTable.Rows[0][3].ToString().Length != 0)
                        imgAvatar.BackgroundImage = Image.FromStream(new System.IO.MemoryStream((byte[])m_DataTable.Rows[0][3]));
                    else
                        imgAvatar.BackgroundImage = Properties.Resources.defaultAvatar;
                }
            };
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Color.Gray), new Rectangle(new Point(0, 0),
                new Size(this.Width - 1, this.Height - 1)));
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
