using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Khach_San_Backend
{
    public partial class frmQuanLy_NhanVien : Form
    {
        HeThong ht = new HeThong();
        public frmQuanLy_NhanVien()
        {
            InitializeComponent();
            this.Load += FrmQuanLy_NhanVien_Load;
            this.btnNV_TimKiemNhanVien.Click += btnTimKiemNhanVien_Click;
            this.btnNV_ThemNhanVien.Click += btnThem_Click;
            this.pbxNV_Hinh.Click += pbxHInh_Click;
            this.btnNV_CapNhatNhanVien.Click += btnCapNhatNhanVien_Click;
            this.dgvNV_NhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            this.btnNV_ThoiViec.Click += btnThoiViec_Click;
            this.btnNV_DiemDanh.Click += btnDiemDanh_Click;
            this.btnNV_BatDauDiemDanh.Click += btnBatDauDiemDanh_Click;
            this.btnNV_HienThiThoiViec.Click += btnHienThiThoiViec_Click;
            this.txtNV_HeSoLuong.KeyPress += ht.numberOnly;
        }

        private void FrmQuanLy_NhanVien_Load(object sender, EventArgs e)
        {
            dgvNV_NhanVien.DataSource = ht.dtv_NhanVien;
            ht.dtv_NhanVien.RowFilter = "ThoiGianThoiViec is NULL";
            cbxNV_GioiTinh.DataSource = new List<string>() { "Nam", "Nữ" };
            cbxNV_ChucVu.DataSource = ht.chucVu;
            dgvNV_DiemDanh.DataSource = ht.dtv_DiemDanh;
        }

        void editMode(bool b, Button btn)
        {
            pbxNV_Hinh.Enabled = cbxNV_GioiTinh.Enabled = dtpNV_NgaySinh.Enabled = dtpNV_NhanViec.Enabled = dtpNV_ThoiViec.Enabled = cbxNV_ChucVu.Enabled = b;
            txtNV_CCCD.ReadOnly = txtNV_DiaChi.ReadOnly = txtNV_NoiSinh.ReadOnly = txtNV_SDT.ReadOnly = txtNV_TenNV.ReadOnly = txtNV_SDT.ReadOnly = !b;
            btnNV_ThemNhanVien.Enabled = btnNV_CapNhatNhanVien.Enabled = btnNV_ThoiViec.Enabled = btnNV_ThoiViec.Enabled = btnNV_TimKiemNhanVien.Enabled = btnNV_DiemDanh.Enabled = btnNV_HienThiThoiViec.Enabled = btnNV_BatDauDiemDanh.Enabled = !b;
            btn.Enabled = true;
        }

        void pbxHInh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                string fileName = open.FileName;

                pbxNV_Hinh.Image = new Bitmap(fileName);

                Directory.CreateDirectory(@"~/Image/Download");
                string path = @"~/Image/Download/" + Path.GetFileNameWithoutExtension(open.FileName) + ".jpeg";
                pbxNV_Hinh.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);

                pbxNV_Hinh.ImageLocation = path;

            }
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            if (btnNV_ThemNhanVien.Text == "Thêm nhân viên")
            {
                dgvNV_NhanVien.ClearSelection();
                clearNhanVien();
                editMode(true, btnNV_ThemNhanVien);
                btnNV_ThemNhanVien.Enabled = true;
                btnNV_ThemNhanVien.Text = "Lưu nhân viên mới";
            }
            else
            {
                string gioiTinh = cbxNV_GioiTinh.SelectedValue.ToString();
                string chucVu = cbxNV_ChucVu.SelectedValue.ToString();
                DateTime ngaySinh = dtpNV_NgaySinh.Value;
                DateTime tgnv = dtpNV_NhanViec.Value;
                string hinh = pbxNV_Hinh.ImageLocation;
                string kq = ht.ThemNhanVien(txtNV_CCCD.Text, txtNV_TenNV.Text, gioiTinh, chucVu, ngaySinh, txtNV_NoiSinh.Text, txtNV_DiaChi.Text, txtNV_SDT.Text, tgnv, hinh);
                MessageBox.Show(kq);
                btnNV_ThemNhanVien.Text = "Thêm nhân viên";
                editMode(false, btnNV_ThemNhanVien);
                btnNV_ThemNhanVien.Enabled = true;
                dgvNV_NhanVien.Refresh();
            }
        }
        void btnHienThiThoiViec_Click(object sender, EventArgs e)
        {
            if (btnNV_HienThiThoiViec.Text == "Hiển thị nhân viên đã thôi việc")
            {
                ht.dtv_NhanVien.RowFilter = "ThoiGianThoiViec is not NULL";
                btnNV_HienThiThoiViec.Text = "Hiển thị toàn bộ nhân viên";
            }
            else
            {
                ht.dtv_NhanVien.RowFilter = "ThoiGianThoiViec is NULL";
                btnNV_HienThiThoiViec.Text = "Hiển thị nhân viên đã thôi việc";
            }
        }

        void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            if (btnNV_TimKiemNhanVien.Text == "Tìm kiếm nhân viên")
            {
                txtNV_MaNV.ReadOnly = false;
                btnNV_TimKiemNhanVien.Text = "Tìm kiếm";
            }
            else if (btnNV_TimKiemNhanVien.Text == "Tìm kiếm")
            {
                if (!ht.checkRong(txtNV_MaNV.Text))
                {
                    ht.dtv_NhanVien.RowFilter = "MaNV = " + txtNV_MaNV.Text + "";
                    txtNV_MaNV.ReadOnly = true;
                    btnNV_TimKiemNhanVien.Text = "Hiển thị toàn bộ nhân viên";
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không được để trống");
                }
            }
            else
            {
                ht.dtv_NhanVien.RowFilter = null;
                btnNV_TimKiemNhanVien.Text = "Tìm kiếm nhân viên";
            }
        }

        void btnBatDauDiemDanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ht.TaoDiemDanh());
        }

        void btnDiemDanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ht.DiemDanh(txtNV_MaNV.Text));
        }

        void btnThoiViec_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ht.ThoiViecNhanVien(txtNV_MaNV.Text));
        }

        void clearNhanVien()
        {
            ht.RefreshTextBox(txtNV_MaNV);
            ht.RefreshTextBox(txtNV_TenNV);
            ht.RefreshTextBox(txtNV_CCCD);
            ht.RefreshTextBox(txtNV_DiaChi);
            ht.RefreshTextBox(txtNV_NoiSinh);
            ht.RefreshTextBox(txtNV_SDT);
            ht.RefreshTextBox(txtNV_HeSoLuong);
            dtpNV_NgaySinh.DataBindings.Clear();
            dtpNV_NhanViec.DataBindings.Clear();
            dtpNV_ThoiViec.DataBindings.Clear();
            pbxNV_Hinh.Image = QL_Khach_San_Backend.Properties.Resources.Default;
        }

        void bindNhanVien(DataView dv)
        {
            ht.RefreshTextBox(txtNV_MaNV, dv, "MaNV");
            ht.RefreshTextBox(txtNV_TenNV, dv, "TenNV");
            ht.RefreshTextBox(txtNV_CCCD, dv, "CMND_CCCD");
            ht.RefreshTextBox(txtNV_DiaChi, dv, "DiaChi");
            ht.RefreshTextBox(txtNV_NoiSinh, dv, "NoiSinh");
            ht.RefreshTextBox(txtNV_SDT, dv, "SDT");
            ht.RefreshTextBox(txtNV_HeSoLuong, dv, "HeSoLuong");
            dtpNV_NgaySinh.DataBindings.Clear();
            dtpNV_NgaySinh.DataBindings.Add("value", dv, "NgaySinh");
            dtpNV_NhanViec.DataBindings.Clear();
            dtpNV_NhanViec.DataBindings.Add("value", dv, "ThoiGianNhanViec");
            dtpNV_ThoiViec.Visible = false;
            pbxNV_Hinh.Image = QL_Khach_San_Backend.Properties.Resources.Default;

            if (cbxNV_GioiTinh.Items.Count > 0)
            {
                cbxNV_GioiTinh.SelectedIndex = cbxNV_GioiTinh.FindStringExact(dv[0]["GioiTinh"].ToString());
            }

            if (cbxNV_ChucVu.Items.Count > 0)
            {
                cbxNV_ChucVu.SelectedIndex = cbxNV_ChucVu.FindStringExact(dv[0]["ChucVu"].ToString());
            }

            if (dv[0]["ThoiGianThoiViec"] != DBNull.Value)
            {
                dtpNV_ThoiViec.Visible = true;
                dtpNV_ThoiViec.DataBindings.Clear();
                dtpNV_ThoiViec.DataBindings.Add("value", dv, "ThoiGianThoiViec");
            }


            if (dv[0]["DuongDanHinh"] != DBNull.Value)
            {
                pbxNV_Hinh.ImageLocation = dv[0]["DuongDanHinh"].ToString();
            }
        }

        void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNV_NhanVien.Rows.Count > 0)
            {
                string mnv = dgvNV_NhanVien.CurrentRow.Cells[0].Value.ToString();
                ht.dtv_DiemDanh.RowFilter = "MaNV = " + mnv + "";
                bindNhanVien(ht.dtv_NhanVien);
            }
        }

        void btnCapNhatNhanVien_Click(object sender, EventArgs e)
        {
            if (btnNV_CapNhatNhanVien.Text == "Cập nhật nhân viên")
            {
                editMode(true, btnNV_CapNhatNhanVien);
                btnNV_CapNhatNhanVien.Text = "Lưu thông tin nhân viên";
            }
            else
            {
                string gioiTinh = cbxNV_GioiTinh.SelectedValue.ToString();
                string chucVu = cbxNV_ChucVu.SelectedValue.ToString();
                DateTime ngaySinh = dtpNV_NgaySinh.Value;
                DateTime tgnv = dtpNV_NhanViec.Value;
                string hinh = pbxNV_Hinh.ImageLocation;
                string maNV = dgvNV_NhanVien.CurrentRow.Cells[0].Value.ToString();
                double heSoLuong = Convert.ToDouble(txtNV_HeSoLuong.Text);
                string kq = ht.CapNhatNhanVien(maNV, txtNV_CCCD.Text, txtNV_TenNV.Text, gioiTinh, chucVu, ngaySinh, txtNV_NoiSinh.Text, txtNV_DiaChi.Text, txtNV_SDT.Text, tgnv, heSoLuong, hinh);
                MessageBox.Show(kq);
                btnNV_CapNhatNhanVien.Text = "Cập nhật nhân viên";
                editMode(false, btnNV_CapNhatNhanVien);
                btnNV_ThemNhanVien.Enabled = true;
                dgvNV_NhanVien.Refresh();
            }
        }
    }
}
