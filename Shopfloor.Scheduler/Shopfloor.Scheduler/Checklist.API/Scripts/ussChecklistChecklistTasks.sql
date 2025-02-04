CREATE TABLE [dbo].[ussChecklistChecklistTasks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ChecklistID] [int] NULL,
	[ChecklistTaskID] [int] NULL,
	[Sequence] [int] NULL,
 CONSTRAINT [PK_ussChecklistTasks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

