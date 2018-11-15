using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDTO;
using DoAnQLKaraokeDAO;
using System.Data.SqlClient;

namespace DoAnQLKaraokeDAO
{
  public  class TinhTrangTDDAO
    {
      public List<TinhTrang> dsTinhTrangTD()
      {

          List<TinhTrang> ds = new List<TinhTrang>();
          SqlConnection conn = DataProvider.TaoKetNoi();

          SqlCommand com = new SqlCommand("select * from TINHTRANGTHUCDON", conn);
          SqlDataReader sdr = com.ExecuteReader();
          while (sdr.Read())
          {
              TinhTrang a = new TinhTrang()
              {
                  MATTR = sdr.GetInt32(0),
                  TENTTR = sdr.GetString(1)
              };
              ds.Add(a);
          }
          sdr.Close();
          conn.Close();
          return ds;
      }
    }
}
