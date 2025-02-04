CREATE TABLE [dbo].[ussSFRequisitionLine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RequisitionID] [int] NULL,
	[ERPRequisitionLineID] [int] NULL,
	[JobLineID] [int] NULL,
	[InventoryItemID] [int] NULL,
	[Quantity] [float] NULL,
	[UnitCost] [float] NULL,
	[TotalCost] [float] NULL,
	[LineNote] [nvarchar](1024) NULL,
 CONSTRAINT [PK_ussSFRequisitionLine] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]