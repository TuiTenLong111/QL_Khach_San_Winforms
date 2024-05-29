using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public class DichVu
    {
        protected string tenDichVu, moTaDichVu;
        protected int giaDichVu;

        public DichVu()
        {

        }

        public DichVu(string tdv, string mtdv, int gdv)
        {
            this.TenDichVu = tdv;
            this.MoTaDichVu = mtdv;
            this.GiaDichVu = gdv;
        }

        public int GiaDichVu
        {
            get { return this.giaDichVu; }
            set
            {
                if (value >= 0)
                {
                    this.giaDichVu = value;
                }
            }
        }

        public string TenDichVu
        {
            get { return this.tenDichVu; }
            set { this.tenDichVu = value; }
        }

        public string MoTaDichVu
        {
            get { return this.moTaDichVu; }
            set { this.moTaDichVu = value; }
        }
    }
}
