
GO
CREATE TABLE [dbo].[Tbl_ChiTietHoaDon](
	[quantityProduct] [int] NULL,
	[unitPrice] [float] NULL,
	[intoMoney] [float] NULL,
	[moneyDown] [float] NULL,
	[idProduct] [nvarchar](50) NOT NULL,
	[idBill] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC,
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_ChiTietKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ChiTietKhuyenMai](
	[discount] [float] NULL,
	[status] [nvarchar](50) NULL,
	[idProduct] [nvarchar](50) NOT NULL,
	[idPromotion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC,
	[idPromotion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_ChiTietNhapKho]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ChiTietNhapKho](
	[idReceipt] [int] NOT NULL,
	[quantityRequest] [int] NULL,
	[quantityActual] [int] NULL,
	[unitPrice] [float] NULL,
	[intoMoney] [float] NULL,
	[idProduct] [nvarchar](50) NOT NULL,
 CONSTRAINT [pk_ProductRe] PRIMARY KEY CLUSTERED 
(
	[idReceipt] ASC,
	[idProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_ChiTietPhieuYcNhapHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang](
	[idProduct] [nvarchar](50) NOT NULL,
	[idCoupon] [int] NOT NULL,
	[quantityImport] [int] NULL,
	[unitPrice] [float] NULL,
	[intoMoney] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC,
	[idCoupon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_DanhMucLapTop]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_DanhMucLapTop](
	[idTypeProduct] [int] NOT NULL,
	[nameTypeProduct] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[idTypeProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_HangSP]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_HangSP](
	[idManufactutre] [int] NOT NULL,
	[nameManufactutre] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_HangSP] PRIMARY KEY CLUSTERED 
(
	[idManufactutre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_HoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_HoaDon](
	[idBill] [int] NOT NULL,
	[dateBill] [date] NULL,
	[sumPay] [float] NULL,
	[typePay] [nvarchar](50) NULL,
	[discountMoney] [float] NULL,
	[pay] [float] NULL,
	[status] [nvarchar](max) NULL,
	[idEmployee] [nvarchar](50) NOT NULL,
	[idCustomer] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Bill] PRIMARY KEY CLUSTERED 
(
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_KhachHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_KhachHang](
	[idCustomer] [nvarchar](50) NOT NULL,
	[nameCustomer] [nvarchar](50) NULL,
	[address] [nvarchar](max) NULL,
	[phoneNumber] [nvarchar](10) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[idCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_KhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_KhuyenMai](
	[idPromotion] [int] NOT NULL,
	[namePromotions] [nvarchar](max) NULL,
	[status] [nvarchar](50) NULL,
	[startDay] [date] NULL,
	[endDay] [date] NULL,
 CONSTRAINT [PK_Tbl_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[idPromotion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_NhaCungCap]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_NhaCungCap](
	[idSupplier] [nvarchar](50) NOT NULL,
	[nameSupplier] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[idSupplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_NhanVien]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_NhanVien](
	[idEmployee] [nvarchar](50) NOT NULL,
	[nameEmployee] [nvarchar](50) NULL,
	[serviceEmployee] [nvarchar](50) NULL,
	[birthday] [date] NULL,
	[phoneNumber] [nchar](10) NULL,
	[salaryEmployee] [float] NULL,
	[totalSales] [float] NULL,
	[quantityBillPay] [int] NULL,
	[idUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[idEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_PhieuNhapKho]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PhieuNhapKho](
	[idReceipt] [int] NOT NULL,
	[idSupplier] [nvarchar](50) NOT NULL,
	[dateReceipt] [date] NULL,
	[sumPay] [float] NULL,
 CONSTRAINT [Pk_id] PRIMARY KEY CLUSTERED 
(
	[idReceipt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_PhieuYeuCauNhapHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PhieuYeuCauNhapHang](
	[idCoupon] [int] NOT NULL,
	[dateAdded] [date] NULL,
	[intoMoney] [float] NULL,
	[idSupplier] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[idCoupon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Quyen]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Quyen](
	[idQuyen] [int] NOT NULL,
	[nameAuth] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Quyen] PRIMARY KEY CLUSTERED 
(
	[idQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_SanPham]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_SanPham](
	[idProduct] [nvarchar](50) NOT NULL,
	[nameProduct] [nvarchar](max) NULL,
	[unitPrice] [float] NOT NULL,
	[quantityProduct] [int] NOT NULL,
	[statusProduct] [nvarchar](max) NULL,
	[idTypeProduct] [int] NOT NULL,
	[idManufactutre] [int] NOT NULL,
	[image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tbl_SanPham] PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_TaiKhoan]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_TaiKhoan](
	[idUser] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NULL,
	[idQuyen] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[Tbl_HoaDon] ([idBill])
GO
ALTER TABLE [dbo].[Tbl_ChiTietHoaDon] CHECK CONSTRAINT [fk_bill]
GO
ALTER TABLE [dbo].[Tbl_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_ProductLapTop] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Tbl_SanPham] ([idProduct])
GO
ALTER TABLE [dbo].[Tbl_ChiTietHoaDon] CHECK CONSTRAINT [fk_ProductLapTop]
GO
ALTER TABLE [dbo].[Tbl_ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [fk_ProductPromotion] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Tbl_SanPham] ([idProduct])
GO
ALTER TABLE [dbo].[Tbl_ChiTietKhuyenMai] CHECK CONSTRAINT [fk_ProductPromotion]
GO
ALTER TABLE [dbo].[Tbl_ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [fk_Promotion] FOREIGN KEY([idPromotion])
REFERENCES [dbo].[Tbl_KhuyenMai] ([idPromotion])
GO
ALTER TABLE [dbo].[Tbl_ChiTietKhuyenMai] CHECK CONSTRAINT [fk_Promotion]
GO
ALTER TABLE [dbo].[Tbl_ChiTietNhapKho]  WITH CHECK ADD  CONSTRAINT [fk_idProduct] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Tbl_SanPham] ([idProduct])
GO
ALTER TABLE [dbo].[Tbl_ChiTietNhapKho] CHECK CONSTRAINT [fk_idProduct]
GO
ALTER TABLE [dbo].[Tbl_ChiTietNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho] FOREIGN KEY([idReceipt])
REFERENCES [dbo].[Tbl_PhieuNhapKho] ([idReceipt])
GO
ALTER TABLE [dbo].[Tbl_ChiTietNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho]
GO
ALTER TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_Coupon] FOREIGN KEY([idCoupon])
REFERENCES [dbo].[Tbl_PhieuYeuCauNhapHang] ([idCoupon])
GO
ALTER TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang] CHECK CONSTRAINT [fk_Coupon]
GO
ALTER TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_Product] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Tbl_SanPham] ([idProduct])
GO
ALTER TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang] CHECK CONSTRAINT [fk_Product]
GO
ALTER TABLE [dbo].[Tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_KhachHangBill] FOREIGN KEY([idCustomer])
REFERENCES [dbo].[Tbl_KhachHang] ([idCustomer])
GO
ALTER TABLE [dbo].[Tbl_HoaDon] CHECK CONSTRAINT [fk_KhachHangBill]
GO
ALTER TABLE [dbo].[Tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_NhanVienBill] FOREIGN KEY([idEmployee])
REFERENCES [dbo].[Tbl_NhanVien] ([idEmployee])
GO
ALTER TABLE [dbo].[Tbl_HoaDon] CHECK CONSTRAINT [fk_NhanVienBill]
GO
ALTER TABLE [dbo].[Tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_keyUser] FOREIGN KEY([idUser])
REFERENCES [dbo].[Tbl_TaiKhoan] ([idUser])
GO
ALTER TABLE [dbo].[Tbl_NhanVien] CHECK CONSTRAINT [fk_keyUser]
GO
ALTER TABLE [dbo].[Tbl_PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [PK_NhaCungCap] FOREIGN KEY([idSupplier])
REFERENCES [dbo].[Tbl_NhaCungCap] ([idSupplier])
GO
ALTER TABLE [dbo].[Tbl_PhieuNhapKho] CHECK CONSTRAINT [PK_NhaCungCap]
GO
ALTER TABLE [dbo].[Tbl_PhieuYeuCauNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_NhapHang] FOREIGN KEY([idSupplier])
REFERENCES [dbo].[Tbl_NhaCungCap] ([idSupplier])
GO
ALTER TABLE [dbo].[Tbl_PhieuYeuCauNhapHang] CHECK CONSTRAINT [fk_NhapHang]
GO
ALTER TABLE [dbo].[Tbl_SanPham]  WITH CHECK ADD  CONSTRAINT [fk_ManufacturerProduct] FOREIGN KEY([idManufactutre])
REFERENCES [dbo].[Tbl_HangSP] ([idManufactutre])
GO
ALTER TABLE [dbo].[Tbl_SanPham] CHECK CONSTRAINT [fk_ManufacturerProduct]
GO
ALTER TABLE [dbo].[Tbl_SanPham]  WITH CHECK ADD  CONSTRAINT [fk_TypeProductProduct] FOREIGN KEY([idTypeProduct])
REFERENCES [dbo].[Tbl_DanhMucLapTop] ([idTypeProduct])
GO
ALTER TABLE [dbo].[Tbl_SanPham] CHECK CONSTRAINT [fk_TypeProductProduct]
GO
ALTER TABLE [dbo].[Tbl_TaiKhoan]  WITH CHECK ADD  CONSTRAINT [fk_QuyenID] FOREIGN KEY([idQuyen])
REFERENCES [dbo].[Tbl_Quyen] ([idQuyen])
GO
ALTER TABLE [dbo].[Tbl_TaiKhoan] CHECK CONSTRAINT [fk_QuyenID]
GO
/****** Object:  StoredProcedure [dbo].[Proc_addCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc		[dbo].[Proc_addCoupon]
@idCoupon int,
@dateAdded date,
@intoMoney float,
@idSupplier nvarchar(50)
as
begin
insert into Tbl_PhieuYeuCauNhapHang(idCoupon, dateAdded, intoMoney,idSupplier)
values (@idCoupon, @dateAdded, @intoMoney, @idSupplier)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addChiTietHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addChiTietHoaDon]

@quantityProduct int,
@unitPrice float,
@intoMoney float,
@moneyDown float,
@idProduct nvarchar(50),
@idBill int

as 
begin
insert into [dbo].[Tbl_ChiTietHoaDon](quantityProduct, unitPrice,intoMoney,moneyDown, idProduct, idBill)
 values (@quantityProduct, @unitPrice, @intoMoney,@moneyDown, @idProduct,@idBill)
 end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addChiTietKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addChiTietKhuyenMai]

@discount float,
@status nvarchar(50),
@idProduct nvarchar(50),
@idPromotion int

as 
begin
insert into [dbo].[Tbl_ChiTietKhuyenMai](discount, status, idProduct, idPromotion)
 values (@discount, @status, @idProduct, @idPromotion)
 end


GO
/****** Object:  StoredProcedure [dbo].[Proc_addDetailCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc		[dbo].[Proc_addDetailCoupon]
@quantityImport int,
@unitPrice float,
@intoMoney float,
@idCoupon int,
@idProduct nvarchar(50)
as
begin
insert into Tbl_ChiTietPhieuYcNhapHang(quantityImport,unitPrice, intoMoney, idCoupon , idProduct)
values (@quantityImport,@unitPrice, @intoMoney, @idCoupon , @idProduct)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addDetailReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Proc_addDetailReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int,
@idCoupon int,
@quantityRequest int,
@quantityActual INT,
@unitPrice FLOAT,
@intoMoney FLOAT
as
BEGIN 
/* câu lệnh SELECT */
INSERT INTO dbo.Tbl_ChiTietNhapKho
VALUES (@idReceipt, @idCoupon, @quantityRequest, @quantityActual, @unitPrice, @intoMoney)
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_addEmployee]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addEmployee]

@idEmployee nvarchar(50),
@nameEmployee nvarchar(50),
@serviceEmployee nvarchar(50),
@phoneNumber nvarchar(50),
@salaryEmployee float,
@totalSales float,
@quantityBillPay int,
@idUser nvarchar(50),
@birthday date
as
begin
insert into Tbl_NhanVien(idEmployee, nameEmployee, serviceEmployee, phoneNumber, salaryEmployee, totalSales, quantityBillPay, idUser, birthday)
values (@idEmployee, @nameEmployee, @serviceEmployee, @phoneNumber, @salaryEmployee, @totalSales, @quantityBillPay, @idUser, @birthday)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addHoaDon]
@idBill int,
@dateBill date,
@sumPay float,
@typePay nvarchar(50),
@discountMoney float,
@pay float ,
@status nvarchar(50),
@idEmployee nvarchar(50),
@idCustomer nvarchar(50)
as 
begin
insert into [dbo].[Tbl_HoaDon](idBill, dateBill, sumPay, typePay, discountMoney, pay, status, idEmployee, idCustomer)
 values (@idBill, @dateBill,@sumPay, @typePay, @discountMoney, @pay, @status, @idEmployee, @idCustomer)
 end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addKhachHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addKhachHang]
