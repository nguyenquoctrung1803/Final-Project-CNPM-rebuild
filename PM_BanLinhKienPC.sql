Drop database PM_BanLinhKienPC
Create database PM_BanLinhKienPC
USE [PM_BanLinhKienPC]
GO

/****** Object:  Table [dbo].[ChucVu]   *******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [nvarchar](50) NOT NULL,
	[TenCV] [nvarchar](50) NOT NULL,
	[NhanVien] [bit] NULL,
	[KhachHang] [bit] NULL,
	[LinhKien] [bit] NULL,
	[BanHang] [bit] NULL,
	[NhaCungCap] [bit] NULL,
	[LoaiLK] [bit] NULL,
	[NhapKho] [bit] NULL,
	[BaoHanh] [bit] NULL,
	[PhanQuyen] [bit] NULL,
	[ThongKe] [bit] NULL,
	[HoaDon] [bit] NULL,
	[Setting] [bit] NULL,
	[TrangThai] [nchar](10) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[CT_HoaDonBanHang]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HoaDonBanHang](
	[MaHDBH] [nvarchar](50) NOT NULL,
	[MaLK] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [decimal](28, 0) NULL,
	[KhuyenMai] [decimal](28, 0) NULL,
	[ThanhTien] [decimal](28, 0) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[TrangThaiTToan] [nvarchar](50) NULL,
	[TrangThaiVChuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_CT_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[MaHDBH] ASC,
	[MaLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[CT_HoaDonNhapHang]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HoaDonNhapHang](
	[MaHDNH] [nvarchar](50) NOT NULL,
	[MaLK] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [decimal](28, 0) NULL,
	[KhuyenMai] [decimal](28, 0) NULL,
	[ThanhTien] [decimal](28, 0) NULL,
	[TrangThai] [nchar](10) NULL,
 CONSTRAINT [PK_CT_HoaDonNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaHDNH] ASC,
	[MaLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[HoaDonBanHang] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[MaHDBH] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[NgayLapHDBH] [datetime] NULL,
	[TongTien] [decimal](28, 0) NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[MaHDBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[HoaDonNhapHang] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhapHang](
	[MaHDNH] [nvarchar](50) NOT NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[NgayLapHDNH] [datetime] NULL,
	[TongTien] [decimal](28, 0) NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HoaDonNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaHDNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[KhachHang]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[DienThoai] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[LinhKien]    Script Date: 11/17/2021 9:31:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LinhKien](
	[MaLK] [nvarchar](50) NOT NULL,
	[MaLLK] [nvarchar](50) NOT NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenLK] [nvarchar](max) NULL,
	[BaoHanh] [nvarchar](50) NOT NULL,
	[XuatXu] [nvarchar](50) NULL,
	[TinhTrang] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](50) NOT NULL,
	[DonGia] [int] NULL,
	[SoLuongTon] [int] NOT NULL,
	[KhuyenMai] [int] NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LinhKien] PRIMARY KEY CLUSTERED 
(
	[MaLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

/****** Object:  Table [dbo].[LoaiLinhKien]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiLinhKien](
	[MaLLK] [nvarchar](50) NOT NULL,
	[TenLLK] [nvarchar](50) NOT NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiLinhKien] PRIMARY KEY CLUSTERED 
(
	[MaLLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[NhaCungCap]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[NhaSanXuat]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNSX] [nvarchar](50) NOT NULL,
	[TenNSX] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[NhanVien]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[MaCV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NULL,
	[DienThoai] [nvarchar](50) NULL,
	[CMND] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[UserName] [nvarchar](50) NULL,
	[PassWord] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


// Data

INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [NhanVien], [KhachHang], [LinhKien], [BanHang], [NhaCungCap], [LoaiLK], [NhapKho], [BaoHanh], [PhanQuyen], [ThongKe], [HoaDon], [Setting], [TrangThai]) VALUES (N'CV01', N'Nhân Viên Quản Trị', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, N'True      ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [NhanVien], [KhachHang], [LinhKien], [BanHang], [NhaCungCap], [LoaiLK], [NhapKho], [BaoHanh], [PhanQuyen], [ThongKe], [HoaDon], [Setting], [TrangThai]) VALUES (N'CV02', N'Kế Toán', 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, N'1         ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [NhanVien], [KhachHang], [LinhKien], [BanHang], [NhaCungCap], [LoaiLK], [NhapKho], [BaoHanh], [PhanQuyen], [ThongKe], [HoaDon], [Setting], [TrangThai]) VALUES (N'CV03', N'Nhân Viên Kỹ Thuật', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, N'1         ')

INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK00', N'LLK12', N'NCC00', N'Nguồn máy tính Antec Atom B550', N'24 Tháng', N'Thái Lan', N'Mới', N'Cái', 1500000, 50, 0, N'atom-b550.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK01', N'LLK03', N'NCC00', N'RAM Corsair Vengeance LPX 8GB DDR4 DRAM 2666MHz', N'24 Tháng', N'Thái Lan', N'Mới', N'Cái', 1000000, 30, 0, N'ram-corsair-vengeance-lpx-16gb-ddr4-2666mhz-c16-black.png', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK02', N'LLK03', N'NCC00', N'Ram Kingston 16GB DDR4 ECC REG', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 2500000, 30, 0, N'ram-kingston.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK03', N'LLK03', N'NCC00', N'Ram Gigabyte AORUS RGB 16GB (2x8GB) DDR4 3200Mhz', N'24 Tháng', N'Việt Nam', N'Mới', N'Cái', 2200000, 30, 0, N'ram-aorus-16gb.png', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK04', N'LLK03', N'NCC00', N'RAM KINGSTON HyperX FURY 16GB DDR4 Bus 3200', N'24 Tháng', N'Việt Nam', N'Mới', N'Cái', 2300000, 30, 0, N'ram-kingston-16gb.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK05', N'LLK12', N'NCC00', N'Nguồn máy tính Cooler Master MWE Gold 750 V2 Ful', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 1800000, 30, 0, N'mwe-gold-750-v2-full-modular.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK06', N'LLK10', N'NCC00', N'Vỏ Case Cooler Master Master Case MC600P (ATX-Mid Tower / Màu Đen)', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái ', 700000, 30, 0, N'vo-case-cooler-master-master-case-mc600p-7.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK07', N'LLK10', N'NCC00', N'Vỏ case Xigmatek VENTUS 3FC', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 800000, 30, 0, N'ventus-3fc.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK08', N'LLK10', N'NCC00', N'Vỏ Case XIGMATEK GAMING X 3FX', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 1000000, 30, 0, N'ventus-3fc.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK09', N'LLK10', N'NCC00', N'Vỏ Case SAMA W03', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 1100000, 30, 0, N'51309-vo-case-sama-w03-0002-1-1-.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK10', N'LLK00', N'NCC00', N'CHUỘT LOGITECH B100', N'24 Tháng', N'Việt Nam', N'Mới', N'Cái', 150000, 30, 0, N'6848-chu-t-logitech-b100-usb-1.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK11', N'LLK00', N'NCC00', N'Chuột DAREU LM130', N'24 Tháng', N'Việt Nam', N'Mới', N'Cái', 250000, 26, 0, N'chuot-dareu-lm130-multi-led-usb-01.png', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK12', N'LLK00', N'NCC00', N'Chuột Logitech G102', N'24 Tháng', N'Việt Nam', N'Mới', N'Cái', 400000, 28, 0, N'g102.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK13', N'LLK00', N'NCC00', N'Chuột Corsair Harpoon Pro RGB', N'24 Tháng', N'Việt Nam', N'Mới', N'Cái', 600000, 29, 0, N'1-1-.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK14', N'LLK01', N'NCC00', N'Bàn phím DareU LK135', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 250000, 29, 0, N'ban-phim-dareu-lk135-2.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK15', N'LLK01', N'NCC00', N'Bàn phím cơ DareU EK1280 RGB Red switch', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 550000, 30, 0, N'26619.png', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK16', N'LLK01', N'NCC00', N'Bàn phím cơ DareU DK880 RGB Blue switch', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 700000, 18, 0, N'dk880.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK17', N'LLK04', N'NCC00', N'Màn hình Asus ProArt PA248QV', N'24 Tháng', N'Thái Lan', N'Mới', N'Cái', 5000000, 20, 0, N'man-hinh-asus-proart-pa248qv-01.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK18', N'LLK04', N'NCC00', N'Màn hình ViewSonic VX2776-SH 27 inch FHD', N'24 Tháng', N'Thái Lan', N'Mới ', N'Cái', 7000000, 20, 0, N'52120-viewsonic-vx2776-sh-gaming-7-.png', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK19', N'LLK13', N'NCC00', N'CARD MÀN HÌNH ASUS GT710-SL-2GD5 (2GB GDDR5, 64-BIT, DVI+HDMI)', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 2000000, 30, 0, N'250_51573_asus_gt710_sl_2gd5_001.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK20', N'LLK13', N'NCC00', N'CARD MÀN HÌNH INNO3D GT 710 1GB (1GB GDDR3, 64-BIT, DVI +HDMI)', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 2500000, 30, 0, N'250_54389_inno3d_geforce_gt_710_1gb_ddr3_lp.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK21', N'LLK13', N'NCC00', N'CARD MÀN HÌNH ASUS DUAL RADEON RX 6600 8GB', N'24 Tháng', N'Thái Lan', N'Mới', N'Cái', 3000000, 30, 0, N'250_61050_card_man_hinh_asus_dual_radeon_rx_6600_8gb_1.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK22', N'LLK06', N'NCC00', N'Ổ CỨNG HDD SEAGATE SKYHAWK 2TB 3.5 INCH, 5900RPM, SATA3, 64MB CACHE (ST2000VX008)', N'24 Tháng', N'Thái Lan', N'Mới', N'Cái', 400000, 30, 0, N'250_35130_hdd_seagate_skyhawk_surveillance_2tb.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK23', N'LLK06', N'NCC00', N'Ổ CỨNG HDD WD 1TB BLUE 3.5 INCH, 7200RPM, SATA3, 64MB CACHE (WD10EZEX)', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 300000, 30, 0, N'250_50317_hdd_western_caviar_blue_1tb_7200rpm_sata3_6gbs_64mb_cache_01.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK24', N'LLK06', N'NCC00', N'Ổ CỨNG HDD WD 2TB BLUE 3.5 INCH, 5400RPM, SATA3, 256MB CACHE', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 450000, 30, 0, N'250_32085_21047_western_digital_wd20ezrz_2gb_blue_02.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK25', N'LLK06', N'NCC00', N'Ổ CỨNG HDD TOSHIBA 500GB 3.5 INCH 7200RPM, SATA3 6GB/S, 32MB CACHE', N'24 Tháng', N'Trung Quốc', N'Mới ', N'Cái', 160000, 30, 0, N'250_29617_____c___ng_hdd_toshiba_500gb_.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK26', N'LLK06', N'NCC00', N'Ổ CỨNG HDD TOSHIBA AV S300 2TB 3.5 INCH, 5400RPM, SATA3, 128MB CACHE (HDWT720UZSVA)', N'24 Tháng', N'Trung Quốc', N'Mới ', N'Cái', 500000, 30, 0, N'250_55666_o_cung_toshiba_av_s300_2tb_3_5_inch_5400rpm_sata_3_6gb_s_128mb_cache_hdwt720uzsva_01.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK27', N'LLK05', N'NCC00', N'MAINBOARD ASUS PRIME H410M-D (INTEL H410, SOCKET 1200, M-ATX, 2 KHE RAM DDR4)', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 1550000, 30, 0, N'250_52873_prime_h410m_d_1.png', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK28', N'LLK05', N'NCC00', N'MAINBOARD GIGABYTE H410M H-V2', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 2000000, 30, 0, N'250_58857_mainboard_gigabyte_h410m_h_v2_1.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK29', N'LLK01', N'NCC00', N'CPU INTEL PENTIUM GOLD G6400 (4.0GHZ, 2 NHÂN 4 LUỒNG, 4MB CACHE, 58W) - SOCKET INTEL LGA', N'24 Tháng', N'Thái Lan', N'Mới', N'Cái', 1900000, 30, 0, N'250_52618_intel_g6400.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK30', N'LLK01', N'NCC00', N'CPU INTEL CORE I7-11700F (2.5GHZ TURBO UP TO 4.9GHZ, 8 NHÂN 16 LUỒNG, 16MB CACHE, 65W) - SOCKET INTEL LGA 1200', N'24 Tháng', N'Thái Lan', N'Mới', N'Cái', 3000000, 60, 0, N'250_58408_cpu_intel_core_i7_11700f_2_5ghz_turbo_up_to_4_9ghz_8_nhan_16_luong_16mb_cache_65w_socket_intel_lga_1200_1.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK31', N'LLK02', N'NCC00', N'Loa máy tính LOGITECH X-230', N'24 Tháng', N'Thái Lan', N'Mới', N'Cái', 450000, 30, 0, N'shopping.png', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK32', N'LLK02', N'NCC00', N'LOA VI TÍNH MICROLAB M106BT/2.1', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 550000, 30, 0, N'10027328-loa-vi-tinh-microlab-m106bt-2-1-1.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK33', N'LLK06', N'NCC00', N'Ổ CỨNG SSD KINGSTON A400 120GB 2.5 INCH SATA3 (ĐỌC 500MB/S - GHI 320MB/S)', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 550000, 27, 0, N'250_38001_____c___ng_ssd_kingston_a400_120gb_2_5_inch_sata3.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK34', N'LLK06', N'NCC00', N'Ổ CỨNG SSD KINGFAST F8N 512GB M.2 2280 PCIE NVME GEN 3X4 (ĐỌC 1850MB/S - GHI', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 850000, 30, 0, N'250_47523_ssd_kingfast_nvme_m_2_2280_f8n_512gb_read_1850mbs_write_1500mbs_1.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK35', N'LLK00', N'NCC00', N'Chuột ASUS B100', N'24 Tháng', N'Trung Quốc', N'Mới', N'Cái', 390000, 30, 0, N'aus.jpg', N'1')
INSERT [dbo].[LinhKien] ([MaLK], [MaLLK], [MaNCC], [TenLK], [BaoHanh], [XuatXu], [TinhTrang], [DonViTinh], [DonGia], [SoLuongTon], [KhuyenMai], [HinhAnh], [TrangThai]) VALUES (N'LK36', N'LLK06', N'NCC00', N'Ổ Cứng SSD Sam Sung 256GB', N'12 Tháng', N'Trung Quốc', N'Mới', N'Cái', 1550000, 30, 0, N'shopping2.png', N'1')

INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK00', N'Chuột', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK01', N'Bàn Phím', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK02', N'Loa', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK03', N'Ram', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK04', N'Màn Hình', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK05', N'Maninboard', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK06', N'Ổ Cứng', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK07', N'CPU', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK08', N'CASE', N'0')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK09', N'Vỏ Máy Tính', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK10', N'Cường Lực', N'0')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK11', N'Nguồn Máy Tính', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK12', N'Card Màn Hình', N'1')
INSERT [dbo].[LoaiLinhKien] ([MaLLK], [TenLLK], [TrangThai]) VALUES (N'LLK13', N'CPU', N'0')

INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email], [TrangThai]) VALUES (N'NCC00', N'ADDA VIET NAM - Công Ty TNHH Công Nghệ AX FAN', N'Lô 11, Khu Công Nghiệp Cẩm Điền, Lương Điền, Xã Cẩm Điền, Huyện Cẩm Giàng,Hải Dương', N'(0220) 3777168', N'patrick_chang@adda.com.tw', N'1')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email], [TrangThai]) VALUES (N'NCC01', N'Intel', N'KCNC Q9, TPHCM', N'0386437634', N'intel.com.vn', N'1')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email], [TrangThai]) VALUES (N'NCC02', N'Công Ty TNHH Tin Học Thành Nhân', N'174-180 Bùi Thị Xuân, P. Phạm Ngũ Lão, Q. 1,Tp. Hồ Chí Minh (TPHCM)', N'(028) 39250295', N'thanhnhan@tnc.com.vn', N'1')


INSERT [dbo].[NhanVien] ([MaNV], [MaCV], [TenNV], [GioiTinh], [Email], [NgaySinh], [DienThoai], [CMND], [DiaChi], [HinhAnh], [UserName], [PassWord], [TrangThai]) VALUES (N'NV01', N'CV01', N'Lê Thiện Thanh Tâm', N'Nam', N'kq909981@gmail.com', CAST(N'2021-11-08 00:00:00.000' AS DateTime), N'0343754517', N'12345', N'Bào Mây, Tân Phú, Đồng Nai', N'3461cef78f927ccc2583.jpg', N'admin2', N'E10ADC3949BA59ABBE56E057F20F883E', N'0')
INSERT [dbo].[NhanVien] ([MaNV], [MaCV], [TenNV], [GioiTinh], [Email], [NgaySinh], [DienThoai], [CMND], [DiaChi], [HinhAnh], [UserName], [PassWord], [TrangThai]) VALUES (N'NV00', N'CV01', N'Nguyễn Quốc Trung', N'Nam', N'nguyenquoctrung579@gmail.com', CAST(N'2021-11-08 00:00:00.000' AS DateTime), N'0373933507', N'12345678910', N'Lộc Điền, Lộc Ninh, Bình Phước', N'3461cef78f927ccc2583.jpg', N'admin', N'E10ADC3949BA59ABBE56E057F20F883E', N'1')

INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [DiaChi], [TrangThai]) VALUES (N'NSX01', N'PSC', N'65 Huỳnh Thúc Kháng', N'1')


ALTER TABLE [dbo].[CT_HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK__CT_HoaDon__MAHDB__7B5B524B] FOREIGN KEY([MaHDBH])
REFERENCES [dbo].[HoaDonBanHang] ([MaHDBH])
GO
ALTER TABLE [dbo].[CT_HoaDonBanHang] CHECK CONSTRAINT [FK__CT_HoaDon__MAHDB__7B5B524B]
GO

ALTER TABLE [dbo].[CT_HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK__CT_HoaDonB__MALK__7C4F7684] FOREIGN KEY([MaLK])
REFERENCES [dbo].[LinhKien] ([MaLK])
GO
ALTER TABLE [dbo].[CT_HoaDonBanHang] CHECK CONSTRAINT [FK__CT_HoaDonB__MALK__7C4F7684]
GO

ALTER TABLE [dbo].[CT_HoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK__CT_HoaDon__MAHDN__7E37BEF6] FOREIGN KEY([MaHDNH])
REFERENCES [dbo].[HoaDonNhapHang] ([MaHDNH])
GO
ALTER TABLE [dbo].[CT_HoaDonNhapHang] CHECK CONSTRAINT [FK__CT_HoaDon__MAHDN__7E37BEF6]
GO

ALTER TABLE [dbo].[CT_HoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK__CT_HoaDonN__MALK__7D439ABD] FOREIGN KEY([MaLK])
REFERENCES [dbo].[LinhKien] ([MaLK])
GO
ALTER TABLE [dbo].[CT_HoaDonNhapHang] CHECK CONSTRAINT [FK__CT_HoaDonN__MALK__7D439ABD]
GO

ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK__HoaDonBanH__MAKH__778AC167] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK__HoaDonBanH__MAKH__778AC167]
GO

ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK__HoaDonBanH__MANV__76969D2E] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK__HoaDonBanH__MANV__76969D2E]
GO

ALTER TABLE [dbo].[HoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK__HoaDonNha__MANHA__73BA3083] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhapHang] CHECK CONSTRAINT [FK__HoaDonNha__MANHA__73BA3083]
GO

ALTER TABLE [dbo].[HoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK__HoaDonNhap__MANV__72C60C4A] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonNhapHang] CHECK CONSTRAINT [FK__HoaDonNhap__MANV__72C60C4A]
GO

ALTER TABLE [dbo].[LinhKien]  WITH CHECK ADD  CONSTRAINT [FK__LinhKien__MALOAI__74AE54BC] FOREIGN KEY([MaLLK])
REFERENCES [dbo].[LoaiLinhKien] ([MaLLK])
GO
ALTER TABLE [dbo].[LinhKien] CHECK CONSTRAINT [FK__LinhKien__MALOAI__74AE54BC]
GO

ALTER TABLE [dbo].[LinhKien]  WITH CHECK ADD  CONSTRAINT [FK_MANCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[LinhKien] CHECK CONSTRAINT [FK_MANCC]
GO

ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK__NhanVien__MACV__71D1E811] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK__NhanVien__MACV__71D1E811]
GO


/* Database of WebApplication */
create table Customer 
(
	IDCus int identity(1,1),
	CodeCus int primary key,
	Email_Cus nvarchar(50),
	Address_Cus nvarchar(50),
	Phone_Cus int,		
)

create table Orders
(
	IDOrder int identity(1,1) primary key,	
	OrderDate date,
	CodeCus int,
	Descriptions nvarchar(50),
	Foreign key (CodeCus) references Customer(CodeCus)
)

create table OrderDetail 
(
	ID int identity (1,1),
	IDOrder int,
	MaLK nvarchar(50),
	UnitPriceSale decimal, 
	Quantity int,
	foreign key (IDOrder) references Orders(IDOrder),
	foreign key (MaLK) references LinhKien(MaLK)
)




