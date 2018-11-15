using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnQLKaraokeDAO
{
    public class TaiKhoanDAO
    {
        static string strKetNoi = @"Data Source = .; Initial Catalog = csdl; Integrated Security = true;";
        public List<TaiKhoanDTO> dsTaiKhoan()
        {
    

            List<TaiKhoanDTO> ds = new List<TaiKhoanDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string sql = "select * from NGUOIDUNG where TINHTRANG=1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
            while (sdr.Read())
            {
                TaiKhoanDTO a = new TaiKhoanDTO()
                {
                  
                    TAIKHOAN = sdr.GetString(0),
                    MATKHAU = sdr.GetString(1),
                    MANV = sdr.GetString(2),
                    LOAIND = int.Parse(sdr["LOAIND"].ToString()),
                   TINHTRANG = int.Parse(sdr["TINHTRANG"].ToString())
                };
                ds.Add(a);          
            }
            sdr.Close();
            conn.Close();
            return ds;
        }
       
    }
}
