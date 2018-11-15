using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
   public class ThucDonBUS
    {
        public List<ThucDonDTO> DanhSachTD()
        {
            ThucDonDAO b = new ThucDonDAO();
            return b.dsThucDon();
        }
        public static string MaThucDonMoi()
        {
            ThucDonDAO p = new ThucDonDAO();
            string MaTDLonNhat = p.MaThucDonMoi();
            //MessageBox.Show(MaSPLonNhat);
            if (string.IsNullOrEmpty(MaTDLonNhat))
            {
                return "TD01";

            }
            else
            {
                int masotiep = int.Parse(MaTDLonNhat.Substring(2));/*MaSPLonNhat.Replace('S', '')*/
                //return string.Format("S{0:4}", masotiep + 1);
                return "TD" + (masotiep + 1).ToString("00");
            }
        }

        public bool Them(ThucDonDTO thucdon)
        {
            ThucDonDAO a = new ThucDonDAO();
            return a.ThemTD(thucdon);
        }

        public bool CapNhat(ThucDonDTO thucdon)
        {
            ThucDonDAO a = new ThucDonDAO();
            return a.CapNhatTD(thucdon);
        }

        public List<ThucDonDTO> TraCuu(int x, int y)
        {
            ThucDonDAO a = new ThucDonDAO();
            return a.TraCuu(x,y);
        }
    }
}
