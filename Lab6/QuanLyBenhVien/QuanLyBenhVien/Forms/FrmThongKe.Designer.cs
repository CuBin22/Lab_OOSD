namespace QuanLyBenhVien.Forms
{
    partial class FrmThongKe
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
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.lblBacSiLoc = new System.Windows.Forms.Label();
            this.cboBacSiLoc = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblSoHoSoMoi = new System.Windows.Forms.Label();
            this.lblSoPhieuKham = new System.Windows.Forms.Label();
            this.lblKhamDinhKy = new System.Windows.Forms.Label();
            this.lblTongLePhi = new System.Windows.Forms.Label();
            this.lblTongVienPhi = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabTheoBacSi = new System.Windows.Forms.TabPage();
            this.dgvBacSi = new System.Windows.Forms.DataGridView();
            this.colBacSi_MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi_TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi_TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi_SoPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi_SoKhamBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi_SoKhamDinhKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTheoThuoc = new System.Windows.Forms.TabPage();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.colThuoc_MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc_TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc_SoLanKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc_TongSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc_PhanUngPhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTheoHoSo = new System.Windows.Forms.TabPage();
            this.dgvDieuTri = new System.Windows.Forms.DataGridView();
            this.colDieuTri_MaHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDieuTri_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDieuTri_SoDotDieuTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDieuTri_LanKhamGanNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDieuTri_KetLuanGanNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuTri)).BeginInit();
            this.tabThongKe.SuspendLayout();
            this.tabTheoBacSi.SuspendLayout();
            this.tabTheoThuoc.SuspendLayout();
            this.tabTheoHoSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTu
            // 
            this.lblTu.Location = new System.Drawing.Point(15, 18);
            this.lblTu.Name = "lblTu";
            this.lblTu.AutoSize = true;
            this.lblTu.Size = new System.Drawing.Size(50, 13);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Location = new System.Drawing.Point(70, 15);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(110, 20);
            this.dtTu.TabIndex = 1;
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            // 
            // lblDen
            // 
            this.lblDen.Location = new System.Drawing.Point(200, 18);
            this.lblDen.Name = "lblDen";
            this.lblDen.AutoSize = true;
            this.lblDen.Size = new System.Drawing.Size(50, 13);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.Location = new System.Drawing.Point(260, 15);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(110, 20);
            this.dtDen.TabIndex = 3;
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            // 
            // lblBacSiLoc
            // 
            this.lblBacSiLoc.Location = new System.Drawing.Point(390, 18);
            this.lblBacSiLoc.Name = "lblBacSiLoc";
            this.lblBacSiLoc.AutoSize = true;
            this.lblBacSiLoc.Size = new System.Drawing.Size(50, 13);
            this.lblBacSiLoc.TabIndex = 4;
            this.lblBacSiLoc.Text = "Bác sĩ:";
            // 
            // cboBacSiLoc
            // 
            this.cboBacSiLoc.Location = new System.Drawing.Point(435, 15);
            this.cboBacSiLoc.Name = "cboBacSiLoc";
            this.cboBacSiLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSiLoc.FormattingEnabled = true;
            this.cboBacSiLoc.Size = new System.Drawing.Size(170, 21);
            this.cboBacSiLoc.TabIndex = 5;
            this.cboBacSiLoc.SelectedIndexChanged += new System.EventHandler(this.cboBacSiLoc_SelectedIndexChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(625, 12);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 27);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblSoHoSoMoi
            // 
            this.lblSoHoSoMoi.Location = new System.Drawing.Point(15, 61);
            this.lblSoHoSoMoi.Name = "lblSoHoSoMoi";
            this.lblSoHoSoMoi.AutoSize = true;
            this.lblSoHoSoMoi.Size = new System.Drawing.Size(50, 13);
            this.lblSoHoSoMoi.TabIndex = 7;
            this.lblSoHoSoMoi.Text = "Hồ sơ mới: 0";
            this.lblSoHoSoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoHoSoMoi.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            // 
            // lblSoPhieuKham
            // 
            this.lblSoPhieuKham.Location = new System.Drawing.Point(250, 61);
            this.lblSoPhieuKham.Name = "lblSoPhieuKham";
            this.lblSoPhieuKham.AutoSize = true;
            this.lblSoPhieuKham.Size = new System.Drawing.Size(50, 13);
            this.lblSoPhieuKham.TabIndex = 8;
            this.lblSoPhieuKham.Text = "Phiếu khám: 0";
            this.lblSoPhieuKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoPhieuKham.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            // 
            // lblKhamDinhKy
            // 
            this.lblKhamDinhKy.Location = new System.Drawing.Point(500, 61);
            this.lblKhamDinhKy.Name = "lblKhamDinhKy";
            this.lblKhamDinhKy.AutoSize = true;
            this.lblKhamDinhKy.Size = new System.Drawing.Size(50, 13);
            this.lblKhamDinhKy.TabIndex = 9;
            this.lblKhamDinhKy.Text = "Khám định kỳ: 0";
            this.lblKhamDinhKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhamDinhKy.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            // 
            // lblTongLePhi
            // 
            this.lblTongLePhi.Location = new System.Drawing.Point(15, 93);
            this.lblTongLePhi.Name = "lblTongLePhi";
            this.lblTongLePhi.AutoSize = true;
            this.lblTongLePhi.Size = new System.Drawing.Size(50, 13);
            this.lblTongLePhi.TabIndex = 10;
            this.lblTongLePhi.Text = "Tổng lệ phí: 0 đ";
            this.lblTongLePhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongLePhi.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            // 
            // lblTongVienPhi
            // 
            this.lblTongVienPhi.Location = new System.Drawing.Point(250, 93);
            this.lblTongVienPhi.Name = "lblTongVienPhi";
            this.lblTongVienPhi.AutoSize = true;
            this.lblTongVienPhi.Size = new System.Drawing.Size(50, 13);
            this.lblTongVienPhi.TabIndex = 11;
            this.lblTongVienPhi.Text = "Tổng viện phí: 0 đ";
            this.lblTongVienPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongVienPhi.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            // 
            // tabThongKe
            // 
            this.tabThongKe.Location = new System.Drawing.Point(10, 125);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(940, 465);
            this.tabThongKe.TabIndex = 12;
            this.tabThongKe.Controls.Add(this.tabTheoBacSi);
            this.tabThongKe.Controls.Add(this.tabTheoThuoc);
            this.tabThongKe.Controls.Add(this.tabTheoHoSo);
            // 
            // tabTheoBacSi
            // 
            this.tabTheoBacSi.Location = new System.Drawing.Point(4, 22);
            this.tabTheoBacSi.Name = "tabTheoBacSi";
            this.tabTheoBacSi.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheoBacSi.Size = new System.Drawing.Size(932, 439);
            this.tabTheoBacSi.TabIndex = 0;
            this.tabTheoBacSi.Text = "Theo bác sĩ (trách nhiệm điều trị)";
            this.tabTheoBacSi.UseVisualStyleBackColor = true;
            this.tabTheoBacSi.Controls.Add(this.dgvBacSi);
            // 
            // dgvBacSi
            // 
            this.dgvBacSi.AllowUserToAddRows = false;
            this.dgvBacSi.AllowUserToDeleteRows = false;
            this.dgvBacSi.AllowUserToResizeRows = false;
            this.dgvBacSi.AutoGenerateColumns = false;
            this.dgvBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBacSi.BackgroundColor = System.Drawing.Color.White;
            this.dgvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBacSi_MaBS,
            this.colBacSi_TenBS,
            this.colBacSi_TenKhoa,
            this.colBacSi_SoPhieuKham,
            this.colBacSi_SoKhamBenh,
            this.colBacSi_SoKhamDinhKy});
            this.dgvBacSi.Location = new System.Drawing.Point(10, 10);
            this.dgvBacSi.MultiSelect = false;
            this.dgvBacSi.Name = "dgvBacSi";
            this.dgvBacSi.ReadOnly = true;
            this.dgvBacSi.RowHeadersVisible = false;
            this.dgvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBacSi.Size = new System.Drawing.Size(910, 420);
            this.dgvBacSi.TabIndex = 0;
            // 
            // colBacSi_MaBS
            // 
            this.colBacSi_MaBS.DataPropertyName = "MaBS";
            this.colBacSi_MaBS.HeaderText = "Mã BS";
            this.colBacSi_MaBS.Name = "colBacSi_MaBS";
            this.colBacSi_MaBS.ReadOnly = true;
            // 
            // colBacSi_TenBS
            // 
            this.colBacSi_TenBS.DataPropertyName = "TenBS";
            this.colBacSi_TenBS.HeaderText = "Bác sĩ";
            this.colBacSi_TenBS.Name = "colBacSi_TenBS";
            this.colBacSi_TenBS.ReadOnly = true;
            // 
            // colBacSi_TenKhoa
            // 
            this.colBacSi_TenKhoa.DataPropertyName = "TenKhoa";
            this.colBacSi_TenKhoa.HeaderText = "Khoa";
            this.colBacSi_TenKhoa.Name = "colBacSi_TenKhoa";
            this.colBacSi_TenKhoa.ReadOnly = true;
            // 
            // colBacSi_SoPhieuKham
            // 
            this.colBacSi_SoPhieuKham.DataPropertyName = "SoPhieuKham";
            this.colBacSi_SoPhieuKham.HeaderText = "Số phiếu khám";
            this.colBacSi_SoPhieuKham.Name = "colBacSi_SoPhieuKham";
            this.colBacSi_SoPhieuKham.ReadOnly = true;
            // 
            // colBacSi_SoKhamBenh
            // 
            this.colBacSi_SoKhamBenh.DataPropertyName = "SoKhamBenh";
            this.colBacSi_SoKhamBenh.HeaderText = "Khám bệnh";
            this.colBacSi_SoKhamBenh.Name = "colBacSi_SoKhamBenh";
            this.colBacSi_SoKhamBenh.ReadOnly = true;
            // 
            // colBacSi_SoKhamDinhKy
            // 
            this.colBacSi_SoKhamDinhKy.DataPropertyName = "SoKhamDinhKy";
            this.colBacSi_SoKhamDinhKy.HeaderText = "Khám định kỳ";
            this.colBacSi_SoKhamDinhKy.Name = "colBacSi_SoKhamDinhKy";
            this.colBacSi_SoKhamDinhKy.ReadOnly = true;
            // 
            // tabTheoThuoc
            // 
            this.tabTheoThuoc.Location = new System.Drawing.Point(4, 22);
            this.tabTheoThuoc.Name = "tabTheoThuoc";
            this.tabTheoThuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheoThuoc.Size = new System.Drawing.Size(932, 439);
            this.tabTheoThuoc.TabIndex = 1;
            this.tabTheoThuoc.Text = "Thuốc và phản ứng phụ";
            this.tabTheoThuoc.UseVisualStyleBackColor = true;
            this.tabTheoThuoc.Controls.Add(this.dgvThuoc);
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
            this.colThuoc_SoLanKe,
            this.colThuoc_TongSoLuong,
            this.colThuoc_PhanUngPhu});
            this.dgvThuoc.Location = new System.Drawing.Point(10, 10);
            this.dgvThuoc.MultiSelect = false;
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(910, 420);
            this.dgvThuoc.TabIndex = 0;
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
            // colThuoc_SoLanKe
            // 
            this.colThuoc_SoLanKe.DataPropertyName = "SoLanKe";
            this.colThuoc_SoLanKe.HeaderText = "Số lần kê";
            this.colThuoc_SoLanKe.Name = "colThuoc_SoLanKe";
            this.colThuoc_SoLanKe.ReadOnly = true;
            // 
            // colThuoc_TongSoLuong
            // 
            this.colThuoc_TongSoLuong.DataPropertyName = "TongSoLuong";
            this.colThuoc_TongSoLuong.HeaderText = "Tổng số lượng";
            this.colThuoc_TongSoLuong.Name = "colThuoc_TongSoLuong";
            this.colThuoc_TongSoLuong.ReadOnly = true;
            // 
            // colThuoc_PhanUngPhu
            // 
            this.colThuoc_PhanUngPhu.DataPropertyName = "PhanUngPhu";
            this.colThuoc_PhanUngPhu.HeaderText = "Phản ứng phụ";
            this.colThuoc_PhanUngPhu.Name = "colThuoc_PhanUngPhu";
            this.colThuoc_PhanUngPhu.ReadOnly = true;
            // 
            // tabTheoHoSo
            // 
            this.tabTheoHoSo.Location = new System.Drawing.Point(4, 22);
            this.tabTheoHoSo.Name = "tabTheoHoSo";
            this.tabTheoHoSo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheoHoSo.Size = new System.Drawing.Size(932, 439);
            this.tabTheoHoSo.TabIndex = 2;
            this.tabTheoHoSo.Text = "Diễn biến theo hồ sơ";
            this.tabTheoHoSo.UseVisualStyleBackColor = true;
            this.tabTheoHoSo.Controls.Add(this.dgvDieuTri);
            // 
            // dgvDieuTri
            // 
            this.dgvDieuTri.AllowUserToAddRows = false;
            this.dgvDieuTri.AllowUserToDeleteRows = false;
            this.dgvDieuTri.AllowUserToResizeRows = false;
            this.dgvDieuTri.AutoGenerateColumns = false;
            this.dgvDieuTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDieuTri.BackgroundColor = System.Drawing.Color.White;
            this.dgvDieuTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDieuTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDieuTri_MaHoSo,
            this.colDieuTri_HoTen,
            this.colDieuTri_SoDotDieuTri,
            this.colDieuTri_LanKhamGanNhat,
            this.colDieuTri_KetLuanGanNhat});
            this.dgvDieuTri.Location = new System.Drawing.Point(10, 10);
            this.dgvDieuTri.MultiSelect = false;
            this.dgvDieuTri.Name = "dgvDieuTri";
            this.dgvDieuTri.ReadOnly = true;
            this.dgvDieuTri.RowHeadersVisible = false;
            this.dgvDieuTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDieuTri.Size = new System.Drawing.Size(910, 420);
            this.dgvDieuTri.TabIndex = 0;
            // 
            // colDieuTri_MaHoSo
            // 
            this.colDieuTri_MaHoSo.DataPropertyName = "MaHoSo";
            this.colDieuTri_MaHoSo.HeaderText = "Mã hồ sơ";
            this.colDieuTri_MaHoSo.Name = "colDieuTri_MaHoSo";
            this.colDieuTri_MaHoSo.ReadOnly = true;
            // 
            // colDieuTri_HoTen
            // 
            this.colDieuTri_HoTen.DataPropertyName = "HoTen";
            this.colDieuTri_HoTen.HeaderText = "Bệnh nhân";
            this.colDieuTri_HoTen.Name = "colDieuTri_HoTen";
            this.colDieuTri_HoTen.ReadOnly = true;
            // 
            // colDieuTri_SoDotDieuTri
            // 
            this.colDieuTri_SoDotDieuTri.DataPropertyName = "SoDotDieuTri";
            this.colDieuTri_SoDotDieuTri.HeaderText = "Số đợt điều trị";
            this.colDieuTri_SoDotDieuTri.Name = "colDieuTri_SoDotDieuTri";
            this.colDieuTri_SoDotDieuTri.ReadOnly = true;
            // 
            // colDieuTri_LanKhamGanNhat
            // 
            this.colDieuTri_LanKhamGanNhat.DataPropertyName = "LanKhamGanNhat";
            this.colDieuTri_LanKhamGanNhat.HeaderText = "Lần khám gần nhất";
            this.colDieuTri_LanKhamGanNhat.Name = "colDieuTri_LanKhamGanNhat";
            this.colDieuTri_LanKhamGanNhat.ReadOnly = true;
            // 
            // colDieuTri_KetLuanGanNhat
            // 
            this.colDieuTri_KetLuanGanNhat.DataPropertyName = "KetLuanGanNhat";
            this.colDieuTri_KetLuanGanNhat.HeaderText = "Kết luận gần nhất";
            this.colDieuTri_KetLuanGanNhat.Name = "colDieuTri_KetLuanGanNhat";
            this.colDieuTri_KetLuanGanNhat.ReadOnly = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(850, 600);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 27);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblBacSiLoc);
            this.Controls.Add(this.cboBacSiLoc);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblSoHoSoMoi);
            this.Controls.Add(this.lblSoPhieuKham);
            this.Controls.Add(this.lblKhamDinhKy);
            this.Controls.Add(this.lblTongLePhi);
            this.Controls.Add(this.lblTongVienPhi);
            this.Controls.Add(this.tabThongKe);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi - Thống kê";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuTri)).EndInit();
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
            this.tabTheoBacSi.ResumeLayout(false);
            this.tabTheoThuoc.ResumeLayout(false);
            this.tabTheoHoSo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Label lblBacSiLoc;
        private System.Windows.Forms.ComboBox cboBacSiLoc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblSoHoSoMoi;
        private System.Windows.Forms.Label lblSoPhieuKham;
        private System.Windows.Forms.Label lblKhamDinhKy;
        private System.Windows.Forms.Label lblTongLePhi;
        private System.Windows.Forms.Label lblTongVienPhi;
        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabTheoBacSi;
        private System.Windows.Forms.DataGridView dgvBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi_MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi_TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi_TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi_SoPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi_SoKhamBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi_SoKhamDinhKy;
        private System.Windows.Forms.TabPage tabTheoThuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_SoLanKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_TongSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc_PhanUngPhu;
        private System.Windows.Forms.TabPage tabTheoHoSo;
        private System.Windows.Forms.DataGridView dgvDieuTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDieuTri_MaHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDieuTri_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDieuTri_SoDotDieuTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDieuTri_LanKhamGanNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDieuTri_KetLuanGanNhat;
        private System.Windows.Forms.Button btnDong;
    }
}
