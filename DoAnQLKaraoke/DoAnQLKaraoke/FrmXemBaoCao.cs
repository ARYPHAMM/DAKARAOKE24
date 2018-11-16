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
        public FrmXemBaoCao()
        {
            InitializeComponent();
        }

        internal void XemThongKeTheoNgay(List<HoaDonDTO> ngay)
        {
            throw new NotImplementedException();
        }

        private void FrmXemBaoCao_Load(object sender, EventArgs e)
        {

            this.rpcBaoCao.RefreshReport();
        }

        internal void XemHoaDon(HoaDonDTO hdHienHanh)
        {
            HoaDonBUS hdBUS = new HoaDonBUS();
            ChiTietHoaDonBUS ctHDbus = new ChiTietHoaDonBUS();
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
