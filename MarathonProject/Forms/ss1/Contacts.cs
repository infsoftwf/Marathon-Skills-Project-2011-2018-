using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonProject.Forms
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Color.Gray), new Rectangle(new Point(0, 0),
                new Size(this.Width - 1, this.Height - 1)));
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            //Application.OpenForms.OfType<RunnerMenu>().Single().Show();

            this.Dispose();
            this.Close();
        }
    }
}
