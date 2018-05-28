using MarathonProject.INF_TOOLS;

namespace MarathonProject.Forms
{
    partial class PostResultMarathon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butlogout = new System.Windows.Forms.Button();
            this.backbut = new System.Windows.Forms.Button();
            this.maintext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumnEx1 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx2 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx3 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx4 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx5 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx6 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.btAddCharity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.Column2 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.Column3 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.Column4 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMarathon = new System.Windows.Forms.ComboBox();
            this.CGender = new System.Windows.Forms.ComboBox();
            this.CDistance = new System.Windows.Forms.ComboBox();
            this.CCategories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCountRunners = new System.Windows.Forms.Label();
            this.lbCountFinish = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCountAvTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
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
            // btAddCharity
            // 
            this.btAddCharity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCharity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddCharity.Location = new System.Drawing.Point(755, 234);
            this.btAddCharity.Name = "btAddCharity";
            this.btAddCharity.Size = new System.Drawing.Size(140, 33);
            this.btAddCharity.TabIndex = 43;
            this.btAddCharity.TabStop = false;
            this.btAddCharity.Text = "Поиск";
            this.btAddCharity.UseVisualStyleBackColor = true;
            this.btAddCharity.Click += new System.EventHandler(this.btAddCharity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(203, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "Результаты предыдущих гонок";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle23;
            this.DataGrid.Location = new System.Drawing.Point(12, 330);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowTemplate.Height = 40;
            this.DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.ShowCellErrors = false;
            this.DataGrid.ShowCellToolTips = false;
            this.DataGrid.ShowEditingIcon = false;
            this.DataGrid.ShowRowErrors = false;
            this.DataGrid.Size = new System.Drawing.Size(943, 345);
            this.DataGrid.TabIndex = 44;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Место";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Время";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя бегуна";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Страна";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(90, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Марафон:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(75, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Дистанция:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(489, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(428, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Категория:";
            // 
            // CMarathon
            // 
            this.CMarathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CMarathon.FormattingEnabled = true;
            this.CMarathon.ItemHeight = 20;
            this.CMarathon.Location = new System.Drawing.Point(194, 170);
            this.CMarathon.Name = "CMarathon";
            this.CMarathon.Size = new System.Drawing.Size(193, 28);
            this.CMarathon.TabIndex = 49;
            this.CMarathon.TabStop = false;
            // 
            // CGender
            // 
            this.CGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CGender.FormattingEnabled = true;
            this.CGender.ItemHeight = 20;
            this.CGender.Location = new System.Drawing.Point(544, 170);
            this.CGender.Name = "CGender";
            this.CGender.Size = new System.Drawing.Size(193, 28);
            this.CGender.TabIndex = 50;
            this.CGender.TabStop = false;
            // 
            // CDistance
            // 
            this.CDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CDistance.FormattingEnabled = true;
            this.CDistance.ItemHeight = 20;
            this.CDistance.Location = new System.Drawing.Point(194, 238);
            this.CDistance.Name = "CDistance";
            this.CDistance.Size = new System.Drawing.Size(193, 28);
            this.CDistance.TabIndex = 51;
            this.CDistance.TabStop = false;
            // 
            // CCategories
            // 
            this.CCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CCategories.FormattingEnabled = true;
            this.CCategories.ItemHeight = 20;
            this.CCategories.Items.AddRange(new object[] {
            "18",
            "18-29",
            "30-39",
            "40-55",
            "56-70",
            "70",
            "Any"});
            this.CCategories.Location = new System.Drawing.Point(544, 237);
            this.CCategories.Name = "CCategories";
            this.CCategories.Size = new System.Drawing.Size(193, 28);
            this.CCategories.TabIndex = 52;
            this.CCategories.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(8, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Всего бегунов:";
            // 
            // lbCountRunners
            // 
            this.lbCountRunners.AutoSize = true;
            this.lbCountRunners.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountRunners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCountRunners.Location = new System.Drawing.Point(138, 295);
            this.lbCountRunners.Name = "lbCountRunners";
            this.lbCountRunners.Size = new System.Drawing.Size(35, 20);
            this.lbCountRunners.TabIndex = 56;
            this.lbCountRunners.Text = "unk";
            // 
            // lbCountFinish
            // 
            this.lbCountFinish.AutoSize = true;
            this.lbCountFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCountFinish.Location = new System.Drawing.Point(534, 295);
            this.lbCountFinish.Name = "lbCountFinish";
            this.lbCountFinish.Size = new System.Drawing.Size(35, 20);
            this.lbCountFinish.TabIndex = 58;
            this.lbCountFinish.Text = "unk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(268, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Всего бегунов финишировало:";
            // 
            // lbCountAvTime
            // 
            this.lbCountAvTime.AutoSize = true;
            this.lbCountAvTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountAvTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCountAvTime.Location = new System.Drawing.Point(836, 295);
            this.lbCountAvTime.Name = "lbCountAvTime";
            this.lbCountAvTime.Size = new System.Drawing.Size(35, 20);
            this.lbCountAvTime.TabIndex = 60;
            this.lbCountAvTime.Text = "unk";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(695, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 59;
            this.label11.Text = "Среднее время:";
            // 
            // PostResultMarathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.lbCountAvTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbCountFinish);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbCountRunners);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CCategories);
            this.Controls.Add(this.CDistance);
            this.Controls.Add(this.CGender);
            this.Controls.Add(this.CMarathon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.btAddCharity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PostResultMarathon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - Previous race results";
            this.Activated += new System.EventHandler(this.PostResultMarathon_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarathonRegister_FormClosed);
            this.Load += new System.EventHandler(this.PostResultMarathon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
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
        private System.Windows.Forms.Button btAddCharity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGrid;
        private DataGridViewTextBoxColumnEx Column1;
        private DataGridViewTextBoxColumnEx Column2;
        private DataGridViewTextBoxColumnEx Column3;
        private DataGridViewTextBoxColumnEx Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMarathon;
        private System.Windows.Forms.ComboBox CGender;
        private System.Windows.Forms.ComboBox CDistance;
        private System.Windows.Forms.ComboBox CCategories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCountRunners;
        private System.Windows.Forms.Label lbCountFinish;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCountAvTime;
        private System.Windows.Forms.Label label11;
    }
}