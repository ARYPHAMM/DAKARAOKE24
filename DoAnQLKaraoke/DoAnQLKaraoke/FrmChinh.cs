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
        public LichSuNguoiDungDTO lsNDDTO;
        public LichSuNguoiDungBUS lsNDBUS;
        public FrmDangNhap dn = null;
       public FrmQLNhanVien f1 = null;
        FrmQLTaiKhoan f2;
        FrmQLThucDon f4;
        FrmQLPhong f5;
        FrmThongKe f6;
        FrmQLKHACHHANG f8;
        FrmQLHoaDon f9;
        FrmLichSuHoatDong f10;
        public  bool isDangNhap;
        public  TaiKhoanDTO nvDangNhap;
        public FrmChinh()
        {
            InitializeComponent();
            menuStrip1.Enabled = false;
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Quản Lý Nhân Viên"

            };
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            DongFrmCon();
            f1 = new FrmQLNhanVien();
            f1.MdiParent = this;
            f1.Dock = DockStyle.Fill;
            f1.Show();

        }

        private void tAIKHOANNGƯƠIDUNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Quản Lý Tài Khoản"

            };
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            lsNDBUS = new LichSuNguoiDungBUS();
            DongFrmCon();
            f2 = new FrmQLTaiKhoan();
            f2.MdiParent = this;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        public void XetTruyCap(int lOAIND)
        {
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Đăng nhập hệ thống"

               };
            lsNDBUS = new LichSuNguoiDungBUS();
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);

             
             

            menuStrip1.Enabled = true;
            tAIKHOANCUATÔIToolStripMenuItem.Text = nvDangNhap.TAIKHOAN.Trim();
            if (lOAIND == 2)
            {
                kHACHHANGToolStripMenuItem.Enabled = true;
                hOAĐƠNToolStripMenuItem.Enabled = true;
                tHƯCĐƠNToolStripMenuItem.Enabled = true;
                pHONGToolStripMenuItem.Enabled =true;
                nHÂNVIÊNToolStripMenuItem.Enabled = false;
                tAIKHOANNGƯƠIDUNGToolStripMenuItem.Enabled = false;
                bAOCAOToolStripMenuItem.Enabled = false;
                lịchSửHoạtĐộngToolStripMenuItem.Enabled = false;
                

            }
            else if(lOAIND == 1)
            {
                kHACHHANGToolStripMenuItem.Enabled = true;
                hOAĐƠNToolStripMenuItem.Enabled = true;
                tHƯCĐƠNToolStripMenuItem.Enabled = true;
                pHONGToolStripMenuItem.Enabled = true;
                nHÂNVIÊNToolStripMenuItem.Enabled = true;
                tAIKHOANNGƯƠIDUNGToolStripMenuItem.Enabled = true;
                bAOCAOToolStripMenuItem.Enabled = true;
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
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Quản Lý Khách Hàng"

            };
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            DongFrmCon();
            f8 = new FrmQLKHACHHANG();
            f8.MdiParent = this;
            f8.Dock = DockStyle.Fill;
            f8.Show();


        }

        private void tHƯCĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Quản Lý Thực Đơn"

            };
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            DongFrmCon();
            f4 = new FrmQLThucDon();
            f4.MdiParent = this;
            f4.Dock = DockStyle.Fill;
            f4.Show();
        }

        private void pHONGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Quản Lý Phòng"

            };
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            DongFrmCon();
            f5 = new FrmQLPhong();
            f5.MdiParent = this;
            f5.Dock = DockStyle.Fill;
            f5.FormBorderStyle = FormBorderStyle.None;
            f5.StartPosition = FormStartPosition.CenterScreen;
            f5.Show();
        }

        private void bAOCAOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Báo Cáo Thống Kê"

            };
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            DongFrmCon();
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
                fdn.FormBorderStyle = FormBorderStyle.None;
                fdn.StartPosition = FormStartPosition.CenterScreen;
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
            DongFrmCon();
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Đăng Xuất Khỏi Hệ Thống"

            };
            try
            {
                List<LichSuNguoiDungDTO> LichSuSauMotNgay = lsNDBUS.DSLichSuHoatDong().FindAll(o => o.THOIGIAN.Day < lsNDDTO.THOIGIAN.Day);
                if (LichSuSauMotNgay != null)
                {
                    lsNDBUS.GhiFile(LichSuSauMotNgay, Utils.MaHoaMD5(LichSuSauMotNgay[LichSuSauMotNgay.Count() - 1].THOIGIAN.ToString()));
                }

                bool ktls = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            }
            catch
            {

            }
         
            dn = null;
            f1 = null;
            FrmDangNhap fdn = new FrmDangNhap();
            fdn.MdiParent = this;
            fdn.Dock = DockStyle.Fill;
            fdn.FormBorderStyle = FormBorderStyle.None;
            fdn.StartPosition = FormStartPosition.CenterScreen;
            fdn.Show();
            đĂNGXUÂTToolStripMenuItem.Visible = false;
            menuStrip1.Enabled = false;
            tAIKHOANCUATÔIToolStripMenuItem.Text = "TÀI KHOẢN CỦA TÔI";

        }

        private void đĂTPHONGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Đặt Phòng"

            };
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            DongFrmCon();
            f9 = new FrmQLHoaDon();
            f9.MdiParent = this;
            f9.Dock = DockStyle.Fill;
            f9.Show();
        }
       public void DongFrmCon()
        {
            foreach (Form a in this.MdiChildren)
            {
                a.Close();
            }
        }


        private void hOAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsNDDTO = new LichSuNguoiDungDTO()
            {
                MAND = nvDangNhap.MAND,
                MANV = nvDangNhap.MANV,
                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                SUKIEN = "Đặt Phòng"

            };
            bool kt = lsNDBUS.ThemLichSuNguoiDung(lsNDDTO);
            DongFrmCon();
            f9 = new FrmQLHoaDon();
            f9.MdiParent = this;
            f9.Dock = DockStyle.Fill;
            f9.Show();
        }

        private void FrmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nvDangNhap != null)
            {
                đĂNGXUÂTToolStripMenuItem_Click(sender, e);
            }
        }

        private void lịchSửHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f10 = new FrmLichSuHoatDong();
            f10.MdiParent = this;
            f10.Dock = DockStyle.Fill;
            f10.FormBorderStyle = FormBorderStyle.None;
            f10.StartPosition = FormStartPosition.CenterScreen;
            f10.Show();
        }
    }
}
