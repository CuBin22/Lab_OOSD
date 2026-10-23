namespace QuanLyNhanSu.Forms
{
    partial class FrmBangLuong
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
            this.lblSoBL = new System.Windows.Forms.Label();
            this.txtSoBL = new System.Windows.Forms.TextBox();
            this.lblBLNhanVien = new System.Windows.Forms.Label();
            this.cboBLNhanVien = new System.Windows.Forms.ComboBox();
            this.lblBLThang = new System.Windows.Forms.Label();
            this.numBLThang = new System.Windows.Forms.NumericUpDown();
            this.lblBLNam = new System.Windows.Forms.Label();
            this.numBLNam = new System.Windows.Forms.NumericUpDown();
            this.lblBLLuongCoBan = new System.Windows.Forms.Label();
            this.txtBLLuongCoBan = new System.Windows.Forms.TextBox();
            this.lblBLPhuCap = new System.Windows.Forms.Label();
            this.txtBLPhuCap = new System.Windows.Forms.TextBox();
            this.lblBLPhuTroi = new System.Windows.Forms.Label();
            this.txtBLPhuTroi = new System.Windows.Forms.TextBox();
            this.lblBLThuong = new System.Windows.Forms.Label();
            this.txtBLThuong = new System.Windows.Forms.TextBox();
            this.lblBLTruBH = new System.Windows.Forms.Label();
            this.txtBLTruBH = new System.Windows.Forms.TextBox();
            this.lblBLPhat = new System.Windows.Forms.Label();
            this.txtBLPhat = new System.Windows.Forms.TextBox();
            this.lblBLThucLanh = new System.Windows.Forms.Label();
            this.txtBLThucLanh = new System.Windows.Forms.TextBox();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnLuuBL = new System.Windows.Forms.Button();
            this.btnLamMoiBL = new System.Windows.Forms.Button();
            this.dgvBL = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBL)).BeginInit();
            this.SuspendLayout();
            // lblSoBL
            //
            this.lblSoBL.AutoSize = true;
            this.lblSoBL.Location = new System.Drawing.Point(15, 18);
            this.lblSoBL.Name = "lblSoBL";
            this.lblSoBL.TabIndex = 0;
            this.lblSoBL.Text = "Số bảng lương:";
            // txtSoBL
            //
            this.txtSoBL.Location = new System.Drawing.Point(120, 15);
            this.txtSoBL.Name = "txtSoBL";
            this.txtSoBL.Size = new System.Drawing.Size(130, 23);
            this.txtSoBL.TabIndex = 1;
            // lblBLNhanVien
            //
            this.lblBLNhanVien.AutoSize = true;
            this.lblBLNhanVien.Location = new System.Drawing.Point(255, 18);
            this.lblBLNhanVien.Name = "lblBLNhanVien";
            this.lblBLNhanVien.TabIndex = 2;
            this.lblBLNhanVien.Text = "Nhân viên:";
            // cboBLNhanVien
            //
            this.cboBLNhanVien.Location = new System.Drawing.Point(360, 15);
            this.cboBLNhanVien.Name = "cboBLNhanVien";
            this.cboBLNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBLNhanVien.FormattingEnabled = true;
            this.cboBLNhanVien.Size = new System.Drawing.Size(130, 23);
            this.cboBLNhanVien.TabIndex = 3;
            // lblBLThang
            //
            this.lblBLThang.AutoSize = true;
            this.lblBLThang.Location = new System.Drawing.Point(495, 18);
            this.lblBLThang.Name = "lblBLThang";
            this.lblBLThang.TabIndex = 4;
            this.lblBLThang.Text = "Tháng:";
            // numBLThang
            //
            this.numBLThang.Location = new System.Drawing.Point(600, 15);
            this.numBLThang.Name = "numBLThang";
            this.numBLThang.Maximum = new decimal(new int[] {12, 0, 0, 0});
            this.numBLThang.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numBLThang.Size = new System.Drawing.Size(130, 23);
            this.numBLThang.TabIndex = 5;
            this.numBLThang.Value = new decimal(new int[] {1, 0, 0, 0});
            // lblBLNam
            //
            this.lblBLNam.AutoSize = true;
            this.lblBLNam.Location = new System.Drawing.Point(735, 18);
            this.lblBLNam.Name = "lblBLNam";
            this.lblBLNam.TabIndex = 6;
            this.lblBLNam.Text = "Năm:";
            // numBLNam
            //
            this.numBLNam.Location = new System.Drawing.Point(840, 15);
            this.numBLNam.Name = "numBLNam";
            this.numBLNam.Maximum = new decimal(new int[] {2100, 0, 0, 0});
            this.numBLNam.Minimum = new decimal(new int[] {2000, 0, 0, 0});
            this.numBLNam.Size = new System.Drawing.Size(130, 23);
            this.numBLNam.TabIndex = 7;
            this.numBLNam.Value = new decimal(new int[] {2026, 0, 0, 0});
            // lblBLLuongCoBan
            //
            this.lblBLLuongCoBan.AutoSize = true;
            this.lblBLLuongCoBan.Location = new System.Drawing.Point(15, 52);
            this.lblBLLuongCoBan.Name = "lblBLLuongCoBan";
            this.lblBLLuongCoBan.TabIndex = 8;
            this.lblBLLuongCoBan.Text = "Lương cơ bản:";
            // txtBLLuongCoBan
            //
            this.txtBLLuongCoBan.Location = new System.Drawing.Point(120, 49);
            this.txtBLLuongCoBan.Name = "txtBLLuongCoBan";
            this.txtBLLuongCoBan.Size = new System.Drawing.Size(130, 23);
            this.txtBLLuongCoBan.ReadOnly = true;
            this.txtBLLuongCoBan.TabIndex = 9;
            // lblBLPhuCap
            //
            this.lblBLPhuCap.AutoSize = true;
            this.lblBLPhuCap.Location = new System.Drawing.Point(255, 52);
            this.lblBLPhuCap.Name = "lblBLPhuCap";
            this.lblBLPhuCap.TabIndex = 10;
            this.lblBLPhuCap.Text = "Phụ cấp:";
            // txtBLPhuCap
            //
            this.txtBLPhuCap.Location = new System.Drawing.Point(360, 49);
            this.txtBLPhuCap.Name = "txtBLPhuCap";
            this.txtBLPhuCap.Size = new System.Drawing.Size(130, 23);
            this.txtBLPhuCap.ReadOnly = true;
            this.txtBLPhuCap.TabIndex = 11;
            // lblBLPhuTroi
            //
            this.lblBLPhuTroi.AutoSize = true;
            this.lblBLPhuTroi.Location = new System.Drawing.Point(495, 52);
            this.lblBLPhuTroi.Name = "lblBLPhuTroi";
            this.lblBLPhuTroi.TabIndex = 12;
            this.lblBLPhuTroi.Text = "Tiền phụ trội:";
            // txtBLPhuTroi
            //
            this.txtBLPhuTroi.Location = new System.Drawing.Point(600, 49);
            this.txtBLPhuTroi.Name = "txtBLPhuTroi";
            this.txtBLPhuTroi.Size = new System.Drawing.Size(130, 23);
            this.txtBLPhuTroi.ReadOnly = true;
            this.txtBLPhuTroi.TabIndex = 13;
            // lblBLThuong
            //
            this.lblBLThuong.AutoSize = true;
            this.lblBLThuong.Location = new System.Drawing.Point(735, 52);
            this.lblBLThuong.Name = "lblBLThuong";
            this.lblBLThuong.TabIndex = 14;
            this.lblBLThuong.Text = "Tiền thưởng:";
            // txtBLThuong
            //
            this.txtBLThuong.Location = new System.Drawing.Point(840, 49);
            this.txtBLThuong.Name = "txtBLThuong";
            this.txtBLThuong.Size = new System.Drawing.Size(130, 23);
            this.txtBLThuong.ReadOnly = true;
            this.txtBLThuong.TabIndex = 15;
            // lblBLTruBH
            //
            this.lblBLTruBH.AutoSize = true;
            this.lblBLTruBH.Location = new System.Drawing.Point(15, 86);
            this.lblBLTruBH.Name = "lblBLTruBH";
            this.lblBLTruBH.TabIndex = 16;
            this.lblBLTruBH.Text = "Trừ bảo hiểm:";
            // txtBLTruBH
            //
            this.txtBLTruBH.Location = new System.Drawing.Point(120, 83);
            this.txtBLTruBH.Name = "txtBLTruBH";
            this.txtBLTruBH.Size = new System.Drawing.Size(130, 23);
            this.txtBLTruBH.ReadOnly = true;
            this.txtBLTruBH.TabIndex = 17;
            // lblBLPhat
            //
            this.lblBLPhat.AutoSize = true;
            this.lblBLPhat.Location = new System.Drawing.Point(255, 86);
            this.lblBLPhat.Name = "lblBLPhat";
            this.lblBLPhat.TabIndex = 18;
            this.lblBLPhat.Text = "Tiền phạt:";
            // txtBLPhat
            //
            this.txtBLPhat.Location = new System.Drawing.Point(360, 83);
            this.txtBLPhat.Name = "txtBLPhat";
            this.txtBLPhat.Size = new System.Drawing.Size(130, 23);
            this.txtBLPhat.ReadOnly = true;
            this.txtBLPhat.TabIndex = 19;
            // lblBLThucLanh
            //
            this.lblBLThucLanh.AutoSize = true;
            this.lblBLThucLanh.Location = new System.Drawing.Point(495, 86);
            this.lblBLThucLanh.Name = "lblBLThucLanh";
            this.lblBLThucLanh.TabIndex = 20;
            this.lblBLThucLanh.Text = "Thực lãnh:";
            // txtBLThucLanh
            //
            this.txtBLThucLanh.Location = new System.Drawing.Point(600, 83);
            this.txtBLThucLanh.Name = "txtBLThucLanh";
            this.txtBLThucLanh.Size = new System.Drawing.Size(130, 23);
            this.txtBLThucLanh.ReadOnly = true;
            this.txtBLThucLanh.TabIndex = 21;
            // btnTinhLuong
            //
            this.btnTinhLuong.Location = new System.Drawing.Point(15, 115);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(105, 28);
            this.btnTinhLuong.TabIndex = 22;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // btnLuuBL
            //
            this.btnLuuBL.Location = new System.Drawing.Point(130, 115);
            this.btnLuuBL.Name = "btnLuuBL";
            this.btnLuuBL.Size = new System.Drawing.Size(125, 28);
            this.btnLuuBL.TabIndex = 23;
            this.btnLuuBL.Text = "Lưu bảng lương";
            this.btnLuuBL.UseVisualStyleBackColor = true;
            this.btnLuuBL.Click += new System.EventHandler(this.btnLuuBL_Click);
            // btnLamMoiBL
            //
            this.btnLamMoiBL.Location = new System.Drawing.Point(265, 115);
            this.btnLamMoiBL.Name = "btnLamMoiBL";
            this.btnLamMoiBL.Size = new System.Drawing.Size(105, 28);
            this.btnLamMoiBL.TabIndex = 24;
            this.btnLamMoiBL.Text = "Làm mới";
            this.btnLamMoiBL.UseVisualStyleBackColor = true;
            this.btnLamMoiBL.Click += new System.EventHandler(this.btnLamMoiBL_Click);
            // dgvBL
            //
            this.dgvBL.Location = new System.Drawing.Point(15, 155);
            this.dgvBL.Name = "dgvBL";
            this.dgvBL.AllowUserToAddRows = false;
            this.dgvBL.AllowUserToDeleteRows = false;
            this.dgvBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBL.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBL.MultiSelect = false;
            this.dgvBL.ReadOnly = true;
            this.dgvBL.RowHeadersVisible = false;
            this.dgvBL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBL.Size = new System.Drawing.Size(970, 378);
            this.dgvBL.TabIndex = 25;
            this.dgvBL.SelectionChanged += new System.EventHandler(this.dgvBL_SelectionChanged);
            // btnDong
            //
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(880, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 26;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // FrmBangLuong
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblSoBL);
            this.Controls.Add(this.txtSoBL);
            this.Controls.Add(this.lblBLNhanVien);
            this.Controls.Add(this.cboBLNhanVien);
            this.Controls.Add(this.lblBLThang);
            this.Controls.Add(this.numBLThang);
            this.Controls.Add(this.lblBLNam);
            this.Controls.Add(this.numBLNam);
            this.Controls.Add(this.lblBLLuongCoBan);
            this.Controls.Add(this.txtBLLuongCoBan);
            this.Controls.Add(this.lblBLPhuCap);
            this.Controls.Add(this.txtBLPhuCap);
            this.Controls.Add(this.lblBLPhuTroi);
            this.Controls.Add(this.txtBLPhuTroi);
            this.Controls.Add(this.lblBLThuong);
            this.Controls.Add(this.txtBLThuong);
            this.Controls.Add(this.lblBLTruBH);
            this.Controls.Add(this.txtBLTruBH);
            this.Controls.Add(this.lblBLPhat);
            this.Controls.Add(this.txtBLPhat);
            this.Controls.Add(this.lblBLThucLanh);
            this.Controls.Add(this.txtBLThucLanh);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnLuuBL);
            this.Controls.Add(this.btnLamMoiBL);
            this.Controls.Add(this.dgvBL);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương hằng tháng";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSoBL;
        private System.Windows.Forms.TextBox txtSoBL;
        private System.Windows.Forms.Label lblBLNhanVien;
        private System.Windows.Forms.ComboBox cboBLNhanVien;
        private System.Windows.Forms.Label lblBLThang;
        private System.Windows.Forms.NumericUpDown numBLThang;
        private System.Windows.Forms.Label lblBLNam;
        private System.Windows.Forms.NumericUpDown numBLNam;
        private System.Windows.Forms.Label lblBLLuongCoBan;
        private System.Windows.Forms.TextBox txtBLLuongCoBan;
        private System.Windows.Forms.Label lblBLPhuCap;
        private System.Windows.Forms.TextBox txtBLPhuCap;
        private System.Windows.Forms.Label lblBLPhuTroi;
        private System.Windows.Forms.TextBox txtBLPhuTroi;
        private System.Windows.Forms.Label lblBLThuong;
        private System.Windows.Forms.TextBox txtBLThuong;
        private System.Windows.Forms.Label lblBLTruBH;
        private System.Windows.Forms.TextBox txtBLTruBH;
        private System.Windows.Forms.Label lblBLPhat;
        private System.Windows.Forms.TextBox txtBLPhat;
        private System.Windows.Forms.Label lblBLThucLanh;
        private System.Windows.Forms.TextBox txtBLThucLanh;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnLuuBL;
        private System.Windows.Forms.Button btnLamMoiBL;
        private System.Windows.Forms.DataGridView dgvBL;
        private System.Windows.Forms.Button btnDong;
    }
}