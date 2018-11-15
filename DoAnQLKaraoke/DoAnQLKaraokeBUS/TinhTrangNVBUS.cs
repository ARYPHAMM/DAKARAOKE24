using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;


namespace DoAnQLKaraokeBUS
{
   public class TinhTrangNVBUS
    {
       public List<TinhTrang> DSTINHTRANGNV()
       {
           TinhTrangNVDAO b = new TinhTrangNVDAO();
           return b.dsTinhTrangNV();
       }

    }
}
