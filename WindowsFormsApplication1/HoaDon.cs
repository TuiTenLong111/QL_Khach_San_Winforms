using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public class HoaDon
    {
        protected string maHoaDon;
        protected Khach khachThuePhong;
        protected Phong phongThue;
        protected DateTime ngayLap, ngayThanhToan;
        protected int tongChiPhi;

        public HoaDon()
        {

        }

        public HoaDon (string mhd, Khach ktp, Phong pt, DateTime nl, DateTime ntt, int tcp)
        {
            this.MaHoaDon = mhd;
            this.KhachThuePhong = ktp;
            this.PhongThue = pt;
            this.NgayLap = nl;
            this.NgayThanhToan = ntt;
            this.TongChiPhi = tcp;
        }

        public string MaHoaDon
        {
            get { return this.maHoaDon; }
            set
            {
                if (value.Length == 10)
                {
                    this.maHoaDon = value;
                }
            }
        }

        public Khach KhachThuePhong
        {
            get { return this.khachThuePhong; }
            set { this.khachThuePhong = value; }
        }

        public Phong PhongThue
        {
            get { return this.phongThue; }
            set { this.phongThue = value; }
        }

        public DateTime NgayLap
        {
            get { return this.ngayLap; }
            set { this.ngayLap = value; }
        }

        public DateTime NgayThanhToan
        {
            get { return this.ngayThanhToan; }
            set 
            {
                if (DateTime.Compare(this.NgayLap, value) < 0)
                {
                    this.ngayThanhToan = value;
                }
            }
        }

        public int TongChiPhi
        {
            get { return this.tongChiPhi; }
            set { this.tongChiPhi = value; }
        }

        public int TinhSoNgayThue()
        {
            return Convert.ToInt32(Math.Ceiling(this.NgayThanhToan.Subtract(this.NgayLap).TotalDays));
        }

        public int TinhTongChiPhi()
        {
            return this.TongChiPhi + this.PhongThue.TinhTienPhong(TinhSoNgayThue());
        }
    }
}
