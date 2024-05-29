using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public class DanhSach_HoaDon
    {
        public List<HoaDon> ds_hd;

        public DanhSach_HoaDon()
        {
            ds_hd = new List<HoaDon>();
        }

        public HoaDon TimHoaDonHienTai(Khach k)
        {
            HoaDon hd = new HoaDon();
            foreach (HoaDon i in ds_hd)
            {
                if (i.KhachThuePhong == k && DateTime.Compare(DateTime.Today, i.NgayThanhToan) < 0)
                {
                    hd = i;
                }
            }
            return hd;
        }
        public HoaDon TimHoaDonHienTai(Phong p)
        {
            HoaDon hd = new HoaDon();
            foreach (HoaDon i in ds_hd)
            {
                if (i.PhongThue == p && DateTime.Compare(DateTime.Today, i.NgayThanhToan) < 0)
                {
                    hd = i;
                }
            }
            return hd;
        }
    }
}
