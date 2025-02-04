ALTER TABLE [dbo].[ussSSOperationChecklistLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSOperationChecklistLog_ussSSArtisan] FOREIGN KEY([ArtisanID])
REFERENCES [dbo].[ussSSArtisan] ([id])


ALTER TABLE [dbo].[ussSSOperationChecklistLog] CHECK CONSTRAINT [FK_ussSSOperationChecklistLog_ussSSArtisan]


ALTER TABLE [dbo].[ussSSOperationChecklistLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSOperationChecklistLog_ussSSMachine] FOREIGN KEY([MachineID])
REFERENCES [dbo].[ussSSMachine] ([id])


ALTER TABLE [dbo].[ussSSOperationChecklistLog] CHECK CONSTRAINT [FK_ussSSOperationChecklistLog_ussSSMachine]


ALTER TABLE [dbo].[ussSSOperationChecklistLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSOperationChecklistLog_ussSSOperationChecklist] FOREIGN KEY([ChecklistID])
REFERENCES [dbo].[ussSSOperationChecklist] ([Id])


ALTER TABLE [dbo].[ussSSOperationChecklistLog] CHECK CONSTRAINT [FK_ussSSOperationChecklistLog_ussSSOperationChecklist]






