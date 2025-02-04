

ALTER TABLE [dbo].[ussChecklist]  WITH CHECK ADD  CONSTRAINT [FK_ussChecklist_ussChecklistType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[ussChecklistType] ([ID])


ALTER TABLE [dbo].[ussChecklist] CHECK CONSTRAINT [FK_ussChecklist_ussChecklistType]