@idCustomer nvarchar(50),
@nameCustomer nvarchar(50),
@address nvarchar(max),
@phoneNumber nvarchar(10),
@email nvarchar(50)

as 
begin
insert into [dbo].[Tbl_KhachHang](idCustomer, nameCustomer, address, phoneNumber, email)
 values (@idCustomer, @nameCustomer,@address, @phoneNumber, @email)
 end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addKhuyenMai]

@idPromotion int,
@namePromotion nvarchar(max),
@status nvarchar(50),
@startDay date,
@endDay date

as 
begin
insert into [dbo].[Tbl_KhuyenMai](idPromotion, namePromotions, status, startDay,endDay)
 values (@idPromotion, @namePromotion, @status, @startDay, @endDay)
 end



GO
/****** Object:  StoredProcedure [dbo].[Proc_addManufacture]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addManufacture]
@id int,
@name nvarchar(50)
as
begin
insert into Tbl_HangSP(idManufactutre, nameManufactutre)
values (@id, @name)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addQuyen]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addQuyen]
@id int,
@name nvarchar(50)
as
begin
insert into Tbl_Quyen(idQuyen, nameAuth)
values (@id, @name)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_addReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int,
@idSupplier NVARCHAR(50),
@dateReceipt date,
@sumPay float

/* @dateReceipt DATE,
@sumPay FLOAT */
as
BEGIN 
/* câu lệnh SELECT */
INSERT INTO dbo.Tbl_PhieuNhapKho (idReceipt, idSupplier, dateReceipt,sumPay)
VALUES (@idReceipt, @idSupplier, @dateReceipt, @sumPay)
END 
GO
/****** Object:  StoredProcedure [dbo].[Proc_addSupplier]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Proc_addSupplier]
/* tạo biến trùng tên với biến trong code */
@idSupplier NVARCHAR(50),
@nameSupplier NVARCHAR(50)
as
BEGIN 
/* câu lệnh SELECT */
INSERT INTO dbo.Tbl_NhaCungCap (idSupplier,nameSupplier)
VALUES (@idSupplier, @nameSupplier)
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_addTypeProduct]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[Proc_addTypeProduct]
@id int,
@name nvarchar(50)
as 
begin
	insert into [dbo].[Tbl_DanhMucLapTop] (idTypeProduct, nameTypeProduct)
	values (@id, @name)
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteCoupon]

@idCoupon int
as
begin

delete from Tbl_PhieuYeuCauNhapHang
WHERE idCoupon = @idCoupon
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteChiTietHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteChiTietHoaDon]

@idProduct nvarchar(50),
@idBill int

as 
begin 
delete from [dbo].[Tbl_ChiTietHoaDon] 
WHERE idProduct =@idProduct and idProduct = @idProduct
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteChiTietKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteChiTietKhuyenMai]

@idProduct nvarchar(50),
@idPromotion int

as 
begin 
delete from [dbo].[Tbl_ChiTietKhuyenMai] 
WHERE idPromotion =@idPromotion and idProduct = @idProduct
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteDetailCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteDetailCoupon]

@idProduct nvarchar(50),
@idCoupon int
as
begin

delete from Tbl_ChiTietPhieuYcNhapHang
WHERE idCoupon = @idCoupon and idProduct = @idProduct
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteDetailReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_deleteDetailReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt INT,
@idCoupon INT
as
BEGIN 
DELETE FROM dbo.Tbl_ChiTietNhapKho WHERE idReceipt = @idReceipt AND idCoupon = @idCoupon
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteEmployee]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteEmployee]
@idEmployee nvarchar(50)
as
begin
delete from Tbl_NhanVien
WHERE idEmployee = @idEmployee
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteHoaDon]
@idBill int
as
begin
	delete from Tbl_HoaDon
	where idBill=@idBill
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteKhachHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteKhachHang]
@idCustomer nvarchar(50)
as
begin
	delete from Tbl_KhachHang
	where idCustomer=@idCustomer
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteKhuyenMai]
@idPromotion int
as 
begin
  delete from [dbo].[Tbl_KhuyenMai] where idPromotion=@idPromotion
 end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteManufacture]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteManufacture]
@id int
as
begin
delete from Tbl_HangSP
WHERE idManufactutre = @id
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteQuyen]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteQuyen]
@id int
as
begin

delete from Tbl_Quyen
WHERE idQuyen = @id
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_deleteReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int
as
BEGIN 
DELETE FROM dbo.Tbl_PhieuNhapKho WHERE idReceipt = @idReceipt
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteSupplier]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_deleteSupplier]
/* tạo biến trùng tên với biến trong code */
@idSupplier NVARCHAR(50)
as
BEGIN 
DELETE FROM dbo.Tbl_NhaCungCap WHERE idSupplier = @idSupplier
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteTypeProduct]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteTypeProduct]
@id int
as
begin
	delete from Tbl_DanhMucLapTop
WHERE idTypeProduct = @id
end
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_login]
@user nvarchar(50),
@pass nvarchar(50)
as
begin
select * from Tbl_TaiKhoan where UserName = @user and Password = @pass
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateCoupon]
@idCoupon int,
@dateAdded date,
@intoMoney float,
@idSupplier nvarchar(50)
as
begin

UPDATE Tbl_PhieuYeuCauNhapHang
SET dateAdded = @dateAdded,  intoMoney = @intoMoney, idSupplier = @idSupplier
WHERE idCoupon = @idCoupon
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateChiTietHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateChiTietHoaDon]

@quantityProduct int,
@unitPrice float,
@intoMoney float,
@moneyDown float,
@idProduct nvarchar(50),
@idBill int

as 
begin
UPDATE [dbo].[Tbl_ChiTietHoaDon]
SET  quantityProduct=@quantityProduct, unitPrice=@unitPrice, intoMoney=@intoMoney, moneyDown=@moneyDown
WHERE idBill =@idBill and idProduct = @idProduct
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateChiTietKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateChiTietKhuyenMai]

@discount float,
@status nvarchar(50),
@idProduct nvarchar(50),
@idPromotion int

as 
begin
UPDATE [dbo].[Tbl_ChiTietKhuyenMai]
SET  discount=@discount, status = @status
WHERE idPromotion =@idPromotion and idProduct = @idProduct
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateDetailCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateDetailCoupon]

@quantityImport int,
@unitPrice float,
@intoMoney float,
@idCoupon int,
@idProduct nvarchar(50)
as
begin

UPDATE Tbl_ChiTietPhieuYcNhapHang
SET quantityImport = @quantityImport,  unitPrice = @unitPrice, intoMoney = @intoMoney
WHERE idCoupon = @idCoupon and idProduct = @idProduct
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateDetailReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_updateDetailReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int,
@idCoupon int,
@quantityRequest int,
@quantityActual INT,
@unitPrice FLOAT,
@intoMoney FLOAT
as
BEGIN 
UPDATE dbo.Tbl_ChiTietNhapKho
SET idReceipt = @idReceipt, idCoupon = @idCoupon, quantityRequest = @quantityRequest, quantityActual = @quantityActual, unitPrice = @unitPrice, intoMoney = @intoMoney
WHERE idReceipt = @idReceipt AND idCoupon = @idCoupon
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateEmployee]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateEmployee]
@idEmployee nvarchar(50),
@nameEmployee nvarchar(50),
@serviceEmployee nvarchar(50),
@phoneNumber nvarchar(50),
@salaryEmployee float,
@totalSales float,
@quantityBillPay int,
@idUser nvarchar(50),
@birthday date
as
begin
UPDATE Tbl_NhanVien
SET nameEmployee = @nameEmployee, serviceEmployee = @serviceEmployee, phoneNumber = @phoneNumber, salaryEmployee = @salaryEmployee, totalSales = @totalSales, quantityBillPay = @quantityBillPay, idUser = @idUser, birthday = @birthday
WHERE idEmployee = @idEmployee
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateHoaDon]
@idBill int,
@dateBill date,
@sumPay float,
@typePay nvarchar(50),
@discountMoney float,
@pay float ,
@status nvarchar(50),
@idEmployee nvarchar(50),
@idCustomer nvarchar(50)

as
begin
	UPDATE tbl_HoaDon
	SET  dateBill=@dateBill, sumPay=@sumPay, 
		typePay=@typePay, discountMoney=@discountMoney, pay=@pay, 
		status=@status, idEmployee=@idEmployee, idCustomer=@idCustomer
	WHERE idBill = @idBill
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateKhachHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateKhachHang]
@idCustomer nvarchar(50),
@nameCustomer nvarchar(50),
@address nvarchar(max),
@phoneNumber nvarchar(10),
@email nvarchar(50)

as
begin
	UPDATE tbl_KhachHang
	SET nameCustomer=@nameCustomer, address=@address, 
		phoneNumber=@phoneNumber, email=@email
	WHERE idCustomer = @idCustomer
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateKhuyenMai]

@idPromotion int,
@namePromotion nvarchar(max),
@status nvarchar(50),
@startDay date,
@endDay date

as 
begin
UPDATE [dbo].[Tbl_KhuyenMai]
SET  namePromotions= @namePromotion, status = @status, startDay= @startDay, endDay=@endDay
WHERE idPromotion =@idPromotion
 end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateManufacture]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateManufacture]
@id int,
@name nvarchar(50)
as
begin
UPDATE Tbl_HangSP
SET idManufactutre=@id, nameManufactutre = @name
WHERE idManufactutre = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateQuyen]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateQuyen]
@id int,
@name nvarchar(50)
as
begin

UPDATE Tbl_Quyen
SET nameAuth = @name
WHERE idQuyen = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_updateReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int,
@idSupplier NVARCHAR(50),
@dateReceipt date,
@sumPay float
as
BEGIN 
UPDATE dbo.Tbl_PhieuNhapKho
SET idSupplier = @idSupplier , dateReceipt = @dateReceipt, sumPay = @sumPay
WHERE idReceipt = @idReceipt
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateSupplier]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_updateSupplier]
/* tạo biến trùng tên với biến trong code */
@idSupplier NVARCHAR(50),
@nameSupplier NVARCHAR(50)
as
BEGIN 
UPDATE dbo.Tbl_NhaCungCap
SET nameSupplier = @nameSupplier
WHERE idSupplier = @idSupplier
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateTypeProduct]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Proc_updateTypeProduct]
@id int,
@name nvarchar(50)
as
begin
	UPDATE Tbl_DanhMucLapTop
	SET idTypeProduct=@id, nameTypeProduct=@name
	WHERE idTypeProduct = @id
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanLapTop] SET  READ_WRITE 
GO



INSERT INTO Tbl_HangSP VALUES
(4001, N'Asus'),
(4002, N'Acer'),
(4003, N'Apple'),
(4004, N'Dell'),
(4005, N'Lenovo')

---   2) Danh mục laptop   ---
INSERT INTO Tbl_DanhMucLapTop VALUES
(5001, N'Laptop gaming'),
(5002, N'Ultrabook mỏng nhẹ'),
(5003, N'Laptop văn phòng')



