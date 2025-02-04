
CREATE TABLE [dbo].[ussChecklistLog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ChecklistID] [int] NULL,
	[AgentID] [int] NULL,
	[RecordID] [int] NULL,
	[AgentName] [nvarchar](50) NULL,
	[StartDateTime] [datetime] NULL,
	[EndDateTime] [datetime] NULL,
 CONSTRAINT [PK_ussChecklistLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



