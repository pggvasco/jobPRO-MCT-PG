CREATE VIEW [dbo].[ussEvoCreditNotesFull]
AS
SELECT     TOP (100) PERCENT REPLACE(dbo._bvARTransactionsFull.InvNumber, '*', '') AS CrnNumber, dbo._bvARTransactionsFull.Order_No AS CrnJobNumber, 
                      dbo._bvARTransactionsFull.Description, 
                      CASE WHEN dbo._bvARTransactionsFull.Debit > 0 THEN (dbo._bvARTransactionsFull.Debit - dbo._bvARTransactionsFull.Tax_Amount) 
                      ELSE dbo._bvARTransactionsFull.Credit * - 1 + dbo._bvARTransactionsFull.Tax_Amount END AS Credit, dbo.Client.Account AS ClientCode, 
                      dbo._bvARTransactionsFull.Id AS CostCentreCode, dbo._bvARTransactionsFull.TxDate AS CrnDate, dbo._bvARTransactionsFull.Tax_Amount, 
                      dbo.Client.Name AS AccountName, dbo.SalesRep.Code AS SalesRepCode, dbo.SalesRep.Name AS SalesRepName
FROM         dbo._bvARTransactionsFull INNER JOIN
                      dbo.Client ON dbo._bvARTransactionsFull.AccountLink = dbo.Client.DCLink LEFT OUTER JOIN
                      dbo.SalesRep ON dbo._bvARTransactionsFull.RepID = dbo.SalesRep.idSalesRep
WHERE     (dbo._bvARTransactionsFull.Id IN ('Crn', 'Inv'))
ORDER BY CrnNumber

