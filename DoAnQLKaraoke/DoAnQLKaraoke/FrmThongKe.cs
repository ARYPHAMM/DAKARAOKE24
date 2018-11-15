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
    public partial class FrmThongKe : Form
    {
        List<HoaDonDTO> hoadon = null;
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void btn_xuatThongKe_Click(object sender, EventArgs e)
        {
            FrmXemBaoCao f = new FrmXemBaoCao();
            HoaDonBUS dhBUS = new HoaDonBUS();
            if (rad_ngay.Checked)
            {                                     
                List<HoaDonDTO> ngay = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC == dtp_hoadon.Value);
                f.XemThongKeTheoNgay(ngay);
            }
            //if (rdbTatCa.Checked)
            //{
            //    f.xemtatcatruyen(lstruyen);
            //}
            //if (rdbTheoLoai.Checked)
            //{
            //    NhaXuatBanDTO nxbchon = (NhaXuatBanDTO)cboNhaXB.SelectedItem;
            //    List<TruyenDTO> truyenTheoNXB = lstruyen.FindAll(o => o.MaNXB == nxbchon.MaNXB);
            //    f.XemDsTruyenTheoNXB(truyenTheoNXB, nxbchon);
            //}
            //if (rdbNhomTheoLoai.Checked)
            //{
            //    f.NhomTruyenTheoNXB();
            //}
            //if (rdbHoaDon.Checked)
            //{
            //    HoaDonDTO hoadon = (HoaDonDTO)cbo_hoadon.SelectedItem;
            //    if (hoadon != null)
            //    {
            //        f.InHoaDon(hoadon);
            //    }
            //}
            f.ShowDialog();
        }

        private void rad_chon(object sender, EventArgs e)
        {
            dtp_hoadon.CustomFormat = rad_ngay.Checked ? "dd/MM/yyyy" : rad_thang.Checked ? "MM/yyyy" : rad_quy.Checked ? "dd" : "yyyy"; 
        }
    
    }
}
