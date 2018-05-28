using MarathonProject.INF_TOOLS;

namespace MarathonProject.Forms
{
    partial class RunnerSponsor
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
            this.butlogout = new System.Windows.Forms.Button();
            this.backbut = new System.Windows.Forms.Button();
            this.maintext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbdesc = new System.Windows.Forms.Label();
            this.lbCharityName = new System.Windows.Forms.Label();
            this.imgCharity = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumnEx1 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx2 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx3 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx4 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx5 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx6 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.butlogout);
            this.panel1.Controls.Add(this.backbut);
            this.panel1.Controls.Add(this.maintext);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 91);
            this.panel1.TabIndex = 1;
            // 
            // butlogout
            // 
            this.butlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butlogout.Location = new System.Drawing.Point(813, 32);
            this.butlogout.Name = "butlogout";
            this.butlogout.Size = new System.Drawing.Size(133, 36);
            this.butlogout.TabIndex = 13;
            this.butlogout.TabStop = false;
            this.butlogout.Text = "Выход";
            this.butlogout.UseVisualStyleBackColor = true;
            this.butlogout.Click += new System.EventHandler(this.butlogout_Click);
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
            this.maintext.Location = new System.Drawing.Point(187, 23);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(349, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "Мои спонсоры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(212, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Здесь показаны все ваши спонсоры в Marathon Skills 2018";
            // 
            // lbdesc
            // 
            this.lbdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbdesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbdesc.Location = new System.Drawing.Point(60, 520);
            this.lbdesc.Name = "lbdesc";
            this.lbdesc.Size = new System.Drawing.Size(25, 24);
            this.lbdesc.TabIndex = 47;
            this.lbdesc.Text = "...";
            // 
            // lbCharityName
            // 
            this.lbCharityName.AutoSize = true;
            this.lbCharityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCharityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCharityName.Location = new System.Drawing.Point(132, 230);
            this.lbCharityName.Name = "lbCharityName";
            this.lbCharityName.Size = new System.Drawing.Size(58, 31);
            this.lbCharityName.TabIndex = 51;
            this.lbCharityName.Text = "unk";
            this.lbCharityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgCharity
            // 
            this.imgCharity.BackColor = System.Drawing.Color.Gainsboro;
            this.imgCharity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCharity.InitialImage = null;
            this.imgCharity.Location = new System.Drawing.Point(64, 275);
            this.imgCharity.Name = "imgCharity";
            this.imgCharity.Size = new System.Drawing.Size(230, 232);
            this.imgCharity.TabIndex = 52;
            this.imgCharity.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(558, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 53;
            this.label1.Text = "Спонсор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(812, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 31);
            this.label4.TabIndex = 54;
            this.label4.Text = "Взнос";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAmount.Location = new System.Drawing.Point(752, 537);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(65, 25);
            this.lbAmount.TabIndex = 55;
            this.lbAmount.Text = "unk $";
            this.lbAmount.Visible = false;
            // 
            // splitter
            // 
            this.splitter.AutoScroll = true;
            this.splitter.BackColor = System.Drawing.Color.DimGray;
            this.splitter.Location = new System.Drawing.Point(570, 520);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(359, 5);
            this.splitter.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumnEx1
            // 
            this.dataGridViewTextBoxColumnEx1.HeaderText = "Комплект";
            this.dataGridViewTextBoxColumnEx1.Name = "dataGridViewTextBoxColumnEx1";
            this.dataGridViewTextBoxColumnEx1.ReadOnly = true;
            this.dataGridViewTextBoxColumnEx1.Width = 157;
            // 
            // dataGridViewTextBoxColumnEx2
            // 
            this.dataGridViewTextBoxColumnEx2.HeaderText = "Тип A";
            this.dataGridViewTextBoxColumnEx2.Name = "dataGridViewTextBoxColumnEx2";
            this.dataGridViewTextBoxColumnEx2.ReadOnly = true;
            this.dataGridViewTextBoxColumnEx2.Width = 156;
            // 
            // dataGridViewTextBoxColumnEx3
            // 
            this.dataGridViewTextBoxColumnEx3.HeaderText = "Тип B";
            this.dataGridViewTextBoxColumnEx3.Name = "dataGridViewTextBoxColumnEx3";
            this.dataGridViewTextBoxColumnEx3.ReadOnly = true;
            this.dataGridViewTextBoxColumnEx3.Width = 157;
            // 
            // dataGridViewTextBoxColumnEx4
            // 
            this.dataGridViewTextBoxColumnEx4.HeaderText = "Тип C";
            this.dataGridViewTextBoxColumnEx4.Name = "dataGridViewTextBoxColumnEx4";
            this.dataGridViewTextBoxColumnEx4.ReadOnly = true;
            this.dataGridViewTextBoxColumnEx4.Width = 157;
            // 
            // dataGridViewTextBoxColumnEx5
            // 
            this.dataGridViewTextBoxColumnEx5.HeaderText = "Необходимо";
            this.dataGridViewTextBoxColumnEx5.Name = "dataGridViewTextBoxColumnEx5";
            this.dataGridViewTextBoxColumnEx5.ReadOnly = true;
            this.dataGridViewTextBoxColumnEx5.Width = 156;
            // 
            // dataGridViewTextBoxColumnEx6
            // 
            this.dataGridViewTextBoxColumnEx6.HeaderText = "Остаток";
            this.dataGridViewTextBoxColumnEx6.Name = "dataGridViewTextBoxColumnEx6";
            this.dataGridViewTextBoxColumnEx6.ReadOnly = true;
            this.dataGridViewTextBoxColumnEx6.Width = 157;
            // 
            // RunnerSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgCharity);
            this.Controls.Add(this.lbCharityName);
            this.Controls.Add(this.lbdesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RunnerSponsor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - My Sponsorship";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunnerSponsor_FormClosed);
            this.Load += new System.EventHandler(this.RunnerSponsor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label maintext;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Button butlogout;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx1;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx2;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx3;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx4;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx5;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbdesc;
        private System.Windows.Forms.Label lbCharityName;
        private System.Windows.Forms.PictureBox imgCharity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Panel splitter;
    }
}