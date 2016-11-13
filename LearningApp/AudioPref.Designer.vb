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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AudioPref))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.cmbSampleRate2 = New MetroFramework.Controls.MetroComboBox()
        Me.cmbAudioDevices2 = New MetroFramework.Controls.MetroComboBox()
        Me.sldBuffer = New MetroFramework.Controls.MetroScrollBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnOK = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.lblLatency = New MetroFramework.Controls.MetroLabel()
        Me.lblAudioDevices = New MetroFramework.Controls.MetroLabel()
        Me.lblSampleRate = New MetroFramework.Controls.MetroLabel()
        Me.lblBuffer = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(382, 209)
        Me.MetroTabControl1.TabIndex = 22
        Me.MetroTabControl1.UseSelectable = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1002, 419)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "MetroTabPage2"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.lblBuffer)
        Me.MetroTabPage1.Controls.Add(Me.lblSampleRate)
        Me.MetroTabPage1.Controls.Add(Me.lblAudioDevices)
        Me.MetroTabPage1.Controls.Add(Me.lblLatency)
        Me.MetroTabPage1.Controls.Add(Me.btnCancel)
        Me.MetroTabPage1.Controls.Add(Me.btnOK)
        Me.MetroTabPage1.Controls.Add(Me.cmbSampleRate2)
        Me.MetroTabPage1.Controls.Add(Me.cmbAudioDevices2)
        Me.MetroTabPage1.Controls.Add(Me.sldBuffer)
        Me.MetroTabPage1.Controls.Add(Me.PictureBox1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(374, 167)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "MetroTabPage1"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'cmbSampleRate2
        '
        Me.cmbSampleRate2.FormattingEnabled = True
        Me.cmbSampleRate2.ItemHeight = 23
        Me.cmbSampleRate2.Location = New System.Drawing.Point(232, 49)
        Me.cmbSampleRate2.Name = "cmbSampleRate2"
        Me.cmbSampleRate2.Size = New System.Drawing.Size(121, 29)
        Me.cmbSampleRate2.TabIndex = 31
        Me.cmbSampleRate2.UseSelectable = True
        '
        'cmbAudioDevices2
        '
        Me.cmbAudioDevices2.FormattingEnabled = True
        Me.cmbAudioDevices2.ItemHeight = 23
        Me.cmbAudioDevices2.Location = New System.Drawing.Point(232, 13)
        Me.cmbAudioDevices2.Name = "cmbAudioDevices2"
        Me.cmbAudioDevices2.Size = New System.Drawing.Size(121, 29)
        Me.cmbAudioDevices2.TabIndex = 30
        Me.cmbAudioDevices2.UseSelectable = True
        '
        'sldBuffer
        '
        Me.sldBuffer.LargeChange = 10
        Me.sldBuffer.Location = New System.Drawing.Point(216, 84)
        Me.sldBuffer.Maximum = 3000
        Me.sldBuffer.Minimum = 0
        Me.sldBuffer.MouseWheelBarPartitions = 10
        Me.sldBuffer.Name = "sldBuffer"
        Me.sldBuffer.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal
        Me.sldBuffer.ScrollbarSize = 10
        Me.sldBuffer.Size = New System.Drawing.Size(149, 10)
        Me.sldBuffer.TabIndex = 29
        Me.sldBuffer.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(138, 135)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 32
        Me.btnOK.Text = "OK"
        Me.btnOK.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(290, 135)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'lblLatency
        '
        Me.lblLatency.AutoSize = True
        Me.lblLatency.Location = New System.Drawing.Point(259, 97)
        Me.lblLatency.Name = "lblLatency"
        Me.lblLatency.Size = New System.Drawing.Size(81, 19)
        Me.lblLatency.TabIndex = 34
        Me.lblLatency.Text = "MetroLabel1"
        '
        'lblAudioDevices
        '
        Me.lblAudioDevices.AutoSize = True
        Me.lblAudioDevices.Location = New System.Drawing.Point(135, 16)
        Me.lblAudioDevices.Name = "lblAudioDevices"
        Me.lblAudioDevices.Size = New System.Drawing.Size(91, 19)
        Me.lblAudioDevices.TabIndex = 35
        Me.lblAudioDevices.Text = "Audio Devices"
        '
        'lblSampleRate
        '
        Me.lblSampleRate.AutoSize = True
        Me.lblSampleRate.Location = New System.Drawing.Point(135, 49)
        Me.lblSampleRate.Name = "lblSampleRate"
        Me.lblSampleRate.Size = New System.Drawing.Size(83, 19)
        Me.lblSampleRate.TabIndex = 36
        Me.lblSampleRate.Text = "Sample Rate"
        '
        'lblBuffer
        '
        Me.lblBuffer.AutoSize = True
        Me.lblBuffer.Location = New System.Drawing.Point(135, 84)
        Me.lblBuffer.Name = "lblBuffer"
        Me.lblBuffer.Size = New System.Drawing.Size(44, 19)
        Me.lblBuffer.TabIndex = 37
        Me.lblBuffer.Text = "Buffer"
        '
        'AudioPref
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroTabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AudioPref"
        Me.Text = "Audio Preferences"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmbSampleRate2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbAudioDevices2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents sldBuffer As MetroFramework.Controls.MetroScrollBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblLatency As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnOK As MetroFramework.Controls.MetroButton
    Friend WithEvents lblBuffer As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSampleRate As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAudioDevices As MetroFramework.Controls.MetroLabel
End Class
