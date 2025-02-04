CREATE TABLE [dbo].[ussSFPurchaseOrder](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [nvarchar](20) NULL,
	[GRVNumber] [nvarchar](20) NULL,
	[OrderDate] [datetime] NULL,
	[RequiredDate] [datetime] NULL,
	[GRVDate] [datetime] NULL,
	[SupplierID] [int] NULL,
	[AgentID] [int] NULL,
	[AgentName] [nvarchar](50) NULL,
	[ERPPurchaseOrderID] [int] NULL,
	[JobID] [int] NULL,
	[WorkCentreID] [int] NULL,
	[WorkCentreCategoryID] [int] NULL,
	[PartID] [int] NULL,
	[PartGroupID] [int] NULL,
	[SupplyScopeID] [int] NULL,
 CONSTRAINT [PK_ussSFPurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]