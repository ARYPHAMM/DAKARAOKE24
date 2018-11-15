using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
   public class LoaiThucDonBUS
    {
        public List<LoaiThucDonDTO> DanhSachLoaiTD()
        {
            LoaiThucDonDAO b = new LoaiThucDonDAO();
            return b.dsLoaiTD();
        }
        public bool CapNhatLoai(LoaiThucDonDTO loai)
        {
            LoaiThucDonDAO a = new LoaiThucDonDAO();
            return a.CapNhatLoai(loai);
        }
    }
}
