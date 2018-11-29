namespace DoAnQLKaraoke
{
    partial class FrmLichSuHoatDong
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
            this.dgv_lichsu = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_lichsu
            // 
            this.dgv_lichsu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_lichsu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lichsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lichsu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.mand,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_lichsu.Location = new System.Drawing.Point(27, 12);
            this.dgv_lichsu.Name = "dgv_lichsu";
            this.dgv_lichsu.RowTemplate.Height = 24;
            this.dgv_lichsu.Size = new System.Drawing.Size(740, 464);
            this.dgv_lichsu.TabIndex = 0;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "MAHD";
            this.MAHD.Name = "MAHD";
            // 
            // mand
            // 
            this.mand.DataPropertyName = "MAND";
            this.mand.HeaderText = "MAND";
            this.mand.Name = "mand";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MANV";
            this.Column2.HeaderText = "MANV";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "THOIGIAN";
            this.Column3.HeaderText = "THOIGIAN";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SUKIEN";
            this.Column4.HeaderText = "HANHDONG";
            this.Column4.Name = "Column4";
            // 
            // FrmLichSuHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 488);
            this.Controls.Add(this.dgv_lichsu);
            this.Name = "FrmLichSuHoatDong";
            this.Text = "FrmLichSuHoatDong";
            this.Load += new System.EventHandler(this.FrmLichSuHoatDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_lichsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn mand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}