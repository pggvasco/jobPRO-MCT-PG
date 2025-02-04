Public Class xaeCustomerRateTime 
    Inherits xaegCustomerRateTime

    Protected Overrides Sub SaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btSave.Click
        'its not passing the property dont know why??


        'Dim rate = API.CustomerRatePrice.FindAllByProperty("CustomerID", Me.Record.ID).FirstOrDefault
        'If rate Is Nothing Then
        '    rate = New API.CustomerRatePrice
        'End If
        'rate.CustomerID = Me.Record.ID
        'rate.WeekDayPriceList = CStr(WeekDayLookUpEdit.EditValue)
        'rate.WeekNightPriceList = CStr(WeekNightLookUpEdit.EditValue)
        'rate.SaturdayDayPriceList = CStr(SaturdayLookUpEdit.EditValue)
        'rate.SaturdayNightPriceList = CStr(SaturdayNightLookUpEdit.EditValue)
        'rate.SundayDayPriceList = CStr(SundayDayLookUpEdit.EditValue)
        'rate.SundayNightPriceList = CStr(SundayNightLookUpEdit.EditValue)
        'rate.PublicHolidayDayPricelist = CStr(PublicHolidayDayLookUpEdit.EditValue)
        'rate.PublicHolidayNightPricelist = CStr(PublicHolidayNightLookUpEdit.EditValue)
        'rate.SaveAndFlush()
        'SaveRecord()
    End Sub

    Private Sub xaeCustomerRateTime_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            PriceListNameBindingSource.DataSource = UniSource.Helper.ActiveRecord.Evolution.PriceListName.FindAll
            Dim iibl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.PriceListName)(WeekDayLookUpEdit, AddressOf LoadPrices)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for Inventory Items.", ex)
        End Try

    End Sub


    Private Function LoadPrices() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.PriceListName)
        Return UniSource.Helper.ActiveRecord.Evolution.PriceListName.FindAll
    End Function
End Class
Public Class xaegCustomerRateTime
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.SFCustomer)

    'Public Sub New()
    '    MyBase.New()
    '    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    'End Sub

    Protected Overrides Sub SaveClick(sender As Object, e As System.EventArgs)
        '' MyBase.SaveClick(sender, e)
        Me.SaveRecord()
        MyBase.SaveRecord()
    End Sub
End Class