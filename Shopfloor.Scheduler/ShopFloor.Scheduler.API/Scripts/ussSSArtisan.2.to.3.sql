IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSSArtisan' AND COLUMN_NAME = 'ForemanArtisanID')
BEGIN
ALTER TABLE ussSSArtisan
ADD ForemanArtisanID int NULL
End
