namespace MarathonProject.Forms
{
    partial class CharityInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharityInfo));
            this.CharityName = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.imgCharity = new System.Windows.Forms.PictureBox();
            this.CharityDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharity)).BeginInit();
            this.SuspendLayout();
            // 
            // CharityName
            // 
            this.CharityName.AutoSize = true;
            this.CharityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CharityName.Location = new System.Drawing.Point(265, 27);
            this.CharityName.Name = "CharityName";
            this.CharityName.Size = new System.Drawing.Size(102, 39);
            this.CharityName.TabIndex = 12;
            this.CharityName.Text = "Arise";
            // 
            // butExit
            // 
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(621, 12);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(25, 23);
            this.butExit.TabIndex = 13;
            this.butExit.Text = "X";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // imgCharity
            // 
            this.imgCharity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCharity.InitialImage = null;
            this.imgCharity.Location = new System.Drawing.Point(187, 87);
            this.imgCharity.Name = "imgCharity";
            this.imgCharity.Size = new System.Drawing.Size(269, 192);
            this.imgCharity.TabIndex = 37;
            this.imgCharity.TabStop = false;
            // 
            // CharityDesc
            // 
            this.CharityDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharityDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CharityDesc.Location = new System.Drawing.Point(12, 300);
            this.CharityDesc.Name = "CharityDesc";
            this.CharityDesc.Size = new System.Drawing.Size(634, 357);
            this.CharityDesc.TabIndex = 38;
            this.CharityDesc.Text = resources.GetString("CharityDesc.Text");
            // 
            // CharityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 666);
            this.Controls.Add(this.CharityDesc);
            this.Controls.Add(this.imgCharity);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.CharityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharityInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imgCharity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharityName;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.PictureBox imgCharity;
        private System.Windows.Forms.Label CharityDesc;
    }
}