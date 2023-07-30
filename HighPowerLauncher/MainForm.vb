Public Class MainForm
    Private _appName As String = Application.ProductName
    Private _appVersion As String = Application.ProductVersion

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"{_appName} ver.{_appVersion}"
    End Sub
End Class
