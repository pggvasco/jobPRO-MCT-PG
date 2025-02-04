
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'SubContractorReference')
BEGIN
ALTER TABLE ussSFJob ADD SubContractorReference nvarchar(255)
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'SubContractorQuotedPrice')
BEGIN
ALTER TABLE ussSFJob ADD SubContractorQuotedPrice float
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'SubContractor')
BEGIN
ALTER TABLE ussSFJob ADD SubContractor nvarchar(255)
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'PreRequisitionPrintedAgentID')
BEGIN
ALTER TABLE ussSFJob ADD PreRequisitionPrintedAgentID int
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'RequisitionPrintedAgentID')
BEGIN
ALTER TABLE ussSFJob ADD RequisitionPrintedAgentID int
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJob' AND COLUMN_NAME = 'ImportReference')
BEGIN
ALTER TABLE ussSFJob ADD ImportReference nvarchar(255)
END

