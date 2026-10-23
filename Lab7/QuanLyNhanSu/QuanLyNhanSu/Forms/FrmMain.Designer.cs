namespace QuanLyNhanSu.Forms
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
            this.lblCongTy = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnTuyenDung = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnQuyetDinh = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnKhenKyLuat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTieuDe
            //
            this.lblTieuDe.AutoSize = false;
            this.lblTieuDe.Size = new System.Drawing.Size(760, 34);
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(0, 51, 122);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            // lblCongTy
            //
            this.lblCongTy.AutoSize = false;
            this.lblCongTy.Size = new System.Drawing.Size(760, 22);
            this.lblCongTy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCongTy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblCongTy.Location = new System.Drawing.Point(0, 58);
            this.lblCongTy.Name = "lblCongTy";
            this.lblCongTy.TabIndex = 1;
            this.lblCongTy.Text = "Công ty sơn Đông Á";
            // btnDanhMuc
            //
            this.btnDanhMuc.Location = new System.Drawing.Point(40, 100);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(200, 60);
            this.btnDanhMuc.TabIndex = 2;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // btnTuyenDung
            //
            this.btnTuyenDung.Location = new System.Drawing.Point(280, 100);
            this.btnTuyenDung.Name = "btnTuyenDung";
            this.btnTuyenDung.Size = new System.Drawing.Size(200, 60);
            this.btnTuyenDung.TabIndex = 3;
            this.btnTuyenDung.Text = "Tuyển dụng - Thử việc";
            this.btnTuyenDung.UseVisualStyleBackColor = true;
            this.btnTuyenDung.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTuyenDung.Click += new System.EventHandler(this.btnTuyenDung_Click);
            // btnHopDong
            //
            this.btnHopDong.Location = new System.Drawing.Point(520, 100);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(200, 60);
            this.btnHopDong.TabIndex = 4;
            this.btnHopDong.Text = "Hợp đồng - Bảo hiểm";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // btnQuyetDinh
            //
            this.btnQuyetDinh.Location = new System.Drawing.Point(40, 190);
            this.btnQuyetDinh.Name = "btnQuyetDinh";
            this.btnQuyetDinh.Size = new System.Drawing.Size(200, 60);
            this.btnQuyetDinh.TabIndex = 5;
            this.btnQuyetDinh.Text = "Chức vụ - Lương";
            this.btnQuyetDinh.UseVisualStyleBackColor = true;
            this.btnQuyetDinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQuyetDinh.Click += new System.EventHandler(this.btnQuyetDinh_Click);
            // btnChamCong
            //
            this.btnChamCong.Location = new System.Drawing.Point(280, 190);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(200, 60);
            this.btnChamCong.TabIndex = 6;
            this.btnChamCong.Text = "Chấm công - Phụ trội";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // btnBangLuong
            //
            this.btnBangLuong.Location = new System.Drawing.Point(520, 190);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(200, 60);
            this.btnBangLuong.TabIndex = 7;
            this.btnBangLuong.Text = "Bảng lương";
            this.btnBangLuong.UseVisualStyleBackColor = true;
            this.btnBangLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // btnKhenKyLuat
            //
            this.btnKhenKyLuat.Location = new System.Drawing.Point(40, 280);
            this.btnKhenKyLuat.Name = "btnKhenKyLuat";
            this.btnKhenKyLuat.Size = new System.Drawing.Size(200, 60);
            this.btnKhenKyLuat.TabIndex = 8;
            this.btnKhenKyLuat.Text = "Khen thưởng - Kỷ luật";
            this.btnKhenKyLuat.UseVisualStyleBackColor = true;
            this.btnKhenKyLuat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnKhenKyLuat.Click += new System.EventHandler(this.btnKhenKyLuat_Click);
            // btnThongKe
            //
            this.btnThongKe.Location = new System.Drawing.Point(280, 280);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 60);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // btnThoat
            //
            this.btnThoat.Location = new System.Drawing.Point(520, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(200, 60);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // FrmMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblCongTy);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnTuyenDung);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnQuyetDinh);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.btnBangLuong);
            this.Controls.Add(this.btnKhenKyLuat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblCongTy;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnTuyenDung;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnQuyetDinh;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnKhenKyLuat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}