
CREATE TABLE [dbo].[ussChecklistTaskLog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ChecklistID] [int] NULL,
	[ChecklistLogID] [int] NULL,
	[ChecklistTaskID] [int] NULL,
	[LogDateTime] [datetime] NULL,
	[Document] [nvarchar](50) NULL,
	[Value] [nvarchar](MAX) NULL,
 CONSTRAINT [PK_ussChecklistTaskLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



