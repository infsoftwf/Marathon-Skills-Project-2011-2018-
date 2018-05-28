using MarathonProject.INF_TOOLS;

namespace MarathonProject.Forms
{
    partial class BMR
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
            this.imgFem = new System.Windows.Forms.PictureBox();
            this.imgMan = new System.Windows.Forms.PictureBox();
            this.txYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbBMR = new System.Windows.Forms.Label();
            this.lblow = new System.Windows.Forms.Label();
            this.lbsmall = new System.Windows.Forms.Label();
            this.lbav = new System.Windows.Forms.Label();
            this.lbhigh = new System.Windows.Forms.Label();
            this.lbultra = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumnEx1 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx2 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx3 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx4 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx5 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx6 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.imgDesc = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDesc)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(307, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "BMR калькулятор";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(46, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 73);
            this.label4.TabIndex = 47;
            this.label4.Text = "Информация о том, что такое BMR и как рассчитываются результаты\r\n";
            // 
            // btResult
            // 
            this.btResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btResult.Location = new System.Drawing.Point(28, 583);
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
            this.btCancel.Location = new System.Drawing.Point(202, 583);
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
            // txYear
            // 
            this.txYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txYear.Location = new System.Drawing.Point(161, 524);
            this.txYear.MaxLength = 3;
            this.txYear.Multiline = true;
            this.txYear.Name = "txYear";
            this.txYear.Size = new System.Drawing.Size(62, 33);
            this.txYear.TabIndex = 66;
            this.txYear.TabStop = false;
            this.txYear.Text = "30";
            this.txYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txYear.TextChanged += new System.EventHandler(this.OnlyNum);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(229, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "лет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(60, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "Возраст:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(570, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(344, 73);
            this.label9.TabIndex = 67;
            this.label9.Text = "Информация о показателях калорий показывается здесь\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(681, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "Ваш BMR";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(631, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 62);
            this.label11.TabIndex = 69;
            this.label11.Text = "Ежедневно тратится калорий";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBMR
            // 
            this.lbBMR.AutoSize = true;
            this.lbBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBMR.Location = new System.Drawing.Point(683, 295);
            this.lbBMR.Name = "lbBMR";
            this.lbBMR.Size = new System.Drawing.Size(87, 31);
            this.lbBMR.TabIndex = 70;
            this.lbBMR.Text = "1,676";
            // 
            // lblow
            // 
            this.lblow.AutoSize = true;
            this.lblow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblow.ForeColor = System.Drawing.Color.Blue;
            this.lblow.Location = new System.Drawing.Point(640, 439);
            this.lblow.Name = "lblow";
            this.lblow.Size = new System.Drawing.Size(93, 24);
            this.lblow.TabIndex = 71;
            this.lblow.Text = "Сидячий:";
            this.lblow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbsmall
            // 
            this.lbsmall.AutoSize = true;
            this.lbsmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbsmall.ForeColor = System.Drawing.Color.Lime;
            this.lbsmall.Location = new System.Drawing.Point(511, 475);
            this.lbsmall.Name = "lbsmall";
            this.lbsmall.Size = new System.Drawing.Size(222, 24);
            this.lbsmall.TabIndex = 72;
            this.lbsmall.Text = "Маленькая активность:";
            this.lbsmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbav
            // 
            this.lbav.AutoSize = true;
            this.lbav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbav.Location = new System.Drawing.Point(531, 511);
            this.lbav.Name = "lbav";
            this.lbav.Size = new System.Drawing.Size(202, 24);
            this.lbav.TabIndex = 73;
            this.lbav.Text = "Средняя активность:";
            this.lbav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbhigh
            // 
            this.lbhigh.AutoSize = true;
            this.lbhigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbhigh.ForeColor = System.Drawing.Color.Red;
            this.lbhigh.Location = new System.Drawing.Point(533, 547);
            this.lbhigh.Name = "lbhigh";
            this.lbhigh.Size = new System.Drawing.Size(200, 24);
            this.lbhigh.TabIndex = 74;
            this.lbhigh.Text = "Сильная активность:";
            this.lbhigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbultra
            // 
            this.lbultra.AutoSize = true;
            this.lbultra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbultra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbultra.Location = new System.Drawing.Point(478, 583);
            this.lbultra.Name = "lbultra";
            this.lbultra.Size = new System.Drawing.Size(255, 24);
            this.lbultra.TabIndex = 75;
            this.lbultra.Text = "Максимальная активность:";
            this.lbultra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // imgDesc
            // 
            this.imgDesc.BackgroundImage = global::MarathonProject.Properties.Resources.emblem_important;
            this.imgDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDesc.InitialImage = null;
            this.imgDesc.Location = new System.Drawing.Point(850, 377);
            this.imgDesc.Name = "imgDesc";
            this.imgDesc.Size = new System.Drawing.Size(32, 32);
            this.imgDesc.TabIndex = 76;
            this.imgDesc.TabStop = false;
            this.imgDesc.Click += new System.EventHandler(this.imgDesc_Click);
            // 
            // BMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.imgDesc);
            this.Controls.Add(this.lbultra);
            this.Controls.Add(this.lbhigh);
            this.Controls.Add(this.lbav);
            this.Controls.Add(this.lbsmall);
            this.Controls.Add(this.lblow);
            this.Controls.Add(this.lbBMR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
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
            this.Name = "BMR";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - BMR calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMR_FormClosed);
            this.Load += new System.EventHandler(this.BMR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDesc)).EndInit();
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
        private System.Windows.Forms.TextBox txYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbBMR;
        private System.Windows.Forms.Label lblow;
        private System.Windows.Forms.Label lbsmall;
        private System.Windows.Forms.Label lbav;
        private System.Windows.Forms.Label lbhigh;
        private System.Windows.Forms.Label lbultra;
        private System.Windows.Forms.PictureBox imgDesc;
    }
}