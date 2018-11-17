using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLKaraokeDTO
{
   public class NhanVienDTO
    {
        public string MANV { get; set; }
        public string HONV { get; set; }
        public string TENV { get; set; }
        public DateTime NAMSINH { get; set; }
        public int LOAINV { get; set; }
        public string SDTNV { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public int TINHTRANG { get; set; }
        public string HOTENNV
        {
            get
            {
                return HONV + " " + TENV;
            }
        }
    }
}
