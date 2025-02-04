CREATE TABLE [dbo].[ussSFPart](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Description] [varchar](255) NULL,
	[TransactionTypeID] [int] NULL,
	[PartGroupID] [int] NULL,
	[SupplyScopeID] [int] NULL,
	[Criteria] [varchar](255) NULL,
	[Colour] [varchar](50) NULL,
	[Image] [image] NULL,
 CONSTRAINT [PK_ussSFPart] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]