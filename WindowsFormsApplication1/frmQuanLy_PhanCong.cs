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
    public partial class frmQuanLy_PhanCong : Form
    {
        HeThong ht = new HeThong();
        public frmQuanLy_PhanCong()
        {
            InitializeComponent();
            this.Load += FrmQuanLy_PhanCong_Load;
            this.dgvPC_NhanVien.SelectionChanged += dgvPC_NhanVien_SelectionChanged;
            this.btnPhanCong.Click += btnPhanCong_Click;
            this.dgvPC_Ca.CellDoubleClick += dgvPC_Ca_CellDoubleClick;
            this.btnThemCa.Click += btnThemCa_Click;
            this.btnCapNhatCa.Click += btnCapNhatCa_Click;
            this.dgvPC_Ca.SelectionChanged += dgvPC_Ca_SelectionChanged;
        }

        private void FrmQuanLy_PhanCong_Load(object sender, EventArgs e)
        {
            dgvPC_NhanVien.DataSource = ht.dtv_NhanVien;
            ht.dtv_NhanVien.RowFilter = "ThoiGianThoiViec is NULL";
            dgvPC_Ca.DataSource = ht.dtv_Ca;
            dgvPC_PhanCong.DataSource = ht.dtv_PhanCong;
            ht.dtv_NhanVien.RowFilter = null;
            cbxChucVu.DataSource = ht.chucVu;
        }

        void dgvPC_Ca_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPC_Ca.Rows.Count > 0)
            {
                string soCa = dgvPC_Ca.CurrentRow.Cells[0].Value.ToString();
                string chucVu = dgvPC_Ca.CurrentRow.Cells[1].Value.ToString();

                DataView ca = ht.ReloadCa(soCa, chucVu);

                if (ca.Count > 0)
                {
                    ht.RefreshTextBox(txtSoCa, ca, "SoCa");

                    if (cbxChucVu.Items.Count > 0)
                    {
                        cbxChucVu.SelectedIndex = cbxChucVu.FindStringExact(ca[0]["ChucVu"].ToString());
                    }

                    DateTime bd = Convert.ToDateTime(ca[0]["ThoiGianBatDauCa"].ToString());
                    dtpBatDau.Value = bd;
                    DateTime kt = Convert.ToDateTime(ca[0]["ThoiGianKetThucCa"].ToString());
                    dtpKetThuc.Value = kt;
                }
                else
                {
                    ht.RefreshTextBox(txtSoCa);
                    dtpBatDau.DataBindings.Clear();
                    dtpKetThuc.DataBindings.Clear();
                }
            }
        }

        void btnCapNhatCa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ht.CapNhatCa(txtSoCa.Text, cbxChucVu.SelectedValue.ToString(), dtpBatDau.Value, dtpKetThuc.Value));
        }

        void btnThemCa_Click(object sender, EventArgs e)
        {
            if (btnThemCa.Text == "Thêm ca")
            {
                txtSoCa.Enabled = cbxChucVu.Enabled = dtpBatDau.Enabled = dtpKetThuc.Enabled = true;
                btnPhanCong.Enabled = btnCapNhatCa.Enabled = false;
                txtSoCa.Clear();
                btnThemCa.Text = "Lưu";
            }
            else
            {
                MessageBox.Show(ht.ThemCa(txtSoCa.Text, cbxChucVu.SelectedValue.ToString(), dtpBatDau.Value, dtpKetThuc.Value));
                txtSoCa.Enabled = cbxChucVu.Enabled = dtpBatDau.Enabled = dtpKetThuc.Enabled = false;
                btnPhanCong.Enabled = btnCapNhatCa.Enabled = true;
                btnThemCa.Text = "Thêm ca";
            }
        }

        void refresh_dgvP_PhanCong(DataView dv)
        {
            dgvPC_PhanCong.DataSource = null;
            dgvPC_PhanCong.DataSource = dv;
            dgvPC_PhanCong.Columns[0].Visible = false;
            dgvPC_PhanCong.Columns[1].Visible = false;
            dgvPC_PhanCong.Columns[2].HeaderText = "Ca";
        }

        void dgvPC_Ca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnPhanCong.Text == "Lưu")
            {
                string Ca = dgvPC_Ca.CurrentRow.Cells[0].Value.ToString();
                string MaNV = dgvPC_NhanVien.CurrentRow.Cells[0].Value.ToString();
                string ChucVu = ht.ReloadNhanVien(MaNV)[0]["ChucVu"].ToString();
                ht.ThemPhanCong(MaNV, Ca, ChucVu);
                refresh_dgvP_PhanCong(ht.ReloadPhanCong(dgvPC_NhanVien.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (btnPhanCong.Text == "Phân công")
            {
                lbPhanCong.Visible = true;
                dgvPC_PhanCong.ReadOnly = false;
                dgvPC_PhanCong.AllowUserToAddRows = dgvPC_PhanCong.AllowUserToDeleteRows = true;
                btnPhanCong.Text = "Lưu";
            }
            else
            {
                ht.Luu("PhanCong");
                lbPhanCong.Visible = false;
                refresh_dgvP_PhanCong(ht.ReloadPhanCong(dgvPC_NhanVien.CurrentRow.Cells[0].Value.ToString()));
                dgvPC_PhanCong.ReadOnly = true;
                dgvPC_PhanCong.AllowUserToAddRows = false;
                btnPhanCong.Text = "Phân công";
            }
        }








        void dgvPC_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            string mnv = dgvPC_NhanVien.CurrentRow.Cells[0].Value.ToString();
            string cv = dgvPC_NhanVien.CurrentRow.Cells[2].Value.ToString();
            ht.dtv_Ca.RowFilter = "ChucVu = '" + cv + "'";
            ht.dtv_PhanCong.RowFilter = "MaNV = '" + mnv + "'";
        }
    }
}
