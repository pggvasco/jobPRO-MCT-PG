Imports Castle.ActiveRecord
Imports Castle.Components.Validator
Imports UniSource
Imports NHibernate.Event
Imports System.Data.SqlClient
Namespace Functions
    Public Class RecalculateLinePrices
        Inherits JobFunction
        Protected Overrides Sub Action()

            For Each job In Jobs
                Dim bc As New Helper.ActiveRecord.Checkout
                If bc.AddCheckOut("Job", job.ID) Then
                    If job.State = API.JobState.QuoteInactive Then
                        job.State = API.JobState.Quote
                    End If
                    'change job qoute date to currentdate
                    job.QuoteDate = System.DateTime.Now
                    'Update the Quoteline prices to evolution prices
                    job.RecalculateLinePrices()
                    job.SaveAndFlush()

                    If bc.AlreadyCheckedOut(bc.Checkout.GUID) Then
                        bc.RemoveCheckout(bc.Checkout.GUID)
                    End If
                End If
            Next
        End Sub

        Public Overrides Property RequiresInstance As Boolean = False

        Public Overrides ReadOnly Property Code As String
            Get
                Return "RecalculateQuotelines"
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Return "RecalculatelinePrices."
            End Get
        End Property

        Public Overrides ReadOnly Property ID As API.JobFunction
            Get
                Return API.JobFunction.RecalculateLinePrices
            End Get
        End Property

        Public Overrides ReadOnly Property Glyph As System.Drawing.Image
            Get
                Return Helper.GUI.My.Resources.page_add
            End Get
        End Property
    End Class
End Namespace
