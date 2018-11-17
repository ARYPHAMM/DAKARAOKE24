namespace DoAnQLKaraoke
{
    partial class FrmQLThucDon
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
            this.cbo_TT = new System.Windows.Forms.ComboBox();
            this.btnquayve = new System.Windows.Forms.Button();
            this.cbo_Loai = new System.Windows.Forms.ComboBox();
            this.txt_TenTD = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txt_MaTD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.grb_TTTD = new System.Windows.Forms.GroupBox();
            this.btn_qlLoai = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_ThucDon = new System.Windows.Forms.DataGridView();
            this.colMATD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAITD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTENTHUCDON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grb_TTTD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_TT
            // 
            this.cbo_TT.FormattingEnabled = true;
            this.cbo_TT.Location = new System.Drawing.Point(117, 127);
            this.cbo_TT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_TT.Name = "cbo_TT";
            this.cbo_TT.Size = new System.Drawing.Size(220, 24);
            this.cbo_TT.TabIndex = 24;
            // 
            // btnquayve
            // 
            this.btnquayve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquayve.Location = new System.Drawing.Point(1563, 22);
            this.btnquayve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnquayve.Name = "btnquayve";
            this.btnquayve.Size = new System.Drawing.Size(121, 37);
            this.btnquayve.TabIndex = 5;
            this.btnquayve.Text = "Quay Về";
            this.btnquayve.UseVisualStyleBackColor = true;
            // 
            // cbo_Loai
            // 
            this.cbo_Loai.FormattingEnabled = true;
            this.cbo_Loai.Location = new System.Drawing.Point(117, 81);
            this.cbo_Loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Loai.Name = "cbo_Loai";
            this.cbo_Loai.Size = new System.Drawing.Size(220, 24);
            this.cbo_Loai.TabIndex = 2;
            // 
            // txt_TenTD
            // 
            this.txt_TenTD.Location = new System.Drawing.Point(497, 33);
            this.txt_TenTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenTD.Name = "txt_TenTD";
            this.txt_TenTD.Size = new System.Drawing.Size(223, 22);
            this.txt_TenTD.TabIndex = 1;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(497, 86);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(223, 22);
            this.txt_Gia.TabIndex = 1;
            this.txt_Gia.TextChanged += new System.EventHandler(this.txt_Gia_TextChanged);
            // 
            // txt_MaTD
            // 
            this.txt_MaTD.Location = new System.Drawing.Point(115, 33);
            this.txt_MaTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaTD.Name = "txt_MaTD";
            this.txt_MaTD.Size = new System.Drawing.Size(223, 22);
            this.txt_MaTD.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(407, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(407, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên TĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(13, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại TĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(13, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "MATĐ";
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(351, 68);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(905, 58);
            this.lbldanhsachnv.TabIndex = 6;
            this.lbldanhsachnv.Text = "Danh Sách Thực Đơn";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb_TTTD
            // 
            this.grb_TTTD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grb_TTTD.Controls.Add(this.btn_qlLoai);
            this.grb_TTTD.Controls.Add(this.btn_lamMoi);
            this.grb_TTTD.Controls.Add(this.btn_luu);
            this.grb_TTTD.Controls.Add(this.btn_traCuu);
            this.grb_TTTD.Controls.Add(this.btn_capNhat);
            this.grb_TTTD.Controls.Add(this.btn_them);
            this.grb_TTTD.Controls.Add(this.cbo_TT);
            this.grb_TTTD.Controls.Add(this.btnquayve);
            this.grb_TTTD.Controls.Add(this.cbo_Loai);
            this.grb_TTTD.Controls.Add(this.txt_TenTD);
            this.grb_TTTD.Controls.Add(this.txt_Gia);
            this.grb_TTTD.Controls.Add(this.txt_MaTD);
            this.grb_TTTD.Controls.Add(this.label8);
            this.grb_TTTD.Controls.Add(this.label7);
            this.grb_TTTD.Controls.Add(this.label1);
            this.grb_TTTD.Controls.Add(this.label6);
            this.grb_TTTD.Controls.Add(this.label5);
            this.grb_TTTD.Location = new System.Drawing.Point(1, 159);
            this.grb_TTTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TTTD.Name = "grb_TTTD";
            this.grb_TTTD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_TTTD.Size = new System.Drawing.Size(1691, 174);
            this.grb_TTTD.TabIndex = 7;
            this.grb_TTTD.TabStop = false;
            this.grb_TTTD.Text = "Thông tin";
            // 
            // btn_qlLoai
            // 
            this.btn_qlLoai.Location = new System.Drawing.Point(357, 84);
            this.btn_qlLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_qlLoai.Name = "btn_qlLoai";
            this.btn_qlLoai.Size = new System.Drawing.Size(28, 23);
            this.btn_qlLoai.TabIndex = 30;
            this.btn_qlLoai.Text = "+";
            this.btn_qlLoai.UseVisualStyleBackColor = true;
            this.btn_qlLoai.Click += new System.EventHandler(this.btn_qlLoai_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(1013, 37);
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
            this.btn_luu.Location = new System.Drawing.Point(765, 33);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(76, 52);
            this.btn_luu.TabIndex = 28;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.Image = global::DoAnQLKaraoke.Properties.Resources.search;
            this.btn_traCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuu.Location = new System.Drawing.Point(913, 116);
            this.btn_traCuu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_traCuu.Size = new System.Drawing.Size(107, 52);
            this.btn_traCuu.TabIndex = 25;
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
            this.btn_capNhat.Location = new System.Drawing.Point(1141, 37);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(107, 52);
            this.btn_capNhat.TabIndex = 26;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DoAnQLKaraoke.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(879, 37);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(88, 52);
            this.btn_them.TabIndex = 27;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_ThucDon
            // 
            this.dgv_ThucDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMATD,
            this.colLOAITD,
            this.colTENTHUCDON,
            this.colGIA,
            this.colTINHTRANG});
            this.dgv_ThucDon.Location = new System.Drawing.Point(15, 337);
            this.dgv_ThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ThucDon.Name = "dgv_ThucDon";
            this.dgv_ThucDon.RowTemplate.Height = 24;
            this.dgv_ThucDon.Size = new System.Drawing.Size(1516, 197);
            this.dgv_ThucDon.TabIndex = 5;
            this.dgv_ThucDon.SelectionChanged += new System.EventHandler(this.dgv_ThucDon_SelectionChanged);
            // 
            // colMATD
            // 
            this.colMATD.DataPropertyName = "MATD";
            this.colMATD.HeaderText = "MATD";
            this.colMATD.Name = "colMATD";
            // 
            // colLOAITD
            // 
            this.colLOAITD.DataPropertyName = "LOAITD";
            this.colLOAITD.HeaderText = "Loại Thực Đơn";
            this.colLOAITD.Name = "colLOAITD";
            this.colLOAITD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLOAITD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTENTHUCDON
            // 
            this.colTENTHUCDON.DataPropertyName = "TENTHUCDON";
            this.colTENTHUCDON.HeaderText = "Tên Thực Đơn";
            this.colTENTHUCDON.Name = "colTENTHUCDON";
            // 
            // colGIA
            // 
            this.colGIA.DataPropertyName = "GIA";
            this.colGIA.HeaderText = "Giá";
            this.colGIA.Name = "colGIA";
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.HeaderText = "Tình Trạng";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTINHTRANG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmQLThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 571);
            this.Controls.Add(this.lbldanhsachnv);
            this.Controls.Add(this.grb_TTTD);
            this.Controls.Add(this.dgv_ThucDon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQLThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLThucDon";
            this.Load += new System.EventHandler(this.FrmQLThucDon_Load);
            this.grb_TTTD.ResumeLayout(false);
            this.grb_TTTD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_TT;
        private System.Windows.Forms.Button btnquayve;
        private System.Windows.Forms.ComboBox cbo_Loai;
        private System.Windows.Forms.TextBox txt_TenTD;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_MaTD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.GroupBox grb_TTTD;
        private System.Windows.Forms.DataGridView dgv_ThucDon;
        private System.Windows.Forms.Button btn_qlLoai;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_traCuu;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMATD;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLOAITD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENTHUCDON;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGIA;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTINHTRANG;
    }
}