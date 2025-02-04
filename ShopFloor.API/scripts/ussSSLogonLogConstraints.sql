
ALTER TABLE [dbo].[ussSSLogonLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSLogonLog_ussSSArtisan] FOREIGN KEY([ArtisanID])
REFERENCES [dbo].[ussSSArtisan] ([id])


ALTER TABLE [dbo].[ussSSLogonLog] CHECK CONSTRAINT [FK_ussSSLogonLog_ussSSArtisan]


ALTER TABLE [dbo].[ussSSLogonLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSLogonLog_ussSSMachine] FOREIGN KEY([MachineID])
REFERENCES [dbo].[ussSSMachine] ([id])


ALTER TABLE [dbo].[ussSSLogonLog] CHECK CONSTRAINT [FK_ussSSLogonLog_ussSSMachine]


ALTER TABLE [dbo].[ussSSLogonLog]  WITH CHECK ADD  CONSTRAINT [FK_ussSSLogonLog_ussSSReasonCode] FOREIGN KEY([ReasonCodeID])
REFERENCES [dbo].[ussSSReasonCode] ([Id])


ALTER TABLE [dbo].[ussSSLogonLog] CHECK CONSTRAINT [FK_ussSSLogonLog_ussSSReasonCode]

