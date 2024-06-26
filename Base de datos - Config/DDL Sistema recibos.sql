USE [master]
GO
/****** Object:  Database [db_sistema_recibos]    Script Date: 29/02/2024 21:32:43 ******/
CREATE DATABASE [db_sistema_recibos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_sistema_recibos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_sistema_recibos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_sistema_recibos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_sistema_recibos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_sistema_recibos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_sistema_recibos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_sistema_recibos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_sistema_recibos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_sistema_recibos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_sistema_recibos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_sistema_recibos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_sistema_recibos] SET  MULTI_USER 
GO
ALTER DATABASE [db_sistema_recibos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_sistema_recibos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_sistema_recibos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_sistema_recibos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_sistema_recibos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_sistema_recibos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_sistema_recibos] SET QUERY_STORE = OFF
GO
USE [db_sistema_recibos]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 29/02/2024 21:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[localidad] [varchar](100) NULL,
	[direccion] [varchar](100) NULL,
	[cod_postal] [varchar](100) NULL,
	[telefono] [varchar](100) NULL,
	[cuit] [varchar](100) NULL,
	[categoria] [varchar](100) NULL,
	[provincia] [varchar](100) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[recibos]    Script Date: 29/02/2024 21:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[recibos](
	[id_recibo] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[importe] [real] NOT NULL,
	[mes_comprobante] [int] NOT NULL,
	[anio_comprobante] [int] NOT NULL,
	[fecha_emision_comprobante] [datetime] NOT NULL,
	[nro_comprobante] [int] NOT NULL,
 CONSTRAINT [PK__Recibos__1F2CC1BAEF6D9E0E] PRIMARY KEY CLUSTERED 
(
	[id_recibo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sistema]    Script Date: 29/02/2024 21:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sistema](
	[id_sistema] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[contador] [int] NULL,
 CONSTRAINT [PK__sistema__A0747B268D682556] PRIMARY KEY CLUSTERED 
(
	[id_sistema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[recibos] ADD  CONSTRAINT [DF__Recibos__fecha_e__267ABA7A]  DEFAULT (getdate()) FOR [fecha_emision_comprobante]
GO
ALTER TABLE [dbo].[recibos]  WITH CHECK ADD  CONSTRAINT [FK__Recibos__nro_com__276EDEB3] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[recibos] CHECK CONSTRAINT [FK__Recibos__nro_com__276EDEB3]
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarUltimoRecibo]    Script Date: 29/02/2024 21:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BuscarUltimoRecibo]
AS
	DECLARE @id int;

	SET @id = @@IDENTITY

	SELECT * FROM db_sistema_recibos.dbo.recibos r INNER JOIN clientes c ON r.id_cliente = c.id_cliente WHERE id_recibo = @id;
GO
/****** Object:  StoredProcedure [dbo].[sp_CrearReciboNuevo]    Script Date: 29/02/2024 21:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CrearReciboNuevo]
	@id_cliente int, @desc varchar(100), @importe real, @mes int, @anio int
AS
	BEGIN;

		DECLARE @contador int;

		SELECT @contador = contador FROM sistema WHERE id_sistema = 1;

		INSERT INTO recibos(id_cliente, descripcion, importe, mes_comprobante, anio_comprobante, nro_comprobante)
		VALUES (@id_cliente, @desc, @importe, @mes, @anio, @contador);

		UPDATE sistema SET contador = contador + 1 WHERE id_sistema = 1;
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_RecibosPorMesYAnio]    Script Date: 29/02/2024 21:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RecibosPorMesYAnio]
@mes int, @anio int
AS
	SELECT r.id_recibo, r.id_cliente, c.nombre, c.cuit, c.categoria, r.nro_comprobante, r.fecha_emision_comprobante, r.descripcion, r.importe FROM recibos r
	INNER JOIN clientes c
		ON c.id_cliente = r.id_cliente
	WHERE r.mes_comprobante = @mes AND r.anio_comprobante = @anio
GO
USE [master]
GO
ALTER DATABASE [db_sistema_recibos] SET  READ_WRITE 
GO
