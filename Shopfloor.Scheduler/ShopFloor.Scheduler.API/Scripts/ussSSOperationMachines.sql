CREATE TABLE [dbo].[ussSSOperationMachines](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OperationID] [int] NULL,
	[MachineID] [int] NULL,
 CONSTRAINT [PK_OperationMachines] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]




