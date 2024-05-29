using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    class NhanVien
    {
        string maNV, ten, cmnd_cccd, diaChi, sdt, chucVu, noiSinh;
        DateTime ngaySinh, thoiGianNhanViec, thoiGianThoiViec;
        bool gioiTinhNam;

        public NhanVien()
        {

        }

        public NhanVien(string mnv, string t, string c, string gt, string dc, string sdt, string cv, string ns, DateTime ngs)
        {
            this.MaNV = mnv;
            this.Ten = t;
            this.CMND_CCCD = c;
            this.GioiTinh = gt;
            this.DiaChi = dc;
            this.SDT = sdt;
            this.ChucVu = cv;
            this.NoiSinh = ns;
            this.NgaySinh = ngs;
            this.ThoiGianNhanViec = DateTime.Today;
        }

        public string MaNV
        {
            get { return this.maNV; }
            set
            {
                if (value.Length == 5)
                {
                    this.maNV = value;
                }
            }
        }

        public string Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }

        public string CMND_CCCD
        {
            get { return this.cmnd_cccd; }
            set
            {
                if (value.Length == 11 || value.Length == 9)
                {
                    this.cmnd_cccd = value;
                }
            }
        }

        public string GioiTinh
        {
            get
            {
                if (this.gioiTinhNam)
                {
                    return "Nam";
                }
                else
                {
                    return "Nữ";
                }
            }
            set
            {
                if (value == "Nam")
                {
                    this.gioiTinhNam = true;
                }
                else if (value == "Nữ")
                {
                    this.gioiTinhNam = false;
                }
            }
        }

        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }

        public string NoiSinh
        {
            get { return this.noiSinh; }
            set { this.noiSinh = value; }
        }

        public string ChucVu
        {
            get { return this.chucVu; }
            set { this.chucVu = value; }
        }

        public string SDT
        {
            get { return this.sdt; }
            set
            {
                if (value.Length == 10)
                {
                    this.sdt = value;
                }
            }
        }

        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set
            {
                if (DateTime.Today.Year - value.Year >= 18)
                {
                    this.ngaySinh = value;
                }
            }
        }

        public DateTime ThoiGianNhanViec
        {
            get { return this.thoiGianNhanViec; }
            set
            {
                if (DateTime.Compare(this.NgaySinh, value) < 0)
                {
                    this.thoiGianNhanViec = value;
                }
            }
        }

        public DateTime ThoiGianThoiViec
        {
            get { return this.thoiGianThoiViec; }
            set
            {
                if (DateTime.Compare(this.ThoiGianNhanViec, value) < 0)
                {
                    this.thoiGianThoiViec = value;
                }
            }
        }

        public void ThoiViec()
        {
            this.ThoiGianThoiViec = DateTime.Today;
        }
    }
}
