using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLKaraokeBUS;
using DoAnQLKaraokeDTO;

namespace DoAnQLKaraoke
{
    public partial class FrmQLNhanVien : Form
    {
        public int trThai = 1;
        NhanVienDTO NVhienhanh;
        string maNVMoi;
        public FrmQLNhanVien()
        {
            InitializeComponent();

            dgv_NhanVien.AutoGenerateColumns = false;
  
            //MessageBox.Show(maNVMoi);
        }



        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_MaNV.Enabled = false;
            TrangThai();
        }
        private void TrangThai()
        {
            switch (trThai)
            {
                case 1: // mac dinh
                    {
                        //pic_hinh.BackgroundImage = Properties.Resources.s22;
                        btn_luu.Text = "Lưu";
                        btn_luu.Image = Properties.Resources.save;
                        btn_them.Enabled = true;
                        btn_them.Text = "Thêm";
                        btn_capNhat.Text = "Cập nhật";
                        btn_them.Image = Properties.Resources.add;
                        btn_capNhat.Image = Properties.Resources.edit;
                        btn_luu.Visible = false;
                        txt_MaNV.Enabled = false;
                        txt_HoNV.Enabled = false;
                        txt_TenNV.Enabled = false;
                        dtp_NgaySinh.Enabled = false;
                        cbo_LoaiNV.Enabled = true;
                        txt_SDT.Enabled = false;
                        txt_DiaChi.Enabled = false;
                        txt_Email.Enabled = false;
                        cbo_TinhTrang.Enabled = true;
                        NVhienhanh = null;
                        //Bind();

                    }
                    break;
                case 2: // them moi
                    {
                        btn_them.Enabled = true;
                        btn_them.Text = "Hủy";
                        btn_them.Image = Properties.Resources.cancel;
                        btn_capNhat.Enabled = false;
                        btn_luu.Visible = true;
                        txt_TenNV.Enabled = true;
                        txt_HoNV.Enabled = true;
                        dtp_NgaySinh.Enabled = true;
                        cbo_LoaiNV.Enabled = true;
                        txt_SDT.Enabled = true;
                        txt_DiaChi.Enabled = true;
                        txt_Email.Enabled = true;
                        cbo_TinhTrang.Enabled = true;
                        NVhienhanh = null;
                        //Bind();
                    }
                    break;
                case 3: // chinh sua
                    {
                        btn_them.Enabled = false;
                        btn_luu.Visible = true;
                        btn_capNhat.Enabled = true;
                        btn_capNhat.Text = "Hủy";
                        btn_capNhat.Image = Properties.Resources.cancel;
                        btn_luu.Visible = true;
                        txt_HoNV.Enabled = true;
                        txt_TenNV.Enabled = true;
                        dtp_NgaySinh.Enabled = true;
                        txt_SDT.Enabled = true;
                        txt_DiaChi.Enabled = true;
                        txt_Email.Enabled = true;
                        cbo_LoaiNV.Enabled = true;
                        cbo_TinhTrang.Enabled = true;

                    }
                    break;


            }
        }

        public void LoadData()
        {
            NhanVienBUS a = new NhanVienBUS();
            maNVMoi = a.MaNVMoi();
            txt_MaNV.Text = maNVMoi;
            //trThai = 1;
            //TrangThai();
            LoaiNhanVienBUS lp = new LoaiNhanVienBUS();
            cbo_LoaiNV.DataSource = lp.DanhSachLoaiNhanVien().FindAll(o => o.TINHTRANG == true);
            cbo_LoaiNV.ValueMember = "MALOAI";
            cbo_LoaiNV.DisplayMember = "TENLOAI";

            TinhTrangNVBUS tt = new TinhTrangNVBUS();
            cbo_TinhTrang.DataSource = tt.DSTINHTRANGNV();
            cbo_TinhTrang.ValueMember = "MATTR";
            cbo_TinhTrang.DisplayMember = "TENTTR";

            //load datagridviewcomboboxcolum truoc khi load ds .
            DataGridViewComboBoxColumn dgvcb_loaiphong = (DataGridViewComboBoxColumn)dgv_NhanVien.Columns["colLOAINV"];
            dgvcb_loaiphong.DataSource = lp.DanhSachLoaiNhanVien().FindAll(o => o.TINHTRANG == true);
            dgvcb_loaiphong.ValueMember = "MALOAI";
            dgvcb_loaiphong.DisplayMember = "TENLOAI";

            DataGridViewComboBoxColumn dgvcb_tinhtrang = (DataGridViewComboBoxColumn)dgv_NhanVien.Columns["colTINHTRANG"];
            dgvcb_tinhtrang.DataSource = tt.DSTINHTRANGNV();
            dgvcb_tinhtrang.ValueMember = "MATTR";
            dgvcb_tinhtrang.DisplayMember = "TENTTR";

            //DataGridViewCheckBoxColumn dgvckb = (DataGridViewCheckBoxColumn)dgv_sanpham.Columns["TinhTrang"];
            NhanVienBUS b = new NhanVienBUS();
            dgv_NhanVien.DataSource = b.DanhSachNhanVien();


        }
        private void Bind()
        {


            if (NVhienhanh != null)
            {
                txt_MaNV.Text = NVhienhanh.MANV;
                txt_HoNV.Text = NVhienhanh.HONV;
                txt_TenNV.Text = NVhienhanh.TENV;
                dtp_NgaySinh.Text = NVhienhanh.NAMSINH.ToString();
                txt_SDT.Text = NVhienhanh.SDTNV;
                txt_Email.Text = NVhienhanh.EMAIL;
                txt_DiaChi.Text = NVhienhanh.DIACHI;
                cbo_LoaiNV.SelectedValue = NVhienhanh.LOAINV;
                cbo_TinhTrang.SelectedValue = NVhienhanh.TINHTRANG;

            }
            else
            {
                if (dgv_NhanVien.SelectedRows.Count == 0 || trThai == 1)
                {
                    txt_MaNV.Text = maNVMoi; // truong hop dang cap nhat
                }


                txt_HoNV.Text = string.Empty;
                txt_TenNV.Text = string.Empty;
                txt_SDT.Text = string.Empty;
                dtp_NgaySinh.Text = string.Empty;
                txt_DiaChi.Text = string.Empty;
                txt_Email.Text = string.Empty;
                cbo_LoaiNV.SelectedIndex = -1;
                cbo_TinhTrang.SelectedIndex = -1;
            }
        }

