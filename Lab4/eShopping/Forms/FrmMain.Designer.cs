namespace eShopping.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống eShopping";
            // 
            // btnSanPham
            // 
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.Location = new System.Drawing.Point(193, 107);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(219, 69);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Location = new System.Drawing.Point(519, 107);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(219, 69);
            this.btnGioHang.TabIndex = 2;
            this.btnGioHang.Text = "Giỏ hàng";
            this.btnGioHang.UseVisualStyleBackColor = true;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Location = new System.Drawing.Point(854, 107);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(219, 69);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.Location = new System.Drawing.Point(193, 262);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(219, 69);
            this.btnDatHang.TabIndex = 4;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(519, 262);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(219, 69);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(854, 262);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(219, 69);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 572);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.btnGioHang);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
    }
}