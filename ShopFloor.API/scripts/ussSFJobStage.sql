CREATE TABLE [dbo].[ussSFJobStage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[IsRequired] [bit] NULL,
	[IsActive] [bit] NULL,
	[IsProcurement] [bit] NULL,
	[Sequence] [int] NULL,
 CONSTRAINT [PK_ussSFJobStage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]