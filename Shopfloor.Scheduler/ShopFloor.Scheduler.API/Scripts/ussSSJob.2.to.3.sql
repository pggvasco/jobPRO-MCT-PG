IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSSJob' AND COLUMN_NAME = 'JobStateID')
BEGIN
ALTER TABLE ussSSJob
ADD JobStateID int NULL
End
