namespace QuanLyBenhVien.Forms
{
    partial class FrmDangNhap
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
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.lblNguoi = new System.Windows.Forms.Label();
            this.cboNguoi = new System.Windows.Forms.ComboBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Location = new System.Drawing.Point(0, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(420, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.AutoSize = false;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.Location = new System.Drawing.Point(40, 83);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Size = new System.Drawing.Size(50, 13);
            this.lblVaiTro.TabIndex = 1;
            this.lblVaiTro.Text = "Vai trò:";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.Location = new System.Drawing.Point(130, 80);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Items.AddRange(new object[] {
                "Bác sĩ",
                "Chăm sóc khách hàng",
                "Xét nghiệm",
                "Thanh toán",
                "Quản lý"});
            this.cboVaiTro.Size = new System.Drawing.Size(230, 21);
            this.cboVaiTro.TabIndex = 2;
            this.cboVaiTro.SelectedIndexChanged += new System.EventHandler(this.cboVaiTro_SelectedIndexChanged);
            // 
            // lblNguoi
            // 
            this.lblNguoi.Location = new System.Drawing.Point(40, 121);
            this.lblNguoi.Name = "lblNguoi";
            this.lblNguoi.AutoSize = true;
            this.lblNguoi.Size = new System.Drawing.Size(50, 13);
            this.lblNguoi.TabIndex = 3;
            this.lblNguoi.Text = "Người dùng:";
            // 
            // cboNguoi
            // 
            this.cboNguoi.Location = new System.Drawing.Point(130, 118);
            this.cboNguoi.Name = "cboNguoi";
            this.cboNguoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoi.FormattingEnabled = true;
            this.cboNguoi.Size = new System.Drawing.Size(230, 21);
            this.cboNguoi.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(130, 165);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(110, 32);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(250, 165);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 240);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblVaiTro);
            this.Controls.Add(this.cboVaiTro);
            this.Controls.Add(this.lblNguoi);
            this.Controls.Add(this.cboNguoi);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label lblNguoi;
        private System.Windows.Forms.ComboBox cboNguoi;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}
