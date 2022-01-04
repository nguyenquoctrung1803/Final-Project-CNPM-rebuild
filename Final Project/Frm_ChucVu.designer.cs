
namespace Final_Project
{
    partial class Frm_ChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChucVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewCV = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLNV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLKH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLLK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLBH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLNCC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLLLK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLNK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QLBaoHanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ToanQ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThongKe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HoaDon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Setting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxThongKe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkBoxHoaDon = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkBoxNhapKho = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkBoxPhanQuyen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkBoxkH = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxBanHang = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkBoxNhanViem = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCV)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1579, 53);
            this.panel1.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1491, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewCV
            // 
            this.dataGridViewCV.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewCV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCV.ColumnHeadersHeight = 25;
            this.dataGridViewCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.QLNV,
            this.QLKH,
            this.QLLK,
            this.QLBH,
            this.QLNCC,
            this.QLLLK,
            this.QLNK,
            this.QLBaoHanh,
            this.ToanQ,
            this.ThongKe,
            this.HoaDon,
            this.Setting,
            this.TrangThai});
            this.dataGridViewCV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCV.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCV.Location = new System.Drawing.Point(16, 420);
            this.dataGridViewCV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCV.Name = "dataGridViewCV";
            this.dataGridViewCV.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCV.RowHeadersVisible = false;
            this.dataGridViewCV.RowHeadersWidth = 51;
            this.dataGridViewCV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCV.Size = new System.Drawing.Size(1547, 224);
            this.dataGridViewCV.TabIndex = 25;
            this.dataGridViewCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCV_CellClick);
            this.dataGridViewCV.DoubleClick += new System.EventHandler(this.dataGridViewCV_DoubleClick);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã chức vụ";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên chức vụ";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            // 
            // QLNV
            // 
            this.QLNV.DataPropertyName = "NhanVien";
            this.QLNV.HeaderText = "Nhân viên";
            this.QLNV.MinimumWidth = 6;
            this.QLNV.Name = "QLNV";
            this.QLNV.ReadOnly = true;
            this.QLNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QLNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QLKH
            // 
            this.QLKH.DataPropertyName = "KhachHang";
            this.QLKH.HeaderText = "Khách hàng";
            this.QLKH.MinimumWidth = 6;
            this.QLKH.Name = "QLKH";
            this.QLKH.ReadOnly = true;
            this.QLKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QLKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QLLK
            // 
            this.QLLK.DataPropertyName = "LinhKien";
            this.QLLK.HeaderText = "Linh kiện";
            this.QLLK.MinimumWidth = 6;
            this.QLLK.Name = "QLLK";
            this.QLLK.ReadOnly = true;
            this.QLLK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QLLK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QLBH
            // 
            this.QLBH.DataPropertyName = "BanHang";
            this.QLBH.HeaderText = "Bán hàng";
            this.QLBH.MinimumWidth = 6;
            this.QLBH.Name = "QLBH";
            this.QLBH.ReadOnly = true;
            // 
            // QLNCC
            // 
            this.QLNCC.DataPropertyName = "NhaCungCap";
            this.QLNCC.HeaderText = "Nhà cung cấp";
            this.QLNCC.MinimumWidth = 6;
            this.QLNCC.Name = "QLNCC";
            this.QLNCC.ReadOnly = true;
            this.QLNCC.Visible = false;
            // 
            // QLLLK
            // 
            this.QLLLK.DataPropertyName = "LoaiLK";
            this.QLLLK.HeaderText = "Loại linh kiện";
            this.QLLLK.MinimumWidth = 6;
            this.QLLLK.Name = "QLLLK";
            this.QLLLK.ReadOnly = true;
            this.QLLLK.Visible = false;
            // 
            // QLNK
            // 
            this.QLNK.DataPropertyName = "NhapKho";
            this.QLNK.HeaderText = "Hóa Đơn Nhập";
            this.QLNK.MinimumWidth = 6;
            this.QLNK.Name = "QLNK";
            this.QLNK.ReadOnly = true;
            this.QLNK.Visible = false;
            // 
            // QLBaoHanh
            // 
            this.QLBaoHanh.DataPropertyName = "BaoHanh";
            this.QLBaoHanh.HeaderText = "Bảo Hành";
            this.QLBaoHanh.MinimumWidth = 6;
            this.QLBaoHanh.Name = "QLBaoHanh";
            this.QLBaoHanh.ReadOnly = true;
            this.QLBaoHanh.Visible = false;
            // 
            // ToanQ
            // 
            this.ToanQ.DataPropertyName = "PhanQuyen";
            this.ToanQ.HeaderText = "Phân Quyền";
            this.ToanQ.MinimumWidth = 6;
            this.ToanQ.Name = "ToanQ";
            this.ToanQ.ReadOnly = true;
            this.ToanQ.Visible = false;
            // 
            // ThongKe
            // 
            this.ThongKe.DataPropertyName = "ThongKe";
            this.ThongKe.HeaderText = "Thống Kê";
            this.ThongKe.MinimumWidth = 6;
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.ReadOnly = true;
            this.ThongKe.Visible = false;
            // 
            // HoaDon
            // 
            this.HoaDon.DataPropertyName = "HoaDon";
            this.HoaDon.HeaderText = "Hóa Đơn";
            this.HoaDon.MinimumWidth = 6;
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.ReadOnly = true;
            this.HoaDon.Visible = false;
            // 
            // Setting
            // 
            this.Setting.DataPropertyName = "Setting";
            this.Setting.HeaderText = "Setting";
            this.Setting.MinimumWidth = 6;
            this.Setting.Name = "Setting";
            this.Setting.ReadOnly = true;
            this.Setting.Visible = false;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TrangThai.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Location = new System.Drawing.Point(425, 326);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 72);
            this.panel3.TabIndex = 31;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(500, 11);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 49);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(113, 11);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 49);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Cấp Quyền";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtTenCV);
            this.groupBox1.Controls.Add(this.txtMaCV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(351, 224);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Vụ";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.Location = new System.Drawing.Point(17, 172);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCV.Multiline = true;
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(308, 35);
            this.txtTenCV.TabIndex = 4;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.Location = new System.Drawing.Point(17, 81);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCV.Multiline = true;
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(308, 35);
            this.txtMaCV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã chức vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBoxThongKe);
            this.groupBox2.Controls.Add(this.checkBoxHoaDon);
            this.groupBox2.Controls.Add(this.checkBoxNhapKho);
            this.groupBox2.Controls.Add(this.checkBoxPhanQuyen);
            this.groupBox2.Controls.Add(this.checkBoxkH);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxBanHang);
            this.groupBox2.Controls.Add(this.checkBoxNhanViem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(375, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1187, 224);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Bán hàng";
            // 
            // checkBoxThongKe
            // 
            this.checkBoxThongKe.BackColor = System.Drawing.Color.SeaGreen;
            this.checkBoxThongKe.ChechedOffColor = System.Drawing.Color.SeaGreen;
            this.checkBoxThongKe.Checked = false;
            this.checkBoxThongKe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBoxThongKe.ForeColor = System.Drawing.Color.White;
            this.checkBoxThongKe.Location = new System.Drawing.Point(316, 110);
            this.checkBoxThongKe.Margin = new System.Windows.Forms.Padding(43, 68, 43, 68);
            this.checkBoxThongKe.Name = "checkBoxThongKe";
            this.checkBoxThongKe.Size = new System.Drawing.Size(20, 20);
            this.checkBoxThongKe.TabIndex = 32;
            // 
            // checkBoxHoaDon
            // 
            this.checkBoxHoaDon.BackColor = System.Drawing.Color.SeaGreen;
            this.checkBoxHoaDon.ChechedOffColor = System.Drawing.Color.SeaGreen;
            this.checkBoxHoaDon.Checked = false;
            this.checkBoxHoaDon.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBoxHoaDon.ForeColor = System.Drawing.Color.White;
            this.checkBoxHoaDon.Location = new System.Drawing.Point(33, 172);
            this.checkBoxHoaDon.Margin = new System.Windows.Forms.Padding(96, 177, 96, 177);
            this.checkBoxHoaDon.Name = "checkBoxHoaDon";
            this.checkBoxHoaDon.Size = new System.Drawing.Size(20, 20);
            this.checkBoxHoaDon.TabIndex = 32;
            // 
            // checkBoxNhapKho
            // 
            this.checkBoxNhapKho.BackColor = System.Drawing.Color.SeaGreen;
            this.checkBoxNhapKho.ChechedOffColor = System.Drawing.Color.SeaGreen;
            this.checkBoxNhapKho.Checked = false;
            this.checkBoxNhapKho.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBoxNhapKho.ForeColor = System.Drawing.Color.White;
            this.checkBoxNhapKho.Location = new System.Drawing.Point(714, 108);
            this.checkBoxNhapKho.Margin = new System.Windows.Forms.Padding(64, 110, 64, 110);
            this.checkBoxNhapKho.Name = "checkBoxNhapKho";
            this.checkBoxNhapKho.Size = new System.Drawing.Size(20, 20);
            this.checkBoxNhapKho.TabIndex = 32;
            // 
            // checkBoxPhanQuyen
            // 
            this.checkBoxPhanQuyen.BackColor = System.Drawing.Color.SeaGreen;
            this.checkBoxPhanQuyen.ChechedOffColor = System.Drawing.Color.SeaGreen;
            this.checkBoxPhanQuyen.Checked = false;
            this.checkBoxPhanQuyen.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBoxPhanQuyen.ForeColor = System.Drawing.Color.White;
            this.checkBoxPhanQuyen.Location = new System.Drawing.Point(714, 42);
            this.checkBoxPhanQuyen.Margin = new System.Windows.Forms.Padding(43, 68, 43, 68);
            this.checkBoxPhanQuyen.Name = "checkBoxPhanQuyen";
            this.checkBoxPhanQuyen.Size = new System.Drawing.Size(20, 20);
            this.checkBoxPhanQuyen.TabIndex = 32;
            // 
            // checkBoxkH
            // 
            this.checkBoxkH.BackColor = System.Drawing.Color.SeaGreen;
            this.checkBoxkH.ChechedOffColor = System.Drawing.Color.SeaGreen;
            this.checkBoxkH.Checked = false;
            this.checkBoxkH.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBoxkH.ForeColor = System.Drawing.Color.White;
            this.checkBoxkH.Location = new System.Drawing.Point(316, 34);
            this.checkBoxkH.Margin = new System.Windows.Forms.Padding(19, 26, 19, 26);
            this.checkBoxkH.Name = "checkBoxkH";
            this.checkBoxkH.Size = new System.Drawing.Size(20, 20);
            this.checkBoxkH.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 28);
            this.label8.TabIndex = 33;
            this.label8.Text = "Thống kê\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 28);
            this.label12.TabIndex = 33;
            this.label12.Text = "Quản lý hóa đơn bán";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(781, 105);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 28);
            this.label14.TabIndex = 33;
            this.label14.Text = "Nhập hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(781, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 28);
            this.label13.TabIndex = 33;
            this.label13.Text = "Phân quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quản lý khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Quản lý nhân viên";
            // 
            // checkBoxBanHang
            // 
            this.checkBoxBanHang.BackColor = System.Drawing.Color.SeaGreen;
            this.checkBoxBanHang.ChechedOffColor = System.Drawing.Color.SeaGreen;
            this.checkBoxBanHang.Checked = false;
            this.checkBoxBanHang.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBoxBanHang.ForeColor = System.Drawing.Color.White;
            this.checkBoxBanHang.Location = new System.Drawing.Point(33, 105);
            this.checkBoxBanHang.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.checkBoxBanHang.Name = "checkBoxBanHang";
            this.checkBoxBanHang.Size = new System.Drawing.Size(20, 20);
            this.checkBoxBanHang.TabIndex = 32;
            // 
            // checkBoxNhanViem
            // 
            this.checkBoxNhanViem.BackColor = System.Drawing.Color.SeaGreen;
            this.checkBoxNhanViem.ChechedOffColor = System.Drawing.Color.SeaGreen;
            this.checkBoxNhanViem.Checked = false;
            this.checkBoxNhanViem.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBoxNhanViem.ForeColor = System.Drawing.Color.White;
            this.checkBoxNhanViem.Location = new System.Drawing.Point(33, 37);
            this.checkBoxNhanViem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBoxNhanViem.Name = "checkBoxNhanViem";
            this.checkBoxNhanViem.Size = new System.Drawing.Size(20, 20);
            this.checkBoxNhanViem.TabIndex = 32;
            // 
            // Frm_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1579, 875);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewCV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ChucVu";
            this.Text = "Frm_PhanQuyen";
            this.Load += new System.EventHandler(this.Frm_ChucVu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxNhanViem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxBanHang;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxThongKe;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxkH;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxHoaDon;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxNhapKho;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxPhanQuyen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLNV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLKH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLLK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLBH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLNCC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLLLK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLNK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QLBaoHanh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ToanQ;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ThongKe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HoaDon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Setting;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}