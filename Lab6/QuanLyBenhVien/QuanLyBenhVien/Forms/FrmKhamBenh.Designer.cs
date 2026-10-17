namespace QuanLyBenhVien.Forms
{
    partial class FrmKhamBenh
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
            this.tabKham = new System.Windows.Forms.TabControl();
            this.tabPhieuKham = new System.Windows.Forms.TabPage();
            this.grpTraCuuHS = new System.Windows.Forms.GroupBox();
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.btnTimHoSo = new System.Windows.Forms.Button();
            this.lblThongTinBN = new System.Windows.Forms.Label();
            this.grpPhieu = new System.Windows.Forms.GroupBox();
            this.lblSoPhieuKham = new System.Windows.Forms.Label();
            this.txtSoPhieuKham = new System.Windows.Forms.TextBox();
            this.lblNgayGioKham = new System.Windows.Forms.Label();
            this.dtNgayGioKham = new System.Windows.Forms.DateTimePicker();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblLoaiKham = new System.Windows.Forms.Label();
            this.cboLoaiKham = new System.Windows.Forms.ComboBox();
            this.lblNVGhiNhan = new System.Windows.Forms.Label();
            this.cboNVGhiNhan = new System.Windows.Forms.ComboBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblThanNhiet = new System.Windows.Forms.Label();
            this.numThanNhiet = new System.Windows.Forms.NumericUpDown();
            this.lblHuyetAp = new System.Windows.Forms.Label();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.lblKetLuan = new System.Windows.Forms.Label();
            this.txtKetLuan = new System.Windows.Forms.TextBox();
            this.grpLichSu = new System.Windows.Forms.GroupBox();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.colLichSu_SoPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_NgayGioKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichSu_KetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpXetNghiem = new System.Windows.Forms.GroupBox();
            this.lblLoaiXN = new System.Windows.Forms.Label();
            this.cboLoaiXN = new System.Windows.Forms.ComboBox();
            this.btnThemXN = new System.Windows.Forms.Button();
            this.btnBoXN = new System.Windows.Forms.Button();
            this.dgvXNChon = new System.Windows.Forms.DataGridView();
            this.colXNChon_MaLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNChon_TenLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpToa = new System.Windows.Forms.GroupBox();
            this.lblMaToa = new System.Windows.Forms.Label();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblLieuDung = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnBoThuoc = new System.Windows.Forms.Button();
            this.dgvToaChon = new System.Windows.Forms.DataGridView();
            this.colToaChon_MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToaChon_TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToaChon_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToaChon_LieuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToaChon_CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.btnLamMoiPhieu = new System.Windows.Forms.Button();
            this.tabKetQuaXN = new System.Windows.Forms.TabPage();
            this.lblDSXN = new System.Windows.Forms.Label();
            this.dgvXNChoKQ = new System.Windows.Forms.DataGridView();
            this.colXNChoKQ_MaXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNChoKQ_SoPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNChoKQ_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNChoKQ_TenLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNChoKQ_NgayChiDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNChoKQ_KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXNChoKQ_NgayCoKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGhiKQ = new System.Windows.Forms.GroupBox();
            this.lblMaXNChon = new System.Windows.Forms.Label();
            this.txtMaXNChon = new System.Windows.Forms.TextBox();
            this.lblNgayCoKQ = new System.Windows.Forms.Label();
            this.dtNgayCoKetQua = new System.Windows.Forms.DateTimePicker();
            this.lblNVXN = new System.Windows.Forms.Label();
            this.cboNVXetNghiem = new System.Windows.Forms.ComboBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGhiKetQua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numThanNhiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXNChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXNChoKQ)).BeginInit();
            this.tabKham.SuspendLayout();
            this.tabPhieuKham.SuspendLayout();
            this.grpTraCuuHS.SuspendLayout();
            this.grpPhieu.SuspendLayout();
            this.grpLichSu.SuspendLayout();
            this.grpXetNghiem.SuspendLayout();
            this.grpToa.SuspendLayout();
            this.tabKetQuaXN.SuspendLayout();
            this.grpGhiKQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKham
            // 
            this.tabKham.Location = new System.Drawing.Point(10, 10);
            this.tabKham.Name = "tabKham";
            this.tabKham.SelectedIndex = 0;
            this.tabKham.Size = new System.Drawing.Size(1080, 645);
            this.tabKham.TabIndex = 0;
            this.tabKham.Controls.Add(this.tabPhieuKham);
            this.tabKham.Controls.Add(this.tabKetQuaXN);
            // 
            // tabPhieuKham
            // 
            this.tabPhieuKham.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuKham.Name = "tabPhieuKham";
            this.tabPhieuKham.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuKham.Size = new System.Drawing.Size(1072, 619);
            this.tabPhieuKham.TabIndex = 0;
            this.tabPhieuKham.Text = "Lập phiếu khám";
            this.tabPhieuKham.UseVisualStyleBackColor = true;
            this.tabPhieuKham.Controls.Add(this.grpTraCuuHS);
            this.tabPhieuKham.Controls.Add(this.grpPhieu);
            this.tabPhieuKham.Controls.Add(this.grpLichSu);
            this.tabPhieuKham.Controls.Add(this.grpXetNghiem);
            this.tabPhieuKham.Controls.Add(this.grpToa);
            this.tabPhieuKham.Controls.Add(this.btnLuuPhieu);
            this.tabPhieuKham.Controls.Add(this.btnLamMoiPhieu);
            // 
            // grpTraCuuHS
            // 
            this.grpTraCuuHS.Location = new System.Drawing.Point(10, 6);
            this.grpTraCuuHS.Name = "grpTraCuuHS";
            this.grpTraCuuHS.Size = new System.Drawing.Size(1050, 52);
            this.grpTraCuuHS.TabStop = false;
            this.grpTraCuuHS.TabIndex = 0;
            this.grpTraCuuHS.Text = "Hồ sơ bệnh án";
            this.grpTraCuuHS.Controls.Add(this.lblMaHoSo);
            this.grpTraCuuHS.Controls.Add(this.txtMaHoSo);
            this.grpTraCuuHS.Controls.Add(this.btnTimHoSo);
            this.grpTraCuuHS.Controls.Add(this.lblThongTinBN);
            // 
            // lblMaHoSo
            // 
            this.lblMaHoSo.Location = new System.Drawing.Point(15, 25);
            this.lblMaHoSo.Name = "lblMaHoSo";
            this.lblMaHoSo.AutoSize = true;
            this.lblMaHoSo.Size = new System.Drawing.Size(50, 13);
            this.lblMaHoSo.TabIndex = 0;
            this.lblMaHoSo.Text = "Mã hồ sơ:";
            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Location = new System.Drawing.Point(80, 21);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Size = new System.Drawing.Size(120, 20);
            this.txtMaHoSo.TabIndex = 1;
            // 
            // btnTimHoSo
            // 
            this.btnTimHoSo.Location = new System.Drawing.Point(210, 19);
            this.btnTimHoSo.Name = "btnTimHoSo";
            this.btnTimHoSo.Size = new System.Drawing.Size(90, 27);
            this.btnTimHoSo.TabIndex = 2;
            this.btnTimHoSo.Text = "Tìm hồ sơ";
            this.btnTimHoSo.UseVisualStyleBackColor = true;
            this.btnTimHoSo.Click += new System.EventHandler(this.btnTimHoSo_Click);
            // 
            // lblThongTinBN
            // 
            this.lblThongTinBN.Location = new System.Drawing.Point(320, 27);
            this.lblThongTinBN.Name = "lblThongTinBN";
            this.lblThongTinBN.AutoSize = true;
            this.lblThongTinBN.Size = new System.Drawing.Size(50, 13);
            this.lblThongTinBN.TabIndex = 3;
            this.lblThongTinBN.Text = "Chưa chọn hồ sơ.";
            // 
            // grpPhieu
            // 
            this.grpPhieu.Location = new System.Drawing.Point(10, 62);
            this.grpPhieu.Name = "grpPhieu";
            this.grpPhieu.Size = new System.Drawing.Size(520, 245);
            this.grpPhieu.TabStop = false;
            this.grpPhieu.TabIndex = 1;
            this.grpPhieu.Text = "Phiếu khám";
            this.grpPhieu.Controls.Add(this.lblSoPhieuKham);
            this.grpPhieu.Controls.Add(this.txtSoPhieuKham);
            this.grpPhieu.Controls.Add(this.lblNgayGioKham);
            this.grpPhieu.Controls.Add(this.dtNgayGioKham);
            this.grpPhieu.Controls.Add(this.lblBacSi);
            this.grpPhieu.Controls.Add(this.cboBacSi);
            this.grpPhieu.Controls.Add(this.lblKhoa);
            this.grpPhieu.Controls.Add(this.cboKhoa);
            this.grpPhieu.Controls.Add(this.lblLoaiKham);
            this.grpPhieu.Controls.Add(this.cboLoaiKham);
            this.grpPhieu.Controls.Add(this.lblNVGhiNhan);
            this.grpPhieu.Controls.Add(this.cboNVGhiNhan);
            this.grpPhieu.Controls.Add(this.lblTrieuChung);
            this.grpPhieu.Controls.Add(this.txtTrieuChung);
            this.grpPhieu.Controls.Add(this.lblThanNhiet);
            this.grpPhieu.Controls.Add(this.numThanNhiet);
            this.grpPhieu.Controls.Add(this.lblHuyetAp);
            this.grpPhieu.Controls.Add(this.txtHuyetAp);
            this.grpPhieu.Controls.Add(this.lblKetLuan);
            this.grpPhieu.Controls.Add(this.txtKetLuan);
            // 
            // lblSoPhieuKham
            // 
            this.lblSoPhieuKham.Location = new System.Drawing.Point(12, 27);
            this.lblSoPhieuKham.Name = "lblSoPhieuKham";
            this.lblSoPhieuKham.AutoSize = true;
            this.lblSoPhieuKham.Size = new System.Drawing.Size(50, 13);
            this.lblSoPhieuKham.TabIndex = 0;
            this.lblSoPhieuKham.Text = "Số phiếu khám:";
            // 
            // txtSoPhieuKham
            // 
            this.txtSoPhieuKham.Location = new System.Drawing.Point(95, 24);
            this.txtSoPhieuKham.Name = "txtSoPhieuKham";
            this.txtSoPhieuKham.Size = new System.Drawing.Size(110, 20);
            this.txtSoPhieuKham.TabIndex = 1;
            // 
            // lblNgayGioKham
            // 
            this.lblNgayGioKham.Location = new System.Drawing.Point(235, 27);
            this.lblNgayGioKham.Name = "lblNgayGioKham";
            this.lblNgayGioKham.AutoSize = true;
            this.lblNgayGioKham.Size = new System.Drawing.Size(50, 13);
            this.lblNgayGioKham.TabIndex = 2;
            this.lblNgayGioKham.Text = "Ngày giờ khám:";
            // 
            // dtNgayGioKham
            // 
            this.dtNgayGioKham.Location = new System.Drawing.Point(322, 24);
            this.dtNgayGioKham.Name = "dtNgayGioKham";
            this.dtNgayGioKham.Size = new System.Drawing.Size(180, 20);
            this.dtNgayGioKham.TabIndex = 3;
            this.dtNgayGioKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGioKham.CustomFormat = "dd/MM/yyyy HH:mm";
            // 
            // lblBacSi
            // 
            this.lblBacSi.Location = new System.Drawing.Point(12, 57);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Size = new System.Drawing.Size(50, 13);
            this.lblBacSi.TabIndex = 4;
            this.lblBacSi.Text = "Bác sĩ khám:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.Location = new System.Drawing.Point(95, 54);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Size = new System.Drawing.Size(140, 21);
            this.cboBacSi.TabIndex = 5;
            this.cboBacSi.SelectedIndexChanged += new System.EventHandler(this.cboBacSi_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.Location = new System.Drawing.Point(255, 57);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Size = new System.Drawing.Size(50, 13);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.Location = new System.Drawing.Point(322, 54);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Size = new System.Drawing.Size(180, 21);
            this.cboKhoa.TabIndex = 7;
            // 
            // lblLoaiKham
            // 
            this.lblLoaiKham.Location = new System.Drawing.Point(12, 87);
            this.lblLoaiKham.Name = "lblLoaiKham";
            this.lblLoaiKham.AutoSize = true;
            this.lblLoaiKham.Size = new System.Drawing.Size(50, 13);
            this.lblLoaiKham.TabIndex = 8;
            this.lblLoaiKham.Text = "Loại khám:";
            // 
            // cboLoaiKham
            // 
            this.cboLoaiKham.Location = new System.Drawing.Point(95, 84);
            this.cboLoaiKham.Name = "cboLoaiKham";
            this.cboLoaiKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKham.FormattingEnabled = true;
            this.cboLoaiKham.Items.AddRange(new object[] {
                "Khám bệnh",
                "Khám định kỳ"});
            this.cboLoaiKham.Size = new System.Drawing.Size(140, 21);
            this.cboLoaiKham.TabIndex = 9;
            this.cboLoaiKham.SelectedIndexChanged += new System.EventHandler(this.cboLoaiKham_SelectedIndexChanged);
            // 
            // lblNVGhiNhan
            // 
            this.lblNVGhiNhan.Location = new System.Drawing.Point(255, 87);
            this.lblNVGhiNhan.Name = "lblNVGhiNhan";
            this.lblNVGhiNhan.AutoSize = true;
            this.lblNVGhiNhan.Size = new System.Drawing.Size(50, 13);
            this.lblNVGhiNhan.TabIndex = 10;
            this.lblNVGhiNhan.Text = "NV ghi nhận:";
            // 
            // cboNVGhiNhan
            // 
            this.cboNVGhiNhan.Location = new System.Drawing.Point(322, 84);
            this.cboNVGhiNhan.Name = "cboNVGhiNhan";
            this.cboNVGhiNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVGhiNhan.FormattingEnabled = true;
            this.cboNVGhiNhan.Size = new System.Drawing.Size(180, 21);
            this.cboNVGhiNhan.TabIndex = 11;
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.Location = new System.Drawing.Point(12, 117);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Size = new System.Drawing.Size(50, 13);
            this.lblTrieuChung.TabIndex = 12;
            this.lblTrieuChung.Text = "Triệu chứng:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(95, 114);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(407, 42);
            this.txtTrieuChung.TabIndex = 13;
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // lblThanNhiet
            // 
            this.lblThanNhiet.Location = new System.Drawing.Point(12, 169);
            this.lblThanNhiet.Name = "lblThanNhiet";
            this.lblThanNhiet.AutoSize = true;
            this.lblThanNhiet.Size = new System.Drawing.Size(50, 13);
            this.lblThanNhiet.TabIndex = 14;
            this.lblThanNhiet.Text = "Thân nhiệt (°C):";
            // 
            // numThanNhiet
            // 
            this.numThanNhiet.Location = new System.Drawing.Point(95, 166);
            this.numThanNhiet.Name = "numThanNhiet";
            this.numThanNhiet.Size = new System.Drawing.Size(70, 20);
            this.numThanNhiet.TabIndex = 15;
            this.numThanNhiet.Maximum = new decimal(new int[] { 450, 0, 0, 65536});
            this.numThanNhiet.Minimum = new decimal(new int[] { 300, 0, 0, 65536});
            this.numThanNhiet.Value = new decimal(new int[] { 370, 0, 0, 65536});
            this.numThanNhiet.DecimalPlaces = 1;
            this.numThanNhiet.Increment = new decimal(new int[] { 1, 0, 0, 65536});
            // 
            // lblHuyetAp
            // 
            this.lblHuyetAp.Location = new System.Drawing.Point(235, 169);
            this.lblHuyetAp.Name = "lblHuyetAp";
            this.lblHuyetAp.AutoSize = true;
            this.lblHuyetAp.Size = new System.Drawing.Size(50, 13);
            this.lblHuyetAp.TabIndex = 16;
            this.lblHuyetAp.Text = "Huyết áp:";
            // 
            // txtHuyetAp
            // 
            this.txtHuyetAp.Location = new System.Drawing.Point(322, 166);
            this.txtHuyetAp.Name = "txtHuyetAp";
            this.txtHuyetAp.Size = new System.Drawing.Size(90, 20);
            this.txtHuyetAp.TabIndex = 17;
            // 
            // lblKetLuan
            // 
            this.lblKetLuan.Location = new System.Drawing.Point(12, 199);
            this.lblKetLuan.Name = "lblKetLuan";
            this.lblKetLuan.AutoSize = true;
            this.lblKetLuan.Size = new System.Drawing.Size(50, 13);
            this.lblKetLuan.TabIndex = 18;
            this.lblKetLuan.Text = "Kết luận:";
            // 
            // txtKetLuan
            // 
            this.txtKetLuan.Location = new System.Drawing.Point(95, 196);
            this.txtKetLuan.Name = "txtKetLuan";
            this.txtKetLuan.Size = new System.Drawing.Size(407, 40);
            this.txtKetLuan.TabIndex = 19;
            this.txtKetLuan.Multiline = true;
            this.txtKetLuan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // grpLichSu
            // 
            this.grpLichSu.Location = new System.Drawing.Point(540, 62);
            this.grpLichSu.Name = "grpLichSu";
            this.grpLichSu.Size = new System.Drawing.Size(520, 245);
            this.grpLichSu.TabStop = false;
            this.grpLichSu.TabIndex = 2;
            this.grpLichSu.Text = "Lịch sử khám của hồ sơ";
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
            this.dgvLichSu.Size = new System.Drawing.Size(500, 215);
            this.dgvLichSu.TabIndex = 0;
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
            // grpXetNghiem
            // 
            this.grpXetNghiem.Location = new System.Drawing.Point(10, 312);
            this.grpXetNghiem.Name = "grpXetNghiem";
            this.grpXetNghiem.Size = new System.Drawing.Size(520, 265);
            this.grpXetNghiem.TabStop = false;
            this.grpXetNghiem.TabIndex = 3;
            this.grpXetNghiem.Text = "Chỉ định xét nghiệm";
            this.grpXetNghiem.Controls.Add(this.lblLoaiXN);
            this.grpXetNghiem.Controls.Add(this.cboLoaiXN);
            this.grpXetNghiem.Controls.Add(this.btnThemXN);
            this.grpXetNghiem.Controls.Add(this.btnBoXN);
            this.grpXetNghiem.Controls.Add(this.dgvXNChon);
            // 
            // lblLoaiXN
            // 
            this.lblLoaiXN.Location = new System.Drawing.Point(12, 29);
            this.lblLoaiXN.Name = "lblLoaiXN";
            this.lblLoaiXN.AutoSize = true;
            this.lblLoaiXN.Size = new System.Drawing.Size(50, 13);
            this.lblLoaiXN.TabIndex = 0;
            this.lblLoaiXN.Text = "Loại xét nghiệm:";
            // 
            // cboLoaiXN
            // 
            this.cboLoaiXN.Location = new System.Drawing.Point(105, 26);
            this.cboLoaiXN.Name = "cboLoaiXN";
            this.cboLoaiXN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiXN.FormattingEnabled = true;
            this.cboLoaiXN.Size = new System.Drawing.Size(235, 21);
            this.cboLoaiXN.TabIndex = 1;
            // 
            // btnThemXN
            // 
            this.btnThemXN.Location = new System.Drawing.Point(350, 23);
            this.btnThemXN.Name = "btnThemXN";
            this.btnThemXN.Size = new System.Drawing.Size(75, 27);
            this.btnThemXN.TabIndex = 2;
            this.btnThemXN.Text = "Thêm";
            this.btnThemXN.UseVisualStyleBackColor = true;
            this.btnThemXN.Click += new System.EventHandler(this.btnThemXN_Click);
            // 
            // btnBoXN
            // 
            this.btnBoXN.Location = new System.Drawing.Point(430, 23);
            this.btnBoXN.Name = "btnBoXN";
            this.btnBoXN.Size = new System.Drawing.Size(75, 27);
            this.btnBoXN.TabIndex = 3;
            this.btnBoXN.Text = "Bỏ";
            this.btnBoXN.UseVisualStyleBackColor = true;
            this.btnBoXN.Click += new System.EventHandler(this.btnBoXN_Click);
            // 
            // dgvXNChon
            // 
            this.dgvXNChon.AllowUserToAddRows = false;
            this.dgvXNChon.AllowUserToDeleteRows = false;
            this.dgvXNChon.AllowUserToResizeRows = false;
            this.dgvXNChon.AutoGenerateColumns = false;
            this.dgvXNChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXNChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvXNChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXNChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colXNChon_MaLoaiXN,
            this.colXNChon_TenLoaiXN});
            this.dgvXNChon.Location = new System.Drawing.Point(10, 58);
            this.dgvXNChon.MultiSelect = false;
            this.dgvXNChon.Name = "dgvXNChon";
            this.dgvXNChon.ReadOnly = true;
            this.dgvXNChon.RowHeadersVisible = false;
            this.dgvXNChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXNChon.Size = new System.Drawing.Size(500, 197);
            this.dgvXNChon.TabIndex = 4;
            // 
            // colXNChon_MaLoaiXN
            // 
            this.colXNChon_MaLoaiXN.DataPropertyName = "MaLoaiXN";
            this.colXNChon_MaLoaiXN.HeaderText = "Mã loại XN";
            this.colXNChon_MaLoaiXN.Name = "colXNChon_MaLoaiXN";
            this.colXNChon_MaLoaiXN.ReadOnly = true;
            // 
            // colXNChon_TenLoaiXN
            // 
            this.colXNChon_TenLoaiXN.DataPropertyName = "TenLoaiXN";
            this.colXNChon_TenLoaiXN.HeaderText = "Tên loại xét nghiệm";
            this.colXNChon_TenLoaiXN.Name = "colXNChon_TenLoaiXN";
            this.colXNChon_TenLoaiXN.ReadOnly = true;
            // 
            // grpToa
            // 
            this.grpToa.Location = new System.Drawing.Point(540, 312);
            this.grpToa.Name = "grpToa";
            this.grpToa.Size = new System.Drawing.Size(520, 265);
            this.grpToa.TabStop = false;
            this.grpToa.TabIndex = 4;
            this.grpToa.Text = "Toa thuốc điều trị";
            this.grpToa.Controls.Add(this.lblMaToa);
            this.grpToa.Controls.Add(this.txtMaToa);
            this.grpToa.Controls.Add(this.lblThuoc);
            this.grpToa.Controls.Add(this.cboThuoc);
            this.grpToa.Controls.Add(this.lblSoLuong);
            this.grpToa.Controls.Add(this.numSoLuong);
            this.grpToa.Controls.Add(this.lblLieuDung);
            this.grpToa.Controls.Add(this.txtLieuDung);
            this.grpToa.Controls.Add(this.lblCachDung);
            this.grpToa.Controls.Add(this.txtCachDung);
            this.grpToa.Controls.Add(this.btnThemThuoc);
            this.grpToa.Controls.Add(this.btnBoThuoc);
            this.grpToa.Controls.Add(this.dgvToaChon);
            // 
            // lblMaToa
            // 
            this.lblMaToa.Location = new System.Drawing.Point(12, 29);
            this.lblMaToa.Name = "lblMaToa";
            this.lblMaToa.AutoSize = true;
            this.lblMaToa.Size = new System.Drawing.Size(50, 13);
            this.lblMaToa.TabIndex = 0;
            this.lblMaToa.Text = "Mã toa:";
            // 
            // txtMaToa
            // 
            this.txtMaToa.Location = new System.Drawing.Point(60, 26);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(80, 20);
            this.txtMaToa.TabIndex = 1;
            // 
            // lblThuoc
            // 
            this.lblThuoc.Location = new System.Drawing.Point(155, 29);
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.AutoSize = true;
            this.lblThuoc.Size = new System.Drawing.Size(50, 13);
            this.lblThuoc.TabIndex = 2;
            this.lblThuoc.Text = "Thuốc:";
            // 
            // cboThuoc
            // 
            this.cboThuoc.Location = new System.Drawing.Point(200, 26);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.FormattingEnabled = true;
            this.cboThuoc.Size = new System.Drawing.Size(170, 21);
            this.cboThuoc.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(385, 29);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Size = new System.Drawing.Size(50, 13);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "SL:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(410, 26);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(60, 20);
            this.numSoLuong.TabIndex = 5;
            this.numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0});
            this.numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0});
            this.numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0});
            // 
            // lblLieuDung
            // 
            this.lblLieuDung.Location = new System.Drawing.Point(12, 61);
            this.lblLieuDung.Name = "lblLieuDung";
            this.lblLieuDung.AutoSize = true;
            this.lblLieuDung.Size = new System.Drawing.Size(50, 13);
            this.lblLieuDung.TabIndex = 6;
            this.lblLieuDung.Text = "Liều dùng:";
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(75, 58);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(130, 20);
            this.txtLieuDung.TabIndex = 7;
            // 
            // lblCachDung
            // 
            this.lblCachDung.Location = new System.Drawing.Point(220, 61);
            this.lblCachDung.Name = "lblCachDung";
            this.lblCachDung.AutoSize = true;
            this.lblCachDung.Size = new System.Drawing.Size(50, 13);
            this.lblCachDung.TabIndex = 8;
            this.lblCachDung.Text = "Cách dùng:";
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(285, 58);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(110, 20);
            this.txtCachDung.TabIndex = 9;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(405, 55);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(50, 27);
            this.btnThemThuoc.TabIndex = 10;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // btnBoThuoc
            // 
            this.btnBoThuoc.Location = new System.Drawing.Point(460, 55);
            this.btnBoThuoc.Name = "btnBoThuoc";
            this.btnBoThuoc.Size = new System.Drawing.Size(50, 27);
            this.btnBoThuoc.TabIndex = 11;
            this.btnBoThuoc.Text = "Bỏ";
            this.btnBoThuoc.UseVisualStyleBackColor = true;
            this.btnBoThuoc.Click += new System.EventHandler(this.btnBoThuoc_Click);
            // 
            // dgvToaChon
            // 
            this.dgvToaChon.AllowUserToAddRows = false;
            this.dgvToaChon.AllowUserToDeleteRows = false;
            this.dgvToaChon.AllowUserToResizeRows = false;
            this.dgvToaChon.AutoGenerateColumns = false;
            this.dgvToaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToaChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvToaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colToaChon_MaThuoc,
            this.colToaChon_TenThuoc,
            this.colToaChon_SoLuong,
            this.colToaChon_LieuDung,
            this.colToaChon_CachDung});
            this.dgvToaChon.Location = new System.Drawing.Point(10, 90);
            this.dgvToaChon.MultiSelect = false;
            this.dgvToaChon.Name = "dgvToaChon";
            this.dgvToaChon.ReadOnly = true;
            this.dgvToaChon.RowHeadersVisible = false;
            this.dgvToaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToaChon.Size = new System.Drawing.Size(500, 165);
            this.dgvToaChon.TabIndex = 12;
            // 
            // colToaChon_MaThuoc
            // 
            this.colToaChon_MaThuoc.DataPropertyName = "MaThuoc";
            this.colToaChon_MaThuoc.HeaderText = "Mã thuốc";
            this.colToaChon_MaThuoc.Name = "colToaChon_MaThuoc";
            this.colToaChon_MaThuoc.ReadOnly = true;
            // 
            // colToaChon_TenThuoc
            // 
            this.colToaChon_TenThuoc.DataPropertyName = "TenThuoc";
            this.colToaChon_TenThuoc.HeaderText = "Tên thuốc";
            this.colToaChon_TenThuoc.Name = "colToaChon_TenThuoc";
            this.colToaChon_TenThuoc.ReadOnly = true;
            // 
            // colToaChon_SoLuong
            // 
            this.colToaChon_SoLuong.DataPropertyName = "SoLuong";
            this.colToaChon_SoLuong.HeaderText = "Số lượng";
            this.colToaChon_SoLuong.Name = "colToaChon_SoLuong";
            this.colToaChon_SoLuong.ReadOnly = true;
            // 
            // colToaChon_LieuDung
            // 
            this.colToaChon_LieuDung.DataPropertyName = "LieuDung";
            this.colToaChon_LieuDung.HeaderText = "Liều dùng";
            this.colToaChon_LieuDung.Name = "colToaChon_LieuDung";
            this.colToaChon_LieuDung.ReadOnly = true;
            // 
            // colToaChon_CachDung
            // 
            this.colToaChon_CachDung.DataPropertyName = "CachDung";
            this.colToaChon_CachDung.HeaderText = "Cách dùng";
            this.colToaChon_CachDung.Name = "colToaChon_CachDung";
            this.colToaChon_CachDung.ReadOnly = true;
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.Location = new System.Drawing.Point(820, 584);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(130, 30);
            this.btnLuuPhieu.TabIndex = 5;
            this.btnLuuPhieu.Text = "Lưu phiếu khám";
            this.btnLuuPhieu.UseVisualStyleBackColor = true;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // btnLamMoiPhieu
            // 
            this.btnLamMoiPhieu.Location = new System.Drawing.Point(960, 584);
            this.btnLamMoiPhieu.Name = "btnLamMoiPhieu";
            this.btnLamMoiPhieu.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoiPhieu.TabIndex = 6;
            this.btnLamMoiPhieu.Text = "Làm mới";
            this.btnLamMoiPhieu.UseVisualStyleBackColor = true;
            this.btnLamMoiPhieu.Click += new System.EventHandler(this.btnLamMoiPhieu_Click);
            // 
            // tabKetQuaXN
            // 
            this.tabKetQuaXN.Location = new System.Drawing.Point(4, 22);
            this.tabKetQuaXN.Name = "tabKetQuaXN";
            this.tabKetQuaXN.Padding = new System.Windows.Forms.Padding(3);
            this.tabKetQuaXN.Size = new System.Drawing.Size(1072, 619);
            this.tabKetQuaXN.TabIndex = 1;
            this.tabKetQuaXN.Text = "Kết quả xét nghiệm";
            this.tabKetQuaXN.UseVisualStyleBackColor = true;
            this.tabKetQuaXN.Controls.Add(this.lblDSXN);
            this.tabKetQuaXN.Controls.Add(this.dgvXNChoKQ);
            this.tabKetQuaXN.Controls.Add(this.grpGhiKQ);
            // 
            // lblDSXN
            // 
            this.lblDSXN.Location = new System.Drawing.Point(15, 15);
            this.lblDSXN.Name = "lblDSXN";
            this.lblDSXN.AutoSize = true;
            this.lblDSXN.Size = new System.Drawing.Size(50, 13);
            this.lblDSXN.TabIndex = 0;
            this.lblDSXN.Text = "Xét nghiệm đã chỉ định, chờ kết quả:";
            // 
            // dgvXNChoKQ
            // 
            this.dgvXNChoKQ.AllowUserToAddRows = false;
            this.dgvXNChoKQ.AllowUserToDeleteRows = false;
            this.dgvXNChoKQ.AllowUserToResizeRows = false;
            this.dgvXNChoKQ.AutoGenerateColumns = false;
            this.dgvXNChoKQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXNChoKQ.BackgroundColor = System.Drawing.Color.White;
            this.dgvXNChoKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXNChoKQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colXNChoKQ_MaXN,
            this.colXNChoKQ_SoPhieuKham,
            this.colXNChoKQ_HoTen,
            this.colXNChoKQ_TenLoaiXN,
            this.colXNChoKQ_NgayChiDinh,
            this.colXNChoKQ_KetQua,
            this.colXNChoKQ_NgayCoKetQua});
            this.dgvXNChoKQ.Location = new System.Drawing.Point(10, 35);
            this.dgvXNChoKQ.MultiSelect = false;
            this.dgvXNChoKQ.Name = "dgvXNChoKQ";
            this.dgvXNChoKQ.ReadOnly = true;
            this.dgvXNChoKQ.RowHeadersVisible = false;
            this.dgvXNChoKQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXNChoKQ.Size = new System.Drawing.Size(1050, 330);
            this.dgvXNChoKQ.TabIndex = 1;
            this.dgvXNChoKQ.SelectionChanged += new System.EventHandler(this.dgvXNChoKQ_SelectionChanged);
            // 
            // colXNChoKQ_MaXN
            // 
            this.colXNChoKQ_MaXN.DataPropertyName = "MaXN";
            this.colXNChoKQ_MaXN.HeaderText = "Mã XN";
            this.colXNChoKQ_MaXN.Name = "colXNChoKQ_MaXN";
            this.colXNChoKQ_MaXN.ReadOnly = true;
            // 
            // colXNChoKQ_SoPhieuKham
            // 
            this.colXNChoKQ_SoPhieuKham.DataPropertyName = "SoPhieuKham";
            this.colXNChoKQ_SoPhieuKham.HeaderText = "Số phiếu khám";
            this.colXNChoKQ_SoPhieuKham.Name = "colXNChoKQ_SoPhieuKham";
            this.colXNChoKQ_SoPhieuKham.ReadOnly = true;
            // 
            // colXNChoKQ_HoTen
            // 
            this.colXNChoKQ_HoTen.DataPropertyName = "HoTen";
            this.colXNChoKQ_HoTen.HeaderText = "Bệnh nhân";
            this.colXNChoKQ_HoTen.Name = "colXNChoKQ_HoTen";
            this.colXNChoKQ_HoTen.ReadOnly = true;
            // 
            // colXNChoKQ_TenLoaiXN
            // 
            this.colXNChoKQ_TenLoaiXN.DataPropertyName = "TenLoaiXN";
            this.colXNChoKQ_TenLoaiXN.HeaderText = "Loại xét nghiệm";
            this.colXNChoKQ_TenLoaiXN.Name = "colXNChoKQ_TenLoaiXN";
            this.colXNChoKQ_TenLoaiXN.ReadOnly = true;
            // 
            // colXNChoKQ_NgayChiDinh
            // 
            this.colXNChoKQ_NgayChiDinh.DataPropertyName = "NgayChiDinh";
            this.colXNChoKQ_NgayChiDinh.HeaderText = "Ngày chỉ định";
            this.colXNChoKQ_NgayChiDinh.Name = "colXNChoKQ_NgayChiDinh";
            this.colXNChoKQ_NgayChiDinh.ReadOnly = true;
            // 
            // colXNChoKQ_KetQua
            // 
            this.colXNChoKQ_KetQua.DataPropertyName = "KetQua";
            this.colXNChoKQ_KetQua.HeaderText = "Kết quả";
            this.colXNChoKQ_KetQua.Name = "colXNChoKQ_KetQua";
            this.colXNChoKQ_KetQua.ReadOnly = true;
            // 
            // colXNChoKQ_NgayCoKetQua
            // 
            this.colXNChoKQ_NgayCoKetQua.DataPropertyName = "NgayCoKetQua";
            this.colXNChoKQ_NgayCoKetQua.HeaderText = "Ngày có kết quả";
            this.colXNChoKQ_NgayCoKetQua.Name = "colXNChoKQ_NgayCoKetQua";
            this.colXNChoKQ_NgayCoKetQua.ReadOnly = true;
            // 
            // grpGhiKQ
            // 
            this.grpGhiKQ.Location = new System.Drawing.Point(10, 375);
            this.grpGhiKQ.Name = "grpGhiKQ";
            this.grpGhiKQ.Size = new System.Drawing.Size(1050, 200);
            this.grpGhiKQ.TabStop = false;
            this.grpGhiKQ.TabIndex = 2;
            this.grpGhiKQ.Text = "Ghi nhận kết quả";
            this.grpGhiKQ.Controls.Add(this.lblMaXNChon);
            this.grpGhiKQ.Controls.Add(this.txtMaXNChon);
            this.grpGhiKQ.Controls.Add(this.lblNgayCoKQ);
            this.grpGhiKQ.Controls.Add(this.dtNgayCoKetQua);
            this.grpGhiKQ.Controls.Add(this.lblNVXN);
            this.grpGhiKQ.Controls.Add(this.cboNVXetNghiem);
            this.grpGhiKQ.Controls.Add(this.lblKetQua);
            this.grpGhiKQ.Controls.Add(this.txtKetQua);
            this.grpGhiKQ.Controls.Add(this.btnGhiKetQua);
            // 
            // lblMaXNChon
            // 
            this.lblMaXNChon.Location = new System.Drawing.Point(15, 31);
            this.lblMaXNChon.Name = "lblMaXNChon";
            this.lblMaXNChon.AutoSize = true;
            this.lblMaXNChon.Size = new System.Drawing.Size(50, 13);
            this.lblMaXNChon.TabIndex = 0;
            this.lblMaXNChon.Text = "Mã XN:";
            // 
            // txtMaXNChon
            // 
            this.txtMaXNChon.Location = new System.Drawing.Point(65, 28);
            this.txtMaXNChon.Name = "txtMaXNChon";
            this.txtMaXNChon.Size = new System.Drawing.Size(110, 20);
            this.txtMaXNChon.TabIndex = 1;
            this.txtMaXNChon.ReadOnly = true;
            // 
            // lblNgayCoKQ
            // 
            this.lblNgayCoKQ.Location = new System.Drawing.Point(200, 31);
            this.lblNgayCoKQ.Name = "lblNgayCoKQ";
            this.lblNgayCoKQ.AutoSize = true;
            this.lblNgayCoKQ.Size = new System.Drawing.Size(50, 13);
            this.lblNgayCoKQ.TabIndex = 2;
            this.lblNgayCoKQ.Text = "Ngày có kết quả:";
            // 
            // dtNgayCoKetQua
            // 
            this.dtNgayCoKetQua.Location = new System.Drawing.Point(295, 28);
            this.dtNgayCoKetQua.Name = "dtNgayCoKetQua";
            this.dtNgayCoKetQua.Size = new System.Drawing.Size(130, 20);
            this.dtNgayCoKetQua.TabIndex = 3;
            this.dtNgayCoKetQua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCoKetQua.CustomFormat = "dd/MM/yyyy";
            // 
            // lblNVXN
            // 
            this.lblNVXN.Location = new System.Drawing.Point(450, 31);
            this.lblNVXN.Name = "lblNVXN";
            this.lblNVXN.AutoSize = true;
            this.lblNVXN.Size = new System.Drawing.Size(50, 13);
            this.lblNVXN.TabIndex = 4;
            this.lblNVXN.Text = "NV xét nghiệm:";
            // 
            // cboNVXetNghiem
            // 
            this.cboNVXetNghiem.Location = new System.Drawing.Point(535, 28);
            this.cboNVXetNghiem.Name = "cboNVXetNghiem";
            this.cboNVXetNghiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVXetNghiem.FormattingEnabled = true;
            this.cboNVXetNghiem.Size = new System.Drawing.Size(180, 21);
            this.cboNVXetNghiem.TabIndex = 5;
            // 
            // lblKetQua
            // 
            this.lblKetQua.Location = new System.Drawing.Point(15, 65);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Size = new System.Drawing.Size(50, 13);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(65, 62);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(650, 90);
            this.txtKetQua.TabIndex = 7;
            this.txtKetQua.Multiline = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // btnGhiKetQua
            // 
            this.btnGhiKetQua.Location = new System.Drawing.Point(735, 60);
            this.btnGhiKetQua.Name = "btnGhiKetQua";
            this.btnGhiKetQua.Size = new System.Drawing.Size(130, 30);
            this.btnGhiKetQua.TabIndex = 8;
            this.btnGhiKetQua.Text = "Ghi kết quả";
            this.btnGhiKetQua.UseVisualStyleBackColor = true;
            this.btnGhiKetQua.Click += new System.EventHandler(this.btnGhiKetQua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(990, 664);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 27);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabKham);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khám bệnh - Xét nghiệm - Toa thuốc";
            this.Load += new System.EventHandler(this.FrmKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThanNhiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXNChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXNChoKQ)).EndInit();
            this.tabKham.ResumeLayout(false);
            this.tabKham.PerformLayout();
            this.tabPhieuKham.ResumeLayout(false);
            this.grpTraCuuHS.ResumeLayout(false);
            this.grpTraCuuHS.PerformLayout();
            this.grpPhieu.ResumeLayout(false);
            this.grpPhieu.PerformLayout();
            this.grpLichSu.ResumeLayout(false);
            this.grpLichSu.PerformLayout();
            this.grpXetNghiem.ResumeLayout(false);
            this.grpXetNghiem.PerformLayout();
            this.grpToa.ResumeLayout(false);
            this.grpToa.PerformLayout();
            this.tabKetQuaXN.ResumeLayout(false);
            this.grpGhiKQ.ResumeLayout(false);
            this.grpGhiKQ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabKham;
        private System.Windows.Forms.TabPage tabPhieuKham;
        private System.Windows.Forms.GroupBox grpTraCuuHS;
        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Button btnTimHoSo;
        private System.Windows.Forms.Label lblThongTinBN;
        private System.Windows.Forms.GroupBox grpPhieu;
        private System.Windows.Forms.Label lblSoPhieuKham;
        private System.Windows.Forms.TextBox txtSoPhieuKham;
        private System.Windows.Forms.Label lblNgayGioKham;
        private System.Windows.Forms.DateTimePicker dtNgayGioKham;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblLoaiKham;
        private System.Windows.Forms.ComboBox cboLoaiKham;
        private System.Windows.Forms.Label lblNVGhiNhan;
        private System.Windows.Forms.ComboBox cboNVGhiNhan;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblThanNhiet;
        private System.Windows.Forms.NumericUpDown numThanNhiet;
        private System.Windows.Forms.Label lblHuyetAp;
        private System.Windows.Forms.TextBox txtHuyetAp;
        private System.Windows.Forms.Label lblKetLuan;
        private System.Windows.Forms.TextBox txtKetLuan;
        private System.Windows.Forms.GroupBox grpLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_SoPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_NgayGioKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_TrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichSu_KetLuan;
        private System.Windows.Forms.GroupBox grpXetNghiem;
        private System.Windows.Forms.Label lblLoaiXN;
        private System.Windows.Forms.ComboBox cboLoaiXN;
        private System.Windows.Forms.Button btnThemXN;
        private System.Windows.Forms.Button btnBoXN;
        private System.Windows.Forms.DataGridView dgvXNChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChon_MaLoaiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChon_TenLoaiXN;
        private System.Windows.Forms.GroupBox grpToa;
        private System.Windows.Forms.Label lblMaToa;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblLieuDung;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.Label lblCachDung;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnBoThuoc;
        private System.Windows.Forms.DataGridView dgvToaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaChon_MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaChon_TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaChon_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaChon_LieuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaChon_CachDung;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnLamMoiPhieu;
        private System.Windows.Forms.TabPage tabKetQuaXN;
        private System.Windows.Forms.Label lblDSXN;
        private System.Windows.Forms.DataGridView dgvXNChoKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChoKQ_MaXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChoKQ_SoPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChoKQ_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChoKQ_TenLoaiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChoKQ_NgayChiDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChoKQ_KetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXNChoKQ_NgayCoKetQua;
        private System.Windows.Forms.GroupBox grpGhiKQ;
        private System.Windows.Forms.Label lblMaXNChon;
        private System.Windows.Forms.TextBox txtMaXNChon;
        private System.Windows.Forms.Label lblNgayCoKQ;
        private System.Windows.Forms.DateTimePicker dtNgayCoKetQua;
        private System.Windows.Forms.Label lblNVXN;
        private System.Windows.Forms.ComboBox cboNVXetNghiem;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGhiKetQua;
        private System.Windows.Forms.Button btnDong;
    }
}
