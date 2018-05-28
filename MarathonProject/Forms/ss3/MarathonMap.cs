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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.Global.globals;
using static MarathonProject.Global.SqlEx;
using static MarathonProject.INF_TOOLS.WinAPI;
using static MarathonProject.INF_TOOLS.INFAPI;

namespace MarathonProject.Forms
{
    public partial class MarathonMap : Form
    {
        Thread mainThread = null;

        SqlConnection sqlConnection = null;

        public MarathonMap()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(cSQLLSPTR);

            sqlConnection.Open();
        }

        private void MarathonMap_Load(object sender, EventArgs e)
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

            mainThread = null;
            sqlConnection = null;

            Application.OpenForms.OfType<MarathonInfo>().Single().Show();

            this.Dispose(true);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            this.Close();
        }

        private void backbut_Click(object sender, EventArgs e) => methodExit();

        private void CharityList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainThread != null)
                mainThread.Abort();

            Process.GetCurrentProcess().Kill();
        }

        public struct cImg
        {
            public String lpDesc;
            public String lpPath;
        }

        private void MainMap_Click(object sender, EventArgs e)
        {
            Tuple<string, string, List<cImg>> map_Map = null;
            int AutoYImgBox = 235;

            if (IsInBox(229, 150, 56, 55))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                      "Race Start",
                      "42km Full Marathon",
                      null
                );

                lbLandMarkName.Visible = lbSericeHead.Visible = false;
            }

            if (IsInBox(382, 597, 56, 55))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                      "Race Start",
                      "21km Half Marathon",
                      null
                );

                lbLandMarkName.Visible = lbSericeHead.Visible = false;
            }

            if (IsInBox(74, 341, 56, 55))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                      "Race Start",
                      "5km Fun Run",
                      null
                );

                lbLandMarkName.Visible = lbSericeHead.Visible = false;
            }

            if (IsInBox(358, 137, 45, 45))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                    "Checkpoint 1",
                    "Avenida Rudge",
                    new List<cImg>
                    {
                        new cImg
                        {
                            lpDesc = "Drinks",
                            lpPath = "map-icon-drinks.png"
                        },
                        new cImg
                        {
                            lpDesc = "Energy Bars",
                            lpPath = "map-icon-energy-bars.png"
                        }
                    }
                 );
            }
            if (IsInBox(423, 292, 45, 45))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                    "Checkpoint 2",
                    "Theatro Municipal",
                    new List<cImg>
                    {
                        new cImg
                        {
                            lpDesc = "Drinks",
                            lpPath = "map-icon-drinks.png"
                        },
                        new cImg
                        {
                            lpDesc = "Energy Bars",
                            lpPath = "map-icon-energy-bars.png"
                        },
                        new cImg
                        {
                            lpDesc = "Toilets",
                            lpPath = "map-icon-toilets.png"
                        },
                        new cImg
                        {
                            lpDesc = "Information",
                            lpPath = "map-icon-information.png"
                        },
                        new cImg
                        {
                            lpDesc = "Medical",
                            lpPath = "map-icon-medical.png"
                        }
                    }
                 );
            }

            if (IsInBox(409, 401, 45, 45))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                    "Checkpoint 3",
                    "Parque do Ibirapuera",
                    new List<cImg>
                    {
                        new cImg
                        {
                            lpDesc = "Drinks",
                            lpPath = "map-icon-drinks.png"
                        },
                        new cImg
                        {
                            lpDesc = "Energy Bars",
                            lpPath = "map-icon-energy-bars.png"
                        },
                        new cImg
                        {
                            lpDesc = "Toilets",
                            lpPath = "map-icon-toilets.png"
                        }
                    }
                 );
            }

            if (IsInBox(550, 522, 45, 45))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                    "Checkpoint 4",
                    "Jardim Luzitania",
                    new List<cImg>
                    {
                        new cImg
                        {
                            lpDesc = "Drinks",
                            lpPath = "map-icon-drinks.png"
                        },
                        new cImg
                        {
                            lpDesc = "Energy Bars",
                            lpPath = "map-icon-energy-bars.png"
                        },
                        new cImg
                        {
                            lpDesc = "Toilets",
                            lpPath = "map-icon-toilets.png"
                        },
                        new cImg
                        {
                            lpDesc = "Medical",
                            lpPath = "map-icon-medical.png"
                        }
                    }
                 );
            }

            if (IsInBox(326, 599, 45, 45))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                    "Checkpoint 5",
                    "Iguatemi",
                    new List<cImg>
                    {
                        new cImg
                        {
                            lpDesc = "Drinks",
                            lpPath = "map-icon-drinks.png"
                        },
                        new cImg
                        {
                            lpDesc = "Energy Bars",
                            lpPath = "map-icon-energy-bars.png"
                        },
                        new cImg
                        {
                            lpDesc = "Toilets",
                            lpPath = "map-icon-toilets.png"
                        },
                        new cImg
                        {
                            lpDesc = "Information",
                            lpPath = "map-icon-information.png"
                        }
                    }
                 );
            }

            if (IsInBox(146, 543, 45, 45))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                    "Checkpoint 6",
                    "Rua Lisboa",
                    new List<cImg>
                    {
                        new cImg
                        {
                            lpDesc = "Drinks",
                            lpPath = "map-icon-drinks.png"
                        },
                        new cImg
                        {
                            lpDesc = "Energy Bars",
                            lpPath = "map-icon-energy-bars.png"
                        },
                        new cImg
                        {
                            lpDesc = "Toilets",
                            lpPath = "map-icon-toilets.png"
                        }
                    }
                 );
            }

            if (IsInBox(92, 448, 45, 45))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                    "Checkpoint 7",
                    "Cemitério da Consolação",
                    new List<cImg>
                    {
                        new cImg
                        {
                            lpDesc = "Drinks",
                            lpPath = "map-icon-drinks.png"
                        },
                        new cImg
                        {
                            lpDesc = "Energy Bars",
                            lpPath = "map-icon-energy-bars.png"
                        },
                        new cImg
                        {
                            lpDesc = "Toilets",
                            lpPath = "map-icon-toilets.png"
                        },
                        new cImg
                        {
                            lpDesc = "Information",
                            lpPath = "map-icon-information.png"
                        },
                        new cImg
                        {
                            lpDesc = "Medical",
                            lpPath = "map-icon-medical.png"
                        }
                    }
                 );
            }

            if (IsInBox(77, 287, 45, 45))
            {
                map_Map = new Tuple<string, string, List<cImg>>
                (
                    "Checkpoint 8",
                    "Cemitério da Consolação",
                    new List<cImg>
                    {
                        new cImg
                        {
                            lpDesc = "Drinks",
                            lpPath = "map-icon-drinks.png"
                        },
                        new cImg
                        {
                            lpDesc = "Energy Bars",
                            lpPath = "map-icon-energy-bars.png"
                        },
                        new cImg
                        {
                            lpDesc = "Toilets",
                            lpPath = "map-icon-toilets.png"
                        },
                        new cImg
                        {
                            lpDesc = "Information",
                            lpPath = "map-icon-information.png"
                        },
                        new cImg
                        {
                            lpDesc = "Medical",
                            lpPath = "map-icon-medical.png"
                        }
                    }
                 );
            }

            if (map_Map == null)
                return;

            if (map_Map.Item3 != null ? lbChkp.Text.Equals(map_Map.Item1) : lbTmp.Text.Equals(map_Map.Item2))
            {
                map_Map = null;
                return;
            }

            lbChkp.Text = map_Map.Item1;

            if (map_Map.Item3 != null)
            { 
                lbTmp.Text = "Landmark:";
                lbLandMarkName.Text = map_Map.Item2;
            }
            else
                lbTmp.Text = map_Map.Item2;

            var itemsToRemoveBox = new List<PictureBox>();

            foreach (var pb in panelInfo.Controls.OfType<PictureBox>())
                itemsToRemoveBox.Add(pb);

            foreach (var pb in itemsToRemoveBox)
            {
                panelInfo.Controls.Remove(pb);
                pb.Dispose();
            }

            var itemsToRemove = new List<Label>();

            foreach (var lb in panelInfo.Controls.OfType<Label>().Where(x => x.Tag != null && x.Tag.ToString() == "__forceinline"))
                itemsToRemove.Add(lb);

            foreach (var lb in itemsToRemove)
            {
                panelInfo.Controls.Remove(lb);
                lb.Dispose();
            }

            if (map_Map.Item3 != null && map_Map.Item3.Count > 0)
            {
                lbLandMarkName.Visible = lbSericeHead.Visible = true;

                for (int i = 0; i < map_Map.Item3.Count; i++)
                {
                    PictureBox tmpImgBox = new PictureBox();
                    tmpImgBox.Size = new Size(69, 52);
                    tmpImgBox.Location = new Point(21, AutoYImgBox);
                    tmpImgBox.BackgroundImage = Image.FromFile(string.Concat(g_PathMapIcons, @"\\", map_Map.Item3[i].lpPath));
                    tmpImgBox.BackgroundImageLayout = ImageLayout.Zoom;
                    SetWindowRgn(tmpImgBox.Handle, CreateEllipticRgn(0, 0, tmpImgBox.Width, tmpImgBox.Height), true);
                    panelInfo.Controls.Add(tmpImgBox);

                    Label tmpLbCharityHead = new Label();
                    tmpLbCharityHead.AutoSize = true;
                    tmpLbCharityHead.Font = new Font("Tahoma", 16f);
                    tmpLbCharityHead.Location = new Point(92, AutoYImgBox + 12);
                    tmpLbCharityHead.Text = map_Map.Item3[i].lpDesc;
                    tmpLbCharityHead.Tag = "__forceinline";
                    panelInfo.Controls.Add(tmpLbCharityHead);

                    AutoYImgBox += 58;
                }
            }
            map_Map = null;
            itemsToRemove.Clear();
            itemsToRemoveBox.Clear();
            GC.Collect();

            panelInfo.Visible = true;
        }

        private void lbCloseInfo_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;

            lbChkp.Text = lbLandMarkName.Text = "unknown";

            var itemsToRemoveBox = new List<PictureBox>();

            foreach (var pb in panelInfo.Controls.OfType<PictureBox>())
                itemsToRemoveBox.Add(pb);

            foreach (var pb in itemsToRemoveBox)
            {
                panelInfo.Controls.Remove(pb);
                pb.Dispose();
            }

            var itemsToRemove = new List<Label>();

            foreach (var lb in panelInfo.Controls.OfType<Label>().Where(x => x.Tag != null && x.Tag.ToString() == "__forceinline"))
                itemsToRemove.Add(lb);

            foreach (var lb in itemsToRemove)
            {
                panelInfo.Controls.Remove(lb);
                lb.Dispose();
            }

            itemsToRemoveBox.Clear();
            itemsToRemove.Clear();
            GC.Collect();
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray), new Rectangle(new Point(0, 0),
                new Size(panelInfo.Width - 1, panelInfo.Height - 1)));
        }
    }
}

