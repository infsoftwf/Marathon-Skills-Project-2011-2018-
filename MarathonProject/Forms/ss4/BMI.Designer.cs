using MarathonProject.INF_TOOLS;

namespace MarathonProject.Forms
{
    partial class BMI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btResult = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txRise = new System.Windows.Forms.TextBox();
            this.txWeight = new System.Windows.Forms.TextBox();
            this.h_underweight = new System.Windows.Forms.Label();
            this.h_healthy = new System.Windows.Forms.Label();
            this.h_overweight = new System.Windows.Forms.Label();
            this.h_obese = new System.Windows.Forms.Label();
            this.imgBMILine = new System.Windows.Forms.PictureBox();
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.imgFem = new System.Windows.Forms.PictureBox();
            this.imgMan = new System.Windows.Forms.PictureBox();
            this.refBmi = new System.Windows.Forms.PictureBox();
            this.lbresbmi = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumnEx1 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx2 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx3 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx4 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx5 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx6 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBMILine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refBmi)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(318, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "BMI калькулятор";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(46, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 55);
            this.label4.TabIndex = 47;
            this.label4.Text = "Информация о том, что такое BMI и как работает калькулятор\r\n";
            // 
            // btResult
            // 
            this.btResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btResult.Location = new System.Drawing.Point(28, 534);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(155, 36);
            this.btResult.TabIndex = 56;
            this.btResult.TabStop = false;
            this.btResult.Text = "Рассчитать";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // btCancel
            // 
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(202, 534);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(155, 36);
            this.btCancel.TabIndex = 57;
            this.btCancel.TabStop = false;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(91, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Рост:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(101, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Вес:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(229, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "см";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(229, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "кг";
            // 
            // txRise
            // 
            this.txRise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txRise.Location = new System.Drawing.Point(161, 422);
            this.txRise.MaxLength = 3;
            this.txRise.Multiline = true;
            this.txRise.Name = "txRise";
            this.txRise.Size = new System.Drawing.Size(62, 33);
            this.txRise.TabIndex = 62;
            this.txRise.TabStop = false;
            this.txRise.Text = "170";
            this.txRise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txRise.TextChanged += new System.EventHandler(this.OnlyNum);
            // 
            // txWeight
            // 
            this.txWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txWeight.Location = new System.Drawing.Point(161, 473);
            this.txWeight.MaxLength = 3;
            this.txWeight.Multiline = true;
            this.txWeight.Name = "txWeight";
            this.txWeight.Size = new System.Drawing.Size(62, 33);
            this.txWeight.TabIndex = 63;
            this.txWeight.TabStop = false;
            this.txWeight.Text = "70";
            this.txWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txWeight.TextChanged += new System.EventHandler(this.OnlyNum);
            // 
            // h_underweight
            // 
            this.h_underweight.AutoSize = true;
            this.h_underweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_underweight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.h_underweight.Location = new System.Drawing.Point(412, 636);
            this.h_underweight.Name = "h_underweight";
            this.h_underweight.Size = new System.Drawing.Size(119, 18);
            this.h_underweight.TabIndex = 66;
            this.h_underweight.Text = "Недостаточный";
            // 
            // h_healthy
            // 
            this.h_healthy.AutoSize = true;
            this.h_healthy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_healthy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.h_healthy.Location = new System.Drawing.Point(562, 636);
            this.h_healthy.Name = "h_healthy";
            this.h_healthy.Size = new System.Drawing.Size(80, 18);
            this.h_healthy.TabIndex = 67;
            this.h_healthy.Text = "Здоровый";
            // 
            // h_overweight
            // 
            this.h_overweight.AutoSize = true;
            this.h_overweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_overweight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.h_overweight.Location = new System.Drawing.Point(689, 636);
            this.h_overweight.Name = "h_overweight";
            this.h_overweight.Size = new System.Drawing.Size(98, 18);
            this.h_overweight.TabIndex = 68;
            this.h_overweight.Text = "Избыточный";
            // 
            // h_obese
            // 
            this.h_obese.AutoSize = true;
            this.h_obese.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_obese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.h_obese.Location = new System.Drawing.Point(830, 636);
            this.h_obese.Name = "h_obese";
            this.h_obese.Size = new System.Drawing.Size(79, 18);
            this.h_obese.TabIndex = 70;
            this.h_obese.Text = "Ожирение";
            // 
            // imgBMILine
            // 
            this.imgBMILine.BackColor = System.Drawing.Color.DarkGray;
            this.imgBMILine.BackgroundImage = global::MarathonProject.Properties.Resources.BMILine;
            this.imgBMILine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBMILine.InitialImage = null;
            this.imgBMILine.Location = new System.Drawing.Point(405, 614);
            this.imgBMILine.Name = "imgBMILine";
            this.imgBMILine.Size = new System.Drawing.Size(530, 19);
            this.imgBMILine.TabIndex = 65;
            this.imgBMILine.TabStop = false;
            // 
            // imgMain
            // 
            this.imgMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgMain.InitialImage = null;
            this.imgMain.Location = new System.Drawing.Point(542, 179);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(252, 322);
            this.imgMain.TabIndex = 64;
            this.imgMain.TabStop = false;
            this.imgMain.Tag = "";
            // 
            // imgFem
            // 
            this.imgFem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgFem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFem.InitialImage = null;
            this.imgFem.Location = new System.Drawing.Point(201, 266);
            this.imgFem.Name = "imgFem";
            this.imgFem.Size = new System.Drawing.Size(133, 128);
            this.imgFem.TabIndex = 55;
            this.imgFem.TabStop = false;
            this.imgFem.Click += new System.EventHandler(this.imgFem_Click);
            // 
            // imgMan
            // 
            this.imgMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgMan.InitialImage = null;
            this.imgMan.Location = new System.Drawing.Point(50, 266);
            this.imgMan.Name = "imgMan";
            this.imgMan.Size = new System.Drawing.Size(133, 128);
            this.imgMan.TabIndex = 54;
            this.imgMan.TabStop = false;
            this.imgMan.Click += new System.EventHandler(this.imgMan_Click);
            // 
            // refBmi
            // 
            this.refBmi.BackColor = System.Drawing.Color.Transparent;
            this.refBmi.BackgroundImage = global::MarathonProject.Properties.Resources.arbmi;
            this.refBmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refBmi.InitialImage = null;
            this.refBmi.Location = new System.Drawing.Point(585, 578);
            this.refBmi.Name = "refBmi";
            this.refBmi.Size = new System.Drawing.Size(33, 30);
            this.refBmi.TabIndex = 72;
            this.refBmi.TabStop = false;
            // 
            // lbresbmi
            // 
            this.lbresbmi.AutoSize = true;
            this.lbresbmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbresbmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbresbmi.Location = new System.Drawing.Point(580, 552);
            this.lbresbmi.Name = "lbresbmi";
            this.lbresbmi.Size = new System.Drawing.Size(44, 18);
            this.lbresbmi.TabIndex = 73;
            this.lbresbmi.Text = "24,22";
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
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.lbresbmi);
            this.Controls.Add(this.refBmi);
            this.Controls.Add(this.h_obese);
            this.Controls.Add(this.h_overweight);
            this.Controls.Add(this.h_healthy);
            this.Controls.Add(this.h_underweight);
            this.Controls.Add(this.imgBMILine);
            this.Controls.Add(this.imgMain);
            this.Controls.Add(this.txWeight);
            this.Controls.Add(this.txRise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.imgFem);
            this.Controls.Add(this.imgMan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BMI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - BMI calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMI_FormClosed);
            this.Load += new System.EventHandler(this.BMI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBMILine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refBmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label maintext;
        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEndTime;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx1;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx2;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx3;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx4;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx5;
        private DataGridViewTextBoxColumnEx dataGridViewTextBoxColumnEx6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgMan;
        private System.Windows.Forms.PictureBox imgFem;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txRise;
        private System.Windows.Forms.TextBox txWeight;
        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.PictureBox imgBMILine;
        private System.Windows.Forms.Label h_underweight;
        private System.Windows.Forms.Label h_healthy;
        private System.Windows.Forms.Label h_overweight;
        private System.Windows.Forms.Label h_obese;
        private System.Windows.Forms.PictureBox refBmi;
        private System.Windows.Forms.Label lbresbmi;
    }
}