USE [master]
GO
/****** Object:  Database [sodacafe]    Script Date: 8/10/2022 6:05:07 PM ******/
CREATE DATABASE [sodacafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sodacafe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sodacafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sodacafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sodacafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sodacafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sodacafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sodacafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [sodacafe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sodacafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sodacafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sodacafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sodacafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sodacafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sodacafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sodacafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sodacafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sodacafe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sodacafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sodacafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sodacafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sodacafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sodacafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sodacafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sodacafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sodacafe] SET RECOVERY FULL 
GO
ALTER DATABASE [sodacafe] SET  MULTI_USER 
GO
ALTER DATABASE [sodacafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sodacafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sodacafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sodacafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sodacafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sodacafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'sodacafe', N'ON'
GO
ALTER DATABASE [sodacafe] SET QUERY_STORE = OFF
GO
USE [sodacafe]
GO
/****** Object:  User [Admin]    Script Date: 8/10/2022 6:05:07 PM ******/
CREATE USER [Admin] FOR LOGIN [Admin] WITH DEFAULT_SCHEMA=[db_datareader]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Admin]
GO
/****** Object:  Table [dbo].[tblproduct]    Script Date: 8/10/2022 6:05:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblproduct](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](240) NOT NULL,
	[catId] [int] NOT NULL,
	[price] [money] NOT NULL,
	[image] [nvarchar](max) NOT NULL,
	[pro_size] [varchar](5) NOT NULL,
 CONSTRAINT [PK__tblprodu__3213E83F3A27CDB9] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblorder]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblorder](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[seller] [varchar](240) NULL,
	[date] [date] NULL,
	[time] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblorderdetail]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblorderdetail](
	[id] [int] NOT NULL,
	[proId] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [money] NULL,
	[discount] [float] NULL,
 CONSTRAINT [pk_id_o] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[proId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcategory]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[description] [text] NULL,
	[uptodate] [datetime] NOT NULL,
 CONSTRAINT [PK__tblcateg__3213E83F92AF2DBF] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_product_sale]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_product_sale] AS SELECT p.id,p.name as product_name,c.name,p.pro_size,p.price,od.quantity,od.discount,o.seller,o.[date],o.[time] 
FROM tblcategory c INNER JOIN (tblproduct p INNER JOIN (tblorderdetail od INNER JOIN tblorder o on o.id = od.id) on od.proId = p.id) on p.catId = c.id;
GO
/****** Object:  View [dbo].[view_product]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_product] AS SELECT  s.id ,s.product_name,s.price,s.pro_size,SUM(s.quantity) as [quantity],s.[date]
FROM view_product_sale s GROUP BY s.id,s.product_name,s.price,s.pro_size,s.[date];
GO
/****** Object:  Table [dbo].[tblimport]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblimport](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[supId] [int] NOT NULL,
	[employee] [varchar](240) NULL,
	[importdate] [datetime2](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblimportdetail]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblimportdetail](
	[imID] [int] NOT NULL,
	[proID] [int] NOT NULL,
	[quantity] [int] NULL,
	[cost] [money] NULL,
	[expire ] [datetime2](7) NOT NULL,
 CONSTRAINT [pk_id] PRIMARY KEY CLUSTERED 
(
	[imID] ASC,
	[proID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblsupplier]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblsupplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[phone] [varchar](240) NULL,
	[address] [nvarchar](240) NULL,
	[email] [varchar](50) NULL,
	[image] [nvarchar](max) NULL,
	[uptodate] [datetime] NOT NULL,
	[active] [tinyint] NOT NULL,
 CONSTRAINT [PK__tblsuppl__3213E83F668EAEC8] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblproductimport]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblproductimport](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[cost] [money] NULL,
	[description] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_product_import]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_product_import]
	AS select im.id as [Import ID],p.id as [Product ID],p.name as [Product Name],imd.cost as [Cost],imd.quantity
	as [Quantity],imd.[expire ] as [Expire],s.name as [Supplier],im.employee as [Employee] ,im.importdate as [Import Date]
from tblproductimport p INNER JOIN (tblimportdetail imd INNER JOIN (tblimport im INNER JOIN tblsupplier s on im.supId= s.id) on im.id = imd.imID) on imd.proID = p.id
GO
SET IDENTITY_INSERT [dbo].[tblcategory] ON 

INSERT [dbo].[tblcategory] ([id], [name], [description], [uptodate]) VALUES (1, N'ice coffee', NULL, CAST(N'2022-07-13T16:52:09.180' AS DateTime))
INSERT [dbo].[tblcategory] ([id], [name], [description], [uptodate]) VALUES (2, N'hot coffee', NULL, CAST(N'2022-07-20T09:30:39.137' AS DateTime))
INSERT [dbo].[tblcategory] ([id], [name], [description], [uptodate]) VALUES (3, N'bread', NULL, CAST(N'2022-07-20T09:31:23.733' AS DateTime))
INSERT [dbo].[tblcategory] ([id], [name], [description], [uptodate]) VALUES (4, N'Buns & Rolls', NULL, CAST(N'2022-07-23T10:59:07.027' AS DateTime))
INSERT [dbo].[tblcategory] ([id], [name], [description], [uptodate]) VALUES (5, N'Cake', NULL, CAST(N'2022-07-23T10:59:33.193' AS DateTime))
INSERT [dbo].[tblcategory] ([id], [name], [description], [uptodate]) VALUES (6, N'Cookies & Bars', NULL, CAST(N'2022-07-23T10:59:54.050' AS DateTime))
INSERT [dbo].[tblcategory] ([id], [name], [description], [uptodate]) VALUES (7, N'Muffins & Popovers', NULL, CAST(N'2022-07-23T11:00:14.387' AS DateTime))
INSERT [dbo].[tblcategory] ([id], [name], [description], [uptodate]) VALUES (8, N'Doughnuts', NULL, CAST(N'2022-07-23T11:08:48.323' AS DateTime))
SET IDENTITY_INSERT [dbo].[tblcategory] OFF
GO
SET IDENTITY_INSERT [dbo].[tblimport] ON 

INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (2, 1, N'sa', CAST(N'2022-07-01T21:56:42.0000000' AS DateTime2))
INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (3, 1, N'sa', CAST(N'2022-08-01T10:14:42.0000000' AS DateTime2))
INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (4, 1, N'sa', CAST(N'2022-08-01T10:17:47.0000000' AS DateTime2))
INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (5, 6, N'sa', CAST(N'2022-08-01T10:20:35.0000000' AS DateTime2))
INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (6, 8, N'sa', CAST(N'2022-08-01T10:20:52.0000000' AS DateTime2))
INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (7, 3, N'sa', CAST(N'2022-08-01T10:27:37.0000000' AS DateTime2))
INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (8, 6, N'sa', CAST(N'2022-08-01T10:29:13.0000000' AS DateTime2))
INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (3004, 2, N'Admin', CAST(N'2022-08-02T21:04:36.0000000' AS DateTime2))
INSERT [dbo].[tblimport] ([id], [supId], [employee], [importdate]) VALUES (3005, 1, N'Admin', CAST(N'2022-08-09T10:05:46.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[tblimport] OFF
GO
INSERT [dbo].[tblimportdetail] ([imID], [proID], [quantity], [cost], [expire ]) VALUES (3, 3, 30, 12.0000, CAST(N'2022-08-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblimportdetail] ([imID], [proID], [quantity], [cost], [expire ]) VALUES (3, 4, 40, 3.0000, CAST(N'2022-08-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblimportdetail] ([imID], [proID], [quantity], [cost], [expire ]) VALUES (4, 3, 20, 12.0000, CAST(N'2023-09-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblimportdetail] ([imID], [proID], [quantity], [cost], [expire ]) VALUES (6, 3, 20, 12.0000, CAST(N'2022-08-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblimportdetail] ([imID], [proID], [quantity], [cost], [expire ]) VALUES (7, 4, 40, 2.0000, CAST(N'2022-08-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblimportdetail] ([imID], [proID], [quantity], [cost], [expire ]) VALUES (8, 4, 30, 2.0000, CAST(N'2022-08-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblimportdetail] ([imID], [proID], [quantity], [cost], [expire ]) VALUES (3005, 3, 4, 12.0000, CAST(N'2023-08-09T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblimportdetail] ([imID], [proID], [quantity], [cost], [expire ]) VALUES (3005, 4, 10, 2.0000, CAST(N'2022-12-09T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[tblorder] ON 

INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (1, N'sa', CAST(N'2021-01-25' AS Date), CAST(N'11:45:08' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2, N'sa', CAST(N'2021-01-25' AS Date), CAST(N'12:00:49' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (3, N'sa', CAST(N'2021-01-25' AS Date), CAST(N'12:04:24' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (4, N'sa', CAST(N'2021-01-25' AS Date), CAST(N'12:13:47' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (5, N'sa', CAST(N'2021-02-25' AS Date), CAST(N'23:03:07' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (6, N'sa', CAST(N'2021-02-25' AS Date), CAST(N'23:03:37' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (7, N'sa', CAST(N'2021-02-25' AS Date), CAST(N'23:04:06' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (8, N'sa', CAST(N'2021-02-25' AS Date), CAST(N'23:04:36' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (9, N'sa', CAST(N'2021-03-27' AS Date), CAST(N'23:05:58' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (10, N'sa', CAST(N'2021-03-27' AS Date), CAST(N'23:06:26' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (11, N'sa', CAST(N'2021-03-27' AS Date), CAST(N'23:07:14' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (12, N'sa', CAST(N'2021-03-27' AS Date), CAST(N'23:32:23' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (13, N'sa', CAST(N'2021-03-27' AS Date), CAST(N'23:34:25' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (14, N'sa', CAST(N'2021-03-27' AS Date), CAST(N'08:03:42' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (15, N'sa', CAST(N'2021-04-28' AS Date), CAST(N'09:54:23' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (16, N'sa', CAST(N'2021-04-28' AS Date), CAST(N'09:57:17' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (1015, N'sa', CAST(N'2021-04-28' AS Date), CAST(N'14:30:41' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (1016, N'sa', CAST(N'2021-04-28' AS Date), CAST(N'14:31:30' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (1017, N'sa', CAST(N'2021-04-28' AS Date), CAST(N'14:32:14' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2015, N'sa', CAST(N'2021-05-28' AS Date), CAST(N'13:19:24' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2016, N'sa', CAST(N'2021-05-28' AS Date), CAST(N'13:19:40' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2017, N'sa', CAST(N'2021-05-28' AS Date), CAST(N'13:20:10' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2018, N'sa', CAST(N'2021-05-28' AS Date), CAST(N'13:20:33' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2019, N'sa', CAST(N'2021-05-28' AS Date), CAST(N'13:20:54' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2020, N'sa', CAST(N'2021-06-28' AS Date), CAST(N'13:21:52' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2021, N'sa', CAST(N'2021-06-28' AS Date), CAST(N'16:21:15' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2022, N'sa', CAST(N'2021-06-28' AS Date), CAST(N'16:21:32' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2023, N'sa', CAST(N'2021-07-28' AS Date), CAST(N'16:21:57' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2024, N'sa', CAST(N'2021-07-28' AS Date), CAST(N'16:22:14' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2025, N'sa', CAST(N'2021-07-28' AS Date), CAST(N'16:22:41' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2026, N'sa', CAST(N'2021-07-28' AS Date), CAST(N'16:26:57' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2027, N'sa', CAST(N'2021-08-28' AS Date), CAST(N'16:27:17' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2028, N'sa', CAST(N'2021-08-28' AS Date), CAST(N'16:27:24' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2029, N'sa', CAST(N'2021-08-28' AS Date), CAST(N'16:27:34' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2030, N'sa', CAST(N'2021-08-28' AS Date), CAST(N'16:29:02' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2031, N'sa', CAST(N'2021-09-28' AS Date), CAST(N'16:29:33' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2032, N'sa', CAST(N'2021-09-28' AS Date), CAST(N'16:29:50' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2033, N'sa', CAST(N'2021-09-28' AS Date), CAST(N'16:30:07' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2034, N'sa', CAST(N'2021-09-28' AS Date), CAST(N'16:30:26' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2035, N'sa', CAST(N'2021-10-28' AS Date), CAST(N'16:30:44' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2036, N'sa', CAST(N'2021-10-28' AS Date), CAST(N'16:31:50' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2037, N'sa', CAST(N'2021-10-28' AS Date), CAST(N'16:33:23' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2038, N'sa', CAST(N'2021-10-28' AS Date), CAST(N'16:34:24' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2039, N'sa', CAST(N'2021-11-28' AS Date), CAST(N'16:42:14' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2040, N'sa', CAST(N'2021-11-28' AS Date), CAST(N'16:42:28' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2041, N'sa', CAST(N'2021-11-28' AS Date), CAST(N'16:42:41' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2042, N'sa', CAST(N'2021-11-28' AS Date), CAST(N'16:48:00' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2043, N'sa', CAST(N'2021-12-28' AS Date), CAST(N'16:48:21' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2044, N'sa', CAST(N'2021-12-28' AS Date), CAST(N'16:48:33' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2045, N'sa', CAST(N'2021-12-28' AS Date), CAST(N'16:48:44' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2046, N'sa', CAST(N'2021-12-29' AS Date), CAST(N'16:50:39' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2047, N'sa', CAST(N'2022-01-29' AS Date), CAST(N'16:51:13' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2048, N'sa', CAST(N'2022-01-29' AS Date), CAST(N'16:52:02' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2049, N'sa', CAST(N'2022-02-28' AS Date), CAST(N'16:52:58' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2050, N'sa', CAST(N'2022-02-28' AS Date), CAST(N'16:53:42' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2051, N'sa', CAST(N'2022-02-28' AS Date), CAST(N'16:54:30' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2052, N'sa', CAST(N'2022-03-29' AS Date), CAST(N'16:57:43' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2053, N'sa', CAST(N'2022-03-29' AS Date), CAST(N'16:58:35' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2054, N'sa', CAST(N'2022-04-29' AS Date), CAST(N'16:59:27' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2055, N'sa', CAST(N'2022-05-29' AS Date), CAST(N'17:00:31' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2056, N'sa', CAST(N'2022-05-29' AS Date), CAST(N'17:01:24' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2057, N'sa', CAST(N'2022-06-29' AS Date), CAST(N'17:02:25' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2058, N'sa', CAST(N'2022-06-29' AS Date), CAST(N'17:03:01' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (2059, N'sa', CAST(N'2022-07-29' AS Date), CAST(N'17:03:50' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (3021, N'sa', CAST(N'2022-07-29' AS Date), CAST(N'21:10:56' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (3022, N'sa', CAST(N'2022-07-29' AS Date), CAST(N'21:11:15' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (3023, N'sa', CAST(N'2022-07-29' AS Date), CAST(N'21:12:31' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (3024, N'sa', CAST(N'2022-07-29' AS Date), CAST(N'21:13:27' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (3025, N'sa', CAST(N'2022-07-29' AS Date), CAST(N'21:16:52' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (3026, N'sa', CAST(N'2022-07-29' AS Date), CAST(N'21:17:45' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (3027, N'sa', CAST(N'2022-07-29' AS Date), CAST(N'21:43:57' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (4021, N'sa', CAST(N'2022-07-30' AS Date), CAST(N'08:02:43' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (4022, N'sa', CAST(N'2022-07-30' AS Date), CAST(N'08:02:58' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (4023, N'sa', CAST(N'2022-07-30' AS Date), CAST(N'08:58:51' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (4024, N'sa', CAST(N'2022-07-30' AS Date), CAST(N'08:59:07' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (4025, N'sa', CAST(N'2022-07-30' AS Date), CAST(N'08:59:21' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (5021, N'sa', CAST(N'2022-07-30' AS Date), CAST(N'11:11:49' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (5022, N'sa', CAST(N'2022-07-30' AS Date), CAST(N'11:13:34' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (6021, N'Admin', CAST(N'2022-07-30' AS Date), CAST(N'14:31:06' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (7021, N'Admin', CAST(N'2022-08-01' AS Date), CAST(N'09:33:21' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (8021, N'Admin', CAST(N'2022-08-02' AS Date), CAST(N'11:28:29' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (9021, N'Admin', CAST(N'2022-08-03' AS Date), CAST(N'15:49:38' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (10021, N'sa', CAST(N'2022-08-03' AS Date), CAST(N'21:56:45' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (10022, N'sa', CAST(N'2022-08-03' AS Date), CAST(N'22:35:30' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (10023, N'sa', CAST(N'2022-08-03' AS Date), CAST(N'22:39:08' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (10024, N'sa', CAST(N'2022-08-03' AS Date), CAST(N'22:41:20' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (10025, N'sa', CAST(N'2022-08-03' AS Date), CAST(N'22:45:38' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (10026, N'sa', CAST(N'2022-08-03' AS Date), CAST(N'23:00:50' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (11021, N'sa', CAST(N'2022-08-04' AS Date), CAST(N'17:32:09' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (11022, N'sa', CAST(N'2022-08-04' AS Date), CAST(N'17:33:44' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (12021, N'sa', CAST(N'2022-08-05' AS Date), CAST(N'10:29:48' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (13021, N'sa', CAST(N'2022-08-08' AS Date), CAST(N'21:40:32' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (13022, N'sa', CAST(N'2022-08-08' AS Date), CAST(N'21:43:14' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (14021, N'sa', CAST(N'2022-08-09' AS Date), CAST(N'12:50:18' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (14022, N'sa', CAST(N'2022-08-09' AS Date), CAST(N'12:54:46' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (14023, N'sa', CAST(N'2022-08-09' AS Date), CAST(N'12:57:05' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (14024, N'sa', CAST(N'2022-08-09' AS Date), CAST(N'13:07:03' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (15021, N'sa', CAST(N'2022-08-09' AS Date), CAST(N'17:38:25' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (16021, N'sa', CAST(N'2022-08-09' AS Date), CAST(N'22:07:45' AS Time))
GO
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (16022, N'sa', CAST(N'2022-08-09' AS Date), CAST(N'22:09:45' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (16023, N'sa', CAST(N'2022-08-09' AS Date), CAST(N'22:10:59' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (17021, N'sa', CAST(N'2022-08-10' AS Date), CAST(N'09:16:32' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (17022, N'sa', CAST(N'2022-08-10' AS Date), CAST(N'09:17:56' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (17023, N'sa', CAST(N'2022-08-10' AS Date), CAST(N'14:32:30' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (17024, N'sa', CAST(N'2022-08-10' AS Date), CAST(N'15:06:19' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (17025, N'sa', CAST(N'2022-08-10' AS Date), CAST(N'17:18:36' AS Time))
INSERT [dbo].[tblorder] ([id], [seller], [date], [time]) VALUES (17026, N'sa', CAST(N'2022-08-10' AS Date), CAST(N'17:34:44' AS Time))
SET IDENTITY_INSERT [dbo].[tblorder] OFF
GO
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1, 71, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 8, 2, 3.0000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 9, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 11, 2, 2.0000, 30)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 12, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 43, 2, 0.4000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 45, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 49, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 50, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 53, 2, 4.0000, 20)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 55, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2, 56, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 27, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 28, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 30, 1, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 31, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 32, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 35, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 36, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 37, 3, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 38, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 46, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 47, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 52, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 55, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 56, 3, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3, 74, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 27, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 28, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 29, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 31, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 32, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 33, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 34, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 35, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 36, 1, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 37, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 38, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 57, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 58, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 59, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 62, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 65, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4, 67, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (5, 70, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (5, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (6, 47, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (6, 50, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (6, 53, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (6, 55, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7, 31, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7, 32, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7, 37, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7, 38, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7, 47, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7, 52, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7, 55, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (8, 26, 3, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (8, 59, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (8, 61, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (8, 62, 1, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (8, 65, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (8, 68, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (9, 59, 3, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (9, 65, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10, 57, 1, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10, 61, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (11, 50, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (11, 53, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (11, 56, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (12, 12, 4, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (13, 32, 4, 1.5000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14, 50, 2, 3.0000, 30)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14, 52, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14, 56, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (15, 47, 2, 4.0000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16, 46, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16, 49, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16, 52, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1015, 49, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1015, 50, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1015, 52, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1015, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1015, 54, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1015, 55, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1016, 31, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1016, 33, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1016, 35, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1016, 37, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1016, 38, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1017, 11, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1017, 12, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1017, 40, 2, 0.3000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (1017, 41, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2015, 45, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2015, 46, 2, 2.0000, 0)
GO
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2015, 48, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2015, 49, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2015, 50, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2015, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2015, 55, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2015, 56, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2016, 27, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2016, 31, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2016, 32, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2016, 34, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2016, 35, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2016, 38, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2017, 25, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2017, 26, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2017, 69, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2017, 72, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2017, 73, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2017, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 57, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 58, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 59, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 60, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 61, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 62, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 63, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 65, 4, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 66, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 67, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2018, 68, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 7, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 9, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 11, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 12, 3, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 40, 3, 0.3000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 41, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 42, 2, 0.3000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 43, 2, 0.4000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2019, 44, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2020, 8, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2020, 9, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2020, 10, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2020, 12, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2020, 41, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2021, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2022, 69, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2022, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2023, 12, 1, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2023, 40, 1, 0.3000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2023, 44, 1, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2023, 70, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2023, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2024, 47, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2024, 50, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2024, 52, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2024, 56, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2025, 28, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2025, 30, 1, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2025, 35, 1, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2025, 38, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2026, 32, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2026, 34, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2026, 35, 1, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2026, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2027, 53, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2027, 55, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2028, 45, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2028, 49, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2028, 52, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2029, 31, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2029, 35, 1, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2030, 28, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2030, 29, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2030, 31, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2030, 32, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2030, 33, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2030, 35, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2030, 37, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2030, 38, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2031, 24, 3, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2031, 25, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2031, 26, 3, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2031, 52, 3, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2031, 54, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2031, 55, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2031, 56, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2032, 46, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2032, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2032, 62, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2032, 65, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2032, 68, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2033, 58, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2033, 62, 3, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2033, 64, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2034, 3, 3, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2034, 14, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2034, 15, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2035, 2, 2, 3.0000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2035, 3, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2035, 5, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2035, 23, 2, 2.0000, 0)
GO
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2036, 3, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2036, 6, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2036, 15, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2036, 18, 2, 3.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2036, 21, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2036, 72, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 8, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 9, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 10, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 11, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 12, 4, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 39, 4, 0.2000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 40, 1, 0.3000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 41, 3, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 43, 2, 0.4000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2037, 44, 4, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2038, 3, 10, 4.0000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2038, 26, 10, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2038, 29, 10, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2038, 35, 3, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2038, 38, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2038, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2039, 47, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2039, 50, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2039, 56, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2039, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2040, 47, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2040, 52, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2040, 53, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2040, 55, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2040, 56, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2041, 32, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2041, 35, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2041, 38, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2042, 46, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2042, 49, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2042, 50, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2042, 51, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2042, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2042, 55, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2042, 56, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2042, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2043, 46, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2043, 49, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2043, 56, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2044, 29, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2044, 32, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2044, 38, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2045, 11, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2045, 41, 3, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2046, 3, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2046, 18, 2, 3.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2046, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2047, 3, 4, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2047, 15, 9, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2047, 23, 3, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2047, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2048, 3, 6, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2048, 6, 4, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2048, 14, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2048, 15, 3, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2048, 17, 5, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2048, 18, 3, 3.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2048, 21, 4, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2048, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2049, 3, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2049, 18, 10, 3.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2049, 74, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2050, 3, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2050, 18, 2, 3.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2050, 74, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2051, 3, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2051, 23, 10, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2051, 74, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2052, 3, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2052, 18, 10, 3.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2052, 23, 20, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2052, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2053, 3, 20, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2053, 18, 20, 3.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2053, 23, 20, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2054, 3, 20, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2054, 6, 20, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2054, 23, 20, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2055, 12, 20, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2055, 44, 30, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2055, 56, 20, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2056, 50, 20, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2056, 56, 30, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2057, 47, 7, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2057, 50, 10, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2057, 53, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2057, 56, 11, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2058, 32, 10, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2058, 35, 10, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2058, 53, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2058, 56, 9, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2059, 47, 11, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2059, 53, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (2059, 56, 20, 5.0000, 0)
GO
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3021, 49, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3021, 50, 3, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3021, 53, 3, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3021, 55, 4, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3022, 61, 3, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3022, 62, 3, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3022, 65, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3022, 67, 4, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3023, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3024, 56, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3025, 2, 5, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3025, 5, 6, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3026, 14, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3026, 17, 4, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3026, 34, 4, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3027, 3, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3027, 6, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3027, 50, 10, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3027, 53, 4, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3027, 55, 5, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (3027, 56, 10, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4021, 50, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4021, 53, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4021, 56, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4022, 29, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4022, 32, 1, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4022, 34, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4023, 47, 4, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4023, 56, 2, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4023, 62, 3, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4023, 65, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4023, 67, 3, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4024, 3, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4024, 6, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4024, 18, 2, 3.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4024, 21, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4025, 3, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4025, 6, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4025, 17, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (4025, 23, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (5021, 1, 10, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (5022, 2, 10, 3.0000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (6021, 1, 3, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (6021, 2, 3, 3.0000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (6021, 3, 4, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7021, 11, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7021, 12, 3, 2.5000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (7021, 41, 2, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (8021, 3, 3, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (8021, 6, 2, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (9021, 8, 4, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10021, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10022, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10023, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10024, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10025, 46, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10025, 47, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10025, 50, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10026, 4, 2, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10026, 13, 2, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (10026, 17, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (11021, 71, 3, 3.0000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (11022, 8, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (11022, 9, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (11022, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (12021, 70, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (13021, 25, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (13021, 26, 2, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (13022, 27, 1, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (13022, 30, 1, 0.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (13022, 32, 3, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14021, 3, 1, 4.0000, 20)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14021, 5, 4, 3.0000, 10)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14022, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14023, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14024, 28, 1, 1.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (14024, 29, 2, 1.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (15021, 2, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (15021, 3, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (15021, 4, 1, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (15021, 5, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16021, 35, 10, 2.5000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16022, 3, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16022, 71, 10, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16023, 47, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16023, 50, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16023, 56, 1, 5.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16023, 71, 3, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (16023, 74, 2, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17021, 2, 10, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17021, 3, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17021, 6, 10, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17021, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17022, 23, 10, 2.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17022, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17023, 3, 3, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17024, 47, 1, 4.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17024, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17025, 71, 1, 3.0000, 0)
INSERT [dbo].[tblorderdetail] ([id], [proId], [quantity], [price], [discount]) VALUES (17026, 71, 1, 3.0000, 0)
GO
SET IDENTITY_INSERT [dbo].[tblproduct] ON 

INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (1, N'Buger', 3, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Burger.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (2, N'Buger', 3, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\Burger.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (3, N'Buger', 3, 4.0000, N'F:\code\C#\UI\MyAdmin\Resources\Burger.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (4, N'No-Knead Sourdough', 3, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\1.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (5, N'No-Knead Sourdough', 3, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\1.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (6, N'No-Knead Sourdough', 3, 4.0000, N'F:\code\C#\UI\MyAdmin\Resources\1.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (7, N'Cinnamon Star Bread', 4, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\2.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (8, N'Cinnamon Star Bread', 4, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\2.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (9, N'Cinnamon Star Bread', 4, 4.0000, N'F:\code\C#\UI\MyAdmin\Resources\2.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (10, N'Japanese Milk Bread Rolls', 4, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\3.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (11, N'Japanese Milk Bread Rolls', 4, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\3.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (12, N'Japanese Milk Bread Rolls', 4, 2.5000, N'F:\code\C#\UI\MyAdmin\Resources\3.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (13, N'Pain de Mie', 3, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\4.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (14, N'Pain de Mie', 3, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\4.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (15, N'Pain de Mie', 3, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\4.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (16, N'Overnight Panettone', 3, 2.5000, N'F:\code\C#\UI\MyAdmin\Resources\5.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (17, N'Overnight Panettone', 3, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\5.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (18, N'Overnight Panettone', 3, 3.5000, N'F:\code\C#\UI\MyAdmin\Resources\5.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (19, N'Banana Bread', 3, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\6.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (20, N'Banana Bread', 3, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\6.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (21, N'Banana Bread', 3, 2.5000, N'F:\code\C#\UI\MyAdmin\Resources\6.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (22, N'Sand wich', 3, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\sand_wich.png', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (23, N'Sand wich', 3, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\sand_wich.png', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (24, N'Famous Department Store Blueberry Muffins', 7, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Famous Department Store Blueberry Muffins.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (25, N'Famous Department Store Blueberry Muffins', 7, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Famous Department Store Blueberry Muffins.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (26, N'Famous Department Store Blueberry Muffins', 7, 2.5000, N'F:\code\C#\UI\MyAdmin\Resources\Famous Department Store Blueberry Muffins.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (27, N'Doughnut Muffins', 8, 0.5000, N'F:\code\C#\UI\MyAdmin\Resources\Doughnut Muffins.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (28, N'Doughnut Muffins', 8, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Doughnut Muffins.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (29, N'Doughnut Muffins', 8, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Doughnut Muffins.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (30, N'Chocolate Fudge Cake', 8, 0.5000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Fudge Cake.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (31, N'Chocolate Fudge Cake', 8, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Fudge Cake.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (32, N'Chocolate Fudge Cake', 8, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Fudge Cake.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (33, N'Baked Doughnuts Three Ways', 8, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Baked Doughnuts Three Ways.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (34, N'Baked Doughnuts Three Ways', 8, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Baked Doughnuts Three Ways.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (35, N'Baked Doughnuts Three Ways100', 8, 2.5000, N'F:\code\C#\UI\MyAdmin\Resources\Baked Doughnuts Three Ways.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (36, N'Cider Doughnuts', 8, 0.5000, N'F:\code\C#\UI\MyAdmin\Resources\Cider Doughnuts.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (37, N'Cider Doughnuts', 8, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Cider Doughnuts.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (38, N'Cider Doughnuts', 8, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Cider Doughnuts.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (39, N'Amish Dinner Rolls', 4, 0.2000, N'F:\code\C#\UI\MyAdmin\Resources\Amish Dinner Rolls.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (40, N'Amish Dinner Rolls', 4, 0.3000, N'F:\code\C#\UI\MyAdmin\Resources\Amish Dinner Rolls.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (41, N'Amish Dinner Rolls', 4, 0.5000, N'F:\code\C#\UI\MyAdmin\Resources\Amish Dinner Rolls.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (42, N'Beautiful Burger', 4, 0.3000, N'F:\code\C#\UI\MyAdmin\Resources\Beautiful Burger.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (43, N'Beautiful Burger', 4, 0.4000, N'F:\code\C#\UI\MyAdmin\Resources\Beautiful Burger.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (44, N'Beautiful Burger', 4, 0.5000, N'F:\code\C#\UI\MyAdmin\Resources\Beautiful Burger.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (45, N'Lemon Bliss', 5, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Lemon Bliss Cake.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (46, N'Lemon Bliss', 5, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Lemon Bliss Cake.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (47, N'Lemon Bliss', 5, 4.0000, N'F:\code\C#\UI\MyAdmin\Resources\Lemon Bliss Cake.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (48, N'Flourless Chocolate', 5, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Flourless Chocolate.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (49, N'Flourless Chocolate', 5, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Flourless Chocolate.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (50, N'Flourless Chocolate', 5, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\Flourless Chocolate.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (51, N'Chocolate Fudge Bundt', 5, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Fudge Bundt.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (52, N'Chocolate Fudge Bundt', 5, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Fudge Bundt.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (53, N'Chocolate Fudge Bundt', 5, 4.0000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Fudge Bundt.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (54, N'Golden Vanilla', 5, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\Golden Vanilla.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (55, N'Golden Vanilla', 5, 4.0000, N'F:\code\C#\UI\MyAdmin\Resources\Golden Vanilla.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (56, N'Golden Vanilla', 5, 5.0000, N'F:\code\C#\UI\MyAdmin\Resources\Golden Vanilla.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (57, N'Chocolate Chip', 6, 0.5000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Chip.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (58, N'Chocolate Chip', 6, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Chip.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (59, N'Chocolate Chip', 6, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Chocolate Chip.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (60, N'Fudge Brownies', 6, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Fudge Brownies.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (61, N'Fudge Brownies', 6, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Fudge Brownies.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (62, N'Fudge Brownies', 6, 2.5000, N'F:\code\C#\UI\MyAdmin\Resources\Fudge Brownies.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (63, N'Chewy Chocolate Chip', 6, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Chewy Chocolate Chip.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (64, N'Chewy Chocolate Chip', 6, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Chewy Chocolate Chip.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (65, N'Chewy Chocolate Chip', 6, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Chewy Chocolate Chip.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (66, N'Linzer Cookies', 6, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Linzer Cookies.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (67, N'Linzer Cookies', 6, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Linzer Cookies.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (68, N'Linzer Cookies', 6, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\Linzer Cookies.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (69, N'Mocha latte', 2, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Mocha latte.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (70, N'Mocha latte', 2, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Mocha latte.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (71, N'Mocha latte', 1, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\Mocha latte.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (72, N'Espresso', 2, 1.5000, N'F:\code\C#\UI\MyAdmin\Resources\Espresso.jpg', N'S')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (73, N'Espresso', 2, 2.0000, N'F:\code\C#\UI\MyAdmin\Resources\Espresso.jpg', N'M')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (74, N'Espresso', 2, 3.0000, N'F:\code\C#\UI\MyAdmin\Resources\Espresso.jpg', N'L')
INSERT [dbo].[tblproduct] ([id], [name], [catId], [price], [image], [pro_size]) VALUES (1069, N'test', 1, 1.0000, N'F:\code\C#\UI\MyAdmin\Resources\Linzer Cookies.jpg', N'S')
SET IDENTITY_INSERT [dbo].[tblproduct] OFF
GO
SET IDENTITY_INSERT [dbo].[tblproductimport] ON 

INSERT [dbo].[tblproductimport] ([id], [name], [cost], [description]) VALUES (3, N'ទឹកដោះគោ', 12.0000, N'')
INSERT [dbo].[tblproductimport] ([id], [name], [cost], [description]) VALUES (4, N'ម្សៅនំបុ័ង', 2.0000, N'')
SET IDENTITY_INSERT [dbo].[tblproductimport] OFF
GO
SET IDENTITY_INSERT [dbo].[tblsupplier] ON 

INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (1, N'គឹម​​​ ចិន្ដា', N'060 985 251', N'តាពៅ,បាវិត,បាវិត,ស្វាយរៀង', N'koemchinda.it@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\me.jpg', CAST(N'2022-07-22T17:17:07.337' AS DateTime), 0)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (2, N'ព្រាប នី', N'097 xxx xxxx', N'ស្វាយរៀង', N'preapny@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\preab_ny.jpg', CAST(N'2022-07-19T23:36:21.000' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (3, N'សោម ស្រីដា', N'097 xxx xxxx', N'ស្វាយរៀង', N'somsreyda@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\som_sreyda.jpg', CAST(N'2022-07-19T23:36:21.730' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (4, N'អឿន មតី', N'097 xxx xxxx', N'ស្វាយរៀង', N'preapny@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\mertey.jpg', CAST(N'2022-07-17T15:21:24.000' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (5, N'សេក ញ៉ាញ់', N'097 xxx xxxx', N'ស្វាយរៀង', N'preapny@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\sek_nhanh.jpg', CAST(N'2022-07-17T15:27:41.000' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (6, N'ភឿង ឃាង', N'097 xxx xxxx', N'ស្វាយរៀង', N'mechomnan@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\f_kheang.jpg', CAST(N'2022-07-17T15:27:41.000' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (7, N'ម៉ែ ចំណាន', N'097 xxx xxxx', N'ស្វាយរៀង', N'mechomnan@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\chamnan.jpg', CAST(N'2022-07-18T07:33:14.000' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (8, N'សុត មករា', N'097 xxx xxx xxx', N'ស្វាយរៀង', N'sotmakara@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\sot-makara.jpg', CAST(N'2022-07-20T01:00:56.663' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (9, N'ម៉ៅ ពេជ្រ', N'097 xxx xxxx', N'ស្វាយរៀង', N'moapich@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\som_sreyda.jpg', CAST(N'2022-07-20T01:00:56.667' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (10, N'ផន ពិសាល', N'060 xxx xxx', N'ស្វាយរៀង', N'phornpisal@gmail.com', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\som_sreyda.jpg', CAST(N'2022-07-20T01:00:56.670' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (11, N'គឹម ចិន្ដា', N'060 982 551', N'ស្វាយរៀង', N'', N'C:\Users\CHINDA\Desktop\me.jpg', CAST(N'2022-07-20T01:00:56.000' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (12, N'ពៅ វរៈបុត្រ', N'087 xxx xxx', N'ស្វាយរៀង', N'', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\bot.jpg', CAST(N'2022-07-22T01:00:56.000' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (13, N'សយ សុខី', N'087 xxx xxxx', N'ស្វាយរៀង', N'', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\khey.jpg', CAST(N'2022-07-20T01:00:56.677' AS DateTime), 1)
INSERT [dbo].[tblsupplier] ([id], [name], [phone], [address], [email], [image], [uptodate], [active]) VALUES (14, N'សុខ ភាព', N'097 xxx xxxx', N'ស្វាយរៀង', N'', N'F:\code\C#\UI\MyAdmin\MyAdmin\bin\Debug\People\phea.jpg', CAST(N'2022-07-20T08:55:15.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tblsupplier] OFF
GO
ALTER TABLE [dbo].[tblcategory] ADD  CONSTRAINT [DF__tblcatego__uptod__24927208]  DEFAULT (getdate()) FOR [uptodate]
GO
ALTER TABLE [dbo].[tblorder] ADD  DEFAULT (NULL) FOR [date]
GO
ALTER TABLE [dbo].[tblorder] ADD  DEFAULT (NULL) FOR [time]
GO
ALTER TABLE [dbo].[tblsupplier] ADD  CONSTRAINT [DF__tblsuppli__uptod__276EDEB3]  DEFAULT (getdate()) FOR [uptodate]
GO
ALTER TABLE [dbo].[tblsupplier] ADD  CONSTRAINT [DF_tblsupplier_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[tblimport]  WITH CHECK ADD  CONSTRAINT [FK__tblimport__supId__300424B4] FOREIGN KEY([supId])
REFERENCES [dbo].[tblsupplier] ([id])
GO
ALTER TABLE [dbo].[tblimport] CHECK CONSTRAINT [FK__tblimport__supId__300424B4]
GO
ALTER TABLE [dbo].[tblimportdetail]  WITH CHECK ADD  CONSTRAINT [fk_imID] FOREIGN KEY([imID])
REFERENCES [dbo].[tblimport] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblimportdetail] CHECK CONSTRAINT [fk_imID]
GO
ALTER TABLE [dbo].[tblimportdetail]  WITH CHECK ADD  CONSTRAINT [fk_proId] FOREIGN KEY([proID])
REFERENCES [dbo].[tblproductimport] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblimportdetail] CHECK CONSTRAINT [fk_proId]
GO
ALTER TABLE [dbo].[tblorderdetail]  WITH CHECK ADD  CONSTRAINT [fk_id] FOREIGN KEY([id])
REFERENCES [dbo].[tblorder] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblorderdetail] CHECK CONSTRAINT [fk_id]
GO
ALTER TABLE [dbo].[tblorderdetail]  WITH CHECK ADD  CONSTRAINT [fk_proId_o] FOREIGN KEY([proId])
REFERENCES [dbo].[tblproduct] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblorderdetail] CHECK CONSTRAINT [fk_proId_o]
GO
ALTER TABLE [dbo].[tblproduct]  WITH CHECK ADD  CONSTRAINT [FK__tblproduc__catId__2B3F6F97] FOREIGN KEY([catId])
REFERENCES [dbo].[tblcategory] ([id])
GO
ALTER TABLE [dbo].[tblproduct] CHECK CONSTRAINT [FK__tblproduc__catId__2B3F6F97]
GO
/****** Object:  StoredProcedure [dbo].[create_order]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[create_order](@seller varchar(50),@date date,@time time)
as
begin
	insert into tblorder(seller,date,time) values(@seller,@date,@time);
end
GO
/****** Object:  StoredProcedure [dbo].[create_order_detail]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[create_order_detail](@id int,@proId int,@qty int,@price money,@discount int)
as
begin
	insert into tblorderdetail values(@id,@proId,@qty,@price,@discount);
end
GO
/****** Object:  StoredProcedure [dbo].[create_product]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[create_product](
@name VARCHAR(50),
@catId int,
@price money,
@image nvarchar(max),
@pro_size varchar(5)
)
as
begin
	insert into tblproduct(name,catId,price,image,pro_size) values(@name,@catId,@price,@image,@pro_size);
end
GO
/****** Object:  StoredProcedure [dbo].[create_product_import]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[create_product_import](@name nvarchar(max),@cost money,@description nvarchar(max))
as
begin
	insert into tblproductimport(name,cost,description) values(@name,@cost,@description);
end
GO
/****** Object:  StoredProcedure [dbo].[create_supplier]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[create_supplier](
@name nvarchar(max),
@phone varchar(20),
@address nvarchar(max),
@email varchar(50),
@image nvarchar(max),
@update datetime
)
as
begin
	insert into tblsupplier(name,phone,address,email,image,uptodate) values(@name,@phone,@address,@email,@image,@update);
end
GO
/****** Object:  StoredProcedure [dbo].[delete_product]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[delete_product](@id int)
as
begin
	delete from tblproduct where id=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[delete_product_import]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_product_import](@id int)
as
begin
	delete from tblproductimport where id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[delete_supplier]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--create procedure read_supplier
CREATE procedure [dbo].[delete_supplier](@id int)
as
begin
	update tblsupplier set active = 0,uptodate = GETDATE() where id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[product_by_catId]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[product_by_catId](@catId int)
as
begin
	select * from tblproduct where catId = @catId;
end
GO
/****** Object:  StoredProcedure [dbo].[read_product]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[read_product]
as
begin
	select id,name,catId,price,image,pro_size from tblproduct order by id desc;
end
GO
/****** Object:  StoredProcedure [dbo].[read_product_import]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[read_product_import]
as
begin
	select * from tblproductimport;
end
GO
/****** Object:  StoredProcedure [dbo].[read_product_sale]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[read_product_sale](@date date)
as
begin
	SELECT s.id as [ID],s.product_name as [Product name],s.price as [Price],s.pro_size as [Size],SUM(s.quantity) as [Quantity],s.discount,
((s.price*SUM(s.quantity))-s.price*SUM(s.quantity)*s.discount/100) as [Amount],s.seller as [Seller],s.[date] as [Date]
FROM view_product_sale s WHERE s.[date] = @date GROUP BY s.id,s.product_name,s.price,s.pro_size,s.discount,s.seller,s.[date];
end
GO
/****** Object:  StoredProcedure [dbo].[read_supplier]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[read_supplier]
as
begin
	select id,name,phone,address,email,image,uptodate from tblsupplier as s where s.active = 1; 
end
GO
/****** Object:  StoredProcedure [dbo].[report_sale]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[report_sale](@year int)
as
begin
	SELECT MONTH([date]) as [month],sum(((price*quantity)-((price*quantity)*discount)/100)) as total FROM view_product_sale where YEAR([date])=@year GROUP BY MONTH([date]);
end
GO
/****** Object:  StoredProcedure [dbo].[search_product]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[search_product](@name nvarchar(max))
as
begin
	select id,name,catId,price,image,pro_size from tblproduct where name like @name;
end
GO
/****** Object:  StoredProcedure [dbo].[search_product_import]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_product_import](@name nvarchar(max))
as
begin
	select * from tblproductimport where name like @name;
end
GO
/****** Object:  StoredProcedure [dbo].[search_supplier]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--create procedure read_supplier
--as
--begin
--	select * from tblsupplier as s where s.active = 1; 
--end

--exec read_supplier;
CREATE procedure [dbo].[search_supplier](@name nvarchar(max))
as
begin
 select id,name,phone,address,email,image,uptodate from tblsupplier as s where s.active = 1 and s.name like @name;
end
GO
/****** Object:  StoredProcedure [dbo].[top_product]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[top_product](@date date)
as
begin
SELECT top  10 s.id as [ID],s.product_name as [Name],s.price as [Price],s.pro_size as [Size],MAX(s.quantity) as [Quantiy],
s.[date] as [Date] FROM  view_product s 
WHERE s.[date] = @date GROUP BY s.id,s.product_name,s.price,s.pro_size,s.[date]
ORDER BY MAX(s.quantity) DESC
end
GO
/****** Object:  StoredProcedure [dbo].[update_product]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec read_product;
CREATE procedure [dbo].[update_product](
@id int,
@name varchar(50),
@catId int,
@price money,
@image nvarchar(max),
@pro_size varchar(5)
)
as
begin
	update tblproduct set name = @name,catId = @catId ,price = @price,image = @image,pro_size = @pro_size
	where id =@id;
end
GO
/****** Object:  StoredProcedure [dbo].[update_product_import]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_product_import](@id int,@name nvarchar(max),@cost money,@description nvarchar(max))
as
begin
	update tblproductimport set name = @name,cost = @cost,description = @description where id=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[update_supplier]    Script Date: 8/10/2022 6:05:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--create procedure read_supplier
--as
--begin
--	select * from tblsupplier as s where s.active = 1; 
--end

--exec read_supplier;
--create procedure search_supplier(@name nvarchar(max))
--as
--begin
-- select id,name,phone,address,email,image,uptodate from tblsupplier as s where s.active = 1 and s.name like N'@name%';
--end

--exec search_supplier N'ស%'
create procedure [dbo].[update_supplier](
@id int,
@name nvarchar(max),
@phone varchar(20),
@address nvarchar(max),
@email varchar(50),
@image nvarchar(max),
@uptodate DATETIME
)
as
begin
	update tblsupplier set name =@name,phone=@phone,address = @address,email= @email,image = @image,uptodate=@uptodate where id =@id;
end
GO
USE [master]
GO
ALTER DATABASE [sodacafe] SET  READ_WRITE 
GO
