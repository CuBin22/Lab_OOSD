namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmThanhToan
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
            this.lblLoaiPhieu = new System.Windows.Forms.Label();
            this.txtLoaiPhieu = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblDaThanhToan = new System.Windows.Forms.Label();
            this.txtDaThanhToan = new System.Windows.Forms.TextBox();
            this.lblConLai = new System.Windows.Forms.Label();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.lblLoaiThanhToan = new System.Windows.Forms.Label();
            this.cboLoaiThanhToan = new System.Windows.Forms.ComboBox();
            this.lblHinhThucTT = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyMatCoc = new System.Windows.Forms.Button();
            this.btnInBienNhan = new System.Windows.Forms.Button();
            this.lblLichSu = new System.Windows.Forms.Label();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.grpThanhToan.SuspendLayout();
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
            this.cboPhieu.SelectedIndexChanged += new System.EventHandler(this.cboPhieu_SelectedIndexChanged);
            // 
            // lblLoaiPhieu
            // 
            this.lblLoaiPhieu.AutoSize = true;
            this.lblLoaiPhieu.Location = new System.Drawing.Point(660, 23);
            this.lblLoaiPhieu.Name = "lblLoaiPhieu";
            this.lblLoaiPhieu.Size = new System.Drawing.Size(73, 13);
            this.lblLoaiPhieu.TabIndex = 2;
            this.lblLoaiPhieu.Text = "Loại phiếu:";
            // 
            // txtLoaiPhieu
            // 
            this.txtLoaiPhieu.ReadOnly = true;
            this.txtLoaiPhieu.Location = new System.Drawing.Point(730, 20);
            this.txtLoaiPhieu.Name = "txtLoaiPhieu";
            this.txtLoaiPhieu.Size = new System.Drawing.Size(150, 20);
            this.txtLoaiPhieu.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(20, 60);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(67, 13);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTongTien.Location = new System.Drawing.Point(120, 57);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(130, 20);
            this.txtTongTien.TabIndex = 5;
            // 
            // lblDaThanhToan
            // 
            this.lblDaThanhToan.AutoSize = true;
            this.lblDaThanhToan.Location = new System.Drawing.Point(270, 60);
            this.lblDaThanhToan.Name = "lblDaThanhToan";
            this.lblDaThanhToan.Size = new System.Drawing.Size(92, 13);
            this.lblDaThanhToan.TabIndex = 6;
            this.lblDaThanhToan.Text = "Đã thanh toán:";
            // 
            // txtDaThanhToan
            // 
            this.txtDaThanhToan.ReadOnly = true;
            this.txtDaThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDaThanhToan.Location = new System.Drawing.Point(360, 57);
            this.txtDaThanhToan.Name = "txtDaThanhToan";
            this.txtDaThanhToan.Size = new System.Drawing.Size(130, 20);
            this.txtDaThanhToan.TabIndex = 7;
            // 
            // lblConLai
            // 
            this.lblConLai.AutoSize = true;
            this.lblConLai.Location = new System.Drawing.Point(510, 60);
            this.lblConLai.Name = "lblConLai";
            this.lblConLai.Size = new System.Drawing.Size(54, 13);
            this.lblConLai.TabIndex = 8;
            this.lblConLai.Text = "Còn lại:";
            // 
            // txtConLai
            // 
            this.txtConLai.ReadOnly = true;
            this.txtConLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConLai.Location = new System.Drawing.Point(570, 57);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(130, 20);
            this.txtConLai.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(20, 92);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 13);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Location = new System.Drawing.Point(120, 89);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(200, 20);
            this.txtTrangThai.TabIndex = 11;
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Location = new System.Drawing.Point(20, 125);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(860, 110);
            this.grpThanhToan.TabIndex = 12;
            this.grpThanhToan.Text = "Ghi nhận thanh toán";
            this.grpThanhToan.Controls.Add(this.lblLoaiThanhToan);
            this.grpThanhToan.Controls.Add(this.cboLoaiThanhToan);
            this.grpThanhToan.Controls.Add(this.lblHinhThucTT);
            this.grpThanhToan.Controls.Add(this.cboHinhThuc);
            this.grpThanhToan.Controls.Add(this.lblSoTien);
            this.grpThanhToan.Controls.Add(this.txtSoTien);
            this.grpThanhToan.Controls.Add(this.btnThanhToan);
            this.grpThanhToan.Controls.Add(this.btnHuyMatCoc);
            this.grpThanhToan.Controls.Add(this.btnInBienNhan);
            // 
            // lblLoaiThanhToan
            // 
            this.lblLoaiThanhToan.AutoSize = true;
            this.lblLoaiThanhToan.Location = new System.Drawing.Point(15, 30);
            this.lblLoaiThanhToan.Name = "lblLoaiThanhToan";
            this.lblLoaiThanhToan.Size = new System.Drawing.Size(104, 13);
            this.lblLoaiThanhToan.TabIndex = 0;
            this.lblLoaiThanhToan.Text = "Loại thanh toán:";
            // 
            // cboLoaiThanhToan
            // 
            this.cboLoaiThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThanhToan.FormattingEnabled = true;
            this.cboLoaiThanhToan.Items.AddRange(new object[] {
            "Đặt cọc",
            "Tiền vé",
            "Kinh phí đoàn"});
            this.cboLoaiThanhToan.Location = new System.Drawing.Point(115, 27);
            this.cboLoaiThanhToan.Name = "cboLoaiThanhToan";
            this.cboLoaiThanhToan.Size = new System.Drawing.Size(150, 21);
            this.cboLoaiThanhToan.TabIndex = 1;
            this.cboLoaiThanhToan.SelectedIndexChanged += new System.EventHandler(this.cboLoaiThanhToan_SelectedIndexChanged);
            // 
            // lblHinhThucTT
            // 
            this.lblHinhThucTT.AutoSize = true;
            this.lblHinhThucTT.Location = new System.Drawing.Point(290, 30);
            this.lblHinhThucTT.Name = "lblHinhThucTT";
            this.lblHinhThucTT.Size = new System.Drawing.Size(67, 13);
            this.lblHinhThucTT.TabIndex = 2;
            this.lblHinhThucTT.Text = "Hình thức:";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ",
            "Ví điện tử"});
            this.cboHinhThuc.Location = new System.Drawing.Point(355, 27);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(130, 21);
            this.cboHinhThuc.TabIndex = 3;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(505, 30);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(54, 13);
            this.lblSoTien.TabIndex = 4;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTien.Location = new System.Drawing.Point(555, 27);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(130, 20);
            this.txtSoTien.TabIndex = 5;
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien_KeyPress);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Location = new System.Drawing.Point(710, 23);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(130, 28);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuyMatCoc
            // 
            this.btnHuyMatCoc.UseVisualStyleBackColor = true;
            this.btnHuyMatCoc.Location = new System.Drawing.Point(15, 66);
            this.btnHuyMatCoc.Name = "btnHuyMatCoc";
            this.btnHuyMatCoc.Size = new System.Drawing.Size(160, 28);
            this.btnHuyMatCoc.TabIndex = 7;
            this.btnHuyMatCoc.Text = "Hủy phiếu (mất cọc)";
            this.btnHuyMatCoc.Click += new System.EventHandler(this.btnHuyMatCoc_Click);
            // 
            // btnInBienNhan
            // 
            this.btnInBienNhan.UseVisualStyleBackColor = true;
            this.btnInBienNhan.Location = new System.Drawing.Point(185, 66);
            this.btnInBienNhan.Name = "btnInBienNhan";
            this.btnInBienNhan.Size = new System.Drawing.Size(130, 28);
            this.btnInBienNhan.TabIndex = 8;
            this.btnInBienNhan.Text = "In biên nhận";
            this.btnInBienNhan.Click += new System.EventHandler(this.btnInBienNhan_Click);
            // 
            // lblLichSu
            // 
            this.lblLichSu.AutoSize = true;
            this.lblLichSu.Location = new System.Drawing.Point(20, 247);
            this.lblLichSu.Name = "lblLichSu";
            this.lblLichSu.Size = new System.Drawing.Size(186, 13);
            this.lblLichSu.TabIndex = 13;
            this.lblLichSu.Text = "Lịch sử thanh toán của phiếu:";
            // 
            // dgvThanhToan
            // 
            this.dgvThanhToan.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvThanhToan.AllowUserToAddRows = false;
            this.dgvThanhToan.AllowUserToDeleteRows = false;
            this.dgvThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhToan.MultiSelect = false;
            this.dgvThanhToan.ReadOnly = true;
            this.dgvThanhToan.RowHeadersVisible = false;
            this.dgvThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhToan.Location = new System.Drawing.Point(20, 265);
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.Size = new System.Drawing.Size(860, 240);
            this.dgvThanhToan.TabIndex = 14;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(20, 530);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(4, 13);
            this.lblThongBao.TabIndex = 15;
            this.lblThongBao.Text = "";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(805, 522);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 565);
            this.Controls.Add(this.lblPhieu);
            this.Controls.Add(this.cboPhieu);
            this.Controls.Add(this.lblLoaiPhieu);
            this.Controls.Add(this.txtLoaiPhieu);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblDaThanhToan);
            this.Controls.Add(this.txtDaThanhToan);
            this.Controls.Add(this.lblConLai);
            this.Controls.Add(this.txtConLai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.lblLichSu);
            this.Controls.Add(this.dgvThanhToan);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnDong);
            this.MinimumSize = new System.Drawing.Size(900, 565);
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.FrmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieu;
        private System.Windows.Forms.ComboBox cboPhieu;
        private System.Windows.Forms.Label lblLoaiPhieu;
        private System.Windows.Forms.TextBox txtLoaiPhieu;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblDaThanhToan;
        private System.Windows.Forms.TextBox txtDaThanhToan;
        private System.Windows.Forms.Label lblConLai;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblLoaiThanhToan;
        private System.Windows.Forms.ComboBox cboLoaiThanhToan;
        private System.Windows.Forms.Label lblHinhThucTT;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyMatCoc;
        private System.Windows.Forms.Button btnInBienNhan;
        private System.Windows.Forms.Label lblLichSu;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDong;
    }
}
