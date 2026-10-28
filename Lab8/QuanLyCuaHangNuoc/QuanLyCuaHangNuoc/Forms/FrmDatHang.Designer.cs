namespace QuanLyCuaHangNuoc.Forms
{
    partial class FrmDatHang
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
            this.txtSoDDH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvNGK = new System.Windows.Forms.DataGridView();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnBoMH = new System.Windows.Forms.Button();
            this.btnLuuDon = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaDon = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvDon = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNGK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.AutoSize = true;
            this.label1.TabIndex = 0;
            this.label1.Text = "Số đơn:";
            // 
            // txtSoDDH
            // 
            this.txtSoDDH.Location = new System.Drawing.Point(69, 12);
            this.txtSoDDH.Name = "txtSoDDH";
            this.txtSoDDH.Size = new System.Drawing.Size(100, 23);
            this.txtSoDDH.TabIndex = 1;
            this.txtSoDDH.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(200, 15);
            this.label2.Name = "label2";
            this.label2.AutoSize = true;
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà cung ứng:";
            // 
            // cboNCC
            // 
            this.cboNCC.Location = new System.Drawing.Point(282, 12);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(260, 21);
            this.cboNCC.TabIndex = 3;
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.SelectedIndexChanged += new System.EventHandler(this.cboNCC_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(600, 15);
            this.label3.Name = "label3";
            this.label3.AutoSize = true;
            this.label3.TabIndex = 4;
            this.label3.Text = "NV lập đơn:";
            // 
            // cboNV
            // 
            this.cboNV.Location = new System.Drawing.Point(677, 12);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(250, 21);
            this.cboNV.TabIndex = 5;
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.AutoSize = true;
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày đặt:";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Location = new System.Drawing.Point(69, 44);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(110, 23);
            this.dtNgayDat.TabIndex = 7;
            this.dtNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(200, 47);
            this.label5.Name = "label5";
            this.label5.AutoSize = true;
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày nhận dự kiến:";
            // 
            // dtNgayNhan
            // 
            this.dtNgayNhan.Location = new System.Drawing.Point(307, 44);
            this.dtNgayNhan.Name = "dtNgayNhan";
            this.dtNgayNhan.Size = new System.Drawing.Size(110, 23);
            this.dtNgayNhan.TabIndex = 9;
            this.dtNgayNhan.CustomFormat = "dd/MM/yyyy";
            this.dtNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.AutoSize = true;
            this.label6.TabIndex = 10;
            this.label6.Text = "Mặt hàng của nhà cung ứng đã chọn:";
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(500, 78);
            this.label7.Name = "label7";
            this.label7.AutoSize = true;
            this.label7.TabIndex = 11;
            this.label7.Text = "Mặt hàng trong đơn đặt:";
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // dgvNGK
            // 
            this.dgvNGK.Location = new System.Drawing.Point(12, 96);
            this.dgvNGK.Name = "dgvNGK";
            this.dgvNGK.Size = new System.Drawing.Size(470, 160);
            this.dgvNGK.TabIndex = 12;
            this.dgvNGK.AllowUserToAddRows = false;
            this.dgvNGK.AllowUserToDeleteRows = false;
            this.dgvNGK.AllowUserToResizeRows = false;
            this.dgvNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNGK.BackgroundColor = System.Drawing.Color.White;
            this.dgvNGK.MultiSelect = false;
            this.dgvNGK.ReadOnly = true;
            this.dgvNGK.RowHeadersVisible = false;
            this.dgvNGK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgvChon
            // 
            this.dgvChon.Location = new System.Drawing.Point(500, 96);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.Size = new System.Drawing.Size(488, 160);
            this.dgvChon.TabIndex = 13;
            this.dgvChon.AllowUserToAddRows = false;
            this.dgvChon.AllowUserToDeleteRows = false;
            this.dgvChon.AllowUserToResizeRows = false;
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChon.MultiSelect = false;
            this.dgvChon.ReadOnly = true;
            this.dgvChon.RowHeadersVisible = false;
            this.dgvChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 265);
            this.label8.Name = "label8";
            this.label8.AutoSize = true;
            this.label8.TabIndex = 14;
            this.label8.Text = "Số lượng:";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(69, 262);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(80, 23);
            this.numSL.TabIndex = 15;
            this.numSL.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.ThousandsSeparator = true;
            this.numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(160, 260);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(100, 28);
            this.btnThemMH.TabIndex = 16;
            this.btnThemMH.Text = "Thêm >>";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnBoMH
            // 
            this.btnBoMH.Location = new System.Drawing.Point(500, 260);
            this.btnBoMH.Name = "btnBoMH";
            this.btnBoMH.Size = new System.Drawing.Size(110, 28);
            this.btnBoMH.TabIndex = 17;
            this.btnBoMH.Text = "Bỏ mặt hàng";
            this.btnBoMH.UseVisualStyleBackColor = true;
            this.btnBoMH.Click += new System.EventHandler(this.btnBoMH_Click);
            // 
            // btnLuuDon
            // 
            this.btnLuuDon.Location = new System.Drawing.Point(12, 298);
            this.btnLuuDon.Name = "btnLuuDon";
            this.btnLuuDon.Size = new System.Drawing.Size(100, 28);
            this.btnLuuDon.TabIndex = 18;
            this.btnLuuDon.Text = "Lập đơn";
            this.btnLuuDon.UseVisualStyleBackColor = true;
            this.btnLuuDon.Click += new System.EventHandler(this.btnLuuDon_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(120, 298);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 28);
            this.btnCapNhat.TabIndex = 19;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaDon
            // 
            this.btnXoaDon.Location = new System.Drawing.Point(228, 298);
            this.btnXoaDon.Name = "btnXoaDon";
            this.btnXoaDon.Size = new System.Drawing.Size(100, 28);
            this.btnXoaDon.TabIndex = 20;
            this.btnXoaDon.Text = "Xóa đơn";
            this.btnXoaDon.UseVisualStyleBackColor = true;
            this.btnXoaDon.Click += new System.EventHandler(this.btnXoaDon_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(336, 298);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(100, 28);
            this.btnMoi.TabIndex = 21;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 344);
            this.label9.Name = "label9";
            this.label9.AutoSize = true;
            this.label9.TabIndex = 22;
            this.label9.Text = "Tra cứu:";
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(70, 341);
            this.label10.Name = "label10";
            this.label10.AutoSize = true;
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã đơn / NCC:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(152, 338);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(150, 23);
            this.txtTim.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(380, 341);
            this.label11.Name = "label11";
            this.label11.AutoSize = true;
            this.label11.TabIndex = 25;
            this.label11.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Location = new System.Drawing.Point(437, 338);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(110, 23);
            this.dtTu.TabIndex = 26;
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(560, 341);
            this.label12.Name = "label12";
            this.label12.AutoSize = true;
            this.label12.TabIndex = 27;
            this.label12.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.Location = new System.Drawing.Point(622, 338);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(110, 23);
            this.dtDen.TabIndex = 28;
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(740, 335);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 28);
            this.btnTim.TabIndex = 29;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvDon
            // 
            this.dgvDon.Location = new System.Drawing.Point(12, 368);
            this.dgvDon.Name = "dgvDon";
            this.dgvDon.Size = new System.Drawing.Size(976, 150);
            this.dgvDon.TabIndex = 30;
            this.dgvDon.AllowUserToAddRows = false;
            this.dgvDon.AllowUserToDeleteRows = false;
            this.dgvDon.AllowUserToResizeRows = false;
            this.dgvDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDon.MultiSelect = false;
            this.dgvDon.ReadOnly = true;
            this.dgvDon.RowHeadersVisible = false;
            this.dgvDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDon_CellClick);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 526);
            this.label13.Name = "label13";
            this.label13.AutoSize = true;
            this.label13.TabIndex = 31;
            this.label13.Text = "Chi tiết đơn đặt hàng đang chọn:";
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // dgvCT
            // 
            this.dgvCT.Location = new System.Drawing.Point(12, 544);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.Size = new System.Drawing.Size(976, 120);
            this.dgvCT.TabIndex = 32;
            this.dgvCT.AllowUserToAddRows = false;
            this.dgvCT.AllowUserToDeleteRows = false;
            this.dgvCT.AllowUserToResizeRows = false;
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.BackgroundColor = System.Drawing.Color.White;
            this.dgvCT.MultiSelect = false;
            this.dgvCT.ReadOnly = true;
            this.dgvCT.RowHeadersVisible = false;
            this.dgvCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(888, 668);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 28);
            this.btnDong.TabIndex = 33;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoDDH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtNgayDat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgayNhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvNGK);
            this.Controls.Add(this.dgvChon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.btnBoMH);
            this.Controls.Add(this.btnLuuDon);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoaDon);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvDon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvCT);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt hàng nhà cung ứng";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNGK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoDDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvNGK;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnBoMH;
        private System.Windows.Forms.Button btnLuuDon;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaDon;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.Button btnDong;
    }
}
