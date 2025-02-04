CREATE TABLE [dbo].[ussSFJobSupplierDeliveryNote](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobID] [int] NULL,
	[DeliveryDate] [date] NULL,
	[DeliveryNumber] [varchar](20) NULL,
	[Quantity] [float] NULL,
	[AgentID] [int] NULL,
	[ResponsibleAgentID] [int] NULL,
	[SpecialInstruction1] [nvarchar](255) NULL,
	[SpecialInstruction2] [nvarchar](255) NULL,
	[Attention] [varchar](255) NULL,
	[SupplierID] [int] NOT NULL,
 CONSTRAINT [PK_ussSFJobSupplierDelivery] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



