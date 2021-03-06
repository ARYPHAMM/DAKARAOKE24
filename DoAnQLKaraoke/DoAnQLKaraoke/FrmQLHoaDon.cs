﻿using System;
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
    public partial class FrmQLHoaDon : Form
    {
        int trThai = 1;
        string maHDmoi = null;
        HoaDonBUS hdBUS = null;
        KhachHangBUS khBUS = null;
        NhanVienBUS nvBUS = null;
        LoaiPhongBUS lpBUS = null;
        PhongBUS pBUS = null;
        KhachHangDTO khHienHanh = null;
        List<HoaDonDTO> lsHoaDonHienHanh = new List<HoaDonDTO>();
       public static HoaDonDTO hdHienHanh = null;
        public FrmQLHoaDon()
        {
            InitializeComponent();
            hdHienHanh = null;
            Bind();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmQLHoaDon_Load(object sender, EventArgs e)
        {


                loaddata();
                TrangThai();

        }

        private void loaddata()
        {
            lv_HoaDonChuaThanhToan.Items.Clear();

            LoaiPhongBUS lp = new LoaiPhongBUS();
            
            cbo_loaiPhong.DataSource = lp.DanhSachLoaiPhong().FindAll(o => o.TINHTRANG == true);
            cbo_loaiPhong.ValueMember = "MALOAIPHONG";
            cbo_loaiPhong.DisplayMember = "TENLOAIPHONG";
            cbo_loaiPhong.SelectedIndex = -1;
            khBUS = new KhachHangBUS();
            nvBUS = new NhanVienBUS();

            HoaDonBUS hdBus = new HoaDonBUS();
            lsHoaDonHienHanh = hdBus.DanhSachHoaDon().FindAll(o=>o.TINHTRANG == false);
            foreach (HoaDonDTO a in lsHoaDonHienHanh)
            {
                PhongBUS pBus = new PhongBUS();
                PhongDTO pDTO = pBus.DanhSachPhong().Find(o => o.MAPHONG == a.MAPHONG );
                ListViewItem item = new ListViewItem(pDTO.TENPHONG);
                item.SubItems.Add(a.MAHD);
                item.SubItems.Add(a.MAPHONG);
                item.SubItems.Add(a.MANV);
                item.SubItems.Add(nvBUS.DanhSachNhanVien().Find(o => o.MANV.Trim() == a.MANV.Trim()).HOTENNV);
                item.SubItems.Add(a.MAKH);
                item.SubItems.Add(khBUS.DanhSachKhachHang().Find(o=>o.MAKH.Trim() == a.MAKH.Trim()).TENKH);
                item.SubItems.Add(a.THOIGIANBATDAU.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(a.THOIGIANKETTHUC.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(a.TONGTHANHTOAN);
                item.SubItems.Add(a.THOIGIANBATDAU.ToString());
                item.SubItems.Add(a.TINHTRANG?"1":"0");
                item.SubItems.Add(a.GIAPHONG.ToString());
                lv_HoaDonChuaThanhToan.Items.Add(item);
            }

            maHDmoi = DoAnQLKaraokeBUS.HoaDonBUS.MaHDmoi();
            txt_maHD.Text = maHDmoi;
        }
        private void TrangThai()
        {
            switch (trThai)
            {
                case 1: // mac dinh
                    {
                        btn_huyHD.Enabled = false;
                        btn_traCuuSDT.Enabled = false;
                        btn_traCuuSDT.Enabled = false;
                        btn_luu.Text = "Lưu";
                        btn_luu.Image = Properties.Resources.save;
                        btn_them.Enabled = true;
                        btn_luu.Visible = false;
                        btn_them.Text = "Thêm";
                        btn_capNhat.Enabled = false;
                        btn_capNhat.Text = "Cập nhật";
                        btn_them.Image = Properties.Resources.add;
                        btn_capNhat.Image = Properties.Resources.edit;
                        txt_maHD.Enabled = false;
                        txt_gia.Enabled = false;
                        txt_tenPhong.Enabled = false;
                        txt_tenKH.Enabled = false;
                        btn_capNhat.Enabled = false;
                        cbo_loaiPhong.Enabled = true;
                        txt_sdt.Enabled = false;
                        dtp_thoiGianBatDau.Enabled = false;
                        //Bind();

                    }
                    break;
                case 2: // them moi
                    {
                        btn_traCuuSDT.Enabled = true;
                        btn_them.Enabled = true;
                        btn_them.Text = "Hủy";
                        btn_them.Image = Properties.Resources.cancel;
                        btn_capNhat.Enabled = false;
                        btn_luu.Visible = true;
                        txt_tenPhong.Enabled = false;
                        txt_tenKH.Enabled = true;
                        txt_maHD.Enabled = false;
                        txt_gia.Enabled = false;
                        cbo_loaiPhong.Enabled = true;
                        txt_sdt.Enabled = true;
                        dtp_thoiGianBatDau.Enabled = true;
                        //Bind();
                    }
                    break;
                case 3: // chinh sua
                    {
                        btn_traCuuSDT.Enabled = false;
                        btn_them.Enabled = false;
                        btn_luu.Visible = true;
                        btn_capNhat.Enabled = true;
                        btn_luu.Visible = true;
                        txt_tenPhong.Enabled = false;
                        txt_tenKH.Enabled = false;
                        txt_maHD.Enabled = false;
                        txt_gia.Enabled = false;
                        cbo_loaiPhong.Enabled = false;
                        txt_sdt.Enabled = false;
                        dtp_thoiGianBatDau.Enabled = false;
                        btn_traCuuSDT.Enabled = false;
                        txt_sdt.Enabled = false;
                    }
                    break;


            }
        }

        private void grbdstknv_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (trThai == 2) // lan kich thu 2
            {
                trThai = 1;
                TrangThai();

            }
            else
            {
                trThai = 2;
                TrangThai();
                hdHienHanh = null;
                loaddata();
                Bind();
            }
        }

        private void cbo_loaiPhong_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbo_loaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_loaiPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PhongBUS a = new PhongBUS();
            PhongDTO b = new PhongDTO();
            b = a.DanhSachPhong().Find(o => o.LOAIPHONG == int.Parse(cbo_loaiPhong.SelectedValue.ToString()) && o.TINHTRANG == 2);

            if (b != null)
            {
                txt_tenPhong.Text = b.TENPHONG != string.Empty ? b.TENPHONG : "Không còn phòng";
                txt_gia.Text = b.GIAPHONG.ToString();
            }
            else
            {
                txt_tenPhong.Text = "Không còn phòng";
                txt_gia.Text = string.Empty;
            }
            txt_soNGUOI.Text = string.Empty;
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                long a;
                foreach (char s in txt_sdt.Text)
                {
                    bool kt = long.TryParse(s.ToString(), out a);
                    if (!kt)
                    {


                        if (txt_sdt.TextLength > 0)
                        {
                            txt_sdt.Text = txt_sdt.Text.Remove(txt_sdt.Text.Length - 1, 1);
                            txt_sdt.SelectionStart = txt_sdt.Text.Length;
                        }
                        else
                        {
                            txt_sdt.Text = txt_sdt.Text.Remove(0, 0);
                        }


                    }
                }
            }
            catch
            {

            }

        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_traCuuSDT_Click(object sender, EventArgs e)
        {

            KhachHangBUS a = new KhachHangBUS();
 
            try
            {
                khHienHanh = a.DanhSachKhachHang().Find(o => o.SDT.Trim() == txt_sdt.Text.Trim());
                if (khHienHanh != null)
                {
                    txt_tenKH.Text = khHienHanh.TENKH;
                    txt_tenKH.Enabled = false;
                }
                else
                {
                    txt_tenKH.Text = string.Empty;
                    txt_tenKH.Enabled = true;
                }
            }
            catch
            {
                txt_tenKH.Text = string.Empty;
                txt_tenKH.Enabled = true;
            }


         
               
           
           
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (dtp_thoiGianBatDau.Value.Hour < DateTime.Now.Hour)
            {
                MessageBox.Show("Thời gian bắt đầu phải là thời gian hiện tại hoặc lớn hơn");
                return;
            }
            else if (dtp_thoiGianBatDau.Value.Hour == DateTime.Now.Hour && dtp_thoiGianBatDau.Value.Minute < DateTime.Now.Minute)
            {
                MessageBox.Show("Thời gian bắt đầu phải là thời gian hiện tại hoặc lớn hơn");
                return;
            }
            else if(dtp_thoiGianBatDau.Value.Hour > DateTime.Now.Hour + 2)
            {
                MessageBox.Show("Chỉ cho đặt phòng trong 2 tiếng trở lại");
                return;
            }// kiem tra thoi gian

            if (txt_sdt.Text == string.Empty || txt_tenKH.Text == string.Empty || txt_sdt.Text.Length > 11 || txt_sdt.Text.Length < 10)
            {
                MessageBox.Show("Thông tin về khách hàng không hợp lệ !");
            }
            else
            {
  
                KhachHangDTO khDTO;
                if (txt_tenKH.Enabled == true)
                {

                    KhachHangBUS khBUS = new KhachHangBUS();
                    khDTO = new KhachHangDTO()
                    {
                        MAKH = khBUS.MaKHMoi(),
                        LOAIKH = 1,
                        TENKH = txt_tenKH.Text,
                        SDT = txt_sdt.Text,
                        TINHTRANG = 1

                    };

                    bool ktkh = khBUS.ThemKH(khDTO);
                    try
                    {

                        if (ktkh)
                        {
                            MessageBox.Show("Một khách hàng vừa được thêm vào hệ thống");
                            btn_traCuuSDT_Click(sender, e);
                            FrmChinh frmmain = (FrmChinh)this.MdiParent;
                            frmmain.lsNDDTO = new LichSuNguoiDungDTO()
                            {
                                MAND = frmmain.nvDangNhap.MAND,
                                MANV = frmmain.nvDangNhap.MANV,
                                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                                SUKIEN = "Khách hàng " + khDTO.TENKH + " SDT :" + khDTO.SDT + "được thêm vào hệ thống"

                            };
                            bool ktls = frmmain.lsNDBUS.ThemLichSuNguoiDung(frmmain.lsNDDTO);

                        }
                    }
                    catch
                    {
                        MessageBox.Show("SĐT khách hàng này đã có trong hệ thống !");
                    }
                    
                  }
         

                HoaDonDTO hd = new HoaDonDTO();
                PhongBUS a = new PhongBUS();
                PhongDTO pDTO = a.DanhSachPhong().Find(o => o.TENPHONG == txt_tenPhong.Text);
                hd.MAHD = txt_maHD.Text;
                hd.MAPHONG = pDTO.MAPHONG.Trim();

                FrmChinh frmchinh = (FrmChinh)this.MdiParent;
                hd.MANV = frmchinh.nvDangNhap.MANV.Trim();
                NhanVienDTO nv = new NhanVienBUS().DanhSachNhanVien().Find(o => o.MANV.Trim() == frmchinh.nvDangNhap.MANV.Trim());
                hd.NGUOILAPHD = nv.HOTENNV;
                if (khHienHanh != null)
                {

                        hd.MAKH = khHienHanh.MAKH.Trim();
                        hd.THOIGIANBATDAU = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy") + " " + dtp_thoiGianBatDau.Text);
                        hd.THOIGIANKETTHUC = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy") + " " + dtp_thoiGianBatDau.Text);
                        hd.TONGTHANHTOAN = txt_gia.Text.Replace(".", "").Replace("VNĐ", "");
                        hd.GIAPHONG = txt_gia.Text.Replace(".", "").Replace("VNĐ", "");
                        hd.TINHTRANG = false;
                        hd.HOTENKH = txt_tenKH.Text; ;
                        hd.SDT = txt_sdt.Text;


                }
                hdBUS = new HoaDonBUS();
                if (trThai == 2)
                {

                    bool kq = hdBUS.ThemHD(hd);
                    if (kq)
                    {
                        MessageBox.Show("Them hoa don than cong !");
                        trThai = 1;
                        FrmChinh frmmain = (FrmChinh)this.MdiParent;
                        frmmain.lsNDDTO = new LichSuNguoiDungDTO()
                        {
                            MAND = frmmain.nvDangNhap.MAND,
                            MANV = frmmain.nvDangNhap.MANV,
                            THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                            SUKIEN = "Hóa đơn " + hd.MAHD + "được lập"

                        };
                        bool ktls = frmmain.lsNDBUS.ThemLichSuNguoiDung(frmmain.lsNDDTO);
                    }
                    else
                    {
                        MessageBox.Show("Them that bai !");
                    }
                }
                loaddata();
                Bind();
                TrangThai();
            }
        }

        private void lv_HoaDonChuaThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            btn_huyHD.Enabled = true;
            btn_capNhat.Enabled = true;
            pBUS = new PhongBUS();
            lpBUS = new LoaiPhongBUS();
            khBUS = new KhachHangBUS();
            
            if (lv_HoaDonChuaThanhToan.SelectedItems.Count > 0)
            {
                ListViewItem a = lv_HoaDonChuaThanhToan.SelectedItems[0];
                PhongDTO pDTO = pBUS.DanhSachPhong().Find(o => o.MAPHONG.Trim() == a.SubItems[2].Text.Trim());
                LoaiPhongDTO lpDTO = lpBUS.DanhSachLoaiPhong().Find(o => o.MALOAIPHONG == pDTO.LOAIPHONG);
                KhachHangDTO khDTO = khBUS.DanhSachKhachHang().Find(o => o.MAKH.Trim() == a.SubItems[5].Text.Trim());            
                hdHienHanh = new HoaDonDTO()
                {



                    MAHD = a.SubItems[1].Text,
                    MAPHONG = a.SubItems[2].Text,
                    MANV = a.SubItems[3].Text,
                    NGUOILAPHD = a.SubItems[4].Text,
                    MAKH = a.SubItems[5].Text,                
                    HOTENKH = a.SubItems[6].Text,
                    THOIGIANBATDAU = DateTime.Parse(a.SubItems[7].Text),
                    THOIGIANKETTHUC = DateTime.Parse(a.SubItems[8].Text),
                    TONGTHANHTOAN = a.SubItems[9].Text,
                    TINHTRANG = a.SubItems[10].Text == "1" ? true : false,
                    GIAPHONG = a.SubItems[12].Text,
                    TENPHONG = pDTO.TENPHONG,
                    MALOAIPHONG = pDTO.LOAIPHONG,
                    SDT = khDTO.SDT

                };
          
            }


            Bind();

        }

        private void Bind()
        {

            if (hdHienHanh!= null)
            {

                txt_maHD.Text = hdHienHanh.MAHD;
                //MessageBox.Show(lpDTO.MALOAIPHONG.ToString());
                cbo_loaiPhong.SelectedValue = hdHienHanh.MALOAIPHONG;
                txt_tenPhong.Text = hdHienHanh.TENPHONG;
                txt_sdt.Text = hdHienHanh.SDT;
                txt_tenKH.Text = hdHienHanh.HOTENKH;
                txt_gia.Text = hdHienHanh.GIAPHONG;
                dtp_thoiGianBatDau.Text = hdHienHanh.THOIGIANBATDAU.ToString();     
            }
            else
            {
                txt_maHD.Text = maHDmoi;
                //MessageBox.Show(lpDTO.MALOAIPHONG.ToString());
                cbo_loaiPhong.SelectedIndex = -1;
                txt_tenPhong.Text = string.Empty;
                txt_sdt.Text = string.Empty;
                txt_tenKH.Text = string.Empty;
                txt_gia.Text = string.Empty;
                dtp_thoiGianBatDau.Value = DateTime.Now;
            }
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
    
            if (hdHienHanh != null)
            {

                //if (hdHienHanh.THOIGIANBATDAU.Hour >= DateTime.Now.Hour)
                //{
                //    MessageBox.Show("Khách hàng chưa đến");
                //    return;
                //}
                this.Visible = true;
                FrmChiTietHoaDon cthd = new FrmChiTietHoaDon();
                cthd.MdiParent = FrmChinh.ActiveForm;
                cthd.Dock = DockStyle.Fill;
                cthd.FormBorderStyle = FormBorderStyle.None;
                cthd.StartPosition = FormStartPosition.CenterScreen;
                cthd.Show();
            }
    
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            hdHienHanh = null;
            loaddata();
            Bind();
            trThai = 1;
            TrangThai();
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            FrmXemBaoCao f = new FrmXemBaoCao();
            try
            {
               
                f.XemHoaDon(hdHienHanh);
            }
            catch
            {
                MessageBox.Show("Chưa chọn hóa đơn");
            }
          
            f.Show();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            FrmXemBaoCao f = new FrmXemBaoCao();
            HoaDonBUS hdBUS = new HoaDonBUS();
         
            try
            {
                bool ktThanhToan = hdBUS.ThanhToan(hdHienHanh);
                if (ktThanhToan)
                {
                    FrmChinh frmmain = (FrmChinh)this.MdiParent;
                    frmmain.lsNDDTO = new LichSuNguoiDungDTO()
                    {
                        MAND = frmmain.nvDangNhap.MAND,
                        MANV = frmmain.nvDangNhap.MANV,
                        THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                        SUKIEN = "Hóa đơn " + hdHienHanh.MAHD + "được thanh toán"

                    };
                    bool ktls = frmmain.lsNDBUS.ThemLichSuNguoiDung(frmmain.lsNDDTO);
                    hdHienHanh = hdBUS.DanhSachHoaDon().Find(o => o.MAHD.Trim() == hdHienHanh.MAHD.Trim());
                    f.XemHoaDon(hdHienHanh);
                    loaddata();
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn hóa đơn");
            }
            hdHienHanh = null;
            f.Show();
        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmTraCuuHD tchd = new FrmTraCuuHD();
            tchd.MdiParent = this.MdiParent;
            tchd.Dock = DockStyle.Fill;
            tchd.FormBorderStyle = FormBorderStyle.None;
            tchd.StartPosition = FormStartPosition.CenterScreen;
            tchd.Show();
        
        }

        private void txt_tenKH_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int a;
                foreach(char s in txt_tenKH.Text)
                {
                    bool kt = int.TryParse(s.ToString(), out a);
                    if (kt)
                    {


                        if (txt_tenKH.TextLength > 0)
                        {
                            txt_tenKH.Text = txt_tenKH.Text.Remove(txt_tenKH.Text.Length - 1, 1);
                            txt_tenKH.SelectionStart = txt_tenKH.Text.Length;
                        }
                        else
                        {
                            txt_tenKH.Text = txt_tenKH.Text.Remove(0, 0);
                        }


                    }
                }
               
            }
            catch
            {

            }
        }

        private void btn_huyHD_Click(object sender, EventArgs e)
        {
            if (hdHienHanh != null)
            {
                hdBUS = new HoaDonBUS();
                DialogResult kt = MessageBox.Show("Bạn chắc chắn xóa HD này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(kt == DialogResult.Yes)
                {
                    MessageBox.Show(hdHienHanh.MAHD);
                    hdBUS.HuyHD(hdHienHanh.MAHD);
                    trThai = 1;
                    hdHienHanh = null;
                    Bind();
                    TrangThai();
                    loaddata();
                }
              
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_soNGUOI_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int a;
                foreach (char s in txt_soNGUOI.Text)
                {
                    bool kt = int.TryParse(s.ToString(), out a);
                    if (!kt)
                    {


                        if (txt_soNGUOI.TextLength > 0)
                        {
                            txt_soNGUOI.Text = txt_soNGUOI.Text.Remove(txt_soNGUOI.Text.Length - 1, 1);
                            txt_soNGUOI.SelectionStart = txt_soNGUOI.Text.Length;
                        }
                        else
                        {
                            txt_soNGUOI.Text = txt_soNGUOI.Text.Remove(0, 0);
                        }


                    }
                }
            }
            catch
            {

            }

        }

        private void btn_tracuuPSONGUOI_Click(object sender, EventArgs e)
        {
            PhongBUS a = new PhongBUS();
            List<PhongDTO> b = new List<PhongDTO>();
            b = a.DanhSachPhong().FindAll(o => o.SONGUOI >= int.Parse(txt_soNGUOI.Text));
            try
            {
                if (b != null)
                {
                    txt_tenPhong.Text = b[0].TENPHONG;
                    txt_gia.Text = b[0].GIAPHONG.ToString();
                }
                else
                {
                    txt_tenPhong.Text = "Không còn phòng";
                    txt_gia.Text = string.Empty;
                }
            }
            catch
            {
                txt_tenPhong.Text = "Không tìm thấy";
                txt_gia.Text = string.Empty;
            }
            cbo_loaiPhong.SelectedIndex = -1;
        }
    }

}
