namespace QuanLyThuVien.Forms
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
            this.dgvPhat = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMuon = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhat
            // 
            this.dgvPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ngay,
            this.DocGia,
            this.MaSach,
            this.Column1,
            this.LyDo,
            this.PhiPhat});
            this.dgvPhat.Location = new System.Drawing.Point(64, 311);
            this.dgvPhat.Name = "dgvPhat";
            this.dgvPhat.RowHeadersWidth = 51;
            this.dgvPhat.RowTemplate.Height = 24;
            this.dgvPhat.Size = new System.Drawing.Size(931, 363);
            this.dgvPhat.TabIndex = 25;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaPhieuPhat";
            this.Ma.HeaderText = "Mã";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.Width = 125;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "NgayPhat";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 125;
            // 
            // DocGia
            // 
            this.DocGia.DataPropertyName = "MaDocGia";
            this.DocGia.HeaderText = "Độc giả";
            this.DocGia.MinimumWidth = 6;
            this.DocGia.Name = "DocGia";
            this.DocGia.Width = 125;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaDauSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSach";
            this.Column1.HeaderText = "TenSach";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 125;
            // 
            // PhiPhat
            // 
            this.PhiPhat.DataPropertyName = "PhiPhat";
            this.PhiPhat.HeaderText = "Phí phạt";
            this.PhiPhat.MinimumWidth = 6;
            this.PhiPhat.Name = "PhiPhat";
            this.PhiPhat.Width = 125;
            // 
            // dtDen
            // 
            this.dtDen.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(644, 48);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(214, 30);
            this.dtDen.TabIndex = 23;
            // 
            // dtTu
            // 
            this.dtTu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(224, 48);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(214, 30);
            this.dtTu.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Từ ngày: ";
            // 
            // lblMuon
            // 
            this.lblMuon.AutoSize = true;
            this.lblMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuon.Location = new System.Drawing.Point(59, 120);
            this.lblMuon.Name = "lblMuon";
            this.lblMuon.Size = new System.Drawing.Size(168, 25);
            this.lblMuon.TabIndex = 26;
            this.lblMuon.Text = "Lượn sách mượn: ";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.Location = new System.Drawing.Point(59, 182);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(101, 25);
            this.lblMat.TabIndex = 27;
            this.lblMat.Text = "Sách mất:";
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuaHan.Location = new System.Drawing.Point(537, 120);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(140, 25);
            this.lblQuaHan.TabIndex = 28;
            this.lblQuaHan.Text = "Sách quá hạn:";
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuHong.Location = new System.Drawing.Point(537, 182);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(140, 25);
            this.lblHuHong.TabIndex = 29;
            this.lblHuHong.Text = "Sách hư hỏng:";
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiPhat.Location = new System.Drawing.Point(59, 251);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(291, 25);
            this.lblPhiPhat.TabIndex = 30;
            this.lblPhiPhat.Text = "TỔNG PHÍ PHẠT: 360.000 Đ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(426, 240);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(151, 36);
            this.btnThongKe.TabIndex = 31;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(627, 240);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(151, 36);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 830);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblPhiPhat);
            this.Controls.Add(this.lblHuHong);
            this.Controls.Add(this.lblQuaHan);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.lblMuon);
            this.Controls.Add(this.dgvPhat);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPhat;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMuon;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiPhat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDong;
    }
}