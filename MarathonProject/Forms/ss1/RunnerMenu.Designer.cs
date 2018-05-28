namespace MarathonProject.Forms
{
    partial class RunnerMenu
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
            this.btGetRegisterMarathon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btGetEditProfile = new System.Windows.Forms.Button();
            this.butContacts = new System.Windows.Forms.Button();
            this.btSponsor = new System.Windows.Forms.Button();
            this.btGetResult = new System.Windows.Forms.Button();
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
            this.butlogout.TabIndex = 12;
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
            // btGetRegisterMarathon
            // 
            this.btGetRegisterMarathon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGetRegisterMarathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGetRegisterMarathon.Location = new System.Drawing.Point(182, 233);
            this.btGetRegisterMarathon.Name = "btGetRegisterMarathon";
            this.btGetRegisterMarathon.Size = new System.Drawing.Size(271, 92);
            this.btGetRegisterMarathon.TabIndex = 38;
            this.btGetRegisterMarathon.TabStop = false;
            this.btGetRegisterMarathon.Text = "Регистрация на марафон\r\n";
            this.btGetRegisterMarathon.UseVisualStyleBackColor = true;
            this.btGetRegisterMarathon.Click += new System.EventHandler(this.btGetRegisterMarathon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(360, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 78);
            this.label1.TabIndex = 11;
            this.label1.Text = "Меню бегуна\r\n\r\n";
            // 
            // btGetEditProfile
            // 
            this.btGetEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGetEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGetEditProfile.Location = new System.Drawing.Point(182, 347);
            this.btGetEditProfile.Name = "btGetEditProfile";
            this.btGetEditProfile.Size = new System.Drawing.Size(271, 92);
            this.btGetEditProfile.TabIndex = 39;
            this.btGetEditProfile.TabStop = false;
            this.btGetEditProfile.Text = "Редактирование профиля\r\n";
            this.btGetEditProfile.UseVisualStyleBackColor = true;
            this.btGetEditProfile.Click += new System.EventHandler(this.btGetEditProfile_Click);
            // 
            // butContacts
            // 
            this.butContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butContacts.Location = new System.Drawing.Point(182, 461);
            this.butContacts.Name = "butContacts";
            this.butContacts.Size = new System.Drawing.Size(271, 92);
            this.butContacts.TabIndex = 40;
            this.butContacts.TabStop = false;
            this.butContacts.Text = "Контакты";
            this.butContacts.UseVisualStyleBackColor = true;
            this.butContacts.Click += new System.EventHandler(this.butContacts_Click);
            // 
            // btSponsor
            // 
            this.btSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSponsor.Location = new System.Drawing.Point(479, 347);
            this.btSponsor.Name = "btSponsor";
            this.btSponsor.Size = new System.Drawing.Size(271, 92);
            this.btSponsor.TabIndex = 42;
            this.btSponsor.TabStop = false;
            this.btSponsor.Text = "Мой спонсор\r\n";
            this.btSponsor.UseVisualStyleBackColor = true;
            this.btSponsor.Click += new System.EventHandler(this.btSponsor_Click);
            // 
            // btGetResult
            // 
            this.btGetResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGetResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGetResult.Location = new System.Drawing.Point(479, 233);
            this.btGetResult.Name = "btGetResult";
            this.btGetResult.Size = new System.Drawing.Size(271, 92);
            this.btGetResult.TabIndex = 41;
            this.btGetResult.TabStop = false;
            this.btGetResult.Text = "Мои результаты\r\n";
            this.btGetResult.UseVisualStyleBackColor = true;
            this.btGetResult.Click += new System.EventHandler(this.btGetResult_Click);
            // 
            // RunnerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.btSponsor);
            this.Controls.Add(this.btGetResult);
            this.Controls.Add(this.butContacts);
            this.Controls.Add(this.btGetEditProfile);
            this.Controls.Add(this.btGetRegisterMarathon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RunnerMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - Runner menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunnerMenu_FormClosed);
            this.Load += new System.EventHandler(this.RunnerMenu_Load);
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
        private System.Windows.Forms.Button btGetRegisterMarathon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGetEditProfile;
        private System.Windows.Forms.Button butContacts;
        private System.Windows.Forms.Button btSponsor;
        private System.Windows.Forms.Button btGetResult;
        private System.Windows.Forms.Button butlogout;
    }
}