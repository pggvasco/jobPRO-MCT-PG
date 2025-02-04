CREATE VIEW [dbo].[ussCreditNotesInvoiceJion]
AS
SELECT     ussEvoCreditNotesFull.CrnNumber AS InvNumber, CrnJobNumber AS JobNumber, ussEvoCreditNotesFull.Credit AS InvTotExcl, ClientCode, Description, 
                      CostCentreCode, CrnDate AS Date, AccountName,SalesRepCode,SalesRepName
FROM         ussEvoCreditNotesFull
UNION ALL
(SELECT     InvNumber, JobNumber, InvTotExcl, ClientCode, Description, '' AS CostCentreCode, InvDate AS Date, AccountName,SalesRepCode,SalesRepName
 FROM         ussJobNumberInvoice)

