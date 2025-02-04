
Public MustInherit Class ShopFloorTrigger(Of T)
    Inherits Helper.ActiveRecord.Trigger(Of T)

    Public Sub New(ByVal instance As T)
        MyBase.New(instance)
    End Sub

    Public Sub New(ByVal instance As T, ByVal defaults As API.Defaults)
        MyBase.New(instance)
    End Sub
    Public Property RollbackTran As Boolean

    Protected Friend Sub CallRun()
        Me.Run()
    End Sub


    Public Overrides Sub Invoke()
        Dim thread As New Threading.Thread(New Threading.ThreadStart(Sub()

                                                                         Using s As New Castle.ActiveRecord.SessionScope()
                                                                             Using t As New Castle.ActiveRecord.TransactionScope(Castle.ActiveRecord.TransactionMode.New, Castle.ActiveRecord.OnDispose.Commit)
                                                                                 Try
                                                                                     Helper.Evolution.Helper.ActivateEvolution(Setup.Settings)
                                                                                     Pastel.Evolution.DatabaseContext.BeginTran()
                                                                                     Run()
                                                                                     If RollbackTran = False Then
                                                                                         Pastel.Evolution.DatabaseContext.CommitTran()
                                                                                         'RunReport()
                                                                                     Else
                                                                                         Pastel.Evolution.DatabaseContext.RollbackTran()
                                                                                         Add("An error occured during processing, transactions have been rolled back.")
                                                                                     End If
                                                                                 Catch ex As Exception
                                                                                     'RollbackTran = True
                                                                                     't.VoteRollBack()
                                                                                     Pastel.Evolution.DatabaseContext.RollbackTran()
                                                                                     Add("An error occured during processing, transactions have been rolled back.", ex)
                                                                                 End Try
                                                                             End Using
                                                                         End Using
                                                                         Complete()
                                                                         If RollbackTran = False Then
                                                                             RunReport()
                                                                         End If
                                                                     End Sub))

        thread.Start()
    End Sub

    Protected Overrides Sub Run()

    End Sub

    Protected Overrides Sub RunReport()

    End Sub
End Class