--creates staging table fo Time upload
if not exists (select * from sys.tables where name='ussSFTimeUpload' and type='U')
BEGIN
----create table if does not exist
CREATE TABLE [dbo].[ussSFTimeUpload](
	[ussID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerNumber] [nvarchar](100) NULL,
	[CostCentre] [nvarchar](100) NULL,
	[Date] [nvarchar](20) NULL,
	[EmployeeNumber] [varchar](100) NULL,
	[EmployeeFirstName] [nvarchar](20) NULL,
	[EmployeeSurname] [nvarchar](50) NULL,
	[Agency] [nvarchar](100) NULL,
	[JobClass] [nvarchar](100) NULL,
	[PayCode] [nvarchar](100) NULL,
	[ClockIn] [nvarchar](100) NULL,
	[ClockOut] [nvarchar](100) NULL,
	[HoursClocked] [float] NULL,
	[SignedOffDate] [nvarchar](50) NULL,
	[UploadDate] [nvarchar](50) NULL,
	[ImportFileName] [nvarchar](max) NULL,
) ON [PRIMARY]

End
