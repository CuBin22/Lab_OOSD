namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDangKy
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
            this.tabDoan = new System.Windows.Forms.TabPage();
            this.tabChuyen = new System.Windows.Forms.TabPage();
            this.lblKhachDoan = new System.Windows.Forms.Label();
            this.cboKhachDoan = new System.Windows.Forms.ComboBox();
            this.btnKhachMoi = new System.Windows.Forms.Button();
            this.lblTourDoan = new System.Windows.Forms.Label();
            this.cboTourDoan = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTienConLai = new System.Windows.Forms.Label();
            this.txtTienConLai = new System.Windows.Forms.TextBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblDiaChiDon = new System.Windows.Forms.Label();
            this.txtDiaChiDon = new System.Windows.Forms.TextBox();
            this.chkCoBaoHiem = new System.Windows.Forms.CheckBox();
            this.lblTienDatCoc = new System.Windows.Forms.Label();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.grpThanhVien = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.btnThemTV = new System.Windows.Forms.Button();
            this.btnXoaTV = new System.Windows.Forms.Button();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.lblDemTV = new System.Windows.Forms.Label();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.btnLamMoiDoan = new System.Windows.Forms.Button();
            this.lblDanhSachDoan = new System.Windows.Forms.Label();
            this.dgvPhieuDoan = new System.Windows.Forms.DataGridView();
            this.lblKhachLe = new System.Windows.Forms.Label();
            this.cboKhachLe = new System.Windows.Forms.ComboBox();
            this.btnKhachLeMoi = new System.Windows.Forms.Button();
            this.lblTourLe = new System.Windows.Forms.Label();
            this.cboTourLe = new System.Windows.Forms.ComboBox();
            this.lblChuyen = new System.Windows.Forms.Label();
            this.cboChuyen = new System.Windows.Forms.ComboBox();
            this.lblDiemBan = new System.Windows.Forms.Label();
            this.cboDiemBan = new System.Windows.Forms.ComboBox();
            this.lblDiemDon = new System.Windows.Forms.Label();
            this.cboDiemDon = new System.Windows.Forms.ComboBox();
            this.lblSoVe = new System.Windows.Forms.Label();
            this.numSoVe = new System.Windows.Forms.NumericUpDown();
            this.lblChoConLai = new System.Windows.Forms.Label();
            this.txtChoConLai = new System.Windows.Forms.TextBox();
            this.lblDonGiaVe = new System.Windows.Forms.Label();
            this.txtDonGiaVe = new System.Windows.Forms.TextBox();
            this.lblTongTienVe = new System.Windows.Forms.Label();
            this.txtTongTienVe = new System.Windows.Forms.TextBox();
            this.lblHinhThucVe = new System.Windows.Forms.Label();
            this.cboHinhThucVe = new System.Windows.Forms.ComboBox();
            this.btnLapPhieuChuyen = new System.Windows.Forms.Button();
            this.btnLamMoiChuyen = new System.Windows.Forms.Button();
            this.lblDanhSachChuyen = new System.Windows.Forms.Label();
            this.dgvPhieuChuyen = new System.Windows.Forms.DataGridView();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChuyen)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabDoan.SuspendLayout();
            this.tabChuyen.SuspendLayout();
            this.grpThanhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(940, 620);
            this.tabControl.TabIndex = 0;
            this.tabControl.Controls.Add(this.tabDoan);
            this.tabControl.Controls.Add(this.tabChuyen);
            // 
            // tabDoan
            // 
            this.tabDoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoan.UseVisualStyleBackColor = true;
            this.tabDoan.Name = "tabDoan";
            this.tabDoan.Text = "Đăng ký đoàn";
            this.tabDoan.Controls.Add(this.lblKhachDoan);
            this.tabDoan.Controls.Add(this.cboKhachDoan);
            this.tabDoan.Controls.Add(this.btnKhachMoi);
            this.tabDoan.Controls.Add(this.lblTourDoan);
            this.tabDoan.Controls.Add(this.cboTourDoan);
            this.tabDoan.Controls.Add(this.lblDonGia);
            this.tabDoan.Controls.Add(this.txtDonGia);
            this.tabDoan.Controls.Add(this.lblTongTien);
            this.tabDoan.Controls.Add(this.txtTongTien);
            this.tabDoan.Controls.Add(this.lblTienConLai);
            this.tabDoan.Controls.Add(this.txtTienConLai);
            this.tabDoan.Controls.Add(this.lblNgayDi);
            this.tabDoan.Controls.Add(this.dtpNgayDi);
            this.tabDoan.Controls.Add(this.lblSoNguoi);
            this.tabDoan.Controls.Add(this.numSoNguoi);
            this.tabDoan.Controls.Add(this.lblPhanLoai);
            this.tabDoan.Controls.Add(this.lblDiaChiDon);
            this.tabDoan.Controls.Add(this.txtDiaChiDon);
            this.tabDoan.Controls.Add(this.chkCoBaoHiem);
            this.tabDoan.Controls.Add(this.lblTienDatCoc);
            this.tabDoan.Controls.Add(this.txtTienDatCoc);
            this.tabDoan.Controls.Add(this.lblHinhThuc);
            this.tabDoan.Controls.Add(this.cboHinhThuc);
            this.tabDoan.Controls.Add(this.grpThanhVien);
            this.tabDoan.Controls.Add(this.btnLapPhieu);
            this.tabDoan.Controls.Add(this.btnLamMoiDoan);
            this.tabDoan.Controls.Add(this.lblDanhSachDoan);
            this.tabDoan.Controls.Add(this.dgvPhieuDoan);
            // 
            // tabChuyen
            // 
            this.tabChuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tabChuyen.UseVisualStyleBackColor = true;
            this.tabChuyen.Name = "tabChuyen";
            this.tabChuyen.Text = "Đăng ký chuyến (khách lẻ)";
            this.tabChuyen.Controls.Add(this.lblKhachLe);
            this.tabChuyen.Controls.Add(this.cboKhachLe);
            this.tabChuyen.Controls.Add(this.btnKhachLeMoi);
            this.tabChuyen.Controls.Add(this.lblTourLe);
            this.tabChuyen.Controls.Add(this.cboTourLe);
            this.tabChuyen.Controls.Add(this.lblChuyen);
            this.tabChuyen.Controls.Add(this.cboChuyen);
            this.tabChuyen.Controls.Add(this.lblDiemBan);
            this.tabChuyen.Controls.Add(this.cboDiemBan);
            this.tabChuyen.Controls.Add(this.lblDiemDon);
            this.tabChuyen.Controls.Add(this.cboDiemDon);
            this.tabChuyen.Controls.Add(this.lblSoVe);
            this.tabChuyen.Controls.Add(this.numSoVe);
            this.tabChuyen.Controls.Add(this.lblChoConLai);
            this.tabChuyen.Controls.Add(this.txtChoConLai);
            this.tabChuyen.Controls.Add(this.lblDonGiaVe);
            this.tabChuyen.Controls.Add(this.txtDonGiaVe);
            this.tabChuyen.Controls.Add(this.lblTongTienVe);
            this.tabChuyen.Controls.Add(this.txtTongTienVe);
            this.tabChuyen.Controls.Add(this.lblHinhThucVe);
            this.tabChuyen.Controls.Add(this.cboHinhThucVe);
            this.tabChuyen.Controls.Add(this.btnLapPhieuChuyen);
            this.tabChuyen.Controls.Add(this.btnLamMoiChuyen);
            this.tabChuyen.Controls.Add(this.lblDanhSachChuyen);
            this.tabChuyen.Controls.Add(this.dgvPhieuChuyen);
            // 
            // lblKhachDoan
            // 
            this.lblKhachDoan.AutoSize = true;
            this.lblKhachDoan.Location = new System.Drawing.Point(15, 20);
            this.lblKhachDoan.Name = "lblKhachDoan";
            this.lblKhachDoan.Size = new System.Drawing.Size(73, 13);
            this.lblKhachDoan.TabIndex = 0;
            this.lblKhachDoan.Text = "Khách đoàn:";
            // 
            // cboKhachDoan
            // 
            this.cboKhachDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachDoan.FormattingEnabled = true;
            this.cboKhachDoan.Location = new System.Drawing.Point(100, 17);
            this.cboKhachDoan.Name = "cboKhachDoan";
            this.cboKhachDoan.Size = new System.Drawing.Size(260, 21);
            this.cboKhachDoan.TabIndex = 1;
            // 
            // btnKhachMoi
            // 
            this.btnKhachMoi.UseVisualStyleBackColor = true;
            this.btnKhachMoi.Location = new System.Drawing.Point(370, 15);
            this.btnKhachMoi.Name = "btnKhachMoi";
            this.btnKhachMoi.Size = new System.Drawing.Size(95, 25);
            this.btnKhachMoi.TabIndex = 2;
            this.btnKhachMoi.Text = "Khách mới...";
            this.btnKhachMoi.Click += new System.EventHandler(this.btnKhachMoi_Click);
            // 
            // lblTourDoan
            // 
            this.lblTourDoan.AutoSize = true;
            this.lblTourDoan.Location = new System.Drawing.Point(15, 52);
            this.lblTourDoan.Name = "lblTourDoan";
            this.lblTourDoan.Size = new System.Drawing.Size(35, 13);
            this.lblTourDoan.TabIndex = 3;
            this.lblTourDoan.Text = "Tour:";
            // 
            // cboTourDoan
            // 
            this.cboTourDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTourDoan.FormattingEnabled = true;
            this.cboTourDoan.Location = new System.Drawing.Point(100, 49);
            this.cboTourDoan.Name = "cboTourDoan";
            this.cboTourDoan.Size = new System.Drawing.Size(360, 21);
            this.cboTourDoan.TabIndex = 4;
            this.cboTourDoan.SelectedIndexChanged += new System.EventHandler(this.cboTourDoan_SelectedIndexChanged);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(520, 20);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(92, 13);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "Đơn giá/khách:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDonGia.Location = new System.Drawing.Point(615, 17);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(135, 20);
            this.txtDonGia.TabIndex = 6;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(520, 52);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(67, 13);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTongTien.Location = new System.Drawing.Point(615, 49);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(135, 20);
            this.txtTongTien.TabIndex = 8;
            // 
            // lblTienConLai
            // 
            this.lblTienConLai.AutoSize = true;
            this.lblTienConLai.Location = new System.Drawing.Point(520, 84);
            this.lblTienConLai.Name = "lblTienConLai";
            this.lblTienConLai.Size = new System.Drawing.Size(85, 13);
            this.lblTienConLai.TabIndex = 9;
            this.lblTienConLai.Text = "Tiền còn lại:";
            // 
            // txtTienConLai
            // 
            this.txtTienConLai.ReadOnly = true;
            this.txtTienConLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienConLai.Location = new System.Drawing.Point(615, 81);
            this.txtTienConLai.Name = "txtTienConLai";
            this.txtTienConLai.Size = new System.Drawing.Size(135, 20);
            this.txtTienConLai.TabIndex = 10;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(15, 87);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(54, 13);
            this.lblNgayDi.TabIndex = 11;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(100, 84);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(110, 20);
            this.dtpNgayDi.TabIndex = 12;
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(230, 87);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(60, 13);
            this.lblSoNguoi.TabIndex = 13;
            this.lblSoNguoi.Text = "Số người:";
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoNguoi.Value = new decimal(new int[] { 13, 0, 0, 0 });
            this.numSoNguoi.Location = new System.Drawing.Point(295, 84);
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(70, 20);
            this.numSoNguoi.TabIndex = 14;
            this.numSoNguoi.ValueChanged += new System.EventHandler(this.numSoNguoi_ValueChanged);
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.ForeColor = System.Drawing.Color.FromArgb(0, 110, 40);
            this.lblPhanLoai.Location = new System.Drawing.Point(375, 87);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(142, 13);
            this.lblPhanLoai.TabIndex = 15;
            this.lblPhanLoai.Text = "> 12 người: khách đoàn";
            // 
            // lblDiaChiDon
            // 
            this.lblDiaChiDon.AutoSize = true;
            this.lblDiaChiDon.Location = new System.Drawing.Point(15, 119);
            this.lblDiaChiDon.Name = "lblDiaChiDon";
            this.lblDiaChiDon.Size = new System.Drawing.Size(85, 13);
            this.lblDiaChiDon.TabIndex = 16;
            this.lblDiaChiDon.Text = "Địa điểm đón:";
            // 
            // txtDiaChiDon
            // 
            this.txtDiaChiDon.MaxLength = 200;
            this.txtDiaChiDon.Location = new System.Drawing.Point(100, 116);
            this.txtDiaChiDon.Name = "txtDiaChiDon";
            this.txtDiaChiDon.Size = new System.Drawing.Size(360, 20);
            this.txtDiaChiDon.TabIndex = 17;
            // 
            // chkCoBaoHiem
            // 
            this.chkCoBaoHiem.AutoSize = true;
            this.chkCoBaoHiem.UseVisualStyleBackColor = true;
            this.chkCoBaoHiem.Location = new System.Drawing.Point(15, 148);
            this.chkCoBaoHiem.Name = "chkCoBaoHiem";
            this.chkCoBaoHiem.Size = new System.Drawing.Size(307, 17);
            this.chkCoBaoHiem.TabIndex = 18;
            this.chkCoBaoHiem.Text = "Có mua bảo hiểm (kèm danh sách người cùng đi)";
            this.chkCoBaoHiem.CheckedChanged += new System.EventHandler(this.chkCoBaoHiem_CheckedChanged);
            // 
            // lblTienDatCoc
            // 
            this.lblTienDatCoc.AutoSize = true;
            this.lblTienDatCoc.Location = new System.Drawing.Point(15, 181);
            this.lblTienDatCoc.Name = "lblTienDatCoc";
            this.lblTienDatCoc.Size = new System.Drawing.Size(85, 13);
            this.lblTienDatCoc.TabIndex = 19;
            this.lblTienDatCoc.Text = "Tiền đặt cọc:";
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienDatCoc.Location = new System.Drawing.Point(100, 178);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(120, 20);
            this.txtTienDatCoc.TabIndex = 20;
            this.txtTienDatCoc.TextChanged += new System.EventHandler(this.txtTienDatCoc_TextChanged);
            this.txtTienDatCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienDatCoc_KeyPress);
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(240, 181);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(67, 13);
            this.lblHinhThuc.TabIndex = 21;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ",
            "Ví điện tử"});
            this.cboHinhThuc.Location = new System.Drawing.Point(305, 178);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(130, 21);
            this.cboHinhThuc.TabIndex = 22;
            // 
            // grpThanhVien
            // 
            this.grpThanhVien.Location = new System.Drawing.Point(15, 210);
            this.grpThanhVien.Name = "grpThanhVien";
            this.grpThanhVien.Size = new System.Drawing.Size(745, 215);
            this.grpThanhVien.TabIndex = 23;
            this.grpThanhVien.Text = "Danh sách người cùng đi (khi mua bảo hiểm)";
            this.grpThanhVien.Controls.Add(this.lblHoTen);
            this.grpThanhVien.Controls.Add(this.txtHoTen);
            this.grpThanhVien.Controls.Add(this.lblNgaySinh);
            this.grpThanhVien.Controls.Add(this.dtpNgaySinh);
            this.grpThanhVien.Controls.Add(this.lblSoCMND);
            this.grpThanhVien.Controls.Add(this.txtSoCMND);
            this.grpThanhVien.Controls.Add(this.btnThemTV);
            this.grpThanhVien.Controls.Add(this.btnXoaTV);
            this.grpThanhVien.Controls.Add(this.dgvThanhVien);
            this.grpThanhVien.Controls.Add(this.lblDemTV);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 28);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(48, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.MaxLength = 100;
            this.txtHoTen.Location = new System.Drawing.Point(65, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(260, 28);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 13);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(330, 25);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.Location = new System.Drawing.Point(445, 28);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(35, 13);
            this.lblSoCMND.TabIndex = 4;
            this.lblSoCMND.Text = "CMND:";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.MaxLength = 20;
            this.txtSoCMND.Location = new System.Drawing.Point(490, 25);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(110, 20);
            this.txtSoCMND.TabIndex = 5;
            // 
            // btnThemTV
            // 
            this.btnThemTV.UseVisualStyleBackColor = true;
            this.btnThemTV.Location = new System.Drawing.Point(610, 23);
            this.btnThemTV.Name = "btnThemTV";
            this.btnThemTV.Size = new System.Drawing.Size(60, 26);
            this.btnThemTV.TabIndex = 6;
            this.btnThemTV.Text = "Thêm";
            this.btnThemTV.Click += new System.EventHandler(this.btnThemTV_Click);
            // 
            // btnXoaTV
            // 
            this.btnXoaTV.UseVisualStyleBackColor = true;
            this.btnXoaTV.Location = new System.Drawing.Point(676, 23);
            this.btnXoaTV.Name = "btnXoaTV";
            this.btnXoaTV.Size = new System.Drawing.Size(60, 26);
            this.btnXoaTV.TabIndex = 7;
            this.btnXoaTV.Text = "Xóa";
            this.btnXoaTV.Click += new System.EventHandler(this.btnXoaTV_Click);
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvThanhVien.AllowUserToAddRows = false;
            this.dgvThanhVien.AllowUserToDeleteRows = false;
            this.dgvThanhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhVien.MultiSelect = false;
            this.dgvThanhVien.ReadOnly = true;
            this.dgvThanhVien.RowHeadersVisible = false;
            this.dgvThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhVien.Location = new System.Drawing.Point(15, 58);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.Size = new System.Drawing.Size(715, 125);
            this.dgvThanhVien.TabIndex = 8;
            // 
            // lblDemTV
            // 
            this.lblDemTV.AutoSize = true;
            this.lblDemTV.Location = new System.Drawing.Point(15, 192);
            this.lblDemTV.Name = "lblDemTV";
            this.lblDemTV.Size = new System.Drawing.Size(104, 13);
            this.lblDemTV.TabIndex = 9;
            this.lblDemTV.Text = "Đã nhập: 0 người";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Location = new System.Drawing.Point(780, 17);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(140, 32);
            this.btnLapPhieu.TabIndex = 24;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // btnLamMoiDoan
            // 
            this.btnLamMoiDoan.UseVisualStyleBackColor = true;
            this.btnLamMoiDoan.Location = new System.Drawing.Point(780, 57);
            this.btnLamMoiDoan.Name = "btnLamMoiDoan";
            this.btnLamMoiDoan.Size = new System.Drawing.Size(140, 32);
            this.btnLamMoiDoan.TabIndex = 25;
            this.btnLamMoiDoan.Text = "Nhập lại";
            this.btnLamMoiDoan.Click += new System.EventHandler(this.btnLamMoiDoan_Click);
            // 
            // lblDanhSachDoan
            // 
            this.lblDanhSachDoan.AutoSize = true;
            this.lblDanhSachDoan.Location = new System.Drawing.Point(15, 430);
            this.lblDanhSachDoan.Name = "lblDanhSachDoan";
            this.lblDanhSachDoan.Size = new System.Drawing.Size(148, 13);
            this.lblDanhSachDoan.TabIndex = 26;
            this.lblDanhSachDoan.Text = "Các phiếu đăng ký đoàn:";
            // 
            // dgvPhieuDoan
            // 
            this.dgvPhieuDoan.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvPhieuDoan.AllowUserToAddRows = false;
            this.dgvPhieuDoan.AllowUserToDeleteRows = false;
            this.dgvPhieuDoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuDoan.MultiSelect = false;
            this.dgvPhieuDoan.ReadOnly = true;
            this.dgvPhieuDoan.RowHeadersVisible = false;
            this.dgvPhieuDoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDoan.Location = new System.Drawing.Point(15, 448);
            this.dgvPhieuDoan.Name = "dgvPhieuDoan";
            this.dgvPhieuDoan.Size = new System.Drawing.Size(905, 140);
            this.dgvPhieuDoan.TabIndex = 27;
            // 
            // lblKhachLe
            // 
            this.lblKhachLe.AutoSize = true;
            this.lblKhachLe.Location = new System.Drawing.Point(15, 20);
            this.lblKhachLe.Name = "lblKhachLe";
            this.lblKhachLe.Size = new System.Drawing.Size(60, 13);
            this.lblKhachLe.TabIndex = 0;
            this.lblKhachLe.Text = "Khách lẻ:";
            // 
            // cboKhachLe
            // 
            this.cboKhachLe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachLe.FormattingEnabled = true;
            this.cboKhachLe.Location = new System.Drawing.Point(110, 17);
            this.cboKhachLe.Name = "cboKhachLe";
            this.cboKhachLe.Size = new System.Drawing.Size(260, 21);
            this.cboKhachLe.TabIndex = 1;
            // 
            // btnKhachLeMoi
            // 
            this.btnKhachLeMoi.UseVisualStyleBackColor = true;
            this.btnKhachLeMoi.Location = new System.Drawing.Point(380, 15);
            this.btnKhachLeMoi.Name = "btnKhachLeMoi";
            this.btnKhachLeMoi.Size = new System.Drawing.Size(95, 25);
            this.btnKhachLeMoi.TabIndex = 2;
            this.btnKhachLeMoi.Text = "Khách mới...";
            this.btnKhachLeMoi.Click += new System.EventHandler(this.btnKhachLeMoi_Click);
            // 
            // lblTourLe
            // 
            this.lblTourLe.AutoSize = true;
            this.lblTourLe.Location = new System.Drawing.Point(15, 52);
            this.lblTourLe.Name = "lblTourLe";
            this.lblTourLe.Size = new System.Drawing.Size(35, 13);
            this.lblTourLe.TabIndex = 3;
            this.lblTourLe.Text = "Tour:";
            // 
            // cboTourLe
            // 
            this.cboTourLe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTourLe.FormattingEnabled = true;
            this.cboTourLe.Location = new System.Drawing.Point(110, 49);
            this.cboTourLe.Name = "cboTourLe";
            this.cboTourLe.Size = new System.Drawing.Size(360, 21);
            this.cboTourLe.TabIndex = 4;
            this.cboTourLe.SelectedIndexChanged += new System.EventHandler(this.cboTourLe_SelectedIndexChanged);
            // 
            // lblChuyen
            // 
            this.lblChuyen.AutoSize = true;
            this.lblChuyen.Location = new System.Drawing.Point(15, 84);
            this.lblChuyen.Name = "lblChuyen";
            this.lblChuyen.Size = new System.Drawing.Size(48, 13);
            this.lblChuyen.TabIndex = 5;
            this.lblChuyen.Text = "Chuyến:";
            // 
            // cboChuyen
            // 
            this.cboChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyen.FormattingEnabled = true;
            this.cboChuyen.Location = new System.Drawing.Point(110, 81);
            this.cboChuyen.Name = "cboChuyen";
            this.cboChuyen.Size = new System.Drawing.Size(360, 21);
            this.cboChuyen.TabIndex = 6;
            this.cboChuyen.SelectedIndexChanged += new System.EventHandler(this.cboChuyen_SelectedIndexChanged);
            // 
            // lblDiemBan
            // 
            this.lblDiemBan.AutoSize = true;
            this.lblDiemBan.Location = new System.Drawing.Point(15, 116);
            this.lblDiemBan.Name = "lblDiemBan";
            this.lblDiemBan.Size = new System.Drawing.Size(79, 13);
            this.lblDiemBan.TabIndex = 7;
            this.lblDiemBan.Text = "Điểm bán vé:";
            // 
            // cboDiemBan
            // 
            this.cboDiemBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemBan.FormattingEnabled = true;
            this.cboDiemBan.Location = new System.Drawing.Point(110, 113);
            this.cboDiemBan.Name = "cboDiemBan";
            this.cboDiemBan.Size = new System.Drawing.Size(260, 21);
            this.cboDiemBan.TabIndex = 8;
            // 
            // lblDiemDon
            // 
            this.lblDiemDon.AutoSize = true;
            this.lblDiemDon.Location = new System.Drawing.Point(15, 148);
            this.lblDiemDon.Name = "lblDiemDon";
            this.lblDiemDon.Size = new System.Drawing.Size(60, 13);
            this.lblDiemDon.TabIndex = 9;
            this.lblDiemDon.Text = "Điểm đón:";
            // 
            // cboDiemDon
            // 
            this.cboDiemDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDon.FormattingEnabled = true;
            this.cboDiemDon.Location = new System.Drawing.Point(110, 145);
            this.cboDiemDon.Name = "cboDiemDon";
            this.cboDiemDon.Size = new System.Drawing.Size(260, 21);
            this.cboDiemDon.TabIndex = 10;
            // 
            // lblSoVe
            // 
            this.lblSoVe.AutoSize = true;
            this.lblSoVe.Location = new System.Drawing.Point(15, 180);
            this.lblSoVe.Name = "lblSoVe";
            this.lblSoVe.Size = new System.Drawing.Size(41, 13);
            this.lblSoVe.TabIndex = 11;
            this.lblSoVe.Text = "Số vé:";
            // 
            // numSoVe
            // 
            this.numSoVe.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            this.numSoVe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoVe.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoVe.Location = new System.Drawing.Point(110, 177);
            this.numSoVe.Name = "numSoVe";
            this.numSoVe.Size = new System.Drawing.Size(70, 20);
            this.numSoVe.TabIndex = 12;
            this.numSoVe.ValueChanged += new System.EventHandler(this.numSoVe_ValueChanged);
            // 
            // lblChoConLai
            // 
            this.lblChoConLai.AutoSize = true;
            this.lblChoConLai.Location = new System.Drawing.Point(300, 180);
            this.lblChoConLai.Name = "lblChoConLai";
            this.lblChoConLai.Size = new System.Drawing.Size(79, 13);
            this.lblChoConLai.TabIndex = 13;
            this.lblChoConLai.Text = "Chỗ còn lại:";
            // 
            // txtChoConLai
            // 
            this.txtChoConLai.ReadOnly = true;
            this.txtChoConLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChoConLai.Location = new System.Drawing.Point(380, 177);
            this.txtChoConLai.Name = "txtChoConLai";
            this.txtChoConLai.Size = new System.Drawing.Size(90, 20);
            this.txtChoConLai.TabIndex = 14;
            // 
            // lblDonGiaVe
            // 
            this.lblDonGiaVe.AutoSize = true;
            this.lblDonGiaVe.Location = new System.Drawing.Point(15, 212);
            this.lblDonGiaVe.Name = "lblDonGiaVe";
            this.lblDonGiaVe.Size = new System.Drawing.Size(73, 13);
            this.lblDonGiaVe.TabIndex = 15;
            this.lblDonGiaVe.Text = "Đơn giá vé:";
            // 
            // txtDonGiaVe
            // 
            this.txtDonGiaVe.ReadOnly = true;
            this.txtDonGiaVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDonGiaVe.Location = new System.Drawing.Point(110, 209);
            this.txtDonGiaVe.Name = "txtDonGiaVe";
            this.txtDonGiaVe.Size = new System.Drawing.Size(150, 20);
            this.txtDonGiaVe.TabIndex = 16;
            // 
            // lblTongTienVe
            // 
            this.lblTongTienVe.AutoSize = true;
            this.lblTongTienVe.Location = new System.Drawing.Point(15, 244);
            this.lblTongTienVe.Name = "lblTongTienVe";
            this.lblTongTienVe.Size = new System.Drawing.Size(85, 13);
            this.lblTongTienVe.TabIndex = 17;
            this.lblTongTienVe.Text = "Tổng tiền vé:";
            // 
            // txtTongTienVe
            // 
            this.txtTongTienVe.ReadOnly = true;
            this.txtTongTienVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTongTienVe.Location = new System.Drawing.Point(110, 241);
            this.txtTongTienVe.Name = "txtTongTienVe";
            this.txtTongTienVe.Size = new System.Drawing.Size(150, 20);
            this.txtTongTienVe.TabIndex = 18;
            // 
            // lblHinhThucVe
            // 
            this.lblHinhThucVe.AutoSize = true;
            this.lblHinhThucVe.Location = new System.Drawing.Point(15, 276);
            this.lblHinhThucVe.Name = "lblHinhThucVe";
            this.lblHinhThucVe.Size = new System.Drawing.Size(85, 13);
            this.lblHinhThucVe.TabIndex = 19;
            this.lblHinhThucVe.Text = "Hình thức TT:";
            // 
            // cboHinhThucVe
            // 
            this.cboHinhThucVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucVe.FormattingEnabled = true;
            this.cboHinhThucVe.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ",
            "Ví điện tử"});
            this.cboHinhThucVe.Location = new System.Drawing.Point(110, 273);
            this.cboHinhThucVe.Name = "cboHinhThucVe";
            this.cboHinhThucVe.Size = new System.Drawing.Size(150, 21);
            this.cboHinhThucVe.TabIndex = 20;
            // 
            // btnLapPhieuChuyen
            // 
            this.btnLapPhieuChuyen.UseVisualStyleBackColor = true;
            this.btnLapPhieuChuyen.Location = new System.Drawing.Point(110, 310);
            this.btnLapPhieuChuyen.Name = "btnLapPhieuChuyen";
            this.btnLapPhieuChuyen.Size = new System.Drawing.Size(160, 32);
            this.btnLapPhieuChuyen.TabIndex = 21;
            this.btnLapPhieuChuyen.Text = "Lập phiếu && bán vé";
            this.btnLapPhieuChuyen.Click += new System.EventHandler(this.btnLapPhieuChuyen_Click);
            // 
            // btnLamMoiChuyen
            // 
            this.btnLamMoiChuyen.UseVisualStyleBackColor = true;
            this.btnLamMoiChuyen.Location = new System.Drawing.Point(280, 310);
            this.btnLamMoiChuyen.Name = "btnLamMoiChuyen";
            this.btnLamMoiChuyen.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoiChuyen.TabIndex = 22;
            this.btnLamMoiChuyen.Text = "Nhập lại";
            this.btnLamMoiChuyen.Click += new System.EventHandler(this.btnLamMoiChuyen_Click);
            // 
            // lblDanhSachChuyen
            // 
            this.lblDanhSachChuyen.AutoSize = true;
            this.lblDanhSachChuyen.Location = new System.Drawing.Point(15, 352);
            this.lblDanhSachChuyen.Name = "lblDanhSachChuyen";
            this.lblDanhSachChuyen.Size = new System.Drawing.Size(161, 13);
            this.lblDanhSachChuyen.TabIndex = 23;
            this.lblDanhSachChuyen.Text = "Các phiếu đăng ký chuyến:";
            // 
            // dgvPhieuChuyen
            // 
            this.dgvPhieuChuyen.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvPhieuChuyen.AllowUserToAddRows = false;
            this.dgvPhieuChuyen.AllowUserToDeleteRows = false;
            this.dgvPhieuChuyen.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuChuyen.MultiSelect = false;
            this.dgvPhieuChuyen.ReadOnly = true;
            this.dgvPhieuChuyen.RowHeadersVisible = false;
            this.dgvPhieuChuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuChuyen.Location = new System.Drawing.Point(15, 370);
            this.dgvPhieuChuyen.Name = "dgvPhieuChuyen";
            this.dgvPhieuChuyen.Size = new System.Drawing.Size(905, 215);
            this.dgvPhieuChuyen.TabIndex = 24;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(12, 648);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(4, 13);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(865, 640);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 680);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnDong);
            this.MinimumSize = new System.Drawing.Size(960, 680);
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tour (theo đoàn / theo chuyến)";
            this.Load += new System.EventHandler(this.FrmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChuyen)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabDoan.ResumeLayout(false);
            this.tabChuyen.ResumeLayout(false);
            this.grpThanhVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDoan;
        private System.Windows.Forms.TabPage tabChuyen;
        private System.Windows.Forms.Label lblKhachDoan;
        private System.Windows.Forms.ComboBox cboKhachDoan;
        private System.Windows.Forms.Button btnKhachMoi;
        private System.Windows.Forms.Label lblTourDoan;
        private System.Windows.Forms.ComboBox cboTourDoan;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTienConLai;
        private System.Windows.Forms.TextBox txtTienConLai;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblDiaChiDon;
        private System.Windows.Forms.TextBox txtDiaChiDon;
        private System.Windows.Forms.CheckBox chkCoBaoHiem;
        private System.Windows.Forms.Label lblTienDatCoc;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.GroupBox grpThanhVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Button btnThemTV;
        private System.Windows.Forms.Button btnXoaTV;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.Label lblDemTV;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Button btnLamMoiDoan;
        private System.Windows.Forms.Label lblDanhSachDoan;
        private System.Windows.Forms.DataGridView dgvPhieuDoan;
        private System.Windows.Forms.Label lblKhachLe;
        private System.Windows.Forms.ComboBox cboKhachLe;
        private System.Windows.Forms.Button btnKhachLeMoi;
        private System.Windows.Forms.Label lblTourLe;
        private System.Windows.Forms.ComboBox cboTourLe;
        private System.Windows.Forms.Label lblChuyen;
        private System.Windows.Forms.ComboBox cboChuyen;
        private System.Windows.Forms.Label lblDiemBan;
        private System.Windows.Forms.ComboBox cboDiemBan;
        private System.Windows.Forms.Label lblDiemDon;
        private System.Windows.Forms.ComboBox cboDiemDon;
        private System.Windows.Forms.Label lblSoVe;
        private System.Windows.Forms.NumericUpDown numSoVe;
        private System.Windows.Forms.Label lblChoConLai;
        private System.Windows.Forms.TextBox txtChoConLai;
        private System.Windows.Forms.Label lblDonGiaVe;
        private System.Windows.Forms.TextBox txtDonGiaVe;
        private System.Windows.Forms.Label lblTongTienVe;
        private System.Windows.Forms.TextBox txtTongTienVe;
        private System.Windows.Forms.Label lblHinhThucVe;
        private System.Windows.Forms.ComboBox cboHinhThucVe;
        private System.Windows.Forms.Button btnLapPhieuChuyen;
        private System.Windows.Forms.Button btnLamMoiChuyen;
        private System.Windows.Forms.Label lblDanhSachChuyen;
        private System.Windows.Forms.DataGridView dgvPhieuChuyen;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDong;
    }
}
