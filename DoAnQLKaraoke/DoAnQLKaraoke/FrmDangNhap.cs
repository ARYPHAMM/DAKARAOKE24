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
            FrmChinh frmchinh = (FrmChinh)this.MdiParent;
            TaiKhoanBUS taikhoan = new TaiKhoanBUS();
            frmchinh.nvDangNhap = taikhoan.LayThongTinTaiKhoan(txtTaiKhoan.Text.Trim(), Utils.MaHoaMD5(txtMatKhau.Text.Trim()));
            MessageBox.Show(Utils.MaHoaMD5(txtMatKhau.Text.Trim()));

            frmchinh.isDangNhap = true;
            if (frmchinh.nvDangNhap != null)
            {

                this.Close();
               

                frmchinh.XetTruyCap(frmchinh.nvDangNhap.LOAIND);
                frmchinh.Show();

                //frmchinh.XetTruyCap(FrmChinh.nvDangNhap.LOAIND);





                //frmchinh.MdiParent = FrmChinh.ActiveForm;
                //frmchinh.Dock = DockStyle.Fill;
                //frmchinh.FormBorderStyle = FormBorderStyle.None;
                //frmchinh.WindowState = FormWindowState.Maximized;
                //frmchinh.StartPosition = FormStartPosition.CenterScreen;


                //frmchinh.Show();


            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

    }
}
