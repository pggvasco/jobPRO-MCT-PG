IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'JobLineCancelledReasonMinLenght')
BEGIN
ALTER TABLE ussSFDefaults ADD  JobLineCancelledReasonMinLenght int null
End

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'IsRequisitionQtyReadOnly')
BEGIN
ALTER TABLE ussSFDefaults ADD  IsRequisitionQtyReadOnly bit null
End
