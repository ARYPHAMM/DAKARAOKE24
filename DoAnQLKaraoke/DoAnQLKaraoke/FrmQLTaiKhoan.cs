﻿using System;
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
            cbo_manv.DataSource = nv.DanhSachNhanVien().FindAll(o => o.LOAINV == 1 ||o.LOAINV == 2);
            cbo_manv.ValueMember = "MANV";
            cbo_manv.DisplayMember = "MANV";

            LoaiTaiKhoanBUS lp = new LoaiTaiKhoanBUS();
            cbo_LoaiND.DataSource = lp.DanhSachLoaiTK().FindAll(o => o.TINHTRANG == true );
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
            dgv_TaiKhoan.DataSource = b.DanhSachTaiKhoan().FindAll(o => o.TINHTRANG == 1);
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
                        ckh_doimk.Enabled = false;

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
                        txtMK.Enabled = true;
                        tk = null;
                        ckh_doimk.Enabled = false;
                        //Bindnhanvien();

                    }
                    break;
                case 3: // chinh sua
                    {

                        cbo_TT.Enabled = true;
                        btn_them.Enabled = false;
                        btn_capNhat.Enabled = true;
                        btn_capNhat.Text = "Hủy";
                        btn_capNhat.Image = Properties.Resources.cancel;
                        btn_luu.Visible = true;
                        txt_TK.Enabled = true;
                        txtMK.Enabled = false;
                        cbo_LoaiND.Enabled = true;
                        cbo_TT.Enabled = true;
                        ckh_doimk.Enabled = true;
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
                cbo_manv.SelectedValue = tk.MANV.Trim();
             
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
                cbo_manv.SelectedIndex = -1;
                txt_TK.Text = string.Empty;
                txtMK.Text = string.Empty;
                cbo_LoaiND.SelectedIndex = -1;
                cbo_TT.SelectedIndex = -1;

            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            tk = null;
            trThai = 1;
            trangthai();
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
                txtMK.Enabled = false;
                trangthai();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO taikhoan = new TaiKhoanDTO();
            try
            {

                taikhoan.MAND = txt_MaND.Text.Trim();
                taikhoan.MANV = cbo_manv.SelectedValue.ToString();
                taikhoan.TAIKHOAN = txt_TK.Text.Trim();
                taikhoan.MATKHAU = txtMK.Text.Trim();
                taikhoan.MANV = cbo_manv.SelectedValue.ToString();
                taikhoan.LOAIND = int.Parse(cbo_LoaiND.SelectedValue.ToString());
                taikhoan.TINHTRANG = 1;

            }
            catch
            {
                MessageBox.Show("Thieu thong tin");
                return;

            }



            if (txt_TK.Text == string.Empty)
            {
                MessageBox.Show("Thông tin về nhân viên không hợp lệ !");
            }
            else
            {

                TaiKhoanBUS a = new TaiKhoanBUS();
                if (trThai == 2)
                {
                    if (txtMK.Text == string.Empty || txtMK.Text.Length < 6 || txtMK.TextLength < 4)
                    {
                        MessageBox.Show("Thông tin về nhân viên không hợp lệ !" + Environment.NewLine + "Mật khẩu phải lớn hơn 6 ký tự!" + Environment.NewLine + "Tài Khoản phải lớn hơn 4 ký tự!");
                        return;
                    }

                    try
                    {

                        bool kq = a.ThemTaiKhoan(taikhoan);
                        if (kq)
                        {
                            MessageBox.Show("Them thanh cong", manvmoi);
                            FrmChinh frmmain = (FrmChinh)this.MdiParent;
                            frmmain.lsNDDTO = new LichSuNguoiDungDTO()
                            {
                                MAND = frmmain.nvDangNhap.MAND,
                                MANV = frmmain.nvDangNhap.MANV,
                                THOIGIAN = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyy HH:mm")),
                                SUKIEN = "Tài khoản " + txt_TK.Text + " được thêm vào hệ thống "

                            };
                            bool ktls = frmmain.lsNDBUS.ThemLichSuNguoiDung(frmmain.lsNDDTO);
                            trThai = 1;
                            tk = null;
                            Bind();
                            LoadNguoiDung();
                            trangthai();
                        }
                        else
                            MessageBox.Show("Them that bai !");
                    }
                    catch (Exception ex)
                    {
                        // trigger csdl kiem tra
                        MessageBox.Show(ex.Message);
                        return;
                    }


                }
                else
                {
                    try
                    {

                        if (txtMK.Text == string.Empty && trThai == 3 && ckh_doimk.Checked)
                        {
                            MessageBox.Show("Vui lòng nhập mk mới");
                            return;
                        }
                        else if (txtMK.Text != string.Empty && trThai == 3 && ckh_doimk.Checked)
                        {
                            taikhoan.MATKHAU = txtMK.Text;
                        }
                        else if(ckh_doimk.Checked == false && taikhoan.MATKHAU != string.Empty)
                        {
                            taikhoan.MATKHAU = string.Empty;
                        }

                        taikhoan.TINHTRANG = int.Parse(cbo_TT.SelectedValue.ToString());
                        if (taikhoan.LOAIND == 1 && taikhoan.TINHTRANG == 2 )
                        {
                            MessageBox.Show("Tài khoản quản lý phải luôn hoạt động");
                            trThai = 1;
                            trangthai();
                            return;
                        }
                   
                        bool kt = a.CapNhatTaiKhoan(taikhoan);
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
                                SUKIEN = "Tài khoản " + txt_TK.Text + " được chỉnh sửa"

                            };
                            bool ktls = frmmain.lsNDBUS.ThemLichSuNguoiDung(frmmain.lsNDDTO);
                            trThai = 1;
                            tk = null;
                            Bind();
                            LoadNguoiDung();
                            trangthai();
                        }
                    }
                    catch (Exception ex)
                    {
                        // trigger csdl kiem tra
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
         
            }
    

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
                if (cbo_manv.SelectedIndex > 0)
                {
                    XuLyTraCuu(cbo_manv.SelectedValue.ToString());
                    return;
                }
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
        private void XuLyTraCuu(string maNV)
        {
            TaiKhoanBUS b = new TaiKhoanBUS();
            List<TaiKhoanDTO> lst = b.DanhSachTaiKhoan().FindAll(o => o.MANV.Trim() == maNV.Trim());
            dgv_TaiKhoan.DataSource = lst;
        }

        private void btn_qlLoaiTK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmQLLoaiTK qlltk = new FrmQLLoaiTK();
            qlltk.MdiParent = FrmChinh.ActiveForm;
            qlltk.Dock = DockStyle.Fill;
            qlltk.FormBorderStyle = FormBorderStyle.None;
            qlltk.StartPosition = FormStartPosition.CenterScreen;
            qlltk.Show();

        }

        private void ckh_doimk_CheckedChanged(object sender, EventArgs e)
        {
            if(ckh_doimk.Checked)
            {
                txtMK.Enabled = true;
                txtMK.Text = "";
            }
            else
            {
                txtMK.Enabled = false;
            }
        }
    }
}
