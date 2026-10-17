namespace QuanLyBenhVien.Forms
{
    partial class FrmTraCuu
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
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTieuChi = new System.Windows.Forms.Label();
            this.cboTieuChi = new System.Windows.Forms.ComboBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblSoKetQua = new System.Windows.Forms.Label();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.dgvHoSo = new System.Windows.Forms.DataGridView();
            this.colHoSo_MaHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoSo_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoSo_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoSo_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoSo_DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoSo_NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoSo_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLichSu = new System.Windows.Forms.GroupBox();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.colLichSu_SoPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_NgayGioKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_LoaiKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_KetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpToa = new System.Windows.Forms.GroupBox();
            this.dgvToa = new System.Windows.Forms.DataGridView();
            this.colToa_TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToa_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToa_LieuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToa_CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpXN = new System.Windows.Forms.GroupBox();
            this.dgvXN = new System.Windows.Forms.DataGridView();
            this.colXN_TenLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXN_NgayChiDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXN_KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXN_NgayCoKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXN)).BeginInit();
            this.grpTimKiem.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            this.grpLichSu.SuspendLayout();
            this.grpToa.SuspendLayout();
            this.grpXN.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Location = new System.Drawing.Point(10, 8);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(1030, 62);
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.Text = "Tìm kiếm hồ sơ";
            this.grpTimKiem.Controls.Add(this.lblTieuChi);
            this.grpTimKiem.Controls.Add(this.cboTieuChi);
            this.grpTimKiem.Controls.Add(this.lblTuKhoa);
            this.grpTimKiem.Controls.Add(this.txtTuKhoa);
            this.grpTimKiem.Controls.Add(this.btnTim);
            this.grpTimKiem.Controls.Add(this.btnLamMoi);
            this.grpTimKiem.Controls.Add(this.lblSoKetQua);
            // 
            // lblTieuChi
            // 
            this.lblTieuChi.Location = new System.Drawing.Point(15, 29);
            this.lblTieuChi.Name = "lblTieuChi";
            this.lblTieuChi.AutoSize = true;
            this.lblTieuChi.Size = new System.Drawing.Size(50, 13);
            this.lblTieuChi.TabIndex = 0;
            this.lblTieuChi.Text = "Tìm theo:";
            // 
            // cboTieuChi
            // 
            this.cboTieuChi.Location = new System.Drawing.Point(75, 26);
            this.cboTieuChi.Name = "cboTieuChi";
            this.cboTieuChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTieuChi.FormattingEnabled = true;
            this.cboTieuChi.Items.AddRange(new object[] {
                "Mã hồ sơ",
                "Họ tên",
                "Ngày sinh",
                "Điện thoại"});
            this.cboTieuChi.Size = new System.Drawing.Size(130, 21);
            this.cboTieuChi.TabIndex = 1;
            this.cboTieuChi.SelectedIndexChanged += new System.EventHandler(this.cboTieuChi_SelectedIndexChanged);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.Location = new System.Drawing.Point(225, 29);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Size = new System.Drawing.Size(50, 13);
            this.lblTuKhoa.TabIndex = 2;
            this.lblTuKhoa.Text = "Từ khóa:";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(280, 26);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(280, 20);
            this.txtTuKhoa.TabIndex = 3;
            this.txtTuKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuKhoa_KeyDown);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(575, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(90, 27);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(675, 22);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 27);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblSoKetQua
            // 
            this.lblSoKetQua.Location = new System.Drawing.Point(790, 29);
            this.lblSoKetQua.Name = "lblSoKetQua";
            this.lblSoKetQua.AutoSize = true;
            this.lblSoKetQua.Size = new System.Drawing.Size(50, 13);
            this.lblSoKetQua.TabIndex = 6;
            this.lblSoKetQua.Text = "Tìm thấy: 0 hồ sơ";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Location = new System.Drawing.Point(10, 76);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(1030, 160);
            this.grpKetQua.TabStop = false;
            this.grpKetQua.TabIndex = 1;
            this.grpKetQua.Text = "Hồ sơ tìm thấy (trang bìa)";
            this.grpKetQua.Controls.Add(this.dgvHoSo);
            // 
            // dgvHoSo
            // 
            this.dgvHoSo.AllowUserToAddRows = false;
            this.dgvHoSo.AllowUserToDeleteRows = false;
            this.dgvHoSo.AllowUserToResizeRows = false;
            this.dgvHoSo.AutoGenerateColumns = false;
            this.dgvHoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoSo.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colHoSo_MaHoSo,
            this.colHoSo_HoTen,
            this.colHoSo_NgaySinh,
            this.colHoSo_DiaChi,
            this.colHoSo_DienThoai,
            this.colHoSo_NgayCap,
            this.colHoSo_TrangThai});
            this.dgvHoSo.Location = new System.Drawing.Point(10, 20);
            this.dgvHoSo.MultiSelect = false;
            this.dgvHoSo.Name = "dgvHoSo";
            this.dgvHoSo.ReadOnly = true;
            this.dgvHoSo.RowHeadersVisible = false;
            this.dgvHoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoSo.Size = new System.Drawing.Size(1010, 130);
            this.dgvHoSo.TabIndex = 0;
            this.dgvHoSo.SelectionChanged += new System.EventHandler(this.dgvHoSo_SelectionChanged);
            // 
            // colHoSo_MaHoSo
            // 
            this.colHoSo_MaHoSo.DataPropertyName = "MaHoSo";
            this.colHoSo_MaHoSo.HeaderText = "Mã hồ sơ";
            this.colHoSo_MaHoSo.Name = "colHoSo_MaHoSo";
            this.colHoSo_MaHoSo.ReadOnly = true;
            // 
            // colHoSo_HoTen
            // 
            this.colHoSo_HoTen.DataPropertyName = "HoTen";
            this.colHoSo_HoTen.HeaderText = "Họ tên";
            this.colHoSo_HoTen.Name = "colHoSo_HoTen";
            this.colHoSo_HoTen.ReadOnly = true;
            // 
            // colHoSo_NgaySinh
            // 
            this.colHoSo_NgaySinh.DataPropertyName = "NgaySinh";
            this.colHoSo_NgaySinh.HeaderText = "Ngày sinh";
            this.colHoSo_NgaySinh.Name = "colHoSo_NgaySinh";
            this.colHoSo_NgaySinh.ReadOnly = true;
            // 
            // colHoSo_DiaChi
            // 
            this.colHoSo_DiaChi.DataPropertyName = "DiaChi";
            this.colHoSo_DiaChi.HeaderText = "Địa chỉ";
            this.colHoSo_DiaChi.Name = "colHoSo_DiaChi";
            this.colHoSo_DiaChi.ReadOnly = true;
            // 
            // colHoSo_DienThoai
            // 
            this.colHoSo_DienThoai.DataPropertyName = "DienThoai";
            this.colHoSo_DienThoai.HeaderText = "Điện thoại";
            this.colHoSo_DienThoai.Name = "colHoSo_DienThoai";
            this.colHoSo_DienThoai.ReadOnly = true;
            // 
            // colHoSo_NgayCap
            // 
            this.colHoSo_NgayCap.DataPropertyName = "NgayCap";
            this.colHoSo_NgayCap.HeaderText = "Ngày cấp";
            this.colHoSo_NgayCap.Name = "colHoSo_NgayCap";
            this.colHoSo_NgayCap.ReadOnly = true;
            // 
            // colHoSo_TrangThai
            // 
            this.colHoSo_TrangThai.DataPropertyName = "TrangThai";
            this.colHoSo_TrangThai.HeaderText = "Trạng thái";
            this.colHoSo_TrangThai.Name = "colHoSo_TrangThai";
            this.colHoSo_TrangThai.ReadOnly = true;
            // 
            // grpLichSu
            // 
            this.grpLichSu.Location = new System.Drawing.Point(10, 242);
            this.grpLichSu.Name = "grpLichSu";
            this.grpLichSu.Size = new System.Drawing.Size(1030, 200);
            this.grpLichSu.TabStop = false;
            this.grpLichSu.TabIndex = 2;
            this.grpLichSu.Text = "Lịch sử khám và điều trị";
            this.grpLichSu.Controls.Add(this.dgvLichSu);
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AllowUserToResizeRows = false;
            this.dgvLichSu.AutoGenerateColumns = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLichSu_SoPhieuKham,
            this.colLichSu_NgayGioKham,
            this.colLichSu_LoaiKham,
            this.colLichSu_TenBS,
            this.colLichSu_TenKhoa,
            this.colLichSu_TrieuChung,
            this.colLichSu_KetLuan});
            this.dgvLichSu.Location = new System.Drawing.Point(10, 20);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(1010, 170);
            this.dgvLichSu.TabIndex = 0;
            this.dgvLichSu.SelectionChanged += new System.EventHandler(this.dgvLichSu_SelectionChanged);
            // 
            // colLichSu_SoPhieuKham
            // 
            this.colLichSu_SoPhieuKham.DataPropertyName = "SoPhieuKham";
            this.colLichSu_SoPhieuKham.HeaderText = "Số phiếu";
            this.colLichSu_SoPhieuKham.Name = "colLichSu_SoPhieuKham";
            this.colLichSu_SoPhieuKham.ReadOnly = true;
            // 
            // colLichSu_NgayGioKham
            // 
            this.colLichSu_NgayGioKham.DataPropertyName = "NgayGioKham";
            this.colLichSu_NgayGioKham.HeaderText = "Ngày giờ khám";
            this.colLichSu_NgayGioKham.Name = "colLichSu_NgayGioKham";
            this.colLichSu_NgayGioKham.ReadOnly = true;
            // 
            // colLichSu_LoaiKham
            // 
            this.colLichSu_LoaiKham.DataPropertyName = "LoaiKham";
            this.colLichSu_LoaiKham.HeaderText = "Loại khám";
            this.colLichSu_LoaiKham.Name = "colLichSu_LoaiKham";
            this.colLichSu_LoaiKham.ReadOnly = true;
            // 
            // colLichSu_TenBS
            // 
            this.colLichSu_TenBS.DataPropertyName = "TenBS";
            this.colLichSu_TenBS.HeaderText = "Bác sĩ";
            this.colLichSu_TenBS.Name = "colLichSu_TenBS";
            this.colLichSu_TenBS.ReadOnly = true;
            // 
            // colLichSu_TenKhoa
            // 
            this.colLichSu_TenKhoa.DataPropertyName = "TenKhoa";
            this.colLichSu_TenKhoa.HeaderText = "Khoa";
            this.colLichSu_TenKhoa.Name = "colLichSu_TenKhoa";
            this.colLichSu_TenKhoa.ReadOnly = true;
            // 
            // colLichSu_TrieuChung
            // 
            this.colLichSu_TrieuChung.DataPropertyName = "TrieuChung";
            this.colLichSu_TrieuChung.HeaderText = "Triệu chứng";
            this.colLichSu_TrieuChung.Name = "colLichSu_TrieuChung";
            this.colLichSu_TrieuChung.ReadOnly = true;
            // 
            // colLichSu_KetLuan
            // 
            this.colLichSu_KetLuan.DataPropertyName = "KetLuan";
            this.colLichSu_KetLuan.HeaderText = "Kết luận";
            this.colLichSu_KetLuan.Name = "colLichSu_KetLuan";
            this.colLichSu_KetLuan.ReadOnly = true;
            // 
            // grpToa
            // 
            this.grpToa.Location = new System.Drawing.Point(10, 448);
            this.grpToa.Name = "grpToa";
            this.grpToa.Size = new System.Drawing.Size(510, 200);
            this.grpToa.TabStop = false;
            this.grpToa.TabIndex = 3;
            this.grpToa.Text = "Toa thuốc của phiếu khám";
            this.grpToa.Controls.Add(this.dgvToa);
            // 
            // dgvToa
            // 
            this.dgvToa.AllowUserToAddRows = false;
            this.dgvToa.AllowUserToDeleteRows = false;
            this.dgvToa.AllowUserToResizeRows = false;
            this.dgvToa.AutoGenerateColumns = false;
            this.dgvToa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToa.BackgroundColor = System.Drawing.Color.White;
            this.dgvToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colToa_TenThuoc,
            this.colToa_SoLuong,
            this.colToa_LieuDung,
            this.colToa_CachDung});
            this.dgvToa.Location = new System.Drawing.Point(10, 20);
            this.dgvToa.MultiSelect = false;
            this.dgvToa.Name = "dgvToa";
            this.dgvToa.ReadOnly = true;
            this.dgvToa.RowHeadersVisible = false;
            this.dgvToa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToa.Size = new System.Drawing.Size(490, 170);
            this.dgvToa.TabIndex = 0;
            // 
            // colToa_TenThuoc
            // 
            this.colToa_TenThuoc.DataPropertyName = "TenThuoc";
            this.colToa_TenThuoc.HeaderText = "Thuốc";
            this.colToa_TenThuoc.Name = "colToa_TenThuoc";
            this.colToa_TenThuoc.ReadOnly = true;
            // 
            // colToa_SoLuong
            // 
            this.colToa_SoLuong.DataPropertyName = "SoLuong";
            this.colToa_SoLuong.HeaderText = "Số lượng";
            this.colToa_SoLuong.Name = "colToa_SoLuong";
            this.colToa_SoLuong.ReadOnly = true;
            // 
            // colToa_LieuDung
            // 
            this.colToa_LieuDung.DataPropertyName = "LieuDung";
            this.colToa_LieuDung.HeaderText = "Liều dùng";
            this.colToa_LieuDung.Name = "colToa_LieuDung";
            this.colToa_LieuDung.ReadOnly = true;
            // 
            // colToa_CachDung
            // 
            this.colToa_CachDung.DataPropertyName = "CachDung";
            this.colToa_CachDung.HeaderText = "Cách dùng";
            this.colToa_CachDung.Name = "colToa_CachDung";
            this.colToa_CachDung.ReadOnly = true;
            // 
            // grpXN
            // 
            this.grpXN.Location = new System.Drawing.Point(530, 448);
            this.grpXN.Name = "grpXN";
            this.grpXN.Size = new System.Drawing.Size(510, 200);
            this.grpXN.TabStop = false;
            this.grpXN.TabIndex = 4;
            this.grpXN.Text = "Xét nghiệm của phiếu khám";
            this.grpXN.Controls.Add(this.dgvXN);
            // 
            // dgvXN
            // 
            this.dgvXN.AllowUserToAddRows = false;
            this.dgvXN.AllowUserToDeleteRows = false;
            this.dgvXN.AllowUserToResizeRows = false;
            this.dgvXN.AutoGenerateColumns = false;
            this.dgvXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXN.BackgroundColor = System.Drawing.Color.White;
            this.dgvXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colXN_TenLoaiXN,
            this.colXN_NgayChiDinh,
            this.colXN_KetQua,
            this.colXN_NgayCoKetQua});
            this.dgvXN.Location = new System.Drawing.Point(10, 20);
            this.dgvXN.MultiSelect = false;
            this.dgvXN.Name = "dgvXN";
            this.dgvXN.ReadOnly = true;
            this.dgvXN.RowHeadersVisible = false;
            this.dgvXN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXN.Size = new System.Drawing.Size(490, 170);
            this.dgvXN.TabIndex = 0;
            // 
            // colXN_TenLoaiXN
            // 
            this.colXN_TenLoaiXN.DataPropertyName = "TenLoaiXN";
            this.colXN_TenLoaiXN.HeaderText = "Loại xét nghiệm";
            this.colXN_TenLoaiXN.Name = "colXN_TenLoaiXN";
            this.colXN_TenLoaiXN.ReadOnly = true;
            // 
            // colXN_NgayChiDinh
            // 
            this.colXN_NgayChiDinh.DataPropertyName = "NgayChiDinh";
            this.colXN_NgayChiDinh.HeaderText = "Ngày chỉ định";
            this.colXN_NgayChiDinh.Name = "colXN_NgayChiDinh";
            this.colXN_NgayChiDinh.ReadOnly = true;
            // 
            // colXN_KetQua
            // 
            this.colXN_KetQua.DataPropertyName = "KetQua";
            this.colXN_KetQua.HeaderText = "Kết quả";
            this.colXN_KetQua.Name = "colXN_KetQua";
            this.colXN_KetQua.ReadOnly = true;
            // 
            // colXN_NgayCoKetQua
            // 
            this.colXN_NgayCoKetQua.DataPropertyName = "NgayCoKetQua";
            this.colXN_NgayCoKetQua.HeaderText = "Ngày có kết quả";
            this.colXN_NgayCoKetQua.Name = "colXN_NgayCoKetQua";
            this.colXN_NgayCoKetQua.ReadOnly = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(940, 654);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 27);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 690);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpLichSu);
            this.Controls.Add(this.grpToa);
            this.Controls.Add(this.grpXN);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tái khám - Tra cứu hồ sơ bệnh án";
            this.Load += new System.EventHandler(this.FrmTraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXN)).EndInit();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.grpLichSu.ResumeLayout(false);
            this.grpLichSu.PerformLayout();
            this.grpToa.ResumeLayout(false);
            this.grpToa.PerformLayout();
            this.grpXN.ResumeLayout(false);
            this.grpXN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTieuChi;
        private System.Windows.Forms.ComboBox cboTieuChi;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblSoKetQua;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.DataGridView dgvHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSo_MaHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSo_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSo_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSo_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSo_DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSo_NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSo_TrangThai;
        private System.Windows.Forms.GroupBox grpLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_SoPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_NgayGioKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_LoaiKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_TrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_KetLuan;
        private System.Windows.Forms.GroupBox grpToa;
        private System.Windows.Forms.DataGridView dgvToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToa_TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToa_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToa_LieuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToa_CachDung;
        private System.Windows.Forms.GroupBox grpXN;
        private System.Windows.Forms.DataGridView dgvXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXN_TenLoaiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXN_NgayChiDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXN_KetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXN_NgayCoKetQua;
        private System.Windows.Forms.Button btnDong;
    }
}
