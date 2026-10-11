namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDanhMuc
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
            this.lnkDiaDiem = new System.Windows.Forms.LinkLabel();
            this.lnkPhuongTien = new System.Windows.Forms.LinkLabel();
            this.lnkDiemThamQuan = new System.Windows.Forms.LinkLabel();
            this.lnkDiemBanVe = new System.Windows.Forms.LinkLabel();
            this.lnkDiemDon = new System.Windows.Forms.LinkLabel();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblThongTin1 = new System.Windows.Forms.Label();
            this.txtThongTin1 = new System.Windows.Forms.TextBox();
            this.lblThongTin2 = new System.Windows.Forms.Label();
            this.txtThongTin2 = new System.Windows.Forms.TextBox();
            this.lblThongTin3 = new System.Windows.Forms.Label();
            this.txtThongTin3 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkDiaDiem
            // 
            this.lnkDiaDiem.AutoSize = true;
            this.lnkDiaDiem.TabStop = true;
            this.lnkDiaDiem.Location = new System.Drawing.Point(20, 20);
            this.lnkDiaDiem.Name = "lnkDiaDiem";
            this.lnkDiaDiem.Size = new System.Drawing.Size(75, 13);
            this.lnkDiaDiem.TabIndex = 0;
            this.lnkDiaDiem.Text = "[ Địa điểm ]";
            this.lnkDiaDiem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDiaDiem_LinkClicked);
            // 
            // lnkPhuongTien
            // 
            this.lnkPhuongTien.AutoSize = true;
            this.lnkPhuongTien.TabStop = true;
            this.lnkPhuongTien.Location = new System.Drawing.Point(105, 20);
            this.lnkPhuongTien.Name = "lnkPhuongTien";
            this.lnkPhuongTien.Size = new System.Drawing.Size(94, 13);
            this.lnkPhuongTien.TabIndex = 1;
            this.lnkPhuongTien.Text = "[ Phương tiện ]";
            this.lnkPhuongTien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPhuongTien_LinkClicked);
            // 
            // lnkDiemThamQuan
            // 
            this.lnkDiemThamQuan.AutoSize = true;
            this.lnkDiemThamQuan.TabStop = true;
            this.lnkDiemThamQuan.Location = new System.Drawing.Point(205, 20);
            this.lnkDiemThamQuan.Name = "lnkDiemThamQuan";
            this.lnkDiemThamQuan.Size = new System.Drawing.Size(113, 13);
            this.lnkDiemThamQuan.TabIndex = 2;
            this.lnkDiemThamQuan.Text = "[ Điểm tham quan ]";
            this.lnkDiemThamQuan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDiemThamQuan_LinkClicked);
            // 
            // lnkDiemBanVe
            // 
            this.lnkDiemBanVe.AutoSize = true;
            this.lnkDiemBanVe.TabStop = true;
            this.lnkDiemBanVe.Location = new System.Drawing.Point(330, 20);
            this.lnkDiemBanVe.Name = "lnkDiemBanVe";
            this.lnkDiemBanVe.Size = new System.Drawing.Size(94, 13);
            this.lnkDiemBanVe.TabIndex = 3;
            this.lnkDiemBanVe.Text = "[ Điểm bán vé ]";
            this.lnkDiemBanVe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDiemBanVe_LinkClicked);
            // 
            // lnkDiemDon
            // 
            this.lnkDiemDon.AutoSize = true;
            this.lnkDiemDon.TabStop = true;
            this.lnkDiemDon.Location = new System.Drawing.Point(430, 20);
            this.lnkDiemDon.Name = "lnkDiemDon";
            this.lnkDiemDon.Size = new System.Drawing.Size(75, 13);
            this.lnkDiemDon.TabIndex = 4;
            this.lnkDiemDon.Text = "[ Điểm đón ]";
            this.lnkDiemDon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDiemDon_LinkClicked);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 63);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(22, 13);
            this.lblMa.TabIndex = 5;
            this.lblMa.Text = "Mã:";
            // 
            // txtMa
            // 
            this.txtMa.MaxLength = 20;
            this.txtMa.Location = new System.Drawing.Point(55, 60);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(150, 20);
            this.txtMa.TabIndex = 6;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(225, 63);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(29, 13);
            this.lblTen.TabIndex = 7;
            this.lblTen.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.MaxLength = 100;
            this.txtTen.Location = new System.Drawing.Point(260, 60);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(240, 20);
            this.txtTen.TabIndex = 8;
            // 
            // lblThongTin1
            // 
            this.lblThongTin1.AutoSize = true;
            this.lblThongTin1.Location = new System.Drawing.Point(520, 63);
            this.lblThongTin1.Name = "lblThongTin1";
            this.lblThongTin1.Size = new System.Drawing.Size(79, 13);
            this.lblThongTin1.TabIndex = 9;
            this.lblThongTin1.Text = "Thông tin 1:";
            // 
            // txtThongTin1
            // 
            this.txtThongTin1.MaxLength = 200;
            this.txtThongTin1.Location = new System.Drawing.Point(610, 60);
            this.txtThongTin1.Name = "txtThongTin1";
            this.txtThongTin1.Size = new System.Drawing.Size(230, 20);
            this.txtThongTin1.TabIndex = 10;
            // 
            // lblThongTin2
            // 
            this.lblThongTin2.AutoSize = true;
            this.lblThongTin2.Location = new System.Drawing.Point(20, 95);
            this.lblThongTin2.Name = "lblThongTin2";
            this.lblThongTin2.Size = new System.Drawing.Size(79, 13);
            this.lblThongTin2.TabIndex = 11;
            this.lblThongTin2.Text = "Thông tin 2:";
            // 
            // txtThongTin2
            // 
            this.txtThongTin2.MaxLength = 500;
            this.txtThongTin2.Location = new System.Drawing.Point(110, 92);
            this.txtThongTin2.Name = "txtThongTin2";
            this.txtThongTin2.Size = new System.Drawing.Size(390, 20);
            this.txtThongTin2.TabIndex = 12;
            // 
            // lblThongTin3
            // 
            this.lblThongTin3.AutoSize = true;
            this.lblThongTin3.Location = new System.Drawing.Point(520, 95);
            this.lblThongTin3.Name = "lblThongTin3";
            this.lblThongTin3.Size = new System.Drawing.Size(79, 13);
            this.lblThongTin3.TabIndex = 13;
            this.lblThongTin3.Text = "Thông tin 3:";
            // 
            // txtThongTin3
            // 
            this.txtThongTin3.MaxLength = 500;
            this.txtThongTin3.Location = new System.Drawing.Point(610, 92);
            this.txtThongTin3.Name = "txtThongTin3";
            this.txtThongTin3.Size = new System.Drawing.Size(230, 20);
            this.txtThongTin3.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Location = new System.Drawing.Point(520, 122);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Location = new System.Drawing.Point(601, 122);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Location = new System.Drawing.Point(682, 122);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Location = new System.Drawing.Point(763, 122);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(77, 26);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.Location = new System.Drawing.Point(20, 160);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Size = new System.Drawing.Size(820, 255);
            this.dgvDanhMuc.TabIndex = 19;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(20, 432);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(4, 13);
            this.lblThongBao.TabIndex = 20;
            this.lblThongBao.Text = "";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(765, 428);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 470);
            this.Controls.Add(this.lnkDiaDiem);
            this.Controls.Add(this.lnkPhuongTien);
            this.Controls.Add(this.lnkDiemThamQuan);
            this.Controls.Add(this.lnkDiemBanVe);
            this.Controls.Add(this.lnkDiemDon);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblThongTin1);
            this.Controls.Add(this.txtThongTin1);
            this.Controls.Add(this.lblThongTin2);
            this.Controls.Add(this.txtThongTin2);
            this.Controls.Add(this.lblThongTin3);
            this.Controls.Add(this.txtThongTin3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnDong);
            this.MinimumSize = new System.Drawing.Size(860, 470);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục công ty du lịch";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkDiaDiem;
        private System.Windows.Forms.LinkLabel lnkPhuongTien;
        private System.Windows.Forms.LinkLabel lnkDiemThamQuan;
        private System.Windows.Forms.LinkLabel lnkDiemBanVe;
        private System.Windows.Forms.LinkLabel lnkDiemDon;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblThongTin1;
        private System.Windows.Forms.TextBox txtThongTin1;
        private System.Windows.Forms.Label lblThongTin2;
        private System.Windows.Forms.TextBox txtThongTin2;
        private System.Windows.Forms.Label lblThongTin3;
        private System.Windows.Forms.TextBox txtThongTin3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDong;
    }
}
