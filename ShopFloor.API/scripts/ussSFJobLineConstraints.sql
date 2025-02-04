ALTER TABLE [dbo].[ussSFJobLine]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJobLine_ussSFJob] FOREIGN KEY([JobID])
REFERENCES [dbo].[ussSFJob] ([id])

ALTER TABLE [dbo].[ussSFJobLine] CHECK CONSTRAINT [FK_ussSFJobLine_ussSFJob]

ALTER TABLE [dbo].[ussSFJobLine]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJobLine_ussSFPart] FOREIGN KEY([PartID])
REFERENCES [dbo].[ussSFPart] ([id])

ALTER TABLE [dbo].[ussSFJobLine] CHECK CONSTRAINT [FK_ussSFJobLine_ussSFPart]

ALTER TABLE [dbo].[ussSFJobLine]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJobLine_ussSFWorkCentre] FOREIGN KEY([WorkCentreID])
REFERENCES [dbo].[ussSFWorkCentre] ([id])

ALTER TABLE [dbo].[ussSFJobLine] CHECK CONSTRAINT [FK_ussSFJobLine_ussSFWorkCentre]