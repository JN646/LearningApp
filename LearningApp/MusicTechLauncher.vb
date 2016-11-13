Imports System.IO
Imports System.Xml

Public Class MusicTechLauncher
    ' Default Zoom
    Dim InitialZoom As Integer = 100

    ' Admin Mode
    Public AdminMode = 0

    ' Set Directories
    Dim path As String = AppDomain.CurrentDomain.BaseDirectory
    Dim path1 As String = Path.Replace("\bin\Debug\", "\HTML\")
    Dim path2 As String = Path.Replace("\bin\Debug\", "\")

    Private mRootPath As String = path2

    ' Enums
    Public Enum Exec
        ' Set Zoom Values
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum
    Private Enum execOpt
        ' Set Defaults
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    ' Load Form
    Private Sub MusicTechLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Refresh Form with Permissions
        FormRefresh()

        ' Set the home navigation page
        brwContent2.Navigate(path1 + "Home.html")

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(path1).Where(Function(item) item.ToLower().EndsWith(".html"))
            trvTreeview2.Nodes.Add(foundFile.Replace(path1, ""))
        Next
    End Sub

    Sub trvTreeview2_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles trvTreeview2.NodeMouseClick
        ' Node name will find the relevant HTML file and then open in browser
        tlsLessonName.Text = e.Node.Text
        brwContent2.Navigate(path1 + e.Node.Text)

    End Sub

    ' Navigation
    Private Sub tlsHome_Click(sender As Object, e As EventArgs) Handles tlsHome.Click
        ' Loads the Homepage
        brwContent2.Navigate(path1 + "Home.html")
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Refresh browser content
        brwContent2.Refresh()
    End Sub
    Private Sub PageNavigateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageNavigateToolStripMenuItem.Click
        Dim message, title, defaultValue As String
        Dim myValue As Object

        ' Set prompt.
        message = "Navigate to... "

        ' Set title.
        title = "navigation Box"
        defaultValue = "http://www.google.co.uk"   ' Set default value.

        ' Display message, title, and default value.
        myValue = InputBox(message, title, defaultValue)

        ' If user has clicked Cancel, set myValue to defaultValue 
        If myValue Is "" Then myValue = defaultValue

        brwContent2.Navigate(myValue)
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        brwContent2.GoBack()
    End Sub
    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        brwContent2.GoForward()
    End Sub

    ' Menu Items
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        brwContent2.ShowPrintPreviewDialog()
    End Sub
    Private Sub UpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatesToolStripMenuItem.Click
        If ProductVersion = "1" Then
            MessageBox.Show("This version is an Alpha... " + ProductVersion, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("This version is the current release... " + ProductVersion, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If trvTreeview2.SelectedNode.Text = "Home" Then
            ' Define the message you want to see inside the message box. 
            Dim msg = "Data Saved"
            Dim title = "File Saved"

            ' Display a simple message box.
            MsgBox(msg)

            ' Add the title to the display.
            MsgBox(msg, , title)
        Else
            trvTreeview2.Nodes.Remove(trvTreeview2.SelectedNode)
        End If
    End Sub
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Copy Web Browser Text
        My.Computer.Clipboard.SetText(brwContent2.DocumentText)
    End Sub

    ' Other Windows
    Private Sub AudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioToolStripMenuItem.Click
        ' Launch Audio preferences
        AudioPref.Show()
    End Sub
    Private Sub MediaPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediaPlayerToolStripMenuItem.Click
        ' Launch video player
        VideoPlayer.Show()
    End Sub
    Private Sub mnuBtnAbout_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        ' Show about box
        AboutBox.Show()
    End Sub

    ' Timing
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        ' Show Date and Time
        ToolStripStatusLabel1.Text = Format(Now, "dd-MM-yyyy - hh:mm:ss")
    End Sub

    ' Theme changing
    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        Theme = MetroFramework.MetroThemeStyle.Light
        Refresh()
    End Sub
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Theme = MetroFramework.MetroThemeStyle.Default
        Refresh()
    End Sub
    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        Theme = MetroFramework.MetroThemeStyle.Dark
        Refresh()
    End Sub

    ' Download required applications
    Private Sub DownloadMaxMSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadMaxMSPToolStripMenuItem.Click
        brwContent2.Navigate("https://cycling74.com/downloads/older/#.WCPnKPmLSHs")
    End Sub
    Private Sub AdobeAcrobatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdobeAcrobatToolStripMenuItem.Click
        brwContent2.Navigate("https://get.adobe.com/uk/reader/")
    End Sub

    ' Account Tools
    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        login.Show()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MessageBox.Show("Logged Out ", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        AdminMode = 0
        FormRefresh()
    End Sub

    ' Nodestoolstrip
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim myValue

        ' Display message, title, and default value.
        myValue = InputBox("Add New Folder", "New Node", "")
        ' If user has clicked Cancel, set myValue to defaultValue 
        If myValue Is "" Then myValue = ""

        trvTreeview2.Nodes.Add(myValue)
    End Sub
    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If trvTreeview2.SelectedNode.Text = "Home" Then
            ' Define the message you want to see inside the message box. 
            MessageBox.Show("Cannot remove home directoy ", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Remove selected node
            trvTreeview2.Nodes.Remove(trvTreeview2.SelectedNode)
        End If
    End Sub

    ' Zoom controls
    Private Sub ZoomIntoolstrip_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem1.Click
        InitialZoom += 10
        PerformZoom(InitialZoom)
    End Sub

    Private Sub ZoomResettoolstrip_Click(sender As Object, e As EventArgs) Handles ZoomResetToolStripMenuItem.Click
        PerformZoom(100)
    End Sub

    Private Sub ZoomOuttoolstrip_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem1.Click
        InitialZoom -= 10
        PerformZoom(InitialZoom)
    End Sub

    ' Debug Tools
    Private Sub HTMLTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HTMLTestToolStripMenuItem.Click
        brwContent2.Navigate("https://html5test.com/")
    End Sub
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        If AdminMode = 0 Then
            AdminMode = 1
        Else
            AdminMode = 0
        End If
        FormRefresh()
    End Sub

    ' Functions
    Public Sub FormRefresh()
        ' Show/Hide Debug Menu
        If AdminMode = 0 Then
            DEBUGToolStripMenuItem.Enabled = 0
            LogoutToolStripMenuItem.Enabled = 0
        Else
            DEBUGToolStripMenuItem.Enabled = 1
            LoginToolStripMenuItem.Enabled = 1
        End If

        ' Set App name and version number
        If AdminMode = 1 Then
            ForeColor = Color.Red
            Text = "Learning Application " + ProductVersion + " [ADMIN MODE]"
        Else
            ForeColor = Color.Black
            Text = "Learning Application " + ProductVersion
        End If
    End Sub
    Public Sub PerformZoom(ByVal Value As Integer)
        Try
            Dim Res As Object = Nothing
            Dim MyWeb As Object
            'MyWeb = brwContent2.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, Value, IntPtr.Zero)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub JSTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JSTestToolStripMenuItem.Click
        brwContent2.Navigate("http://lab.hakim.se/reveal-js/#/")
    End Sub
End Class