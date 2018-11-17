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
        public List<LoaiTaiKhoanDTO> dsloaiND()
        {

            List<LoaiTaiKhoanDTO> ds = new List<LoaiTaiKhoanDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from LOAIND ", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                LoaiTaiKhoanDTO a = new LoaiTaiKhoanDTO()
                {
                    MALOAIND = sdr.GetInt32(0),
                    TENLOAI = sdr.GetString(1),
                    TINHTRANG = sdr.GetBoolean(2)

                };
                ds.Add(a);
            }
            return ds;
        }

        public bool CapNhatDSLoaiTK(LoaiTaiKhoanDTO loai)
        {
            string update = "UPDATE LOAIND "
                               + "SET TENLOAI = @TENLOAI,"
                               + " TINHTRANG = @TINHTRANG"

                               + " WHERE MALOAIND = @MALOAIND";
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@TENLOAI", loai.TENLOAI));
            lsparams.Add(new SqlParameter("@TINHTRANG", loai.TINHTRANG));
            lsparams.Add(new SqlParameter("@MALOAIND", loai.MALOAIND));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }
    }
}
