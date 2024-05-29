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
    public partial class frmQuanLy_Main : Form
    {
        string MaNV = "";
        public frmQuanLy_Main(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.FormClosing += FrmQuanLy_Main_FormClosing;
            this.Load += FrmQuanLy_Main_Load;
        }

        private void FrmQuanLy_Main_Load(object sender, EventArgs e)
        {
            frmQuanLy_NhanVien f = new frmQuanLy_NhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void FrmQuanLy_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TatForm()
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Hide();
                c.Dispose();
            }
        }

        private void hồSơNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

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
            TatForm();

            this.Hide();

            frmDangNhap f = new frmDangNhap();
            f.Show();

            this.Dispose();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

            frmQuanLy_NhanVien f = new frmQuanLy_NhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

            frmQuanLy_Phong f = new frmQuanLy_Phong();
            f.MdiParent = this;
            f.Show();
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TatForm();

            frmTaiKhoan f = new frmTaiKhoan();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

            frmQuanLy_Khach f = new frmQuanLy_Khach();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐợnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

            frmQuanLy_HoaDon f = new frmQuanLy_HoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

            frmQuanLy_DichVu f = new frmQuanLy_DichVu();
            f.MdiParent = this;
            f.Show();
        }

        private void vậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

            frmQuanLy_VatTu f = new frmQuanLy_VatTu();
            f.MdiParent = this;
            f.Show();
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

            frmQuanLy_PhanCong f = new frmQuanLy_PhanCong();
            f.MdiParent = this;
            f.Show();
        }

        private void lươngThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatForm();

            frmQuanLy_LuongThuong f = new frmQuanLy_LuongThuong();
            f.MdiParent = this;
            f.Show();
        }
    }
}
