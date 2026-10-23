namespace QuanLyNhanSu.Forms
{
    partial class FrmTuyenDung
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
            this.lblSoQDTD = new System.Windows.Forms.Label();
            this.txtSoQDTD = new System.Windows.Forms.TextBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.lblNguoiKy = new System.Windows.Forms.Label();
            this.cboNguoiKy = new System.Windows.Forms.ComboBox();
            this.lblNgayKy = new System.Windows.Forms.Label();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.lblBatDauThuViec = new System.Windows.Forms.Label();
            this.dtBatDauThuViec = new System.Windows.Forms.DateTimePicker();
            this.lblKetThucThuViec = new System.Windows.Forms.Label();
            this.dtKetThucThuViec = new System.Windows.Forms.DateTimePicker();
            this.lblLuongThuViec = new System.Windows.Forms.Label();
            this.numLuongThuViec = new System.Windows.Forms.NumericUpDown();
            this.lblDieuKhoan = new System.Windows.Forms.Label();
            this.txtDieuKhoan = new System.Windows.Forms.TextBox();
            this.btnLapQD = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvQDTD = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQDTD)).BeginInit();
            this.SuspendLayout();
            // lblSoQDTD
            //
            this.lblSoQDTD.AutoSize = true;
            this.lblSoQDTD.Location = new System.Drawing.Point(15, 18);
            this.lblSoQDTD.Name = "lblSoQDTD";
            this.lblSoQDTD.TabIndex = 0;
            this.lblSoQDTD.Text = "Số QĐ:";
            // txtSoQDTD
            //
            this.txtSoQDTD.Location = new System.Drawing.Point(120, 15);
            this.txtSoQDTD.Name = "txtSoQDTD";
            this.txtSoQDTD.Size = new System.Drawing.Size(130, 23);
            this.txtSoQDTD.TabIndex = 1;
            // lblNhanVien
            //
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(255, 18);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân viên:";
            // cboNhanVien
            //
            this.cboNhanVien.Location = new System.Drawing.Point(360, 15);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Size = new System.Drawing.Size(130, 23);
            this.cboNhanVien.TabIndex = 3;
            // lblPhongBan
            //
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(495, 18);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.TabIndex = 4;
            this.lblPhongBan.Text = "Phòng ban:";
            // cboPhongBan
            //
            this.cboPhongBan.Location = new System.Drawing.Point(600, 15);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Size = new System.Drawing.Size(130, 23);
            this.cboPhongBan.TabIndex = 5;
            // lblNguoiKy
            //
            this.lblNguoiKy.AutoSize = true;
            this.lblNguoiKy.Location = new System.Drawing.Point(735, 18);
            this.lblNguoiKy.Name = "lblNguoiKy";
            this.lblNguoiKy.TabIndex = 6;
            this.lblNguoiKy.Text = "Người ký:";
            // cboNguoiKy
            //
            this.cboNguoiKy.Location = new System.Drawing.Point(840, 15);
            this.cboNguoiKy.Name = "cboNguoiKy";
            this.cboNguoiKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiKy.FormattingEnabled = true;
            this.cboNguoiKy.Size = new System.Drawing.Size(130, 23);
            this.cboNguoiKy.TabIndex = 7;
            // lblNgayKy
            //
            this.lblNgayKy.AutoSize = true;
            this.lblNgayKy.Location = new System.Drawing.Point(15, 52);
            this.lblNgayKy.Name = "lblNgayKy";
            this.lblNgayKy.TabIndex = 8;
            this.lblNgayKy.Text = "Ngày ký:";
            // dtNgayKy
            //
            this.dtNgayKy.Location = new System.Drawing.Point(120, 49);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKy.Size = new System.Drawing.Size(130, 23);
            this.dtNgayKy.TabIndex = 9;
            // lblBatDauThuViec
            //
            this.lblBatDauThuViec.AutoSize = true;
            this.lblBatDauThuViec.Location = new System.Drawing.Point(255, 52);
            this.lblBatDauThuViec.Name = "lblBatDauThuViec";
            this.lblBatDauThuViec.TabIndex = 10;
            this.lblBatDauThuViec.Text = "Thử việc từ:";
            // dtBatDauThuViec
            //
            this.dtBatDauThuViec.Location = new System.Drawing.Point(360, 49);
            this.dtBatDauThuViec.Name = "dtBatDauThuViec";
            this.dtBatDauThuViec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBatDauThuViec.Size = new System.Drawing.Size(130, 23);
            this.dtBatDauThuViec.TabIndex = 11;
            // lblKetThucThuViec
            //
            this.lblKetThucThuViec.AutoSize = true;
            this.lblKetThucThuViec.Location = new System.Drawing.Point(495, 52);
            this.lblKetThucThuViec.Name = "lblKetThucThuViec";
            this.lblKetThucThuViec.TabIndex = 12;
            this.lblKetThucThuViec.Text = "Thử việc đến:";
            // dtKetThucThuViec
            //
            this.dtKetThucThuViec.Location = new System.Drawing.Point(600, 49);
            this.dtKetThucThuViec.Name = "dtKetThucThuViec";
            this.dtKetThucThuViec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKetThucThuViec.Size = new System.Drawing.Size(130, 23);
            this.dtKetThucThuViec.TabIndex = 13;
            // lblLuongThuViec
            //
            this.lblLuongThuViec.AutoSize = true;
            this.lblLuongThuViec.Location = new System.Drawing.Point(735, 52);
            this.lblLuongThuViec.Name = "lblLuongThuViec";
            this.lblLuongThuViec.TabIndex = 14;
            this.lblLuongThuViec.Text = "Lương thử việc:";
            // numLuongThuViec
            //
            this.numLuongThuViec.Location = new System.Drawing.Point(840, 49);
            this.numLuongThuViec.Name = "numLuongThuViec";
            this.numLuongThuViec.Maximum = new decimal(new int[] {999999999, 0, 0, 0});
            this.numLuongThuViec.Size = new System.Drawing.Size(130, 23);
            this.numLuongThuViec.ThousandsSeparator = true;
            this.numLuongThuViec.TabIndex = 15;
            // lblDieuKhoan
            //
            this.lblDieuKhoan.AutoSize = true;
            this.lblDieuKhoan.Location = new System.Drawing.Point(15, 86);
            this.lblDieuKhoan.Name = "lblDieuKhoan";
            this.lblDieuKhoan.TabIndex = 16;
            this.lblDieuKhoan.Text = "Điều khoản:";
            // txtDieuKhoan
            //
            this.txtDieuKhoan.Location = new System.Drawing.Point(120, 83);
            this.txtDieuKhoan.Name = "txtDieuKhoan";
            this.txtDieuKhoan.Size = new System.Drawing.Size(850, 56);
            this.txtDieuKhoan.Multiline = true;
            this.txtDieuKhoan.TabIndex = 17;
            // btnLapQD
            //
            this.btnLapQD.Location = new System.Drawing.Point(15, 149);
            this.btnLapQD.Name = "btnLapQD";
            this.btnLapQD.Size = new System.Drawing.Size(125, 28);
            this.btnLapQD.TabIndex = 18;
            this.btnLapQD.Text = "Lập quyết định";
            this.btnLapQD.UseVisualStyleBackColor = true;
            this.btnLapQD.Click += new System.EventHandler(this.btnLapQD_Click);
            // btnLamMoi
            //
            this.btnLamMoi.Location = new System.Drawing.Point(150, 149);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // dgvQDTD
            //
            this.dgvQDTD.Location = new System.Drawing.Point(15, 190);
            this.dgvQDTD.Name = "dgvQDTD";
            this.dgvQDTD.AllowUserToAddRows = false;
            this.dgvQDTD.AllowUserToDeleteRows = false;
            this.dgvQDTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvQDTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQDTD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvQDTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQDTD.MultiSelect = false;
            this.dgvQDTD.ReadOnly = true;
            this.dgvQDTD.RowHeadersVisible = false;
            this.dgvQDTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQDTD.Size = new System.Drawing.Size(970, 343);
            this.dgvQDTD.TabIndex = 20;
            this.dgvQDTD.SelectionChanged += new System.EventHandler(this.dgvQDTD_SelectionChanged);
            // btnDong
            //
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(880, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // FrmTuyenDung
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblSoQDTD);
            this.Controls.Add(this.txtSoQDTD);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.lblNguoiKy);
            this.Controls.Add(this.cboNguoiKy);
            this.Controls.Add(this.lblNgayKy);
            this.Controls.Add(this.dtNgayKy);
            this.Controls.Add(this.lblBatDauThuViec);
            this.Controls.Add(this.dtBatDauThuViec);
            this.Controls.Add(this.lblKetThucThuViec);
            this.Controls.Add(this.dtKetThucThuViec);
            this.Controls.Add(this.lblLuongThuViec);
            this.Controls.Add(this.numLuongThuViec);
            this.Controls.Add(this.lblDieuKhoan);
            this.Controls.Add(this.txtDieuKhoan);
            this.Controls.Add(this.btnLapQD);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvQDTD);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmTuyenDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quyết định tuyển dụng - Thử việc";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQDTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSoQDTD;
        private System.Windows.Forms.TextBox txtSoQDTD;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblNguoiKy;
        private System.Windows.Forms.ComboBox cboNguoiKy;
        private System.Windows.Forms.Label lblNgayKy;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private System.Windows.Forms.Label lblBatDauThuViec;
        private System.Windows.Forms.DateTimePicker dtBatDauThuViec;
        private System.Windows.Forms.Label lblKetThucThuViec;
        private System.Windows.Forms.DateTimePicker dtKetThucThuViec;
        private System.Windows.Forms.Label lblLuongThuViec;
        private System.Windows.Forms.NumericUpDown numLuongThuViec;
        private System.Windows.Forms.Label lblDieuKhoan;
        private System.Windows.Forms.TextBox txtDieuKhoan;
        private System.Windows.Forms.Button btnLapQD;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvQDTD;
        private System.Windows.Forms.Button btnDong;
    }
}