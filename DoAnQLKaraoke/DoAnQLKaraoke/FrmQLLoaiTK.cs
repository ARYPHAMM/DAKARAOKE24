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
    public partial class FrmQLLoaiTK : Form
    {
        public int trThai = 1;
        public LoaiTaiKhoanDTO loaiTK = null;
        public FrmQLLoaiTK()
        {
            InitializeComponent();
        }
        private void FrmQLLoaiTK_Load(object sender, EventArgs e)
        {
            LoadData();
            TrangThai();
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
            LoaiTaiKhoanBUS b = new LoaiTaiKhoanBUS();
            dgv_dsloaiTK.DataSource = b.DanhSachLoaiTK();
        }

        private void dgv_dsloaiTK_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_dsloaiTK.SelectedRows.Count > 0)
            {
                trThai = 1;
                TrangThai();
                btn_capNhat.Enabled = true;
                loaiTK = (LoaiTaiKhoanDTO)dgv_dsloaiTK.SelectedRows[0].DataBoundItem; // dgvSinhVien.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                loaiTK = null;
            }
            Bind();
        }

        private void Bind()
        {
            if (loaiTK != null)
            {
                txt_maLoai.Text = loaiTK.MALOAIND.ToString();
                txt_tenLoai.Text = loaiTK.TENLOAI;
                ckb_tinhtrang.Checked = loaiTK.TINHTRANG;

            }
            else
            {
                if (dgv_dsloaiTK.SelectedRows.Count == 0)
                {
                    txt_maLoai.Text = string.Empty; // truong hop dang cap nhat
                }
                txt_tenLoai.Text = string.Empty;
                ckb_tinhtrang.Checked = false;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            LoaiTaiKhoanBUS a = new LoaiTaiKhoanBUS();
            if (trThai == 2)
            {
                LoaiTaiKhoanDTO loai;
                try
                {
                    loai = new LoaiTaiKhoanDTO()
                    {
                        MALOAIND = int.Parse(txt_maLoai.Text),
                        TENLOAI = txt_tenLoai.Text,
                        TINHTRANG = ckb_tinhtrang.Checked ? true : false
                    };


                }
                catch
                {
                    MessageBox.Show("Thieu thong tin");
                    return;

                }
                bool kt = a.CapNhatDSLoaiTK(loai);
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
                        SUKIEN = "Loại khách hàng cập nhật" + loaiTK.TENLOAI + " => :" + loai.TENLOAI

                    };
                    bool ktls = frmmain.lsNDBUS.ThemLichSuNguoiDung(frmmain.lsNDDTO);
                    trThai = 1;
                    loaiTK = null;
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

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            if (trThai != 2)
            {
                loaiTK = null;
                Bind();
            }
            LoadData();
        }

        private void btn_quayve_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmQLTaiKhoan qltk = new FrmQLTaiKhoan();
            qltk.MdiParent = FrmChinh.ActiveForm;
            qltk.Dock = DockStyle.Fill;
            qltk.FormBorderStyle = FormBorderStyle.None;
            qltk.StartPosition = FormStartPosition.CenterScreen;
            qltk.Show();
        }
    }
}