---	  4) Sản phẩm   ----
INSERT INTO Tbl_SanPham VALUES
('SP001', N'Tuf Gaming F15 2022', 21000000,  16, N'Còn hàng', 5001, 4001, ''),
('SP002', N'Laptop Acer Swift 3', 22000000,  5, N'Còn hàng', 5002, 4002, ''),
('SP003', N'Laptop Dell Precision 5510', 23000000,  5, N'Còn hàng', 5003, 4004, ''),
('SP004', N'Tuf Gaming A15 2022', 24000000,  5, N'Còn hàng', 5001, 4001, ''),
('SP005', N'Macbook Pro M2', 25000000,  5, N'Còn hàng', 5002, 4003, ''),
('SP006', N'Laptop Asus TUF Gaming F15', 27899000,  5, N'Còn hàng', 5001, 4001, ''),
('SP007', N'Laptop Asus ROG Flow X13', 33990000,  5, N'Còn hàng', 5001, 4001, ''),
('SP008', N'Laptop ASUS ROG Strix SCAR 17 SE G733CX-LL6789W', 102900000 ,  5, N'Còn hàng', 5001, 4001, ''),
('SP009', N'Laptop Acer Gaming Aspire 7 A715-42G-R4XX NH.QAYSV.008', 14690000,  5, N'Còn hàng', 5001, 4002, ''),
('SP010', N'Laptop Gaming Acer Nitro 5 Eagle AN515-57-54MV NH.QENSV.003', 19990000,  5, N'Còn hàng', 5001, 4002, ''),
('SP011', N'Laptop Acer Predator Helios 300 PH315-55-76KG NH.QGPSV.001', 40990000,  5, N'Còn hàng', 5001, 4002, ''),
('SP012', N'Laptop Asus ROG Zephyrus M16 GU603ZX-K8025W', 94990000,  5, N'Còn hàng', 5001, 4001, ''),
('SP013', N'Laptop ASUS ROG Zephyrus G15 GA503RM-LN006W', 40690000,  5, N'Còn hàng', 5001, 4001, ''),
('SP014', N'Laptop Asus ROG Strix G15 G513RC-HN090W', 25990000,  5, N'Còn hàng', 5001, 4001, ''),
('SP015', N'Laptop Dell G15 5511 70283449', 22590000,  5, N'Còn hàng', 5001, 4004, ''),
('SP016', N'Laptop Dell G15 5515C P105F004CGR', 18590000,  5, N'Còn hàng', 5001, 4004, ''),
('SP017', N'Laptop Dell G15 5515D P105F004DGR', 20690000,  5, N'Còn hàng', 5001, 4004, ''),
('SP018', N'Laptop Lenovo IdeaPad Gaming 3 15IAH7 82S9006YVN', 26190000,  5, N'Còn hàng', 5001, 4005, ''),
('SP019', N'Laptop Lenovo Legion 5 15IAH7H 82RB0048VN', 38990000,  5, N'Còn hàng', 5001, 4005, ''),
('SP020', N'Laptop Lenovo Legion 5 Pro 16IAH7H 82RG008SVN', 43990000,  5, N'Còn hàng', 5001, 4005, ''),
('SP021', N'Laptop Asus ZenBook 14 UX425EA-KI839W', 18990000,  5, N'Còn hàng', 5002, 4001, ''),
('SP022', N'Laptop Asus ExpertBook B9400CEA-KC0773T', 29990000,  5, N'Còn hàng', 5002, 4001, ''),
('SP023', N'Laptop Asus Zenbook 14 Flip OLED UP5401ZA-KN101W', 31690000,  5, N'Còn hàng', 5002, 4001, ''),
('SP024', N'Laptop Acer Aspire 3 A315-56-58EG NX.HS5SV.00J', 10999000,  5, N'Còn hàng', 5002, 4002, ''),
('SP025', N'Laptop Acer Aspire 5 A514-55-5954 NX.K5BSV.001', 16990000,  5, N'Còn hàng', 5002, 4002, ''),
('SP026', N'Laptop Acer Swift 3 SF314-512-56QN NX.K0FSV.002', 22990000,  5, N'Còn hàng', 5002, 4002, ''),
('SP027', N'Laptop Apple MacBook Pro M2 2022 13.3 inch MNEH3SA/A Space Grey', 29990000,  5, N'Còn hàng', 5002, 4003, ''),
('SP028', N'Laptop Apple Macbook Air 13.6 inch MLY13SA/A STARLIGHT (Apple M2)', 29550000,  5, N'Còn hàng', 5002, 4003, ''),
('SP029', N'Laptop Apple Macbook Air 13.6 inch MLXW3SA/A Xám (Apple M2)', 29550000,  5, N'Còn hàng', 5002, 4003, ''),
('SP030', N'Laptop Dell Vostro 14 3400 YX51W6', 16790000,  5, N'Còn hàng', 5002, 4004, ''),
('SP031', N'Laptop Dell Inspiron 16 5620 P1WKN', 20790000,  5, N'Còn hàng', 5002, 4004, ''),
('SP032', N'Laptop Dell Inspiron 14 7420 1YT85', 32290000,  5, N'Còn hàng', 5002, 4004, ''),
('SP033', N'Laptop Lenovo ThinkPad X13 Gen 3 21BN00AJVA', 30890000,  5, N'Còn hàng', 5002, 4005, ''),
('SP034', N'Laptop Lenovo IdeaPad 5 15IAL7 82SF006LVN', 18390000,  5, N'Còn hàng', 5002, 4005, ''),
('SP035', N'Laptop Lenovo ThinkBook 14 G2 ITL 20VD00Y0VN', 14990000,  5, N'Còn hàng', 5002, 4005, ''),
('SP036', N'Laptop Asus ZenBook 14 UX425EA-KI839W', 18999000,  5, N'Còn hàng', 5003, 4001, ''),
('SP037', N'Laptop Asus ExpertBook B9400CEA-KC0773T', 29990000,  5, N'Còn hàng', 5003, 4001, ''),
('SP038', N'Laptop Asus Vivobook 14X A1403ZA-LY072W', 14490000,  5, N'Còn hàng', 5003, 4001, ''),
('SP039', N'Laptop Acer Gaming Aspire 7 A715-42G-R4XX NH.QAYSV.008', 14690000,  5, N'Còn hàng', 5003, 4002, ''),
('SP040', N'Laptop Acer Aspire 3 A315-56-58EG NX.HS5SV.00J', 10999000,  5, N'Còn hàng', 5003, 4002, ''),
('SP041', N'Laptop Acer Swift 3 SF314-43-R4X3 NX.AB1SV.004', 18690000,  5, N'Còn hàng', 5003, 4002, ''),
('SP042', N'Laptop Acer Aspire 3 A315-58G-50S4 NX.ADUSV.001', 14690000,  5, N'Còn hàng', 5003, 4002, ''),
('SP043', N'Laptop Acer Aspire 3 A315-56-38B1 NX.HS5SV.00G', 9290000,  5, N'Còn hàng', 5003, 4002, ''),
('SP044', N'Laptop Acer Aspire 5 A515-57-52Y2 NX.K3KSV.003', 16990000,  5, N'Còn hàng', 5003, 4002, ''),
('SP045', N'Laptop Dell Latitude 3420 42LT342001', 10990000,  5, N'Còn hàng', 5003, 4004, ''),
('SP046', N'Laptop Dell Vostro 14 3400 YX51W5', 16790000,  5, N'Còn hàng', 5003, 4004, ''),
('SP047', N'Laptop Dell Vostro 3400 V4I7015W1', 22390000,  5, N'Còn hàng', 5003, 4004, ''),
('SP048', N'Laptop Lenovo V14 G2 ITL 82KA00RTVN', 8990000,  5, N'Còn hàng', 5003, 4005, ''),
('SP049', N'Laptop Lenovo ThinkBook 14 G2 ITL 20VD00Y0VN', 14990000,  5, N'Còn hàng', 5003, 4005, ''),
('SP050', N'Laptop Lenovo ThinkBook 14 G2 ITL 20VD00Y3VN', 17690000,  5, N'Còn hàng', 5003, 4005, '')

