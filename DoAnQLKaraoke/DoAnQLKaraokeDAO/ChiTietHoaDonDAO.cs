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
    public class ChiTietHoaDonDAO
    {
        public List<ChiTietHoaDonDTO> DanhSachChiTietHD(string MAHD)
        {
            List<ChiTietHoaDonDTO> ds = new List<ChiTietHoaDonDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string sql = "select * from CTHD where MAHD = '"+MAHD.Trim()+"'";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
            while (sdr.Read())
            {
                ChiTietHoaDonDTO a = new ChiTietHoaDonDTO()
                {
                    MAHD = sdr.GetString(0),
                    MATD = sdr.GetString(1),
                    TENTHUCDON = sdr.GetString(2),
                    SOLUONG = sdr.GetInt32(3),
                    GIA = sdr.GetDecimal(4).ToString("0,00 VNĐ"),
                    THANHTIEN = sdr.GetDecimal(5).ToString("0,00 VNĐ")

                };
                ds.Add(a);
            }
            sdr.Close();
            conn.Close();
            return ds;
        }

        public bool CapNhatSLCTHD(ChiTietHoaDonDTO ctHDHienHanh)
        {
            SqlConnection con = DataProvider.TaoKetNoi();
            string updatehd = "update HOADON set TONGTHANHTOAN = TONGTHANHTOAN + " + ctHDHienHanh.THANHTIEN.Replace("VNĐ", "").Replace(".", "") + " where MAHD = '" + ctHDHienHanh.MAHD + "'";
            bool kq = DataProvider.ThucThi(updatehd, con);
            string updateCTHD = "update CTHD SET SOLUONG = SOLUONG + " + ctHDHienHanh.SOLUONG + " ,THANHTIEN = THANHTIEN + " + ctHDHienHanh.THANHTIEN.Replace("VNĐ", "").Replace(".", "") + "  where MATD = '" + ctHDHienHanh.MATD + "'";
            bool thucthi = DataProvider.ThucThi(updateCTHD, con);
            return thucthi;
        }

       public void HuyCTHD(string maHD)
        {
            SqlConnection con = DataProvider.TaoKetNoi();
            string huyCTHD = "delete from CTHD where MAHD = '" + maHD + "'";
            bool thucthip = DataProvider.ThucThi(huyCTHD, con);
        }

        public bool CapNhatCTHD(ChiTietHoaDonDTO ctHDHienHanh)
        {
          
            SqlConnection con = DataProvider.TaoKetNoi();
            string updatehd = "update HOADON set TONGTHANHTOAN = TONGTHANHTOAN - " + ctHDHienHanh.THANHTIEN.Replace("VNĐ", "").Replace(".", "") + " where MAHD = '" + ctHDHienHanh.MAHD + "'";
            bool kq = DataProvider.ThucThi(updatehd, con);
            
            string updateCTHD = "DELETE  FROM CTHD where MATD = '" + ctHDHienHanh.MATD + "'";
            bool thucthi = DataProvider.ThucThi(updateCTHD, con);
            return thucthi;
        }

        public bool ThemCTHD(ChiTietHoaDonDTO ctHDHienHanh)
        {
            SqlConnection con = DataProvider.TaoKetNoi();
            string updatehd = "update HOADON set TONGTHANHTOAN = TONGTHANHTOAN + " + ctHDHienHanh.THANHTIEN.Replace("VNĐ", "").Replace(".", "") + " where MAHD = '" + ctHDHienHanh.MAHD + "'";
            bool kq = DataProvider.ThucThi(updatehd, con);
            string insert = "insert into CTHD(MAHD,MATD,TENTHUCDON,SOLUONG,GIA,THANHTIEN)VALUES(@MAHD,@MATD,@TENTHUCDON,@SOLUONG,@GIA,@THANHTIEN)";

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAHD", ctHDHienHanh.MAHD));
            lsparams.Add(new SqlParameter("@MATD", ctHDHienHanh.MATD));
            lsparams.Add(new SqlParameter("@TENTHUCDON", ctHDHienHanh.TENTHUCDON));
            lsparams.Add(new SqlParameter("@SOLUONG", ctHDHienHanh.SOLUONG));
            lsparams.Add(new SqlParameter("@GIA", ctHDHienHanh.GIA));
            lsparams.Add(new SqlParameter("@THANHTIEN", ctHDHienHanh.THANHTIEN));


            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;
        }
    }
}
