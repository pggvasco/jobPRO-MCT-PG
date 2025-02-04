Public Class xfArtisanLogonPseudo 

    Private Sub xfArtisanLogonPseudo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim aar As New ArtisanActivityRunner
        aar.Run()
    End Sub

End Class