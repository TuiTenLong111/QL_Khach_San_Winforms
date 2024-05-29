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
    public partial class frmHoSo : Form
    {
        HeThong ht = new HeThong();
        string MaNV = "";

        public frmHoSo(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void frmHoSo_Load(object sender, EventArgs e)
        {
            DataView dv = ht.ReloadNhanVien(this.MaNV);
            txtMaNV.DataBindings.Add("text", dv, "MaNV");
            txtTenNV.DataBindings.Add("text", dv, "TenNV");
            txtChucVu.DataBindings.Add("text", dv, "ChucVu");
            txtSDT.DataBindings.Add("text", dv, "SDT");
            txtGioiTinh.DataBindings.Add("text", dv, "GioiTinh");
            txtNoiSinh.DataBindings.Add("text", dv, "NoiSinh");
            dtpNgaySinh.DataBindings.Add("value", dv, "NgaySinh");
            txtCMND_CCCD.DataBindings.Add("text", dv, "CMND_CCCD");
            txtDiaChi.DataBindings.Add("text", dv, "DiaChi");
            if (dv[0]["DuongDanHinh"] != DBNull.Value)
            {
                pictureBox1.ImageLocation = dv[0]["DuongDanHinh"].ToString();
            }
        }
    }
}
