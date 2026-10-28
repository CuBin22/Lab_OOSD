namespace QuanLyCuaHangNuoc.Forms
{
    partial class FrmNhanHang
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
            this.cboDDH = new System.Windows.Forms.ComboBox();
            this.lblDot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoPG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numTien = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTienDo = new System.Windows.Forms.DataGridView();
            this.dgvGiao = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnBoMH = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.dgvCTPhieu = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.AutoSize = true;
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn đặt hàng:";
            // 
            // cboDDH
            // 
            this.cboDDH.Location = new System.Drawing.Point(94, 12);
            this.cboDDH.Name = "cboDDH";
            this.cboDDH.Size = new System.Drawing.Size(420, 21);
            this.cboDDH.TabIndex = 1;
            this.cboDDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDDH.FormattingEnabled = true;
            this.cboDDH.SelectedIndexChanged += new System.EventHandler(this.cboDDH_SelectedIndexChanged);
            // 
            // lblDot
            // 
            this.lblDot.Location = new System.Drawing.Point(540, 15);
            this.lblDot.Name = "lblDot";
            this.lblDot.AutoSize = true;
            this.lblDot.TabIndex = 2;
            this.lblDot.Text = "Đợt giao tiếp theo: 1/3";
            this.lblDot.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDot.ForeColor = System.Drawing.Color.FromArgb(0, 59, 122);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.AutoSize = true;
            this.label2.TabIndex = 3;
            this.label2.Text = "Số phiếu giao:";
            // 
            // txtSoPG
            // 
            this.txtSoPG.Location = new System.Drawing.Point(94, 44);
            this.txtSoPG.Name = "txtSoPG";
            this.txtSoPG.Size = new System.Drawing.Size(100, 23);
            this.txtSoPG.TabIndex = 4;
            this.txtSoPG.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(250, 47);
            this.label3.Name = "label3";
            this.label3.AutoSize = true;
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày giao:";
            // 
            // dtNgayGiao
            // 
            this.dtNgayGiao.Location = new System.Drawing.Point(312, 44);
            this.dtNgayGiao.Name = "dtNgayGiao";
            this.dtNgayGiao.Size = new System.Drawing.Size(110, 23);
            this.dtNgayGiao.TabIndex = 6;
            this.dtNgayGiao.CustomFormat = "dd/MM/yyyy";
            this.dtNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(470, 47);
            this.label4.Name = "label4";
            this.label4.AutoSize = true;
            this.label4.TabIndex = 7;
            this.label4.Text = "Số tiền phải trả:";
            // 
            // numTien
            // 
            this.numTien.Location = new System.Drawing.Point(562, 44);
            this.numTien.Name = "numTien";
            this.numTien.Size = new System.Drawing.Size(140, 23);
            this.numTien.TabIndex = 8;
            this.numTien.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            this.numTien.ThousandsSeparator = true;
            this.numTien.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.AutoSize = true;
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiến độ nhận hàng của đơn:";
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(500, 78);
            this.label6.Name = "label6";
            this.label6.AutoSize = true;
            this.label6.TabIndex = 10;
            this.label6.Text = "Mặt hàng giao đợt này:";
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // dgvTienDo
            // 
            this.dgvTienDo.Location = new System.Drawing.Point(12, 96);
            this.dgvTienDo.Name = "dgvTienDo";
            this.dgvTienDo.Size = new System.Drawing.Size(470, 150);
            this.dgvTienDo.TabIndex = 11;
            this.dgvTienDo.AllowUserToAddRows = false;
            this.dgvTienDo.AllowUserToDeleteRows = false;
            this.dgvTienDo.AllowUserToResizeRows = false;
            this.dgvTienDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTienDo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTienDo.MultiSelect = false;
            this.dgvTienDo.ReadOnly = true;
            this.dgvTienDo.RowHeadersVisible = false;
            this.dgvTienDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgvGiao
            // 
            this.dgvGiao.Location = new System.Drawing.Point(500, 96);
            this.dgvGiao.Name = "dgvGiao";
            this.dgvGiao.Size = new System.Drawing.Size(448, 150);
            this.dgvGiao.TabIndex = 12;
            this.dgvGiao.AllowUserToAddRows = false;
            this.dgvGiao.AllowUserToDeleteRows = false;
            this.dgvGiao.AllowUserToResizeRows = false;
            this.dgvGiao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiao.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiao.MultiSelect = false;
            this.dgvGiao.ReadOnly = true;
            this.dgvGiao.RowHeadersVisible = false;
            this.dgvGiao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.AutoSize = true;
            this.label7.TabIndex = 13;
            this.label7.Text = "SL thực giao:";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(89, 252);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(90, 23);
            this.numSL.TabIndex = 14;
            this.numSL.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.ThousandsSeparator = true;
            this.numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(190, 250);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(100, 28);
            this.btnThemMH.TabIndex = 15;
            this.btnThemMH.Text = "Thêm >>";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnBoMH
            // 
            this.btnBoMH.Location = new System.Drawing.Point(500, 250);
            this.btnBoMH.Name = "btnBoMH";
            this.btnBoMH.Size = new System.Drawing.Size(110, 28);
            this.btnBoMH.TabIndex = 16;
            this.btnBoMH.Text = "Bỏ mặt hàng";
            this.btnBoMH.UseVisualStyleBackColor = true;
            this.btnBoMH.Click += new System.EventHandler(this.btnBoMH_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(790, 250);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(158, 28);
            this.btnLapPhieu.TabIndex = 17;
            this.btnLapPhieu.Text = "Lập phiếu giao";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 290);
            this.label8.Name = "label8";
            this.label8.AutoSize = true;
            this.label8.TabIndex = 18;
            this.label8.Text = "Các phiếu giao của đơn:";
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(500, 290);
            this.label9.Name = "label9";
            this.label9.AutoSize = true;
            this.label9.TabIndex = 19;
            this.label9.Text = "Chi tiết phiếu giao đang chọn:";
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.Location = new System.Drawing.Point(12, 308);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.Size = new System.Drawing.Size(470, 200);
            this.dgvPhieu.TabIndex = 20;
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AllowUserToDeleteRows = false;
            this.dgvPhieu.AllowUserToResizeRows = false;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.MultiSelect = false;
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersVisible = false;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);
            // 
            // dgvCTPhieu
            // 
            this.dgvCTPhieu.Location = new System.Drawing.Point(500, 308);
            this.dgvCTPhieu.Name = "dgvCTPhieu";
            this.dgvCTPhieu.Size = new System.Drawing.Size(448, 200);
            this.dgvCTPhieu.TabIndex = 21;
            this.dgvCTPhieu.AllowUserToAddRows = false;
            this.dgvCTPhieu.AllowUserToDeleteRows = false;
            this.dgvCTPhieu.AllowUserToResizeRows = false;
            this.dgvCTPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTPhieu.MultiSelect = false;
            this.dgvCTPhieu.ReadOnly = true;
            this.dgvCTPhieu.RowHeadersVisible = false;
            this.dgvCTPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(848, 520);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 28);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmNhanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDDH);
            this.Controls.Add(this.lblDot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoPG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtNgayGiao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTienDo);
            this.Controls.Add(this.dgvGiao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.btnBoMH);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvPhieu);
            this.Controls.Add(this.dgvCTPhieu);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNhanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhận hàng - Phiếu giao hàng";
            this.Load += new System.EventHandler(this.FrmNhanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDDH;
        private System.Windows.Forms.Label lblDot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoPG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayGiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTienDo;
        private System.Windows.Forms.DataGridView dgvGiao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnBoMH;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.DataGridView dgvCTPhieu;
        private System.Windows.Forms.Button btnDong;
    }
}
