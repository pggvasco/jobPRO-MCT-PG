
if not exists (select * from sys.tables where name='ussSFEmployeeQualification' and type='U')
BEGIN
---create table if does not exist
CREATE TABLE [dbo].[ussSFEmployeeQualification](
	[id] [int] IDENTITY(1,1) NOT NULL,
	EmployeeID  int  NULL,
	InventoryItemID  int NULL,
    Active bit  NULL,
		
) ON [PRIMARY]

End


