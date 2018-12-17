using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQLKaraokeDTO;
using DoAnQLKaraokeDAO;
using System.Windows.Forms;
using System.IO;

namespace DoAnQLKaraokeBUS
{
   public class LichSuNguoiDungBUS
    {
        public bool ThemLichSuNguoiDung(LichSuNguoiDungDTO ls)
        {
            LichSuNguoiDungDAO a = new LichSuNguoiDungDAO();
            return a.ThemLichSuNguoiDung(ls);
        }
        public List<LichSuNguoiDungDTO>DSLichSuHoatDong()
        {
            LichSuNguoiDungDAO a = new LichSuNguoiDungDAO();
            return a.DanhSachLichSuNguoiDung();
        }

        public void GhiFile(List<LichSuNguoiDungDTO> lichSuSauMotNgay,string tenfile)
        {

           
            try
            {
                // Bước 1: tạo biến để lưu thư mục cần tạo, tên thư mục cần tạo là "StoredFiles"
                string directoryPath = @"lichsu\";
                // Bước 2: kiểm tra nếu thư mục "StoredFiles" chưa tồn tại thì tạo mới
                //if (!System.IO.Directory.Exists(directoryPath))
                //    System.IO.Directory.CreateDirectory(directoryPath);
                // Bước 4: tạo tập tin "EmployeeList.txt" trong thư mục "StoredFiles"
                string filePath = directoryPath + tenfile + ".txt";
                System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create);
                fs.Close();
                fs.Dispose();
                StreamWriter sw = new StreamWriter(@"E:\LTWNC\DoAnQLKaraoke\DoAnQLKaraoke\bin\Debug\lichsu\" + tenfile + ".txt", false);
                foreach (LichSuNguoiDungDTO lichsu in lichSuSauMotNgay) 
                {
                    string line = string.Format("{0},{1},{2},{3},{4}",lichsu.MAHD, lichsu.MAND, lichsu.MANV, lichsu.THOIGIAN,lichsu.SUKIEN);
                    sw.WriteLine(line);
                }
                sw.Close();
                sw.Dispose();
            }
            catch
            {

            }
            LichSuNguoiDungDAO a = new LichSuNguoiDungDAO();
            a.xoalichsu();


            // Kết thúc: thông báo tạo tập tin thành công
            // và chỉ ra đường dẫn tập tin để người dùng dễ dàng kiểm tra tập tin vừa tạo
            //string mesage = "Tạo tập tin \"EmployeeList.txt\" thành công." + Environment.NewLine;
            //mesage += "Đường dẫn là \"" + Application.StartupPath + @"\" + directoryPath + filePath + "\"";
            //MessageBox.Show(mesage, "Thông báo");
        }
    }
}
