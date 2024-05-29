namespace QL_Khach_San_Backend
{
    partial class frmLeTan_VatTu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDV_Phong = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDV_TenKhach = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDV_DiaChi = new System.Windows.Forms.TextBox();
            this.txtDV_SDT = new System.Windows.Forms.TextBox();
            this.txtDV_CCCD = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbxDV_GioiTinh = new System.Windows.Forms.ComboBox();
            this.btn_ChucNang = new System.Windows.Forms.Button();
            this.gbxCTHD = new System.Windows.Forms.GroupBox();
            this.dgv_CTHD = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV_Phong)).BeginInit();
            this.gbxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.gbxCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.gbxDanhSach, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.gbxCTHD, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1184, 761);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDV_Phong);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(586, 374);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phòng đã được thuê";
            // 
            // dgvDV_Phong
            // 
            this.dgvDV_Phong.AllowUserToAddRows = false;
            this.dgvDV_Phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column8,
            this.Column7,
            this.Column9,
            this.Column10});
            this.dgvDV_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDV_Phong.Location = new System.Drawing.Point(3, 16);
            this.dgvDV_Phong.MultiSelect = false;
            this.dgvDV_Phong.Name = "dgvDV_Phong";
            this.dgvDV_Phong.ReadOnly = true;
            this.dgvDV_Phong.RowHeadersVisible = false;
            this.dgvDV_Phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV_Phong.Size = new System.Drawing.Size(580, 355);
            this.dgvDV_Phong.TabIndex = 1;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaPhong";
            this.Column6.HeaderText = "Mã phòng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "LoaiPhong";
            this.Column8.HeaderText = "Loại";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ViTriPhong";
            this.Column7.HeaderText = "Vị trí";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "GiaPhong";
            this.Column9.HeaderText = "Giá phòng";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TinhTrang";
            this.Column10.HeaderText = "Tình trạng";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // gbxDanhSach
            // 
            this.gbxDanhSach.Controls.Add(this.dgvDanhSach);
            this.gbxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDanhSach.Location = new System.Drawing.Point(595, 3);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Size = new System.Drawing.Size(586, 374);
            this.gbxDanhSach.TabIndex = 1;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "Danh sách vật tư";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDV,
            this.GiaDV});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(580, 355);
            this.dgvDanhSach.TabIndex = 1;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.Name = "TenDV";
            this.TenDV.ReadOnly = true;
            // 
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "GiaDV";
            this.GiaDV.HeaderText = "Chi phí";
            this.GiaDV.Name = "GiaDV";
            this.GiaDV.ReadOnly = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel6);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 383);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(586, 375);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông tin khách thuê phòng";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label17, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtDV_TenKhach, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbSoLuong, 3, 6);
            this.tableLayoutPanel6.Controls.Add(this.txtSoLuong, 4, 6);
            this.tableLayoutPanel6.Controls.Add(this.label20, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.label18, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label19, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtDV_DiaChi, 2, 5);
            this.tableLayoutPanel6.Controls.Add(this.txtDV_SDT, 2, 4);
            this.tableLayoutPanel6.Controls.Add(this.txtDV_CCCD, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.label22, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.cbxDV_GioiTinh, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.btn_ChucNang, 1, 6);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 9;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(580, 356);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(45, 73);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 30);
            this.label17.TabIndex = 25;
            this.label17.Text = "Tên khách hàng";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDV_TenKhach
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.txtDV_TenKhach, 3);
            this.txtDV_TenKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDV_TenKhach.Location = new System.Drawing.Point(195, 77);
            this.txtDV_TenKhach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDV_TenKhach.Name = "txtDV_TenKhach";
            this.txtDV_TenKhach.Size = new System.Drawing.Size(340, 20);
            this.txtDV_TenKhach.TabIndex = 23;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSoLuong.Location = new System.Drawing.Point(343, 223);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(94, 30);
            this.lbSoLuong.TabIndex = 34;
            this.lbSoLuong.Text = "Số lượng";
            this.lbSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSoLuong.Visible = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Location = new System.Drawing.Point(443, 226);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(94, 20);
            this.txtSoLuong.TabIndex = 33;
            this.txtSoLuong.Visible = false;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(45, 193);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 30);
            this.label20.TabIndex = 26;
            this.label20.Text = "Địa chỉ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(45, 163);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 30);
            this.label18.TabIndex = 28;
            this.label18.Text = "Số điện thoại";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(45, 133);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 30);
            this.label19.TabIndex = 27;
            this.label19.Text = "CCCD/CMND";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDV_DiaChi
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.txtDV_DiaChi, 3);
            this.txtDV_DiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDV_DiaChi.Location = new System.Drawing.Point(195, 197);
            this.txtDV_DiaChi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDV_DiaChi.Name = "txtDV_DiaChi";
            this.txtDV_DiaChi.Size = new System.Drawing.Size(340, 20);
            this.txtDV_DiaChi.TabIndex = 24;
            // 
            // txtDV_SDT
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.txtDV_SDT, 3);
            this.txtDV_SDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDV_SDT.Location = new System.Drawing.Point(195, 167);
            this.txtDV_SDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDV_SDT.Name = "txtDV_SDT";
            this.txtDV_SDT.Size = new System.Drawing.Size(340, 20);
            this.txtDV_SDT.TabIndex = 22;
            // 
            // txtDV_CCCD
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.txtDV_CCCD, 3);
            this.txtDV_CCCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDV_CCCD.Location = new System.Drawing.Point(195, 137);
            this.txtDV_CCCD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDV_CCCD.Name = "txtDV_CCCD";
            this.txtDV_CCCD.Size = new System.Drawing.Size(340, 20);
            this.txtDV_CCCD.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(43, 103);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 30);
            this.label22.TabIndex = 35;
            this.label22.Text = "Giới tính";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDV_GioiTinh
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.cbxDV_GioiTinh, 3);
            this.cbxDV_GioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDV_GioiTinh.FormattingEnabled = true;
            this.cbxDV_GioiTinh.Location = new System.Drawing.Point(193, 106);
            this.cbxDV_GioiTinh.Name = "cbxDV_GioiTinh";
            this.cbxDV_GioiTinh.Size = new System.Drawing.Size(344, 21);
            this.cbxDV_GioiTinh.TabIndex = 36;
            // 
            // btn_ChucNang
            // 
            this.btn_ChucNang.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanel6.SetColumnSpan(this.btn_ChucNang, 2);
            this.btn_ChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ChucNang.Location = new System.Drawing.Point(43, 226);
            this.btn_ChucNang.Name = "btn_ChucNang";
            this.tableLayoutPanel6.SetRowSpan(this.btn_ChucNang, 2);
            this.btn_ChucNang.Size = new System.Drawing.Size(294, 54);
            this.btn_ChucNang.TabIndex = 32;
            this.btn_ChucNang.Text = "Ghị nhận yêu cầu vật tư";
            this.btn_ChucNang.UseVisualStyleBackColor = false;
            // 
            // gbxCTHD
            // 
            this.gbxCTHD.Controls.Add(this.dgv_CTHD);
            this.gbxCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCTHD.Location = new System.Drawing.Point(595, 383);
            this.gbxCTHD.Name = "gbxCTHD";
            this.gbxCTHD.Size = new System.Drawing.Size(586, 375);
            this.gbxCTHD.TabIndex = 3;
            this.gbxCTHD.TabStop = false;
            this.gbxCTHD.Text = "Chi tiết yêu cầu vật tư của khách";
            // 
            // dgv_CTHD
            // 
            this.dgv_CTHD.AllowUserToAddRows = false;
            this.dgv_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CTHD.Location = new System.Drawing.Point(3, 16);
            this.dgv_CTHD.MultiSelect = false;
            this.dgv_CTHD.Name = "dgv_CTHD";
            this.dgv_CTHD.ReadOnly = true;
            this.dgv_CTHD.RowHeadersVisible = false;
            this.dgv_CTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CTHD.Size = new System.Drawing.Size(580, 356);
            this.dgv_CTHD.TabIndex = 2;
            // 
            // frmLeTan_VatTu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "frmLeTan_VatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yêu cầu vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV_Phong)).EndInit();
            this.gbxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.gbxCTHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvDV_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDV_TenKhach;
        private System.Windows.Forms.Button btn_ChucNang;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDV_DiaChi;
        private System.Windows.Forms.TextBox txtDV_SDT;
        private System.Windows.Forms.TextBox txtDV_CCCD;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbxDV_GioiTinh;
        private System.Windows.Forms.GroupBox gbxCTHD;
        private System.Windows.Forms.DataGridView dgv_CTHD;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}