namespace DoAnQLKaraoke
{
    partial class FrmQLKHACHHANG
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
            this.cbo_TinhTrang = new System.Windows.Forms.ComboBox();
            this.cbo_LoaiKH = new System.Windows.Forms.ComboBox();
            this.btn_qlLoaiKH = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.colMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAIKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHOKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNAMSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grbdstknv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_TinhTrang
            // 
            this.cbo_TinhTrang.FormattingEnabled = true;
            this.cbo_TinhTrang.Location = new System.Drawing.Point(140, 144);
            this.cbo_TinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_TinhTrang.Name = "cbo_TinhTrang";
            this.cbo_TinhTrang.Size = new System.Drawing.Size(223, 24);
            this.cbo_TinhTrang.TabIndex = 29;
            // 
            // cbo_LoaiKH
            // 
            this.cbo_LoaiKH.FormattingEnabled = true;
            this.cbo_LoaiKH.Location = new System.Drawing.Point(140, 81);
            this.cbo_LoaiKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_LoaiKH.Name = "cbo_LoaiKH";
            this.cbo_LoaiKH.Size = new System.Drawing.Size(223, 24);
            this.cbo_LoaiKH.TabIndex = 28;
            // 
            // btn_qlLoaiKH
            // 
            this.btn_qlLoaiKH.Location = new System.Drawing.Point(384, 84);
            this.btn_qlLoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_qlLoaiKH.Name = "btn_qlLoaiKH";
            this.btn_qlLoaiKH.Size = new System.Drawing.Size(28, 23);
            this.btn_qlLoaiKH.TabIndex = 27;
            this.btn_qlLoaiKH.Text = "+";
            this.btn_qlLoaiKH.UseVisualStyleBackColor = true;
            this.btn_qlLoaiKH.Click += new System.EventHandler(this.btn_qlLoaiKH_Click_1);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(1139, 81);
            this.btn_lamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_lamMoi.Size = new System.Drawing.Size(107, 55);
            this.btn_lamMoi.TabIndex = 26;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click_1);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(805, 84);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(104, 52);
            this.btn_luu.TabIndex = 25;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.Image = global::DoAnQLKaraoke.Properties.Resources.search;
            this.btn_traCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuu.Location = new System.Drawing.Point(1253, 81);
            this.btn_traCuu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_traCuu.Size = new System.Drawing.Size(108, 55);
            this.btn_traCuu.TabIndex = 22;
            this.btn_traCuu.Text = "Tra cứu";
            this.btn_traCuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_traCuu.UseVisualStyleBackColor = true;
            this.btn_traCuu.Click += new System.EventHandler(this.btn_traCuu_Click_1);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capNhat.Image = global::DoAnQLKaraoke.Properties.Resources.edit;
            this.btn_capNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capNhat.Location = new System.Drawing.Point(1024, 84);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(107, 52);
            this.btn_capNhat.TabIndex = 23;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DoAnQLKaraoke.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(916, 86);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 52);
            this.btn_them.TabIndex = 24;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(885, 27);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(200, 22);
            this.txt_SDT.TabIndex = 1;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(557, 82);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(223, 22);
            this.txt_Ten.TabIndex = 1;
            this.txt_Ten.TextChanged += new System.EventHandler(this.txt_Ten_TextChanged);
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(140, 31);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(223, 22);
            this.txt_MaKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(449, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "TênKH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(816, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "SDT";
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(121, 23);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(1252, 68);
            this.lbldanhsachnv.TabIndex = 16;
            this.lbldanhsachnv.Text = "Quản Lý Khách Hàng";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbdstknv
            // 
            this.grbdstknv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbdstknv.Controls.Add(this.cbo_TinhTrang);
            this.grbdstknv.Controls.Add(this.cbo_LoaiKH);
            this.grbdstknv.Controls.Add(this.btn_qlLoaiKH);
            this.grbdstknv.Controls.Add(this.btn_lamMoi);
            this.grbdstknv.Controls.Add(this.btn_luu);
            this.grbdstknv.Controls.Add(this.btn_traCuu);
            this.grbdstknv.Controls.Add(this.btn_capNhat);
            this.grbdstknv.Controls.Add(this.btn_them);
            this.grbdstknv.Controls.Add(this.txt_SDT);
            this.grbdstknv.Controls.Add(this.txt_Ten);
            this.grbdstknv.Controls.Add(this.txt_MaKH);
            this.grbdstknv.Controls.Add(this.label2);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.label4);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(28, 110);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Size = new System.Drawing.Size(1364, 191);
            this.grbdstknv.TabIndex = 17;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(32, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(32, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại KH\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(32, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã KH";
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMA,
            this.colLOAI,
            this.colTEN,
            this.colSDTKH,
            this.colTT});
            this.dgv_KhachHang.Location = new System.Drawing.Point(28, 318);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1364, 247);
            this.dgv_KhachHang.TabIndex = 18;
            this.dgv_KhachHang.SelectionChanged += new System.EventHandler(this.dgv_KhachHang_SelectionChanged);
            // 
            // colMA
            // 
            this.colMA.DataPropertyName = "MAKH";
            this.colMA.HeaderText = "MAKH";
            this.colMA.Name = "colMA";
            // 
            // colLOAI
            // 
            this.colLOAI.DataPropertyName = "LOAIKH";
            this.colLOAI.HeaderText = "LOAIKH";
            this.colLOAI.Name = "colLOAI";
            // 
            // colTEN
            // 
            this.colTEN.DataPropertyName = "TENKH";
            this.colTEN.HeaderText = "TENKH";
            this.colTEN.Name = "colTEN";
            // 
            // colSDTKH
            // 
            this.colSDTKH.DataPropertyName = "SDT";
            this.colSDTKH.HeaderText = "SDT";
            this.colSDTKH.Name = "colSDTKH";
            // 
            // colTT
            // 
            this.colTT.DataPropertyName = "TINHTRANG";
            this.colTT.HeaderText = "TINHTRANG";
            this.colTT.Name = "colTT";
            // 
            // colMAKH
            // 
            this.colMAKH.DataPropertyName = "MAKH";
            this.colMAKH.HeaderText = "MAKH";
            this.colMAKH.Name = "colMAKH";
            // 
            // colLOAIKH
            // 
            this.colLOAIKH.DataPropertyName = "LOAIKH";
            this.colLOAIKH.HeaderText = "LOAIKH";
            this.colLOAIKH.Name = "colLOAIKH";
            this.colLOAIKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLOAIKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colHOKH
            // 
            this.colHOKH.DataPropertyName = "HOKH";
            this.colHOKH.HeaderText = "HOKH";
            this.colHOKH.Name = "colHOKH";
            // 
            // colTENKH
            // 
            this.colTENKH.DataPropertyName = "TENKH";
            this.colTENKH.HeaderText = "TENKH";
            this.colTENKH.Name = "colTENKH";
            // 
            // colNAMSINH
            // 
            this.colNAMSINH.DataPropertyName = "NAMSINH";
            this.colNAMSINH.HeaderText = "NAMSINH";
            this.colNAMSINH.Name = "colNAMSINH";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "SDT";
            this.colSDT.Name = "colSDT";
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.HeaderText = "TINHTRANG";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTINHTRANG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmQLKHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1421, 588);
            this.Controls.Add(this.lbldanhsachnv);
            this.Controls.Add(this.grbdstknv);
            this.Controls.Add(this.dgv_KhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQLKHACHHANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLKHACHHANG";
            this.Load += new System.EventHandler(this.FrmQLKHACHHANG_Load);
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        private void btn_qlLoaiKH_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }



        private void btn_them_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btn_capNhat_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btn_traCuu_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        //private void btn_luu_Click(object sender, System.EventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        private void btn_lamMoi_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.ComboBox cbo_TinhTrang;
        private System.Windows.Forms.ComboBox cbo_LoaiKH;
        private System.Windows.Forms.Button btn_qlLoaiKH;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_traCuu;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLOAIKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNAMSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTINHTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMA;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTT;

        //public System.EventHandler dgv_KhachHang_SelectionChanged { get; set; }
    }
}