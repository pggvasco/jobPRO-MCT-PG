Public Class xaeOperation
    Inherits xaegOperation

    Public Property Operation As API.Operation
        Get
            If Me.BindingSource IsNot Nothing Then
                Return Me.BindingSource.Current
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.Operation)
            BindingSource.Clear()
            If value.ID > 0 Then
                Try
                    Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                        BindingSource.DataSource = API.Operation.Find(value.ID)
                    End Using
                Catch ex As Exception
                    Setup.Log.logError(ex.Message, ex)
                End Try
            Else
                BindingSource.Add(value)
            End If
        End Set
    End Property

    Private Sub xaeOperation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                CostCentreBindingSource.DataSource = API.CostCentre.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Cost Centres.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                ChecklistBindingSource.DataSource = Checklist.API.Checklist.FindAll
            End Using
        Catch ex As Exception
            Setup.Log.logError("Error fetching Checklists.", ex)
        End Try

        Try
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                ArtisanBindingSource.DataSource = API.Artisan.FindAll
                For Each cl As API.Artisan In ArtisanBindingSource.DataSource
                    For Each cl2 As API.Artisan In CType(Me.Record, API.Operation).Artisans
                        If cl = cl2 Then
                            clbcArtisanChecklist.SetItemChecked(ArtisanBindingSource.IndexOf(cl), True)
                        End If
                    Next
                Next
            End Using
            
        Catch ex As Exception
            Setup.Log.logError("Error fetching Checklist.", ex)
        End Try
    End Sub

    Private Sub clbcChecklist_ItemCheck(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbcArtisanChecklist.ItemCheck
        If e.State = Windows.Forms.CheckState.Checked Then
            If Not CType(Me.Record, API.Operation).Artisans.Contains(clbcArtisanChecklist.GetItem(e.Index)) Then
                CType(Me.Record, API.Operation).Artisans.Add(clbcArtisanChecklist.GetItem(e.Index))
            End If
        Else
            If CType(Me.Record, API.Operation).Artisans.Contains(clbcArtisanChecklist.GetItem(e.Index)) Then
                CType(Me.Record, API.Operation).Artisans.Remove(clbcArtisanChecklist.GetItem(e.Index))
            End If
        End If
    End Sub

    Private Sub luChecklist_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luChecklist.EditValueChanged
        If ChecklistBindingSource IsNot Nothing Then
            Operation.Checklist = CType(luChecklist.EditValue, Checklist.API.Checklist)
            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                Operation.Checklist.SaveAndFlush()
            End Using
        End If
    End Sub
End Class

Public Class xaegOperation
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.Operation)
End Class
