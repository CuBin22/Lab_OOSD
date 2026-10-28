namespace QuanLyCuaHangNuoc.Forms
{
    partial class FrmBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.lblLoaiKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimHang = new System.Windows.Forms.TextBox();
            this.btnTimHang = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.dgvGio = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgayHen = new System.Windows.Forms.DateTimePicker();
            this.chkGhiNo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numNo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dtDuKienTra = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.AutoSize = true;
            this.label1.TabIndex = 0;
            this.label1.Text = "Số HD:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(59, 12);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(80, 23);
            this.txtSoHD.TabIndex = 1;
            this.txtSoHD.ReadOnly = true;
            this.txtSoHD.Text = "(tự động)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 15);
            this.label2.Name = "label2";
            this.label2.AutoSize = true;
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách hàng:";
            // 
            // cboKH
            // 
            this.cboKH.Location = new System.Drawing.Point(242, 12);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(270, 21);
            this.cboKH.TabIndex = 3;
            this.cboKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKH.FormattingEnabled = true;
            this.cboKH.SelectedIndexChanged += new System.EventHandler(this.cboKH_SelectedIndexChanged);
            // 
            // lblLoaiKH
            // 
            this.lblLoaiKH.Location = new System.Drawing.Point(530, 15);
            this.lblLoaiKH.Name = "lblLoaiKH";
            this.lblLoaiKH.AutoSize = true;
            this.lblLoaiKH.TabIndex = 4;
            this.lblLoaiKH.Text = "Loại khách: -";
            this.lblLoaiKH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiKH.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(700, 15);
            this.label3.Name = "label3";
            this.label3.AutoSize = true;
            this.label3.TabIndex = 5;
            this.label3.Text = "NV lập:";
            // 
            // cboNV
            // 
            this.cboNV.Location = new System.Drawing.Point(747, 12);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(230, 21);
            this.cboNV.TabIndex = 6;
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.AutoSize = true;
            this.label4.TabIndex = 7;
            this.label4.Text = "Tìm hàng:";
            // 
            // txtTimHang
            // 
            this.txtTimHang.Location = new System.Drawing.Point(69, 44);
            this.txtTimHang.Name = "txtTimHang";
            this.txtTimHang.Size = new System.Drawing.Size(220, 23);
            this.txtTimHang.TabIndex = 8;
            // 
            // btnTimHang
            // 
            this.btnTimHang.Location = new System.Drawing.Point(300, 41);
            this.btnTimHang.Name = "btnTimHang";
            this.btnTimHang.Size = new System.Drawing.Size(70, 28);
            this.btnTimHang.TabIndex = 9;
            this.btnTimHang.Text = "Tìm";
            this.btnTimHang.UseVisualStyleBackColor = true;
            this.btnTimHang.Click += new System.EventHandler(this.btnTimHang_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.AutoSize = true;
            this.label5.TabIndex = 10;
            this.label5.Text = "Danh sách nước giải khát (kèm tồn kho):";
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(500, 78);
            this.label6.Name = "label6";
            this.label6.AutoSize = true;
            this.label6.TabIndex = 11;
            this.label6.Text = "Giỏ hàng / chi tiết hóa đơn:";
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // dgvHang
            // 
            this.dgvHang.Location = new System.Drawing.Point(12, 96);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.Size = new System.Drawing.Size(470, 190);
            this.dgvHang.TabIndex = 12;
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AllowUserToDeleteRows = false;
            this.dgvHang.AllowUserToResizeRows = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvHang.MultiSelect = false;
            this.dgvHang.ReadOnly = true;
            this.dgvHang.RowHeadersVisible = false;
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgvGio
            // 
            this.dgvGio.Location = new System.Drawing.Point(500, 96);
            this.dgvGio.Name = "dgvGio";
            this.dgvGio.Size = new System.Drawing.Size(488, 190);
            this.dgvGio.TabIndex = 13;
            this.dgvGio.AllowUserToAddRows = false;
            this.dgvGio.AllowUserToDeleteRows = false;
            this.dgvGio.AllowUserToResizeRows = false;
            this.dgvGio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGio.BackgroundColor = System.Drawing.Color.White;
            this.dgvGio.MultiSelect = false;
            this.dgvGio.ReadOnly = true;
            this.dgvGio.RowHeadersVisible = false;
            this.dgvGio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 297);
            this.label7.Name = "label7";
            this.label7.AutoSize = true;
            this.label7.TabIndex = 14;
            this.label7.Text = "Số lượng:";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(69, 294);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(80, 23);
            this.numSL.TabIndex = 15;
            this.numSL.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.ThousandsSeparator = true;
            this.numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(160, 292);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm >>";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBo
            // 
            this.btnBo.Location = new System.Drawing.Point(500, 292);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(100, 28);
            this.btnBo.TabIndex = 17;
            this.btnBo.Text = "Bỏ khỏi giỏ";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(610, 292);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(130, 28);
            this.btnKiemTra.TabIndex = 18;
            this.btnKiemTra.Text = "Kiểm tra tồn kho";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // lblTong
            // 
            this.lblTong.Location = new System.Drawing.Point(770, 298);
            this.lblTong.Name = "lblTong";
            this.lblTong.AutoSize = true;
            this.lblTong.TabIndex = 19;
            this.lblTong.Text = "Tổng tiền: 0 đ";
            this.lblTong.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTong.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.Location = new System.Drawing.Point(12, 332);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.AutoSize = false;
            this.lblTinhTrang.Size = new System.Drawing.Size(976, 36);
            this.lblTinhTrang.TabIndex = 20;
            this.lblTinhTrang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTinhTrang.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 378);
            this.label8.Name = "label8";
            this.label8.AutoSize = true;
            this.label8.TabIndex = 21;
            this.label8.Text = "Ngày hẹn giao phần còn thiếu (khách quen):";
            // 
            // dtNgayHen
            // 
            this.dtNgayHen.Location = new System.Drawing.Point(260, 374);
            this.dtNgayHen.Name = "dtNgayHen";
            this.dtNgayHen.Size = new System.Drawing.Size(110, 23);
            this.dtNgayHen.TabIndex = 22;
            this.dtNgayHen.CustomFormat = "dd/MM/yyyy";
            this.dtNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // chkGhiNo
            // 
            this.chkGhiNo.Location = new System.Drawing.Point(12, 410);
            this.chkGhiNo.Name = "chkGhiNo";
            this.chkGhiNo.AutoSize = true;
            this.chkGhiNo.TabIndex = 23;
            this.chkGhiNo.Text = "Khách quen trả chậm - lập phiếu ghi nợ";
            this.chkGhiNo.UseVisualStyleBackColor = true;
            this.chkGhiNo.CheckedChanged += new System.EventHandler(this.chkGhiNo_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 439);
            this.label9.Name = "label9";
            this.label9.AutoSize = true;
            this.label9.TabIndex = 24;
            this.label9.Text = "Số tiền nợ:";
            // 
            // numNo
            // 
            this.numNo.Location = new System.Drawing.Point(84, 436);
            this.numNo.Name = "numNo";
            this.numNo.Size = new System.Drawing.Size(130, 23);
            this.numNo.TabIndex = 25;
            this.numNo.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            this.numNo.ThousandsSeparator = true;
            this.numNo.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(260, 439);
            this.label10.Name = "label10";
            this.label10.AutoSize = true;
            this.label10.TabIndex = 26;
            this.label10.Text = "Dự kiến trả:";
            // 
            // dtDuKienTra
            // 
            this.dtDuKienTra.Location = new System.Drawing.Point(332, 436);
            this.dtDuKienTra.Name = "dtDuKienTra";
            this.dtDuKienTra.Size = new System.Drawing.Size(110, 23);
            this.dtDuKienTra.TabIndex = 27;
            this.dtDuKienTra.CustomFormat = "dd/MM/yyyy";
            this.dtDuKienTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(470, 439);
            this.label11.Name = "label11";
            this.label11.AutoSize = true;
            this.label11.TabIndex = 28;
            this.label11.Text = "Lý do nợ:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(527, 436);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(400, 23);
            this.txtLyDo.TabIndex = 29;
            // 
            // btnLapHD
            // 
            this.btnLapHD.Location = new System.Drawing.Point(12, 474);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(130, 28);
            this.btnLapHD.TabIndex = 30;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(150, 474);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(100, 28);
            this.btnMoi.TabIndex = 31;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 514);
            this.label12.Name = "label12";
            this.label12.AutoSize = true;
            this.label12.TabIndex = 32;
            this.label12.Text = "Hóa đơn gần đây:";
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // dgvHD
            // 
            this.dgvHD.Location = new System.Drawing.Point(12, 532);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(976, 106);
            this.dgvHD.TabIndex = 33;
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            this.dgvHD.AllowUserToResizeRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvHD.MultiSelect = false;
            this.dgvHD.ReadOnly = true;
            this.dgvHD.RowHeadersVisible = false;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(888, 644);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 28);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboKH);
            this.Controls.Add(this.lblLoaiKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimHang);
            this.Controls.Add(this.btnTimHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.dgvGio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtNgayHen);
            this.Controls.Add(this.chkGhiNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtDuKienTra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bán hàng - Lập hóa đơn";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.Label lblLoaiKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimHang;
        private System.Windows.Forms.Button btnTimHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridView dgvGio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtNgayHen;
        private System.Windows.Forms.CheckBox chkGhiNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtDuKienTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Button btnDong;
    }
}
