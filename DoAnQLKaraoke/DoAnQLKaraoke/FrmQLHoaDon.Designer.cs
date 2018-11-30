namespace DoAnQLKaraoke
{
    partial class FrmQLHoaDon
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
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_thoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.cbo_loaiPhong = new System.Windows.Forms.ComboBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_traCuuSDT = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tenPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lv_HoaDonChuaThanhToan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_InHD = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.grbdstknv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(361, 6);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(473, 74);
            this.lbldanhsachnv.TabIndex = 8;
            this.lbldanhsachnv.Text = "Quản Lý Hóa Đơn";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbdstknv
            // 
            this.grbdstknv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.dtp_thoiGianBatDau);
            this.grbdstknv.Controls.Add(this.btn_them);
            this.grbdstknv.Controls.Add(this.btn_lamMoi);
            this.grbdstknv.Controls.Add(this.cbo_loaiPhong);
            this.grbdstknv.Controls.Add(this.btn_luu);
            this.grbdstknv.Controls.Add(this.btn_traCuuSDT);
            this.grbdstknv.Controls.Add(this.btn_capNhat);
            this.grbdstknv.Controls.Add(this.label1);
            this.grbdstknv.Controls.Add(this.txt_gia);
            this.grbdstknv.Controls.Add(this.txt_maHD);
            this.grbdstknv.Controls.Add(this.txt_tenKH);
            this.grbdstknv.Controls.Add(this.txt_sdt);
            this.grbdstknv.Controls.Add(this.txt_tenPhong);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label2);
            this.grbdstknv.Controls.Add(this.label4);
            this.grbdstknv.Controls.Add(this.label9);
            this.grbdstknv.Controls.Add(this.label3);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(19, 79);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Size = new System.Drawing.Size(614, 343);
            this.grbdstknv.TabIndex = 9;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            this.grbdstknv.Enter += new System.EventHandler(this.grbdstknv_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Thời gian";
            // 
            // dtp_thoiGianBatDau
            // 
            this.dtp_thoiGianBatDau.CustomFormat = "HH:mm:ss ";
            this.dtp_thoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thoiGianBatDau.Location = new System.Drawing.Point(415, 29);
            this.dtp_thoiGianBatDau.Name = "dtp_thoiGianBatDau";
            this.dtp_thoiGianBatDau.Size = new System.Drawing.Size(182, 22);
            this.dtp_thoiGianBatDau.TabIndex = 22;
            this.dtp_thoiGianBatDau.Value = new System.DateTime(2018, 11, 16, 15, 29, 36, 0);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.Image = global::DoAnQLKaraoke.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(116, 259);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 56);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(328, 263);
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
            this.cbo_loaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loaiPhong.FormattingEnabled = true;
            this.cbo_loaiPhong.Location = new System.Drawing.Point(116, 60);
            this.cbo_loaiPhong.Name = "cbo_loaiPhong";
            this.cbo_loaiPhong.Size = new System.Drawing.Size(146, 24);
            this.cbo_loaiPhong.TabIndex = 19;
            this.cbo_loaiPhong.SelectionChangeCommitted += new System.EventHandler(this.cbo_loaiPhong_SelectionChangeCommitted);
            this.cbo_loaiPhong.MouseLeave += new System.EventHandler(this.cbo_loaiPhong_MouseLeave);
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_luu.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(29, 263);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(76, 52);
            this.btn_luu.TabIndex = 18;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_traCuuSDT
            // 
            this.btn_traCuuSDT.Image = global::DoAnQLKaraoke.Properties.Resources.search;
            this.btn_traCuuSDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuuSDT.Location = new System.Drawing.Point(269, 132);
            this.btn_traCuuSDT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_traCuuSDT.Name = "btn_traCuuSDT";
            this.btn_traCuuSDT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_traCuuSDT.Size = new System.Drawing.Size(37, 26);
            this.btn_traCuuSDT.TabIndex = 15;
            this.btn_traCuuSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_traCuuSDT.UseVisualStyleBackColor = true;
            this.btn_traCuuSDT.Click += new System.EventHandler(this.btn_traCuuSDT_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capNhat.Image = global::DoAnQLKaraoke.Properties.Resources.edit;
            this.btn_capNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capNhat.Location = new System.Drawing.Point(214, 263);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(106, 52);
            this.btn_capNhat.TabIndex = 16;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá Phòng";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(116, 215);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(146, 22);
            this.txt_gia.TabIndex = 1;
            this.txt_gia.TextChanged += new System.EventHandler(this.txt_gia_TextChanged);
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(116, 29);
            this.txt_maHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(148, 22);
            this.txt_maHD.TabIndex = 1;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Location = new System.Drawing.Point(116, 163);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenKH.Multiline = true;
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(146, 39);
            this.txt_tenKH.TabIndex = 1;
            this.txt_tenKH.TextChanged += new System.EventHandler(this.txt_tenKH_TextChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(116, 132);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(146, 22);
            this.txt_sdt.TabIndex = 1;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            // 
            // txt_tenPhong
            // 
            this.txt_tenPhong.Location = new System.Drawing.Point(116, 96);
            this.txt_tenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenPhong.Name = "txt_tenPhong";
            this.txt_tenPhong.Size = new System.Drawing.Size(148, 22);
            this.txt_tenPhong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(29, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Khách\r\n        Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(21, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "SĐT Khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên phòng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lv_HoaDonChuaThanhToan
            // 
            this.lv_HoaDonChuaThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_HoaDonChuaThanhToan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lv_HoaDonChuaThanhToan.Location = new System.Drawing.Point(639, 83);
            this.lv_HoaDonChuaThanhToan.Name = "lv_HoaDonChuaThanhToan";
            this.lv_HoaDonChuaThanhToan.Size = new System.Drawing.Size(500, 339);
            this.lv_HoaDonChuaThanhToan.TabIndex = 10;
            this.lv_HoaDonChuaThanhToan.UseCompatibleStateImageBehavior = false;
            this.lv_HoaDonChuaThanhToan.SelectedIndexChanged += new System.EventHandler(this.lv_HoaDonChuaThanhToan_SelectedIndexChanged);
            // 
            // btn_InHD
            // 
            this.btn_InHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_InHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InHD.Location = new System.Drawing.Point(171, 435);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(96, 52);
            this.btn_InHD.TabIndex = 44;
            this.btn_InHD.Text = "Xem nhanh hóa đơn";
            this.btn_InHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_thanhtoan.Location = new System.Drawing.Point(48, 435);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(106, 52);
            this.btn_thanhtoan.TabIndex = 45;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TraCuu.Image = global::DoAnQLKaraoke.Properties.Resources.search;
            this.btn_TraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TraCuu.Location = new System.Drawing.Point(1018, 434);
            this.btn_TraCuu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_TraCuu.Size = new System.Drawing.Size(106, 52);
            this.btn_TraCuu.TabIndex = 20;
            this.btn_TraCuu.Text = "Tra cứu";
            this.btn_TraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TraCuu.UseVisualStyleBackColor = true;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // FrmQLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 499);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.lv_HoaDonChuaThanhToan);
            this.Controls.Add(this.btn_TraCuu);
            this.Controls.Add(this.lbldanhsachnv);
            this.Controls.Add(this.grbdstknv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQLHoaDon";
            this.Text = "FormQLHoaDon";
            this.Load += new System.EventHandler(this.FrmQLHoaDon_Load);
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.ComboBox cbo_loaiPhong;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_traCuuSDT;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_tenPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_thoiGianBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_HoaDonChuaThanhToan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_TraCuu;
    }
}