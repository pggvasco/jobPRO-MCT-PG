
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'ExpectedGP')
BEGIN
ALTER TABLE ussSFJob ADD ExpectedGP float
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'CurrentGP')
BEGIN
ALTER TABLE ussSFJob ADD CurrentGP float
END

