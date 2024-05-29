namespace QL_Khach_San_Backend
{
    partial class frmQuanLy_HoaDon
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
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.dgvHD_SuDungDV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dgvHD_HoaDon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label35 = new System.Windows.Forms.Label();
            this.txtHD_MaHD = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtHD_ThanhTien = new System.Windows.Forms.TextBox();
            this.txtHD_TongChiPhi = new System.Windows.Forms.TextBox();
            this.txtHD_TienPhong = new System.Windows.Forms.TextBox();
            this.dtpHD_ThoiGianTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpHD_ThoiGianGiaoPhong = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.txtHD_CMND_CCCD = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtHD_MaPhong = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dgvHD_TieuThuVT = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel12.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD_SuDungDV)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD_HoaDon)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD_TieuThuVT)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.groupBox19, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.groupBox11, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.groupBox12, 1, 2);
            this.tableLayoutPanel12.Controls.Add(this.groupBox10, 1, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1184, 761);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.dgvHD_SuDungDV);
            this.groupBox19.Location = new System.Drawing.Point(595, 3);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(582, 207);
            this.groupBox19.TabIndex = 5;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Chi tiết sử dụng dịch vụ";
            // 
            // dgvHD_SuDungDV
            // 
            this.dgvHD_SuDungDV.AllowUserToAddRows = false;
            this.dgvHD_SuDungDV.AllowUserToDeleteRows = false;
            this.dgvHD_SuDungDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD_SuDungDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD_SuDungDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.Column34});
            this.dgvHD_SuDungDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHD_SuDungDV.Location = new System.Drawing.Point(3, 16);
            this.dgvHD_SuDungDV.MultiSelect = false;
            this.dgvHD_SuDungDV.Name = "dgvHD_SuDungDV";
            this.dgvHD_SuDungDV.ReadOnly = true;
            this.dgvHD_SuDungDV.RowHeadersVisible = false;
            this.dgvHD_SuDungDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD_SuDungDV.Size = new System.Drawing.Size(576, 188);
            this.dgvHD_SuDungDV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TenDV";
            this.dataGridViewTextBoxColumn11.HeaderText = "Mã dịch vụ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ThoiGianYeuCau";
            this.dataGridViewTextBoxColumn12.HeaderText = "Thời gian yêu cầu";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // Column34
            // 
            this.Column34.DataPropertyName = "MaHD";
            this.Column34.HeaderText = "MaHD";
            this.Column34.Name = "Column34";
            this.Column34.ReadOnly = true;
            this.Column34.Visible = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dgvHD_HoaDon);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.tableLayoutPanel12.SetRowSpan(this.groupBox11, 3);
            this.groupBox11.Size = new System.Drawing.Size(586, 755);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Danh sách hóa đơn";
            // 
            // dgvHD_HoaDon
            // 
            this.dgvHD_HoaDon.AllowUserToAddRows = false;
            this.dgvHD_HoaDon.AllowUserToDeleteRows = false;
            this.dgvHD_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Column31,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column20,
            this.dataGridViewTextBoxColumn8});
            this.dgvHD_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHD_HoaDon.Location = new System.Drawing.Point(3, 16);
            this.dgvHD_HoaDon.MultiSelect = false;
            this.dgvHD_HoaDon.Name = "dgvHD_HoaDon";
            this.dgvHD_HoaDon.ReadOnly = true;
            this.dgvHD_HoaDon.RowHeadersVisible = false;
            this.dgvHD_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD_HoaDon.Size = new System.Drawing.Size(580, 736);
            this.dgvHD_HoaDon.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column31
            // 
            this.Column31.DataPropertyName = "MaPhong";
            this.Column31.HeaderText = "Mã phòng";
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CMND_CCCD";
            this.dataGridViewTextBoxColumn6.HeaderText = "CMND/CCCD";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ThoiGianGiaoPhong";
            this.dataGridViewTextBoxColumn7.FillWeight = 135F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Thời gian nhận phòng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "ThoiGianTraPhong";
            this.Column20.FillWeight = 125F;
            this.Column20.HeaderText = "Thời gian trả phòng";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tổng tiền đã thanh toán";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tableLayoutPanel14);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(595, 459);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(586, 299);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin hóa đơn";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.Controls.Add(this.label35, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.txtHD_MaHD, 2, 1);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 1, 9);
            this.tableLayoutPanel14.Controls.Add(this.label53, 1, 8);
            this.tableLayoutPanel14.Controls.Add(this.label52, 1, 7);
            this.tableLayoutPanel14.Controls.Add(this.label51, 1, 6);
            this.tableLayoutPanel14.Controls.Add(this.label38, 1, 5);
            this.tableLayoutPanel14.Controls.Add(this.label37, 1, 4);
            this.tableLayoutPanel14.Controls.Add(this.txtHD_ThanhTien, 2, 8);
            this.tableLayoutPanel14.Controls.Add(this.txtHD_TongChiPhi, 2, 7);
            this.tableLayoutPanel14.Controls.Add(this.txtHD_TienPhong, 2, 6);
            this.tableLayoutPanel14.Controls.Add(this.dtpHD_ThoiGianTraPhong, 2, 5);
            this.tableLayoutPanel14.Controls.Add(this.dtpHD_ThoiGianGiaoPhong, 2, 4);
            this.tableLayoutPanel14.Controls.Add(this.label36, 1, 3);
            this.tableLayoutPanel14.Controls.Add(this.txtHD_CMND_CCCD, 2, 3);
            this.tableLayoutPanel14.Controls.Add(this.label30, 1, 2);
            this.tableLayoutPanel14.Controls.Add(this.txtHD_MaPhong, 2, 2);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 11;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(580, 280);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Location = new System.Drawing.Point(116, 10);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(119, 25);
            this.label35.TabIndex = 0;
            this.label35.Text = "Mã hóa đơn";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHD_MaHD
            // 
            this.txtHD_MaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHD_MaHD.Location = new System.Drawing.Point(241, 13);
            this.txtHD_MaHD.Name = "txtHD_MaHD";
            this.txtHD_MaHD.ReadOnly = true;
            this.txtHD_MaHD.Size = new System.Drawing.Size(221, 20);
            this.txtHD_MaHD.TabIndex = 4;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 5;
            this.tableLayoutPanel14.SetColumnSpan(this.tableLayoutPanel15, 2);
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel15.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.btnSua, 2, 0);
            this.tableLayoutPanel15.Controls.Add(this.btnXoa, 4, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(116, 213);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(344, 54);
            this.tableLayoutPanel15.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Ivory;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 48);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Ivory;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Location = new System.Drawing.Point(124, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 48);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Ivory;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(245, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 48);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // label53
            // 
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Location = new System.Drawing.Point(116, 185);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(119, 25);
            this.label53.TabIndex = 13;
            this.label53.Text = "Thành tiền";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Location = new System.Drawing.Point(116, 160);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(119, 25);
            this.label52.TabIndex = 12;
            this.label52.Text = "Tổng chi phí phát sinh";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label51
            // 
            this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label51.Location = new System.Drawing.Point(116, 135);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(119, 25);
            this.label51.TabIndex = 11;
            this.label51.Text = "Tiền phòng";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Location = new System.Drawing.Point(116, 110);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(119, 25);
            this.label38.TabIndex = 3;
            this.label38.Text = "Thời gian trả phòng";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Location = new System.Drawing.Point(116, 85);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(119, 25);
            this.label37.TabIndex = 2;
            this.label37.Text = "Thời gian giao phòng";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHD_ThanhTien
            // 
            this.txtHD_ThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHD_ThanhTien.Location = new System.Drawing.Point(241, 188);
            this.txtHD_ThanhTien.Name = "txtHD_ThanhTien";
            this.txtHD_ThanhTien.ReadOnly = true;
            this.txtHD_ThanhTien.Size = new System.Drawing.Size(221, 20);
            this.txtHD_ThanhTien.TabIndex = 16;
            // 
            // txtHD_TongChiPhi
            // 
            this.txtHD_TongChiPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHD_TongChiPhi.Location = new System.Drawing.Point(241, 163);
            this.txtHD_TongChiPhi.Name = "txtHD_TongChiPhi";
            this.txtHD_TongChiPhi.ReadOnly = true;
            this.txtHD_TongChiPhi.Size = new System.Drawing.Size(221, 20);
            this.txtHD_TongChiPhi.TabIndex = 15;
            // 
            // txtHD_TienPhong
            // 
            this.txtHD_TienPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHD_TienPhong.Location = new System.Drawing.Point(241, 138);
            this.txtHD_TienPhong.Name = "txtHD_TienPhong";
            this.txtHD_TienPhong.ReadOnly = true;
            this.txtHD_TienPhong.Size = new System.Drawing.Size(221, 20);
            this.txtHD_TienPhong.TabIndex = 14;
            // 
            // dtpHD_ThoiGianTraPhong
            // 
            this.dtpHD_ThoiGianTraPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpHD_ThoiGianTraPhong.Enabled = false;
            this.dtpHD_ThoiGianTraPhong.Location = new System.Drawing.Point(241, 113);
            this.dtpHD_ThoiGianTraPhong.Name = "dtpHD_ThoiGianTraPhong";
            this.dtpHD_ThoiGianTraPhong.Size = new System.Drawing.Size(221, 20);
            this.dtpHD_ThoiGianTraPhong.TabIndex = 10;
            // 
            // dtpHD_ThoiGianGiaoPhong
            // 
            this.dtpHD_ThoiGianGiaoPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpHD_ThoiGianGiaoPhong.Enabled = false;
            this.dtpHD_ThoiGianGiaoPhong.Location = new System.Drawing.Point(241, 88);
            this.dtpHD_ThoiGianGiaoPhong.Name = "dtpHD_ThoiGianGiaoPhong";
            this.dtpHD_ThoiGianGiaoPhong.Size = new System.Drawing.Size(221, 20);
            this.dtpHD_ThoiGianGiaoPhong.TabIndex = 9;
            // 
            // label36
            // 
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Location = new System.Drawing.Point(116, 60);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(119, 25);
            this.label36.TabIndex = 1;
            this.label36.Text = "CMND/CCCD";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHD_CMND_CCCD
            // 
            this.txtHD_CMND_CCCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHD_CMND_CCCD.Location = new System.Drawing.Point(241, 63);
            this.txtHD_CMND_CCCD.Name = "txtHD_CMND_CCCD";
            this.txtHD_CMND_CCCD.ReadOnly = true;
            this.txtHD_CMND_CCCD.Size = new System.Drawing.Size(221, 20);
            this.txtHD_CMND_CCCD.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(116, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(119, 25);
            this.label30.TabIndex = 17;
            this.label30.Text = "Mã Phòng";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHD_MaPhong
            // 
            this.txtHD_MaPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHD_MaPhong.Location = new System.Drawing.Point(241, 38);
            this.txtHD_MaPhong.Name = "txtHD_MaPhong";
            this.txtHD_MaPhong.ReadOnly = true;
            this.txtHD_MaPhong.Size = new System.Drawing.Size(221, 20);
            this.txtHD_MaPhong.TabIndex = 18;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dgvHD_TieuThuVT);
            this.groupBox10.Location = new System.Drawing.Point(595, 231);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(582, 207);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Chi tiết tiêu thụ vật tư";
            // 
            // dgvHD_TieuThuVT
            // 
            this.dgvHD_TieuThuVT.AllowUserToAddRows = false;
            this.dgvHD_TieuThuVT.AllowUserToDeleteRows = false;
            this.dgvHD_TieuThuVT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD_TieuThuVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD_TieuThuVT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn31,
            this.Column38,
            this.Column35});
            this.dgvHD_TieuThuVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHD_TieuThuVT.Location = new System.Drawing.Point(3, 16);
            this.dgvHD_TieuThuVT.MultiSelect = false;
            this.dgvHD_TieuThuVT.Name = "dgvHD_TieuThuVT";
            this.dgvHD_TieuThuVT.ReadOnly = true;
            this.dgvHD_TieuThuVT.RowHeadersVisible = false;
            this.dgvHD_TieuThuVT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD_TieuThuVT.Size = new System.Drawing.Size(576, 188);
            this.dgvHD_TieuThuVT.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TenVT";
            this.dataGridViewTextBoxColumn17.HeaderText = "Tên vật tư";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "ThoiGianTieuThu";
            this.dataGridViewTextBoxColumn31.HeaderText = "Thời gian tiêu thụ";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // Column38
            // 
            this.Column38.DataPropertyName = "SoLuong";
            this.Column38.HeaderText = "Số lượng tiêu thụ";
            this.Column38.Name = "Column38";
            this.Column38.ReadOnly = true;
            // 
            // Column35
            // 
            this.Column35.DataPropertyName = "MaHD";
            this.Column35.HeaderText = "MaHD";
            this.Column35.Name = "Column35";
            this.Column35.ReadOnly = true;
            this.Column35.Visible = false;
            // 
            // frmQuanLy_HoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel12);
            this.Name = "frmQuanLy_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel12.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD_SuDungDV)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD_HoaDon)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD_TieuThuVT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.DataGridView dgvHD_SuDungDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView dgvHD_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtHD_MaHD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtHD_ThanhTien;
        private System.Windows.Forms.TextBox txtHD_TongChiPhi;
        private System.Windows.Forms.TextBox txtHD_TienPhong;
        private System.Windows.Forms.DateTimePicker dtpHD_ThoiGianTraPhong;
        private System.Windows.Forms.DateTimePicker dtpHD_ThoiGianGiaoPhong;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtHD_CMND_CCCD;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtHD_MaPhong;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView dgvHD_TieuThuVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column38;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column35;
    }
}