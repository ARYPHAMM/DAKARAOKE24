using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDTO;
using DoAnQLKaraokeDAO;

namespace DoAnQLKaraokeBUS
{
   public class LichSuNguoiDungBUS
    {
        public bool ThemLichSuNguoiDung(LichSuNguoiDungDTO ls)
        {
            LichSuNguoiDungDAO a = new LichSuNguoiDungDAO();
            return a.ThemLichSuNguoiDung(ls);
        }
        public List<LichSuNguoiDungDTO>DSLichSuHoatDong()
        {
            LichSuNguoiDungDAO a = new LichSuNguoiDungDAO();
            return a.DanhSachLichSuNguoiDung();
        }
    }
}
