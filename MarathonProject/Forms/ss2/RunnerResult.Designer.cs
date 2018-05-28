namespace MarathonProject.Forms
{
    partial class RunnerResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_MarathonList = new System.Windows.Forms.Panel();
            this.lbHeadMarathon = new System.Windows.Forms.Label();
            this.lbHeadDistance = new System.Windows.Forms.Label();
            this.lbHeadTime = new System.Windows.Forms.Label();
            this.lbHeadSharedNum = new System.Windows.Forms.Label();
            this.lbHeadCat = new System.Windows.Forms.Label();
            this.btGetAllResults = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.butlogout.TabIndex = 14;
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
            this.label1.Location = new System.Drawing.Point(324, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Мои результаты\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(108, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(777, 75);
            this.label3.TabIndex = 13;
            this.label3.Text = "Это - список всех ваших прошлых результатов гонки Marathon Skills.\r\nОбщее место с" +
    "равнивает всех бегунов.\r\nМесто по категории compares runners in the same gender " +
    "and age categories.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_MarathonList
            // 
            this.pnl_MarathonList.AutoScroll = true;
            this.pnl_MarathonList.Location = new System.Drawing.Point(12, 346);
            this.pnl_MarathonList.Name = "pnl_MarathonList";
            this.pnl_MarathonList.Size = new System.Drawing.Size(943, 233);
            this.pnl_MarathonList.TabIndex = 14;
            // 
            // lbHeadMarathon
            // 
            this.lbHeadMarathon.AutoSize = true;
            this.lbHeadMarathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeadMarathon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeadMarathon.Location = new System.Drawing.Point(55, 305);
            this.lbHeadMarathon.Name = "lbHeadMarathon";
            this.lbHeadMarathon.Size = new System.Drawing.Size(107, 25);
            this.lbHeadMarathon.TabIndex = 15;
            this.lbHeadMarathon.Text = "Марафон";
            this.lbHeadMarathon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeadDistance
            // 
            this.lbHeadDistance.AutoSize = true;
            this.lbHeadDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeadDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeadDistance.Location = new System.Drawing.Point(238, 305);
            this.lbHeadDistance.Name = "lbHeadDistance";
            this.lbHeadDistance.Size = new System.Drawing.Size(120, 25);
            this.lbHeadDistance.TabIndex = 16;
            this.lbHeadDistance.Text = "Дистанция";
            this.lbHeadDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeadTime
            // 
            this.lbHeadTime.AutoSize = true;
            this.lbHeadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeadTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeadTime.Location = new System.Drawing.Point(416, 305);
            this.lbHeadTime.Name = "lbHeadTime";
            this.lbHeadTime.Size = new System.Drawing.Size(76, 25);
            this.lbHeadTime.TabIndex = 17;
            this.lbHeadTime.Text = "Время";
            this.lbHeadTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeadSharedNum
            // 
            this.lbHeadSharedNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeadSharedNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeadSharedNum.Location = new System.Drawing.Point(546, 305);
            this.lbHeadSharedNum.Name = "lbHeadSharedNum";
            this.lbHeadSharedNum.Size = new System.Drawing.Size(147, 25);
            this.lbHeadSharedNum.TabIndex = 18;
            this.lbHeadSharedNum.Text = "Общее место";
            this.lbHeadSharedNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeadCat
            // 
            this.lbHeadCat.AutoSize = true;
            this.lbHeadCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeadCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeadCat.Location = new System.Drawing.Point(733, 305);
            this.lbHeadCat.Name = "lbHeadCat";
            this.lbHeadCat.Size = new System.Drawing.Size(212, 25);
            this.lbHeadCat.TabIndex = 19;
            this.lbHeadCat.Text = "Место по категории";
            this.lbHeadCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btGetAllResults
            // 
            this.btGetAllResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGetAllResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGetAllResults.Location = new System.Drawing.Point(293, 629);
            this.btGetAllResults.Name = "btGetAllResults";
            this.btGetAllResults.Size = new System.Drawing.Size(363, 36);
            this.btGetAllResults.TabIndex = 20;
            this.btGetAllResults.TabStop = false;
            this.btGetAllResults.Text = "Показать все результаты";
            this.btGetAllResults.UseVisualStyleBackColor = true;
            this.btGetAllResults.Click += new System.EventHandler(this.btGetAllResults_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(177, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Дистанция: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(528, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Возрастная категория:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbGender.Location = new System.Drawing.Point(297, 264);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(73, 20);
            this.lbGender.TabIndex = 23;
            this.lbGender.Text = "unknown";
            this.lbGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAge.Location = new System.Drawing.Point(765, 264);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(73, 20);
            this.lbAge.TabIndex = 24;
            this.lbAge.Text = "unknown";
            this.lbAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunnerResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btGetAllResults);
            this.Controls.Add(this.lbHeadCat);
            this.Controls.Add(this.lbHeadSharedNum);
            this.Controls.Add(this.lbHeadTime);
            this.Controls.Add(this.lbHeadDistance);
            this.Controls.Add(this.lbHeadMarathon);
            this.Controls.Add(this.pnl_MarathonList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RunnerResult";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - My race results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunnerResult_FormClosed);
            this.Load += new System.EventHandler(this.ResultList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_MarathonList;
        private System.Windows.Forms.Label lbHeadMarathon;
        private System.Windows.Forms.Label lbHeadDistance;
        private System.Windows.Forms.Label lbHeadTime;
        private System.Windows.Forms.Label lbHeadSharedNum;
        private System.Windows.Forms.Label lbHeadCat;
        private System.Windows.Forms.Button butlogout;
        private System.Windows.Forms.Button btGetAllResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbAge;
    }
}