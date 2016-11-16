Public Class VideoPlayer
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Video|*.MP4"

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
            sr.Close()
        End If
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VideoPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class