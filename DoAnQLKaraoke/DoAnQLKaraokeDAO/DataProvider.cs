using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnQLKaraokeDAO
{
    class DataProvider
    {
        static string strKetNoi = @"Data Source = . ; Initial Catalog = csdl; Integrated Security = true;";

        public static SqlConnection TaoKetNoi()
        {
            SqlConnection con = new SqlConnection(strKetNoi);
            con.Open();
            //MessageBox.Show("da ket noi csdl");
            return con;
        }
        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            return com.ExecuteReader();
        }

        public static SqlDataReader TruyVanDuLieu(string strTruyVan,SqlParameter[] param, SqlConnection conn) //trường hợp có parammeter
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            com.Parameters.AddRange(param);
            return com.ExecuteReader();
        }
        public static bool ThucThi(string strTruyVan, SqlParameter[] param, SqlConnection conn) //trường hợp có parammeter
        {

            SqlCommand scom = new SqlCommand(strTruyVan, conn);
            scom.Parameters.AddRange(param);
            int a = scom.ExecuteNonQuery();
            if (a != 0)
                return true;
            return false;
        }
        public static bool ThucThi(string strTruyVan, SqlConnection conn) //trường hợp khong có parammeter
        {

            SqlCommand scom = new SqlCommand(strTruyVan, conn);
            int a = scom.ExecuteNonQuery();
            if (a != 0)
                return true;
            return false;
        }

    }
}
