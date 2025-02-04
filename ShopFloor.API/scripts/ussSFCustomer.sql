if not exists (select * from sys.tables where name='ussSFCustomer' and type='U')
BEGIN
---create table if does not exist
CREATE TABLE [dbo].[ussSFCustomer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	ERPCustomerID  int  NULL
) ON [PRIMARY]

End
