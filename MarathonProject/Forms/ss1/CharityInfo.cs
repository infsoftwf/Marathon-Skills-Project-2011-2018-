using MarathonProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonProject.Forms
{
    public partial class CharityInfo : Form
    {
        public CharityInfo(String m_Name, String m_Desc, String m_Logo)
        {
            InitializeComponent();

            CharityName.Text = m_Name;
            CharityDesc.Text = m_Desc;

            imgCharity.BackgroundImage = File.Exists(m_Logo) ? Image.FromFile(m_Logo) : Resources.defaultAvatar;

            CharityName.Location = new Point((this.Size.Width - CharityName.Size.Width) / 2, 9);
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
