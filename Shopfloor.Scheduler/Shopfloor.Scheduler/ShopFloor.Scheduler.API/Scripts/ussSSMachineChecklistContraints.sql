ALTER TABLE [dbo].[ussSSMachineChecklist]  WITH CHECK ADD  CONSTRAINT [FK_ussSSMachineChecklist_ussSSMachine] FOREIGN KEY([MachineId])
REFERENCES [dbo].[ussSSMachine] ([id])

ALTER TABLE [dbo].[ussSSMachineChecklist] CHECK CONSTRAINT [FK_ussSSMachineChecklist_ussSSMachine]





