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
    public class NhanVienDAO
    {
        // string chuoiketnoi = @"Data Source =DESKTOP-20TAQ02\SQLEXPRESS;Initial Catalog = csdlDAKARAOKE;Integrated Sucurity = True;";
        public List<NhanVienDTO> dsNhanVien()
        {

            List<NhanVienDTO> ds = new List<NhanVienDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select * from NHANVIEN where TinhTrang=1", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                NhanVienDTO a = new NhanVienDTO()
                {

                    MANV = sdr.GetString(0),
                    HONV = sdr.GetString(1),
                    TENV = sdr.GetString(2),
                    NAMSINH = Convert.ToDateTime(sdr.GetDateTime(3).ToString("dd/MM/yyyy")),
                    LOAINV = sdr.GetInt32(4),
                    SDTNV = sdr.GetString(5),
                     EMAIL=sdr.GetString(6),
                      DIACHI=sdr.GetString(7),
                    TINHTRANG = sdr.GetInt32(8)
                   
                   
                };
                ds.Add(a);
            }
            return ds;
        }
        public bool ThemNhanVien(NhanVienDTO nhanvien)
        {
            string insert = "INSERT INTO NHANVIEN"
                                      + " (MANV"
                                       + ", HONV"
                                       + ",TENV"
                                       + "  , LOAINV"
                                        + " , NAMSINH"
                                        + ",SDTNV"
                                        + ",DIACHI"
                                        + ",EMAIL"
                                        + " ,TINHTRANG)"
                                  + " VALUES"
                                     + "(@MANV,"
                                     + "@HONV,"
                                     + "@TENV,"
                                     + "@LOAINV,"
                                     + "@NAMSINH,"
                                     + "@SDTNV,"
                                     + "@DIACHI,"
                                     + "@EMAIL,"
                                      + "@TINHTRANG)";
            //SqlParameter[] arrParams = new SqlParameter[7];

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MANV", nhanvien.MANV));
            lsparams.Add(new SqlParameter("@HONV", nhanvien.HONV));
            lsparams.Add(new SqlParameter("@TENV", nhanvien.TENV));
            lsparams.Add(new SqlParameter("@LOAINV", nhanvien.LOAINV));
            lsparams.Add(new SqlParameter("@NAMSINH", nhanvien.NAMSINH));
            lsparams.Add(new SqlParameter("@SDTNV", nhanvien.SDTNV));
            lsparams.Add(new SqlParameter("@DIACHI", nhanvien.DIACHI));
            lsparams.Add(new SqlParameter("@EMAIL", nhanvien.EMAIL));
            lsparams.Add(new SqlParameter("@TINHTRANG", nhanvien.TINHTRANG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;


        }
        public List<NhanVienDTO> TraCuu(int x, int y)
        {
            string search = "SELECT * FROM NHANVIEN"
                               + " WHERE MANV LIKE '%" + x + "%' and TINHTRANG  LIKE '%" + y + "%' ";


            SqlConnection con = DataProvider.TaoKetNoi();
            List<NhanVienDTO> ds = new List<NhanVienDTO>();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(search, con);
            while (sdr.Read())
            {
                NhanVienDTO a = new NhanVienDTO();
                a.MANV = sdr.GetString(0);
                a.HONV = sdr.GetString(1);
                a.TENV = sdr.GetString(2);
                a.LOAINV = sdr.GetInt32(3);
                a.NAMSINH = sdr.GetDateTime(4);
                a.SDTNV = sdr.GetString(5);
                a.TINHTRANG = sdr.GetInt32(6);
                a.DIACHI = sdr.GetString(7);
                a.EMAIL = sdr.GetString(8);
                ds.Add(a);
            }
            sdr.Close();
            con.Close();
            return ds;
        }
        public bool CapNhaNV(NhanVienDTO nhanvien)
        {
            string update = "UPDATE NHANVIEN "
                              + "SET HONV = @HONV,"
                              + "TENV=@TENV,"
                              + " LOAINV = @LOAINV,"
                              + "NAMSINH = @NAMSINH,"
                              + "SDTNV=@SDTNV,"
                              + "DIACHI=@DIACHI,"
                              + "EMAIL=@EMAIL,"
                              + " TINHTRANG = @TINHTRANG"
                              + " WHERE MANV = @MANV";
            //SqlParameter[] arrParams = new SqlParameter[7];

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MANV", nhanvien.MANV));
            lsparams.Add(new SqlParameter("@HONV", nhanvien.HONV));
            lsparams.Add(new SqlParameter("@TENV", nhanvien.TENV));
            lsparams.Add(new SqlParameter("@LOAINV", nhanvien.LOAINV));
            lsparams.Add(new SqlParameter("@NAMSINH", nhanvien.NAMSINH));
            lsparams.Add(new SqlParameter("@SDTNV", nhanvien.SDTNV));
            lsparams.Add(new SqlParameter("@DIACHI", nhanvien.DIACHI));
            lsparams.Add(new SqlParameter("@EMAIL", nhanvien.EMAIL));
            lsparams.Add(new SqlParameter("@TINHTRANG", nhanvien.TINHTRANG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }

        public string MaNVMoi()
        {
            string strtruyvan = "Select max(MANV) From NHANVIEN";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            string ma = null;
            if (sdr.Read())
            {
                try
                {
                    ma = sdr["MANV"].ToString();
                }
                catch
                {

                }

            }
            sdr.Close();
            conn.Close();
            return ma;
        }
    }
}
