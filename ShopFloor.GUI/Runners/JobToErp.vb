Imports System.Data.SqlClient

Public Class JobToErp
    Inherits ShopFloorTrigger(Of API.Job)

    Private Property IsForeignCurrencyAccount As Boolean

    Private _jobcard As Pastel.Evolution.JobCard
    Protected Friend Property JobCard As Pastel.Evolution.JobCard
        Get
            If _jobcard Is Nothing And Me.Instance.JobCardID.HasValue Then
                _jobcard = New Pastel.Evolution.JobCard(Instance.JobCardID.Value)
            End If
            Return _jobcard
        End Get
        Set(value As Pastel.Evolution.JobCard)
            _jobcard = value
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Instance.JobCardID = value.ID
            End If
        End Set
    End Property

    Public Sub New(ByVal job As API.Job)
        MyBase.New(job)
    End Sub

    Protected Overrides Sub Run()
        Try
            If Not IIf(Instance.IsApproved.HasValue, Instance.IsApproved, False) Then
                Add("", New Exception("Job has not been approved."))
                Exit Sub
            End If
            If IIf(IIf(IsDBNull(Instance.JobCardID.HasValue), False, Instance.JobCardID.HasValue), Instance.JobCardID, 0) > 0 Then
                'Dim ERPJobResults As Windows.Forms.DialogResult = UniSource.Helper.GUI.Dialog.YesNoCancelDialog("Job already created on ERP" & vbCrLf & "Unlink and create new Job Card?", "Job To ERP")
                'If ERPJobResults = Windows.Forms.DialogResult.Yes Then
                '    'unlink job
                '    UniSource.Helper.GUI.Dialog.OKDialog("Remember old Job card still sits on ERP", "Job To ERP")
                '    Instance.JobCardID = Nothing
                'ElseIf ERPJobResults = Windows.Forms.DialogResult.No Then
                '    Exit Sub
                'Else
                '    Add("", New Exception(String.Format("Job has already been sent to ERP, JobCard created with ID {0}.", Instance.JobCardID)))
                'End If

                'Job Allready in ERP Top removed due to user error in creating new jobs
                Try
                    Dim ERPJobCard = New Pastel.Evolution.JobCard(Instance.JobNumber)
                    If ERPJobCard IsNot Nothing AndAlso ERPJobCard.Code = Instance.JobNumber Then
                        'Job Allready in ERP Links to ID
                        Instance.JobCardID = ERPJobCard.ID
                        Exit Sub
                    Else

                    End If
                Catch ex As Exception
                    Instance.JobCardID = 0
                End Try
            Else
                'Checks if Job With same Job No exist in ERP
                Try
                    Dim ERPJobCard = New Pastel.Evolution.JobCard(Instance.JobNumber)
                    If ERPJobCard IsNot Nothing AndAlso ERPJobCard.Code = Instance.JobNumber Then
                        'Job Allready in ERP Links to ID
                        Instance.JobCardID = ERPJobCard.ID
                        Exit Sub
                    End If
                Catch ex As Exception
                End Try
            End If

            Add(String.Format("Sending Job({0}) to ERP...", Instance.JobNumber))
            Try
                SendToErp()
            Catch ex As Exception
                Add("Error sending Job to ERP", ex)
                Throw ex
            End Try
            Add("Job sent to ERP.")

            If API.Context.Defaults.JobCardCreateBudgetLines Then
                Add("Sending Budget Lines to ERP...")
                Try
                    SendBudgetToErp()
                Catch ex As Exception
                    Add("Error sending Budget Lines to ERP.", ex)
                    If ex.InnerException IsNot Nothing Then
                        Add("InnerException: ", ex.InnerException)
                    End If
                    Throw ex
                End Try
                Add("Budget Lines sent to ERP.")
            End If


            If API.Context.Defaults.JobCardCreateRecoveryLines Then
                Add("Sending Recovery Lines to ERP...")
                Try
                    SendRecoveryToErp()
                Catch ex As Exception
                    Add("Error sending Recovery Lines to ERP.", ex)
                    Throw ex
                End Try
                Add("Recovery Lines sent to ERP.")
            End If

            If API.Context.Defaults.JobCardCreateStandardLines Then
                Add("Sending Standard Lines to ERP...")
                Try
                    SendStandardToErp()
                Catch ex As Exception
                    Add("Error sending Standard Lines to ERP.", ex)
                    Throw ex
                End Try
                Add("Standard Lines sent to ERP.")
            End If

            Try
                UpdateAssetUsage()
            Catch ex As Exception
                Add("Error Updating Asset Usage.", ex)
                Throw ex
            End Try
        Catch ex As Exception
            Add("", New Exception(String.Format("Error sending Job To Erp. {0}", ex.Message)))
            RollbackTran = True

        End Try
    End Sub

    Private Sub UpdateAssetUsage()
        Dim AllLinesUsageCaptured As Boolean = True

        'Go through all lines and check
        For Each jl As API.JobLine In Instance.JobLines
            AllLinesUsageCaptured = True

            If jl.WorkCentre.UsageRequired IsNot Nothing Then
                If (jl.WorkCentre.UsageRequired = True) AndAlso (jl.PrimaryAssetUsage <= 0 Or jl.PrimaryAssetUsage Is Nothing) Then
                    Throw New Exception("Error: Please capture all Usage Values for required Work Centres")
                    AllLinesUsageCaptured = False
                End If
            End If

        Next

        If AllLinesUsageCaptured AndAlso Instance.JobLines.Count > 0 Then

            ' This code is seperated into each asset to simply avoid confusion
            Dim TotalUsage As Double = 0
            Dim TotalUsage2 As Double = 0
            Dim TotalUsage3 As Double = 0
            Dim TotalUsage4 As Double = 0
            Dim TotalUsage5 As Double = 0

            Dim Asset2TotalUsage As Double = 0
            Dim Asset2TotalUsage2 As Double = 0
            Dim Asset2TotalUsage3 As Double = 0
            Dim Asset2TotalUsage4 As Double = 0
            Dim Asset2TotalUsage5 As Double = 0

            Dim Equip1Asset As New API.Asset
            Dim Equip2Asset As New API.Asset
            Dim Equip3Asset As New API.Asset
            Dim Equip4Asset As New API.Asset
            Dim Equip5Asset As New API.Asset

            Dim Asset1UsageDifference As Double = 0


            If Instance.EquipamentoNo1 IsNot Nothing Then
                If Instance.EquipamentoNo1 > 0 Then
                    Equip1Asset = UniSource.ShopFloor.API.Asset.Find(Instance.EquipamentoNo1)
                End If
            End If

            If Instance.EquipamentoNo2 IsNot Nothing Then
                If Instance.EquipamentoNo2 > 0 Then
                    Equip2Asset = UniSource.ShopFloor.API.Asset.Find(Instance.EquipamentoNo2)
                End If
            End If

            If Instance.EquipamentoNo3 IsNot Nothing Then
                If Instance.EquipamentoNo3 > 0 Then
                    Equip3Asset = UniSource.ShopFloor.API.Asset.Find(Instance.EquipamentoNo3)
                End If
            End If

            If Instance.EquipamentoNo4 IsNot Nothing Then
                If Instance.EquipamentoNo4 > 0 Then
                    Equip4Asset = UniSource.ShopFloor.API.Asset.Find(Instance.EquipamentoNo4)
                End If
            End If

            If Instance.EquipamentoNo5 IsNot Nothing Then
                If Instance.EquipamentoNo5 > 0 Then
                    Equip5Asset = UniSource.ShopFloor.API.Asset.Find(Instance.EquipamentoNo5)
                End If
            End If

            For Each jl As API.JobLine In Instance.JobLines

                If Instance.EquipamentoNo1 IsNot Nothing Then
                    If jl.AssetID = Instance.EquipamentoNo1 Then
                        'TotalUsage = TotalUsage + Convert.ToDouble(jl.PrimaryAssetUsage)
                        If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage Then
                            TotalUsage = Convert.ToDouble(jl.PrimaryAssetUsage)
                        End If
                    End If

                    If jl.Asset2ID = Instance.EquipamentoNo1 Then
                        If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage Then
                            Asset2TotalUsage = Convert.ToDouble(jl.Asset2Usage)
                        End If
                    End If

                End If

                If Instance.EquipamentoNo2 IsNot Nothing Then
                    If jl.AssetID = Instance.EquipamentoNo2 Then

                        If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage2 Then
                            TotalUsage2 = Convert.ToDouble(jl.PrimaryAssetUsage)
                        End If
                    End If

                    If jl.Asset2ID = Instance.EquipamentoNo2 Then
                        If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage2 Then
                            Asset2TotalUsage2 = Convert.ToDouble(jl.Asset2Usage)
                        End If

                    End If
                End If

                If Instance.EquipamentoNo3 IsNot Nothing Then
                    If jl.AssetID = Instance.EquipamentoNo3 Then

                        If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage3 Then
                            TotalUsage3 = Convert.ToDouble(jl.PrimaryAssetUsage)
                        End If

                    End If

                    If jl.Asset2ID = Instance.EquipamentoNo3 Then

                        If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage3 Then
                            Asset2TotalUsage3 = Convert.ToDouble(jl.Asset2Usage)
                        End If
                    End If

                End If

                If Instance.EquipamentoNo4 IsNot Nothing Then
                    If jl.AssetID = Instance.EquipamentoNo4 Then

                        If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage4 Then
                            TotalUsage4 = Convert.ToDouble(jl.PrimaryAssetUsage)
                        End If

                    End If

                    If jl.Asset2ID = Instance.EquipamentoNo4 Then

                        If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage4 Then
                            Asset2TotalUsage4 = Convert.ToDouble(jl.Asset2Usage)
                        End If

                    End If

                End If


                If Instance.EquipamentoNo5 IsNot Nothing Then
                    If jl.AssetID = Instance.EquipamentoNo5 Then

                        If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage5 Then
                            TotalUsage5 = Convert.ToDouble(jl.PrimaryAssetUsage)
                        End If

                    End If

                    If jl.Asset2ID = Instance.EquipamentoNo5 Then
                        If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage5 Then
                            Asset2TotalUsage5 = Convert.ToDouble(jl.Asset2Usage)
                        End If

                    End If
                End If

            Next

            '     Instance.KMPercorridos = (TotalUsage + TotalUsage2 + TotalUsage3 + TotalUsage4 + TotalUsage5


            'Usage is the Assets Odometer reading so we cannot add the totals we can only choose the highest in the Job Card
            'This portion must not update if the TotalUsage is less than the current Instance.Eq1TotalUsage
            'So in the screen we should only allow for a 0 value to be entered but anything else must be greater than the Usage Before on the Job
            'The Asset2 values is the second dropdown from the screen- 1 is primary other is Secondary so i cater for both
            'something like this  Eq1UsageBefore 
            If (TotalUsage > Instance.Eq1UsageBefore Or Asset2TotalUsage > Instance.Eq1UsageBefore) Then

                Equip1Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage > Asset2TotalUsage, TotalUsage, Asset2TotalUsage))     ' TotalUsage + Asset2TotalUsage
                Equip1Asset.SaveAndFlush()

            End If

            If (TotalUsage > Instance.Eq2UsageBefore Or Asset2TotalUsage2 > Instance.Eq2UsageBefore) Then
                Equip2Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage2 > Asset2TotalUsage2, TotalUsage2, Asset2TotalUsage2))  ' TotalUsage2 + Asset2TotalUsage2
                Equip2Asset.SaveAndFlush()
            End If
           
            If (TotalUsage > Instance.Eq3UsageBefore Or Asset2TotalUsage3 > Instance.Eq3UsageBefore) Then
                Equip3Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage3 > Asset2TotalUsage3, TotalUsage3, Asset2TotalUsage3))  'TotalUsage3 + Asset2TotalUsage3
                Equip3Asset.SaveAndFlush()
            End If

            If (TotalUsage > Instance.Eq4UsageBefore Or Asset2TotalUsage4 > Instance.Eq4UsageBefore) Then
                Equip4Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage4 > Asset2TotalUsage4, TotalUsage4, Asset2TotalUsage4))  ' TotalUsage4 + Asset2TotalUsage4
                Equip4Asset.SaveAndFlush()
            End If

            If (TotalUsage > Instance.Eq5UsageBefore Or Asset2TotalUsage5 > Instance.Eq5UsageBefore) Then
                Equip5Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage5 > Asset2TotalUsage5, TotalUsage5, Asset2TotalUsage5))  'TotalUsage5 + Asset2TotalUsage5
                Equip5Asset.SaveAndFlush()
            End If

            'Dim TotalUsagebefore As Double = (Instance.Job.Eq1UsageBefore + Instance.Job.Eq2UsageBefore + Instance.Job.Eq3UsageBefore + Instance.Job.Eq4UsageBefore + Instance.Job.Eq5UsageBefore)
            'Dim TotalUsageAfter As Double = (TotalUsage + TotalUsage2 + TotalUsage3 + TotalUsage4 + TotalUsage5)

            Instance.Eq1TotalUsage = Equip1Asset.TotalUsage - Instance.Eq1UsageBefore


            Instance.Eq2TotalUsage = Equip2Asset.TotalUsage - Instance.Eq2UsageBefore


            Instance.Eq3TotalUsage = Equip3Asset.TotalUsage - Instance.Eq3UsageBefore


            Instance.Eq4TotalUsage = Equip4Asset.TotalUsage - Instance.Eq4UsageBefore


            Instance.Eq5TotalUsage = Equip5Asset.TotalUsage - Instance.Eq5UsageBefore


            Instance.KMPercorridos = Instance.Eq1TotalUsage + Instance.Eq2TotalUsage + Instance.Eq3TotalUsage + Instance.Eq4TotalUsage + Instance.Eq5TotalUsage
            'Why was this commented
            'Instance.SaveAndFlush()

        End If

    End Sub

    Public Overridable Sub SendToErp()
        If Not API.Context.Defaults.ERPIntegrationMethod = API.ERPIntegrationMethod.JobCard Then Exit Sub
        'Tawanda 
        '09/04/2020
        'Try
        '    'check via SDK for that record in JctxLines
        '    Dim ids As Long = Instance.JobCardID
        '    JobCard = New Pastel.Evolution.JobCard

        '    Add("", New Exception(String.Format("ERP JobCard has already been created.", Instance.JobCardID)))
        '    Exit Sub
        'Catch ex As Exception
        '    Instance.JobCardID = 0
        'End Try
        'Tawanda Checks

        Try
            Dim ERPJobCard = New Pastel.Evolution.JobCard(Instance.JobNumber)
            If ERPJobCard IsNot Nothing AndAlso ERPJobCard.Code = Instance.JobNumber Then
                'Job Allready in ERP Links to ID
                Throw New Exception("ERP JobCard has already been created.")
            End If
        Catch ex As Exception
            'Throw New Exception("ERP JobCard has already been created.")
        End Try


        If Instance.JobCardID > 0 Then
            Throw New Exception("ERP JobCard has already been created.")
        End If

            JobCard = New Pastel.Evolution.JobCard


            With JobCard
                .Account = New Pastel.Evolution.Customer(CInt(Instance.Customer.ID))

            Try

                .Started = Instance.JobDate
                .DeliveryDate = Instance.JobDate
                .CompletionDate = Instance.JobDate
                .ClosingDate = Instance.JobDate
            Catch ex As Exception
            End Try


                Dim PrimaryWorkCentreDescription As String = "zzzzz"
                For Each jl As API.JobLine In Instance.JobLines
                    If jl.WorkCentre.PrimaryService Then
                        If jl.Description1.Length > 40 Then
                            PrimaryWorkCentreDescription = jl.Description1.Substring(0, 40)
                        Else
                            PrimaryWorkCentreDescription = jl.Description1
                        End If

                        .Description = PrimaryWorkCentreDescription
                        Instance.Description1 = PrimaryWorkCentreDescription

                        Try
                            Instance.DistanciaSTD = Convert.ToDouble(jl.WorkCentre.DefaultUsage)
                            Instance.KMAutorizado = Convert.ToDouble(jl.WorkCentre.ApprovedUsage)
                        Catch ex As Exception
                            Instance.DistanciaSTD = 0
                            Instance.KMAutorizado = 0
                        End Try
                        Instance.SaveAndFlush()
                        Exit For
                    End If
                Next


                .Code = Instance.JobNumber


                If Instance.Description1 IsNot Nothing And PrimaryWorkCentreDescription = "zzzzz" Then
                    If Instance.Description1.Length > 40 Then
                        .Description = Instance.Description1.Substring(0, 40)
                    Else
                        .Description = Instance.Description1
                    End If
                End If

                If Instance.OrderNumber IsNot Nothing Then
                    .ExtOrderNo = Instance.OrderNumber
                End If

                .Code = Instance.JobNumber
                .DeliverTo = .Account.PhysicalAddress
                .InvoiceTo = .Account.PostalAddress
                .Status = Pastel.Evolution.JobCard.JobStatus.Active



                If Instance.RepresentativeID IsNot Nothing Then
                    .SalesRepresentativeID = Instance.RepresentativeID
                End If

                'User Def Fields
                Try
                    .UserFields("ubJCMaintRep") = IIf(Instance.Maintenance_Repair Is Nothing Or IsDBNull(Instance.Maintenance_Repair) = True, False, True)
                Catch ex As Exception
                End Try

                'Try
                '    If Instance.WorkCentreCategory IsNot Nothing Then
                '        .UserFields("ucJCJobProCategory") = Instance.WorkCentreCategory.Code
                '    End If
                '    If Instance.TotalPrice IsNot Nothing Then
                '        .UserFields("ufJCJobProPrice") = Instance.TotalPrice
                '    End If
                '    If Instance.CostCentre IsNot Nothing Then
                '        .UserFields("ucJCJobProCostCentre") = Instance.CostCentre.Code
                '    End If
                'Catch ex As Exception
                'End Try
                .Save()

                If .Account.IsForeignCurrencyAccount Then
                    IsForeignCurrencyAccount = True
                End If

            End With

            Instance.JobCardID = JobCard.ID


            'If IsForeignCurrencyAccount Then
            '    Dim MyAppCon As SqlConnection = New SqlConnection(ShopFloor.API.ActiveConnection.Company.ConnectionString)
            '    Try
            '        MyAppCon.Open()

            '        Dim cmd As New SqlCommand
            '        Dim cmd2 As New SqlCommand

            '        Dim query1 As String = "Update [dbo].[_btblJCMaster] set iCurrencyID = " & New Pastel.Evolution.Customer(CInt(Instance.Customer.ID)).CurrencyID & " where IdJCMaster =" & Instance.JobCardID
            '        cmd = New SqlCommand(query1, MyAppCon)
            '        cmd.ExecuteNonQuery()
            '        Add("Foreign Currency Set")
            '    Catch ex As Exception
            '        Add("Error update Currency for Job Card- " & ex.Message)
            '    End Try
            '    MyAppCon.Close()
            'End If



    End Sub

    Public Overridable Sub SendBudgetToErp()
        If Not API.Context.Defaults.ERPIntegrationMethod = API.ERPIntegrationMethod.JobCard AndAlso Not API.Context.Defaults.JobCardCreateBudgetLines Then Exit Sub

        If JobCard Is Nothing Then
            Throw New Exception("ERP JobCard not yet created for processing Budget lines.")
        End If

        For Each line As API.JobLine In Instance.JobLines
            Using t As New BudgetLinesToErp(line, JobCard, API.Context.Defaults)
                t.Subscribe(Me)
                t.CallRun()
            End Using
        Next line

    End Sub

    Public Overridable Sub SendRecoveryToErp()
        If Not API.Context.Defaults.ERPIntegrationMethod = API.ERPIntegrationMethod.JobCard AndAlso Not API.Context.Defaults.JobCardCreateRecoveryLines Then Exit Sub

        If JobCard Is Nothing Then
            Throw New Exception("ERP JobCard not yet created for processing Recovery lines.")
        End If

        ' Dim JLTest As API.JobLine = Instance.JobLines

        For Each line As API.JobLine In (From jl As API.JobLine In Instance.JobLines Where jl.WorkCentre IsNot Nothing AndAlso (jl.WorkCentre.CalculationType = API.CalculationType.Recovery OrElse jl.InventoryItem.ServiceItem = True) AndAlso (jl.WorkCentre.IsBuyOut Is Nothing OrElse Not jl.WorkCentre.IsBuyOut))
            Using t As New RecoveryLinesToErp(line, JobCard, API.Context.Defaults)
                t.Subscribe(Me)
                t.CallRun()
            End Using
        Next line

    End Sub


    Public Overridable Sub SendStandardToErp()
        If Not API.Context.Defaults.ERPIntegrationMethod = API.ERPIntegrationMethod.JobCard AndAlso Not API.Context.Defaults.JobCardCreateRecoveryLines Then Exit Sub

        If JobCard Is Nothing Then
            Throw New Exception("ERP JobCard not yet created for processing Standard lines.")
        End If

        For Each line As API.JobLine In (From jl As API.JobLine In Instance.JobLines Where jl.WorkCentre IsNot Nothing AndAlso (jl.WorkCentre.CalculationType = API.CalculationType.Standard OrElse jl.InventoryItem.ServiceItem = True) AndAlso (jl.WorkCentre.IsBuyOut Is Nothing OrElse Not jl.WorkCentre.IsBuyOut))
            Dim t As New StandardLinetoERP(line, JobCard, API.Context.Defaults)
            t.SendStandardLinetoERP()

            'Using t As New StandardLinetoERP(line, JobCard, API.Context.Defaults)
            '    t.Subscribe(Me)
            '    t.CallRun()
            'End Using
        Next line

    End Sub

    Protected Overrides Sub RunReport()

    End Sub

End Class
