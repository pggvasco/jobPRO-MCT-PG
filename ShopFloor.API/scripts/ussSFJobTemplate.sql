CREATE TABLE [dbo].[ussSFJobTemplate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TemplateNumber] [varchar](20) NULL,
	[ValidityDays] [smallint] NULL,
	[DeliveryDays] [smallint] NULL,
	[WorkCentreCategoryID] [int] NULL,
	[CategoryID] [int] NULL,
	[TypeID] [int] NULL,
	[DrawingID] [int] NULL,
	[MakeID] [int] NULL,
	[ModelID] [int] NULL,
	[FunctionID] [int] NULL,
	[GenerationID] [int] NULL,
	[CostCentreID] [int] NULL,
	[Description1] [varchar](255) NULL,
	[Description2] [varchar](255) NULL,
	[UnitCost] [float] NULL,
	[UnitPrice] [float] NULL,
 CONSTRAINT [PK_ussSFJobTemplate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]