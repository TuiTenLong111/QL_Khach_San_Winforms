using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public class ChiTietHoaDon_SuDungDV : ChiTietHoaDon
    {
        protected DichVu dichVuYeuCau;
        protected DateTime thoiGianYeuCauDV;

        public ChiTietHoaDon_SuDungDV()
        {

        }

        public ChiTietHoaDon_SuDungDV(HoaDon hd, DichVu dv)
        {
            this.HD = hd;
            this.DichVuYeuCau = dv;
            this.ThoiGianYeuCauDV = DateTime.Today;
            this.ThemChiPhi();
        }

        public DichVu DichVuYeuCau
        {
            get { return this.dichVuYeuCau; }
            set { this.dichVuYeuCau = value; }
        }

        public DateTime ThoiGianYeuCauDV
        {
            get { return this.thoiGianYeuCauDV; }
            set { this.thoiGianYeuCauDV = value; }
        }

        public override void ThemChiPhi()
        {
            this.hd.TongChiPhi += this.DichVuYeuCau.GiaDichVu;
        }
    }
}
