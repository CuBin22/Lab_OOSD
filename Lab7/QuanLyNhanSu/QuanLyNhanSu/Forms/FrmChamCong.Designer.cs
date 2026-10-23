namespace QuanLyNhanSu.Forms
{
    partial class FrmChamCong
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPhanCong = new System.Windows.Forms.TabPage();
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.tabPhuTroi = new System.Windows.Forms.TabPage();
            this.lblSoKH = new System.Windows.Forms.Label();
            this.txtSoKH = new System.Windows.Forms.TextBox();
            this.lblKHNguoiLap = new System.Windows.Forms.Label();
            this.cboKHNguoiLap = new System.Windows.Forms.ComboBox();
            this.lblKHPhongBan = new System.Windows.Forms.Label();
            this.cboKHPhongBan = new System.Windows.Forms.ComboBox();
            this.lblKHTuNgay = new System.Windows.Forms.Label();
            this.dtKHTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblKHDenNgay = new System.Windows.Forms.Label();
            this.dtKHDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblPCNhanVien = new System.Windows.Forms.Label();
            this.cboPCNhanVien = new System.Windows.Forms.ComboBox();
            this.lblPCNgay = new System.Windows.Forms.Label();
            this.dtPCNgay = new System.Windows.Forms.DateTimePicker();
            this.lblPCCa = new System.Windows.Forms.Label();
            this.cboPCCa = new System.Windows.Forms.ComboBox();
            this.chkPCPhuTroi = new System.Windows.Forms.CheckBox();
            this.btnThemPC = new System.Windows.Forms.Button();
            this.btnBoPC = new System.Windows.Forms.Button();
            this.btnLapKH = new System.Windows.Forms.Button();
            this.lblPCChon = new System.Windows.Forms.Label();
            this.lblKHDaLap = new System.Windows.Forms.Label();
            this.dgvPCChon = new System.Windows.Forms.DataGridView();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.lblSoCC = new System.Windows.Forms.Label();
            this.txtSoCC = new System.Windows.Forms.TextBox();
            this.lblCCNhanVien = new System.Windows.Forms.Label();
            this.cboCCNhanVien = new System.Windows.Forms.ComboBox();
            this.lblCCNguoiLap = new System.Windows.Forms.Label();
            this.cboCCNguoiLap = new System.Windows.Forms.ComboBox();
            this.lblCCNgay = new System.Windows.Forms.Label();
            this.dtCCNgay = new System.Windows.Forms.DateTimePicker();
            this.lblCCCa = new System.Windows.Forms.Label();
            this.cboCCCa = new System.Windows.Forms.ComboBox();
            this.lblCCSoGio = new System.Windows.Forms.Label();
            this.numCCSoGio = new System.Windows.Forms.NumericUpDown();
            this.lblCCGhiChu = new System.Windows.Forms.Label();
            this.txtCCGhiChu = new System.Windows.Forms.TextBox();
            this.btnLapCC = new System.Windows.Forms.Button();
            this.btnLamMoiCC = new System.Windows.Forms.Button();
            this.dgvCC = new System.Windows.Forms.DataGridView();
            this.lblSoPT = new System.Windows.Forms.Label();
            this.txtSoPT = new System.Windows.Forms.TextBox();
            this.lblPTNgay = new System.Windows.Forms.Label();
            this.dtPTNgay = new System.Windows.Forms.DateTimePicker();
            this.lblPTSoGio = new System.Windows.Forms.Label();
            this.numPTSoGio = new System.Windows.Forms.NumericUpDown();
            this.lblPTHinhThuc = new System.Windows.Forms.Label();
            this.cboPTHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblPTHeSo = new System.Windows.Forms.Label();
            this.txtPTHeSo = new System.Windows.Forms.TextBox();
            this.lblPTNguoiLap = new System.Windows.Forms.Label();
            this.cboPTNguoiLap = new System.Windows.Forms.ComboBox();
            this.lblPTNhanVien = new System.Windows.Forms.Label();
            this.cboPTNhanVien = new System.Windows.Forms.ComboBox();
            this.btnThemPTNV = new System.Windows.Forms.Button();
            this.btnBoPTNV = new System.Windows.Forms.Button();
            this.btnLapPT = new System.Windows.Forms.Button();
            this.btnLamMoiPT = new System.Windows.Forms.Button();
            this.lblPTChon = new System.Windows.Forms.Label();
            this.lblPTDaLap = new System.Windows.Forms.Label();
            this.dgvPTChon = new System.Windows.Forms.DataGridView();
            this.dgvPT = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPhanCong.SuspendLayout();
            this.tabChamCong.SuspendLayout();
            this.tabPhuTroi.SuspendLayout();
            this.SuspendLayout();
            // tabMain
            //
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPhanCong);
            this.tabMain.Controls.Add(this.tabChamCong);
            this.tabMain.Controls.Add(this.tabPhuTroi);
            this.tabMain.Location = new System.Drawing.Point(10, 10);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(980, 542);
            this.tabMain.TabIndex = 0;
            // tabPhanCong
            //
            this.tabPhanCong.Controls.Add(this.lblSoKH);
            this.tabPhanCong.Controls.Add(this.txtSoKH);
            this.tabPhanCong.Controls.Add(this.lblKHNguoiLap);
            this.tabPhanCong.Controls.Add(this.cboKHNguoiLap);
            this.tabPhanCong.Controls.Add(this.lblKHPhongBan);
            this.tabPhanCong.Controls.Add(this.cboKHPhongBan);
            this.tabPhanCong.Controls.Add(this.lblKHTuNgay);
            this.tabPhanCong.Controls.Add(this.dtKHTuNgay);
            this.tabPhanCong.Controls.Add(this.lblKHDenNgay);
            this.tabPhanCong.Controls.Add(this.dtKHDenNgay);
            this.tabPhanCong.Controls.Add(this.lblPCNhanVien);
            this.tabPhanCong.Controls.Add(this.cboPCNhanVien);
            this.tabPhanCong.Controls.Add(this.lblPCNgay);
            this.tabPhanCong.Controls.Add(this.dtPCNgay);
            this.tabPhanCong.Controls.Add(this.lblPCCa);
            this.tabPhanCong.Controls.Add(this.cboPCCa);
            this.tabPhanCong.Controls.Add(this.chkPCPhuTroi);
            this.tabPhanCong.Controls.Add(this.btnThemPC);
            this.tabPhanCong.Controls.Add(this.btnBoPC);
            this.tabPhanCong.Controls.Add(this.btnLapKH);
            this.tabPhanCong.Controls.Add(this.lblPCChon);
            this.tabPhanCong.Controls.Add(this.lblKHDaLap);
            this.tabPhanCong.Controls.Add(this.dgvPCChon);
            this.tabPhanCong.Controls.Add(this.dgvKH);
            this.tabPhanCong.Location = new System.Drawing.Point(4, 24);
            this.tabPhanCong.Name = "tabPhanCong";
            this.tabPhanCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhanCong.Size = new System.Drawing.Size(972, 514);
            this.tabPhanCong.TabIndex = 0;
            this.tabPhanCong.Text = "Phân công";
            this.tabPhanCong.UseVisualStyleBackColor = true;
            // tabChamCong
            //
            this.tabChamCong.Controls.Add(this.lblSoCC);
            this.tabChamCong.Controls.Add(this.txtSoCC);
            this.tabChamCong.Controls.Add(this.lblCCNhanVien);
            this.tabChamCong.Controls.Add(this.cboCCNhanVien);
            this.tabChamCong.Controls.Add(this.lblCCNguoiLap);
            this.tabChamCong.Controls.Add(this.cboCCNguoiLap);
            this.tabChamCong.Controls.Add(this.lblCCNgay);
            this.tabChamCong.Controls.Add(this.dtCCNgay);
            this.tabChamCong.Controls.Add(this.lblCCCa);
            this.tabChamCong.Controls.Add(this.cboCCCa);
            this.tabChamCong.Controls.Add(this.lblCCSoGio);
            this.tabChamCong.Controls.Add(this.numCCSoGio);
            this.tabChamCong.Controls.Add(this.lblCCGhiChu);
            this.tabChamCong.Controls.Add(this.txtCCGhiChu);
            this.tabChamCong.Controls.Add(this.btnLapCC);
            this.tabChamCong.Controls.Add(this.btnLamMoiCC);
            this.tabChamCong.Controls.Add(this.dgvCC);
            this.tabChamCong.Location = new System.Drawing.Point(4, 24);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabChamCong.Size = new System.Drawing.Size(972, 514);
            this.tabChamCong.TabIndex = 0;
            this.tabChamCong.Text = "Chấm công";
            this.tabChamCong.UseVisualStyleBackColor = true;
            // tabPhuTroi
            //
            this.tabPhuTroi.Controls.Add(this.lblSoPT);
            this.tabPhuTroi.Controls.Add(this.txtSoPT);
            this.tabPhuTroi.Controls.Add(this.lblPTNgay);
            this.tabPhuTroi.Controls.Add(this.dtPTNgay);
            this.tabPhuTroi.Controls.Add(this.lblPTSoGio);
            this.tabPhuTroi.Controls.Add(this.numPTSoGio);
            this.tabPhuTroi.Controls.Add(this.lblPTHinhThuc);
            this.tabPhuTroi.Controls.Add(this.cboPTHinhThuc);
            this.tabPhuTroi.Controls.Add(this.lblPTHeSo);
            this.tabPhuTroi.Controls.Add(this.txtPTHeSo);
            this.tabPhuTroi.Controls.Add(this.lblPTNguoiLap);
            this.tabPhuTroi.Controls.Add(this.cboPTNguoiLap);
            this.tabPhuTroi.Controls.Add(this.lblPTNhanVien);
            this.tabPhuTroi.Controls.Add(this.cboPTNhanVien);
            this.tabPhuTroi.Controls.Add(this.btnThemPTNV);
            this.tabPhuTroi.Controls.Add(this.btnBoPTNV);
            this.tabPhuTroi.Controls.Add(this.btnLapPT);
            this.tabPhuTroi.Controls.Add(this.btnLamMoiPT);
            this.tabPhuTroi.Controls.Add(this.lblPTChon);
            this.tabPhuTroi.Controls.Add(this.lblPTDaLap);
            this.tabPhuTroi.Controls.Add(this.dgvPTChon);
            this.tabPhuTroi.Controls.Add(this.dgvPT);
            this.tabPhuTroi.Location = new System.Drawing.Point(4, 24);
            this.tabPhuTroi.Name = "tabPhuTroi";
            this.tabPhuTroi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhuTroi.Size = new System.Drawing.Size(972, 514);
            this.tabPhuTroi.TabIndex = 0;
            this.tabPhuTroi.Text = "Phụ trội";
            this.tabPhuTroi.UseVisualStyleBackColor = true;
            // lblSoKH
            //
            this.lblSoKH.AutoSize = true;
            this.lblSoKH.Location = new System.Drawing.Point(15, 18);
            this.lblSoKH.Name = "lblSoKH";
            this.lblSoKH.TabIndex = 1;
            this.lblSoKH.Text = "Số kế hoạch:";
            // txtSoKH
            //
            this.txtSoKH.Location = new System.Drawing.Point(120, 15);
            this.txtSoKH.Name = "txtSoKH";
            this.txtSoKH.Size = new System.Drawing.Size(130, 23);
            this.txtSoKH.TabIndex = 2;
            // lblKHNguoiLap
            //
            this.lblKHNguoiLap.AutoSize = true;
            this.lblKHNguoiLap.Location = new System.Drawing.Point(255, 18);
            this.lblKHNguoiLap.Name = "lblKHNguoiLap";
            this.lblKHNguoiLap.TabIndex = 3;
            this.lblKHNguoiLap.Text = "Người lập:";
            // cboKHNguoiLap
            //
            this.cboKHNguoiLap.Location = new System.Drawing.Point(360, 15);
            this.cboKHNguoiLap.Name = "cboKHNguoiLap";
            this.cboKHNguoiLap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKHNguoiLap.FormattingEnabled = true;
            this.cboKHNguoiLap.Size = new System.Drawing.Size(130, 23);
            this.cboKHNguoiLap.TabIndex = 4;
            // lblKHPhongBan
            //
            this.lblKHPhongBan.AutoSize = true;
            this.lblKHPhongBan.Location = new System.Drawing.Point(495, 18);
            this.lblKHPhongBan.Name = "lblKHPhongBan";
            this.lblKHPhongBan.TabIndex = 5;
            this.lblKHPhongBan.Text = "Phòng/Ban:";
            // cboKHPhongBan
            //
            this.cboKHPhongBan.Location = new System.Drawing.Point(600, 15);
            this.cboKHPhongBan.Name = "cboKHPhongBan";
            this.cboKHPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKHPhongBan.FormattingEnabled = true;
            this.cboKHPhongBan.Size = new System.Drawing.Size(130, 23);
            this.cboKHPhongBan.TabIndex = 6;
            // lblKHTuNgay
            //
            this.lblKHTuNgay.AutoSize = true;
            this.lblKHTuNgay.Location = new System.Drawing.Point(15, 52);
            this.lblKHTuNgay.Name = "lblKHTuNgay";
            this.lblKHTuNgay.TabIndex = 7;
            this.lblKHTuNgay.Text = "Từ ngày:";
            // dtKHTuNgay
            //
            this.dtKHTuNgay.Location = new System.Drawing.Point(120, 49);
            this.dtKHTuNgay.Name = "dtKHTuNgay";
            this.dtKHTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKHTuNgay.Size = new System.Drawing.Size(130, 23);
            this.dtKHTuNgay.TabIndex = 8;
            // lblKHDenNgay
            //
            this.lblKHDenNgay.AutoSize = true;
            this.lblKHDenNgay.Location = new System.Drawing.Point(255, 52);
            this.lblKHDenNgay.Name = "lblKHDenNgay";
            this.lblKHDenNgay.TabIndex = 9;
            this.lblKHDenNgay.Text = "Đến ngày:";
            // dtKHDenNgay
            //
            this.dtKHDenNgay.Location = new System.Drawing.Point(360, 49);
            this.dtKHDenNgay.Name = "dtKHDenNgay";
            this.dtKHDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKHDenNgay.Size = new System.Drawing.Size(130, 23);
            this.dtKHDenNgay.TabIndex = 10;
            // lblPCNhanVien
            //
            this.lblPCNhanVien.AutoSize = true;
            this.lblPCNhanVien.Location = new System.Drawing.Point(15, 86);
            this.lblPCNhanVien.Name = "lblPCNhanVien";
            this.lblPCNhanVien.TabIndex = 11;
            this.lblPCNhanVien.Text = "Nhân viên:";
            // cboPCNhanVien
            //
            this.cboPCNhanVien.Location = new System.Drawing.Point(120, 83);
            this.cboPCNhanVien.Name = "cboPCNhanVien";
            this.cboPCNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPCNhanVien.FormattingEnabled = true;
            this.cboPCNhanVien.Size = new System.Drawing.Size(130, 23);
            this.cboPCNhanVien.TabIndex = 12;
            // lblPCNgay
            //
            this.lblPCNgay.AutoSize = true;
            this.lblPCNgay.Location = new System.Drawing.Point(255, 86);
            this.lblPCNgay.Name = "lblPCNgay";
            this.lblPCNgay.TabIndex = 13;
            this.lblPCNgay.Text = "Ngày làm việc:";
            // dtPCNgay
            //
            this.dtPCNgay.Location = new System.Drawing.Point(360, 83);
            this.dtPCNgay.Name = "dtPCNgay";
            this.dtPCNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPCNgay.Size = new System.Drawing.Size(130, 23);
            this.dtPCNgay.TabIndex = 14;
            // lblPCCa
            //
            this.lblPCCa.AutoSize = true;
            this.lblPCCa.Location = new System.Drawing.Point(495, 86);
            this.lblPCCa.Name = "lblPCCa";
            this.lblPCCa.TabIndex = 15;
            this.lblPCCa.Text = "Ca:";
            // cboPCCa
            //
            this.cboPCCa.Location = new System.Drawing.Point(600, 83);
            this.cboPCCa.Name = "cboPCCa";
            this.cboPCCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPCCa.FormattingEnabled = true;
            this.cboPCCa.Items.AddRange(new object[] {
                "Sáng",
    "Chiều",
    "Tối"});
            this.cboPCCa.Size = new System.Drawing.Size(130, 23);
            this.cboPCCa.TabIndex = 16;
            // chkPCPhuTroi
            //
            this.chkPCPhuTroi.Location = new System.Drawing.Point(840, 84);
            this.chkPCPhuTroi.Name = "chkPCPhuTroi";
            this.chkPCPhuTroi.AutoSize = true;
            this.chkPCPhuTroi.TabIndex = 17;
            this.chkPCPhuTroi.Text = "Có phụ trội";
            this.chkPCPhuTroi.UseVisualStyleBackColor = true;
            // btnThemPC
            //
            this.btnThemPC.Location = new System.Drawing.Point(15, 115);
            this.btnThemPC.Name = "btnThemPC";
            this.btnThemPC.Size = new System.Drawing.Size(115, 28);
            this.btnThemPC.TabIndex = 18;
            this.btnThemPC.Text = "Thêm vào KH";
            this.btnThemPC.UseVisualStyleBackColor = true;
            this.btnThemPC.Click += new System.EventHandler(this.btnThemPC_Click);
            // btnBoPC
            //
            this.btnBoPC.Location = new System.Drawing.Point(140, 115);
            this.btnBoPC.Name = "btnBoPC";
            this.btnBoPC.Size = new System.Drawing.Size(105, 28);
            this.btnBoPC.TabIndex = 19;
            this.btnBoPC.Text = "Bỏ dòng";
            this.btnBoPC.UseVisualStyleBackColor = true;
            this.btnBoPC.Click += new System.EventHandler(this.btnBoPC_Click);
            // btnLapKH
            //
            this.btnLapKH.Location = new System.Drawing.Point(735, 115);
            this.btnLapKH.Name = "btnLapKH";
            this.btnLapKH.Size = new System.Drawing.Size(115, 28);
            this.btnLapKH.TabIndex = 20;
            this.btnLapKH.Text = "Lập kế hoạch";
            this.btnLapKH.UseVisualStyleBackColor = true;
            this.btnLapKH.Click += new System.EventHandler(this.btnLapKH_Click);
            // lblPCChon
            //
            this.lblPCChon.AutoSize = true;
            this.lblPCChon.Location = new System.Drawing.Point(15, 152);
            this.lblPCChon.Name = "lblPCChon";
            this.lblPCChon.TabIndex = 21;
            this.lblPCChon.Text = "Chi tiết phân công đang chọn:";
            // lblKHDaLap
            //
            this.lblKHDaLap.AutoSize = true;
            this.lblKHDaLap.Location = new System.Drawing.Point(495, 152);
            this.lblKHDaLap.Name = "lblKHDaLap";
            this.lblKHDaLap.TabIndex = 22;
            this.lblKHDaLap.Text = "Kế hoạch đã lập:";
            // dgvPCChon
            //
            this.dgvPCChon.Location = new System.Drawing.Point(15, 175);
            this.dgvPCChon.Name = "dgvPCChon";
            this.dgvPCChon.AllowUserToAddRows = false;
            this.dgvPCChon.AllowUserToDeleteRows = false;
            this.dgvPCChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPCChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPCChon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPCChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPCChon.MultiSelect = false;
            this.dgvPCChon.ReadOnly = true;
            this.dgvPCChon.RowHeadersVisible = false;
            this.dgvPCChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPCChon.Size = new System.Drawing.Size(470, 327);
            this.dgvPCChon.TabIndex = 23;
            // dgvKH
            //
            this.dgvKH.Location = new System.Drawing.Point(495, 175);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToDeleteRows = false;
            this.dgvKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.MultiSelect = false;
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(462, 327);
            this.dgvKH.TabIndex = 24;
            // lblSoCC
            //
            this.lblSoCC.AutoSize = true;
            this.lblSoCC.Location = new System.Drawing.Point(15, 18);
            this.lblSoCC.Name = "lblSoCC";
            this.lblSoCC.TabIndex = 25;
            this.lblSoCC.Text = "Số phiếu:";
            // txtSoCC
            //
            this.txtSoCC.Location = new System.Drawing.Point(120, 15);
            this.txtSoCC.Name = "txtSoCC";
            this.txtSoCC.Size = new System.Drawing.Size(130, 23);
            this.txtSoCC.TabIndex = 26;
            // lblCCNhanVien
            //
            this.lblCCNhanVien.AutoSize = true;
            this.lblCCNhanVien.Location = new System.Drawing.Point(255, 18);
            this.lblCCNhanVien.Name = "lblCCNhanVien";
            this.lblCCNhanVien.TabIndex = 27;
            this.lblCCNhanVien.Text = "Nhân viên:";
            // cboCCNhanVien
            //
            this.cboCCNhanVien.Location = new System.Drawing.Point(360, 15);
            this.cboCCNhanVien.Name = "cboCCNhanVien";
            this.cboCCNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCCNhanVien.FormattingEnabled = true;
            this.cboCCNhanVien.Size = new System.Drawing.Size(130, 23);
            this.cboCCNhanVien.TabIndex = 28;
            // lblCCNguoiLap
            //
            this.lblCCNguoiLap.AutoSize = true;
            this.lblCCNguoiLap.Location = new System.Drawing.Point(495, 18);
            this.lblCCNguoiLap.Name = "lblCCNguoiLap";
            this.lblCCNguoiLap.TabIndex = 29;
            this.lblCCNguoiLap.Text = "Người lập:";
            // cboCCNguoiLap
            //
            this.cboCCNguoiLap.Location = new System.Drawing.Point(600, 15);
            this.cboCCNguoiLap.Name = "cboCCNguoiLap";
            this.cboCCNguoiLap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCCNguoiLap.FormattingEnabled = true;
            this.cboCCNguoiLap.Size = new System.Drawing.Size(130, 23);
            this.cboCCNguoiLap.TabIndex = 30;
            // lblCCNgay
            //
            this.lblCCNgay.AutoSize = true;
            this.lblCCNgay.Location = new System.Drawing.Point(735, 18);
            this.lblCCNgay.Name = "lblCCNgay";
            this.lblCCNgay.TabIndex = 31;
            this.lblCCNgay.Text = "Ngày công:";
            // dtCCNgay
            //
            this.dtCCNgay.Location = new System.Drawing.Point(840, 15);
            this.dtCCNgay.Name = "dtCCNgay";
            this.dtCCNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCCNgay.Size = new System.Drawing.Size(130, 23);
            this.dtCCNgay.TabIndex = 32;
            // lblCCCa
            //
            this.lblCCCa.AutoSize = true;
            this.lblCCCa.Location = new System.Drawing.Point(15, 52);
            this.lblCCCa.Name = "lblCCCa";
            this.lblCCCa.TabIndex = 33;
            this.lblCCCa.Text = "Ca:";
            // cboCCCa
            //
            this.cboCCCa.Location = new System.Drawing.Point(120, 49);
            this.cboCCCa.Name = "cboCCCa";
            this.cboCCCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCCCa.FormattingEnabled = true;
            this.cboCCCa.Items.AddRange(new object[] {
                "Sáng",
    "Chiều",
    "Tối"});
            this.cboCCCa.Size = new System.Drawing.Size(130, 23);
            this.cboCCCa.TabIndex = 34;
            // lblCCSoGio
            //
            this.lblCCSoGio.AutoSize = true;
            this.lblCCSoGio.Location = new System.Drawing.Point(255, 52);
            this.lblCCSoGio.Name = "lblCCSoGio";
            this.lblCCSoGio.TabIndex = 35;
            this.lblCCSoGio.Text = "Số giờ làm:";
            // numCCSoGio
            //
            this.numCCSoGio.Location = new System.Drawing.Point(360, 49);
            this.numCCSoGio.Name = "numCCSoGio";
            this.numCCSoGio.DecimalPlaces = 1;
            this.numCCSoGio.Increment = new decimal(new int[] {5, 0, 0, 65536});
            this.numCCSoGio.Maximum = new decimal(new int[] {24, 0, 0, 0});
            this.numCCSoGio.Size = new System.Drawing.Size(130, 23);
            this.numCCSoGio.TabIndex = 36;
            // lblCCGhiChu
            //
            this.lblCCGhiChu.AutoSize = true;
            this.lblCCGhiChu.Location = new System.Drawing.Point(495, 52);
            this.lblCCGhiChu.Name = "lblCCGhiChu";
            this.lblCCGhiChu.TabIndex = 37;
            this.lblCCGhiChu.Text = "Ghi chú:";
            // txtCCGhiChu
            //
            this.txtCCGhiChu.Location = new System.Drawing.Point(600, 49);
            this.txtCCGhiChu.Name = "txtCCGhiChu";
            this.txtCCGhiChu.Size = new System.Drawing.Size(370, 23);
            this.txtCCGhiChu.TabIndex = 38;
            // btnLapCC
            //
            this.btnLapCC.Location = new System.Drawing.Point(15, 81);
            this.btnLapCC.Name = "btnLapCC";
            this.btnLapCC.Size = new System.Drawing.Size(105, 28);
            this.btnLapCC.TabIndex = 39;
            this.btnLapCC.Text = "Lập phiếu";
            this.btnLapCC.UseVisualStyleBackColor = true;
            this.btnLapCC.Click += new System.EventHandler(this.btnLapCC_Click);
            // btnLamMoiCC
            //
            this.btnLamMoiCC.Location = new System.Drawing.Point(130, 81);
            this.btnLamMoiCC.Name = "btnLamMoiCC";
            this.btnLamMoiCC.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiCC.TabIndex = 40;
            this.btnLamMoiCC.Text = "Làm mới";
            this.btnLamMoiCC.UseVisualStyleBackColor = true;
            this.btnLamMoiCC.Click += new System.EventHandler(this.btnLamMoiCC_Click);
            // dgvCC
            //
            this.dgvCC.Location = new System.Drawing.Point(15, 120);
            this.dgvCC.Name = "dgvCC";
            this.dgvCC.AllowUserToAddRows = false;
            this.dgvCC.AllowUserToDeleteRows = false;
            this.dgvCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCC.MultiSelect = false;
            this.dgvCC.ReadOnly = true;
            this.dgvCC.RowHeadersVisible = false;
            this.dgvCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCC.Size = new System.Drawing.Size(942, 382);
            this.dgvCC.TabIndex = 41;
            // lblSoPT
            //
            this.lblSoPT.AutoSize = true;
            this.lblSoPT.Location = new System.Drawing.Point(15, 18);
            this.lblSoPT.Name = "lblSoPT";
            this.lblSoPT.TabIndex = 42;
            this.lblSoPT.Text = "Số phiếu:";
            // txtSoPT
            //
            this.txtSoPT.Location = new System.Drawing.Point(120, 15);
            this.txtSoPT.Name = "txtSoPT";
            this.txtSoPT.Size = new System.Drawing.Size(130, 23);
            this.txtSoPT.TabIndex = 43;
            // lblPTNgay
            //
            this.lblPTNgay.AutoSize = true;
            this.lblPTNgay.Location = new System.Drawing.Point(255, 18);
            this.lblPTNgay.Name = "lblPTNgay";
            this.lblPTNgay.TabIndex = 44;
            this.lblPTNgay.Text = "Ngày phụ trội:";
            // dtPTNgay
            //
            this.dtPTNgay.Location = new System.Drawing.Point(360, 15);
            this.dtPTNgay.Name = "dtPTNgay";
            this.dtPTNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPTNgay.Size = new System.Drawing.Size(130, 23);
            this.dtPTNgay.TabIndex = 45;
            // lblPTSoGio
            //
            this.lblPTSoGio.AutoSize = true;
            this.lblPTSoGio.Location = new System.Drawing.Point(495, 18);
            this.lblPTSoGio.Name = "lblPTSoGio";
            this.lblPTSoGio.TabIndex = 46;
            this.lblPTSoGio.Text = "Số giờ phụ trội:";
            // numPTSoGio
            //
            this.numPTSoGio.Location = new System.Drawing.Point(600, 15);
            this.numPTSoGio.Name = "numPTSoGio";
            this.numPTSoGio.DecimalPlaces = 1;
            this.numPTSoGio.Increment = new decimal(new int[] {5, 0, 0, 65536});
            this.numPTSoGio.Maximum = new decimal(new int[] {24, 0, 0, 0});
            this.numPTSoGio.Size = new System.Drawing.Size(130, 23);
            this.numPTSoGio.TabIndex = 47;
            // lblPTHinhThuc
            //
            this.lblPTHinhThuc.AutoSize = true;
            this.lblPTHinhThuc.Location = new System.Drawing.Point(735, 18);
            this.lblPTHinhThuc.Name = "lblPTHinhThuc";
            this.lblPTHinhThuc.TabIndex = 48;
            this.lblPTHinhThuc.Text = "Hình thức:";
            // cboPTHinhThuc
            //
            this.cboPTHinhThuc.Location = new System.Drawing.Point(840, 15);
            this.cboPTHinhThuc.Name = "cboPTHinhThuc";
            this.cboPTHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPTHinhThuc.FormattingEnabled = true;
            this.cboPTHinhThuc.Items.AddRange(new object[] {
                "Tăng ca",
    "Ngày lễ",
    "Ngày nghỉ"});
            this.cboPTHinhThuc.Size = new System.Drawing.Size(130, 23);
            this.cboPTHinhThuc.TabIndex = 49;
            // lblPTHeSo
            //
            this.lblPTHeSo.AutoSize = true;
            this.lblPTHeSo.Location = new System.Drawing.Point(15, 52);
            this.lblPTHeSo.Name = "lblPTHeSo";
            this.lblPTHeSo.TabIndex = 50;
            this.lblPTHeSo.Text = "Hệ số:";
            // txtPTHeSo
            //
            this.txtPTHeSo.Location = new System.Drawing.Point(120, 49);
            this.txtPTHeSo.Name = "txtPTHeSo";
            this.txtPTHeSo.Size = new System.Drawing.Size(130, 23);
            this.txtPTHeSo.ReadOnly = true;
            this.txtPTHeSo.Text = "1.5";
            this.txtPTHeSo.TabIndex = 51;
            // lblPTNguoiLap
            //
            this.lblPTNguoiLap.AutoSize = true;
            this.lblPTNguoiLap.Location = new System.Drawing.Point(255, 52);
            this.lblPTNguoiLap.Name = "lblPTNguoiLap";
            this.lblPTNguoiLap.TabIndex = 52;
            this.lblPTNguoiLap.Text = "Người lập:";
            // cboPTNguoiLap
            //
            this.cboPTNguoiLap.Location = new System.Drawing.Point(360, 49);
            this.cboPTNguoiLap.Name = "cboPTNguoiLap";
            this.cboPTNguoiLap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPTNguoiLap.FormattingEnabled = true;
            this.cboPTNguoiLap.Size = new System.Drawing.Size(130, 23);
            this.cboPTNguoiLap.TabIndex = 53;
            // lblPTNhanVien
            //
            this.lblPTNhanVien.AutoSize = true;
            this.lblPTNhanVien.Location = new System.Drawing.Point(495, 52);
            this.lblPTNhanVien.Name = "lblPTNhanVien";
            this.lblPTNhanVien.TabIndex = 54;
            this.lblPTNhanVien.Text = "Nhân viên:";
            // cboPTNhanVien
            //
            this.cboPTNhanVien.Location = new System.Drawing.Point(600, 49);
            this.cboPTNhanVien.Name = "cboPTNhanVien";
            this.cboPTNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPTNhanVien.FormattingEnabled = true;
            this.cboPTNhanVien.Size = new System.Drawing.Size(130, 23);
            this.cboPTNhanVien.TabIndex = 55;
            // btnThemPTNV
            //
            this.btnThemPTNV.Location = new System.Drawing.Point(735, 47);
            this.btnThemPTNV.Name = "btnThemPTNV";
            this.btnThemPTNV.Size = new System.Drawing.Size(105, 28);
            this.btnThemPTNV.TabIndex = 56;
            this.btnThemPTNV.Text = "Thêm NV";
            this.btnThemPTNV.UseVisualStyleBackColor = true;
            this.btnThemPTNV.Click += new System.EventHandler(this.btnThemPTNV_Click);
            // btnBoPTNV
            //
            this.btnBoPTNV.Location = new System.Drawing.Point(15, 81);
            this.btnBoPTNV.Name = "btnBoPTNV";
            this.btnBoPTNV.Size = new System.Drawing.Size(105, 28);
            this.btnBoPTNV.TabIndex = 57;
            this.btnBoPTNV.Text = "Bỏ dòng";
            this.btnBoPTNV.UseVisualStyleBackColor = true;
            this.btnBoPTNV.Click += new System.EventHandler(this.btnBoPTNV_Click);
            // btnLapPT
            //
            this.btnLapPT.Location = new System.Drawing.Point(495, 81);
            this.btnLapPT.Name = "btnLapPT";
            this.btnLapPT.Size = new System.Drawing.Size(105, 28);
            this.btnLapPT.TabIndex = 58;
            this.btnLapPT.Text = "Lập phiếu";
            this.btnLapPT.UseVisualStyleBackColor = true;
            this.btnLapPT.Click += new System.EventHandler(this.btnLapPT_Click);
            // btnLamMoiPT
            //
            this.btnLamMoiPT.Location = new System.Drawing.Point(610, 81);
            this.btnLamMoiPT.Name = "btnLamMoiPT";
            this.btnLamMoiPT.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiPT.TabIndex = 59;
            this.btnLamMoiPT.Text = "Làm mới";
            this.btnLamMoiPT.UseVisualStyleBackColor = true;
            this.btnLamMoiPT.Click += new System.EventHandler(this.btnLamMoiPT_Click);
            // lblPTChon
            //
            this.lblPTChon.AutoSize = true;
            this.lblPTChon.Location = new System.Drawing.Point(15, 122);
            this.lblPTChon.Name = "lblPTChon";
            this.lblPTChon.TabIndex = 60;
            this.lblPTChon.Text = "Nhân viên tham gia phụ trội:";
            // lblPTDaLap
            //
            this.lblPTDaLap.AutoSize = true;
            this.lblPTDaLap.Location = new System.Drawing.Point(495, 122);
            this.lblPTDaLap.Name = "lblPTDaLap";
            this.lblPTDaLap.TabIndex = 61;
            this.lblPTDaLap.Text = "Phiếu phụ trội đã lập:";
            // dgvPTChon
            //
            this.dgvPTChon.Location = new System.Drawing.Point(15, 145);
            this.dgvPTChon.Name = "dgvPTChon";
            this.dgvPTChon.AllowUserToAddRows = false;
            this.dgvPTChon.AllowUserToDeleteRows = false;
            this.dgvPTChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPTChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPTChon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPTChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTChon.MultiSelect = false;
            this.dgvPTChon.ReadOnly = true;
            this.dgvPTChon.RowHeadersVisible = false;
            this.dgvPTChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPTChon.Size = new System.Drawing.Size(470, 357);
            this.dgvPTChon.TabIndex = 62;
            // dgvPT
            //
            this.dgvPT.Location = new System.Drawing.Point(495, 145);
            this.dgvPT.Name = "dgvPT";
            this.dgvPT.AllowUserToAddRows = false;
            this.dgvPT.AllowUserToDeleteRows = false;
            this.dgvPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPT.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPT.MultiSelect = false;
            this.dgvPT.ReadOnly = true;
            this.dgvPT.RowHeadersVisible = false;
            this.dgvPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPT.Size = new System.Drawing.Size(462, 357);
            this.dgvPT.TabIndex = 63;
            // btnDong
            //
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(880, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 64;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // FrmChamCong
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công - Chấm công - Phụ trội";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).EndInit();
            this.tabPhanCong.ResumeLayout(false);
            this.tabChamCong.ResumeLayout(false);
            this.tabPhuTroi.ResumeLayout(false);
            this.tabPhanCong.PerformLayout();
            this.tabChamCong.PerformLayout();
            this.tabPhuTroi.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPhanCong;
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.TabPage tabPhuTroi;
        private System.Windows.Forms.Label lblSoKH;
        private System.Windows.Forms.TextBox txtSoKH;
        private System.Windows.Forms.Label lblKHNguoiLap;
        private System.Windows.Forms.ComboBox cboKHNguoiLap;
        private System.Windows.Forms.Label lblKHPhongBan;
        private System.Windows.Forms.ComboBox cboKHPhongBan;
        private System.Windows.Forms.Label lblKHTuNgay;
        private System.Windows.Forms.DateTimePicker dtKHTuNgay;
        private System.Windows.Forms.Label lblKHDenNgay;
        private System.Windows.Forms.DateTimePicker dtKHDenNgay;
        private System.Windows.Forms.Label lblPCNhanVien;
        private System.Windows.Forms.ComboBox cboPCNhanVien;
        private System.Windows.Forms.Label lblPCNgay;
        private System.Windows.Forms.DateTimePicker dtPCNgay;
        private System.Windows.Forms.Label lblPCCa;
        private System.Windows.Forms.ComboBox cboPCCa;
        private System.Windows.Forms.CheckBox chkPCPhuTroi;
        private System.Windows.Forms.Button btnThemPC;
        private System.Windows.Forms.Button btnBoPC;
        private System.Windows.Forms.Button btnLapKH;
        private System.Windows.Forms.Label lblPCChon;
        private System.Windows.Forms.Label lblKHDaLap;
        private System.Windows.Forms.DataGridView dgvPCChon;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label lblSoCC;
        private System.Windows.Forms.TextBox txtSoCC;
        private System.Windows.Forms.Label lblCCNhanVien;
        private System.Windows.Forms.ComboBox cboCCNhanVien;
        private System.Windows.Forms.Label lblCCNguoiLap;
        private System.Windows.Forms.ComboBox cboCCNguoiLap;
        private System.Windows.Forms.Label lblCCNgay;
        private System.Windows.Forms.DateTimePicker dtCCNgay;
        private System.Windows.Forms.Label lblCCCa;
        private System.Windows.Forms.ComboBox cboCCCa;
        private System.Windows.Forms.Label lblCCSoGio;
        private System.Windows.Forms.NumericUpDown numCCSoGio;
        private System.Windows.Forms.Label lblCCGhiChu;
        private System.Windows.Forms.TextBox txtCCGhiChu;
        private System.Windows.Forms.Button btnLapCC;
        private System.Windows.Forms.Button btnLamMoiCC;
        private System.Windows.Forms.DataGridView dgvCC;
        private System.Windows.Forms.Label lblSoPT;
        private System.Windows.Forms.TextBox txtSoPT;
        private System.Windows.Forms.Label lblPTNgay;
        private System.Windows.Forms.DateTimePicker dtPTNgay;
        private System.Windows.Forms.Label lblPTSoGio;
        private System.Windows.Forms.NumericUpDown numPTSoGio;
        private System.Windows.Forms.Label lblPTHinhThuc;
        private System.Windows.Forms.ComboBox cboPTHinhThuc;
        private System.Windows.Forms.Label lblPTHeSo;
        private System.Windows.Forms.TextBox txtPTHeSo;
        private System.Windows.Forms.Label lblPTNguoiLap;
        private System.Windows.Forms.ComboBox cboPTNguoiLap;
        private System.Windows.Forms.Label lblPTNhanVien;
        private System.Windows.Forms.ComboBox cboPTNhanVien;
        private System.Windows.Forms.Button btnThemPTNV;
        private System.Windows.Forms.Button btnBoPTNV;
        private System.Windows.Forms.Button btnLapPT;
        private System.Windows.Forms.Button btnLamMoiPT;
        private System.Windows.Forms.Label lblPTChon;
        private System.Windows.Forms.Label lblPTDaLap;
        private System.Windows.Forms.DataGridView dgvPTChon;
        private System.Windows.Forms.DataGridView dgvPT;
        private System.Windows.Forms.Button btnDong;
    }
}