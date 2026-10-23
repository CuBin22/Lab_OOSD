namespace QuanLyNhanSu.Forms
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTongNV = new System.Windows.Forms.Label();
            this.lblThuViec = new System.Windows.Forms.Label();
            this.lblHopDong = new System.Windows.Forms.Label();
            this.lblTongThucLanh = new System.Windows.Forms.Label();
            this.lblTongThuong = new System.Windows.Forms.Label();
            this.lblTongPhat = new System.Windows.Forms.Label();
            this.lblBangLuongThang = new System.Windows.Forms.Label();
            this.lblNhanSuPhongBan = new System.Windows.Forms.Label();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // lblTu
            //
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(15, 18);
            this.lblTu.Name = "lblTu";
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // dtTu
            //
            this.dtTu.Location = new System.Drawing.Point(120, 15);
            this.dtTu.Name = "dtTu";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Size = new System.Drawing.Size(130, 23);
            this.dtTu.TabIndex = 1;
            // lblDen
            //
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(255, 18);
            this.lblDen.Name = "lblDen";
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // dtDen
            //
            this.dtDen.Location = new System.Drawing.Point(360, 15);
            this.dtDen.Name = "dtDen";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Size = new System.Drawing.Size(130, 23);
            this.dtDen.TabIndex = 3;
            // btnThongKe
            //
            this.btnThongKe.Location = new System.Drawing.Point(495, 13);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(105, 28);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // lblTongNV
            //
            this.lblTongNV.AutoSize = true;
            this.lblTongNV.Location = new System.Drawing.Point(15, 62);
            this.lblTongNV.Name = "lblTongNV";
            this.lblTongNV.TabIndex = 5;
            this.lblTongNV.Text = "Tổng nhân viên: 0";
            // lblThuViec
            //
            this.lblThuViec.AutoSize = true;
            this.lblThuViec.Location = new System.Drawing.Point(275, 62);
            this.lblThuViec.Name = "lblThuViec";
            this.lblThuViec.TabIndex = 6;
            this.lblThuViec.Text = "Đang thử việc: 0";
            // lblHopDong
            //
            this.lblHopDong.AutoSize = true;
            this.lblHopDong.Location = new System.Drawing.Point(535, 62);
            this.lblHopDong.Name = "lblHopDong";
            this.lblHopDong.TabIndex = 7;
            this.lblHopDong.Text = "Hợp đồng hiệu lực: 0";
            // lblTongThucLanh
            //
            this.lblTongThucLanh.AutoSize = true;
            this.lblTongThucLanh.Location = new System.Drawing.Point(15, 92);
            this.lblTongThucLanh.Name = "lblTongThucLanh";
            this.lblTongThucLanh.TabIndex = 8;
            this.lblTongThucLanh.Text = "Tổng thực lãnh: 0 đ";
            // lblTongThuong
            //
            this.lblTongThuong.AutoSize = true;
            this.lblTongThuong.Location = new System.Drawing.Point(275, 92);
            this.lblTongThuong.Name = "lblTongThuong";
            this.lblTongThuong.TabIndex = 9;
            this.lblTongThuong.Text = "Tổng thưởng: 0 đ";
            // lblTongPhat
            //
            this.lblTongPhat.AutoSize = true;
            this.lblTongPhat.Location = new System.Drawing.Point(535, 92);
            this.lblTongPhat.Name = "lblTongPhat";
            this.lblTongPhat.TabIndex = 10;
            this.lblTongPhat.Text = "Tổng tiền phạt: 0 đ";
            // lblBangLuongThang
            //
            this.lblBangLuongThang.AutoSize = true;
            this.lblBangLuongThang.Location = new System.Drawing.Point(15, 132);
            this.lblBangLuongThang.Name = "lblBangLuongThang";
            this.lblBangLuongThang.TabIndex = 11;
            this.lblBangLuongThang.Text = "Bảng lương theo tháng:";
            // lblNhanSuPhongBan
            //
            this.lblNhanSuPhongBan.AutoSize = true;
            this.lblNhanSuPhongBan.Location = new System.Drawing.Point(505, 132);
            this.lblNhanSuPhongBan.Name = "lblNhanSuPhongBan";
            this.lblNhanSuPhongBan.TabIndex = 12;
            this.lblNhanSuPhongBan.Text = "Nhân sự theo phòng ban:";
            // dgvTongHop
            //
            this.dgvTongHop.Location = new System.Drawing.Point(15, 155);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.AllowUserToAddRows = false;
            this.dgvTongHop.AllowUserToDeleteRows = false;
            this.dgvTongHop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongHop.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.MultiSelect = false;
            this.dgvTongHop.ReadOnly = true;
            this.dgvTongHop.RowHeadersVisible = false;
            this.dgvTongHop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTongHop.Size = new System.Drawing.Size(480, 378);
            this.dgvTongHop.TabIndex = 13;
            // dgvPhongBan
            //
            this.dgvPhongBan.Location = new System.Drawing.Point(505, 155);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.MultiSelect = false;
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.RowHeadersVisible = false;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(480, 378);
            this.dgvPhongBan.TabIndex = 14;
            // btnDong
            //
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(880, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // FrmThongKe
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblTongNV);
            this.Controls.Add(this.lblThuViec);
            this.Controls.Add(this.lblHopDong);
            this.Controls.Add(this.lblTongThucLanh);
            this.Controls.Add(this.lblTongThuong);
            this.Controls.Add(this.lblTongPhat);
            this.Controls.Add(this.lblBangLuongThang);
            this.Controls.Add(this.lblNhanSuPhongBan);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu - Thống kê nhân sự";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTongNV;
        private System.Windows.Forms.Label lblThuViec;
        private System.Windows.Forms.Label lblHopDong;
        private System.Windows.Forms.Label lblTongThucLanh;
        private System.Windows.Forms.Label lblTongThuong;
        private System.Windows.Forms.Label lblTongPhat;
        private System.Windows.Forms.Label lblBangLuongThang;
        private System.Windows.Forms.Label lblNhanSuPhongBan;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Button btnDong;
    }
}