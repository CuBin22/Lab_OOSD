namespace eShopping.Forms
{
    partial class FrmSanPham
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
            this.cboNhomSanPham = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.btnXemGioHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm sản phẩm: ";
            // 
            // cboNhomSanPham
            // 
            this.cboNhomSanPham.FormattingEnabled = true;
            this.cboNhomSanPham.Location = new System.Drawing.Point(157, 17);
            this.cboNhomSanPham.Name = "cboNhomSanPham";
            this.cboNhomSanPham.Size = new System.Drawing.Size(155, 24);
            this.cboNhomSanPham.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(345, 17);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(543, 18);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(172, 22);
            this.txtKhachHang.TabIndex = 4;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSanPham.Location = new System.Drawing.Point(33, 69);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(682, 263);
            this.dgvSanPham.TabIndex = 5;
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
            this.Column3.DataPropertyName = "NhaSanXuat";
            this.Column3.HeaderText = "Nhà sản xuất";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GiaBan";
            this.Column4.HeaderText = "Giá bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TinhTrang";
            this.Column5.HeaderText = "Tình trạng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(113, 360);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 22);
            this.nudSoLuong.TabIndex = 7;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(264, 351);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(108, 31);
            this.btnXemChiTiet.TabIndex = 8;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.Location = new System.Drawing.Point(403, 351);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(128, 31);
            this.btnThemVaoGio.TabIndex = 9;
            this.btnThemVaoGio.Text = "Thêm vào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = true;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // btnXemGioHang
            // 
            this.btnXemGioHang.Location = new System.Drawing.Point(563, 351);
            this.btnXemGioHang.Name = "btnXemGioHang";
            this.btnXemGioHang.Size = new System.Drawing.Size(128, 31);
            this.btnXemGioHang.TabIndex = 10;
            this.btnXemGioHang.Text = "Xem giỏ hàng";
            this.btnXemGioHang.UseVisualStyleBackColor = true;
            this.btnXemGioHang.Click += new System.EventHandler(this.btnXemGioHang_Click);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 467);
            this.Controls.Add(this.btnXemGioHang);
            this.Controls.Add(this.btnThemVaoGio);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cboNhomSanPham);
            this.Controls.Add(this.label1);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhomSanPham;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Button btnXemGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}