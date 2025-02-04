CREATE TABLE [dbo].[ussChecklistTask](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[LongDescription] [nvarchar](255) NULL,
	[Document] [nvarchar](50) NULL,
	[LookupID] [int] NULL,
	[IsForceValue] [bit] NULL,
	[DefaultValue] [nvarchar](50) NULL,
 CONSTRAINT [PK_ussChecklistType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



