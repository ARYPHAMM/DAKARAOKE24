using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraokeDAO
{
   public class LoaiNhanVienDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdl;Integrated Sucurity = True;";
        public List<LoaiNhanVienDTO> dsloaiNV()
        {

            List<LoaiNhanVienDTO> ds = new List<LoaiNhanVienDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from LOAINV ", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                LoaiNhanVienDTO a = new LoaiNhanVienDTO()
                {
                    MALOAI = sdr.GetInt32(0),
                    TENLOAI = sdr.GetString(1),
                    TINHTRANG = sdr.GetBoolean(2)

                };
                ds.Add(a);
            }
            sdr.Close();
            conn.Close();
            return ds;
        }
        public bool CapNhatLoaiNV(LoaiNhanVienDTO loai)
        {
            string update = "UPDATE LOAINV "
                               + "SET TENLOAI = @TENLOAI,"
                               + " TINHTRANG = @TINHTRANG"
                               + " WHERE MALOAI = @MALOAI";
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@TENLOAI", loai.TENLOAI));
            lsparams.Add(new SqlParameter("@TINHTRANG", loai.TINHTRANG));
            lsparams.Add(new SqlParameter("@MALOAI", loai.MALOAI));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }
    }
}
