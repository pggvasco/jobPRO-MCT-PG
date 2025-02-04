Public Class xaePublicHoliday 
    Inherits xaegPublicHoliday

    Protected Overrides Sub ValidationError(ByVal errors As System.Collections.Generic.Dictionary(Of System.Reflection.PropertyInfo, System.Collections.ArrayList))
           If errors IsNot Nothing Then
                MyBase.ValidationError(errors)
                For Each prop As Reflection.PropertyInfo In errors.Keys
                If prop.Name = "PublicHolidayDate" Then
                    PublicHolidayDateEdit.ErrorText = errors(prop)(0)
                End If
                If prop.Name = "Description" Then
                    DescriptionTextEdit.ErrorText = errors(prop)(0)
                End If
                Next

            MyBase.ValidationError(errors)
        End If
    End Sub
    
End Class

Public Class xaegPublicHoliday
    Inherits UniSource.Helper.ActiveRecord.xfAddEdit(Of API.PublicHoliday)

    Public Sub New()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
End Class
