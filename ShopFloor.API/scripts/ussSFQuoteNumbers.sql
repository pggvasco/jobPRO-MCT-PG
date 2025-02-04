CREATE VIEW [dbo].[ussSFQuoteNumbers]
AS
SELECT       ID, QuoteNumber, OrderNumber, Description1, Description2
FROM            dbo.ussSFJob
Where QuoteNumber is Not Null
And QuoteNumber <> ''