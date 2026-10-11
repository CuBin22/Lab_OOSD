namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmKhaoSat
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
            this.lblPhieu = new System.Windows.Forms.Label();
            this.cboPhieu = new System.Windows.Forms.ComboBox();
            this.chkTatCa = new System.Windows.Forms.CheckBox();
            this.lblNgayGui = new System.Windows.Forms.Label();
            this.dtpNgayGui = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTraLoi = new System.Windows.Forms.Label();
            this.dtpNgayTraLoi = new System.Windows.Forms.DateTimePicker();
            this.lblDiem = new System.Windows.Forms.Label();
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            this.lblGopY = new System.Windows.Forms.Label();
            this.txtGopY = new System.Windows.Forms.TextBox();
            this.btnGuiKhaoSat = new System.Windows.Forms.Button();
            this.btnGhiNhanGopY = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvKhaoSat = new System.Windows.Forms.DataGridView();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhaoSat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhieu
            // 
            this.lblPhieu.AutoSize = true;
            this.lblPhieu.Location = new System.Drawing.Point(20, 23);
            this.lblPhieu.Name = "lblPhieu";
            this.lblPhieu.Size = new System.Drawing.Size(92, 13);
            this.lblPhieu.TabIndex = 0;
            this.lblPhieu.Text = "Phiếu đăng ký:";
            // 
            // cboPhieu
            // 
            this.cboPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhieu.FormattingEnabled = true;
            this.cboPhieu.Location = new System.Drawing.Point(120, 20);
            this.cboPhieu.Name = "cboPhieu";
            this.cboPhieu.Size = new System.Drawing.Size(520, 21);
            this.cboPhieu.TabIndex = 1;
            // 
            // chkTatCa
            // 
            this.chkTatCa.AutoSize = true;
            this.chkTatCa.UseVisualStyleBackColor = true;
            this.chkTatCa.Location = new System.Drawing.Point(660, 22);
            this.chkTatCa.Name = "chkTatCa";
            this.chkTatCa.Size = new System.Drawing.Size(131, 17);
            this.chkTatCa.TabIndex = 2;
            this.chkTatCa.Text = "Hiện tất cả phiếu";
            this.chkTatCa.CheckedChanged += new System.EventHandler(this.chkTatCa_CheckedChanged);
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = true;
            this.lblNgayGui.Location = new System.Drawing.Point(20, 56);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(60, 13);
            this.lblNgayGui.TabIndex = 3;
            this.lblNgayGui.Text = "Ngày gửi:";
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGui.Location = new System.Drawing.Point(120, 53);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.Size = new System.Drawing.Size(110, 20);
            this.dtpNgayGui.TabIndex = 4;
            // 
            // lblNgayTraLoi
            // 
            this.lblNgayTraLoi.AutoSize = true;
            this.lblNgayTraLoi.Location = new System.Drawing.Point(250, 56);
            this.lblNgayTraLoi.Name = "lblNgayTraLoi";
            this.lblNgayTraLoi.Size = new System.Drawing.Size(85, 13);
            this.lblNgayTraLoi.TabIndex = 5;
            this.lblNgayTraLoi.Text = "Ngày trả lời:";
            // 
            // dtpNgayTraLoi
            // 
            this.dtpNgayTraLoi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTraLoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTraLoi.ShowCheckBox = true;
            this.dtpNgayTraLoi.Location = new System.Drawing.Point(330, 53);
            this.dtpNgayTraLoi.Name = "dtpNgayTraLoi";
            this.dtpNgayTraLoi.Size = new System.Drawing.Size(120, 20);
            this.dtpNgayTraLoi.TabIndex = 6;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(470, 56);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(130, 13);
            this.lblDiem.TabIndex = 7;
            this.lblDiem.Text = "Điểm đánh giá (1-5):";
            // 
            // numDiem
            // 
            this.numDiem.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numDiem.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiem.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.numDiem.Location = new System.Drawing.Point(585, 53);
            this.numDiem.Name = "numDiem";
            this.numDiem.Size = new System.Drawing.Size(55, 20);
            this.numDiem.TabIndex = 8;
            // 
            // lblGopY
            // 
            this.lblGopY.AutoSize = true;
            this.lblGopY.Location = new System.Drawing.Point(20, 90);
            this.lblGopY.Name = "lblGopY";
            this.lblGopY.Size = new System.Drawing.Size(41, 13);
            this.lblGopY.TabIndex = 9;
            this.lblGopY.Text = "Góp ý:";
            // 
            // txtGopY
            // 
            this.txtGopY.Multiline = true;
            this.txtGopY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGopY.MaxLength = 500;
            this.txtGopY.Location = new System.Drawing.Point(120, 87);
            this.txtGopY.Name = "txtGopY";
            this.txtGopY.Size = new System.Drawing.Size(520, 60);
            this.txtGopY.TabIndex = 10;
            // 
            // btnGuiKhaoSat
            // 
            this.btnGuiKhaoSat.UseVisualStyleBackColor = true;
            this.btnGuiKhaoSat.Location = new System.Drawing.Point(660, 87);
            this.btnGuiKhaoSat.Name = "btnGuiKhaoSat";
            this.btnGuiKhaoSat.Size = new System.Drawing.Size(120, 28);
            this.btnGuiKhaoSat.TabIndex = 11;
            this.btnGuiKhaoSat.Text = "Gửi khảo sát";
            this.btnGuiKhaoSat.Click += new System.EventHandler(this.btnGuiKhaoSat_Click);
            // 
            // btnGhiNhanGopY
            // 
            this.btnGhiNhanGopY.UseVisualStyleBackColor = true;
            this.btnGhiNhanGopY.Location = new System.Drawing.Point(660, 119);
            this.btnGhiNhanGopY.Name = "btnGhiNhanGopY";
            this.btnGhiNhanGopY.Size = new System.Drawing.Size(120, 28);
            this.btnGhiNhanGopY.TabIndex = 12;
            this.btnGhiNhanGopY.Text = "Ghi nhận góp ý";
            this.btnGhiNhanGopY.Click += new System.EventHandler(this.btnGhiNhanGopY_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Location = new System.Drawing.Point(786, 87);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 28);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvKhaoSat
            // 
            this.dgvKhaoSat.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvKhaoSat.AllowUserToAddRows = false;
            this.dgvKhaoSat.AllowUserToDeleteRows = false;
            this.dgvKhaoSat.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhaoSat.MultiSelect = false;
            this.dgvKhaoSat.ReadOnly = true;
            this.dgvKhaoSat.RowHeadersVisible = false;
            this.dgvKhaoSat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhaoSat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhaoSat.Location = new System.Drawing.Point(20, 165);
            this.dgvKhaoSat.Name = "dgvKhaoSat";
            this.dgvKhaoSat.Size = new System.Drawing.Size(860, 330);
            this.dgvKhaoSat.TabIndex = 14;
            this.dgvKhaoSat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhaoSat_CellClick);
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(20, 510);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(4, 13);
            this.lblThongBao.TabIndex = 15;
            this.lblThongBao.Text = "";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(805, 506);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmKhaoSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 545);
            this.Controls.Add(this.lblPhieu);
            this.Controls.Add(this.cboPhieu);
            this.Controls.Add(this.chkTatCa);
            this.Controls.Add(this.lblNgayGui);
            this.Controls.Add(this.dtpNgayGui);
            this.Controls.Add(this.lblNgayTraLoi);
            this.Controls.Add(this.dtpNgayTraLoi);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.numDiem);
            this.Controls.Add(this.lblGopY);
            this.Controls.Add(this.txtGopY);
            this.Controls.Add(this.btnGuiKhaoSat);
            this.Controls.Add(this.btnGhiNhanGopY);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvKhaoSat);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnDong);
            this.MinimumSize = new System.Drawing.Size(900, 545);
            this.Name = "FrmKhaoSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khảo sát khách hàng";
            this.Load += new System.EventHandler(this.FrmKhaoSat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhaoSat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieu;
        private System.Windows.Forms.ComboBox cboPhieu;
        private System.Windows.Forms.CheckBox chkTatCa;
        private System.Windows.Forms.Label lblNgayGui;
        private System.Windows.Forms.DateTimePicker dtpNgayGui;
        private System.Windows.Forms.Label lblNgayTraLoi;
        private System.Windows.Forms.DateTimePicker dtpNgayTraLoi;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.NumericUpDown numDiem;
        private System.Windows.Forms.Label lblGopY;
        private System.Windows.Forms.TextBox txtGopY;
        private System.Windows.Forms.Button btnGuiKhaoSat;
        private System.Windows.Forms.Button btnGhiNhanGopY;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvKhaoSat;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDong;
    }
}
