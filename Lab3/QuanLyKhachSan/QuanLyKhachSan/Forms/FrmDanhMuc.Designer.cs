namespace QuanLyKhachSan.Forms
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
            this.TabPage = new System.Windows.Forms.TabControl();
            this.TabKhu = new System.Windows.Forms.TabPage();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TabNV = new System.Windows.Forms.TabPage();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabLoaiTN = new System.Windows.Forms.TabPage();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TabDichVu = new System.Windows.Forms.TabPage();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TabQD = new System.Windows.Forms.TabPage();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.colMaKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiQD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucDoQD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienQD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage.SuspendLayout();
            this.TabKhu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.TabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.TabLoaiTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.TabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.TabQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.TabKhu);
            this.TabPage.Controls.Add(this.TabNV);
            this.TabPage.Controls.Add(this.TabLoaiTN);
            this.TabPage.Controls.Add(this.TabDichVu);
            this.TabPage.Controls.Add(this.TabQD);
            this.TabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage.Location = new System.Drawing.Point(-1, 3);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(1366, 829);
            this.TabPage.TabIndex = 0;
            // 
            // TabKhu
            // 
            this.TabKhu.Controls.Add(this.dgvKhu);
            this.TabKhu.Controls.Add(this.btnThemKhu);
            this.TabKhu.Controls.Add(this.txtKhuTen);
            this.TabKhu.Controls.Add(this.label3);
            this.TabKhu.Controls.Add(this.txtKhuMa);
            this.TabKhu.Controls.Add(this.label4);
            this.TabKhu.Location = new System.Drawing.Point(4, 38);
            this.TabKhu.Name = "TabKhu";
            this.TabKhu.Padding = new System.Windows.Forms.Padding(3);
            this.TabKhu.Size = new System.Drawing.Size(1358, 787);
            this.TabKhu.TabIndex = 0;
            this.TabKhu.Text = "Khu vực";
            this.TabKhu.UseVisualStyleBackColor = true;
            // 
            // dgvKhu
            // 
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKhu,
            this.colTenKhu});
            this.dgvKhu.Location = new System.Drawing.Point(153, 160);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.RowHeadersWidth = 51;
            this.dgvKhu.RowTemplate.Height = 24;
            this.dgvKhu.Size = new System.Drawing.Size(1055, 563);
            this.dgvKhu.TabIndex = 11;
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(1016, 69);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(183, 36);
            this.btnThemKhu.TabIndex = 10;
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);
            // 
            // txtKhuTen
            // 
            this.txtKhuTen.Location = new System.Drawing.Point(687, 71);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(182, 34);
            this.txtKhuTen.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên khu:";
            // 
            // txtKhuMa
            // 
            this.txtKhuMa.Location = new System.Drawing.Point(283, 68);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(182, 34);
            this.txtKhuMa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã khu:";
            // 
            // TabNV
            // 
            this.TabNV.Controls.Add(this.txtNVSDT);
            this.TabNV.Controls.Add(this.label5);
            this.TabNV.Controls.Add(this.txtNVVaiTro);
            this.TabNV.Controls.Add(this.label6);
            this.TabNV.Controls.Add(this.dgvNV);
            this.TabNV.Controls.Add(this.btnThemNV);
            this.TabNV.Controls.Add(this.txtNVTen);
            this.TabNV.Controls.Add(this.label2);
            this.TabNV.Controls.Add(this.txtNVMa);
            this.TabNV.Controls.Add(this.label1);
            this.TabNV.Location = new System.Drawing.Point(4, 38);
            this.TabNV.Name = "TabNV";
            this.TabNV.Padding = new System.Windows.Forms.Padding(3);
            this.TabNV.Size = new System.Drawing.Size(1358, 787);
            this.TabNV.TabIndex = 1;
            this.TabNV.Text = "Nhân viên";
            this.TabNV.UseVisualStyleBackColor = true;
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(711, 90);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(182, 34);
            this.txtNVSDT.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại: ";
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(307, 88);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(182, 34);
            this.txtNVVaiTro.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vai trò:";
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.VaiTro,
            this.SoDienThoai});
            this.dgvNV.Location = new System.Drawing.Point(146, 178);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(1053, 565);
            this.dgvNV.TabIndex = 5;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(994, 45);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(183, 36);
            this.btnThemNV.TabIndex = 4;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(711, 44);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(182, 34);
            this.txtNVTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên: ";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(307, 42);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(182, 34);
            this.txtNVMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // TabLoaiTN
            // 
            this.TabLoaiTN.Controls.Add(this.dgvLoaiTN);
            this.TabLoaiTN.Controls.Add(this.btnThemLoaiTN);
            this.TabLoaiTN.Controls.Add(this.txtLoaiTen);
            this.TabLoaiTN.Controls.Add(this.label7);
            this.TabLoaiTN.Controls.Add(this.txtLoaiMa);
            this.TabLoaiTN.Controls.Add(this.label8);
            this.TabLoaiTN.Location = new System.Drawing.Point(4, 38);
            this.TabLoaiTN.Name = "TabLoaiTN";
            this.TabLoaiTN.Padding = new System.Windows.Forms.Padding(3);
            this.TabLoaiTN.Size = new System.Drawing.Size(1358, 787);
            this.TabLoaiTN.TabIndex = 2;
            this.TabLoaiTN.Text = "Loại tiện nghi";
            this.TabLoaiTN.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiTN,
            this.TenLoaiTN});
            this.dgvLoaiTN.Location = new System.Drawing.Point(149, 155);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.RowHeadersWidth = 51;
            this.dgvLoaiTN.RowTemplate.Height = 24;
            this.dgvLoaiTN.Size = new System.Drawing.Size(1055, 563);
            this.dgvLoaiTN.TabIndex = 17;
            // 
            // btnThemLoaiTN
            // 
            this.btnThemLoaiTN.Location = new System.Drawing.Point(1012, 64);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(183, 36);
            this.btnThemLoaiTN.TabIndex = 16;
            this.btnThemLoaiTN.Text = "Thêm";
            this.btnThemLoaiTN.UseVisualStyleBackColor = true;
            this.btnThemLoaiTN.Click += new System.EventHandler(this.btnThemLoaiTN_Click);
            // 
            // txtLoaiTen
            // 
            this.txtLoaiTen.Location = new System.Drawing.Point(683, 66);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(182, 34);
            this.txtLoaiTen.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên loại:";
            // 
            // txtLoaiMa
            // 
            this.txtLoaiMa.Location = new System.Drawing.Point(279, 63);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(182, 34);
            this.txtLoaiMa.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã loại:";
            // 
            // TabDichVu
            // 
            this.TabDichVu.Controls.Add(this.numDVGia);
            this.TabDichVu.Controls.Add(this.label9);
            this.TabDichVu.Controls.Add(this.txtDVDVT);
            this.TabDichVu.Controls.Add(this.label10);
            this.TabDichVu.Controls.Add(this.dgvDV);
            this.TabDichVu.Controls.Add(this.btnThemDV);
            this.TabDichVu.Controls.Add(this.txtDVTen);
            this.TabDichVu.Controls.Add(this.label11);
            this.TabDichVu.Controls.Add(this.txtDVMa);
            this.TabDichVu.Controls.Add(this.label12);
            this.TabDichVu.Location = new System.Drawing.Point(4, 38);
            this.TabDichVu.Name = "TabDichVu";
            this.TabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.TabDichVu.Size = new System.Drawing.Size(1358, 787);
            this.TabDichVu.TabIndex = 3;
            this.TabDichVu.Text = "Dịch vụ";
            this.TabDichVu.UseVisualStyleBackColor = true;
            // 
            // numDVGia
            // 
            this.numDVGia.Location = new System.Drawing.Point(720, 94);
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(182, 34);
            this.numDVGia.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Giá:";
            // 
            // txtDVDVT
            // 
            this.txtDVDVT.Location = new System.Drawing.Point(316, 89);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(182, 34);
            this.txtDVDVT.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Đơn vị tính:";
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.DonViTinh,
            this.DonGia});
            this.dgvDV.Location = new System.Drawing.Point(155, 179);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(1054, 564);
            this.dgvDV.TabIndex = 15;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(1003, 46);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(183, 36);
            this.btnThemDV.TabIndex = 14;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // txtDVTen
            // 
            this.txtDVTen.Location = new System.Drawing.Point(720, 45);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(182, 34);
            this.txtDVTen.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tên dịch vụ:";
            // 
            // txtDVMa
            // 
            this.txtDVMa.Location = new System.Drawing.Point(316, 43);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(182, 34);
            this.txtDVMa.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "Mã dịch vụ:";
            // 
            // TabQD
            // 
            this.TabQD.Controls.Add(this.cboQDLoai);
            this.TabQD.Controls.Add(this.numQDTien);
            this.TabQD.Controls.Add(this.label13);
            this.TabQD.Controls.Add(this.label14);
            this.TabQD.Controls.Add(this.dgvQD);
            this.TabQD.Controls.Add(this.btnThemQD);
            this.TabQD.Controls.Add(this.txtQDMucDo);
            this.TabQD.Controls.Add(this.label15);
            this.TabQD.Controls.Add(this.txtQDMa);
            this.TabQD.Controls.Add(this.label16);
            this.TabQD.Location = new System.Drawing.Point(4, 38);
            this.TabQD.Name = "TabQD";
            this.TabQD.Padding = new System.Windows.Forms.Padding(3);
            this.TabQD.Size = new System.Drawing.Size(1358, 787);
            this.TabQD.TabIndex = 4;
            this.TabQD.Text = "Quy định đền bù";
            this.TabQD.UseVisualStyleBackColor = true;
            // 
            // cboQDLoai
            // 
            this.cboQDLoai.FormattingEnabled = true;
            this.cboQDLoai.Location = new System.Drawing.Point(317, 91);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(181, 37);
            this.cboQDLoai.TabIndex = 31;
            // 
            // numQDTien
            // 
            this.numQDTien.Location = new System.Drawing.Point(747, 94);
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(182, 34);
            this.numQDTien.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(547, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "Tiền quy định:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "Loại quy định:";
            // 
            // dgvQD
            // 
            this.dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQD,
            this.LoaiQD,
            this.MucDoQD,
            this.TienQD});
            this.dgvQD.Location = new System.Drawing.Point(155, 179);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.RowHeadersWidth = 51;
            this.dgvQD.RowTemplate.Height = 24;
            this.dgvQD.Size = new System.Drawing.Size(1054, 564);
            this.dgvQD.TabIndex = 26;
            // 
            // btnThemQD
            // 
            this.btnThemQD.Location = new System.Drawing.Point(1003, 46);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(183, 36);
            this.btnThemQD.TabIndex = 25;
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.UseVisualStyleBackColor = true;
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);
            // 
            // txtQDMucDo
            // 
            this.txtQDMucDo.Location = new System.Drawing.Point(747, 45);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(182, 34);
            this.txtQDMucDo.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(547, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 29);
            this.label15.TabIndex = 23;
            this.label15.Text = "Mức độ quy định:";
            // 
            // txtQDMa
            // 
            this.txtQDMa.Location = new System.Drawing.Point(316, 43);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(182, 34);
            this.txtQDMa.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(150, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 29);
            this.label16.TabIndex = 21;
            this.label16.Text = "Mã quy định:";
            // 
            // colMaKhu
            // 
            this.colMaKhu.DataPropertyName = "MaKhuVuc";
            this.colMaKhu.HeaderText = "Mã khu";
            this.colMaKhu.MinimumWidth = 6;
            this.colMaKhu.Name = "colMaKhu";
            this.colMaKhu.Width = 500;
            // 
            // colTenKhu
            // 
            this.colTenKhu.DataPropertyName = "TenKhuVuc";
            this.colTenKhu.HeaderText = "Tên khu";
            this.colTenKhu.MinimumWidth = 6;
            this.colTenKhu.Name = "colTenKhu";
            this.colTenKhu.Width = 500;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 250;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên nhân viên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 250;
            // 
            // VaiTro
            // 
            this.VaiTro.DataPropertyName = "VaiTro";
            this.VaiTro.HeaderText = "Vai trò";
            this.VaiTro.MinimumWidth = 6;
            this.VaiTro.Name = "VaiTro";
            this.VaiTro.Width = 250;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 250;
            // 
            // MaLoaiTN
            // 
            this.MaLoaiTN.DataPropertyName = "MaLoaiTN";
            this.MaLoaiTN.HeaderText = "Mã loại";
            this.MaLoaiTN.MinimumWidth = 6;
            this.MaLoaiTN.Name = "MaLoaiTN";
            this.MaLoaiTN.Width = 500;
            // 
            // TenLoaiTN
            // 
            this.TenLoaiTN.DataPropertyName = "TenLoaiTN";
            this.TenLoaiTN.HeaderText = "Tên loại";
            this.TenLoaiTN.MinimumWidth = 6;
            this.TenLoaiTN.Name = "TenLoaiTN";
            this.TenLoaiTN.Width = 500;
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã dịch vụ";
            this.MaDV.MinimumWidth = 6;
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 250;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.Width = 250;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 250;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 250;
            // 
            // MaQD
            // 
            this.MaQD.DataPropertyName = "MaQuyDinh";
            this.MaQD.HeaderText = "Mã quy định";
            this.MaQD.MinimumWidth = 6;
            this.MaQD.Name = "MaQD";
            this.MaQD.Width = 250;
            // 
            // LoaiQD
            // 
            this.LoaiQD.DataPropertyName = "TenLoaiTN";
            this.LoaiQD.HeaderText = "Loại quy định";
            this.LoaiQD.MinimumWidth = 6;
            this.LoaiQD.Name = "LoaiQD";
            this.LoaiQD.Width = 250;
            // 
            // MucDoQD
            // 
            this.MucDoQD.DataPropertyName = "MucDoThietHai";
            this.MucDoQD.HeaderText = "Mức độ quy định";
            this.MucDoQD.MinimumWidth = 6;
            this.MucDoQD.Name = "MucDoQD";
            this.MucDoQD.Width = 250;
            // 
            // TienQD
            // 
            this.TienQD.DataPropertyName = "MucDenBu";
            this.TienQD.HeaderText = "Tiền quy định";
            this.TienQD.MinimumWidth = 6;
            this.TienQD.Name = "TienQD";
            this.TienQD.Width = 250;
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 831);
            this.Controls.Add(this.TabPage);
            this.Name = "FrmDanhMuc";
            this.Text = "FrmDanhMuc";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.TabPage.ResumeLayout(false);
            this.TabKhu.ResumeLayout(false);
            this.TabKhu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.TabNV.ResumeLayout(false);
            this.TabNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.TabLoaiTN.ResumeLayout(false);
            this.TabLoaiTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.TabDichVu.ResumeLayout(false);
            this.TabDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.TabQD.ResumeLayout(false);
            this.TabQD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage TabKhu;
        private System.Windows.Forms.TabPage TabNV;
        private System.Windows.Forms.TabPage TabLoaiTN;
        private System.Windows.Forms.TabPage TabDichVu;
        private System.Windows.Forms.TabPage TabQD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLoaiTN;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvQD;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiQD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucDoQD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienQD;
    }
}