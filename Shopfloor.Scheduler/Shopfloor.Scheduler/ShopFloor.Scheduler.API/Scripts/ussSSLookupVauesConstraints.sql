ALTER TABLE [dbo].[ussSSLookupValues]  WITH CHECK ADD  CONSTRAINT [FK_ussSSLookupValues_ussSSLookup] FOREIGN KEY([LookupID])
REFERENCES [dbo].[ussSSLookup] ([Id])

ALTER TABLE [dbo].[ussSSLookupValues] CHECK CONSTRAINT [FK_ussSSLookupValues_ussSSLookup]




