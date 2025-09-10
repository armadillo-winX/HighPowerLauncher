Imports System.IO

Public Class AddItemDialog
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
        openFileDialog.Filter = "実行ファイル|*.exe;*.bat;*.cmd"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PathBox.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub AddItemDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttentionLabel.Visible = False
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        If NameBox.Text.Contains("/") _
                Or NameBox.Text.Contains("\") _
                Or NameBox.Text.Contains(":") _
                Or NameBox.Text.Contains("*") _
                Or NameBox.Text.Contains("?") _
                Or NameBox.Text.Contains("""") _
                Or NameBox.Text.Contains("<") _
                Or NameBox.Text.Contains(">") _
                Or NameBox.Text.Contains("|") Then
            AttentionLabel.Visible = True
            AddButton.Enabled = False
        Else
            AttentionLabel.Visible = False
            AddButton.Enabled = True
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If (NameBox.Text.Length = 0 Or PathBox.Text.Length = 0) Then
            MessageBox.Show(Me, "何か入力してください", "アイテムの追加", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                If File.Exists($"{PathInfo.CommandDirectory}\\{NameBox.Text}") Then
                    MessageBox.Show(Me, $"{NameBox.Text} はすでに登録済みです。", "アイテムの追加",
MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    ApplicationStarter.AddApplicationCommand(NameBox.Text, PathBox.Text)
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End Try
        End If
    End Sub
End Class