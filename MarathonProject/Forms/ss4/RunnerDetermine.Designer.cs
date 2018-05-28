namespace MarathonProject.Forms.ss4
{
    partial class RunnerDetermine
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
            this.sName = new System.Windows.Forms.Label();
            this.SLast = new System.Windows.Forms.Label();
            this.SGender = new System.Windows.Forms.Label();
            this.SBirth = new System.Windows.Forms.Label();
            this.SCountry = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sName.Location = new System.Drawing.Point(197, 12);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(51, 24);
            this.sName.TabIndex = 48;
            this.sName.Text = "Имя:";
            // 
            // SLast
            // 
            this.SLast.AutoSize = true;
            this.SLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SLast.Location = new System.Drawing.Point(197, 49);
            this.SLast.Name = "SLast";
            this.SLast.Size = new System.Drawing.Size(96, 24);
            this.SLast.TabIndex = 49;
            this.SLast.Text = "Фамилия:";
            // 
            // SGender
            // 
            this.SGender.AutoSize = true;
            this.SGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SGender.Location = new System.Drawing.Point(197, 89);
            this.SGender.Name = "SGender";
            this.SGender.Size = new System.Drawing.Size(49, 24);
            this.SGender.TabIndex = 50;
            this.SGender.Text = "Пол:";
            // 
            // SBirth
            // 
            this.SBirth.AutoSize = true;
            this.SBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SBirth.Location = new System.Drawing.Point(197, 129);
            this.SBirth.Name = "SBirth";
            this.SBirth.Size = new System.Drawing.Size(155, 24);
            this.SBirth.TabIndex = 51;
            this.SBirth.Text = "Дата рождения:";
            // 
            // SCountry
            // 
            this.SCountry.AutoSize = true;
            this.SCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SCountry.Location = new System.Drawing.Point(197, 166);
            this.SCountry.Name = "SCountry";
            this.SCountry.Size = new System.Drawing.Size(80, 24);
            this.SCountry.TabIndex = 52;
            this.SCountry.Text = "Страна:";
            // 
            // butExit
            // 
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(568, 4);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(25, 23);
            this.butExit.TabIndex = 53;
            this.butExit.Text = "X";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAvatar.Location = new System.Drawing.Point(15, 13);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(175, 178);
            this.imgAvatar.TabIndex = 0;
            this.imgAvatar.TabStop = false;
            // 
            // RunnerDetermine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 204);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.SCountry);
            this.Controls.Add(this.SBirth);
            this.Controls.Add(this.SGender);
            this.Controls.Add(this.SLast);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.imgAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RunnerDetermine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RunnerDetermine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.Label SLast;
        private System.Windows.Forms.Label SGender;
        private System.Windows.Forms.Label SBirth;
        private System.Windows.Forms.Label SCountry;
        private System.Windows.Forms.Button butExit;
    }
}