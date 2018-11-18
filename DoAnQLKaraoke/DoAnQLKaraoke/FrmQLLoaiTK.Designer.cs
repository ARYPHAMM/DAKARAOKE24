namespace DoAnQLKaraoke
{
    partial class FrmQLLoaiTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_quayve = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.ckb_tinhtrang = new System.Windows.Forms.CheckBox();
            this.txt_tenLoai = new System.Windows.Forms.TextBox();
            this.txt_maLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_dsloaiTK = new System.Windows.Forms.DataGridView();
            this.colMALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.grbdstknv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsloaiTK)).BeginInit();
            this.SuspendLayout();
            // 
            // grbdstknv
            // 
            this.grbdstknv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbdstknv.BackColor = System.Drawing.SystemColors.Control;
            this.grbdstknv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbdstknv.Controls.Add(this.label1);
            this.grbdstknv.Controls.Add(this.btn_luu);
            this.grbdstknv.Controls.Add(this.btn_quayve);
            this.grbdstknv.Controls.Add(this.btn_lamMoi);
            this.grbdstknv.Controls.Add(this.btn_capNhat);
            this.grbdstknv.Controls.Add(this.ckb_tinhtrang);
            this.grbdstknv.Controls.Add(this.txt_tenLoai);
            this.grbdstknv.Controls.Add(this.txt_maLoai);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbdstknv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbdstknv.Location = new System.Drawing.Point(12, 130);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdstknv.Size = new System.Drawing.Size(975, 202);
            this.grbdstknv.TabIndex = 24;
            this.grbdstknv.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Loại Người Dùng";
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(247, 122);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(76, 52);
            this.btn_luu.TabIndex = 22;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_quayve
            // 
            this.btn_quayve.Image = global::DoAnQLKaraoke.Properties.Resources.DangXuat;
            this.btn_quayve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quayve.Location = new System.Drawing.Point(862, 6);
            this.btn_quayve.Name = "btn_quayve";
            this.btn_quayve.Size = new System.Drawing.Size(114, 52);
            this.btn_quayve.TabIndex = 17;
            this.btn_quayve.Text = "Trở về";
            this.btn_quayve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quayve.UseVisualStyleBackColor = true;
            this.btn_quayve.Click += new System.EventHandler(this.btn_quayve_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(862, 131);
            this.btn_lamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_lamMoi.Size = new System.Drawing.Size(106, 52);
            this.btn_lamMoi.TabIndex = 21;
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
            this.btn_capNhat.Location = new System.Drawing.Point(337, 122);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(106, 52);
            this.btn_capNhat.TabIndex = 17;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // ckb_tinhtrang
            // 
            this.ckb_tinhtrang.AutoSize = true;
            this.ckb_tinhtrang.Location = new System.Drawing.Point(594, 37);
            this.ckb_tinhtrang.Name = "ckb_tinhtrang";
            this.ckb_tinhtrang.Size = new System.Drawing.Size(100, 21);
            this.ckb_tinhtrang.TabIndex = 5;
            this.ckb_tinhtrang.Text = "Tình Trạng";
            this.ckb_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // txt_tenLoai
            // 
            this.txt_tenLoai.Location = new System.Drawing.Point(337, 84);
            this.txt_tenLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenLoai.Name = "txt_tenLoai";
            this.txt_tenLoai.Size = new System.Drawing.Size(223, 22);
            this.txt_tenLoai.TabIndex = 1;
            // 
            // txt_maLoai
            // 
            this.txt_maLoai.Location = new System.Drawing.Point(337, 36);
            this.txt_maLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maLoai.Name = "txt_maLoai";
            this.txt_maLoai.Size = new System.Drawing.Size(223, 22);
            this.txt_maLoai.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(243, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(243, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Loại";
            // 
            // dgv_dsloaiTK
            // 
            this.dgv_dsloaiTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_dsloaiTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsloaiTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsloaiTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMALOAI,
            this.colTENLOAI,
            this.colTINHTRANG});
            this.dgv_dsloaiTK.Location = new System.Drawing.Point(12, 337);
            this.dgv_dsloaiTK.Name = "dgv_dsloaiTK";
            this.dgv_dsloaiTK.RowTemplate.Height = 24;
            this.dgv_dsloaiTK.Size = new System.Drawing.Size(1162, 185);
            this.dgv_dsloaiTK.TabIndex = 26;
            this.dgv_dsloaiTK.SelectionChanged += new System.EventHandler(this.dgv_dsloaiTK_SelectionChanged);
            // 
            // colMALOAI
            // 
            this.colMALOAI.DataPropertyName = "MALOAI";
            this.colMALOAI.HeaderText = "Mã Loại";
            this.colMALOAI.Name = "colMALOAI";
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.DataPropertyName = "TENLOAI";
            this.colTENLOAI.HeaderText = "Tên Loại";
            this.colTENLOAI.Name = "colTENLOAI";
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.HeaderText = "Tình Trạng";
            this.colTINHTRANG.Name = "colTINHTRANG";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1161, 55);
            this.label2.TabIndex = 25;
            this.label2.Text = "Quản Lý Loại Tài Khoản Nhân Viên ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmQLLoaiTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 540);
            this.Controls.Add(this.grbdstknv);
            this.Controls.Add(this.dgv_dsloaiTK);
            this.Controls.Add(this.label2);
            this.Name = "FrmQLLoaiTK";
            this.Text = "FrmQLLoaiTK";
            this.Load += new System.EventHandler(this.FrmQLLoaiTK_Load);
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsloaiTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quayve;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.CheckBox ckb_tinhtrang;
        private System.Windows.Forms.TextBox txt_tenLoai;
        private System.Windows.Forms.TextBox txt_maLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_dsloaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENLOAI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTINHTRANG;
        private System.Windows.Forms.Label label2;
    }
}