namespace QL_Khach_San_Backend
{
    partial class frmQuanLy_DichVu
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
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.dgvDV_SuDungDV = new System.Windows.Forms.DataGridView();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.dgvDV_DichVu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label44 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txtDV_TenDV = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtDV_ChiPhi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel16.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV_SuDungDV)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV_DichVu)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.groupBox13, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.groupBox14, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.groupBox15, 1, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(1184, 761);
            this.tableLayoutPanel16.TabIndex = 2;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.dgvDV_SuDungDV);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(595, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(586, 374);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Thông tin sử dụng dịch vụ";
            // 
            // dgvDV_SuDungDV
            // 
            this.dgvDV_SuDungDV.AllowUserToAddRows = false;
            this.dgvDV_SuDungDV.AllowUserToDeleteRows = false;
            this.dgvDV_SuDungDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV_SuDungDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV_SuDungDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column36,
            this.Column32,
            this.Column33});
            this.dgvDV_SuDungDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDV_SuDungDV.Location = new System.Drawing.Point(3, 16);
            this.dgvDV_SuDungDV.MultiSelect = false;
            this.dgvDV_SuDungDV.Name = "dgvDV_SuDungDV";
            this.dgvDV_SuDungDV.ReadOnly = true;
            this.dgvDV_SuDungDV.RowHeadersVisible = false;
            this.dgvDV_SuDungDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV_SuDungDV.Size = new System.Drawing.Size(580, 355);
            this.dgvDV_SuDungDV.TabIndex = 1;
            // 
            // Column36
            // 
            this.Column36.DataPropertyName = "MaHD";
            this.Column36.HeaderText = "Mã hóa đơn";
            this.Column36.Name = "Column36";
            this.Column36.ReadOnly = true;
            // 
            // Column32
            // 
            this.Column32.DataPropertyName = "TenDV";
            this.Column32.HeaderText = "Tên dịch vụ";
            this.Column32.Name = "Column32";
            this.Column32.ReadOnly = true;
            this.Column32.Visible = false;
            // 
            // Column33
            // 
            this.Column33.DataPropertyName = "ThoiGianYeuCau";
            this.Column33.HeaderText = "Thời gian yêu cầu";
            this.Column33.Name = "Column33";
            this.Column33.ReadOnly = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.dgvDV_DichVu);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(3, 3);
            this.groupBox14.Name = "groupBox14";
            this.tableLayoutPanel16.SetRowSpan(this.groupBox14, 2);
            this.groupBox14.Size = new System.Drawing.Size(586, 755);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Danh sách dịch vụ";
            // 
            // dgvDV_DichVu
            // 
            this.dgvDV_DichVu.AllowUserToAddRows = false;
            this.dgvDV_DichVu.AllowUserToDeleteRows = false;
            this.dgvDV_DichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV_DichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvDV_DichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDV_DichVu.Location = new System.Drawing.Point(3, 16);
            this.dgvDV_DichVu.MultiSelect = false;
            this.dgvDV_DichVu.Name = "dgvDV_DichVu";
            this.dgvDV_DichVu.ReadOnly = true;
            this.dgvDV_DichVu.RowHeadersVisible = false;
            this.dgvDV_DichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV_DichVu.Size = new System.Drawing.Size(580, 736);
            this.dgvDV_DichVu.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TenDV";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tên dịch vụ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GiaDV";
            this.dataGridViewTextBoxColumn10.HeaderText = "Giá dịch vụ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.tableLayoutPanel18);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(595, 383);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(586, 375);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Thông tin dịch vụ";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 4;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel18.Controls.Add(this.label44, 1, 1);
            this.tableLayoutPanel18.Controls.Add(this.label47, 1, 2);
            this.tableLayoutPanel18.Controls.Add(this.txtDV_TenDV, 2, 1);
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel19, 1, 3);
            this.tableLayoutPanel18.Controls.Add(this.txtDV_ChiPhi, 2, 2);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 5;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(580, 356);
            this.tableLayoutPanel18.TabIndex = 0;
            // 
            // label44
            // 
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Location = new System.Drawing.Point(116, 123);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(119, 25);
            this.label44.TabIndex = 0;
            this.label44.Text = "Tên dịch vụ";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label47
            // 
            this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label47.Location = new System.Drawing.Point(116, 148);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(119, 25);
            this.label47.TabIndex = 3;
            this.label47.Text = "Chi phí";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDV_TenDV
            // 
            this.txtDV_TenDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDV_TenDV.Location = new System.Drawing.Point(241, 126);
            this.txtDV_TenDV.Name = "txtDV_TenDV";
            this.txtDV_TenDV.ReadOnly = true;
            this.txtDV_TenDV.Size = new System.Drawing.Size(221, 20);
            this.txtDV_TenDV.TabIndex = 4;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 5;
            this.tableLayoutPanel18.SetColumnSpan(this.tableLayoutPanel19, 2);
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel19.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.btnSua, 2, 0);
            this.tableLayoutPanel19.Controls.Add(this.btnXoa, 4, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(116, 176);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(346, 54);
            this.tableLayoutPanel19.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Ivory;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 48);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm dịch vụ";
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
            this.btnSua.Text = "Cập nhật dịch vụ";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Ivory;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(245, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 48);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa dịch vụ";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // txtDV_ChiPhi
            // 
            this.txtDV_ChiPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDV_ChiPhi.Location = new System.Drawing.Point(241, 151);
            this.txtDV_ChiPhi.Name = "txtDV_ChiPhi";
            this.txtDV_ChiPhi.ReadOnly = true;
            this.txtDV_ChiPhi.Size = new System.Drawing.Size(221, 20);
            this.txtDV_ChiPhi.TabIndex = 9;
            // 
            // frmQuanLy_DichVu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel16);
            this.Name = "frmQuanLy_DichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmQuanLy_DichVu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel16.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV_SuDungDV)).EndInit();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV_DichVu)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DataGridView dgvDV_SuDungDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column33;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.DataGridView dgvDV_DichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtDV_TenDV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtDV_ChiPhi;
    }
}