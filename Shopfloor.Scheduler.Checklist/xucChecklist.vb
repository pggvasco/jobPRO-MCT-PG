Public Class xucChecklist

    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Property Checklist As API.Checklist
        Get
            Return CType(ChecklistBindingSource.Current, API.Checklist)
        End Get
        Private Set(ByVal value As API.Checklist)
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                ChecklistBindingSource.DataSource = value
            End Using
        End Set
    End Property

    Public Property Log As API.ChecklistLog
        Get
            Return CType(ChecklistLogBindingSource.Current, API.ChecklistLog)
        End Get
        Set(ByVal value As API.ChecklistLog)
            Using New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                ChecklistLogBindingSource.DataSource = value
            End Using
        End Set
    End Property

    Public Sub New(ByVal checklist As API.Checklist)
        InitializeComponent()
        Me.Checklist = checklist
        Me.Log = New API.ChecklistLog With {.Checklist = Me.Checklist, .StartDateTime = Now, .AgentID = Setup.Agent.ID, .AgentName = Setup.Agent.Name}
        AddOptions()
    End Sub

    Public Property checklistoptions As New List(Of xucChecklistOption)

    Private Sub AddOptions()
        If Checklist IsNot Nothing Then
            Dim previousItem As DevExpress.XtraLayout.LayoutControlItem
            For Each co As API.ChecklistOption In (From cco As API.ChecklistChecklistOption In Checklist.ChecklistOption Order By cco.Sequence Select cco.ChecklistOption)
                Dim xuco As New xucChecklistOption(co)
                Dim lci As DevExpress.XtraLayout.LayoutControlItem
                If previousItem IsNot Nothing Then
                    lci = Root.AddItem(co.Description, xuco, previousItem, DevExpress.XtraLayout.Utils.InsertType.Bottom)
                Else
                    lci = Root.AddItem(co.Description, xuco)
                End If

                lci.AppearanceItemCaption.Font = New Font(lci.AppearanceItemCaption.Font.FontFamily, lci.AppearanceItemCaption.Font.Size * 1.5)

                If co.DataTypeID = API.Datatype.Boolean Then
                    lci.TextVisible = False
                End If
                previousItem = lci
                checklistoptions.Add(xuco)
            Next
            If previousItem IsNot Nothing Then
                Root.AddItem(New DevExpress.XtraLayout.EmptySpaceItem, previousItem, DevExpress.XtraLayout.Utils.InsertType.Bottom)
            End If
        End If
    End Sub


    Public Event DoneClick()

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        If ValidateChecklist() Then

            Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                For Each co In checklistoptions
                    Log.ChecklistOptionLogs.Add(co.Log)
                Next
                Log.EndDateTime = Now
                Log.Save()
            End Using

            RaiseEvent DoneClick()
        Else
            UniSource.Logging.Log.Log.logWarn("Please verify and fix the Checklist errors before proceeding.")
        End If
    End Sub

    Public Function ValidateChecklist() As Boolean
        Dim validated As Boolean = True
        Try
            For Each item As xucChecklistOption In checklistoptions
                If item.Option.IsForceValue Then
                    If item.EditValue IsNot Nothing Then
                    Else
                        item.ErrorText = "Please complete, this is a required option."
                        validated = False
                    End If
                    If Not String.IsNullOrEmpty(item.Option.RequiredValue) Then
                        If item.EditValue = item.Option.RequiredValue Then
                        Else
                            item.ErrorText = "Please complete, this is not the required option."
                            validated = False
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            UniSource.Logging.Log.Log.logError("Error validating Checklist.", ex)
        End Try

        Return validated
    End Function

End Class
