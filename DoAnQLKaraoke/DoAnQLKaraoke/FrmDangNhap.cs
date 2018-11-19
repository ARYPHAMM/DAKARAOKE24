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
        public int solandangnhap = 0;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtTaiKhoan.Text != string.Empty && txtMatKhau.Text != string.Empty && txtMatKhau.Text.Length >= 6)
            {
                FrmChinh frmchinh = (FrmChinh)this.MdiParent;
                TaiKhoanBUS taikhoan = new TaiKhoanBUS();
                frmchinh.nvDangNhap = taikhoan.LayThongTinTaiKhoan(txtTaiKhoan.Text.Trim(), Utils.MaHoaMD5(txtMatKhau.Text.Trim()));
                frmchinh.isDangNhap = true;
                if (frmchinh.nvDangNhap != null && frmchinh.nvDangNhap.TINHTRANG == 1)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Close();
                    solandangnhap = 0;
                    frmchinh.XetTruyCap(frmchinh.nvDangNhap.LOAIND);
                    frmchinh.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    solandangnhap++;
                    if (solandangnhap > 6)
                    {
                        
                        try
                        {
                            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
                            TaiKhoanDTO tk = new TaiKhoanDTO();
                            tk = tkBUS.DanhSachTaiKhoan().Find(o => o.TAIKHOAN.Trim() == txtTaiKhoan.Text.Trim());                     
                            if (tk.LOAIND != 1)
                            {
                                tk.TINHTRANG = 2;
                                tkBUS.CapNhatTaiKhoan(tk);
                               
                            }
                            MessageBox.Show("Tài khoản bạn đã đăng nhập quá 6 lần." + Environment.NewLine + " Hệ thống sẽ khóa tài khoản vui lòng liên hệ admin để được hổ trợ");
                        }
                        catch
                        {

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin");
            }
        }

    }
}
