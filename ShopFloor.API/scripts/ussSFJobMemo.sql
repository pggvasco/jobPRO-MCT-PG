CREATE TABLE [dbo].[ussSFJobMemo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobID] [int] NULL,
	[StageID] [int] NULL,
	[Memo] [varchar](max) NULL,
	[CreateUserID] [int] NULL,
	[CreateDate] [datetime] NULL,
	[EditUserID] [int] NULL,
	[EditDate] [datetime] NULL
) ON [PRIMARY]