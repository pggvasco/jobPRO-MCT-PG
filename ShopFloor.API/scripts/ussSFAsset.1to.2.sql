IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFAsset' AND COLUMN_NAME = 'UnderWarranty')
BEGIN
ALTER TABLE ussSFAsset ADD  bit	Checked
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFAsset' AND COLUMN_NAME = 'WarrantyCode')
BEGIN
ALTER TABLE ussSFAsset ADD  WarrantyCode nvarchar(150)
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFAsset' AND COLUMN_NAME = 'WarrantyStartDate')
BEGIN
ALTER TABLE ussSFAsset ADD  WarrantyStartDate datetime
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFAsset' AND COLUMN_NAME = 'WarrantyEndDate')
BEGIN
ALTER TABLE ussSFAsset ADD WarrantyEndDate datetime
End

