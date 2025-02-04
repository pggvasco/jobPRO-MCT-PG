CREATE VIEW [dbo].[ussEvoJobLineFull]
AS
SELECT     dbo.JobNum.InvNumber, REPLACE(dbo._btblJCMaster.cJobCode, '*', '') AS EvoJobNumber, dbo._btblJCInvoiceLines.cDescription AS EvoLineDescription, 
                      dbo._btblJCInvoiceLines.fLineTotExcl AS EvoLineTotalExcl, dbo._btblJCInvoiceLines.cLineNotes AS EvoLineNotes, 
                      dbo._btblJCInvoiceLines.fUnitCost * dbo._btblJCInvoiceLines.fQuantity AS EvoLineTotalCost, dbo.Client.Account AS ClientCode, 
                      dbo.JobTxTp.TxType AS CostCentreCode, dbo.JobNum.InvDate, dbo.JobNum.cAccountName AS AccountName, dbo.SalesRep.Code AS SalesRepCode, 
                      dbo.SalesRep.Name AS SalesRepName
FROM         dbo._btblJCInvoiceLines INNER JOIN
                      dbo.JobNum ON dbo._btblJCInvoiceLines.iJobNumID = dbo.JobNum.AutoIndex INNER JOIN
                      dbo._btblJCMaster ON dbo.JobNum.iJCMasterID = dbo._btblJCMaster.IdJCMaster INNER JOIN
                      dbo.Client ON dbo.JobNum.AccountID = dbo.Client.DCLink INNER JOIN
                      dbo.JobTxTp ON dbo._btblJCInvoiceLines.iJobTxTpID = dbo.JobTxTp.idJobTxTp LEFT OUTER JOIN
                      dbo.SalesRep ON dbo.JobNum.iRepID = dbo.SalesRep.idSalesRep
WHERE     (dbo.JobNum.DocType = 1)

