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
    public partial class REmailDetermine : Form
    {
        public REmailDetermine(DataTable m_Email)
        {
            InitializeComponent();

            if (m_Email == null)
            {
                MessageBox.Show(this, "UnknownData[DataTable]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Dispose();
                this.Close();
            }

            DataGrid.DataSource = m_Email;
            DataGrid.CurrentCell = null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Color.Gray), new Rectangle(new Point(0, 0),
                new Size(this.Width - 1, this.Height - 1)));
        }

        private void REmailDetermine_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.TopMost = true;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
