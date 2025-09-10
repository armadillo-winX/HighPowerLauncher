Imports System.IO

Public Class MainForm
    Private _appName As String = Application.ProductName
    Private _appVersion As String = Application.ProductVersion
    Private _developer As String = Application.CompanyName
    Private _windowsDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
    Private _systemDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.System)
    Private _userDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

    Private Sub StartApplication()
        If ApplicationListBox.SelectedIndex > -1 Then
            Dim applicationName As String = ApplicationListBox.SelectedItem
            Try
                Launcher.LaunchApplication(applicationName)
            Catch ex As Exception
                MessageBox.Show(Me, $"アプリケーションの起動に失敗。{Environment.NewLine}{ex.Message}", "エラー",
MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub OpenLocale()
        If ApplicationListBox.SelectedIndex > -1 Then
            Dim applicationName As String = ApplicationListBox.SelectedItem
            Try
                Launcher.OpenApplicationLocale(applicationName)
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub OpenShutdownDialog()
        Try
            Process.Start("WScript.exe", "Tools\\shutdown.vbs")
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetApplicationItems()
        ApplicationListBox.Items.Clear()
        Try
            For Each commandFile As String In My.Computer.FileSystem.GetFiles(PathInfo.CommandDirectory)
                ApplicationListBox.Items.Add(Path.GetFileName(commandFile))
            Next
        Catch ex As Exception
            MessageBox.Show(Me, $"アプリケーションアイテムの一覧の取得に失敗。{Environment.NewLine}{ex.Message}", "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddApplicationItem()
        Dim addItemDailog As AddItemDialog = New AddItemDialog()
        addItemDailog.Owner = Me
        addItemDailog.ShowDialog()
        GetApplicationItems()
    End Sub

    Private Sub RemoveApplicationItem()
        If ApplicationListBox.SelectedIndex = "-1" Then
            MessageBox.Show("削除するアイテムを選択してください。", _appName,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Select Case MessageBox.Show(
                                    "アイテム '" + ApplicationListBox.SelectedItem + "' を削除しますか？", _appName,
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    Launcher.DeleteApplicationCommand(ApplicationListBox.SelectedItem)
                    GetApplicationItems()
            End Select
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"{_appName} ver.{_appVersion}"
        Me.Location = My.MySettings.Default.MyLocation

        If Directory.Exists(PathInfo.CommandDirectory) = False Then
            Try
                Launcher.CreateCommandsDirectory()
            Catch ex As Exception
                MessageBox.Show(Me, $"コマンド定義ファイル保存ディレクトリの生成に失敗。{Environment.NewLine}アプリケーションを終了します。", "エラー",
MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            GetApplicationItems()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim versionInfo As String = $"{_appName} version{_appVersion}{Environment.NewLine}By {_developer}"
        MessageBox.Show(Me, versionInfo, "バージョン情報",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        Me.Activate()
    End Sub

    Private Sub LaunchButton_Click(sender As Object, e As EventArgs) Handles LaunchButton.Click
        StartApplication()
    End Sub

    Private Sub ApplicationListBox_DoubleClick(sender As Object, e As EventArgs) Handles ApplicationListBox.DoubleClick
        StartApplication()
    End Sub

    Private Sub OpenLocaleButton_Click(sender As Object, e As EventArgs) Handles OpenLocaleButton.Click
        OpenLocale()
    End Sub

    Private Sub ReloadItemButton_Click(sender As Object, e As EventArgs) Handles ReloadItemButton.Click
        GetApplicationItems()
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        GetApplicationItems()
    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        AddApplicationItem()
    End Sub

    Private Sub RemoveItemButton_Click(sender As Object, e As EventArgs) Handles RemoveItemButton.Click
        RemoveApplicationItem()
    End Sub

    Private Sub AddItemMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemMenuItem.Click
        AddApplicationItem()
    End Sub

    Private Sub RemoveItemMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemMenuItem.Click
        RemoveApplicationItem()
    End Sub

    Private Sub ShutDownButton_Click(sender As Object, e As EventArgs) Handles ShutDownButton.Click
        OpenShutdownDialog()
    End Sub

    Private Sub LaunchPowershellMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchPowershellMenuItem.Click
        Try
            Dim pshellStartInfo As ProcessStartInfo = New ProcessStartInfo()
            pshellStartInfo.FileName = "powershell.exe"
            pshellStartInfo.WorkingDirectory = _userDirectory
            Process.Start(pshellStartInfo)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LaunchExplorerMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchExplorerMenuItem.Click
        Try
            Dim explorerStartInfo As ProcessStartInfo = New ProcessStartInfo()
            explorerStartInfo.FileName = $"{_windowsDirectory}\\explorer.exe"
            Process.Start(explorerStartInfo)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LaunchRegeditMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchRegeditMenuItem.Click
        Try
            Dim regeditStartInfo As ProcessStartInfo = New ProcessStartInfo()
            regeditStartInfo.FileName = $"{_windowsDirectory}\\regedit.exe"
            regeditStartInfo.Verb = "runas"
            regeditStartInfo.UseShellExecute = True
            Process.Start(regeditStartInfo)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LaunchTaskmgrMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchTaskmgrMenuItem.Click
        Try
            Dim taskMgrStartInfo As ProcessStartInfo = New ProcessStartInfo()
            taskMgrStartInfo.FileName = $"{_systemDirectory}\\taskmgr.exe"
            taskMgrStartInfo.Verb = "runas"
            taskMgrStartInfo.UseShellExecute = True
            Process.Start(taskMgrStartInfo)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddStartupMenuItem_Click(sender As Object, e As EventArgs) Handles AddStartupMenuItem.Click
        Select Case MessageBox.Show(
        "スタートアップに登録しますか？", _appName,
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Try
                    Dim regkey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                    regkey.SetValue(Application.ProductName, Application.ExecutablePath)
                    regkey.Close()
                    MessageBox.Show("スタートアップに登録しました。", _appName,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(Me, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.MySettings.Default.MyLocation = Me.Location
        My.MySettings.Default.Save()
    End Sub
End Class
