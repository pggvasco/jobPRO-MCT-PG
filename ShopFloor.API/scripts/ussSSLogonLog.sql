CREATE TABLE [dbo].[ussSSLogonLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtisanID] [int] NULL,
	[MachineID] [int] NULL,
	[Timestamp] [datetime] NULL,
	[LogonTypeID] [int] NULL,
	[ReasonCodeID] [int] NULL,
 CONSTRAINT [PK_ussLogonLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



