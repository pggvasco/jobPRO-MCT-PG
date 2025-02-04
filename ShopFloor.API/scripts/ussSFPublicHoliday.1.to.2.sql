if not exists (select * from sys.tables where name='ussSFPublicHoliday' and type='U')
BEGIN
---create table if does not exist
CREATE TABLE [dbo].[ussSFPublicHoliday](
	[id] [int] IDENTITY(1,1) NOT NULL,
     PublicHolidayDate  Date NULL,
	 Description nvarchar(100) ,
) ON [PRIMARY]

End