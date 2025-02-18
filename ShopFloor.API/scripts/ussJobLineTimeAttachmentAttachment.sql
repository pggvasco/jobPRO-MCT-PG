CREATE TABLE [dbo].[ussSFJobLineTimeAttachment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobLineTimeID] [int] NULL,
	[Name] [varchar](255) NULL,
	[Description] [varchar](255) NULL,
	[Attachment] [varbinary](max) NULL,
 CONSTRAINT [PK_ussSFJobLineTimeAttachmentAttachment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]