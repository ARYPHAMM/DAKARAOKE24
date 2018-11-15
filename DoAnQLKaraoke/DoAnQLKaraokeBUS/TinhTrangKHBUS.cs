using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
   public class TinhTrangKHBUS
    {
       public List<TinhTrang> DSTINHTRANGKH()
       {
           TinhTrangKHDAO b = new TinhTrangKHDAO();
           return b.dsTinhTrangKH();
       }
    }
}
