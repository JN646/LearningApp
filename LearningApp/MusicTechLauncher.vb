Imports System.IO
Imports System.Xml

Public Class MusicTechLauncher
    Dim InitialZoom As Integer = 100
    Public Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum
    Private Enum execOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    ' Get Base Directory
    Dim path As String = AppDomain.CurrentDomain.BaseDirectory

    ' Admin Mode
    Public AdminMode = 0

    ' Replace HTML location
    Dim path1 As String = path.Replace("\bin\Debug\", "\HTML\")
    Dim path2 As String = path.Replace("\bin\Debug\", "\")

    ' Declare XML Values
    Dim xmldoc As New XmlDataDocument()
    Dim xmlnode As XmlNode

    ' LoadXML
    Dim fs As New FileStream(path2 + "tree.xml", FileMode.Open, FileAccess.Read)

    Private Sub MusicTechLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set Base 
        Theme = MetroFramework.MetroThemeStyle.Default
        Style = MetroFramework.MetroColorStyle.Default

        ' Refresh Form with Permissions
        FormRefresh()

        ' Set the home navigation page
        brwContent.Navigate(path1 + "Home.html")

        ' XML Data
        xmldoc.Load(fs)
        xmlnode = xmldoc.ChildNodes(1)

        ' Clear and Add
        trvTreeview.Nodes.Clear()
        trvTreeview.Nodes.Add(New TreeNode(xmldoc.DocumentElement.Name))
        Dim tNode As TreeNode
        tNode = trvTreeview.Nodes(0)
        AddNode(xmlnode, tNode)
    End Sub
    Sub treeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles trvTreeview.NodeMouseClick
        ' Node name will find the relevant HTML file and then open in browser
        tlsLessonName.Text = e.Node.Text
        brwContent.Navigate(path1 + e.Node.Text + ".html")

    End Sub 'treeView1_NodeMouseClick
    Private Sub tlsHome_Click(sender As Object, e As EventArgs) Handles tlsHome.Click
        ' Loads the Homepage
        brwContent.Navigate(path1 + "Home.html")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        brwContent.ShowPrintPreviewDialog()
    End Sub

    Private Sub mnuBtnAbout_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        brwContent.Refresh()
    End Sub

    Private Sub UpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatesToolStripMenuItem.Click
        If ProductVersion = "1" Then
            MessageBox.Show("This version is an Alpha... " + ProductVersion, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("This version is the current release... " + ProductVersion, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioToolStripMenuItem.Click
        ' Launch Audio preferences
        AudioPref.Show()
    End Sub

    Private Sub MediaPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediaPlayerToolStripMenuItem.Click
        ' Launch video player
        VideoPlayer.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        ' Show Date and Time
        ToolStripStatusLabel1.Text = Format(Now, "dd-MM-yyyy - hh:mm:ss")
    End Sub

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

    Private Sub AddNode(ByVal inXmlNode As XmlNode, ByVal inTreeNode As TreeNode)
        ' XML variables
        Dim xNode As XmlNode
        Dim tNode As TreeNode
        Dim nodeList As XmlNodeList
        Dim i As Integer

        ' Create nodes
        If inXmlNode.HasChildNodes Then
            nodeList = inXmlNode.ChildNodes
            For i = 0 To nodeList.Count - 1
                xNode = inXmlNode.ChildNodes(i)
                inTreeNode.Nodes.Add(New TreeNode(xNode.Name))
                tNode = inTreeNode.Nodes(i)
                AddNode(xNode, tNode)
            Next
        Else
            inTreeNode.Text = inXmlNode.InnerText.ToString
        End If
    End Sub

    Private Sub DownloadMaxMSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadMaxMSPToolStripMenuItem.Click
        brwContent.Navigate("https://cycling74.com/downloads/older/#.WCPnKPmLSHs")
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Copy Web Browser Text
        My.Computer.Clipboard.SetText(brwContent.DocumentText)
    End Sub

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
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        If AdminMode = 0 Then
            AdminMode = 1
        Else
            AdminMode = 0
        End If
        FormRefresh()
    End Sub
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
    Private Sub btnAddNode_Click(sender As Object, e As EventArgs) Handles btnAddNode.Click
        Dim myValue

        ' Display message, title, and default value.
        myValue = InputBox("Add New Folder", "New Node", "")
        ' If user has clicked Cancel, set myValue to defaultValue 
        If myValue Is "" Then myValue = ""

        trvTreeview.Nodes.Add(myValue)
    End Sub
    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        InitialZoom += 10
        PerformZoom(InitialZoom)
    End Sub
    Public Sub PerformZoom(ByVal Value As Integer)
        Try
            Dim Res As Object = Nothing
            Dim MyWeb As Object
            MyWeb = Me.brwContent.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, CObj(Value), CObj(IntPtr.Zero))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        InitialZoom -= 10
        PerformZoom(InitialZoom)
    End Sub
    Private Sub ZoomCurrentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomCurrentToolStripMenuItem.Click
        PerformZoom(100)
    End Sub

    Private Sub AdobeAcrobatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdobeAcrobatToolStripMenuItem.Click
        brwContent.Navigate("https://get.adobe.com/uk/reader/")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        brwContent.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        brwContent.GoForward()
    End Sub

    Private Sub OpenMaxToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Users\joshg\Desktop\testpatchbuild.mxf")
    End Sub

    Private Sub HTMLTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HTMLTestToolStripMenuItem.Click
        brwContent.Navigate("https://html5test.com/")
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

        brwContent.Navigate(myValue)
    End Sub
End Class