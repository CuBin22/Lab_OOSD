namespace eShopping.Forms
{
    partial class FrmDatHang
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
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.txtNguoiMua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThoiGianXuLy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radHoaToc = new System.Windows.Forms.RadioButton();
            this.radNhanh = new System.Windows.Forms.RadioButton();
            this.radThuong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChiNguoiNhan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDTNguoiNhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTenNguoiNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTinhPhi = new System.Windows.Forms.Button();
            this.txtTongGiaTri = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhiGiaoHang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongTienHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyDatHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(119, 6);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(149, 22);
            this.txtMaDonHang.TabIndex = 1;
            // 
            // txtNguoiMua
            // 
            this.txtNguoiMua.Location = new System.Drawing.Point(400, 7);
            this.txtNguoiMua.Name = "txtNguoiMua";
            this.txtNguoiMua.Size = new System.Drawing.Size(149, 22);
            this.txtNguoiMua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người mua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày đặt:";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGioHang.Location = new System.Drawing.Point(16, 46);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(427, 205);
            this.dgvGioHang.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSanPham";
            this.Column1.HeaderText = "Sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thời gian dự kiến: ";
            // 
            // txtThoiGianXuLy
            // 
            this.txtThoiGianXuLy.Location = new System.Drawing.Point(159, 72);
            this.txtThoiGianXuLy.Name = "txtThoiGianXuLy";
            this.txtThoiGianXuLy.Size = new System.Drawing.Size(100, 22);
            this.txtThoiGianXuLy.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radHoaToc);
            this.groupBox1.Controls.Add(this.radNhanh);
            this.groupBox1.Controls.Add(this.radThuong);
            this.groupBox1.Controls.Add(this.txtThoiGianXuLy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(510, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại phiếu đặt hàng";
            // 
            // radHoaToc
            // 
            this.radHoaToc.AutoSize = true;
            this.radHoaToc.Location = new System.Drawing.Point(225, 35);
            this.radHoaToc.Name = "radHoaToc";
            this.radHoaToc.Size = new System.Drawing.Size(75, 20);
            this.radHoaToc.TabIndex = 14;
            this.radHoaToc.TabStop = true;
            this.radHoaToc.Text = "Hỏa tốc";
            this.radHoaToc.UseVisualStyleBackColor = true;
            // 
            // radNhanh
            // 
            this.radNhanh.AutoSize = true;
            this.radNhanh.Location = new System.Drawing.Point(125, 35);
            this.radNhanh.Name = "radNhanh";
            this.radNhanh.Size = new System.Drawing.Size(67, 20);
            this.radNhanh.TabIndex = 13;
            this.radNhanh.TabStop = true;
            this.radNhanh.Text = "Nhanh";
            this.radNhanh.UseVisualStyleBackColor = true;
            // 
            // radThuong
            // 
            this.radThuong.AutoSize = true;
            this.radThuong.Location = new System.Drawing.Point(27, 35);
            this.radThuong.Name = "radThuong";
            this.radThuong.Size = new System.Drawing.Size(74, 20);
            this.radThuong.TabIndex = 12;
            this.radThuong.TabStop = true;
            this.radThuong.Text = "Thường";
            this.radThuong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboKhuVuc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDiaChiNguoiNhan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSDTNguoiNhan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtHoTenNguoiNhan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(510, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 173);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người nhận";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(116, 107);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(176, 24);
            this.cboKhuVuc.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Khu vực giao:";
            // 
            // txtDiaChiNguoiNhan
            // 
            this.txtDiaChiNguoiNhan.Location = new System.Drawing.Point(84, 68);
            this.txtDiaChiNguoiNhan.Name = "txtDiaChiNguoiNhan";
            this.txtDiaChiNguoiNhan.Size = new System.Drawing.Size(301, 22);
            this.txtDiaChiNguoiNhan.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtSDTNguoiNhan
            // 
            this.txtSDTNguoiNhan.Location = new System.Drawing.Point(321, 33);
            this.txtSDTNguoiNhan.Name = "txtSDTNguoiNhan";
            this.txtSDTNguoiNhan.Size = new System.Drawing.Size(153, 22);
            this.txtSDTNguoiNhan.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Điện thoại:";
            // 
            // txtHoTenNguoiNhan
            // 
            this.txtHoTenNguoiNhan.Location = new System.Drawing.Point(84, 30);
            this.txtHoTenNguoiNhan.Name = "txtHoTenNguoiNhan";
            this.txtHoTenNguoiNhan.Size = new System.Drawing.Size(156, 22);
            this.txtHoTenNguoiNhan.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Họ tên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTinhPhi);
            this.groupBox3.Controls.Add(this.txtTongGiaTri);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtPhiGiaoHang);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTongTienHang);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(16, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tính phí giao hàng và tổng giá trị";
            // 
            // btnTinhPhi
            // 
            this.btnTinhPhi.Location = new System.Drawing.Point(867, 41);
            this.btnTinhPhi.Name = "btnTinhPhi";
            this.btnTinhPhi.Size = new System.Drawing.Size(101, 24);
            this.btnTinhPhi.TabIndex = 25;
            this.btnTinhPhi.Text = "Tính phí giao";
            this.btnTinhPhi.UseVisualStyleBackColor = true;
            this.btnTinhPhi.Click += new System.EventHandler(this.btnTinhPhi_Click);
            // 
            // txtTongGiaTri
            // 
            this.txtTongGiaTri.Location = new System.Drawing.Point(698, 43);
            this.txtTongGiaTri.Name = "txtTongGiaTri";
            this.txtTongGiaTri.Size = new System.Drawing.Size(156, 22);
            this.txtTongGiaTri.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(596, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tổng giá trị";
            // 
            // txtPhiGiaoHang
            // 
            this.txtPhiGiaoHang.Location = new System.Drawing.Point(412, 43);
            this.txtPhiGiaoHang.Name = "txtPhiGiaoHang";
            this.txtPhiGiaoHang.Size = new System.Drawing.Size(156, 22);
            this.txtPhiGiaoHang.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phí giao hàng";
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.Location = new System.Drawing.Point(119, 43);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.Size = new System.Drawing.Size(156, 22);
            this.txtTongTienHang.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tổng tiền hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Phiếu đặt hàng:";
            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvPhieuDat.Location = new System.Drawing.Point(16, 536);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.RowHeadersWidth = 51;
            this.dgvPhieuDat.RowTemplate.Height = 24;
            this.dgvPhieuDat.Size = new System.Drawing.Size(927, 153);
            this.dgvPhieuDat.TabIndex = 17;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaDonHang";
            this.Column4.HeaderText = "Mã đơn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayDat";
            this.Column5.HeaderText = "Ngày đặt";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HoTenNguoiNhan";
            this.Column6.HeaderText = "Người nhận";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenKhuVuc";
            this.Column7.HeaderText = "Khu vực";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenLoaiPhieu";
            this.Column8.HeaderText = "Loại phiếu";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PhiGiaoHang";
            this.Column9.HeaderText = "Phí giao";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TongGiaTri";
            this.Column10.HeaderText = "Tổng giá trị";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // btnHuyDatHang
            // 
            this.btnHuyDatHang.Location = new System.Drawing.Point(669, 716);
            this.btnHuyDatHang.Name = "btnHuyDatHang";
            this.btnHuyDatHang.Size = new System.Drawing.Size(101, 24);
            this.btnHuyDatHang.TabIndex = 26;
            this.btnHuyDatHang.Text = "Hủy đơn hàng";
            this.btnHuyDatHang.UseVisualStyleBackColor = true;
            this.btnHuyDatHang.Click += new System.EventHandler(this.btnHuyDatHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(805, 716);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(101, 24);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(688, 8);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(149, 22);
            this.txtNgayDat.TabIndex = 28;
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 761);
            this.Controls.Add(this.txtNgayDat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnHuyDatHang);
            this.Controls.Add(this.dgvPhieuDat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNguoiMua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatHang";
            this.Text = "FrmDatHang";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.TextBox txtNguoiMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThoiGianXuLy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChiNguoiNhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDTNguoiNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTenNguoiNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTinhPhi;
        private System.Windows.Forms.TextBox txtTongGiaTri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhiGiaoHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongTienHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPhieuDat;
        private System.Windows.Forms.Button btnHuyDatHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.RadioButton radHoaToc;
        private System.Windows.Forms.RadioButton radNhanh;
        private System.Windows.Forms.RadioButton radThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox txtNgayDat;
    }
}