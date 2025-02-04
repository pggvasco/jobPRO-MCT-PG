ALTER TABLE [dbo].[ussSFJobDeliveryNote]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJobDeliveryNote_ussSFJob] FOREIGN KEY([JobID])
REFERENCES [dbo].[ussSFJob] ([id])

ALTER TABLE [dbo].[ussSFJobDeliveryNote] CHECK CONSTRAINT [FK_ussSFJobDeliveryNote_ussSFJob]