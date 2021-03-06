USE [master]
GO
/****** Object:  Database [QLBH_Maytinh]    Script Date: 4/23/2019 9:41:43 PM ******/
CREATE DATABASE [QLBH_Maytinh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH_Maytinh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLBH_Maytinh.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLBH_Maytinh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLBH_Maytinh_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBH_Maytinh] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH_Maytinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH_Maytinh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLBH_Maytinh] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH_Maytinh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH_Maytinh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH_Maytinh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH_Maytinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH_Maytinh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBH_Maytinh] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH_Maytinh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH_Maytinh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH_Maytinh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH_Maytinh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLBH_Maytinh]
GO
/****** Object:  User [thao]    Script Date: 4/23/2019 9:41:43 PM ******/
CREATE USER [thao] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [huy]    Script Date: 4/23/2019 9:41:43 PM ******/
CREATE USER [huy] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Ha1997]    Script Date: 4/23/2019 9:41:43 PM ******/
CREATE USER [Ha1997] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Ha]    Script Date: 4/23/2019 9:41:43 PM ******/
CREATE USER [Ha] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  StoredProcedure [dbo].[cau1]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cau1]
(@mahh varchar(9),
@tenhh nvarchar(50),
@loaihang nvarchar(50),
@soluong int,
@mancc varchar(9)
)
as begin
	if(exists(select * from hanghoa where mahh = @mahh))
		print(N'Tên hàng trùng')
	else if @soluong < 0
		print(N'Số lượng phải lớn hơn 0')
	else
		insert into hanghoa 
		values (@mahh, @tenhh, @loaihang, @soluong, @mancc)
	END;
