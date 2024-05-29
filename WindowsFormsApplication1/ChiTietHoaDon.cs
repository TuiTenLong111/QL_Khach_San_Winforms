using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public abstract class ChiTietHoaDon
    {
        protected HoaDon hd;

        public HoaDon HD
        {
            get { return this.hd; }
            set { this.hd = value; }
        }

        public abstract void ThemChiPhi();
    }
}
