CREATE TABLE [dbo].[ussSFJobStageFieldPrompt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobStageID] [int] NULL,
	[FieldName] [nvarchar](255) NULL,
	[IsRequired] [bit] NULL,
	[DefaultValue] [nvarchar](max) NULL,
	[RequiredValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_ussSFJobStageFieldPrompt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]