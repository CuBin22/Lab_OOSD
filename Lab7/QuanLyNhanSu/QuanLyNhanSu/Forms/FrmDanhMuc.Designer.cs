namespace QuanLyNhanSu.Forms
{
    partial class FrmDanhMuc
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPhongBan = new System.Windows.Forms.TabPage();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.lblPBMa = new System.Windows.Forms.Label();
            this.txtPBMa = new System.Windows.Forms.TextBox();
            this.lblPBTen = new System.Windows.Forms.Label();
            this.txtPBTen = new System.Windows.Forms.TextBox();
            this.lblPBMoTa = new System.Windows.Forms.Label();
            this.txtPBMoTa = new System.Windows.Forms.TextBox();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.btnLamMoiPB = new System.Windows.Forms.Button();
            this.dgvPB = new System.Windows.Forms.DataGridView();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVHoTen = new System.Windows.Forms.Label();
            this.txtNVHoTen = new System.Windows.Forms.TextBox();
            this.lblNVCCCD = new System.Windows.Forms.Label();
            this.txtNVCCCD = new System.Windows.Forms.TextBox();
            this.lblNVNgaySinh = new System.Windows.Forms.Label();
            this.dtNVNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNVGioiTinh = new System.Windows.Forms.Label();
            this.cboNVGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.lblNVPhongBan = new System.Windows.Forms.Label();
            this.cboNVPhongBan = new System.Windows.Forms.ComboBox();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.cboNVVaiTro = new System.Windows.Forms.ComboBox();
            this.lblNVTrangThai = new System.Windows.Forms.Label();
            this.cboNVTrangThai = new System.Windows.Forms.ComboBox();
            this.lblNVDiaChi = new System.Windows.Forms.Label();
            this.txtNVDiaChi = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnLamMoiNV = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPhongBan.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.SuspendLayout();
            // tabMain
            //
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPhongBan);
            this.tabMain.Controls.Add(this.tabNhanVien);
            this.tabMain.Location = new System.Drawing.Point(10, 10);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(980, 542);
            this.tabMain.TabIndex = 0;
            // tabPhongBan
            //
            this.tabPhongBan.Controls.Add(this.lblPBMa);
            this.tabPhongBan.Controls.Add(this.txtPBMa);
            this.tabPhongBan.Controls.Add(this.lblPBTen);
            this.tabPhongBan.Controls.Add(this.txtPBTen);
            this.tabPhongBan.Controls.Add(this.lblPBMoTa);
            this.tabPhongBan.Controls.Add(this.txtPBMoTa);
            this.tabPhongBan.Controls.Add(this.btnThemPB);
            this.tabPhongBan.Controls.Add(this.btnLamMoiPB);
            this.tabPhongBan.Controls.Add(this.dgvPB);
            this.tabPhongBan.Location = new System.Drawing.Point(4, 24);
            this.tabPhongBan.Name = "tabPhongBan";
            this.tabPhongBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongBan.Size = new System.Drawing.Size(972, 514);
            this.tabPhongBan.TabIndex = 0;
            this.tabPhongBan.Text = "Phòng ban";
            this.tabPhongBan.UseVisualStyleBackColor = true;
            // tabNhanVien
            //
            this.tabNhanVien.Controls.Add(this.lblNVMa);
            this.tabNhanVien.Controls.Add(this.txtNVMa);
            this.tabNhanVien.Controls.Add(this.lblNVHoTen);
            this.tabNhanVien.Controls.Add(this.txtNVHoTen);
            this.tabNhanVien.Controls.Add(this.lblNVCCCD);
            this.tabNhanVien.Controls.Add(this.txtNVCCCD);
            this.tabNhanVien.Controls.Add(this.lblNVNgaySinh);
            this.tabNhanVien.Controls.Add(this.dtNVNgaySinh);
            this.tabNhanVien.Controls.Add(this.lblNVGioiTinh);
            this.tabNhanVien.Controls.Add(this.cboNVGioiTinh);
            this.tabNhanVien.Controls.Add(this.lblNVSDT);
            this.tabNhanVien.Controls.Add(this.txtNVSDT);
            this.tabNhanVien.Controls.Add(this.lblNVPhongBan);
            this.tabNhanVien.Controls.Add(this.cboNVPhongBan);
            this.tabNhanVien.Controls.Add(this.lblNVVaiTro);
            this.tabNhanVien.Controls.Add(this.cboNVVaiTro);
            this.tabNhanVien.Controls.Add(this.lblNVTrangThai);
            this.tabNhanVien.Controls.Add(this.cboNVTrangThai);
            this.tabNhanVien.Controls.Add(this.lblNVDiaChi);
            this.tabNhanVien.Controls.Add(this.txtNVDiaChi);
            this.tabNhanVien.Controls.Add(this.btnThemNV);
            this.tabNhanVien.Controls.Add(this.btnLamMoiNV);
            this.tabNhanVien.Controls.Add(this.dgvNV);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 24);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(972, 514);
            this.tabNhanVien.TabIndex = 0;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // lblPBMa
            //
            this.lblPBMa.AutoSize = true;
            this.lblPBMa.Location = new System.Drawing.Point(15, 18);
            this.lblPBMa.Name = "lblPBMa";
            this.lblPBMa.TabIndex = 1;
            this.lblPBMa.Text = "Mã phòng ban:";
            // txtPBMa
            //
            this.txtPBMa.Location = new System.Drawing.Point(120, 15);
            this.txtPBMa.Name = "txtPBMa";
            this.txtPBMa.Size = new System.Drawing.Size(130, 23);
            this.txtPBMa.TabIndex = 2;
            // lblPBTen
            //
            this.lblPBTen.AutoSize = true;
            this.lblPBTen.Location = new System.Drawing.Point(255, 18);
            this.lblPBTen.Name = "lblPBTen";
            this.lblPBTen.TabIndex = 3;
            this.lblPBTen.Text = "Tên phòng ban:";
            // txtPBTen
            //
            this.txtPBTen.Location = new System.Drawing.Point(360, 15);
            this.txtPBTen.Name = "txtPBTen";
            this.txtPBTen.Size = new System.Drawing.Size(370, 23);
            this.txtPBTen.TabIndex = 4;
            // lblPBMoTa
            //
            this.lblPBMoTa.AutoSize = true;
            this.lblPBMoTa.Location = new System.Drawing.Point(15, 52);
            this.lblPBMoTa.Name = "lblPBMoTa";
            this.lblPBMoTa.TabIndex = 5;
            this.lblPBMoTa.Text = "Mô tả:";
            // txtPBMoTa
            //
            this.txtPBMoTa.Location = new System.Drawing.Point(120, 49);
            this.txtPBMoTa.Name = "txtPBMoTa";
            this.txtPBMoTa.Size = new System.Drawing.Size(610, 23);
            this.txtPBMoTa.TabIndex = 6;
            // btnThemPB
            //
            this.btnThemPB.Location = new System.Drawing.Point(735, 13);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(105, 28);
            this.btnThemPB.TabIndex = 7;
            this.btnThemPB.Text = "Thêm";
            this.btnThemPB.UseVisualStyleBackColor = true;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // btnLamMoiPB
            //
            this.btnLamMoiPB.Location = new System.Drawing.Point(850, 13);
            this.btnLamMoiPB.Name = "btnLamMoiPB";
            this.btnLamMoiPB.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiPB.TabIndex = 8;
            this.btnLamMoiPB.Text = "Làm mới";
            this.btnLamMoiPB.UseVisualStyleBackColor = true;
            this.btnLamMoiPB.Click += new System.EventHandler(this.btnLamMoiPB_Click);
            // dgvPB
            //
            this.dgvPB.Location = new System.Drawing.Point(15, 85);
            this.dgvPB.Name = "dgvPB";
            this.dgvPB.AllowUserToAddRows = false;
            this.dgvPB.AllowUserToDeleteRows = false;
            this.dgvPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPB.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPB.MultiSelect = false;
            this.dgvPB.ReadOnly = true;
            this.dgvPB.RowHeadersVisible = false;
            this.dgvPB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPB.Size = new System.Drawing.Size(942, 417);
            this.dgvPB.TabIndex = 9;
            // lblNVMa
            //
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(15, 18);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.TabIndex = 10;
            this.lblNVMa.Text = "Mã NV:";
            // txtNVMa
            //
            this.txtNVMa.Location = new System.Drawing.Point(120, 15);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(130, 23);
            this.txtNVMa.TabIndex = 11;
            // lblNVHoTen
            //
            this.lblNVHoTen.AutoSize = true;
            this.lblNVHoTen.Location = new System.Drawing.Point(255, 18);
            this.lblNVHoTen.Name = "lblNVHoTen";
            this.lblNVHoTen.TabIndex = 12;
            this.lblNVHoTen.Text = "Họ tên:";
            // txtNVHoTen
            //
            this.txtNVHoTen.Location = new System.Drawing.Point(360, 15);
            this.txtNVHoTen.Name = "txtNVHoTen";
            this.txtNVHoTen.Size = new System.Drawing.Size(130, 23);
            this.txtNVHoTen.TabIndex = 13;
            // lblNVCCCD
            //
            this.lblNVCCCD.AutoSize = true;
            this.lblNVCCCD.Location = new System.Drawing.Point(495, 18);
            this.lblNVCCCD.Name = "lblNVCCCD";
            this.lblNVCCCD.TabIndex = 14;
            this.lblNVCCCD.Text = "CCCD:";
            // txtNVCCCD
            //
            this.txtNVCCCD.Location = new System.Drawing.Point(600, 15);
            this.txtNVCCCD.Name = "txtNVCCCD";
            this.txtNVCCCD.Size = new System.Drawing.Size(130, 23);
            this.txtNVCCCD.TabIndex = 15;
            // lblNVNgaySinh
            //
            this.lblNVNgaySinh.AutoSize = true;
            this.lblNVNgaySinh.Location = new System.Drawing.Point(735, 18);
            this.lblNVNgaySinh.Name = "lblNVNgaySinh";
            this.lblNVNgaySinh.TabIndex = 16;
            this.lblNVNgaySinh.Text = "Ngày sinh:";
            // dtNVNgaySinh
            //
            this.dtNVNgaySinh.Location = new System.Drawing.Point(840, 15);
            this.dtNVNgaySinh.Name = "dtNVNgaySinh";
            this.dtNVNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVNgaySinh.Size = new System.Drawing.Size(130, 23);
            this.dtNVNgaySinh.TabIndex = 17;
            // lblNVGioiTinh
            //
            this.lblNVGioiTinh.AutoSize = true;
            this.lblNVGioiTinh.Location = new System.Drawing.Point(15, 52);
            this.lblNVGioiTinh.Name = "lblNVGioiTinh";
            this.lblNVGioiTinh.TabIndex = 18;
            this.lblNVGioiTinh.Text = "Giới tính:";
            // cboNVGioiTinh
            //
            this.cboNVGioiTinh.Location = new System.Drawing.Point(120, 49);
            this.cboNVGioiTinh.Name = "cboNVGioiTinh";
            this.cboNVGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVGioiTinh.FormattingEnabled = true;
            this.cboNVGioiTinh.Items.AddRange(new object[] {
                "Nam",
    "Nữ",
    "Khác"});
            this.cboNVGioiTinh.Size = new System.Drawing.Size(130, 23);
            this.cboNVGioiTinh.TabIndex = 19;
            // lblNVSDT
            //
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(255, 52);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.TabIndex = 20;
            this.lblNVSDT.Text = "Điện thoại:";
            // txtNVSDT
            //
            this.txtNVSDT.Location = new System.Drawing.Point(360, 49);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(130, 23);
            this.txtNVSDT.TabIndex = 21;
            // lblNVPhongBan
            //
            this.lblNVPhongBan.AutoSize = true;
            this.lblNVPhongBan.Location = new System.Drawing.Point(495, 52);
            this.lblNVPhongBan.Name = "lblNVPhongBan";
            this.lblNVPhongBan.TabIndex = 22;
            this.lblNVPhongBan.Text = "Phòng ban:";
            // cboNVPhongBan
            //
            this.cboNVPhongBan.Location = new System.Drawing.Point(600, 49);
            this.cboNVPhongBan.Name = "cboNVPhongBan";
            this.cboNVPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVPhongBan.FormattingEnabled = true;
            this.cboNVPhongBan.Size = new System.Drawing.Size(130, 23);
            this.cboNVPhongBan.TabIndex = 23;
            // lblNVVaiTro
            //
            this.lblNVVaiTro.AutoSize = true;
            this.lblNVVaiTro.Location = new System.Drawing.Point(735, 52);
            this.lblNVVaiTro.Name = "lblNVVaiTro";
            this.lblNVVaiTro.TabIndex = 24;
            this.lblNVVaiTro.Text = "Vai trò:";
            // cboNVVaiTro
            //
            this.cboNVVaiTro.Location = new System.Drawing.Point(840, 49);
            this.cboNVVaiTro.Name = "cboNVVaiTro";
            this.cboNVVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVVaiTro.FormattingEnabled = true;
            this.cboNVVaiTro.Items.AddRange(new object[] {
                "Giám đốc",
    "Trưởng phòng",
    "Ban chấm công",
    "Nhân viên"});
            this.cboNVVaiTro.Size = new System.Drawing.Size(130, 23);
            this.cboNVVaiTro.TabIndex = 25;
            // lblNVTrangThai
            //
            this.lblNVTrangThai.AutoSize = true;
            this.lblNVTrangThai.Location = new System.Drawing.Point(15, 86);
            this.lblNVTrangThai.Name = "lblNVTrangThai";
            this.lblNVTrangThai.TabIndex = 26;
            this.lblNVTrangThai.Text = "Trạng thái:";
            // cboNVTrangThai
            //
            this.cboNVTrangThai.Location = new System.Drawing.Point(120, 83);
            this.cboNVTrangThai.Name = "cboNVTrangThai";
            this.cboNVTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVTrangThai.FormattingEnabled = true;
            this.cboNVTrangThai.Items.AddRange(new object[] {
                "Thử việc",
    "Chính thức",
    "Đã nghỉ"});
            this.cboNVTrangThai.Size = new System.Drawing.Size(130, 23);
            this.cboNVTrangThai.TabIndex = 27;
            // lblNVDiaChi
            //
            this.lblNVDiaChi.AutoSize = true;
            this.lblNVDiaChi.Location = new System.Drawing.Point(255, 86);
            this.lblNVDiaChi.Name = "lblNVDiaChi";
            this.lblNVDiaChi.TabIndex = 28;
            this.lblNVDiaChi.Text = "Địa chỉ:";
            // txtNVDiaChi
            //
            this.txtNVDiaChi.Location = new System.Drawing.Point(360, 83);
            this.txtNVDiaChi.Name = "txtNVDiaChi";
            this.txtNVDiaChi.Size = new System.Drawing.Size(370, 23);
            this.txtNVDiaChi.TabIndex = 29;
            // btnThemNV
            //
            this.btnThemNV.Location = new System.Drawing.Point(735, 81);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(105, 28);
            this.btnThemNV.TabIndex = 30;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // btnLamMoiNV
            //
            this.btnLamMoiNV.Location = new System.Drawing.Point(850, 81);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiNV.TabIndex = 31;
            this.btnLamMoiNV.Text = "Làm mới";
            this.btnLamMoiNV.UseVisualStyleBackColor = true;
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNV_Click);
            // dgvNV
            //
            this.dgvNV.Location = new System.Drawing.Point(15, 125);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.MultiSelect = false;
            this.dgvNV.ReadOnly = true;
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(942, 377);
            this.dgvNV.TabIndex = 32;
            // btnDong
            //
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(880, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 33;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // FrmDanhMuc
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nhân sự";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabPhongBan.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.tabPhongBan.PerformLayout();
            this.tabNhanVien.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPhongBan;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.Label lblPBMa;
        private System.Windows.Forms.TextBox txtPBMa;
        private System.Windows.Forms.Label lblPBTen;
        private System.Windows.Forms.TextBox txtPBTen;
        private System.Windows.Forms.Label lblPBMoTa;
        private System.Windows.Forms.TextBox txtPBMoTa;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.Button btnLamMoiPB;
        private System.Windows.Forms.DataGridView dgvPB;
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVHoTen;
        private System.Windows.Forms.TextBox txtNVHoTen;
        private System.Windows.Forms.Label lblNVCCCD;
        private System.Windows.Forms.TextBox txtNVCCCD;
        private System.Windows.Forms.Label lblNVNgaySinh;
        private System.Windows.Forms.DateTimePicker dtNVNgaySinh;
        private System.Windows.Forms.Label lblNVGioiTinh;
        private System.Windows.Forms.ComboBox cboNVGioiTinh;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Label lblNVPhongBan;
        private System.Windows.Forms.ComboBox cboNVPhongBan;
        private System.Windows.Forms.Label lblNVVaiTro;
        private System.Windows.Forms.ComboBox cboNVVaiTro;
        private System.Windows.Forms.Label lblNVTrangThai;
        private System.Windows.Forms.ComboBox cboNVTrangThai;
        private System.Windows.Forms.Label lblNVDiaChi;
        private System.Windows.Forms.TextBox txtNVDiaChi;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnLamMoiNV;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button btnDong;
    }
}