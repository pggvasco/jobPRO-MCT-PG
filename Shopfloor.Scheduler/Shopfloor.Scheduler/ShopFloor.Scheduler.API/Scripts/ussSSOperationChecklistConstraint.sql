ALTER TABLE [dbo].[ussSSOperationChecklist]  WITH CHECK ADD  CONSTRAINT [FK_ussSSOperationChecklist_ussSSOperation] FOREIGN KEY([OperationID])
REFERENCES [dbo].[ussSSOperation] ([id])


ALTER TABLE [dbo].[ussSSOperationChecklist] CHECK CONSTRAINT [FK_ussSSOperationChecklist_ussSSOperation]






