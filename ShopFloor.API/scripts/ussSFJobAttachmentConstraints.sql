IF OBJECT_ID('FK_ussSFJobAttachment_ussSFJob') IS NULL
ALTER TABLE [ussSFJobAttachment] WITH CHECK
ADD CONSTRAINT FK_ussSFJobAttachment_ussSFJob FOREIGN KEY ([JobID]) 
REFERENCES [dbo].[ussSFJob] ([id])

ALTER TABLE [dbo].[ussSFJobAttachment] CHECK CONSTRAINT FK_ussSFJobAttachment_ussSFJob