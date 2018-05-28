namespace MarathonProject.Forms.ss4
{
    partial class Token
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
            this.components = new System.ComponentModel.Container();
            this.butExit = new System.Windows.Forms.Button();
            this.lbFLName = new System.Windows.Forms.Label();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.imgCon = new System.Windows.Forms.PictureBox();
            this.lbCountryName = new System.Windows.Forms.Label();
            this.lbCharName = new System.Windows.Forms.Label();
            this.lbEvType = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCon)).BeginInit();
            this.SuspendLayout();
            // 
            // butExit
            // 
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(601, 4);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(25, 23);
            this.butExit.TabIndex = 53;
            this.butExit.Text = "X";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // lbFLName
            // 
            this.lbFLName.AutoSize = true;
            this.lbFLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFLName.ForeColor = System.Drawing.Color.Black;
            this.lbFLName.Location = new System.Drawing.Point(248, 42);
            this.lbFLName.Name = "lbFLName";
            this.lbFLName.Size = new System.Drawing.Size(143, 24);
            this.lbFLName.TabIndex = 76;
            this.lbFLName.Text = "Имя Фамилия";
            this.lbFLName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackgroundImage = global::MarathonProject.Properties.Resources.defaultAvatar;
            this.imgAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgAvatar.Location = new System.Drawing.Point(12, 12);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(209, 240);
            this.imgAvatar.TabIndex = 77;
            this.imgAvatar.TabStop = false;
            // 
            // imgCon
            // 
            this.imgCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCon.Location = new System.Drawing.Point(12, 258);
            this.imgCon.Name = "imgCon";
            this.imgCon.Size = new System.Drawing.Size(41, 35);
            this.imgCon.TabIndex = 78;
            this.imgCon.TabStop = false;
            // 
            // lbCountryName
            // 
            this.lbCountryName.AutoSize = true;
            this.lbCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCountryName.Location = new System.Drawing.Point(59, 265);
            this.lbCountryName.Name = "lbCountryName";
            this.lbCountryName.Size = new System.Drawing.Size(75, 24);
            this.lbCountryName.TabIndex = 79;
            this.lbCountryName.Text = "Country";
            // 
            // lbCharName
            // 
            this.lbCharName.AutoSize = true;
            this.lbCharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCharName.ForeColor = System.Drawing.Color.Black;
            this.lbCharName.Location = new System.Drawing.Point(248, 83);
            this.lbCharName.Name = "lbCharName";
            this.lbCharName.Size = new System.Drawing.Size(339, 24);
            this.lbCharName.TabIndex = 80;
            this.lbCharName.Text = "Благотворительная организация";
            this.lbCharName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEvType
            // 
            this.lbEvType.AutoSize = true;
            this.lbEvType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEvType.ForeColor = System.Drawing.Color.Black;
            this.lbEvType.Location = new System.Drawing.Point(248, 127);
            this.lbEvType.Name = "lbEvType";
            this.lbEvType.Size = new System.Drawing.Size(133, 24);
            this.lbEvType.TabIndex = 81;
            this.lbEvType.Text = "Тип забегов";
            this.lbEvType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Token
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 310);
            this.Controls.Add(this.lbEvType);
            this.Controls.Add(this.lbCharName);
            this.Controls.Add(this.lbCountryName);
            this.Controls.Add(this.imgCon);
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.lbFLName);
            this.Controls.Add(this.butExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Token";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Token_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label lbFLName;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.PictureBox imgCon;
        private System.Windows.Forms.Label lbCountryName;
        private System.Windows.Forms.Label lbCharName;
        private System.Windows.Forms.Label lbEvType;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}