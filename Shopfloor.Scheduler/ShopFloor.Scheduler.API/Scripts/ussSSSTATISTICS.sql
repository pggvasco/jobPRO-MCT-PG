CREATE STATISTICS S_ussSSActivityPartIDArtisanIDOperationIDMachineID ON [dbo].[ussSSActivity]([PartID], [ArtisanID], [OperationID], [MachineID])
CREATE STATISTICS S_ussSSActivityMachineIDArtisanIDCurrentStateIDJobIDOperationIDPartID ON [dbo].[ussSSActivity]([MachineID], [ArtisanID], [CurrentStateID], [JobID], [OperationID], [PartID])
CREATE STATISTICS S_ussSSActivityMachineIDArtisanIDPartID ON [dbo].[ussSSActivity]([MachineID], [ArtisanID], [PartID])
CREATE STATISTICS S_ussSSActivityPartIDOperationIDMachineIDJobID ON [dbo].[ussSSActivity]([PartID], [OperationID], [MachineID], [JobID])
CREATE STATISTICS S_ussSSActivityCurrentStateIDJobID ON [dbo].[ussSSActivity]([CurrentStateID], [JobID])
CREATE STATISTICS S_ussSSActivityJobIDMachineIDArtisanIDOperationID ON [dbo].[ussSSActivity]([JobID], [MachineID], [ArtisanID], [OperationID])
CREATE STATISTICS S_ussSSActivityJobIDArtisanIDCurrentStateID ON [dbo].[ussSSActivity]([JobID], [ArtisanID], [CurrentStateID])
CREATE STATISTICS S_ussSSActivityArtisanIDJobIDPartIDOperationIDMachineID ON [dbo].[ussSSActivity]([ArtisanID], [JobID], [PartID], [OperationID], [MachineID])
CREATE STATISTICS S_ussSSActivityArtisanIDIsNextActivity ON [dbo].[ussSSActivity]([ArtisanID], [IsNextActivity])
CREATE STATISTICS S_ussSSActivityOperationIDJobIDArtisanID ON [dbo].[ussSSActivity]([OperationID], [JobID], [ArtisanID])
CREATE STATISTICS S_ussSSActivityOperationIDArtisanID ON [dbo].[ussSSActivity]([OperationID], [ArtisanID])
CREATE STATISTICS S_ussSSActivityArtisanIDCurrentStateIDPartIDJobIDMachineID ON [dbo].[ussSSActivity]([ArtisanID], [CurrentStateID], [PartID], [JobID], [MachineID])
CREATE STATISTICS S_ussSSActivityLogArtisanIDMachineIDReasonCodeID ON [dbo].[ussSSActivityLog]([ArtisanID], [MachineID], [ReasonCodeID])
CREATE STATISTICS S_ussSSActivityLogMachineIDActivityID ON [dbo].[ussSSActivityLog]([MachineID], [ActivityID])
CREATE STATISTICS S_ussSSActivityLogActivityIDReasonCodeIDArtisanIDMachineID ON [dbo].[ussSSActivityLog]([ActivityID], [ReasonCodeID], [ArtisanID], [MachineID])
CREATE STATISTICS S_ussSSActivityLogActivityIDArtisanIDMachineID ON [dbo].[ussSSActivityLog]([ActivityID], [ArtisanID], [MachineID])
CREATE STATISTICS S_ussSSJobDrawingIDJobStateIDidCustomerIDPrimaryArtisanID ON [dbo].[ussSSJob]([DrawingID], [JobStateID], [id], [CustomerID], [PrimaryArtisanID])
CREATE STATISTICS S_ussSSJobPrimaryArtisanIDJobStateIDid ON [dbo].[ussSSJob]([PrimaryArtisanID], [JobStateID], [id])
CREATE STATISTICS S_ussSSJobJobStateIDCustomerID ON [dbo].[ussSSJob]([JobStateID], [CustomerID])
CREATE STATISTICS S_ussSSJobDrawingIDPrimaryArtisanIDCustomerID ON [dbo].[ussSSJob]([DrawingID], [PrimaryArtisanID], [CustomerID])
CREATE STATISTICS S_ussSSJobidCustomerIDPrimaryArtisanIDDrawingID ON [dbo].[ussSSJob]([id], [CustomerID], [PrimaryArtisanID], [DrawingID])
CREATE STATISTICS S_ussSSJobidPrimaryArtisanID ON [dbo].[ussSSJob]([id], [PrimaryArtisanID])
CREATE STATISTICS S_ussSSJobidJobStateIDCustomerIDPrimaryArtisanID ON [dbo].[ussSSJob]([id], [JobStateID], [CustomerID], [PrimaryArtisanID])



CREATE NONCLUSTERED INDEX I_ussSSActivityCurrentStateID ON [dbo].[ussSSActivity]
(
	[CurrentStateID] ASC
)WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
SET ANSI_PADDING ON

CREATE NONCLUSTERED INDEX I_ussSSActivityArtisanIDCurrentStateIDOperationIDJobIDMachineIDPartID ON [dbo].[ussSSActivity]
(
	[ArtisanID] ASC,
	[CurrentStateID] ASC,
	[OperationID] ASC,
	[JobID] ASC,
	[MachineID] ASC,
	[PartID] ASC
)
INCLUDE ( 	[id],
	[Description],
	[Comments],
	[EstimatedStartDate],
	[EstimatedDuration],
	[EstimatedElapsedDuration],
	[ActualStartDate],
	[ActualDuration],
	[ActualElapsedDuration],
	[Sequence],
	[EstimatedArtisanCost],
	[EstimatedMachineCost],
	[EstimatedOperationCost],
	[ActualArtisanCost],
	[ActualMachineCost],
	[ActualOperationCost],
	[IsActualsPosted],
	[IsNextActivity],
	[IsMaterialAvailable],
	[IsQIR],
	[CreatedUser],
	[Quantity]) WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]

CREATE NONCLUSTERED INDEX I_ussSSActivityLogActivityIDMachineIDArtisanIDReasonCodeID ON [dbo].[ussSSActivityLog]
(
	[ActivityID] ASC,
	[MachineID] ASC,
	[ArtisanID] ASC,
	[ReasonCodeID] ASC
)
INCLUDE ( 	[id],
	[StartDate],
	[Duration],
	[CurrentState],
	[ArtisanCost],
	[MachineCost],
	[OperationCost],
	[LogTime],
	[AgentID]) WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]


SET ANSI_PADDING ON

CREATE NONCLUSTERED INDEX I_ussSSDrawingID ON [dbo].[ussSSDrawing]
(
	[ID] ASC
)
INCLUDE ( 	[Code],
	[DrawingPDFPath]) WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]


