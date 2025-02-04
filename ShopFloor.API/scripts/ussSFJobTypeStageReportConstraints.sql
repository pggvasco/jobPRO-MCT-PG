ALTER TABLE [dbo].[ussSFJobTypeStageReport]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJobTypeStageReport_ussSFJobTypeStages] FOREIGN KEY([JobTypeStageID])
REFERENCES [dbo].[ussSFJobTypeStages] ([id])

ALTER TABLE [dbo].[ussSFJobTypeStageReport] CHECK CONSTRAINT [FK_ussSFJobTypeStageReport_ussSFJobTypeStages]