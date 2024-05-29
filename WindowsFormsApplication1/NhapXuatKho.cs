using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    class NhapXuatKho
    {
        protected VatTu vatTuVanChuyen;
        protected NhanVien nhanVienThucHien;
        protected DateTime thoiGianThucHien;
        protected int soLuong;

        public NhapXuatKho()
        {

        }

        public NhapXuatKho(VatTu vt, NhanVien nv, int sl=1)
        {
            this.VatTuVanChuyen = vt;
            this.NhanVienThucHien = nv;
            this.ThoiGianThucHien = DateTime.Today;
            this.soLuong = sl;
        }

        public VatTu VatTuVanChuyen
        {
            get { return this.vatTuVanChuyen; }
            set { this.vatTuVanChuyen = value; }
        }

        public NhanVien NhanVienThucHien
        {
            get { return this.nhanVienThucHien; }
            set { this.nhanVienThucHien = value; }
        }

        public DateTime ThoiGianThucHien
        {
            get { return this.thoiGianThucHien; }
            set { this.thoiGianThucHien = value; }
        }

        public int SoLuong
        {
            get { return this.soLuong; }
            set
            {
                if (value >= 0)
                {
                    this.soLuong = value;
                }
            }
        }
    }
}
