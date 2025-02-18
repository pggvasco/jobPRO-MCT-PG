CREATE TABLE [dbo].[ussSFProformaInvoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JobID] [int] NOT NULL,
	[Version] [int] NULL,
	[CreatedUserName] [nvarchar](250) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ProformaInvoiceNumber] [nvarchar](250) NULL,
 CONSTRAINT [PK_ussSFProformaInvoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]