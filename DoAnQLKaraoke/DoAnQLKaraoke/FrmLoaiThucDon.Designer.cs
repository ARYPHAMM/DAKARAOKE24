namespace DoAnQLKaraoke
{
    partial class FrmLoaiThucDon
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
            this.dgv_LoaiTD = new System.Windows.Forms.DataGridView();
            this.colMALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENLOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.ckb_TinhTrang = new System.Windows.Forms.CheckBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_quayve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTD)).BeginInit();
            this.grbdstknv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LoaiTD
            // 
            this.dgv_LoaiTD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_LoaiTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMALOAI,
            this.colTENLOAIPHONG,
            this.colTINHTRANG});
            this.dgv_LoaiTD.Location = new System.Drawing.Point(4, 298);
            this.dgv_LoaiTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LoaiTD.Name = "dgv_LoaiTD";
            this.dgv_LoaiTD.RowTemplate.Height = 24;
            this.dgv_LoaiTD.Size = new System.Drawing.Size(1341, 212);
            this.dgv_LoaiTD.TabIndex = 16;
            this.dgv_LoaiTD.SelectionChanged += new System.EventHandler(this.dgv_LoaiTD_SelectionChanged);
            // 
            // colMALOAI
            // 
            this.colMALOAI.DataPropertyName = "MALOAI";
            this.colMALOAI.HeaderText = "Mã Loại ";
            this.colMALOAI.Name = "colMALOAI";
            // 
            // colTENLOAIPHONG
            // 
            this.colTENLOAIPHONG.DataPropertyName = "TENLOAIPHONG";
            this.colTENLOAIPHONG.HeaderText = "Tên Loại";
            this.colTENLOAIPHONG.Name = "colTENLOAIPHONG";
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.HeaderText = "Tình Trạng";
            this.colTINHTRANG.Name = "colTINHTRANG";
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(61, 32);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(1252, 68);
            this.lbldanhsachnv.TabIndex = 14;
            this.lbldanhsachnv.Text = "Quản Lý Loại Thực Đơn";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbdstknv
            // 
            this.grbdstknv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbdstknv.Controls.Add(this.ckb_TinhTrang);
            this.grbdstknv.Controls.Add(this.btn_luu);
            this.grbdstknv.Controls.Add(this.btn_lamMoi);
            this.grbdstknv.Controls.Add(this.btn_capNhat);
            this.grbdstknv.Controls.Add(this.txt_TenLoai);
            this.grbdstknv.Controls.Add(this.txt_MaLoai);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(4, 119);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Size = new System.Drawing.Size(1341, 174);
            this.grbdstknv.TabIndex = 15;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // ckb_TinhTrang
            // 
            this.ckb_TinhTrang.AutoSize = true;
            this.ckb_TinhTrang.Location = new System.Drawing.Point(604, 39);
            this.ckb_TinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_TinhTrang.Name = "ckb_TinhTrang";
            this.ckb_TinhTrang.Size = new System.Drawing.Size(18, 17);
            this.ckb_TinhTrang.TabIndex = 26;
            this.ckb_TinhTrang.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(789, 117);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(76, 52);
            this.btn_luu.TabIndex = 25;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(1076, 116);
            this.btn_lamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_lamMoi.Size = new System.Drawing.Size(107, 52);
            this.btn_lamMoi.TabIndex = 24;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capNhat.Image = global::DoAnQLKaraoke.Properties.Resources.edit;
            this.btn_capNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capNhat.Location = new System.Drawing.Point(907, 116);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(107, 52);
            this.btn_capNhat.TabIndex = 23;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Location = new System.Drawing.Point(235, 90);
            this.txt_TenLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Size = new System.Drawing.Size(223, 22);
            this.txt_TenLoai.TabIndex = 1;
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Location = new System.Drawing.Point(235, 37);
            this.txt_MaLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(223, 22);
            this.txt_MaLoai.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(493, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(136, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(132, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Loại";
            // 
            // btn_quayve
            // 
            this.btn_quayve.Image = global::DoAnQLKaraoke.Properties.Resources.DangXuat;
            this.btn_quayve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quayve.Location = new System.Drawing.Point(1249, 14);
            this.btn_quayve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quayve.Name = "btn_quayve";
            this.btn_quayve.Size = new System.Drawing.Size(85, 31);
            this.btn_quayve.TabIndex = 15;
            this.btn_quayve.Text = "Trở về";
            this.btn_quayve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quayve.UseVisualStyleBackColor = true;
            this.btn_quayve.Click += new System.EventHandler(this.btn_quayve_Click);
            // 
            // FrmLoaiThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 542);
            this.Controls.Add(this.btn_quayve);
            this.Controls.Add(this.dgv_LoaiTD);
            this.Controls.Add(this.lbldanhsachnv);
            this.Controls.Add(this.grbdstknv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLoaiThucDon";
            this.Text = "FrmLoaiThucDon";
            this.Load += new System.EventHandler(this.FrmLoaiThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTD)).EndInit();
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiTD;
        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.TextBox txt_TenLoai;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENLOAIPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTINHTRANG;
        private System.Windows.Forms.Button btn_quayve;
        private System.Windows.Forms.CheckBox ckb_TinhTrang;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_capNhat;
    }
}