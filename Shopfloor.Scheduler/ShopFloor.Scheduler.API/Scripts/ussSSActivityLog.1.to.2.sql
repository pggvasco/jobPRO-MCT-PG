IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSSActivityLog' AND COLUMN_NAME = 'AgentID')
BEGIN
ALTER TABLE ussSSActivityLog
ADD AgentID int NULL
End

