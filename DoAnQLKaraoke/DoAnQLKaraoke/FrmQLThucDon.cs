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
    public partial class FrmQLThucDon : Form
    {
        public int trThai = 1;
        ThucDonDTO TDhienhanh;
        string maTDMoi = DoAnQLKaraokeBUS.ThucDonBUS.MaThucDonMoi();
        public FrmQLThucDon()
        {
            InitializeComponent();
           dgv_ThucDon.AutoGenerateColumns = true;
        }

        private void FrmQLThucDon_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_MaTD.Enabled = false;
            TrangThai();
            kiemtraquyen();

        }

        private void kiemtraquyen()
        {

            FrmChinh frmchinh = (FrmChinh)this.MdiParent;
            if (frmchinh.nvDangNhap.LOAIND != 1)
            {
                btn_them.Enabled = false;
                btn_capNhat.Enabled = false;
                btn_luu.Enabled = false;
                btn_qlLoai.Enabled = false;
                btn_lamMoi.Enabled = false;

            }
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
                        txt_MaTD.Enabled = false;
                        txt_TenTD.Enabled = false;
                        txt_Gia.Enabled = false;
                        cbo_Loai.Enabled = true;
                        cbo_TT.Enabled = true;
                        TDhienhanh = null;
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
                        txt_TenTD.Enabled = true;
                        txt_Gia.Enabled = true;
                        cbo_Loai.Enabled = true;
                        cbo_TT.Enabled = true;
                        TDhienhanh = null;
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
                        txt_TenTD.Enabled = true;
                        txt_Gia.Enabled = true;
                        cbo_Loai.Enabled = true;
                        cbo_TT.Enabled = true;

                    }
                    break;


            }
        }

        public void LoadData()
        {
            maTDMoi = DoAnQLKaraokeBUS.ThucDonBUS.MaThucDonMoi();
            //trThai = 1;
            //TrangThai();
            LoaiThucDonBUS lp = new LoaiThucDonBUS();
            cbo_Loai.DataSource = lp.DanhSachLoaiTD().FindAll(o =>o.TINHTRANG==true);
            cbo_Loai.ValueMember = "MALOAITD";
            cbo_Loai.DisplayMember = "TEN";

            TinhTrangTDBUS tt = new TinhTrangTDBUS();
            cbo_TT.DataSource = tt.DSTINHTRANGTD();
            cbo_TT.ValueMember = "MATTR";
            cbo_TT.DisplayMember = "TENTTR";

            //load datagridviewcomboboxcolum truoc khi load ds .
            DataGridViewComboBoxColumn dgv_LoaiTD = (DataGridViewComboBoxColumn)dgv_ThucDon.Columns["colLOAITD"];
            dgv_LoaiTD.DataSource = lp.DanhSachLoaiTD().FindAll(o => o.TINHTRANG == true);
            dgv_LoaiTD.ValueMember = "MALOAITD";
            dgv_LoaiTD.DisplayMember = "TEN";

            DataGridViewComboBoxColumn dgvcb_tinhtrang = (DataGridViewComboBoxColumn)dgv_ThucDon.Columns["colTINHTRANG"];
            dgvcb_tinhtrang.DataSource = tt.DSTINHTRANGTD();
            dgvcb_tinhtrang.ValueMember = "MATTR";
            dgvcb_tinhtrang.DisplayMember = "TENTTR";

            //DataGridViewCheckBoxColumn dgvckb = (DataGridViewCheckBoxColumn)dgv_sanpham.Columns["TinhTrang"];
            ThucDonBUS b = new ThucDonBUS();
            dgv_ThucDon.DataSource = b.DanhSachTD();


        }

        private void dgv_ThucDon_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_ThucDon.SelectedRows.Count > 0)
            {
                trThai = 1;
                TrangThai();
                btn_capNhat.Enabled = true;
                TDhienhanh = (ThucDonDTO)dgv_ThucDon.SelectedRows[0].DataBoundItem; // dgv_ThucDon.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                TDhienhanh = null;
            }
            Bind();
        }

        private void Bind()
        {


            if (TDhienhanh != null)
            {
                txt_MaTD.Text = TDhienhanh.MATD;
                txt_TenTD.Text = TDhienhanh.TENTHUCDON;
                txt_Gia.Text = TDhienhanh.GIA;
                cbo_Loai.SelectedValue = TDhienhanh.LOAITD;
                cbo_TT.SelectedValue = TDhienhanh.TINHTRANG;

            }
            else
            {
                if (dgv_ThucDon.SelectedRows.Count == 0 || trThai == 1)
                {
                    txt_MaTD.Text = maTDMoi; // truong hop dang cap nhat
                }


                txt_TenTD.Text = string.Empty;
                txt_Gia.Text = string.Empty;
                cbo_Loai.SelectedIndex = -1;
                cbo_TT.SelectedIndex = -1;
            }
        }

        private void XuLyTraCuu(int loaiTD, int tinhTrang)
        {
            ThucDonBUS b = new ThucDonBUS();
            List<ThucDonDTO> lst = b.DanhSachTD().FindAll(o => o.LOAITD == loaiTD && o.TINHTRANG == tinhTrang);
            dgv_ThucDon.DataSource = lst;
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            TDhienhanh = null;
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
            ThucDonDTO TD = new ThucDonDTO();
            try
            {

                TD.MATD = txt_MaTD.Text.Trim();
                TD.TENTHUCDON = txt_TenTD.Text.Trim();
                TD.GIA = int.Parse(txt_Gia.Text.Replace(".", "")).ToString().Trim();
                TD.LOAITD = int.Parse(cbo_Loai.SelectedValue.ToString());
                TD.TINHTRANG = int.Parse(cbo_TT.SelectedValue.ToString());

            }
            catch
            {
                MessageBox.Show("Thieu thong tin");
                return;

            }

            ThucDonBUS a = new ThucDonBUS();
            if (trThai == 2)
            {



                bool kq = a.Them(TD);
                if (kq)
                {
                    MessageBox.Show("Them thanh cong",maTDMoi);
                    trThai = 1;
                }
                else
                    MessageBox.Show("Them that bai !");


            }
            else
            {
                bool kt = a.CapNhat(TD);
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
            TDhienhanh = null;
            LoadData();
            TrangThai();
            Bind();



        }





        public ThucDonDTO thucdon { get; set; }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            try
            {
                XuLyTraCuu(int.Parse(cbo_Loai.SelectedValue.ToString()), int.Parse(cbo_TT.SelectedValue.ToString()));
            }
            catch
            {

            }
        }

        private void btn_qlLoai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLoaiThucDon qllp = new FrmLoaiThucDon();
            qllp.MdiParent = FrmChinh.ActiveForm;
            qllp.Dock = DockStyle.Fill;
            qllp.FormBorderStyle = FormBorderStyle.None;
            qllp.WindowState = FormWindowState.Maximized;
            qllp.StartPosition = FormStartPosition.CenterScreen;
            qllp.Show();
        }

        private void txt_Gia_TextChanged(object sender, EventArgs e)
        {
            try
            {

                double tien = double.Parse(txt_Gia.Text.Replace(",", ""));
                txt_Gia.Text = tien.ToString("0,00.##");
                txt_Gia.Select(txt_Gia.TextLength, 0);
            }
            catch 
            {

                if (txt_Gia.TextLength > 0)
                    txt_Gia.Text = txt_Gia.Text.Remove(txt_Gia.Text.Length - 1, 1);
                else
                    txt_Gia.Text = txt_Gia.Text.Remove(0, 0);
            }
        }

    }
}
