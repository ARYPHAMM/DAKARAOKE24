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
    public partial class FrmQLLoaiNhanVien : Form
    {
        public int trThai = 1;
        public LoaiNhanVienDTO loaiNV = null;
        public FrmQLLoaiNhanVien()
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
                        txt_Ma.Enabled = false;
                        txt_Ten.Enabled = false;
                        ckb_TinhTrang.Enabled = false;
                    }
                    break;
                case 2: // chinh sua
                    {
                        btn_luu.Visible = true;
                        btn_capNhat.Text = "Hủy";
                        btn_capNhat.Image = Properties.Resources.cancel;
                        txt_Ma.Enabled = false;
                        txt_Ten.Enabled = true;
                        ckb_TinhTrang.Enabled = true;
                    }
                    break;
            }
        }
        private void LoadData()
        {

            LoaiNhanVienBUS b = new LoaiNhanVienBUS();
            dgv_LoaiNV.DataSource = b.DanhSachLoaiNhanVien();


        }

        private void FrmQLLoaiNhanVien_Load(object sender, EventArgs e)
        {
            TrangThai();
            LoadData();
        }

        private void Bind()
        {


            if (loaiNV != null)
            {
                txt_Ma.Text = loaiNV.MALOAI.ToString();
                txt_Ten.Text = loaiNV.TENLOAI;
                ckb_TinhTrang.Checked = loaiNV.TINHTRANG;

            }
            else
            {

                    txt_Ma.Text = string.Empty; // truong hop dang cap nhat
                txt_Ten.Text = string.Empty;
                ckb_TinhTrang.Checked = false;
            }
        }

        private void dgv_LoaiNV_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_LoaiNV.SelectedRows.Count > 0)
            {
                trThai = 1;
                TrangThai();
                btn_capNhat.Enabled = true;
                loaiNV = (LoaiNhanVienDTO)dgv_LoaiNV.SelectedRows[0].DataBoundItem; // dgvSinhVien.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                loaiNV = null;
            }
            Bind();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            if (trThai != 2)
            {
                loaiNV = null;
                Bind();
            }
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
            FrmQLNhanVien ql = new FrmQLNhanVien();
            ql.MdiParent = FrmChinh.ActiveForm;
            ql.Dock = DockStyle.Fill;
            ql.FormBorderStyle = FormBorderStyle.None;
            ql.StartPosition = FormStartPosition.CenterScreen;
            ql.Show();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            LoaiNhanVienBUS a = new LoaiNhanVienBUS();
            if (trThai == 2)
            {
                LoaiNhanVienDTO loai;
                try
                {
                    loai = new LoaiNhanVienDTO()
                    {
                        MALOAI = int.Parse(txt_Ma.Text),
                        TENLOAI = txt_Ten.Text,
                        TINHTRANG = ckb_TinhTrang.Checked ? true : false
                    };


                }
                catch
                {
                    MessageBox.Show("Thieu thong tin");
                    return;

                }
                bool kt = a.CapNhatLoaiNV(loai);
                if (!kt)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                    FrmChinh frmmain = (FrmChinh)this.MdiParent;
                    frmmain.lsNDDTO = new LichSuNguoiDungDTO()
                    {
                        MAND = frmmain.nvDangNhap.MAND,
                        MANV = frmmain.nvDangNhap.MANV,
                        THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                        SUKIEN = "Loại khách hàng cập nhật" + loaiNV.TENLOAI + " => :" + loai.TENLOAI

                    };
                    bool ktls = frmmain.lsNDBUS.ThemLichSuNguoiDung(frmmain.lsNDDTO);
                    trThai = 1;
                    loaiNV = null;
                }

            }
            TrangThai();
            Bind();
            LoadData();
        }

    }

}
