IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'ParrentJobID')
BEGIN
ALTER TABLE ussSFJob
ADD ParrentJobID int NULL
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'IsParrentJob')
BEGIN
ALTER TABLE ussSFJob
ADD IsParrentJob bit NULL DEFAULT 1

End