CREATE PROCEDURE ussSFProformaInvoiceTrackingRep (@dateFrom datetime , @dateto datetime) 
AS
BEGIN


select @dateFrom = convert(datetime , convert(varchar(12), @dateFrom, 102))

select @dateto = dateadd(mi, -1 , dateadd(dd, 1,convert(datetime , convert(varchar(12), @dateto , 102))))



SELECT p.ProformaInvoiceNumber , 
		p.CreatedDateTime , 
		j.JobNumber, 
		m.cFinalInvoiceNo , 
		CreatedUserName,
		cl.Name,
		cl.Account ,
		sum(jl.TotalPrice) TotalPrice
  FROM ussSFProformaInvoice p 

		LEFT OUTER JOIN ussSFJob j ON j.id = p.JobID
		LEFT OUTER JOIN _btblJCMaster m ON m.cJobCode = j.JobNumber 
		-- LEFT OUTER JOIN ussSFCustomer c on c.id = j.CustomerID 
		LEFT OUTER JOIN Client cl on cl.DCLink = j.CustomerID 
		LEFT OUTER JOIN ussSFJobLine jl ON jl.JobID = p.JobID
  WHERE p.CreatedDateTime BETWEEN @dateFrom AND @dateTo
  GROUP BY p.ProformaInvoiceNumber , 
		p.CreatedDateTime , 
		j.JobNumber, 
		m.cFinalInvoiceNo , 
		CreatedUserName,
		cl.Name,
		cl.Account
  ORDER BY JobNumber, p.ProformaInvoiceNumber  
END

