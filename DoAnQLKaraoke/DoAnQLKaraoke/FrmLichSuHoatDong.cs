using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLKaraokeDTO;
using DoAnQLKaraokeBUS;

namespace DoAnQLKaraoke
{
    public partial class FrmLichSuHoatDong : Form
    {
        public FrmLichSuHoatDong()
        {
            InitializeComponent();
            dgv_lichsu.AutoGenerateColumns = true;
        }

        private void FrmLichSuHoatDong_Load(object sender, EventArgs e)
        {
            LichSuNguoiDungBUS a = new LichSuNguoiDungBUS();
            dgv_lichsu.DataSource = a.DSLichSuHoatDong();
        }
    }
}
