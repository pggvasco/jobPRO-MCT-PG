CREATE TABLE [dbo].[ussSFJobTemplateLine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Description1] [varchar](255) NULL,
	[Description2] [varchar](255) NULL,
	[QuoteDescription] [varchar](255) NULL,
	[Criteria] [varchar](255) NULL,
	[JobTemplateID] [int] NULL,
	[PartID] [int] NULL,
	[SupplyScopeID] [int] NULL,
	[WorkCentreCategoryID] [int] NULL,
	[WorkCentreID] [int] NULL,
	[InventoryItemID] [int] NULL,
	[SupplierTypeID] [int] NULL,
	[Quantity] [float] NULL,
	[EstimatedDuration] [float] NULL,
	[MarkupPercent] [float] NULL,
	[UnitCost] [float] NULL,
	[TotalCost] [float] NULL,
	[UnitPrice] [float] NULL,
	[UnitPriceBeforeMarkup] [float] NULL,
	[TotalPrice] [float] NULL,
	[Measurement1] [float] NULL,
	[Measurement2] [float] NULL,
	[Measurement3] [float] NULL,
	[LineNumber] [int] NULL,
 CONSTRAINT [PK_ussSFJobTemplateLine] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]