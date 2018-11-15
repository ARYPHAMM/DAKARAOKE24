using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDTO;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQLKaraokeDAO
{
  public  class LoaiTaiKhoanDAO
    {
        //string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdl;Integrated Sucurity = True;";
        public List<LoaiTaiKhoanDTO> dsloaiND()
        {

            List<LoaiTaiKhoanDTO> ds = new List<LoaiTaiKhoanDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from LOAIND where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                LoaiTaiKhoanDTO a = new LoaiTaiKhoanDTO()
                {
                    MALOAIND = sdr.GetInt32(0),
                    TENLOAI = sdr.GetString(1),
                    TINHTRANG = sdr.GetInt32(2)

                };
                ds.Add(a);
            }
            return ds;
        }
    }
}
