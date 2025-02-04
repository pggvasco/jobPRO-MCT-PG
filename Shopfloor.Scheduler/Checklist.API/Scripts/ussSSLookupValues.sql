CREATE TABLE [dbo].[ussSSLookupValues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LookupID] [int] NULL,
	[Code] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_ussSSLookupValues] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[ussSSLookupValues]  WITH CHECK ADD  CONSTRAINT [FK_ussSSLookupValues_ussSSLookup] FOREIGN KEY([LookupID])
REFERENCES [dbo].[ussSSLookup] ([Id])


ALTER TABLE [dbo].[ussSSLookupValues] CHECK CONSTRAINT [FK_ussSSLookupValues_ussSSLookup]



