CREATE TABLE [dbo].[ussSFPaymentFrequency](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] nvarchar(255) NULL,
	[Description] nvarchar(255) NULL,
	[ERPPaymentFrequencyCode] Integer NULL
 CONSTRAINT [PK_ussSFPaymentFrequency] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]