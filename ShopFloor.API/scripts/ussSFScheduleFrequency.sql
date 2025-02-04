USE [MatolaCargoTerminal_Live New]
GO

/****** Object:  Table [dbo].[ussSFScheduleFrequency]    Script Date: 2021/06/25 02:28:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ussSFScheduleFrequency](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](20) NULL,
	[Description] [nvarchar](50) NULL,
	[TemplateID] [int] NULL,
	[RequestTypeID] [int] NULL,
	[ScheduleID] [int] NULL,
	[RepeatAfter] [int] NULL,
	[TypeID] [int] NULL
) ON [PRIMARY]
GO


