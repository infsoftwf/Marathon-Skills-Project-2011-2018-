namespace MarathonProject.Forms
{
    partial class AddEditCharity
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
            this.bSaveEdit = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.imgChar = new System.Windows.Forms.PictureBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butimgload = new System.Windows.Forms.Button();
            this.txFileImgChar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChar)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(201, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 78);
            this.label1.TabIndex = 11;
            this.label1.Text = "Добавление/Редактирование \r\nблаготворительных организаций\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSaveEdit
            // 
            this.bSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSaveEdit.Location = new System.Drawing.Point(338, 626);
            this.bSaveEdit.Name = "bSaveEdit";
            this.bSaveEdit.Size = new System.Drawing.Size(154, 36);
            this.bSaveEdit.TabIndex = 15;
            this.bSaveEdit.TabStop = false;
            this.bSaveEdit.Text = "Сохранить";
            this.bSaveEdit.UseVisualStyleBackColor = true;
            this.bSaveEdit.Click += new System.EventHandler(this.paybut_Click);
            // 
            // bCancel
            // 
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(508, 626);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(133, 36);
            this.bCancel.TabIndex = 16;
            this.bCancel.TabStop = false;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.backbut_Click);
            // 
            // imgChar
            // 
            this.imgChar.BackColor = System.Drawing.Color.DarkGray;
            this.imgChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgChar.InitialImage = null;
            this.imgChar.Location = new System.Drawing.Point(549, 395);
            this.imgChar.Name = "imgChar";
            this.imgChar.Size = new System.Drawing.Size(165, 156);
            this.imgChar.TabIndex = 36;
            this.imgChar.TabStop = false;
            // 
            // txName
            // 
            this.txName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txName.Location = new System.Drawing.Point(22, 228);
            this.txName.Multiline = true;
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(309, 33);
            this.txName.TabIndex = 42;
            this.txName.TabStop = false;
            this.txName.Text = "Наименование";
            this.txName.MouseEnter += new System.EventHandler(this.txName_MouseEnter);
            this.txName.MouseLeave += new System.EventHandler(this.txName_MouseLeave);
            // 
            // txDesc
            // 
            this.txDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txDesc.Location = new System.Drawing.Point(22, 303);
            this.txDesc.Multiline = true;
            this.txDesc.Name = "txDesc";
            this.txDesc.Size = new System.Drawing.Size(437, 284);
            this.txDesc.TabIndex = 41;
            this.txDesc.TabStop = false;
            this.txDesc.Text = "Описание благотворительной организации";
            this.txDesc.MouseEnter += new System.EventHandler(this.txDesc_MouseEnter);
            this.txDesc.MouseLeave += new System.EventHandler(this.txDesc_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Наименование:";
            // 
            // butimgload
            // 
            this.butimgload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butimgload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butimgload.Location = new System.Drawing.Point(788, 307);
            this.butimgload.Name = "butimgload";
            this.butimgload.Size = new System.Drawing.Size(156, 33);
            this.butimgload.TabIndex = 44;
            this.butimgload.TabStop = false;
            this.butimgload.Text = "Просмотр...";
            this.butimgload.UseVisualStyleBackColor = true;
            this.butimgload.Click += new System.EventHandler(this.butimgload_Click);
            // 
            // txFileImgChar
            // 
            this.txFileImgChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txFileImgChar.Location = new System.Drawing.Point(549, 307);
            this.txFileImgChar.Multiline = true;
            this.txFileImgChar.Name = "txFileImgChar";
            this.txFileImgChar.ReadOnly = true;
            this.txFileImgChar.Size = new System.Drawing.Size(233, 33);
            this.txFileImgChar.TabIndex = 45;
            this.txFileImgChar.TabStop = false;
            this.txFileImgChar.Text = "Логотип файл";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(560, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(361, 48);
            this.label13.TabIndex = 56;
            this.label13.Text = "Оставьте поле \"Логотип файл\" пустым\r\nесли вы не хотите загружать логотип";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(545, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Логотип файл:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(545, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 24);
            this.label6.TabIndex = 58;
            this.label6.Text = "Текущий логотип:";
            // 
            // AddEditCharity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txFileImgChar);
            this.Controls.Add(this.butimgload);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imgChar);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSaveEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddEditCharity";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - Add/edit charity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunnerRegister_FormClosed);
            this.Load += new System.EventHandler(this.AddEditCharity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChar)).EndInit();
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
        private System.Windows.Forms.Button bSaveEdit;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.PictureBox imgChar;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butimgload;
        private System.Windows.Forms.TextBox txFileImgChar;
        private System.Windows.Forms.Button butlogout;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}