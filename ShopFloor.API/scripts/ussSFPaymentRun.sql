CREATE TABLE [dbo].[ussSFPaymentRun](
	[id] [int] IDENTITY(1,1) NOT NULL,
	PaymentRunTypeID Integer Null,
	[StartDate] datetime NULL,
	[EndDate] datetime NULL,
	[PaymentDate] datetime NULL
 CONSTRAINT [PK_ussSFPaymentRun] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]