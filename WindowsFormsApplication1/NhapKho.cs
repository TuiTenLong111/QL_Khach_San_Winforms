using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    class NhapKho: NhapXuatKho
    {
        public NhapKho()
        {

        }

        public NhapKho(VatTu vt, NhanVien nv, int sl = 1)
            : base(vt, nv, sl)
        {
            this.VatTuVanChuyen.XuatNhap(this.SoLuong);
        }
    }
}
