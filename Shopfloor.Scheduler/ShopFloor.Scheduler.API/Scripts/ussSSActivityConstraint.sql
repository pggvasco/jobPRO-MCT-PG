ALTER TABLE [dbo].[ussSSActivity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Artisan] FOREIGN KEY([ArtisanID])
REFERENCES [dbo].[ussSSArtisan] ([id])


ALTER TABLE [dbo].[ussSSActivity] CHECK CONSTRAINT [FK_Activity_Artisan]


ALTER TABLE [dbo].[ussSSActivity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Job] FOREIGN KEY([JobID])
REFERENCES [dbo].[ussSSJob] ([id])


ALTER TABLE [dbo].[ussSSActivity] CHECK CONSTRAINT [FK_Activity_Job]


ALTER TABLE [dbo].[ussSSActivity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Machine] FOREIGN KEY([MachineID])
REFERENCES [dbo].[ussSSMachine] ([id])


ALTER TABLE [dbo].[ussSSActivity] CHECK CONSTRAINT [FK_Activity_Machine]


ALTER TABLE [dbo].[ussSSActivity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Operation] FOREIGN KEY([OperationID])
REFERENCES [dbo].[ussSSOperation] ([id])


ALTER TABLE [dbo].[ussSSActivity] CHECK CONSTRAINT [FK_Activity_Operation]


ALTER TABLE [dbo].[ussSSActivity]  WITH CHECK ADD  CONSTRAINT [FK_ussSSActivity_ussSSJob] FOREIGN KEY([JobID])
REFERENCES [dbo].[ussSSJob] ([id])


ALTER TABLE [dbo].[ussSSActivity] CHECK CONSTRAINT [FK_ussSSActivity_ussSSJob]


ALTER TABLE [dbo].[ussSSActivity]  WITH CHECK ADD  CONSTRAINT [FK_ussSSActivity_ussSSMachine] FOREIGN KEY([MachineID])
REFERENCES [dbo].[ussSSMachine] ([id])


ALTER TABLE [dbo].[ussSSActivity] CHECK CONSTRAINT [FK_ussSSActivity_ussSSMachine]


ALTER TABLE [dbo].[ussSSActivity]  WITH CHECK ADD  CONSTRAINT [FK_ussSSActivity_ussSSOperation] FOREIGN KEY([OperationID])
REFERENCES [dbo].[ussSSOperation] ([id])


ALTER TABLE [dbo].[ussSSActivity] CHECK CONSTRAINT [FK_ussSSActivity_ussSSOperation]


ALTER TABLE [dbo].[ussSSActivity]  WITH CHECK ADD  CONSTRAINT [FK_ussSSActivity_ussSSPart] FOREIGN KEY([PartID])
REFERENCES [dbo].[ussSSPart] ([id])


ALTER TABLE [dbo].[ussSSActivity] CHECK CONSTRAINT [FK_ussSSActivity_ussSSPart]



