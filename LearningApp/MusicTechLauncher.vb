Imports System.IO
Imports System.Xml

Public Class MusicTechLauncher
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        brwContent2.ObjectForScripting = True
        brwContent2.ScriptErrorsSuppressed = True
    End Sub

    ' Default Zoom
    Dim InitialZoom As Integer = 100

    ' Admin Mode
    Public AdminMode = 0

    ' Set Directories
    Dim path As String = AppDomain.CurrentDomain.BaseDirectory
    Dim path1 As String = Path.Replace("\bin\Debug\", "\HTML\")
    Dim path2 As String = Path.Replace("\bin\Debug\", "\")

    Private mRootPath As String = path1

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
        PopulateTreeView()

        ' Set the home navigation page
        brwContent2.Navigate(path1 + "Home.html")
    End Sub

    ' Navigation
    Private Sub tlsHome_Click(sender As Object, e As EventArgs) Handles tlsHome.Click
        ' Loads the Homepage
        brwContent2.Navigate(path1 + "Home.html")
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Refresh browser content
        PopulateTreeView()
        brwContent2.Refresh()
    End Sub
    Private Sub PageNavigateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageNavigateToolStripMenuItem.Click
        Dim myValue As Object

        ' Display message, title, and default value.
        myValue = InputBox("Navigate to... ", "Navigation Box", "http://www.google.co.uk")

        ' If user has clicked Cancel, set myValue to defaultValue 
        If myValue Is "" Then myValue = "http://www.google.co.uk"

        brwContent2.Navigate(myValue)
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Go Back
        brwContent2.GoBack()
    End Sub
    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        ' Go Forward
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
        ' Check Version
        If ProductVersion = "1" Then
            MessageBox.Show("This version is an Alpha... " + ProductVersion, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("This version is the current release... " + ProductVersion, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If trvTreeview2.SelectedNode.Text = "Home" Then
            ' Message Box
            MsgBox("Data Saved", , "File Saved")
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
            Text = "Learning Application - " + ProductVersion + " [ADMIN MODE]"
        Else
            ForeColor = Color.Black
            Text = "Learning Application - " + ProductVersion
        End If
    End Sub
    Public Sub PerformZoom(ByVal Value As Integer)
        Try
            Dim Res As Object = Nothing
            Dim MyWeb As Object
            MyWeb = brwContent2.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, Value, IntPtr.Zero)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub JSTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JSTestToolStripMenuItem.Click
        brwContent2.Navigate("http://lab.hakim.se/reveal-js/#/")
    End Sub
    Private Sub PopulateTreeView()
        Dim rootNode As TreeNode

        Dim info As New DirectoryInfo("../../HTML")
        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            trvTreeview2.Nodes.Add(rootNode)
        End If

    End Sub

    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, ByVal nodeToAddTo As TreeNode)

        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo

        For Each subDir In subDirs
            aNode = New TreeNode(subDir.Name, 0, 0)
            aNode.Tag = subDir
            aNode.ImageKey = "folder"
            subSubDirs = subDir.GetDirectories()
            If subSubDirs.Length <> 0 Then
                GetDirectories(subSubDirs, aNode)
            End If
            nodeToAddTo.Nodes.Add(aNode)
        Next subDir
    End Sub
    Private Sub treeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles trvTreeview2.NodeMouseClick

        Dim newSelected As TreeNode = e.Node
        ListView1.Items.Clear()
        Dim nodeDirInfo As DirectoryInfo = CType(newSelected.Tag, DirectoryInfo)
        Dim subItems() As ListViewItem.ListViewSubItem
        Dim item As ListViewItem = Nothing
        Dim file As FileInfo

        For Each file In nodeDirInfo.GetFiles("*.html*")
            item = New ListViewItem(file.Name, 1)
            subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "Files"), New ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())}

            item.SubItems.AddRange(subItems)
            ListView1.Items.Add(item)
        Next file

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        ' Node name will find the relevant HTML file and then open in browser
        tlsLessonName.Text = mRootPath + trvTreeview2.SelectedNode.Text + "\" + ListView1.SelectedItems(0).Text
        brwContent2.Navigate(mRootPath + trvTreeview2.SelectedNode.Text + "\" + ListView1.SelectedItems(0).Text)
    End Sub
End Class