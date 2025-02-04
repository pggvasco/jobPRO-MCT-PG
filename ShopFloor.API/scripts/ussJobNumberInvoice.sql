CREATE VIEW [dbo].[ussJobNumberInvoice]
AS
SELECT     dbo.JobNum.InvNumber, dbo.JobNum.Description, dbo.JobNum.InvDate, REPLACE(dbo._btblJCMaster.cJobCode, '*', '') AS JobNumber, SUM(dbo.JobNum.InvTotExcl) 
                      AS InvTotExcl, dbo.Client.Account AS ClientCode, dbo.JobNum.cAccountName AS AccountName, dbo.SalesRep.Code AS SalesRepCode, 
                      dbo.SalesRep.Name AS SalesRepName
FROM         dbo.JobNum INNER JOIN
                      dbo.Client ON dbo.JobNum.AccountID = dbo.Client.DCLink LEFT OUTER JOIN
                      dbo.SalesRep ON dbo.JobNum.iRepID = dbo.SalesRep.idSalesRep LEFT OUTER JOIN
                      dbo._btblJCMaster ON dbo.JobNum.iJCMasterID = dbo._btblJCMaster.IdJCMaster
WHERE     (dbo.JobNum.DocType = 1)
GROUP BY dbo.JobNum.InvNumber, dbo.JobNum.Description, dbo.JobNum.InvDate, REPLACE(dbo._btblJCMaster.cJobCode, '*', ''), dbo.Client.Account, 
                      dbo.JobNum.cAccountName, dbo.SalesRep.Code, dbo.SalesRep.Name

