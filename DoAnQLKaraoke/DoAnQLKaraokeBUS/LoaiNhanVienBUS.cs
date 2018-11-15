using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;


namespace DoAnQLKaraokeBUS
{
   public class LoaiNhanVienBUS
    {
        public List<LoaiNhanVienDTO> DanhSachLoaiNhanVien()
        {
            LoaiNhanVienDAO b = new LoaiNhanVienDAO();
            return b.dsloaiNV();
        }
        public bool CapNhatLoaiNV(LoaiNhanVienDTO loai)
        {
            LoaiNhanVienDAO a = new LoaiNhanVienDAO();
            return a.CapNhatLoaiNV(loai);
        }
    }
}
