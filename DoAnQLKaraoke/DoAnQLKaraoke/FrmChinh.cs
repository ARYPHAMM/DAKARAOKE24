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
        //FrmQLLSuKhachHang f3;
        FrmQLThucDon f4;
        FrmQLPhong f5;
        FrmChonBaoCao f6;
        FrmQLKHACHHANG f8;
        public bool isDangNhap;
        public TaiKhoanDTO nvDangNhap;
        public FrmChinh()
        {
            InitializeComponent();
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
            f6 = new FrmChonBaoCao();
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
            
            FrmDangNhap fdn = new FrmDangNhap();
            fdn.MdiParent = this;
            fdn.Dock = DockStyle.Fill;
            fdn.Show();

        }
    }
}
