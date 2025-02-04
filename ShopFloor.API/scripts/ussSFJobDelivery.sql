CREATE TABLE [dbo].[ussSFJobDelivery](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobID] [int] NULL,
	[DeliveryDate] [date] NULL,
	[DeliveryNumber] [varchar](20) NULL,
	[Quantity] [float] NULL,
	[AgentID] [int] NULL,
	[ResponsibleAgentID] [int] NULL,
	[Information1] [varchar](255) NULL,
	[Information2] [varchar](255) NULL,
	[Reason] [varchar](255) NULL,
 CONSTRAINT [PK_ussSFJobDelivery] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]