using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDTO;
using DoAnQLKaraokeDAO;

namespace DoAnQLKaraokeBUS
{
    public class TinhTrangTKBUS
    {
        public List<TinhTrang> DSTINHTRANGND()
        {
            TinhTrangTKDAO b = new TinhTrangTKDAO();
            return b.dsTinhTrangND();
        }
    }
}
