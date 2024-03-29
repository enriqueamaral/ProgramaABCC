USE [master]
GO
/****** Object:  Database [Ejercicio_Tecnico]    Script Date: 15/12/2023 10:01:59 a. m. ******/
CREATE DATABASE [Ejercicio_Tecnico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ejercicio_Tecnico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Ejercicio_Tecnico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ejercicio_Tecnico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Ejercicio_Tecnico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Ejercicio_Tecnico] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ejercicio_Tecnico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ejercicio_Tecnico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET  MULTI_USER 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ejercicio_Tecnico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ejercicio_Tecnico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Ejercicio_Tecnico] SET QUERY_STORE = ON
GO
ALTER DATABASE [Ejercicio_Tecnico] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Ejercicio_Tecnico]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 15/12/2023 10:01:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[Sku] [numeric](6, 0) NOT NULL,
	[Articulo] [nchar](15) NOT NULL,
	[Marca] [nchar](15) NOT NULL,
	[Modelo] [nchar](20) NOT NULL,
	[Departamento] [numeric](1, 0) NOT NULL,
	[Clase] [numeric](2, 0) NOT NULL,
	[Familia] [numeric](3, 0) NOT NULL,
	[FechaAlta] [date] NOT NULL,
	[Stock] [numeric](9, 0) NOT NULL,
	[Cantidad] [numeric](9, 0) NOT NULL,
	[Descontinuado] [numeric](1, 0) NOT NULL,
	[FechaBaja] [date] NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[Sku] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clases]    Script Date: 15/12/2023 10:01:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroClase] [numeric](2, 0) NOT NULL,
	[NombreClase] [varchar](50) NOT NULL,
	[NumeroDepartamento] [numeric](1, 0) NOT NULL,
 CONSTRAINT [PK_Clases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 15/12/2023 10:01:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroDepartamento] [numeric](1, 0) NOT NULL,
	[NombreDepartamento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familias]    Script Date: 15/12/2023 10:01:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroFamilia] [numeric](3, 0) NOT NULL,
	[NombreFamilia] [varchar](50) NOT NULL,
	[NumeroClase] [numeric](2, 0) NOT NULL,
	[NombreClase] [varchar](50) NULL,
 CONSTRAINT [PK_Familias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Alta]    Script Date: 15/12/2023 10:01:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Alta]

	@Sku numeric(6,0),
	@Articulo nchar(15),
	@Marca nchar(15),
	@Modelo nchar(20),
	@Departamento numeric(1,0),
	@Clase numeric(2,0),
	@Familia numeric(3,0),
	@Stock numeric(9,0),
	@Cantidad numeric(9,0)
	

as
begin

	insert into Articulos (Sku, Articulo, Marca, Modelo, Departamento, Clase, Familia, FechaAlta, Stock, Cantidad, Descontinuado, FechaBaja)
	values (@Sku, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, GETDATE(), @Stock, @Cantidad, 0, '1900-01-01')

end
GO
/****** Object:  StoredProcedure [dbo].[Baja]    Script Date: 15/12/2023 10:01:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Baja]

	@Sku numeric(6,0)
as
begin
	delete from Articulos where Sku =  @Sku
	
end;
GO
/****** Object:  StoredProcedure [dbo].[Cambio]    Script Date: 15/12/2023 10:01:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Cambio]
	@Sku numeric(6,0),
	@Articulo nchar(15),
	@Marca nchar(15),
	@Modelo nchar(20),
	@Departamento numeric(1,0),
	@Clase numeric(2,0),
	@Familia numeric(3,0),
	@Cantidad numeric(9,0),
	@Stock numeric(9,0),
	@Descontinuado numeric(1,0)

as
begin
	
	update Articulos
	set Articulo = @Articulo,
		Marca = @Marca,
		Modelo = @Modelo,
		Departamento = @Departamento,
		Clase = @Clase,
		Familia = @Familia,
		Cantidad = @Cantidad,
		Stock = @Stock,
		Descontinuado = @Descontinuado,
		FechaBaja = CASE WHEN @Descontinuado = 1 THEN GETDATE() ELSE '1900-01-01' END

	where Sku = @Sku
end;
GO
/****** Object:  StoredProcedure [dbo].[Consulta]    Script Date: 15/12/2023 10:01:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Consulta]

	@Sku numeric(6,0)
as
begin

	select * from Articulos where Sku = @Sku

end;
GO
USE [master]
GO
ALTER DATABASE [Ejercicio_Tecnico] SET  READ_WRITE 
GO
