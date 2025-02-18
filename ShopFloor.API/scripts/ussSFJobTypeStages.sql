CREATE TABLE [dbo].[ussSFJobTypeStages](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobTypeID] [int] NULL,
	[JobStageID] [int] NULL,
 CONSTRAINT [PK_ussSFJobTypeStages] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]