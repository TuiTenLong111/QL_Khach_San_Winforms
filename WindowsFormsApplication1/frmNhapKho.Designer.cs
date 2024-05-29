namespace QL_Khach_San_Backend
{
    partial class frmNhapKho
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
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvVatTu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtVT_SoLuong = new System.Windows.Forms.TextBox();
            this.txtVT_DonGia = new System.Windows.Forms.TextBox();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnVT_HienThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThoiGianNhap = new System.Windows.Forms.DateTimePicker();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.tableLayoutPanel17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).BeginInit();
            this.groupBox18.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Controls.Add(this.groupBox16, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.groupBox17, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.groupBox18, 1, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(1184, 761);
            this.tableLayoutPanel17.TabIndex = 3;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.dgvNhapKho);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Location = new System.Drawing.Point(595, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(586, 374);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Lịch sử nhập kho";
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.AllowUserToAddRows = false;
            this.dgvNhapKho.AllowUserToDeleteRows = false;
            this.dgvNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column6,
            this.Column4});
            this.dgvNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapKho.Location = new System.Drawing.Point(3, 16);
            this.dgvNhapKho.MultiSelect = false;
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.ReadOnly = true;
            this.dgvNhapKho.RowHeadersVisible = false;
            this.dgvNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapKho.Size = new System.Drawing.Size(580, 355);
            this.dgvNhapKho.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaNK";
            this.Column9.FillWeight = 35F;
            this.Column9.HeaderText = "Mã nhập kho";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenVT";
            this.Column1.HeaderText = "Tên vật tư";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaNV";
            this.Column7.HeaderText = "Mã nhân viên";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Nhân viên thực hiện";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ThoiGianNhap";
            this.Column8.HeaderText = "Thời gian nhập";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.FillWeight = 35F;
            this.Column3.HeaderText = "Số lượng nhập";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DonViTinh";
            this.Column6.FillWeight = 35F;
            this.Column6.HeaderText = "Đơn vị";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGiaNhap";
            this.Column4.FillWeight = 35F;
            this.Column4.HeaderText = "Đơn giá nhập";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.dgvVatTu);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Location = new System.Drawing.Point(3, 3);
            this.groupBox17.Name = "groupBox17";
            this.tableLayoutPanel17.SetRowSpan(this.groupBox17, 2);
            this.groupBox17.Size = new System.Drawing.Size(586, 755);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Danh sách vật tư";
            // 
            // dgvVatTu
            // 
            this.dgvVatTu.AllowUserToAddRows = false;
            this.dgvVatTu.AllowUserToDeleteRows = false;
            this.dgvVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.Column5,
            this.dataGridViewTextBoxColumn16});
            this.dgvVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVatTu.Location = new System.Drawing.Point(3, 16);
            this.dgvVatTu.MultiSelect = false;
            this.dgvVatTu.Name = "dgvVatTu";
            this.dgvVatTu.ReadOnly = true;
            this.dgvVatTu.RowHeadersVisible = false;
            this.dgvVatTu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVatTu.Size = new System.Drawing.Size(580, 736);
            this.dgvVatTu.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TenVT";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tên vật tư";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "NguonGoc";
            this.dataGridViewTextBoxColumn14.FillWeight = 75F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Nguồn gốc";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn15.FillWeight = 35F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonViTinh";
            this.Column5.FillWeight = 35F;
            this.Column5.HeaderText = "Đơn vị ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn16.FillWeight = 35F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.tableLayoutPanel20);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox18.Location = new System.Drawing.Point(595, 383);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(586, 375);
            this.groupBox18.TabIndex = 3;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Thông tin vật tư";
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 4;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel20.Controls.Add(this.label39, 1, 1);
            this.tableLayoutPanel20.Controls.Add(this.label40, 1, 2);
            this.tableLayoutPanel20.Controls.Add(this.label41, 1, 3);
            this.tableLayoutPanel20.Controls.Add(this.label42, 1, 4);
            this.tableLayoutPanel20.Controls.Add(this.txtVT_SoLuong, 2, 3);
            this.tableLayoutPanel20.Controls.Add(this.txtVT_DonGia, 2, 4);
            this.tableLayoutPanel20.Controls.Add(this.cbxNhanVien, 2, 2);
            this.tableLayoutPanel20.Controls.Add(this.txtTenVT, 2, 1);
            this.tableLayoutPanel20.Controls.Add(this.tableLayoutPanel21, 1, 6);
            this.tableLayoutPanel20.Controls.Add(this.label1, 1, 5);
            this.tableLayoutPanel20.Controls.Add(this.dtpThoiGianNhap, 2, 5);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 8;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(580, 356);
            this.tableLayoutPanel20.TabIndex = 0;
            // 
            // label39
            // 
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Location = new System.Drawing.Point(116, 85);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(119, 25);
            this.label39.TabIndex = 0;
            this.label39.Text = "Tên vật tư";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Location = new System.Drawing.Point(116, 110);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(119, 25);
            this.label40.TabIndex = 1;
            this.label40.Text = "Nhân viên thực hiện";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label41
            // 
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Location = new System.Drawing.Point(116, 135);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(119, 25);
            this.label41.TabIndex = 2;
            this.label41.Text = "Số lượng";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label42
            // 
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.Location = new System.Drawing.Point(116, 160);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(119, 25);
            this.label42.TabIndex = 3;
            this.label42.Text = "Đơn giá nhập";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVT_SoLuong
            // 
            this.txtVT_SoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVT_SoLuong.Location = new System.Drawing.Point(241, 138);
            this.txtVT_SoLuong.Name = "txtVT_SoLuong";
            this.txtVT_SoLuong.ReadOnly = true;
            this.txtVT_SoLuong.Size = new System.Drawing.Size(221, 20);
            this.txtVT_SoLuong.TabIndex = 6;
            // 
            // txtVT_DonGia
            // 
            this.txtVT_DonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVT_DonGia.Location = new System.Drawing.Point(241, 163);
            this.txtVT_DonGia.Name = "txtVT_DonGia";
            this.txtVT_DonGia.ReadOnly = true;
            this.txtVT_DonGia.Size = new System.Drawing.Size(221, 20);
            this.txtVT_DonGia.TabIndex = 9;
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxNhanVien.Enabled = false;
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(241, 113);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(221, 21);
            this.cbxNhanVien.TabIndex = 11;
            // 
            // txtTenVT
            // 
            this.txtTenVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenVT.Location = new System.Drawing.Point(241, 88);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.ReadOnly = true;
            this.txtTenVT.Size = new System.Drawing.Size(221, 20);
            this.txtTenVT.TabIndex = 12;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 5;
            this.tableLayoutPanel20.SetColumnSpan(this.tableLayoutPanel21, 2);
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel21.Controls.Add(this.btnQuayLai, 4, 0);
            this.tableLayoutPanel21.Controls.Add(this.btnNhapKho, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.btnVT_HienThi, 2, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(116, 213);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(346, 54);
            this.tableLayoutPanel21.TabIndex = 13;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.Color.Ivory;
            this.btnNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Location = new System.Drawing.Point(3, 3);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(97, 48);
            this.btnNhapKho.TabIndex = 0;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            // 
            // btnVT_HienThi
            // 
            this.btnVT_HienThi.BackColor = System.Drawing.Color.Ivory;
            this.btnVT_HienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVT_HienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVT_HienThi.Location = new System.Drawing.Point(123, 3);
            this.btnVT_HienThi.Name = "btnVT_HienThi";
            this.btnVT_HienThi.Size = new System.Drawing.Size(97, 48);
            this.btnVT_HienThi.TabIndex = 2;
            this.btnVT_HienThi.Text = "Hiển thị toàn bộ danh sách";
            this.btnVT_HienThi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(116, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thời gian nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpThoiGianNhap
            // 
            this.dtpThoiGianNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpThoiGianNhap.Location = new System.Drawing.Point(241, 188);
            this.dtpThoiGianNhap.Name = "dtpThoiGianNhap";
            this.dtpThoiGianNhap.Size = new System.Drawing.Size(221, 20);
            this.dtpThoiGianNhap.TabIndex = 15;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Ivory;
            this.btnQuayLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Location = new System.Drawing.Point(243, 3);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(100, 48);
            this.btnQuayLai.TabIndex = 16;
            this.btnQuayLai.Text = "Quay lại màn hình vật tư";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // frmNhapKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel17);
            this.Name = "frmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel17.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.DataGridView dgvNhapKho;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.DataGridView dgvVatTu;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtVT_SoLuong;
        private System.Windows.Forms.TextBox txtVT_DonGia;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGianNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnVT_HienThi;
        private System.Windows.Forms.Button btnQuayLai;
    }
}