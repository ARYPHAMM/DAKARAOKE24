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
    public partial class FrmQLLoaiKhachHang : Form
    {
        public int trThai = 1;
        public LoaiKhachHangDTO loaiKH = null;
        public FrmQLLoaiKhachHang()
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
                        txt_MaLoai.Enabled = false;
                        txt_TenLoai.Enabled = false;
                        ckb_TinhTrang.Enabled = false;
                    }
                    break;
                case 2: // chinh sua
                    {
                        btn_luu.Visible = true;
                        btn_capNhat.Text = "Hủy";
                        btn_capNhat.Image = Properties.Resources.cancel;
                        txt_MaLoai.Enabled = false;
                        txt_TenLoai.Enabled = true;
                        ckb_TinhTrang.Enabled = true;
                    }
                    break;


            }
        }

        private void LoadData()
        {

            LoaiKhachHangBUS b = new LoaiKhachHangBUS();
            dgv_LoaiKH.DataSource = b.DanhSachLoaiKH();


        }

        private void FrmQLLoaiKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            TrangThai();
        }
        private void Bind()
        {


            if (loaiKH != null)
            {
                txt_MaLoai.Text = loaiKH.MALOAI.ToString();
                txt_TenLoai.Text = loaiKH.TENLOAIKH;
                ckb_TinhTrang.Checked = loaiKH.TINHTRANG;

            }
            else
            {
                if (dgv_LoaiKH.SelectedRows.Count == 0)
                {
                    txt_MaLoai.Text = string.Empty; // truong hop dang cap nhat
                }
                txt_TenLoai.Text = string.Empty;
                ckb_TinhTrang.Checked = false;
            }
        }

        private void dgv_LoaiKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_LoaiKH.SelectedRows.Count > 0)
            {
                trThai = 1;
                TrangThai();
                btn_capNhat.Enabled = true;
                loaiKH = (LoaiKhachHangDTO)dgv_LoaiKH.SelectedRows[0].DataBoundItem; // dgvSinhVien.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                loaiKH = null;
            }
            Bind();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            if (trThai != 2)
            {
                loaiKH = null;
                Bind();
            }
               
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            LoaiKhachHangBUS a = new LoaiKhachHangBUS();
            if (trThai == 2)
            {
                LoaiKhachHangDTO loai;
                try
                {
                    loai = new LoaiKhachHangDTO()
                    {
                        MALOAI = int.Parse(txt_MaLoai.Text),
                        TENLOAIKH = txt_TenLoai.Text,
                        TINHTRANG = ckb_TinhTrang.Checked ? true : false
                    };


                }
                catch
                {
                    MessageBox.Show("Thieu thong tin");
                    return;

                }
                bool kt = a.CapNhatLoaiKH(loai);
                if (!kt)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                    trThai = 1;
                    loaiKH = null;
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
            FrmQLKHACHHANG ql = new FrmQLKHACHHANG();
            ql.Show();
        }


    }
}
