﻿using MarathonProject.INF_TOOLS;

namespace MarathonProject.Forms
{
    partial class ManageCharities
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
            this.DataCharity = new System.Windows.Forms.DataGridView();
            this.Column1 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.Column2 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.Column3 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.Column4 = new MarathonProject.INF_TOOLS.DataGridViewTextBoxColumnEx();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCharity)).BeginInit();
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
            this.btAddCharity.Location = new System.Drawing.Point(12, 172);
            this.btAddCharity.Name = "btAddCharity";
            this.btAddCharity.Size = new System.Drawing.Size(209, 36);
            this.btAddCharity.TabIndex = 43;
            this.btAddCharity.TabStop = false;
            this.btAddCharity.Text = "+ Добавить нового";
            this.btAddCharity.UseVisualStyleBackColor = true;
            this.btAddCharity.Click += new System.EventHandler(this.btAddCharity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(73, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "Управление благотворительными организациями";
            // 
            // DataCharity
            // 
            this.DataCharity.AllowUserToAddRows = false;
            this.DataCharity.AllowUserToDeleteRows = false;
            this.DataCharity.AllowUserToResizeColumns = false;
            this.DataCharity.AllowUserToResizeRows = false;
            this.DataCharity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCharity.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataCharity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataCharity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataCharity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCharity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataCharity.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataCharity.Location = new System.Drawing.Point(12, 224);
            this.DataCharity.Name = "DataCharity";
            this.DataCharity.ReadOnly = true;
            this.DataCharity.RowHeadersVisible = false;
            this.DataCharity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataCharity.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataCharity.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataCharity.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataCharity.RowTemplate.Height = 40;
            this.DataCharity.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataCharity.ShowCellErrors = false;
            this.DataCharity.ShowCellToolTips = false;
            this.DataCharity.ShowEditingIcon = false;
            this.DataCharity.ShowRowErrors = false;
            this.DataCharity.Size = new System.Drawing.Size(943, 393);
            this.DataCharity.TabIndex = 44;
            this.DataCharity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCharity_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Лого";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Описание";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ManageCharities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 753);
            this.Controls.Add(this.DataCharity);
            this.Controls.Add(this.btAddCharity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageCharities";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2018 - Manage charities";
            this.Activated += new System.EventHandler(this.ManageCharities_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarathonRegister_FormClosed);
            this.Load += new System.EventHandler(this.ManageCharities_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCharity)).EndInit();
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
        private System.Windows.Forms.DataGridView DataCharity;
        private DataGridViewTextBoxColumnEx Column1;
        private DataGridViewTextBoxColumnEx Column2;
        private DataGridViewTextBoxColumnEx Column3;
        private DataGridViewTextBoxColumnEx Column4;
    }
}