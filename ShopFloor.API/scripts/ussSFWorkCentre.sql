CREATE TABLE [dbo].[ussSFWorkCentre](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](20) NULL,
	[Description] [varchar](50) NULL,
	[CalculationTypeID] [int] NULL,
	[CategoryID] [int] NULL,
	[CostCentreID] [int] NULL,
	[IsBuyOut] [bit] NULL,
	[HourlyRate] [float] NULL,
	[Factor] [float] NOT NULL,
	[Formula] [varchar](255) NULL,
	[RecoveryServiceCode] [varchar](50) NULL,
	[IsPrimary] [bit] NULL,
 CONSTRAINT [PK_ussSFWorkCentre] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]