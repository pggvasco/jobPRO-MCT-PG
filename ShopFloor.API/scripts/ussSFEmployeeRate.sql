
if not exists (select * from sys.tables where name='ussSFRate' and type='U')
BEGIN
---create table if does not exist
CREATE TABLE [dbo].[ussSFRate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	EmployeeID  int  NULL,
	Rate Float(20)  NULL,
	EffectiveDate Date NULL,
    Deleted bit  NULL,
		
) ON [PRIMARY]

End


