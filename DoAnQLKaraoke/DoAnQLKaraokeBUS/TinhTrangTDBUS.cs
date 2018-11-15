using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
   public class TinhTrangTDBUS
    {
       public List<TinhTrang> DSTINHTRANGTD()
       {
           TinhTrangTDDAO b = new TinhTrangTDDAO();
           return b.dsTinhTrangTD();
       }
    }
}
