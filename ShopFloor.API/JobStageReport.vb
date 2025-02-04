Imports Castle.ActiveRecord
Imports UniSource

Public Class JobStageReport

    <BelongsTo("ReportID", NotFoundBehaviour:=NotFoundBehaviour.Ignore)>
    Public Overridable Property Report As ReportManager.Report

    Public Overrides Property IsAutomatic As Boolean?
        Get
            If MyBase.IsAutomatic Is Nothing Then
                Return 0
            Else
                Return MyBase.IsAutomatic
            End If
        End Get
        Set(value As Boolean?)
            MyBase.IsAutomatic = value
        End Set
    End Property
End Class
