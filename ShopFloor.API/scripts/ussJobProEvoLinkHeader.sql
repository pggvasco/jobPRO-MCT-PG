CREATE VIEW [dbo].[ussJobProEvoLinkHeader]
AS
SELECT     dbo.ussJobNumberInvAmtDte.JobNumber AS JobProJobNumber, CASE WHEN ussJobNumberInvAmtDte.JobNumber IS NULL 
                      THEN 'EvoOnly' ELSE 'JobProAndEvo' END AS JobType, CASE WHEN ussJobNumberInvAmtDte.TotalPrice IS NULL 
                      THEN 0 ELSE ussJobNumberInvAmtDte.TotalPrice END AS JobProTotalPrice, dbo.ussJobNumberInvoice.InvNumber, dbo.ussJobNumberInvoice.Description, 
                      dbo.ussJobNumberInvoice.InvDate, dbo.ussJobNumberInvoice.JobNumber, dbo.ussJobNumberInvoice.InvTotExcl
FROM         dbo.ussJobNumberInvAmtDte RIGHT OUTER JOIN
                      dbo.ussJobNumberInvoice ON dbo.ussJobNumberInvAmtDte.InvNumber = dbo.ussJobNumberInvoice.InvNumber

