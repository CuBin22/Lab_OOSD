namespace QuanLyCongTyDuLich.Forms
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
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(20, 23);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(60, 13);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Thống kê:";
            // 
            // cboLoaiThongKe
            // 
            this.cboLoaiThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThongKe.FormattingEnabled = true;
            this.cboLoaiThongKe.Items.AddRange(new object[] {
            "Đăng ký theo tour",
            "Doanh thu theo tour",
            "Phân công & tiền công nhân viên",
            "Khảo sát (điểm trung bình theo tour)",
            "Tour (lộ trình, chuyến, đoàn)",
            "Lương nhân viên theo kỳ"});
            this.cboLoaiThongKe.Location = new System.Drawing.Point(90, 20);
            this.cboLoaiThongKe.Name = "cboLoaiThongKe";
            this.cboLoaiThongKe.Size = new System.Drawing.Size(270, 21);
            this.cboLoaiThongKe.TabIndex = 1;
            this.cboLoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cboLoaiThongKe_SelectedIndexChanged);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(380, 23);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(54, 13);
            this.lblTuNgay.TabIndex = 2;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(435, 20);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(110, 20);
            this.dtpTuNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(560, 23);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(60, 13);
            this.lblDenNgay.TabIndex = 4;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(625, 20);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(110, 20);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // btnThongKe
            // 
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Location = new System.Drawing.Point(755, 17);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 28);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersVisible = false;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.Location = new System.Drawing.Point(20, 60);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(880, 400);
            this.dgvKetQua.TabIndex = 7;
            // 
            // lblTong
            // 
            this.lblTong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(20, 475);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(41, 13);
            this.lblTong.TabIndex = 8;
            this.lblTong.Text = "Tổng: ";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(825, 515);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 560);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.cboLoaiThongKe);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.btnDong);
            this.MinimumSize = new System.Drawing.Size(920, 560);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê - báo cáo";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoaiThongKe;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnDong;
    }
}
