Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        Dim frmMain As MusicTechLauncher = New MusicTechLauncher()
        If MusicTechLauncher.AdminMode = 0 Then
            If txtUsername2.Text = "Admin" And txtPassword2.Text = "Password" Then
                MusicTechLauncher.AdminMode = 1
                MusicTechLauncher.FormRefresh()
                Close()
            Else
                MessageBox.Show("False", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                MusicTechLauncher.AdminMode = 0
                MusicTechLauncher.FormRefresh()
                Close()
            End If
        Else
            MessageBox.Show("Already Logged in...", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class