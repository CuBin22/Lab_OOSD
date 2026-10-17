namespace QuanLyBenhVien.Forms
{
    partial class FrmKhamDinhKy
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
            this.grpHoSo = new System.Windows.Forms.GroupBox();
            this.lblMaHoSoDK = new System.Windows.Forms.Label();
            this.txtMaHoSoDK = new System.Windows.Forms.TextBox();
            this.btnKiemTraHoSo = new System.Windows.Forms.Button();
            this.lblKetQuaKiemTra = new System.Windows.Forms.Label();
            this.grpLichHen = new System.Windows.Forms.GroupBox();
            this.lblMaLichHen = new System.Windows.Forms.Label();
            this.txtMaLichHen = new System.Windows.Forms.TextBox();
            this.lblQuy = new System.Windows.Forms.Label();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.lblNamKham = new System.Windows.Forms.Label();
            this.numNamKham = new System.Windows.Forms.NumericUpDown();
            this.lblNgayGioHen = new System.Windows.Forms.Label();
            this.dtNgayGioHen = new System.Windows.Forms.DateTimePicker();
            this.lblNVHen = new System.Windows.Forms.Label();
            this.cboNVHen = new System.Windows.Forms.ComboBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.btnHuyLich = new System.Windows.Forms.Button();
            this.btnLamMoiLich = new System.Windows.Forms.Button();
            this.grpDotKham = new System.Windows.Forms.GroupBox();
            this.lblLichHenChon = new System.Windows.Forms.Label();
            this.txtLichHenChon = new System.Windows.Forms.TextBox();
            this.lblSoPhieuKhamDK = new System.Windows.Forms.Label();
            this.txtSoPhieuKhamDK = new System.Windows.Forms.TextBox();
            this.lblBacSiDK = new System.Windows.Forms.Label();
            this.cboBacSiDK = new System.Windows.Forms.ComboBox();
            this.lblKhoaDK = new System.Windows.Forms.Label();
            this.cboKhoaDK = new System.Windows.Forms.ComboBox();
            this.lblNVDK = new System.Windows.Forms.Label();
            this.cboNVDK = new System.Windows.Forms.ComboBox();
            this.chkPhatHien = new System.Windows.Forms.CheckBox();
            this.lblGhiChuDK = new System.Windows.Forms.Label();
            this.txtGhiChuDK = new System.Windows.Forms.TextBox();
            this.btnGhiDotKham = new System.Windows.Forms.Button();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.colLichHen_MaLichHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichHen_MaHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichHen_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichHen_Quy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichHen_NgayGioHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichHen_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNamKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            this.grpHoSo.SuspendLayout();
            this.grpLichHen.SuspendLayout();
            this.grpDotKham.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHoSo
            // 
            this.grpHoSo.Location = new System.Drawing.Point(10, 8);
            this.grpHoSo.Name = "grpHoSo";
            this.grpHoSo.Size = new System.Drawing.Size(960, 56);
            this.grpHoSo.TabStop = false;
            this.grpHoSo.TabIndex = 0;
            this.grpHoSo.Text = "Hồ sơ bệnh án";
            this.grpHoSo.Controls.Add(this.lblMaHoSoDK);
            this.grpHoSo.Controls.Add(this.txtMaHoSoDK);
            this.grpHoSo.Controls.Add(this.btnKiemTraHoSo);
            this.grpHoSo.Controls.Add(this.lblKetQuaKiemTra);
            // 
            // lblMaHoSoDK
            // 
            this.lblMaHoSoDK.Location = new System.Drawing.Point(15, 27);
            this.lblMaHoSoDK.Name = "lblMaHoSoDK";
            this.lblMaHoSoDK.AutoSize = true;
            this.lblMaHoSoDK.Size = new System.Drawing.Size(50, 13);
            this.lblMaHoSoDK.TabIndex = 0;
            this.lblMaHoSoDK.Text = "Mã hồ sơ:";
            // 
            // txtMaHoSoDK
            // 
            this.txtMaHoSoDK.Location = new System.Drawing.Point(80, 24);
            this.txtMaHoSoDK.Name = "txtMaHoSoDK";
            this.txtMaHoSoDK.Size = new System.Drawing.Size(120, 20);
            this.txtMaHoSoDK.TabIndex = 1;
            // 
            // btnKiemTraHoSo
            // 
            this.btnKiemTraHoSo.Location = new System.Drawing.Point(215, 21);
            this.btnKiemTraHoSo.Name = "btnKiemTraHoSo";
            this.btnKiemTraHoSo.Size = new System.Drawing.Size(110, 27);
            this.btnKiemTraHoSo.TabIndex = 2;
            this.btnKiemTraHoSo.Text = "Kiểm tra hồ sơ";
            this.btnKiemTraHoSo.UseVisualStyleBackColor = true;
            this.btnKiemTraHoSo.Click += new System.EventHandler(this.btnKiemTraHoSo_Click);
            // 
            // lblKetQuaKiemTra
            // 
            this.lblKetQuaKiemTra.Location = new System.Drawing.Point(345, 30);
            this.lblKetQuaKiemTra.Name = "lblKetQuaKiemTra";
            this.lblKetQuaKiemTra.AutoSize = true;
            this.lblKetQuaKiemTra.Size = new System.Drawing.Size(50, 13);
            this.lblKetQuaKiemTra.TabIndex = 3;
            this.lblKetQuaKiemTra.Text = "Chưa kiểm tra hồ sơ.";
            // 
            // grpLichHen
            // 
            this.grpLichHen.Location = new System.Drawing.Point(10, 70);
            this.grpLichHen.Name = "grpLichHen";
            this.grpLichHen.Size = new System.Drawing.Size(960, 100);
            this.grpLichHen.TabStop = false;
            this.grpLichHen.TabIndex = 1;
            this.grpLichHen.Text = "Hẹn lịch khám định kỳ (không thu phí)";
            this.grpLichHen.Controls.Add(this.lblMaLichHen);
            this.grpLichHen.Controls.Add(this.txtMaLichHen);
            this.grpLichHen.Controls.Add(this.lblQuy);
            this.grpLichHen.Controls.Add(this.cboQuy);
            this.grpLichHen.Controls.Add(this.lblNamKham);
            this.grpLichHen.Controls.Add(this.numNamKham);
            this.grpLichHen.Controls.Add(this.lblNgayGioHen);
            this.grpLichHen.Controls.Add(this.dtNgayGioHen);
            this.grpLichHen.Controls.Add(this.lblNVHen);
            this.grpLichHen.Controls.Add(this.cboNVHen);
            this.grpLichHen.Controls.Add(this.btnDatLich);
            this.grpLichHen.Controls.Add(this.btnHuyLich);
            this.grpLichHen.Controls.Add(this.btnLamMoiLich);
            // 
            // lblMaLichHen
            // 
            this.lblMaLichHen.Location = new System.Drawing.Point(15, 29);
            this.lblMaLichHen.Name = "lblMaLichHen";
            this.lblMaLichHen.AutoSize = true;
            this.lblMaLichHen.Size = new System.Drawing.Size(50, 13);
            this.lblMaLichHen.TabIndex = 0;
            this.lblMaLichHen.Text = "Mã lịch hẹn:";
            // 
            // txtMaLichHen
            // 
            this.txtMaLichHen.Location = new System.Drawing.Point(90, 26);
            this.txtMaLichHen.Name = "txtMaLichHen";
            this.txtMaLichHen.Size = new System.Drawing.Size(100, 20);
            this.txtMaLichHen.TabIndex = 1;
            // 
            // lblQuy
            // 
            this.lblQuy.Location = new System.Drawing.Point(215, 29);
            this.lblQuy.Name = "lblQuy";
            this.lblQuy.AutoSize = true;
            this.lblQuy.Size = new System.Drawing.Size(50, 13);
            this.lblQuy.TabIndex = 2;
            this.lblQuy.Text = "Quý:";
            // 
            // cboQuy
            // 
            this.cboQuy.Location = new System.Drawing.Point(245, 26);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
                "Quý 1",
                "Quý 2",
                "Quý 3",
                "Quý 4"});
            this.cboQuy.Size = new System.Drawing.Size(80, 21);
            this.cboQuy.TabIndex = 3;
            this.cboQuy.SelectedIndexChanged += new System.EventHandler(this.cboQuy_SelectedIndexChanged);
            // 
            // lblNamKham
            // 
            this.lblNamKham.Location = new System.Drawing.Point(345, 29);
            this.lblNamKham.Name = "lblNamKham";
            this.lblNamKham.AutoSize = true;
            this.lblNamKham.Size = new System.Drawing.Size(50, 13);
            this.lblNamKham.TabIndex = 4;
            this.lblNamKham.Text = "Năm:";
            // 
            // numNamKham
            // 
            this.numNamKham.Location = new System.Drawing.Point(380, 26);
            this.numNamKham.Name = "numNamKham";
            this.numNamKham.Size = new System.Drawing.Size(70, 20);
            this.numNamKham.TabIndex = 5;
            this.numNamKham.Maximum = new decimal(new int[] { 2100, 0, 0, 0});
            this.numNamKham.Minimum = new decimal(new int[] { 2000, 0, 0, 0});
            this.numNamKham.Value = new decimal(new int[] { 2026, 0, 0, 0});
            // 
            // lblNgayGioHen
            // 
            this.lblNgayGioHen.Location = new System.Drawing.Point(470, 29);
            this.lblNgayGioHen.Name = "lblNgayGioHen";
            this.lblNgayGioHen.AutoSize = true;
            this.lblNgayGioHen.Size = new System.Drawing.Size(50, 13);
            this.lblNgayGioHen.TabIndex = 6;
            this.lblNgayGioHen.Text = "Ngày giờ hẹn:";
            // 
            // dtNgayGioHen
            // 
            this.dtNgayGioHen.Location = new System.Drawing.Point(555, 26);
            this.dtNgayGioHen.Name = "dtNgayGioHen";
            this.dtNgayGioHen.Size = new System.Drawing.Size(170, 20);
            this.dtNgayGioHen.TabIndex = 7;
            this.dtNgayGioHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";
            // 
            // lblNVHen
            // 
            this.lblNVHen.Location = new System.Drawing.Point(745, 29);
            this.lblNVHen.Name = "lblNVHen";
            this.lblNVHen.AutoSize = true;
            this.lblNVHen.Size = new System.Drawing.Size(50, 13);
            this.lblNVHen.TabIndex = 8;
            this.lblNVHen.Text = "NV nhận hẹn:";
            // 
            // cboNVHen
            // 
            this.cboNVHen.Location = new System.Drawing.Point(820, 26);
            this.cboNVHen.Name = "cboNVHen";
            this.cboNVHen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVHen.FormattingEnabled = true;
            this.cboNVHen.Size = new System.Drawing.Size(125, 21);
            this.cboNVHen.TabIndex = 9;
            // 
            // btnDatLich
            // 
            this.btnDatLich.Location = new System.Drawing.Point(15, 60);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(110, 27);
            this.btnDatLich.TabIndex = 10;
            this.btnDatLich.Text = "Đặt lịch hẹn";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // btnHuyLich
            // 
            this.btnHuyLich.Location = new System.Drawing.Point(135, 60);
            this.btnHuyLich.Name = "btnHuyLich";
            this.btnHuyLich.Size = new System.Drawing.Size(110, 27);
            this.btnHuyLich.TabIndex = 11;
            this.btnHuyLich.Text = "Hủy lịch hẹn";
            this.btnHuyLich.UseVisualStyleBackColor = true;
            this.btnHuyLich.Click += new System.EventHandler(this.btnHuyLich_Click);
            // 
            // btnLamMoiLich
            // 
            this.btnLamMoiLich.Location = new System.Drawing.Point(255, 60);
            this.btnLamMoiLich.Name = "btnLamMoiLich";
            this.btnLamMoiLich.Size = new System.Drawing.Size(90, 27);
            this.btnLamMoiLich.TabIndex = 12;
            this.btnLamMoiLich.Text = "Làm mới";
            this.btnLamMoiLich.UseVisualStyleBackColor = true;
            this.btnLamMoiLich.Click += new System.EventHandler(this.btnLamMoiLich_Click);
            // 
            // grpDotKham
            // 
            this.grpDotKham.Location = new System.Drawing.Point(10, 176);
            this.grpDotKham.Name = "grpDotKham";
            this.grpDotKham.Size = new System.Drawing.Size(960, 128);
            this.grpDotKham.TabStop = false;
            this.grpDotKham.TabIndex = 2;
            this.grpDotKham.Text = "Ghi nhận đợt khám định kỳ (lưu như một lần điều trị)";
            this.grpDotKham.Controls.Add(this.lblLichHenChon);
            this.grpDotKham.Controls.Add(this.txtLichHenChon);
            this.grpDotKham.Controls.Add(this.lblSoPhieuKhamDK);
            this.grpDotKham.Controls.Add(this.txtSoPhieuKhamDK);
            this.grpDotKham.Controls.Add(this.lblBacSiDK);
            this.grpDotKham.Controls.Add(this.cboBacSiDK);
            this.grpDotKham.Controls.Add(this.lblKhoaDK);
            this.grpDotKham.Controls.Add(this.cboKhoaDK);
            this.grpDotKham.Controls.Add(this.lblNVDK);
            this.grpDotKham.Controls.Add(this.cboNVDK);
            this.grpDotKham.Controls.Add(this.chkPhatHien);
            this.grpDotKham.Controls.Add(this.lblGhiChuDK);
            this.grpDotKham.Controls.Add(this.txtGhiChuDK);
            this.grpDotKham.Controls.Add(this.btnGhiDotKham);
            // 
            // lblLichHenChon
            // 
            this.lblLichHenChon.Location = new System.Drawing.Point(15, 29);
            this.lblLichHenChon.Name = "lblLichHenChon";
            this.lblLichHenChon.AutoSize = true;
            this.lblLichHenChon.Size = new System.Drawing.Size(50, 13);
            this.lblLichHenChon.TabIndex = 0;
            this.lblLichHenChon.Text = "Lịch hẹn:";
            // 
            // txtLichHenChon
            // 
            this.txtLichHenChon.Location = new System.Drawing.Point(70, 26);
            this.txtLichHenChon.Name = "txtLichHenChon";
            this.txtLichHenChon.Size = new System.Drawing.Size(100, 20);
            this.txtLichHenChon.TabIndex = 1;
            this.txtLichHenChon.ReadOnly = true;
            // 
            // lblSoPhieuKhamDK
            // 
            this.lblSoPhieuKhamDK.Location = new System.Drawing.Point(190, 29);
            this.lblSoPhieuKhamDK.Name = "lblSoPhieuKhamDK";
            this.lblSoPhieuKhamDK.AutoSize = true;
            this.lblSoPhieuKhamDK.Size = new System.Drawing.Size(50, 13);
            this.lblSoPhieuKhamDK.TabIndex = 2;
            this.lblSoPhieuKhamDK.Text = "Số phiếu khám:";
            // 
            // txtSoPhieuKhamDK
            // 
            this.txtSoPhieuKhamDK.Location = new System.Drawing.Point(275, 26);
            this.txtSoPhieuKhamDK.Name = "txtSoPhieuKhamDK";
            this.txtSoPhieuKhamDK.Size = new System.Drawing.Size(100, 20);
            this.txtSoPhieuKhamDK.TabIndex = 3;
            // 
            // lblBacSiDK
            // 
            this.lblBacSiDK.Location = new System.Drawing.Point(395, 29);
            this.lblBacSiDK.Name = "lblBacSiDK";
            this.lblBacSiDK.AutoSize = true;
            this.lblBacSiDK.Size = new System.Drawing.Size(50, 13);
            this.lblBacSiDK.TabIndex = 4;
            this.lblBacSiDK.Text = "Bác sĩ:";
            // 
            // cboBacSiDK
            // 
            this.cboBacSiDK.Location = new System.Drawing.Point(440, 26);
            this.cboBacSiDK.Name = "cboBacSiDK";
            this.cboBacSiDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSiDK.FormattingEnabled = true;
            this.cboBacSiDK.Size = new System.Drawing.Size(140, 21);
            this.cboBacSiDK.TabIndex = 5;
            // 
            // lblKhoaDK
            // 
            this.lblKhoaDK.Location = new System.Drawing.Point(600, 29);
            this.lblKhoaDK.Name = "lblKhoaDK";
            this.lblKhoaDK.AutoSize = true;
            this.lblKhoaDK.Size = new System.Drawing.Size(50, 13);
            this.lblKhoaDK.TabIndex = 6;
            this.lblKhoaDK.Text = "Khoa:";
            // 
            // cboKhoaDK
            // 
            this.cboKhoaDK.Location = new System.Drawing.Point(638, 26);
            this.cboKhoaDK.Name = "cboKhoaDK";
            this.cboKhoaDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaDK.FormattingEnabled = true;
            this.cboKhoaDK.Size = new System.Drawing.Size(140, 21);
            this.cboKhoaDK.TabIndex = 7;
            // 
            // lblNVDK
            // 
            this.lblNVDK.Location = new System.Drawing.Point(795, 29);
            this.lblNVDK.Name = "lblNVDK";
            this.lblNVDK.AutoSize = true;
            this.lblNVDK.Size = new System.Drawing.Size(50, 13);
            this.lblNVDK.TabIndex = 8;
            this.lblNVDK.Text = "NV:";
            // 
            // cboNVDK
            // 
            this.cboNVDK.Location = new System.Drawing.Point(820, 26);
            this.cboNVDK.Name = "cboNVDK";
            this.cboNVDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVDK.FormattingEnabled = true;
            this.cboNVDK.Size = new System.Drawing.Size(125, 21);
            this.cboNVDK.TabIndex = 9;
            // 
            // chkPhatHien
            // 
            this.chkPhatHien.Location = new System.Drawing.Point(15, 60);
            this.chkPhatHien.Name = "chkPhatHien";
            this.chkPhatHien.AutoSize = true;
            this.chkPhatHien.Size = new System.Drawing.Size(50, 17);
            this.chkPhatHien.TabIndex = 10;
            this.chkPhatHien.Text = "Phát hiện mầm bệnh sớm";
            this.chkPhatHien.UseVisualStyleBackColor = true;
            this.chkPhatHien.CheckedChanged += new System.EventHandler(this.chkPhatHien_CheckedChanged);
            // 
            // lblGhiChuDK
            // 
            this.lblGhiChuDK.Location = new System.Drawing.Point(200, 65);
            this.lblGhiChuDK.Name = "lblGhiChuDK";
            this.lblGhiChuDK.AutoSize = true;
            this.lblGhiChuDK.Size = new System.Drawing.Size(50, 13);
            this.lblGhiChuDK.TabIndex = 11;
            this.lblGhiChuDK.Text = "Ghi chú:";
            // 
            // txtGhiChuDK
            // 
            this.txtGhiChuDK.Location = new System.Drawing.Point(255, 60);
            this.txtGhiChuDK.Name = "txtGhiChuDK";
            this.txtGhiChuDK.Size = new System.Drawing.Size(520, 45);
            this.txtGhiChuDK.TabIndex = 12;
            this.txtGhiChuDK.Multiline = true;
            this.txtGhiChuDK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // btnGhiDotKham
            // 
            this.btnGhiDotKham.Location = new System.Drawing.Point(795, 60);
            this.btnGhiDotKham.Name = "btnGhiDotKham";
            this.btnGhiDotKham.Size = new System.Drawing.Size(150, 32);
            this.btnGhiDotKham.TabIndex = 13;
            this.btnGhiDotKham.Text = "Ghi nhận đợt khám";
            this.btnGhiDotKham.UseVisualStyleBackColor = true;
            this.btnGhiDotKham.Click += new System.EventHandler(this.btnGhiDotKham_Click);
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.AllowUserToAddRows = false;
            this.dgvLichHen.AllowUserToDeleteRows = false;
            this.dgvLichHen.AllowUserToResizeRows = false;
            this.dgvLichHen.AutoGenerateColumns = false;
            this.dgvLichHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLichHen_MaLichHen,
            this.colLichHen_MaHoSo,
            this.colLichHen_HoTen,
            this.colLichHen_Quy,
            this.colLichHen_NgayGioHen,
            this.colLichHen_TrangThai});
            this.dgvLichHen.Location = new System.Drawing.Point(10, 312);
            this.dgvLichHen.MultiSelect = false;
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.ReadOnly = true;
            this.dgvLichHen.RowHeadersVisible = false;
            this.dgvLichHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHen.Size = new System.Drawing.Size(960, 295);
            this.dgvLichHen.TabIndex = 3;
            this.dgvLichHen.SelectionChanged += new System.EventHandler(this.dgvLichHen_SelectionChanged);
            // 
            // colLichHen_MaLichHen
            // 
            this.colLichHen_MaLichHen.DataPropertyName = "MaLichHen";
            this.colLichHen_MaLichHen.HeaderText = "Mã lịch hẹn";
            this.colLichHen_MaLichHen.Name = "colLichHen_MaLichHen";
            this.colLichHen_MaLichHen.ReadOnly = true;
            // 
            // colLichHen_MaHoSo
            // 
            this.colLichHen_MaHoSo.DataPropertyName = "MaHoSo";
            this.colLichHen_MaHoSo.HeaderText = "Mã hồ sơ";
            this.colLichHen_MaHoSo.Name = "colLichHen_MaHoSo";
            this.colLichHen_MaHoSo.ReadOnly = true;
            // 
            // colLichHen_HoTen
            // 
            this.colLichHen_HoTen.DataPropertyName = "HoTen";
            this.colLichHen_HoTen.HeaderText = "Bệnh nhân";
            this.colLichHen_HoTen.Name = "colLichHen_HoTen";
            this.colLichHen_HoTen.ReadOnly = true;
            // 
            // colLichHen_Quy
            // 
            this.colLichHen_Quy.DataPropertyName = "Quy";
            this.colLichHen_Quy.HeaderText = "Quý";
            this.colLichHen_Quy.Name = "colLichHen_Quy";
            this.colLichHen_Quy.ReadOnly = true;
            // 
            // colLichHen_NgayGioHen
            // 
            this.colLichHen_NgayGioHen.DataPropertyName = "NgayGioHen";
            this.colLichHen_NgayGioHen.HeaderText = "Ngày giờ hẹn";
            this.colLichHen_NgayGioHen.Name = "colLichHen_NgayGioHen";
            this.colLichHen_NgayGioHen.ReadOnly = true;
            // 
            // colLichHen_TrangThai
            // 
            this.colLichHen_TrangThai.DataPropertyName = "TrangThai";
            this.colLichHen_TrangThai.HeaderText = "Trạng thái";
            this.colLichHen_TrangThai.Name = "colLichHen_TrangThai";
            this.colLichHen_TrangThai.ReadOnly = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(870, 620);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 27);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmKhamDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 660);
            this.Controls.Add(this.grpHoSo);
            this.Controls.Add(this.grpLichHen);
            this.Controls.Add(this.grpDotKham);
            this.Controls.Add(this.dgvLichHen);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKhamDinhKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khám sức khỏe định kỳ";
            this.Load += new System.EventHandler(this.FrmKhamDinhKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNamKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.grpHoSo.ResumeLayout(false);
            this.grpHoSo.PerformLayout();
            this.grpLichHen.ResumeLayout(false);
            this.grpLichHen.PerformLayout();
            this.grpDotKham.ResumeLayout(false);
            this.grpDotKham.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHoSo;
        private System.Windows.Forms.Label lblMaHoSoDK;
        private System.Windows.Forms.TextBox txtMaHoSoDK;
        private System.Windows.Forms.Button btnKiemTraHoSo;
        private System.Windows.Forms.Label lblKetQuaKiemTra;
        private System.Windows.Forms.GroupBox grpLichHen;
        private System.Windows.Forms.Label lblMaLichHen;
        private System.Windows.Forms.TextBox txtMaLichHen;
        private System.Windows.Forms.Label lblQuy;
        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.Label lblNamKham;
        private System.Windows.Forms.NumericUpDown numNamKham;
        private System.Windows.Forms.Label lblNgayGioHen;
        private System.Windows.Forms.DateTimePicker dtNgayGioHen;
        private System.Windows.Forms.Label lblNVHen;
        private System.Windows.Forms.ComboBox cboNVHen;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Button btnHuyLich;
        private System.Windows.Forms.Button btnLamMoiLich;
        private System.Windows.Forms.GroupBox grpDotKham;
        private System.Windows.Forms.Label lblLichHenChon;
        private System.Windows.Forms.TextBox txtLichHenChon;
        private System.Windows.Forms.Label lblSoPhieuKhamDK;
        private System.Windows.Forms.TextBox txtSoPhieuKhamDK;
        private System.Windows.Forms.Label lblBacSiDK;
        private System.Windows.Forms.ComboBox cboBacSiDK;
        private System.Windows.Forms.Label lblKhoaDK;
        private System.Windows.Forms.ComboBox cboKhoaDK;
        private System.Windows.Forms.Label lblNVDK;
        private System.Windows.Forms.ComboBox cboNVDK;
        private System.Windows.Forms.CheckBox chkPhatHien;
        private System.Windows.Forms.Label lblGhiChuDK;
        private System.Windows.Forms.TextBox txtGhiChuDK;
        private System.Windows.Forms.Button btnGhiDotKham;
        private System.Windows.Forms.DataGridView dgvLichHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichHen_MaLichHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichHen_MaHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichHen_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichHen_Quy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichHen_NgayGioHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichHen_TrangThai;
        private System.Windows.Forms.Button btnDong;
    }
}
