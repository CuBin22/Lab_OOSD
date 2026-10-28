namespace QuanLyCuaHangNuoc.Forms
{
    partial class FrmHenNo
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpHen = new System.Windows.Forms.TabPage();
            this.tpNo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTT = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dgvHen = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCTHen = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayHen = new System.Windows.Forms.DateTimePicker();
            this.btnDoiNgay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numTach = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayTach = new System.Windows.Forms.DateTimePicker();
            this.btnTach = new System.Windows.Forms.Button();
            this.btnDaGiao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboHDNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboNVNo = new System.Windows.Forms.ComboBox();
            this.lblThongTinHD = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numNo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dtNgayLapNo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtDuKien = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.btnLapNo = new System.Windows.Forms.Button();
            this.btnMoiNo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTimNo = new System.Windows.Forms.TextBox();
            this.btnTimNo = new System.Windows.Forms.Button();
            this.dgvNo = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNo)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tpHen.SuspendLayout();
            this.tpNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(976, 530);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Controls.Add(this.tpHen);
            this.tabMain.Controls.Add(this.tpNo);
            // 
            // tpHen
            // 
            this.tpHen.Location = new System.Drawing.Point(4, 22);
            this.tpHen.Name = "tpHen";
            this.tpHen.Text = "Phiếu hẹn giao hàng";
            this.tpHen.Padding = new System.Windows.Forms.Padding(3);
            this.tpHen.UseVisualStyleBackColor = true;
            this.tpHen.Controls.Add(this.label1);
            this.tpHen.Controls.Add(this.cboTT);
            this.tpHen.Controls.Add(this.btnLoc);
            this.tpHen.Controls.Add(this.dgvHen);
            this.tpHen.Controls.Add(this.label2);
            this.tpHen.Controls.Add(this.dgvCTHen);
            this.tpHen.Controls.Add(this.label3);
            this.tpHen.Controls.Add(this.dtNgayHen);
            this.tpHen.Controls.Add(this.btnDoiNgay);
            this.tpHen.Controls.Add(this.label4);
            this.tpHen.Controls.Add(this.numTach);
            this.tpHen.Controls.Add(this.label5);
            this.tpHen.Controls.Add(this.dtNgayTach);
            this.tpHen.Controls.Add(this.btnTach);
            this.tpHen.Controls.Add(this.btnDaGiao);
            // 
            // tpNo
            // 
            this.tpNo.Location = new System.Drawing.Point(4, 22);
            this.tpNo.Name = "tpNo";
            this.tpNo.Text = "Phiếu ghi nợ";
            this.tpNo.Padding = new System.Windows.Forms.Padding(3);
            this.tpNo.UseVisualStyleBackColor = true;
            this.tpNo.Controls.Add(this.label6);
            this.tpNo.Controls.Add(this.txtSoNo);
            this.tpNo.Controls.Add(this.label7);
            this.tpNo.Controls.Add(this.cboHDNo);
            this.tpNo.Controls.Add(this.label8);
            this.tpNo.Controls.Add(this.cboNVNo);
            this.tpNo.Controls.Add(this.lblThongTinHD);
            this.tpNo.Controls.Add(this.label9);
            this.tpNo.Controls.Add(this.numNo);
            this.tpNo.Controls.Add(this.label10);
            this.tpNo.Controls.Add(this.dtNgayLapNo);
            this.tpNo.Controls.Add(this.label11);
            this.tpNo.Controls.Add(this.dtDuKien);
            this.tpNo.Controls.Add(this.label12);
            this.tpNo.Controls.Add(this.txtLyDo);
            this.tpNo.Controls.Add(this.btnLapNo);
            this.tpNo.Controls.Add(this.btnMoiNo);
            this.tpNo.Controls.Add(this.label13);
            this.tpNo.Controls.Add(this.txtTimNo);
            this.tpNo.Controls.Add(this.btnTimNo);
            this.tpNo.Controls.Add(this.dgvNo);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.AutoSize = true;
            this.label1.TabIndex = 1;
            this.label1.Text = "Tình trạng:";
            // 
            // cboTT
            // 
            this.cboTT.Location = new System.Drawing.Point(79, 10);
            this.cboTT.Name = "cboTT";
            this.cboTT.Size = new System.Drawing.Size(140, 21);
            this.cboTT.TabIndex = 2;
            this.cboTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTT.FormattingEnabled = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(230, 7);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(70, 28);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dgvHen
            // 
            this.dgvHen.Location = new System.Drawing.Point(12, 42);
            this.dgvHen.Name = "dgvHen";
            this.dgvHen.Size = new System.Drawing.Size(944, 190);
            this.dgvHen.TabIndex = 4;
            this.dgvHen.AllowUserToAddRows = false;
            this.dgvHen.AllowUserToDeleteRows = false;
            this.dgvHen.AllowUserToResizeRows = false;
            this.dgvHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvHen.MultiSelect = false;
            this.dgvHen.ReadOnly = true;
            this.dgvHen.RowHeadersVisible = false;
            this.dgvHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHen.SelectionChanged += new System.EventHandler(this.dgvHen_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.AutoSize = true;
            this.label2.TabIndex = 5;
            this.label2.Text = "Chi tiết phiếu hẹn đang chọn (chọn một dòng để chia đợt):";
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // dgvCTHen
            // 
            this.dgvCTHen.Location = new System.Drawing.Point(12, 258);
            this.dgvCTHen.Name = "dgvCTHen";
            this.dgvCTHen.Size = new System.Drawing.Size(560, 200);
            this.dgvCTHen.TabIndex = 6;
            this.dgvCTHen.AllowUserToAddRows = false;
            this.dgvCTHen.AllowUserToDeleteRows = false;
            this.dgvCTHen.AllowUserToResizeRows = false;
            this.dgvCTHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTHen.MultiSelect = false;
            this.dgvCTHen.ReadOnly = true;
            this.dgvCTHen.RowHeadersVisible = false;
            this.dgvCTHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(590, 262);
            this.label3.Name = "label3";
            this.label3.AutoSize = true;
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày hẹn mới:";
            // 
            // dtNgayHen
            // 
            this.dtNgayHen.Location = new System.Drawing.Point(690, 258);
            this.dtNgayHen.Name = "dtNgayHen";
            this.dtNgayHen.Size = new System.Drawing.Size(120, 23);
            this.dtNgayHen.TabIndex = 8;
            this.dtNgayHen.CustomFormat = "dd/MM/yyyy";
            this.dtNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // btnDoiNgay
            // 
            this.btnDoiNgay.Location = new System.Drawing.Point(820, 256);
            this.btnDoiNgay.Name = "btnDoiNgay";
            this.btnDoiNgay.Size = new System.Drawing.Size(136, 28);
            this.btnDoiNgay.TabIndex = 9;
            this.btnDoiNgay.Text = "Đổi ngày hẹn";
            this.btnDoiNgay.UseVisualStyleBackColor = true;
            this.btnDoiNgay.Click += new System.EventHandler(this.btnDoiNgay_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(590, 306);
            this.label4.Name = "label4";
            this.label4.AutoSize = true;
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng tách:";
            // 
            // numTach
            // 
            this.numTach.Location = new System.Drawing.Point(690, 302);
            this.numTach.Name = "numTach";
            this.numTach.Size = new System.Drawing.Size(120, 23);
            this.numTach.TabIndex = 11;
            this.numTach.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numTach.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numTach.ThousandsSeparator = true;
            this.numTach.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numTach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(590, 338);
            this.label5.Name = "label5";
            this.label5.AutoSize = true;
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày đợt mới:";
            // 
            // dtNgayTach
            // 
            this.dtNgayTach.Location = new System.Drawing.Point(690, 334);
            this.dtNgayTach.Name = "dtNgayTach";
            this.dtNgayTach.Size = new System.Drawing.Size(120, 23);
            this.dtNgayTach.TabIndex = 13;
            this.dtNgayTach.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // btnTach
            // 
            this.btnTach.Location = new System.Drawing.Point(590, 366);
            this.btnTach.Name = "btnTach";
            this.btnTach.Size = new System.Drawing.Size(366, 28);
            this.btnTach.TabIndex = 14;
            this.btnTach.Text = "Tách thành đợt giao mới";
            this.btnTach.UseVisualStyleBackColor = true;
            this.btnTach.Click += new System.EventHandler(this.btnTach_Click);
            // 
            // btnDaGiao
            // 
            this.btnDaGiao.Location = new System.Drawing.Point(590, 410);
            this.btnDaGiao.Name = "btnDaGiao";
            this.btnDaGiao.Size = new System.Drawing.Size(366, 32);
            this.btnDaGiao.TabIndex = 15;
            this.btnDaGiao.Text = "Xác nhận đã giao (trừ tồn kho)";
            this.btnDaGiao.UseVisualStyleBackColor = true;
            this.btnDaGiao.Click += new System.EventHandler(this.btnDaGiao_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.AutoSize = true;
            this.label6.TabIndex = 16;
            this.label6.Text = "Số phiếu nợ:";
            // 
            // txtSoNo
            // 
            this.txtSoNo.Location = new System.Drawing.Point(89, 12);
            this.txtSoNo.Name = "txtSoNo";
            this.txtSoNo.Size = new System.Drawing.Size(90, 23);
            this.txtSoNo.TabIndex = 17;
            this.txtSoNo.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(230, 15);
            this.label7.Name = "label7";
            this.label7.AutoSize = true;
            this.label7.TabIndex = 18;
            this.label7.Text = "Hóa đơn:";
            // 
            // cboHDNo
            // 
            this.cboHDNo.Location = new System.Drawing.Point(282, 12);
            this.cboHDNo.Name = "cboHDNo";
            this.cboHDNo.Size = new System.Drawing.Size(400, 21);
            this.cboHDNo.TabIndex = 19;
            this.cboHDNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDNo.FormattingEnabled = true;
            this.cboHDNo.SelectedIndexChanged += new System.EventHandler(this.cboHDNo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(700, 15);
            this.label8.Name = "label8";
            this.label8.AutoSize = true;
            this.label8.TabIndex = 20;
            this.label8.Text = "NV lập:";
            // 
            // cboNVNo
            // 
            this.cboNVNo.Location = new System.Drawing.Point(747, 12);
            this.cboNVNo.Name = "cboNVNo";
            this.cboNVNo.Size = new System.Drawing.Size(190, 21);
            this.cboNVNo.TabIndex = 21;
            this.cboNVNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVNo.FormattingEnabled = true;
            // 
            // lblThongTinHD
            // 
            this.lblThongTinHD.Location = new System.Drawing.Point(12, 46);
            this.lblThongTinHD.Name = "lblThongTinHD";
            this.lblThongTinHD.AutoSize = false;
            this.lblThongTinHD.Size = new System.Drawing.Size(944, 22);
            this.lblThongTinHD.TabIndex = 22;
            this.lblThongTinHD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTinHD.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 81);
            this.label9.Name = "label9";
            this.label9.AutoSize = true;
            this.label9.TabIndex = 23;
            this.label9.Text = "Số tiền nợ:";
            // 
            // numNo
            // 
            this.numNo.Location = new System.Drawing.Point(89, 78);
            this.numNo.Name = "numNo";
            this.numNo.Size = new System.Drawing.Size(130, 23);
            this.numNo.TabIndex = 24;
            this.numNo.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            this.numNo.ThousandsSeparator = true;
            this.numNo.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(290, 81);
            this.label10.Name = "label10";
            this.label10.AutoSize = true;
            this.label10.TabIndex = 25;
            this.label10.Text = "Ngày lập:";
            // 
            // dtNgayLapNo
            // 
            this.dtNgayLapNo.Location = new System.Drawing.Point(347, 78);
            this.dtNgayLapNo.Name = "dtNgayLapNo";
            this.dtNgayLapNo.Size = new System.Drawing.Size(110, 23);
            this.dtNgayLapNo.TabIndex = 26;
            this.dtNgayLapNo.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLapNo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(500, 81);
            this.label11.Name = "label11";
            this.label11.AutoSize = true;
            this.label11.TabIndex = 27;
            this.label11.Text = "Dự kiến trả:";
            // 
            // dtDuKien
            // 
            this.dtDuKien.Location = new System.Drawing.Point(572, 78);
            this.dtDuKien.Name = "dtDuKien";
            this.dtDuKien.Size = new System.Drawing.Size(110, 23);
            this.dtDuKien.TabIndex = 28;
            this.dtDuKien.CustomFormat = "dd/MM/yyyy";
            this.dtDuKien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 113);
            this.label12.Name = "label12";
            this.label12.AutoSize = true;
            this.label12.TabIndex = 29;
            this.label12.Text = "Lý do nợ:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(89, 110);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(520, 23);
            this.txtLyDo.TabIndex = 30;
            // 
            // btnLapNo
            // 
            this.btnLapNo.Location = new System.Drawing.Point(640, 107);
            this.btnLapNo.Name = "btnLapNo";
            this.btnLapNo.Size = new System.Drawing.Size(120, 28);
            this.btnLapNo.TabIndex = 31;
            this.btnLapNo.Text = "Lập phiếu nợ";
            this.btnLapNo.UseVisualStyleBackColor = true;
            this.btnLapNo.Click += new System.EventHandler(this.btnLapNo_Click);
            // 
            // btnMoiNo
            // 
            this.btnMoiNo.Location = new System.Drawing.Point(770, 107);
            this.btnMoiNo.Name = "btnMoiNo";
            this.btnMoiNo.Size = new System.Drawing.Size(90, 28);
            this.btnMoiNo.TabIndex = 32;
            this.btnMoiNo.Text = "Làm mới";
            this.btnMoiNo.UseVisualStyleBackColor = true;
            this.btnMoiNo.Click += new System.EventHandler(this.btnMoiNo_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 153);
            this.label13.Name = "label13";
            this.label13.AutoSize = true;
            this.label13.TabIndex = 33;
            this.label13.Text = "Tìm khách/HĐ:";
            // 
            // txtTimNo
            // 
            this.txtTimNo.Location = new System.Drawing.Point(94, 150);
            this.txtTimNo.Name = "txtTimNo";
            this.txtTimNo.Size = new System.Drawing.Size(200, 23);
            this.txtTimNo.TabIndex = 34;
            // 
            // btnTimNo
            // 
            this.btnTimNo.Location = new System.Drawing.Point(300, 147);
            this.btnTimNo.Name = "btnTimNo";
            this.btnTimNo.Size = new System.Drawing.Size(70, 28);
            this.btnTimNo.TabIndex = 35;
            this.btnTimNo.Text = "Tìm";
            this.btnTimNo.UseVisualStyleBackColor = true;
            this.btnTimNo.Click += new System.EventHandler(this.btnTimNo_Click);
            // 
            // dgvNo
            // 
            this.dgvNo.Location = new System.Drawing.Point(12, 180);
            this.dgvNo.Name = "dgvNo";
            this.dgvNo.Size = new System.Drawing.Size(944, 290);
            this.dgvNo.TabIndex = 36;
            this.dgvNo.AllowUserToAddRows = false;
            this.dgvNo.AllowUserToDeleteRows = false;
            this.dgvNo.AllowUserToResizeRows = false;
            this.dgvNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvNo.MultiSelect = false;
            this.dgvNo.ReadOnly = true;
            this.dgvNo.RowHeadersVisible = false;
            this.dgvNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(888, 550);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 28);
            this.btnDong.TabIndex = 37;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmHenNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 590);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHenNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hẹn giao hàng - Phiếu ghi nợ";
            this.Load += new System.EventHandler(this.FrmHenNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNo)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tpHen.ResumeLayout(false);
            this.tpNo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpHen;
        private System.Windows.Forms.TabPage tpNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTT;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView dgvHen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCTHen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayHen;
        private System.Windows.Forms.Button btnDoiNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayTach;
        private System.Windows.Forms.Button btnTach;
        private System.Windows.Forms.Button btnDaGiao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboHDNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboNVNo;
        private System.Windows.Forms.Label lblThongTinHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgayLapNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtDuKien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnLapNo;
        private System.Windows.Forms.Button btnMoiNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTimNo;
        private System.Windows.Forms.Button btnTimNo;
        private System.Windows.Forms.DataGridView dgvNo;
        private System.Windows.Forms.Button btnDong;
    }
}
