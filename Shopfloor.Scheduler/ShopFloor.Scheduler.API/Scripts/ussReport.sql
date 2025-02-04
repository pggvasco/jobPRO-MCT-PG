CREATE TABLE [dbo].[ussReport](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ReportName] [varchar](255) NOT NULL,
	[AssemblyName] [varchar](255) NOT NULL,
	[ReportTypeName] [varchar](255) NOT NULL,
	[DataSourceAssemblyName] [varchar](255) NULL,
	[DataSourceTypeName] [varchar](255) NULL,
	[DataSourceDisplayMember] [varchar](255) NULL,
	[DataSourceDisplayColumns] [varchar](255) NULL,
	[DefaultLayout] [int] NULL,
 CONSTRAINT [PK_ussReport] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]




