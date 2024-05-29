using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace QL_Khach_San_Backend
{
    public partial class frmLeTan_DatPhong : Form
    {
        HeThong ht = new HeThong();
        string MaHD_DoiPhong = "";
        public frmLeTan_DatPhong()
        {
            InitializeComponent();
            this.Load += FrmLeTan_DatPhong_Load;
            this.txtCCCD.KeyPress += ht.numberOnly;
            this.txtSDT.KeyPress += ht.numberOnly;
            this.txtNgayO.KeyPress += ht.numberOnly;
            this.dgv_Phong.SelectionChanged += dgv_Phong_SelectionChanged;
            this.btnTimKiemKhach.Click += btnTimKiemKhach_Click;
            this.btnPhongTrong.Click += btnPhongTrong_Click;
            this.btnThuePhong.Click += btnThuePhong_Click;
            this.btnThanhToan.Click += btnThanhToan_Click;
            this.btnThemKhach.Click += btnThemKhach_Click;
            this.btnCapNhatKhach.Click += btnCapNhatKhach_Click;
            this.btnDoiPhong.Click += BtnDoiPhong_Click;
        }

        private void FrmLeTan_DatPhong_Load(object sender, EventArgs e)
        {
            dgv_Phong.DataSource = ht.dtv_Phong_LoaiPhong;
            cbxGioiTinh.DataSource = ht.gioiTinh;
            cbxLoaiPhong.DataSource = ht.dtv_LoaiPhong;
            cbxLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbxLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void BtnDoiPhong_Click(object sender, EventArgs e)
        {
            if (btnDoiPhong.Text == "Đổi phòng")
            {
                string tt = dgv_Phong.CurrentRow.Cells[5].Value.ToString();

                if (tt == "Đã thuê")
                {
                    string mp = dgv_Phong.CurrentRow.Cells[0].Value.ToString();
                    DataView hd = ht.XemHoaDonPhong(mp);
                    MaHD_DoiPhong = hd[0]["MaHD"].ToString();
                    btnDoiPhong.Text = "Chọn phòng mới";
                }
                else
                {
                    MessageBox.Show("Phòng này chưa được thuê");
                }
            }
            else
            {
                string tt = dgv_Phong.CurrentRow.Cells[5].Value.ToString();

                if (tt == "Trống")
                {
                    string mp = dgv_Phong.CurrentRow.Cells[0].Value.ToString();
                    DataView hd = ht.ReloadHoaDon(MaHD_DoiPhong);
                    string cccd = hd[0]["CMND_CCCD"].ToString();
                    MessageBox.Show(ht.DoiPhong(MaHD_DoiPhong, mp, cccd, DateTime.Now));
                    btnDoiPhong.Text = "Đổi phòng";
                }
                else if (tt == "Đã thuê")
                {
                    MessageBox.Show("Phòng này đã có người thuê");
                }
                else
                {
                    MessageBox.Show("Phòng này đang được sửa chữa");
                }
            }
        }

        void btnCapNhatKhach_Click(object sender, EventArgs e)
        {
            string gioiTinh = cbxGioiTinh.SelectedValue.ToString();
            MessageBox.Show(ht.CapNhatKhach(txtCCCD.Text, txtTenKhach.Text, gioiTinh, txtDiaChi.Text, txtSDT.Text));
        }

        void btnThemKhach_Click(object sender, EventArgs e)
        {
            string gioiTinh = cbxGioiTinh.SelectedValue.ToString();
            MessageBox.Show(ht.ThemKhach(txtCCCD.Text, txtTenKhach.Text, gioiTinh, txtDiaChi.Text, txtSDT.Text));
        }

        void btnThanhToan_Click(object sender, EventArgs e)
        {
            string mp = dgv_Phong.SelectedRows[0].Cells[0].Value.ToString();
            DataView dv = ht.XuatHoaDonPhong(mp);

            if (dv.Count > 0)
            {
                frmXemTruocHoaDon f = new frmXemTruocHoaDon(Convert.ToInt32(dv[0]["MaHD"].ToString()));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                MessageBox.Show("Phòng hiện tại không có khách thuê");
            }
        }

        void btnThuePhong_Click(object sender, EventArgs e)
        {
            if (ht.checkRong(txtCCCD.Text))
            {
                MessageBox.Show("Số CMND/CCCD không được trống");
            }
            else
            {
                ht.dtv_Khach.RowFilter = "CMND_CCCD = '" + txtCCCD.Text + "'";

                if (ht.dtv_Khach.Count > 0)
                {
                    bindingKhach(ht.dtv_Khach);
                    MessageBox.Show(ht.thuePhong(txtPhong.Text, txtCCCD.Text, dateTimePicker1.Value));
                }
                else
                {
                    string gioiTinh = cbxGioiTinh.SelectedValue.ToString();
                    List<string> txt_list = new List<string>() { txtTenKhach.Text, txtDiaChi.Text, txtDiaChi.Text, txtSDT.Text };

                    if (!ht.checkRong(txt_list))
                    {
                        string kq = ht.ThemKhach(txtCCCD.Text, txtTenKhach.Text, gioiTinh, txtDiaChi.Text, txtSDT.Text);

                        if (kq == "Thêm thông tin khách thành công")
                        {
                            MessageBox.Show(ht.thuePhong(txtPhong.Text, txtCCCD.Text, dateTimePicker1.Value));
                        }
                        else
                        {
                            MessageBox.Show(kq);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin khách không đầy đủ");
                    }
                }
            }
        }

        void btnPhongTrong_Click(object sender, EventArgs e)
        {
            if (btnPhongTrong.Text == "Hiển thị danh sách phòng trống")
            {
                ht.dtv_Phong_LoaiPhong.RowFilter = "TinhTrang = 'Trống'";
                btnPhongTrong.Text = "Hiển thị danh sách tất cả phòng";
            }
            else
            {
                ht.dtv_Phong_LoaiPhong.RowFilter = null;
                btnPhongTrong.Text = "Hiển thị danh sách phòng trống";
            }
        }

        void ClearKhach()
        {
            ht.RefreshTextBox(txtTenKhach);
            ht.RefreshTextBox(txtCCCD);
            ht.RefreshTextBox(txtSDT);
            ht.RefreshTextBox(txtDiaChi);
            ht.RefreshTextBox(txtTienPhong);
            ht.RefreshTextBox(txtTongChiPhi);
            ht.RefreshTextBox(txtNgayO);
        }

        void bindingKhach(DataView dataSource)
        {
            ht.RefreshTextBox(txtTenKhach, dataSource, "TenKhach");
            ht.RefreshTextBox(txtCCCD, dataSource, "CMND_CCCD");
            ht.RefreshTextBox(txtSDT, dataSource, "SDT");
            ht.RefreshTextBox(txtDiaChi, dataSource, "DiaChi");

            if (cbxGioiTinh.Items.Count > 0)
            {
                if (dataSource[0]["GioiTinh"].ToString() == "Nam")
                {
                    cbxGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cbxGioiTinh.SelectedIndex = 1;
                }
            }
        }

        void bindingPhong(DataView dataSource)
        {
            ht.RefreshTextBox(txtPhong, dataSource, "MaPhong");
            ht.RefreshTextBox(txtViTri, dataSource, "Tang");
            txtGiaPhong.Text = dgv_Phong.CurrentRow.Cells[5].Value.ToString();
            cbxLoaiPhong.SelectedValue = dgv_Phong.CurrentRow.Cells[1].Value.ToString();
        }

        void btnTimKiemKhach_Click(object sender, EventArgs e)
        {
            if (!ht.checkRong(txtCCCD.Text))
            {
                DataView dv = ht.ReloadKhach(txtCCCD.Text);

                if (dv.Count > 0)
                {
                    bindingKhach(dv);
                }
                else
                {
                    MessageBox.Show("Không có thông tin khách");
                }
            }
            else
            {
                MessageBox.Show("Số CMND/CCCD không được trống");
            }
        }

        void dgv_Phong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Phong.Rows.Count > 0)
            {
                string mp = dgv_Phong.CurrentRow.Cells[0].Value.ToString();
                DataView dv = ht.XuatHoaDonPhong(mp);

                bindingPhong(ht.dtv_Phong_LoaiPhong);


                if (dv.Count > 0 && dv[0]["ThoiGianTraPhong"] == DBNull.Value)
                {
                    ht.dtv_Khach.RowFilter = "CMND_CCCD = '" + dv[0]["CMND_CCCD"] + "'";
                    bindingKhach(ht.dtv_Khach);

                    dateTimePicker1.DataBindings.Clear();
                    dateTimePicker1.DataBindings.Add("value", dv, "ThoiGianGiaoPhong");
                    dateTimePicker1.Enabled = false;

                    txtTongChiPhi.Text = ht.TinhChiPhi(dv[0]["MaHD"].ToString()).ToString();
                    txtNgayO.Text = DateTime.Today.Subtract(dateTimePicker1.Value).Days.ToString();
                    txtTienPhong.Text = ht.TinhTienPhong(dv[0]["MaHD"].ToString()).ToString();
                }
                else
                {
                    ClearKhach();
                    dateTimePicker1.Enabled = true;
                }
            }
        }

        private void btnThuePhong_Click_1(object sender, EventArgs e)
        {

        }
    }
}
