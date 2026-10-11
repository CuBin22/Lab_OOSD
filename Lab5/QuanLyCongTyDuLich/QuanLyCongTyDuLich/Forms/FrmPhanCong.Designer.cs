namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmPhanCong
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPhanCong = new System.Windows.Forms.TabPage();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.rdoChuyen = new System.Windows.Forms.RadioButton();
            this.rdoDoan = new System.Windows.Forms.RadioButton();
            this.lblDoiTuong = new System.Windows.Forms.Label();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTienCong = new System.Windows.Forms.Label();
            this.txtTienCong = new System.Windows.Forms.TextBox();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnXoaPhanCong = new System.Windows.Forms.Button();
            this.lblLich = new System.Windows.Forms.Label();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblHoTenNV = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.lblDiaChiNV = new System.Windows.Forms.Label();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.lblDienThoaiNV = new System.Windows.Forms.Label();
            this.txtDienThoaiNV = new System.Windows.Forms.TextBox();
            this.lblLuongCanBan = new System.Windows.Forms.Label();
            this.txtLuongCanBan = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnLamMoiNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.lblThang = new System.Windows.Forms.Label();
            this.numThang = new System.Windows.Forms.NumericUpDown();
            this.lblNam = new System.Windows.Forms.Label();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.lblTongLuong = new System.Windows.Forms.Label();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPhanCong.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.tabLuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(900, 550);
            this.tabControl.TabIndex = 0;
            this.tabControl.Controls.Add(this.tabPhanCong);
            this.tabControl.Controls.Add(this.tabNhanVien);
            this.tabControl.Controls.Add(this.tabLuong);
            // 
            // tabPhanCong
            // 
            this.tabPhanCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhanCong.UseVisualStyleBackColor = true;
            this.tabPhanCong.Name = "tabPhanCong";
            this.tabPhanCong.Text = "Phân công";
            this.tabPhanCong.Controls.Add(this.rdoChuyen);
            this.tabPhanCong.Controls.Add(this.rdoDoan);
            this.tabPhanCong.Controls.Add(this.lblDoiTuong);
            this.tabPhanCong.Controls.Add(this.cboDoiTuong);
            this.tabPhanCong.Controls.Add(this.lblNhanVien);
            this.tabPhanCong.Controls.Add(this.cboNhanVien);
            this.tabPhanCong.Controls.Add(this.lblTuNgay);
            this.tabPhanCong.Controls.Add(this.dtpTuNgay);
            this.tabPhanCong.Controls.Add(this.lblDenNgay);
            this.tabPhanCong.Controls.Add(this.dtpDenNgay);
            this.tabPhanCong.Controls.Add(this.lblTienCong);
            this.tabPhanCong.Controls.Add(this.txtTienCong);
            this.tabPhanCong.Controls.Add(this.btnPhanCong);
            this.tabPhanCong.Controls.Add(this.btnXoaPhanCong);
            this.tabPhanCong.Controls.Add(this.lblLich);
            this.tabPhanCong.Controls.Add(this.dgvPhanCong);
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.UseVisualStyleBackColor = true;
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.Controls.Add(this.lblMaNV);
            this.tabNhanVien.Controls.Add(this.txtMaNV);
            this.tabNhanVien.Controls.Add(this.lblHoTenNV);
            this.tabNhanVien.Controls.Add(this.txtHoTenNV);
            this.tabNhanVien.Controls.Add(this.lblDiaChiNV);
            this.tabNhanVien.Controls.Add(this.txtDiaChiNV);
            this.tabNhanVien.Controls.Add(this.lblDienThoaiNV);
            this.tabNhanVien.Controls.Add(this.txtDienThoaiNV);
            this.tabNhanVien.Controls.Add(this.lblLuongCanBan);
            this.tabNhanVien.Controls.Add(this.txtLuongCanBan);
            this.tabNhanVien.Controls.Add(this.btnThemNV);
            this.tabNhanVien.Controls.Add(this.btnSuaNV);
            this.tabNhanVien.Controls.Add(this.btnXoaNV);
            this.tabNhanVien.Controls.Add(this.btnLamMoiNV);
            this.tabNhanVien.Controls.Add(this.dgvNhanVien);
            // 
            // tabLuong
            // 
            this.tabLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuong.UseVisualStyleBackColor = true;
            this.tabLuong.Name = "tabLuong";
            this.tabLuong.Text = "Lương tháng";
            this.tabLuong.Controls.Add(this.lblThang);
            this.tabLuong.Controls.Add(this.numThang);
            this.tabLuong.Controls.Add(this.lblNam);
            this.tabLuong.Controls.Add(this.numNam);
            this.tabLuong.Controls.Add(this.btnTinhLuong);
            this.tabLuong.Controls.Add(this.lblTongLuong);
            this.tabLuong.Controls.Add(this.txtTongLuong);
            this.tabLuong.Controls.Add(this.dgvLuong);
            // 
            // rdoChuyen
            // 
            this.rdoChuyen.AutoSize = true;
            this.rdoChuyen.UseVisualStyleBackColor = true;
            this.rdoChuyen.TabStop = true;
            this.rdoChuyen.Checked = true;
            this.rdoChuyen.Location = new System.Drawing.Point(15, 18);
            this.rdoChuyen.Name = "rdoChuyen";
            this.rdoChuyen.Size = new System.Drawing.Size(160, 17);
            this.rdoChuyen.TabIndex = 0;
            this.rdoChuyen.Text = "Theo chuyến (khách lẻ)";
            this.rdoChuyen.CheckedChanged += new System.EventHandler(this.rdoChuyen_CheckedChanged);
            // 
            // rdoDoan
            // 
            this.rdoDoan.AutoSize = true;
            this.rdoDoan.UseVisualStyleBackColor = true;
            this.rdoDoan.TabStop = true;
            this.rdoDoan.Location = new System.Drawing.Point(200, 18);
            this.rdoDoan.Name = "rdoDoan";
            this.rdoDoan.Size = new System.Drawing.Size(110, 17);
            this.rdoDoan.TabIndex = 1;
            this.rdoDoan.Text = "Theo đoàn";
            // 
            // lblDoiTuong
            // 
            this.lblDoiTuong.AutoSize = true;
            this.lblDoiTuong.Location = new System.Drawing.Point(15, 52);
            this.lblDoiTuong.Name = "lblDoiTuong";
            this.lblDoiTuong.Size = new System.Drawing.Size(92, 13);
            this.lblDoiTuong.TabIndex = 2;
            this.lblDoiTuong.Text = "Chuyến / Đoàn:";
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Location = new System.Drawing.Point(120, 49);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(480, 21);
            this.cboDoiTuong.TabIndex = 3;
            this.cboDoiTuong.SelectedIndexChanged += new System.EventHandler(this.cboDoiTuong_SelectedIndexChanged);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(15, 84);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(67, 13);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(120, 81);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(260, 21);
            this.cboNhanVien.TabIndex = 5;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(15, 116);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(54, 13);
            this.lblTuNgay.TabIndex = 6;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(120, 113);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(110, 20);
            this.dtpTuNgay.TabIndex = 7;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(250, 116);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(60, 13);
            this.lblDenNgay.TabIndex = 8;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(320, 113);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(110, 20);
            this.dtpDenNgay.TabIndex = 9;
            // 
            // lblTienCong
            // 
            this.lblTienCong.AutoSize = true;
            this.lblTienCong.Location = new System.Drawing.Point(450, 116);
            this.lblTienCong.Name = "lblTienCong";
            this.lblTienCong.Size = new System.Drawing.Size(98, 13);
            this.lblTienCong.TabIndex = 10;
            this.lblTienCong.Text = "Tiền công tour:";
            // 
            // txtTienCong
            // 
            this.txtTienCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienCong.Location = new System.Drawing.Point(545, 113);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.Size = new System.Drawing.Size(110, 20);
            this.txtTienCong.TabIndex = 11;
            this.txtTienCong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienCong_KeyPress);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Location = new System.Drawing.Point(120, 150);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(110, 30);
            this.btnPhanCong.TabIndex = 12;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnXoaPhanCong
            // 
            this.btnXoaPhanCong.UseVisualStyleBackColor = true;
            this.btnXoaPhanCong.Location = new System.Drawing.Point(236, 150);
            this.btnXoaPhanCong.Name = "btnXoaPhanCong";
            this.btnXoaPhanCong.Size = new System.Drawing.Size(120, 30);
            this.btnXoaPhanCong.TabIndex = 13;
            this.btnXoaPhanCong.Text = "Xóa phân công";
            this.btnXoaPhanCong.Click += new System.EventHandler(this.btnXoaPhanCong_Click);
            // 
            // lblLich
            // 
            this.lblLich.AutoSize = true;
            this.lblLich.Location = new System.Drawing.Point(15, 192);
            this.lblLich.Name = "lblLich";
            this.lblLich.Size = new System.Drawing.Size(237, 13);
            this.lblLich.TabIndex = 14;
            this.lblLich.Text = "Lịch phân công của nhân viên đã chọn:";
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AllowUserToDeleteRows = false;
            this.dgvPhanCong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhanCong.MultiSelect = false;
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersVisible = false;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanCong.Location = new System.Drawing.Point(15, 210);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.Size = new System.Drawing.Size(860, 300);
            this.dgvPhanCong.TabIndex = 15;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(15, 20);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(41, 13);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.MaxLength = 20;
            this.txtMaNV.Location = new System.Drawing.Point(90, 17);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(120, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblHoTenNV
            // 
            this.lblHoTenNV.AutoSize = true;
            this.lblHoTenNV.Location = new System.Drawing.Point(230, 20);
            this.lblHoTenNV.Name = "lblHoTenNV";
            this.lblHoTenNV.Size = new System.Drawing.Size(48, 13);
            this.lblHoTenNV.TabIndex = 2;
            this.lblHoTenNV.Text = "Họ tên:";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.MaxLength = 100;
            this.txtHoTenNV.Location = new System.Drawing.Point(290, 17);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(250, 20);
            this.txtHoTenNV.TabIndex = 3;
            // 
            // lblDiaChiNV
            // 
            this.lblDiaChiNV.AutoSize = true;
            this.lblDiaChiNV.Location = new System.Drawing.Point(15, 52);
            this.lblDiaChiNV.Name = "lblDiaChiNV";
            this.lblDiaChiNV.Size = new System.Drawing.Size(54, 13);
            this.lblDiaChiNV.TabIndex = 4;
            this.lblDiaChiNV.Text = "Địa chỉ:";
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.MaxLength = 200;
            this.txtDiaChiNV.Location = new System.Drawing.Point(90, 49);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(450, 20);
            this.txtDiaChiNV.TabIndex = 5;
            // 
            // lblDienThoaiNV
            // 
            this.lblDienThoaiNV.AutoSize = true;
            this.lblDienThoaiNV.Location = new System.Drawing.Point(15, 84);
            this.lblDienThoaiNV.Name = "lblDienThoaiNV";
            this.lblDienThoaiNV.Size = new System.Drawing.Size(73, 13);
            this.lblDienThoaiNV.TabIndex = 6;
            this.lblDienThoaiNV.Text = "Điện thoại:";
            // 
            // txtDienThoaiNV
            // 
            this.txtDienThoaiNV.MaxLength = 15;
            this.txtDienThoaiNV.Location = new System.Drawing.Point(90, 81);
            this.txtDienThoaiNV.Name = "txtDienThoaiNV";
            this.txtDienThoaiNV.Size = new System.Drawing.Size(150, 20);
            this.txtDienThoaiNV.TabIndex = 7;
            // 
            // lblLuongCanBan
            // 
            this.lblLuongCanBan.AutoSize = true;
            this.lblLuongCanBan.Location = new System.Drawing.Point(260, 84);
            this.lblLuongCanBan.Name = "lblLuongCanBan";
            this.lblLuongCanBan.Size = new System.Drawing.Size(92, 13);
            this.lblLuongCanBan.TabIndex = 8;
            this.lblLuongCanBan.Text = "Lương căn bản:";
            // 
            // txtLuongCanBan
            // 
            this.txtLuongCanBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLuongCanBan.Location = new System.Drawing.Point(350, 81);
            this.txtLuongCanBan.Name = "txtLuongCanBan";
            this.txtLuongCanBan.Size = new System.Drawing.Size(120, 20);
            this.txtLuongCanBan.TabIndex = 9;
            this.txtLuongCanBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongCanBan_KeyPress);
            // 
            // btnThemNV
            // 
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Location = new System.Drawing.Point(620, 15);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(90, 26);
            this.btnThemNV.TabIndex = 10;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Location = new System.Drawing.Point(716, 15);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(90, 26);
            this.btnSuaNV.TabIndex = 11;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Location = new System.Drawing.Point(620, 47);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(90, 26);
            this.btnXoaNV.TabIndex = 12;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.UseVisualStyleBackColor = true;
            this.btnLamMoiNV.Location = new System.Drawing.Point(716, 47);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Size = new System.Drawing.Size(90, 26);
            this.btnLamMoiNV.TabIndex = 13;
            this.btnLamMoiNV.Text = "Làm mới";
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(15, 125);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(860, 385);
            this.dgvNhanVien.TabIndex = 14;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(15, 20);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(41, 13);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng:";
            // 
            // numThang
            // 
            this.numThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            this.numThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numThang.Location = new System.Drawing.Point(65, 17);
            this.numThang.Name = "numThang";
            this.numThang.Size = new System.Drawing.Size(60, 20);
            this.numThang.TabIndex = 1;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(150, 20);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(29, 13);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm:";
            // 
            // numNam
            // 
            this.numNam.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            this.numNam.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            this.numNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNam.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            this.numNam.Location = new System.Drawing.Point(190, 17);
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(70, 20);
            this.numNam.TabIndex = 3;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Location = new System.Drawing.Point(290, 14);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(110, 28);
            this.btnTinhLuong.TabIndex = 4;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // lblTongLuong
            // 
            this.lblTongLuong.AutoSize = true;
            this.lblTongLuong.Location = new System.Drawing.Point(430, 20);
            this.lblTongLuong.Name = "lblTongLuong";
            this.lblTongLuong.Size = new System.Drawing.Size(98, 13);
            this.lblTongLuong.TabIndex = 5;
            this.lblTongLuong.Text = "Tổng chi lương:";
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.ReadOnly = true;
            this.txtTongLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTongLuong.Location = new System.Drawing.Point(530, 17);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(140, 20);
            this.txtTongLuong.TabIndex = 6;
            // 
            // dgvLuong
            // 
            this.dgvLuong.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvLuong.AllowUserToAddRows = false;
            this.dgvLuong.AllowUserToDeleteRows = false;
            this.dgvLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLuong.MultiSelect = false;
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.RowHeadersVisible = false;
            this.dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.Location = new System.Drawing.Point(15, 60);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.Size = new System.Drawing.Size(860, 450);
            this.dgvLuong.TabIndex = 7;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(12, 580);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(4, 13);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(835, 572);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 610);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnDong);
            this.MinimumSize = new System.Drawing.Size(920, 610);
            this.Name = "FrmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công hướng dẫn viên - nhân viên - lương";
            this.Load += new System.EventHandler(this.FrmPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPhanCong.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.tabLuong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPhanCong;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.RadioButton rdoChuyen;
        private System.Windows.Forms.RadioButton rdoDoan;
        private System.Windows.Forms.Label lblDoiTuong;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblTienCong;
        private System.Windows.Forms.TextBox txtTienCong;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnXoaPhanCong;
        private System.Windows.Forms.Label lblLich;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTenNV;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.Label lblDiaChiNV;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.Label lblDienThoaiNV;
        private System.Windows.Forms.TextBox txtDienThoaiNV;
        private System.Windows.Forms.Label lblLuongCanBan;
        private System.Windows.Forms.TextBox txtLuongCanBan;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnLamMoiNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.NumericUpDown numThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Label lblTongLuong;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDong;
    }
}
