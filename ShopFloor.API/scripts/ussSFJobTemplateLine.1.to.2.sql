IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobTemplateLine' AND COLUMN_NAME = 'UnitSize')
BEGIN
ALTER TABLE ussSFJobTemplateLine ADD UnitSize float
END
