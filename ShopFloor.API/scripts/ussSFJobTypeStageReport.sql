CREATE TABLE [dbo].[ussSFJobTypeStageReport](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobTypeStageID] [int] NULL,
	[ReportID] [int] NULL,
	[IsAutomatic] [bit] NULL,
 CONSTRAINT [PK_ussSFJobTypeStageReport] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]