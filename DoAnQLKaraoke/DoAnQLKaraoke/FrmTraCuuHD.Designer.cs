namespace DoAnQLKaraoke
{
    partial class FrmTraCuuHD
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
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.dpt_HoaDonBD = new System.Windows.Forms.DateTimePicker();
            this.dpt_HoaDonKT = new System.Windows.Forms.DateTimePicker();
            this.txt_MAHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_timtheongay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_timsdt = new System.Windows.Forms.Button();
            this.btn_timtheoma = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.btn_trove = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column11,
            this.Column3,
            this.MAKH,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgv_hoadon.Location = new System.Drawing.Point(12, 182);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.Size = new System.Drawing.Size(1093, 329);
            this.dgv_hoadon.TabIndex = 0;
            this.dgv_hoadon.SelectionChanged += new System.EventHandler(this.dgv_hoadon_SelectionChanged);
            // 
            // dpt_HoaDonBD
            // 
            this.dpt_HoaDonBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dpt_HoaDonBD.CustomFormat = "dd/MM/yyyy";
            this.dpt_HoaDonBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpt_HoaDonBD.Location = new System.Drawing.Point(503, 79);
            this.dpt_HoaDonBD.Name = "dpt_HoaDonBD";
            this.dpt_HoaDonBD.Size = new System.Drawing.Size(113, 22);
            this.dpt_HoaDonBD.TabIndex = 4;
            // 
            // dpt_HoaDonKT
            // 
            this.dpt_HoaDonKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dpt_HoaDonKT.CustomFormat = "dd/MM/yyyy";
            this.dpt_HoaDonKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpt_HoaDonKT.Location = new System.Drawing.Point(660, 80);
            this.dpt_HoaDonKT.Name = "dpt_HoaDonKT";
            this.dpt_HoaDonKT.Size = new System.Drawing.Size(113, 22);
            this.dpt_HoaDonKT.TabIndex = 4;
            // 
            // txt_MAHD
            // 
            this.txt_MAHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MAHD.Location = new System.Drawing.Point(114, 80);
            this.txt_MAHD.Name = "txt_MAHD";
            this.txt_MAHD.Size = new System.Drawing.Size(112, 22);
            this.txt_MAHD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tra Cứu Hóa Đơn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hóa đơn : ";
            // 
            // btn_timtheongay
            // 
            this.btn_timtheongay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timtheongay.Location = new System.Drawing.Point(779, 80);
            this.btn_timtheongay.Name = "btn_timtheongay";
            this.btn_timtheongay.Size = new System.Drawing.Size(122, 22);
            this.btn_timtheongay.TabIndex = 8;
            this.btn_timtheongay.Text = "Tìm theo ngày";
            this.btn_timtheongay.UseVisualStyleBackColor = true;
            this.btn_timtheongay.Click += new System.EventHandler(this.btn_timtheongay_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hóa đơn từ ngày : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "đến";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số điện thoại : ";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sdt.Location = new System.Drawing.Point(503, 107);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(113, 22);
            this.txt_sdt.TabIndex = 12;
            // 
            // btn_timsdt
            // 
            this.btn_timsdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timsdt.Location = new System.Drawing.Point(779, 105);
            this.btn_timsdt.Name = "btn_timsdt";
            this.btn_timsdt.Size = new System.Drawing.Size(122, 22);
            this.btn_timsdt.TabIndex = 13;
            this.btn_timsdt.Text = "Tìm SĐT";
            this.btn_timsdt.UseVisualStyleBackColor = true;
            this.btn_timsdt.Click += new System.EventHandler(this.btn_timsdt_Click);
            // 
            // btn_timtheoma
            // 
            this.btn_timtheoma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timtheoma.Location = new System.Drawing.Point(232, 79);
            this.btn_timtheoma.Name = "btn_timtheoma";
            this.btn_timtheoma.Size = new System.Drawing.Size(54, 23);
            this.btn_timtheoma.TabIndex = 14;
            this.btn_timtheoma.Text = "Tìm";
            this.btn_timtheoma.UseVisualStyleBackColor = true;
            this.btn_timtheoma.Click += new System.EventHandler(this.btn_timtheoma_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lammoi.Location = new System.Drawing.Point(1030, 143);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.TabIndex = 15;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_InHD
            // 
            this.btn_InHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_InHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InHD.Location = new System.Drawing.Point(197, 110);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(89, 34);
            this.btn_InHD.TabIndex = 45;
            this.btn_InHD.Text = "In Hóa Đơn";
            this.btn_InHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // btn_trove
            // 
            this.btn_trove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_trove.Image = global::DoAnQLKaraoke.Properties.Resources.cancel;
            this.btn_trove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trove.Location = new System.Drawing.Point(996, 9);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(93, 37);
            this.btn_trove.TabIndex = 46;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capNhat.Image = global::DoAnQLKaraoke.Properties.Resources.edit;
            this.btn_capNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capNhat.Location = new System.Drawing.Point(37, 110);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(106, 35);
            this.btn_capNhat.TabIndex = 47;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "MaHD";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MAPHONG";
            this.Column2.HeaderText = "MAPHONG";
            this.Column2.Name = "Column2";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "GIAPHONG";
            this.Column11.HeaderText = "Giá phòng";
            this.Column11.Name = "Column11";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MANV";
            this.Column3.HeaderText = "MANV";
            this.Column3.Name = "Column3";
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "MAKH";
            this.MAKH.Name = "MAKH";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "THOIGIANBATDAU";
            this.Column7.HeaderText = "Thời gian bắt đầu";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "THOIGIANKETTHUC";
            this.Column8.HeaderText = "Thời gian kết thúc";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TONGTHANHTOAN";
            this.Column9.HeaderText = "Tổng thanh toán";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TINHTRANG";
            this.Column10.HeaderText = "Tình trạng thanh toán";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmTraCuuHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 521);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_timtheoma);
            this.Controls.Add(this.btn_timsdt);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_timtheongay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MAHD);
            this.Controls.Add(this.dpt_HoaDonKT);
            this.Controls.Add(this.dpt_HoaDonBD);
            this.Controls.Add(this.dgv_hoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTraCuuHD";
            this.Text = "FrmTraCuuHD";
            this.Load += new System.EventHandler(this.FrmTraCuuHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.DateTimePicker dpt_HoaDonBD;
        private System.Windows.Forms.DateTimePicker dpt_HoaDonKT;
        private System.Windows.Forms.TextBox txt_MAHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_timtheongay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Button btn_timsdt;
        private System.Windows.Forms.Button btn_timtheoma;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_trove;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
    }
}