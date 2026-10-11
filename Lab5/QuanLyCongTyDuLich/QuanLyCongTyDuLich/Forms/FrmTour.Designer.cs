namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmTour
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
            this.tabTour = new System.Windows.Forms.TabPage();
            this.tabLoTrinh = new System.Windows.Forms.TabPage();
            this.tabChuyen = new System.Windows.Forms.TabPage();
            this.lblMaTour = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.lblTenTour = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.lblSoDem = new System.Windows.Forms.Label();
            this.numSoDem = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThemTour = new System.Windows.Forms.Button();
            this.btnSuaTour = new System.Windows.Forms.Button();
            this.btnXoaTour = new System.Windows.Forms.Button();
            this.btnLamMoiTour = new System.Windows.Forms.Button();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.lblTourLoTrinh = new System.Windows.Forms.Label();
            this.cboTourLoTrinh = new System.Windows.Forms.ComboBox();
            this.lblGhiChuHCM = new System.Windows.Forms.Label();
            this.grpDungChan = new System.Windows.Forms.GroupBox();
            this.lblThuTu = new System.Windows.Forms.Label();
            this.numThuTu = new System.Windows.Forms.NumericUpDown();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.cboDiaDiem = new System.Windows.Forms.ComboBox();
            this.lblPhuongTien = new System.Windows.Forms.Label();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.chkDoiPhuongTien = new System.Windows.Forms.CheckBox();
            this.chkCoNoiAn = new System.Windows.Forms.CheckBox();
            this.chkCoKhachSan = new System.Windows.Forms.CheckBox();
            this.lblLoaiKhachSan = new System.Windows.Forms.Label();
            this.cboLoaiKhachSan = new System.Windows.Forms.ComboBox();
            this.btnThemDungChan = new System.Windows.Forms.Button();
            this.btnXoaDungChan = new System.Windows.Forms.Button();
            this.dgvDungChan = new System.Windows.Forms.DataGridView();
            this.grpDiemTQ = new System.Windows.Forms.GroupBox();
            this.lblDiemTQ = new System.Windows.Forms.Label();
            this.cboDiemThamQuan = new System.Windows.Forms.ComboBox();
            this.btnThemDiemTQ = new System.Windows.Forms.Button();
            this.btnXoaDiemTQ = new System.Windows.Forms.Button();
            this.dgvDiemTQ = new System.Windows.Forms.DataGridView();
            this.lblTourChuyen = new System.Windows.Forms.Label();
            this.cboTourChuyen = new System.Windows.Forms.ComboBox();
            this.lblMaChuyen = new System.Windows.Forms.Label();
            this.txtMaChuyen = new System.Windows.Forms.TextBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.dtpNgayVe = new System.Windows.Forms.DateTimePicker();
            this.lblSoCho = new System.Windows.Forms.Label();
            this.numSoCho = new System.Windows.Forms.NumericUpDown();
            this.btnThemChuyen = new System.Windows.Forms.Button();
            this.btnSuaChuyen = new System.Windows.Forms.Button();
            this.btnXoaChuyen = new System.Windows.Forms.Button();
            this.btnLamMoiChuyen = new System.Windows.Forms.Button();
            this.dgvChuyen = new System.Windows.Forms.DataGridView();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungChan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyen)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabTour.SuspendLayout();
            this.tabLoTrinh.SuspendLayout();
            this.tabChuyen.SuspendLayout();
            this.grpDungChan.SuspendLayout();
            this.grpDiemTQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(880, 550);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Controls.Add(this.tabTour);
            this.tabControl.Controls.Add(this.tabLoTrinh);
            this.tabControl.Controls.Add(this.tabChuyen);
            // 
            // tabTour
            // 
            this.tabTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabTour.UseVisualStyleBackColor = true;
            this.tabTour.Name = "tabTour";
            this.tabTour.Text = "Tour";
            this.tabTour.Controls.Add(this.lblMaTour);
            this.tabTour.Controls.Add(this.txtMaTour);
            this.tabTour.Controls.Add(this.lblTenTour);
            this.tabTour.Controls.Add(this.txtTenTour);
            this.tabTour.Controls.Add(this.lblSoNgay);
            this.tabTour.Controls.Add(this.numSoNgay);
            this.tabTour.Controls.Add(this.lblSoDem);
            this.tabTour.Controls.Add(this.numSoDem);
            this.tabTour.Controls.Add(this.lblDonGia);
            this.tabTour.Controls.Add(this.txtDonGia);
            this.tabTour.Controls.Add(this.btnThemTour);
            this.tabTour.Controls.Add(this.btnSuaTour);
            this.tabTour.Controls.Add(this.btnXoaTour);
            this.tabTour.Controls.Add(this.btnLamMoiTour);
            this.tabTour.Controls.Add(this.dgvTour);
            // 
            // tabLoTrinh
            // 
            this.tabLoTrinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoTrinh.UseVisualStyleBackColor = true;
            this.tabLoTrinh.Name = "tabLoTrinh";
            this.tabLoTrinh.Text = "Lộ trình & điểm tham quan";
            this.tabLoTrinh.Controls.Add(this.lblTourLoTrinh);
            this.tabLoTrinh.Controls.Add(this.cboTourLoTrinh);
            this.tabLoTrinh.Controls.Add(this.lblGhiChuHCM);
            this.tabLoTrinh.Controls.Add(this.grpDungChan);
            this.tabLoTrinh.Controls.Add(this.dgvDungChan);
            this.tabLoTrinh.Controls.Add(this.grpDiemTQ);
            // 
            // tabChuyen
            // 
            this.tabChuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tabChuyen.UseVisualStyleBackColor = true;
            this.tabChuyen.Name = "tabChuyen";
            this.tabChuyen.Text = "Chuyến tour";
            this.tabChuyen.Controls.Add(this.lblTourChuyen);
            this.tabChuyen.Controls.Add(this.cboTourChuyen);
            this.tabChuyen.Controls.Add(this.lblMaChuyen);
            this.tabChuyen.Controls.Add(this.txtMaChuyen);
            this.tabChuyen.Controls.Add(this.lblNgayDi);
            this.tabChuyen.Controls.Add(this.dtpNgayDi);
            this.tabChuyen.Controls.Add(this.lblNgayVe);
            this.tabChuyen.Controls.Add(this.dtpNgayVe);
            this.tabChuyen.Controls.Add(this.lblSoCho);
            this.tabChuyen.Controls.Add(this.numSoCho);
            this.tabChuyen.Controls.Add(this.btnThemChuyen);
            this.tabChuyen.Controls.Add(this.btnSuaChuyen);
            this.tabChuyen.Controls.Add(this.btnXoaChuyen);
            this.tabChuyen.Controls.Add(this.btnLamMoiChuyen);
            this.tabChuyen.Controls.Add(this.dgvChuyen);
            // 
            // lblMaTour
            // 
            this.lblMaTour.AutoSize = true;
            this.lblMaTour.Location = new System.Drawing.Point(15, 20);
            this.lblMaTour.Name = "lblMaTour";
            this.lblMaTour.Size = new System.Drawing.Size(54, 13);
            this.lblMaTour.TabIndex = 0;
            this.lblMaTour.Text = "Mã tour:";
            // 
            // txtMaTour
            // 
            this.txtMaTour.MaxLength = 20;
            this.txtMaTour.Location = new System.Drawing.Point(90, 17);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(140, 20);
            this.txtMaTour.TabIndex = 1;
            // 
            // lblTenTour
            // 
            this.lblTenTour.AutoSize = true;
            this.lblTenTour.Location = new System.Drawing.Point(250, 20);
            this.lblTenTour.Name = "lblTenTour";
            this.lblTenTour.Size = new System.Drawing.Size(60, 13);
            this.lblTenTour.TabIndex = 2;
            this.lblTenTour.Text = "Tên tour:";
            // 
            // txtTenTour
            // 
            this.txtTenTour.MaxLength = 100;
            this.txtTenTour.Location = new System.Drawing.Point(320, 17);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(320, 20);
            this.txtTenTour.TabIndex = 3;
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new System.Drawing.Point(15, 52);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(54, 13);
            this.lblSoNgay.TabIndex = 4;
            this.lblSoNgay.Text = "Số ngày:";
            // 
            // numSoNgay
            // 
            this.numSoNgay.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            this.numSoNgay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoNgay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNgay.Location = new System.Drawing.Point(90, 49);
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(70, 20);
            this.numSoNgay.TabIndex = 5;
            // 
            // lblSoDem
            // 
            this.lblSoDem.AutoSize = true;
            this.lblSoDem.Location = new System.Drawing.Point(180, 52);
            this.lblSoDem.Name = "lblSoDem";
            this.lblSoDem.Size = new System.Drawing.Size(48, 13);
            this.lblSoDem.TabIndex = 6;
            this.lblSoDem.Text = "Số đêm:";
            // 
            // numSoDem
            // 
            this.numSoDem.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            this.numSoDem.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numSoDem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoDem.Value = new decimal(new int[] { 0, 0, 0, 0 });
            this.numSoDem.Location = new System.Drawing.Point(240, 49);
            this.numSoDem.Name = "numSoDem";
            this.numSoDem.Size = new System.Drawing.Size(70, 20);
            this.numSoDem.TabIndex = 7;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(330, 52);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(92, 13);
            this.lblDonGia.TabIndex = 8;
            this.lblDonGia.Text = "Đơn giá/khách:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDonGia.Location = new System.Drawing.Point(425, 49);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(115, 20);
            this.txtDonGia.TabIndex = 9;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // btnThemTour
            // 
            this.btnThemTour.UseVisualStyleBackColor = true;
            this.btnThemTour.Location = new System.Drawing.Point(680, 15);
            this.btnThemTour.Name = "btnThemTour";
            this.btnThemTour.Size = new System.Drawing.Size(85, 26);
            this.btnThemTour.TabIndex = 10;
            this.btnThemTour.Text = "Thêm";
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);
            // 
            // btnSuaTour
            // 
            this.btnSuaTour.UseVisualStyleBackColor = true;
            this.btnSuaTour.Location = new System.Drawing.Point(771, 15);
            this.btnSuaTour.Name = "btnSuaTour";
            this.btnSuaTour.Size = new System.Drawing.Size(85, 26);
            this.btnSuaTour.TabIndex = 11;
            this.btnSuaTour.Text = "Sửa";
            this.btnSuaTour.Click += new System.EventHandler(this.btnSuaTour_Click);
            // 
            // btnXoaTour
            // 
            this.btnXoaTour.UseVisualStyleBackColor = true;
            this.btnXoaTour.Location = new System.Drawing.Point(680, 47);
            this.btnXoaTour.Name = "btnXoaTour";
            this.btnXoaTour.Size = new System.Drawing.Size(85, 26);
            this.btnXoaTour.TabIndex = 12;
            this.btnXoaTour.Text = "Xóa";
            this.btnXoaTour.Click += new System.EventHandler(this.btnXoaTour_Click);
            // 
            // btnLamMoiTour
            // 
            this.btnLamMoiTour.UseVisualStyleBackColor = true;
            this.btnLamMoiTour.Location = new System.Drawing.Point(771, 47);
            this.btnLamMoiTour.Name = "btnLamMoiTour";
            this.btnLamMoiTour.Size = new System.Drawing.Size(85, 26);
            this.btnLamMoiTour.TabIndex = 13;
            this.btnLamMoiTour.Text = "Làm mới";
            this.btnLamMoiTour.Click += new System.EventHandler(this.btnLamMoiTour_Click);
            // 
            // dgvTour
            // 
            this.dgvTour.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvTour.AllowUserToAddRows = false;
            this.dgvTour.AllowUserToDeleteRows = false;
            this.dgvTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvTour.MultiSelect = false;
            this.dgvTour.ReadOnly = true;
            this.dgvTour.RowHeadersVisible = false;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.Location = new System.Drawing.Point(15, 90);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.Size = new System.Drawing.Size(845, 415);
            this.dgvTour.TabIndex = 14;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // lblTourLoTrinh
            // 
            this.lblTourLoTrinh.AutoSize = true;
            this.lblTourLoTrinh.Location = new System.Drawing.Point(15, 20);
            this.lblTourLoTrinh.Name = "lblTourLoTrinh";
            this.lblTourLoTrinh.Size = new System.Drawing.Size(35, 13);
            this.lblTourLoTrinh.TabIndex = 0;
            this.lblTourLoTrinh.Text = "Tour:";
            // 
            // cboTourLoTrinh
            // 
            this.cboTourLoTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTourLoTrinh.FormattingEnabled = true;
            this.cboTourLoTrinh.Location = new System.Drawing.Point(60, 17);
            this.cboTourLoTrinh.Name = "cboTourLoTrinh";
            this.cboTourLoTrinh.Size = new System.Drawing.Size(380, 21);
            this.cboTourLoTrinh.TabIndex = 1;
            this.cboTourLoTrinh.SelectedIndexChanged += new System.EventHandler(this.cboTourLoTrinh_SelectedIndexChanged);
            // 
            // lblGhiChuHCM
            // 
            this.lblGhiChuHCM.AutoSize = true;
            this.lblGhiChuHCM.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.lblGhiChuHCM.Location = new System.Drawing.Point(460, 20);
            this.lblGhiChuHCM.Name = "lblGhiChuHCM";
            this.lblGhiChuHCM.Size = new System.Drawing.Size(508, 13);
            this.lblGhiChuHCM.TabIndex = 2;
            this.lblGhiChuHCM.Text = "Lưu ý: mọi tour xuất phát và kết thúc tại TP.HCM (nơi dừng chân cuối là TP.HCM).";
            // 
            // grpDungChan
            // 
            this.grpDungChan.Location = new System.Drawing.Point(15, 50);
            this.grpDungChan.Name = "grpDungChan";
            this.grpDungChan.Size = new System.Drawing.Size(845, 140);
            this.grpDungChan.TabIndex = 3;
            this.grpDungChan.Text = "Nơi dừng chân";
            this.grpDungChan.Controls.Add(this.lblThuTu);
            this.grpDungChan.Controls.Add(this.numThuTu);
            this.grpDungChan.Controls.Add(this.lblDiaDiem);
            this.grpDungChan.Controls.Add(this.cboDiaDiem);
            this.grpDungChan.Controls.Add(this.lblPhuongTien);
            this.grpDungChan.Controls.Add(this.cboPhuongTien);
            this.grpDungChan.Controls.Add(this.chkDoiPhuongTien);
            this.grpDungChan.Controls.Add(this.chkCoNoiAn);
            this.grpDungChan.Controls.Add(this.chkCoKhachSan);
            this.grpDungChan.Controls.Add(this.lblLoaiKhachSan);
            this.grpDungChan.Controls.Add(this.cboLoaiKhachSan);
            this.grpDungChan.Controls.Add(this.btnThemDungChan);
            this.grpDungChan.Controls.Add(this.btnXoaDungChan);
            // 
            // lblThuTu
            // 
            this.lblThuTu.AutoSize = true;
            this.lblThuTu.Location = new System.Drawing.Point(15, 30);
            this.lblThuTu.Name = "lblThuTu";
            this.lblThuTu.Size = new System.Drawing.Size(48, 13);
            this.lblThuTu.TabIndex = 0;
            this.lblThuTu.Text = "Thứ tự:";
            // 
            // numThuTu
            // 
            this.numThuTu.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numThuTu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numThuTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numThuTu.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numThuTu.Location = new System.Drawing.Point(65, 27);
            this.numThuTu.Name = "numThuTu";
            this.numThuTu.Size = new System.Drawing.Size(55, 20);
            this.numThuTu.TabIndex = 1;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(140, 30);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(60, 13);
            this.lblDiaDiem.TabIndex = 2;
            this.lblDiaDiem.Text = "Địa điểm:";
            // 
            // cboDiaDiem
            // 
            this.cboDiaDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiaDiem.FormattingEnabled = true;
            this.cboDiaDiem.Location = new System.Drawing.Point(200, 27);
            this.cboDiaDiem.Name = "cboDiaDiem";
            this.cboDiaDiem.Size = new System.Drawing.Size(180, 21);
            this.cboDiaDiem.TabIndex = 3;
            // 
            // lblPhuongTien
            // 
            this.lblPhuongTien.AutoSize = true;
            this.lblPhuongTien.Location = new System.Drawing.Point(400, 30);
            this.lblPhuongTien.Name = "lblPhuongTien";
            this.lblPhuongTien.Size = new System.Drawing.Size(104, 13);
            this.lblPhuongTien.TabIndex = 4;
            this.lblPhuongTien.Text = "Phương tiện đến:";
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Location = new System.Drawing.Point(500, 27);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(150, 21);
            this.cboPhuongTien.TabIndex = 5;
            // 
            // chkDoiPhuongTien
            // 
            this.chkDoiPhuongTien.AutoSize = true;
            this.chkDoiPhuongTien.UseVisualStyleBackColor = true;
            this.chkDoiPhuongTien.Location = new System.Drawing.Point(15, 65);
            this.chkDoiPhuongTien.Name = "chkDoiPhuongTien";
            this.chkDoiPhuongTien.Size = new System.Drawing.Size(118, 17);
            this.chkDoiPhuongTien.TabIndex = 6;
            this.chkDoiPhuongTien.Text = "Đổi phương tiện";
            // 
            // chkCoNoiAn
            // 
            this.chkCoNoiAn.AutoSize = true;
            this.chkCoNoiAn.UseVisualStyleBackColor = true;
            this.chkCoNoiAn.Location = new System.Drawing.Point(150, 65);
            this.chkCoNoiAn.Name = "chkCoNoiAn";
            this.chkCoNoiAn.Size = new System.Drawing.Size(80, 17);
            this.chkCoNoiAn.TabIndex = 7;
            this.chkCoNoiAn.Text = "Có nơi ăn";
            // 
            // chkCoKhachSan
            // 
            this.chkCoKhachSan.AutoSize = true;
            this.chkCoKhachSan.UseVisualStyleBackColor = true;
            this.chkCoKhachSan.Location = new System.Drawing.Point(255, 65);
            this.chkCoKhachSan.Name = "chkCoKhachSan";
            this.chkCoKhachSan.Size = new System.Drawing.Size(99, 17);
            this.chkCoKhachSan.TabIndex = 8;
            this.chkCoKhachSan.Text = "Có khách sạn";
            this.chkCoKhachSan.CheckedChanged += new System.EventHandler(this.chkCoKhachSan_CheckedChanged);
            // 
            // lblLoaiKhachSan
            // 
            this.lblLoaiKhachSan.AutoSize = true;
            this.lblLoaiKhachSan.Location = new System.Drawing.Point(385, 67);
            this.lblLoaiKhachSan.Name = "lblLoaiKhachSan";
            this.lblLoaiKhachSan.Size = new System.Drawing.Size(92, 13);
            this.lblLoaiKhachSan.TabIndex = 9;
            this.lblLoaiKhachSan.Text = "Loại KS (sao):";
            // 
            // cboLoaiKhachSan
            // 
            this.cboLoaiKhachSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKhachSan.FormattingEnabled = true;
            this.cboLoaiKhachSan.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cboLoaiKhachSan.Enabled = false;
            this.cboLoaiKhachSan.Location = new System.Drawing.Point(480, 63);
            this.cboLoaiKhachSan.Name = "cboLoaiKhachSan";
            this.cboLoaiKhachSan.Size = new System.Drawing.Size(60, 21);
            this.cboLoaiKhachSan.TabIndex = 10;
            // 
            // btnThemDungChan
            // 
            this.btnThemDungChan.UseVisualStyleBackColor = true;
            this.btnThemDungChan.Location = new System.Drawing.Point(15, 98);
            this.btnThemDungChan.Name = "btnThemDungChan";
            this.btnThemDungChan.Size = new System.Drawing.Size(90, 28);
            this.btnThemDungChan.TabIndex = 11;
            this.btnThemDungChan.Text = "Thêm";
            this.btnThemDungChan.Click += new System.EventHandler(this.btnThemDungChan_Click);
            // 
            // btnXoaDungChan
            // 
            this.btnXoaDungChan.UseVisualStyleBackColor = true;
            this.btnXoaDungChan.Location = new System.Drawing.Point(111, 98);
            this.btnXoaDungChan.Name = "btnXoaDungChan";
            this.btnXoaDungChan.Size = new System.Drawing.Size(90, 28);
            this.btnXoaDungChan.TabIndex = 12;
            this.btnXoaDungChan.Text = "Xóa";
            this.btnXoaDungChan.Click += new System.EventHandler(this.btnXoaDungChan_Click);
            // 
            // dgvDungChan
            // 
            this.dgvDungChan.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvDungChan.AllowUserToAddRows = false;
            this.dgvDungChan.AllowUserToDeleteRows = false;
            this.dgvDungChan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDungChan.MultiSelect = false;
            this.dgvDungChan.ReadOnly = true;
            this.dgvDungChan.RowHeadersVisible = false;
            this.dgvDungChan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDungChan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDungChan.Location = new System.Drawing.Point(15, 198);
            this.dgvDungChan.Name = "dgvDungChan";
            this.dgvDungChan.Size = new System.Drawing.Size(845, 130);
            this.dgvDungChan.TabIndex = 4;
            // 
            // grpDiemTQ
            // 
            this.grpDiemTQ.Location = new System.Drawing.Point(15, 336);
            this.grpDiemTQ.Name = "grpDiemTQ";
            this.grpDiemTQ.Size = new System.Drawing.Size(845, 168);
            this.grpDiemTQ.TabIndex = 5;
            this.grpDiemTQ.Text = "Điểm tham quan của tour";
            this.grpDiemTQ.Controls.Add(this.lblDiemTQ);
            this.grpDiemTQ.Controls.Add(this.cboDiemThamQuan);
            this.grpDiemTQ.Controls.Add(this.btnThemDiemTQ);
            this.grpDiemTQ.Controls.Add(this.btnXoaDiemTQ);
            this.grpDiemTQ.Controls.Add(this.dgvDiemTQ);
            // 
            // lblDiemTQ
            // 
            this.lblDiemTQ.AutoSize = true;
            this.lblDiemTQ.Location = new System.Drawing.Point(15, 30);
            this.lblDiemTQ.Name = "lblDiemTQ";
            this.lblDiemTQ.Size = new System.Drawing.Size(98, 13);
            this.lblDiemTQ.TabIndex = 0;
            this.lblDiemTQ.Text = "Điểm tham quan:";
            // 
            // cboDiemThamQuan
            // 
            this.cboDiemThamQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemThamQuan.FormattingEnabled = true;
            this.cboDiemThamQuan.Location = new System.Drawing.Point(115, 27);
            this.cboDiemThamQuan.Name = "cboDiemThamQuan";
            this.cboDiemThamQuan.Size = new System.Drawing.Size(330, 21);
            this.cboDiemThamQuan.TabIndex = 1;
            // 
            // btnThemDiemTQ
            // 
            this.btnThemDiemTQ.UseVisualStyleBackColor = true;
            this.btnThemDiemTQ.Location = new System.Drawing.Point(465, 24);
            this.btnThemDiemTQ.Name = "btnThemDiemTQ";
            this.btnThemDiemTQ.Size = new System.Drawing.Size(90, 28);
            this.btnThemDiemTQ.TabIndex = 2;
            this.btnThemDiemTQ.Text = "Thêm";
            this.btnThemDiemTQ.Click += new System.EventHandler(this.btnThemDiemTQ_Click);
            // 
            // btnXoaDiemTQ
            // 
            this.btnXoaDiemTQ.UseVisualStyleBackColor = true;
            this.btnXoaDiemTQ.Location = new System.Drawing.Point(561, 24);
            this.btnXoaDiemTQ.Name = "btnXoaDiemTQ";
            this.btnXoaDiemTQ.Size = new System.Drawing.Size(90, 28);
            this.btnXoaDiemTQ.TabIndex = 3;
            this.btnXoaDiemTQ.Text = "Xóa";
            this.btnXoaDiemTQ.Click += new System.EventHandler(this.btnXoaDiemTQ_Click);
            // 
            // dgvDiemTQ
            // 
            this.dgvDiemTQ.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvDiemTQ.AllowUserToAddRows = false;
            this.dgvDiemTQ.AllowUserToDeleteRows = false;
            this.dgvDiemTQ.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemTQ.MultiSelect = false;
            this.dgvDiemTQ.ReadOnly = true;
            this.dgvDiemTQ.RowHeadersVisible = false;
            this.dgvDiemTQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiemTQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemTQ.Location = new System.Drawing.Point(15, 60);
            this.dgvDiemTQ.Name = "dgvDiemTQ";
            this.dgvDiemTQ.Size = new System.Drawing.Size(815, 98);
            this.dgvDiemTQ.TabIndex = 4;
            // 
            // lblTourChuyen
            // 
            this.lblTourChuyen.AutoSize = true;
            this.lblTourChuyen.Location = new System.Drawing.Point(15, 20);
            this.lblTourChuyen.Name = "lblTourChuyen";
            this.lblTourChuyen.Size = new System.Drawing.Size(35, 13);
            this.lblTourChuyen.TabIndex = 0;
            this.lblTourChuyen.Text = "Tour:";
            // 
            // cboTourChuyen
            // 
            this.cboTourChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTourChuyen.FormattingEnabled = true;
            this.cboTourChuyen.Location = new System.Drawing.Point(60, 17);
            this.cboTourChuyen.Name = "cboTourChuyen";
            this.cboTourChuyen.Size = new System.Drawing.Size(380, 21);
            this.cboTourChuyen.TabIndex = 1;
            this.cboTourChuyen.SelectedIndexChanged += new System.EventHandler(this.cboTourChuyen_SelectedIndexChanged);
            // 
            // lblMaChuyen
            // 
            this.lblMaChuyen.AutoSize = true;
            this.lblMaChuyen.Location = new System.Drawing.Point(15, 52);
            this.lblMaChuyen.Name = "lblMaChuyen";
            this.lblMaChuyen.Size = new System.Drawing.Size(67, 13);
            this.lblMaChuyen.TabIndex = 2;
            this.lblMaChuyen.Text = "Mã chuyến:";
            // 
            // txtMaChuyen
            // 
            this.txtMaChuyen.MaxLength = 20;
            this.txtMaChuyen.Location = new System.Drawing.Point(90, 49);
            this.txtMaChuyen.Name = "txtMaChuyen";
            this.txtMaChuyen.Size = new System.Drawing.Size(120, 20);
            this.txtMaChuyen.TabIndex = 3;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(230, 52);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(54, 13);
            this.lblNgayDi.TabIndex = 4;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(290, 49);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(110, 20);
            this.dtpNgayDi.TabIndex = 5;
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Location = new System.Drawing.Point(420, 52);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(54, 13);
            this.lblNgayVe.TabIndex = 6;
            this.lblNgayVe.Text = "Ngày về:";
            // 
            // dtpNgayVe
            // 
            this.dtpNgayVe.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVe.Location = new System.Drawing.Point(480, 49);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(110, 20);
            this.dtpNgayVe.TabIndex = 7;
            // 
            // lblSoCho
            // 
            this.lblSoCho.AutoSize = true;
            this.lblSoCho.Location = new System.Drawing.Point(610, 52);
            this.lblSoCho.Name = "lblSoCho";
            this.lblSoCho.Size = new System.Drawing.Size(92, 13);
            this.lblSoCho.TabIndex = 8;
            this.lblSoCho.Text = "Số chỗ tối đa:";
            // 
            // numSoCho
            // 
            this.numSoCho.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numSoCho.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoCho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoCho.Value = new decimal(new int[] { 40, 0, 0, 0 });
            this.numSoCho.Location = new System.Drawing.Point(695, 49);
            this.numSoCho.Name = "numSoCho";
            this.numSoCho.Size = new System.Drawing.Size(70, 20);
            this.numSoCho.TabIndex = 9;
            // 
            // btnThemChuyen
            // 
            this.btnThemChuyen.UseVisualStyleBackColor = true;
            this.btnThemChuyen.Location = new System.Drawing.Point(15, 85);
            this.btnThemChuyen.Name = "btnThemChuyen";
            this.btnThemChuyen.Size = new System.Drawing.Size(85, 28);
            this.btnThemChuyen.TabIndex = 10;
            this.btnThemChuyen.Text = "Thêm";
            this.btnThemChuyen.Click += new System.EventHandler(this.btnThemChuyen_Click);
            // 
            // btnSuaChuyen
            // 
            this.btnSuaChuyen.UseVisualStyleBackColor = true;
            this.btnSuaChuyen.Location = new System.Drawing.Point(106, 85);
            this.btnSuaChuyen.Name = "btnSuaChuyen";
            this.btnSuaChuyen.Size = new System.Drawing.Size(85, 28);
            this.btnSuaChuyen.TabIndex = 11;
            this.btnSuaChuyen.Text = "Sửa";
            this.btnSuaChuyen.Click += new System.EventHandler(this.btnSuaChuyen_Click);
            // 
            // btnXoaChuyen
            // 
            this.btnXoaChuyen.UseVisualStyleBackColor = true;
            this.btnXoaChuyen.Location = new System.Drawing.Point(197, 85);
            this.btnXoaChuyen.Name = "btnXoaChuyen";
            this.btnXoaChuyen.Size = new System.Drawing.Size(85, 28);
            this.btnXoaChuyen.TabIndex = 12;
            this.btnXoaChuyen.Text = "Xóa";
            this.btnXoaChuyen.Click += new System.EventHandler(this.btnXoaChuyen_Click);
            // 
            // btnLamMoiChuyen
            // 
            this.btnLamMoiChuyen.UseVisualStyleBackColor = true;
            this.btnLamMoiChuyen.Location = new System.Drawing.Point(288, 85);
            this.btnLamMoiChuyen.Name = "btnLamMoiChuyen";
            this.btnLamMoiChuyen.Size = new System.Drawing.Size(85, 28);
            this.btnLamMoiChuyen.TabIndex = 13;
            this.btnLamMoiChuyen.Text = "Làm mới";
            this.btnLamMoiChuyen.Click += new System.EventHandler(this.btnLamMoiChuyen_Click);
            // 
            // dgvChuyen
            // 
            this.dgvChuyen.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvChuyen.AllowUserToAddRows = false;
            this.dgvChuyen.AllowUserToDeleteRows = false;
            this.dgvChuyen.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuyen.MultiSelect = false;
            this.dgvChuyen.ReadOnly = true;
            this.dgvChuyen.RowHeadersVisible = false;
            this.dgvChuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyen.Location = new System.Drawing.Point(15, 125);
            this.dgvChuyen.Name = "dgvChuyen";
            this.dgvChuyen.Size = new System.Drawing.Size(845, 380);
            this.dgvChuyen.TabIndex = 14;
            this.dgvChuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyen_CellClick);
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
            this.btnDong.Location = new System.Drawing.Point(815, 572);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 610);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnDong);
            this.MinimumSize = new System.Drawing.Size(900, 610);
            this.Name = "FrmTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tour - lộ trình - chuyến tour";
            this.Load += new System.EventHandler(this.FrmTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungChan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyen)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabTour.ResumeLayout(false);
            this.tabLoTrinh.ResumeLayout(false);
            this.tabChuyen.ResumeLayout(false);
            this.grpDungChan.ResumeLayout(false);
            this.grpDiemTQ.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTour;
        private System.Windows.Forms.TabPage tabLoTrinh;
        private System.Windows.Forms.TabPage tabChuyen;
        private System.Windows.Forms.Label lblMaTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label lblTenTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Label lblSoDem;
        private System.Windows.Forms.NumericUpDown numSoDem;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThemTour;
        private System.Windows.Forms.Button btnSuaTour;
        private System.Windows.Forms.Button btnXoaTour;
        private System.Windows.Forms.Button btnLamMoiTour;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Label lblTourLoTrinh;
        private System.Windows.Forms.ComboBox cboTourLoTrinh;
        private System.Windows.Forms.Label lblGhiChuHCM;
        private System.Windows.Forms.GroupBox grpDungChan;
        private System.Windows.Forms.Label lblThuTu;
        private System.Windows.Forms.NumericUpDown numThuTu;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.ComboBox cboDiaDiem;
        private System.Windows.Forms.Label lblPhuongTien;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.CheckBox chkDoiPhuongTien;
        private System.Windows.Forms.CheckBox chkCoNoiAn;
        private System.Windows.Forms.CheckBox chkCoKhachSan;
        private System.Windows.Forms.Label lblLoaiKhachSan;
        private System.Windows.Forms.ComboBox cboLoaiKhachSan;
        private System.Windows.Forms.Button btnThemDungChan;
        private System.Windows.Forms.Button btnXoaDungChan;
        private System.Windows.Forms.DataGridView dgvDungChan;
        private System.Windows.Forms.GroupBox grpDiemTQ;
        private System.Windows.Forms.Label lblDiemTQ;
        private System.Windows.Forms.ComboBox cboDiemThamQuan;
        private System.Windows.Forms.Button btnThemDiemTQ;
        private System.Windows.Forms.Button btnXoaDiemTQ;
        private System.Windows.Forms.DataGridView dgvDiemTQ;
        private System.Windows.Forms.Label lblTourChuyen;
        private System.Windows.Forms.ComboBox cboTourChuyen;
        private System.Windows.Forms.Label lblMaChuyen;
        private System.Windows.Forms.TextBox txtMaChuyen;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.DateTimePicker dtpNgayVe;
        private System.Windows.Forms.Label lblSoCho;
        private System.Windows.Forms.NumericUpDown numSoCho;
        private System.Windows.Forms.Button btnThemChuyen;
        private System.Windows.Forms.Button btnSuaChuyen;
        private System.Windows.Forms.Button btnXoaChuyen;
        private System.Windows.Forms.Button btnLamMoiChuyen;
        private System.Windows.Forms.DataGridView dgvChuyen;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDong;
    }
}
