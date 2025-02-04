IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'InvoiceAmount')
BEGIN
ALTER TABLE ussSFJobline ADD InvoiceAmount float
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'CommisionPercentage')
BEGIN
ALTER TABLE ussSFJobline ADD CommisionPercentage float not null DEFAULT '0'
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'PaymentRunYNP')
BEGIN
ALTER TABLE ussSFJobline ADD PaymentRunYNP int not null DEFAULT 1
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'InvoiceRunYNP')
BEGIN
ALTER TABLE ussSFJobline ADD InvoiceRunYNP int
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'TimeSheetClosed')
BEGIN
ALTER TABLE ussSFJobline ADD TimesheetClosed bit
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'CommissionValue')
BEGIN
ALTER TABLE ussSFJobline ADD CommissionValue float
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'SANCReferenceNumber')
BEGIN
ALTER TABLE ussSFJobline ADD SANCReferenceNumber nvarchar(50)
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'SANCReceiptNumber')
BEGIN
ALTER TABLE ussSFJobline ADD SANCReceiptNumber nvarchar(50)
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'ExcludeFromPayment')
BEGIN
ALTER TABLE ussSFJobline ADD ExcludeFromPayment bit not null default '0' 
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'ExcludeReason')
BEGIN
ALTER TABLE ussSFJobline ADD ExcludeReason nvarchar(50)
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'ClockCode')
BEGIN
ALTER TABLE ussSFJobline ADD ClockCode nvarchar(50)
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'IsTimeApproved')
BEGIN
ALTER TABLE ussSFJobline ADD IsTimeApproved bit not null default '0'
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'TimeApprovedAgent')
BEGIN
ALTER TABLE ussSFJobline ADD TimeApprovedAgent nvarchar(50)
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'BillingType')
BEGIN
ALTER TABLE ussSFJobline ADD BillingType int
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'FaxPayRequest')
BEGIN
ALTER TABLE ussSFJobline ADD FaxPayRequest bit
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'Sigma')
BEGIN
ALTER TABLE ussSFJobline ADD Sigma bit
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'Variance')
BEGIN
ALTER TABLE ussSFJobline ADD Variance bit
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'Call')
BEGIN
ALTER TABLE ussSFJobline ADD [Call] bit
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'TarrifDifference')
BEGIN
ALTER TABLE ussSFJobline ADD TarrifDifference bit
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'InvoiceRunDate')
BEGIN
ALTER TABLE ussSFJobline ADD  InvoiceRunDate DateTime
END
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'PaymentRunDate')
BEGIN
ALTER TABLE ussSFJobline ADD  PaymentRunDate DateTime
END







