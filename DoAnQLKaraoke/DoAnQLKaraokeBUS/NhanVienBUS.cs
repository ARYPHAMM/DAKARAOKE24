using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
   public class NhanVienBUS
    {
        public List<NhanVienDTO> DanhSachNhanVien()
        {
            NhanVienDAO b = new NhanVienDAO();
            return b.dsNhanVien();
        }
        public string MaNVMoi()
        {
            NhanVienDAO p = new NhanVienDAO();
            string MaNVLonNhat = p.MaNVMoi();
            //MessageBox.Show(MaSPLonNhat);
            if (string.IsNullOrEmpty(MaNVLonNhat))
            {
                return "NV01";

            }
            int masotiep = int.Parse(MaNVLonNhat.Substring(2));

            return "NV" + (masotiep + 1).ToString("00");
        }
        public bool ThemNV(NhanVienDTO nhanvien)
        {
            NhanVienDAO a = new NhanVienDAO();
            return a.ThemNhanVien(nhanvien);
        }

        public bool CapNhatNV(NhanVienDTO nhanvien)
        {
            NhanVienDAO a = new NhanVienDAO();
            return a.CapNhaNV(nhanvien);
        }

        public List<NhanVienDTO> TraCuu(int x, int y)
        {
            NhanVienDAO a = new NhanVienDAO();
            return a.TraCuu(x, y);
        }
    }
}
