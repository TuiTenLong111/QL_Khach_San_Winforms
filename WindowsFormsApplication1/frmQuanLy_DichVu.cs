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
    public partial class frmQuanLy_DichVu : Form
    {
        HeThong ht = new HeThong();
        public frmQuanLy_DichVu()
        {
            InitializeComponent();
            this.Load += FrmQuanLy_DichVu_Load;
            this.dgvDV_DichVu.SelectionChanged += dgvDV_DichVu_SelectionChanged;
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
            if (btnSua.Text == "Cập nhật dịch vụ")
            {
                txtDV_ChiPhi.ReadOnly = txtDV_TenDV.ReadOnly = false;
                btnXoa.Enabled = btnThem.Enabled = false;
                btnSua.Text = "Lưu";
            }
            else
            {
                txtDV_ChiPhi.ReadOnly = txtDV_TenDV.ReadOnly = true;
                btnXoa.Enabled = btnThem.Enabled = true;
                MessageBox.Show(ht.CapNhatDichVu(txtDV_TenDV.Text, txtDV_ChiPhi.Text));
                btnSua.Text = "Cập nhật dịch vụ";
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm dịch vụ")
            {
                ht.RefreshTextBox(txtDV_ChiPhi);
                ht.RefreshTextBox(txtDV_TenDV);
                txtDV_ChiPhi.ReadOnly = txtDV_TenDV.ReadOnly = false;
                btnXoa.Enabled = btnSua.Enabled = false;
                btnThem.Text = "Lưu";
            }
            else
            {

                txtDV_ChiPhi.ReadOnly = txtDV_TenDV.ReadOnly = true;
                btnXoa.Enabled = btnSua.Enabled = true;
                MessageBox.Show(ht.ThemDichVu(txtDV_TenDV.Text, txtDV_ChiPhi.Text));
                btnThem.Text = "Thêm dịch vụ";
            }
        }

        void dgvDV_DichVu_SelectionChanged(object sender, EventArgs e)
        {
            string tenDV = dgvDV_DichVu.CurrentRow.Cells[0].Value.ToString();

            ht.dtv_ChiTietHoaDon_SuDungDV.RowFilter = "TenDV = '" + tenDV + "'";

            txtDV_TenDV.Text = dgvDV_DichVu.CurrentRow.Cells[0].Value.ToString();
            txtDV_ChiPhi.Text = dgvDV_DichVu.CurrentRow.Cells[1].Value.ToString();
        }

        private void FrmQuanLy_DichVu_Load(object sender, EventArgs e)
        {
            dgvDV_DichVu.DataSource = ht.dtv_DichVu;
            dgvDV_SuDungDV.DataSource = ht.dtv_ChiTietHoaDon_SuDungDV;
        }
    }
}
