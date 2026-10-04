namespace eShopping.Forms
{
    partial class FrmGioHang
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
            this.txtMaGioHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnCapNhatSoLuong = new System.Windows.Forms.Button();
            this.btnTiepTucMua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTamTinh = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giỏ hàng: ";
            // 
            // txtMaGioHang
            // 
            this.txtMaGioHang.Location = new System.Drawing.Point(107, 6);
            this.txtMaGioHang.Name = "txtMaGioHang";
            this.txtMaGioHang.Size = new System.Drawing.Size(132, 22);
            this.txtMaGioHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách hàng:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(365, 10);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(132, 22);
            this.txtKhachHang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày tạo:";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(615, 7);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayTao.TabIndex = 5;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvGioHang.Location = new System.Drawing.Point(16, 51);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(677, 239);
            this.dgvGioHang.TabIndex = 6;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Location = new System.Drawing.Point(16, 317);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(118, 34);
            this.btnXoaSanPham.TabIndex = 7;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // btnCapNhatSoLuong
            // 
            this.btnCapNhatSoLuong.Location = new System.Drawing.Point(166, 317);
            this.btnCapNhatSoLuong.Name = "btnCapNhatSoLuong";
            this.btnCapNhatSoLuong.Size = new System.Drawing.Size(146, 34);
            this.btnCapNhatSoLuong.TabIndex = 8;
            this.btnCapNhatSoLuong.Text = "Cập nhật số lượng";
            this.btnCapNhatSoLuong.UseVisualStyleBackColor = true;
            this.btnCapNhatSoLuong.Click += new System.EventHandler(this.btnCapNhatSoLuong_Click);
            // 
            // btnTiepTucMua
            // 
            this.btnTiepTucMua.Location = new System.Drawing.Point(16, 370);
            this.btnTiepTucMua.Name = "btnTiepTucMua";
            this.btnTiepTucMua.Size = new System.Drawing.Size(146, 34);
            this.btnTiepTucMua.TabIndex = 9;
            this.btnTiepTucMua.Text = "Tiếp tục mua hàng";
            this.btnTiepTucMua.UseVisualStyleBackColor = true;
            this.btnTiepTucMua.Click += new System.EventHandler(this.btnTiepTucMua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng tạm tính:";
            // 
            // txtTongTamTinh
            // 
            this.txtTongTamTinh.Location = new System.Drawing.Point(561, 323);
            this.txtTongTamTinh.Name = "txtTongTamTinh";
            this.txtTongTamTinh.Size = new System.Drawing.Size(132, 22);
            this.txtTongTamTinh.TabIndex = 11;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(501, 370);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(146, 34);
            this.btnTinhTien.TabIndex = 12;
            this.btnTinhTien.Text = "Đặt hàng";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSanPham";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSanPham";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGia";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ThanhTien";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // FrmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 465);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtTongTamTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTiepTucMua);
            this.Controls.Add(this.btnCapNhatSoLuong);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.dtpNgayTao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaGioHang);
            this.Controls.Add(this.label1);
            this.Name = "FrmGioHang";
            this.Text = "FrmGioHang";
            this.Load += new System.EventHandler(this.FrmGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGioHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnCapNhatSoLuong;
        private System.Windows.Forms.Button btnTiepTucMua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTamTinh;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}