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
    public partial class frmQuanLy_VatTu : Form
    {
        HeThong ht = new HeThong();
        public frmQuanLy_VatTu()
        {
            InitializeComponent();
            this.Load += FrmQuanLy_VatTu_Load;
            this.dgvVT_VatTu.SelectionChanged += dgvVT_VatTu_SelectionChanged;
            this.btnNhapKho.Click += btnNhapKho_Click;
            this.btnThem.Click += BtnThem_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện chức năng này chưa được cài đặt");
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Cập nhật vật tư")
            {
                txtVT_DonGia.ReadOnly = txtVT_NguonGoc.ReadOnly = txtVT_VatTu.ReadOnly = false;
                btnXoa.Enabled = btnThem.Enabled = false;
                btnSua.Text = "Lưu";
            }
            else
            {
                txtVT_DonGia.ReadOnly = txtVT_NguonGoc.ReadOnly = txtVT_VatTu.ReadOnly = true;
                btnXoa.Enabled = btnThem.Enabled = true;
                int DonGia = Convert.ToInt32(txtVT_DonGia.Text);
                MessageBox.Show(ht.CapNhatVatTu(txtVT_DonGia.Text, 0, txtVT_NguonGoc.Text, DonGia));
                btnSua.Text = "Cập nhật vật tư";
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm vật tư")
            {
                ht.RefreshTextBox(txtVT_DonGia);
                ht.RefreshTextBox(txtVT_NguonGoc);
                ht.RefreshTextBox(txtVT_VatTu);
                ht.RefreshTextBox(txtVT_SoLuong);
                txtVT_DonGia.ReadOnly = txtVT_NguonGoc.ReadOnly = txtVT_VatTu.ReadOnly = false;
                btnXoa.Enabled = btnSua.Enabled = false;
                btnThem.Text = "Lưu";
            }
            else
            {

                txtVT_DonGia.ReadOnly = txtVT_NguonGoc.ReadOnly = txtVT_VatTu.ReadOnly = true;
                btnXoa.Enabled = btnSua.Enabled = true;
                int DonGia = Convert.ToInt32(txtVT_DonGia.Text);
                MessageBox.Show(ht.ThemVatTu(txtVT_DonGia.Text, 0, txtVT_NguonGoc.Text, DonGia));
                btnThem.Text = "Thêm vật tư";
            }
        }

        void btnNhapKho_Click(object sender, EventArgs e)
        {
            frmNhapKho f = new frmNhapKho();
            f.MdiParent = this.MdiParent;
            f.Show();

            this.Close();
        }

        private void FrmQuanLy_VatTu_Load(object sender, EventArgs e)
        {
            dgvVT_VatTu.DataSource = ht.dtv_VatTu;
            dgvVT_TieuThuVT.DataSource = ht.dtv_ChiTietHoaDon_TieuThuVT;
        }

        void dgvVT_VatTu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVT_VatTu.Rows.Count > 0)
            {
                string tenVT = dgvVT_VatTu.CurrentRow.Cells[0].Value.ToString();

                ht.dtv_ChiTietHoaDon_TieuThuVT.RowFilter = "TenVT = '" + tenVT + "'";

                txtVT_VatTu.Text = dgvVT_VatTu.CurrentRow.Cells[0].Value.ToString();
                txtVT_NguonGoc.Text = dgvVT_VatTu.CurrentRow.Cells[2].Value.ToString();
                txtVT_SoLuong.Text = dgvVT_VatTu.CurrentRow.Cells[1].Value.ToString();
                txtVT_DonGia.Text = dgvVT_VatTu.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
