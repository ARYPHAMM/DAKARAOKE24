using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLKaraokeDTO;
using DoAnQLKaraokeBUS;

namespace DoAnQLKaraoke
{
    public partial class FrmChinh : Form
    {
        public FrmDangNhap dn = null;
       public FrmQLNhanVien f1 = null;
        FrmQLTaiKhoan f2;
        FrmQLThucDon f4;
        FrmQLPhong f5;
        FrmThongKe f6;
        FrmQLKHACHHANG f8;
        FrmQLHoaDon f9;
        public static bool isDangNhap;
        public static TaiKhoanDTO nvDangNhap;
        public FrmChinh()
        {
            InitializeComponent();
            menuStrip1.Enabled = false;
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = new FrmQLNhanVien();
            f1.MdiParent = this;
            f1.Dock = DockStyle.Fill;
            f1.Show();

        }

        private void tAIKHOANNGƯƠIDUNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new FrmQLTaiKhoan();
            f2.MdiParent = this;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        internal void XetTruyCap(int lOAIND)
        {
            menuStrip1.Enabled = true;
            tAIKHOANCUATÔIToolStripMenuItem.Text = FrmChinh.nvDangNhap.TAIKHOAN.Trim();
            if (lOAIND == 2)
            {
                kHACHHANGToolStripMenuItem.Enabled = true;
                hOAĐƠNToolStripMenuItem.Enabled = true;
                tHƯCĐƠNToolStripMenuItem.Enabled = true;
                pHONGToolStripMenuItem.Enabled =true;
                nHÂNVIÊNToolStripMenuItem.Enabled = false;
                tAIKHOANNGƯƠIDUNGToolStripMenuItem.Enabled = false;

               

            }
            else if(lOAIND == 1)
            {
                kHACHHANGToolStripMenuItem.Enabled = true;
                hOAĐƠNToolStripMenuItem.Enabled = true;
                tHƯCĐƠNToolStripMenuItem.Enabled = true;
                pHONGToolStripMenuItem.Enabled = true;
                nHÂNVIÊNToolStripMenuItem.Enabled = true;
                tAIKHOANNGƯƠIDUNGToolStripMenuItem.Enabled = true;
            }
            else
            {
                 menuStrip1.Enabled = true;
            }
            
            đĂNGNHÂPToolStripMenuItem.Visible = false;
            đĂNGXUÂTToolStripMenuItem.Visible = true;
        }

        private void kHACHHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f8 = new FrmQLKHACHHANG();
            f8.MdiParent = this;
            f8.Dock = DockStyle.Fill;
            f8.Show();


        }

        private void tHƯCĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4 = new FrmQLThucDon();
            f4.MdiParent = this;
            f4.Dock = DockStyle.Fill;
            f4.Show();
        }

        private void pHONGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5 = new FrmQLPhong();
            f5.MdiParent = this;
            f5.Dock = DockStyle.Fill;
            f5.Show();
        }

        private void bAOCAOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6 = new FrmThongKe();
            f6.MdiParent = this;
            f6.Dock = DockStyle.Fill;
            f6.Show();
        }

        private void lOAINHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //f7 = new FrmQLLoaiNhanVien();
            //f7.MdiParent = this;
            //f7.Dock = DockStyle.Fill;
            //f7.Show();
        }

        private void FrmChinh_Load(object sender, EventArgs e)
        {
            if (isDangNhap == false)
            {
                FrmDangNhap fdn = new FrmDangNhap();
                fdn.MdiParent = this;
                fdn.Dock = DockStyle.Fill;
                fdn.Show();
            }
            else
            {

            }

        }

        private void đĂNGNHÂPToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void đĂNGXUÂTToolStripMenuItem_Click(object sender, EventArgs e)
        {
                  dn = null;
                 f1 = null;
            FrmDangNhap fdn = new FrmDangNhap();
            fdn.MdiParent = this;
            fdn.Dock = DockStyle.Fill;
            fdn.Show();
            đĂNGXUÂTToolStripMenuItem.Visible = false;
            menuStrip1.Enabled = false;
            tAIKHOANCUATÔIToolStripMenuItem.Text = "TÀI KHOẢN CỦA TÔI";

        }

        private void đĂTPHONGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f9 = new FrmQLHoaDon();
            f9.MdiParent = this;
            f9.Dock = DockStyle.Fill;
            f9.Show();
        }
    }
}
