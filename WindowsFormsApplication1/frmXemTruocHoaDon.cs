using QL_Khach_San_Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmXemTruocHoaDon : Form
    {
        int MaHD = 0;
        HeThong ht = new HeThong();
        public frmXemTruocHoaDon(int MaHD)
        {
            InitializeComponent();
            this.MaHD = MaHD;
            this.btnThanhToan.Click += BtnThanhToan_Click;
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (ht.ThanhToan(MaHD.ToString()))
            {
                MessageBox.Show("Thanh toán thành công");

                frmLeTan_DatPhong f = new frmLeTan_DatPhong();
                f.MdiParent = this.MdiParent;
                f.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }

        private void frmXemTruocHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonIn hdi = new HoaDonIn();
            crystalReportViewer1.ReportSource = hdi;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.SelectionFormula = "{HoaDon.MaHD} = " + MaHD;
        }
    }
}
