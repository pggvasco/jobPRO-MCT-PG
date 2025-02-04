Public Enum RevenueCodeMethod
    None
    [Default]
    CostCentre
    JobCategory
    JobType
End Enum

Public Enum RevenueMethod
    None
    PerLine
    OneLiner
    JobTypeDefined
End Enum

Public Enum ERPIntegrationMethod
    None
    JobCard
End Enum

Public Enum CostCentreMethod
    [Default]
    Job
    JobType
    Part
    WorkCentre
End Enum

Public Enum PricingMethod
    Cost
    Selling
End Enum

Public Enum PrefixType
    [Default]
    CostCentre
    JobType
    JobCategory
End Enum

Public Enum PurchaseOrderPrefixType
    ERP
    [Default]
    CostCentre
    JobType
    JobCategory
End Enum

Public Enum JobState
    None = 1
    Active = 0
    Completed = 4
    Cancelled = 5
    Quote = 6
    QuoteInactive = 7
    History = 8
    Archive = 9
End Enum


Public Enum GPCheckType
    PerLine = 1
    JobCard = 0
    PerLineAndJobCard = 2
End Enum
Public Enum JobSource
    Inventory = 1
    Time = 0

End Enum
Public Enum Source
    ImportedJob = 1
    ManualJob = 0

End Enum
Public Enum RateType
    Weekday = 1
    Weeknight = 2
    Saturdayday = 3
    Saturdaynight = 4
    Sundayday = 5
    Sundaynight = 6
    Publicholidayday = 7
    Publicholidaynight = 8
End Enum
Public Enum BillingType
    Invoice = 0
    CreditNote = 1
End Enum
Public Enum OptionInvoiceRun
    Y = 1
    N = 0
    P = 2
End Enum
Public Enum OptionPaymentRun
    Y = 1
    N = 0
    P = 2
End Enum

Public Enum PricelistSource
    Customer = 0
    WorkCentreCategory = 1
End Enum

Public Enum ShiftType
    Day = 0
    Night = 1
End Enum

Public Enum RepReportTypes
    Standard = 0
    WithNotes = 1
End Enum

Public Enum RepReportQuoteTypes
    None = 0
    All = 1
    Active = 2
    Inactive = 3
End Enum
Public Enum ScheduleTypes
    None = 0
    MeterBased = 1
    DateBased = 2
End Enum
Public Enum ScheduleFrequencyType
    Day = 0
    Week = 1
    Month = 2
    Year = 3
End Enum




