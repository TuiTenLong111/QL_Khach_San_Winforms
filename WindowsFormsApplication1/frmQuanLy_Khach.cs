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
    public partial class frmQuanLy_Khach : Form
    {
        HeThong ht = new HeThong();
        public frmQuanLy_Khach()
        {
            InitializeComponent();
            this.Load += FrmQuanLy_Khach_Load;
            this.dgvK_Khach.SelectionChanged += dgvK_Khach_SelectionChanged;
            this.btnThem.Click += BtnThem_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnXoa.Click += BtnXoa_Click;
        }

        private void FrmQuanLy_Khach_Load(object sender, EventArgs e)
        {
            dgvK_Khach.DataSource = ht.dtv_Khach;
            cbxK_TinhTrang.DataSource = ht.tinhTrang;
            cbxLoaiPhong.DataSource = ht.dtv_LoaiPhong;
            cbxLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbxLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

        }

        void dgvK_Khach_SelectionChanged(object sender, EventArgs e)
        {
            string cccd = dgvK_Khach.CurrentRow.Cells[0].Value.ToString();
            DataView khach = ht.ReloadKhach(cccd);

            if (khach.Count > 0)
            {
                DataView hoaDon = ht.XemHoaDonKhach(cccd);

                if (hoaDon.Count > 0 && hoaDon[0]["ThoiGianTraPhong"] == DBNull.Value)
                {
                    DataView dv = ht.ReloadKhach(hoaDon[0]["CMND_CCCD"].ToString());

                    txtK_TongChiPhi.Text = ht.TinhChiPhi(hoaDon[0]["MaHD"].ToString()).ToString();
                    txtK_TienPhong.Text = ht.TinhTienPhong(hoaDon[0]["MaHD"].ToString()).ToString();
                    int thanhTien = Convert.ToInt32(txtK_TienPhong.Text) + Convert.ToInt32(txtK_TongChiPhi.Text);
                    txtK_ThanhTien.Text = thanhTien.ToString();

                    ht.RefreshTextBox(txtK_MaHD, hoaDon, "MaHD");
                    ht.RefreshTextBox(txtK_MaPhong, hoaDon, "MaPhong");

                    DataView phong = ht.ReloadPhong(hoaDon[0]["MaPhong"].ToString());

                    if (phong.Count > 0)
                    {
                        ht.RefreshTextBox(txtK_ViTri, phong, "Tang");

                        if (cbxLoaiPhong.Items.Count > 0)
                        {
                            cbxLoaiPhong.SelectedValue = phong[0]["MaLoaiPhong"];
                        }

                        if (cbxK_TinhTrang.Items.Count > 0)
                        {
                            cbxK_TinhTrang.SelectedIndex = cbxK_TinhTrang.FindStringExact(phong[0]["TinhTrang"].ToString());
                        }
                    }
                }
                else
                {
                    ht.RefreshTextBox(txtK_MaHD);
                    ht.RefreshTextBox(txtK_MaPhong);
                }
            }
            else
            {
                ht.RefreshTextBox(txtK_MaHD);
                ht.RefreshTextBox(txtK_MaPhong);
            }
        }
    }
}
