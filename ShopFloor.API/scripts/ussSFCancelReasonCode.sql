CREATE TABLE [dbo].[ussSFCancelReasonCode](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] nvarchar(max) NULL,
	[Description] nvarchar(max) NULL,
	[IsCommentAllowed] bit NULL,
	[IsForceCommentValue] bit NULL,
 CONSTRAINT [PK_ussSFCancelReasonCode] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]