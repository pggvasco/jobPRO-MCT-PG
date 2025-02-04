CREATE TABLE [dbo].[ussSSMachineChecklist](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sequence] [int] NULL,
	[Description] [nvarchar](50) NULL,
	[DataTypeID] [int] NULL,
	[IsForceValue] [bit] NULL,
	[MachineId] [int] NULL,
	[LookupId] [int] NULL,
 CONSTRAINT [PK_ussSSMachineChecklist] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


