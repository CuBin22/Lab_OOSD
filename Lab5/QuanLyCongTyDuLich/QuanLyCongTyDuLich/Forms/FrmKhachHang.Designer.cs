namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmKhachHang
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
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblLoaiKhach = new System.Windows.Forms.Label();
            this.cboLoaiKhach = new System.Windows.Forms.ComboBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblNguoiDaiDien = new System.Windows.Forms.Label();
            this.txtNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.cboLocLoai = new System.Windows.Forms.ComboBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(20, 23);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(41, 13);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.MaxLength = 20;
            this.txtMaKH.Location = new System.Drawing.Point(90, 20);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(120, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblLoaiKhach
            // 
            this.lblLoaiKhach.AutoSize = true;
            this.lblLoaiKhach.Location = new System.Drawing.Point(230, 23);
            this.lblLoaiKhach.Name = "lblLoaiKhach";
            this.lblLoaiKhach.Size = new System.Drawing.Size(73, 13);
            this.lblLoaiKhach.TabIndex = 2;
            this.lblLoaiKhach.Text = "Loại khách:";
            // 
            // cboLoaiKhach
            // 
            this.cboLoaiKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKhach.FormattingEnabled = true;
            this.cboLoaiKhach.Items.AddRange(new object[] {
            "Đoàn",
            "Lẻ"});
            this.cboLoaiKhach.Location = new System.Drawing.Point(310, 20);
            this.cboLoaiKhach.Name = "cboLoaiKhach";
            this.cboLoaiKhach.Size = new System.Drawing.Size(100, 21);
            this.cboLoaiKhach.TabIndex = 3;
            this.cboLoaiKhach.SelectedIndexChanged += new System.EventHandler(this.cboLoaiKhach_SelectedIndexChanged);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(430, 23);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(48, 13);
            this.lblTenKH.TabIndex = 4;
            this.lblTenKH.Text = "Tên KH:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.MaxLength = 100;
            this.txtTenKH.Location = new System.Drawing.Point(490, 20);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(260, 20);
            this.txtTenKH.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 55);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(54, 13);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.MaxLength = 200;
            this.txtDiaChi.Location = new System.Drawing.Point(90, 52);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(320, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(430, 55);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(73, 13);
            this.lblDienThoai.TabIndex = 8;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.MaxLength = 15;
            this.txtDienThoai.Location = new System.Drawing.Point(490, 52);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(160, 20);
            this.txtDienThoai.TabIndex = 9;
            // 
            // lblNguoiDaiDien
            // 
            this.lblNguoiDaiDien.AutoSize = true;
            this.lblNguoiDaiDien.Location = new System.Drawing.Point(20, 87);
            this.lblNguoiDaiDien.Name = "lblNguoiDaiDien";
            this.lblNguoiDaiDien.Size = new System.Drawing.Size(98, 13);
            this.lblNguoiDaiDien.TabIndex = 10;
            this.lblNguoiDaiDien.Text = "Người đại diện:";
            // 
            // txtNguoiDaiDien
            // 
            this.txtNguoiDaiDien.MaxLength = 100;
            this.txtNguoiDaiDien.Location = new System.Drawing.Point(110, 84);
            this.txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            this.txtNguoiDaiDien.Size = new System.Drawing.Size(300, 20);
            this.txtNguoiDaiDien.TabIndex = 11;
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.Location = new System.Drawing.Point(430, 87);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(54, 13);
            this.lblSoCMND.TabIndex = 12;
            this.lblSoCMND.Text = "Số CMND:";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.MaxLength = 20;
            this.txtSoCMND.Location = new System.Drawing.Point(490, 84);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(160, 20);
            this.txtSoCMND.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Location = new System.Drawing.Point(770, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 26);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Location = new System.Drawing.Point(770, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 26);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Location = new System.Drawing.Point(770, 82);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 26);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Location = new System.Drawing.Point(770, 114);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 26);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 121);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(29, 13);
            this.lblTimKiem.TabIndex = 18;
            this.lblTimKiem.Text = "Tìm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(60, 118);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 20);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(330, 121);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(60, 13);
            this.lblLoc.TabIndex = 20;
            this.lblLoc.Text = "Lọc loại:";
            // 
            // cboLocLoai
            // 
            this.cboLocLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoai.FormattingEnabled = true;
            this.cboLocLoai.Items.AddRange(new object[] {
            "Tất cả",
            "Đoàn",
            "Lẻ"});
            this.cboLocLoai.Location = new System.Drawing.Point(390, 118);
            this.cboLocLoai.Name = "cboLocLoai";
            this.cboLocLoai.Size = new System.Drawing.Size(100, 21);
            this.cboLocLoai.TabIndex = 21;
            this.cboLocLoai.SelectedIndexChanged += new System.EventHandler(this.cboLocLoai_SelectedIndexChanged);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(20, 150);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(850, 340);
            this.dgvKhachHang.TabIndex = 22;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(20, 508);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(4, 13);
            this.lblThongBao.TabIndex = 23;
            this.lblThongBao.Text = "";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(795, 504);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 24;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 545);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblLoaiKhach);
            this.Controls.Add(this.cboLoaiKhach);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lblNguoiDaiDien);
            this.Controls.Add(this.txtNguoiDaiDien);
            this.Controls.Add(this.lblSoCMND);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.cboLocLoai);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnDong);
            this.MinimumSize = new System.Drawing.Size(890, 545);
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblLoaiKhach;
        private System.Windows.Forms.ComboBox cboLoaiKhach;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblNguoiDaiDien;
        private System.Windows.Forms.TextBox txtNguoiDaiDien;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.ComboBox cboLocLoai;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDong;
    }
}
