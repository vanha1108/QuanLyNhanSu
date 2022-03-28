namespace PhanMemQuanLyNhanSu
{
    partial class FormNhanVien
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
            this.gBInfo = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbPhongBan = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rBNam = new System.Windows.Forms.RadioButton();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtbNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBTacVu = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogPicture = new System.Windows.Forms.OpenFileDialog();
            this.gBInfo.SuspendLayout();
            this.gBTacVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gBInfo
            // 
            this.gBInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gBInfo.Controls.Add(this.label16);
            this.gBInfo.Controls.Add(this.label15);
            this.gBInfo.Controls.Add(this.label14);
            this.gBInfo.Controls.Add(this.cbbPhongBan);
            this.gBInfo.Controls.Add(this.label13);
            this.gBInfo.Controls.Add(this.rbNu);
            this.gBInfo.Controls.Add(this.rBNam);
            this.gBInfo.Controls.Add(this.txtGhiChu);
            this.gBInfo.Controls.Add(this.label10);
            this.gBInfo.Controls.Add(this.txtCMND);
            this.gBInfo.Controls.Add(this.label7);
            this.gBInfo.Controls.Add(this.dtbNgaySinh);
            this.gBInfo.Controls.Add(this.txtDiaChi);
            this.gBInfo.Controls.Add(this.txtTenNV);
            this.gBInfo.Controls.Add(this.txtMaNV);
            this.gBInfo.Controls.Add(this.label6);
            this.gBInfo.Controls.Add(this.label5);
            this.gBInfo.Controls.Add(this.label4);
            this.gBInfo.Controls.Add(this.label3);
            this.gBInfo.Controls.Add(this.label2);
            this.gBInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gBInfo.Location = new System.Drawing.Point(12, 58);
            this.gBInfo.Name = "gBInfo";
            this.gBInfo.Size = new System.Drawing.Size(765, 279);
            this.gBInfo.TabIndex = 1;
            this.gBInfo.TabStop = false;
            this.gBInfo.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(442, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(101, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(101, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "*";
            // 
            // cbbPhongBan
            // 
            this.cbbPhongBan.FormattingEnabled = true;
            this.cbbPhongBan.Location = new System.Drawing.Point(124, 231);
            this.cbbPhongBan.Name = "cbbPhongBan";
            this.cbbPhongBan.Size = new System.Drawing.Size(200, 24);
            this.cbbPhongBan.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Phòng : ";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(222, 142);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(43, 20);
            this.rbNu.TabIndex = 20;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rBNam
            // 
            this.rBNam.AutoSize = true;
            this.rBNam.Location = new System.Drawing.Point(124, 142);
            this.rBNam.Name = "rBNam";
            this.rBNam.Size = new System.Drawing.Size(55, 20);
            this.rBNam.TabIndex = 19;
            this.rBNam.TabStop = true;
            this.rBNam.Text = "Nam";
            this.rBNam.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(461, 67);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(188, 77);
            this.txtGhiChu.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ghi Chú :";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(461, 26);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(188, 24);
            this.txtCMND.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số CMND ";
            // 
            // dtbNgaySinh
            // 
            this.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNgaySinh.Location = new System.Drawing.Point(124, 102);
            this.dtbNgaySinh.Name = "dtbNgaySinh";
            this.dtbNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtbNgaySinh.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(124, 168);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 56);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(124, 64);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(200, 24);
            this.txtTenNV.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(124, 26);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 24);
            this.txtMaNV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa Chỉ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên NV ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên ";
            // 
            // gBTacVu
            // 
            this.gBTacVu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gBTacVu.Controls.Add(this.btnExport);
            this.gBTacVu.Controls.Add(this.btnHuy);
            this.gBTacVu.Controls.Add(this.btnSua);
            this.gBTacVu.Controls.Add(this.btnXoa);
            this.gBTacVu.Controls.Add(this.btnThem);
            this.gBTacVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTacVu.Location = new System.Drawing.Point(806, 58);
            this.gBTacVu.Name = "gBTacVu";
            this.gBTacVu.Size = new System.Drawing.Size(476, 279);
            this.gBTacVu.TabIndex = 2;
            this.gBTacVu.TabStop = false;
            this.gBTacVu.Text = "TÁC VỤ";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(326, 80);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 41);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Xuất file excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(176, 80);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 40);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(21, 80);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgSinh,
            this.Phai,
            this.DChi,
            this.Phong,
            this.CMND,
            this.GhiChu});
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 343);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(1270, 353);
            this.dgvNhanVien.TabIndex = 3;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            this.dgvNhanVien.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNhanVien_DataError);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "HoTenNV";
            this.TenNV.HeaderText = "Họ và tên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // NgSinh
            // 
            this.NgSinh.DataPropertyName = "NgaySinh";
            this.NgSinh.HeaderText = "Ngày sinh";
            this.NgSinh.MinimumWidth = 6;
            this.NgSinh.Name = "NgSinh";
            // 
            // Phai
            // 
            this.Phai.DataPropertyName = "GioiTinh";
            this.Phai.HeaderText = "Giới tính";
            this.Phai.MinimumWidth = 6;
            this.Phai.Name = "Phai";
            // 
            // DChi
            // 
            this.DChi.DataPropertyName = "DiaChi";
            this.DChi.HeaderText = "Địa chỉ";
            this.DChi.MinimumWidth = 6;
            this.DChi.Name = "DChi";
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "Phong";
            this.Phong.HeaderText = "Phòng";
            this.Phong.MinimumWidth = 6;
            this.Phong.Name = "Phong";
            this.Phong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Phong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Số CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 56);
            this.label1.TabIndex = 10;
            this.label1.Tag = "2";
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // openFileDialogPicture
            // 
            this.openFileDialogPicture.FileName = "openFileDialogPicture";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBInfo);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.gBTacVu);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.gBInfo.ResumeLayout(false);
            this.gBInfo.PerformLayout();
            this.gBTacVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBTacVu;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtbNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rBNam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gBInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogPicture;
        private System.Windows.Forms.ComboBox cbbPhongBan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DChi;
        private System.Windows.Forms.DataGridViewComboBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}