        private void dgv_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                //trThai = 3;
                //TrangThai();
                btn_capNhat.Enabled = true;
                NVhienhanh = (NhanVienDTO)dgv_NhanVien.SelectedRows[0].DataBoundItem; // dgvSinhVien.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                NVhienhanh = null;
            }
            Bind();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            NVhienhanh = null;
            Bind();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (trThai == 2) // lan kich thu 2
            {
                trThai = 1;
                TrangThai();

            }
            else
            {
                trThai = 2; // lan kich thu 1
                TrangThai();
            }
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if (trThai == 3) // lan kich thu 2
            {
                trThai = 1;
                TrangThai();

            }
            else
            {
                trThai = 3;
                TrangThai();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            NhanVienDTO nhanvien = new NhanVienDTO();
            try
            {

                nhanvien.MANV = txt_MaNV.Text.Trim();
                nhanvien.HONV = txt_HoNV.Text.Trim();
                nhanvien.TENV = txt_TenNV.Text.Trim();
                nhanvien.SDTNV = txt_SDT.Text.Trim();
                nhanvien.NAMSINH = dtp_NgaySinh.Value;
                nhanvien.DIACHI = txt_DiaChi.Text.Trim();
                nhanvien.EMAIL = txt_Email.Text.Trim();
                nhanvien.LOAINV = int.Parse(cbo_LoaiNV.SelectedValue.ToString());
                nhanvien.TINHTRANG = int.Parse(cbo_TinhTrang.SelectedValue.ToString());

            }
            catch
            {
                MessageBox.Show("Thieu thong tin");
                return;

            }

            NhanVienBUS a = new NhanVienBUS();
            if (trThai == 2)
            {



                bool kq = a.ThemNV(nhanvien);
                if (kq)
                {
                    MessageBox.Show("Them thanh cong", maNVMoi);
                    trThai = 1;
                }
                else
                    MessageBox.Show("Them that bai !");


            }
            else
            {
                bool kt = a.CapNhatNV(nhanvien);
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
            NVhienhanh = null;
            TrangThai();
            Bind();
            LoadData();


        }
        private void XuLyTraCuu(int loai, int tinhTrang)
        {
            NhanVienBUS b = new NhanVienBUS();
            List<NhanVienDTO> lst = b.DanhSachNhanVien().FindAll(o => o.LOAINV == loai && o.TINHTRANG == tinhTrang);
            dgv_NhanVien.DataSource = lst;
        }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            try
            {
                XuLyTraCuu(int.Parse(cbo_LoaiNV.SelectedValue.ToString()), int.Parse(cbo_TinhTrang.SelectedValue.ToString()));
            }
            catch
            {

            }
        }

        private void btn_qlLoaiKH_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_qlLoaiKH_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmQLLoaiNhanVien ql = new FrmQLLoaiNhanVien();
            ql.MdiParent = FrmChinh.ActiveForm;
            ql.Dock = DockStyle.Fill;
            ql.FormBorderStyle = FormBorderStyle.None;
            ql.WindowState = FormWindowState.Maximized;
            ql.StartPosition = FormStartPosition.CenterScreen;
            ql.Show();
        }
    }
}
