Public Class ServidorConexion
    Shared Pross As Process = New Process
    Public Shared Sub AbrirServidor()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("servidor.txt")

        'Dim Pross As Process = New Process
        Console.WriteLine("Iniciando processo")
        Console.ReadLine()
        Pross.StartInfo.FileName = fileReader
        Pross.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        Pross.Start()
        Console.ReadLine()

    End Sub

    Public Shared Sub CerrarServidor()
        Try
            Pross.Kill()
        Catch ex As Exception
            'MsgBox("No se puede cerrar el processo")
        End Try

    End Sub
End Class
