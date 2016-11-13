Public Class AudioPref
    Private Sub AudioPref_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Variables
        Dim SampleRate = 44100
        Dim AudioDevice = "0"
        Dim Latency = 25

        ' Sample Rate Items
        cmbSampleRate2.Items.Add(22050)
        cmbSampleRate2.Items.Add(44100)
        cmbSampleRate2.Items.Add(48000)
        cmbSampleRate2.Items.Add(96000)

        ' Buffer Values
        sldBuffer.Value = Latency
        lblLatency.Text = sldBuffer.Value
        sldBuffer.Minimum = 5
        sldBuffer.Maximum = 3000

        ' Tab Names
        MetroTabPage1.Text = "Audio"
        MetroTabPage2.Text = "Data"

        ' Audio Devices Items
        Dim objSearcher As New Management.ManagementObjectSearcher("SELECT * FROM Win32_SoundDevice")
        Dim objCollection As Management.ManagementObjectCollection = objSearcher.Get()

        ' Add Devices to the combobox
        For Each obj As Management.ManagementObject In objCollection
            cmbAudioDevices2.Items.Add(obj.GetPropertyValue("Caption").ToString())
        Next

        ' Set Defaults
        cmbAudioDevices2.SelectedIndex = 1
        cmbSampleRate2.SelectedIndex = 1
    End Sub

    Private Sub sldBuffer_Scroll_1(sender As Object, e As ScrollEventArgs)
        lblLatency.Text = sldBuffer.Value
    End Sub

    Private Sub btnCancel_Click_2(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOK_Click_2(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub
End Class