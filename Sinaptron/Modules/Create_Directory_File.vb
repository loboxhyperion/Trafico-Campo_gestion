Imports System.IO

Module Create_Directory_File
    'Crea Directorios
    Function Create_Directories(Path) As String
        If Not Directory.Exists(Path) Then
            Directory.CreateDirectory(Path)
            Return "No existe"
        Else
            Return "Existe"
        End If
    End Function

    'Crea ficheros
    Function CreateFiles(Path, Interjson) As Boolean
        Dim fs As FileStream = File.Create(Path)
        fs.Close()
        'Escribe en el fichero
        My.Computer.FileSystem.WriteAllText(Path, Interjson, True)
        Return True
    End Function
End Module
