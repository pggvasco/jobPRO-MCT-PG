
ALTER TABLE [dbo].[ussChecklistTask]  WITH CHECK ADD  CONSTRAINT [FK_ussChecklistTask_ussSSLookup] FOREIGN KEY([LookupID])
REFERENCES [dbo].[ussSSLookup] ([Id])


ALTER TABLE [dbo].[ussChecklistTask] CHECK CONSTRAINT [FK_ussChecklistTask_ussSSLookup]
