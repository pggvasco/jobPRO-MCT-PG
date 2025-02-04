ALTER TABLE [dbo].[ussSFModel]  WITH CHECK ADD  CONSTRAINT [FK_ussSFModel_ussSFMake] FOREIGN KEY([MakeID])
REFERENCES [dbo].[ussSFMake] ([id])

ALTER TABLE [dbo].[ussSFModel] CHECK CONSTRAINT [FK_ussSFModel_ussSFMake]