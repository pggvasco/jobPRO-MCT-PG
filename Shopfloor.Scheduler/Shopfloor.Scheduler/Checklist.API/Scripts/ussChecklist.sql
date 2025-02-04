CREATE TABLE [dbo].[ussChecklist](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[TypeID] [int] NULL,
 CONSTRAINT [PK_ussChecklist] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



ALTER TABLE [dbo].[ussChecklist]  WITH CHECK ADD  CONSTRAINT [FK_ussChecklist_ussChecklstType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[ussChecklstType] ([ID])


ALTER TABLE [dbo].[ussChecklist] CHECK CONSTRAINT [FK_ussChecklist_ussChecklstType]


