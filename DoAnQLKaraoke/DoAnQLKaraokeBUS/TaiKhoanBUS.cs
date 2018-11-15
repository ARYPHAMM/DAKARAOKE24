using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DoAnQLKaraokeDAO;
using DoAnQLKaraokeDTO;
using System.Windows.Forms;

namespace DoAnQLKaraokeBUS
{
    public class TaiKhoanBUS
    {
        public List<TaiKhoanDTO> DanhSachTaiKhoan()
        {
            TaiKhoanDAO b = new TaiKhoanDAO();
            return b.dsTaiKhoan();
        }
        public TaiKhoanDTO LayThongTinTaiKhoan(string taikhoan,string matkhau)
        {
          
            TaiKhoanDAO b = new TaiKhoanDAO();
            List<TaiKhoanDTO> dstk =  b.dsTaiKhoan();
            TaiKhoanDTO tk = dstk.Find(o => o.TAIKHOAN.Trim() == taikhoan && o.MATKHAU.Trim() == matkhau);
            return tk;
        }
    }
}
