using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLKaraokeBUS;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraoke
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS taikhoan = new TaiKhoanBUS();
            FrmChinh main = new FrmChinh();
            main.nvDangNhap = taikhoan.LayThongTinTaiKhoan(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
            main.isDangNhap = true;
            if (main.nvDangNhap != null)
            {
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
