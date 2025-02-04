CREATE TABLE [dbo].[ussSSMachineChecklistLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ChecklistID] [int] NULL,
	[ArtisanID] [int] NULL,
	[MachineID] [int] NULL,
	[Value] [nvarchar](50) NULL,
 CONSTRAINT [PK_ussSSMachineChecklistLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]





