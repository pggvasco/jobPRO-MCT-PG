CREATE TABLE [dbo].[ussSFJobType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
	[Code] [varchar](255) NULL,
	[IsInspectionRequired] [bit] NULL,
	[RevenueServiceCode] [varchar](50) NULL,
	[CostCentreID] [int] NULL,
 CONSTRAINT [PK_ussSFJobType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]