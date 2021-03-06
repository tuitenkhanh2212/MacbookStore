USE [MacBookStore]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_Year]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_RAM]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_HardDrive]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_Group]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_DisplayCard]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_Display]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_CPU]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_Color]
GO
ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Product]
GO
ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Order]
GO
ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_Order_Customer]
GO
/****** Object:  Table [dbo].[Year]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[Year]
GO
/****** Object:  Table [dbo].[RAM]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[RAM]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[Product]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[OrderDetails]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[Order]
GO
/****** Object:  Table [dbo].[HardDrive]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[HardDrive]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[Group]
GO
/****** Object:  Table [dbo].[DisplayCard]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[DisplayCard]
GO
/****** Object:  Table [dbo].[Display]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[Display]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[CPU]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[CPU]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[Color]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP TABLE [dbo].[Admin]
GO
USE [master]
GO
/****** Object:  Database [MacBookStore]    Script Date: 4/11/2021 5:41:47 PM ******/
DROP DATABASE [MacBookStore]
GO
/****** Object:  Database [MacBookStore]    Script Date: 4/11/2021 5:41:47 PM ******/
CREATE DATABASE [MacBookStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MacBookStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MacBookStore.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MacBookStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MacBookStore_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MacBookStore] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MacBookStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MacBookStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MacBookStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MacBookStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MacBookStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MacBookStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [MacBookStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MacBookStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MacBookStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MacBookStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MacBookStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MacBookStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MacBookStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MacBookStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MacBookStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MacBookStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MacBookStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MacBookStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MacBookStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MacBookStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MacBookStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MacBookStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MacBookStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MacBookStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MacBookStore] SET  MULTI_USER 
GO
ALTER DATABASE [MacBookStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MacBookStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MacBookStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MacBookStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MacBookStore] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MacBookStore]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [nvarchar](50) NULL,
	[Account] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Color]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Color](
	[ColorID] [varchar](50) NOT NULL,
	[ColorName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CPU]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CPU](
	[CpuID] [varchar](50) NOT NULL,
	[CpuName] [nvarchar](50) NULL,
 CONSTRAINT [PK_CPU] PRIMARY KEY CLUSTERED 
(
	[CpuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Account] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Birth] [date] NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Display]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Display](
	[DisplayID] [varchar](50) NOT NULL,
	[DisplayName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Display] PRIMARY KEY CLUSTERED 
(
	[DisplayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DisplayCard]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DisplayCard](
	[DisplayCardID] [varchar](50) NOT NULL,
	[DisplayCardName] [nvarchar](50) NULL,
 CONSTRAINT [PK_DisplayCard] PRIMARY KEY CLUSTERED 
(
	[DisplayCardID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Group](
	[GroupID] [varchar](50) NOT NULL,
	[GroupName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HardDrive]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HardDrive](
	[HardDriveID] [varchar](50) NOT NULL,
	[HardDriveName] [nvarchar](50) NULL,
 CONSTRAINT [PK_HardDrive] PRIMARY KEY CLUSTERED 
(
	[HardDriveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[Paid] [bit] NULL,
	[DeliveryStatus] [bit] NULL,
	[OrderDate] [datetime] NULL,
	[DelieveryDate] [datetime] NULL,
	[CustomerID] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Amount] [int] NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[Stock] [int] NULL,
	[Sold] [int] NULL,
	[Description] [nvarchar](1000) NULL,
	[Price] [decimal](18, 0) NULL,
	[ImageSourceMain] [varchar](200) NULL,
	[ImageSource1] [varchar](200) NULL,
	[ImageSource2] [varchar](200) NULL,
	[ImageSource3] [varchar](200) NULL,
	[CpuID] [varchar](50) NULL,
	[DisplayCardID] [varchar](50) NULL,
	[DisplayID] [varchar](50) NULL,
	[ColorID] [varchar](50) NULL,
	[YearID] [varchar](50) NULL,
	[HardDriveID] [varchar](50) NULL,
	[RamID] [varchar](50) NULL,
	[GroupID] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Products_1] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RAM]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RAM](
	[RamID] [varchar](50) NOT NULL,
	[RamName] [nvarchar](50) NULL,
 CONSTRAINT [PK_RAM] PRIMARY KEY CLUSTERED 
(
	[RamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Year]    Script Date: 4/11/2021 5:41:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Year](
	[YearID] [varchar](50) NOT NULL,
	[YearName] [varchar](50) NULL,
 CONSTRAINT [PK_Year] PRIMARY KEY CLUSTERED 
(
	[YearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminID], [AdminName], [Account], [Password]) VALUES (1, N'Hồ Trần Gia Khánh', N'khanh2212', N'123')
SET IDENTITY_INSERT [dbo].[Admin] OFF
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Be', N'Berry')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Bl', N'Black')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Go', N'Gold')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Gr', N'Grey')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Na', N'Navy')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Ol', N'Olive')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Pi', N'Pink')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'RG', N'Rose Gold')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Si', N'Silver')
INSERT [dbo].[Color] ([ColorID], [ColorName]) VALUES (N'Wh', N'White')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'311', N'Core i3 1.1')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'336', N'Core i3 3.3')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'511', N'Core i5 1.1')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'513', N'Core i5 1.3')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'514', N'Core i5 1.4')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'516', N'Core i5 1.6')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'518', N'Core i5 1.8')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'520', N'Core i5 2.0')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'523', N'Core i5 2.3')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'524', N'Core i5 2.4')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'526', N'Core i5 2.6')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'527', N'Core i5 2.7')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'528', N'Core i5 2.8')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'529', N'Core i5 2.9')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'530', N'Core i5 3.0')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'531', N'Core i5 3.1')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'532', N'Core i5 3.2')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'533', N'Core i5 3.3')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'534', N'Core i5 3.4')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'535', N'Core i5 3.5')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'537', N'Core i5 3.7')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'711', N'Core i7 1.1')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'714', N'Core i7 1.4')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'717', N'Core i7 1.7')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'722', N'Core i7 2.2')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'724', N'Core i7 2.4')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'725', N'Core i7 2.5')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'726', N'Core i7 2.6')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'727', N'Core i7 2.7')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'728', N'Core i7 2.8')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'729', N'Core i7 2.9')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'730', N'Core i7 3.0')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'731', N'Core i7 3.1')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'733', N'Core i7 3.3')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'735', N'Core i7 3.5')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'738', N'Core i7 3.8')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'923', N'Core i9 2.3')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'924', N'Core i9 2.4')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'929', N'Core i9 2.9')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'M18C', N'M1 8Core-SPU/ 8-Core')
INSERT [dbo].[CPU] ([CpuID], [CpuName]) VALUES (N'None', N' ')
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [FirstName], [LastName], [Account], [Password], [Email], [Birth], [Address], [PhoneNumber]) VALUES (2, N'Hồ Trần Gia', N'Khánh', N'khanh22122000', N'123456', N'Khanh22122000@gmail.com', CAST(N'2000-12-22' AS Date), N'58/15', N'0703237261')
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Display] ([DisplayID], [DisplayName]) VALUES (N'11', N'11 inch')
INSERT [dbo].[Display] ([DisplayID], [DisplayName]) VALUES (N'12', N'12 inch')
INSERT [dbo].[Display] ([DisplayID], [DisplayName]) VALUES (N'13.3', N'13.3 inch')
INSERT [dbo].[Display] ([DisplayID], [DisplayName]) VALUES (N'14', N'14 inch')
INSERT [dbo].[Display] ([DisplayID], [DisplayName]) VALUES (N'15.4', N'15.4 inch')
INSERT [dbo].[Display] ([DisplayID], [DisplayName]) VALUES (N'16', N'16 inch')
INSERT [dbo].[Display] ([DisplayID], [DisplayName]) VALUES (N'None', N' ')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'', N'')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'A555', N'AMD 555 2GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'A555X', N'AMD 555X 4GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'A560', N'AMD 560 4GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'A560X', N'AMD 560X 4GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'AR555X', N'AMD Radeon 555X 2GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'AR9M370X', N'AMD R9 M370X 2GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'N750M', N'Nvidia 750M 2GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'NMX250', N'Nvidia MX250 2GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'None', N' Không có')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'RP5300M', N'Radeon Pro 5300M 4GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'RP5500M', N'Radeon Pro 5500M 4GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'RP570X', N'Radeon Pro 570X 4GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'RP575X', N'Radeon Pro 575X 4GB')
INSERT [dbo].[DisplayCard] ([DisplayCardID], [DisplayCardName]) VALUES (N'RP580X', N'Radeon Pro 580X 8GB')
INSERT [dbo].[Group] ([GroupID], [GroupName]) VALUES (N'CAP', N'Cáp chuyển đổi')
INSERT [dbo].[Group] ([GroupID], [GroupName]) VALUES (N'MA', N'Macbook Air')
INSERT [dbo].[Group] ([GroupID], [GroupName]) VALUES (N'MK', N'Bàn Phím')
INSERT [dbo].[Group] ([GroupID], [GroupName]) VALUES (N'MM', N'Chuột')
INSERT [dbo].[Group] ([GroupID], [GroupName]) VALUES (N'MP', N'Macbook Pro')
INSERT [dbo].[Group] ([GroupID], [GroupName]) VALUES (N'TP', N'Trackpad')
INSERT [dbo].[Group] ([GroupID], [GroupName]) VALUES (N'TUI', N'Túi chống sốc')
INSERT [dbo].[HardDrive] ([HardDriveID], [HardDriveName]) VALUES (N'128SD', N'128 GB SSD')
INSERT [dbo].[HardDrive] ([HardDriveID], [HardDriveName]) VALUES (N'1HD', N'1 TB HDD')
INSERT [dbo].[HardDrive] ([HardDriveID], [HardDriveName]) VALUES (N'1SD', N'1 TB SSD')
INSERT [dbo].[HardDrive] ([HardDriveID], [HardDriveName]) VALUES (N'256SD', N'256 GB SSD')
INSERT [dbo].[HardDrive] ([HardDriveID], [HardDriveName]) VALUES (N'500HD', N'500 GB HDD')
INSERT [dbo].[HardDrive] ([HardDriveID], [HardDriveName]) VALUES (N'512SD', N'512 GB SSD')
INSERT [dbo].[HardDrive] ([HardDriveID], [HardDriveName]) VALUES (N'None', N' ')
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderID], [Paid], [DeliveryStatus], [OrderDate], [DelieveryDate], [CustomerID]) VALUES (2, 0, 0, CAST(N'2021-04-06 19:30:21.777' AS DateTime), CAST(N'2021-04-22 00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Order] ([OrderID], [Paid], [DeliveryStatus], [OrderDate], [DelieveryDate], [CustomerID]) VALUES (3, 0, 0, CAST(N'2021-04-07 11:06:58.770' AS DateTime), CAST(N'2021-04-22 00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Order] ([OrderID], [Paid], [DeliveryStatus], [OrderDate], [DelieveryDate], [CustomerID]) VALUES (4, 0, 0, CAST(N'2021-04-08 09:21:56.653' AS DateTime), CAST(N'2021-04-14 00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Order] ([OrderID], [Paid], [DeliveryStatus], [OrderDate], [DelieveryDate], [CustomerID]) VALUES (5, 0, 0, CAST(N'2021-04-09 21:08:22.757' AS DateTime), CAST(N'2021-04-14 00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Order] OFF
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Amount], [Price]) VALUES (2, 1, 1, CAST(23500000 AS Decimal(18, 0)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Amount], [Price]) VALUES (2, 7, 2, CAST(20500000 AS Decimal(18, 0)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Amount], [Price]) VALUES (3, 3, 2, CAST(24000000 AS Decimal(18, 0)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Amount], [Price]) VALUES (4, 2, 1, CAST(22000000 AS Decimal(18, 0)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Amount], [Price]) VALUES (4, 34, 1, CAST(36490000 AS Decimal(18, 0)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Amount], [Price]) VALUES (5, 87, 1, CAST(1250000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (1, N'MF843', 5, 1, N'Macbook Pro 2015', CAST(23500000 AS Decimal(18, 0)), N'/Content/Image/MP/2015/macbookpro2015.jpg', N'/Content/Image/MP/2015/macbookpro2015-1.jpg', N'/Content/Image/MP/2015/macbookpro2015-2.jpg', N'/Content/Image/MP/2015/macbookpro2015-3.jpg', N'731', N'None', N'13.3', N'Si', N'15', N'512SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (2, N'MJLQ2', 5, 1, N'Macbook Pro 2015', CAST(22000000 AS Decimal(18, 0)), N'/Content/Image/MP/2015/macbookpro2015.jpg', N'/Content/Image/MP/2015/macbookpro2015-1.jpg', N'/Content/Image/MP/2015/macbookpro2015-2.jpg', N'/Content/Image/MP/2015/macbookpro2015-3.jpg', N'722', N'None', N'15.4', N'Si', N'15', N'256SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (3, N'MJLT2', 5, 4, N'Macbook Pro 2015', CAST(24000000 AS Decimal(18, 0)), N'/Content/Image/MP/2015/macbookpro2015.jpg', N'/Content/Image/MP/2015/macbookpro2015-1.jpg', N'/Content/Image/MP/2015/macbookpro2015-2.jpg', N'/Content/Image/MP/2015/macbookpro2015-3.jpg', N'725', N'AR9M370X', N'15.4', N'Si', N'15', N'512SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (4, N'MF841', 5, 1, N'Macbook Pro 2015', CAST(20500000 AS Decimal(18, 0)), N'/Content/Image/MP/2015/macbookpro2015.jpg', N'/Content/Image/MP/2015/macbookpro2015-1.jpg', N'/Content/Image/MP/2015/macbookpro2015-2.jpg', N'/Content/Image/MP/2015/macbookpro2015-3.jpg', N'529', N'None', N'13.3', N'Si', N'15', N'512SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (5, N'MNQG2', 5, 8, N'Macbook Pro 2016', CAST(25000000 AS Decimal(18, 0)), N'/Content/Image/MP/2016/macbookpro2016-silver13.jpg', N'/Content/Image/MP/2016/1.jpg', N'/Content/Image/MP/2016/2.jpg', N'/Content/Image/MP/2016/3.jpg', N'529', N'None', N'13.3', N'Si', N'16', N'512SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (6, N'MLVP2', 5, 1, N'Macbook Pro 2016', CAST(24400000 AS Decimal(18, 0)), N'/Content/Image/MP/2016/macbookpro2016-silver13.jpg', N'/Content/Image/MP/2016/1.jpg', N'/Content/Image/MP/2016/2.jpg', N'/Content/Image/MP/2016/3.jpg', N'529', N'None', N'13.3', N'Si', N'16', N'256SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (7, N'MLUQ2', 5, 1, N'Macbook Pro 2016', CAST(20500000 AS Decimal(18, 0)), N'/Content/Image/MP/2016/macbookpro2016-silver13.jpg', N'/Content/Image/MP/2016/1.jpg', N'/Content/Image/MP/2016/2.jpg', N'/Content/Image/MP/2016/3.jpg', N'520', N'None', N'13.3', N'Si', N'16', N'256SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (8, N'MLL42', 5, 3, N'Macbook Pro 2016', CAST(20500000 AS Decimal(18, 0)), N'/Content/Image/MP/2016/macbookpro2016-grey13.jpg', N'/Content/Image/MP/2016/1.jpg', N'/Content/Image/MP/2016/2.jpg', N'/Content/Image/MP/2016/3.jpg', N'520', N'None', N'13.3', N'Gr', N'16', N'256SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (9, N'MPXY2', 5, 1, N'Macbook Pro 2017', CAST(28500000 AS Decimal(18, 0)), N'/Content/Image/MP/2017/macbookpro2017-silver13.jpg', N'/Content/Image/MP/2017/1.jpg', N'/Content/Image/MP/2017/2.jpg', N'/Content/Image/MP/2017/3.jpg', N'531', N'None', N'13.3', N'Si', N'17', N'512SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (10, N'MPXX2', 5, 1, N'Macbook Pro 2017', CAST(24000000 AS Decimal(18, 0)), N'/Content/Image/MP/2017/macbookpro2017-silver13.jpg', N'/Content/Image/MP/2017/1.jpg', N'/Content/Image/MP/2017/2.jpg', N'/Content/Image/MP/2017/3.jpg', N'531', N'None', N'13.3', N'Si', N'17', N'256SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (11, N'MPXW2', 5, 1, N'Macbook Pro 2017', CAST(28500000 AS Decimal(18, 0)), N'/Content/Image/MP/2017/macbookpro2017-grey13.jpg', N'/Content/Image/MP/2017/1.jpg', N'/Content/Image/MP/2017/2.jpg', N'/Content/Image/MP/2017/3.jpg', N'531', N'None', N'13.3', N'Gr', N'17', N'512SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (12, N'MPXU2', 5, 5, N'Macbook Pro 2017', CAST(22900000 AS Decimal(18, 0)), N'/Content/Image/MP/2017/macbookpro2017-silver13.jpg', N'/Content/Image/MP/2017/1.jpg', N'/Content/Image/MP/2017/2.jpg', N'/Content/Image/MP/2017/3.jpg', N'523', N'None', N'13.3', N'Si', N'17', N'256SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (13, N'MR932', 5, 1, N'Macbook Pro 2018', CAST(35900000 AS Decimal(18, 0)), N'/Content/Image/MP/2018/macbookpro2018-grey15.jpg', N'/Content/Image/MP/2018/1.jpg', N'/Content/Image/MP/2018/2.jpg', N'/Content/Image/MP/2018/3.jpg', N'722', N'A555X', N'15.4', N'Gr', N'18', N'256SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (14, N'MR942', 5, 7, N'Macbook Pro 2018', CAST(36000000 AS Decimal(18, 0)), N'/Content/Image/MP/2018/macbookpro2018-grey15.jpg', N'/Content/Image/MP/2018/1.jpg', N'/Content/Image/MP/2018/2.jpg', N'/Content/Image/MP/2018/3.jpg', N'726', N'A560X', N'15.4', N'Gr', N'18', N'512SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (15, N'MR962', 5, 7, N'Macbook Pro 2018', CAST(35900000 AS Decimal(18, 0)), N'/Content/Image/MP/2018/macbookpro2018-grey15.jpg', N'/Content/Image/MP/2018/1.jpg', N'/Content/Image/MP/2018/2.jpg', N'/Content/Image/MP/2018/3.jpg', N'722', N'A555X', N'15.4', N'Gr', N'18', N'256SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (16, N'MR9V2', 5, 1, N'Macbook Pro 2018', CAST(32800000 AS Decimal(18, 0)), N'/Content/Image/MP/2018/macbookpro2018-silver13.jpg', N'/Content/Image/MP/2018/1.jpg', N'/Content/Image/MP/2018/2.jpg', N'/Content/Image/MP/2018/3.jpg', N'523', N'None', N'13.3', N'Gr', N'18', N'512SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (17, N'MV902', 5, 6, N'Macbook Pro 2019', CAST(38000000 AS Decimal(18, 0)), N'/Content/Image/MP/2019/macbookpro2019-grey15.jpg', N'/Content/Image/MP/2019/1.jpg', N'/Content/Image/MP/2019/2.jpg', N'/Content/Image/MP/2019/3.jpg', N'726', N'A555X', N'15.4', N'Gr', N'19', N'256SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (18, N'MV903', 5, 2, N'Macbook Pro 2019', CAST(45000000 AS Decimal(18, 0)), N'/Content/Image/MP/2019/macbookpro2019-grey15.jpg', N'/Content/Image/MP/2019/1.jpg', N'/Content/Image/MP/2019/2.jpg', N'/Content/Image/MP/2019/3.jpg', N'923', N'A560X', N'15.4', N'Gr', N'19', N'512SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (19, N'MV972', 5, 9, N'Macbook Pro 2019', CAST(30900000 AS Decimal(18, 0)), N'/Content/Image/MP/2019/macbookpro2019-silver13.jpg', N'/Content/Image/MP/2019/1.jpg', N'/Content/Image/MP/2019/2.jpg', N'/Content/Image/MP/2019/3.jpg', N'524', N'None', N'13.3', N'Gr', N'19', N'512SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (20, N'MV965', 5, 1, N'Macbook Pro 2019', CAST(30000000 AS Decimal(18, 0)), N'/Content/Image/MP/2019/macbookpro2019-silver13.jpg', N'/Content/Image/MP/2019/1.jpg', N'/Content/Image/MP/2019/2.jpg', N'/Content/Image/MP/2019/3.jpg', N'524', N'None', N'13.3', N'Gr', N'19', N'256SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (30, N'MXK62', 5, 1, N'Macbook Pro 2020', CAST(26300000 AS Decimal(18, 0)), N'/Content/Image/MP/2020/macbookpro2020-silver13.jpg', N'/Content/Image/MP/2020/1.jpg', N'/Content/Image/MP/2020/2.jpg', N'/Content/Image/MP/2020/3.jpg', N'514', N'None', N'13.3', N'Gr', N'20', N'256SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (32, N'MXK72', 5, 4, N'Macbook Pro 2020', CAST(31500000 AS Decimal(18, 0)), N'/Content/Image/MP/2020/macbookpro2020-silver13.jpg', N'/Content/Image/MP/2020/1.jpg', N'/Content/Image/MP/2020/2.jpg', N'/Content/Image/MP/2020/3.jpg', N'514', N'None', N'13.3', N'Gr', N'20', N'512SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (33, N'MWP42', 5, 1, N'Macbook Pro 2020', CAST(35500000 AS Decimal(18, 0)), N'/Content/Image/MP/2020/macbookpro2020-silver13.jpg', N'/Content/Image/MP/2020/1.jpg', N'/Content/Image/MP/2020/2.jpg', N'/Content/Image/MP/2020/3.jpg', N'520', N'None', N'13.3', N'Gr', N'20', N'512SD', N'16', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (34, N'MYDC2', 5, 1, N'Macbook Pro 2020', CAST(36490000 AS Decimal(18, 0)), N'/Content/Image/MP/2020/macbookpro2020-silver13.jpg', N'/Content/Image/MP/2020/1.jpg', N'/Content/Image/MP/2020/2.jpg', N'/Content/Image/MP/2020/3.jpg', N'M18C', N'None', N'13.3', N'Gr', N'20', N'512SD', N'8', N'MP', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (35, N'MV902', 5, 6, N'Macbook Pro 2019', CAST(43000000 AS Decimal(18, 0)), N'/Content/Image/MP/2019/macbookpro2019-grey15.jpg', N'/Content/Image/MP/2019/1.jpg', N'/Content/Image/MP/2019/2.jpg', N'/Content/Image/MP/2019/3.jpg', N'726', N'A555X', N'15.4', N'Gr', N'19', N'256SD', N'16', N'MP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (36, N'MV903', 5, 2, N'Macbook Pro 2019', CAST(50000000 AS Decimal(18, 0)), N'/Content/Image/MP/2019/macbookpro2019-grey15.jpg', N'/Content/Image/MP/2019/1.jpg', N'/Content/Image/MP/2019/2.jpg', N'/Content/Image/MP/2019/3.jpg', N'923', N'A560X', N'15.4', N'Gr', N'19', N'512SD', N'16', N'MP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (37, N'MV972', 5, 9, N'Macbook Pro 2019', CAST(35900000 AS Decimal(18, 0)), N'/Content/Image/MP/2019/macbookpro2019-silver13.jpg', N'/Content/Image/MP/2019/1.jpg', N'/Content/Image/MP/2019/2.jpg', N'/Content/Image/MP/2019/3.jpg', N'524', N'None', N'13.3', N'Gr', N'19', N'512SD', N'8', N'MP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (38, N'MV965', 5, 1, N'Macbook Pro 2019', CAST(35000000 AS Decimal(18, 0)), N'/Content/Image/MP/2019/macbookpro2019-silver13.jpg', N'/Content/Image/MP/2019/1.jpg', N'/Content/Image/MP/2019/2.jpg', N'/Content/Image/MP/2019/3.jpg', N'524', N'None', N'13.3', N'Gr', N'19', N'256SD', N'8', N'MP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (43, N'MXK62', 5, 1, N'Macbook Pro 2020', CAST(31300000 AS Decimal(18, 0)), N'/Content/Image/MP/2020/macbookpro2020-silver13.jpg', N'/Content/Image/MP/2020/1.jpg', N'/Content/Image/MP/2020/2.jpg', N'/Content/Image/MP/2020/3.jpg', N'514', N'None', N'13.3', N'Gr', N'20', N'256SD', N'8', N'MP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (44, N'MXK72', 5, 1, N'Macbook Pro 2020', CAST(36500000 AS Decimal(18, 0)), N'/Content/Image/MP/2020/macbookpro2020-silver13.jpg', N'/Content/Image/MP/2020/1.jpg', N'/Content/Image/MP/2020/2.jpg', N'/Content/Image/MP/2020/3.jpg', N'514', N'None', N'13.3', N'Gr', N'20', N'512SD', N'8', N'MP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (45, N'MWP42', 5, 1, N'Macbook Pro 2020', CAST(40500000 AS Decimal(18, 0)), N'/Content/Image/MP/2020/macbookpro2020-silver13.jpg', N'/Content/Image/MP/2020/1.jpg', N'/Content/Image/MP/2020/2.jpg', N'/Content/Image/MP/2020/3.jpg', N'520', N'None', N'13.3', N'Gr', N'20', N'512SD', N'16', N'MP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (46, N'MYDC2', 5, 1, N'Macbook Pro 2020', CAST(41490000 AS Decimal(18, 0)), N'/Content/Image/MP/2020/macbookpro2020-silver13.jpg', N'/Content/Image/MP/2020/1.jpg', N'/Content/Image/MP/2020/2.jpg', N'/Content/Image/MP/2020/3.jpg', N'M18C', N'None', N'13.3', N'Gr', N'20', N'512SD', N'8', N'MP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (47, N'MJVP2', 5, 1, N'Macbook Air 2015', CAST(14000000 AS Decimal(18, 0)), N'/Content/Image/MA/2015/macbookair2015-11.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'516', N'None', N'11', N'Si', N'15', N'256SD', N'4', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (48, N'MJVM2', 5, 1, N'Macbook Air 2015', CAST(12000000 AS Decimal(18, 0)), N'/Content/Image/MA/2015/macbookair2015-11.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'516', N'None', N'11', N'Si', N'15', N'128SD', N'4', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (49, N'MJVG2', 5, 1, N'Macbook Air 2015', CAST(14000000 AS Decimal(18, 0)), N'/Content/Image/MA/2015/macbookair2015-13.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'516', N'None', N'13.3', N'Si', N'15', N'256SD', N'4', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (50, N'MJVE2', 5, 1, N'Macbook Air 2020', CAST(13000000 AS Decimal(18, 0)), N'/Content/Image/MA/2015/macbookair2015-13.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'/Content/Image/MA/2015/Empty.jpg', N'516', N'None', N'13.3', N'Si', N'15', N'128SD', N'4', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (51, N'MMGG2', 5, 1, N'Macbook Air 2016', CAST(16000000 AS Decimal(18, 0)), N'/Content/Image/MA/2016/macbookair2016-13.jpg', N'/Content/Image/MA/2016/Empty.jpg', N'/Content/Image/MA/2016/Empty.jpg', N'/Content/Image/MA/2016/Empty.jpg', N'516', N'None', N'13.3', N'Si', N'16', N'256SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (52, N'MMGF2', 5, 1, N'Macbook Air 2016', CAST(14200000 AS Decimal(18, 0)), N'/Content/Image/MA/2016/macbookair2016-13.jpg', N'/Content/Image/MA/2016/Empty.jpg', N'/Content/Image/MA/2016/Empty.jpg', N'/Content/Image/MA/2016/Empty.jpg', N'516', N'None', N'13.3', N'Si', N'16', N'128SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (53, N'MQD42', 5, 1, N'Macbook Air 2017', CAST(17300000 AS Decimal(18, 0)), N'/Content/Image/MA/2017/macbookair2017-13.jpg', N'/Content/Image/MA/2017/Empty.jpg', N'/Content/Image/MA/2017/Empty.jpg', N'/Content/Image/MA/2017/Empty.jpg', N'518', N'None', N'13.3', N'Si', N'17', N'256SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (54, N'MQD32', 5, 1, N'Macbook Air 2017', CAST(15900000 AS Decimal(18, 0)), N'/Content/Image/MA/2017/macbookair2017-13.jpg', N'/Content/Image/MA/2017/Empty.jpg', N'/Content/Image/MA/2017/Empty.jpg', N'/Content/Image/MA/2017/Empty.jpg', N'518', N'None', N'13.3', N'Si', N'17', N'128SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (55, N'MREC2', 5, 1, N'Macbook Air 2018', CAST(22500000 AS Decimal(18, 0)), N'/Content/Image/MA/2018/macbookair2018-13.jpg', N'/Content/Image/MA/2018/Empty.jpg', N'/Content/Image/MA/2018/Empty.jpg', N'/Content/Image/MA/2018/Empty.jpg', N'516', N'None', N'13.3', N'Gr', N'18', N'256SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (56, N'MREA2', 5, 1, N'Macbook Air 2018', CAST(19500000 AS Decimal(18, 0)), N'/Content/Image/MA/2018/macbookair2018-13.jpg', N'/Content/Image/MA/2018/Empty.jpg', N'/Content/Image/MA/2018/Empty.jpg', N'/Content/Image/MA/2018/Empty.jpg', N'516', N'None', N'13.3', N'Gr', N'18', N'128SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (57, N'MVFL2', 5, 1, N'Macbook Air 2019', CAST(22300000 AS Decimal(18, 0)), N'/Content/Image/MA/2019/macbookair2019-13.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'516', N'None', N'13.3', N'Gr', N'19', N'256SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (58, N'MVFK2', 5, 1, N'Macbook Air 2019', CAST(20900000 AS Decimal(18, 0)), N'/Content/Image/MA/2019/macbookair2019-13.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'516', N'None', N'13.3', N'Gr', N'19', N'128SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (59, N'MWTK2', 5, 1, N'Macbook Air 2020', CAST(21800000 AS Decimal(18, 0)), N'/Content/Image/MA/2020/macbookair2020-13.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'311', N'None', N'13.3', N'Gr', N'20', N'256SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (60, N'MVH52', 5, 10, N'Macbook Air 2020', CAST(23900000 AS Decimal(18, 0)), N'/Content/Image/MA/2020/macbookair2020-13.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'511', N'None', N'13.3', N'Gr', N'20', N'512SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (61, N'MGNE3', 5, 1, N'Macbook Air 2020', CAST(29900000 AS Decimal(18, 0)), N'/Content/Image/MA/2020/macbookair2020-m113.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'M18C', N'None', N'13.3', N'Gr', N'20', N'512SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (62, N'MGND3', 5, 1, N'Macbook Air 2020', CAST(25800000 AS Decimal(18, 0)), N'/Content/Image/MA/2020/macbookair2020-m113.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'M18C', N'None', N'13.3', N'Gr', N'20', N'256SD', N'8', N'MA', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (63, N'MVFL2', 5, 1, N'Macbook Air 2019', CAST(27300000 AS Decimal(18, 0)), N'/Content/Image/MA/2019/macbookair2019-13.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'516', N'None', N'13.3', N'Gr', N'19', N'256SD', N'8', N'MA', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (64, N'MVFK2', 5, 1, N'Macbook Air 2019', CAST(25900000 AS Decimal(18, 0)), N'/Content/Image/MA/2019/macbookair2019-13.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'/Content/Image/MA/2019/Empty.jpg', N'516', N'None', N'13.3', N'Gr', N'19', N'128SD', N'8', N'MA', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (65, N'MWTK2', 5, 1, N'Macbook Air 2020', CAST(26800000 AS Decimal(18, 0)), N'/Content/Image/MA/2020/macbookair2020-13.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'311', N'None', N'13.3', N'Gr', N'20', N'256SD', N'8', N'MA', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (66, N'MVH52', 5, 1, N'Macbook Air 2020', CAST(28900000 AS Decimal(18, 0)), N'/Content/Image/MA/2020/macbookair2020-13.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'511', N'None', N'13.3', N'Gr', N'20', N'512SD', N'8', N'MA', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (67, N'MGNE3', 5, 9, N'Macbook Air 2020', CAST(34900000 AS Decimal(18, 0)), N'/Content/Image/MA/2020/macbookair2020-m113.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'M18C', N'None', N'13.3', N'Gr', N'20', N'512SD', N'8', N'MA', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (68, N'MGND5', 5, 1, N'Macbook Air 2020', CAST(30800000 AS Decimal(18, 0)), N'/Content/Image/MA/2020/macbookair2020-m113.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'/Content/Image/MA/2020/Empty.jpg', N'M18C', N'None', N'13.3', N'Gr', N'20', N'256SD', N'8', N'MA', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (71, N'Magic Keyboard 2', 5, 11, N'Magic Keyboard 2', CAST(1750000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magickeyboard2white.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboard2white1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboard2white2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboard2white3.jpg', NULL, NULL, NULL, N'Wh', N'None', NULL, NULL, N'MK', N'Old')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (72, N'Magic Keyboard 2', 5, 12, N'Magic Keyboard 2', CAST(2700000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magickeyboard2white.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboard2white1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboard2white2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboard2white3.jpg', NULL, NULL, NULL, N'Bl', N'None', NULL, NULL, N'MK', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (73, N'Magic Keyboard Với bàn phím số', 5, 1, N'Magic Keyboard With Number', CAST(3450000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberWhite.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberWhite1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberWhite2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberWhite3.jpg', NULL, NULL, NULL, N'Wh', N'None', NULL, NULL, N'MK', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (74, N'Magic Keyboard với bàn phím số', 5, 5, N'Magic Keyboard With Number', CAST(3950000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberBlack.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberBlack1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberBlack3.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberBlack3.jpg', NULL, NULL, NULL, N'Bl', N'None', NULL, NULL, N'MK', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (75, N'Magic Trackpad 2', 5, 25, N'Magic Trackpad 2', CAST(3450000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magictrackpad2black.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magictrackpad2black1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magictrackpad2black2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magictrackpad2black3.jpg', NULL, NULL, NULL, N'Bl', N'None', NULL, NULL, N'TP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (76, N'Magic Trackpad 2', 5, 1, N'Magic Trackpad 2', CAST(2200000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magictrackpad2white.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magictrackpad2white1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magictrackpad2white2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magictrackpad2white3.jpg', NULL, NULL, NULL, N'Wh', N'None', NULL, NULL, N'TP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (77, N'Magic Mouse 2', 5, 16, N'Magic Mouse 2', CAST(2590000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magicmouse2black.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magicmouse2black1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magicmouse2black2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magicmouse2black3.jpg', NULL, NULL, NULL, N'Bl', N'None', NULL, NULL, N'MM', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (78, N'Magic Mouse 2', 5, 1, N'Magic Mouse 2', CAST(1950000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magicmouse2white.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magicmouse2white1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magicmouse2white2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magicmouse2white3.jpg', NULL, NULL, NULL, N'Wh', N'None', NULL, NULL, N'MM', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (79, N'Magic Keyboard 2 với bàn phím số', 5, 1, N'Magic Keyboard 2 With Number', CAST(3950000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberWhite.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberWhite1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberWhite2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberWhite3.jpg', NULL, NULL, NULL, N'Wh', N'None', NULL, NULL, N'MK', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (80, N'Magic Keyboard 2 With Number', 5, 1, N'Magic Keyboard 2 With Number', CAST(4250000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberBlack.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberBlack1.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberBlack2.jpg', N'/Content/Image/Phukien/Chuotvabanphim/magickeyboardwithnumberBlack3.jpg', NULL, NULL, NULL, N'Bl', N'None', NULL, NULL, N'MK', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (81, N'USB-C VGA Multiport Adapter', 5, 1, N'USB-C VGA Multiport Adapter', CAST(1890000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Cap/USBCVGA.jpg', N'/Content/Image/Phukien/Cap/USBCVGA1.jpg', N'/Content/Image/Phukien/Cap/USBCVGA2.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', NULL, NULL, NULL, N'Wh', N'None', NULL, NULL, N'CAP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (82, N'Mini DP (Thunderbolt 2) sang HDMI + VGA Ugreen', 5, 3, N'Mini DP (Thunderbolt 2) sang HDMI + VGA Ugreen', CAST(1050000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Cap/MiniDP.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', NULL, NULL, NULL, N'Wh', N'None', NULL, NULL, N'CAP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (83, N'USB-C HyperDrive SOLO 7-in-1 (có HDMI, thẻ nhớ)', 5, 1, N'USB-C HyperDrive SOLO 7-in-1 (có HDMI, thẻ nhớ)', CAST(2200000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Cap/USBCHyperDrive7.jpg', N'/Content/Image/Phukien/Cap/USBCHyperDrive71.jpg', N'/Content/Image/Phukien/Cap/USBCHyperDrive72.jpg', N'/Content/Image/Phukien/Cap/USBCHyperDrive73.jpg', NULL, NULL, NULL, N'Gr', N'None', NULL, NULL, N'CAP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (84, N'USB-C HyperDrive 8-in-1', 5, 1, N'USB-C HyperDrive 8-in-1', CAST(2950000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Cap/USBCHyperDrive8.jpg', N'/Content/Image/Phukien/Cap/USBCHyperDrive81.jpg', N'/Content/Image/Phukien/Cap/USBCHyperDrive82.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', NULL, NULL, NULL, N'Gr', N'None', NULL, NULL, N'CAP', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (85, N'Ssimoo', 5, 5, N'Ssimoo', CAST(360000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Tui/Ssimoo.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', NULL, NULL, NULL, N'Na', N'None', NULL, NULL, N'TUI', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (86, N'incase City sleeve 11” 12” 13” 15”', 5, 1, N'incase City sleeve 11” 12” 13” 15”', CAST(750000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Tui/incaseCitySleeve.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', NULL, NULL, NULL, N'Gr', N'None', NULL, NULL, N'TUI', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (87, N'InCase ICON Sleeve with Woolenex cho MacBook', 5, 6, N'InCase ICON Sleeve with Woolenex cho MacBook', CAST(1250000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Tui/incaseIconSleeve.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', NULL, NULL, NULL, N'Bl', N'None', NULL, NULL, N'TUI', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (88, N'Incase Nylon Compact Sleeve cho MacBook', 5, 7, N'Incase Nylon Compact Sleeve cho MacBook', CAST(1200000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Tui/incaseNylon.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', NULL, NULL, NULL, N'Bl', N'None', NULL, NULL, N'TUI', N'New')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Stock], [Sold], [Description], [Price], [ImageSourceMain], [ImageSource1], [ImageSource2], [ImageSource3], [CpuID], [DisplayCardID], [DisplayID], [ColorID], [YearID], [HardDriveID], [RamID], [GroupID], [Status]) VALUES (89, N'Incase 12″ Slim Sleeve in Honeycomb Ripstop cho MacBook', 5, 1, N'Incase 12″ Slim Sleeve in Honeycomb Ripstop cho MacBook', CAST(1200000 AS Decimal(18, 0)), N'/Content/Image/Phukien/Tui/Incase12.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', N'/Content/Image/Phukien/Cap/Empty.jpg', NULL, NULL, NULL, N'Pi', N'None', NULL, NULL, N'TUI', N'New')
SET IDENTITY_INSERT [dbo].[Product] OFF
INSERT [dbo].[RAM] ([RamID], [RamName]) VALUES (N'16', N'16GB')
INSERT [dbo].[RAM] ([RamID], [RamName]) VALUES (N'32', N'32GB')
INSERT [dbo].[RAM] ([RamID], [RamName]) VALUES (N'4', N'4GB')
INSERT [dbo].[RAM] ([RamID], [RamName]) VALUES (N'8', N'8GB')
INSERT [dbo].[RAM] ([RamID], [RamName]) VALUES (N'None', N' ')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'12', N'2012')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'13', N'2013')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'14', N'2014')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'15', N'2015')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'16', N'2016')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'17', N'2017')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'18', N'2018')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'19', N'2019')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'20', N'2020')
INSERT [dbo].[Year] ([YearID], [YearName]) VALUES (N'None', N'UnKnown Years')
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Order]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Color] FOREIGN KEY([ColorID])
REFERENCES [dbo].[Color] ([ColorID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Color]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_CPU] FOREIGN KEY([CpuID])
REFERENCES [dbo].[CPU] ([CpuID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_CPU]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Display] FOREIGN KEY([DisplayID])
REFERENCES [dbo].[Display] ([DisplayID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Display]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_DisplayCard] FOREIGN KEY([DisplayCardID])
REFERENCES [dbo].[DisplayCard] ([DisplayCardID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_DisplayCard]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Group] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Group] ([GroupID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Group]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_HardDrive] FOREIGN KEY([HardDriveID])
REFERENCES [dbo].[HardDrive] ([HardDriveID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_HardDrive]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_RAM] FOREIGN KEY([RamID])
REFERENCES [dbo].[RAM] ([RamID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_RAM]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Year] FOREIGN KEY([YearID])
REFERENCES [dbo].[Year] ([YearID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Year]
GO
USE [master]
GO
ALTER DATABASE [MacBookStore] SET  READ_WRITE 
GO
