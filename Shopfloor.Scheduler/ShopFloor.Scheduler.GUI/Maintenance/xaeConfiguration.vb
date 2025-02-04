Public Class xaeConfiguration
    Inherits xaegConfiguration
    Private ConfigurationDefaults As API.Configuration = API.Configuration.GetConfiguration
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Private Forminitialising As Boolean

    Private Sub xaeConfiguration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Forminitialising = True
        Try
            Me.Record = API.Configuration.GetConfiguration
        Catch ex As Exception
            Setup.Log.logError("Error fetching Configuration.", ex)
        End Try
        CostCentreMethodLookupEdit.Properties.DataSource = [Enum].GetValues(GetType(API.CostCentreMethod))
        RateMethodLookupEdit.Properties.DataSource = [Enum].GetValues(GetType(API.RateMethod))
        LogOffIntervalTypeLookUpEdit.Properties.DataSource = [Enum].GetValues(GetType(API.IntervalTypes))

        Forminitialising = False
    End Sub

    Private Function GetInterval(Interval As Integer, IntervalType As API.IntervalTypes) As Integer
        Dim loginterval As Integer
        Select Case IntervalType
            Case API.IntervalTypes.Seconds
                loginterval = 1000 * Interval
            Case API.IntervalTypes.Minute
                loginterval = 60000 * Interval
            Case API.IntervalTypes.Hours
                loginterval = 3600000 * Interval
            Case Else
                loginterval = 86400000 * Interval
        End Select
        Return loginterval
    End Function

    Private Sub LogOffIntervalTypeLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LogOffIntervalTypeLookUpEdit.EditValueChanged
        If Me.Forminitialising = False Then
            ConfigurationDefaults.TimerInterval = GetInterval(CType(ConfigurationDefaults.LogOffInterval, Integer), ConfigurationDefaults.LogOffIntervalType)
            ConfigurationDefaults.Save()
            TimerTextEdit.Text = ConfigurationDefaults.TimerInterval.ToString
        End If
    End Sub
    Protected Overrides Sub SaveRecord()
        MyBase.SaveRecord()
    End Sub

  
End Class


Public Class xaegConfiguration
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Configuration)
End Class
