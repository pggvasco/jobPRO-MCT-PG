
if not exists (select * from sys.tables where name='ussSFEmployee' and type='U')
BEGIN
---create table if does not exist
CREATE TABLE [dbo].[ussSFEmployee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	PersonID  int  NULL,		
) ON [PRIMARY]

End
