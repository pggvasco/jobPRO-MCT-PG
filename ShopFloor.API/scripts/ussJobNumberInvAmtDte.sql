CREATE VIEW [dbo].[ussJobNumberInvAmtDte]
AS
SELECT     dbo.ussJobNumberFirstInvoiceNumberAndDate.InvNumber, dbo.ussJobNumberFirstInvoiceNumberAndDate.InvDate, 
                      dbo.ussJobNumberFirstInvoiceNumberAndDate.JobNumber, CASE WHEN ussSFJob.TotalPrice IS NULL THEN 0 ELSE ussSFJob.TotalPrice END AS TotalPrice
FROM         dbo.ussJobNumberFirstInvoiceNumberAndDate LEFT OUTER JOIN
                      dbo.ussSFJob ON dbo.ussJobNumberFirstInvoiceNumberAndDate.JobNumber = dbo.ussSFJob.JobNumber

