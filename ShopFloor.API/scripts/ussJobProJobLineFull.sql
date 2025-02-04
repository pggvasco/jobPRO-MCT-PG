CREATE VIEW [dbo].[ussJobProJobLineFull]
AS
SELECT     dbo.ussSFJob.JobNumber, dbo.ussSFJobLine.Description1 AS JobLineDescription, dbo.ussSFWorkCentreCategory.Code AS JobLineCentreCategoryCode, 
                      dbo.Client.Account AS ClientAccount, dbo.ussSFCostCentre.Code AS CostCentreCode, dbo.ussSFJobLine.TotalPrice AS JobProTotalPrice, 
                      CASE WHEN ussSFWorkCentre.CalculationTypeID = 2 AND (ussSFWorkCentre.IsBuyOut IS NULL OR
                      ussSFWorkCentre.IsBuyOut = 0) THEN 0 ELSE ussSFJobLine.TotalCost END AS JobProTotalCost, dbo.ussSFJob.Fitter, dbo.ussSFJob.Tester, dbo.ussSFJob.Inspector, 
                      dbo.ussSFJob.AccountName, dbo.SalesRep.Code AS SalesRepCode, dbo.SalesRep.Name AS SalesRepName
FROM         dbo.ussSFJob INNER JOIN
                      dbo.ussSFJobLine ON dbo.ussSFJob.id = dbo.ussSFJobLine.JobID INNER JOIN
                      dbo.ussSFWorkCentreCategory ON dbo.ussSFJobLine.WorkCentreCategoryID = dbo.ussSFWorkCentreCategory.id INNER JOIN
                      dbo.Client ON dbo.ussSFJob.CustomerID = dbo.Client.DCLink INNER JOIN
                      dbo.ussSFCostCentre ON dbo.ussSFJob.CostCentreID = dbo.ussSFCostCentre.id INNER JOIN
                      dbo.ussSFWorkCentre ON dbo.ussSFJobLine.WorkCentreID = dbo.ussSFWorkCentre.id LEFT OUTER JOIN
                      dbo.SalesRep ON dbo.ussSFJob.RepresentativeID = dbo.SalesRep.idSalesRep

