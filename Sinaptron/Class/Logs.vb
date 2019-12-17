Imports System.IO

Public Class Logs
    Public Shared Sub Guardar(accion As String)
        Try
            Dim Path As String = "acciones.txt"
            Dim Esc As New StreamWriter(Path, True)
            Esc.WriteLine(Date.Now & " :" & "El operario" & ", " & accion)
            Esc.Close()
        Catch ex As Exception
            MsgBox("no se pudo hacer la escritura")
        End Try

    End Sub
End Class
