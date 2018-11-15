using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeBUS
{
    public class PhongBUS
    {
        public List<PhongDTO> DanhSachPhong()
        {
            PhongDAO b = new PhongDAO();
            return b.dsPhong();
        }

        public static string MaPhongMoi()
        {
            PhongDAO p = new PhongDAO();
            string MaPhongLonNhat = p.MaPhongMoi();
            //MessageBox.Show(MaSPLonNhat);
            if (string.IsNullOrEmpty(MaPhongLonNhat))
            {
                return "P01";

            }
            else
            {
                int masotiep = int.Parse(MaPhongLonNhat.Substring(1));/*MaSPLonNhat.Replace('S', '')*/
                //return string.Format("S{0:4}", masotiep + 1);
                return "P" + (masotiep + 1).ToString("00");
            }
        }

        public bool ThemPhong(PhongDTO phong)
        {
            PhongDAO a = new PhongDAO();
            return a.ThemPhong(phong);
        }

        public bool CapNhatPhong(PhongDTO phong)
        {
            PhongDAO a = new PhongDAO();
            return a.CapNhatPhong(phong);
        }

        public List<PhongDTO> TraCuu(int x , int y)
        {
            PhongDAO a = new PhongDAO();
            return a.TraCuu(x,y);
        }
    }
}
