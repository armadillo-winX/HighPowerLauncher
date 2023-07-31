Public Class MainForm
    Private _appName As String = Application.ProductName
    Private _appVersion As String = Application.ProductVersion
    Private _developer As String = Application.CompanyName

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"{_appName} ver.{_appVersion}"
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim versionInfo As String = $"{_appName} version{_appVersion}{Environment.NewLine}By {_developer}"
        MessageBox.Show(Me, versionInfo, "バージョン情報",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
