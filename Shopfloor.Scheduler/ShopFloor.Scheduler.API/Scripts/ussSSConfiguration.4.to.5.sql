
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSSConfiguration' AND COLUMN_NAME = 'VersionNumber')
BEGIN
ALTER TABLE ussSSConfiguration
ADD VersionNumber nvarchar(50) null
End

