CREATE TABLE [dbo].[ussSFDrawing](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[Drawing] [varbinary](max) NULL,
	[DrawingPath] [nvarchar](500) NULL,
 CONSTRAINT [PK_ussSFDrawing] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]




