
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'ValidateActiveJobsEquipment')
BEGIN
ALTER TABLE ussSFDefaults ADD  ValidateActiveJobsEquipment bit null
End
