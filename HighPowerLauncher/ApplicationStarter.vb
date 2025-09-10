Imports System.IO
Imports System.Text

Module ApplicationStarter
    Public Sub Start(ByVal applicationName As String)
        Dim applicationPath As String = GetApplicationPath(applicationName)
        Dim applicationProcessStartInfo As ProcessStartInfo = New ProcessStartInfo With {
            .FileName = applicationPath,
            .WorkingDirectory = Path.GetDirectoryName(applicationPath),
            .UseShellExecute = True
        }
        Process.Start(applicationProcessStartInfo)
    End Sub

    Public Sub OpenApplicationLocale(ByVal applicationName As String)
        Dim applicationPath As String = GetApplicationPath(applicationName)
        Dim applicationLocale As String = Path.GetDirectoryName(applicationPath)
        Process.Start("explorer.exe", applicationLocale)
    End Sub

    Public Function GetApplicationPath(ByVal applicationName As String) As String
        Dim commandsDirectory As String = PathInfo.CommandDirectory
        If File.Exists($"{commandsDirectory}\\{applicationName}") Then
            Dim stream As New StreamReader($"{commandsDirectory}\\{applicationName}", Text.Encoding.UTF8)
            Dim path As String = stream.ReadToEnd()
            stream.Close()
            Return path
        Else
            Throw New FileNotFoundException("コマンド定義ファイルが見つかりませんでした。")
        End If
    End Function

    Public Sub CreateCommandsDirectory()
        Directory.CreateDirectory(PathInfo.CommandDirectory)
    End Sub

    Public Sub AddApplicationCommand(ByVal applicationName As String, ByVal applicationPath As String)
        Dim fileStream As FileStream = File.Create($"{PathInfo.CommandDirectory}\\{applicationName}")
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(applicationPath)
        fileStream.Write(info, 0, info.Length)
        fileStream.Close()
    End Sub

    Public Sub DeleteApplicationCommand(ByVal applicaitonName As String)
        If File.Exists($"{PathInfo.CommandDirectory}\\{applicaitonName}") Then
            File.Delete($"{PathInfo.CommandDirectory}\\{applicaitonName}")
        End If
    End Sub
End Module
