Public Class xfArtisanLogon
    Public Property Conversation As New Castle.ActiveRecord.ScopedConversation(Castle.ActiveRecord.ConversationFlushMode.Explicit)
    Public Property CLH As UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper
    Public Overridable Property LoggedOnArtisan As API.Artisan

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        If txtArtisanCode.Text = "" Then
            txtArtisanCode.ErrorText = "Required field."
            txtArtisanCode.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            txtPassword.ErrorText = "Required field."
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            If ValidateLogin(txtArtisanCode.Text, txtPassword.Text) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                txtArtisanCode.ErrorText = "Logon details incorrect."
                txtPassword.Text = ""
                txtArtisanCode.Focus()
            End If
        Catch ex As Exception
            UniSource.Logging.Log.Log.logWarn("Error validating logon.", ex)
        End Try
    End Sub

    Public Function ValidateLogin(ByVal code As String, ByVal password As String) As Boolean

        Using New Castle.ActiveRecord.ConversationalScope(Conversation)
            LoggedOnArtisan = API.Artisan.FindByCodeAndPassword(txtArtisanCode.Text, txtPassword.Text)
        End Using

        If LoggedOnArtisan IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub SetFullScreen()

        With Me
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With

        UniSource.Helper.DoubleSize(txtArtisanCode, 2, 2, 2, 2)
        UniSource.Helper.DoubleSize(txtPassword, 2, 2, 2, 2)
        UniSource.Helper.DoubleSize(btCancel, 2, 2, 2, 2)
        UniSource.Helper.DoubleSize(btOk, 2, 2, 2, 2)

        Dim codeFont = New Drawing.Font(txtArtisanCode.Font.FontFamily, "16.5")
        txtArtisanCode.Font = codeFont
        lciName.Control.Font = codeFont
        lciName.Control.Top += 16.5 * 0.75
        txtArtisanCode.Top += 16.25 * 2
        PictureEdit1.Font = codeFont
        PictureEdit1.Top += 16.5 * 0.75

        Dim passwordFont = New Drawing.Font(txtPassword.Font.FontFamily, "16.5")
        txtPassword.Font = passwordFont
        lciPassword.Control.Font = passwordFont
        lciPassword.Control.Top += 16.5 * 0.75
        txtPassword.Top += 16.25 * 2
    End Sub

    Private Sub SetLogo()
        If Not String.IsNullOrEmpty(Setup.Settings.LogOnLogoFilePathName) Then
            Try
                PictureEdit1.Image = Drawing.Image.FromFile(Setup.Settings.LogOnLogoFilePathName)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub xfArtisanLogon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLH = New UniSource.Helper.ActiveRecord.GUI.ComponentLayoutHelper(Me)
        SetFullScreen()
        Try
            SetLogo()
        Catch ex As Exception
            Setup.Log.logError("Error displaying Company Logo.", ex)
        End Try
    End Sub

    Private Sub btManage_Click(sender As System.Object, e As System.EventArgs) Handles btManage.Click
        Try
            Setup.ManageJobs()
        Catch ex As Exception
            Setup.Log.logError("Error loading management screens.", ex)
        End Try
    End Sub

End Class
