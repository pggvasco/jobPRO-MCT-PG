IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'PreRequisitionPrintedAgentID')
BEGIN
ALTER TABLE ussSFJobline ADD PreRequisitionPrintedAgentID int
END

