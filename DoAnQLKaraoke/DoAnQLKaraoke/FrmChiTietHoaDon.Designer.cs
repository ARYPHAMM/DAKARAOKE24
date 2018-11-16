namespace DoAnQLKaraoke
{
    partial class FrmChiTietHoaDon
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
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_thoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_tenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.dgv_CTHD = new System.Windows.Forms.DataGridView();
            this.colMAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMATD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTHANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lv_thucDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_tenThucDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_thanhTien = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(855, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Thời gian";
            // 
            // dtp_thoiGianBatDau
            // 
            this.dtp_thoiGianBatDau.CustomFormat = "HH:mm:ss ";
            this.dtp_thoiGianBatDau.Enabled = false;
            this.dtp_thoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thoiGianBatDau.Location = new System.Drawing.Point(943, 71);
            this.dtp_thoiGianBatDau.Name = "dtp_thoiGianBatDau";
            this.dtp_thoiGianBatDau.Size = new System.Drawing.Size(182, 22);
            this.dtp_thoiGianBatDau.TabIndex = 32;
            this.dtp_thoiGianBatDau.Value = new System.DateTime(2018, 11, 14, 14, 38, 30, 0);
            // 
            // txt_maHD
            // 
            this.txt_maHD.Enabled = false;
            this.txt_maHD.Location = new System.Drawing.Point(118, 74);
            this.txt_maHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(148, 22);
            this.txt_maHD.TabIndex = 27;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Enabled = false;
            this.txt_tenKH.Location = new System.Drawing.Point(688, 73);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(146, 22);
            this.txt_tenKH.TabIndex = 28;
            // 
            // txt_tenPhong
            // 
            this.txt_tenPhong.Enabled = false;
            this.txt_tenPhong.Location = new System.Drawing.Point(379, 73);
            this.txt_tenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenPhong.Name = "txt_tenPhong";
            this.txt_tenPhong.Size = new System.Drawing.Size(148, 22);
            this.txt_tenPhong.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã HD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(548, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(272, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên phòng";
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(396, -3);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(473, 74);
            this.lbldanhsachnv.TabIndex = 30;
            this.lbldanhsachnv.Text = "Chi Tiết Hóa Đơn";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_CTHD
            // 
            this.dgv_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMAHD,
            this.colMATD,
            this.colTENTD,
            this.colSOLUONG,
            this.colGIA,
            this.colTHANHTIEN});
            this.dgv_CTHD.Location = new System.Drawing.Point(447, 202);
            this.dgv_CTHD.Name = "dgv_CTHD";
            this.dgv_CTHD.RowTemplate.Height = 24;
            this.dgv_CTHD.Size = new System.Drawing.Size(755, 163);
            this.dgv_CTHD.TabIndex = 34;
            this.dgv_CTHD.SelectionChanged += new System.EventHandler(this.dgv_CTHD_SelectionChanged);
            // 
            // colMAHD
            // 
            this.colMAHD.DataPropertyName = "MAHD";
            this.colMAHD.HeaderText = "MAHD";
            this.colMAHD.Name = "colMAHD";
            // 
            // colMATD
            // 
            this.colMATD.DataPropertyName = "MATD";
            this.colMATD.HeaderText = "MATD";
            this.colMATD.Name = "colMATD";
            // 
            // colTENTD
            // 
            this.colTENTD.DataPropertyName = "TENTHUCDON";
            this.colTENTD.HeaderText = "Tên Thực đơn";
            this.colTENTD.Name = "colTENTD";
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.DataPropertyName = "SOLUONG";
            this.colSOLUONG.HeaderText = "Số Lượng";
            this.colSOLUONG.Name = "colSOLUONG";
            // 
            // colGIA
            // 
            this.colGIA.DataPropertyName = "GIA";
            this.colGIA.HeaderText = "Giá";
            this.colGIA.Name = "colGIA";
            // 
            // colTHANHTIEN
            // 
            this.colTHANHTIEN.DataPropertyName = "THANHTIEN";
            this.colTHANHTIEN.HeaderText = "Thành Tiền";
            this.colTHANHTIEN.Name = "colTHANHTIEN";
            // 
            // lv_thucDon
            // 
            this.lv_thucDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_thucDon.Location = new System.Drawing.Point(32, 128);
            this.lv_thucDon.Name = "lv_thucDon";
            this.lv_thucDon.Size = new System.Drawing.Size(402, 375);
            this.lv_thucDon.TabIndex = 35;
            this.lv_thucDon.UseCompatibleStateImageBehavior = false;
            this.lv_thucDon.SelectedIndexChanged += new System.EventHandler(this.lv_thucDon_SelectedIndexChanged);
            // 
            // txt_tenThucDon
            // 
            this.txt_tenThucDon.Enabled = false;
            this.txt_tenThucDon.Location = new System.Drawing.Point(563, 128);
            this.txt_tenThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenThucDon.Name = "txt_tenThucDon";
            this.txt_tenThucDon.Size = new System.Drawing.Size(148, 22);
            this.txt_tenThucDon.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(443, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên Thực Đơn";
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(797, 130);
            this.txt_soLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(160, 22);
            this.txt_soLuong.TabIndex = 39;
            this.txt_soLuong.TextChanged += new System.EventHandler(this.txt_soLuong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(717, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Số lượng";
            // 
            // txt_gia
            // 
            this.txt_gia.Enabled = false;
            this.txt_gia.Location = new System.Drawing.Point(1004, 132);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(148, 22);
            this.txt_gia.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(963, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(906, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Thành Tiền";
            // 
            // txt_thanhTien
            // 
            this.txt_thanhTien.Enabled = false;
            this.txt_thanhTien.Location = new System.Drawing.Point(1004, 156);
            this.txt_thanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_thanhTien.Name = "txt_thanhTien";
            this.txt_thanhTien.Size = new System.Drawing.Size(148, 22);
            this.txt_thanhTien.TabIndex = 41;
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DoAnQLKaraoke.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(1159, 128);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(43, 50);
            this.btn_them.TabIndex = 42;
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_InHD
            // 
            this.btn_InHD.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_InHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InHD.Location = new System.Drawing.Point(1081, 378);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(121, 52);
            this.btn_InHD.TabIndex = 43;
            this.btn_InHD.Text = "In Hóa Đơn";
            this.btn_InHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Image = global::DoAnQLKaraoke.Properties.Resources.minus;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(447, 378);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(39, 50);
            this.btn_huy.TabIndex = 42;
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // FrmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 515);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_thanhTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenThucDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_thucDon);
            this.Controls.Add(this.dgv_CTHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_thoiGianBatDau);
            this.Controls.Add(this.txt_maHD);
            this.Controls.Add(this.txt_tenKH);
            this.Controls.Add(this.txt_tenPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbldanhsachnv);
            this.Name = "FrmChiTietHoaDon";
            this.Text = "FrmChiTietHoaDon";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_thoiGianBatDau;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.TextBox txt_tenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.DataGridView dgv_CTHD;
        private System.Windows.Forms.ListView lv_thucDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMATD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTHANHTIEN;
        private System.Windows.Forms.TextBox txt_tenThucDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_thanhTien;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_huy;
    }
}