IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobType' AND COLUMN_NAME = 'RevenueMethodID')
BEGIN
ALTER TABLE ussSFJobType ADD RevenueMethodID int
END