namespace QuanLyCuaHangNuoc.Forms
{
    partial class FrmThongKe
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
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.lblDonDat = new System.Windows.Forms.Label();
            this.lblPhieuGiao = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblHenChua = new System.Windows.Forms.Label();
            this.lblGhiNo = new System.Windows.Forms.Label();
            this.tabKQ = new System.Windows.Forms.TabControl();
            this.tpBan = new System.Windows.Forms.TabPage();
            this.tpTon = new System.Windows.Forms.TabPage();
            this.tpNhap = new System.Windows.Forms.TabPage();
            this.tpNo = new System.Windows.Forms.TabPage();
            this.tpHenCG = new System.Windows.Forms.TabPage();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.dgvTon = new System.Windows.Forms.DataGridView();
            this.dgvNhap = new System.Windows.Forms.DataGridView();
            this.dgvNo = new System.Windows.Forms.DataGridView();
            this.dgvHenCG = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenCG)).BeginInit();
            this.tabKQ.SuspendLayout();
            this.tpBan.SuspendLayout();
            this.tpTon.SuspendLayout();
            this.tpNhap.SuspendLayout();
            this.tpNo.SuspendLayout();
            this.tpHenCG.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.AutoSize = true;
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Location = new System.Drawing.Point(74, 12);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(120, 23);
            this.dtTu.TabIndex = 1;
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(230, 15);
            this.label2.Name = "label2";
            this.label2.AutoSize = true;
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.Location = new System.Drawing.Point(294, 12);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(120, 23);
            this.dtDen.TabIndex = 3;
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(430, 9);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(100, 28);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lblDonDat
            // 
            this.lblDonDat.Location = new System.Drawing.Point(12, 50);
            this.lblDonDat.Name = "lblDonDat";
            this.lblDonDat.AutoSize = true;
            this.lblDonDat.TabIndex = 5;
            this.lblDonDat.Text = "Đơn đặt hàng: 0";
            this.lblDonDat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDonDat.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // lblPhieuGiao
            // 
            this.lblPhieuGiao.Location = new System.Drawing.Point(260, 50);
            this.lblPhieuGiao.Name = "lblPhieuGiao";
            this.lblPhieuGiao.AutoSize = true;
            this.lblPhieuGiao.TabIndex = 6;
            this.lblPhieuGiao.Text = "Phiếu giao hàng: 0";
            this.lblPhieuGiao.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhieuGiao.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.Location = new System.Drawing.Point(520, 50);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.TabIndex = 7;
            this.lblHoaDon.Text = "Hóa đơn: 0";
            this.lblHoaDon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Location = new System.Drawing.Point(12, 78);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.TabIndex = 8;
            this.lblDoanhThu.Text = "Doanh thu: 0 đ";
            this.lblDoanhThu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // lblHenChua
            // 
            this.lblHenChua.Location = new System.Drawing.Point(260, 78);
            this.lblHenChua.Name = "lblHenChua";
            this.lblHenChua.AutoSize = true;
            this.lblHenChua.TabIndex = 9;
            this.lblHenChua.Text = "Phiếu hẹn chưa giao: 0";
            this.lblHenChua.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHenChua.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // lblGhiNo
            // 
            this.lblGhiNo.Location = new System.Drawing.Point(520, 78);
            this.lblGhiNo.Name = "lblGhiNo";
            this.lblGhiNo.AutoSize = true;
            this.lblGhiNo.TabIndex = 10;
            this.lblGhiNo.Text = "Phiếu ghi nợ: 0 - Tổng nợ: 0 đ";
            this.lblGhiNo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGhiNo.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // tabKQ
            // 
            this.tabKQ.Location = new System.Drawing.Point(12, 112);
            this.tabKQ.Name = "tabKQ";
            this.tabKQ.Size = new System.Drawing.Size(936, 440);
            this.tabKQ.TabIndex = 11;
            this.tabKQ.SelectedIndex = 0;
            this.tabKQ.Controls.Add(this.tpBan);
            this.tabKQ.Controls.Add(this.tpTon);
            this.tabKQ.Controls.Add(this.tpNhap);
            this.tabKQ.Controls.Add(this.tpNo);
            this.tabKQ.Controls.Add(this.tpHenCG);
            // 
            // tpBan
            // 
            this.tpBan.Location = new System.Drawing.Point(4, 22);
            this.tpBan.Name = "tpBan";
            this.tpBan.Text = "Doanh số theo mặt hàng";
            this.tpBan.Padding = new System.Windows.Forms.Padding(3);
            this.tpBan.UseVisualStyleBackColor = true;
            this.tpBan.Controls.Add(this.dgvBan);
            // 
            // tpTon
            // 
            this.tpTon.Location = new System.Drawing.Point(4, 22);
            this.tpTon.Name = "tpTon";
            this.tpTon.Text = "Tồn kho";
            this.tpTon.Padding = new System.Windows.Forms.Padding(3);
            this.tpTon.UseVisualStyleBackColor = true;
            this.tpTon.Controls.Add(this.dgvTon);
            // 
            // tpNhap
            // 
            this.tpNhap.Location = new System.Drawing.Point(4, 22);
            this.tpNhap.Name = "tpNhap";
            this.tpNhap.Text = "Đặt hàng - Nhận hàng";
            this.tpNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhap.UseVisualStyleBackColor = true;
            this.tpNhap.Controls.Add(this.dgvNhap);
            // 
            // tpNo
            // 
            this.tpNo.Location = new System.Drawing.Point(4, 22);
            this.tpNo.Name = "tpNo";
            this.tpNo.Text = "Công nợ khách quen";
            this.tpNo.Padding = new System.Windows.Forms.Padding(3);
            this.tpNo.UseVisualStyleBackColor = true;
            this.tpNo.Controls.Add(this.dgvNo);
            // 
            // tpHenCG
            // 
            this.tpHenCG.Location = new System.Drawing.Point(4, 22);
            this.tpHenCG.Name = "tpHenCG";
            this.tpHenCG.Text = "Hẹn giao chưa giao";
            this.tpHenCG.Padding = new System.Windows.Forms.Padding(3);
            this.tpHenCG.UseVisualStyleBackColor = true;
            this.tpHenCG.Controls.Add(this.dgvHenCG);
            // 
            // dgvBan
            // 
            this.dgvBan.Location = new System.Drawing.Point(0, 0);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.Size = new System.Drawing.Size(0, 0);
            this.dgvBan.TabIndex = 12;
            this.dgvBan.AllowUserToAddRows = false;
            this.dgvBan.AllowUserToDeleteRows = false;
            this.dgvBan.AllowUserToResizeRows = false;
            this.dgvBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvBan.MultiSelect = false;
            this.dgvBan.ReadOnly = true;
            this.dgvBan.RowHeadersVisible = false;
            this.dgvBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBan.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dgvTon
            // 
            this.dgvTon.Location = new System.Drawing.Point(0, 0);
            this.dgvTon.Name = "dgvTon";
            this.dgvTon.Size = new System.Drawing.Size(0, 0);
            this.dgvTon.TabIndex = 13;
            this.dgvTon.AllowUserToAddRows = false;
            this.dgvTon.AllowUserToDeleteRows = false;
            this.dgvTon.AllowUserToResizeRows = false;
            this.dgvTon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTon.BackgroundColor = System.Drawing.Color.White;
            this.dgvTon.MultiSelect = false;
            this.dgvTon.ReadOnly = true;
            this.dgvTon.RowHeadersVisible = false;
            this.dgvTon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTon.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dgvNhap
            // 
            this.dgvNhap.Location = new System.Drawing.Point(0, 0);
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.Size = new System.Drawing.Size(0, 0);
            this.dgvNhap.TabIndex = 14;
            this.dgvNhap.AllowUserToAddRows = false;
            this.dgvNhap.AllowUserToDeleteRows = false;
            this.dgvNhap.AllowUserToResizeRows = false;
            this.dgvNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhap.MultiSelect = false;
            this.dgvNhap.ReadOnly = true;
            this.dgvNhap.RowHeadersVisible = false;
            this.dgvNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dgvNo
            // 
            this.dgvNo.Location = new System.Drawing.Point(0, 0);
            this.dgvNo.Name = "dgvNo";
            this.dgvNo.Size = new System.Drawing.Size(0, 0);
            this.dgvNo.TabIndex = 15;
            this.dgvNo.AllowUserToAddRows = false;
            this.dgvNo.AllowUserToDeleteRows = false;
            this.dgvNo.AllowUserToResizeRows = false;
            this.dgvNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvNo.MultiSelect = false;
            this.dgvNo.ReadOnly = true;
            this.dgvNo.RowHeadersVisible = false;
            this.dgvNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNo.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dgvHenCG
            // 
            this.dgvHenCG.Location = new System.Drawing.Point(0, 0);
            this.dgvHenCG.Name = "dgvHenCG";
            this.dgvHenCG.Size = new System.Drawing.Size(0, 0);
            this.dgvHenCG.TabIndex = 16;
            this.dgvHenCG.AllowUserToAddRows = false;
            this.dgvHenCG.AllowUserToDeleteRows = false;
            this.dgvHenCG.AllowUserToResizeRows = false;
            this.dgvHenCG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHenCG.BackgroundColor = System.Drawing.Color.White;
            this.dgvHenCG.MultiSelect = false;
            this.dgvHenCG.ReadOnly = true;
            this.dgvHenCG.RowHeadersVisible = false;
            this.dgvHenCG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHenCG.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(848, 562);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 28);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.lblDonDat);
            this.Controls.Add(this.lblPhieuGiao);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblHenChua);
            this.Controls.Add(this.lblGhiNo);
            this.Controls.Add(this.tabKQ);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê cửa hàng nước giải khát";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenCG)).EndInit();
            this.tabKQ.ResumeLayout(false);
            this.tpBan.ResumeLayout(false);
            this.tpTon.ResumeLayout(false);
            this.tpNhap.ResumeLayout(false);
            this.tpNo.ResumeLayout(false);
            this.tpHenCG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label lblDonDat;
        private System.Windows.Forms.Label lblPhieuGiao;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblHenChua;
        private System.Windows.Forms.Label lblGhiNo;
        private System.Windows.Forms.TabControl tabKQ;
        private System.Windows.Forms.TabPage tpBan;
        private System.Windows.Forms.TabPage tpTon;
        private System.Windows.Forms.TabPage tpNhap;
        private System.Windows.Forms.TabPage tpNo;
        private System.Windows.Forms.TabPage tpHenCG;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.DataGridView dgvTon;
        private System.Windows.Forms.DataGridView dgvNhap;
        private System.Windows.Forms.DataGridView dgvNo;
        private System.Windows.Forms.DataGridView dgvHenCG;
        private System.Windows.Forms.Button btnDong;
    }
}
