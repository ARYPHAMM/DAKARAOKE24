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
   public class LoaiPhongDAO
    {
        public List<LoaiPhongDTO> dsloaiPhong()
        {

            List<LoaiPhongDTO> ds = new List<LoaiPhongDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string sql = "select * from LOAIPHONG";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
            while (sdr.Read())
            {
                LoaiPhongDTO a = new LoaiPhongDTO()
                {
                    MALOAIPHONG = sdr.GetInt32(0),
                    TENLOAIPHONG = sdr.GetString(1),
                    TINHTRANG = sdr.GetBoolean(2)

                };
                ds.Add(a);
            }
            sdr.Close();
            conn.Close();
            return ds;
        }

        public bool CapNhatLoaiPhong(LoaiPhongDTO loai)
        {
            string update = "UPDATE LOAIPHONG "
                               + "SET TENLOAIPHONG = @TENLOAIPHONG,"
                               + " TINHTRANG = @TINHTRANG"
                               + " WHERE MALOAIPHONG = @MALOAIPHONG";
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@TENLOAIPHONG",loai.TENLOAIPHONG));
            lsparams.Add(new SqlParameter("@TINHTRANG", loai.TINHTRANG));
            lsparams.Add(new SqlParameter("@MALOAIPHONG", loai.MALOAIPHONG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }
    }
}
