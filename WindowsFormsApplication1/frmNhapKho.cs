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
    public partial class frmNhapKho : Form
    {
        HeThong ht = new HeThong();
        DataView lsnk = new DataView();

        public frmNhapKho()
        {
            InitializeComponent();
            this.Load += fmNhapKho_Load;
            this.dgvVatTu.SelectionChanged += dgvVatTu_SelectionChanged;
            this.dgvNhapKho.SelectionChanged += dgvNhapKho_SelectionChanged;
            this.btnNhapKho.Click += btnNhapKho_Click;
            this.btnVT_HienThi.Click += btnVT_HienThi_Click;
            this.btnQuayLai.Click += BtnQuayLai_Click;
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            frmQuanLy_VatTu f = new frmQuanLy_VatTu();
            f.MdiParent = this.MdiParent;
            f.Show();

            this.Close();
        }

        void btnVT_HienThi_Click(object sender, EventArgs e)
        {
            dgvVatTu.ClearSelection();
            lsnk.RowFilter = null;
        }

        void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (btnNhapKho.Text == "Nhập kho")
            {
                cbxNhanVien.Enabled = true;
                txtVT_DonGia.ReadOnly = txtVT_SoLuong.ReadOnly = txtTenVT.ReadOnly = false;
                btnNhapKho.Text = "Lưu";
            }
            else
            {
                cbxNhanVien.Enabled = false;
                txtVT_DonGia.ReadOnly = txtVT_SoLuong.ReadOnly = txtTenVT.ReadOnly = true;
                string TenVT = txtTenVT.Text;
                string MaNV = cbxNhanVien.SelectedValue.ToString();
                int SoLuong = Convert.ToInt32(txtVT_SoLuong.Text);
                int DonGia = Convert.ToInt32(txtVT_DonGia.Text);
                MessageBox.Show(ht.NhapKho(TenVT, DateTime.Now, MaNV, SoLuong, DonGia));
                lsnk = ht.XemNhapKho();
                dgvNhapKho.Refresh();
                btnNhapKho.Text = "Nhập kho";
            }
        }

        void dgvNhapKho_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhapKho.Rows.Count > 0)
            {
                DataView dv = ht.XemNhapKho();
                dv.RowFilter = "MaNK = " + dgvNhapKho.CurrentRow.Cells[0].Value.ToString() + "";
                if (dv.Count > 0)
                {
                    txtTenVT.Text = dv[0]["TenVT"].ToString();
                }
                else 
                {
                    txtTenVT.Text = dgvVatTu.CurrentRow.Cells[0].Value.ToString();
                }

                cbxNhanVien.SelectedValue = dv[0]["MaNV"].ToString();
                txtVT_SoLuong.Text = dv[0]["SoLuong"].ToString();
                txtVT_DonGia.Text = dv[0]["DonGiaNhap"].ToString();
                dtpThoiGianNhap.Value = Convert.ToDateTime(dv[0]["ThoiGianNhap"]);
            }
            else
            {
                ht.RefreshTextBox(txtTenVT);
                ht.RefreshTextBox(txtVT_SoLuong);
                ht.RefreshTextBox(txtVT_DonGia);
            }

        }

        void dgvVatTu_SelectionChanged(object sender, EventArgs e)
        {
            string TenVT = dgvVatTu.CurrentRow.Cells[0].Value.ToString();
            lsnk.RowFilter = "TenVT = '" + TenVT + "'";
        }

        void fmNhapKho_Load(object sender, EventArgs e)
        {
            dgvVatTu.DataSource = ht.dtv_VatTu;
            lsnk = ht.XemNhapKho();
            dgvNhapKho.DataSource = lsnk;
            cbxNhanVien.DataSource = ht.dtv_NhanVien;
            cbxNhanVien.DisplayMember = "TenNV";
            cbxNhanVien.ValueMember = "MaNV";
        }
    }
}
