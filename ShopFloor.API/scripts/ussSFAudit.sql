CREATE TABLE [dbo].[ussSFAudit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[idJob] [int] NULL,
	[idAgents] [int] NULL,
	[idJobLine] [int] NULL,
	[Description] [text] NULL,
	[Type] [varchar](max) NULL,
	[OldValue] [varchar](max) NULL,
	[NewValue] [varchar](max) NULL,
 CONSTRAINT [PK_ussSFAudit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


