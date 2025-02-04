CREATE TABLE [dbo].[ussSFProformaInvoiceLine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProformaInvoiceID] [int] NOT NULL,
	[JobLineID] [int] NOT NULL,
	[InventoryItemID] [int] NULL,
	[Quantity] [float] NULL,
	[UnitPriceBeforeDiscount] [float] NULL,
	[UnitPrice] [float] NULL,
	[LineDiscountPercent] [float] NULL,
	[TotalPrice] [float] NULL,
 CONSTRAINT [PK_ussSFProformaInvoiceLine] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]