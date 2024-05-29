using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San_Backend
{
    public class VatTu
    {
        protected string tenVatTu, nguonGoc;
        protected int soLuong, giaVatTu;

        public VatTu()
        {

        }

        public VatTu(string tvt, string ng, int sl, int gvt)
        {
            this.TenVatTu = tvt;
            this.NguonGoc = ng;
            this.SoLuong = sl;
            this.GiaVatTu = gvt;
        }

        public string TenVatTu
        {
            get { return this.tenVatTu; }
            set { this.tenVatTu = value; }
        }

        public string NguonGoc
        {
            get { return this.nguonGoc; }
            set { this.nguonGoc = value; }
        }

        public int SoLuong
        {
            get { return this.soLuong; }
            set
            {
                if (value >= 0)
                {
                    this.soLuong = value;
                }
            }
        }

        public int GiaVatTu
        {
            get { return this.giaVatTu; }
            set
            {
                if (value >= 0)
                {
                    this.giaVatTu = value;
                }
            }
        }

        public void XuatNhap(int soLuongXuatKho=1)
        {
            this.SoLuong += soLuongXuatKho;
        }
    }
}
