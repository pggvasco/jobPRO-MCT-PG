IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'IsRevenueOneLinerAutoGenerated')
BEGIN
ALTER TABLE ussSFDefaults ADD IsRevenueOneLinerAutoGenerated bit
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'RevenueOneLinerInventoryItemID')
BEGIN
ALTER TABLE ussSFDefaults ADD RevenueOneLinerInventoryItemID int
END