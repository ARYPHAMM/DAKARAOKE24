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
   public class LichSuNguoiDungDAO
    {
       public List<LichSuNguoiDungDTO> DanhSachLichSuNguoiDung()
        {
            List<LichSuNguoiDungDTO> ds = new List<LichSuNguoiDungDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string sql = "select * from LICHSUNGUOIDUNGHETHONG";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(sql, conn);
            while (sdr.Read())
            {
                LichSuNguoiDungDTO a = new LichSuNguoiDungDTO()
                {
                    MAHD = sdr.GetInt32(0),
                    MAND = sdr.GetString(1),
                    MANV = sdr.GetString(2),
                    THOIGIAN = DateTime.Parse(sdr.GetDateTime(3).ToString("dd/MM/yyyy HH:mm")),
                    SUKIEN = sdr.GetString(4),
                    
                    };
                ds.Add(a);
            }
            sdr.Close();
            conn.Close();
            return ds;
        }
        public bool ThemLichSuNguoiDung(LichSuNguoiDungDTO ls)
        {
            


            string insert = "INSERT INTO LICHSUNGUOIDUNGHETHONG"
                                      + " (MAHD"
                                      + " ,MAND"
                                       + "  ,MANV"
                                        + " ,THOIGIAN"
                                        + " ,SUKIEN)"
                                  + " VALUES"
                                       + " (@MAHD"
                                         + ",@MAND"
                                            + ",@MANV"
                                        + " ,@THOIGIAN"
                                        + " ,@SUKIEN)";
            ls.MAHD = MaHanhDongMoi();

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAHD", ls.MAHD));
            lsparams.Add(new SqlParameter("@MAND", ls.MAND));
            lsparams.Add(new SqlParameter("@MANV", ls.MANV));
            lsparams.Add(new SqlParameter("@THOIGIAN", ls.THOIGIAN));
            lsparams.Add(new SqlParameter("@SUKIEN", ls.SUKIEN));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;
        }

        public void xoalichsu()
        {
            string strtruyvan = "Delete from LICHSUNGUOIDUNGHETHONG";
            SqlConnection conn = DataProvider.TaoKetNoi();
            bool kq = DataProvider.ThucThi(strtruyvan, conn);
        }

        public static int MaHanhDongMoi()
        {
            string strtruyvan = "Select max(MAHD) From LICHSUNGUOIDUNGHETHONG";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            int maHDmoi = 0;
            if (sdr.Read())
            {
                try
                {
                    maHDmoi = sdr.GetInt32(0);
                }
                catch
                {
                    maHDmoi = 0;
                } 

            }
            return ++maHDmoi;
               



        }

    }
}
