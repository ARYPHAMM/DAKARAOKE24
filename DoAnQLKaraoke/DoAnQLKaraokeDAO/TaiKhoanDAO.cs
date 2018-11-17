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
        public List<TaiKhoanDTO> dsTaiKhoan()
        {


            List<TaiKhoanDTO> ds = new List<TaiKhoanDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string sql = "select * from NGUOIDUNG ";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
            while (sdr.Read())
            {
                TaiKhoanDTO a = new TaiKhoanDTO()
                {

                    MAND = sdr.GetString(0),
                    MANV = sdr.GetString(1),
                    LOAIND = int.Parse(sdr["LOAIND"].ToString()),
                    TINHTRANG = int.Parse(sdr["TINHTRANG"].ToString()),
                    TAIKHOAN = sdr.GetString(4),
                    MATKHAU = sdr.GetString(5)
                };
                ds.Add(a);

            }
            sdr.Close();
            conn.Close();
            return ds;
        }

        public bool CapNhatTaiKhoan(TaiKhoanDTO taikhoan)
        {
            string insert = "Update NGUOIDUNG"
                          + " Set TAIKHOAN = @TAIKHOAN,"
                         + "MATKHAU = @MATKHAU, LOAIND =  @LOAIND , TINHTRANG = @TINHTRANG"
                                   + " where  MAND = @MAND";

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAND", taikhoan.MAND.Trim()));
            lsparams.Add(new SqlParameter("@TAIKHOAN", taikhoan.TAIKHOAN));
            lsparams.Add(new SqlParameter("@MATKHAU", Utils.MaHoaMD5(taikhoan.MATKHAU)));
            lsparams.Add(new SqlParameter("@LOAIND", taikhoan.LOAIND));
            lsparams.Add(new SqlParameter("@TINHTRANG", taikhoan.TINHTRANG));

            //lsparams.Add(new SqlParameter("@TrangThai", nvmoi.TrangThai));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;
        }

        public bool ThemTaiKhoan(TaiKhoanDTO tkmoi)
        {


            string insert = "Insert into NGUOIDUNG(MAND,MANV,"
                                        + "LOAIND,TINHTRANG,TAIKHOAN,MATKHAU)values("
                                        + " @MAND,@MANV,"
                                         + "@LOAIND,@TINHTRANG,@TAIKHOAN,@MATKHAU)";

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAND", tkmoi.MAND.Trim()));
            lsparams.Add(new SqlParameter("@TAIKHOAN", tkmoi.TAIKHOAN));
            lsparams.Add(new SqlParameter("@MATKHAU", Utils.MaHoaMD5(tkmoi.MATKHAU)));
            lsparams.Add(new SqlParameter("@MANV", "NV01"));
            lsparams.Add(new SqlParameter("@LOAIND", tkmoi.LOAIND));
            lsparams.Add(new SqlParameter("@TINHTRANG", tkmoi.TINHTRANG));
            //lsparams.Add(new SqlParameter("@TrangThai", nvmoi.TrangThai));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;


        }

        public string LayMaNDMaxPhamLonNhat()
        {
            string strtruyvan = "Select max(MAND) From NGUOIDUNG";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            string mamax = null;
            if (sdr.Read())
            {
                try
                {
                    mamax = sdr.GetString(0);
                }
                catch
                {

                }

            }
            sdr.Close();
            conn.Close();
            return mamax;
        }

    }
}
