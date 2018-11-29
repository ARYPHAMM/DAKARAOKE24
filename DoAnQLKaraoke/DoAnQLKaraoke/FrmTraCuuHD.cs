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
    public partial class FrmTraCuuHD : Form
    {
        HoaDonBUS hdBus = null;
        List<HoaDonDTO> lsHDHienHanh = null;
        HoaDonDTO hdHienHanh = null;
        public FrmTraCuuHD()
        {
            InitializeComponent();
            dgv_hoadon.AutoGenerateColumns = false;
        }

        private void FrmTraCuuHD_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            hdBus = new HoaDonBUS();
            lsHDHienHanh = hdBus.DanhSachHoaDon();          
            dgv_hoadon.DataSource = lsHDHienHanh;        
        }

        private void dgv_hoadon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_hoadon.SelectedRows.Count > 0)
            {
                hdHienHanh = (HoaDonDTO)dgv_hoadon.SelectedRows[0].DataBoundItem; 
            }
            Bind();
            
        }

        private void Bind()
        {
            if(hdHienHanh != null)
            {
                txt_MAHD.Text = hdHienHanh.MAHD;
            }
            else
            {
                hdHienHanh = null;
            }
        }

        private void btn_timtheoma_Click(object sender, EventArgs e)
        {
            
               lsHDHienHanh = hdBus.DanhSachHoaDon().FindAll(o => o.MAHD.Trim() == txt_MAHD.Text.Trim());
               dgv_hoadon.DataSource = lsHDHienHanh;
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MAHD.Text != String.Empty)
                {
                    HoaDonDTO hd = hdBus.DanhSachHoaDon().Find(o => o.MAHD.Trim() == txt_MAHD.Text.Trim());
                    FrmXemBaoCao f = new FrmXemBaoCao();
                    f.XemHoaDon(hd);
                    f.Show();
                }
                else
                {
                    FrmXemBaoCao f = new FrmXemBaoCao();
                    f.XemHoaDon(hdHienHanh);
                    f.Show();
                }
            }
            catch
            {

            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            hdHienHanh = null;
            Bind();
            loaddata();
        }

        private void btn_timtheongay_Click(object sender, EventArgs e)
        {
            lsHDHienHanh = hdBus.DanhSachHoaDon().FindAll(o => o.THOIGIANBATDAU >= dpt_HoaDonBD.Value && o.THOIGIANBATDAU <= dpt_HoaDonKT.Value);
            dgv_hoadon.DataSource = lsHDHienHanh;
        }

        private void btn_timsdt_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangBUS khBUS = new KhachHangBUS();
                KhachHangDTO khDTO = khBUS.DanhSachKhachHang().Find(o => o.SDT.Trim() == txt_sdt.Text.Trim());
                lsHDHienHanh = hdBus.DanhSachHoaDon().FindAll(o => o.MAKH.Trim() == khDTO.MAKH.Trim());
                dgv_hoadon.DataSource = lsHDHienHanh;
            }
            catch
            {
                dgv_hoadon.DataSource = null;
            }
        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmQLHoaDon hd = new FrmQLHoaDon();
            hd.MdiParent = this.MdiParent;
            hd.Dock = DockStyle.Fill;
            hd.FormBorderStyle = FormBorderStyle.None;
            hd.StartPosition = FormStartPosition.CenterScreen;
            hd.Show();


        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {

            if (hdHienHanh != null)
            {
                FrmChinh frmmain = (FrmChinh)this.MdiParent;
                frmmain.lsNDDTO = new LichSuNguoiDungDTO()
                {
                    MAND = frmmain.nvDangNhap.MAND,
                    MANV = frmmain.nvDangNhap.MANV,
                    THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                    SUKIEN = "HD: " + hdHienHanh.MAHD + " được chỉnh sửa với tình trạng đã thanh toán"

                };
                bool ktls = frmmain.lsNDBUS.ThemLichSuNguoiDung(frmmain.lsNDDTO);
                this.Visible = true;
                FrmQLHoaDon.hdHienHanh = hdHienHanh;
                FrmChiTietHoaDon cthd = new FrmChiTietHoaDon();
                cthd.MdiParent = FrmChinh.ActiveForm;
                cthd.Dock = DockStyle.Fill;
                cthd.FormBorderStyle = FormBorderStyle.None;
                cthd.StartPosition = FormStartPosition.CenterScreen;
                cthd.Show();
            }
        }
    }
}
