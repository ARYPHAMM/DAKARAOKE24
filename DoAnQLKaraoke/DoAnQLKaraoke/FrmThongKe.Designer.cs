namespace DoAnQLKaraoke
{
    partial class FrmThongKe
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
            this.rad_ngay = new System.Windows.Forms.RadioButton();
            this.rad_thang = new System.Windows.Forms.RadioButton();
            this.rad_quy = new System.Windows.Forms.RadioButton();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.btn_xuatThongKe = new System.Windows.Forms.Button();
            this.dtp_hoadon = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rad_ngay
            // 
            this.rad_ngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rad_ngay.AutoSize = true;
            this.rad_ngay.Location = new System.Drawing.Point(283, 110);
            this.rad_ngay.Name = "rad_ngay";
            this.rad_ngay.Size = new System.Drawing.Size(62, 21);
            this.rad_ngay.TabIndex = 0;
            this.rad_ngay.TabStop = true;
            this.rad_ngay.Text = "Ngày";
            this.rad_ngay.UseVisualStyleBackColor = true;
            this.rad_ngay.Click += new System.EventHandler(this.rad_chon);
            // 
            // rad_thang
            // 
            this.rad_thang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rad_thang.AutoSize = true;
            this.rad_thang.Location = new System.Drawing.Point(283, 155);
            this.rad_thang.Name = "rad_thang";
            this.rad_thang.Size = new System.Drawing.Size(70, 21);
            this.rad_thang.TabIndex = 0;
            this.rad_thang.TabStop = true;
            this.rad_thang.Text = "Tháng";
            this.rad_thang.UseVisualStyleBackColor = true;
            this.rad_thang.Click += new System.EventHandler(this.rad_chon);
            // 
            // rad_quy
            // 
            this.rad_quy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rad_quy.AutoSize = true;
            this.rad_quy.Location = new System.Drawing.Point(283, 192);
            this.rad_quy.Name = "rad_quy";
            this.rad_quy.Size = new System.Drawing.Size(55, 21);
            this.rad_quy.TabIndex = 0;
            this.rad_quy.TabStop = true;
            this.rad_quy.Text = "Quý";
            this.rad_quy.UseVisualStyleBackColor = true;
            this.rad_quy.Click += new System.EventHandler(this.rad_chon);
            // 
            // rad_nam
            // 
            this.rad_nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rad_nam.AutoSize = true;
            this.rad_nam.Location = new System.Drawing.Point(283, 234);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(58, 21);
            this.rad_nam.TabIndex = 0;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Năm";
            this.rad_nam.UseVisualStyleBackColor = true;
            this.rad_nam.Click += new System.EventHandler(this.rad_chon);
            // 
            // btn_xuatThongKe
            // 
            this.btn_xuatThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xuatThongKe.Location = new System.Drawing.Point(269, 348);
            this.btn_xuatThongKe.Name = "btn_xuatThongKe";
            this.btn_xuatThongKe.Size = new System.Drawing.Size(109, 38);
            this.btn_xuatThongKe.TabIndex = 2;
            this.btn_xuatThongKe.Text = "Xuất thống kê";
            this.btn_xuatThongKe.UseVisualStyleBackColor = true;
            this.btn_xuatThongKe.Click += new System.EventHandler(this.btn_xuatThongKe_Click);
            // 
            // dtp_hoadon
            // 
            this.dtp_hoadon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_hoadon.CustomFormat = "dd/MM/yyyy";
            this.dtp_hoadon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hoadon.Location = new System.Drawing.Point(283, 283);
            this.dtp_hoadon.Name = "dtp_hoadon";
            this.dtp_hoadon.Size = new System.Drawing.Size(91, 22);
            this.dtp_hoadon.TabIndex = 3;
            this.dtp_hoadon.ValueChanged += new System.EventHandler(this.dtp_hoadon_ValueChanged);
            this.dtp_hoadon.Leave += new System.EventHandler(this.dtp_hoadon_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = global::DoAnQLKaraoke.Properties.Resources.HDBan1;
            this.pictureBox1.Image = global::DoAnQLKaraoke.Properties.Resources.HDBan;
            this.pictureBox1.InitialImage = global::DoAnQLKaraoke.Properties.Resources.HDBan;
            this.pictureBox1.Location = new System.Drawing.Point(82, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(184, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 59);
            this.label2.TabIndex = 25;
            this.label2.Text = "Thống kê - Báo cáo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_hoadon);
            this.Controls.Add(this.btn_xuatThongKe);
            this.Controls.Add(this.rad_nam);
            this.Controls.Add(this.rad_quy);
            this.Controls.Add(this.rad_thang);
            this.Controls.Add(this.rad_ngay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_ngay;
        private System.Windows.Forms.RadioButton rad_thang;
        private System.Windows.Forms.RadioButton rad_quy;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.Button btn_xuatThongKe;
        private System.Windows.Forms.DateTimePicker dtp_hoadon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}