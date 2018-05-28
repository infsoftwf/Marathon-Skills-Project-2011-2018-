using MarathonProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;
using static MarathonProject.INF_TOOLS.WinAPI;

namespace MarathonProject.Forms
{
    public partial class MarathonLong : Form
    {
        Thread mainThread = null, hInitialize = null;

        SqlConnection sqlConnection = null;

        String[] SpeedArray = { "f1-car.jpg", "horse.png", "jaguar.jpg", "capybara.jpg", "sloth.jpg", "worm.jpg", "slug.jpg" };
        String[] DistanceArray = { "airbus-a380.jpg", "bus.jpg", "football-field.jpg", "ronaldinho.jpg", "pair-of-havaianas.jpg" };

        Dictionary<string, List<string>> _dataSpeed = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> _dataDistance = new Dictionary<string, List<string>>();

        public MarathonLong()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();

            this.DoubleBuffered = true;
        }

        private void ResultList_Load(object sender, EventArgs e)
        {
            _dataSpeed.Add(SpeedArray[0], new List<string> { "345km/h", Math.Round(Convert.ToDouble(42) / Convert.ToDouble(345), 2).ToString() });
            _dataSpeed.Add(SpeedArray[1], new List<string> { "15km/h", Math.Round(Convert.ToDouble(42) / Convert.ToDouble(15), 2).ToString() });
            _dataSpeed.Add(SpeedArray[2], new List<string> { "80km/h", Math.Round(Convert.ToDouble(42) / Convert.ToDouble(80), 2).ToString() });
            _dataSpeed.Add(SpeedArray[3], new List<string> { "35km/h", Math.Round(Convert.ToDouble(42) / Convert.ToDouble(35), 2).ToString() });
            _dataSpeed.Add(SpeedArray[4], new List<string> { "0.12km/h", Math.Round(Convert.ToDouble(42) / 0.12, 2).ToString() });
            _dataSpeed.Add(SpeedArray[5], new List<string> { "0.03km/h", Math.Round(Convert.ToDouble(42) / 0.03, 2).ToString() });
            _dataSpeed.Add(SpeedArray[6], new List<string> { "0.01km/h", Math.Round(Convert.ToDouble(42) / 0.01, 2).ToString() });

            _dataDistance.Add(DistanceArray[0], new List<string> { "73m", (42000 / 73).ToString() });
            _dataDistance.Add(DistanceArray[1], new List<string> { "10m", (42000 / 10).ToString() });
            _dataDistance.Add(DistanceArray[2], new List<string> { "105m", (42000 / 105).ToString() });
            _dataDistance.Add(DistanceArray[3], new List<string> { "1.81m", Math.Round(42000 / 1.81, 2).ToString() });
            _dataDistance.Add(DistanceArray[4], new List<string> { "0.245m", Math.Round(42000 / 0.245, 2).ToString() });

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

            int AutoYReserveImgBox = 11, AutoYReserveLabel = 46;

            for (int i = 0; i < SpeedArray.Count(); i++)
            {
                PictureBox tmpImgBox = new PictureBox();
                tmpImgBox.Size = new Size(116, 96);
                tmpImgBox.Location = new Point(11, AutoYReserveImgBox);
                tmpImgBox.BackgroundImage = Image.FromFile(string.Concat(g_PathLongMarathon, @"\\", SpeedArray[i]));
                tmpImgBox.BackgroundImageLayout = ImageLayout.Stretch;
                tmpImgBox.BorderStyle = BorderStyle.FixedSingle;
                tmpImgBox.Tag = i;
                tmpImgBox.Click += (_o, _e) => 
                {
                    lbHeadImg.Text = Regex.Replace(SpeedArray[(int)((PictureBox)_o).Tag], ".jpg|.png", String.Empty).ToUpper();
                    lbHeadImg.Location = new Point((MainImgBox.Size.Width / 2) - (lbHeadImg.Size.Width / 2) + 50, 176);

                    lbUnderDesc.Text = $"Максимальная скорость {lbHeadImg.Text} {_dataSpeed[SpeedArray[(int)((PictureBox)_o).Tag]][0]}.\nЭто займет {_dataSpeed[SpeedArray[(int)((PictureBox)_o).Tag]][1]}ч чтобы завершить 42km марафон.";
                    lbUnderDesc.Location = new Point((MainImgBox.Size.Width / 2) - (lbUnderDesc.Size.Width / 2) + 55, 577);

                    MainImgBox.BackgroundImage = Image.FromFile(string.Concat(g_PathLongMarathon, @"\\", SpeedArray[(int)((PictureBox)_o).Tag]));
                };
                TabInformation.TabPages["TabSpeed"].Controls.Add(tmpImgBox);

                Label tmpLbl = new Label();
                tmpLbl.AutoSize = true;
                tmpLbl.Font = new Font("Tahoma", 16f);
                tmpLbl.Location = new Point(133, AutoYReserveLabel);
                tmpLbl.Text = Regex.Replace(SpeedArray[i], ".jpg|.png", String.Empty).ToUpper();
                tmpLbl.Tag = i;

                EventHandler AutoExec = null;
                tmpLbl.Click += AutoExec = (_o, _e) =>
                {
                    lbHeadImg.Text = Regex.Replace(SpeedArray[(int)((Label)_o).Tag], ".jpg|.png", String.Empty).ToUpper();
                    lbHeadImg.Location = new Point((MainImgBox.Size.Width / 2) - (lbHeadImg.Size.Width / 2) + 50, 176);

                    lbUnderDesc.Text = $"Максимальная скорость {lbHeadImg.Text} {_dataSpeed[SpeedArray[(int)((Label)_o).Tag]][0]}.\nЭто займет {_dataSpeed[SpeedArray[(int)((Label)_o).Tag]][1]}ч чтобы завершить 42km марафон.";
                    lbUnderDesc.Location = new Point((MainImgBox.Size.Width / 2) - (lbUnderDesc.Size.Width / 2) + 55, 577);

                    MainImgBox.BackgroundImage = Image.FromFile(string.Concat(g_PathLongMarathon, @"\\", SpeedArray[(int)((Label)_o).Tag]));
                };

                TabInformation.TabPages["TabSpeed"].Controls.Add(tmpLbl);

                if (i == 0)
                    AutoExec((object)tmpLbl, null);

                AutoYReserveImgBox += 102;
                AutoYReserveLabel += 102;
            }

            AutoYReserveImgBox = 11;
            AutoYReserveLabel = 46;

            for (int i = 0; i < DistanceArray.Count(); i++)
            {
                PictureBox tmpImgBox = new PictureBox();
                tmpImgBox.Size = new Size(116, 96);
                tmpImgBox.Location = new Point(11, AutoYReserveImgBox);
                tmpImgBox.BackgroundImage = Image.FromFile(string.Concat(g_PathLongMarathon, @"\\", DistanceArray[i]));
                tmpImgBox.BackgroundImageLayout = ImageLayout.Stretch;
                tmpImgBox.BorderStyle = BorderStyle.FixedSingle;
                tmpImgBox.Tag = i;
                tmpImgBox.Click += (_o, _e) =>
                {
                    lbHeadImg.Text = Regex.Replace(DistanceArray[(int)((PictureBox)_o).Tag], ".jpg|.png", String.Empty).ToUpper();
                    lbHeadImg.Location = new Point((MainImgBox.Size.Width / 2) - (lbHeadImg.Size.Width / 2) + 50, 176);

                    lbUnderDesc.Text = $"Длина {lbHeadImg.Text} {_dataDistance[DistanceArray[(int)((PictureBox)_o).Tag]][0]}.\nЭто займет {_dataDistance[DistanceArray[(int)((PictureBox)_o).Tag]][1]} из них,\n чтобы покрыть расстояние в 42 км марафона";
                    lbUnderDesc.Location = new Point((MainImgBox.Size.Width / 2) - (lbUnderDesc.Size.Width / 2) + 55, 577);

                    MainImgBox.BackgroundImage = Image.FromFile(string.Concat(g_PathLongMarathon, @"\\", DistanceArray[(int)((PictureBox)_o).Tag]));
                };
                TabInformation.TabPages["TabDistance"].Controls.Add(tmpImgBox);

                Label tmpLbl = new Label();
                tmpLbl.AutoSize = true;
                tmpLbl.Font = new Font("Tahoma", 16f);
                tmpLbl.Location = new Point(133, AutoYReserveLabel);
                tmpLbl.Text = Regex.Replace(DistanceArray[i], ".jpg|.png", String.Empty).ToUpper();
                tmpLbl.Tag = i;
              
                tmpLbl.Click += (_o, _e) =>
                {
                    lbHeadImg.Text = Regex.Replace(DistanceArray[(int)((Label)_o).Tag], ".jpg|.png", String.Empty).ToUpper();
                    lbHeadImg.Location = new Point((MainImgBox.Size.Width / 2) - (lbHeadImg.Size.Width / 2) + 50, 176);

                    lbUnderDesc.Text = $"Длина {lbHeadImg.Text} {_dataDistance[DistanceArray[(int)((Label)_o).Tag]][0]}.\nЭто займет {_dataDistance[DistanceArray[(int)((Label)_o).Tag]][1]} из них,\n чтобы покрыть расстояние в 42 км марафона";
                    lbUnderDesc.Location = new Point((MainImgBox.Size.Width / 2) - (lbUnderDesc.Size.Width / 2) + 55, 577);

                    MainImgBox.BackgroundImage = Image.FromFile(string.Concat(g_PathLongMarathon, @"\\", DistanceArray[(int)((Label)_o).Tag]));
                };

                TabInformation.TabPages["TabDistance"].Controls.Add(tmpLbl);

                AutoYReserveImgBox += 102;
                AutoYReserveLabel += 102;
            }
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            if (hInitialize != null)
                hInitialize.Abort();

            if (mainThread != null)
                mainThread.Abort();

            Application.OpenForms.OfType<MoreInfo>().Single().Show();

            this.Dispose();
            this.Close();
        }

        private void RunnerResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }
    }
}

