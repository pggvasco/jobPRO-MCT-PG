CREATE TABLE [dbo].[ussSSActivityLog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ActivityID] [int] NULL,
	[ArtisanID] [int] NULL,
	[MachineID] [int] NULL,
	[StartDate] [datetime] NULL,
	[Duration] [float] NULL,
	[CurrentState] [int] NULL,
	[ArtisanCost] [float] NULL,
	[MachineCost] [float] NULL,
	[OperationCost] [float] NULL,
	[LogTime] [datetime] NULL,
 CONSTRAINT [PK_ActivityLog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]