---   5) Khách hàng   ---
INSERT INTO Tbl_KhachHang VALUES 
 ('', N'', N'', '', ''),
 ('KH01', N'Nguyễn Hửu Trọng',N'123 Phan Văn Trị Q5','0963521458', 'trong@gmail.com'), 
 ('KH02', N'Nguyễn Hữu Toàn',N'11 Nguyễn Trãi Q5','0969681487', 'huutoan@gmail.com'),
 ('KH03', N'Nguyễn Văn Trường',N'85 Nguyễn Khuyến Quận 1','0359642876', 'Truong123@gmail.com'),
 ('KH04', N'Nguyễn Hoà',N'894 3 tháng 2 Quận 3','0969821447', 'hoa123@gmail.com'),
 ('KH05', N'Nguyễn Kha',N'123 Trương Định Quận 1','0399529874', 'nguyenkha@gmail.com'),
 ('KH06', N'Phạm Phú Khánh',N'11 Kinh Dương Vương, Quận Bình Tân','0963521875', 'ppk123@gmail.com'),
 ('KH07', N'Lưu Gia Tính ',N'198 Điện Biên Phủ, Quận 3','0963521877', 'lunh123@gmail.com'),
 ('KH08', N'Nguyễn Công Trình ',N'55 Lê Lai, Quận 1','0963521912', 'nct123@gmail.com'), 
 ('KH09', N'Hà Thanh Điền ',N'63 Nguyễn Khuyến, Quận 3','0963521985', 'dien121@gmail.com'),
 ('KH10', N'Nguyễn Thị Kim Ngân',N'64 Nguyễn Trãi, Quận 1','0963521231', 'kimngan1129@gmail.com'),
 ('KH11', N'Phùng Thiên Trang',N'625 Điện Biên Phủ, Quận 3','0353521981', 'trang123@gmail.com'),
 ('KH12', N'Trần Minh Thuận ',N'92 Trần Bình Trọng, Quận Tân Bình','0933852970', 'thuan123@gmail.com'),
 ('KH13', N'Nguyễn Hoàng Vĩnh Khang',N'0B Sương Nguyệt Ánh, P. Bến Thành, Q. 1','0964036853', 'khang123@gmail.com'),
 ('KH14', N'Trần Minh Công',N'Tầng 3, 6 Phùng Khắc Khoan, P. Đa Kao ,Q.1','0938483265', 'lunh123@gmail.com'),
 ('KH15', N'Nguyễn Thanh Ngân',N'Khách sạn Green Park, 48 Trần Nhân Tông, Quận Tân Bình','0939434725', 'cong123@gmail.com'),
 ('KH16', N'Lê Ngọc Hân',N'36 Đường B1, Phường Tây Thạnh, Quận Tân Phú','0922166682', 'han@gmail.com'),
 ('KH17', N'Nguyễn Thanh Mai',N'23 Hoàng Sa, Quận Tân Bình','0963525142', 'thanhmai@gmail.com'),
 ('KH18', N'Nguyễn Văn Bé',N'43 Ung Văn Khiêm, Quận Bình Thạnh','0353521979', 'baby142@gmail.com'),
 ('KH19', N'Võ Tấn Thanh',N'985 3 tháng 2, Quận Tân Bình','0963587621', 'thnahvo12@gmail.com'),
 ('KH20', N'Nguyễn Hoàng Khang',N'18/5A Cộng Hòa, Phường 12, Quận Tân Bình','0988931111', 'hoangkhangk1@gmail.com'),
 ('KH21', N'Nguyễn Mai Thy',N' B23 Cư Xá An Lộc, Nguyễn Oanh, Phường 17, Quận Gò Vấp','0932315623', 'maithy15@gmail.com'),
 ('KH22', N'Nguyễn Đức Anh',N'168/29 Đặng Văn Ngữ, Phường 14, Quận Phú Nhuận','0967719585', 'ducanh45@gmail.com'),
 ('KH23', N'Nguyễn Anh Tài',N' Lê Thị Hồng Gấm Phường 6, TP Mỹ Tho','0396521985', 'anhtai23@gmail.com'),
 ('KH24', N'Trần Đình Toàn',N'81/4 Phó Đức Chính, Phường 1, Quận Bình Thạnh','0989428450', 'toan1123@gmail.com'),
 ('KH25', N'Huỳnh Thanh Nga',N' 64 Võ Thị Sáu, Q.1','0938628646', 'thnahnga@gmail.com'),
 ('KH26', N'Nguyễn Công Bách',N' 69 Bạch Đằng, Phường 15, Quận Bình Thạnh','0938888394', 'congbach3@gmail.com'),
 ('KH27', N'Nguyễn Băng Di',N'119 Điện Biên Phủ, Quận 1','0939745018', 'bangdi23@gmail.com'),
 ('KH28', N'Nguyễn Thuỳ Anh',N'108/1 Ngô Quyền, P. 5, Q. 1','0968650921', 'thuyanh23@gmail.com'),
 ('KH29', N'Nguyễn Cẩm Tiên',N' 384 Huỳnh Văn Bánh, Phường 14, Quận Phú Nhuận','0967952727', 'camtien123@gmail.com'),
 ('KH30', N'Nguyễn Văn Di',N' 91 Điện Biên Phủ, Phường 15, Quận Bình Thạnh','0963821621', 'vadi123@gmail.com'), 
 ('KH31', N'Cao Thái Phương Trang ',N'145 Trường Sa, Quận Bình Tân','0963521234', 'ngphtrang123@gmail.com'),
 ('KH32', N'Nguyễn Văn Trọng',N'13 Phan Văn Trị Q5','0963521457', 'trong@gmail.com'), 
 ('KH33', N'Nguyễn Đình Toàn',N'51 Nguyễn Trãi Q5','0969681486', 'toan@gmail.com'),
 ('KH34', N'Nguyễn Văn Tiến',N'89 Nguyễn Khuyến Quận 1','0359642875', 'Tienn123@gmail.com'),
 ('KH35', N'Nguyễn Khuyến',N'85 3 tháng 2 Quận 3','0969821446', 'khuen123@gmail.com'),
 ('KH36', N'Nguyễn Nguyên Khôi',N'43 Trương Định Quận 1','0399529873', 'nguyenkhoi@gmail.com'),
 ('KH37', N'Phạm Phú Yên',N'98 Kinh Dương Vương, Quận Bình Tân','0963521874', 'yen123@gmail.com'),
 ('KH38', N'Nguyễn Công Văn',N'87 Lê Lai, Quận 1','0963521911', 'ncv123@gmail.com'), 
 ('KH39', N'Hà Thanh Đức ',N'90 Nguyễn Khuyến, Quận 3','0963521984', 'duc121@gmail.com'),
 ('KH40', N'Nguyễn Kim Ngân',N'4 Nguyễn Trãi, Quận 1','0963521232', 'kimngan29@gmail.com'),
 ('KH41', N'Phùng Văn Ý',N'62 Điện Biên Phủ, Quận 3','0353521980', 'y123@gmail.com'),
 ('KH42', N'Trần Minh Trí',N'102 Trần Bình Trọng, Quận Tân Bình','0933852969', 'tri23@gmail.com'),
 ('KH43', N'Nguyễn Hoàng Vĩnh',N'10B Sương Nguyệt Ánh, P. Bến Thành, Q. 1','0964036852', 'vinh223@gmail.com'),
 ('KH44', N'Trần Minh Lộc',N'19 Phùng Khắc Khoan, P. Đa Kao ,Q.1','0938483264', 'loc@gmail.com'),
 ('KH45', N'Nguyễn Kim Ngân',N'100 Trần Nhân Tông, Quận Tân Bình','0939434724', 'ngan17823@gmail.com'),
 ('KH46', N'Nguyễn Ngọc Hân',N'109 Đường B1, Phường Tây Thạnh, Quận Tân Phú','0922166681', 'han143@gmail.com'),
 ('KH47', N'Nguyễn Thị Thanh Mai',N'85 Hoàng Sa, Quận Tân Bình','0963525141', 'thanhmai93@gmail.com'),
 ('KH48', N'Nguyễn Văn Ba',N'200 Ung Văn Khiêm, Quận Bình Thạnh','0353521978', 'baby1142@gmail.com'),
 ('KH49', N'Võ Tấn Tài',N'1002 3 tháng 2, Quận Tân Bình','0963587620', 'taivo122@gmail.com'),
 ('KH50', N'Nguyễn Hoàng Phát',N'89 Cộng Hòa, Phường 12, Quận Tân Bình','0988931112', 'hoangphat1@gmail.com'),
 ('KH51', N'Nguyễn Bảo Thy',N' 103 Cư Xá An Lộc, Nguyễn Oanh, Phường 17, Quận Gò Vấp','0932315622', 'baothy15@gmail.com'),
 ('KH52', N'Nguyễn Anh Đức',N'166 Đặng Văn Ngữ, Phường 14, Quận Phú Nhuận','0967719584', 'anhduc45@gmail.com'),
 ('KH53', N'Nguyễn Văn Lễ',N' 10 Lê Thị Hồng Gấm Phường 6, TP Mỹ Tho','0396521984', 'vanle23@gmail.com'),
 ('KH54', N'Trần Đình Nghĩa',N'93 Phó Đức Chính, Phường 1, Quận Bình Thạnh','0989428449', 'nghia123@gmail.com'),
 ('KH55', N'Huỳnh Ngọc Nhi',N' 36 Võ Thị Sáu, Q.1','0938628645', 'nhi12@gmail.com'),
 ('KH56', N'Nguyễn Công Văn',N' 170 Bạch Đằng, Phường 15, Quận Bình Thạnh','0938888393', 'congvvn3@gmail.com'),
 ('KH57', N'Nguyễn Lê Duy',N'740 Điện Biên Phủ, Quận 1','0939745017', 'duy23@gmail.com'),
 ('KH58', N'Nguyễn Thuỳ An',N'107 Ngô Quyền, P. 5, Q. 1','0968650920', 'thuyan223@gmail.com'),
 ('KH59', N'Nguyễn Gia Huy',N' 98 Huỳnh Văn Bánh, Phường 14, Quận Phú Nhuận','0967952726', 'giahuy23@gmail.com'),
 ('KH60', N'Nguyễn Văn An',N' 23 Điện Biên Phủ, Phường 15, Quận Bình Thạnh','0963821620', 'vaan2123@gmail.com'), 
 ('KH61', N'Cao Phương Trang ',N'78 Trường Sa, Quận Bình Tân','0963521233', 'phtrang123@gmail.com'),
 ('KH62', N'Lữ Văn An',N'82 Phan Văn Trị Q5','0963521898', 'luan@gmail.com'), 
 ('KH63', N'Nguyễn Hữu Huân',N'121 Nguyễn Trãi Q5','0969681489', 'huuhuan1@gmail.com'),
 ('KH64', N'Nguyễn Văn Lợi',N'87 Nguyễn Khuyến Quận 1','0359642877', 'loi123@gmail.com'),
 ('KH65', N'Nguyễn Văn Khế',N'96 3 tháng 2 Quận 3','0969821448', 'khe123@gmail.com'),
 ('KH66', N'Nguyễn Tiến',N'124 Trương Định Quận 1','0399529876', 'nguyentien@gmail.com'),
 ('KH67', N'Phạm Thu Hà',N'12 Kinh Dương Vương, Quận Bình Tân','0963521876', 'pthuha123@gmail.com'),
 ('KH68', N'Nguyễn Công Đức ',N'56 Lê Lai, Quận 1','0963521913', 'ncd123@gmail.com'), 
 ('KH69', N'Hà Thanh Thảo ',N'64 Nguyễn Khuyến, Quận 3','0963521986', 'thao121@gmail.com'),
 ('KH70', N'Nguyễn Thị Kim Thoa',N'69 Nguyễn Trãi, Quận 1','0963521232', 'kimthoa1129@gmail.com'),
 ('KH71', N'Phùng Thiện My',N'629 Điện Biên Phủ, Quận 3','0353521982', 'my123@gmail.com'),
 ('KH72', N'Trần Minh Bảo ',N'99 Trần Bình Trọng, Quận Tân Bình','0933852974', 'bao123@gmail.com'),
 ('KH73', N'Nguyễn Hoàng Phong',N'8B Sương Nguyệt Ánh, P. Bến Thành, Q. 1','0964036859', 'phong123@gmail.com'),
 ('KH74', N'Trần Minh Tân',N' 10 Phùng Khắc Khoan, P. Đa Kao ,Q.1','0938483268', 'tan123@gmail.com'),
 ('KH75', N'Nguyễn Thanh Duy',N'78 Trần Nhân Tông, Quận Tân Bình','0939434729', 'duy123@gmail.com'),
 ('KH76', N'Lê Ngọc Anh',N'316 Đường B1, Phường Tây Thạnh, Quận Tân Phú','0922166689', 'anh1@gmail.com'),
 ('KH77', N'Nguyễn Kim Ngọc',N'231 Hoàng Sa, Quận Tân Bình','0963525149', 'kimngoc12@gmail.com'),
 ('KH78', N'Nguyễn Trúc Phương',N'413 Ung Văn Khiêm, Quận Bình Thạnh','0353521972', 'trucphuong2@gmail.com'),
 ('KH79', N'Võ Tấn Hảo',N'91 3 tháng 2, Quận Tân Bình','0963587629', 'tanhao12@gmail.com'),
 ('KH80', N'Nguyễn Thuận Phát',N'96 Cộng Hòa, Phường 12, Quận Tân Bình','0988931119', 'thuanphat1@gmail.com'),
 ('KH81', N'Nguyễn Châu Thy',N' 7 Cư Xá An Lộc, Nguyễn Oanh, Phường 17, Quận Gò Vấp','0932315624', 'chauthy15@gmail.com'),
 ('KH82', N'Nguyễn Công Phải',N'634 Đặng Văn Ngữ, Phường 14, Quận Phú Nhuận','0967719589', 'congphai45@gmail.com'),
 ('KH83', N'Nguyễn Quang Nhật',N'12 Lê Thị Hồng Gấm Phường 6, TP Mỹ Tho','0396521984', 'quangnhat23@gmail.com'),
 ('KH84', N'Trần Đình Kiệt',N'100 Phó Đức Chính, Phường 1, Quận Bình Thạnh','0989428450', 'kiet1123@gmail.com'),
 ('KH85', N'Huỳnh Thị Diễm Quỳnh',N' 92 Võ Thị Sáu, Q.1','0938628649', 'diemquynh12@gmail.com'),
 ('KH86', N'Nguyễn Phi Bằng',N' 109 Bạch Đằng, Phường 15, Quận Bình Thạnh','0938888399', 'phibang3@gmail.com'),
 ('KH87', N'Nguyễn Ý Nhi',N'120 Điện Biên Phủ, Quận 1','0939745019', 'ynhi23@gmail.com'),
 ('KH88', N'Nguyễn Anh Thư',N'300 Ngô Quyền, P. 5, Q. 1','0968650929', 'thu23@gmail.com'),
 ('KH89', N'Nguyễn Văn Sơn',N' 314 Huỳnh Văn Bánh, Phường 14, Quận Phú Nhuận','0967952729', 'vanson123@gmail.com'),
 ('KH90', N'Nguyễn Xuân Trường',N' 231 Điện Biên Phủ, Phường 15, Quận Bình Thạnh','0963821629', 'xuantruong1@gmail.com'), 
 ('KH91', N'Nguyễn Quang Trường ',N'124 Trường Sa, Quận Bình Tân','0963521239', 'quangtruong123@gmail.com')

---   6) Dữ liệu bảng quyền   ---
INSERT INTO Tbl_Quyen VALUES
(7001, 'Admin'),
(7002, 'Employee')

---   7) Dữ liệu bảng tài khoản   ---
INSERT INTO Tbl_TaiKhoan VALUES 
('admin', N'admin', '1234', 7001),
(N'Tien1',N'Tien1',N'1234',7002),
(N'Anh1',N'Anh1',N'1234',7002),
(N'Quan1',N'Quan1',N'1234',7002),
(N'Truc1',N'Truc1',N'1234',7002)

---	  8) Dữ liệu bảng nhân viên   ---
INSERT INTO Tbl_NhanVien VALUES
('admin', N'Nguyễn Hữu Trọng', N'Quản lý', '05/05/2002', '0157823578', 100000000, 0, 0, 'admin'),
('', N'', N'Quản lý', '05/05/2002', '0157823578', 100000000, 0, 0, 'admin'),
('NV01', N'Nguyễn Tiến', N'Nhân viên kỹ thuật', '06/06/2002', '0456788945', 20000000,2430568000, 42, 'Tien1'),
('NV02', N'Nguyễn Đức Anh', N'Nhân viên bán hàng', '07/07/2002', '0489784545', 20000000, 2037332000, 42, 'Anh1'),
('NV03', N'Nguyễn Hoàng Quân', N'Nhân viên thu ngân', '08/08/2002', '0489748546', 15000000,2841370800, 42, 'Quan1'),
('NV04', N'Thanh Trực', N'Chăm sóc khách hàng', '09/09/2002', '0887484645', 20000000, 3171550200, 66, 'Truc1')


