<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtUsername2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword2 = New MetroFramework.Controls.MetroTextBox()
        Me.btnOK2 = New MetroFramework.Controls.MetroButton()
        Me.btnCancel2 = New MetroFramework.Controls.MetroButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(127, 19)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "Username"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(127, 48)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel2.TabIndex = 8
        Me.MetroLabel2.Text = "Password"
        '
        'txtUsername2
        '
        '
        '
        '
        Me.txtUsername2.CustomButton.Image = Nothing
        Me.txtUsername2.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtUsername2.CustomButton.Name = ""
        Me.txtUsername2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUsername2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername2.CustomButton.TabIndex = 1
        Me.txtUsername2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername2.CustomButton.UseSelectable = True
        Me.txtUsername2.CustomButton.Visible = False
        Me.txtUsername2.Lines = New String() {"MetroTextBox1"}
        Me.txtUsername2.Location = New System.Drawing.Point(211, 19)
        Me.txtUsername2.MaxLength = 32767
        Me.txtUsername2.Name = "txtUsername2"
        Me.txtUsername2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername2.SelectedText = ""
        Me.txtUsername2.SelectionLength = 0
        Me.txtUsername2.SelectionStart = 0
        Me.txtUsername2.ShortcutsEnabled = True
        Me.txtUsername2.Size = New System.Drawing.Size(140, 23)
        Me.txtUsername2.TabIndex = 9
        Me.txtUsername2.Text = "MetroTextBox1"
        Me.txtUsername2.UseSelectable = True
        Me.txtUsername2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassword2
        '
        '
        '
        '
        Me.txtPassword2.CustomButton.Image = Nothing
        Me.txtPassword2.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtPassword2.CustomButton.Name = ""
        Me.txtPassword2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPassword2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword2.CustomButton.TabIndex = 1
        Me.txtPassword2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword2.CustomButton.UseSelectable = True
        Me.txtPassword2.CustomButton.Visible = False
        Me.txtPassword2.Lines = New String() {"MetroTextBox2"}
        Me.txtPassword2.Location = New System.Drawing.Point(211, 48)
        Me.txtPassword2.MaxLength = 32767
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword2.SelectedText = ""
        Me.txtPassword2.SelectionLength = 0
        Me.txtPassword2.SelectionStart = 0
        Me.txtPassword2.ShortcutsEnabled = True
        Me.txtPassword2.Size = New System.Drawing.Size(140, 23)
        Me.txtPassword2.TabIndex = 10
        Me.txtPassword2.Text = "MetroTextBox2"
        Me.txtPassword2.UseSelectable = True
        Me.txtPassword2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnOK2
        '
        Me.btnOK2.Location = New System.Drawing.Point(127, 87)
        Me.btnOK2.Name = "btnOK2"
        Me.btnOK2.Size = New System.Drawing.Size(75, 23)
        Me.btnOK2.TabIndex = 11
        Me.btnOK2.Text = "OK"
        Me.btnOK2.UseSelectable = True
        '
        'btnCancel2
        '
        Me.btnCancel2.Location = New System.Drawing.Point(276, 87)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel2.TabIndex = 12
        Me.btnCancel2.Text = "Cancel"
        Me.btnCancel2.UseSelectable = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(361, 125)
        Me.Controls.Add(Me.btnCancel2)
        Me.Controls.Add(Me.btnOK2)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.txtUsername2)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUsername2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnOK2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel2 As MetroFramework.Controls.MetroButton
End Class
