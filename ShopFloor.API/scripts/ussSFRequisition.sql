CREATE TABLE [dbo].[ussSFRequisition](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ERPRequisitionID] [int] NULL,
	[Number] [nvarchar](20) NULL,
	[Date] [datetime] NULL,
	[AgentID] [int] NULL,
	[AgentName] [nvarchar](50) NULL,
	[JobID] [int] NULL,
	[WorkCentreID] [int] NULL,
	[WorkCentreCategoryID] [int] NULL,
	[PartID] [int] NULL,
	[PartGroupID] [int] NULL,
	[SupplyScopeID] [int] NULL,
 CONSTRAINT [PK_ussSFRequisition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]