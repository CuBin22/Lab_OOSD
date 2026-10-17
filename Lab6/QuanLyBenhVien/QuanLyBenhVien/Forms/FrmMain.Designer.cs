namespace QuanLyBenhVien.Forms
{
    partial class FrmMain
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnKhamDinhKy = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.btnDoiNguoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Location = new System.Drawing.Point(0, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(800, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN";
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.AutoSize = false;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(60, 110);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(200, 60);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(300, 110);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(200, 60);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký - Hồ sơ";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.Location = new System.Drawing.Point(540, 110);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(200, 60);
            this.btnKhamBenh.TabIndex = 3;
            this.btnKhamBenh.Text = "Khám bệnh - Toa thuốc";
            this.btnKhamBenh.UseVisualStyleBackColor = true;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(60, 200);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(200, 60);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Xuất viện - Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(300, 200);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(200, 60);
            this.btnTraCuu.TabIndex = 5;
            this.btnTraCuu.Text = "Tra cứu hồ sơ";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnKhamDinhKy
            // 
            this.btnKhamDinhKy.Location = new System.Drawing.Point(540, 200);
            this.btnKhamDinhKy.Name = "btnKhamDinhKy";
            this.btnKhamDinhKy.Size = new System.Drawing.Size(200, 60);
            this.btnKhamDinhKy.TabIndex = 6;
            this.btnKhamDinhKy.Text = "Khám định kỳ";
            this.btnKhamDinhKy.UseVisualStyleBackColor = true;
            this.btnKhamDinhKy.Click += new System.EventHandler(this.btnKhamDinhKy_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(180, 290);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 60);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Theo dõi - Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(420, 290);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(200, 60);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Location = new System.Drawing.Point(60, 402);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Size = new System.Drawing.Size(50, 13);
            this.lblNguoiDung.TabIndex = 9;
            this.lblNguoiDung.Text = "Người dùng: ";
            // 
            // btnDoiNguoi
            // 
            this.btnDoiNguoi.Location = new System.Drawing.Point(600, 392);
            this.btnDoiNguoi.Name = "btnDoiNguoi";
            this.btnDoiNguoi.Size = new System.Drawing.Size(140, 30);
            this.btnDoiNguoi.TabIndex = 10;
            this.btnDoiNguoi.Text = "Đổi người dùng";
            this.btnDoiNguoi.UseVisualStyleBackColor = true;
            this.btnDoiNguoi.Click += new System.EventHandler(this.btnDoiNguoi_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnKhamBenh);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnKhamDinhKy);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblNguoiDung);
            this.Controls.Add(this.btnDoiNguoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hồ sơ bệnh án";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnKhamDinhKy;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Button btnDoiNguoi;
    }
}
