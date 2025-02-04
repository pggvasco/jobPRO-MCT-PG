CREATE TABLE [dbo].[ussSSJob](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [varchar](20) NULL,
	[Description] [varchar](250) NULL,
	[JobDate] [date] NULL,
	[RequiredDeliveryDate] [date] NULL,
	[EstimatedDeliveryDate] [date] NULL,
	[OrderPrice] [float] NULL,
	[TotalCost] [float] NULL,
	[EstimatedStartDate] [datetime] NULL,
	[EstimatedEndDate] [datetime] NULL,
	[ActualStartDate] [datetime] NULL,
	[ActualEndDate] [datetime] NULL,
	[CustomerID] [int] NULL,
	[JobCardID] [int] NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]