GO
/****** Object:  StoredProcedure [dbo].[HH_NCC]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HH_NCC]
@tenncc nvarchar(50)
as
begin
	select hanghoa.tenhh,nhacungcap.tenncc
	from hanghoa inner join nhacungcap on hanghoa.mancc = nhacungcap.mancc
	where tenncc = @tenncc
end;
GO
/****** Object:  StoredProcedure [dbo].[KH_Mua]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KH_Mua]
@thang int
as
select tenkh, sum(hanghoa_xuat.giaxuat * hanghoa_xuat.slxuat) as tong 
from ((khachhang inner join hoadonxuat on khachhang.makh = hoadonxuat.makh) inner join
 hanghoa_xuat on hoadonxuat.mahdx = hanghoa_xuat.mahdx)
where month(ngayxuat) = @thang 
group by khachhang.tenkh
having sum(hanghoa_xuat.giaxuat * hanghoa_xuat.slxuat)> 5000000;
GO
/****** Object:  StoredProcedure [dbo].[nhanvien_noio]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhanvien_noio]
@diachi nvarchar(50)
as
begin
select manv,tennv,ngaysinh,gioitinh,diachi
from nhanvien
where diachi = @diachi
end;
GO
/****** Object:  StoredProcedure [dbo].[pr_nhaphang]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_nhaphang]
@mahh varchar(9),
@tenhh nvarchar(50),
@loaihang nvarchar(50),
@soluong int,
@mancc varchar(9)
AS
BEGIN
	
	INSERT INTO hanghoa
	VALUES(@mahh,@tenhh,@loaihang,@soluong,@mancc)
END	;
GO
/****** Object:  StoredProcedure [dbo].[proc_rp_hoadonnhap]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_rp_hoadonnhap]
@mahdn nvarchar(9)
as
begin
select hanghoa.mahh,hanghoa.tenhh,gianhap,slnhap,thanhtien
from hanghoa_nhap inner join hanghoa
on hanghoa_nhap.mahh=hanghoa.mahh
where mahdn = @mahdn
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_rp_hoadonxuat]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_rp_hoadonxuat]
@mahdx nvarchar(9)
as
begin
select hanghoa.mahh,hanghoa.tenhh,giaxuat,slxuat,thanhtien
from hanghoa_xuat inner join hanghoa
on hanghoa_xuat.mahh=hanghoa.mahh
where mahdx = @mahdx
end;
GO
/****** Object:  StoredProcedure [dbo].[proc_rp_tktheoquy]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_rp_tktheoquy]
@nam int
as
SELECT 
        SUM(CASE  WHEN MONTH(Ngayxuat) in (1,2,3 )THEN tongtien
            ELSE 0 END) AS N'Qúy 1',
        SUM(CASE WHEN  MONTH(Ngayxuat) in ( 4,5,6) THEN tongtien
            ELSE 0 END) AS N'Qúy 2',
        SUM(CASE WHEN MONTH(Ngayxuat) in (7,8,9) THEN tongtien
            ELSE 0 END) AS N'Qúy 3',
        SUM(CASE WHEN  MONTH(Ngayxuat) in (10,11,12) THEN tongtien
            ELSE 0 END) AS N'Qúy 4'
from hoadonxuat where year(ngayxuat)=@nam
GO
/****** Object:  StoredProcedure [dbo].[proc_rp_thongkehangton]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_rp_thongkehangton]
as
select mahh, tenhh, soluong, nhacungcap.tenncc
from hanghoa inner join nhacungcap
on hanghoa.mancc = nhacungcap.mancc
where soluong >0
GO
/****** Object:  StoredProcedure [dbo].[sp_LayNhanVienCoTuoi]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayNhanVienCoTuoi]
@a int
as
	select * from nhanvien  where Year(Getdate()) - year(ngaysinh) > @a;
GO
/****** Object:  StoredProcedure [dbo].[SP_tuoinv]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_tuoinv]
as
select max(year(getdate())-year(ngaysinh)) as 'So Tuoi'
from nhanvien;
GO
/****** Object:  StoredProcedure [dbo].[sp_Them_HHN]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Them_HHN]
@mahdn varchar(9),
@mahh varchar(9),
@gianhap float,
@slnhap int,
@thanhtien float
as
	begin
	insert into hanghoa_nhap
	values (@mahdn, @mahh, @gianhap, @slnhap,@thanhtien)
	end;
	
GO
/****** Object:  StoredProcedure [dbo].[sp_Them_HHX]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Them_HHX]
@mahdx varchar(9),
@mahh varchar(9),
@giaxuat float,
@slxuat int,
@thanhtien float
as
	begin
	if(exists (select * from hanghoa_xuat where @mahdx = mahdx and @mahh=mahh))
		begin
		print N'Đã tồn tại'
		end
	else
	insert into hanghoa_xuat 
	values (@mahdx, @mahh, @giaxuat, @slxuat,@thanhtien)
	end;
GO
/****** Object:  StoredProcedure [dbo].[Sua_DiachiNV]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sua_DiachiNV]
@manv varchar(9),
@diachi nvarchar(50)
as
begin
if(exists (select * from nhanvien where @manv = manv))
begin
update nhanvien
set diachi=@diachi
where manv=@manv
end
end;
GO
/****** Object:  StoredProcedure [dbo].[sua_nv]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sua_nv]
@manv nvarchar (50),
@tennv nvarchar(50),
@ngaysinh smalldatetime,
@gioitinh nvarchar(3),
@diachi nvarchar(50),
@sdt varchar(11),
@cmnd varchar(9)
as begin
	update nhanvien
	set 
	tennv=@tennv,
	ngaysinh=@ngaysinh,
	gioitinh=@gioitinh,
	diachi=@diachi,
	sdt=@sdt,
	cmnd = @cmnd
	where manv = @manv
end;
GO
/****** Object:  StoredProcedure [dbo].[Sua_Tenhang]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sua_Tenhang]
@mahh varchar(9),
@tenhh nvarchar(50)
as
begin
if(exists (select * from hanghoa where @mahh = mahh))
begin
update hanghoa
set tenhh=@tenhh
where mahh=@mahh
end
end;
GO
/****** Object:  StoredProcedure [dbo].[tongtien]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tongtien]
@thang int,
@nam int
as
begin
	select SUM(giaxuat * slxuat) as N'Tổng tiền bán' from hanghoa_xuat hhx, hoadonxuat hdx
	where hhx.mahdx = hdx.mahdx and
	month(ngayxuat) = @thang and year(ngayxuat) = @nam
end;

GO
/****** Object:  StoredProcedure [dbo].[them_hdn]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[them_hdn]
@mahdn varchar(9),
@ngaynhap smalldatetime,
@manv nvarchar(50),
@tongtien float
as
Begin
	if(exists (select * from hoadonnhap where @mahdn = mahdn))
		begin
		print N'Đã tồn tại hóa đơn nhập'
		end
	else
		insert into hoadonnhap
		values (@mahdn, @ngaynhap, @manv,@tongtien)
end;
GO
/****** Object:  StoredProcedure [dbo].[them_HDX]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[them_HDX]
@mahdx varchar(9),
@tenkh nvarchar(50),
@diachikh nvarchar(50),
@sdtkh nvarchar(11),
@ngayxuat date,
@manv nvarchar(50),
@tongtien float
as
Begin
	if(exists (select * from hoadonxuat where @mahdx = mahdx))
		begin
		print N'Đã tồn tại hóa đơn xuất'
		end
	else
		insert into hoadonxuat
		values (@mahdx,@tenkh,@diachikh,@sdtkh,@ngayxuat,@manv,@tongtien)
end;
GO
/****** Object:  StoredProcedure [dbo].[them_KH]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_KH]
@makh varchar (9),
@tenkh nvarchar(50),
@diachi nvarchar(50),
@sdt varchar(11)
as
Begin
	if(exists (select * from khachhang where @makh = makh))
		begin
		print N'Đã tồn tại khách hàng'
		end
	else
		insert into khachhang
		values (@makh, @tenkh, @diachi, @sdt)
end;
GO
/****** Object:  StoredProcedure [dbo].[them_NCC]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_NCC]
@mancc varchar(9),
@tenncc nvarchar(50),
@diachi nvarchar(50),
@sdt varchar(11)
as
Begin
	if(exists (select * from nhacungcap where @mancc = mancc))
		begin
		print N'Đã tồn tại nhà cung cấp'
		end
	else
		insert into nhacungcap
		values (@mancc, @tenncc, @diachi, @sdt)
end;
GO
/****** Object:  StoredProcedure [dbo].[themnv]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themnv]
@manv varchar(9),
@tennv nvarchar(50),
@ngaysinh date,
@gioitinh nvarchar(3),
@diachi nvarchar(50),
@sdt varchar(11),
@cmnd varchar(9)
as
Begin
	if(exists (select * from nhanvien where @manv = manv))
		begin
		print N'Đã tồn tại nhân viên'
		end
	else
		insert into nhanvien
		values (@manv, @tennv, @ngaysinh, @gioitinh,@diachi,@sdt,@cmnd)
		end;
GO
/****** Object:  StoredProcedure [dbo].[thongke_thang]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thongke_thang]
@thang int,
@nam int
as
begin
	select SUM(giaxuat * slxuat)as N'Tổng tiền' from hanghoa_xuat hhx, hoadonxuat hdx
	where hhx.mahdx = hdx.mahdx and
	month(ngayxuat) = @thang and year(ngayxuat) = @nam
end;
GO
/****** Object:  StoredProcedure [dbo].[thongkenhap_thang]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thongkenhap_thang]
@thang int,
@nam int
as
begin
	select SUM(gianhap * slnhap)as N'Tổng tiền' from hanghoa_nhap hhn, hoadonnhap hdn
	where hhn.mahdn = hdn.mahdn and
	month(ngaynhap) = @thang and year(ngaynhap) = @nam
end;
GO
/****** Object:  StoredProcedure [dbo].[update_hh]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_hh]
@mahh varchar(9),
@tenhh nvarchar(50),
@loaihang nvarchar(50),
@soluong int,
@mancc varchar(9)
as begin
	update hanghoa
	set 
		tenhh= @tenhh,
		loaihang =@loaihang,
		soluong=@soluong,
		mancc=@mancc
	where mahh = @mahh
end;

GO
/****** Object:  StoredProcedure [dbo].[Update_KH]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_KH]
@makh varchar (9),
@tenkh nvarchar(50),
@diachi nvarchar(50),
@sdt varchar(11)
as begin
	update khachhang
	set makh = @makh,
		tenkh= @tenkh,
		diachi =@diachi,
		sdt=@sdt
	where makh = @makh
end;
GO
/****** Object:  StoredProcedure [dbo].[update_ncc]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_ncc]
@mancc varchar (9),
@tenncc nvarchar(50),
@diachi nvarchar(50),
@sdt varchar(11)
as begin
	update nhacungcap
	set 
	tenncc=@tenncc,
	diachi=@diachi,
	sdt=@sdt
	where mancc = @mancc
end;
GO
/****** Object:  StoredProcedure [dbo].[Update_NV]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_NV]
@manv varchar(9),
@tennv nvarchar(50),
@ngaysinh smalldatetime,
@gioitinh nvarchar(3),
@diachi nvarchar(50),
@sdt varchar(11),
@cmnd varchar(9)
as begin
	update nhanvien
	set manv = @manv,
		tennv= @tennv,
		ngaysinh =@ngaysinh,
		gioitinh=@gioitinh,
		diachi=@diachi,
		sdt=@sdt,
		cmnd=@cmnd
	where manv = @manv
end;

GO
/****** Object:  StoredProcedure [dbo].[Xoa_HD_Nhap]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Xoa_HD_Nhap]
@mahdn varchar(9)
as
	if(exists (select * from hoadonnhap where @mahdn = mahdn))
		begin
			delete from hanghoa_nhap where @mahdn = mahdn
			delete from hoadonnhap where @mahdn = mahdn
		end
	else
		print N'HND không tồn tại';
GO
/****** Object:  StoredProcedure [dbo].[Xoa_HD_Xuat]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Xoa_HD_Xuat]
@mahdx varchar(9)
as
	if(exists (select * from hoadonxuat where @mahdx = mahdx))
		begin
			delete from hanghoa_xuat where @mahdx = mahdx
			delete from hoadonxuat where @mahdx = mahdx
			
		end
	else
		print N'HNX không tồn tại';
GO
/****** Object:  StoredProcedure [dbo].[xoa_Mathang]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoa_Mathang]
@mahh varchar(9)
as
begin
	if(exists (select * from hanghoa where @mahh = mahh))
		begin
			delete from hanghoa where @mahh = mahh
		end
	else
		print N'Hàng hóa không tồn tại'
end;
		
GO
/****** Object:  StoredProcedure [dbo].[xoa_ncc]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoa_ncc]
@mancc varchar(9)
as
begin
	if(exists (select * from nhacungcap where @mancc = mancc))
		begin
			delete from nhacungcap where @mancc = mancc
		end
	else
		print N'Nhà cung cấp không tồn tại'
end;
GO
/****** Object:  StoredProcedure [dbo].[xoahh]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoahh]
@mahh varchar(9)
as
	if(exists (select * from hanghoa where @mahh = mahh))
		begin
			delete from hanghoa where @mahh = mahh
		end
	else
		print N'Mã hàng hóa không tồn tại';
GO
/****** Object:  StoredProcedure [dbo].[xoanv]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

		CREATE proc [dbo].[xoanv]
@manv nvarchar(50)
as
	if(exists (select * from nhanvien where @manv = manv))
		begin
			delete from nhanvien where @manv = manv
		end
	else
		print N'Mã nhân viên không tồn tại';
GO
/****** Object:  Table [dbo].[account]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hanghoa]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hanghoa](
	[mahh] [varchar](9) NOT NULL,
	[tenhh] [nvarchar](50) NULL,
	[loaihang] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[mancc] [varchar](9) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hanghoa_nhap]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hanghoa_nhap](
	[mahdn] [varchar](9) NOT NULL,
	[mahh] [varchar](9) NULL,
	[gianhap] [float] NULL,
	[slnhap] [int] NULL,
	[thanhtien] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hanghoa_xuat]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hanghoa_xuat](
	[mahdx] [varchar](9) NOT NULL,
	[mahh] [varchar](9) NULL,
	[giaxuat] [float] NULL,
	[slxuat] [int] NULL,
	[thanhtien] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoadonnhap]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadonnhap](
	[mahdn] [varchar](9) NOT NULL,
	[ngaynhap] [date] NULL,
	[manv] [nvarchar](50) NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK__hoadonnh__108E545BFC8AEF15] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoadonxuat]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadonxuat](
	[mahdx] [varchar](9) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[diachikh] [nvarchar](50) NULL,
	[sdtkh] [nvarchar](11) NULL,
	[ngayxuat] [date] NULL,
	[manv] [nvarchar](50) NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK__hoadonxu__108E5451E1B0F9E6] PRIMARY KEY CLUSTERED 
(
	[mahdx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[mancc] [varchar](9) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [nvarchar](50) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](3) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [varchar](11) NULL,
	[cmnd] [varchar](9) NULL,
 CONSTRAINT [PK__nhanvien__7A21B37D26AEA21B] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[giaban_re]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[giaban_re]
as
select top 3 hanghoa.mahh,hanghoa.tenhh,hanghoa_xuat.giaxuat
from hanghoa inner join hanghoa_xuat on hanghoa.mahh = hanghoa_xuat.mahh
order by hanghoa_xuat.giaxuat;
GO
/****** Object:  View [dbo].[gianhap_re]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[gianhap_re]
as
select top 3hanghoa.mahh,hanghoa.tenhh,hanghoa_nhap.gianhap
from hanghoa inner join hanghoa_nhap on hanghoa.mahh = hanghoa_nhap.mahh
order by hanghoa_nhap.gianhap;
GO
/****** Object:  View [dbo].[hanghoa_banmax]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hanghoa_banmax]
as
select top 3 hanghoa.mahh as 'Mã hàng',hanghoa.tenhh as 'Tên hàng' , hanghoa_xuat.giaxuat as 'Giá xuất'
from hanghoa inner join hanghoa_xuat
on hanghoa.mahh = hanghoa_xuat.mahh
order by [Giá xuất] desc;
GO
/****** Object:  View [dbo].[hanghoa_max]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hanghoa_max]
as
select top 3 hanghoa.mahh as 'Mã hàng',hanghoa.tenhh as 'Tên hàng' , hanghoa_nhap.gianhap as 'Giá nhập'
from hanghoa inner join hanghoa_nhap
on hanghoa.mahh = hanghoa_nhap.mahh;

GO
/****** Object:  View [dbo].[hanghoa_max1]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hanghoa_max1]
as
select top 3 hanghoa.mahh as 'Mã hàng',hanghoa.tenhh as 'Tên hàng' , hanghoa_nhap.gianhap as 'Giá nhập'
from hanghoa inner join hanghoa_nhap
on hanghoa.mahh = hanghoa_nhap.mahh
order by [Giá nhập] desc;
GO
/****** Object:  View [dbo].[laisuat]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[laisuat]
as
select hanghoa.tenhh, sum(hanghoa_xuat.giaxuat-hanghoa_nhap.gianhap) as Laisuat
from ((hanghoa inner join hanghoa_xuat on hanghoa.mahh = hanghoa_xuat.mahh) 
inner join hanghoa_nhap on hanghoa.mahh=hanghoa_nhap.mahh)
group by hanghoa.tenhh;
GO
/****** Object:  View [dbo].[nhanviennoio]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[nhanviennoio] as
select manv,tennv,ngaysinh,gioitinh,diachi
from nhanvien
GO
/****** Object:  View [dbo].[rp_hoadonnhap]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[rp_hoadonnhap] as
select hanghoa.mahh,hanghoa.tenhh,gianhap,slnhap,thanhtien
from hanghoa_nhap inner join hanghoa
on hanghoa_nhap.mahh=hanghoa.mahh
GO
/****** Object:  View [dbo].[sanphamApple]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sanphamApple]
as
select hanghoa.mahh,hanghoa.tenhh,hanghoa.loaihang,nhacungcap.tenncc
from hanghoa inner join nhacungcap on hanghoa.mancc=nhacungcap.mancc
where nhacungcap.tenncc='Apple';
GO
/****** Object:  View [dbo].[slconlai]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[slconlai]
as
select hanghoa.tenhh, sum(hanghoa.soluong-hanghoa_xuat.slxuat) as SL
from hanghoa inner join hanghoa_xuat on hanghoa.mahh = hanghoa_xuat.mahh
group by hanghoa.tenhh;
GO
/****** Object:  View [dbo].[spApple]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[spApple]
as
select hanghoa.mahh,hanghoa.tenhh,hanghoa.loaihang,nhacungcap.tenncc
from hanghoa inner join nhacungcap on hanghoa.mancc=nhacungcap.mancc
where nhacungcap.mancc='Apple';
GO
/****** Object:  View [dbo].[ten_diachi]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ten_diachi]
as
select nhanvien.tennv as 'Tên' ,nhanvien.diachi as 'Địa chỉ'
from nhanvien;
GO
/****** Object:  View [dbo].[thongkehangcon]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[thongkehangcon] as
SELECT mahh,tenhh,loaihang,soluong,tenncc
FROM hanghoa inner join nhacungcap on hanghoa.mancc=nhacungcap.mancc
GO
/****** Object:  View [dbo].[view_rp_hoadonxuat]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_rp_hoadonxuat] as
select hanghoa.mahh,hanghoa.tenhh,giaxuat,slxuat,thanhtien
from hanghoa_xuat inner join hanghoa
on hanghoa_xuat.mahh=hanghoa.mahh
GO
/****** Object:  View [dbo].[view_rp_tktheoquy]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_rp_tktheoquy]
as
SELECT 
        SUM(CASE  WHEN MONTH(Ngayxuat) in (1,2,3 )THEN tongtien
            ELSE 0 END) AS N'Qúy 1',
        SUM(CASE WHEN  MONTH(Ngayxuat) in ( 4,5,6) THEN tongtien
            ELSE 0 END) AS N'Qúy 2',
        SUM(CASE WHEN MONTH(Ngayxuat) in (7,8,9) THEN tongtien
            ELSE 0 END) AS N'Qúy 3',
        SUM(CASE WHEN  MONTH(Ngayxuat) in (10,11,12) THEN tongtien
            ELSE 0 END) AS N'Qúy 4'
from hoadonxuat
GO
/****** Object:  View [dbo].[view_rp_thongkehangton]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_rp_thongkehangton]
as
select mahh, tenhh, soluong, nhacungcap.tenncc
from hanghoa inner join nhacungcap
on hanghoa.mancc = nhacungcap.mancc
GO
/****** Object:  View [dbo].[xemtiennhap]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[xemtiennhap]
as
select nhanvien.tennv, sum(hanghoa_nhap.slnhap * hanghoa_nhap.gianhap) as Tongtien 
from ((nhanvien inner join hoadonnhap on nhanvien.manv = hoadonnhap.manv) inner join
 hanghoa_nhap on hoadonnhap.mahdn = hanghoa_nhap.mahdn)
where month(ngaynhap) = 2 and  YEAR(ngaynhap) = 2017
group by nhanvien.tennv	
GO
/****** Object:  View [dbo].[xemtienxuat]    Script Date: 4/23/2019 9:41:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[xemtienxuat]
as
select nhanvien.manv, sum(hanghoa_xuat.slxuat * hanghoa_xuat.giaxuat) as Tongtien 
from ((nhanvien inner join hoadonxuat on nhanvien.manv = hoadonxuat.manv) inner join
 hanghoa_xuat on hoadonxuat.mahdx = hanghoa_xuat.mahdx)
where month(ngayxuat) = 4 and  YEAR(ngayxuat) = 2016
group by nhanvien.manv;
GO
ALTER TABLE [dbo].[hoadonnhap] ADD  CONSTRAINT [DF_hoadonnhap_tongtien]  DEFAULT ((0)) FOR [tongtien]
GO
ALTER TABLE [dbo].[hoadonxuat] ADD  CONSTRAINT [DF_hoadonxuat_tongtien]  DEFAULT ((0)) FOR [tongtien]
GO
ALTER TABLE [dbo].[hanghoa]  WITH CHECK ADD FOREIGN KEY([mancc])
REFERENCES [dbo].[nhacungcap] ([mancc])
GO
ALTER TABLE [dbo].[hanghoa_nhap]  WITH CHECK ADD  CONSTRAINT [FK_hanghoa_nhap_hanghoa] FOREIGN KEY([mahh])
REFERENCES [dbo].[hanghoa] ([mahh])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[hanghoa_nhap] CHECK CONSTRAINT [FK_hanghoa_nhap_hanghoa]
GO
ALTER TABLE [dbo].[hanghoa_nhap]  WITH CHECK ADD  CONSTRAINT [FK_hanghoa_nhap_hoadonnhap] FOREIGN KEY([mahdn])
REFERENCES [dbo].[hoadonnhap] ([mahdn])
GO
ALTER TABLE [dbo].[hanghoa_nhap] CHECK CONSTRAINT [FK_hanghoa_nhap_hoadonnhap]
GO
ALTER TABLE [dbo].[hanghoa_xuat]  WITH CHECK ADD  CONSTRAINT [FK_hanghoa_xuat_hanghoa] FOREIGN KEY([mahh])
REFERENCES [dbo].[hanghoa] ([mahh])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[hanghoa_xuat] CHECK CONSTRAINT [FK_hanghoa_xuat_hanghoa]
GO
ALTER TABLE [dbo].[hanghoa_xuat]  WITH CHECK ADD  CONSTRAINT [FK_hanghoa_xuat_hoadonxuat] FOREIGN KEY([mahdx])
REFERENCES [dbo].[hoadonxuat] ([mahdx])
GO
ALTER TABLE [dbo].[hanghoa_xuat] CHECK CONSTRAINT [FK_hanghoa_xuat_hoadonxuat]
GO
ALTER TABLE [dbo].[hoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_hoadonnhap_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[hoadonnhap] CHECK CONSTRAINT [FK_hoadonnhap_nhanvien]
GO
ALTER TABLE [dbo].[hoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_hoadonxuat_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[hoadonxuat] CHECK CONSTRAINT [FK_hoadonxuat_nhanvien]
GO
USE [master]
GO
ALTER DATABASE [QLBH_Maytinh] SET  READ_WRITE 
GO
