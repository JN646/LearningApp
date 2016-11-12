Public Class AudioPref
    Private Sub AudioPref_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Variables
        Dim SampleRate = 44100
        Dim AudioDevice = "0"
        Dim Latency = 25

        ' Sample Rate Items
        cmbSampleRate.Items.Add(22050)
        cmbSampleRate.Items.Add(44100)
        cmbSampleRate.Items.Add(48000)
        cmbSampleRate.Items.Add(96000)

        ' Buffer Values
        sldBuffer.Value = Latency
        sldBuffer.Minimum = 5
        sldBuffer.Maximum = 3000

        ' Tab Names
        TabPage1.Text = "Audio"
        TabPage2.Text = "Data"

        ' Audio Devices Items
        Dim objSearcher As New Management.ManagementObjectSearcher("SELECT * FROM Win32_SoundDevice")
        Dim objCollection As Management.ManagementObjectCollection = objSearcher.Get()

        ' Add Devices to the combobox
        For Each obj As Management.ManagementObject In objCollection
            cmbAudioDevices.Items.Add(obj.GetPropertyValue("Caption").ToString())
        Next

        ' Set Defaults
        cmbAudioDevices.SelectedIndex = 1
        cmbSampleRate.SelectedIndex = 1
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub sldBuffer_Scroll(sender As Object, e As ScrollEventArgs)
        lblLatency.Text = sldBuffer.Value
    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class