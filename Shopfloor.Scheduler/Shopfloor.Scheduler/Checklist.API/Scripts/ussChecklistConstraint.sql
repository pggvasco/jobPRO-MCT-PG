

ALTER TABLE [dbo].[ussChecklist]  WITH CHECK ADD  CONSTRAINT [FK_ussChecklist_ussChecklstType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[ussChecklstType] ([ID])


ALTER TABLE [dbo].[ussChecklist] CHECK CONSTRAINT [FK_ussChecklist_ussChecklstType]

