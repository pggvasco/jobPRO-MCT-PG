
CREATE VIEW [dbo].[ussJobProEvoiJion]
AS
SELECT     InvNumber, ussJobProJobLineFull.JobNumber, JobLineDescription AS Description, JobLineCentreCategoryCode AS CentreCategoryCode, ClientAccount, 
                      CostCentreCode, JobProTotalPrice, JobProTotalCost, 0 AS EvoLineTotalExcl, 0 AS EvoLineTotalCost, '' AS EvoLineNotes, InvDate, Fitter, Tester, Inspector, 
                      AccountName,SalesRepCode,SalesRepName
FROM         ussJobProJobLineFull, ussJobNumberFirstInvoiceNumberAndDate
WHERE     ussJobProJobLineFull.JobNumber = ussJobNumberFirstInvoiceNumberAndDate.JobNumber
UNION ALL
(SELECT     InvNumber, EvoJobNumber, EvoLineDescription AS Description, '' AS CentreCategoryCode, ClientCode AS ClientAccount, CostCentreCode, 0 AS JobProTotalPrice, 
                        0 AS JobProTotalCost, EvoLineTotalExcl, EvoLineTotalCost, EvoLineNotes, InvDate, '' AS Fitter, '' AS Tester, '' AS Inspector, AccountName,SalesRepCode,SalesRepName
 FROM         ussEvoJobLineFull)

