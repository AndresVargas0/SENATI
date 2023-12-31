USE [BD]
GO
/****** Object:  Table [dbo].[Estudiantes_Matriculados]    Script Date: 19/09/2023 18:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes_Matriculados](
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Apoderado] [nvarchar](50) NOT NULL,
	[DNI] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Grado] [nvarchar](50) NOT NULL,
	[Seccion] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
