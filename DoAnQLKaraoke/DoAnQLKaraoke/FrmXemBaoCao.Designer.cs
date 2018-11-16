namespace DoAnQLKaraoke
{
    partial class FrmXemBaoCao
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
            this.rpcBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpcBaoCao
            // 
            this.rpcBaoCao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpcBaoCao.Location = new System.Drawing.Point(12, 12);
            this.rpcBaoCao.Name = "rpcBaoCao";
            this.rpcBaoCao.Size = new System.Drawing.Size(762, 478);
            this.rpcBaoCao.TabIndex = 0;
            // 
            // FrmXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 502);
            this.Controls.Add(this.rpcBaoCao);
            this.Name = "FrmXemBaoCao";
            this.Text = "FrmXemBaoCao";
            this.Load += new System.EventHandler(this.FrmXemBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpcBaoCao;
    }
}