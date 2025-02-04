CREATE TABLE [dbo].[ussSFPurchaseOrderLine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderID] [int] NULL,
	[JobLineID] [int] NULL,
	[InventoryItemID] [int] NULL,
	[ERPPurchaseOrderLineID] [int] NULL,
	[Quantity] [float] NULL,
	[UnitPrice] [float] NULL,
	[TotalPrice] [float] NULL,
	[LineNote] [nvarchar](1024) NULL,
 CONSTRAINT [PK_ussSFPurchaseOrderLine] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]