using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    public class ChiTietHoaDonBUS
    {
        public List<ChiTietHoaDonDTO> DanhSachChiTietHD(string MAHD)
        {
            ChiTietHoaDonDAO a = new ChiTietHoaDonDAO();
            return a.DanhSachChiTietHD(MAHD);
        }

        public bool ThemCTHD(ChiTietHoaDonDTO ctHDHienHanh)
        {
            ChiTietHoaDonDAO a = new ChiTietHoaDonDAO();
            return a.ThemCTHD(ctHDHienHanh);
        }

        public bool CapNhatCTHD(ChiTietHoaDonDTO ctHDHienHanh)
        {
            ChiTietHoaDonDAO a = new ChiTietHoaDonDAO();
            return a.CapNhatCTHD(ctHDHienHanh);

        }

        public bool CapNhatSLCTHD(ChiTietHoaDonDTO ctHDHienHanh)
        {
            ChiTietHoaDonDAO a = new ChiTietHoaDonDAO();
            return a.CapNhatSLCTHD(ctHDHienHanh);
        }
    }
}
