Create Procedure [dbo].[ussSFValidateProformaJobLines] (@JobID BigInt, @ProformaInvoiceID BigINt)
AS

BEGIN
declare @Count bigint

-- Checking for differences
SELECT @Count = COUNT(*) from ussSFJobLine jl 
                              	inner join ussSFProformaInvoiceLine crl ON crl.JobLineId = jl.id  
								and JobId = @JobID 
                                 WHERE ((jl.InventoryItemID <> crl.InventoryItemID )   
                           		  or (jl.Quantity <> crl.Quantity )    
                         		  or (jl.UnitPriceBeforeDiscount <> crl.UnitPriceBeforeDiscount )   
                          		  or (jl.UnitPrice <> crl.UnitPrice )    
                              	  or (jl.LineDiscountPercent <> crl.LineDiscountPercent )   
                               	  or (jl.TotalPrice <> crl.TotalPrice ))    
                                  AND (JobId = @JobID   and  ProformaInvoiceID = @ProformaInvoiceID ) 
								
If (@Count=0) -- Check if lines are added
Begin
							SELECT @Count= COUNT(*) from ussSFJobLine where id not in
                            (SELECT jl.id from ussSFJobLine jl 	inner join ussSFProformaInvoiceLine crl ON crl.JobLineId = jl.id  
							AND (JobId = @JobID   and  ProformaInvoiceID = @ProformaInvoiceID ))
							AND JobId = @JobID
End

select @Count

END