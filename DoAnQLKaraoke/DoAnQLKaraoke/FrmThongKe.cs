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
        public static int radio = 0;
        public FrmThongKe()
        {
            InitializeComponent();
           
        }

        private void btn_xuatThongKe_Click(object sender, EventArgs e)
        {
            FrmXemBaoCao f = new FrmXemBaoCao();
            HoaDonBUS dhBUS = new HoaDonBUS();
            try
            {
                if (rad_ngay.Checked)
                {
                    radio = 1;
                    hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("dd/MM/yyyy") == dtp_hoadon.Value.ToString("dd/MM/yyyy"));
                    f.XemThongKe(hoadon);
                }
                if (rad_thang.Checked)
                {
                    radio = 2;
                    hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("MM/yyyy") == dtp_hoadon.Value.ToString("MM/yyyy"));
                    f.XemThongKe(hoadon);
                }
                if (rad_nam.Checked)
                {
                    radio = 3;
                    hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("yyyy") == dtp_hoadon.Value.ToString("yyyy"));
                    f.XemThongKe(hoadon);
                }
                if(rad_quy.Checked)
                {
                    radio = 4;
                    kiemtraquy();  
                    f.XemThongKe(hoadon);
                }
            }
            catch
            {
                MessageBox.Show("Chưa có dữ liệu trong hệ thống");
            }

            f.ShowDialog();
        }

        private void kiemtraquy()
        {
            HoaDonBUS dhBUS = new HoaDonBUS();
            DateTime a = dtp_hoadon.Value;
            int kt = int.Parse(a.ToString("MM"));
            if (kt == 1)
            {
                hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("MM/yyyy") == "01/"+dtp_hoadon.Value.ToString("yyyy") || o.THOIGIANKETTHUC.ToString("MM/yyyy") == "02/" + dtp_hoadon.Value.ToString("yyyy") || o.THOIGIANKETTHUC.ToString("MM/yyyy") == "03/" + dtp_hoadon.Value.ToString("yyyy"));
            }
            if(kt == 2)
            {
                hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("MM/yyyy") == "04/" + dtp_hoadon.Value.ToString("yyyy") || o.THOIGIANKETTHUC.ToString("MM/yyyy") == "05/" + dtp_hoadon.Value.ToString("yyyy") || o.THOIGIANKETTHUC.ToString("MM/yyyy") == "06/" + dtp_hoadon.Value.ToString("yyyy"));
            }
            if (kt == 3)
            {
                hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("MM/yyyy") == "07/" + dtp_hoadon.Value.ToString("yyyy") || o.THOIGIANKETTHUC.ToString("MM/yyyy") == "08/" + dtp_hoadon.Value.ToString("yyyy") || o.THOIGIANKETTHUC.ToString("MM/yyyy") == "09/" + dtp_hoadon.Value.ToString("yyyy"));
            }
            if (kt == 4)
            {
                hoadon = dhBUS.DanhSachHoaDon().FindAll(o => o.THOIGIANKETTHUC.ToString("MM/yyyy") == "10/" + dtp_hoadon.Value.ToString("yyyy") || o.THOIGIANKETTHUC.ToString("MM/yyyy") == "11/" + dtp_hoadon.Value.ToString("yyyy") || o.THOIGIANKETTHUC.ToString("MM/yyyy") == "12/" + dtp_hoadon.Value.ToString("yyyy"));
            }

        }

        private void rad_chon(object sender, EventArgs e)
        {
            dtp_hoadon.CustomFormat = rad_ngay.Checked ? "dd/MM/yyyy" : rad_thang.Checked ? "MM/yyyy" : rad_quy.Checked ? "MM/yyyy" : "yyyy";
            
            if(rad_quy.Checked)
            {
                dtp_hoadon.Text = "01/" + DateTime.Now.ToString("yyyy");
            }
            else
            {
                dtp_hoadon.Text = DateTime.Now.ToString();
            }
        }

        private void dtp_hoadon_Leave(object sender, EventArgs e)
        {
            
        }

        private void dtp_hoadon_ValueChanged(object sender, EventArgs e)
        {
            if (rad_quy.Checked)
            {
                DateTime a = dtp_hoadon.Value;
                int kt = int.Parse(a.ToString("MM"));
                if (kt > 4)
                {
                    MessageBox.Show("Một năm có 4 quý");
                    dtp_hoadon.Text = "01/" + DateTime.Now.ToString("yyyy");
                }
            }
        }
    }
}
