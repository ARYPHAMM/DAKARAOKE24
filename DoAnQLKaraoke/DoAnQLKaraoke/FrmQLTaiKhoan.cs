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
    public partial class FrmQLTaiKhoan : Form
    {
        TaiKhoanDTO tk;
        string manvmoi = DoAnQLKaraokeBUS.TaiKhoanBUS.MaNDTiepTheo();
        //string duongdanHA = "Dulieu/NhanVien/";
        public int trThai = 0;
        public FrmQLTaiKhoan()
        {
            InitializeComponent();
            TaiKhoanBUS a = new TaiKhoanBUS();
            dgv_TaiKhoan.AutoGenerateColumns = true;
        }

        private void LoadNguoiDung()
        {
            trThai = 1;
            trangthai();

            NhanVienBUS nv = new NhanVienBUS();
            cbo_manv.DataSource = nv.DanhSachNhanVien().FindAll(o => o.TINHTRANG == 1);
            cbo_manv.ValueMember = "MANV";
            cbo_manv.DisplayMember = "HOTENNV";

            LoaiTaiKhoanBUS lp = new LoaiTaiKhoanBUS();
            cbo_LoaiND.DataSource = lp.DanhSachLoaiTK().FindAll(o => o.TINHTRANG == true && o.MALOAIND != 1);
            cbo_LoaiND.ValueMember = "MALOAIND";
            cbo_LoaiND.DisplayMember = "TENLOAI";

            TinhTrangTKBUS tt = new TinhTrangTKBUS();
            cbo_TT.DataSource = tt.DSTINHTRANGND();
            cbo_TT.ValueMember = "MATTR";
            cbo_TT.DisplayMember = "TENTTR";

            //load datagridviewcomboboxcolum truoc khi load ds .
            DataGridViewComboBoxColumn dgvcb_loai = (DataGridViewComboBoxColumn)dgv_TaiKhoan.Columns["colLOAIND"];
            dgvcb_loai.DataSource = lp.DanhSachLoaiTK().FindAll(o => o.TINHTRANG == true);
            dgvcb_loai.ValueMember = "MALOAIND";
            dgvcb_loai.DisplayMember = "TENLOAI";

            DataGridViewComboBoxColumn dgvcb_tinhtrang = (DataGridViewComboBoxColumn)dgv_TaiKhoan.Columns["colTINHTRANG"];
            dgvcb_tinhtrang.DataSource = tt.DSTINHTRANGND();
            dgvcb_tinhtrang.ValueMember = "MATTR";
            dgvcb_tinhtrang.DisplayMember = "TENTTR";
            TaiKhoanBUS b = new TaiKhoanBUS();
            //dgv_nhanvien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_TaiKhoan.DataSource = b.DanhSachTaiKhoan().FindAll(o => o.LOAIND != 1);
        }
        private void grbdstknv_Enter(object sender, EventArgs e)
        {

        }

        private void trangthai()
        {

            switch (trThai)
            {
                case 1: // mac dinh
                    {
                        txt_MaND.Text = manvmoi;
                        //pic_hinh.BackgroundImage = Properties.Resources.s22;
                        btn_them.Enabled = true;
                        btn_them.Text = "Thêm";
                        btn_capNhat.Text = "Sửa";
                        btn_them.Image = Properties.Resources.add;
                        btn_capNhat.Image = Properties.Resources.edit;
                        btn_luu.Visible = false;
                        txt_MaND.Enabled = false;
                        txt_TK.Enabled = false;
                        txtMK.Enabled = false;
                        cbo_LoaiND.Enabled = true;
                        cbo_TT.Enabled = true;


                        Bind();
                    }
                    break;
                case 2: // them moi
                    {
                        btn_them.Enabled = true;
                        btn_them.Text = "Hủy";
                        btn_them.Image = Properties.Resources.cancel;
                        btn_capNhat.Enabled = false;
                        btn_luu.Visible = true;

                        txt_TK.Enabled = true;
                        txtMK.Enabled = true;
                        cbo_LoaiND.Enabled = true;
                        cbo_TT.Enabled = false;

                        tk = null;
                        //Bindnhanvien();

                    }
                    break;
                case 3: // chinh sua
                    {


                        btn_them.Enabled = false;
                        btn_capNhat.Enabled = true;
                        btn_capNhat.Text = "Hủy";
                        btn_capNhat.Image = Properties.Resources.cancel;
                        btn_luu.Visible = true;

                        txt_TK.Enabled = true;
                        txtMK.Enabled = true;
                        cbo_LoaiND.Enabled = true;
                        cbo_TT.Enabled = true;

                    }
                    break;


            }
        }

        private void dgv_TaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_TaiKhoan.SelectedRows.Count > 0)
            {
                trThai = 1;
                trangthai();
                btn_capNhat.Enabled = true;
                tk = (TaiKhoanDTO)dgv_TaiKhoan.SelectedRows[0].DataBoundItem; // dgvSinhVien.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                tk = null;
            }
            Bind();
        }
        private void Bind()
        {
            if (tk != null)
            {
                txt_MaND.Text = tk.MAND;
                txt_TK.Text = tk.TAIKHOAN;
                txtMK.Text = tk.MATKHAU;
                cbo_LoaiND.SelectedValue = int.Parse(tk.LOAIND.ToString());
                cbo_TT.SelectedValue = int.Parse(tk.TINHTRANG.ToString());

            }
            else
            {

                if (trThai == 2)
                {
                    txt_MaND.Text = manvmoi;
                }
                txt_TK.Text = string.Empty;
                txtMK.Text = string.Empty;
                cbo_LoaiND.SelectedIndex = -1;
                cbo_TT.SelectedIndex = -1;

            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            tk = null;
            Bind();
            LoadNguoiDung();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (trThai == 2) // lan kich thu 2
            {
                trThai = 1;
                trangthai();

            }
            else
            {
                trThai = 2; // lan kich thu 1
                trangthai();
                tk = null;
                Bind();
            }
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if (trThai == 3) // lan kich thu 2
            {
                trThai = 1;
                trangthai();

            }
            else
            {
                trThai = 3; // lan kich thu 1
                trangthai();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO taikhoan = new TaiKhoanDTO();
            try
            {

                taikhoan.MAND = txt_MaND.Text.Trim();
                taikhoan.MANV = cbo_manv.SelectedValue.ToString() ;
                taikhoan.TAIKHOAN = txt_TK.Text.Trim();
                taikhoan.MATKHAU = txtMK.Text.Trim();
                taikhoan.LOAIND = int.Parse(cbo_LoaiND.SelectedValue.ToString());
                taikhoan.TINHTRANG = 1;

            }
            catch
            {
                MessageBox.Show("Thieu thong tin");
                return;

            }

            TaiKhoanBUS a = new TaiKhoanBUS();
            if (trThai == 2)
            {



                bool kq = a.ThemTaiKhoan(taikhoan);
                if (kq)
                {
                    MessageBox.Show("Them thanh cong", manvmoi);
                    trThai = 1;
                }
                else
                    MessageBox.Show("Them that bai !");


            }
            else
            {
                taikhoan.TINHTRANG = int.Parse(cbo_TT.SelectedValue.ToString());
                bool kt = a.CapNhatTaiKhoan(taikhoan);
                if (!kt)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                }

                trThai = 1;
            }
            tk = null;
            trangthai();
            Bind();
            LoadNguoiDung();

        }

        private void FrmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadNguoiDung();
            txt_MaND.Enabled = false;
            trangthai();
        }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            try
            {
                XuLyTraCuu(int.Parse(cbo_LoaiND.SelectedValue.ToString()), int.Parse(cbo_TT.SelectedValue.ToString()));


            }
            catch
            {

            }
        }

        private void XuLyTraCuu(int loaind, int tinhtrang)
        {
            TaiKhoanBUS b = new TaiKhoanBUS();
            List<TaiKhoanDTO> lst = b.DanhSachTaiKhoan().FindAll(o => o.LOAIND == loaind && o.TINHTRANG == tinhtrang);
            dgv_TaiKhoan.DataSource = lst;
        }

        private void btn_qlLoaiTK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmQLLoaiTK qlltk = new FrmQLLoaiTK();
            qlltk.MdiParent = FrmChinh.ActiveForm;
            qlltk.Dock = DockStyle.Fill;
            qlltk.FormBorderStyle = FormBorderStyle.None;
            qlltk.WindowState = FormWindowState.Maximized;
            qlltk.StartPosition = FormStartPosition.CenterScreen;
            qlltk.Show();

        }
    }
}
