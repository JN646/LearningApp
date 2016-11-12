<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioPref
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.sldBuffer = New System.Windows.Forms.HScrollBar()
        Me.lblLatency = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmbAudioDevices = New System.Windows.Forms.ComboBox()
        Me.lblAudioDevice = New System.Windows.Forms.Label()
        Me.cmbSampleRate = New System.Windows.Forms.ComboBox()
        Me.lblSampleRate = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(242, 190)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.sldBuffer)
        Me.TabPage1.Controls.Add(Me.lblLatency)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnOK)
        Me.TabPage1.Controls.Add(Me.cmbAudioDevices)
        Me.TabPage1.Controls.Add(Me.lblAudioDevice)
        Me.TabPage1.Controls.Add(Me.cmbSampleRate)
        Me.TabPage1.Controls.Add(Me.lblSampleRate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(234, 164)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'sldBuffer
        '
        Me.sldBuffer.Location = New System.Drawing.Point(102, 75)
        Me.sldBuffer.Name = "sldBuffer"
        Me.sldBuffer.Size = New System.Drawing.Size(121, 17)
        Me.sldBuffer.TabIndex = 17
        '
        'lblLatency
        '
        Me.lblLatency.AutoSize = True
        Me.lblLatency.Location = New System.Drawing.Point(131, 104)
        Me.lblLatency.Name = "lblLatency"
        Me.lblLatency.Size = New System.Drawing.Size(68, 13)
        Me.lblLatency.TabIndex = 16
        Me.lblLatency.Text = "LatencyTime"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Buffer"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(148, 134)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(15, 134)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmbAudioDevices
        '
        Me.cmbAudioDevices.FormattingEnabled = True
        Me.cmbAudioDevices.Location = New System.Drawing.Point(102, 8)
        Me.cmbAudioDevices.Name = "cmbAudioDevices"
        Me.cmbAudioDevices.Size = New System.Drawing.Size(121, 21)
        Me.cmbAudioDevices.TabIndex = 12
        '
        'lblAudioDevice
        '
        Me.lblAudioDevice.AutoSize = True
        Me.lblAudioDevice.Location = New System.Drawing.Point(12, 11)
        Me.lblAudioDevice.Name = "lblAudioDevice"
        Me.lblAudioDevice.Size = New System.Drawing.Size(71, 13)
        Me.lblAudioDevice.TabIndex = 11
        Me.lblAudioDevice.Text = "Audio Device"
        '
        'cmbSampleRate
        '
        Me.cmbSampleRate.FormattingEnabled = True
        Me.cmbSampleRate.Location = New System.Drawing.Point(102, 41)
        Me.cmbSampleRate.Name = "cmbSampleRate"
        Me.cmbSampleRate.Size = New System.Drawing.Size(121, 21)
        Me.cmbSampleRate.TabIndex = 10
        '
        'lblSampleRate
        '
        Me.lblSampleRate.AutoSize = True
        Me.lblSampleRate.Location = New System.Drawing.Point(12, 44)
        Me.lblSampleRate.Name = "lblSampleRate"
        Me.lblSampleRate.Size = New System.Drawing.Size(68, 13)
        Me.lblSampleRate.TabIndex = 9
        Me.lblSampleRate.Text = "Sample Rate"
        '
        'AudioPref
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 190)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AudioPref"
        Me.Text = "Audio Preferences"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents sldBuffer As HScrollBar
    Friend WithEvents lblLatency As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents cmbAudioDevices As ComboBox
    Friend WithEvents lblAudioDevice As Label
    Friend WithEvents cmbSampleRate As ComboBox
    Friend WithEvents lblSampleRate As Label
    Friend WithEvents TabPage2 As TabPage
End Class
