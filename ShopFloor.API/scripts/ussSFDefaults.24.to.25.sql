
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'ValidateActiveJobsAsset')
BEGIN
ALTER TABLE ussSFDefaults ADD  ValidateActiveJobsAsset bit null
End
