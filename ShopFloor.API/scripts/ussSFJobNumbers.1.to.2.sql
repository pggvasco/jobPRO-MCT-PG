Alter VIEW [dbo].[ussSFJobNumbers]
AS
SELECT       ID, JobNumber, OrderNumber, Description1, Description2
FROM            dbo.ussSFJob
Where JobNumber Is Not Null
And JobNumber <> ''