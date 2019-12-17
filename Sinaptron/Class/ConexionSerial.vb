Imports System.IO.Ports

Public Class ConexionSerial
    Public Shared Sub Configuracion(ByVal Conexion As SerialPort)
        Conexion.BaudRate = 19200
        Conexion.DataBits = 8
        Conexion.Parity = Parity.None
        Conexion.StopBits = StopBits.One
        Conexion.Handshake = Handshake.None
        Conexion.Encoding = System.Text.Encoding.Default 'very important!
        Conexion.ReadTimeout = 10000

    End Sub
End Class
