CREATE TABLE [dbo].[ussSFJobNote](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StageID] [int] NULL,
	[JobID] [int] NULL,
	[Note] [varchar](max) NULL,
	[CreateUserID] [int] NULL,
	[CreateDate] [datetime] NULL,
	[EditUserID] [int] NULL,
	[EditUserDate] [datetime] NULL
) ON [PRIMARY]