
CREATE TABLE ussSFInvoiceRun(
	[id] int IDENTITY(1,1) NOT NULL,
	InvoiceWeek int  NULL,
	InvoiceDate Date NULL,
	StartDate Date NULL,
	EndDate  Date NULL,
	ExcludeDummy bit NULL
	)