
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSSConfiguration' AND COLUMN_NAME = 'DrawingPath')
BEGIN
ALTER TABLE ussSSConfiguration
ADD DrawingPath nvarchar(MAX) null
End
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSSConfiguration' AND COLUMN_NAME = 'DrawingExtension')
BEGIN
ALTER TABLE ussSSConfiguration
ADD DrawingExtension nvarchar(50) null
End

