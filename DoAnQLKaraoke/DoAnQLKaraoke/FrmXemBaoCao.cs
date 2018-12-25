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
using Microsoft.Reporting.WinForms;

namespace DoAnQLKaraoke
{
    public partial class FrmXemBaoCao : Form
    {
        HoaDonBUS hdBUS;
        ChiTietHoaDonBUS ctHDbus;
        public FrmXemBaoCao()
        {
            InitializeComponent();
        }

        internal void XemThongKe(List<HoaDonDTO> ngay)
        {
            string thoigian = "";
            if (FrmThongKe.radio == 4)
            {
                int thang = int.Parse(ngay[0].THOIGIANBATDAU.ToString("MM"));
                switch (thang)
                {
                    case 1:
                    case 2:
                    case 3: thoigian = "Theo quý " + 1; break;
                    case 4:
                    case 5:
                    case 6: thoigian = "Theo quý " + 2; break;
                    case 7:
                    case 8:
                    case 9: thoigian = "Theo quý " + 3; break;
                    case 10:
                    case 11:
                    case 12: thoigian = "Theo quý " + 4; break;

                }
            }
            else
            {
                thoigian = FrmThongKe.radio == 1 ? "Theo ngày " + ngay[0].THOIGIANBATDAU.ToString("dd/MM/yyyy").ToString() : FrmThongKe.radio == 2 ? "theo tháng " + ngay[0].THOIGIANBATDAU.ToString("MM/yyyy") : "theo năm " + ngay[0].THOIGIANBATDAU.ToString("yyyy");
            }
       
         
                ctHDbus = new ChiTietHoaDonBUS();
                this.rpcBaoCao.LocalReport.ReportEmbeddedResource = "DoAnQLKaraoke.RptDoanhThu.rdlc";
                this.rpcBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubSDT);
                this.rpcBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsHoaDon", ngay));
                this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paNgay", thoigian));
                this.rpcBaoCao.RefreshReport();
        }



        private void SubSDT(object sender, SubreportProcessingEventArgs e)
        {  
            KhachHangBUS khBUS = new KhachHangBUS();
            string makh = e.Parameters["paSDT"].Values[0].ToString();
            List<KhachHangDTO> lsKH = khBUS.DanhSachKhachHang().FindAll(o => o.MAKH.Trim() == makh.Trim());
            e.DataSources.Add(new ReportDataSource("dsKH", lsKH));

        }

        private void FrmXemBaoCao_Load(object sender, EventArgs e)
        {

           
        }

        internal void XemHoaDon(HoaDonDTO hdHienHanh)
        {
            hdBUS = new HoaDonBUS();
            ctHDbus = new ChiTietHoaDonBUS();
            hdHienHanh.HOTENKH = new KhachHangBUS().DanhSachKhachHang().Find(o => o.MAKH.Trim() == hdHienHanh.MAKH.Trim()).TENKH;
            hdHienHanh.NGUOILAPHD = new NhanVienBUS().DanhSachNhanVien().Find(o => o.MANV.Trim() == hdHienHanh.MANV.Trim()).HOTENNV;
            HoaDonDTO hd = hdHienHanh;
            List<ChiTietHoaDonDTO> dsCTHD = ctHDbus.DanhSachChiTietHD(hd.MAHD);

            this.rpcBaoCao.LocalReport.ReportEmbeddedResource = "DoAnQLKaraoke.RptHoaDon.rdlc";
            this.rpcBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(subTenTD);
            this.rpcBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsCTHD", dsCTHD));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paMAHD", hd.MAHD));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paLOAIPHONG",hdHienHanh.MALOAIPHONG == 1?"vip":"thường"));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paGIAPHONG", hdHienHanh.GIAPHONG = hdHienHanh.GIAPHONG));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paKH", hd.HOTENKH));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paTGBATDAU", hd.THOIGIANBATDAU.ToString("dd/MM/yyyy HH:mm")));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paNGAYLAP",hd.TINHTRANG ? hd.THOIGIANKETTHUC.ToString("dd/MM/yyyy HH:mm"):"chưa thanh toán"));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paNGUOILAP", hd.NGUOILAPHD.ToString()));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paTONGTIEN", hd.TONGTHANHTOAN + " VNĐ"));
            this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paTINHTRANG", hd.TINHTRANG?"đã thanh toán" : "chưa thanh toán"));
            this.rpcBaoCao.RefreshReport();


        }

        private void subTenTD(object sender, SubreportProcessingEventArgs e)
        {
            ThucDonBUS tdBUS = new ThucDonBUS();
            string matd = e.Parameters["paMATD"].Values[0].ToString();
            List<ThucDonDTO> lsTD = tdBUS.DanhSachTD().FindAll(o => o.MATD.Trim() == matd.Trim());
            e.DataSources.Add(new ReportDataSource("ThucDon", lsTD));
        }
    }
}
