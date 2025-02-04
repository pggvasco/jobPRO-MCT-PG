Public Class xaeCustomerWardWarehouse 
    Inherits xaegCustomerWardWarehouse

    Private Sub xaeCustomerWardWarehouse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        Try
            PriceListNameBindingSource.DataSource = UniSource.Helper.ActiveRecord.Evolution.PriceListName.FindAll
        Catch ex As Exception
            Setup.Log.logError("Error loading pricelistnames.", ex)
        End Try

    End Sub


    Private Function LoadWorkCentreCategories() As IEnumerable(Of API.WorkCentreCategory)
        Return API.WorkCentreCategory.FindAll
    End Function
    Private Function LoadWarehouses() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster)
        Return UniSource.Helper.ActiveRecord.Evolution.WarehouseMaster.FindAll
    End Function


    
    Private Sub AddEditJobClass_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddEditJobClass.ItemClick
        Dim workC As API.CustomerWorkCentreCategory = CType(gvCustomerWards.GetFocusedRow, API.CustomerWorkCentreCategory)
        Dim xaejl As New xaeJobClass With {.Record = workC}

        xaejl.ShowDialog()
        'xaejl.Icon = UniSource.Helper.GUI.Extensions.MakeIcon(bbiAddLine.Glyph)

        'xaejl.DataLayoutControl1.Enabled = False

    End Sub

    Private Sub gvQualification_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvCustomerWards.ValidateRow
        Dim selectedWard As API.CustomerWorkCentreCategory = CType(gvCustomerWards.GetFocusedRow(), API.CustomerWorkCentreCategory)
        If selectedWard Is Nothing Then
            Exit Sub
        End If
        If selectedWard IsNot Nothing Then
            If selectedWard.Code Is Nothing Then
                e.Valid = False
                'e.ErrorText = "Please Enter a valid Quantity"
                UniSource.Helper.GUI.Dialog.OKDialog("Please Enter Ward Code .", "Ward Code Missing")
                gvCustomerWards.SetColumnError(colCode, "Please Enter Ward Code.")

            ElseIf selectedWard.Description Is Nothing Then
                e.Valid = False

                UniSource.Helper.GUI.Dialog.OKDialog("Please Enter Ward.", "Ward Missing")
                gvCustomerWards.SetColumnError(colDescription, "Please Enter  Ward.")

            ElseIf selectedWard.WeekDayPriceList Is Nothing Then
                e.Valid = False

                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Week Day Pricelist.", "Week Day Pricelist")
                gvCustomerWards.SetColumnError(colWeekDayPriceList, "Please Select  WeekDay Price list.")
            ElseIf selectedWard.WeekNightPricelist Is Nothing Then
                e.Valid = False
                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Wekk Night Pricelist.", "Week Day Pricelist")
                gvCustomerWards.SetColumnError(colWeekNightPricelist, "Please Select  WeekNight  Price list.")
            ElseIf selectedWard.SaturdayDayPricelist Is Nothing Then
                e.Valid = False

                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Saturday Day Pricelist.", "Saturday Day Pricelist")
                gvCustomerWards.SetColumnError(colSaturdayDayPricelist, "Please Select  Saturday Day Price list.")
            ElseIf selectedWard.SaturdayNightPricelist Is Nothing Then
                e.Valid = False

                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Saturday Night Pricelist.", "Saturday Night Pricelist")
                gvCustomerWards.SetColumnError(colSaturdayNightPricelist, "Please Select  Saturday Night Price list.")
            ElseIf selectedWard.SundayDayPricelist Is Nothing Then
                e.Valid = False

                UniSource.Helper.GUI.Dialog.OKDialog("Please Select SundayDay Pricelist.", "SundayDay Pricelist")
                gvCustomerWards.SetColumnError(colSundayDayPricelist, "Please Select  SundayDay Price list.")
            ElseIf selectedWard.SundayNightPricelist Is Nothing Then
                e.Valid = False

                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Sunday Night Pricelist.", "Sunday Night Pricelist")
                gvCustomerWards.SetColumnError(colSundayNightPricelist, "Please Select Sunday Night Price list.")
            ElseIf selectedWard.PublicHolidayDayPricelist Is Nothing Then
                e.Valid = False

                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Public Holiday Pricelist.", "Week Day Pricelist")
                gvCustomerWards.SetColumnError(colPublicHolidayDayPricelist, "Please Select  Public Holiday Day  Price list.")
            ElseIf selectedWard.PublicHolidayNightPricelist Is Nothing Then
                e.Valid = False

                UniSource.Helper.GUI.Dialog.OKDialog("Please Select Holiday Night Pricelist.", "Holiday  Pricelist")
                gvCustomerWards.SetColumnError(colPublicHolidayNightPricelist, "Please Select  Holiday Price list.")
            End If
            If selectedWard.Code IsNot Nothing Then
                Dim ward = (From wrd In API.CustomerWorkCentreCategory.FindAll.Where(Function(wd) wd.SFCustomer.ERPCustomerID = Me.Record.ERPCustomerID And wd.Code = selectedWard.Code)).FirstOrDefault
                If ward IsNot Nothing Then
                    e.Valid = False

                    UniSource.Helper.GUI.Dialog.OKDialog(String.Format("Duplicate Ward Entry on.{0}", Me.Record.Client.AccountDescription))
                    gvCustomerWards.SetColumnError(colCode, "Please  Select Another Code.")
                    e.Valid = False
                End If
            End If

        End If
    End Sub
End Class
Public Class xaegCustomerWardWarehouse
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.SFCustomer)

    'Public Sub New()
    '    MyBase.New()
    '    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    'End Sub

    
End Class