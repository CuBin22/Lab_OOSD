namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
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
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.PhieuDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DangO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenBu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(145, 26);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(200, 30);
            this.dtTu.TabIndex = 1;
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(503, 26);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(200, 30);
            this.dtDen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(758, 26);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(160, 30);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhieuDat,
            this.DangO,
            this.HD,
            this.DoanhThu,
            this.DenBu});
            this.dgvTongHop.Location = new System.Drawing.Point(79, 81);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.RowHeadersWidth = 51;
            this.dgvTongHop.RowTemplate.Height = 24;
            this.dgvTongHop.Size = new System.Drawing.Size(804, 236);
            this.dgvTongHop.TabIndex = 5;
            // 
            // PhieuDat
            // 
            this.PhieuDat.HeaderText = "Phiếu đặt";
            this.PhieuDat.MinimumWidth = 6;
            this.PhieuDat.Name = "PhieuDat";
            this.PhieuDat.Width = 150;
            // 
            // DangO
            // 
            this.DangO.HeaderText = "Đang ở";
            this.DangO.MinimumWidth = 6;
            this.DangO.Name = "DangO";
            this.DangO.Width = 150;
            // 
            // HD
            // 
            this.HD.HeaderText = "Hóa đơn";
            this.HD.MinimumWidth = 6;
            this.HD.Name = "HD";
            this.HD.Width = 150;
            // 
            // DoanhThu
            // 
            this.DoanhThu.HeaderText = "Doanh thu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.Width = 150;
            // 
            // DenBu
            // 
            this.DenBu.HeaderText = "Đền bù";
            this.DenBu.MinimumWidth = 6;
            this.DenBu.Name = "DenBu";
            this.DenBu.Width = 150;
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.SoLuong,
            this.TongTien});
            this.dgvDV.Location = new System.Drawing.Point(107, 377);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(756, 236);
            this.dgvDV.TabIndex = 6;
            // 
            // MaDV
            // 
            this.MaDV.HeaderText = "Mã dịch vụ";
            this.MaDV.MinimumWidth = 6;
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 175;
            // 
            // TenDV
            // 
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.Width = 175;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 175;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 175;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(373, 648);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(160, 30);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrnThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 696);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrnThongKe";
            this.Text = "FrnThongKe";
            this.Load += new System.EventHandler(this.FrnThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DangO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenBu;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnDong;
    }
}