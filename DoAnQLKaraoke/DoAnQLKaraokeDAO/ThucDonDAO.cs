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
    public class ThucDonDAO
    {
        
        public List<ThucDonDTO> dsThucDon()
        {

            List<ThucDonDTO> ds = new List<ThucDonDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            SqlCommand com = new SqlCommand("select *  from THUCDON ,LOAITD where THUCDON.LOAITD = LOAITD.MALOAITD and lOAITD.TINHTRANG = '1'", conn);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                ThucDonDTO a = new ThucDonDTO()
                {
                    MATD = sdr.GetString(0),
                    LOAITD = sdr.GetInt32(1),
                    TENTHUCDON = sdr.GetString(2),
                    GIA = sdr.GetDecimal(3).ToString("0,00 VNĐ"),
                    TINHTRANG = sdr.GetInt32(4)

                };
                ds.Add(a);
            }
            return ds;
        }
        public bool ThemTD(ThucDonDTO thucdon)
        {
            string insert = "INSERT INTO THUCDON"
                + " (MATD"
                 + ", TENTHUCDON"
                 + "  , LOAITD"
                 + " , GIA"
                 + " , TINHTRANG)"
            + " VALUES"
                 + "(@MATD,"
                 + "@TENTHUCDON,"
                 + "@LOAITD,"
                 + "@GIA,"
                 + "@TINHTRANG)";
            string gia = null;
            foreach (char a in thucdon.GIA.ToString())
            {
                if (a.ToString() != "V" || a.ToString() != "N" || a.ToString() != "Đ")
                {
                    gia += a;
                }

            }
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MATD", thucdon.MATD));
            lsparams.Add(new SqlParameter("@TENTHUCDON", thucdon.TENTHUCDON));
            lsparams.Add(new SqlParameter("@GIA", thucdon.GIA));
            lsparams.Add(new SqlParameter("@LOAITD",thucdon.LOAITD));
            lsparams.Add(new SqlParameter("@TINHTRANG", thucdon.TINHTRANG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(insert, lsparams.ToArray(), con);
            return thucthi;
        }

        public List<ThucDonDTO> TraCuu(int x, int y)
        {
            string search = "SELECT * FROM THUCDON"
                               + " WHERE MATD LIKE '%" + x + "%' and TINHTRANG  LIKE '%" + y + "%' ";


            SqlConnection con = DataProvider.TaoKetNoi();
            List<ThucDonDTO> ds = new List<ThucDonDTO>();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(search, con);
            while (sdr.Read())
            {
                ThucDonDTO a = new ThucDonDTO();
                a.MATD = sdr.GetString(0);
                a.TENTHUCDON = sdr.GetString(1);
                a.LOAITD = sdr.GetInt32(2);
                a.GIA = sdr.GetDecimal(3).ToString("0,00 VNĐ");
                a.TINHTRANG = sdr.GetInt32(4);
                ds.Add(a);
            }
            sdr.Close();
            con.Close();
            return ds;
        }

        public bool CapNhatTD(ThucDonDTO thucdon)
        {
            string update = "UPDATE THUCDON "
                              + "SET TENTHUCDON = @TENTHUCDON,"
                              + " LOAITD = @LOAITD"
                              + ",GIA = @GIA"
                              + " , TINHTRANG = @TINHTRANG"
                              + " WHERE MATD = @MATD";
            //SqlParameter[] arrParams = new SqlParameter[7];
            string gia = null;
            foreach (char a in thucdon.GIA.ToString())
            {
                if (a.ToString() != "V" || a.ToString() != "N" || a.ToString() != "Đ")
                {
                    gia += a;
                }

            }
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MATD", thucdon.MATD));
            lsparams.Add(new SqlParameter("@TENTHUCDON", thucdon.TENTHUCDON));
            lsparams.Add(new SqlParameter("@GIA", thucdon.GIA));
            lsparams.Add(new SqlParameter("@LOAITD", thucdon.LOAITD));
            lsparams.Add(new SqlParameter("@TINHTRANG", thucdon.TINHTRANG));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThi(update, lsparams.ToArray(), con);
            return thucthi;
        }

        public string MaThucDonMoi()
        {
            string strtruyvan = "Select max(MATD) From THUCDON";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            string mathucdonmoi = null;
            if (sdr.Read())
            {
                mathucdonmoi = sdr.GetString(0);
                //MessageBox.Show(masuamax);
                return mathucdonmoi;

            }
            sdr.Close();
            conn.Close();
            return mathucdonmoi;



        }


    }
}
