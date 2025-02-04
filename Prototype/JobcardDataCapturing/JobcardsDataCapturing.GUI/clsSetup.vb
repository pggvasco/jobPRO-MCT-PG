Public Class clsSetup
    Inherits UniSource.LogOn.ActiveRecord.Setup

    Shared Shadows Sub Main()
        _setup = New clsSetup
        _setup.MainForm = New UniSource.Menu.xfMain
        _setup.CallFromMain()
    End Sub

    Public Overrides Sub InitiliaseDatabase()
        MyBase.InitiliaseDatabase()
        Me.ARHelper.AddAssembly(GetType(JobCardDataCapturing.API.awJobDataCapturingHelper).Assembly)
    End Sub

    Public Function GetMenu() As UniSource.Menu.INode
        GetMenu = New UniSource.Menu.Node("Shop Floor")

        Dim ShopList As UniSource.Menu.ListNode(Of JobCardDataCapturing.API.Customer) = New UniSource.Menu.ListNode(Of JobCardDataCapturing.API.Customer)(xaeCustomer) With {.Caption = "Customer"}


        GetMenu.AddChild(New UniSource.Menu.ListNode(Of JobCardDataCapturing.API.Department)(xaeDepartment) With {.Caption = "Department"})
        GetMenu.AddChild(New UniSource.Menu.ListNode(Of JobCardDataCapturing.API.Job)(xaeJob) With {.Caption = "Job"})
        GetMenu.AddChild(New UniSource.Menu.ListNode(Of JobCardDataCapturing.API.Operation_)(xaeOperation) With {.Caption = "Operation"})

    End Function

    Public Overrides Sub InitialiseMenu()
        MyBase.InitialiseMenu()
        CType(Me.MainForm, UniSource.Menu.xfMain).MainNode = GetMenu()
        Me.MainForm.Text = "ATS2000 - Shop Floor"
        Me.MainForm.ShowIcon = False
    End Sub

    Public Overrides Sub SetTableVersions()

    End Sub

End Class
