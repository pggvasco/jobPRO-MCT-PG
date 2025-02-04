Public Class xfActivityQIR 

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Overridable Property Reason As API.ReasonCode
    Public Property QIRActivities As New System.ComponentModel.BindingList(Of API.Activity)

    Public Property ActiveActivity As API.Activity
        Get
            If ActivityBindingSource.Current IsNot Nothing Then
                Return CType(ActivityBindingSource.Current, API.Activity)
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Activity)
            ActivityBindingSource.Clear()
            Try
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    ActivityBindingSource.Add(API.Activity.Find(value.ID))
                End Using
            Catch ex As Exception
                Setup.Log.logError(ex.Message, ex)
            End Try
        End Set
    End Property

    Public Sub SetFullScreen()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With
    End Sub

    Public Sub SetCLH()
        CLU = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        CLU.Components.Add(lcActivityQIR)
        CLU.Components.Add(gvActivityQIR)
    End Sub

    Private Sub xfActivityQIR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFullScreen()

        Try
            For Each act As API.Activity In From a As API.Activity In ActiveActivity.Job.ActivityList Where a.Part = ActiveActivity.Part
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    QIRActivities.Add(act.GetCopy())
                End Using
            Next
            ActivityListBindingSource.DataSource = QIRActivities
        Catch ex As Exception
            Setup.Log.logError("Error creating copies for QIR Activities.", ex)
        End Try

        Try
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error setting Component Layout Helper.", ex)
        End Try
    End Sub

    Private Sub bbiSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        If UniSource.Helper.GUI.Dialog.YesNoDialog("Are you sure you want to Save?", "Save on Evolution") = Windows.Forms.DialogResult.Yes Then
            Try
                Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    For Each act As API.Activity In QIRActivities
                        act.Save()
                    Next
                End Using
            Catch ex As Exception
                Setup.Log.logError("Error saving new QIR activities.", ex)
                Exit Sub
            End Try

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub
End Class