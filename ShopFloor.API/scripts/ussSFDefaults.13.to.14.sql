IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'IsTimeSheetVersion')
BEGIN
ALTER TABLE ussSFDefaults ADD  IsTimeSheetVersion bit
End