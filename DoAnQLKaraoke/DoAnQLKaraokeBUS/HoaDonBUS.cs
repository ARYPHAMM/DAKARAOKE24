using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
   public class HoaDonBUS
    {
        public List<HoaDonDTO> DanhSachHoaDon()
        {
            HoaDonDAO b = new HoaDonDAO();
            return b.dsHoaDon();
        }

        public static string MaHDmoi()
        {
            HoaDonDAO p = new HoaDonDAO();
            string MaHDLonNhat = p.MaHDLonNhat();
            //MessageBox.Show(MaSPLonNhat);
            if (string.IsNullOrEmpty(MaHDLonNhat))
            {
                return "HD01";

            }
            else
            {
                int masotiep = int.Parse(MaHDLonNhat.Substring(2));/*MaSPLonNhat.Replace('S', '')*/
                //return string.Format("S{0:4}", masotiep + 1);
                return "HD" + (masotiep + 1).ToString("00");
            }
        }

        public bool ThanhToan(HoaDonDTO hd)
        {

            

            HoaDonDAO a = new HoaDonDAO();
            return a.CapNhatHD(hd);
        }

        public bool ThemHD(HoaDonDTO hd)
        {
            HoaDonDAO a = new HoaDonDAO();
            return a.ThemHD(hd);
        }
    }
}