---   11) Khuyến mãi   ---
INSERT INTO Tbl_KhuyenMai VALUES
(2001, N'Chúc mừng năm mới 2020', N'Hết khuyến mãi', '2020-01-01', '2020-01-03'),
(2002, N'Mừng lễ 30/4', N'Hết khuyến mãi', '2022-04-25', '2022-05-05'),
(2003, N'Back to School', N'Đang khuyến mãi', '2022-08-25', '2022-09-25'),
(2004, N'Merry Chirstmas', N'Sắp khuyến mãi', '2022-12-20', '2022-12-28'),
(2005, N'Chúc mừng năm mới 2022', N'Hết khuyến mãi', '2022-01-01', '2022-01-07'),
(2006, N'Flash sale 2/2', N'Hết khuyến mãi', '2020-02-02', '2020-02-05'),
(2007, N'Flash sale 4/4', N'Hết khuyến mãi', '2020-04-04', '2020-04-06'),
(2008, N'Flash sale 6/6', N'Hết khuyến mãi', '2021-06-06', '2021-06-08'),
(2009, N'Flash sale 8/8', N'Hết khuyến mãi', '2021-08-08', '2021-08-11'),
(2010, N'Back to School', N'Hết khuyến mãi', '2021-08-25', '2021-08-29'),
(2011, N'Flash sale 11/11', N'Hết khuyến mãi', '2021-11-11', '2022-11-13'),
(2012, N'Merry Christmas', N'Hết khuyến mãi', '2021-12-20', '2022-12-28')



---   12) Dữ liệu bảng chi tiết khuyến mãi
INSERT INTO Tbl_ChiTietKhuyenMai VALUES
(10, N'Hết khuyến mãi', 'SP001', 2001),
(10, N'Hết khuyến mãi', 'SP002', 2001),
(20, N'Hết khuyến mãi', 'SP003', 2002),
(20, N'Hết khuyến mãi', 'SP010', 2002),
(20, N'Hết khuyến mãi', 'SP011', 2002),
(20, N'Hết khuyến mãi', 'SP012', 2002),
(20, N'Hết khuyến mãi', 'SP014', 2002),
(20, N'Hết khuyến mãi', 'SP013', 2002),
(20, N'Hết khuyến mãi', 'SP015', 2002),
(20, N'Hết khuyến mãi', 'SP040', 2002),
(20, N'Đang khuyến mãi', 'SP024', 2003),
(20, N'Hết khuyến mãi', 'SP008', 2005),
(20, N'Hết khuyến mãi', 'SP012', 2005),
(20, N'Hết khuyến mãi', 'SP005', 2005),
(20, N'Hết khuyến mãi', 'SP006', 2005),
(20, N'Hết khuyến mãi', 'SP007', 2005),
(20, N'Hết khuyến mãi', 'SP009', 2006),
(20, N'Hết khuyến mãi', 'SP039', 2006),
(20, N'Hết khuyến mãi', 'SP009', 2007),
(20, N'Hết khuyến mãi', 'SP011', 2007),
(20, N'Hết khuyến mãi', 'SP019', 2008),
(20, N'Hết khuyến mãi', 'SP044', 2008),
(20, N'Hết khuyến mãi', 'SP014', 2009),
(20, N'Hết khuyến mãi', 'SP045', 2009),
(20, N'Hết khuyến mãi', 'SP012', 2010),
(20, N'Hết khuyến mãi', 'SP042', 2011),
(20, N'Hết khuyến mãi', 'SP048', 2012),
(20, N'Hết khuyến mãi', 'SP049', 2012),
(20, N'Hết khuyến mãi', 'SP050', 2012),
(10, N'Sắp khuyến mãi', 'SP005', 2004),
(10, N'Sắp khuyến mãi', 'SP001', 2004),
(10, N'Sắp khuyến mãi', 'SP002', 2004),
(10, N'Sắp khuyến mãi', 'SP003', 2004),
(10, N'Sắp khuyến mãi', 'SP004', 2004),
(10, N'Sắp khuyến mãi', 'SP006', 2004),
(10, N'Sắp khuyến mãi', 'SP007', 2004),
(10, N'Sắp khuyến mãi', 'SP008', 2004),
(10, N'Sắp khuyến mãi', 'SP009', 2004),
(10, N'Sắp khuyến mãi', 'SP010', 2004),
(10, N'Sắp khuyến mãi', 'SP011', 2004),
(10, N'Sắp khuyến mãi', 'SP012', 2004),
(10, N'Sắp khuyến mãi', 'SP013', 2004)


---   13) Nhà cung cấp   ---
INSERT INTO Tbl_NhaCungCap VALUES
('ASUS', N'Asus'),
('ACER', N'Acer'),
('APPLE', N'Apple'),
('DELL', N'Dell'),
('LENOVO', N'Lenovo')

