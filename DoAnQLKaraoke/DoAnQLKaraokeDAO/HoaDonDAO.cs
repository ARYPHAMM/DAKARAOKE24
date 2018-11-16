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
    public class HoaDonDAO
    {
        string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<HoaDonDTO> dsHoaDon()
        {

            List<HoaDonDTO> ds = new List<HoaDonDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

          string sql = "select * from HOADON";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
            while (sdr.Read())
            {
                HoaDonDTO a = new HoaDonDTO()
                {
                    MAHD = sdr.GetString(0),
                    MAPHONG = sdr.GetString(1),
                    MANV = sdr.GetString(2),
                    NGUOILAPHD = sdr.GetString(3),
                    MAKH = sdr.GetString(4),
                    HOTENKH = sdr.GetString(5),

                    THOIGIANBATDAU = DateTime.Parse(sdr.GetDateTime(6).ToString("dd/MM/yyyy HH:mm")),
                
                    THOIGIANKETTHUC = DateTime.Parse(sdr.GetDateTime(7).ToString("dd/MM/yyyy HH:mm")),

                    TONGTHANHTOAN =sdr.GetDecimal(8).ToString("0,00"),

                    TINHTRANG = sdr.GetBoolean(9),
                    GIAPHONG = sdr.GetDecimal(10).ToString("0,00"),

                };
                ds.Add(a);
            }
            return ds;
        }

        public bool CapNhatHD(HoaDonDTO hd)
        {
            DateTime aDateTime = DateTime.Now;


            //MessageBox.Show(aDateTime.ToString("dd/MM/yyyy HH:mm:ss.fff"));
            DateTime y2K = hd.THOIGIANBATDAU;


            TimeSpan interval = aDateTime.Subtract(y2K);


            SqlConnection con = DataProvider.TaoKetNoi();
            int gio = interval.Hours;
            if (gio > 1)
            {
                gio = gio - 1; // neu hat tren 2h
            }
            else
            {
                gio = 0; // hat chua den 1h
            }
            MessageBox.Show(gio.ToString());

            string capnhatphong = "UPDATE PHONG SET TINHTRANG = 2 where MAPHONG = '" + hd.MAPHONG + "'";
            bool thucthip = DataProvider.ThucThi(capnhatphong, con);
            string updateHD = "UPDATE HOADON SET TONGTHANHTOAN = TONGTHANHTOAN + (GIAPHONG * "+gio+"),THOIGIANKETTHUC = '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "', TINHTRANG = 1 where MAHD = '" + hd.MAHD.Trim()+"'";
            bool thucthi = DataProvider.ThucThi(updateHD, con);
            return thucthi;
        }

        public string MaHDLonNhat()
        {
            string strtruyvan = "Select max(MAHD) From HOADON";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            string maHDmoi = null;
            if (sdr.Read())
            {
                try
                {
                    maHDmoi = sdr.GetString(0);
                    //MessageBox.Show(masuamax);
              
                }
                catch
                {

                }
                return maHDmoi;

            }
            sdr.Close();
            conn.Close();
            return maHDmoi;
        }

        public bool ThemHD(HoaDonDTO hd)
        {
            string insert = "INSERT INTO HOADON"
                                                                       + "(MAHD,"
                                                                       + " MAPHONG,"
                                                                      + "  MANV,"
                                                                       + " NGUOILAPHD,"
                                                                       + " MAKH,"
                                                                       + " HOTENKH,"
                                                                       + " THOIGIANBATDAU,"
                                                                       + " THOIGIANKETTHUC,"
                                                                       + " TONGTHANHTOAN,"
                                                                       + " TINHTRANG,"
                                                                       + " GIAPHONG)"
                                   + " VALUES"
                                       + " (@MAHD,"
            + " @MAPHONG,"
            + " @MANV,"
            + " @NGUOILAPHD,"
           + "  @MAKH,"
            + " @HOTENKH,"
            + " @THOIGIANBATDAU,"
            + " @THOIGIANKETTHUC,"
            + " @TONGTHANHTOAN,"
            + " @TINHTRANG,"
            + " @GIAPHONG)";
            //SqlParameter[] arrParams = new SqlParameter[7];
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAHD", hd.MAHD.Trim()));
            lsparams.Add(new SqlParameter("@MAPHONG", hd.MAPHONG.Trim()));
            lsparams.Add(new SqlParameter("@MANV", hd.MANV));
            lsparams.Add(new SqlParameter("@NGUOILAPHD", hd.NGUOILAPHD));
            lsparams.Add(new SqlParameter("@MAKH", hd.MAKH));
            lsparams.Add(new SqlParameter("@HOTENKH", hd.HOTENKH));
            lsparams.Add(new SqlParameter("@THOIGIANBATDAU", hd.THOIGIANBATDAU));
            lsparams.Add(new SqlParameter("@THOIGIANKETTHUC", hd.THOIGIANBATDAU));
            lsparams.Add(new SqlParameter("@TINHTRANG", hd.TINHTRANG));
            lsparams.Add(new SqlParameter("@GIAPHONG", hd.GIAPHONG));
            lsparams.Add(new SqlParameter("@TONGTHANHTOAN", hd.GIAPHONG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;
        }

        //public List<HoaDonDTO> dsHoaDonTheoNgay(string date)
        //{
        //    List<HoaDonDTO> ds = new List<HoaDonDTO>();
        //    SqlConnection conn = DataProvider.TaoKetNoi();
        //    string sql = "select * from HOADON where  THOIGIANKETTHUC = '"+date+"'  and  TINHTRANG = 1";
        //    SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
        //    while (sdr.Read())
        //    {
        //        HoaDonDTO a = new HoaDonDTO()
        //        {
        //            MAHD = sdr.GetInt32(0),
        //            MAPHONG = sdr.GetInt32(1),
        //            MANV = sdr.GetString(2),
        //            NGUOILAPHD = sdr.GetString(3),
        //            MAKH = sdr.GetInt32(4),
        //            HOTENKH = sdr.GetString(5),

        //            THOIGIANBATDAU = sdr.GetDateTime(6),

        //            THOIGIANKETTHUC = sdr.GetDateTime(7),

        //            TONGTHANHTOAN = sdr.GetInt32(8),

        //            TINHTRANG = sdr.GetBoolean(9)

        //        };
        //        ds.Add(a);
        //    }
        //    return ds;
        //}
    }
}
