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
                                      + " (MAND"
                                       + "  ,MANV"
                                        + " ,THOIGIAN"
                                        + " ,SUKIEN)"
                                  + " VALUES"
                                       + " (@MAND"
                                            + ",@MANV"
                                        + " ,@THOIGIAN"
                                        + " ,@SUKIEN)";

            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MAND", ls.MAND));
            lsparams.Add(new SqlParameter("@MANV", ls.MANV));
            lsparams.Add(new SqlParameter("@THOIGIAN", ls.THOIGIAN));
            lsparams.Add(new SqlParameter("@SUKIEN", ls.SUKIEN));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;
        }
        public string MaHanhDongMoi()
        {
            string strtruyvan = "Select max(MAHD) From LICHSUNGUOIDUNGHETHONG";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            string mHDmoi = null;
            if (sdr.Read())
            {
                try
                {
                    mHDmoi = sdr.GetString(0);
                //MessageBox.Show(masuamax);

            }
                catch
            {
                mHDmoi = null;
            }



        }
            sdr.Close();
            conn.Close();
            if (string.IsNullOrEmpty(mHDmoi))
            {
                return "HDO01";

            }
            else
            {
                int masotiep = int.Parse(mHDmoi.Substring(3));/*MaSPLonNhat.Replace('S', '')*/
                //return string.Format("S{0:4}", masotiep + 1);
                ++masotiep;
                return "HDO" + masotiep.ToString("00");
            }




        }
    }
}
