namespace DoAnQLKaraoke
{
    partial class FrmQLTaiKhoan
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
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.colMAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAIND = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo_manv = new System.Windows.Forms.ComboBox();
            this.txt_MaND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_qlLoaiTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_TT = new System.Windows.Forms.ComboBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.ckh_doimk = new System.Windows.Forms.CheckBox();
            this.cbo_LoaiND = new System.Windows.Forms.ComboBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            this.grbdstknv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(153, 9);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(1252, 68);
            this.lbldanhsachnv.TabIndex = 6;
            this.lbldanhsachnv.Text = "Quản Lý Người Dùng";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMAND,
            this.MANV,
            this.colTAIKHOAN,
            this.colMATKHAU,
            this.colLOAIND,
            this.colTINHTRANG});
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(22, 322);
            this.dgv_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            this.dgv_TaiKhoan.RowTemplate.Height = 24;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(1215, 212);
            this.dgv_TaiKhoan.TabIndex = 7;
            this.dgv_TaiKhoan.SelectionChanged += new System.EventHandler(this.dgv_TaiKhoan_SelectionChanged);
            // 
            // colMAND
            // 
            this.colMAND.DataPropertyName = "MAND";
            this.colMAND.HeaderText = "MAND";
            this.colMAND.Name = "colMAND";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MANV";
            this.MANV.Name = "MANV";
            // 
            // colTAIKHOAN
            // 
            this.colTAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.colTAIKHOAN.HeaderText = "Tài Khoản";
            this.colTAIKHOAN.Name = "colTAIKHOAN";
            // 
            // colMATKHAU
            // 
            this.colMATKHAU.DataPropertyName = "MATKHAU";
            this.colMATKHAU.HeaderText = "Mật Khẩu";
            this.colMATKHAU.Name = "colMATKHAU";
            // 
            // colLOAIND
            // 
            this.colLOAIND.DataPropertyName = "LOAIND";
            this.colLOAIND.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colLOAIND.HeaderText = "Loại Người Dùng";
            this.colLOAIND.Name = "colLOAIND";
            this.colLOAIND.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLOAIND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTINHTRANG.HeaderText = "Tình Trạng";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTINHTRANG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cbo_manv
            // 
            this.cbo_manv.FormattingEnabled = true;
            this.cbo_manv.Location = new System.Drawing.Point(584, 45);
            this.cbo_manv.Name = "cbo_manv";
            this.cbo_manv.Size = new System.Drawing.Size(121, 24);
            this.cbo_manv.TabIndex = 31;
            // 
            // txt_MaND
            // 
            this.txt_MaND.Location = new System.Drawing.Point(236, 45);
            this.txt_MaND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaND.Name = "txt_MaND";
            this.txt_MaND.Size = new System.Drawing.Size(223, 22);
            this.txt_MaND.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(145, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã ND";
            // 
            // btn_qlLoaiTK
            // 
            this.btn_qlLoaiTK.Location = new System.Drawing.Point(711, 91);
            this.btn_qlLoaiTK.Name = "btn_qlLoaiTK";
            this.btn_qlLoaiTK.Size = new System.Drawing.Size(28, 23);
            this.btn_qlLoaiTK.TabIndex = 28;
            this.btn_qlLoaiTK.Text = "+";
            this.btn_qlLoaiTK.UseVisualStyleBackColor = true;
            this.btn_qlLoaiTK.Click += new System.EventHandler(this.btn_qlLoaiTK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(840, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tinh Trang";
            // 
            // cbo_TT
            // 
            this.cbo_TT.FormattingEnabled = true;
            this.cbo_TT.Location = new System.Drawing.Point(949, 34);
            this.cbo_TT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_TT.Name = "cbo_TT";
            this.cbo_TT.Size = new System.Drawing.Size(121, 24);
            this.cbo_TT.TabIndex = 26;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(920, 134);
            this.btn_lamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_lamMoi.Size = new System.Drawing.Size(107, 52);
            this.btn_lamMoi.TabIndex = 25;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(615, 134);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(76, 52);
            this.btn_luu.TabIndex = 24;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.Image = global::DoAnQLKaraoke.Properties.Resources.search;
            this.btn_traCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuu.Location = new System.Drawing.Point(1048, 134);
            this.btn_traCuu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_traCuu.Size = new System.Drawing.Size(107, 52);
            this.btn_traCuu.TabIndex = 21;
            this.btn_traCuu.Text = "Tra cứu";
            this.btn_traCuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_traCuu.UseVisualStyleBackColor = true;
            this.btn_traCuu.Click += new System.EventHandler(this.btn_traCuu_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capNhat.Image = global::DoAnQLKaraoke.Properties.Resources.edit;
            this.btn_capNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capNhat.Location = new System.Drawing.Point(805, 134);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(107, 52);
            this.btn_capNhat.TabIndex = 22;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DoAnQLKaraoke.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(709, 134);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(88, 52);
            this.btn_them.TabIndex = 23;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(493, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "MANV";
            // 
            // grbdstknv
            // 
            this.grbdstknv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbdstknv.Controls.Add(this.ckh_doimk);
            this.grbdstknv.Controls.Add(this.cbo_manv);
            this.grbdstknv.Controls.Add(this.txt_MaND);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.btn_qlLoaiTK);
            this.grbdstknv.Controls.Add(this.label1);
            this.grbdstknv.Controls.Add(this.cbo_TT);
            this.grbdstknv.Controls.Add(this.btn_lamMoi);
            this.grbdstknv.Controls.Add(this.btn_luu);
            this.grbdstknv.Controls.Add(this.btn_traCuu);
            this.grbdstknv.Controls.Add(this.btn_capNhat);
            this.grbdstknv.Controls.Add(this.btn_them);
            this.grbdstknv.Controls.Add(this.cbo_LoaiND);
            this.grbdstknv.Controls.Add(this.txtMK);
            this.grbdstknv.Controls.Add(this.txt_TK);
            this.grbdstknv.Controls.Add(this.label8);
            this.grbdstknv.Controls.Add(this.label2);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(22, 101);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Size = new System.Drawing.Size(1341, 217);
            this.grbdstknv.TabIndex = 8;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // ckh_doimk
            // 
            this.ckh_doimk.AutoSize = true;
            this.ckh_doimk.Location = new System.Drawing.Point(236, 165);
            this.ckh_doimk.Name = "ckh_doimk";
            this.ckh_doimk.Size = new System.Drawing.Size(75, 21);
            this.ckh_doimk.TabIndex = 32;
            this.ckh_doimk.Text = "Đổi MK";
            this.ckh_doimk.UseVisualStyleBackColor = true;
            this.ckh_doimk.CheckedChanged += new System.EventHandler(this.ckh_doimk_CheckedChanged);
            // 
            // cbo_LoaiND
            // 
            this.cbo_LoaiND.FormattingEnabled = true;
            this.cbo_LoaiND.Location = new System.Drawing.Point(584, 90);
            this.cbo_LoaiND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_LoaiND.Name = "cbo_LoaiND";
            this.cbo_LoaiND.Size = new System.Drawing.Size(121, 24);
            this.cbo_LoaiND.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(236, 123);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(223, 22);
            this.txtMK.TabIndex = 1;
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(236, 81);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(223, 22);
            this.txt_TK.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(493, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loại ND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(137, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(133, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tài Khoản";
            // 
            // FrmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 718);
            this.Controls.Add(this.lbldanhsachnv);
            this.Controls.Add(this.dgv_TaiKhoan);
            this.Controls.Add(this.grbdstknv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLTaiKhoan";
            this.Text = "FrmQLTaiKhoan";
            this.Load += new System.EventHandler(this.FrmQLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.DataGridView dgv_TaiKhoan;
        private System.Windows.Forms.ComboBox cbo_manv;
        private System.Windows.Forms.TextBox txt_MaND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_qlLoaiTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_TT;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_traCuu;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.ComboBox cbo_LoaiND;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckh_doimk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMATKHAU;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLOAIND;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTINHTRANG;
    }
}