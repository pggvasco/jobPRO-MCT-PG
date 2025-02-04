IF OBJECT_ID('FK_ussJobLineTimeAttachmentAttachment_ussDMReconciliationBatch') IS NULL
ALTER TABLE [ussSFJobLineTimeAttachment] WITH CHECK
ADD CONSTRAINT FK_ussSFJobLineTimeAttachment_ussSFJobLineTime FOREIGN KEY ([JobLineTimeID]) 
REFERENCES [dbo].[ussSFJobLineTime] ([id])

ALTER TABLE [dbo].[ussSFJobLineTimeAttachment] CHECK CONSTRAINT FK_ussSFJobLineTimeAttachment_ussSFJobLineTime