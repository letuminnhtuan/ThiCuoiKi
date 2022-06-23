﻿
namespace _102200292_LeTuMinhTuan.GUI
{
    partial class MainForm
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
            this.cbbHocPhan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLopSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbHocPhan
            // 
            this.cbbHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHocPhan.FormattingEnabled = true;
            this.cbbHocPhan.Location = new System.Drawing.Point(111, 10);
            this.cbbHocPhan.Name = "cbbHocPhan";
            this.cbbHocPhan.Size = new System.Drawing.Size(221, 30);
            this.cbbHocPhan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Học phần";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(808, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 28);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSV,
            this.colLopSH,
            this.colTenHP,
            this.colDiemBT,
            this.colDiemGK,
            this.colDiemCK,
            this.colTongKet,
            this.colNgayThi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 329);
            this.dataGridView1.TabIndex = 3;
            // 
            // colTenSV
            // 
            this.colTenSV.HeaderText = "Tên SV";
            this.colTenSV.MinimumWidth = 6;
            this.colTenSV.Name = "colTenSV";
            // 
            // colLopSH
            // 
            this.colLopSH.HeaderText = "Lớp SH";
            this.colLopSH.MinimumWidth = 6;
            this.colLopSH.Name = "colLopSH";
            // 
            // colTenHP
            // 
            this.colTenHP.HeaderText = "Tên học phần";
            this.colTenHP.MinimumWidth = 6;
            this.colTenHP.Name = "colTenHP";
            // 
            // colDiemBT
            // 
            this.colDiemBT.HeaderText = "Điểm BT";
            this.colDiemBT.MinimumWidth = 6;
            this.colDiemBT.Name = "colDiemBT";
            // 
            // colDiemGK
            // 
            this.colDiemGK.HeaderText = "Điểm GK";
            this.colDiemGK.MinimumWidth = 6;
            this.colDiemGK.Name = "colDiemGK";
            // 
            // colDiemCK
            // 
            this.colDiemCK.HeaderText = "Điểm CK";
            this.colDiemCK.MinimumWidth = 6;
            this.colDiemCK.Name = "colDiemCK";
            // 
            // colTongKet
            // 
            this.colTongKet.HeaderText = "Tổng kết";
            this.colTongKet.MinimumWidth = 6;
            this.colTongKet.Name = "colTongKet";
            // 
            // colNgayThi
            // 
            this.colNgayThi.HeaderText = "Ngày thi";
            this.colNgayThi.MinimumWidth = 6;
            this.colNgayThi.Name = "colNgayThi";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1003, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(782, 387);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(94, 38);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(564, 387);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 38);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(280, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cbbSort
            // 
            this.cbbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(882, 391);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(221, 30);
            this.cbbSort.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 440);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbHocPhan);
            this.Name = "MainForm";
            this.Text = "fMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbHocPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLopSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbbSort;
    }
}