USE [MatolaCargoTerminal_Live New]
GO

/****** Object:  Table [dbo].[ussSFRequestType]    Script Date: 2021/06/25 02:27:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ussSFRequestType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](20) NULL,
	[Description] [nvarchar](50) NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO


