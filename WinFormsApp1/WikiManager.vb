Imports System.IO
Imports System.Windows.Forms

Public Class WikiManager
    Private pagesFolder As String

    Public Sub New()
        ' Combine path using fully qualified System.IO.Path
        pagesFolder = System.IO.Path.Combine(Application.StartupPath, "WikiPages")
        If Not Directory.Exists(pagesFolder) Then
            Directory.CreateDirectory(pagesFolder)
        End If
    End Sub

    Public Sub SavePage(title As String, rtfContent As String)
        Dim safeTitle As String = MakeFilenameSafe(title)
        Dim path As String = System.IO.Path.Combine(pagesFolder, safeTitle & ".rtf")
        File.WriteAllText(path, rtfContent)
    End Sub

    Public Function LoadPage(title As String) As String
        Dim safeTitle As String = MakeFilenameSafe(title)
        Dim path As String = System.IO.Path.Combine(pagesFolder, safeTitle & ".rtf")
        If File.Exists(path) Then
            Return File.ReadAllText(path)
        Else
            Return ""
        End If
    End Function

    Public Function GetAllPages() As List(Of String)
        Dim list As New List(Of String)
        For Each file As String In Directory.GetFiles(pagesFolder, "*.rtf")
            list.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
        Return list
    End Function

    Private Function MakeFilenameSafe(name As String) As String
        Dim invalidChars As Char() = System.IO.Path.GetInvalidFileNameChars()
        For Each ch As Char In invalidChars
            name = name.Replace(ch, "_"c)
        Next
        Return name
    End Function
End Class
