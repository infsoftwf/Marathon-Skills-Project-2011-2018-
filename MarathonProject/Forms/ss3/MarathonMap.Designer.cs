namespace MarathonProject.Forms
{
    partial class MarathonMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbut = new System.Windows.Forms.Button();
            this.maintext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.MainMap = new System.Windows.Forms.PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lbSericeHead = new System.Windows.Forms.Label();
            this.lbLandMarkName = new System.Windows.Forms.Label();
            this.lbCloseInfo = new System.Windows.Forms.Label();
            this.lbChkp = new System.Windows.Forms.Label();
            this.lbTmp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMap)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.backbut);
            this.panel1.Controls.Add(this.maintext);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 91);
            this.panel1.TabIndex = 1;
            // 
            // backbut
            // 
            this.backbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backbut.Location = new System.Drawing.Point(24, 27);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(133, 36);
            this.backbut.TabIndex = 11;
            this.backbut.TabStop = false;
            this.backbut.Text = "Назад";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // maintext
            // 
            this.maintext.AutoSize = true;
            this.maintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maintext.ForeColor = System.Drawing.Color.White;
            this.maintext.Location = new System.Drawing.Point(187, 29);
            this.maintext.Name = "maintext";
            this.maintext.Size = new System.Drawing.Size(721, 31);
            this.maintext.TabIndex = 0;
            this.maintext.Text = "ИНТЕРАКТИВНАЯ КАРТА MARATHON SKILLS 2018";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lbEndTime);
            this.panel2.Location = new System.Drawing.Point(-2, 694);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 62);
            this.panel2.TabIndex = 10;
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEndTime.ForeColor = System.Drawing.Color.White;
            this.lbEndTime.Location = new System.Drawing.Point(269, 16);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(281, 29);
            this.lbEndTime.TabIndex = 0;
            this.lbEndTime.Text = "До старта марафона: \r\n";
            this.lbEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMap
            // 
            this.MainMap.BackgroundImage = global::MarathonProject.Properties.Resources.map;
            this.MainMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMap.Location = new System.Drawing.Point(12, 115);
            this.MainMap.Name = "MainMap";
            this.MainMap.Size = new System.Drawing.Size(620, 540);
            this.MainMap.TabIndex = 11;
            this.MainMap.TabStop = false;
            this.MainMap.Click += new System.EventHandler(this.MainMap_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.DarkGray;
            this.panelInfo.Controls.Add(this.lbSericeHead);
            this.panelInfo.Controls.Add(this.lbLandMarkName);
            this.panelInfo.Controls.Add(this.lbCloseInfo);
            this.panelInfo.Controls.Add(this.lbChkp);
            this.panelInfo.Controls.Add(this.lbTmp);
            this.panelInfo.Location = new System.Drawing.Point(638, 115);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(304, 540);
            this.panelInfo.TabIndex = 13;
            this.panelInfo.Visible = false;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfo_Paint);
            // 
            // lbSericeHead
            // 
            this.lbSericeHead.AutoSize = true;
            this.lbSericeHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSericeHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSericeHead.Location = new System.Drawing.Point(27, 188);
            this.lbSericeHead.Name = "lbSericeHead";
            this.lbSericeHead.Size = new System.Drawing.Size(198, 25);
            this.lbSericeHead.TabIndex = 15;
            this.lbSericeHead.Text = "Service Provided:";
            // 
            // lbLandMarkName
            // 
            this.lbLandMarkName.AutoSize = true;
            this.lbLandMarkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLandMarkName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLandMarkName.Location = new System.Drawing.Point(27, 138);
            this.lbLandMarkName.Name = "lbLandMarkName";
            this.lbLandMarkName.Size = new System.Drawing.Size(98, 25);
            this.lbLandMarkName.TabIndex = 14;
            this.lbLandMarkName.Text = "unknown";
            // 
            // lbCloseInfo
            // 
            this.lbCloseInfo.AutoSize = true;
            this.lbCloseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCloseInfo.ForeColor = System.Drawing.Color.Red;
            this.lbCloseInfo.Location = new System.Drawing.Point(278, 6);
            this.lbCloseInfo.Name = "lbCloseInfo";
            this.lbCloseInfo.Size = new System.Drawing.Size(19, 18);
            this.lbCloseInfo.TabIndex = 0;
            this.lbCloseInfo.Text = "X";
            this.lbCloseInfo.Click += new System.EventHandler(this.lbCloseInfo_Click);
            // 
            // lbChkp
            // 
            this.lbChkp.AutoSize = true;
            this.lbChkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChkp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbChkp.Location = new System.Drawing.Point(26, 32);
            this.lbChkp.Name = "lbChkp";
            this.lbChkp.Size = new System.Drawing.Size(130, 31);
            this.lbChkp.TabIndex = 12;
            this.lbChkp.Text = "unknown";
            // 
            // lbTmp
            // 
            this.lbTmp.AutoSize = true;
            this.lbTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTmp.Location = new System.Drawing.Point(27, 91);
            this.lbTmp.Name = "lbTmp";
            this.lbTmp.Size = new System.Drawing.Size(122, 25);
            this.lbTmp.TabIndex = 13;
            this.lbTmp.Text = "Landmark:";
            // 
            // MarathonMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.MainMap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MarathonMap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - Interactive map";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CharityList_FormClosed);
            this.Load += new System.EventHandler(this.MarathonMap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMap)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label maintext;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.PictureBox MainMap;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lbCloseInfo;
        private System.Windows.Forms.Label lbSericeHead;
        private System.Windows.Forms.Label lbLandMarkName;
        private System.Windows.Forms.Label lbTmp;
        private System.Windows.Forms.Label lbChkp;
    }
}