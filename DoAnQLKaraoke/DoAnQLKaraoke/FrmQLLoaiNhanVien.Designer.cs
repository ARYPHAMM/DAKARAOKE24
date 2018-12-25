namespace DoAnQLKaraoke
{
    partial class FrmQLLoaiNhanVien
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
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.ckb_TinhTrang = new System.Windows.Forms.CheckBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_LoaiNV = new System.Windows.Forms.DataGridView();
            this.btn_quayve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbdstknv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiNV)).BeginInit();
            this.SuspendLayout();
            // 
            // grbdstknv
            // 
            this.grbdstknv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbdstknv.Controls.Add(this.ckb_TinhTrang);
            this.grbdstknv.Controls.Add(this.btn_lamMoi);
            this.grbdstknv.Controls.Add(this.btn_luu);
            this.grbdstknv.Controls.Add(this.btn_capNhat);
            this.grbdstknv.Controls.Add(this.txt_Ten);
            this.grbdstknv.Controls.Add(this.txt_Ma);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(4, 127);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Size = new System.Drawing.Size(1135, 174);
            this.grbdstknv.TabIndex = 29;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // ckb_TinhTrang
            // 
            this.ckb_TinhTrang.AutoSize = true;
            this.ckb_TinhTrang.Location = new System.Drawing.Point(543, 37);
            this.ckb_TinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_TinhTrang.Name = "ckb_TinhTrang";
            this.ckb_TinhTrang.Size = new System.Drawing.Size(18, 17);
            this.ckb_TinhTrang.TabIndex = 31;
            this.ckb_TinhTrang.UseVisualStyleBackColor = true;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(901, 90);
            this.btn_lamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_lamMoi.Size = new System.Drawing.Size(107, 52);
            this.btn_lamMoi.TabIndex = 29;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(603, 92);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(100, 52);
            this.btn_luu.TabIndex = 30;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capNhat.Image = global::DoAnQLKaraoke.Properties.Resources.edit;
            this.btn_capNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capNhat.Location = new System.Drawing.Point(748, 92);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(107, 52);
            this.btn_capNhat.TabIndex = 28;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(152, 89);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(223, 22);
            this.txt_Ten.TabIndex = 1;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(152, 34);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(223, 22);
            this.txt_Ma.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(432, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(27, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(27, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Loại";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(228, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 55);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quản Lý Loại Nhân Viên ";
            // 
            // dgv_LoaiNV
            // 
            this.dgv_LoaiNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_LoaiNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoai,
            this.colTenLoai,
            this.colTINHTRANG});
            this.dgv_LoaiNV.Location = new System.Drawing.Point(4, 306);
            this.dgv_LoaiNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LoaiNV.Name = "dgv_LoaiNV";
            this.dgv_LoaiNV.RowTemplate.Height = 24;
            this.dgv_LoaiNV.Size = new System.Drawing.Size(1191, 212);
            this.dgv_LoaiNV.TabIndex = 30;
            this.dgv_LoaiNV.SelectionChanged += new System.EventHandler(this.dgv_LoaiNV_SelectionChanged);
            // 
            // btn_quayve
            // 
            this.btn_quayve.Image = global::DoAnQLKaraoke.Properties.Resources.DangXuat;
            this.btn_quayve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quayve.Location = new System.Drawing.Point(1058, -43);
            this.btn_quayve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quayve.Name = "btn_quayve";
            this.btn_quayve.Size = new System.Drawing.Size(136, 41);
            this.btn_quayve.TabIndex = 31;
            this.btn_quayve.Text = "Trở về";
            this.btn_quayve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quayve.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::DoAnQLKaraoke.Properties.Resources.DangXuat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1043, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Trở về";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_quayve_Click);
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MALOAI";
            this.colMaLoai.HeaderText = "Mã Loại NV";
            this.colMaLoai.Name = "colMaLoai";
            // 
            // colTenLoai
            // 
            this.colTenLoai.DataPropertyName = "TENLOAI";
            this.colTenLoai.HeaderText = "Tên Loại NV";
            this.colTenLoai.Name = "colTenLoai";
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.HeaderText = "Tình Trạng";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTINHTRANG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmQLLoaiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbdstknv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LoaiNV);
            this.Controls.Add(this.btn_quayve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLLoaiNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLLoaiNhanVien";
            this.Load += new System.EventHandler(this.FrmQLLoaiNhanVien_Load);
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.CheckBox ckb_TinhTrang;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_LoaiNV;
        private System.Windows.Forms.Button btn_quayve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTINHTRANG;
    }
}