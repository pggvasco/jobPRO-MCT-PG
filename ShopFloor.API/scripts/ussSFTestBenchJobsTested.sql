CREATE TABLE [dbo].[ussSFTestBenchJobsTested](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JOB_NO] [nvarchar](50) NULL,
	[SAMPLE_NO] [int] NULL,
	[CUSTOMER] [nvarchar](50) NULL,
	[TESTED_BY] [nvarchar](50) NULL,
	[DATE] [nvarchar](50) NULL,
	[PRESSURE] [int] NULL,
	[PRESSURE_UNITS] [nvarchar](20) NULL,
	[FLOW] [int] NULL,
	[FLOW_UNITS] [nvarchar](20) NULL,
	[FLOW_OFFSET] [int] NULL,
	[SPEED] [int] NULL,
	[SPEED_UNITS] [nvarchar](20) NULL,
	[TEMP] [int] NULL,
	[TEMP_UNITS] [nvarchar](20) NULL,
	[EFFICIENCY] [real] NULL,
	[RESULT] [nvarchar](10) NULL,
	[DESCRIPTION] [nvarchar](50) NULL,
	[COMMENT] [nvarchar](50) NULL,
	[SEC_PORT] [nvarchar](5) NULL,
	[PARTNO] [nvarchar](20) NULL,
	[ROTATION] [nvarchar](20) NULL,
	[REVISION] [nvarchar](5) NULL
) ON [PRIMARY]


