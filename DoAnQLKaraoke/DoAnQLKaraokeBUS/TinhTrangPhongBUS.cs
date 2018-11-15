using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    public class TinhTrangPhongBUS
    {
        public List<TinhTrang> DSTINHTRANGPHONG()
        {
            TinhTrangPhongDAO b = new TinhTrangPhongDAO();
            return b.dsTinhTrangPhong();
        }
    }
}
