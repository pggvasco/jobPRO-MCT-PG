ALTER TABLE ussSSJob
ADD DrawingID int, PrimaryArtisanID int, PrimaryOperationID int,PartID int, OrderNumber varchar(50)

ALTER TABLE ussSSOperation
ADD IsPrimary bit

ALTER TABLE ussSSActivityLog
ADD DrawingID int, ReasonCodeID int, Comments nvarchar(50)

ALTER TABLE ussSSArtisan
ADD IsPrimary bit

ALTER TABLE ussSSActivity
ADD [Description] nvarchar(50) NULL, IsNextActivity bit,
	[Comments] nvarchar(50) NULL;