-- 14)  Hoá Đơn--
insert into Tbl_HoaDon
values 
(1001, '2020-01-01', 65000000, N'Tiền mặt', 6500000, 58500000, N'Đã thanh toán', 'NV01', 'KH01'),
(1002, '2020-01-02', 69000000, N'Tiền mặt', 6900000, 62100000, N'Đã thanh toán', 'NV02', 'KH02'),
(1003, '2020-01-04', 96000000, N'Chuyển khoản',0, 96000000, N'Đã thanh toán', 'NV03', 'KH03'),
(1004, '2020-01-14', 125000000, N'Chuyển khoản',0, 125000000, N'Đã thanh toán', 'NV04', 'KH04'),
(1005, '2020-01-15', 65000000, N'Tiền mặt', 0, 65000000, N'Đã thanh toán', 'NV01', 'KH05'),
(1006, '2020-01-26', 69000000, N'Tiền mặt', 0, 69000000, N'Đã thanh toán', 'NV02', 'KH06'),
(1007, '2020-01-27', 96000000, N'Chuyển khoản',0, 96000000, N'Đã thanh toán', 'NV03', 'KH07'),
(1008, '2020-01-27', 125000000, N'Chuyển khoản',0, 125000000, N'Đã thanh toán', 'NV04', 'KH08'),
(1009, '2020-02-01', 9290000, N'Tiền mặt', 0, 9290000, N'Đã thanh toán', 'NV01', 'KH01'),
(1010, '2020-02-02', 16990000, N'Tiền mặt', 0, 16990000, N'Đã thanh toán', 'NV02', 'KH09'),
(1011, '2020-02-04', 10990000, N'Chuyển khoản',0, 10990000, N'Đã thanh toán', 'NV03', 'KH10'),
(1012, '2020-02-14', 16790000, N'Chuyển khoản',0, 16790000, N'Đã thanh toán', 'NV04', 'KH11'),
(1013, '2020-02-15', 22390000, N'Tiền mặt', 0, 22390000, N'Đã thanh toán', 'NV01', 'KH05'),
(1014, '2020-02-26', 8990000, N'Tiền mặt', 0, 8990000, N'Đã thanh toán', 'NV02', 'KH12'),
(1015, '2020-02-27', 14990000, N'Chuyển khoản',0, 14990000, N'Đã thanh toán', 'NV03', 'KH13'),
(1016, '2020-02-27', 17690000, N'Chuyển khoản',0, 17690000, N'Đã thanh toán', 'NV04', 'KH14'),
(1017, '2020-03-01', 135980000, N'Tiền mặt', 0, 135980000, N'Đã thanh toán', 'NV01', 'KH02'),
(1018, '2020-03-02', 81380000, N'Tiền mặt', 0, 81380000, N'Đã thanh toán', 'NV02', 'KH03'),
(1019, '2020-03-04', 25990000, N'Chuyển khoản',0, 25990000, N'Đã thanh toán', 'NV03', 'KH04'),
(1020, '2020-03-14', 101970000, N'Chuyển khoản',0, 101970000, N'Đã thanh toán', 'NV04', 'KH15'),
(1021, '2020-04-05', 14690000, N'Tiền mặt', 2938000, 11752000, N'Đã thanh toán', 'NV01', 'KH16'),
(1022, '2020-04-06', 16790000, N'Tiền mặt', 0, 16790000, N'Đã thanh toán', 'NV02', 'KH17'),
(1023, '2020-04-17', 20790000, N'Chuyển khoản',0, 20790000, N'Đã thanh toán', 'NV03', 'KH18'),
(1024, '2020-04-27', 32290000, N'Chuyển khoản',0, 32290000, N'Đã thanh toán', 'NV04', 'KH19'),
(1025, '2020-05-01', 123778000, N'Tiền mặt', 0, 123778000, N'Đã thanh toán', 'NV01', 'KH20'),
(1026, '2020-05-02', 102900000, N'Tiền mặt', 0, 102900000, N'Đã thanh toán', 'NV02', 'KH21'),
(1027, '2020-05-04', 62070000, N'Chuyển khoản',0, 62070000, N'Đã thanh toán', 'NV03', 'KH22'),
(1028, '2020-05-14', 91370000, N'Chuyển khoản',0, 91370000, N'Đã thanh toán', 'NV04', 'KH23'),
(1029, '2020-06-05', 131970000, N'Tiền mặt', 0, 131970000, N'Đã thanh toán', 'NV01', 'KH24'),
(1030, '2020-06-06', 18990000, N'Tiền mặt', 0, 18990000, N'Đã thanh toán', 'NV02', 'KH25'),
(1031, '2020-06-17', 119960000, N'Chuyển khoản',0, 119960000, N'Đã thanh toán', 'NV03', 'KH26'),
(1032, '2020-06-27', 31690000, N'Chuyển khoản',0, 31690000, N'Đã thanh toán', 'NV04', 'KH27'),
(1033, '2020-06-27', 32997000, N'Chuyển khoản',0, 32997000, N'Đã thanh toán', 'NV04', 'KH28'),
(1034, '2020-06-27', 16990000, N'Chuyển khoản',0, 16990000, N'Đã thanh toán', 'NV04', 'KH29'),
(1035, '2020-07-01', 58970000, N'Tiền mặt', 0, 58970000, N'Đã thanh toán', 'NV01', 'KH30'),
(1036, '2020-07-02', 29380000, N'Tiền mặt', 0, 29380000, N'Đã thanh toán', 'NV02', 'KH31'),
(1037, '2020-07-04', 43996000, N'Chuyển khoản',0, 43996000, N'Đã thanh toán', 'NV03', 'KH32'),
(1038, '2020-07-14', 56070000, N'Chuyển khoản',0, 56070000, N'Đã thanh toán', 'NV04', 'KH33'),
(1039, '2020-07-15', 14690000, N'Tiền mặt', 0, 14690000, N'Đã thanh toán', 'NV01', 'KH34'),
(1040, '2020-07-16', 9290000, N'Tiền mặt', 0, 9290000, N'Đã thanh toán', 'NV02', 'KH35'),
(1041, '2020-08-01', 100930000, N'Chuyển khoản',0, 100930000, N'Đã thanh toán', 'NV03', 'KH36'),
(1042, '2020-08-07', 33580000, N'Chuyển khoản',0, 33580000, N'Đã thanh toán', 'NV04', 'KH37'),
(1043, '2020-08-17', 22390000, N'Chuyển khoản',0, 22390000, N'Đã thanh toán', 'NV04', 'KH38'),
(1044, '2020-08-27', 17980000, N'Chuyển khoản',0, 17980000, N'Đã thanh toán', 'NV04', 'KH39'),
(1045, '2020-09-01', 39980000, N'Tiền mặt', 0, 39980000, N'Đã thanh toán', 'NV01', 'KH40'),
(1046, '2020-09-02', 40990000, N'Tiền mặt', 0, 40990000, N'Đã thanh toán', 'NV02', 'KH41'),
(1047, '2020-09-04', 189980000, N'Chuyển khoản',0, 189980000, N'Đã thanh toán', 'NV03', 'KH42'),
(1048, '2020-09-14', 40690000, N'Chuyển khoản',0, 40690000, N'Đã thanh toán', 'NV04', 'KH43'),
(1049, '2020-09-15', 25990000, N'Tiền mặt', 0, 25990000, N'Đã thanh toán', 'NV01', 'KH44'),
(1050, '2020-09-16', 82360000, N'Tiền mặt', 0, 82360000, N'Đã thanh toán', 'NV02', 'KH45'),
(1051, '2020-10-01', 46880000, N'Chuyển khoản',0, 46880000, N'Đã thanh toán', 'NV03', 'KH46'),
(1052, '2020-10-07', 38990000, N'Chuyển khoản',0, 38990000, N'Đã thanh toán', 'NV04', 'KH47'),
(1053, '2020-10-17', 87980000, N'Chuyển khoản',0, 87980000, N'Đã thanh toán', 'NV04', 'KH48'),
(1054, '2020-10-27', 48980000, N'Chuyển khoản',0, 48980000, N'Đã thanh toán', 'NV04', 'KH49'),  
(1055, '2020-11-01', 94950000, N'Tiền mặt', 0, 94950000, N'Đã thanh toán', 'NV01', 'KH50'),
(1056, '2020-11-02', 29990000, N'Tiền mặt', 0, 29990000, N'Đã thanh toán', 'NV02', 'KH51'),
(1057, '2020-11-04', 63380000, N'Chuyển khoản',0, 63380000, N'Đã thanh toán', 'NV03', 'KH52'),
(1058, '2020-12-01', 10999000, N'Chuyển khoản',0, 10999000, N'Đã thanh toán', 'NV04', 'KH53'),
(1059, '2020-12-02', 16990000, N'Tiền mặt', 0, 16990000, N'Đã thanh toán', 'NV01', 'KH54'),
(1060, '2020-12-09', 105960000, N'Tiền mặt', 0, 105960000, N'Đã thanh toán', 'NV02', 'KH55'),
(1061, '2020-12-10', 59100000, N'Chuyển khoản',0, 59100000, N'Đã thanh toán', 'NV03', 'KH56'),
(1062, '2020-12-12', 16790000, N'Chuyển khoản',0, 16790000, N'Đã thanh toán', 'NV04', 'KH57'),
(1063, '2020-12-23', 41580000, N'Chuyển khoản',0, 41580000, N'Đã thanh toán', 'NV04', 'KH58'), 
(1064, '2020-12-30', 51280000, N'Chuyển khoản',0, 51280000, N'Đã thanh toán', 'NV04', 'KH59'),
(1065, '2021-01-02', 65000000, N'Tiền mặt', 0, 65000000, N'Đã thanh toán', 'NV01', 'KH61'),
(1066, '2021-01-04', 69000000, N'Tiền mặt', 0, 69000000, N'Đã thanh toán', 'NV02', 'KH62'),
(1067, '2021-01-06', 96000000, N'Chuyển khoản',0, 96000000, N'Đã thanh toán', 'NV03', 'KH63'),
(1068, '2021-01-11', 125000000, N'Chuyển khoản',0, 125000000, N'Đã thanh toán', 'NV04', 'KH64'),
(1069, '2021-01-13', 65000000, N'Tiền mặt', 0, 65000000, N'Đã thanh toán', 'NV01', 'KH65'),
(1070, '2021-01-21', 69000000, N'Tiền mặt', 0, 69000000, N'Đã thanh toán', 'NV02', 'KH66'),
(1071, '2021-01-23', 96000000, N'Chuyển khoản',0, 96000000, N'Đã thanh toán', 'NV03', 'KH67'),
(1072, '2021-01-28', 125000000, N'Chuyển khoản',0, 125000000, N'Đã thanh toán', 'NV04', 'KH68'),
(1073, '2021-02-01', 9290000, N'Tiền mặt', 0, 9290000, N'Đã thanh toán', 'NV01', 'KH61'),
(1074, '2021-02-01', 16990000, N'Tiền mặt', 0, 16990000, N'Đã thanh toán', 'NV02', 'KH69'),
(1075, '2021-02-01', 10990000, N'Chuyển khoản',0, 10990000, N'Đã thanh toán', 'NV03', 'KH70'),
(1076, '2021-02-13', 16790000, N'Chuyển khoản',0, 16790000, N'Đã thanh toán', 'NV04', 'KH71'),
(1077, '2021-02-15', 22390000, N'Tiền mặt', 0, 22390000, N'Đã thanh toán', 'NV01', 'KH55'),
(1078, '2021-02-21', 8990000, N'Tiền mặt', 0, 8990000, N'Đã thanh toán', 'NV02', 'KH22'),
(1079, '2021-02-21', 14990000, N'Chuyển khoản',0, 14990000, N'Đã thanh toán', 'NV03', 'KH43'),
(1080, '2021-02-24', 17690000, N'Chuyển khoản',0, 17690000, N'Đã thanh toán', 'NV04', 'KH74'),
(1081, '2021-02-25', 135980000, N'Tiền mặt', 0, 135980000, N'Đã thanh toán', 'NV01', 'KH61'),
(1082, '2021-02-26', 81380000, N'Tiền mặt', 0, 81380000, N'Đã thanh toán', 'NV02', 'KH73'),
(1083, '2021-02-28', 25990000, N'Chuyển khoản',0, 25990000, N'Đã thanh toán', 'NV03', 'KH72'),
(1084, '2021-03-01', 101970000, N'Chuyển khoản',0, 101970000, N'Đã thanh toán', 'NV04', 'KH75'),
(1085, '2021-03-01', 14690000, N'Tiền mặt', 0, 14690000, N'Đã thanh toán', 'NV01', 'KH76'),
(1086, '2021-03-06', 16790000, N'Tiền mặt', 0, 16790000, N'Đã thanh toán', 'NV02', 'KH77'),
(1087, '2021-03-17', 20790000, N'Chuyển khoản',0, 20790000, N'Đã thanh toán', 'NV03', 'KH78'),
(1088, '2021-03-27', 32290000, N'Chuyển khoản',0, 32290000, N'Đã thanh toán', 'NV04', 'KH79'),
(1089, '2021-04-01', 123778000, N'Tiền mặt', 0, 123778000, N'Đã thanh toán', 'NV01', 'KH80'),
(1090, '2021-04-02', 102900000, N'Tiền mặt', 0, 102900000, N'Đã thanh toán', 'NV02', 'KH81'),
(1091, '2021-04-04', 62070000, N'Chuyển khoản',0, 62070000, N'Đã thanh toán', 'NV03', 'KH82'),
(1092, '2021-04-14', 91370000, N'Chuyển khoản',0, 91370000, N'Đã thanh toán', 'NV04', 'KH83'),
(1093, '2021-04-15', 131970000, N'Tiền mặt', 0, 131970000, N'Đã thanh toán', 'NV01', 'KH84'),
(1094, '2021-04-16', 18990000, N'Tiền mặt', 0, 18990000, N'Đã thanh toán', 'NV02', 'KH85'),
(1095, '2021-04-17', 119960000, N'Chuyển khoản',0, 119960000, N'Đã thanh toán', 'NV03', 'KH86'),
(1096, '2021-05-01', 31690000, N'Chuyển khoản',0, 31690000, N'Đã thanh toán', 'NV04', 'KH87'),
(1097, '2021-05-01', 32997000, N'Chuyển khoản',0, 32997000, N'Đã thanh toán', 'NV04', 'KH88'),
(1098, '2021-05-17', 16990000, N'Chuyển khoản',0, 16990000, N'Đã thanh toán', 'NV04', 'KH89'),
(1099, '2021-05-21', 58970000, N'Tiền mặt', 0, 58970000, N'Đã thanh toán', 'NV01', 'KH90'),
(1100, '2021-05-22', 29380000, N'Tiền mặt', 0, 29380000, N'Đã thanh toán', 'NV02', 'KH91'),
(1101, '2021-06-04', 43996000, N'Chuyển khoản',0, 43996000, N'Đã thanh toán', 'NV03', 'KH12'),
(1102, '2021-06-14', 56070000, N'Chuyển khoản',0, 56070000, N'Đã thanh toán', 'NV04', 'KH43'),
(1103, '2021-06-15', 14690000, N'Tiền mặt', 0, 14690000, N'Đã thanh toán', 'NV01', 'KH64'),
(1104, '2021-06-16', 9290000, N'Tiền mặt', 0, 9290000, N'Đã thanh toán', 'NV02', 'KH15'),
(1105, '2021-06-21', 100930000, N'Chuyển khoản',0, 100930000, N'Đã thanh toán', 'NV03', 'KH26'),
(1106, '2021-06-27', 33580000, N'Chuyển khoản',0, 33580000, N'Đã thanh toán', 'NV04', 'KH87'),
(1107, '2021-07-01', 22390000, N'Chuyển khoản',0, 22390000, N'Đã thanh toán', 'NV04', 'KH88'),
(1108, '2021-07-01', 17980000, N'Chuyển khoản',0, 17980000, N'Đã thanh toán', 'NV04', 'KH29'),
(1109, '2021-07-01', 39980000, N'Tiền mặt', 0, 39980000, N'Đã thanh toán', 'NV01', 'KH20'),
(1110, '2021-07-02', 40990000, N'Tiền mặt', 0, 40990000, N'Đã thanh toán', 'NV02', 'KH44'),
(1111, '2021-07-04', 189980000, N'Chuyển khoản',0, 189980000, N'Đã thanh toán', 'NV03', 'KH12'),
(1112, '2021-07-14', 40690000, N'Chuyển khoản',0, 40690000, N'Đã thanh toán', 'NV04', 'KH13'),
(1113, '2021-07-15', 25990000, N'Tiền mặt', 0, 25990000, N'Đã thanh toán', 'NV01', 'KH74'),
(1114, '2021-07-16', 82360000, N'Tiền mặt', 0, 82360000, N'Đã thanh toán', 'NV02', 'KH41'),
(1115, '2021-08-01', 46880000, N'Chuyển khoản',0, 46880000, N'Đã thanh toán', 'NV03', 'KH56'),
(1116, '2021-08-07', 38990000, N'Chuyển khoản',0, 38990000, N'Đã thanh toán', 'NV04', 'KH46'),
(1117, '2021-08-17', 87980000, N'Chuyển khoản',0, 87980000, N'Đã thanh toán', 'NV04', 'KH43'),
(1118, '2021-08-19', 48980000, N'Chuyển khoản',0, 48980000, N'Đã thanh toán', 'NV04', 'KH41'),  
(1119, '2021-08-20', 94950000, N'Tiền mặt', 0, 94950000, N'Đã thanh toán', 'NV01', 'KH10'),
(1120, '2021-09-02', 29990000, N'Tiền mặt', 0, 29990000, N'Đã thanh toán', 'NV02', 'KH31'),
(1121, '2021-09-04', 63380000, N'Chuyển khoản',0, 63380000, N'Đã thanh toán', 'NV03', 'KH72'),
(1122, '2021-09-10', 10999000, N'Chuyển khoản',0, 10999000, N'Đã thanh toán', 'NV04', 'KH91'),
(1123, '2021-09-12', 16990000, N'Tiền mặt', 0, 16990000, N'Đã thanh toán', 'NV01', 'KH90'),
(1124, '2021-09-19', 105960000, N'Tiền mặt', 0, 105960000, N'Đã thanh toán', 'NV02', 'KH15'),
(1125, '2021-10-10', 59100000, N'Chuyển khoản',0, 59100000, N'Đã thanh toán', 'NV03', 'KH53'),
(1126, '2021-10-12', 16790000, N'Chuyển khoản',0, 16790000, N'Đã thanh toán', 'NV04', 'KH51'),
(1127, '2021-10-23', 41580000, N'Chuyển khoản',0, 41580000, N'Đã thanh toán', 'NV04', 'KH18'), 
(1128, '2021-10-30', 51280000, N'Chuyển khoản',0, 51280000, N'Đã thanh toán', 'NV04', 'KH49'),
(1129, '2021-11-01', 65000000, N'Tiền mặt', 0, 65000000, N'Đã thanh toán', 'NV01', 'KH41'),
(1130, '2021-11-02', 69000000, N'Tiền mặt', 0, 69000000, N'Đã thanh toán', 'NV02', 'KH52'),
(1131, '2021-11-04', 96000000, N'Chuyển khoản',0, 96000000, N'Đã thanh toán', 'NV03', 'KH13'),
(1132, '2021-11-14', 125000000, N'Chuyển khoản',0, 125000000, N'Đã thanh toán', 'NV04', 'KH84'),
(1133, '2021-11-15', 65000000, N'Tiền mặt', 0, 65000000, N'Đã thanh toán', 'NV01', 'KH15'),
(1134, '2021-11-26', 69000000, N'Tiền mặt', 0, 69000000, N'Đã thanh toán', 'NV02', 'KH26'),
(1135, '2021-11-27', 96000000, N'Chuyển khoản',0, 96000000, N'Đã thanh toán', 'NV03', 'KH37'),
(1136, '2021-11-27', 125000000, N'Chuyển khoản',0, 125000000, N'Đã thanh toán', 'NV04', 'KH48'),
(1137, '2021-12-01', 9290000, N'Tiền mặt', 0, 9290000, N'Đã thanh toán', 'NV01', 'KH61'),
(1138, '2021-12-02', 16990000, N'Tiền mặt', 0, 16990000, N'Đã thanh toán', 'NV02', 'KH79'),
(1139, '2021-12-04', 10990000, N'Chuyển khoản',0, 10990000, N'Đã thanh toán', 'NV03', 'KH80'),
(1140, '2021-12-14', 16790000, N'Chuyển khoản',0, 16790000, N'Đã thanh toán', 'NV04', 'KH81'),
(1141, '2021-12-15', 22390000, N'Tiền mặt', 0, 22390000, N'Đã thanh toán', 'NV01', 'KH15'),
(1142, '2021-12-26', 8990000, N'Tiền mặt', 1798000, 7192000, N'Đã thanh toán', 'NV02', 'KH02'),
(1143, '2021-12-27', 14990000, N'Chuyển khoản',2998000, 11992000, N'Đã thanh toán', 'NV03', 'KH23'),
(1144, '2021-12-27', 17690000, N'Chuyển khoản',3538000, 14152000, N'Đã thanh toán', 'NV04', 'KH34'),
(1145, '2022-01-01', 135980000, N'Tiền mặt', 18998000, 116982000, N'Đã thanh toán', 'NV01', 'KH42'),
(1146, '2022-01-02', 81380000, N'Tiền mặt', 0, 81380000, N'Đã thanh toán', 'NV02', 'KH53'),
(1147, '2022-01-04', 25990000, N'Chuyển khoản',0, 25990000, N'Đã thanh toán', 'NV03', 'KH64'),
(1148, '2022-01-14', 101970000, N'Chuyển khoản',0, 101970000, N'Đã thanh toán', 'NV04', 'KH75'),
(1149, '2022-02-05', 14690000, N'Tiền mặt', 0, 14690000, N'Đã thanh toán', 'NV01', 'KH86'),
(1150, '2022-02-06', 16790000, N'Tiền mặt', 0, 16790000, N'Đã thanh toán', 'NV02', 'KH07'),
(1151, '2022-02-17', 20790000, N'Chuyển khoản',0, 20790000, N'Đã thanh toán', 'NV03', 'KH28'),
(1152, '2022-02-27', 32290000, N'Chuyển khoản',0, 32290000, N'Đã thanh toán', 'NV04', 'KH39'),
(1153, '2022-03-01', 123778000, N'Tiền mặt', 0, 123778000, N'Đã thanh toán', 'NV01', 'KH10'),
(1154, '2022-03-02', 102900000, N'Tiền mặt', 0, 102900000, N'Đã thanh toán', 'NV02', 'KH41'),
(1155, '2022-03-04', 62070000, N'Chuyển khoản',0, 62070000, N'Đã thanh toán', 'NV03', 'KH52'),
(1156, '2022-03-14', 91370000, N'Chuyển khoản',0, 91370000, N'Đã thanh toán', 'NV04', 'KH63'),
(1157, '2022-04-05', 131970000, N'Tiền mặt', 0, 131970000, N'Đã thanh toán', 'NV01', 'KH74'),
(1158, '2022-04-06', 18990000, N'Tiền mặt', 0, 18990000, N'Đã thanh toán', 'NV02', 'KH85'),
(1159, '2022-04-17', 119960000, N'Chuyển khoản',0, 119960000, N'Đã thanh toán', 'NV03', 'KH06'),
(1160, '2022-04-27', 31690000, N'Chuyển khoản',0, 31690000, N'Đã thanh toán', 'NV04', 'KH17'),
(1161, '2022-04-27', 32997000, N'Chuyển khoản',0, 32997000, N'Đã thanh toán', 'NV04', 'KH38'),
(1162, '2022-04-27', 16990000, N'Chuyển khoản',0, 16990000, N'Đã thanh toán', 'NV04', 'KH49'),
(1163, '2022-05-01', 58970000, N'Tiền mặt', 0, 58970000, N'Đã thanh toán', 'NV01', 'KH20'),
(1164, '2022-05-02', 29380000, N'Tiền mặt', 0, 29380000, N'Đã thanh toán', 'NV02', 'KH51'),
(1165, '2022-05-04', 43996000, N'Chuyển khoản',8799200, 35196800, N'Đã thanh toán', 'NV03', 'KH62'),
(1166, '2022-05-14', 56070000, N'Chuyển khoản',0, 56070000, N'Đã thanh toán', 'NV04', 'KH23'),
(1167, '2022-05-15', 14690000, N'Tiền mặt', 0, 14690000, N'Đã thanh toán', 'NV01', 'KH44'),
(1168, '2022-05-16', 9290000, N'Tiền mặt', 0, 9290000, N'Đã thanh toán', 'NV02', 'KH15'),
(1169, '2022-06-01', 100930000, N'Chuyển khoản',0, 100930000, N'Đã thanh toán', 'NV03', 'KH26'),
(1170, '2022-06-07', 33580000, N'Chuyển khoản',0, 33580000, N'Đã thanh toán', 'NV04', 'KH47'),
(1171, '2022-06-17', 22390000, N'Chuyển khoản',0, 22390000, N'Đã thanh toán', 'NV04', 'KH18'),
(1172, '2022-06-27', 17980000, N'Chuyển khoản',0, 17980000, N'Đã thanh toán', 'NV04', 'KH29'),
(1173, '2022-07-01', 39980000, N'Tiền mặt', 0, 39980000, N'Đã thanh toán', 'NV01', 'KH30'),
(1174, '2022-07-02', 40990000, N'Tiền mặt', 0, 40990000, N'Đã thanh toán', 'NV02', 'KH31'),
(1175, '2022-07-04', 189980000, N'Chuyển khoản',0, 189980000, N'Đã thanh toán', 'NV03', 'KH12'),
(1176, '2022-07-14', 40690000, N'Chuyển khoản',0, 40690000, N'Đã thanh toán', 'NV04', 'KH33'),
(1177, '2022-07-15', 25990000, N'Tiền mặt', 0, 25990000, N'Đã thanh toán', 'NV01', 'KH34'),
(1178, '2022-07-16', 82360000, N'Tiền mặt', 0, 82360000, N'Đã thanh toán', 'NV02', 'KH15'),
(1179, '2022-08-01', 46880000, N'Chuyển khoản',0, 46880000, N'Đã thanh toán', 'NV03', 'KH16'),
(1180, '2022-08-07', 38990000, N'Chuyển khoản',0, 38990000, N'Đã thanh toán', 'NV04', 'KH91'),
(1181, '2022-08-17', 87980000, N'Chuyển khoản',0, 87980000, N'Đã thanh toán', 'NV04', 'KH28'),
(1182, '2022-08-27', 48980000, N'Chuyển khoản',0, 48980000, N'Đã thanh toán', 'NV04', 'KH39'),  
(1183, '2022-09-01', 94950000, N'Tiền mặt', 0, 94950000, N'Đã thanh toán', 'NV01', 'KH10'),
(1184, '2022-09-02', 29990000, N'Tiền mặt', 0, 29990000, N'Đã thanh toán', 'NV02', 'KH21'),
(1185, '2022-09-04', 63380000, N'Chuyển khoản',0, 63380000, N'Đã thanh toán', 'NV03', 'KH32'),
(1186, '2022-10-01', 10999000, N'Chuyển khoản',2199800, 8799200, N'Đã thanh toán', 'NV04', 'KH43'),
(1187, '2022-10-02', 16990000, N'Tiền mặt', 0, 16990000, N'Đã thanh toán', 'NV01', 'KH64'),
(1188, '2022-10-09', 105960000, N'Tiền mặt', 0, 105960000, N'Đã thanh toán', 'NV02', 'KH15'),
(1189, '2022-10-10', 59100000, N'Chuyển khoản',0, 59100000, N'Đã thanh toán', 'NV03', 'KH26'),
(1190, '2022-10-12', 16790000, N'Chuyển khoản',0, 16790000, N'Đã thanh toán', 'NV04', 'KH67'),
(1191, '2022-10-23', 41580000, N'Chuyển khoản',0, 41580000, N'Đã thanh toán', 'NV04', 'KH78'), 
(1192, '2022-10-30', 51280000, N'Chuyển khoản',0, 51280000, N'Đã thanh toán', 'NV04', 'KH89')


