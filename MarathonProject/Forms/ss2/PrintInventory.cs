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
    public partial class PrintInventory : Form
    {
        Dictionary<Char, List<String>> _dataTypes = new Dictionary<Char, List<String>>();
        Dictionary<String, List<int>> m_mapKits = null;

        public PrintInventory(Dictionary<String, List<int>> m_map)
        {
            m_mapKits = m_map;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Color.Gray), new Rectangle(new Point(0, 0),
                new Size(this.Width - 1, this.Height - 1)));
        }

        private void PrintInventory_Load(object sender, EventArgs e)
        {
            _dataTypes.Add('A', new List<string> { "Номер", "RFID бр-т" });
            _dataTypes.Add('B', new List<string> { "Бейсболка", "Бут.Воды" });
            _dataTypes.Add('C', new List<string> { "Футболка", "Сув.букл" });

            DataInventory.EnableHeadersVisualStyles = false;
            DataInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.LightGreen;
            DataInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

            DataInventory.Rows.Add(_dataTypes['A'][0]);//2
            DataInventory.Rows.Add(_dataTypes['A'][1]);//3
            DataInventory.Rows.Add(_dataTypes['B'][0]);//4
            DataInventory.Rows.Add(_dataTypes['B'][1]);//5
            DataInventory.Rows.Add(_dataTypes['C'][0]);//6
            DataInventory.Rows.Add(_dataTypes['C'][1]);//7

            DataInventory[1, 0].Value = m_mapKits[_dataTypes['A'][0]][1];
            DataInventory[2, 0].Value = m_mapKits[_dataTypes['A'][0]][0];
            DataInventory[3, 0].Value = m_mapKits[_dataTypes['A'][0]][2];

            DataInventory[1, 1].Value = m_mapKits[_dataTypes['A'][1]][1];
            DataInventory[2, 1].Value = m_mapKits[_dataTypes['A'][1]][0];
            DataInventory[3, 1].Value = m_mapKits[_dataTypes['A'][1]][2];


            DataInventory[1, 2].Value = m_mapKits[_dataTypes['B'][0]][1];
            DataInventory[2, 2].Value = m_mapKits[_dataTypes['B'][0]][0];
            DataInventory[3, 2].Value = m_mapKits[_dataTypes['B'][0]][2];

            DataInventory[1, 3].Value = m_mapKits[_dataTypes['B'][1]][1];
            DataInventory[2, 3].Value = m_mapKits[_dataTypes['B'][1]][0];
            DataInventory[3, 3].Value = m_mapKits[_dataTypes['B'][1]][2];


            DataInventory[1, 4].Value = m_mapKits[_dataTypes['C'][0]][1];
            DataInventory[2, 4].Value = m_mapKits[_dataTypes['C'][0]][0];
            DataInventory[3, 4].Value = m_mapKits[_dataTypes['C'][0]][2];

            DataInventory[1, 5].Value = m_mapKits[_dataTypes['C'][1]][1];
            DataInventory[2, 5].Value = m_mapKits[_dataTypes['C'][1]][0];
            DataInventory[3, 5].Value = m_mapKits[_dataTypes['C'][1]][2];

            DataInventory.CurrentCell = null;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        Bitmap m_bmpImage = null;

        private void btPrint_Click(object sender, EventArgs e)
        {
            m_bmpImage = new Bitmap(DataInventory.Width, DataInventory.Height);
            DataInventory.DrawToBitmap(m_bmpImage, new Rectangle(0, 0, DataInventory.Width, DataInventory.Height));
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) => 
            e.Graphics.DrawImage(m_bmpImage, 0, 0);
    }
}
