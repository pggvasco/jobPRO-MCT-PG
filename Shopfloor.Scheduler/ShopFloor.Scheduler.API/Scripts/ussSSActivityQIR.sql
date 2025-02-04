CREATE TABLE [dbo].[ussSSActivityQIR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReasonCodeID] [int] NULL,
	[LogDateTime] [datetime] NULL,
	[LogAgentID] [int] NULL,
	[LogAgentName] [varchar](50) NULL,
	[ActivityID] [int] NULL,
 CONSTRAINT [PK_ussSSQIR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