--15) Chi tiết hoá đơn --
INSERT INTO Tbl_ChiTietHoaDon VALUES 
(1, 21000000, 21000000, 2100000, 'SP001', 1001),
(2, 22000000, 44000000, 4400000, 'SP002', 1001),
(3, 23000000, 69000000, 6900000, 'SP003', 1002),
(4, 24000000, 96000000, 0, 'SP004', 1003),
(5, 25000000, 125000000, 0, 'SP005', 1004),
(1, 21000000, 21000000, 0, 'SP001', 1005),
(2, 22000000, 44000000, 0, 'SP002', 1005),
(3, 23000000, 69000000, 0, 'SP003', 1006),
(4, 24000000, 96000000, 0, 'SP004', 1007),
(5, 25000000, 125000000, 0, 'SP005', 1008),
(1, 9290000, 9290000, 0, 'SP043', 1009),
(1, 96000000, 96000000, 0, 'SP044', 1010),
(1, 10990000, 10990000, 0, 'SP045', 1011),
(1, 16790000, 16790000, 0, 'SP046', 1012),
(1, 22390000, 22390000, 0, 'SP047', 1013),
(1, 8990000, 8990000, 0, 'SP048', 1014),
(1, 14990000, 14990000, 0, 'SP049', 1015),
(1, 17690000, 17690000, 0, 'SP050', 1016),
(1, 40990000, 40990000, 0, 'SP011', 1017),
(1, 94990000, 94990000, 0, 'SP012', 1017),
(2, 40690000, 81380000, 0, 'SP013', 1018),
(1, 25990000, 25990000, 0, 'SP014', 1019),
(1, 19990000, 19990000, 0, 'SP010', 1020),
(2, 40990000, 81980000,  0, 'SP011', 1020),
(1, 14690000, 14690000, 2938000, 'SP009', 1021),
(1, 16790000, 16790000, 0, 'SP030', 1022),
(1, 20790000, 20790000, 0, 'SP031', 1023),
(1, 32290000, 32290000, 0, 'SP032', 1024),
(2, 27899000 ,55798000,  0, 'SP006', 1025),
(2, 33990000,67980000,  0, 'SP007', 1025),
(1, 102900000, 102900000, 0, 'SP008', 1026),
(3, 20690000, 62070000, 0, 'SP017', 1027),
(2, 26190000, 52380000, 0, 'SP018', 1028),
(1, 38990000, 38990000, 0, 'SP019', 1028),
(3, 43990000, 131970000, 0, 'SP020', 1029),
(1, 18990000, 18990000, 0, 'SP021', 1030),
(4,29990000, 119960000,  0, 'SP022', 1031),
(1, 31690000, 31690000, 0, 'SP023', 1032),
(3, 10999000, 32997000, 0, 'SP024', 1033),
(1, 16990000, 16990000, 0, 'SP025', 1034),
(1, 29990000, 29990000, 0, 'SP037', 1035),
(2, 14490000, 28980000, 0, 'SP038', 1035),
(2, 14690000, 29380000, 0, 'SP039', 1036),
(4, 10999000, 43996000, 0, 'SP040', 1037),
(3, 18690000, 56070000, 0, 'SP041', 1038),
(1, 14690000, 14690000, 0, 'SP042', 1039),
(2, 9290000, 9290000, 0, 'SP043', 1040),
(4, 16990000, 67960000, 0, 'SP044', 1041),
(3, 10990000, 32970000, 0, 'SP045', 1041),
(2, 16790000, 33580000, 0, 'SP046', 1042),
(1, 22390000, 22390000, 0, 'SP047', 1043),
(2, 8990000, 17980000, 0, 'SP048', 1044),
(2, 19990000, 39980000, 0, 'SP010', 1045),
(1, 40990000, 40990000, 0, 'SP011', 1046),
(2, 94990000, 189980000, 0, 'SP012', 1047),
(1, 40690000, 40690000, 0, 'SP013', 1048),
(1, 25990000, 25990000, 0, 'SP014', 1049),
(2, 22590000, 45180000, 0, 'SP015', 1050),
(2, 18590000, 37180000, 0, 'SP016', 1050),
(1, 20690000, 20690000, 0, 'SP017', 1051),
(1, 26190000, 26190000, 0, 'SP018', 1051),
(1, 38990000, 38990000, 0, 'SP019', 1052),
(2, 43990000, 87980000, 0, 'SP020', 1053),
(1, 18990000, 18990000, 0, 'SP021', 1054),
(1, 29990000, 29990000, 0, 'SP022', 1054), 
(5, 18990000, 94950000, 0, 'SP021', 1055),
(1, 29990000, 29990000, 0, 'SP022', 1056),
(2, 31690000, 63380000, 0, 'SP023', 1057),
(1, 10999000, 10999000, 0, 'SP024', 1058),
(1, 16990000, 16990000, 0, 'SP025', 1059),
(2, 22990000, 45980000, 0, 'SP026', 1060),
(2, 29990000, 59980000, 0, 'SP027', 1060),
(1, 29550000, 29550000, 0, 'SP028', 1061),
(1, 29550000, 29550000, 0, 'SP029', 1061),
(1, 16790000, 16790000, 0, 'SP030', 1062),
(2, 20790000, 41580000, 0, 'SP031', 1063),
(1, 18990000, 18990000, 0, 'SP021', 1064),
(1, 32290000, 32290000, 0, 'SP032', 1064),
(1, 21000000, 21000000, 0, 'SP001', 1065),
(2, 22000000, 44000000, 0, 'SP002', 1065),
(3, 23000000, 69000000, 0, 'SP003', 1066),
(4, 24000000, 96000000, 0, 'SP004', 1067),
(5, 25000000, 125000000, 0, 'SP005', 1068),
(1, 21000000, 21000000, 0, 'SP001', 1069),
(2, 22000000, 44000000, 0, 'SP002', 1069),
(3, 23000000, 69000000, 0, 'SP003', 1070),
(4, 24000000, 96000000, 0, 'SP004', 1071),
(5, 25000000, 125000000, 0, 'SP005', 1072),
(1, 9290000, 9290000, 0, 'SP043', 1073),
(1, 96000000, 96000000, 0, 'SP044', 1074),
(1, 10990000, 10990000, 0, 'SP045', 1075),
(1, 16790000, 16790000, 0, 'SP046', 1076),
(1, 22390000, 22390000, 0, 'SP047', 1077),
(1, 8990000, 8990000, 0, 'SP048', 1078),
(1, 14990000, 14990000, 0, 'SP049', 1079),
(1, 17690000, 17690000, 0, 'SP050', 1080),
(1, 40990000, 40990000, 0, 'SP011', 1081),
(1, 94990000, 94990000, 0, 'SP012', 1081),
(2, 40690000, 81380000, 0, 'SP013', 1082),
(1, 25990000, 25990000, 0, 'SP014', 1083),
(1, 19990000, 19990000, 0, 'SP010', 1084),
(2, 40990000, 81980000,  0, 'SP011', 1084),
(1, 14690000, 14690000, 0, 'SP009', 1085),
(1, 16790000, 16790000, 0, 'SP030', 1086),
(1, 20790000, 20790000, 0, 'SP031', 1087),
(1, 32290000, 32290000, 0, 'SP032', 1088),
(2, 27899000 ,55798000,  0, 'SP006', 1089),
(2, 33990000,67980000,  0, 'SP007', 1089),
(1, 102900000, 102900000, 0, 'SP008', 1090),
(3, 20690000, 62070000, 0, 'SP017', 1091),
(2, 26190000, 52380000, 0, 'SP018', 1092),
(1, 38990000, 38990000, 0, 'SP019', 1092),
(3, 43990000, 131970000, 0, 'SP020', 1093),
(1, 18990000, 18990000, 0, 'SP021', 1094),
(4,29990000, 119960000,  0, 'SP022', 1095),
(1, 31690000, 31690000, 0, 'SP023', 1096),
(3, 10999000, 32997000, 0, 'SP024', 1097),
(1, 16990000, 16990000, 0, 'SP025', 1098),
(1, 29990000, 29990000, 0, 'SP037', 1099),
(2, 14490000, 28980000, 0, 'SP038', 1099),
(2, 14690000, 29380000, 0, 'SP039', 1100),
(4, 10999000, 43996000, 0, 'SP040', 1101),
(3, 18690000, 56070000, 0, 'SP041', 1102),
(1, 14690000, 14690000, 0, 'SP042', 1103),
(2, 9290000, 9290000, 0, 'SP043', 1104),
(4, 16990000, 67960000, 0, 'SP044', 1105),
(3, 10990000, 32970000, 0, 'SP045', 1105),
(2, 16790000, 33580000, 0, 'SP046', 1106),
(1, 22390000, 22390000, 0, 'SP047', 1107),
(2, 8990000, 17980000, 0, 'SP048', 1108),
(2, 19990000, 39980000, 0, 'SP010', 1109),
(1, 40990000, 40990000, 0, 'SP011', 1110),
(2, 94990000, 189980000, 0, 'SP012', 1111),
(1, 40690000, 40690000, 0, 'SP013', 1112),
(1, 25990000, 25990000, 0, 'SP014', 1113),
(2, 22590000, 45180000, 0, 'SP015', 1114),
(2, 18590000, 37180000, 0, 'SP016', 1114),
(1, 20690000, 20690000, 0, 'SP017', 1115),
(1, 26190000, 26190000, 0, 'SP018', 1115),
(1, 38990000, 38990000, 0, 'SP019', 1116),
(2, 43990000, 87980000, 0, 'SP020', 1117),
(1, 18990000, 18990000, 0, 'SP021', 1118),
(1, 29990000, 29990000, 0, 'SP022', 1118), 
(5, 18990000, 94950000, 0, 'SP021', 1119),
(1, 29990000, 29990000, 0, 'SP022', 1120),
(2, 31690000, 63380000, 0, 'SP023', 1121),
(1, 10999000, 10999000, 0, 'SP024', 1122),
(1, 16990000, 16990000, 0, 'SP025', 1123),
(2, 22990000, 45980000, 0, 'SP026', 1124),
(2, 29990000, 59980000, 0, 'SP027', 1124),
(1, 29550000, 29550000, 0, 'SP028', 1125),
(1, 29550000, 29550000, 0, 'SP029', 1125),
(1, 16790000, 16790000, 0, 'SP030', 1126),
(2, 20790000, 41580000, 0, 'SP031', 1127),
(1, 18990000, 18990000, 0, 'SP021', 1128),
(1, 32290000, 32290000, 0, 'SP032', 1128),
(1, 21000000, 21000000, 0, 'SP001', 1129),
(2, 22000000, 44000000, 0, 'SP002', 1129),
(3, 23000000, 69000000, 0, 'SP003', 1130),
(4, 24000000, 96000000, 0, 'SP004', 1131),
(5, 25000000, 125000000, 0, 'SP005', 1132),
(1, 21000000, 21000000, 0, 'SP001', 1133),
(2, 22000000, 44000000, 0, 'SP002', 1133),
(3, 23000000, 69000000, 0, 'SP003', 1134),
(4, 24000000, 96000000, 0, 'SP004', 1135),
(5, 25000000, 125000000, 0, 'SP005', 1136),
(1, 9290000, 9290000, 0, 'SP043', 1137),
(1, 96000000, 96000000, 0, 'SP044', 1138),
(1, 10990000, 10990000, 0, 'SP045', 1139),
(1, 16790000, 16790000, 0, 'SP046', 1140),
(1, 22390000, 22390000, 0, 'SP047', 1141),
(1, 8990000, 8990000, 1798000, 'SP048', 1142),
(1, 14990000, 14990000, 2998000, 'SP049', 1143),
(1, 17690000, 17690000, 3538000, 'SP050', 1144),
(1, 40990000, 40990000, 0, 'SP011', 1145),
(1, 94990000, 94990000, 18998000, 'SP012', 1145),
(2, 40690000, 81380000, 0, 'SP013', 1146),
(1, 25990000, 25990000, 0, 'SP014', 1147),
(1, 19990000, 19990000, 0, 'SP010', 1148),
(2, 40990000, 81980000,  0, 'SP011', 1148),
(1, 14690000, 14690000, 0, 'SP009', 1149),
(1, 16790000, 16790000, 0, 'SP030', 1150),
(1, 20790000, 20790000, 0, 'SP031', 1151),
(1, 32290000, 32290000, 0, 'SP032', 1152),
(2, 27899000 ,55798000,  0, 'SP006', 1153),
(2, 33990000,67980000,  0, 'SP007', 1153),
(1, 102900000, 102900000, 0, 'SP008', 1154),
(3, 20690000, 62070000, 0, 'SP017', 1155),
(2, 26190000, 52380000, 0, 'SP018', 1156),
(1, 38990000, 38990000, 0, 'SP019', 1156),
(3, 43990000, 131970000, 0, 'SP020', 1157),
(1, 18990000, 18990000, 0, 'SP021', 1158),
(4,29990000, 119960000,  0, 'SP022', 1159),
(1, 31690000, 31690000, 0, 'SP023', 1160),
(3, 10999000, 32997000, 0, 'SP024', 1161),
(1, 16990000, 16990000, 0, 'SP025', 1162),
(1, 29990000, 29990000, 0, 'SP037', 1163),
(2, 14490000, 28980000, 0, 'SP038', 1163),
(2, 14690000, 29380000, 0, 'SP039', 1164),
(4, 10999000, 43996000, 8799200, 'SP040', 1165),
(3, 18690000, 56070000, 0, 'SP041', 1166),
(1, 14690000, 14690000, 0, 'SP042', 1167),
(2, 9290000, 9290000, 0, 'SP043', 1168),
(4, 16990000, 67960000, 0, 'SP044', 1169),
(3, 10990000, 32970000, 0, 'SP045', 1169),
(2, 16790000, 33580000, 0, 'SP046', 1170),
(1, 22390000, 22390000, 0, 'SP047', 1171),
(2, 8990000, 17980000, 0, 'SP048', 1172),
(2, 19990000, 39980000, 0, 'SP010', 1173),
(1, 40990000, 40990000, 0, 'SP011', 1174),
(2, 94990000, 189980000, 0, 'SP012', 1175),
(1, 40690000, 40690000, 0, 'SP013', 1176),
(1, 25990000, 25990000, 0, 'SP014', 1177),
(2, 22590000, 45180000, 0, 'SP015', 1178),
(2, 18590000, 37180000, 0, 'SP016', 1178),
(1, 20690000, 20690000, 0, 'SP017', 1179),
(1, 26190000, 26190000, 0, 'SP018', 1179),
(1, 38990000, 38990000, 0, 'SP019', 1180),
(2, 43990000, 87980000, 0, 'SP020', 1181),
(1, 18990000, 18990000, 0, 'SP021', 1182),
(1, 29990000, 29990000, 0, 'SP022', 1182), 
(5, 18990000, 94950000, 0, 'SP021', 1183),
(1, 29990000, 29990000, 0, 'SP022', 1184),
(2, 31690000, 63380000, 0, 'SP023', 1185),
(1, 10999000, 10999000, 2199800, 'SP024', 1186),
(1, 16990000, 16990000, 0, 'SP025', 1187),
(2, 22990000, 45980000, 0, 'SP026', 1188),
(2, 29990000, 59980000, 0, 'SP027', 1188),
(1, 29550000, 29550000, 0, 'SP028', 1189),
(1, 29550000, 29550000, 0, 'SP029', 1189),
(1, 16790000, 16790000, 0, 'SP030', 1190),
(2, 20790000, 41580000, 0, 'SP031', 1191),
(1, 18990000, 18990000, 0, 'SP021', 1192),
(1, 32290000, 32290000, 0, 'SP032', 1192)

