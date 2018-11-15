namespace DoAnQLKaraoke
{
    partial class FrmQLPhong
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
            this.cbo_tinhtrang = new System.Windows.Forms.ComboBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_tenPhONG = new System.Windows.Forms.TextBox();
            this.txt_maPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.btn_qlLoaiPhong = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.cbo_loaiPhong = new System.Windows.Forms.ComboBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_phong = new System.Windows.Forms.DataGridView();
            this.colMAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAIPHONG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGIAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grbdstknv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(228, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá Phòng";
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.FormattingEnabled = true;
            this.cbo_tinhtrang.Location = new System.Drawing.Point(680, 88);
            this.cbo_tinhtrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Size = new System.Drawing.Size(121, 24);
            this.cbo_tinhtrang.TabIndex = 2;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(338, 131);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(223, 22);
            this.txt_gia.TabIndex = 1;
            this.txt_gia.TextChanged += new System.EventHandler(this.txt_gia_TextChanged);
            // 
            // txt_tenPhONG
            // 
            this.txt_tenPhONG.Location = new System.Drawing.Point(338, 88);
            this.txt_tenPhONG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenPhONG.Name = "txt_tenPhONG";
            this.txt_tenPhONG.Size = new System.Drawing.Size(223, 22);
            this.txt_tenPhONG.TabIndex = 1;
            // 
            // txt_maPhong
            // 
            this.txt_maPhong.Location = new System.Drawing.Point(338, 41);
            this.txt_maPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maPhong.Name = "txt_maPhong";
            this.txt_maPhong.Size = new System.Drawing.Size(223, 22);
            this.txt_maPhong.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(581, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tình Trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(581, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loại Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(226, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(226, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Phòng";
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(124, 9);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(912, 74);
            this.lbldanhsachnv.TabIndex = 5;
            this.lbldanhsachnv.Text = "Quản Lý Phòng";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldanhsachnv.Click += new System.EventHandler(this.lbldanhsachnv_Click);
            // 
            // grbdstknv
            // 
            this.grbdstknv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbdstknv.Controls.Add(this.btn_qlLoaiPhong);
            this.grbdstknv.Controls.Add(this.btn_lamMoi);
            this.grbdstknv.Controls.Add(this.cbo_loaiPhong);
            this.grbdstknv.Controls.Add(this.btn_luu);
            this.grbdstknv.Controls.Add(this.btn_traCuu);
            this.grbdstknv.Controls.Add(this.btn_capNhat);
            this.grbdstknv.Controls.Add(this.btn_them);
            this.grbdstknv.Controls.Add(this.label1);
            this.grbdstknv.Controls.Add(this.cbo_tinhtrang);
            this.grbdstknv.Controls.Add(this.txt_gia);
            this.grbdstknv.Controls.Add(this.txt_tenPhONG);
            this.grbdstknv.Controls.Add(this.txt_maPhong);
            this.grbdstknv.Controls.Add(this.label8);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(58, 85);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Size = new System.Drawing.Size(1049, 271);
            this.grbdstknv.TabIndex = 6;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // btn_qlLoaiPhong
            // 
            this.btn_qlLoaiPhong.Location = new System.Drawing.Point(808, 44);
            this.btn_qlLoaiPhong.Name = "btn_qlLoaiPhong";
            this.btn_qlLoaiPhong.Size = new System.Drawing.Size(28, 23);
            this.btn_qlLoaiPhong.TabIndex = 21;
            this.btn_qlLoaiPhong.Text = "+";
            this.btn_qlLoaiPhong.UseVisualStyleBackColor = true;
            this.btn_qlLoaiPhong.Click += new System.EventHandler(this.btn_qlLoaiPhong_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(619, 186);
            this.btn_lamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_lamMoi.Size = new System.Drawing.Size(106, 52);
            this.btn_lamMoi.TabIndex = 20;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // cbo_loaiPhong
            // 
            this.cbo_loaiPhong.FormattingEnabled = true;
            this.cbo_loaiPhong.Location = new System.Drawing.Point(681, 43);
            this.cbo_loaiPhong.Name = "cbo_loaiPhong";
            this.cbo_loaiPhong.Size = new System.Drawing.Size(121, 24);
            this.cbo_loaiPhong.TabIndex = 19;
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(326, 186);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(76, 52);
            this.btn_luu.TabIndex = 18;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.Image = global::DoAnQLKaraoke.Properties.Resources.search;
            this.btn_traCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuu.Location = new System.Drawing.Point(31, 195);
            this.btn_traCuu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_traCuu.Size = new System.Drawing.Size(106, 52);
            this.btn_traCuu.TabIndex = 15;
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
            this.btn_capNhat.Location = new System.Drawing.Point(505, 186);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(106, 52);
            this.btn_capNhat.TabIndex = 16;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DoAnQLKaraoke.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(409, 186);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(88, 52);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_phong
            // 
            this.dgv_phong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMAPHONG,
            this.colTENPHONG,
            this.colLOAIPHONG,
            this.colGIAPHONG,
            this.colTINHTRANG});
            this.dgv_phong.Location = new System.Drawing.Point(58, 360);
            this.dgv_phong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_phong.Name = "dgv_phong";
            this.dgv_phong.RowTemplate.Height = 24;
            this.dgv_phong.Size = new System.Drawing.Size(1047, 203);
            this.dgv_phong.TabIndex = 4;
            this.dgv_phong.SelectionChanged += new System.EventHandler(this.dgv_phong_SelectionChanged);
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.DataPropertyName = "MAPHONG";
            this.colMAPHONG.HeaderText = "Mã Phòng";
            this.colMAPHONG.Name = "colMAPHONG";
            // 
            // colTENPHONG
            // 
            this.colTENPHONG.DataPropertyName = "TENPHONG";
            this.colTENPHONG.HeaderText = "Tên Phòng";
            this.colTENPHONG.Name = "colTENPHONG";
            // 
            // colLOAIPHONG
            // 
            this.colLOAIPHONG.DataPropertyName = "LOAIPHONG";
            this.colLOAIPHONG.HeaderText = "Loại Phòng";
            this.colLOAIPHONG.Name = "colLOAIPHONG";
            this.colLOAIPHONG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLOAIPHONG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colGIAPHONG
            // 
            this.colGIAPHONG.DataPropertyName = "GIAPHONG";
            this.colGIAPHONG.HeaderText = "Giá Phòng";
            this.colGIAPHONG.Name = "colGIAPHONG";
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.HeaderText = "Tình Trạng";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 604);
            this.Controls.Add(this.lbldanhsachnv);
            this.Controls.Add(this.grbdstknv);
            this.Controls.Add(this.dgv_phong);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQLPhong";
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.FrmQLPhong_Load);
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_tinhtrang;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_tenPhONG;
        private System.Windows.Forms.TextBox txt_maPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.DataGridView dgv_phong;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_traCuu;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbo_loaiPhong;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENPHONG;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLOAIPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGIAPHONG;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTINHTRANG;
        private System.Windows.Forms.Button btn_qlLoaiPhong;
    }
}