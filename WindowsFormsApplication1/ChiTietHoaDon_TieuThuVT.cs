using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public class ChiTietHoaDon_TieuThuVT: ChiTietHoaDon
    {
        protected VatTu vatTuTieuThu;
        protected DateTime thoiGianTieuThuVT;

        public ChiTietHoaDon_TieuThuVT()
        {

        }

        public ChiTietHoaDon_TieuThuVT(HoaDon hd, VatTu vt)
        {
            this.HD = hd;
            this.VatTuTieuThu = vt;
            this.ThoiGianTieuThuVT = DateTime.Today;
            this.ThemChiPhi();
        }

        public VatTu VatTuTieuThu
        {
            get { return this.vatTuTieuThu; }
            set { this.vatTuTieuThu = value; }
        }

        public DateTime ThoiGianTieuThuVT
        {
            get { return this.thoiGianTieuThuVT; }
            set { this.thoiGianTieuThuVT = value; }
        }

        public override void ThemChiPhi()
        {
            this.hd.TongChiPhi += this.VatTuTieuThu.GiaVatTu;
        }
    }
}
