using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    public class LoaiPhongBUS
    {
        public List<LoaiPhongDTO> DanhSachLoaiPhong()
        {
            LoaiPhongDAO b = new LoaiPhongDAO();
            return b.dsloaiPhong();
        }

        public bool CapNhatLoaiPhong(LoaiPhongDTO loai)
        {
            LoaiPhongDAO a = new LoaiPhongDAO();
            return a.CapNhatLoaiPhong(loai);
        }
    }
}
