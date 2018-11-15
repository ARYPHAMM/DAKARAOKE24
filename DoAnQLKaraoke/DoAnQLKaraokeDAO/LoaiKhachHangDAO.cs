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
    public class LoaiKhachHangDAO
    {
       // string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdl;Integrated Sucurity = True;";
        public List<LoaiKhachHangDTO> dsloaiKH()
        {

            List<LoaiKhachHangDTO> ds = new List<LoaiKhachHangDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string sql = "select * from LOAIKH";

            SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
            while (sdr.Read())
            {
                LoaiKhachHangDTO a = new LoaiKhachHangDTO()
                {
                    MALOAI = sdr.GetInt32(0),
                    TENLOAIKH = sdr.GetString(1),
                    TINHTRANG = sdr.GetBoolean(2)

                };
                ds.Add(a);
            }
            sdr.Close();
            conn.Close();
            return ds;
        }
        public bool CapNhatLoaiKH(LoaiKhachHangDTO loai)
        {
            string update = "UPDATE LOAIKH "
                               + "SET TENLOAIKH = @TENLOAIKH,"
                               + " TINHTRANG = @TINHTRANG"
                               + " WHERE MALOAI = @MALOAI";
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@TENLOAIKH", loai.TENLOAIKH));
            lsparams.Add(new SqlParameter("@TINHTRANG", loai.TINHTRANG));
            lsparams.Add(new SqlParameter("@MALOAI", loai.MALOAI));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }
    }
}
