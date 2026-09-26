namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
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
            this.TabTienNghi = new System.Windows.Forms.TabPage();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TabLapDat = new System.Windows.Forms.TabPage();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.SoPhieuLapDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTienNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPhong = new System.Windows.Forms.TabPage();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MaTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            this.TabLapDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // TabTienNghi
            // 
            this.TabTienNghi.Controls.Add(this.cboLoai);
            this.TabTienNghi.Controls.Add(this.numSTT);
            this.TabTienNghi.Controls.Add(this.label9);
            this.TabTienNghi.Controls.Add(this.label10);
            this.TabTienNghi.Controls.Add(this.dgvTN);
            this.TabTienNghi.Controls.Add(this.btnThemTN);
            this.TabTienNghi.Controls.Add(this.txtTinhTrang);
            this.TabTienNghi.Controls.Add(this.label11);
            this.TabTienNghi.Controls.Add(this.txtMaTN);
            this.TabTienNghi.Controls.Add(this.label12);
            this.TabTienNghi.Location = new System.Drawing.Point(4, 38);
            this.TabTienNghi.Name = "TabTienNghi";
            this.TabTienNghi.Padding = new System.Windows.Forms.Padding(3);
            this.TabTienNghi.Size = new System.Drawing.Size(1358, 787);
            this.TabTienNghi.TabIndex = 3;
            this.TabTienNghi.Text = "Tiện nghi";
            this.TabTienNghi.UseVisualStyleBackColor = true;
            this.TabTienNghi.Click += new System.EventHandler(this.TabTienNghi_Click);
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(316, 96);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(181, 37);
            this.cboLoai.TabIndex = 33;
            // 
            // numSTT
            // 
            this.numSTT.Location = new System.Drawing.Point(720, 94);
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(182, 34);
            this.numSTT.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "STT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Loại:";
            // 
            // dgvTN
            // 
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTN,
            this.Loai,
            this.STT,
            this.TinhTrang});
            this.dgvTN.Location = new System.Drawing.Point(155, 179);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.RowTemplate.Height = 24;
            this.dgvTN.Size = new System.Drawing.Size(1054, 564);
            this.dgvTN.TabIndex = 15;
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(1003, 46);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(183, 36);
            this.btnThemTN.TabIndex = 14;
            this.btnThemTN.Text = "Thêm";
            this.btnThemTN.UseVisualStyleBackColor = true;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(720, 45);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(182, 34);
            this.txtTinhTrang.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tình trạng:";
            // 
            // txtMaTN
            // 
            this.txtMaTN.Location = new System.Drawing.Point(316, 43);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(182, 34);
            this.txtMaTN.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "Mã tiện nghi:";
            // 
            // TabLapDat
            // 
            this.TabLapDat.Controls.Add(this.dgvLD);
            this.TabLapDat.Controls.Add(this.txtGhiChu);
            this.TabLapDat.Controls.Add(this.cboNV);
            this.TabLapDat.Controls.Add(this.label6);
            this.TabLapDat.Controls.Add(this.label7);
            this.TabLapDat.Controls.Add(this.txtTTLD);
            this.TabLapDat.Controls.Add(this.label8);
            this.TabLapDat.Controls.Add(this.dtNgay);
            this.TabLapDat.Controls.Add(this.cboPhong);
            this.TabLapDat.Controls.Add(this.cboTN);
            this.TabLapDat.Controls.Add(this.label13);
            this.TabLapDat.Controls.Add(this.label14);
            this.TabLapDat.Controls.Add(this.btnLapDat);
            this.TabLapDat.Controls.Add(this.label15);
            this.TabLapDat.Controls.Add(this.txtSoLD);
            this.TabLapDat.Controls.Add(this.label16);
            this.TabLapDat.Location = new System.Drawing.Point(4, 38);
            this.TabLapDat.Name = "TabLapDat";
            this.TabLapDat.Padding = new System.Windows.Forms.Padding(3);
            this.TabLapDat.Size = new System.Drawing.Size(1358, 787);
            this.TabLapDat.TabIndex = 4;
            this.TabLapDat.Text = "Phiếu lắp đặt";
            this.TabLapDat.UseVisualStyleBackColor = true;
            this.TabLapDat.Click += new System.EventHandler(this.TabLapDat_Click);
            // 
            // dgvLD
            // 
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuLapDat,
            this.MaTienNghi,
            this.TenLoaiTN,
            this.Phong,
            this.NgayLap,
            this.TT,
            this.MaNV,
            this.GhiChu});
            this.dgvLD.Location = new System.Drawing.Point(39, 196);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.RowHeadersWidth = 51;
            this.dgvLD.RowTemplate.Height = 24;
            this.dgvLD.Size = new System.Drawing.Size(1055, 229);
            this.dgvLD.TabIndex = 42;
            // 
            // SoPhieuLapDat
            // 
            this.SoPhieuLapDat.DataPropertyName = "SoPhieuLapDat";
            this.SoPhieuLapDat.HeaderText = "SoPhieuLapDat";
            this.SoPhieuLapDat.MinimumWidth = 6;
            this.SoPhieuLapDat.Name = "SoPhieuLapDat";
            this.SoPhieuLapDat.Width = 125;
            // 
            // MaTienNghi
            // 
            this.MaTienNghi.DataPropertyName = "MaTienNghi";
            this.MaTienNghi.HeaderText = "MaTienNghi";
            this.MaTienNghi.MinimumWidth = 6;
            this.MaTienNghi.Name = "MaTienNghi";
            this.MaTienNghi.Width = 125;
            // 
            // TenLoaiTN
            // 
            this.TenLoaiTN.DataPropertyName = "TenLoaiTN";
            this.TenLoaiTN.HeaderText = "TenLoaiTN";
            this.TenLoaiTN.MinimumWidth = 6;
            this.TenLoaiTN.Name = "TenLoaiTN";
            this.TenLoaiTN.Width = 125;
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "SoPhong";
            this.Phong.HeaderText = "SoPhong";
            this.Phong.MinimumWidth = 6;
            this.Phong.Name = "Phong";
            this.Phong.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // TT
            // 
            this.TT.DataPropertyName = "TinhTrang";
            this.TT.HeaderText = "TinhTrang";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "GhiChu";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 125;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(936, 23);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 34);
            this.txtGhiChu.TabIndex = 41;
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(936, 79);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(200, 37);
            this.cboNV.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nhân viên:";
            // 
            // txtTTLD
            // 
            this.txtTTLD.Location = new System.Drawing.Point(251, 136);
            this.txtTTLD.Name = "txtTTLD";
            this.txtTTLD.Size = new System.Drawing.Size(337, 34);
            this.txtTTLD.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Thông tin lắp đặt:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(530, 77);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 34);
            this.dtNgay.TabIndex = 33;
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(530, 26);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(200, 37);
            this.cboPhong.TabIndex = 32;
            // 
            // cboTN
            // 
            this.cboTN.FormattingEnabled = true;
            this.cboTN.Location = new System.Drawing.Point(201, 74);
            this.cboTN.Name = "cboTN";
            this.cboTN.Size = new System.Drawing.Size(181, 37);
            this.cboTN.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(410, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ngày:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tiện nghi:";
            // 
            // btnLapDat
            // 
            this.btnLapDat.Location = new System.Drawing.Point(763, 134);
            this.btnLapDat.Name = "btnLapDat";
            this.btnLapDat.Size = new System.Drawing.Size(183, 36);
            this.btnLapDat.TabIndex = 25;
            this.btnLapDat.Text = "Thêm";
            this.btnLapDat.UseVisualStyleBackColor = true;
            this.btnLapDat.Click += new System.EventHandler(this.btnLapDat_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(410, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 29);
            this.label15.TabIndex = 23;
            this.label15.Text = "Phòng:";
            // 
            // txtSoLD
            // 
            this.txtSoLD.Location = new System.Drawing.Point(200, 26);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(182, 34);
            this.txtSoLD.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 29);
            this.label16.TabIndex = 21;
            this.label16.Text = "Số lắp đặt:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPhong);
            this.tabControl1.Controls.Add(this.TabTienNghi);
            this.tabControl1.Controls.Add(this.TabLapDat);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1366, 829);
            this.tabControl1.TabIndex = 1;
            // 
            // TabPhong
            // 
            this.TabPhong.Controls.Add(this.numMax);
            this.TabPhong.Controls.Add(this.cboKhu);
            this.TabPhong.Controls.Add(this.numGia);
            this.TabPhong.Controls.Add(this.label1);
            this.TabPhong.Controls.Add(this.label2);
            this.TabPhong.Controls.Add(this.dgvPhong);
            this.TabPhong.Controls.Add(this.btnThemPhong);
            this.TabPhong.Controls.Add(this.label3);
            this.TabPhong.Controls.Add(this.txtPhong);
            this.TabPhong.Controls.Add(this.label4);
            this.TabPhong.Location = new System.Drawing.Point(4, 38);
            this.TabPhong.Name = "TabPhong";
            this.TabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.TabPhong.Size = new System.Drawing.Size(1358, 787);
            this.TabPhong.TabIndex = 2;
            this.TabPhong.Text = "Phòng";
            this.TabPhong.UseVisualStyleBackColor = true;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(720, 45);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(182, 34);
            this.numMax.TabIndex = 33;
            // 
            // cboKhu
            // 
            this.cboKhu.FormattingEnabled = true;
            this.cboKhu.Location = new System.Drawing.Point(316, 91);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(181, 37);
            this.cboKhu.TabIndex = 32;
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(720, 94);
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(182, 34);
            this.numGia.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Khu:";
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.TenKhuVuc,
            this.SoNguoiToiDa,
            this.DonGiaNgay,
            this.TrangThai});
            this.dgvPhong.Location = new System.Drawing.Point(155, 179);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(1054, 564);
            this.dgvPhong.TabIndex = 26;
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Phòng";
            this.SoPhong.MinimumWidth = 6;
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 250;
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.DataPropertyName = "TenKhuVuc";
            this.TenKhuVuc.HeaderText = "Khu";
            this.TenKhuVuc.MinimumWidth = 6;
            this.TenKhuVuc.Name = "TenKhuVuc";
            this.TenKhuVuc.Width = 250;
            // 
            // SoNguoiToiDa
            // 
            this.SoNguoiToiDa.DataPropertyName = "SoNguoiToiDa";
            this.SoNguoiToiDa.HeaderText = "Max";
            this.SoNguoiToiDa.MinimumWidth = 6;
            this.SoNguoiToiDa.Name = "SoNguoiToiDa";
            this.SoNguoiToiDa.Width = 250;
            // 
            // DonGiaNgay
            // 
            this.DonGiaNgay.DataPropertyName = "DonGiaNgay";
            this.DonGiaNgay.HeaderText = "Giá";
            this.DonGiaNgay.MinimumWidth = 6;
            this.DonGiaNgay.Name = "DonGiaNgay";
            this.DonGiaNgay.Width = 250;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(1003, 46);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(183, 36);
            this.btnThemPhong.TabIndex = 25;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Max:";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(316, 43);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(182, 34);
            this.txtPhong.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phòng:";
            // 
            // MaTN
            // 
            this.MaTN.DataPropertyName = "MaTienNghi";
            this.MaTN.HeaderText = "Mã tiện nghi";
            this.MaTN.MinimumWidth = 6;
            this.MaTN.Name = "MaTN";
            this.MaTN.Width = 250;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "TenLoaiTN";
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            this.Loai.Width = 250;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "SoThuTu";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 250;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrangHienTai";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 250;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 842);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm";
            this.Text = "FrmPhongTienNghi";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.TabTienNghi.ResumeLayout(false);
            this.TabTienNghi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            this.TabLapDat.ResumeLayout(false);
            this.TabLapDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabPhong.ResumeLayout(false);
            this.TabPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabTienNghi;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage TabLapDat;
        private System.Windows.Forms.ComboBox cboTN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLapDat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPhong;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTTLD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuLapDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTienNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}