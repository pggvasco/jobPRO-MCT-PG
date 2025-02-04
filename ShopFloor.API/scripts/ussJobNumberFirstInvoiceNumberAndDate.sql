CREATE VIEW [dbo].[ussJobNumberFirstInvoiceNumberAndDate]
AS
SELECT     TOP (100) PERCENT MIN(dbo.JobNum.InvNumber) AS InvNumber, MIN(dbo.JobNum.InvDate) AS InvDate, REPLACE(dbo._btblJCMaster.cJobCode, '*', '') AS JobNumber,
                       SUM(dbo.JobNum.InvTotExcl) AS InvTotExcl
FROM         dbo.JobNum INNER JOIN
                      dbo._btblJCMaster ON dbo.JobNum.iJCMasterID = dbo._btblJCMaster.IdJCMaster
WHERE     (dbo.JobNum.DocType = 1)
GROUP BY REPLACE(dbo._btblJCMaster.cJobCode, '*', '')
ORDER BY JobNumber
