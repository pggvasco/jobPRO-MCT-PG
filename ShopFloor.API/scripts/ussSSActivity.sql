CREATE TABLE [dbo].[ussSSActivity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](255) NULL,
	[Comments] [varchar](255) NULL,
	[EstimatedStartDate] [datetime] NULL,
	[EstimatedDuration] [float] NULL,
	[EstimatedElapsedDuration] [float] NULL,
	[ActualStartDate] [datetime] NULL,
	[ActualDuration] [float] NULL,
	[ActualElapsedDuration] [float] NULL,
	[ArtisanID] [int] NULL,
	[OperationID] [int] NULL,
	[MachineID] [int] NULL,
	[PartID] [int] NULL,
	[JobID] [int] NULL,
	[Sequence] [int] NULL,
	[EstimatedArtisanCost] [float] NULL,
	[EstimatedMachineCost] [float] NULL,
	[EstimatedOperationCost] [float] NULL,
	[ActualArtisanCost] [float] NULL,
	[ActualMachineCost] [float] NULL,
	[ActualOperationCost] [float] NULL,
	[IsActualsPosted] [bit] NULL,
	[IsNextActivity] [bit] NULL,
 CONSTRAINT [PK_Activity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]