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
                hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("dd/MM/yyyy") == dtp_hoadon.Value.ToString("dd/MM/yyyy"));
                f.XemThongKe(hoadon);
            }
            if (rad_thang.Checked)
            {

                hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("MM/yyyy") == dtp_hoadon.Value.ToString("MM/yyyy"));
                f.XemThongKe(hoadon);
            }
            if (rad_nam.Checked)
            {

                hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("yyyy") == dtp_hoadon.Value.ToString("yyyy"));
                f.XemThongKe(hoadon);
            }

            f.ShowDialog();
        }

        private void rad_chon(object sender, EventArgs e)
        {
            dtp_hoadon.CustomFormat = rad_ngay.Checked ? "dd/MM/yyyy" : rad_thang.Checked ? "MM/yyyy" : rad_quy.Checked ? "dd" : "yyyy"; 
        }
    
    }
}
