IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobline' AND COLUMN_NAME = 'CancelledDateTime')
BEGIN
ALTER TABLE ussSFJobline ADD CancelledDateTime DateTime Null
END





