USE [MatolaCargoTerminal_Live New]
GO

/****** Object:  Table [dbo].[ussSFAssetSchedule]    Script Date: 2021/06/25 02:26:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ussSFAssetSchedule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AssetID] [int] NULL,
	[Sequence] [int] NULL,
	[ScheduleID] [int] NULL
) ON [PRIMARY]
GO


