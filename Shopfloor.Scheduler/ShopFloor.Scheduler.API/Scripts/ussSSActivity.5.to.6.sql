IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSSActivity' AND COLUMN_NAME = 'CurrentStateID')
BEGIN
ALTER TABLE ussSSActivity
ADD CurrentStateID int null
End
