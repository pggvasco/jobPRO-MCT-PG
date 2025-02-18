CREATE TABLE [dbo].[ussSFJobStageReport](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobStageID] [int] NULL,
	[ReportID] [int] NULL,
	[IsAutomatic] [bit] NOT NULL,
 CONSTRAINT [PK_ussSFJobStageReport] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]