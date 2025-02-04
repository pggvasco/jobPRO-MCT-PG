CREATE TABLE [dbo].[ussSSArtisan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Description] [varchar](250) NULL,
	[Colour] [varchar](50) NULL,
	[Image] [image] NULL,
	[Rate] [float] NULL,
	[CostCentreID] [int] NULL,
	[CalendarID] [int] NULL,
	[ServiceCode] [nvarchar](50) NULL,
	[IsPrimary] [bit] NULL,
 CONSTRAINT [PK_Artisan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]