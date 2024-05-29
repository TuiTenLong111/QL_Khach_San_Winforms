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
    public partial class frmDangNhap : Form
    {
        HeThong ht = new HeThong();

        public frmDangNhap()
        {
            InitializeComponent();
            this.btnDangNhap.Click += btnDangNhap_Click;
            this.FormClosing += FrmDangNhap_FormClosing;
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string kq = ht.KiemTraTaiKhoan(txtMaNV.Text, txtMatKhau.Text);

            if (kq != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();

                if (kq == "Quản lý")
                {
                    frmQuanLy_Main f = new frmQuanLy_Main(txtMaNV.Text);
                    f.Show();
                }
                else if (kq == "Lễ tân")
                {
                    frmLeTan_Main f = new frmLeTan_Main(txtMaNV.Text);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản chưa được cấp quyền truy cập");
                }
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản không chính xác");
            }

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.Icon = QL_Khach_San_Backend.Properties.Resources.Hotel;
        }
    }
}
