using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    class Test
    {
        static void Main(string[] args)
        {
            Phong p = new Phong("00001", 100000, "Trống");
            Khach k = new Khach("Nam", "2001206925", "Nam", "TPHCM", "0366764749");
            HoaDon hd = new HoaDon("00001", k, p, new DateTime(2022, 10, 20, 12, 20, 24), new DateTime(2022, 11, 20, 12, 20, 24), 0);
            DanhSach_HoaDon danhSachHoaDon = new DanhSach_HoaDon();
            DichVu dv = new DichVu("Dọn dẹp", "Dọn dẹp toàn bộ phòng trong tối đá 1h", 50000);
            danhSachHoaDon.ds_hd.Add(hd);
            HoaDon hd_k = danhSachHoaDon.TimHoaDonHienTai(k);
            ChiTietHoaDon_SuDungDV cthd_dv = new ChiTietHoaDon_SuDungDV(hd_k, dv);
            Console.WriteLine("Tổng chi phí = {0} cho {1} ngày thuê", hd.TinhTongChiPhi() , hd.TinhSoNgayThue());
            Console.ReadKey();
        }
    }
}
