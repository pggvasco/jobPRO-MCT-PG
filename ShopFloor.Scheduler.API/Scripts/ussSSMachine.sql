CREATE TABLE [dbo].[ussSSMachine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Description] [varchar](250) NULL,
	[Colour] [varchar](50) NULL,
	[Image] [image] NULL,
	[Rate] [float] NULL,
	[CostCentreID] [int] NULL,
	[ChecklistID] [int] NULL,
	[CalendarID] [int] NULL,
	[ServiceCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_Machine] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

