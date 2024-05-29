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
    public partial class frmTaiKhoan : Form
    {
        HeThong ht = new HeThong();

        public frmTaiKhoan()
        {
            InitializeComponent();
            this.btnThemTaiKhoan.Click += btnThemTaiKhoan_Click;
            this.btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            this.btnXoaTaiKhoan.Click += btnXoaTaiKhoan_Click;
            this.dgvTaiKhoan.SelectionChanged += dgvTaiKhoan_SelectionChanged;
        }

        void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            cbxMaNV.SelectedValue = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
        }

        void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ht.XoaTaiKhoan(cbxMaNV.SelectedValue.ToString()));
        }

        void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (btnDoiMatKhau.Text == "Đổi mật khẩu")
            {
                txtMatKhau.ReadOnly = false;
                btnThemTaiKhoan.Enabled = btnXoaTaiKhoan.Enabled = false;
                btnDoiMatKhau.Text = "Lưu";
            }
            else
            {
                string MaNV = cbxMaNV.SelectedValue.ToString();
                MessageBox.Show(ht.DoiMatKhau(MaNV, txtMatKhau.Text));
                txtMatKhau.ReadOnly = true;
                btnThemTaiKhoan.Enabled = btnXoaTaiKhoan.Enabled = true;
                btnDoiMatKhau.Text = "Đổi mật khẩu";
            }
        }

        void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (btnThemTaiKhoan.Text == "Thêm tài khoản")
            {
                txtMatKhau.Clear();
                txtMatKhau.ReadOnly = false;
                btnDoiMatKhau.Enabled = btnXoaTaiKhoan.Enabled = false;
                btnThemTaiKhoan.Text = "Lưu";
            }
            else
            {
                string MaNV = cbxMaNV.SelectedValue.ToString();
                MessageBox.Show(ht.ThemTaiKhoan(MaNV, txtMatKhau.Text));
                txtMatKhau.ReadOnly = true;
                btnDoiMatKhau.Enabled = btnXoaTaiKhoan.Enabled = true;
                btnThemTaiKhoan.Text = "Thêm tài khoản";
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = ht.dtv_TaiKhoan;
            cbxMaNV.DataSource = ht.dtv_NhanVien;
            cbxMaNV.DisplayMember = "TenNV";
            cbxMaNV.ValueMember = "MaNV";
            ht.dtv_NhanVien.RowFilter = "ChucVu = 'Lễ tân' or ChucVu = 'Quản lý'";
        }
    }
}
