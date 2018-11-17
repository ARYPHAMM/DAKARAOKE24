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
            string thoigian = FrmThongKe.radio == 1 ? "Theo ngày " + ngay[0].THOIGIANBATDAU.ToString("dd/MM/yyyy").ToString() : FrmThongKe.radio == 2 ? "theo tháng " + ngay[0].THOIGIANBATDAU.ToString("MM/yyyy") : FrmThongKe.radio == 3 ? "theo năm "+ngay[0].THOIGIANBATDAU.ToString("yyyy") : "theo quý " + ngay[0].THOIGIANBATDAU.ToString("MM/yyyy");
         
                ctHDbus = new ChiTietHoaDonBUS();
                this.rpcBaoCao.LocalReport.ReportEmbeddedResource = "DoAnQLKaraoke.RptDoanhThu.rdlc";
                this.rpcBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubSDT);
            this.rpcBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsHoaDon", ngay));
                this.rpcBaoCao.LocalReport.SetParameters(new ReportParameter("paNgay", thoigian));

            this.rpcBaoCao.RefreshReport();
        }



        private void SubSDT(object sender, SubreportProcessingEventArgs e)
        {
            //PhongBUS Phong = new PhongBUS();
            //string ma = e.Parameters["paMaPhong"].Values[0].ToString();
            //// tim danh sach truyen theo nxb
            ////MessageBox.Show(ma.ToString());
            //List<PhongDTO> lsPhong = Phong.DanhSachPhong().FindAll(o => o.MAPHONG.Trim() == ma.Trim());
            //// do vao subreport
            //e.DataSources.Add(new ReportDataSource("dsPhong", lsPhong));
   
            KhachHangBUS khBUS = new KhachHangBUS();
            string makh = e.Parameters["paSDT"].Values[0].ToString();
            // tim danh sach truyen theo nxb
            //MessageBox.Show(ma.ToString());
            List<KhachHangDTO> lsKH = khBUS.DanhSachKhachHang().FindAll(o => o.MAKH.Trim() == makh.Trim());
            // do vao subreport
            e.DataSources.Add(new ReportDataSource("dsKH", lsKH));

        }

        private void FrmXemBaoCao_Load(object sender, EventArgs e)
        {

           
        }

        internal void XemHoaDon(HoaDonDTO hdHienHanh)
        {
            hdBUS = new HoaDonBUS();
            ctHDbus = new ChiTietHoaDonBUS();
            HoaDonDTO hd = hdBUS.DanhSachHoaDon().Find(o => o.MAHD == hdHienHanh.MAHD);
            List<ChiTietHoaDonDTO> dsCTHD = ctHDbus.DanhSachChiTietHD(hd.MAHD);

            this.rpcBaoCao.LocalReport.ReportEmbeddedResource = "DoAnQLKaraoke.RptHoaDon.rdlc";
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
    }
}
