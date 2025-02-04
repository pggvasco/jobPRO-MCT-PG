Public Class JobImport

    Public Property Job As API.Job
    Public Property JobToImport As API.Job
    Public Property Recalculate As Boolean = False
    Public Property UseImportQuoteDiscount As Boolean = False
    Public Property DefaultDiscountPercentage As Double = 0.0


    Public Sub New(ByVal job As API.Job, ByVal recalculate As Boolean, ByVal UseDiscount As Boolean, ByVal DefaultDiscountPerc As Double)
        Me.Job = job
        Me.Recalculate = recalculate
        Me.UseImportQuoteDiscount = UseDiscount
        Me.DefaultDiscountPercentage = DefaultDiscountPerc
    End Sub

    Public Sub Process()
        If JobToImport Is Nothing Then Throw New ArgumentNullException("JobToImport", "No Job specified to import from.")
        If Job Is Nothing Then Throw New ArgumentNullException("Job", "No Job specified to import to.")

        Dim objects As New List(Of API.JobLine)(JobToImport.JobLines)
        Dim xfr As New Helper.GUI.xfRunner(Of API.JobLine)(objects, AddressOf ProcessLine)
        xfr.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(Helper.GUI.My.Resources.page_white)
        xfr.ShowDialog()

        If xfr.Errors.Count > 0 Then
            Dim xfpe As New Helper.GUI.xfProcessingErrorMsgs()
            For Each er As Exception In xfr.Errors.Values
                xfpe.Errors.Add(er)
            Next
            xfpe.ShowDialog()
        End If

        ' Copies drawing settings
        If JobToImport.Drawing IsNot Nothing Then
            If Job.Drawing Is Nothing Then
                Job.Drawing = JobToImport.Drawing
            End If
            If Job.Drawing = JobToImport.Drawing Then
                For Each jtida As API.JobDrawingAnnotation In JobToImport.JobDrawingAnnotations
                    If Job.JobDrawingAnnotations IsNot Nothing AndAlso Job.JobDrawingAnnotations.Count > jtida.Sequence - 1 Then
                        If Job.JobDrawingAnnotations(jtida.Sequence - 1).Size Is Nothing OrElse Job.JobDrawingAnnotations(jtida.Sequence - 1).Size.Trim = "" Then
                            Job.JobDrawingAnnotations(jtida.Sequence - 1).Size = jtida.Size
                        End If
                    Else
                        'Job.JobDrawingAnnotations.Add(jtida)
                        Dim njda As API.JobDrawingAnnotation = New API.JobDrawingAnnotation
                        njda.Code = jtida.Code
                        njda.Description = jtida.Description
                        njda.Sequence = jtida.Sequence
                        njda.Size = jtida.Size
                        'Job.JobDrawingAnnotations.Add(jtida)
                        Job.JobDrawingAnnotations.Add(njda)
                    End If
                Next
            End If
        End If

        Job.ImportReference = "Job Number : " + JobToImport.JobNumber
        'Job.SaveAndFlush()
    End Sub

    Protected Sub ProcessLine(ByVal jtl As API.JobLine)
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

        If jl.InventoryItem.ServiceItem Then
            If Recalculate = False Then
                If jtl.UnitPrice IsNot Nothing AndAlso jtl.UnitPrice > 0 Then
                    jl.UnitPrice = jtl.UnitPrice
                    jl.TotalPrice = jtl.TotalPrice
                    jl.LineDiscountPercent = jtl.LineDiscountPercent
                    jl.UnitPriceBeforeMarkup = jtl.UnitPriceBeforeMarkup
                End If
            End If
        End If

        ' Yes to use the imported lines discount then set all
        If Me.UseImportQuoteDiscount = True Then
            jl.LineDiscountPercent = jtl.LineDiscountPercent
        Else
            ' No to use the default discount but only for non service items          
            If jl.InventoryItem.ServiceItem = False Then
                jl.LineDiscountPercent = DefaultDiscountPercentage / 100
            End If
        End If

        'Buy-outs details
        If jl.WorkCentre IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut IsNot Nothing AndAlso jl.WorkCentre.IsBuyOut = True Then
            If jtl.SupplierTypeID IsNot Nothing Then
                jl.SupplierTypeID = jtl.SupplierTypeID
            End If
            If jtl.Supplier1ID IsNot Nothing Then
                jl.Supplier1ID = jtl.Supplier1ID
            End If
            If jtl.Supplier2ID IsNot Nothing Then
                jl.Supplier2ID = jtl.Supplier2ID
            End If
            If jtl.UnitCost IsNot Nothing Then
                jl.UnitCost = jtl.UnitCost
            End If
            If jtl.PurchaseDiscountPercent IsNot Nothing Then
                jl.PurchaseDiscountPercent = jtl.PurchaseDiscountPercent
            End If
            If jtl.UnitPriceBeforeMarkup IsNot Nothing Then
                jl.UnitPriceBeforeMarkup = jtl.UnitPriceBeforeMarkup
            End If
        End If
        jl.IsImporting = True
        If jl.IsValid Then
            jl.IsImporting = False
            jl.Recalculate()
            'jl.Save()
            Job.JobLines.Add(jl)
        End If

    End Sub

End Class
