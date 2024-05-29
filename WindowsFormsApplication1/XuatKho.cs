using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    class XuatKho: NhapXuatKho
    {
        public XuatKho()
        {

        }

        public XuatKho(VatTu vt, NhanVien nv, int sl = 1)
            : base(vt, nv, sl)
        {
            this.SoLuong = -sl;
            this.VatTuVanChuyen.XuatNhap(this.SoLuong);
        }
    }
}
