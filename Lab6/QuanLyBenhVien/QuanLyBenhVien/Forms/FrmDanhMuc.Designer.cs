namespace QuanLyBenhVien.Forms
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
            this.tabDanhMuc = new System.Windows.Forms.TabControl();
            this.tabKhoa = new System.Windows.Forms.TabPage();
            this.lblKhoaMa = new System.Windows.Forms.Label();
            this.txtKhoaMa = new System.Windows.Forms.TextBox();
            this.lblKhoaTen = new System.Windows.Forms.Label();
            this.txtKhoaTen = new System.Windows.Forms.TextBox();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.colKhoa_MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa_TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBacSi = new System.Windows.Forms.TabPage();
            this.lblBSMa = new System.Windows.Forms.Label();
            this.txtBSMa = new System.Windows.Forms.TextBox();
            this.lblBSTen = new System.Windows.Forms.Label();
            this.txtBSTen = new System.Windows.Forms.TextBox();
            this.lblBSKhoa = new System.Windows.Forms.Label();
            this.cboBSKhoa = new System.Windows.Forms.ComboBox();
            this.lblBSSDT = new System.Windows.Forms.Label();
            this.txtBSSDT = new System.Windows.Forms.TextBox();
            this.btnThemBS = new System.Windows.Forms.Button();
            this.dgvBS = new System.Windows.Forms.DataGridView();
            this.colBS_MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBS_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBS_TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBS_SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.cboNVVaiTro = new System.Windows.Forms.ComboBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.colNV_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNV_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNV_VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNV_SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLoaiXN = new System.Windows.Forms.TabPage();
            this.lblLoaiXNMa = new System.Windows.Forms.Label();
            this.txtLoaiXNMa = new System.Windows.Forms.TextBox();
            this.lblLoaiXNTen = new System.Windows.Forms.Label();
            this.txtLoaiXNTen = new System.Windows.Forms.TextBox();
            this.btnThemLoaiXN = new System.Windows.Forms.Button();
            this.dgvLoaiXN = new System.Windows.Forms.DataGridView();
            this.colLoaiXN_MaLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiXN_TenLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabThuoc = new System.Windows.Forms.TabPage();
            this.lblThuocMa = new System.Windows.Forms.Label();
            this.txtThuocMa = new System.Windows.Forms.TextBox();
            this.lblThuocTen = new System.Windows.Forms.Label();
            this.txtThuocTen = new System.Windows.Forms.TextBox();
            this.lblThuocDVT = new System.Windows.Forms.Label();
            this.txtThuocDVT = new System.Windows.Forms.TextBox();
            this.lblThuocPUP = new System.Windows.Forms.Label();
            this.txtThuocPUP = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.colThuoc_MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc_TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc_DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc_PhanUngPhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiXN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.tabDanhMuc.SuspendLayout();
            this.tabKhoa.SuspendLayout();
            this.tabBacSi.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.tabLoaiXN.SuspendLayout();
            this.tabThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Location = new System.Drawing.Point(10, 10);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.SelectedIndex = 0;
            this.tabDanhMuc.Size = new System.Drawing.Size(800, 465);
            this.tabDanhMuc.TabIndex = 0;
            this.tabDanhMuc.Controls.Add(this.tabKhoa);
            this.tabDanhMuc.Controls.Add(this.tabBacSi);
            this.tabDanhMuc.Controls.Add(this.tabNhanVien);
            this.tabDanhMuc.Controls.Add(this.tabLoaiXN);
            this.tabDanhMuc.Controls.Add(this.tabThuoc);
            // 
            // tabKhoa
            // 
            this.tabKhoa.Location = new System.Drawing.Point(4, 22);
            this.tabKhoa.Name = "tabKhoa";
            this.tabKhoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoa.Size = new System.Drawing.Size(792, 439);
            this.tabKhoa.TabIndex = 0;
            this.tabKhoa.Text = "Khoa";
            this.tabKhoa.UseVisualStyleBackColor = true;
            this.tabKhoa.Controls.Add(this.lblKhoaMa);
            this.tabKhoa.Controls.Add(this.txtKhoaMa);
            this.tabKhoa.Controls.Add(this.lblKhoaTen);
            this.tabKhoa.Controls.Add(this.txtKhoaTen);
            this.tabKhoa.Controls.Add(this.btnThemKhoa);
            this.tabKhoa.Controls.Add(this.dgvKhoa);
            // 
            // lblKhoaMa
            // 
            this.lblKhoaMa.Location = new System.Drawing.Point(15, 21);
            this.lblKhoaMa.Name = "lblKhoaMa";
            this.lblKhoaMa.AutoSize = true;
            this.lblKhoaMa.Size = new System.Drawing.Size(50, 13);
            this.lblKhoaMa.TabIndex = 0;
            this.lblKhoaMa.Text = "Mã khoa:";
            // 
            // txtKhoaMa
            // 
            this.txtKhoaMa.Location = new System.Drawing.Point(75, 18);
            this.txtKhoaMa.Name = "txtKhoaMa";
            this.txtKhoaMa.Size = new System.Drawing.Size(100, 20);
            this.txtKhoaMa.TabIndex = 1;
            // 
            // lblKhoaTen
            // 
            this.lblKhoaTen.Location = new System.Drawing.Point(195, 21);
            this.lblKhoaTen.Name = "lblKhoaTen";
            this.lblKhoaTen.AutoSize = true;
            this.lblKhoaTen.Size = new System.Drawing.Size(50, 13);
            this.lblKhoaTen.TabIndex = 2;
            this.lblKhoaTen.Text = "Tên khoa:";
            // 
            // txtKhoaTen
            // 
            this.txtKhoaTen.Location = new System.Drawing.Point(255, 18);
            this.txtKhoaTen.Name = "txtKhoaTen";
            this.txtKhoaTen.Size = new System.Drawing.Size(260, 20);
            this.txtKhoaTen.TabIndex = 3;
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(640, 15);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(110, 27);
            this.btnThemKhoa.TabIndex = 4;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AllowUserToDeleteRows = false;
            this.dgvKhoa.AllowUserToResizeRows = false;
            this.dgvKhoa.AutoGenerateColumns = false;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colKhoa_MaKhoa,
            this.colKhoa_TenKhoa});
            this.dgvKhoa.Location = new System.Drawing.Point(15, 55);
            this.dgvKhoa.MultiSelect = false;
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.RowHeadersVisible = false;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(750, 370);
            this.dgvKhoa.TabIndex = 5;
            // 
            // colKhoa_MaKhoa
            // 
            this.colKhoa_MaKhoa.DataPropertyName = "MaKhoa";
            this.colKhoa_MaKhoa.HeaderText = "Mã khoa";
            this.colKhoa_MaKhoa.Name = "colKhoa_MaKhoa";
            this.colKhoa_MaKhoa.ReadOnly = true;
            // 
            // colKhoa_TenKhoa
            // 
            this.colKhoa_TenKhoa.DataPropertyName = "TenKhoa";
            this.colKhoa_TenKhoa.HeaderText = "Tên khoa";
            this.colKhoa_TenKhoa.Name = "colKhoa_TenKhoa";
            this.colKhoa_TenKhoa.ReadOnly = true;
            // 
            // tabBacSi
            // 
            this.tabBacSi.Location = new System.Drawing.Point(4, 22);
            this.tabBacSi.Name = "tabBacSi";
            this.tabBacSi.Padding = new System.Windows.Forms.Padding(3);
            this.tabBacSi.Size = new System.Drawing.Size(792, 439);
            this.tabBacSi.TabIndex = 1;
            this.tabBacSi.Text = "Bác sĩ";
            this.tabBacSi.UseVisualStyleBackColor = true;
            this.tabBacSi.Controls.Add(this.lblBSMa);
            this.tabBacSi.Controls.Add(this.txtBSMa);
            this.tabBacSi.Controls.Add(this.lblBSTen);
            this.tabBacSi.Controls.Add(this.txtBSTen);
            this.tabBacSi.Controls.Add(this.lblBSKhoa);
            this.tabBacSi.Controls.Add(this.cboBSKhoa);
            this.tabBacSi.Controls.Add(this.lblBSSDT);
            this.tabBacSi.Controls.Add(this.txtBSSDT);
            this.tabBacSi.Controls.Add(this.btnThemBS);
            this.tabBacSi.Controls.Add(this.dgvBS);
            // 
            // lblBSMa
            // 
            this.lblBSMa.Location = new System.Drawing.Point(15, 21);
            this.lblBSMa.Name = "lblBSMa";
            this.lblBSMa.AutoSize = true;
            this.lblBSMa.Size = new System.Drawing.Size(50, 13);
            this.lblBSMa.TabIndex = 0;
            this.lblBSMa.Text = "Mã BS:";
            // 
            // txtBSMa
            // 
            this.txtBSMa.Location = new System.Drawing.Point(65, 18);
            this.txtBSMa.Name = "txtBSMa";
            this.txtBSMa.Size = new System.Drawing.Size(80, 20);
            this.txtBSMa.TabIndex = 1;
            // 
            // lblBSTen
            // 
            this.lblBSTen.Location = new System.Drawing.Point(160, 21);
            this.lblBSTen.Name = "lblBSTen";
            this.lblBSTen.AutoSize = true;
            this.lblBSTen.Size = new System.Drawing.Size(50, 13);
            this.lblBSTen.TabIndex = 2;
            this.lblBSTen.Text = "Họ tên:";
            // 
            // txtBSTen
            // 
            this.txtBSTen.Location = new System.Drawing.Point(210, 18);
            this.txtBSTen.Name = "txtBSTen";
            this.txtBSTen.Size = new System.Drawing.Size(170, 20);
            this.txtBSTen.TabIndex = 3;
            // 
            // lblBSKhoa
            // 
            this.lblBSKhoa.Location = new System.Drawing.Point(395, 21);
            this.lblBSKhoa.Name = "lblBSKhoa";
            this.lblBSKhoa.AutoSize = true;
            this.lblBSKhoa.Size = new System.Drawing.Size(50, 13);
            this.lblBSKhoa.TabIndex = 4;
            this.lblBSKhoa.Text = "Khoa:";
            // 
            // cboBSKhoa
            // 
            this.cboBSKhoa.Location = new System.Drawing.Point(435, 18);
            this.cboBSKhoa.Name = "cboBSKhoa";
            this.cboBSKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBSKhoa.FormattingEnabled = true;
            this.cboBSKhoa.Size = new System.Drawing.Size(150, 21);
            this.cboBSKhoa.TabIndex = 5;
            // 
            // lblBSSDT
            // 
            this.lblBSSDT.Location = new System.Drawing.Point(600, 21);
            this.lblBSSDT.Name = "lblBSSDT";
            this.lblBSSDT.AutoSize = true;
            this.lblBSSDT.Size = new System.Drawing.Size(50, 13);
            this.lblBSSDT.TabIndex = 6;
            this.lblBSSDT.Text = "ĐT:";
            // 
            // txtBSSDT
            // 
            this.txtBSSDT.Location = new System.Drawing.Point(625, 18);
            this.txtBSSDT.Name = "txtBSSDT";
            this.txtBSSDT.Size = new System.Drawing.Size(90, 20);
            this.txtBSSDT.TabIndex = 7;
            // 
            // btnThemBS
            // 
            this.btnThemBS.Location = new System.Drawing.Point(725, 15);
            this.btnThemBS.Name = "btnThemBS";
            this.btnThemBS.Size = new System.Drawing.Size(40, 27);
            this.btnThemBS.TabIndex = 8;
            this.btnThemBS.Text = "Thêm";
            this.btnThemBS.UseVisualStyleBackColor = true;
            this.btnThemBS.Click += new System.EventHandler(this.btnThemBS_Click);
            // 
            // dgvBS
            // 
            this.dgvBS.AllowUserToAddRows = false;
            this.dgvBS.AllowUserToDeleteRows = false;
            this.dgvBS.AllowUserToResizeRows = false;
            this.dgvBS.AutoGenerateColumns = false;
            this.dgvBS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBS.BackgroundColor = System.Drawing.Color.White;
            this.dgvBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBS_MaBS,
            this.colBS_HoTen,
            this.colBS_TenKhoa,
            this.colBS_SoDienThoai});
            this.dgvBS.Location = new System.Drawing.Point(15, 55);
            this.dgvBS.MultiSelect = false;
            this.dgvBS.Name = "dgvBS";
            this.dgvBS.ReadOnly = true;
            this.dgvBS.RowHeadersVisible = false;
            this.dgvBS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBS.Size = new System.Drawing.Size(750, 370);
            this.dgvBS.TabIndex = 9;
            // 
            // colBS_MaBS
            // 
            this.colBS_MaBS.DataPropertyName = "MaBS";
            this.colBS_MaBS.HeaderText = "Mã BS";
            this.colBS_MaBS.Name = "colBS_MaBS";
            this.colBS_MaBS.ReadOnly = true;
            // 
            // colBS_HoTen
            // 
            this.colBS_HoTen.DataPropertyName = "HoTen";
            this.colBS_HoTen.HeaderText = "Họ tên";
            this.colBS_HoTen.Name = "colBS_HoTen";
            this.colBS_HoTen.ReadOnly = true;
            // 
            // colBS_TenKhoa
            // 
            this.colBS_TenKhoa.DataPropertyName = "TenKhoa";
            this.colBS_TenKhoa.HeaderText = "Khoa";
            this.colBS_TenKhoa.Name = "colBS_TenKhoa";
            this.colBS_TenKhoa.ReadOnly = true;
            // 
            // colBS_SoDienThoai
            // 
            this.colBS_SoDienThoai.DataPropertyName = "SoDienThoai";
            this.colBS_SoDienThoai.HeaderText = "Điện thoại";
            this.colBS_SoDienThoai.Name = "colBS_SoDienThoai";
            this.colBS_SoDienThoai.ReadOnly = true;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(792, 439);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            this.tabNhanVien.Controls.Add(this.lblNVMa);
            this.tabNhanVien.Controls.Add(this.txtNVMa);
            this.tabNhanVien.Controls.Add(this.lblNVTen);
            this.tabNhanVien.Controls.Add(this.txtNVTen);
            this.tabNhanVien.Controls.Add(this.lblNVVaiTro);
            this.tabNhanVien.Controls.Add(this.cboNVVaiTro);
            this.tabNhanVien.Controls.Add(this.lblNVSDT);
            this.tabNhanVien.Controls.Add(this.txtNVSDT);
            this.tabNhanVien.Controls.Add(this.btnThemNV);
            this.tabNhanVien.Controls.Add(this.dgvNV);
            // 
            // lblNVMa
            // 
            this.lblNVMa.Location = new System.Drawing.Point(15, 21);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Size = new System.Drawing.Size(50, 13);
            this.lblNVMa.TabIndex = 0;
            this.lblNVMa.Text = "Mã NV:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(65, 18);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(80, 20);
            this.txtNVMa.TabIndex = 1;
            // 
            // lblNVTen
            // 
            this.lblNVTen.Location = new System.Drawing.Point(160, 21);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Size = new System.Drawing.Size(50, 13);
            this.lblNVTen.TabIndex = 2;
            this.lblNVTen.Text = "Họ tên:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(210, 18);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(170, 20);
            this.txtNVTen.TabIndex = 3;
            // 
            // lblNVVaiTro
            // 
            this.lblNVVaiTro.Location = new System.Drawing.Point(395, 21);
            this.lblNVVaiTro.Name = "lblNVVaiTro";
            this.lblNVVaiTro.AutoSize = true;
            this.lblNVVaiTro.Size = new System.Drawing.Size(50, 13);
            this.lblNVVaiTro.TabIndex = 4;
            this.lblNVVaiTro.Text = "Vai trò:";
            // 
            // cboNVVaiTro
            // 
            this.cboNVVaiTro.Location = new System.Drawing.Point(445, 18);
            this.cboNVVaiTro.Name = "cboNVVaiTro";
            this.cboNVVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVVaiTro.FormattingEnabled = true;
            this.cboNVVaiTro.Items.AddRange(new object[] {
                "Chăm sóc khách hàng",
                "Xét nghiệm",
                "Thanh toán",
                "Quản lý"});
            this.cboNVVaiTro.Size = new System.Drawing.Size(140, 21);
            this.cboNVVaiTro.TabIndex = 5;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.Location = new System.Drawing.Point(600, 21);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Size = new System.Drawing.Size(50, 13);
            this.lblNVSDT.TabIndex = 6;
            this.lblNVSDT.Text = "ĐT:";
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(625, 18);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(90, 20);
            this.txtNVSDT.TabIndex = 7;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(725, 15);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(40, 27);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.AllowUserToResizeRows = false;
            this.dgvNV.AutoGenerateColumns = false;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNV_MaNV,
            this.colNV_HoTen,
            this.colNV_VaiTro,
            this.colNV_SoDienThoai});
            this.dgvNV.Location = new System.Drawing.Point(15, 55);
            this.dgvNV.MultiSelect = false;
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(750, 370);
            this.dgvNV.TabIndex = 9;
            // 
            // colNV_MaNV
            // 
            this.colNV_MaNV.DataPropertyName = "MaNV";
            this.colNV_MaNV.HeaderText = "Mã NV";
            this.colNV_MaNV.Name = "colNV_MaNV";
            this.colNV_MaNV.ReadOnly = true;
            // 
            // colNV_HoTen
            // 
            this.colNV_HoTen.DataPropertyName = "HoTen";
            this.colNV_HoTen.HeaderText = "Họ tên";
            this.colNV_HoTen.Name = "colNV_HoTen";
            this.colNV_HoTen.ReadOnly = true;
            // 
            // colNV_VaiTro
            // 
            this.colNV_VaiTro.DataPropertyName = "VaiTro";
            this.colNV_VaiTro.HeaderText = "Vai trò";
            this.colNV_VaiTro.Name = "colNV_VaiTro";
            this.colNV_VaiTro.ReadOnly = true;
            // 
            // colNV_SoDienThoai
            // 
            this.colNV_SoDienThoai.DataPropertyName = "SoDienThoai";
            this.colNV_SoDienThoai.HeaderText = "Điện thoại";
            this.colNV_SoDienThoai.Name = "colNV_SoDienThoai";
            this.colNV_SoDienThoai.ReadOnly = true;
            // 
            // tabLoaiXN
            // 
            this.tabLoaiXN.Location = new System.Drawing.Point(4, 22);
            this.tabLoaiXN.Name = "tabLoaiXN";
            this.tabLoaiXN.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiXN.Size = new System.Drawing.Size(792, 439);
            this.tabLoaiXN.TabIndex = 3;
            this.tabLoaiXN.Text = "Loại xét nghiệm";
            this.tabLoaiXN.UseVisualStyleBackColor = true;
            this.tabLoaiXN.Controls.Add(this.lblLoaiXNMa);
            this.tabLoaiXN.Controls.Add(this.txtLoaiXNMa);
            this.tabLoaiXN.Controls.Add(this.lblLoaiXNTen);
            this.tabLoaiXN.Controls.Add(this.txtLoaiXNTen);
            this.tabLoaiXN.Controls.Add(this.btnThemLoaiXN);
            this.tabLoaiXN.Controls.Add(this.dgvLoaiXN);
            // 
            // lblLoaiXNMa
            // 
            this.lblLoaiXNMa.Location = new System.Drawing.Point(15, 21);
            this.lblLoaiXNMa.Name = "lblLoaiXNMa";
            this.lblLoaiXNMa.AutoSize = true;
            this.lblLoaiXNMa.Size = new System.Drawing.Size(50, 13);
            this.lblLoaiXNMa.TabIndex = 0;
            this.lblLoaiXNMa.Text = "Mã loại XN:";
            // 
            // txtLoaiXNMa
            // 
            this.txtLoaiXNMa.Location = new System.Drawing.Point(85, 18);
            this.txtLoaiXNMa.Name = "txtLoaiXNMa";
            this.txtLoaiXNMa.Size = new System.Drawing.Size(100, 20);
            this.txtLoaiXNMa.TabIndex = 1;
            // 
            // lblLoaiXNTen
            // 
            this.lblLoaiXNTen.Location = new System.Drawing.Point(205, 21);
            this.lblLoaiXNTen.Name = "lblLoaiXNTen";
            this.lblLoaiXNTen.AutoSize = true;
            this.lblLoaiXNTen.Size = new System.Drawing.Size(50, 13);
            this.lblLoaiXNTen.TabIndex = 2;
            this.lblLoaiXNTen.Text = "Tên loại XN:";
            // 
            // txtLoaiXNTen
            // 
            this.txtLoaiXNTen.Location = new System.Drawing.Point(280, 18);
            this.txtLoaiXNTen.Name = "txtLoaiXNTen";
            this.txtLoaiXNTen.Size = new System.Drawing.Size(260, 20);
            this.txtLoaiXNTen.TabIndex = 3;
            // 
            // btnThemLoaiXN
            // 
            this.btnThemLoaiXN.Location = new System.Drawing.Point(640, 15);
            this.btnThemLoaiXN.Name = "btnThemLoaiXN";
            this.btnThemLoaiXN.Size = new System.Drawing.Size(110, 27);
            this.btnThemLoaiXN.TabIndex = 4;
            this.btnThemLoaiXN.Text = "Thêm";
            this.btnThemLoaiXN.UseVisualStyleBackColor = true;
            this.btnThemLoaiXN.Click += new System.EventHandler(this.btnThemLoaiXN_Click);
            // 
            // dgvLoaiXN
            // 
            this.dgvLoaiXN.AllowUserToAddRows = false;
            this.dgvLoaiXN.AllowUserToDeleteRows = false;
            this.dgvLoaiXN.AllowUserToResizeRows = false;
            this.dgvLoaiXN.AutoGenerateColumns = false;
            this.dgvLoaiXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiXN.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiXN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLoaiXN_MaLoaiXN,
            this.colLoaiXN_TenLoaiXN});
            this.dgvLoaiXN.Location = new System.Drawing.Point(15, 55);
            this.dgvLoaiXN.MultiSelect = false;
            this.dgvLoaiXN.Name = "dgvLoaiXN";
            this.dgvLoaiXN.ReadOnly = true;
            this.dgvLoaiXN.RowHeadersVisible = false;
            this.dgvLoaiXN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiXN.Size = new System.Drawing.Size(750, 370);
            this.dgvLoaiXN.TabIndex = 5;
            // 
            // colLoaiXN_MaLoaiXN
            // 
            this.colLoaiXN_MaLoaiXN.DataPropertyName = "MaLoaiXN";
            this.colLoaiXN_MaLoaiXN.HeaderText = "Mã loại XN";
            this.colLoaiXN_MaLoaiXN.Name = "colLoaiXN_MaLoaiXN";
            this.colLoaiXN_MaLoaiXN.ReadOnly = true;
            // 
            // colLoaiXN_TenLoaiXN
            // 
            this.colLoaiXN_TenLoaiXN.DataPropertyName = "TenLoaiXN";
            this.colLoaiXN_TenLoaiXN.HeaderText = "Tên loại xét nghiệm";
            this.colLoaiXN_TenLoaiXN.Name = "colLoaiXN_TenLoaiXN";
            this.colLoaiXN_TenLoaiXN.ReadOnly = true;
            // 
            // tabThuoc
            // 
            this.tabThuoc.Location = new System.Drawing.Point(4, 22);
            this.tabThuoc.Name = "tabThuoc";
            this.tabThuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabThuoc.Size = new System.Drawing.Size(792, 439);
            this.tabThuoc.TabIndex = 4;
            this.tabThuoc.Text = "Thuốc";
            this.tabThuoc.UseVisualStyleBackColor = true;
            this.tabThuoc.Controls.Add(this.lblThuocMa);
            this.tabThuoc.Controls.Add(this.txtThuocMa);
            this.tabThuoc.Controls.Add(this.lblThuocTen);
            this.tabThuoc.Controls.Add(this.txtThuocTen);
            this.tabThuoc.Controls.Add(this.lblThuocDVT);
            this.tabThuoc.Controls.Add(this.txtThuocDVT);
            this.tabThuoc.Controls.Add(this.lblThuocPUP);
            this.tabThuoc.Controls.Add(this.txtThuocPUP);
            this.tabThuoc.Controls.Add(this.btnThemThuoc);
            this.tabThuoc.Controls.Add(this.dgvThuoc);
            // 
            // lblThuocMa
            // 
            this.lblThuocMa.Location = new System.Drawing.Point(15, 21);
            this.lblThuocMa.Name = "lblThuocMa";
            this.lblThuocMa.AutoSize = true;
            this.lblThuocMa.Size = new System.Drawing.Size(50, 13);
            this.lblThuocMa.TabIndex = 0;
            this.lblThuocMa.Text = "Mã thuốc:";
            // 
            // txtThuocMa
            // 
            this.txtThuocMa.Location = new System.Drawing.Point(75, 18);
            this.txtThuocMa.Name = "txtThuocMa";
            this.txtThuocMa.Size = new System.Drawing.Size(90, 20);
            this.txtThuocMa.TabIndex = 1;
            // 
            // lblThuocTen
            // 
            this.lblThuocTen.Location = new System.Drawing.Point(180, 21);
            this.lblThuocTen.Name = "lblThuocTen";
            this.lblThuocTen.AutoSize = true;
            this.lblThuocTen.Size = new System.Drawing.Size(50, 13);
            this.lblThuocTen.TabIndex = 2;
            this.lblThuocTen.Text = "Tên thuốc:";
            // 
            // txtThuocTen
            // 
            this.txtThuocTen.Location = new System.Drawing.Point(245, 18);
            this.txtThuocTen.Name = "txtThuocTen";
            this.txtThuocTen.Size = new System.Drawing.Size(200, 20);
            this.txtThuocTen.TabIndex = 3;
            // 
            // lblThuocDVT
            // 
            this.lblThuocDVT.Location = new System.Drawing.Point(460, 21);
            this.lblThuocDVT.Name = "lblThuocDVT";
            this.lblThuocDVT.AutoSize = true;
            this.lblThuocDVT.Size = new System.Drawing.Size(50, 13);
            this.lblThuocDVT.TabIndex = 4;
            this.lblThuocDVT.Text = "ĐVT:";
            // 
            // txtThuocDVT
            // 
            this.txtThuocDVT.Location = new System.Drawing.Point(495, 18);
            this.txtThuocDVT.Name = "txtThuocDVT";
            this.txtThuocDVT.Size = new System.Drawing.Size(70, 20);
            this.txtThuocDVT.TabIndex = 5;
            // 
            // lblThuocPUP
            // 
            this.lblThuocPUP.Location = new System.Drawing.Point(580, 21);
            this.lblThuocPUP.Name = "lblThuocPUP";
            this.lblThuocPUP.AutoSize = true;
            this.lblThuocPUP.Size = new System.Drawing.Size(50, 13);
            this.lblThuocPUP.TabIndex = 6;
            this.lblThuocPUP.Text = "Phản ứng phụ:";
            // 
            // txtThuocPUP
            // 
            this.txtThuocPUP.Location = new System.Drawing.Point(655, 18);
            this.txtThuocPUP.Name = "txtThuocPUP";
            this.txtThuocPUP.Size = new System.Drawing.Size(100, 20);
            this.txtThuocPUP.TabIndex = 7;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(655, 45);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(100, 27);
            this.btnThemThuoc.TabIndex = 8;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.AllowUserToResizeRows = false;
            this.dgvThuoc.AutoGenerateColumns = false;
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colThuoc_MaThuoc,
            this.colThuoc_TenThuoc,
            this.colThuoc_DonViTinh,
            this.colThuoc_PhanUngPhu});
            this.dgvThuoc.Location = new System.Drawing.Point(15, 80);
            this.dgvThuoc.MultiSelect = false;
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(750, 345);
            this.dgvThuoc.TabIndex = 9;
            // 
            // colThuoc_MaThuoc
            // 
            this.colThuoc_MaThuoc.DataPropertyName = "MaThuoc";
            this.colThuoc_MaThuoc.HeaderText = "Mã thuốc";
            this.colThuoc_MaThuoc.Name = "colThuoc_MaThuoc";
            this.colThuoc_MaThuoc.ReadOnly = true;
            // 
            // colThuoc_TenThuoc
            // 
            this.colThuoc_TenThuoc.DataPropertyName = "TenThuoc";
            this.colThuoc_TenThuoc.HeaderText = "Tên thuốc";
            this.colThuoc_TenThuoc.Name = "colThuoc_TenThuoc";
            this.colThuoc_TenThuoc.ReadOnly = true;
            // 
            // colThuoc_DonViTinh
            // 
            this.colThuoc_DonViTinh.DataPropertyName = "DonViTinh";
            this.colThuoc_DonViTinh.HeaderText = "Đơn vị tính";
            this.colThuoc_DonViTinh.Name = "colThuoc_DonViTinh";
            this.colThuoc_DonViTinh.ReadOnly = true;
            // 
            // colThuoc_PhanUngPhu
            // 
            this.colThuoc_PhanUngPhu.DataPropertyName = "PhanUngPhu";
            this.colThuoc_PhanUngPhu.HeaderText = "Phản ứng phụ";
            this.colThuoc_PhanUngPhu.Name = "colThuoc_PhanUngPhu";
            this.colThuoc_PhanUngPhu.ReadOnly = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(700, 480);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 27);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 520);
            this.Controls.Add(this.tabDanhMuc);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục bệnh viện";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiXN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.tabDanhMuc.ResumeLayout(false);
            this.tabDanhMuc.PerformLayout();
            this.tabKhoa.ResumeLayout(false);
            this.tabBacSi.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.tabLoaiXN.ResumeLayout(false);
            this.tabThuoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDanhMuc;
        private System.Windows.Forms.TabPage tabKhoa;
        private System.Windows.Forms.Label lblKhoaMa;
        private System.Windows.Forms.TextBox txtKhoaMa;
        private System.Windows.Forms.Label lblKhoaTen;
        private System.Windows.Forms.TextBox txtKhoaTen;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa_MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa_TenKhoa;
        private System.Windows.Forms.TabPage tabBacSi;
        private System.Windows.Forms.Label lblBSMa;
        private System.Windows.Forms.TextBox txtBSMa;
        private System.Windows.Forms.Label lblBSTen;
        private System.Windows.Forms.TextBox txtBSTen;
        private System.Windows.Forms.Label lblBSKhoa;
        private System.Windows.Forms.ComboBox cboBSKhoa;
        private System.Windows.Forms.Label lblBSSDT;
        private System.Windows.Forms.TextBox txtBSSDT;
        private System.Windows.Forms.Button btnThemBS;
        private System.Windows.Forms.DataGridView dgvBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBS_MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBS_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBS_TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBS_SoDienThoai;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVVaiTro;
        private System.Windows.Forms.ComboBox cboNVVaiTro;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNV_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNV_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNV_VaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNV_SoDienThoai;
        private System.Windows.Forms.TabPage tabLoaiXN;
        private System.Windows.Forms.Label lblLoaiXNMa;
        private System.Windows.Forms.TextBox txtLoaiXNMa;
        private System.Windows.Forms.Label lblLoaiXNTen;
        private System.Windows.Forms.TextBox txtLoaiXNTen;
        private System.Windows.Forms.Button btnThemLoaiXN;
        private System.Windows.Forms.DataGridView dgvLoaiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiXN_MaLoaiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiXN_TenLoaiXN;
        private System.Windows.Forms.TabPage tabThuoc;
        private System.Windows.Forms.Label lblThuocMa;
        private System.Windows.Forms.TextBox txtThuocMa;
        private System.Windows.Forms.Label lblThuocTen;
        private System.Windows.Forms.TextBox txtThuocTen;
        private System.Windows.Forms.Label lblThuocDVT;
        private System.Windows.Forms.TextBox txtThuocDVT;
        private System.Windows.Forms.Label lblThuocPUP;
        private System.Windows.Forms.TextBox txtThuocPUP;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_PhanUngPhu;
        private System.Windows.Forms.Button btnDong;
    }
}
