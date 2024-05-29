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
    public partial class frmQuanLy_Phong : Form
    {
        HeThong ht = new HeThong();
        public frmQuanLy_Phong()
        {
            InitializeComponent();
            this.Load += FrmQuanLy_Phong_Load;
            this.dgvP_Phong.SelectionChanged += dgvP_Phong_SelectionChanged;
            this.btnP_ThemPhong.Click += btnThemPhong_Click;
            this.btnP_CapNhatPhong.Click += btnCapNhatPhong_Click;
            this.btnP_XoaPhong.Click += btnXoaPhong_Click;
        }

        private void FrmQuanLy_Phong_Load(object sender, EventArgs e)
        {
            dgvP_Phong.DataSource = ht.dtv_Phong_LoaiPhong;
            cbxP_TinhTrangPhong.DataSource = ht.tinhTrang;
            cbxLoaiPhong.DataSource = ht.dtv_LoaiPhong;
            cbxLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbxLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        void bindP_Khach(DataView dv)
        {
            ht.RefreshTextBox(txtP_CCCD, dv, "CMND_CCCD");
            ht.RefreshTextBox(txtP_TenKhach, dv, "TenKhach");
            ht.RefreshTextBox(txtP_GioiTinh, dv, "GioiTinh");
            ht.RefreshTextBox(txtP_DiaChi, dv, "DiaChi");
            ht.RefreshTextBox(txtP_SDT, dv, "SDT");
        }

        void bindP_Phong(DataView dv)
        {

            ht.RefreshTextBox(txtP_MaPhong, dv, "MaPhong");
            ht.RefreshTextBox(txtP_ViTri, dv, "Tang");

            txtP_GiaPhong.Text = dgvP_Phong.CurrentRow.Cells[4].Value.ToString();

            if (cbxLoaiPhong.Items.Count > 0)
            {
                cbxLoaiPhong.SelectedValue = dgvP_Phong.CurrentRow.Cells[1].Value.ToString();
            }

            if (cbxP_TinhTrangPhong.Items.Count > 0)
            {
                cbxP_TinhTrangPhong.SelectedIndex = cbxP_TinhTrangPhong.FindStringExact(dgvP_Phong.CurrentRow.Cells[5].Value.ToString());
            }
        }

        void bindP_HoaDon(DataView dv)
        {
            txtP_ChiPhi.Text = ht.TinhChiPhi(dv[0]["MaHD"].ToString()).ToString();
            DateTime ngayThuePhong = Convert.ToDateTime(dv[0]["ThoiGianGiaoPhong"]);
            txtP_NgayO.Text = DateTime.Today.Subtract(ngayThuePhong).Days.ToString();
            txtP_TienPhong.Text = ht.TinhTienPhong(dv[0]["MaHD"].ToString()).ToString();
            int thanhTien = Convert.ToInt32(txtP_TienPhong.Text) + Convert.ToInt32(txtP_ChiPhi.Text);
            txtP_ThanhTien.Text = thanhTien.ToString();
        }

        void clearP_Khach()
        {
            ht.RefreshTextBox(txtP_CCCD);
            ht.RefreshTextBox(txtP_TenKhach);
            ht.RefreshTextBox(txtP_GioiTinh);
            ht.RefreshTextBox(txtP_DiaChi);
            ht.RefreshTextBox(txtP_SDT);
            ht.RefreshTextBox(txtP_TienPhong);
            ht.RefreshTextBox(txtP_ChiPhi);
            ht.RefreshTextBox(txtP_NgayO);
            txtP_ThanhTien.Clear();
        }

        void dgvP_Phong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvP_Phong.Rows.Count > 0)
            {
                string mp = dgvP_Phong.CurrentRow.Cells[0].Value.ToString();
                DataView hoaDon = ht.XuatHoaDonPhong(mp);

                if (hoaDon.Count > 0 && hoaDon[0]["ThoiGianTraPhong"] == DBNull.Value)
                {
                    bindP_HoaDon(hoaDon);
                    ht.dtv_Khach.RowFilter = "CMND_CCCD = '" + hoaDon[0]["CMND_CCCD"].ToString() + "'";
                    bindP_Khach(ht.dtv_Khach);
                }
                else
                {
                    clearP_Khach();
                }

                bindP_Phong(ht.dtv_Phong);
            }
        }

        void btnXoaPhong_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ht.XoaPhong(txtP_MaPhong.Text));
        }

        void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            if (btnP_CapNhatPhong.Text == "Cập nhật phòng")
            {
                txtP_MaPhong.ReadOnly = txtP_ViTri.ReadOnly = txtP_GiaPhong.ReadOnly = false;
                btnP_ThemPhong.Enabled = btnP_XoaPhong.Enabled = false;
                btnP_CapNhatPhong.Text = "Lưu";
            }
            else
            {
                string TinhTrang = cbxP_TinhTrangPhong.SelectedValue.ToString();
                string LoaiPhong = cbxLoaiPhong.SelectedValue.ToString();
                MessageBox.Show(ht.CapNhatPhong(txtP_MaPhong.Text, LoaiPhong, txtP_ViTri.Text, txtP_GiaPhong.Text, TinhTrang));
                txtP_MaPhong.ReadOnly = txtP_ViTri.ReadOnly = txtP_GiaPhong.ReadOnly = true;
                btnP_ThemPhong.Enabled = btnP_XoaPhong.Enabled = true;
                btnP_CapNhatPhong.Text = "Cập nhật phòng";
                dgvP_Phong.Refresh();
            }
        }

        void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (btnP_ThemPhong.Text == "Thêm phòng")
            {
                ht.RefreshTextBox(txtP_MaPhong);
                ht.RefreshTextBox(txtP_ViTri);
                ht.RefreshTextBox(txtP_GiaPhong);
                txtP_MaPhong.ReadOnly = txtP_ViTri.ReadOnly = txtP_GiaPhong.ReadOnly = false;
                btnP_CapNhatPhong.Enabled = btnP_XoaPhong.Enabled = false;
                btnP_ThemPhong.Text = "Lưu";
            }
            else
            {
                string LoaiPhong = cbxLoaiPhong.SelectedValue.ToString();
                MessageBox.Show(ht.ThemPhong(txtP_MaPhong.Text, LoaiPhong, txtP_ViTri.Text, txtP_GiaPhong.Text));
                txtP_MaPhong.ReadOnly = txtP_ViTri.ReadOnly = txtP_GiaPhong.ReadOnly = true;
                btnP_CapNhatPhong.Enabled = btnP_XoaPhong.Enabled = true;
                btnP_ThemPhong.Text = "Thêm phòng";
            }
        }
    }
}
