ALTER TABLE [dbo].[ussSFJobTypeStages]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJobTypeStages_ussSFJobStage] FOREIGN KEY([JobStageID])
REFERENCES [dbo].[ussSFJobStage] ([id])

ALTER TABLE [dbo].[ussSFJobTypeStages] CHECK CONSTRAINT [FK_ussSFJobTypeStages_ussSFJobStage]

ALTER TABLE [dbo].[ussSFJobTypeStages]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJobTypeStages_ussSFJobType] FOREIGN KEY([JobTypeID])
REFERENCES [dbo].[ussSFJobType] ([id])

ALTER TABLE [dbo].[ussSFJobTypeStages] CHECK CONSTRAINT [FK_ussSFJobTypeStages_ussSFJobType]