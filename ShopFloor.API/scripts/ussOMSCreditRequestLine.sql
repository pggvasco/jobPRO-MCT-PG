create table ussOMSCreditRequestLine
(
id						integer identity not null,
ProformaInvoiceID		Integer not null,
JobLineID				Integer not null,
InventoryItemID			Integer,
Quantity				Float,
UnitPriceBeforeDiscount Float,
UnitPrice				Float,
LineDiscountPercent		Float,
TotalPrice				Float
, constraint fk_ussOMSCreditRequestLine_JobID foreign key (ProformaInvoiceID) references ussSFProformaInvoice(ID)

)
