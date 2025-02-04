ALTER TABLE [dbo].[ussSSMachineChecklistLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSMachineChecklistLog_ussSSArtisan] FOREIGN KEY([ArtisanID])
REFERENCES [dbo].[ussSSArtisan] ([id])


ALTER TABLE [dbo].[ussSSMachineChecklistLog] CHECK CONSTRAINT [FK_ussSSMachineChecklistLog_ussSSArtisan]


ALTER TABLE [dbo].[ussSSMachineChecklistLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSMachineChecklistLog_ussSSMachine] FOREIGN KEY([MachineID])
REFERENCES [dbo].[ussSSMachine] ([id])


ALTER TABLE [dbo].[ussSSMachineChecklistLog] CHECK CONSTRAINT [FK_ussSSMachineChecklistLog_ussSSMachine]


ALTER TABLE [dbo].[ussSSMachineChecklistLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSMachineChecklistLog_ussSSMachineChecklist] FOREIGN KEY([ChecklistID])
REFERENCES [dbo].[ussSSMachineChecklist] ([Id])


ALTER TABLE [dbo].[ussSSMachineChecklistLog] CHECK CONSTRAINT [FK_ussSSMachineChecklistLog_ussSSMachineChecklist]
