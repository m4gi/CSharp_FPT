USE [master]
GO
/****** Object:  Database [LAB4]    Script Date: 3/24/2021 12:49:36 AM ******/
CREATE DATABASE [LAB4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Northwind', FILENAME = N'E:\Programs\SQL\MSSQL15.MAGI\MSSQL\DATA\Northwind.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Northwind_log', FILENAME = N'E:\Programs\SQL\MSSQL15.MAGI\MSSQL\DATA\Northwind_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LAB4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LAB4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LAB4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LAB4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LAB4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LAB4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LAB4] SET ARITHABORT OFF 
GO
ALTER DATABASE [LAB4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LAB4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LAB4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LAB4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LAB4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LAB4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LAB4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LAB4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LAB4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LAB4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LAB4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LAB4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LAB4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LAB4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LAB4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LAB4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LAB4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LAB4] SET RECOVERY FULL 
GO
ALTER DATABASE [LAB4] SET  MULTI_USER 
GO
ALTER DATABASE [LAB4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LAB4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LAB4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LAB4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LAB4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LAB4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LAB4', N'ON'
GO
ALTER DATABASE [LAB4] SET QUERY_STORE = OFF
GO
ALTER AUTHORIZATION ON DATABASE::[LAB4] TO [magi]
GO
USE [LAB4]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 3/24/2021 12:49:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Picture] [varchar](250) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Categories] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/24/2021 12:49:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[SupplierID] [int] NULL,
	[CategoryID] [int] NULL,
	[QuantityPerUnit] [float] NULL,
	[UnitPrice] [float] NULL,
	[UnitsInStock] [int] NULL,
	[UnitsOnOrder] [int] NULL,
	[ReorderLevel] [int] NULL,
	[Discontinued] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Products] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 3/24/2021 12:49:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](100) NOT NULL,
	[ContactName] [nvarchar](50) NULL,
	[ContactTitle] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[City] [nvarchar](200) NULL,
	[Region] [nvarchar](50) NULL,
	[PostalCode] [nchar](10) NULL,
	[Country] [nvarchar](50) NULL,
	[Phone] [varchar](12) NULL,
	[Fax] [varchar](12) NULL,
	[HomePage] [nvarchar](50) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Suppliers] TO  SCHEMA OWNER 
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (1, N'Milk', N'Sữa bò tươi', NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued]) VALUES (1, N'Sữa TH TrueMilk', 1, 1, 180, 18000, 100, 20, 1, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax], [HomePage]) VALUES (1, N'LAT', N'Lê Tuấn', N'LT', N'DOM', N'Ngũ Hành Sơn', N'Đà Nẵng', NULL, N'Việt Nam', N'0914743856', N'0914743856', NULL)
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
/****** Object:  StoredProcedure [dbo].[GetAllCategories]    Script Date: 3/24/2021 12:49:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllCategories]
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Categories
END
GO
ALTER AUTHORIZATION ON [dbo].[GetAllCategories] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GetAllProducts]    Script Date: 3/24/2021 12:49:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllProducts]
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Products
END
GO
ALTER AUTHORIZATION ON [dbo].[GetAllProducts] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GetAllSupplier]    Script Date: 3/24/2021 12:49:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllSupplier]
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Suppliers
	RETURN
END
GO
ALTER AUTHORIZATION ON [dbo].[GetAllSupplier] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SearchProductsByProductName]    Script Date: 3/24/2021 12:49:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchProductsByProductName]
@ProductName nvarchar(50) 
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Products WHERE ProductName = @ProductName
	RETURN
END
GO
ALTER AUTHORIZATION ON [dbo].[SearchProductsByProductName] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SearchSuppliersByCompanyName]    Script Date: 3/24/2021 12:49:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchSuppliersByCompanyName]
@CompanyName nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Suppliers WHERE CompanyName = @CompanyName
END
GO
ALTER AUTHORIZATION ON [dbo].[SearchSuppliersByCompanyName] TO  SCHEMA OWNER 
GO
USE [master]
GO
ALTER DATABASE [LAB4] SET  READ_WRITE 
GO
