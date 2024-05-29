using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    class PhucVu
    {
        DichVu dichVuPhucVu;
        NhanVien nhanVienPhucVu;
        HoaDon hoaDonYeuCau;
        DateTime thoiGianPhucVu;

        public PhucVu(DichVu dv, NhanVien nv, HoaDon hd, DateTime tgpv)
        {
            this.DichVuPhucVu = dv;
            this.NhanVienPhucVu = nv;
            this.HoaDonYeuCau = hd;
            this.ThoiGianPhucVu = DateTime.Today;
        }

        public DichVu DichVuPhucVu
        {
            get { return this.dichVuPhucVu; }
            set { this.dichVuPhucVu = value; }
        }

        public NhanVien NhanVienPhucVu
        {
            get { return this.nhanVienPhucVu; }
            set { this.nhanVienPhucVu = value; }
        }

        public HoaDon HoaDonYeuCau
        {
            get { return this.hoaDonYeuCau; }
            set { this.hoaDonYeuCau = value; }
        }

        public DateTime ThoiGianPhucVu
        {
            get { return this.thoiGianPhucVu; }
            set { this.thoiGianPhucVu = value; }
        }

    }
}
