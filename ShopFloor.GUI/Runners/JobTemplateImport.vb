Public Class JobTemplateImport

    Public Property Job As API.Job
    Public Property Template As API.JobTemplate
    Public Property Recalculate As Boolean = False

    Public Sub New(ByVal job As API.Job, ByVal recalculate As Boolean)
        Me.Job = job
        Me.Recalculate = Recalculate
    End Sub

    Public Sub Process()
        If Template Is Nothing Then Throw New ArgumentNullException("Template", "No template specified to import from.")
        If Job Is Nothing Then Throw New ArgumentNullException("Job", "No Job specified to import to.")

        Dim objects As New List(Of API.JobTemplateLine)(Template.JobTemplateLines)
        Dim xfr As New Helper.GUI.xfRunner(Of API.JobTemplateLine)(objects, AddressOf ProcessLine)
        xfr.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(Helper.GUI.My.Resources.page)
        xfr.ShowDialog()

        If xfr.Errors.Count > 0 Then
            Dim xfpe As New Helper.GUI.xfProcessingErrorMsgs()
            For Each er As Exception In xfr.Errors.Values
                xfpe.Errors.Add(er)
            Next
            xfpe.ShowDialog()
        End If

        'Job.SaveAndFlush()
    End Sub

    Protected Sub ProcessLine(ByVal jtl As API.JobTemplateLine)
        Helper.Evolution.Helper.ActivateEvolution(Setup.Settings)

        Dim jl As New API.JobLine

        jl.Job = Me.Job
        jl.LineNumber = jtl.LineNumber
        jl.JobLineDate = Now
        jl.Criteria = jtl.Criteria
        jl.Description1 = jtl.Description1
        jl.Description2 = jtl.Description2
        jl.EstimatedDuration = jtl.EstimatedDuration
        jl.MarkupPercent = jtl.MarkupPercent
        jl.Measurement1 = jtl.Measurement1
        jl.Measurement2 = jtl.Measurement2
        jl.Measurement3 = jtl.Measurement3
        jl.Part = jtl.Part
        jl.Quantity = jtl.Quantity
        jl.QuoteDescription = jtl.QuoteDescription
        jl.SupplierType = jtl.SupplierType
        jl.SupplyScope = jtl.SupplyScope
        jl.UnitSize = jtl.UnitSize
        jl.WorkCentre = jtl.WorkCentre
        jl.WorkCentreCategory = jtl.WorkCentreCategory
        jl.InventoryItem = jtl.InventoryItem

        If jl.InventoryItem.ServiceItem Or jtl.JobTemplate.UseTemplatePricing = True Then
            If Recalculate = False Then
                If jtl.UnitPrice IsNot Nothing AndAlso jtl.UnitPrice > 0 Then
                    jl.UnitPrice = jtl.UnitPrice
                End If
                If jtl.TotalPrice IsNot Nothing AndAlso jtl.TotalPrice > 0 Then
                    jl.TotalPrice = jtl.TotalPrice
                End If
                If jtl.UnitPriceBeforeMarkup IsNot Nothing AndAlso jtl.UnitPriceBeforeMarkup > 0 Then
                    jl.UnitPriceBeforeMarkup = jtl.UnitPriceBeforeMarkup
                End If
            End If
        End If

        'Buy-outs details
        If jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut = True Then
            If jtl.SupplierTypeID IsNot Nothing Then
                jl.SupplierTypeID = jtl.SupplierTypeID
            End If
            If jtl.UnitCost IsNot Nothing Then
                jl.UnitCost = jtl.UnitCost
            End If
            If jtl.UnitPriceBeforeMarkup IsNot Nothing Then
                jl.UnitPriceBeforeMarkup = jtl.UnitPriceBeforeMarkup
            End If
        End If
        jl.IsImporting = True
        If jl.IsValid Then
            jl.Recalculate()
            jl.IsImporting = False
            Job.JobLines.Add(jl)
        End If
    End Sub

End Class
