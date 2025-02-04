IF OBJECT_ID('FK_ussSFJobSupplierDeliveryNote_ussSFJob') IS NULL
ALTER TABLE [dbo].[ussSFJobSupplierDeliveryNote]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJobSupplierDeliveryNote_ussSFJob] FOREIGN KEY([JobID])
REFERENCES [dbo].[ussSFJob] ([id])

ALTER TABLE [dbo].[ussSFJobSupplierDeliveryNote] CHECK CONSTRAINT [FK_ussSFJobSupplierDeliveryNote_ussSFJob]