alter table ussSFDefaults
add ProformaInvoiceNumberPrefix nvarchar(10) Not null default 'PINV',
	ProformaInvoiceNumberPadding Integer not null default 5,
	ProformaInvoiceNumberNextNumber Integer not null default 1

