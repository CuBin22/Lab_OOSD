namespace QuanLyBenhVien.Forms
{
    partial class FrmThanhToan
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
            this.grpPhieuKham = new System.Windows.Forms.GroupBox();
            this.lblLocSoPhieu = new System.Windows.Forms.Label();
            this.txtLocSoPhieu = new System.Windows.Forms.TextBox();
            this.cboLocTT = new System.Windows.Forms.ComboBox();
            this.btnTaiPhieu = new System.Windows.Forms.Button();
            this.dgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.colPhieuKham_SoPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhieuKham_MaHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhieuKham_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhieuKham_NgayGioKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhieuKham_TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhieuKham_TrangThaiTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpToaXem = new System.Windows.Forms.GroupBox();
            this.dgvToaXem = new System.Windows.Forms.DataGridView();
            this.colToaXem_TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToaXem_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToaXem_LieuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToaXem_CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpXNXem = new System.Windows.Forms.GroupBox();
            this.dgvXNXem = new System.Windows.Forms.DataGridView();
            this.colXNXem_TenLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNXem_NgayChiDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNXem_KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.lblSoPhieuChon = new System.Windows.Forms.Label();
            this.txtSoPhieuChon = new System.Windows.Forms.TextBox();
            this.lblSoBienLai = new System.Windows.Forms.Label();
            this.txtSoBienLai = new System.Windows.Forms.TextBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblSoTienTT = new System.Windows.Forms.Label();
            this.numSoTienTT = new System.Windows.Forms.NumericUpDown();
            this.lblNVThu = new System.Windows.Forms.Label();
            this.cboNVThu = new System.Windows.Forms.ComboBox();
            this.lblNgayTT = new System.Windows.Forms.Label();
            this.dtNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThaiTT = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXuatVien = new System.Windows.Forms.Button();
            this.grpGhiNhan = new System.Windows.Forms.GroupBox();
            this.lblGhiChuHS = new System.Windows.Forms.Label();
            this.txtGhiChuHS = new System.Windows.Forms.TextBox();
            this.lblNVGhiNhanHS = new System.Windows.Forms.Label();
            this.cboNVGhiNhanHS = new System.Windows.Forms.ComboBox();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaXem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXNXem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTienTT)).BeginInit();
            this.grpPhieuKham.SuspendLayout();
            this.grpToaXem.SuspendLayout();
            this.grpXNXem.SuspendLayout();
            this.grpThanhToan.SuspendLayout();
            this.grpGhiNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPhieuKham
            // 
            this.grpPhieuKham.Location = new System.Drawing.Point(10, 8);
            this.grpPhieuKham.Name = "grpPhieuKham";
            this.grpPhieuKham.Size = new System.Drawing.Size(940, 190);
            this.grpPhieuKham.TabStop = false;
            this.grpPhieuKham.TabIndex = 0;
            this.grpPhieuKham.Text = "Phiếu khám của bệnh nhân";
            this.grpPhieuKham.Controls.Add(this.lblLocSoPhieu);
            this.grpPhieuKham.Controls.Add(this.txtLocSoPhieu);
            this.grpPhieuKham.Controls.Add(this.cboLocTT);
            this.grpPhieuKham.Controls.Add(this.btnTaiPhieu);
            this.grpPhieuKham.Controls.Add(this.dgvPhieuKham);
            // 
            // lblLocSoPhieu
            // 
            this.lblLocSoPhieu.Location = new System.Drawing.Point(15, 25);
            this.lblLocSoPhieu.Name = "lblLocSoPhieu";
            this.lblLocSoPhieu.AutoSize = true;
            this.lblLocSoPhieu.Size = new System.Drawing.Size(50, 13);
            this.lblLocSoPhieu.TabIndex = 0;
            this.lblLocSoPhieu.Text = "Số phiếu khám:";
            // 
            // txtLocSoPhieu
            // 
            this.txtLocSoPhieu.Location = new System.Drawing.Point(100, 22);
            this.txtLocSoPhieu.Name = "txtLocSoPhieu";
            this.txtLocSoPhieu.Size = new System.Drawing.Size(120, 20);
            this.txtLocSoPhieu.TabIndex = 1;
            // 
            // cboLocTT
            // 
            this.cboLocTT.Location = new System.Drawing.Point(240, 22);
            this.cboLocTT.Name = "cboLocTT";
            this.cboLocTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTT.FormattingEnabled = true;
            this.cboLocTT.Items.AddRange(new object[] {
                "Chưa thanh toán",
                "Đã thanh toán",
                "Tất cả"});
            this.cboLocTT.Size = new System.Drawing.Size(150, 21);
            this.cboLocTT.TabIndex = 2;
            this.cboLocTT.SelectedIndexChanged += new System.EventHandler(this.cboLocTT_SelectedIndexChanged);
            // 
            // btnTaiPhieu
            // 
            this.btnTaiPhieu.Location = new System.Drawing.Point(405, 19);
            this.btnTaiPhieu.Name = "btnTaiPhieu";
            this.btnTaiPhieu.Size = new System.Drawing.Size(90, 27);
            this.btnTaiPhieu.TabIndex = 3;
            this.btnTaiPhieu.Text = "Tải phiếu";
            this.btnTaiPhieu.UseVisualStyleBackColor = true;
            this.btnTaiPhieu.Click += new System.EventHandler(this.btnTaiPhieu_Click);
            // 
            // dgvPhieuKham
            // 
            this.dgvPhieuKham.AllowUserToAddRows = false;
            this.dgvPhieuKham.AllowUserToDeleteRows = false;
            this.dgvPhieuKham.AllowUserToResizeRows = false;
            this.dgvPhieuKham.AutoGenerateColumns = false;
            this.dgvPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuKham.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPhieuKham_SoPhieuKham,
            this.colPhieuKham_MaHoSo,
            this.colPhieuKham_HoTen,
            this.colPhieuKham_NgayGioKham,
            this.colPhieuKham_TenBS,
            this.colPhieuKham_TrangThaiTT});
            this.dgvPhieuKham.Location = new System.Drawing.Point(10, 52);
            this.dgvPhieuKham.MultiSelect = false;
            this.dgvPhieuKham.Name = "dgvPhieuKham";
            this.dgvPhieuKham.ReadOnly = true;
            this.dgvPhieuKham.RowHeadersVisible = false;
            this.dgvPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuKham.Size = new System.Drawing.Size(920, 128);
            this.dgvPhieuKham.TabIndex = 4;
            this.dgvPhieuKham.SelectionChanged += new System.EventHandler(this.dgvPhieuKham_SelectionChanged);
            // 
            // colPhieuKham_SoPhieuKham
            // 
            this.colPhieuKham_SoPhieuKham.DataPropertyName = "SoPhieuKham";
            this.colPhieuKham_SoPhieuKham.HeaderText = "Số phiếu";
            this.colPhieuKham_SoPhieuKham.Name = "colPhieuKham_SoPhieuKham";
            this.colPhieuKham_SoPhieuKham.ReadOnly = true;
            // 
            // colPhieuKham_MaHoSo
            // 
            this.colPhieuKham_MaHoSo.DataPropertyName = "MaHoSo";
            this.colPhieuKham_MaHoSo.HeaderText = "Mã hồ sơ";
            this.colPhieuKham_MaHoSo.Name = "colPhieuKham_MaHoSo";
            this.colPhieuKham_MaHoSo.ReadOnly = true;
            // 
            // colPhieuKham_HoTen
            // 
            this.colPhieuKham_HoTen.DataPropertyName = "HoTen";
            this.colPhieuKham_HoTen.HeaderText = "Bệnh nhân";
            this.colPhieuKham_HoTen.Name = "colPhieuKham_HoTen";
            this.colPhieuKham_HoTen.ReadOnly = true;
            // 
            // colPhieuKham_NgayGioKham
            // 
            this.colPhieuKham_NgayGioKham.DataPropertyName = "NgayGioKham";
            this.colPhieuKham_NgayGioKham.HeaderText = "Ngày giờ khám";
            this.colPhieuKham_NgayGioKham.Name = "colPhieuKham_NgayGioKham";
            this.colPhieuKham_NgayGioKham.ReadOnly = true;
            // 
            // colPhieuKham_TenBS
            // 
            this.colPhieuKham_TenBS.DataPropertyName = "TenBS";
            this.colPhieuKham_TenBS.HeaderText = "Bác sĩ";
            this.colPhieuKham_TenBS.Name = "colPhieuKham_TenBS";
            this.colPhieuKham_TenBS.ReadOnly = true;
            // 
            // colPhieuKham_TrangThaiTT
            // 
            this.colPhieuKham_TrangThaiTT.DataPropertyName = "TrangThaiTT";
            this.colPhieuKham_TrangThaiTT.HeaderText = "Thanh toán";
            this.colPhieuKham_TrangThaiTT.Name = "colPhieuKham_TrangThaiTT";
            this.colPhieuKham_TrangThaiTT.ReadOnly = true;
            // 
            // grpToaXem
            // 
            this.grpToaXem.Location = new System.Drawing.Point(10, 204);
            this.grpToaXem.Name = "grpToaXem";
            this.grpToaXem.Size = new System.Drawing.Size(460, 160);
            this.grpToaXem.TabStop = false;
            this.grpToaXem.TabIndex = 1;
            this.grpToaXem.Text = "Toa thuốc của phiếu khám";
            this.grpToaXem.Controls.Add(this.dgvToaXem);
            // 
            // dgvToaXem
            // 
            this.dgvToaXem.AllowUserToAddRows = false;
            this.dgvToaXem.AllowUserToDeleteRows = false;
            this.dgvToaXem.AllowUserToResizeRows = false;
            this.dgvToaXem.AutoGenerateColumns = false;
            this.dgvToaXem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToaXem.BackgroundColor = System.Drawing.Color.White;
            this.dgvToaXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaXem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colToaXem_TenThuoc,
            this.colToaXem_SoLuong,
            this.colToaXem_LieuDung,
            this.colToaXem_CachDung});
            this.dgvToaXem.Location = new System.Drawing.Point(10, 20);
            this.dgvToaXem.MultiSelect = false;
            this.dgvToaXem.Name = "dgvToaXem";
            this.dgvToaXem.ReadOnly = true;
            this.dgvToaXem.RowHeadersVisible = false;
            this.dgvToaXem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToaXem.Size = new System.Drawing.Size(440, 130);
            this.dgvToaXem.TabIndex = 0;
            // 
            // colToaXem_TenThuoc
            // 
            this.colToaXem_TenThuoc.DataPropertyName = "TenThuoc";
            this.colToaXem_TenThuoc.HeaderText = "Thuốc";
            this.colToaXem_TenThuoc.Name = "colToaXem_TenThuoc";
            this.colToaXem_TenThuoc.ReadOnly = true;
            // 
            // colToaXem_SoLuong
            // 
            this.colToaXem_SoLuong.DataPropertyName = "SoLuong";
            this.colToaXem_SoLuong.HeaderText = "Số lượng";
            this.colToaXem_SoLuong.Name = "colToaXem_SoLuong";
            this.colToaXem_SoLuong.ReadOnly = true;
            // 
            // colToaXem_LieuDung
            // 
            this.colToaXem_LieuDung.DataPropertyName = "LieuDung";
            this.colToaXem_LieuDung.HeaderText = "Liều dùng";
            this.colToaXem_LieuDung.Name = "colToaXem_LieuDung";
            this.colToaXem_LieuDung.ReadOnly = true;
            // 
            // colToaXem_CachDung
            // 
            this.colToaXem_CachDung.DataPropertyName = "CachDung";
            this.colToaXem_CachDung.HeaderText = "Cách dùng";
            this.colToaXem_CachDung.Name = "colToaXem_CachDung";
            this.colToaXem_CachDung.ReadOnly = true;
            // 
            // grpXNXem
            // 
            this.grpXNXem.Location = new System.Drawing.Point(480, 204);
            this.grpXNXem.Name = "grpXNXem";
            this.grpXNXem.Size = new System.Drawing.Size(470, 160);
            this.grpXNXem.TabStop = false;
            this.grpXNXem.TabIndex = 2;
            this.grpXNXem.Text = "Xét nghiệm của phiếu khám";
            this.grpXNXem.Controls.Add(this.dgvXNXem);
            // 
            // dgvXNXem
            // 
            this.dgvXNXem.AllowUserToAddRows = false;
            this.dgvXNXem.AllowUserToDeleteRows = false;
            this.dgvXNXem.AllowUserToResizeRows = false;
            this.dgvXNXem.AutoGenerateColumns = false;
            this.dgvXNXem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXNXem.BackgroundColor = System.Drawing.Color.White;
            this.dgvXNXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXNXem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colXNXem_TenLoaiXN,
            this.colXNXem_NgayChiDinh,
            this.colXNXem_KetQua});
            this.dgvXNXem.Location = new System.Drawing.Point(10, 20);
            this.dgvXNXem.MultiSelect = false;
            this.dgvXNXem.Name = "dgvXNXem";
            this.dgvXNXem.ReadOnly = true;
            this.dgvXNXem.RowHeadersVisible = false;
            this.dgvXNXem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXNXem.Size = new System.Drawing.Size(450, 130);
            this.dgvXNXem.TabIndex = 0;
            // 
            // colXNXem_TenLoaiXN
            // 
            this.colXNXem_TenLoaiXN.DataPropertyName = "TenLoaiXN";
            this.colXNXem_TenLoaiXN.HeaderText = "Loại xét nghiệm";
            this.colXNXem_TenLoaiXN.Name = "colXNXem_TenLoaiXN";
            this.colXNXem_TenLoaiXN.ReadOnly = true;
            // 
            // colXNXem_NgayChiDinh
            // 
            this.colXNXem_NgayChiDinh.DataPropertyName = "NgayChiDinh";
            this.colXNXem_NgayChiDinh.HeaderText = "Ngày chỉ định";
            this.colXNXem_NgayChiDinh.Name = "colXNXem_NgayChiDinh";
            this.colXNXem_NgayChiDinh.ReadOnly = true;
            // 
            // colXNXem_KetQua
            // 
            this.colXNXem_KetQua.DataPropertyName = "KetQua";
            this.colXNXem_KetQua.HeaderText = "Kết quả";
            this.colXNXem_KetQua.Name = "colXNXem_KetQua";
            this.colXNXem_KetQua.ReadOnly = true;
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Location = new System.Drawing.Point(10, 370);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(940, 110);
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.TabIndex = 3;
            this.grpThanhToan.Text = "Thanh toán viện phí";
            this.grpThanhToan.Controls.Add(this.lblSoPhieuChon);
            this.grpThanhToan.Controls.Add(this.txtSoPhieuChon);
            this.grpThanhToan.Controls.Add(this.lblSoBienLai);
            this.grpThanhToan.Controls.Add(this.txtSoBienLai);
            this.grpThanhToan.Controls.Add(this.lblHinhThuc);
            this.grpThanhToan.Controls.Add(this.cboHinhThuc);
            this.grpThanhToan.Controls.Add(this.lblSoTienTT);
            this.grpThanhToan.Controls.Add(this.numSoTienTT);
            this.grpThanhToan.Controls.Add(this.lblNVThu);
            this.grpThanhToan.Controls.Add(this.cboNVThu);
            this.grpThanhToan.Controls.Add(this.lblNgayTT);
            this.grpThanhToan.Controls.Add(this.dtNgayThanhToan);
            this.grpThanhToan.Controls.Add(this.lblTrangThaiTT);
            this.grpThanhToan.Controls.Add(this.btnThanhToan);
            this.grpThanhToan.Controls.Add(this.btnXuatVien);
            // 
            // lblSoPhieuChon
            // 
            this.lblSoPhieuChon.Location = new System.Drawing.Point(15, 29);
            this.lblSoPhieuChon.Name = "lblSoPhieuChon";
            this.lblSoPhieuChon.AutoSize = true;
            this.lblSoPhieuChon.Size = new System.Drawing.Size(50, 13);
            this.lblSoPhieuChon.TabIndex = 0;
            this.lblSoPhieuChon.Text = "Phiếu khám:";
            // 
            // txtSoPhieuChon
            // 
            this.txtSoPhieuChon.Location = new System.Drawing.Point(85, 26);
            this.txtSoPhieuChon.Name = "txtSoPhieuChon";
            this.txtSoPhieuChon.Size = new System.Drawing.Size(100, 20);
            this.txtSoPhieuChon.TabIndex = 1;
            this.txtSoPhieuChon.ReadOnly = true;
            // 
            // lblSoBienLai
            // 
            this.lblSoBienLai.Location = new System.Drawing.Point(205, 29);
            this.lblSoBienLai.Name = "lblSoBienLai";
            this.lblSoBienLai.AutoSize = true;
            this.lblSoBienLai.Size = new System.Drawing.Size(50, 13);
            this.lblSoBienLai.TabIndex = 2;
            this.lblSoBienLai.Text = "Số biên lai:";
            // 
            // txtSoBienLai
            // 
            this.txtSoBienLai.Location = new System.Drawing.Point(275, 26);
            this.txtSoBienLai.Name = "txtSoBienLai";
            this.txtSoBienLai.Size = new System.Drawing.Size(100, 20);
            this.txtSoBienLai.TabIndex = 3;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.Location = new System.Drawing.Point(395, 29);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Size = new System.Drawing.Size(50, 13);
            this.lblHinhThuc.TabIndex = 4;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.Location = new System.Drawing.Point(455, 26);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
                "Tiền mặt",
                "Chuyển khoản",
                "Thẻ",
                "Ví điện tử"});
            this.cboHinhThuc.Size = new System.Drawing.Size(110, 21);
            this.cboHinhThuc.TabIndex = 5;
            // 
            // lblSoTienTT
            // 
            this.lblSoTienTT.Location = new System.Drawing.Point(585, 29);
            this.lblSoTienTT.Name = "lblSoTienTT";
            this.lblSoTienTT.AutoSize = true;
            this.lblSoTienTT.Size = new System.Drawing.Size(50, 13);
            this.lblSoTienTT.TabIndex = 6;
            this.lblSoTienTT.Text = "Số tiền:";
            // 
            // numSoTienTT
            // 
            this.numSoTienTT.Location = new System.Drawing.Point(635, 26);
            this.numSoTienTT.Name = "numSoTienTT";
            this.numSoTienTT.Size = new System.Drawing.Size(120, 20);
            this.numSoTienTT.TabIndex = 7;
            this.numSoTienTT.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0});
            this.numSoTienTT.Minimum = new decimal(new int[] { 0, 0, 0, 0});
            this.numSoTienTT.Value = new decimal(new int[] { 0, 0, 0, 0});
            this.numSoTienTT.ThousandsSeparator = true;
            this.numSoTienTT.Increment = new decimal(new int[] { 1000, 0, 0, 0});
            // 
            // lblNVThu
            // 
            this.lblNVThu.Location = new System.Drawing.Point(775, 29);
            this.lblNVThu.Name = "lblNVThu";
            this.lblNVThu.AutoSize = true;
            this.lblNVThu.Size = new System.Drawing.Size(50, 13);
            this.lblNVThu.TabIndex = 8;
            this.lblNVThu.Text = "NV thu:";
            // 
            // cboNVThu
            // 
            this.cboNVThu.Location = new System.Drawing.Point(820, 26);
            this.cboNVThu.Name = "cboNVThu";
            this.cboNVThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVThu.FormattingEnabled = true;
            this.cboNVThu.Size = new System.Drawing.Size(105, 21);
            this.cboNVThu.TabIndex = 9;
            // 
            // lblNgayTT
            // 
            this.lblNgayTT.Location = new System.Drawing.Point(15, 71);
            this.lblNgayTT.Name = "lblNgayTT";
            this.lblNgayTT.AutoSize = true;
            this.lblNgayTT.Size = new System.Drawing.Size(50, 13);
            this.lblNgayTT.TabIndex = 10;
            this.lblNgayTT.Text = "Ngày thanh toán:";
            // 
            // dtNgayThanhToan
            // 
            this.dtNgayThanhToan.Location = new System.Drawing.Point(105, 68);
            this.dtNgayThanhToan.Name = "dtNgayThanhToan";
            this.dtNgayThanhToan.Size = new System.Drawing.Size(150, 20);
            this.dtNgayThanhToan.TabIndex = 11;
            this.dtNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThanhToan.CustomFormat = "dd/MM/yyyy HH:mm";
            // 
            // lblTrangThaiTT
            // 
            this.lblTrangThaiTT.Location = new System.Drawing.Point(280, 74);
            this.lblTrangThaiTT.Name = "lblTrangThaiTT";
            this.lblTrangThaiTT.AutoSize = true;
            this.lblTrangThaiTT.Size = new System.Drawing.Size(50, 13);
            this.lblTrangThaiTT.TabIndex = 12;
            this.lblTrangThaiTT.Text = "Trạng thái: chưa chọn phiếu.";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(650, 62);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(130, 30);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXuatVien
            // 
            this.btnXuatVien.Location = new System.Drawing.Point(790, 62);
            this.btnXuatVien.Name = "btnXuatVien";
            this.btnXuatVien.Size = new System.Drawing.Size(135, 30);
            this.btnXuatVien.TabIndex = 14;
            this.btnXuatVien.Text = "Hoàn tất xuất viện";
            this.btnXuatVien.UseVisualStyleBackColor = true;
            this.btnXuatVien.Click += new System.EventHandler(this.btnXuatVien_Click);
            // 
            // grpGhiNhan
            // 
            this.grpGhiNhan.Location = new System.Drawing.Point(10, 486);
            this.grpGhiNhan.Name = "grpGhiNhan";
            this.grpGhiNhan.Size = new System.Drawing.Size(940, 110);
            this.grpGhiNhan.TabStop = false;
            this.grpGhiNhan.TabIndex = 4;
            this.grpGhiNhan.Text = "Ghi nhận vào hồ sơ (Phòng chăm sóc khách hàng)";
            this.grpGhiNhan.Controls.Add(this.lblGhiChuHS);
            this.grpGhiNhan.Controls.Add(this.txtGhiChuHS);
            this.grpGhiNhan.Controls.Add(this.lblNVGhiNhanHS);
            this.grpGhiNhan.Controls.Add(this.cboNVGhiNhanHS);
            this.grpGhiNhan.Controls.Add(this.btnGhiNhan);
            // 
            // lblGhiChuHS
            // 
            this.lblGhiChuHS.Location = new System.Drawing.Point(15, 31);
            this.lblGhiChuHS.Name = "lblGhiChuHS";
            this.lblGhiChuHS.AutoSize = true;
            this.lblGhiChuHS.Size = new System.Drawing.Size(50, 13);
            this.lblGhiChuHS.TabIndex = 0;
            this.lblGhiChuHS.Text = "Ghi chú:";
            // 
            // txtGhiChuHS
            // 
            this.txtGhiChuHS.Location = new System.Drawing.Point(65, 28);
            this.txtGhiChuHS.Name = "txtGhiChuHS";
            this.txtGhiChuHS.Size = new System.Drawing.Size(860, 40);
            this.txtGhiChuHS.TabIndex = 1;
            this.txtGhiChuHS.Multiline = true;
            this.txtGhiChuHS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // lblNVGhiNhanHS
            // 
            this.lblNVGhiNhanHS.Location = new System.Drawing.Point(15, 79);
            this.lblNVGhiNhanHS.Name = "lblNVGhiNhanHS";
            this.lblNVGhiNhanHS.AutoSize = true;
            this.lblNVGhiNhanHS.Size = new System.Drawing.Size(50, 13);
            this.lblNVGhiNhanHS.TabIndex = 2;
            this.lblNVGhiNhanHS.Text = "NV ghi nhận:";
            // 
            // cboNVGhiNhanHS
            // 
            this.cboNVGhiNhanHS.Location = new System.Drawing.Point(90, 76);
            this.cboNVGhiNhanHS.Name = "cboNVGhiNhanHS";
            this.cboNVGhiNhanHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVGhiNhanHS.FormattingEnabled = true;
            this.cboNVGhiNhanHS.Size = new System.Drawing.Size(190, 21);
            this.cboNVGhiNhanHS.TabIndex = 3;
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(760, 70);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(165, 30);
            this.btnGhiNhan.TabIndex = 4;
            this.btnGhiNhan.Text = "Ghi nhận vào hồ sơ";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(850, 610);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 27);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 655);
            this.Controls.Add(this.grpPhieuKham);
            this.Controls.Add(this.grpToaXem);
            this.Controls.Add(this.grpXNXem);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.grpGhiNhan);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất viện - Thanh toán viện phí - Ghi nhận";
            this.Load += new System.EventHandler(this.FrmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaXem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXNXem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTienTT)).EndInit();
            this.grpPhieuKham.ResumeLayout(false);
            this.grpPhieuKham.PerformLayout();
            this.grpToaXem.ResumeLayout(false);
            this.grpToaXem.PerformLayout();
            this.grpXNXem.ResumeLayout(false);
            this.grpXNXem.PerformLayout();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.grpGhiNhan.ResumeLayout(false);
            this.grpGhiNhan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPhieuKham;
        private System.Windows.Forms.Label lblLocSoPhieu;
        private System.Windows.Forms.TextBox txtLocSoPhieu;
        private System.Windows.Forms.ComboBox cboLocTT;
        private System.Windows.Forms.Button btnTaiPhieu;
        private System.Windows.Forms.DataGridView dgvPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuKham_SoPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuKham_MaHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuKham_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuKham_NgayGioKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuKham_TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuKham_TrangThaiTT;
        private System.Windows.Forms.GroupBox grpToaXem;
        private System.Windows.Forms.DataGridView dgvToaXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaXem_TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaXem_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaXem_LieuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaXem_CachDung;
        private System.Windows.Forms.GroupBox grpXNXem;
        private System.Windows.Forms.DataGridView dgvXNXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNXem_TenLoaiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNXem_NgayChiDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNXem_KetQua;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblSoPhieuChon;
        private System.Windows.Forms.TextBox txtSoPhieuChon;
        private System.Windows.Forms.Label lblSoBienLai;
        private System.Windows.Forms.TextBox txtSoBienLai;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Label lblSoTienTT;
        private System.Windows.Forms.NumericUpDown numSoTienTT;
        private System.Windows.Forms.Label lblNVThu;
        private System.Windows.Forms.ComboBox cboNVThu;
        private System.Windows.Forms.Label lblNgayTT;
        private System.Windows.Forms.DateTimePicker dtNgayThanhToan;
        private System.Windows.Forms.Label lblTrangThaiTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXuatVien;
        private System.Windows.Forms.GroupBox grpGhiNhan;
        private System.Windows.Forms.Label lblGhiChuHS;
        private System.Windows.Forms.TextBox txtGhiChuHS;
        private System.Windows.Forms.Label lblNVGhiNhanHS;
        private System.Windows.Forms.ComboBox cboNVGhiNhanHS;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.Button btnDong;
    }
}
