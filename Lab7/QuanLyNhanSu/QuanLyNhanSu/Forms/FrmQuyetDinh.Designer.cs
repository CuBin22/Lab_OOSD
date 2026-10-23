namespace QuanLyNhanSu.Forms
{
    partial class FrmQuyetDinh
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
            this.tabChucVu = new System.Windows.Forms.TabPage();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.lblSoQDCV = new System.Windows.Forms.Label();
            this.txtSoQDCV = new System.Windows.Forms.TextBox();
            this.lblCVNhanVien = new System.Windows.Forms.Label();
            this.cboCVNhanVien = new System.Windows.Forms.ComboBox();
            this.lblCVChucVu = new System.Windows.Forms.Label();
            this.txtCVChucVu = new System.Windows.Forms.TextBox();
            this.lblCVPhuCap = new System.Windows.Forms.Label();
            this.numCVPhuCap = new System.Windows.Forms.NumericUpDown();
            this.lblCVHieuLuc = new System.Windows.Forms.Label();
            this.dtCVHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.lblCVNguoiKy = new System.Windows.Forms.Label();
            this.cboCVNguoiKy = new System.Windows.Forms.ComboBox();
            this.btnLapCV = new System.Windows.Forms.Button();
            this.btnLamMoiCV = new System.Windows.Forms.Button();
            this.dgvCV = new System.Windows.Forms.DataGridView();
            this.lblSoQDL = new System.Windows.Forms.Label();
            this.txtSoQDL = new System.Windows.Forms.TextBox();
            this.lblLNhanVien = new System.Windows.Forms.Label();
            this.cboLNhanVien = new System.Windows.Forms.ComboBox();
            this.lblLCoBan = new System.Windows.Forms.Label();
            this.numLCoBan = new System.Windows.Forms.NumericUpDown();
            this.lblLPhuCap = new System.Windows.Forms.Label();
            this.numLPhuCap = new System.Windows.Forms.NumericUpDown();
            this.lblLDocHai = new System.Windows.Forms.Label();
            this.numLDocHai = new System.Windows.Forms.NumericUpDown();
            this.lblLHieuLuc = new System.Windows.Forms.Label();
            this.dtLHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.lblLNguoiKy = new System.Windows.Forms.Label();
            this.cboLNguoiKy = new System.Windows.Forms.ComboBox();
            this.btnLapL = new System.Windows.Forms.Button();
            this.btnLamMoiL = new System.Windows.Forms.Button();
            this.dgvL = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabChucVu.SuspendLayout();
            this.tabLuong.SuspendLayout();
            this.SuspendLayout();
            // tabMain
            //
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabChucVu);
            this.tabMain.Controls.Add(this.tabLuong);
            this.tabMain.Location = new System.Drawing.Point(10, 10);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(980, 542);
            this.tabMain.TabIndex = 0;
            // tabChucVu
            //
            this.tabChucVu.Controls.Add(this.lblSoQDCV);
            this.tabChucVu.Controls.Add(this.txtSoQDCV);
            this.tabChucVu.Controls.Add(this.lblCVNhanVien);
            this.tabChucVu.Controls.Add(this.cboCVNhanVien);
            this.tabChucVu.Controls.Add(this.lblCVChucVu);
            this.tabChucVu.Controls.Add(this.txtCVChucVu);
            this.tabChucVu.Controls.Add(this.lblCVPhuCap);
            this.tabChucVu.Controls.Add(this.numCVPhuCap);
            this.tabChucVu.Controls.Add(this.lblCVHieuLuc);
            this.tabChucVu.Controls.Add(this.dtCVHieuLuc);
            this.tabChucVu.Controls.Add(this.lblCVNguoiKy);
            this.tabChucVu.Controls.Add(this.cboCVNguoiKy);
            this.tabChucVu.Controls.Add(this.btnLapCV);
            this.tabChucVu.Controls.Add(this.btnLamMoiCV);
            this.tabChucVu.Controls.Add(this.dgvCV);
            this.tabChucVu.Location = new System.Drawing.Point(4, 24);
            this.tabChucVu.Name = "tabChucVu";
            this.tabChucVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabChucVu.Size = new System.Drawing.Size(972, 514);
            this.tabChucVu.TabIndex = 0;
            this.tabChucVu.Text = "Quyết định chức vụ";
            this.tabChucVu.UseVisualStyleBackColor = true;
            // tabLuong
            //
            this.tabLuong.Controls.Add(this.lblSoQDL);
            this.tabLuong.Controls.Add(this.txtSoQDL);
            this.tabLuong.Controls.Add(this.lblLNhanVien);
            this.tabLuong.Controls.Add(this.cboLNhanVien);
            this.tabLuong.Controls.Add(this.lblLCoBan);
            this.tabLuong.Controls.Add(this.numLCoBan);
            this.tabLuong.Controls.Add(this.lblLPhuCap);
            this.tabLuong.Controls.Add(this.numLPhuCap);
            this.tabLuong.Controls.Add(this.lblLDocHai);
            this.tabLuong.Controls.Add(this.numLDocHai);
            this.tabLuong.Controls.Add(this.lblLHieuLuc);
            this.tabLuong.Controls.Add(this.dtLHieuLuc);
            this.tabLuong.Controls.Add(this.lblLNguoiKy);
            this.tabLuong.Controls.Add(this.cboLNguoiKy);
            this.tabLuong.Controls.Add(this.btnLapL);
            this.tabLuong.Controls.Add(this.btnLamMoiL);
            this.tabLuong.Controls.Add(this.dgvL);
            this.tabLuong.Location = new System.Drawing.Point(4, 24);
            this.tabLuong.Name = "tabLuong";
            this.tabLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuong.Size = new System.Drawing.Size(972, 514);
            this.tabLuong.TabIndex = 0;
            this.tabLuong.Text = "Quyết định lương";
            this.tabLuong.UseVisualStyleBackColor = true;
            // lblSoQDCV
            //
            this.lblSoQDCV.AutoSize = true;
            this.lblSoQDCV.Location = new System.Drawing.Point(15, 18);
            this.lblSoQDCV.Name = "lblSoQDCV";
            this.lblSoQDCV.TabIndex = 1;
            this.lblSoQDCV.Text = "Số QĐ:";
            // txtSoQDCV
            //
            this.txtSoQDCV.Location = new System.Drawing.Point(120, 15);
            this.txtSoQDCV.Name = "txtSoQDCV";
            this.txtSoQDCV.Size = new System.Drawing.Size(130, 23);
            this.txtSoQDCV.TabIndex = 2;
            // lblCVNhanVien
            //
            this.lblCVNhanVien.AutoSize = true;
            this.lblCVNhanVien.Location = new System.Drawing.Point(255, 18);
            this.lblCVNhanVien.Name = "lblCVNhanVien";
            this.lblCVNhanVien.TabIndex = 3;
            this.lblCVNhanVien.Text = "Nhân viên:";
            // cboCVNhanVien
            //
            this.cboCVNhanVien.Location = new System.Drawing.Point(360, 15);
            this.cboCVNhanVien.Name = "cboCVNhanVien";
            this.cboCVNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCVNhanVien.FormattingEnabled = true;
            this.cboCVNhanVien.Size = new System.Drawing.Size(130, 23);
            this.cboCVNhanVien.TabIndex = 4;
            // lblCVChucVu
            //
            this.lblCVChucVu.AutoSize = true;
            this.lblCVChucVu.Location = new System.Drawing.Point(495, 18);
            this.lblCVChucVu.Name = "lblCVChucVu";
            this.lblCVChucVu.TabIndex = 5;
            this.lblCVChucVu.Text = "Chức vụ:";
            // txtCVChucVu
            //
            this.txtCVChucVu.Location = new System.Drawing.Point(600, 15);
            this.txtCVChucVu.Name = "txtCVChucVu";
            this.txtCVChucVu.Size = new System.Drawing.Size(130, 23);
            this.txtCVChucVu.TabIndex = 6;
            // lblCVPhuCap
            //
            this.lblCVPhuCap.AutoSize = true;
            this.lblCVPhuCap.Location = new System.Drawing.Point(735, 18);
            this.lblCVPhuCap.Name = "lblCVPhuCap";
            this.lblCVPhuCap.TabIndex = 7;
            this.lblCVPhuCap.Text = "Phụ cấp chức vụ:";
            // numCVPhuCap
            //
            this.numCVPhuCap.Location = new System.Drawing.Point(840, 15);
            this.numCVPhuCap.Name = "numCVPhuCap";
            this.numCVPhuCap.Maximum = new decimal(new int[] {999999999, 0, 0, 0});
            this.numCVPhuCap.Size = new System.Drawing.Size(130, 23);
            this.numCVPhuCap.ThousandsSeparator = true;
            this.numCVPhuCap.TabIndex = 8;
            // lblCVHieuLuc
            //
            this.lblCVHieuLuc.AutoSize = true;
            this.lblCVHieuLuc.Location = new System.Drawing.Point(15, 52);
            this.lblCVHieuLuc.Name = "lblCVHieuLuc";
            this.lblCVHieuLuc.TabIndex = 9;
            this.lblCVHieuLuc.Text = "Ngày hiệu lực:";
            // dtCVHieuLuc
            //
            this.dtCVHieuLuc.Location = new System.Drawing.Point(120, 49);
            this.dtCVHieuLuc.Name = "dtCVHieuLuc";
            this.dtCVHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCVHieuLuc.Size = new System.Drawing.Size(130, 23);
            this.dtCVHieuLuc.TabIndex = 10;
            // lblCVNguoiKy
            //
            this.lblCVNguoiKy.AutoSize = true;
            this.lblCVNguoiKy.Location = new System.Drawing.Point(255, 52);
            this.lblCVNguoiKy.Name = "lblCVNguoiKy";
            this.lblCVNguoiKy.TabIndex = 11;
            this.lblCVNguoiKy.Text = "Người ký:";
            // cboCVNguoiKy
            //
            this.cboCVNguoiKy.Location = new System.Drawing.Point(360, 49);
            this.cboCVNguoiKy.Name = "cboCVNguoiKy";
            this.cboCVNguoiKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCVNguoiKy.FormattingEnabled = true;
            this.cboCVNguoiKy.Size = new System.Drawing.Size(130, 23);
            this.cboCVNguoiKy.TabIndex = 12;
            // btnLapCV
            //
            this.btnLapCV.Location = new System.Drawing.Point(495, 47);
            this.btnLapCV.Name = "btnLapCV";
            this.btnLapCV.Size = new System.Drawing.Size(125, 28);
            this.btnLapCV.TabIndex = 13;
            this.btnLapCV.Text = "Lập quyết định";
            this.btnLapCV.UseVisualStyleBackColor = true;
            this.btnLapCV.Click += new System.EventHandler(this.btnLapCV_Click);
            // btnLamMoiCV
            //
            this.btnLamMoiCV.Location = new System.Drawing.Point(630, 47);
            this.btnLamMoiCV.Name = "btnLamMoiCV";
            this.btnLamMoiCV.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiCV.TabIndex = 14;
            this.btnLamMoiCV.Text = "Làm mới";
            this.btnLamMoiCV.UseVisualStyleBackColor = true;
            this.btnLamMoiCV.Click += new System.EventHandler(this.btnLamMoiCV_Click);
            // dgvCV
            //
            this.dgvCV.Location = new System.Drawing.Point(15, 85);
            this.dgvCV.Name = "dgvCV";
            this.dgvCV.AllowUserToAddRows = false;
            this.dgvCV.AllowUserToDeleteRows = false;
            this.dgvCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCV.MultiSelect = false;
            this.dgvCV.ReadOnly = true;
            this.dgvCV.RowHeadersVisible = false;
            this.dgvCV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCV.Size = new System.Drawing.Size(942, 417);
            this.dgvCV.TabIndex = 15;
            // lblSoQDL
            //
            this.lblSoQDL.AutoSize = true;
            this.lblSoQDL.Location = new System.Drawing.Point(15, 18);
            this.lblSoQDL.Name = "lblSoQDL";
            this.lblSoQDL.TabIndex = 16;
            this.lblSoQDL.Text = "Số QĐ:";
            // txtSoQDL
            //
            this.txtSoQDL.Location = new System.Drawing.Point(120, 15);
            this.txtSoQDL.Name = "txtSoQDL";
            this.txtSoQDL.Size = new System.Drawing.Size(130, 23);
            this.txtSoQDL.TabIndex = 17;
            // lblLNhanVien
            //
            this.lblLNhanVien.AutoSize = true;
            this.lblLNhanVien.Location = new System.Drawing.Point(255, 18);
            this.lblLNhanVien.Name = "lblLNhanVien";
            this.lblLNhanVien.TabIndex = 18;
            this.lblLNhanVien.Text = "Nhân viên:";
            // cboLNhanVien
            //
            this.cboLNhanVien.Location = new System.Drawing.Point(360, 15);
            this.cboLNhanVien.Name = "cboLNhanVien";
            this.cboLNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLNhanVien.FormattingEnabled = true;
            this.cboLNhanVien.Size = new System.Drawing.Size(130, 23);
            this.cboLNhanVien.TabIndex = 19;
            // lblLCoBan
            //
            this.lblLCoBan.AutoSize = true;
            this.lblLCoBan.Location = new System.Drawing.Point(495, 18);
            this.lblLCoBan.Name = "lblLCoBan";
            this.lblLCoBan.TabIndex = 20;
            this.lblLCoBan.Text = "Lương cơ bản:";
            // numLCoBan
            //
            this.numLCoBan.Location = new System.Drawing.Point(600, 15);
            this.numLCoBan.Name = "numLCoBan";
            this.numLCoBan.Maximum = new decimal(new int[] {999999999, 0, 0, 0});
            this.numLCoBan.Size = new System.Drawing.Size(130, 23);
            this.numLCoBan.ThousandsSeparator = true;
            this.numLCoBan.TabIndex = 21;
            // lblLPhuCap
            //
            this.lblLPhuCap.AutoSize = true;
            this.lblLPhuCap.Location = new System.Drawing.Point(735, 18);
            this.lblLPhuCap.Name = "lblLPhuCap";
            this.lblLPhuCap.TabIndex = 22;
            this.lblLPhuCap.Text = "Phụ cấp lương:";
            // numLPhuCap
            //
            this.numLPhuCap.Location = new System.Drawing.Point(840, 15);
            this.numLPhuCap.Name = "numLPhuCap";
            this.numLPhuCap.Maximum = new decimal(new int[] {999999999, 0, 0, 0});
            this.numLPhuCap.Size = new System.Drawing.Size(130, 23);
            this.numLPhuCap.ThousandsSeparator = true;
            this.numLPhuCap.TabIndex = 23;
            // lblLDocHai
            //
            this.lblLDocHai.AutoSize = true;
            this.lblLDocHai.Location = new System.Drawing.Point(15, 52);
            this.lblLDocHai.Name = "lblLDocHai";
            this.lblLDocHai.TabIndex = 24;
            this.lblLDocHai.Text = "Phụ cấp độc hại:";
            // numLDocHai
            //
            this.numLDocHai.Location = new System.Drawing.Point(120, 49);
            this.numLDocHai.Name = "numLDocHai";
            this.numLDocHai.Maximum = new decimal(new int[] {999999999, 0, 0, 0});
            this.numLDocHai.Size = new System.Drawing.Size(130, 23);
            this.numLDocHai.ThousandsSeparator = true;
            this.numLDocHai.TabIndex = 25;
            // lblLHieuLuc
            //
            this.lblLHieuLuc.AutoSize = true;
            this.lblLHieuLuc.Location = new System.Drawing.Point(255, 52);
            this.lblLHieuLuc.Name = "lblLHieuLuc";
            this.lblLHieuLuc.TabIndex = 26;
            this.lblLHieuLuc.Text = "Ngày hiệu lực:";
            // dtLHieuLuc
            //
            this.dtLHieuLuc.Location = new System.Drawing.Point(360, 49);
            this.dtLHieuLuc.Name = "dtLHieuLuc";
            this.dtLHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLHieuLuc.Size = new System.Drawing.Size(130, 23);
            this.dtLHieuLuc.TabIndex = 27;
            // lblLNguoiKy
            //
            this.lblLNguoiKy.AutoSize = true;
            this.lblLNguoiKy.Location = new System.Drawing.Point(495, 52);
            this.lblLNguoiKy.Name = "lblLNguoiKy";
            this.lblLNguoiKy.TabIndex = 28;
            this.lblLNguoiKy.Text = "Người ký:";
            // cboLNguoiKy
            //
            this.cboLNguoiKy.Location = new System.Drawing.Point(600, 49);
            this.cboLNguoiKy.Name = "cboLNguoiKy";
            this.cboLNguoiKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLNguoiKy.FormattingEnabled = true;
            this.cboLNguoiKy.Size = new System.Drawing.Size(130, 23);
            this.cboLNguoiKy.TabIndex = 29;
            // btnLapL
            //
            this.btnLapL.Location = new System.Drawing.Point(15, 81);
            this.btnLapL.Name = "btnLapL";
            this.btnLapL.Size = new System.Drawing.Size(125, 28);
            this.btnLapL.TabIndex = 30;
            this.btnLapL.Text = "Lập quyết định";
            this.btnLapL.UseVisualStyleBackColor = true;
            this.btnLapL.Click += new System.EventHandler(this.btnLapL_Click);
            // btnLamMoiL
            //
            this.btnLamMoiL.Location = new System.Drawing.Point(150, 81);
            this.btnLamMoiL.Name = "btnLamMoiL";
            this.btnLamMoiL.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiL.TabIndex = 31;
            this.btnLamMoiL.Text = "Làm mới";
            this.btnLamMoiL.UseVisualStyleBackColor = true;
            this.btnLamMoiL.Click += new System.EventHandler(this.btnLamMoiL_Click);
            // dgvL
            //
            this.dgvL.Location = new System.Drawing.Point(15, 120);
            this.dgvL.Name = "dgvL";
            this.dgvL.AllowUserToAddRows = false;
            this.dgvL.AllowUserToDeleteRows = false;
            this.dgvL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvL.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvL.MultiSelect = false;
            this.dgvL.ReadOnly = true;
            this.dgvL.RowHeadersVisible = false;
            this.dgvL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvL.Size = new System.Drawing.Size(942, 382);
            this.dgvL.TabIndex = 32;
            // btnDong
            //
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(880, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 33;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // FrmQuyetDinh
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmQuyetDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quyết định chức vụ - Quyết định lương";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvL)).EndInit();
            this.tabChucVu.ResumeLayout(false);
            this.tabLuong.ResumeLayout(false);
            this.tabChucVu.PerformLayout();
            this.tabLuong.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabChucVu;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.Label lblSoQDCV;
        private System.Windows.Forms.TextBox txtSoQDCV;
        private System.Windows.Forms.Label lblCVNhanVien;
        private System.Windows.Forms.ComboBox cboCVNhanVien;
        private System.Windows.Forms.Label lblCVChucVu;
        private System.Windows.Forms.TextBox txtCVChucVu;
        private System.Windows.Forms.Label lblCVPhuCap;
        private System.Windows.Forms.NumericUpDown numCVPhuCap;
        private System.Windows.Forms.Label lblCVHieuLuc;
        private System.Windows.Forms.DateTimePicker dtCVHieuLuc;
        private System.Windows.Forms.Label lblCVNguoiKy;
        private System.Windows.Forms.ComboBox cboCVNguoiKy;
        private System.Windows.Forms.Button btnLapCV;
        private System.Windows.Forms.Button btnLamMoiCV;
        private System.Windows.Forms.DataGridView dgvCV;
        private System.Windows.Forms.Label lblSoQDL;
        private System.Windows.Forms.TextBox txtSoQDL;
        private System.Windows.Forms.Label lblLNhanVien;
        private System.Windows.Forms.ComboBox cboLNhanVien;
        private System.Windows.Forms.Label lblLCoBan;
        private System.Windows.Forms.NumericUpDown numLCoBan;
        private System.Windows.Forms.Label lblLPhuCap;
        private System.Windows.Forms.NumericUpDown numLPhuCap;
        private System.Windows.Forms.Label lblLDocHai;
        private System.Windows.Forms.NumericUpDown numLDocHai;
        private System.Windows.Forms.Label lblLHieuLuc;
        private System.Windows.Forms.DateTimePicker dtLHieuLuc;
        private System.Windows.Forms.Label lblLNguoiKy;
        private System.Windows.Forms.ComboBox cboLNguoiKy;
        private System.Windows.Forms.Button btnLapL;
        private System.Windows.Forms.Button btnLamMoiL;
        private System.Windows.Forms.DataGridView dgvL;
        private System.Windows.Forms.Button btnDong;
    }
}