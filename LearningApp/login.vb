Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frmMain As MusicTechLauncher = New MusicTechLauncher()
        If MusicTechLauncher.AdminMode = 0 Then
            If txtUsername.Text = "Admin" And txtPassword.Text = "Password" Then
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
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class