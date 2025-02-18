
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'DayStartTime')
BEGIN
ALTER TABLE ussSFDefaults ADD  DayStartTime DateTime
End
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'NightStartTime')
BEGIN
ALTER TABLE ussSFDefaults ADD  NightStartTime DateTime
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'EmployeeNumberUDF')
BEGIN
ALTER TABLE ussSFDefaults ADD  EmployeeNumberUDF varchar(50)
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFDefaults' AND COLUMN_NAME = 'EmployeeIDUDF')
BEGIN
ALTER TABLE ussSFDefaults ADD  EmployeeIDUDF varchar(50)
END

