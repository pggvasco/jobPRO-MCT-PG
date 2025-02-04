
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'IsStockReservedOnPreRequisition')
BEGIN
ALTER TABLE ussSFDefaults ADD  IsStockReservedOnPreRequisition bit null
End
