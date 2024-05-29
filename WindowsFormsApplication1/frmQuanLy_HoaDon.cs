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
    public partial class frmQuanLy_HoaDon : Form
    {
        HeThong ht = new HeThong();
        public frmQuanLy_HoaDon()
        {
            InitializeComponent();
            this.Load += FrmQuanLy_HoaDon_Load;
            this.dgvHD_HoaDon.SelectionChanged += dgvHD_HoaDon_SelectionChanged;
            this.btnThem.Click += BtnThem_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa hóa đơn này sẽ xóa mọi chi tiết hóa đơn liên quan. Bạn có muốn xóa hay không?", "Xác nhận xóa hóa đơn", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(ht.XoaHoaDon(txtHD_MaHD.Text));
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ht.CapNhatHoaDon(txtHD_MaHD.Text, txtHD_MaPhong.Text, txtHD_CMND_CCCD.Text, dtpHD_ThoiGianGiaoPhong.Value, dtpHD_ThoiGianTraPhong.Value));
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ht.ThemHoaDon(txtHD_MaPhong.Text, txtHD_CMND_CCCD.Text, dtpHD_ThoiGianGiaoPhong.Value));
        }
        void clearHoaDon()
        {
            ht.RefreshTextBox(txtHD_MaHD);
            ht.RefreshTextBox(txtHD_MaPhong);
            ht.RefreshTextBox(txtHD_CMND_CCCD);
            dtpHD_ThoiGianGiaoPhong.DataBindings.Clear();
            dtpHD_ThoiGianTraPhong.DataBindings.Clear();
            txtHD_TongChiPhi.Clear();
            txtHD_TienPhong.Clear();
            txtHD_ThanhTien.Clear();
        }

        void bindHoaDon(DataView dv)
        {
            ht.RefreshTextBox(txtHD_MaHD, dv, "MaHD");
            ht.RefreshTextBox(txtHD_MaPhong, dv, "MaPhong");
            ht.RefreshTextBox(txtHD_CMND_CCCD, dv, "CMND_CCCD");

            dtpHD_ThoiGianGiaoPhong.DataBindings.Clear();
            dtpHD_ThoiGianGiaoPhong.DataBindings.Add("value", dv, "ThoiGianGiaoPhong");
            dtpHD_ThoiGianTraPhong.DataBindings.Clear();

            if (dv[0]["ThoiGianTraPhong"] != DBNull.Value)
            {
                dtpHD_ThoiGianTraPhong.DataBindings.Add("value", dv, "ThoiGianTraPhong");
            }

            txtHD_TongChiPhi.Text = ht.TinhChiPhi(dv[0]["MaHD"].ToString()).ToString();
            txtHD_TienPhong.Text = ht.TinhTienPhong(dv[0]["MaHD"].ToString()).ToString();
            int thanhTien = Convert.ToInt32(txtHD_TienPhong.Text) + Convert.ToInt32(txtHD_TongChiPhi.Text);
            txtHD_ThanhTien.Text = thanhTien.ToString();
        }

        void dgvHD_HoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHD_HoaDon.Rows.Count > 0)
            {
                string maHD = dgvHD_HoaDon.CurrentRow.Cells[0].Value.ToString();
                ht.dtv_ChiTietHoaDon_SuDungDV.RowFilter = "MaHD = '" + maHD + "'";
                ht.dtv_ChiTietHoaDon_TieuThuVT.RowFilter = "MaHD = '" + maHD + "'";
                bindHoaDon(ht.dtv_HoaDon);
            }
            else
            {
                clearHoaDon();
            }
        }

        private void FrmQuanLy_HoaDon_Load(object sender, EventArgs e)
        {
            dgvHD_HoaDon.DataSource = ht.dtv_HoaDon;
            dgvHD_SuDungDV.DataSource = ht.dtv_ChiTietHoaDon_SuDungDV;
            dgvHD_TieuThuVT.DataSource = ht.dtv_ChiTietHoaDon_TieuThuVT;
        }
    }
}
