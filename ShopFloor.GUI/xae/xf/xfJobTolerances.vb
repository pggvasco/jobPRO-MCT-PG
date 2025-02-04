Public Class xfJobTolerances

    Public Property CLH As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Property Job As API.Job
        Get
            Return JobBindingSource.Current
        End Get
        Set(value As API.Job)
            JobBindingSource.Clear()
            If value IsNot Nothing Then
                If value.ID > 0 Then
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        value = API.Job.Find(value.ID)
                    End Using
                End If
                JobBindingSource.Add(value)
            End If
        End Set
    End Property

    Public Sub New(ByVal job As API.Job)
        InitializeComponent()
        Me.Job = job
        If job.JobToleranceList.Count = 0 Then
            For bnd As Integer = 1 To 3
                For seq As Integer = 1 To 9
                    Dim jtol As New API.JobTolerance
                    jtol.Job = Me.Job
                    jtol.Band = bnd
                    jtol.Sequence = seq
                    Me.Job.JobToleranceList.Add(jtol)
                Next
            Next
        End If
    End Sub

    Private Sub pgcJobTolerances_EditValueChanged(sender As System.Object, e As DevExpress.XtraPivotGrid.EditValueChangedEventArgs) Handles pgcJobTolerances.EditValueChanged
        Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
        For i As Integer = 0 To ds.RowCount - 1
            ds(i)(e.DataField) = CTypeDynamic(e.Editor.EditValue, e.DataField.DataType)
        Next i
    End Sub

    Private Sub xfJobTolerances_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        bbiSave.Glyph = UniSource.Helper.GUI.My.Resources.accept
        bbiCancel.Glyph = UniSource.Helper.GUI.My.Resources.cancel
        bbiPhotographs.Glyph = UniSource.Helper.GUI.My.Resources.photos
        SetCLH()
    End Sub

    Private Sub SetCLH()
        CLH = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        CLH.Components.Add(BarManager1)
        CLH.Components.Add(pgcJobTolerances)
    End Sub

    Private Sub bbiSave_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        Try
            Save()
            Me.Close()
        Catch ex As Exception
            Setup.Log.logError("Error saving Tolerances.", ex)
        End Try
    End Sub

    Private Sub bbiCancel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
        Me.Close()
    End Sub

    Private Sub bbiPhotographs_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPhotographs.ItemClick
        Try
            ViewPhotographs()
        Catch ex As Exception
            Setup.Log.logError("Error viewing Photographs.", ex)
        End Try
    End Sub

    Private Sub Save()
        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            Job.SaveAndFlush()
        End Using
    End Sub

    Private Sub ViewPhotographs()
        Throw New NotImplementedException
    End Sub

End Class