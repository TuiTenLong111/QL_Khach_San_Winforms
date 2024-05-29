﻿using System;
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
    public partial class frmLeTan_DichVu : Form
    {
        HeThong ht = new HeThong();
        public frmLeTan_DichVu()
        {
            InitializeComponent();
            this.dgvDV_Phong.SelectionChanged += dgvDV_Phong_SelectionChanged;
            this.btn_ChucNang.Click += btn_ChucNang_Click;
        }

        void ClearKhachDV()
        {
            ht.RefreshTextBox(txtDV_TenKhach);
            ht.RefreshTextBox(txtDV_CCCD);
            ht.RefreshTextBox(txtDV_SDT);
            ht.RefreshTextBox(txtDV_DiaChi);
        }

        void bindingKhachDV(DataView dataSource)
        {
            ht.RefreshTextBox(txtDV_TenKhach, dataSource, "TenKhach");
            ht.RefreshTextBox(txtDV_CCCD, dataSource, "CMND_CCCD");
            ht.RefreshTextBox(txtDV_SDT, dataSource, "SDT");
            ht.RefreshTextBox(txtDV_DiaChi, dataSource, "DiaChi");

            if (cbxDV_GioiTinh.Items.Count > 0)
            {
                if (dataSource[0]["GioiTinh"].ToString() == "Nam")
                {
                    cbxDV_GioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cbxDV_GioiTinh.SelectedIndex = 1;
                }
            }
        }

        void btn_ChucNang_Click(object sender, EventArgs e)
        {
            string mp = dgvDV_Phong.SelectedRows[0].Cells[0].Value.ToString();
            DataView dv = ht.XuatHoaDonPhong(mp);

            string tenDV = dgvDanhSach.SelectedRows[0].Cells[0].Value.ToString();

            MessageBox.Show(ht.SuDungDV(dv[0]["MaHD"].ToString(), tenDV));
        }

        void dgvDV_Phong_SelectionChanged(object sender, EventArgs e)
        {
            string mp = dgvDV_Phong.CurrentRow.Cells[0].Value.ToString();
            DataView dv = ht.XuatHoaDonPhong(mp);

            dgv_CTHD.DataSource = null;

            if (dv.Count > 0 && dv[0]["ThoiGianTraPhong"] == DBNull.Value)
            {
                bindingKhachDV(ht.ReloadKhach(dv[0]["CMND_CCCD"].ToString()));
                dgv_CTHD.DataSource = ht.ReloadCTHD_DV(dv[0]["MaHD"].ToString());
                dgv_CTHD.Columns[0].Visible = false;
                dgv_CTHD.Columns[0].HeaderText = "Ma hóa đơn";
                dgv_CTHD.Columns[1].HeaderText = "Tên dịch vụ";
                dgv_CTHD.Columns[2].HeaderText = "Thời gian yêu cầu";
            }
            else
            {
                ClearKhachDV();
            }

            if (btn_ChucNang.Text == "Sử dụng dịch vụ")
            {

            }
            else if ((btn_ChucNang.Text == "Tiêu thụ vật tư"))
            {
                if (dv.Count > 0 && dv[0]["ThoiGianTraPhong"] == DBNull.Value)
                {
                    bindingKhachDV(ht.ReloadKhach(dv[0]["CMND_CCCD"].ToString()));
                    dgv_CTHD.DataSource = ht.ReloadCTHD_VT(dv[0]["MaHD"].ToString());
                    dgv_CTHD.Columns[0].Visible = false;
                    dgv_CTHD.Columns[1].HeaderText = "Tên vật tư";
                    dgv_CTHD.Columns[2].HeaderText = "Thời gian yêu cầu";
                    dgv_CTHD.Columns[3].HeaderText = "Số lượng";
                }
                else
                {
                    ClearKhachDV();
                }
            }
        }
    }
}