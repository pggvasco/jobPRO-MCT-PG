Imports UniSource.Helper.ActiveRecord
Imports UniSource

Public Class xfShopFloorTriggerRunner(Of T)
    Implements IObserver(Of TriggerMessage)

    Dim FormLoaded As Boolean = False
    Private Property IsDragging As Boolean = False
    Private Property DragStartPoint As Point
    Public Property Errors As New List(Of Exception)

    Public Overridable Sub Run(ByVal record As Object, ByVal triggerType As API.Trigger)
        Select Case triggerType
            Case API.Trigger.JobToErp
                Dim trigger As New JobToErp(record)
                Me.Text = record.JobNumber
                trigger.Subscribe(Me)
                trigger.Invoke()
            Case API.Trigger.RequisitionToErp
                Dim trigger As New RequisitionToErp(record)
                Me.Text = record.Number
                trigger.Subscribe(Me)
                trigger.Invoke()
            Case API.Trigger.PurchaseOrderToErp
                Dim trigger As New PurchaseOrderToErp(record)
                Me.Text = record.OrderNumber
                trigger.Subscribe(Me)
                trigger.Invoke()
            Case API.Trigger.RenevueOneLinerToErp
                Dim trigger As New RenevueOneLinerToErp(record)
                Me.Text = record.JobNumber
                trigger.Subscribe(Me)
                trigger.Invoke()
            Case API.Trigger.JobCancelRenevueOneLinerToErp
                Dim trigger As New CancelRenevueOneLinerToErp(record)
                trigger.CancelJobStage()
                Me.Text = record.JobNumber
                trigger.Subscribe(Me)
                trigger.Invoke()


        End Select
    End Sub

    Public Sub OnCompleted() Implements System.IObserver(Of TriggerMessage).OnCompleted
        Me.Invoke(Sub()
                      If Errors.Count = 0 Then
                          Me.Close()
                      Else
                          btOK.Enabled = True
                          Me.ProgressPanel1.Caption = "Errors!"
                          Me.ProgressPanel1.Description = "Errors encountered, please check the log below."
                      End If
                  End Sub)
    End Sub

    Public Sub OnError([error] As System.Exception) Implements System.IObserver(Of TriggerMessage).OnError
        Me.Invoke(Sub()
                      Dim ex As Exception = [error]
                      While ex IsNot Nothing
                          Me.Errors.Add(ex)
                          Me.ProgressPanel1.Description = ex.Message
                          Me.MemoEdit1.Text = Now + " : " + ex.Message + vbCrLf + Me.MemoEdit1.Text
                          ex = ex.InnerException
                      End While
                  End Sub)
    End Sub

    Public Sub OnNext(value As TriggerMessage) Implements System.IObserver(Of TriggerMessage).OnNext
        Dim TryCount As Integer = 0
        Do While FormLoaded = False And TryCount <= 1000
            Threading.Thread.Sleep(10)
            TryCount += 1
        Loop
        Me.Invoke(Sub()
                      Me.ProgressPanel1.Description = value.Message
                      Me.MemoEdit1.Text = value.LogDateTime + " : " + value.Message + vbCrLf + Me.MemoEdit1.Text
                      If value.Exception IsNot Nothing Then
                          OnError(value.Exception)
                      End If
                  End Sub)
    End Sub

    Private Sub btOK_Click(sender As System.Object, e As System.EventArgs) Handles btOK.Click
        Me.Close()
    End Sub

    Private Sub xfTriggerRunner_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, ProgressPanel1.MouseDown
        IsDragging = True
        Me.DragStartPoint = e.Location
    End Sub

    Private Sub xfTriggerRunner_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, ProgressPanel1.MouseUp
        IsDragging = False
        Me.Opacity = 1
    End Sub

    Private Sub xfTriggerRunner_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, ProgressPanel1.MouseMove
        If IsDragging Then
            Me.Opacity = 0.5
            Dim p2 As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Dim p3 As Point = New Point(p2.X - Me.DragStartPoint.X, p2.Y - Me.DragStartPoint.Y)
            Me.Location = p3
        End If
    End Sub

    Private Sub xfShopFloorTriggerRunner_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FormLoaded = True
    End Sub
End Class
