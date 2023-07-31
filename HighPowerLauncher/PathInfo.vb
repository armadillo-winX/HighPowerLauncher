Imports System.IO

Module PathInfo
    Private ReadOnly _appPath As String =
        Reflection.Assembly.GetExecutingAssembly().Location

    Public ReadOnly Property AppLocation() As String
        Get
            Return Path.GetDirectoryName(_appPath)
        End Get
    End Property

    Public ReadOnly Property CommandDirectory() As String
        Get
            Return $"{AppLocation}\\commands"
        End Get
    End Property
End Module
