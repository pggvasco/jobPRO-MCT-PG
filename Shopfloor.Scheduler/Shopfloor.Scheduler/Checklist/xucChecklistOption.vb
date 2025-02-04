Imports UniSource.Helper.ActiveRecord

Public Class xucChecklistOption
    Inherits xucgChecklistOption

    Public Property CLH As New UniSource.Helper.GUI.ComponentLayoutHelper
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)

    Public Property Job As API.Checklist
        Get
            If BindingSource.Current IsNot Nothing Then
                Return CType(BindingSource.Current, API.Checklist)
            End If
            Return Nothing
        End Get
        Protected Set(ByVal value As API.Checklist)
            BindingSource.Clear()
            If value IsNot Nothing Then
                If CInt(DirectCast(value, IIdentifier).ID) > 0 Then
                    Try
                        Using c As New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                            BindingSource.Add(API.Checklist.Find(DirectCast(value, IIdentifier).ID))
                        End Using
                    Catch ex As Exception
                        UniSource.Logging.Log.Log.logError(ex.Message, ex)
                    End Try
                Else
                    BindingSource.Add(value)
                End If
            End If
        End Set
    End Property
End Class

Public Class xucgChecklistOption
    Inherits UniSource.Helper.ActiveRecord.xucgInheritableLookup(Of API.ChecklistOption)

    Public Sub New()
        MyBase.New(xaeCheckListOption)
    End Sub

End Class