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
    public partial class FrmLoaiThucDon : Form
    {
        public int trThai = 1;
        public LoaiThucDonDTO loaiTD = null;
        public FrmLoaiThucDon()
        {
            InitializeComponent();
            dgv_LoaiTD.AutoGenerateColumns = true;
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

            LoaiThucDonBUS b = new LoaiThucDonBUS();
            dgv_LoaiTD.DataSource = b.DanhSachLoaiTD();



        }

        private void FrmLoaiThucDon_Load(object sender, EventArgs e)
        {

            TrangThai();
            LoadData();
        }
        private void Bind()
        {


            if (loaiTD != null)
            {
                txt_MaLoai.Text = loaiTD.MALOAITD.ToString();
                txt_TenLoai.Text = loaiTD.TEN;
                ckb_TinhTrang.Checked = loaiTD.TINHTRANG;

            }
            else
            {
                if (dgv_LoaiTD.SelectedRows.Count == 0)
                {
                    txt_MaLoai.Text = string.Empty; // truong hop dang cap nhat
                }
                txt_TenLoai.Text = string.Empty;
                ckb_TinhTrang.Checked = false;
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            if (trThai != 2)
            {
                loaiTD = null;
                Bind();
            }
               
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
             LoaiThucDonBUS a = new LoaiThucDonBUS();
            if (trThai == 2)
            {
                LoaiThucDonDTO loai;
                try
                {
                    loai = new LoaiThucDonDTO()
                    {
                        MALOAITD = int.Parse(txt_MaLoai.Text),
                        TEN = txt_TenLoai.Text,
                        TINHTRANG = ckb_TinhTrang.Checked ? true : false
                    };


                }
                catch
                {
                    MessageBox.Show("Thieu thong tin");
                    return;

                }
                bool kt = a.CapNhatLoai(loai);
                if (!kt)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                    trThai = 1;
                    loaiTD = null;
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
            FrmQLThucDon ql = new FrmQLThucDon();
            ql.MdiParent = FrmChinh.ActiveForm;
            ql.Dock = DockStyle.Fill;
            ql.FormBorderStyle = FormBorderStyle.None;
            ql.StartPosition = FormStartPosition.CenterScreen;
            ql.Show();
        }

        private void dgv_LoaiTD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_LoaiTD.SelectedRows.Count > 0)
            {
                trThai = 1;
                TrangThai();
                btn_capNhat.Enabled = true;
                loaiTD = (LoaiThucDonDTO)dgv_LoaiTD.SelectedRows[0].DataBoundItem; // dgvSinhVien.CurrentRow
            }
            else
            {
                btn_capNhat.Enabled = false;
                loaiTD = null;
            }
            Bind();
        }
    }
}
