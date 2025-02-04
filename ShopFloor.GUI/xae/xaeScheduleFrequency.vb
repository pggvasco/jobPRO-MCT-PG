Public Class xaeScheduleFrequency
    Inherits xaegScheduleFrequency

    Private Sub xaeScheduleFrequency_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Template 
        Try
            Dim temp As New Helper.GUI.LookupBackgroundLoader(Of API.JobTemplate)(TemplateIDLookUpEdit, AddressOf LoadTemplates, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Templates.", ex)
        End Try
        'Request Type
        Try
            Dim rt As New Helper.GUI.LookupBackgroundLoader(Of API.RequestType)(RequestTypeIDLookUpEdit, AddressOf LoadRequestType, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Request Type.", ex)
        End Try
        'Enums
        Try
            LoadEnums()
        Catch ex As Exception
            Setup.Log.logError("Error populating enums.", ex)
        End Try

    End Sub
    Private Function LoadTemplates() As IEnumerable(Of API.JobTemplate)
        Return API.JobTemplate.FindAll
    End Function

    Private Function LoadRequestType() As IEnumerable(Of API.RequestType)
        Return API.RequestType.FindAll
    End Function

    Private Sub LoadEnums()
        ScheduleIDLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.ScheduleTypes))
        TypeIDLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.ScheduleFrequencyType))
    End Sub

    Private Sub SetRepeatAfterType()
        If IsDBNull(Me.ScheduleIDLookUpEdit.EditValue) = False Then
            If Me.ScheduleIDLookUpEdit.EditValue = API.ScheduleTypes.MeterBased Then
                ItemForRepeatAfter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForTypeID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ElseIf Me.ScheduleIDLookUpEdit.EditValue = API.ScheduleTypes.DateBased Then
                ItemForRepeatAfter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                ItemForTypeID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Else
                ItemForRepeatAfter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                ItemForTypeID.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If
        End If
    End Sub

    Private Sub ScheduleIDLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ScheduleIDLookUpEdit.EditValueChanged
        SetRepeatAfterType()
    End Sub
End Class
Public Class xaegScheduleFrequency
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.ScheduleFrequency)
End Class
