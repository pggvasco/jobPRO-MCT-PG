
CREATE TABLE ussSFCustomerCostCentre(
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	Code nvarchar(50) NULL,
	[Description]nvarchar(Max) NULL,
	[WeekDayPriceListID] [int] NULL,
	[WeekNightPriceListID] [int] NULL,
	[SaturdayDayPriceListID] [int] NULL,
	[SaturdayNightPriceListID] [int] NULL,
	[SundayDayPriceListID] [int] NULL,
	[SundayNightPriceListID] [int] NULL,
	[PublicHolidayDayPricelistID] [int] NULL,
	[PublicHolidayNightPricelistID] [int] NULL
) ON [PRIMARY]




