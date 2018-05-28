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
    public partial class BMRDetermine : Form
    {
        public BMRDetermine()
        {
            InitializeComponent();
        }

        private void BMRDetermine_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.TopMost = true;
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
