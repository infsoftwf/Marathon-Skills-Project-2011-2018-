namespace MarathonProject.Forms
{
    partial class MarathonLong
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
            this.label1 = new System.Windows.Forms.Label();
            this.TabInformation = new System.Windows.Forms.TabControl();
            this.tabSpeed = new System.Windows.Forms.TabPage();
            this.tabDistance = new System.Windows.Forms.TabPage();
            this.MainImgBox = new System.Windows.Forms.PictureBox();
            this.lbHeadImg = new System.Windows.Forms.Label();
            this.lbUnderDesc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImgBox)).BeginInit();
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
            this.maintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maintext.ForeColor = System.Drawing.Color.White;
            this.maintext.Location = new System.Drawing.Point(187, 24);
            this.maintext.Name = "maintext";
            this.maintext.Size = new System.Drawing.Size(482, 42);
            this.maintext.TabIndex = 0;
            this.maintext.Text = "MARATHON SKILLS 2018";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(247, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Насколько долгий марафон";
            // 
            // TabInformation
            // 
            this.TabInformation.Controls.Add(this.tabSpeed);
            this.TabInformation.Controls.Add(this.tabDistance);
            this.TabInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabInformation.Location = new System.Drawing.Point(552, 182);
            this.TabInformation.Name = "TabInformation";
            this.TabInformation.SelectedIndex = 0;
            this.TabInformation.Size = new System.Drawing.Size(396, 482);
            this.TabInformation.TabIndex = 14;
            // 
            // tabSpeed
            // 
            this.tabSpeed.AutoScroll = true;
            this.tabSpeed.Location = new System.Drawing.Point(4, 29);
            this.tabSpeed.Name = "tabSpeed";
            this.tabSpeed.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpeed.Size = new System.Drawing.Size(388, 449);
            this.tabSpeed.TabIndex = 0;
            this.tabSpeed.Text = "Скорость";
            this.tabSpeed.UseVisualStyleBackColor = true;
            // 
            // tabDistance
            // 
            this.tabDistance.AutoScroll = true;
            this.tabDistance.Location = new System.Drawing.Point(4, 29);
            this.tabDistance.Name = "tabDistance";
            this.tabDistance.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistance.Size = new System.Drawing.Size(388, 449);
            this.tabDistance.TabIndex = 1;
            this.tabDistance.Text = "Дистанция";
            this.tabDistance.UseVisualStyleBackColor = true;
            // 
            // MainImgBox
            // 
            this.MainImgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainImgBox.Location = new System.Drawing.Point(61, 222);
            this.MainImgBox.Name = "MainImgBox";
            this.MainImgBox.Size = new System.Drawing.Size(425, 343);
            this.MainImgBox.TabIndex = 15;
            this.MainImgBox.TabStop = false;
            // 
            // lbHeadImg
            // 
            this.lbHeadImg.AutoSize = true;
            this.lbHeadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeadImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeadImg.Location = new System.Drawing.Point(228, 176);
            this.lbHeadImg.Name = "lbHeadImg";
            this.lbHeadImg.Size = new System.Drawing.Size(73, 39);
            this.lbHeadImg.TabIndex = 16;
            this.lbHeadImg.Text = "unk";
            // 
            // lbUnderDesc
            // 
            this.lbUnderDesc.AutoSize = true;
            this.lbUnderDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUnderDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUnderDesc.Location = new System.Drawing.Point(66, 577);
            this.lbUnderDesc.Name = "lbUnderDesc";
            this.lbUnderDesc.Size = new System.Drawing.Size(35, 20);
            this.lbUnderDesc.TabIndex = 17;
            this.lbUnderDesc.Text = "unk";
            this.lbUnderDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarathonLong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.lbUnderDesc);
            this.Controls.Add(this.lbHeadImg);
            this.Controls.Add(this.MainImgBox);
            this.Controls.Add(this.TabInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MarathonLong";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - How long is a marathon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunnerResult_FormClosed);
            this.Load += new System.EventHandler(this.ResultList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label maintext;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabInformation;
        private System.Windows.Forms.TabPage tabSpeed;
        private System.Windows.Forms.TabPage tabDistance;
        private System.Windows.Forms.PictureBox MainImgBox;
        private System.Windows.Forms.Label lbHeadImg;
        private System.Windows.Forms.Label lbUnderDesc;
    }
}