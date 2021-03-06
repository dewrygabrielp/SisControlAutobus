USE [master]
GO
/****** Object:  Database [Control_autobuses]    Script Date: 15/8/2021 4:31:32 a. m. ******/
CREATE DATABASE [Control_autobuses]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Control_autobuses', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Control_autobuses.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Control_autobuses_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Control_autobuses_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Control_autobuses] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Control_autobuses].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Control_autobuses] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Control_autobuses] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Control_autobuses] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Control_autobuses] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Control_autobuses] SET ARITHABORT OFF 
GO
ALTER DATABASE [Control_autobuses] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Control_autobuses] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Control_autobuses] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Control_autobuses] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Control_autobuses] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Control_autobuses] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Control_autobuses] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Control_autobuses] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Control_autobuses] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Control_autobuses] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Control_autobuses] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Control_autobuses] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Control_autobuses] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Control_autobuses] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Control_autobuses] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Control_autobuses] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Control_autobuses] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Control_autobuses] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Control_autobuses] SET  MULTI_USER 
GO
ALTER DATABASE [Control_autobuses] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Control_autobuses] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Control_autobuses] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Control_autobuses] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Control_autobuses] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Control_autobuses] SET QUERY_STORE = OFF
GO
USE [Control_autobuses]
GO
/****** Object:  Table [dbo].[AUTOBUS]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUTOBUS](
	[IdAutobus] [int] IDENTITY(1,1) NOT NULL,
	[MARCA] [varchar](50) NOT NULL,
	[MODELO] [varchar](50) NOT NULL,
	[PLACA] [varchar](9) NOT NULL,
	[COLOR] [varchar](10) NOT NULL,
	[AÑO] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAutobus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHOFER]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHOFER](
	[IdChofer] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[APELLIDO] [varchar](50) NOT NULL,
	[FECHA_NACIMIENTO] [date] NOT NULL,
	[CEDULA] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdChofer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTUDIANTES]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTUDIANTES](
	[IdEstudiante] [int] IDENTITY(133,133) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[MATRICULA]  AS ('ITLA'+right('2015-32-'+CONVERT([varchar],[IdEstudiante]),(100))),
	[TICKET]  AS ('TICKET'+right('001-'+CONVERT([varchar],[IdEstudiante]),(100))),
	[TIEMPO_DE_LA_COMPRA] [varchar](100) NULL,
	[RUTA] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion](
	[IdInscripcion] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('N.Serial'+right('00DGPV000'+CONVERT([varchar],[IdInscripcion]),(50))),
	[IdChofer] [int] NULL,
	[IdBus] [int] NULL,
	[IdRuta] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RUTAS]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RUTAS](
	[IdRuta] [int] IDENTITY(1,1) NOT NULL,
	[RUTA] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRuta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AUTOBUS] ON 

INSERT [dbo].[AUTOBUS] ([IdAutobus], [MARCA], [MODELO], [PLACA], [COLOR], [AÑO]) VALUES (2, N'PUMA', N'FERRARY', N'I- 452226', N'AMARILLO', CAST(N'2021-08-15' AS Date))
INSERT [dbo].[AUTOBUS] ([IdAutobus], [MARCA], [MODELO], [PLACA], [COLOR], [AÑO]) VALUES (3, N'PORCHET', N'NICK', N'I- 784541', N'ROJO', CAST(N'2021-08-15' AS Date))
SET IDENTITY_INSERT [dbo].[AUTOBUS] OFF
SET IDENTITY_INSERT [dbo].[CHOFER] ON 

INSERT [dbo].[CHOFER] ([IdChofer], [NOMBRE], [APELLIDO], [FECHA_NACIMIENTO], [CEDULA]) VALUES (1, N'ANTONIA', N'PEREZ', CAST(N'1994-01-01' AS Date), N'40278655655')
INSERT [dbo].[CHOFER] ([IdChofer], [NOMBRE], [APELLIDO], [FECHA_NACIMIENTO], [CEDULA]) VALUES (2, N'DANILO', N'MEDINA', CAST(N'2021-08-15' AS Date), N'40214655665')
SET IDENTITY_INSERT [dbo].[CHOFER] OFF
SET IDENTITY_INSERT [dbo].[ESTUDIANTES] ON 

INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (29534, N'Esmerlin Borges Corporán', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (29667, N'Edward Alfonso De La Rosa Bodre', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (29800, N'Rafael Antonio Duarte Rosario', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (29933, N'Javier Garcia Luciano	', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (30066, N'Diego Manuel De La Cruz Alvarez	', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (30199, N' Gaddiel Leonardo Comas Santiago', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (30332, N'John BuretJohn Buret', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (30465, N'Victor Raymond Campusano', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (30598, N'Anthony Manuel Caceres Velez', N'17 horas 44 minutos', N'La Churchill')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (30731, N'Alejandro Martin Cabrera Castillo', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (30864, N' Erick De Jesús Brito', N'10 días 7 horas', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (30997, N'Esmerlin Borges Corporán', N'17 horas 44 minutos', N'La Churchill')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (31130, N'Edward Alfonso De La Rosa Bodre', N'17 horas 44 minutos', N'Sabana')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (31263, N'Rafael Antonio Duarte Rosario', N'17 horas 44 minutos', N'La Churchill')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (31396, N'Javier Garcia Luciano	', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (31529, N'Diego Manuel De La Cruz Alvarez	', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (31662, N' Gaddiel Leonardo Comas Santiago', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (31795, N'John BuretJohn Buret', N'17 horas 44 minutos', N'Puente Juan Carlo')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (31928, N'Victor Raymond Campusano', N'17 horas 44 minutos', N'Puente Juan Carlo')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (32061, N'Anthony Manuel Caceres Velez', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (32194, N'Alejandro Martin Cabrera Castillo', N'17 horas 44 minutos', N'Puente Juan Carlo')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (32327, N' Erick De Jesús Brito', N'10 días 7 horas', N'Sabana')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (32460, N'Esmerlin Borges Corporán', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (32593, N'Edward Alfonso De La Rosa Bodre', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (32726, N'Rafael Antonio Duarte Rosario', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (32859, N'Javier Garcia Luciano	', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (32992, N'Diego Manuel De La Cruz Alvarez	', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (33125, N' Gaddiel Leonardo Comas Santiago', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (33258, N'John BuretJohn Buret', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (33391, N'Victor Raymond Campusano', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (33524, N'Anthony Manuel Caceres Velez', N'17 horas 44 minutos', N'La Churchill')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (33657, N'Alejandro Martin Cabrera Castillo', N'17 horas 44 minutos', N'Villa Mella')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (33790, N' Erick De Jesús Brito', N'10 días 7 horas', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (33923, N'Esmerlin Borges Corporán', N'17 horas 44 minutos', N'La Churchill')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (34056, N'Edward Alfonso De La Rosa Bodre', N'17 horas 44 minutos', N'Sabana')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (34189, N'Rafael Antonio Duarte Rosario', N'17 horas 44 minutos', N'La Churchill')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (34322, N'Javier Garcia Luciano	', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (34455, N'Diego Manuel De La Cruz Alvarez	', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (34588, N' Gaddiel Leonardo Comas Santiago', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (34721, N'John BuretJohn Buret', N'17 horas 44 minutos', N'Puente Juan Carlo')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (34854, N'Victor Raymond Campusano', N'17 horas 44 minutos', N'Puente Juan Carlo')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (34987, N'Anthony Manuel Caceres Velez', N'17 horas 44 minutos', N'CHARLES')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (35120, N'Alejandro Martin Cabrera Castillo', N'17 horas 44 minutos', N'Puente Juan Carlo')
INSERT [dbo].[ESTUDIANTES] ([IdEstudiante], [NOMBRE], [TIEMPO_DE_LA_COMPRA], [RUTA]) VALUES (35253, N' Erick De Jesús Brito', N'10 días 7 horas', N'Sabana')
SET IDENTITY_INSERT [dbo].[ESTUDIANTES] OFF
SET IDENTITY_INSERT [dbo].[Inscripcion] ON 

INSERT [dbo].[Inscripcion] ([IdInscripcion], [IdChofer], [IdBus], [IdRuta]) VALUES (2, 1, 2, 2)
SET IDENTITY_INSERT [dbo].[Inscripcion] OFF
SET IDENTITY_INSERT [dbo].[RUTAS] ON 

INSERT [dbo].[RUTAS] ([IdRuta], [RUTA]) VALUES (1, N'VILLA MELLA')
INSERT [dbo].[RUTAS] ([IdRuta], [RUTA]) VALUES (2, N'SAN CARLOS')
INSERT [dbo].[RUTAS] ([IdRuta], [RUTA]) VALUES (3, N'SABANA')
INSERT [dbo].[RUTAS] ([IdRuta], [RUTA]) VALUES (4, N'CHARLES')
SET IDENTITY_INSERT [dbo].[RUTAS] OFF
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_AUTOBUS] FOREIGN KEY([IdBus])
REFERENCES [dbo].[AUTOBUS] ([IdAutobus])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_AUTOBUS]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH NOCHECK ADD  CONSTRAINT [FK_Inscripcion_CHOFER] FOREIGN KEY([IdChofer])
REFERENCES [dbo].[CHOFER] ([IdChofer])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_CHOFER]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH NOCHECK ADD  CONSTRAINT [FK_Inscripcion_RUTAS] FOREIGN KEY([IdRuta])
REFERENCES [dbo].[RUTAS] ([IdRuta])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_RUTAS]
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_inscripcion]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_buscar_inscripcion]
@textobuscar varchar(50)
as
select   UPPER(Codigo) AS "CÓDIGO SERIAL", CONCAT (APELLIDO,' ', NOMBRE) "NOMBRE COMPLETO",CEDULA AS CÉDULA, PLACA as "PLACA BUS", MODELO, RUTA "RUTAS ENCARGADAS"
FROM Inscripcion inner join CHOFER on Inscripcion.IdChofer = CHOFER.IdChofer inner join AUTOBUS ON AUTOBUS.IdAutobus = Inscripcion.IdBus inner join RUTAS ON RUTAS.IdRuta = Inscripcion.IdRuta

where APELLIDO like @textobuscar + '%'
ORDER BY APELLIDO ASC
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_rutas]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_buscar_rutas]

@textobuscar varchar(50)
as
select IdEstudiante as "ID Estudiantil", UPPER(NOMBRE) "NOMBRE DE ESTUDIANTE" , MATRICULA, TICKET, TIEMPO_DE_LA_COMPRA AS "TIEMPO DE LA COMPRA",  UPPER(RUTA) RUTA  from estudiantes
where ruta like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_bus]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--create proc editar

create proc [dbo].[sp_editar_bus]
@idautobus int,
@marca varchar(50),
@modelo varchar(50),
@placa varchar(9),
@color varchar(10),
@ano date
as
update autobus set marca=@marca,modelo=@modelo, placa=@placa, color=@color, año=@ano
where IdAutobus=@idautobus
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_chofer]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--creando proc editar

create proc [dbo].[sp_editar_chofer]
@idchofer int,
@nombre varchar(50),
@apellido varchar(50),
@fecha_nac date,
@cedula varchar(15)
as
update  CHOFER set NOMBRE=@nombre,APELLIDO=@apellido,FECHA_NACIMIENTO=@fecha_nac,CEDULA=@cedula
where IdChofer=@idchofer
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_inscripcion]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_editar_inscripcion]
@idinscripcion int,
@idcodigo varchar(50),
@idchofer int,
@idbus int,
@idruta int
as
update Inscripcion set IdChofer=@idchofer, IdBus=@idbus, IdRuta=@idruta
where IdInscripcion=@idinscripcion or Codigo=@idcodigo
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_ruta]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_editar_ruta]
@idruta int,
@ruta varchar(max)
as
update RUTAS set Ruta=@ruta
where IdRuta=@idruta
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_bus]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- create proc eliminar
create proc [dbo].[sp_eliminar_bus]
@idautobus int
as
delete from autobus
where IdAutobus=@idautobus
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_chofer]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--procedimiento eliminar

create proc [dbo].[sp_eliminar_chofer]
@idchofer int
as
delete from CHOFER
where IdChofer=@idchofer
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_estudiantes]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_estudiantes]
as
delete from estudiantes
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_inscripcion]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_inscripcion]
@idinscripcion int 
as
delete from Inscripcion
where IdInscripcion=@idinscripcion
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_ruta]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_eliminar_ruta]
@idruta int
as
delete from rutas
where IdRuta=@idruta
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_bus]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertar_bus]
@idautobus int output,
@marca varchar(50),
@modelo varchar(50),
@placa varchar(9),
@color varchar(10),
@ano date
as
if exists (select * from AUTOBUS where @placa=PLACA)
begin
print 'La placa del autobus ya fue registrada'
return
end

begin
insert into autobus (marca,modelo,placa,color,año) values (@marca,@modelo,@placa,@color,@ano)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_chofer]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertar_chofer]
@idchofer int output,
@nombre varchar(50),
@apellido varchar(50),
@fecha_nac date,
@cedula varchar(15)
as

if exists (select * from CHOFER where @cedula=CEDULA)
BEGIN
PRINT 'El Doc. de Identidad ya ha sido registrado'
return 
end

begin 
insert into CHOFER(NOMBRE,APELLIDO,FECHA_NACIMIENTO,CEDULA) values(@nombre,@apellido,@fecha_nac,@cedula)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_estudiantes]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_estudiantes]
as

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Esmerlin Borges Corporán','17 horas 44 minutos', 'CHARLES');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Edward Alfonso De La Rosa Bodre','17 horas 44 minutos', 'Villa Mella');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Rafael Antonio Duarte Rosario','17 horas 44 minutos', 'Villa Mella');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Javier Garcia Luciano	','17 horas 44 minutos', 'Villa Mella');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Diego Manuel De La Cruz Alvarez	','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES (' Gaddiel Leonardo Comas Santiago','17 horas 44 minutos', 'Villa Mella');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('John BuretJohn Buret','17 horas 44 minutos', 'Villa Mella');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Victor Raymond Campusano','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Anthony Manuel Caceres Velez','17 horas 44 minutos', 'La Churchill');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Alejandro Martin Cabrera Castillo','17 horas 44 minutos', 'Villa Mella');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES (' Erick De Jesús Brito','10 días 7 horas', 'CHARLES');


insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Esmerlin Borges Corporán','17 horas 44 minutos', 'La Churchill');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Edward Alfonso De La Rosa Bodre','17 horas 44 minutos', 'Sabana');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Rafael Antonio Duarte Rosario','17 horas 44 minutos', 'La Churchill');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Javier Garcia Luciano	','17 horas 44 minutos', 'CHARLES');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Diego Manuel De La Cruz Alvarez	','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES (' Gaddiel Leonardo Comas Santiago','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('John BuretJohn Buret','17 horas 44 minutos', 'Puente Juan Carlo');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Victor Raymond Campusano','17 horas 44 minutos', 'Puente Juan Carlo');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Anthony Manuel Caceres Velez','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Alejandro Martin Cabrera Castillo','17 horas 44 minutos', 'Puente Juan Carlo');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES (' Erick De Jesús Brito','10 días 7 horas', 'Sabana');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Esmerlin Borges Corporán','17 horas 44 minutos', 'CHARLES');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Edward Alfonso De La Rosa Bodre','17 horas 44 minutos', 'Villa Mella');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Rafael Antonio Duarte Rosario','17 horas 44 minutos', 'Villa Mella');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Javier Garcia Luciano	','17 horas 44 minutos', 'Villa Mella');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Diego Manuel De La Cruz Alvarez	','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES (' Gaddiel Leonardo Comas Santiago','17 horas 44 minutos', 'Villa Mella');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('John BuretJohn Buret','17 horas 44 minutos', 'Villa Mella');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Victor Raymond Campusano','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Anthony Manuel Caceres Velez','17 horas 44 minutos', 'La Churchill');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Alejandro Martin Cabrera Castillo','17 horas 44 minutos', 'Villa Mella');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES (' Erick De Jesús Brito','10 días 7 horas', 'CHARLES');


insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Esmerlin Borges Corporán','17 horas 44 minutos', 'La Churchill');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Edward Alfonso De La Rosa Bodre','17 horas 44 minutos', 'Sabana');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Rafael Antonio Duarte Rosario','17 horas 44 minutos', 'La Churchill');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Javier Garcia Luciano	','17 horas 44 minutos', 'CHARLES');

insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Diego Manuel De La Cruz Alvarez	','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES (' Gaddiel Leonardo Comas Santiago','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('John BuretJohn Buret','17 horas 44 minutos', 'Puente Juan Carlo');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Victor Raymond Campusano','17 horas 44 minutos', 'Puente Juan Carlo');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Anthony Manuel Caceres Velez','17 horas 44 minutos', 'CHARLES');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES ('Alejandro Martin Cabrera Castillo','17 horas 44 minutos', 'Puente Juan Carlo');
insert into ESTUDIANTES (NOMBRE,TIEMPO_DE_LA_COMPRA,RUTA)
VALUES (' Erick De Jesús Brito','10 días 7 horas', 'Sabana');  
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_inscripcion]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertar_inscripcion]
@idchofer int,
@idbus int,
@idruta int
as

if exists (select * from Inscripcion where @idchofer=IdChofer or @idbus=IdBus or @idruta=IdRuta)
begin
print 'Revise que el conductor  esté inactivo o autobus esté en desuso'
return
end

begin 
insert into Inscripcion  values (@idchofer,@idbus,@idruta)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_ruta]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertar_ruta]
@idruta int output,
@ruta varchar(max)
as

if exists (select * from RUTAS where @ruta=RUTA)

begin
print 'La ruta ya ha sido registrada en la base de datos'
return 
end

begin
insert into rutas (RUTA) values (@ruta)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_autobus]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_autobus]
as
select IdAutobus,MARCA, MODELO , PLACA , COLOR,YEAR(AÑO)AÑO from autobus
order by IdAutobus desc
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_chofer]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_chofer]
 as
 select IdChofer, NOMBRE, APELLIDO, FECHA_NACIMIENTO AS "FECHA DE NACIMIENTO", CEDULA as "CÉDULA / DNI" from CHOFER ORDER BY IdChofer desc
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_estudiantes]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_estudiantes]
as
select IdEstudiante as "ID Estudiantil", UPPER(NOMBRE) "NOMBRE DE ESTUDIANTE" , MATRICULA, TICKET, TIEMPO_DE_LA_COMPRA AS "TIEMPO DE LA COMPRA",  UPPER(RUTA) RUTA  from estudiantes
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_inscripcion]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_inscripcion]
as

select  IdInscripcion, UPPER(Codigo) AS "CÓDIGO SERIAL", CONCAT (APELLIDO,' ', NOMBRE) "NOMBRE COMPLETO",CEDULA AS CÉDULA, PLACA as "PLACA BUS", MODELO, RUTA "RUTAS ENCARGADAS"
FROM Inscripcion inner join CHOFER on Inscripcion.IdChofer = CHOFER.IdChofer inner join AUTOBUS ON AUTOBUS.IdAutobus = Inscripcion.IdBus inner join RUTAS ON RUTAS.IdRuta = Inscripcion.IdRuta
ORDER BY CODIGO ASC;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_rutas]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_rutas]
as
select IdRuta, RUTA AS RECORRIDO from RUTAS
order by RUTA desc
GO
/****** Object:  StoredProcedure [dbo].[sp_reiniciar_bd]    Script Date: 15/8/2021 4:31:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE proc [dbo].[sp_reiniciar_bd]
	     as

 /*ALTER TABLE Inscripcion NOCHECK CONSTRAINT ALL;
 ALTER TABLE CHOFER NOCHECK CONSTRAINT ALL;
 ALTER TABLE RUTAS NOCHECK CONSTRAINT ALL;
 ALTER TABLE AUTOBUS NOCHECK CONSTRAINT ALL;*/

	delete from  RUTAS;
	delete from CHOFER;
	delete from AUTOBUS;
	delete from Inscripcion;

 /*ALTER TABLE  Inscripcion CHECK CONSTRAINT ALL;
 ALTER TABLE CHOFER CHECK CONSTRAINT ALL;
 ALTER TABLE RUTAS CHECK CONSTRAINT ALL;
 ALTER TABLE AUTOBUS CHECK CONSTRAINT ALL;*/

DBCC CHECKIDENT ([Inscripcion], RESEED,0);
DBCC CHECKIDENT ([CHOFER], RESEED,0);
DBCC CHECKIDENT ([RUTAS], RESEED,0);
DBCC CHECKIDENT ([AUTOBUS], RESEED,0);
GO
USE [master]
GO
ALTER DATABASE [Control_autobuses] SET  READ_WRITE 
GO
