CREATE VIEW [dbo].[ussJobProEvoSalesAnalysis]
AS
SELECT     InvNumber, JobNumber, InvTotExcl AS EvoTotal, 0 AS EvoTotalPrice, 0 AS EvoTotalCost, 0 AS JobProTotalPrice, 0 AS JobProTotalCost, ClientCode AS ClientAccount, 
                      Description AS Description, CostCentreCode, '' AS CentreCategoryCode, '' AS EvoLineNotes, Date, '' AS Fitter, '' AS Tester, '' AS Inspector, AccountName,SalesRepCode,SalesRepName
FROM         ussCreditNotesInvoiceJion
UNION ALL
(SELECT     InvNumber, JobNumber, 0 AS EvoTotal, EvoLineTotalExcl AS EvoTotalPrice, EvoLineTotalCost AS EvoTotalCost, JobProTotalPrice AS JobProTotalPrice, 
                        JobProTotalCost AS JobProTotalCost, ClientAccount, Description AS Description, CostCentreCode, CentreCategoryCode, EvoLineNotes, InvDate AS Date, Fitter, Tester, 
                        Inspector, AccountName,SalesRepCode,SalesRepName
 FROM         ussJobProEvoiJion)

