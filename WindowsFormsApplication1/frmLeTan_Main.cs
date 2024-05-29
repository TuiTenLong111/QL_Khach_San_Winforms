using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Khach_San_Backend
{
    public partial class frmLeTan_Main : Form
    {
        string MaNV = "";
        public frmLeTan_Main(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.FormClosing += frmLeTan_Main_FormClosing;
        }

        private void frmLeTan_Main_Load(object sender, EventArgs e)
        {
            frmLeTan_DatPhong f = new frmLeTan_DatPhong();
            f.MdiParent = this;
            f.Show();
        }
        void frmLeTan_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Hide();
                c.Dispose();
            }

            frmLeTan_DatPhong f = new frmLeTan_DatPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void hồSơNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Hide();
                c.Dispose();
            }

            frmHoSo f = new frmHoSo(MaNV);
            f.MdiParent = this;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Hide();
                c.Dispose();
            }

            this.Hide();

            frmDangNhap f = new frmDangNhap();
            f.Show();

            this.Dispose();
        }
    }
}
