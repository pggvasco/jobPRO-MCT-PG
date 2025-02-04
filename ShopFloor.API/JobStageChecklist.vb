Imports Castle.ActiveRecord
'Imports UniSource.ShopFloor.Scheduler
Imports UniSource

Public Class JobStageChecklist

    <BelongsTo("ChecklistID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    Public Overridable Property Checklist As Checklist.API.Checklist

End Class
