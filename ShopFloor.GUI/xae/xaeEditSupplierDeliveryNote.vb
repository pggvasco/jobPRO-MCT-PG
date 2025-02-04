Imports UniSource.Helper.ActiveRecord


Public Class xaeEditSupplierDeliveryNote
    Inherits xaegEditSupplierDeliveryNote

    <SmartAssembly.Attributes.DoNotPrune()>
    Public Property JobSupplierDeliveryNote As API.JobSupplierDeliveryNote
        Get
            If JobSupplierDeliveryNoteBindingSource IsNot Nothing Then
                If JobSupplierDeliveryNoteBindingSource.Current IsNot Nothing Then
                    Return TryCast(JobSupplierDeliveryNoteBindingSource.Current, API.JobSupplierDeliveryNote)
                End If
            End If
            Return Nothing
        End Get
        Set(ByVal value As API.JobSupplierDeliveryNote)
            If value.ID > 0 Then
                Try
                    'Conversation.Restart()
                    'Using New Castle.ActiveRecord.ConversationalScope(Conversation)
                    JobSupplierDeliveryNoteBindingSource.DataSource = value
                    'End Using
                Catch ex As Exception
                    'Conversation.Restart()
                    Setup.Log.logError(String.Format("Error fetching Supplier Delivery Note from database with id {0}.", value.ID), ex)
                End Try
            Else
                JobSupplierDeliveryNoteBindingSource.DataSource = value
            End If
        End Set
    End Property

    Private Sub xaeEditSupplierDeliveryNote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cbl As New Helper.GUI.LookupBackgroundLoader(Of UniSource.Helper.ActiveRecord.Evolution.Vendor)(SupplierLookUpEdit, AddressOf LoadVendors, False)
        Catch ex As Exception
            Setup.Log.logError("Error setting loader for JobSuppliers.", ex)
        End Try

    End Sub


    Private Function LoadVendors() As IEnumerable(Of UniSource.Helper.ActiveRecord.Evolution.Vendor)
        'Dim vendorcrit = NHibernate.Criterion.DetachedCriteria.For(Of UniSource.Helper.ActiveRecord.Evolution.Vendor)()
        Return UniSource.Helper.ActiveRecord.Evolution.Vendor.FindAllByProperty("OnHold", False)
    End Function

    Protected Overrides Sub SaveRecord()

        Dim Valid As Boolean = True
        If Me.Record IsNot Nothing Then
            BeforeValidate()

            If JobSupplierDeliveryNote.IsValid Then
                'Check out moved to be only checked after record is valid
                If Me.PerformBatchCheckout Then
                    If Not Me.CheckoutGuid = Guid.Empty Then
                        Try
                            Dim bc As New Checkout
                            If bc.AlreadyCheckedOut(Me.CheckoutGuid) Then
                                bc.RemoveCheckout(Me.CheckoutGuid)
                            Else
                                Throw New Exception("You have lost your checkout authority, your changes cannot be saved.")
                            End If
                        Catch ex As Exception
                            UniSource.Logging.Log.Log.logError("Error testing checkout authority.", ex)
                            Me.DialogResult = Windows.Forms.DialogResult.None
                            Exit Sub
                        End Try
                    End If
                End If
                Try
                    Dim c As New Castle.ActiveRecord.ConversationalScope(Me.Conversation)
                    Try
                        If SaveOnDialogWorkerForm Then
                            Dim dwf As New DialogWorkerForm(c, Record, "Save", String.Format("Saving {0}...", Record.ToString))
                        Else
                            JobSupplierDeliveryNote.Save()
                        End If
                    Catch ex As Exception
                        UniSource.Logging.Log.Log.logError(ex.Message, ex)
                        Me.DialogResult = Windows.Forms.DialogResult.None
                        Valid = False
                    End Try
                    If Valid Then
                        c.Flush()
                        c.Dispose()
                    End If
                Catch ex As Exception
                    UniSource.Logging.Log.Log.logError(ex.Message, ex)
                    Me.DialogResult = Windows.Forms.DialogResult.None
                    Valid = False
                End Try

                If Valid = False Then
                    Exit Sub
                End If

                Try
                    Me.Conversation.Flush()
                    Me.Conversation.Dispose()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Catch ex As Exception
                    UniSource.Logging.Log.Log.logError(ex.Message, ex)
                    Me.DialogResult = Windows.Forms.DialogResult.None
                End Try
            Else
                ValidationError(DirectCast(JobSupplierDeliveryNote, API.JobSupplierDeliveryNote).PropertiesValidationErrorMessages)
                UniSource.Logging.Log.Log.logWarn(DirectCast(JobSupplierDeliveryNote, API.JobSupplierDeliveryNote).PropertiesValidationErrorMessages)
                Beep()
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub DeliveryNoteLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DeliveryNoteLookUpEdit.EditValueChanged
        JobSupplierDeliveryNote = DeliveryNoteLookUpEdit.EditValue
        SupplierLookUpEdit.Enabled = True
        SupplierLookUpEdit.Properties.ReadOnly = False
    End Sub
End Class

Public Class xaegEditSupplierDeliveryNote
    Inherits Helper.ActiveRecord.xfAddEdit(Of API.Job)
End Class
