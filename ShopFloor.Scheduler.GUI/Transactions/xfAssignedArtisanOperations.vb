Imports UniSource.Helper.GUI

Public Class xfAssignedArtisanOperations
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLU As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Property Criterion As NHibernate.Criterion.DetachedCriteria
    Public Property LookupType() As Type

#Region "Loading Events"

    Public Property Artisan As API.Artisan
        Get
            If Me.ArtisanBindingSource IsNot Nothing Then
                Return Me.ArtisanBindingSource.Current
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Artisan)
            ArtisanBindingSource.Clear()
            If value.ID > 0 Then
                Try
                    Conversation.Restart()
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        ArtisanBindingSource.DataSource = API.Artisan.Find(value.ID)
                    End Using
                Catch ex As Exception
                    Setup.Log.logError(ex.Message, ex)
                End Try
            Else
                ArtisanBindingSource.Add(value)
            End If
        End Set
    End Property

    Private Property FullScreen As Boolean = False

    Public Sub SetFullScreen()
        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
            .FullScreen = True
        End With
    End Sub

    Private Sub xfAssignedArtisanOperations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFullScreen()
        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            Dim activityList() As API.Activity = API.Activity.FindAll
        End Using

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                ArtisanActivityListBindingSource.DataSource = (From act As API.Activity In Artisan.ActivityList Where act.CurrentState <> API.ControlScan.Stop).ToList
            End Using
            SetCLH()
        Catch ex As Exception
            Setup.Log.logError("Error loading artisan operations.", ex)
        End Try
    End Sub

    Public Sub SetCLH()
        CLU = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        CLU.Components.Add(dlcArtisan)
        CLU.Components.Add(lcArtisanAssignedOperation)
        CLU.Components.Add(gvAssignedArtisanOperation)
    End Sub
#End Region

    Private Sub gvAssignedArtisanOperation_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvAssignedArtisanOperation.ValidateRow
        Dim batchDetail As API.Activity = TryCast(e.Row, API.Activity)

        If batchDetail Is Nothing Then
            Logging.Log.Log.logInfo(String.Format("There are no operations assigned to '{0}'.", Artisan.Description))
        End If
    End Sub

    Private Sub bbiCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
