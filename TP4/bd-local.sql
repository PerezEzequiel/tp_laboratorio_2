USE [master]
GO
/****** Object:  Database [bd-local]    Script Date: 22/11/2021 16:12:17 ******/
CREATE DATABASE [bd-local]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd-local', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd-local.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd-local_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd-local_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bd-local] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd-local].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd-local] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd-local] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd-local] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd-local] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd-local] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd-local] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd-local] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd-local] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd-local] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd-local] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd-local] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd-local] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd-local] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd-local] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd-local] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd-local] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd-local] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd-local] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd-local] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd-local] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd-local] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd-local] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd-local] SET RECOVERY FULL 
GO
ALTER DATABASE [bd-local] SET  MULTI_USER 
GO
ALTER DATABASE [bd-local] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd-local] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd-local] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd-local] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd-local] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd-local] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bd-local', N'ON'
GO
ALTER DATABASE [bd-local] SET QUERY_STORE = OFF
GO
USE [bd-local]
GO
/****** Object:  Table [dbo].[tabla_stockBateria]    Script Date: 22/11/2021 16:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tabla_stockBateria](
	[codigo] [int] NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[esUsado] [bit] NOT NULL,
	[origen] [int] NOT NULL,
	[tipoInstrumento] [int] NOT NULL,
	[costo] [float] NOT NULL,
	[porcentajeGanancia] [int] NOT NULL,
	[cantidadDeCuerpos] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tabla_stockGuitarra]    Script Date: 22/11/2021 16:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tabla_stockGuitarra](
	[codigo] [int] NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[esUsado] [bit] NOT NULL,
	[origen] [int] NOT NULL,
	[tipoInstrumento] [int] NOT NULL,
	[costo] [float] NOT NULL,
	[porcentajeGanancia] [int] NOT NULL,
	[cantidadDeCuerdas] [int] NOT NULL,
	[tipo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tabla_stockTrompetaDos]    Script Date: 22/11/2021 16:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tabla_stockTrompetaDos](
	[codigo] [int] NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[esUsado] [bit] NULL,
	[origen] [int] NULL,
	[tipoInstrumento] [int] NULL,
	[costo] [float] NULL,
	[porcentajeGanancia] [int] NULL,
	[clave] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tabla_stockBateria] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerpos]) VALUES (2, N'Truth', N'Truth2021', 1, 0, 1, 1000, 10, 6)
INSERT [dbo].[tabla_stockBateria] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerpos]) VALUES (3, N'Mapex', N'Blade', 1, 3, 2, 750, 20, 4)
INSERT [dbo].[tabla_stockBateria] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerpos]) VALUES (4, N'Mapex', N'Fastback', 0, 2, 2, 650, 20, 4)
INSERT [dbo].[tabla_stockBateria] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerpos]) VALUES (1, N'Pearl', N'EXX705', 1, 0, 2, 1900, 10, 4)
GO
INSERT [dbo].[tabla_stockGuitarra] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerdas], [tipo]) VALUES (5, N'Fender', N'Telecaster', 0, 0, 0, 800, 10, 6, 1)
INSERT [dbo].[tabla_stockGuitarra] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerdas], [tipo]) VALUES (6, N'Fender', N'Jazzmaster', 1, 1, 0, 700, 10, 6, 1)
INSERT [dbo].[tabla_stockGuitarra] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerdas], [tipo]) VALUES (8, N'Gibson', N'Sheryl', 1, 0, 0, 800, 20, 6, 2)
INSERT [dbo].[tabla_stockGuitarra] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerdas], [tipo]) VALUES (9, N'Ibanez', N'SteveVai', 0, 3, 0, 1000, 15, 7, 0)
INSERT [dbo].[tabla_stockGuitarra] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [cantidadDeCuerdas], [tipo]) VALUES (7, N'Fender', N'Jaguar', 1, 1, 0, 900, 10, 6, 1)
GO
INSERT [dbo].[tabla_stockTrompetaDos] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [clave]) VALUES (10, N'Bach', N'bach', 1, 0, 1, 900, 20, N'LA')
INSERT [dbo].[tabla_stockTrompetaDos] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [clave]) VALUES (11, N'LEXINGTON', N'Knight', 0, 1, 1, 1000, 21, N'LA#')
INSERT [dbo].[tabla_stockTrompetaDos] ([codigo], [marca], [modelo], [esUsado], [origen], [tipoInstrumento], [costo], [porcentajeGanancia], [clave]) VALUES (12, N'Linconl', N'linconl2008', 1, 1, 1, 1000, 20, N'LA')
GO
USE [master]
GO
ALTER DATABASE [bd-local] SET  READ_WRITE 
GO
