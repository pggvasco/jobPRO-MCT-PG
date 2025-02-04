CREATE TABLE [dbo].[ussSFWorkCentreCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](20) NULL,
	[Description] [varchar](50) NULL,
	[RecoveryServiceCode] [varchar](50) NULL,
 CONSTRAINT [PK_ussSFWorkCentreCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]