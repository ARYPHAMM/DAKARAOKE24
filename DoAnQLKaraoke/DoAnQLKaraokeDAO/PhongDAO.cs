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
    public class PhongDAO
    {
       
        public List<PhongDTO> dsPhong()
        {

            List<PhongDTO> ds = new List<PhongDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

           string sql = "select * from PHONG ,LOAIPHONG where PHONG.LOAIPHONG = LOAIPHONG.MALOAIPHONG and LOAIPHONG.TINHTRANG = '1'";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
            while (sdr.Read())
            {
                PhongDTO a = new PhongDTO()
                {
                    MAPHONG = sdr.GetString(0),
                    TENPHONG = sdr.GetString(1),
                    LOAIPHONG = sdr.GetInt32(2),
                    GIAPHONG = sdr.GetDecimal(3).ToString("0,00 VNĐ"),
                    TINHTRANG = sdr.GetInt32(4),
                    SONGUOI = sdr.GetInt32(5)
                };
                ds.Add(a);
            }
            sdr.Close();
            conn.Close();
            return ds;
        }

        public bool ThemPhong(PhongDTO phong)
        {
            string insert = "INSERT INTO PHONG"
                                      + " (MAPHONG"
                                       + ", TENPHONG"
                                       + "  , LOAIPHONG"
                                        + " , GIAPHONG"
                                        + " , TINHTRANG"
                                                 + " , SONGUOI)"
                                  + " VALUES"
                                     + "(@MAPHONG,"
                                     + "@TENPHONG,"
                                     + "@LOAIPHONG,"
                                     + "@GIAPHONG,"
                                      + "@TINHTRANG"
                                       +" ,@SONGUOI)";
            //SqlParameter[] arrParams = new SqlParameter[7];
            string gia = null;
            foreach (char a in phong.GIAPHONG.ToString())
            {
                if (a.ToString() != "V" || a.ToString() != "N" || a.ToString() != "Đ")
                {
                    gia += a;
                }

            }
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAPHONG", phong.MAPHONG));
            lsparams.Add(new SqlParameter("@TENPHONG", phong.TENPHONG));
            lsparams.Add(new SqlParameter("@GIAPHONG", phong.GIAPHONG));
            lsparams.Add(new SqlParameter("@LOAIPHONG", phong.LOAIPHONG));
            lsparams.Add(new SqlParameter("@TINHTRANG", phong.TINHTRANG));
            lsparams.Add(new SqlParameter("@SONGUOI", phong.SONGUOI));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;
        }

        public List<PhongDTO> TraCuu(int x,int y)
        {
            string search = "SELECT * FROM PHONG"
                               + " WHERE MAPHONG LIKE '%" + x + "%' and TINHTRANG  LIKE '%" + y + "%' ";
                  

            SqlConnection con = DataProvider.TaoKetNoi();
            List<PhongDTO> ds = new List<PhongDTO>();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(search, con);
            while (sdr.Read())
            {
                PhongDTO a = new PhongDTO();
                    a.MAPHONG = sdr.GetString(0);
                    a.TENPHONG = sdr.GetString(1);
                    a.LOAIPHONG = sdr.GetInt32(2);
                    a.GIAPHONG = sdr.GetDecimal(3).ToString("0,00 VNĐ");
                    a.TINHTRANG = sdr.GetInt32(4);
                ds.Add(a);
            }
            sdr.Close();
            con.Close();
            return ds;
        }

        public bool CapNhatPhong(PhongDTO phong)
        {
            string update = "UPDATE PHONG "
                              + "SET TENPHONG = @TENPHONG,"
                              + " LOAIPHONG = @LOAIPHONG"
                              + ",GIAPHONG = @GIAPHONG"
                              + " , TINHTRANG = @TINHTRANG"
                               + " , SONGUOI = @SONGUOI"
                              + " WHERE MAPHONG = @MAPHONG";
            //SqlParameter[] arrParams = new SqlParameter[7];
            string gia = null;
            foreach (char a in phong.GIAPHONG.ToString())
            {
                if (a.ToString() != "V" || a.ToString() != "N" || a.ToString() != "Đ")
                {
                    gia += a;
                }

            }
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAPHONG", phong.MAPHONG));
            lsparams.Add(new SqlParameter("@TENPHONG", phong.TENPHONG));
            lsparams.Add(new SqlParameter("@GIAPHONG", phong.GIAPHONG));
            lsparams.Add(new SqlParameter("@LOAIPHONG", phong.LOAIPHONG));
            lsparams.Add(new SqlParameter("@TINHTRANG", phong.TINHTRANG));
            lsparams.Add(new SqlParameter("@SONGUOI", phong.SONGUOI));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }

        public string MaPhongMoi()
        {
            string strtruyvan = "Select max(MAPHONG) From PHONG";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            string maPhongmoi = null;
            if (sdr.Read())
            {
                maPhongmoi = sdr.GetString(0);
                //MessageBox.Show(masuamax);
                return maPhongmoi;

            }
            sdr.Close();
            conn.Close();
            return maPhongmoi;



        }

        public bool Them(ThucDonDTO thucdon)
        {
            throw new NotImplementedException();
        }

        public bool CapNhat(ThucDonDTO thucdon)
        {
            throw new NotImplementedException();
        }
    }
}
