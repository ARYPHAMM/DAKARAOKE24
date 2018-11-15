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
    public partial class FrmQLPhong : Form
    {

        public int trThai = 3;
        PhongDTO phongHienHanh;
        string maPhongMoi = DoAnQLKaraokeBUS.PhongBUS.MaPhongMoi();
        public FrmQLPhong()
        {
            InitializeComponent();
            dgv_phong.AutoGenerateColumns = true;
        }

        private void lbldanhsachnv_Click(object sender, EventArgs e)
        {

        }

        private void FrmQLPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_maPhong.Enabled = false;
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
                        txt_maPhong.Enabled = false;
                        txt_tenPhONG.Enabled = false;
                        txt_gia.Enabled = false;
                        cbo_loaiPhong.Enabled = true;
                        cbo_tinhtrang.Enabled = true;
                        phongHienHanh = null;
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
                        txt_tenPhONG.Enabled = true;
                        txt_gia.Enabled = true;
                        cbo_loaiPhong.Enabled = true;
                        cbo_tinhtrang.Enabled = true;
                        phongHienHanh = null;
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
                        txt_tenPhONG.Enabled = true;
                        txt_gia.Enabled = true;
                        cbo_loaiPhong.Enabled = true;
                        cbo_tinhtrang.Enabled = true;

                    }
                    break;


            }
        }

        public void LoadData()
        {
            //trThai = 1;
            //TrangThai();
            LoaiPhongBUS lp = new LoaiPhongBUS();
            cbo_loaiPhong.DataSource = lp.DanhSachLoaiPhong().FindAll(o => o.TINHTRANG == true);
            cbo_loaiPhong.ValueMember = "MALOAIPHONG";
            cbo_loaiPhong.DisplayMember = "TENLOAIPHONG";

            TinhTrangPhongBUS tt = new TinhTrangPhongBUS();
            cbo_tinhtrang.DataSource = tt.DSTINHTRANGPHONG();
            cbo_tinhtrang.ValueMember = "MATTR";
            cbo_tinhtrang.DisplayMember = "TENTTR";

            //load datagridviewcomboboxcolum truoc khi load ds .
            DataGridViewComboBoxColumn dgvcb_loaiphong = (DataGridViewComboBoxColumn)dgv_phong.Columns["colLOAIPHONG"];
            dgvcb_loaiphong.DataSource = lp.DanhSachLoaiPhong().FindAll(o => o.TINHTRANG == true);
            dgvcb_loaiphong.ValueMember = "MALOAIPHONG";
            dgvcb_loaiphong.DisplayMember = "TENLOAIPHONG";

            DataGridViewComboBoxColumn dgvcb_tinhtrang = (DataGridViewComboBoxColumn)dgv_phong.Columns["colTINHTRANG"];
            dgvcb_tinhtrang.DataSource = tt.DSTINHTRANGPHONG();
            dgvcb_tinhtrang.ValueMember = "MATTR";
            dgvcb_tinhtrang.DisplayMember = "TENTTR";

            //DataGridViewCheckBoxColumn dgvckb = (DataGridViewCheckBoxColumn)dgv_sanpham.Columns["TinhTrang"];
            PhongBUS b = new PhongBUS();
            dgv_phong.DataSource = b.DanhSachPhong();


        }

        private void dgv_phong_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_phong.SelectedRows.Count > 0)
            {
                trThai = 1;
                TrangThai();
                btn_capNhat.Enabled = true;
                phongHienHanh = (PhongDTO)dgv_phong.SelectedRows[0].DataBoundItem; // dgvSinhVien.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                phongHienHanh = null;
            }
            Bind();
        }
        private void Bind()
        {
  

            if (phongHienHanh != null)
            {
                txt_maPhong.Text = phongHienHanh.MAPHONG;
                txt_tenPhONG.Text = phongHienHanh.TENPHONG;
                txt_gia.Text = phongHienHanh.GIAPHONG;
                cbo_loaiPhong.SelectedValue = phongHienHanh.LOAIPHONG;
                cbo_tinhtrang.SelectedValue = phongHienHanh.TINHTRANG;

            }
            else
            {
                if (dgv_phong.SelectedRows.Count == 0)
                {
                    txt_maPhong.Text = maPhongMoi; // truong hop dang cap nhat
                }
                    

                txt_tenPhONG.Text = string.Empty;
                txt_gia.Text = string.Empty;
                cbo_loaiPhong.SelectedIndex = -1;
                cbo_tinhtrang.SelectedIndex = -1;
            }
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            phongHienHanh = null;
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

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {
            try
            {

                double tien = double.Parse(txt_gia.Text.Replace(",", ""));
                txt_gia.Text = tien.ToString("0,00.##");
                txt_gia.Select(txt_gia.TextLength, 0);
            }
            catch 
            {

                if (txt_gia.TextLength > 0)
                    txt_gia.Text = txt_gia.Text.Remove(txt_gia.Text.Length - 1, 1);
                else
                    txt_gia.Text = txt_gia.Text.Remove(0, 0);
            }
        }


        private void btn_luu_Click(object sender, EventArgs e)
        {
            PhongDTO phong = new PhongDTO();
            try
            {

                phong.MAPHONG = txt_maPhong.Text.Trim();
                phong.TENPHONG = txt_tenPhONG.Text.Trim();
                phong.GIAPHONG = int.Parse(txt_gia.Text.Replace(".", "")).ToString().Trim();
                phong.LOAIPHONG = int.Parse(cbo_loaiPhong.SelectedValue.ToString());
                phong.TINHTRANG = int.Parse(cbo_tinhtrang.SelectedValue.ToString());

            }
            catch
            {
                MessageBox.Show("Thieu thong tin");
                return;
                     
            }

            PhongBUS a = new PhongBUS();
            if (trThai == 2)
            {



                bool kq = a.ThemPhong(phong);
                if (kq)
                {
                    MessageBox.Show("Them thanh cong", maPhongMoi);
                    trThai = 1;
                }
                else
                    MessageBox.Show("Them that bai !");


            }
            else
            {
                bool kt = a.CapNhatPhong(phong);
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
            phongHienHanh = null;
            TrangThai();
            Bind();
            LoadData();



        }

        private void XuLyTraCuu(int loaiPhong,int tinhTrang)
        {
            PhongBUS b = new PhongBUS();
            List<PhongDTO> lst = b.DanhSachPhong().FindAll(o => o.LOAIPHONG == loaiPhong && o.TINHTRANG==tinhTrang);
            dgv_phong.DataSource = lst;
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

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            try
            {
                XuLyTraCuu(int.Parse(cbo_loaiPhong.SelectedValue.ToString()), int.Parse(cbo_tinhtrang.SelectedValue.ToString()));
            }
            catch
            {

            }
        }

        private void btn_qlLoaiPhong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmQLLoaiPhong qllp = new FrmQLLoaiPhong();
            qllp.Show();
           
        }
    }
}
