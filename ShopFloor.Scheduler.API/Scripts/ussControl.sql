CREATE TABLE [dbo].[ussControl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[AssemblyName] [varchar](255) NOT NULL,
	[TypeName] [varchar](255) NOT NULL,
	[DefaultLayoutID] [int] NULL,
 CONSTRAINT [PK_ussControl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]