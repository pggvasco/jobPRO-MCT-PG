CREATE TABLE [dbo].[ussSSOperation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Description] [varchar](250) NULL,
	[Rate] [float] NULL,
	[IsBuyOut] [bit] NULL,
	[CostCentreID] [int] NULL,
	[ChecklistID] [int] NULL,
	[ServiceCode] [nvarchar](50) NULL,
	[IsPrimary] [bit] NULL,
 CONSTRAINT [PK_Operation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


