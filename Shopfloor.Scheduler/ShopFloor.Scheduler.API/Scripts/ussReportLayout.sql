CREATE TABLE [dbo].[ussReportLayout](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ReportID] [int] NOT NULL,
	[LayoutName] [varchar](255) NOT NULL,
	[Layout] [varchar](max) NULL,
 CONSTRAINT [PK_ussReportLayout] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


