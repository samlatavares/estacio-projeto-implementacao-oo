USE [TRABPROJIMPLOO]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/02/2019 18:58:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Senha] [varchar](10) NOT NULL,
	[Endereco] [varchar](200) NULL,
	[Documento] [varchar](50) NULL,
	[Nome] [varchar](100) NULL,
	[RazaoSocial] [varchar](100) NULL,
	[DataNascimento] [datetime] NULL,
	[Tipo] [nchar](1) NULL,
 CONSTRAINT [PK_Id_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
