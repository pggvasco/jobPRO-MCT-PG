IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'EmployeeImportCodeUDF')
BEGIN
ALTER TABLE ussSFDefaults ADD  EmployeeImportCodeUDF nvarchar(50)
END



