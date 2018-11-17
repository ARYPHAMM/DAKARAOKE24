using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;
using System.Windows.Forms;

namespace DoAnQLKaraokeBUS
{
    public class TaiKhoanBUS
    {
        public List<TaiKhoanDTO> DanhSachTaiKhoan()
        {
            TaiKhoanDAO b = new TaiKhoanDAO();
            return b.dsTaiKhoan();
        }
        public TaiKhoanDTO LayThongTinTaiKhoan(string taikhoan, string matkhau)
        {

            TaiKhoanDAO b = new TaiKhoanDAO();
            List<TaiKhoanDTO> dstk = b.dsTaiKhoan();
          
            TaiKhoanDTO tk = dstk.Find(o => o.TAIKHOAN.Trim().Trim() == taikhoan.Trim() && o.MATKHAU.Trim() == matkhau.Trim());
       
            return tk;
        }
        public static string MaNDTiepTheo()
        {
            TaiKhoanDAO nv = new TaiKhoanDAO();
            string Manvmax = nv.LayMaNDMaxPhamLonNhat();
            if (Manvmax == null)
            {
                return "ND01";

            }
            int masotiep = int.Parse(Manvmax.Substring(2));
            return "ND" + (masotiep + 1).ToString("00");
        }
        public List<TaiKhoanDTO> dsNhanVien()
        {
            TaiKhoanDAO nv = new TaiKhoanDAO();
            return nv.dsTaiKhoan();
        }

        public bool ThemTaiKhoan(TaiKhoanDTO tkmoi)
        {
            TaiKhoanDAO a = new TaiKhoanDAO();
            return a.ThemTaiKhoan(tkmoi);
        }

        public bool CapNhatTaiKhoan(TaiKhoanDTO taikhoan)
        {
            TaiKhoanDAO a = new TaiKhoanDAO();
            return a.CapNhatTaiKhoan(taikhoan);
        }
    }
}
