﻿
namespace PhanMemQuanLyNhanSu
{
    partial class FormLuong
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
            this.HeSoLuongL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLuongL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLuongL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.LuongCoBanL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gBTacVu = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLuong = new System.Windows.Forms.TextBox();
            this.txtMaLuong = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gBInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.gBTacVu.SuspendLayout();
            this.gBInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeSoLuongL
            // 
            this.HeSoLuongL.DataPropertyName = "HeSoLuong";
            this.HeSoLuongL.HeaderText = "Hệ số lương";
            this.HeSoLuongL.Name = "HeSoLuongL";
            // 
            // TenLuongL
            // 
            this.TenLuongL.DataPropertyName = "TenLuong";
            this.TenLuongL.HeaderText = "Tên lương";
            this.TenLuongL.Name = "TenLuongL";
            // 
            // MaLuongL
            // 
            this.MaLuongL.DataPropertyName = "MaLuong";
            this.MaLuongL.HeaderText = "Mã lương";
            this.MaLuongL.Name = "MaLuongL";
            // 
            // dgvLuong
            // 
            this.dgvLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuongL,
            this.TenLuongL,
            this.LuongCoBanL,
            this.HeSoLuongL});
            this.dgvLuong.Location = new System.Drawing.Point(11, 251);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.Size = new System.Drawing.Size(847, 392);
            this.dgvLuong.TabIndex = 21;
            // 
            // LuongCoBanL
            // 
            this.LuongCoBanL.DataPropertyName = "LuongCB";
            this.LuongCoBanL.HeaderText = "Lương cơ bản";
            this.LuongCoBanL.Name = "LuongCoBanL";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 56);
            this.label1.TabIndex = 20;
            this.label1.Tag = "2";
            this.label1.Text = "Quản Lý Lương";
            // 
            // gBTacVu
            // 
            this.gBTacVu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gBTacVu.Controls.Add(this.btnThoat);
            this.gBTacVu.Controls.Add(this.btnReload);
            this.gBTacVu.Controls.Add(this.btnSua);
            this.gBTacVu.Controls.Add(this.btnXoa);
            this.gBTacVu.Controls.Add(this.btnThem);
            this.gBTacVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTacVu.Location = new System.Drawing.Point(397, 71);
            this.gBTacVu.Name = "gBTacVu";
            this.gBTacVu.Size = new System.Drawing.Size(463, 174);
            this.gBTacVu.TabIndex = 18;
            this.gBTacVu.TabStop = false;
            this.gBTacVu.Text = "TÁC VỤ";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(238, 86);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(192, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(40, 86);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(192, 40);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(176, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(330, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(20, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Lương :";
            // 
            // txtTenLuong
            // 
            this.txtTenLuong.Location = new System.Drawing.Point(133, 64);
            this.txtTenLuong.Multiline = true;
            this.txtTenLuong.Name = "txtTenLuong";
            this.txtTenLuong.Size = new System.Drawing.Size(200, 24);
            this.txtTenLuong.TabIndex = 6;
            // 
            // txtMaLuong
            // 
            this.txtMaLuong.Location = new System.Drawing.Point(133, 26);
            this.txtMaLuong.Multiline = true;
            this.txtMaLuong.Name = "txtMaLuong";
            this.txtMaLuong.Size = new System.Drawing.Size(200, 24);
            this.txtMaLuong.TabIndex = 5;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(133, 143);
            this.txtHeSoLuong.Multiline = true;
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(200, 24);
            this.txtHeSoLuong.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Hệ Số Lương : ";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(133, 107);
            this.txtLuongCB.Multiline = true;
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(200, 24);
            this.txtLuongCB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lương Cơ Bản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Lương :";
            // 
            // gBInfo
            // 
            this.gBInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gBInfo.Controls.Add(this.txtHeSoLuong);
            this.gBInfo.Controls.Add(this.label13);
            this.gBInfo.Controls.Add(this.txtLuongCB);
            this.gBInfo.Controls.Add(this.label7);
            this.gBInfo.Controls.Add(this.txtTenLuong);
            this.gBInfo.Controls.Add(this.txtMaLuong);
            this.gBInfo.Controls.Add(this.label3);
            this.gBInfo.Controls.Add(this.label2);
            this.gBInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gBInfo.Location = new System.Drawing.Point(11, 71);
            this.gBInfo.Name = "gBInfo";
            this.gBInfo.Size = new System.Drawing.Size(370, 174);
            this.gBInfo.TabIndex = 19;
            this.gBInfo.TabStop = false;
            this.gBInfo.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // FormLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 655);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBTacVu);
            this.Controls.Add(this.gBInfo);
            this.Name = "FormLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lương";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.gBTacVu.ResumeLayout(false);
            this.gBInfo.ResumeLayout(false);
            this.gBInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuongL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLuongL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuongL;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoBanL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBTacVu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLuong;
        private System.Windows.Forms.TextBox txtMaLuong;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBInfo;
    }
}