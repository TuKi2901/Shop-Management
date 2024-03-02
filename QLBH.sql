USE [master]
GO
/****** Object:  Database [DuAnMau]    Script Date: 10/10/2023 7:05:40 PM ******/
CREATE DATABASE [DuAnMau]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DuAnMau', FILENAME = N'D:\FPT Polytechnic\DuAnMau\Assignment\ASM\QuanLyBanHang\DAL_QLBanHang\DuAnMau.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DuAnMau_log', FILENAME = N'D:\FPT Polytechnic\DuAnMau\Assignment\ASM\QuanLyBanHang\DAL_QLBanHang\DuAnMau_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DuAnMau] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DuAnMau].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DuAnMau] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DuAnMau] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DuAnMau] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DuAnMau] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DuAnMau] SET ARITHABORT OFF 
GO
ALTER DATABASE [DuAnMau] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DuAnMau] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DuAnMau] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DuAnMau] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DuAnMau] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DuAnMau] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DuAnMau] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DuAnMau] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DuAnMau] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DuAnMau] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DuAnMau] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DuAnMau] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DuAnMau] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DuAnMau] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DuAnMau] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DuAnMau] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DuAnMau] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DuAnMau] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DuAnMau] SET  MULTI_USER 
GO
ALTER DATABASE [DuAnMau] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DuAnMau] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DuAnMau] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DuAnMau] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DuAnMau] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DuAnMau] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DuAnMau] SET QUERY_STORE = OFF
GO
USE [DuAnMau]
GO
/****** Object:  User [DESKTOP-H82IH4V\TuKi2901]    Script Date: 10/10/2023 7:05:40 PM ******/
CREATE USER [DESKTOP-H82IH4V\TuKi2901] FOR LOGIN [DESKTOP-H82IH4V\TuKi2901] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
ALTER ROLE [db_datareader] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [DESKTOP-H82IH4V\TuKi2901]
GO
/****** Object:  Table [dbo].[tblHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHang](
	[MaHang] [int] IDENTITY(1,1) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
	[DonGiaban] [float] NOT NULL,
	[HinhAnh] [varchar](200) NOT NULL,
	[GhiChu] [nvarchar](200) NOT NULL,
	[Manv] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblHang] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[DienThoai] [varchar](15) NOT NULL,
	[TenKhach] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[Phai] [nvarchar](5) NOT NULL,
	[Manv] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[DienThoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Manv] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[VaiTro] [tinyint] NOT NULL,
	[TinhTrang] [tinyint] NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblHang]  WITH CHECK ADD  CONSTRAINT [FK_tblHang_tblNhanVien] FOREIGN KEY([Manv])
REFERENCES [dbo].[tblNhanVien] ([Manv])
GO
ALTER TABLE [dbo].[tblHang] CHECK CONSTRAINT [FK_tblHang_tblNhanVien]
GO
ALTER TABLE [dbo].[tblKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhachHang_tblNhanVien] FOREIGN KEY([Manv])
REFERENCES [dbo].[tblNhanVien] ([Manv])
GO
ALTER TABLE [dbo].[tblKhachHang] CHECK CONSTRAINT [FK_tblKhachHang_tblNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[CheckEmailTonTai]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[CheckEmailTonTai]
@email varchar(50)
AS
BEGIN
	declare @status int
if exists(select Manv from tblNhanVien where Email = @email)
	set @status = 1
else
	set @status = 0
select @status
END



GO
/****** Object:  StoredProcedure [dbo].[CheckPhoneNumberDuplicate]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create   proc [dbo].[CheckPhoneNumberDuplicate]
@dienThoai varchar(15), @status int = 1
as
begin
	if exists (select DienThoai from tblKhachHang where DienThoai=@dienThoai)
	begin
		set @status = 0;
		rollback;
	end
	select @status
end


GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[DangNhap] 
	@email varchar(50), @matkhau nvarchar(50)
	AS
	BEGIN
		declare @status int
	if exists(select * from tblNhanVien where Email=@email and MatKhau=@matkhau)
		set @status = 1
	else
		set @status = 0
	select @status
	END

GO
/****** Object:  StoredProcedure [dbo].[DanhSachNV]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC  [dbo].[DanhSachNV]
AS
BEGIN
	select Email, TenNV, DiaChi, VaiTro, TinhTrang from tblNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteHang_tblHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create   proc [dbo].[DeleteHang_tblHang]
@maHang varchar(20)
as
begin
	delete from tblHang
	where MaHang=@maHang
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteKhachHang_tblKhachHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create   proc [dbo].[DeleteKhachHang_tblKhachHang]
@dienThoai varchar(20)
as
begin
	delete from tblKhachHang
	where DienThoai=@dienThoai
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteNhanVien_tblNhanVien]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[DeleteNhanVien_tblNhanVien]
	@email varchar(50)
as
begin
	delete from tblNhanVien
	where Email = @email
end
GO
/****** Object:  StoredProcedure [dbo].[DoiMatKhau]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[DoiMatKhau]
@email varchar(50), @matKhauCu nvarchar(50), @matKhauMoi nvarchar(50), @status int =1
as
begin
	if exists (select MatKhau from tblNhanVien where Email = @email and MatKhau=@matKhauCu)
	begin
	update tblNhanVien
	set MatKhau = @matkhaumoi
	where Email = @email
	end
	else
	set @status = 0;
	select @status;
end

GO
/****** Object:  StoredProcedure [dbo].[Get_MaNV_From_Email]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create   proc [dbo].[Get_MaNV_From_Email]
@email varchar(50)
as
begin
	select Manv from tblNhanVien
	where Email = @email
end

exec dbo.Get_MaNV_From_Email 'kiet43012@gmail.com'

GO
/****** Object:  StoredProcedure [dbo].[InsertHang_tblHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[InsertHang_tblHang]
@tenHang nvarchar(50), @soLuong  int, @donGiaNhap  float, @donGiaBan float, @hinhAnh varchar(200), @ghiChu nvarchar(200), @maNV varchar(20)
as
begin
	
	insert into tblHang (TenHang, SoLuong, DonGiaNhap, DonGiaBan, HinhAnh, GhiChu, Manv)
	values (@tenHang, @soLuong, @donGiaNhap, @donGiaBan, @hinhAnh, @ghiChu, @Manv)

end
GO
/****** Object:  StoredProcedure [dbo].[InsertKhachHang_tblKhachHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[InsertKhachHang_tblKhachHang]
@dienThoai varchar(15), @tenKhach  nvarchar(50), @diaChi  nvarchar(100), @phai nvarchar(5), @maNV varchar(20)
as
begin
	
	insert into tblKhachHang (DienThoai, TenKhach, DiaChi, Phai, MaNV)
	values (@dienThoai, @tenKhach, @diaChi, @phai, @maNV)

end
GO
/****** Object:  StoredProcedure [dbo].[InsertNhanVien_tblNhanVien]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[InsertNhanVien_tblNhanVien]
	@Email nvarchar(50),
	@TenNV nvarchar(50),
	@DiaChi nvarchar(100),
	@VaiTro tinyint,
	@TinhTrang tinyint

as
begin
	
	declare @id int;
	declare @MaNV varchar(20)
	select @id = ISNULL(max(ID),0)+1 from tblNhanVien
	select @MaNV = 'NV' + RIGHT('000' + CAST(@id as varchar(3)),3)
	begin try
	insert into tblNhanVien (Manv,Email, TenNV, DiaChi, VaiTro, TinhTrang, MatKhau)
	values (@MaNV,@Email, @TenNV, @DiaChi, @VaiTro, @TinhTrang, '12345678')
	--select @id;
	end try
	begin catch
	select ERROR_NUMBER()
		rollback;
	end catch
end

GO
/****** Object:  StoredProcedure [dbo].[LayMaHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create   proc [dbo].[LayMaHang]
as
begin
select max(MaHang)+1 from tblHang
end

GO
/****** Object:  StoredProcedure [dbo].[LayTatCaHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[LayTatCaHang]
as
begin
	select MaHang, TenHang, SoLuong, DonGiaNhap, DonGiaBan, HinhAnh, GhiChu from tblHang
end

GO
/****** Object:  StoredProcedure [dbo].[LayTatCaKhachHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[LayTatCaKhachHang]
as
begin
	select DienThoai, TenKhach, DiaChi, Phai from tblKhachHang
end

GO
/****** Object:  StoredProcedure [dbo].[LayTatCaNhanVien]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




	-- PROC CRUD

create   proc [dbo].[LayTatCaNhanVien]
as
begin
	select 
	[Email],
	[TenNV],
	[DiaChi],
	[VaiTro],
	[TinhTrang] 
	from tblNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[LayVaiTro]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[LayVaiTro]
@email varchar(50)
as

begin
	select vaitro from tblNhanVien where Email = @email;
end

GO
/****** Object:  StoredProcedure [dbo].[QuenMatKhau]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[QuenMatKhau]
@email varchar(50), @matkhau nvarchar(50), @status int = 1
as
begin
	if exists(select * from tblNhanVien where Email=@email)
		begin
			update tblNhanVien
			set MatKhau = @matkhau where Email =@email
		end
	else
		begin
			set @status = 0;
		end
	select @status;
end

GO
/****** Object:  StoredProcedure [dbo].[ThongKeSP]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[ThongKeSP]
as
begin
	select h.Manv, nv.Tennv, count(h.MaHang) as N'Sản Phẩm' 
	from tblHang h inner join tblNhanVien nv
	on h.Manv = nv.Manv
	group by h.Manv, nv.TenNV
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKeTonKho]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create   proc [dbo].[ThongKeTonKho]
as
begin
	select TenHang, Sum(SoLuong) as N'Tồn Kho'
	from tblHang
	group by TenHang
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemHang_tblHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create   proc [dbo].[TimKiemHang_tblHang]
@tenHang nvarchar(50)
as
begin
	select MaHang, TenHang, SoLuong, DonGiaNhap, DonGiaBan, HinhAnh, GhiChu from tblHang
	where TenHang like '%' + @tenHang + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemKhachHang_tblKhachHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create   proc [dbo].[TimKiemKhachHang_tblKhachHang]
@tenKhach nvarchar(50)
as
begin
	select DienThoai, TenKhach, DiaChi, Phai from tblKhachHang
	where TenKhach like '%' + @tenKhach + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemNhanVien_tblNhanVien]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[TimKiemNhanVien_tblNhanVien]
@TenNv varchar(50)
as
begin
	set nocount on;
	select email, tennv, DiaChi, VaiTro, TinhTrang from tblNhanVien
	where TenNV like '%' + @TenNv + '%'
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateHang_tblHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create   proc [dbo].[UpdateHang_tblHang]
@maHang int, @tenHang nvarchar(50), @soLuong  int, @donGiaNhap  float, @donGiaBan float, @hinhAnh varchar(200), @ghiChu nvarchar(200), @maNV varchar(20)
as
begin
	update tblHang
	set 
	TenHang = @tenHang,
	SoLuong = @soLuong,
	DonGiaNhap = @donGiaNhap,
	DonGiaBan = @donGiaBan,
	HinhAnh = @hinhAnh,
	GhiChu =@ghiChu,
	Manv = @maNV
	where Mahang = @maHang;
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateKhachHang_tblKhachHang]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create   proc [dbo].[UpdateKhachHang_tblKhachHang]
@dienThoai varchar(15), @tenKhach  nvarchar(50), @diaChi  nvarchar(100), @phai nvarchar(5), @maNV varchar(20)
as
begin
	update tblKhachHang
	set 
	DienThoai = @dienThoai,
	TenKhach = @tenKhach,
	DiaChi = @diaChi,
	Phai = @phai,
	MaNV = @maNV
	where DienThoai = @dienThoai;
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateNhanVien_tblNhanVien]    Script Date: 10/10/2023 7:05:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create   proc [dbo].[UpdateNhanVien_tblNhanVien]
	@Email nvarchar(50),
	@TenNV nvarchar(50),
	@DiaChi nvarchar(100),
	@VaiTro tinyint,
	@TinhTrang tinyint
as
begin
	update tblNhanVien
	set 
	Email = @Email,
	TenNV = @TenNV,
	DiaChi = @DiaChi,
	VaiTro = @VaiTro,
	TinhTrang = @TinhTrang
	where Email = @Email
end

GO
USE [master]
GO
ALTER DATABASE [DuAnMau] SET  READ_WRITE 
GO
