IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'PriceCheckNumberPrefixTypeID')
BEGIN
ALTER TABLE ussSFDefaults ADD  PriceCheckNumberPrefixTypeID int null
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'PriceCheckNumberPrefix')
BEGIN
ALTER TABLE ussSFDefaults ADD  PriceCheckNumberPrefix nvarchar(10) null
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'PriceCheckNumberPadding')
BEGIN
ALTER TABLE ussSFDefaults ADD  PriceCheckNumberPadding int null
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'PriceCheckNumberNextNumber')
BEGIN
ALTER TABLE ussSFDefaults ADD  PriceCheckNumberNextNumber int null
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'PriceCheckJobTypeID')
BEGIN
ALTER TABLE ussSFDefaults ADD  PriceCheckJobTypeID Integer
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'PriceCheckCostCentreID')
BEGIN
ALTER TABLE ussSFDefaults ADD  PriceCheckCostCentreID Integer
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'PriceCheckCustomerID')
BEGIN
ALTER TABLE ussSFDefaults ADD  PriceCheckCustomerID Integer
End