using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLKaraokeDAO
{
    public class Utils
    {
        public static string MaHoaMD5(string strChuoi)
        {
            MD5 mahoa = MD5.Create();
            //Chuyển chuỗi sang mảng byte
            byte[] mangchuoi = Encoding.UTF8.GetBytes(strChuoi);
            //Băm mảng
            byte[] data = mahoa.ComputeHash(mangchuoi);

            //chuyển từng giá trị của mảng --> mã hóa sang số thập lục phân
            StringBuilder strKQ = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                strKQ.Append(data[i].ToString("x2"));
            }
            return strKQ.ToString();
        }
    }
}
