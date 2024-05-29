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
    public partial class frmQuanLy_LuongThuong : Form
    {
        HeThong ht = new HeThong();
        public frmQuanLy_LuongThuong()
        {
            InitializeComponent();
            this.Load += FrmQuanLy_LuongThuong_Load;
        }

        private void FrmQuanLy_LuongThuong_Load(object sender, EventArgs e)
        {
            dgvLT_NhanVien.DataSource = ht.dtv_NhanVien;
            dgvLT_Luong.DataSource = ht.dtv_Luong;
            dgvLT_Thuong.DataSource = ht.dtv_Thuong;
            ht.dtv_NhanVien.RowFilter = null;
        }
    }
}
