ALTER TABLE ussSSJob
ADD DrawingID int

ALTER TABLE ussSSOperation
ADD IsPrimary bit, IsDefault bit

ALTER TABLE ussSSActivityLog
ADD DrawingID int, ReasonCodeID int, Comments nvarchar(50)

ALTER TABLE ussSSMachine
ADD IsDefault bit

ALTER TABLE ussSSArtisan
ADD IsDefault bit




