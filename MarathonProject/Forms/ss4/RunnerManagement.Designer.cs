using MarathonProject.INF_TOOLS;

namespace MarathonProject.Forms
{
    partial class RunnerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butlogout = new System.Windows.Forms.Button();
            this.backbut = new System.Windows.Forms.Button();
            this.maintext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CStatus = new System.Windows.Forms.ComboBox();
            this.CDistance = new System.Windows.Forms.ComboBox();
            this.lbCountRunners = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CSort = new System.Windows.Forms.ComboBox();
            this.btDetailtCSV = new System.Windows.Forms.Button();
            this.btEmailList = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEx1 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx2 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx3 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx4 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx5 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.dataGridViewTextBoxColumnEx6 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
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
            // btFind
            // 
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFind.Location = new System.Drawing.Point(366, 277);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(140, 33);
            this.btFind.TabIndex = 43;
            this.btFind.TabStop = false;
            this.btFind.Text = "Поиск";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.Location = new System.Drawing.Point(12, 373);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowTemplate.Height = 40;
            this.DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.ShowCellErrors = false;
            this.DataGrid.ShowCellToolTips = false;
            this.DataGrid.ShowEditingIcon = false;
            this.DataGrid.ShowRowErrors = false;
            this.DataGrid.Size = new System.Drawing.Size(943, 302);
            this.DataGrid.TabIndex = 44;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Статус";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Сортировка и фильтрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(71, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(35, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Дистанция:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(699, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Выгрузка";
            // 
            // CStatus
            // 
            this.CStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CStatus.FormattingEnabled = true;
            this.CStatus.ItemHeight = 20;
            this.CStatus.Location = new System.Drawing.Point(154, 198);
            this.CStatus.Name = "CStatus";
            this.CStatus.Size = new System.Drawing.Size(193, 28);
            this.CStatus.TabIndex = 49;
            this.CStatus.TabStop = false;
            // 
            // CDistance
            // 
            this.CDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CDistance.FormattingEnabled = true;
            this.CDistance.ItemHeight = 20;
            this.CDistance.Location = new System.Drawing.Point(154, 239);
            this.CDistance.Name = "CDistance";
            this.CDistance.Size = new System.Drawing.Size(193, 28);
            this.CDistance.TabIndex = 51;
            this.CDistance.TabStop = false;
            // 
            // lbCountRunners
            // 
            this.lbCountRunners.AutoSize = true;
            this.lbCountRunners.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountRunners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCountRunners.Location = new System.Drawing.Point(507, 340);
            this.lbCountRunners.Name = "lbCountRunners";
            this.lbCountRunners.Size = new System.Drawing.Size(35, 20);
            this.lbCountRunners.TabIndex = 58;
            this.lbCountRunners.Text = "unk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(387, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Total runners: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(280, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 39);
            this.label7.TabIndex = 62;
            this.label7.Text = "Управление бегунами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Сортировать:";
            // 
            // CSort
            // 
            this.CSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CSort.FormattingEnabled = true;
            this.CSort.ItemHeight = 20;
            this.CSort.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Email",
            "Статус"});
            this.CSort.Location = new System.Drawing.Point(154, 280);
            this.CSort.Name = "CSort";
            this.CSort.Size = new System.Drawing.Size(193, 28);
            this.CSort.TabIndex = 64;
            this.CSort.TabStop = false;
            // 
            // btDetailtCSV
            // 
            this.btDetailtCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetailtCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDetailtCSV.Location = new System.Drawing.Point(621, 198);
            this.btDetailtCSV.Name = "btDetailtCSV";
            this.btDetailtCSV.Size = new System.Drawing.Size(255, 40);
            this.btDetailtCSV.TabIndex = 65;
            this.btDetailtCSV.TabStop = false;
            this.btDetailtCSV.Text = "Детальная информация (CSV)";
            this.btDetailtCSV.UseVisualStyleBackColor = true;
            this.btDetailtCSV.Click += new System.EventHandler(this.btDetailtCSV_Click);
            // 
            // btEmailList
            // 
            this.btEmailList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEmailList.Location = new System.Drawing.Point(621, 254);
            this.btEmailList.Name = "btEmailList";
            this.btEmailList.Size = new System.Drawing.Size(255, 40);
            this.btEmailList.TabIndex = 66;
            this.btEmailList.TabStop = false;
            this.btEmailList.Text = "Email список";
            this.btEmailList.UseVisualStyleBackColor = true;
            this.btEmailList.Click += new System.EventHandler(this.btEmailList_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 188;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 188;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 188;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 188;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 188;
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
            // RunnerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.btEmailList);
            this.Controls.Add(this.btDetailtCSV);
            this.Controls.Add(this.CSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCountRunners);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CDistance);
            this.Controls.Add(this.CStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RunnerManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - Runner Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarathonRegister_FormClosed);
            this.Load += new System.EventHandler(this.RunnerManagement_Load);
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
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CStatus;
        private System.Windows.Forms.ComboBox CDistance;
        private System.Windows.Forms.Label lbCountRunners;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CSort;
        private System.Windows.Forms.Button btDetailtCSV;
        private System.Windows.Forms.Button btEmailList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}