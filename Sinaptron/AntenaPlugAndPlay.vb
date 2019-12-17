Imports System.IO.Ports
Imports System.Net.NetworkInformation
Public Class AntenaPlugAndPlay
    Dim comPORT As String 'guarda el puerto COM de la antena
    Dim receivedData As String = "" 'Almacena la trama captada
    Dim ComPortList As New List(Of String) 'Almacena los COM Disponibles 
    Dim Contador As Integer = 0 'Limita el tiempo sin atena para cerrar el programa

    Private Sub AntenaPlugAndPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializo el puerto //////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        comPORT = ""
        ConexionSerial.Configuracion(Conexion)
        'Conexion.BaudRate = 19200
        'Conexion.DataBits = 8
        ' Conexion.Parity = Parity.None
        ' Conexion.StopBits = StopBits.One
        ' Conexion.Handshake = Handshake.None
        ' Conexion.Encoding = System.Text.Encoding.Default 'very important!
        ' Conexion.ReadTimeout = 1000

    End Sub

    'COMPROBACIÓN DE PUERTOS //////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub tmrPuertoCom_Tick(sender As Object, e As EventArgs) Handles tmrPuertoCom.Tick
        Try
            'verifica si hay puertos COM 
            If (My.Computer.Ports.SerialPortNames).Count > 0 Then
                If (Contador = 0 Or Contador <= 6) Then
                    InOutAntenna(20, "CONECTE LA ANTENA", 265, 184, 374, 229)
                End If
                'Recorre los puertos COM dispnibles
                For Each sp As String In My.Computer.Ports.SerialPortNames
                    comPORT = sp
                    If comPORT <> "" Then
                        Conexion.Close()
                        Conexion.PortName = comPORT
                        Conexion.Open()

                        tmrEscuchando.Enabled = True

                        Conexion.Write("?")
                        Conexion.DiscardInBuffer()
                    End If
                    Console.WriteLine(comPORT)
                Next
            Else
                If (Contador = 0 Or (Contador > 6 And Contador <= 20)) Then
                    InOutAntenna(6, "NO HAY ANTENA CONECTADA", 218, 184, 383, 229)
                End If

            End If
        Catch ex As Exception
            Console.WriteLine("SIN CONEXION")
        End Try

    End Sub

    Private Sub InOutAntenna(time As Integer, message As String, xAntenna As Integer, yAntenna As Integer, xTime As Integer, yTime As Integer)
        Contador = time
        tmrContador.Enabled = True
        'Si no hay puertos disponibles se cierra el programa automaticamente
        lblMessageAntena.Text = message
        lblMessageAntena.Location = New Point(xAntenna, yAntenna)
        lblTimeOut.Text = time
        lblTimeOut.Location = New Point(xTime, yTime)
    End Sub

    Private Sub tmrEscuchando_Tick(sender As Object, e As EventArgs) Handles tmrEscuchando.Tick
        Try
            receivedData = ReceiveSerialData()
            Conexion.DiscardInBuffer()

            If receivedData <> "" Then
                If Len(receivedData) = 27 Then
                    Dim Mac As String
                    Mac = getMacAddress()
                    'If Mac = Mid(receivedData, 15, 12) Then
                    'MsgBox("Correcto")
                    tmrEscuchando.Enabled = False
                    tmrPuertoCom.Enabled = False
                    tmrContador.Enabled = False
                    Conexion.Close()
                    LoginForm.Show()
                    'Permite que se cierre el formulario cuando se cierre el segundo
                    Me.Owner = LoginForm
                    Me.Hide()
                    'Else
                    ' MsgBox("Incorrecto")
                    ' End If
                End If

                End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Console.WriteLine("se desconecto la antena")

        End Try
    End Sub

    'Revisa si llego algo en el puerto serial
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = Conexion.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        'devuelve la mac del ethernet 
        Return nics(0).GetPhysicalAddress.ToString
    End Function

    Private Sub tmrContador_Tick(sender As Object, e As EventArgs) Handles tmrContador.Tick
        'TimeLimitWithOutAntenna()
        Console.WriteLine("pase")
        Contador -= 1
        Console.WriteLine(Contador)
        lblTimeOut.Text = Contador
        If Contador = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub TimeLimitWithOutAntenna()
        Contador -= 1
        lblTimeOut.Text = Contador
        If Contador = 0 Then
            Me.Close()
        End If
    End Sub
End Class