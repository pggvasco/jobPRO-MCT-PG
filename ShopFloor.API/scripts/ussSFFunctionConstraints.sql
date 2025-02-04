ALTER TABLE [dbo].[ussSFFunction]  WITH CHECK ADD  CONSTRAINT [FK_ussSFFunction_ussSFMake] FOREIGN KEY([MakeID])
REFERENCES [dbo].[ussSFMake] ([id])

ALTER TABLE [dbo].[ussSFFunction] CHECK CONSTRAINT [FK_ussSFFunction_ussSFMake]