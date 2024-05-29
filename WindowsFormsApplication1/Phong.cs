using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public class Phong
    {
        protected int giaPhong;
        protected string maPhong, tinhTrangPhong;

        public Phong()
        {

        }

        public Phong(string mp, int gp, string ttp)
        {
            this.maPhong = mp;
            this.giaPhong = gp;
            this.tinhTrangPhong = ttp;
        }

        public int GiaPhong
        {
            get { return this.giaPhong; }
            set
            {
                if (value >= 0)
                {
                    this.giaPhong = value;
                }
            }
        }

        public string MaPhong
        {
            get { return this.maPhong; }
            set 
            {
                if (value.Length == 5)
                {
                    this.maPhong = value;
                }
            }
        }

        public string TinhTrangPhong
        {
            get { return this.tinhTrangPhong; }
            set 
            {
                if (value == "Trống" || value == "Đã thuê" || value == "Đang sửa chữa")
                {
                    this.tinhTrangPhong = value;
                }
            }
        }

        public int TinhTienPhong(int soNgayThue)
        {
            return this.GiaPhong * soNgayThue;
        }

        public void DoiTinhTrangPhong()
        {
            if (this.TinhTrangPhong == "Trống")
            {
                this.TinhTrangPhong = "Đã thuê";
            }
            else if (this.TinhTrangPhong == "Đã thuê")
            {
                this.TinhTrangPhong = "Trống";
            }
        }
    }
}
