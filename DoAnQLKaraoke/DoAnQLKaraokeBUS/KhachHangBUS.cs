using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
   public class KhachHangBUS
    {
        public List<KhachHangDTO> DanhSachKhachHang()
        {
            KhachHangDAO b = new KhachHangDAO();
            return b.dsKhachHang(); 
        }
        public string MaKHMoi()
        {
            KhachHangDAO p = new KhachHangDAO();
            string MaKHLonNhat = p.MaKHMoi();
            //MessageBox.Show(MaSPLonNhat);
            if (string.IsNullOrEmpty(MaKHLonNhat))
            {
                return "KH01";

            }

                int masotiep = int.Parse(MaKHLonNhat.Substring(2));/*MaSPLonNhat.Replace('S', '')*/
                //return string.Format("S{0:4}", masotiep + 1);
                return "KH" + (masotiep + 1).ToString("00");
        }
        public bool ThemKH(KhachHangDTO khachhang)
        {
            KhachHangDAO a = new KhachHangDAO();
            return a.ThemKH(khachhang);
        }

        public bool CapNhatKH(KhachHangDTO khachhang)
        {
            KhachHangDAO a = new KhachHangDAO();
            return a.CapNhatKH(khachhang);
        }

        public List<KhachHangDTO> TraCuu(int x, int y)
        {
            KhachHangDAO a = new KhachHangDAO();
            return a.TraCuu(x, y);
        }

        public bool ThemHD(HoaDonDTO hd)
        {
            HoaDonDAO a = new HoaDonDAO();
            return a.ThemHD(hd);
        }
    }
}
