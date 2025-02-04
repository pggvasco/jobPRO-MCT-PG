
if not exists (select * from sys.tables where name='ussSFCustomerJobClass' and type='U')
BEGIN
---create table if does not exist
CREATE TABLE [dbo].[ussSFCustomerJobClass](
	[id] [int] IDENTITY(1,1) NOT NULL,
	Code  nvarchar(50) NULL,
	[Description] nvarchar(Max) NULL,
	CustomerCostCentreID  int NULL,
      InventoryItemID  int NULL
) ON [PRIMARY]
End
