USE [master]
GO
/****** Object:  Database [ECommerce_PRN211]    Script Date: 11/12/2021 19:24:18 ******/
CREATE DATABASE [ECommerce_PRN211] ON  PRIMARY 
( NAME = N'ECommerce_PRN211', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ECommerce_PRN211.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ECommerce_PRN211_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ECommerce_PRN211_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ECommerce_PRN211] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ECommerce_PRN211].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ECommerce_PRN211] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET ARITHABORT OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET AUTO_CLOSE ON
GO
ALTER DATABASE [ECommerce_PRN211] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ECommerce_PRN211] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ECommerce_PRN211] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ECommerce_PRN211] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET  ENABLE_BROKER
GO
ALTER DATABASE [ECommerce_PRN211] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ECommerce_PRN211] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ECommerce_PRN211] SET  READ_WRITE
GO
ALTER DATABASE [ECommerce_PRN211] SET RECOVERY SIMPLE
GO
ALTER DATABASE [ECommerce_PRN211] SET  MULTI_USER
GO
ALTER DATABASE [ECommerce_PRN211] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ECommerce_PRN211] SET DB_CHAINING OFF
GO
USE [ECommerce_PRN211]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/12/2021 19:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[cid] [int] IDENTITY(1,1) NOT NULL,
	[cname] [nvarchar](30) NOT NULL,
	[cphone] [varchar](30) NULL,
	[cAddress] [nvarchar](100) NULL,
	[username] [varchar](30) NOT NULL,
	[password] [varchar](32) NOT NULL,
	[salt] [varchar](30) NULL,
	[status] [bit] NULL,
	[role] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/12/2021 19:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[cateID] [int] IDENTITY(1,1) NOT NULL,
	[cateName] [nvarchar](50) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[cateID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/12/2021 19:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[pid] [varchar](30) NOT NULL,
	[pname] [nvarchar](100) NOT NULL,
	[quantity] [int] NULL,
	[price] [money] NULL,
	[image] [varchar](100) NULL,
	[description] [nvarchar](max) NULL,
	[status] [bit] NULL,
	[cateID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/12/2021 19:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bill](
	[oID] [varchar](32) NOT NULL,
	[dateCreate] [datetime] NULL,
	[cname] [nvarchar](30) NOT NULL,
	[cphone] [varchar](30) NULL,
	[cAddress] [nvarchar](100) NULL,
	[total] [money] NULL,
	[status] [int] NULL,
	[cid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[oID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 11/12/2021 19:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BillDetail](
	[pid] [varchar](30) NOT NULL,
	[oID] [varchar](32) NOT NULL,
	[quantity] [int] NULL,
	[price] [money] NULL,
	[total] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[pid] ASC,
	[oID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__Customer__status__117F9D94]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((1)) FOR [status]
GO
/****** Object:  Default [DF__Category__status__014935CB]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Category] ADD  DEFAULT ((1)) FOR [status]
GO
/****** Object:  Default [DF__Product__status__07F6335A]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((1)) FOR [status]
GO
/****** Object:  Default [DF__Bill__dateCreate__164452B1]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [dateCreate]
GO
/****** Object:  Default [DF__Bill__status__173876EA]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
/****** Object:  Check [CK__Customer__passwo__108B795B]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD CHECK  ((len([password])>=(8)))
GO
/****** Object:  Check [CK__Product__price__07020F21]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Product]  WITH CHECK ADD CHECK  (([price]>=(0)))
GO
/****** Object:  Check [CK__Product__quantit__060DEAE8]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Product]  WITH CHECK ADD CHECK  (([quantity]>=(0)))
GO
/****** Object:  ForeignKey [FK__Product__cateID__08EA5793]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([cateID])
REFERENCES [dbo].[Category] ([cateID])
GO
/****** Object:  ForeignKey [FK__Bill__cid__182C9B23]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([cid])
REFERENCES [dbo].[Customer] ([cid])
GO
/****** Object:  ForeignKey [FK__BillDetail__oID__1DE57479]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD FOREIGN KEY([oID])
REFERENCES [dbo].[Bill] ([oID])
GO
/****** Object:  ForeignKey [FK__BillDetail__pid__1CF15040]    Script Date: 11/12/2021 19:24:19 ******/
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD FOREIGN KEY([pid])
REFERENCES [dbo].[Product] ([pid])
GO
