IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'IsSellingPriceGPChecked')
BEGIN
ALTER TABLE ussSFDefaults ADD IsSellingPriceGPChecked bit
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'SellingPriceGPPercentage')
BEGIN
ALTER TABLE ussSFDefaults ADD SellingPriceGPPercentage float
END