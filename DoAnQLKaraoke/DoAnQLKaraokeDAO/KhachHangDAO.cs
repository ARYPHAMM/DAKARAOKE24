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
    public class KhachHangDAO
    {
        //string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<KhachHangDTO> dsKhachHang()
        {

            List<KhachHangDTO> ds = new List<KhachHangDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from KHACHANG", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                KhachHangDTO a = new KhachHangDTO()
                {
                    MAKH = sdr.GetString(0),
                    LOAIKH = sdr.GetInt32(1),
                    TENKH = sdr.GetString(2),
                    SDT = sdr.GetString(3),
                    TINHTRANG = sdr.GetInt32(4)

                };
                ds.Add(a);
            }
            return ds;
        }
        public bool ThemKH(KhachHangDTO khachhang)
        {
            string insert = "INSERT INTO KHACHANG"
                                      + " (MAKH"
                                       +",TENKH"
                                       + "  , LOAIKH"
                                        +",SDT"
                                        + " , TINHTRANG)"
                                  + " VALUES"
                                     + "(@MAKH,"
                                     + "@TENKH,"
                                     + "@LOAIKH,"
                                     +"@SDT,"
                                      + "@TINHTRANG)";
            //SqlParameter[] arrParams = new SqlParameter[7];
            
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAKH", khachhang.MAKH));
            lsparams.Add(new SqlParameter("@TENKH", khachhang.TENKH));
            lsparams.Add(new SqlParameter("@LOAIKH", khachhang.LOAIKH));
            lsparams.Add(new SqlParameter("@SDT", khachhang.SDT));
            lsparams.Add(new SqlParameter("@TINHTRANG", khachhang.TINHTRANG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;

            
        }
        public List<KhachHangDTO> TraCuu(int x, int y)
        {
            string search = "SELECT * FROM KHACHANG"
                               + " WHERE MAKH LIKE '%" + x + "%' and TINHTRANG  LIKE '%" + y + "%' ";


            SqlConnection con = DataProvider.TaoKetNoi();
            List<KhachHangDTO> ds = new List<KhachHangDTO>();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(search, con);
            while (sdr.Read())
            {
                KhachHangDTO a = new KhachHangDTO();
                a.MAKH = sdr.GetString(0);
                a.TENKH = sdr.GetString(1);
                a.LOAIKH = sdr.GetInt32(2);
                a.SDT = sdr.GetString(3);
                a.TINHTRANG = sdr.GetInt32(4);
                ds.Add(a);
            }
            sdr.Close();
            con.Close();
            return ds;
        }
        public bool CapNhatKH(KhachHangDTO khachhang)
        {
            string update = "UPDATE KHACHANG "
                             + "SET "
                             + " TENKH = @TENKH ,"
                              +" LOAIKH = @LOAIKH ,"
                              +"SDT=@SDT ,"
                              + "TINHTRANG = @TINHTRANG "
                              + " WHERE MAKH = @MAKH";
            //SqlParameter[] arrParams = new SqlParameter[7];

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAKH", khachhang.MAKH));
            lsparams.Add(new SqlParameter("@TENKH", khachhang.TENKH));
            lsparams.Add(new SqlParameter("@LOAIKH", khachhang.LOAIKH));
            lsparams.Add(new SqlParameter("@SDT", khachhang.SDT));
            lsparams.Add(new SqlParameter("@TINHTRANG", khachhang.TINHTRANG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }

        public string MaKHMoi()
        {
            string strtruyvan = "Select max(MAKH) From KHACHANG";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            string maKHmoi = null;
            if (sdr.Read())
            {
                try
                {
                    maKHmoi = sdr.GetString(0);
                    //MessageBox.Show(masuamax);
                }
                catch
                {
                  
                }
                return maKHmoi;


            }
            sdr.Close();
            conn.Close();
            return maKHmoi;

        }
        public bool Them(KhachHangDTO khachhang)
        {
            throw new NotImplementedException();
        }

        public bool CapNhat(KhachHangDTO khachhang)
        {
            throw new NotImplementedException();
        }
    }
}
