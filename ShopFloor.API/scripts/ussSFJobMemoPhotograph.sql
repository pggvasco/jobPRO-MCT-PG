CREATE TABLE [dbo].[ussSFJobMemoPhotograph](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobMemoId] [int] NULL,
	[Photo] [varbinary](max) NULL
) ON [PRIMARY]