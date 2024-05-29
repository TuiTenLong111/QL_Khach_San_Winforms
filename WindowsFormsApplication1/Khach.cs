using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public class Khach
    {
        protected string ten, cmnd_cccd, diaChi, sdt;
        protected bool gioiTinhNam;

        public Khach()
        {

        }

        public Khach(string t, string c, string gt, string dc, string sdt)
        {
            this.Ten = t;
            this.CMND_CCCD = c;
            this.GioiTinh = gt;
            this.DiaChi = dc;
            this.SDT = sdt;
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
    }
}
