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
    public partial class Token : Form
    {
        private String m_pRunnerId = String.Empty;
        SqlConnection sqlConnection = null;

        public Token(String RunnerId)
        {
            InitializeComponent();

            m_pRunnerId = RunnerId;

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void Token_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.TopMost = true;

            toolTip1.SetToolTip(lbCharName, "Благотворительная организация");
            toolTip1.SetToolTip(lbEvType, "Типы забегов");

            using (var isqldat = new SqlDataAdapter($@"SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.Country.CountryName, dbo.Country.CountryFlag, dbo.Charity.CharityName, dbo.Runner.Image
                         FROM dbo.Runner INNER JOIN
                         dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN
                         dbo.Charity ON dbo.Registration.CharityId = dbo.Charity.CharityId INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode
                         WHERE(dbo.Runner.Email = '{m_pRunnerId}')", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                if (m_DataTable.Rows.Count == 0)
                {
                    MessageBox.Show(this, "Fatal Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Dispose();
                    this.Close();
                }

                lbFLName.Text = string.Concat(m_DataTable.Rows[0][0], " ", m_DataTable.Rows[0][1]);
                lbCharName.Text = m_DataTable.Rows[0][4].ToString();
                imgCon.BackgroundImage = Image.FromFile(string.Concat(g_PathFlags, @"\\", m_DataTable.Rows[0][3]));
                lbCountryName.Text = m_DataTable.Rows[0][2].ToString();

                if (m_DataTable.Rows[0][5].ToString().Length != 0)
                    imgAvatar.BackgroundImage = Image.FromStream(new System.IO.MemoryStream((byte[])m_DataTable.Rows[0][5]));
            }

            using (var isqldat = new SqlDataAdapter($@"SELECT dbo.EventType.EventTypeName
                         FROM dbo.Runner INNER JOIN
                         dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN
                         dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN
                         dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN
                         dbo.Event ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN
                         dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId
                         WHERE(dbo.Runner.Email = '{m_pRunnerId}')", sqlConnection))
            {
                var m_DataTable = new DataTable();
                isqldat.Fill(m_DataTable);

                if (m_DataTable.Rows.Count == 0)
                {
                    MessageBox.Show(this, "Fatal Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Dispose();
                    this.Close();
                }

                lbEvType.Text = null;

                for (int i = 0; i < m_DataTable.Rows.Count; i++ )
                {
                    if (i == 5)
                    {
                        lbEvType.Text = "...";
                        break;
                    }
                    lbEvType.Text = string.Concat(lbEvType.Text, m_DataTable.Rows[i][0].ToString() + "\n");
                }          
            }
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
