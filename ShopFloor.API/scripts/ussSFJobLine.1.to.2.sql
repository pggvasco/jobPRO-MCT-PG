IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'EmployeeID')
BEGIN
ALTER TABLE ussSFJobline ADD EmployeeID int
END


IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'RateTypeID')
BEGIN
ALTER TABLE ussSFJobline ADD RateTypeID int
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'EmployeeRate')
BEGIN
ALTER TABLE ussSFJobline ADD EmployeeRate float
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'EmployeeTotal')
BEGIN
ALTER TABLE ussSFJobline ADD EmployeeTotal float
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'TimeUnitPrice')
BEGIN
ALTER TABLE ussSFJobline ADD TimeUnitPrice float
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'StartDate')
BEGIN
ALTER TABLE ussSFJobline ADD StartDate dateTime
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'EndDate')
BEGIN
ALTER TABLE ussSFJobline ADD EndDate dateTime
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'NotWorked')
BEGIN
ALTER TABLE ussSFJobline ADD NotWorked bit
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'Deleted')
BEGIN
ALTER TABLE ussSFJobline ADD Deleted bit
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'InvoiceRun')
BEGIN
ALTER TABLE ussSFJobline ADD InvoiceRun bit
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'PaymentRun')
BEGIN
ALTER TABLE ussSFJobline ADD PaymentRun bit
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'InvoiceWeek')
BEGIN
ALTER TABLE ussSFJobline ADD InvoiceWeek int
END