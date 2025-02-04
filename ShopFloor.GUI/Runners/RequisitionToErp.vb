Imports DevExpress.XtraReports.UI
Public Class RequisitionToErp
    Inherits ShopFloorTrigger(Of API.Requisition)

    Private _requisition As Pastel.Evolution.JobCard
    Protected Friend Property Requisition As Pastel.Evolution.JobCard
        Get
            If _requisition Is Nothing And Me.Instance.ERPRequisitionID.HasValue Then
                ' not working as it wants a long(int64)
                _requisition = New Pastel.Evolution.JobCard(Me.Instance.ERPRequisitionID.Value)
                '_requisition = New Pastel.Evolution.JobCard(Me.Instance.Job.JobNumber)
            End If
            Return _requisition
        End Get
        Set(ByVal value As Pastel.Evolution.JobCard)
            _requisition = value
            If value IsNot Nothing AndAlso value.ID > 0 Then
                Instance.ERPRequisitionID = value.ID
            End If
        End Set
    End Property
    Public Sub New(ByVal req As API.Requisition)
        MyBase.New(req)
    End Sub

    Protected Overrides Sub Run()
        Try
            If UniSource.Helper.GUI.Dialog.YesNoDialog("Warning" & vbCrLf & "Please confirm that all Asset Usage has been updated before continuing?") = Windows.Forms.DialogResult.Yes Then
                SendRequisitionToERP()

            Else
                RollbackTran = True

                Throw New Exception("Error locating ERP JobCard when posting Requisition.")
            End If

           
        Catch ex As Exception
            Add("", New Exception(String.Format("Error sending Requisition To Erp. {0}", ex.Message)))
            RollbackTran = True

        End Try

      
    End Sub

    Public Overridable Sub SendRequisitionToERP()

        If Not API.Context.Defaults.JobCardCreateRequisitionLines Then Exit Sub
        Add(String.Format("Sending Job({0}) Requisition to ERP...", Instance.Job.JobNumber))
        If Instance.ERPRequisitionID > 0 Then
            Throw New Exception("ERP JobCard has already been created.")
        Else
            If Me.Instance.Job IsNot Nothing AndAlso Instance.Job.JobCardID IsNot Nothing Then
                Instance.ERPRequisitionID = Instance.Job.JobCardID
            Else
                Throw New Exception("ERP JobCard not linked or ERP JobCard not yet created.")
            End If
        End If

        'Checks if Job is still active
        'Try
        'Dim ERPJobCard = New Pastel.Evolution.JobCard(CType(Instance.Job.JobCardID, Integer))
        'Checks if ERP Job is still active

        Dim ERPJobCard
        Try
            ERPJobCard = New Pastel.Evolution.JobCard(CType(Instance.Job.JobCardID, Integer))
            'Checks if ERP Job is still active
            If ERPJobCard.Status = 2 Then ' Pastel.Evolution.JobStatus.Completed Then
                Throw New Exception("Error ERP JobCard is not active.")


            End If
        Catch ex As Exception
            '  Dim Conversation As Castle.ActiveRecord.ScopedConversation = New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
            '  Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            Instance.Job.JobCardID = 0

            'End Using

            Dim xftr As New xfShopFloorTriggerRunner(Of API.Job)
            xftr.Run(Instance.Job, 0)
            xftr.ShowDialog()

            If xftr.Errors.Count > 0 Then
                Dim ss As String = ""
                For Each Val As Exception In xftr.Errors.ToArray
                    ss = ss & vbCrLf & Val.Message
                Next
                'Throw New Exception(vbCrLf & vbCrLf & vbCrLf & "Portuguese Error Message" & vbCrLf & ss)
                Throw New Exception(vbCrLf & vbCrLf & vbCrLf & "Requisição -Processo incompleto" & vbCrLf & ss)
            End If
            RollbackTran = True
        End Try
        'If ERPJobCard.Status = 2 Then ' Pastel.Evolution.JobStatus.Completed Then
        '    Throw New Exception("Error ERP JobCard is not active.")
        'End If

        'Catch ex As Exception
        'Throw New Exception("Error Checking ERP JobCard Status.")
        'End Try



        Try
            Dim AllLinesUsageCaptured As Boolean = True

            'Go through all lines and check
            For Each jl As API.JobLine In Instance.Job.JobLines
                AllLinesUsageCaptured = True

                If jl.WorkCentre.UsageRequired IsNot Nothing Then
                    If (jl.WorkCentre.UsageRequired = True) AndAlso (jl.PrimaryAssetUsage <= 0 Or jl.PrimaryAssetUsage Is Nothing) Then
                        Throw New Exception("Error: Please capture all Usage Values for required Work Centres")
                        AllLinesUsageCaptured = False
                    End If
                End If

            Next

            If AllLinesUsageCaptured Then
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

                If Instance.Job.EquipamentoNo1 IsNot Nothing Then
                    If Instance.Job.EquipamentoNo1 > 0 Then
                        Equip1Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo1)
                    End If
                End If

                If Instance.Job.EquipamentoNo2 IsNot Nothing Then
                    If Instance.Job.EquipamentoNo2 > 0 Then
                        Equip2Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo2)
                    End If

                End If

                If Instance.Job.EquipamentoNo3 IsNot Nothing Then
                    If Instance.Job.EquipamentoNo3 > 0 Then
                        Equip3Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo3)
                    End If
                End If

                If Instance.Job.EquipamentoNo4 IsNot Nothing Then
                    If Instance.Job.EquipamentoNo4 > 0 Then
                        Equip4Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo4)
                    End If
                End If

                If Instance.Job.EquipamentoNo5 IsNot Nothing Then
                    If Instance.Job.EquipamentoNo5 > 0 Then
                        Equip5Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo5)
                    End If
                End If


                For Each jl As API.JobLine In Instance.Job.JobLines

                    If Instance.Job.EquipamentoNo1 IsNot Nothing Then
                        If jl.AssetID = Instance.Job.EquipamentoNo1 Then
                            'TotalUsage = TotalUsage + Convert.ToDouble(jl.PrimaryAssetUsage)
                            If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage Then
                                TotalUsage = Convert.ToDouble(jl.PrimaryAssetUsage)
                            End If
                        End If

                        If jl.Asset2ID = Instance.Job.EquipamentoNo1 Then
                            If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage Then
                                Asset2TotalUsage = Convert.ToDouble(jl.Asset2Usage)
                            End If
                        End If

                    End If

                    If Instance.Job.EquipamentoNo2 IsNot Nothing Then
                        If jl.AssetID = Instance.Job.EquipamentoNo2 Then

                            If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage2 Then
                                TotalUsage2 = Convert.ToDouble(jl.PrimaryAssetUsage)
                            End If
                        End If

                        If jl.Asset2ID = Instance.Job.EquipamentoNo2 Then
                            If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage2 Then
                                Asset2TotalUsage2 = Convert.ToDouble(jl.Asset2Usage)
                            End If

                        End If
                    End If

                    If Instance.Job.EquipamentoNo3 IsNot Nothing Then
                        If jl.AssetID = Instance.Job.EquipamentoNo3 Then

                            If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage3 Then
                                TotalUsage3 = Convert.ToDouble(jl.PrimaryAssetUsage)
                            End If

                        End If

                        If jl.Asset2ID = Instance.Job.EquipamentoNo3 Then

                            If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage3 Then
                                Asset2TotalUsage3 = Convert.ToDouble(jl.Asset2Usage)
                            End If
                        End If

                    End If

                    If Instance.Job.EquipamentoNo4 IsNot Nothing Then
                        If jl.AssetID = Instance.Job.EquipamentoNo4 Then

                            If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage4 Then
                                TotalUsage4 = Convert.ToDouble(jl.PrimaryAssetUsage)
                            End If

                        End If

                        If jl.Asset2ID = Instance.Job.EquipamentoNo4 Then

                            If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage4 Then
                                Asset2TotalUsage4 = Convert.ToDouble(jl.Asset2Usage)
                            End If

                        End If

                    End If


                    If Instance.Job.EquipamentoNo5 IsNot Nothing Then
                        If jl.AssetID = Instance.Job.EquipamentoNo5 Then

                            If Convert.ToDouble(jl.PrimaryAssetUsage) > TotalUsage5 Then
                                TotalUsage5 = Convert.ToDouble(jl.PrimaryAssetUsage)
                            End If

                        End If

                        If jl.Asset2ID = Instance.Job.EquipamentoNo5 Then
                            If Convert.ToDouble(jl.Asset2Usage) > Asset2TotalUsage5 Then
                                Asset2TotalUsage5 = Convert.ToDouble(jl.Asset2Usage)
                            End If

                        End If
                    End If

                Next
                '     Instance.KMPercorridos = (TotalUsage + TotalUsage2 + TotalUsage3 + TotalUsage4 + TotalUsage5
                'Usage is the Assets Odometer reading so we cannot add the totals we can only choose the highest in the Job Card
                If Equip1Asset.Asset IsNot Nothing Then
                    Equip1Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage > Asset2TotalUsage, TotalUsage, Asset2TotalUsage))       ' TotalUsage + Asset2TotalUsage
                    Equip1Asset.SaveAndFlush()
                End If
                If Equip2Asset.Asset IsNot Nothing Then
                    Equip2Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage2 > Asset2TotalUsage2, TotalUsage2, Asset2TotalUsage2))   ' TotalUsage2 + Asset2TotalUsage2
                    Equip2Asset.SaveAndFlush()
                End If
                If Equip3Asset.Asset IsNot Nothing Then
                    Equip3Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage3 > Asset2TotalUsage3, TotalUsage3, Asset2TotalUsage3))  'TotalUsage3 + Asset2TotalUsage3
                    Equip3Asset.SaveAndFlush()
                End If
                If Equip4Asset.Asset IsNot Nothing Then
                    Equip4Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage4 > Asset2TotalUsage4, TotalUsage4, Asset2TotalUsage4)) ' TotalUsage4 + Asset2TotalUsage4
                    Equip4Asset.SaveAndFlush()
                End If
                If Equip5Asset.Asset IsNot Nothing Then
                    Equip5Asset.TotalUsage = Convert.ToDouble(IIf(TotalUsage5 > Asset2TotalUsage5, TotalUsage5, Asset2TotalUsage5))  'TotalUsage5 + Asset2TotalUsage5
                    Equip5Asset.SaveAndFlush()
                End If

                '      Dim TotalUsagebefore As Double = (Instance.Job.Eq1UsageBefore + Instance.Job.Eq2UsageBefore + Instance.Job.Eq3UsageBefore + Instance.Job.Eq4UsageBefore + Instance.Job.Eq5UsageBefore)
                '     Dim TotalUsageAfter As Double = (TotalUsage + TotalUsage2 + TotalUsage3 + TotalUsage4 + TotalUsage5)


                Instance.Job.Eq1TotalUsage = Equip1Asset.TotalUsage - Instance.Job.Eq1UsageBefore


                Instance.Job.Eq2TotalUsage = Equip2Asset.TotalUsage - Instance.Job.Eq2UsageBefore


                Instance.Job.Eq3TotalUsage = Equip3Asset.TotalUsage - Instance.Job.Eq3UsageBefore


                Instance.Job.Eq4TotalUsage = Equip4Asset.TotalUsage - Instance.Job.Eq4UsageBefore


                Instance.Job.Eq5TotalUsage = Equip5Asset.TotalUsage - Instance.Job.Eq5UsageBefore

                Instance.Job.KMPercorridos = Instance.Job.Eq1TotalUsage + Instance.Job.Eq2TotalUsage + Instance.Job.Eq3TotalUsage + Instance.Job.Eq4TotalUsage + Instance.Job.Eq5TotalUsage


                '' This code is seperated into each asset to simply avoid confusion
                'Dim TotalUsage As Double = 0
                'Dim TotalUsage2 As Double = 0
                'Dim TotalUsage3 As Double = 0
                'Dim TotalUsage4 As Double = 0
                'Dim TotalUsage5 As Double = 0

                'Dim Asset2TotalUsage As Double = 0
                'Dim Asset2TotalUsage2 As Double = 0
                'Dim Asset2TotalUsage3 As Double = 0
                'Dim Asset2TotalUsage4 As Double = 0
                'Dim Asset2TotalUsage5 As Double = 0

                'Dim Equip1Asset As New API.Asset
                'Dim Equip2Asset As New API.Asset
                'Dim Equip3Asset As New API.Asset
                'Dim Equip4Asset As New API.Asset
                'Dim Equip5Asset As New API.Asset

                'If Instance.Job.EquipamentoNo1 IsNot Nothing Then
                '    Equip1Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo1)
                'End If

                'If Instance.Job.EquipamentoNo2 IsNot Nothing Then
                '    Equip2Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo2)
                'End If

                'If Instance.Job.EquipamentoNo3 IsNot Nothing Then
                '    Equip3Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo3)
                'End If

                'If Instance.Job.EquipamentoNo4 IsNot Nothing Then
                '    Equip4Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo4)
                'End If

                'If Instance.Job.EquipamentoNo5 IsNot Nothing Then
                '    Equip5Asset = UniSource.ShopFloor.API.Asset.Find(Instance.Job.EquipamentoNo5)
                'End If

                'For Each jl As API.JobLine In Instance.Job.JobLines

                '    If Instance.Job.EquipamentoNo1 IsNot Nothing Then
                '        If jl.AssetID = Instance.Job.EquipamentoNo1 Then
                '            'TotalUsage = TotalUsage + Convert.ToDouble(jl.PrimaryAssetUsage)
                '            TotalUsage = Convert.ToDouble(jl.PrimaryAssetUsage)

                '        End If

                '        If jl.Asset2ID = Instance.Job.EquipamentoNo1 Then
                '            Asset2TotalUsage = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If
                '    End If

                '    If Instance.Job.EquipamentoNo2 IsNot Nothing Then
                '        If jl.AssetID = Instance.Job.EquipamentoNo2 Then
                '            'TotalUsage2 = TotalUsage2 + Convert.ToDouble(jl.PrimaryAssetUsage)
                '            TotalUsage2 = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If

                '        If jl.Asset2ID = Instance.Job.EquipamentoNo2 Then
                '            Asset2TotalUsage2 = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If
                '    End If

                '    If Instance.Job.EquipamentoNo3 IsNot Nothing Then
                '        If jl.AssetID = Instance.Job.EquipamentoNo3 Then
                '            'TotalUsage3 = TotalUsage3 + Convert.ToDouble(jl.PrimaryAssetUsage)
                '            TotalUsage3 = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If

                '        If jl.Asset2ID = Instance.Job.EquipamentoNo3 Then
                '            Asset2TotalUsage3 = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If

                '    End If

                '    If Instance.Job.EquipamentoNo4 IsNot Nothing Then
                '        If jl.AssetID = Instance.Job.EquipamentoNo4 Then
                '            'TotalUsage4 = TotalUsage4 + Convert.ToDouble(jl.PrimaryAssetUsage)
                '            TotalUsage4 = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If

                '        If jl.Asset2ID = Instance.Job.EquipamentoNo4 Then
                '            Asset2TotalUsage4 = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If
                '    End If


                '    If Instance.Job.EquipamentoNo5 IsNot Nothing Then
                '        If jl.AssetID = Instance.Job.EquipamentoNo5 Then
                '            'TotalUsage5 = TotalUsage5 + Convert.ToDouble(jl.PrimaryAssetUsage)
                '            TotalUsage5 = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If

                '        If jl.Asset2ID = Instance.Job.EquipamentoNo5 Then
                '            Asset2TotalUsage5 = Convert.ToDouble(jl.PrimaryAssetUsage)
                '        End If
                '    End If

                'Next

                ''Update the Assets current Total Usage+-
                'Equip1Asset.TotalUsage = TotalUsage + Asset2TotalUsage
                'Equip1Asset.SaveAndFlush()

                'Equip2Asset.TotalUsage = TotalUsage2 + Asset2TotalUsage2
                'Equip2Asset.SaveAndFlush()

                'Equip3Asset.TotalUsage = TotalUsage3 + Asset2TotalUsage3
                'Equip3Asset.SaveAndFlush()

                'Equip4Asset.TotalUsage = TotalUsage4 + Asset2TotalUsage4
                'Equip4Asset.SaveAndFlush()

                'Equip5Asset.TotalUsage = TotalUsage5 + Asset2TotalUsage5
                'Equip5Asset.SaveAndFlush()

                ''      Dim TotalUsagebefore As Double = (Instance.Job.Eq1UsageBefore + Instance.Job.Eq2UsageBefore + Instance.Job.Eq3UsageBefore + Instance.Job.Eq4UsageBefore + Instance.Job.Eq5UsageBefore)
                ''     Dim TotalUsageAfter As Double = (TotalUsage + TotalUsage2 + TotalUsage3 + TotalUsage4 + TotalUsage5)


                'Instance.Job.Eq1TotalUsage = Equip1Asset.TotalUsage - Instance.Job.Eq1UsageBefore
                ''   Instance.SaveAndFlush()

                'Instance.Job.Eq2TotalUsage = Equip2Asset.TotalUsage - Instance.Job.Eq2UsageBefore
                ''    Instance.SaveAndFlush()

                'Instance.Job.Eq3TotalUsage = Equip3Asset.TotalUsage - Instance.Job.Eq3UsageBefore
                ''     Instance.SaveAndFlush()

                'Instance.Job.Eq4TotalUsage = Equip4Asset.TotalUsage - Instance.Job.Eq4UsageBefore
                ''      Instance.SaveAndFlush()

                'Instance.Job.Eq5TotalUsage = Equip5Asset.TotalUsage - Instance.Job.Eq5UsageBefore
                ''       Instance.SaveAndFlush()

                'Instance.SetLoading(True)
                If Me.Requisition IsNot Nothing Then
                    For Each rl As API.RequisitionLine In Instance.RequisitionLines
                        Using t As New RequisitionLineToErp(rl, Requisition, API.Context.Defaults)
                            t.Subscribe(Me)
                            t.CallRun()
                        End Using
                    Next
                    
                Else
                    Throw New Exception("Error locating ERP JobCard when posting Requisition.")
                End If
                'Instance.SaveAndFlush()
                'Instance.Job.MachineHoursToDate = TotalUsage
                ' Instance.Job.TotalUsage = TotalUsage + TotalUsage2 + TotalUsage3 + TotalUsage4 + TotalUsage5

                Instance.Job.RequisitionPrintedAgentID = API.Context.Agent.ID

                Instance.SaveAndFlush()
                'Instance.SetLoading(False)
                'For Each jl As API.JobLine In API.Job.Find(Instance.Job.ID).JobLineList
                '    For Each rl As API.RequisitionLine In jl.RequisitionLineList
                '        rl.Requisition = Instance
                '        rl.SaveAndFlush()
                '    Next
                'Next
                For Each rl As API.RequisitionLine In CType(Instance, API.Requisition).RequisitionLineList
                    rl.Requisition = Instance
                    rl.SaveAndFlush()
                Next
                'Dim xrPR As New ShopFloor.Report.xrDoscoRequisition
                'xrPR.RequisitionBindingSource.DataSource = Instance
                'xrPR.ShowPreviewDialog()
                'Throw New Exception("Request TO ERP Error")


            End If

        Catch ex As Exception
            'TODO: Test delete not delete any job info
            RollbackTran = True
            Instance.Delete()
            Throw New Exception(ex.Message)

        End Try

    End Sub

    Protected Overrides Sub RunReport()
        Dim xrPR As New ShopFloor.Report.xrDoscoRequisition
        xrPR.RequisitionBindingSource.DataSource = Instance
        xrPR.ShowPreviewDialog()
    End Sub

End Class
