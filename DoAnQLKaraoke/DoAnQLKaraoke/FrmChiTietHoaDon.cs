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
    public partial class FrmChiTietHoaDon : Form
    {
        ThucDonBUS tdBUS = null;
        ChiTietHoaDonBUS ctHdBUS = null;
        List<ChiTietHoaDonDTO> lsCTHDDTO = null;
        List<ThucDonDTO> lsThucDon = null;
        ChiTietHoaDonDTO ctHDHienHanh = null;

        public FrmChiTietHoaDon()
        {

          
            InitializeComponent();
            txt_maHD.Text = FrmQLHoaDon.hdHienHanh.MAHD;
            txt_tenPhong.Text = FrmQLHoaDon.hdHienHanh.TENPHONG;
            dtp_thoiGianBatDau.Value = FrmQLHoaDon.hdHienHanh.THOIGIANBATDAU;
            txt_tenKH.Text = FrmQLHoaDon.hdHienHanh.HOTENKH;



        }

        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            lv_thucDon.Items.Clear();


             ctHdBUS= new ChiTietHoaDonBUS();
            lsCTHDDTO = ctHdBUS.DanhSachChiTietHD(FrmQLHoaDon.hdHienHanh.MAHD);
            dgv_CTHD.DataSource = lsCTHDDTO;

            tdBUS = new ThucDonBUS();
            lsThucDon = tdBUS.DanhSachTD();

            foreach (ThucDonDTO td in lsThucDon)
            {

                ListViewItem item = new ListViewItem(td.TENTHUCDON);
                item.SubItems.Add(td.MATD);
                item.SubItems.Add(td.GIA.Replace("VNĐ", "").Replace(".", ""));
                lv_thucDon.Items.Add(item);

            }

        }

        private void lv_thucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_thucDon.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_thucDon.SelectedItems[0];
                ctHDHienHanh = new ChiTietHoaDonDTO()
                {
                    MAHD = FrmQLHoaDon.hdHienHanh.MAHD.Trim(),
                    MATD = item.SubItems[1].Text,
                    TENTHUCDON = item.SubItems[0].Text,
                    SOLUONG = 1,
                    GIA = item.SubItems[2].Text,
                    THANHTIEN = (1* int.Parse(item.SubItems[2].Text)).ToString()

                };

            }
            Bind();
        }

        private void Bind()
        {
            if(ctHDHienHanh!= null)
            {
                txt_tenThucDon.Text = ctHDHienHanh.TENTHUCDON;
                txt_soLuong.Text = ctHDHienHanh.SOLUONG.ToString();
                txt_gia.Text = ctHDHienHanh.GIA.ToString();
                txt_thanhTien.Text = ctHDHienHanh.THANHTIEN.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           

            if (ctHDHienHanh != null)
            {

                ctHDHienHanh.SOLUONG = int.Parse(txt_soLuong.Text);
                ctHDHienHanh.THANHTIEN = (double.Parse(txt_soLuong.Text) * double.Parse(txt_gia.Text)).ToString();
             
                if (KiemTraTDbiTrung(ctHDHienHanh))
                {
                    ctHDHienHanh.THANHTIEN = (double.Parse(txt_soLuong.Text) * double.Parse(txt_gia.Text)).ToString();
                    bool ktcn = ctHdBUS.CapNhatSLCTHD(ctHDHienHanh);
                    if(ktcn)
                    {
                        MessageBox.Show("Cập nhật lại sl thành công");
                    }
                }
                else
                {
                    bool kq = ctHdBUS.ThemCTHD(ctHDHienHanh);
                    if (kq)
                    {
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }

            }
            LoadData();
        }

        private bool KiemTraTDbiTrung(ChiTietHoaDonDTO ctHDHienHanh)
        {
            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
            {
                if (dgv_CTHD.Rows[i].Cells[1].Value.ToString().Trim() == ctHDHienHanh.MATD.Trim())
                {
                    return true;

                }
            }
            return false;
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int thanhtien = int.Parse(txt_soLuong.Text) * int.Parse(txt_gia.Text);
                txt_thanhTien.Text = thanhtien.ToString();
            }
            catch
            {

            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (dgv_CTHD.SelectedRows.Count > 0)
            {
                ctHDHienHanh = (ChiTietHoaDonDTO)dgv_CTHD.SelectedRows[0].DataBoundItem;
                bool kt = ctHdBUS.CapNhatCTHD(ctHDHienHanh);
                     if(kt)
                    {
                    MessageBox.Show("Cap nhat thanh cong");
                    }
            }
            LoadData();
        }

        private void dgv_CTHD_SelectionChanged(object sender, EventArgs e)
        {
          
            if (dgv_CTHD.SelectedRows.Count > 0)
            {
                ctHDHienHanh = null;
                ctHDHienHanh = (ChiTietHoaDonDTO)dgv_CTHD.SelectedRows[0].DataBoundItem;
            }
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            //FrmXemBaoCao f = new FrmXemBaoCao();
            //HoaDonBUS hdBUS = new HoaDonBUS();
            //HoaDonDTO a = FrmQLHoaDon.hdHienHanh;

            //bool ktThanhToan = hdBUS.ThanhToan(a);
            //if (ktThanhToan)
            //{
              
            //    f.XemHoaDon(a);
            //}
            //f.Show();
            


        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmQLHoaDon f = new FrmQLHoaDon();
            f.MdiParent = FrmChinh.ActiveForm;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.WindowState = FormWindowState.Maximized;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }
    }
}
