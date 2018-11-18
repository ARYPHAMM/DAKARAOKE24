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
    public partial class FrmQLLoaiPhong : Form
    {
        public int trThai = 1;
        public LoaiPhongDTO loaiPhong = null;
        public FrmQLLoaiPhong()
        {
            InitializeComponent();
        }

        private void TrangThai()
        {
            switch (trThai)
            {
                case 1: // mac dinh
                    {

                        //Bind();
                        btn_luu.Visible = false;
                        btn_capNhat.Text = "Cập nhật";
                        btn_capNhat.Image = Properties.Resources.edit;                    
                        txt_maLoai.Enabled = false;
                        txt_tenLoai.Enabled = false;
                        ckb_tinhtrang.Enabled = false;
                    }
                    break;
                case 2: // chinh sua
                    {
                        btn_luu.Visible = true;
                        btn_capNhat.Text = "Hủy";
                        btn_capNhat.Image = Properties.Resources.cancel;
                        txt_maLoai.Enabled = false;
                        txt_tenLoai.Enabled = true;
                        ckb_tinhtrang.Enabled = true;
                    }
                    break;


            }
        }

        private void LoadData()
        {
            
            LoaiPhongBUS b = new LoaiPhongBUS();
            dgv_loaiphong.DataSource = b.DanhSachLoaiPhong();


        }

        private void FrmQLLoaiPhong_Load(object sender, EventArgs e)
        {

            LoadData();
            TrangThai();
            
        }

        private void dgv_loaiphong_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_loaiphong.SelectedRows.Count > 0)
            {
                trThai = 1;
                TrangThai();
                btn_capNhat.Enabled = true;
                loaiPhong = (LoaiPhongDTO)dgv_loaiphong.SelectedRows[0].DataBoundItem; // dgvSinhVien.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                loaiPhong = null;
            }
            Bind();
        }
        private void Bind()
        {


            if (loaiPhong != null)
            {
                txt_maLoai.Text = loaiPhong.MALOAIPHONG.ToString();
                txt_tenLoai.Text = loaiPhong.TENLOAIPHONG;
                ckb_tinhtrang.Checked = loaiPhong.TINHTRANG;

            }
            else
            {
                if (dgv_loaiphong.SelectedRows.Count == 0)
                {
                    txt_maLoai.Text = string.Empty; // truong hop dang cap nhat
                }
                txt_tenLoai.Text = string.Empty;
                ckb_tinhtrang.Checked = false;
            }
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            if (trThai != 2)
            {
                loaiPhong = null;
                Bind();
            }
               
          
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            LoaiPhongBUS a = new LoaiPhongBUS();
            if (trThai == 2)
            {
                LoaiPhongDTO loai;
                try
                {
                    loai = new LoaiPhongDTO()
                    {
                        MALOAIPHONG = int.Parse(txt_maLoai.Text),
                        TENLOAIPHONG = txt_tenLoai.Text,
                        TINHTRANG = ckb_tinhtrang.Checked ? true : false
                    };


                }
                catch
                {
                    MessageBox.Show("Thieu thong tin");
                    return;

                }
                bool kt = a.CapNhatLoaiPhong(loai);
                if (!kt)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                    trThai = 1;
                    loaiPhong = null;
                }

            }
            TrangThai();
            Bind();
            LoadData();
        }
        private void btn_capNhat_Click(object sender, EventArgs e)
        {

            if (trThai == 2) 
            {
                trThai = 1;
                TrangThai();

            }
            else
            {
                trThai = 2;
                TrangThai();
            }
        }

        private void btn_quayve_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmQLPhong qlphong = new FrmQLPhong();
            qlphong.MdiParent = FrmChinh.ActiveForm;
            qlphong.Dock = DockStyle.Fill;
            qlphong.FormBorderStyle = FormBorderStyle.None;
            qlphong.WindowState = FormWindowState.Maximized;
            qlphong.StartPosition = FormStartPosition.CenterScreen;
            qlphong.Show();

        }
    }
}
