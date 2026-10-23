namespace QuanLyNhanSu.Forms
{
    partial class FrmHopDong
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
            this.tabHopDong = new System.Windows.Forms.TabPage();
            this.tabBaoHiem = new System.Windows.Forms.TabPage();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblHDNhanVien = new System.Windows.Forms.Label();
            this.cboHDNhanVien = new System.Windows.Forms.ComboBox();
            this.lblHDQDTD = new System.Windows.Forms.Label();
            this.cboHDQDTD = new System.Windows.Forms.ComboBox();
            this.lblLoaiHD = new System.Windows.Forms.Label();
            this.cboLoaiHD = new System.Windows.Forms.ComboBox();
            this.lblHDNgayKy = new System.Windows.Forms.Label();
            this.dtHDNgayKy = new System.Windows.Forms.DateTimePicker();
            this.lblHDBatDau = new System.Windows.Forms.Label();
            this.dtHDBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblHDKetThuc = new System.Windows.Forms.Label();
            this.dtHDKetThuc = new System.Windows.Forms.DateTimePicker();
            this.chkHDKhongThoiHan = new System.Windows.Forms.CheckBox();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.btnLamMoiHD = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.lblBHHopDong = new System.Windows.Forms.Label();
            this.cboBHHopDong = new System.Windows.Forms.ComboBox();
            this.lblBHNhanVien = new System.Windows.Forms.Label();
            this.txtBHNhanVien = new System.Windows.Forms.TextBox();
            this.lblBHLoai = new System.Windows.Forms.Label();
            this.cboBHLoai = new System.Windows.Forms.ComboBox();
            this.lblBHSoSo = new System.Windows.Forms.Label();
            this.txtBHSoSo = new System.Windows.Forms.TextBox();
            this.lblBHNgayLap = new System.Windows.Forms.Label();
            this.dtBHNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblBHMucDong = new System.Windows.Forms.Label();
            this.numBHMucDong = new System.Windows.Forms.NumericUpDown();
            this.btnLapBH = new System.Windows.Forms.Button();
            this.btnLamMoiBH = new System.Windows.Forms.Button();
            this.dgvBH = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabHopDong.SuspendLayout();
            this.tabBaoHiem.SuspendLayout();
            this.SuspendLayout();
            // tabMain
            //
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabHopDong);
            this.tabMain.Controls.Add(this.tabBaoHiem);
            this.tabMain.Location = new System.Drawing.Point(10, 10);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(980, 542);
            this.tabMain.TabIndex = 0;
            // tabHopDong
            //
            this.tabHopDong.Controls.Add(this.lblSoHD);
            this.tabHopDong.Controls.Add(this.txtSoHD);
            this.tabHopDong.Controls.Add(this.lblHDNhanVien);
            this.tabHopDong.Controls.Add(this.cboHDNhanVien);
            this.tabHopDong.Controls.Add(this.lblHDQDTD);
            this.tabHopDong.Controls.Add(this.cboHDQDTD);
            this.tabHopDong.Controls.Add(this.lblLoaiHD);
            this.tabHopDong.Controls.Add(this.cboLoaiHD);
            this.tabHopDong.Controls.Add(this.lblHDNgayKy);
            this.tabHopDong.Controls.Add(this.dtHDNgayKy);
            this.tabHopDong.Controls.Add(this.lblHDBatDau);
            this.tabHopDong.Controls.Add(this.dtHDBatDau);
            this.tabHopDong.Controls.Add(this.lblHDKetThuc);
            this.tabHopDong.Controls.Add(this.dtHDKetThuc);
            this.tabHopDong.Controls.Add(this.chkHDKhongThoiHan);
            this.tabHopDong.Controls.Add(this.btnLapHD);
            this.tabHopDong.Controls.Add(this.btnLamMoiHD);
            this.tabHopDong.Controls.Add(this.dgvHD);
            this.tabHopDong.Location = new System.Drawing.Point(4, 24);
            this.tabHopDong.Name = "tabHopDong";
            this.tabHopDong.Padding = new System.Windows.Forms.Padding(3);
            this.tabHopDong.Size = new System.Drawing.Size(972, 514);
            this.tabHopDong.TabIndex = 0;
            this.tabHopDong.Text = "Hợp đồng";
            this.tabHopDong.UseVisualStyleBackColor = true;
            // tabBaoHiem
            //
            this.tabBaoHiem.Controls.Add(this.lblBHHopDong);
            this.tabBaoHiem.Controls.Add(this.cboBHHopDong);
            this.tabBaoHiem.Controls.Add(this.lblBHNhanVien);
            this.tabBaoHiem.Controls.Add(this.txtBHNhanVien);
            this.tabBaoHiem.Controls.Add(this.lblBHLoai);
            this.tabBaoHiem.Controls.Add(this.cboBHLoai);
            this.tabBaoHiem.Controls.Add(this.lblBHSoSo);
            this.tabBaoHiem.Controls.Add(this.txtBHSoSo);
            this.tabBaoHiem.Controls.Add(this.lblBHNgayLap);
            this.tabBaoHiem.Controls.Add(this.dtBHNgayLap);
            this.tabBaoHiem.Controls.Add(this.lblBHMucDong);
            this.tabBaoHiem.Controls.Add(this.numBHMucDong);
            this.tabBaoHiem.Controls.Add(this.btnLapBH);
            this.tabBaoHiem.Controls.Add(this.btnLamMoiBH);
            this.tabBaoHiem.Controls.Add(this.dgvBH);
            this.tabBaoHiem.Location = new System.Drawing.Point(4, 24);
            this.tabBaoHiem.Name = "tabBaoHiem";
            this.tabBaoHiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoHiem.Size = new System.Drawing.Size(972, 514);
            this.tabBaoHiem.TabIndex = 0;
            this.tabBaoHiem.Text = "Bảo hiểm";
            this.tabBaoHiem.UseVisualStyleBackColor = true;
            // lblSoHD
            //
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(15, 18);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.TabIndex = 1;
            this.lblSoHD.Text = "Số hợp đồng:";
            // txtSoHD
            //
            this.txtSoHD.Location = new System.Drawing.Point(120, 15);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(130, 23);
            this.txtSoHD.TabIndex = 2;
            // lblHDNhanVien
            //
            this.lblHDNhanVien.AutoSize = true;
            this.lblHDNhanVien.Location = new System.Drawing.Point(255, 18);
            this.lblHDNhanVien.Name = "lblHDNhanVien";
            this.lblHDNhanVien.TabIndex = 3;
            this.lblHDNhanVien.Text = "Nhân viên:";
            // cboHDNhanVien
            //
            this.cboHDNhanVien.Location = new System.Drawing.Point(360, 15);
            this.cboHDNhanVien.Name = "cboHDNhanVien";
            this.cboHDNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDNhanVien.FormattingEnabled = true;
            this.cboHDNhanVien.Size = new System.Drawing.Size(130, 23);
            this.cboHDNhanVien.TabIndex = 4;
            // lblHDQDTD
            //
            this.lblHDQDTD.AutoSize = true;
            this.lblHDQDTD.Location = new System.Drawing.Point(495, 18);
            this.lblHDQDTD.Name = "lblHDQDTD";
            this.lblHDQDTD.TabIndex = 5;
            this.lblHDQDTD.Text = "QĐ tuyển dụng:";
            // cboHDQDTD
            //
            this.cboHDQDTD.Location = new System.Drawing.Point(600, 15);
            this.cboHDQDTD.Name = "cboHDQDTD";
            this.cboHDQDTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDQDTD.FormattingEnabled = true;
            this.cboHDQDTD.Size = new System.Drawing.Size(130, 23);
            this.cboHDQDTD.TabIndex = 6;
            // lblLoaiHD
            //
            this.lblLoaiHD.AutoSize = true;
            this.lblLoaiHD.Location = new System.Drawing.Point(735, 18);
            this.lblLoaiHD.Name = "lblLoaiHD";
            this.lblLoaiHD.TabIndex = 7;
            this.lblLoaiHD.Text = "Loại hợp đồng:";
            // cboLoaiHD
            //
            this.cboLoaiHD.Location = new System.Drawing.Point(840, 15);
            this.cboLoaiHD.Name = "cboLoaiHD";
            this.cboLoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHD.FormattingEnabled = true;
            this.cboLoaiHD.Items.AddRange(new object[] {
                "Dài hạn",
    "Ngắn hạn"});
            this.cboLoaiHD.Size = new System.Drawing.Size(130, 23);
            this.cboLoaiHD.TabIndex = 8;
            // lblHDNgayKy
            //
            this.lblHDNgayKy.AutoSize = true;
            this.lblHDNgayKy.Location = new System.Drawing.Point(15, 52);
            this.lblHDNgayKy.Name = "lblHDNgayKy";
            this.lblHDNgayKy.TabIndex = 9;
            this.lblHDNgayKy.Text = "Ngày ký:";
            // dtHDNgayKy
            //
            this.dtHDNgayKy.Location = new System.Drawing.Point(120, 49);
            this.dtHDNgayKy.Name = "dtHDNgayKy";
            this.dtHDNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHDNgayKy.Size = new System.Drawing.Size(130, 23);
            this.dtHDNgayKy.TabIndex = 10;
            // lblHDBatDau
            //
            this.lblHDBatDau.AutoSize = true;
            this.lblHDBatDau.Location = new System.Drawing.Point(255, 52);
            this.lblHDBatDau.Name = "lblHDBatDau";
            this.lblHDBatDau.TabIndex = 11;
            this.lblHDBatDau.Text = "Ngày bắt đầu:";
            // dtHDBatDau
            //
            this.dtHDBatDau.Location = new System.Drawing.Point(360, 49);
            this.dtHDBatDau.Name = "dtHDBatDau";
            this.dtHDBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHDBatDau.Size = new System.Drawing.Size(130, 23);
            this.dtHDBatDau.TabIndex = 12;
            // lblHDKetThuc
            //
            this.lblHDKetThuc.AutoSize = true;
            this.lblHDKetThuc.Location = new System.Drawing.Point(495, 52);
            this.lblHDKetThuc.Name = "lblHDKetThuc";
            this.lblHDKetThuc.TabIndex = 13;
            this.lblHDKetThuc.Text = "Ngày kết thúc:";
            // dtHDKetThuc
            //
            this.dtHDKetThuc.Location = new System.Drawing.Point(600, 49);
            this.dtHDKetThuc.Name = "dtHDKetThuc";
            this.dtHDKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHDKetThuc.Size = new System.Drawing.Size(130, 23);
            this.dtHDKetThuc.TabIndex = 14;
            // chkHDKhongThoiHan
            //
            this.chkHDKhongThoiHan.Location = new System.Drawing.Point(840, 50);
            this.chkHDKhongThoiHan.Name = "chkHDKhongThoiHan";
            this.chkHDKhongThoiHan.AutoSize = true;
            this.chkHDKhongThoiHan.TabIndex = 15;
            this.chkHDKhongThoiHan.Text = "Không thời hạn";
            this.chkHDKhongThoiHan.UseVisualStyleBackColor = true;
            this.chkHDKhongThoiHan.CheckedChanged += new System.EventHandler(this.chkHDKhongThoiHan_CheckedChanged);
            // btnLapHD
            //
            this.btnLapHD.Location = new System.Drawing.Point(15, 81);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(125, 28);
            this.btnLapHD.TabIndex = 16;
            this.btnLapHD.Text = "Lập hợp đồng";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // btnLamMoiHD
            //
            this.btnLamMoiHD.Location = new System.Drawing.Point(150, 81);
            this.btnLamMoiHD.Name = "btnLamMoiHD";
            this.btnLamMoiHD.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiHD.TabIndex = 17;
            this.btnLamMoiHD.Text = "Làm mới";
            this.btnLamMoiHD.UseVisualStyleBackColor = true;
            this.btnLamMoiHD.Click += new System.EventHandler(this.btnLamMoiHD_Click);
            // dgvHD
            //
            this.dgvHD.Location = new System.Drawing.Point(15, 120);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            this.dgvHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.MultiSelect = false;
            this.dgvHD.ReadOnly = true;
            this.dgvHD.RowHeadersVisible = false;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(942, 382);
            this.dgvHD.TabIndex = 18;
            // lblBHHopDong
            //
            this.lblBHHopDong.AutoSize = true;
            this.lblBHHopDong.Location = new System.Drawing.Point(15, 18);
            this.lblBHHopDong.Name = "lblBHHopDong";
            this.lblBHHopDong.TabIndex = 19;
            this.lblBHHopDong.Text = "Hợp đồng:";
            // cboBHHopDong
            //
            this.cboBHHopDong.Location = new System.Drawing.Point(120, 15);
            this.cboBHHopDong.Name = "cboBHHopDong";
            this.cboBHHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBHHopDong.FormattingEnabled = true;
            this.cboBHHopDong.Size = new System.Drawing.Size(130, 23);
            this.cboBHHopDong.TabIndex = 20;
            this.cboBHHopDong.SelectedIndexChanged += new System.EventHandler(this.cboBHHopDong_SelectedIndexChanged);
            // lblBHNhanVien
            //
            this.lblBHNhanVien.AutoSize = true;
            this.lblBHNhanVien.Location = new System.Drawing.Point(255, 18);
            this.lblBHNhanVien.Name = "lblBHNhanVien";
            this.lblBHNhanVien.TabIndex = 21;
            this.lblBHNhanVien.Text = "Nhân viên:";
            // txtBHNhanVien
            //
            this.txtBHNhanVien.Location = new System.Drawing.Point(360, 15);
            this.txtBHNhanVien.Name = "txtBHNhanVien";
            this.txtBHNhanVien.Size = new System.Drawing.Size(130, 23);
            this.txtBHNhanVien.ReadOnly = true;
            this.txtBHNhanVien.TabIndex = 22;
            // lblBHLoai
            //
            this.lblBHLoai.AutoSize = true;
            this.lblBHLoai.Location = new System.Drawing.Point(495, 18);
            this.lblBHLoai.Name = "lblBHLoai";
            this.lblBHLoai.TabIndex = 23;
            this.lblBHLoai.Text = "Loại bảo hiểm:";
            // cboBHLoai
            //
            this.cboBHLoai.Location = new System.Drawing.Point(600, 15);
            this.cboBHLoai.Name = "cboBHLoai";
            this.cboBHLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBHLoai.FormattingEnabled = true;
            this.cboBHLoai.Items.AddRange(new object[] {
                "BHYT",
    "BHXH"});
            this.cboBHLoai.Size = new System.Drawing.Size(130, 23);
            this.cboBHLoai.TabIndex = 24;
            // lblBHSoSo
            //
            this.lblBHSoSo.AutoSize = true;
            this.lblBHSoSo.Location = new System.Drawing.Point(735, 18);
            this.lblBHSoSo.Name = "lblBHSoSo";
            this.lblBHSoSo.TabIndex = 25;
            this.lblBHSoSo.Text = "Số sổ BH:";
            // txtBHSoSo
            //
            this.txtBHSoSo.Location = new System.Drawing.Point(840, 15);
            this.txtBHSoSo.Name = "txtBHSoSo";
            this.txtBHSoSo.Size = new System.Drawing.Size(130, 23);
            this.txtBHSoSo.TabIndex = 26;
            // lblBHNgayLap
            //
            this.lblBHNgayLap.AutoSize = true;
            this.lblBHNgayLap.Location = new System.Drawing.Point(15, 52);
            this.lblBHNgayLap.Name = "lblBHNgayLap";
            this.lblBHNgayLap.TabIndex = 27;
            this.lblBHNgayLap.Text = "Ngày lập:";
            // dtBHNgayLap
            //
            this.dtBHNgayLap.Location = new System.Drawing.Point(120, 49);
            this.dtBHNgayLap.Name = "dtBHNgayLap";
            this.dtBHNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBHNgayLap.Size = new System.Drawing.Size(130, 23);
            this.dtBHNgayLap.TabIndex = 28;
            // lblBHMucDong
            //
            this.lblBHMucDong.AutoSize = true;
            this.lblBHMucDong.Location = new System.Drawing.Point(255, 52);
            this.lblBHMucDong.Name = "lblBHMucDong";
            this.lblBHMucDong.TabIndex = 29;
            this.lblBHMucDong.Text = "Mức đóng (%):";
            // numBHMucDong
            //
            this.numBHMucDong.Location = new System.Drawing.Point(360, 49);
            this.numBHMucDong.Name = "numBHMucDong";
            this.numBHMucDong.DecimalPlaces = 2;
            this.numBHMucDong.Increment = new decimal(new int[] {5, 0, 0, 65536});
            this.numBHMucDong.Maximum = new decimal(new int[] {100, 0, 0, 0});
            this.numBHMucDong.Size = new System.Drawing.Size(130, 23);
            this.numBHMucDong.TabIndex = 30;
            // btnLapBH
            //
            this.btnLapBH.Location = new System.Drawing.Point(495, 47);
            this.btnLapBH.Name = "btnLapBH";
            this.btnLapBH.Size = new System.Drawing.Size(105, 28);
            this.btnLapBH.TabIndex = 31;
            this.btnLapBH.Text = "Lập hồ sơ";
            this.btnLapBH.UseVisualStyleBackColor = true;
            this.btnLapBH.Click += new System.EventHandler(this.btnLapBH_Click);
            // btnLamMoiBH
            //
            this.btnLamMoiBH.Location = new System.Drawing.Point(610, 47);
            this.btnLamMoiBH.Name = "btnLamMoiBH";
            this.btnLamMoiBH.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiBH.TabIndex = 32;
            this.btnLamMoiBH.Text = "Làm mới";
            this.btnLamMoiBH.UseVisualStyleBackColor = true;
            this.btnLamMoiBH.Click += new System.EventHandler(this.btnLamMoiBH_Click);
            // dgvBH
            //
            this.dgvBH.Location = new System.Drawing.Point(15, 85);
            this.dgvBH.Name = "dgvBH";
            this.dgvBH.AllowUserToAddRows = false;
            this.dgvBH.AllowUserToDeleteRows = false;
            this.dgvBH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBH.MultiSelect = false;
            this.dgvBH.ReadOnly = true;
            this.dgvBH.RowHeadersVisible = false;
            this.dgvBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBH.Size = new System.Drawing.Size(942, 417);
            this.dgvBH.TabIndex = 33;
            // btnDong
            //
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(880, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // FrmHopDong
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hợp đồng - Bảo hiểm";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).EndInit();
            this.tabHopDong.ResumeLayout(false);
            this.tabBaoHiem.ResumeLayout(false);
            this.tabHopDong.PerformLayout();
            this.tabBaoHiem.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabHopDong;
        private System.Windows.Forms.TabPage tabBaoHiem;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblHDNhanVien;
        private System.Windows.Forms.ComboBox cboHDNhanVien;
        private System.Windows.Forms.Label lblHDQDTD;
        private System.Windows.Forms.ComboBox cboHDQDTD;
        private System.Windows.Forms.Label lblLoaiHD;
        private System.Windows.Forms.ComboBox cboLoaiHD;
        private System.Windows.Forms.Label lblHDNgayKy;
        private System.Windows.Forms.DateTimePicker dtHDNgayKy;
        private System.Windows.Forms.Label lblHDBatDau;
        private System.Windows.Forms.DateTimePicker dtHDBatDau;
        private System.Windows.Forms.Label lblHDKetThuc;
        private System.Windows.Forms.DateTimePicker dtHDKetThuc;
        private System.Windows.Forms.CheckBox chkHDKhongThoiHan;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.Button btnLamMoiHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Label lblBHHopDong;
        private System.Windows.Forms.ComboBox cboBHHopDong;
        private System.Windows.Forms.Label lblBHNhanVien;
        private System.Windows.Forms.TextBox txtBHNhanVien;
        private System.Windows.Forms.Label lblBHLoai;
        private System.Windows.Forms.ComboBox cboBHLoai;
        private System.Windows.Forms.Label lblBHSoSo;
        private System.Windows.Forms.TextBox txtBHSoSo;
        private System.Windows.Forms.Label lblBHNgayLap;
        private System.Windows.Forms.DateTimePicker dtBHNgayLap;
        private System.Windows.Forms.Label lblBHMucDong;
        private System.Windows.Forms.NumericUpDown numBHMucDong;
        private System.Windows.Forms.Button btnLapBH;
        private System.Windows.Forms.Button btnLamMoiBH;
        private System.Windows.Forms.DataGridView dgvBH;
        private System.Windows.Forms.Button btnDong;
    }
}