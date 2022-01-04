namespace Final_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBot = new System.Windows.Forms.Panel();
            this.labeldateTime = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnThuNho = new System.Windows.Forms.Button();
            this.labelHienThiTenDangNhap = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbl_HienThiForm = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPhanQuyen = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBot.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(305, 62);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1066, 605);
            this.panelChildForm.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.labeldateTime);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(305, 667);
            this.panelBot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1066, 55);
            this.panelBot.TabIndex = 24;
            // 
            // labeldateTime
            // 
            this.labeldateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldateTime.ForeColor = System.Drawing.Color.White;
            this.labeldateTime.Location = new System.Drawing.Point(628, 7);
            this.labeldateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldateTime.Name = "labeldateTime";
            this.labeldateTime.Size = new System.Drawing.Size(423, 41);
            this.labeldateTime.TabIndex = 1;
            this.labeldateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnThuNho);
            this.panelTop.Controls.Add(this.labelHienThiTenDangNhap);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.lbl_HienThiForm);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(305, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1066, 62);
            this.panelTop.TabIndex = 23;
            // 
            // btnThuNho
            // 
            this.btnThuNho.FlatAppearance.BorderSize = 0;
            this.btnThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuNho.Image = ((System.Drawing.Image)(resources.GetObject("btnThuNho.Image")));
            this.btnThuNho.Location = new System.Drawing.Point(8, 7);
            this.btnThuNho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(68, 43);
            this.btnThuNho.TabIndex = 5;
            this.btnThuNho.UseVisualStyleBackColor = false;
            this.btnThuNho.Click += new System.EventHandler(this.iconBtnThuNho_Click);
            // 
            // labelHienThiTenDangNhap
            // 
            this.labelHienThiTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHienThiTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelHienThiTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHienThiTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.labelHienThiTenDangNhap.Location = new System.Drawing.Point(802, 7);
            this.labelHienThiTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHienThiTenDangNhap.Name = "labelHienThiTenDangNhap";
            this.labelHienThiTenDangNhap.Size = new System.Drawing.Size(188, 43);
            this.labelHienThiTenDangNhap.TabIndex = 4;
            this.labelHienThiTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1012, 7);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(51, 43);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbl_HienThiForm
            // 
            this.lbl_HienThiForm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HienThiForm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HienThiForm.ForeColor = System.Drawing.Color.Black;
            this.lbl_HienThiForm.Location = new System.Drawing.Point(116, 11);
            this.lbl_HienThiForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HienThiForm.Name = "lbl_HienThiForm";
            this.lbl_HienThiForm.Size = new System.Drawing.Size(393, 34);
            this.lbl_HienThiForm.TabIndex = 0;
            this.lbl_HienThiForm.Text = "\r\nHome";
            this.lbl_HienThiForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.Controls.Add(this.btnProfile);
            this.panelSideMenu.Controls.Add(this.btnPhanQuyen);
            this.panelSideMenu.Controls.Add(this.btnThongKe);
            this.panelSideMenu.Controls.Add(this.btnBanHang);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnPhieuNhap);
            this.panelSideMenu.Controls.Add(this.btnHoaDon);
            this.panelSideMenu.Controls.Add(this.btnKhachHang);
            this.panelSideMenu.Controls.Add(this.btnNhanVien);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(305, 722);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 504);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(305, 57);
            this.btnProfile.TabIndex = 18;
            this.btnProfile.Text = "Thông tin cá nhân";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanQuyen.FlatAppearance.BorderSize = 0;
            this.btnPhanQuyen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPhanQuyen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPhanQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanQuyen.ForeColor = System.Drawing.Color.Black;
            this.btnPhanQuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.Image")));
            this.btnPhanQuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanQuyen.Location = new System.Drawing.Point(0, 447);
            this.btnPhanQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnPhanQuyen.Size = new System.Drawing.Size(305, 57);
            this.btnPhanQuyen.TabIndex = 17;
            this.btnPhanQuyen.Text = "Phân quyền";
            this.btnPhanQuyen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhanQuyen.UseVisualStyleBackColor = false;
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click_1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 390);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(305, 57);
            this.btnThongKe.TabIndex = 16;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click_1);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnBanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.ForeColor = System.Drawing.Color.Black;
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(0, 333);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnBanHang.Size = new System.Drawing.Size(305, 57);
            this.btnBanHang.TabIndex = 14;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 667);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(305, 55);
            this.btnExit.TabIndex = 12;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnPhieuNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPhieuNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.btnPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuNhap.Image")));
            this.btnPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuNhap.Location = new System.Drawing.Point(0, 278);
            this.btnPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnPhieuNhap.Size = new System.Drawing.Size(305, 55);
            this.btnPhieuNhap.TabIndex = 2;
            this.btnPhieuNhap.Text = "Nhập hàng";
            this.btnPhieuNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhieuNhap.UseVisualStyleBackColor = false;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 223);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(305, 55);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Quản lý hóa đơn bán";
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 168);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(305, 55);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Quản lý khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 113);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(305, 55);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(305, 113);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1371, 722);
            this.ControlBox = false;
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1257, 704);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBot.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Label labelHienThiTenDangNhap;
        public System.Windows.Forms.Button btnNhanVien;
        public System.Windows.Forms.Button btnHoaDon;
        public System.Windows.Forms.Button btnKhachHang;
        public System.Windows.Forms.Button btnPhieuNhap;
        public System.Windows.Forms.Button btnBanHang;
        public System.Windows.Forms.Button btnProfile;
        public System.Windows.Forms.Button btnPhanQuyen;
        public System.Windows.Forms.Button btnThongKe;
        public System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panelBot;
        public System.Windows.Forms.Panel panelSideMenu;
        public System.Windows.Forms.Label labeldateTime;
        public System.Windows.Forms.Label lbl_HienThiForm;
        private System.Windows.Forms.Button btnThuNho;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

