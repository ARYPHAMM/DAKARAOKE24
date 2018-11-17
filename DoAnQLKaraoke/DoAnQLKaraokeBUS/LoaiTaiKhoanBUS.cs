using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
   public class LoaiTaiKhoanBUS
    {
        public List<LoaiTaiKhoanDTO> DanhSachLoaiTK()
        {
            LoaiTaiKhoanDAO b = new LoaiTaiKhoanDAO();
            return b.dsloaiND();
        }

        public bool CapNhatDSLoaiTK(LoaiTaiKhoanDTO loai)
        {
            LoaiTaiKhoanDAO a = new LoaiTaiKhoanDAO();
            return a.CapNhatDSLoaiTK(loai);
        }
    }
}
