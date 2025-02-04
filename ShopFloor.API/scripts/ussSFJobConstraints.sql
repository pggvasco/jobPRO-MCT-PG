ALTER TABLE [dbo].[ussSFJob]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJob_ussSFJobStage] FOREIGN KEY([StageID])
REFERENCES [dbo].[ussSFJobStage] ([id])

ALTER TABLE [dbo].[ussSFJob] CHECK CONSTRAINT [FK_ussSFJob_ussSFJobStage]

ALTER TABLE [dbo].[ussSFJob]  WITH CHECK ADD  CONSTRAINT [FK_ussSFJob_ussSFJobType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[ussSFJobType] ([id])

ALTER TABLE [dbo].[ussSFJob] CHECK CONSTRAINT [FK_ussSFJob_ussSFJobType]