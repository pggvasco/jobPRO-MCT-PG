CREATE TABLE [dbo].[ussSFTestBenchResultChart](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JOB_NO] [nvarchar](40) NOT NULL,
	[DBPIC] [image] NULL,
	[SEC_PORT] [nvarchar](5) NULL,
	[REVISION] [nvarchar](5) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



