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
            FrmChinh.nvDangNhap = taikhoan.LayThongTinTaiKhoan(txtTaiKhoan.Text.Trim(), Utils.MaHoaMD5(txtMatKhau.Text.Trim()));
            MessageBox.Show(Utils.MaHoaMD5(txtMatKhau.Text.Trim()));

            FrmChinh.isDangNhap = true;
            if (FrmChinh.nvDangNhap != null)
            {
                FrmChinh frmchinh = new FrmChinh();
                frmchinh.XetTruyCap(FrmChinh.nvDangNhap.LOAIND);
                this.Close();
                
                frmchinh.Show();


            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

    }
}
