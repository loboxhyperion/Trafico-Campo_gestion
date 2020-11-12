Imports System.IO.Ports
Imports System.Net.NetworkInformation
Imports Gmap.net.MapProviders
Imports Gmap.net
Imports Gmap.net.WindowsForms
Imports Gmap.net.WindowsForms.Markers
Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class SnPrincipal
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim nrenglon As Integer
    Dim entanalog As Integer
    Dim voltaje As Double
    Dim data As String
    Dim TRojo As String
    Dim TAmarillo As String
    Dim Tverde As String
    Dim minumhex As String
    Dim minumdec As Double
    Dim VOLTBATERIA1 As String = ""
    Dim VOLTPANEL1 As String = ""
    Dim ACTUALESTDC1 As String = ""
    Dim VOLTBATERIA2 As String = ""
    Dim VOLTPANEL2 As String = ""
    Dim ACTUALESTDC2 As String = ""

    Dim RegEstado1 As String = ""
    Dim RegHora1 As String = ""
    Dim RegMinuto1 As String = ""
    Dim RegEstado2 As String = ""
    Dim RegHora2 As String = ""
    Dim RegMinuto2 As String = ""

    Dim RegNumFcom1 As String = ""
    Dim RegNumFcom2 As String = ""

    Dim flagAudio1 As Integer
    Dim flagAudio2 As Integer




    Dim numletras As Integer
    Dim posicionX0 As String
    Dim posicionY0 As String
    Dim posicionX1 As String
    Dim posicionY1 As String
    Dim posicionX2 As String
    Dim posicionY2 As String
    Dim datoEE As String
    Dim datoCMD As String
    Dim datoADR1 As String
    Dim datoADR0 As String
    Dim datoDATO0 As String

    Dim VarCalVolt As Integer

    Dim ValRojo1 As String
    Dim ValVerde1 As String
    Dim ValAmar1 As String

    Dim DatNVenergy As String

    'Formato del Sinpatron
    Dim SnFormat As DeserializeFormat

    Dim Modelsinaptron As Sinaptron = New Sinaptron() 'almacena todos los datos generales del sinpatron en el modelo de datos establecido

    Dim Flag1 As Boolean = True
    Dim Flag2 As Boolean = False
    Dim Flag3 As Boolean = False
    Dim Flag4 As Boolean = False
    Dim Flag5 As Boolean = False
    Dim Flag6 As Boolean = False

    Dim FlagConsultaMapa As Boolean
    Dim ExisteRegis As Boolean = False

    Dim LimitTime As Integer = 15 ' evita que al enviar los comandos de consulta no se quede en bucle infinito

    Dim FlagNodos = False

    Dim SinaptronMapa As PictureBox
    Dim ListSemaforos As New List(Of PictureBox)
    Dim ListSemaforosX As New List(Of Integer)
    Dim ListSemaforosY As New List(Of Integer)
    Dim ListX As New List(Of TextBox)
    Dim ListY As New List(Of TextBox)
    Dim CountSemaforo As Integer

    Public comando As New comandos() ' sirve para poder separar los comandos en un modulo
    Dim PreTiempoOptica As Integer

    Dim FlagPrevNext = False 'Decide si se va hacer el antes y el despues de un valor enviado(tiempos semaforo)
    Dim TiempoPre As Integer 'Almacena el tiempo  anterior(rojo,amarillo,verde)
    Dim TiempoNext As Integer 'Almacena el tiempo posterior(rojo,amarillo,verde)
    Private Sub SnPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Permisos()
        ' For index = 1 To 600
        Log.Guardar("Ingresó al Programa!")
        '  Next
        'Log.Guardar("Ingresó al Programa!")

        'Inicializo el puerto
        ConexionSerial.Configuracion(Conexion)
        'comPORT = ""

        nrenglon = 0

        picSemaforo.Visible = True

        flagAudio1 = 0

        VarCalVolt = 151

        If My.Computer.Network.IsAvailable Then
            'WebBrowser1.Navigate("https://www.google.com/maps/place/Corporaci%C3%B3n+de+Ferias+y+Exposiciones+-+Corferias/@4.6282494,-74.0914433,15z/data=!4m5!3m4!1s0x0:0x3f449bb47da9bef3!8m2!3d4.6294899!4d-74.0900271")
        Else
            MsgBox("El internet no esta habilitado", MsgBoxStyle.Critical)
        End If

        ' ConsultarTodo()
        'alamacena la red de nodos en x y en y
        'S
        ListSemaforosX.Add(405)
        ListSemaforosY.Add(240)
        For y = 49 To 432
            For x = 76 To 735
                If x = 405 And y = 240 Then
                Else
                    ListSemaforosY.Add(y)
                    ListSemaforosX.Add(x)
                End If

                x += 329 - 1
            Next
            y += 191 - 1

        Next
        'X
        ListX.Add(TextBox9)
        ListX.Add(TextBox1)
        ListX.Add(TextBox3)
        ListX.Add(TextBox5)
        ListX.Add(TextBox7)
        ListX.Add(TextBox11)
        ListX.Add(TextBox13)
        ListX.Add(TextBox15)
        ListX.Add(TextBox17)
        'Y
        ListY.Add(TextBox10)
        ListY.Add(TextBox2)
        ListY.Add(TextBox4)
        ListY.Add(TextBox6)
        ListY.Add(TextBox8)
        ListY.Add(TextBox12)
        ListY.Add(TextBox14)
        ListY.Add(TextBox16)
        ListY.Add(TextBox18)
    End Sub
    Private Sub Permisos()
        If LoginForm.permisos.Rol = "operario" Then
            GroupBox2.Enabled = False
            GroupBox6.Enabled = False
            GroupBox7.Enabled = False
        End If
    End Sub

    'Crea  la representacion de un Sinpatron
    Private Function Create_Sn_Shape(snposX As String, snposY As String, tipo As String, index As Integer) As PictureBox
        Console.WriteLine(index)
        'Crea Sinaptron
        SinaptronMapa = New PictureBox()
        SinaptronMapa.Name = snposX + snposY
        SinaptronMapa.Size = New Size(51, 97)
        SinaptronMapa.Location = New Point(ListSemaforosX.Item(index), ListSemaforosY.Item(index))
        SinaptronMapa.Image = Image.FromFile("..\..\img\" + tipo + ".png")
        SinaptronMapa.SizeMode = PictureBoxSizeMode.StretchImage
        SinaptronMapa.TabIndex = 1S
        AddHandler SinaptronMapa.Click, AddressOf ShapeClick

        ListSemaforos.Add(SinaptronMapa)
        Panel1.Controls.Add(SinaptronMapa)

        'Guardar el Sinaptron cargado en una lista que servira para visualizarlos luego
        'ListSemaforos.Add(SinaptronMapa)

        Return SinaptronMapa
    End Function
    'Muestra las opciones del sinaptron
    Private Sub ShapeClick(sender As Object, e As EventArgs)
        SinaptronMapa = DirectCast(sender, PictureBox)
        txtPosX2.Text = Mid(SinaptronMapa.Name, 1, 3)
        txtPosX2.ForeColor = Color.Red
        txtPosY2.Text = Mid(SinaptronMapa.Name, 4, 3)
        txtPosY2.ForeColor = Color.Red
        ' MsgBox(SinaptronMapa.Name)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Conexion y Clasificacion de la información 
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub tmrPuertoCom_Tick(sender As Object, e As EventArgs) Handles tmrPuertoCom.Tick
        Try
            For Each sp As String In My.Computer.Ports.SerialPortNames
                comPORT = sp
                'If Not ComPortList.Contains(sp) Then
                'ComPortList.Add(sp)
                'cboxPuerto.Items.Add(sp)
                'End If
                If comPORT <> "" Then
                    Conexion.Close()
                    Conexion.PortName = comPORT
                    Conexion.Open()


                    Timer1.Enabled = True

                    Conexion.Write("?")
                    Conexion.DiscardInBuffer()

                End If
                Console.WriteLine(comPORT)
            Next
        Catch ex As Exception
            Console.WriteLine("Sin CONEXION")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            receivedData = ReceiveSerialData()
            Conexion.DiscardInBuffer()
            If receivedData.Length <> 0 Then
                Console.WriteLine(receivedData.Length)
            End If
            If Len(receivedData) = 4 Then
                picEstadoPort.BackColor = Color.LimeGreen
                tmrPuertoCom.Enabled = False
            End If

            If receivedData <> "" Then
                If Len(receivedData) >= 32 And Len(receivedData) <= 66 And Mid(receivedData, 1, 2) = "RF" And Mid(receivedData, 28, 4) <> "2330" Then
                    'Acciones
                    ' RichTextBox2.Text &= receivedData
                    RichTextBox2.Text &= "Recibido" & vbCrLf
                    SnFormat = New DeserializeFormat(receivedData)

                    ClasificarCM(SnFormat)
                ElseIf Len(receivedData) >= 32 And Len(receivedData) <= 66 And Mid(receivedData, 1, 2) = "PC" Then
                    RichTextBox2.Text &= "Antena" & vbCrLf
                Else
                    ' en Eventos
                    'RichTextBox1.Text &= receivedData
                    RichTextBox1.Text &= "Recibido" & vbCrLf
                End If

                'RichTextBox2.Text &= receivedData
                'Console.WriteLine(receivedData)


                'Console.WriteLine(receivedData)
                RichTextBox2.ForeColor = Color.Yellow

                If receivedData <> "" Then
                    nrenglon = nrenglon + 1
                    If nrenglon > 8 Then
                        RichTextBox2.Text = ""

                        nrenglon = 0
                    End If

                End If
                receivedData = ""
            End If
        Catch ex As Exception
            Timer1.Enabled = False
            picEstadoPort.BackColor = Color.Red
            MessageBox.Show("SE PERDIO LA CONEXION CON LA ANTENA")
            tmrPuertoCom.Enabled = True
            'Me.Close()
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

    Private Sub tmrSimulacion_Tick(sender As Object, e As EventArgs) Handles tmrSimulacion.Tick
        Dim Simula As String = "RF-858886888488FFFF000000B423XX85880000000000000000000000000052."
        SnFormat = New DeserializeFormat(Simula)
        ClasificarCM(SnFormat)
    End Sub

    'Clasifica la información de acuerdo  al CM 
    Private Sub ClasificarCM(snFormat)
        Console.WriteLine(snFormat.CM)
        Console.WriteLine(snFormat.A1)
        Console.WriteLine(snFormat.A0)
        If snFormat.UU = "RF" Then
            If snFormat.CM = "91" Or snFormat.CM = "B1" Then
                RichTextBox2.Text &= "ESTADO DE LA BATERÍA RECIBIDO" & vbCrLf
                RichTextBox2.ForeColor = Color.Lime
                'MsgBox("Modulo Antena")
                ProcesarModulos(snFormat, "Antena")
            ElseIf snFormat.CM = "92" Then
                ' MsgBox("Modulo Ambiental")
                ProcesarModulos(snFormat, "Ambiental")
                'ProcesarModulos(snFormat, "Antena")
            ElseIf snFormat.CM = "93" Then
                'MsgBox("Modulo de Seguridad")
                ProcesarModulos(snFormat, "Seguridad")
            ElseIf snFormat.CM = "94" Then
                ProcesarModulos(snFormat, "Trafico")
                ' MsgBox("Modulo de Trafico")
            ElseIf snFormat.CM = "95" Then
                ' MsgBox("Modulo secundario de semaforo")
            ElseIf snFormat.CM = "96" Then
                'MsgBox("Modulo de configuracion del Sinaptron")
                If snFormat.A1 = "23" And snFormat.A0 = "00" Then
                    ProcesarModulos(snFormat, "Tiempo")
                ElseIf snFormat.A1 = "23" And snFormat.A0 = "10" Then
                    ProcesarModulos(snFormat, "Posicion")
                ElseIf snFormat.A1 = "23" And snFormat.A0 = "20" Then
                    ProcesarModulos(snFormat, "Bateria")
                End If
            ElseIf snFormat.CM = "97" Then
                MsgBox("Modulo de configuracion del Sinaptron")
                ProcesarModulos(snFormat, "Integridad")
            End If
            'VERIFICA QUE LLEGUE LOS DATOS
            'prender
            ' If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "14" And snFormat.D0.ToString = "BD" Then
            ' Log.Guardar("Prendió el semáforo! " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            ' End If
            'Apagar
            'If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "14" And snFormat.D0.ToString = "A5" Then
            'Log.Guardar("Apagó el semáforo! " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            'End If
            'Precaución roja
            ' If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "14" And snFormat.D0.ToString = "54" Then
            ' Log.Guardar("Activó la intermitencia roja del semáforo " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            'End If
            'Precaución amarilla
            ' If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "14" And snFormat.D0.ToString = "53" Then
            ' Log.Guardar("Activó la intermitencia amarilla  del semáforo " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            'End If
            'Opticas
            '  If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "14" And snFormat.D0.ToString = "C5" Then
            '  Log.Guardar("Probo las opticas del semáforo! " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            'End If
            'Sensores
            ' If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "14" And snFormat.D0.ToString = "C3" Then
            'Log.Guardar("Probo los sensores del semáforo! " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            'End If
            'Rojo
            ' If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "20" Then
            'Log.Guardar("Se envió tiempo del rojo con " & ValRojo1 & " segundos " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            ' End If
            'Amarillo
            'If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "25" Then
            ' Log.Guardar("Se envió tiempo del amarillo con " & ValAmar1 & " segundos " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            'End If
            'Verde
            'If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "23" Then
            'Log.Guardar("Se envió tiempo del verde con " & ValVerde1 & " segundos " + " en Sinptron X:" + snFormat.X2 + " Y:" + snFormat.y2)
            'End If

            'CONSULTAS
            'Batería
            If snFormat.CM = "81" Then

                If Flag1 = True Then
                    txtSnX.Text = CInt("&H" & snFormat.X2)
                    txtSnY.Text = CInt("&H" & snFormat.Y2)

                    txtNVBatt.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                    Flag1 = False
                    Flag2 = True
                ElseIf Flag2 = True Then
                    txtNVPanel.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                    Flag2 = False
                    Flag3 = True
                ElseIf Flag3 = True Then
                    txtStatusE.Text = snFormat.D0
                    Flag3 = False
                End If

            End If
            'Tiempos 

            'Tiempos 
            If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "FF" Then
                TiempoPre = snFormat.D0

                If Flag1 = True Then
                    txtRed.Text = snFormat.D0
                    Flag1 = False
                    If FlagPrevNext = True Then
                        Threading.Thread.Sleep(500)
                        SendTiempos("rojo")
                    End If
                    ' Flag5 = True
                ElseIf Flag2 = True Then
                    txtAmbar.Text = snFormat.D0
                    Flag2 = False
                    If FlagPrevNext = True Then
                        Threading.Thread.Sleep(500)
                        SendTiempos("amarillo")
                    End If
                ElseIf Flag3 = True Then

                    txtGreen.Text = snFormat.D0
                    Flag3 = False
                    If FlagPrevNext = True Then
                        Threading.Thread.Sleep(500)
                        SendTiempos("verde")
                    End If
                End If
            End If

            'Mapa de nodos
            If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "XX" Then
                Console.WriteLine("Pase por aqui")

                If FlagNodos = False Then
                    Log.Guardar("Se consulto el Mapa de nodos desde " + "x:" + snFormat.X2 + " Y:" + snFormat.y2)
                    FlagNodos = True
                    Create_Sn_Shape(snFormat.D0, snFormat.D1, "Icono", CountSemaforo)
                Else
                    Create_Sn_Shape(snFormat.D0, snFormat.D1, "TrafficOn", CountSemaforo)
                End If

                ListX.Item(CountSemaforo).Text = snFormat.D0
                ListX.Item(CountSemaforo).Visible = True
                ListY.Item(CountSemaforo).Text = snFormat.D1
                ListY.Item(CountSemaforo).Visible = True
                CountSemaforo += 1
                If CountSemaforo = 9 Then
                    tmrSimulacion.Enabled = False
                End If

            End If

        End If

    End Sub


    Private Sub ProcesarModulos(snFormat, TipModulo)
        '/////////////////////////////////ACCIONES A TOMAR SEGUN LOS MODULOS/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If TipModulo = "Antena" Then

            txtSnX.Text = CInt("&H" & snFormat.X0)
            txtSnY.Text = CInt("&H" & snFormat.Y0)
            txtNVBatt.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
            txtNVPanel.Text = Format((snFormat.D1 * 10) / VarCalVolt, "0.00")
            txtStatusE.Text = snFormat.D2


        ElseIf TipModulo = "Trafico" Then
            RichTextBox2.Text &= "Recibido" & vbCrLf
        ElseIf TipModulo = "Secundario" Then
        ElseIf TipModulo = "Configuracion" Then
        ElseIf TipModulo = "Bateria" Then
        ElseIf TipModulo = "Posicion" Then
        ElseIf TipModulo = "Tiempo" Then
        ElseIf TipModulo = "Integridad" Then
        End If
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub ComprobanteDeAcciones(trama As String, mensaje As String)
        'Console.WriteLine(trama.Length)
        If (Val(txtPosX0.Text) <> 0 And Val(txtPosY0.Text) <> 0) And (Val(txtPosX1.Text) <> 0 And Val(txtPosY1.Text) <> 0) And (Val(txtPosX2.Text) <> 0 And Val(txtPosY2.Text) <> 0) Then
            ConsolaMensajeEnviado()
            Log.Guardar(mensaje)
            Conexion.DiscardOutBuffer()
            Conexion.Write(trama)
        Else
            MsgBox("No se pudo realizar la acción")
        End If

    End Sub
    'SECCIÓN PARA ENVIAR INFORMACIÓN POR LA TRAMA
    'Optimiza  sacar la informacion de lo que hay en
    Function PositionSn() As String
        posicionX0 = Hex(Val(txtPosX0.Text))
        posicionY0 = Hex(Val(txtPosY0.Text))

        posicionX1 = Hex(Val(txtPosX1.Text))
        posicionY1 = Hex(Val(txtPosY1.Text))

        posicionX2 = Hex(Val(txtPosX2.Text))
        posicionY2 = Hex(Val(txtPosY2.Text))

        'datoEE = EE.Text
        datoEE = "00"

        'Desactiva el estado de intermitencia y coloca la imagen apagado
        picSemaforo.Image = Image.FromFile("..\..\img\TrafficOff.png")
        picSemaforo.SizeMode = PictureBoxSizeMode.StretchImage

        tmrIntermitencias.Enabled = False
        tmrIntermAmarilla.Enabled = False

    End Function

    Function ConsolaMensajeEnviado() As String
        RichTextBox1.Text &= "Enviado" & vbCrLf
    End Function
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'SEMAFOROS
    'TIEMPOS
    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        TiempoNext = txtRed.Text
        ConsultarTiempos("rojo", True)
        'PositionSn()
        ' ValRojo1 = Hex(Val(txtRed.Text))
        ' Log.Guardar("Se envió tiempo del rojo con " & ValRojo1 & " segundos")

        ' RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000942314A5000000000000000000000000000052." + vbCrLf

        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        'data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42320" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        'ComprobanteDeAcciones(data, "Se envió tiempo del rojo con " & ValRojo1 & " segundos")

    End Sub

    Private Sub btnAmbar_Click(sender As Object, e As EventArgs) Handles btnAmbar.Click
        TiempoNext = txtAmbar.Text
        ConsultarTiempos("amarillo", True)
        ' PositionSn()

        ' ValAmar1 = Hex(Val(txtAmbar.Text))

        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42325" + ValAmar1.PadLeft(2, "0") + "000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        ' data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42325" + ValAmar1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ' ComprobanteDeAcciones(data, "Se envió tiempo del amarillo con " & ValAmar1 & " segundos")


    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        TiempoNext = txtGreen.Text
        ConsultarTiempos("verde", True)
        ' PositionSn()

        ' ValVerde1 = Hex(Val(txtGreen.Text))
        'Log.Guardar("Se envió tiempo del verde con " & ValVerde1 & " segundos")


        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42323" + ValVerde1.PadLeft(2, "0") + "000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        'data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42323" + ValVerde1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        'ComprobanteDeAcciones(data, "Se envió tiempo del verde con " & ValVerde1 & " segundos")
        ' Console.WriteLine(data.Length)
        ' Console.WriteLine(RichTextBox2.TextLength)


    End Sub

    Private Sub btnTiempoRojo_Click(sender As Object, e As EventArgs) Handles btnTiempoRojo.Click
        Log.Guardar("Consultó tiempo del rojo")
        'txtRed.Text = "0"
        ' LimitTime = 15
        ' PositionSn()
        ' ValRojo1 = Hex(Val("0"))
        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42320" + ValRojo1.PadLeft(2, "0") + "000000000000000000000000000052." + vbCrLf
        ' ConsolaMensajeEnviado()
        'Flag4 = True
        ' tmrRojo.Enabled = False
        ' tmrRojo.Enabled = True
        Flag1 = True
        ConsultarTiempos("rojo", False)
    End Sub


    Private Sub btnTiempoAmarillo_Click(sender As Object, e As EventArgs) Handles btnTiempoAmarillo.Click
        Log.Guardar("Consultó tiempo del amarillo")
        ConsultarTiempos("amarillo", False)
        Flag2 = True
    End Sub

    Private Sub btnTiempoVerde_Click(sender As Object, e As EventArgs) Handles btnTiempoVerde.Click
        Log.Guardar("Consultó tiempo del verde")
        ConsultarTiempos("verde", False)
        Flag3 = True
    End Sub
    Private Sub ConsultarTiempos(Color As String, Permiso As Boolean)
        'determina si  se hace la consulta  pre y post del envio de tiempos
        FlagPrevNext = Permiso
        If Color = "rojo" Then
            txtRed.Text = "0"
            Flag1 = True
        End If
        If Color = "amarillo" Then
            txtAmbar.Text = "0"
            Flag2 = True
        End If
        If Color = "verde" Then
            txtGreen.Text = "0"
            Flag3 = True
        End If
        LimitTime = 15
        PositionSn()
        ValRojo1 = Hex(Val("0"))
        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42320" + ValRojo1.PadLeft(2, "0") + "000000000000000000000000000052." + vbCrLf
        ConsolaMensajeEnviado()
        tmrRojo.Enabled = False
        tmrRojo.Enabled = True
    End Sub



    Private Sub SendTiempos(Color As String)
        If Color = "rojo" Then
            PositionSn()

            ValRojo1 = Hex(Val(TiempoNext))
            txtRed.Text = ValRojo1
            data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42320" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
            ComprobanteDeAcciones(data, "Se envió tiempo del rojo con " & ValRojo1 & " segundos, el valor anterior era de " & TiempoPre & " segundos")
        End If
        If Color = "amarillo" Then
            PositionSn()

            ValAmar1 = Hex(Val(TiempoNext))
            txtAmbar.Text = ValAmar1
            data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42325" + ValAmar1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
            ComprobanteDeAcciones(data, "Se envió tiempo del amarillo con " & ValAmar1 & " segundos, el valor anterior era de " & TiempoPre & " segundos")

        End If
        If Color = "verde" Then
            PositionSn()

            ValVerde1 = Hex(Val(TiempoNext))
            txtGreen.Text = ValVerde1

            data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42323" + ValVerde1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
            ComprobanteDeAcciones(data, "Se envió tiempo del verde con " & ValVerde1 & " segundos, el valor anterior era de " & TiempoPre & " segundos")

        End If
    End Sub
    Dim countRed As Integer = 1
    'timer para enviar la señal de consulta según el color 
    Private Sub tmrRojo_Tick(sender As Object, e As EventArgs) Handles tmrRojo.Tick

        If LimitTime > 0 Then

            If (Flag1 = True) Then
                data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000842320" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
                Conexion.DiscardOutBuffer()
                Conexion.Write(data)
            ElseIf (Flag2 = True) Then
                data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000842325" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
                Conexion.DiscardOutBuffer()
                Conexion.Write(data)
            ElseIf (Flag3 = True) Then
                data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000842323" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
                Conexion.DiscardOutBuffer()
                Conexion.Write(data)
            Else
                tmrRojo.Enabled = False
            End If
        Else
            tmrRojo.Enabled = False
        End If

        LimitTime -= 1

    End Sub
    Private Sub btnTiemposConsultar_Click(sender As Object, e As EventArgs) Handles btnTiemposConsultar.Click
        'False para cargar la consulta en la pantalla de menu
        InicializarConsultaTiempos(False)
    End Sub

    Private Sub btnTiempoConsultarMap_Click(sender As Object, e As EventArgs)
        'True  cargar la consulta en el despliege del mapa
        InicializarConsultaTiempos(True)
    End Sub
    '
    Private Sub InicializarConsultaTiempos(flag)
        FlagConsultaMapa = flag
        PositionSn()

        ValRojo1 = Hex(Val("0"))

        'Reinicia los valores 
        Flag4 = True
        Flag5 = False
        Flag6 = False

        tmrTiemposSemaforo.Enabled = True
        ConsolaMensajeEnviado()
    End Sub
    Private Sub tmrTiemposSemaforo_Tick(sender As Object, e As EventArgs) Handles tmrTiemposSemaforo.Tick
        If Flag4 = True Then
            'Rojo
            data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000842320" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        End If

        If Flag5 = True Then
            'Ambar
            data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000842325" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        End If

        If Flag6 = True Then
            'Verde
            data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000842323" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        End If

        Conexion.DiscardOutBuffer()
        Conexion.Write(data)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'FUNCIONALIDADES
    Private Sub btnPrecaucion_Click(sender As Object, e As EventArgs) Handles btnPrecaucion.Click
        'Log.Guardar("Activo la intermitencia roja")

        PositionSn()
        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B4231454000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B4231454000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ComprobanteDeAcciones(data, "Activo la intermitencia roja  en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))

        'Intermitencia roja
        ' tmrIntermitencias.Enabled = True
        'tmrIntermAmarilla.Enabled = False

        picSemaforo.Image = Image.FromFile("..\..\img\TrafficOff.png")
        picSemaforo.SizeMode = PictureBoxSizeMode.StretchImage
        FlagLight = False


    End Sub

    Private Sub btnPrecaucion2_Click(sender As Object, e As EventArgs) Handles btnPrecaucion2.Click
        ' Log.Guardar("Activo la intermitencia amarilla")

        PositionSn()

        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B4231453000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B4231453000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ComprobanteDeAcciones(data, "Activo la intermitencia amarilla  en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))

        'Intermitencia Ambar
        'tmrIntermitencias.Enabled = False
        'tmrIntermAmarilla.Enabled = True

        picSemaforo.Image = Image.FromFile("..\..\img\TrafficOff.png")
        picSemaforo.SizeMode = PictureBoxSizeMode.StretchImage
        FlagLight = False


    End Sub

    Private Sub btnPrender_Click(sender As Object, e As EventArgs) Handles btnPrender.Click
        's
        PositionSn()


        ' RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42314BD000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42314BD000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ComprobanteDeAcciones(data, "Prendió el semáforo! en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))



    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click

        PositionSn()


        ' RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000942314A5000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42314A5000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ComprobanteDeAcciones(data, "Apagó el semáforo!  en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    'SECCION DE ENTRADAS Y SALIDAS
    Private Sub btnTryOut_Click(sender As Object, e As EventArgs) Handles btnTryOut.Click

        PositionSn()


        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42314C5000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42314C5000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ComprobanteDeAcciones(data, "Probo las Ópticas  en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))

    End Sub

    Private Sub btnTryIn_Click(sender As Object, e As EventArgs) Handles btnTryIn.Click

        PositionSn()

        ' RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42314C3000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42314C3000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ComprobanteDeAcciones(data, "Probo los sensores  en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))

    End Sub

    Private Sub btnOffTest_Click(sender As Object, e As EventArgs) Handles btnOffTest.Click


        PositionSn()
        ' RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000942314A5000000000000000000000000000052." + vbCrLf
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42314A5000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ComprobanteDeAcciones(data, "Apagó la Prueba de los sensores  en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    'SECCION DE RESET
    Private Sub btnAutoReset_Click(sender As Object, e As EventArgs)
        PositionSn()

        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "000094250008090401020000000000000000000000." + vbCrLf
        ConsolaMensajeEnviado()
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B420FC44000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        Conexion.DiscardOutBuffer()
        Conexion.Write(data)
        Console.WriteLine(data.Length)
    End Sub

    Private Sub btnDesAutoReset_Click(sender As Object, e As EventArgs)
        PositionSn()

        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "000094250008090401020000000000000000000000." + vbCrLf
        ConsolaMensajeEnviado()
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B420FC33000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        Conexion.DiscardOutBuffer()
        Conexion.Write(data)

    End Sub

    Private Sub btnResetTotal_Click(sender As Object, e As EventArgs)
        PositionSn()


        'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "000094250008090401020000000000000000000000." + vbCrLf
        ConsolaMensajeEnviado()
        'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B420ECA7000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000000."
        Conexion.DiscardOutBuffer()
        Conexion.Write(data)

    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'SECCION DE BATERÍA
    Private Sub btnBateriaConsulta_Click(sender As Object, e As EventArgs) Handles btnBateriaConsulta.Click
        ' Log.Guardar("Consultó el estado de la batería  en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))

        LimitTime = 20
        PositionSn()
        ValRojo1 = Hex(Val(txtRed.Text))

        'Reinicia los valores 
        Flag1 = False
        Flag2 = False
        Flag3 = False

        Flag1 = True
        tmrEstadoBatería.Enabled = False
        tmrEstadoBatería.Enabled = True
        ConsolaMensajeEnviado()
    End Sub

    ' Dim Flag3 As Boolean = True
    Private Sub tmrEstadoBatería_Tick(sender As Object, e As EventArgs) Handles tmrEstadoBatería.Tick
        If LimitTime > 0 Then
            If Flag1 = True Then
                'Batería
                data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000812305" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
            ElseIf Flag2 = True Then
                'Panel
                data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000812306" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
            ElseIf Flag3 = True Then
                'Estado de energia
                data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000812303" + ValRojo1.PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
            Else
                tmrEstadoBatería.Enabled = False
            End If
        Else
            tmrEstadoBatería.Enabled = False
        End If

        LimitTime -= 1


        Conexion.DiscardOutBuffer()
        Conexion.Write(data)
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'VERIFICACION

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Mapa de nodos
    Private Sub MapaNodos_Click(sender As Object, e As EventArgs) Handles MapaNodos.Click
        ResetMapaNodos()
        FlagNodos = False
        CountSemaforo = 0
        PositionSn()

        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B423XX00000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
        ' ComprobanteDeAcciones(data, "Se consulto el Mapa de nodos desde")
        tmrSimulacion.Enabled = True

    End Sub

    Private Sub ResetMapaNodos()
        If ListSemaforos.Count > 0 Then
            For index = 0 To ListSemaforos.Count - 1
                Panel1.Controls.Remove(ListSemaforos.Item(index))
            Next
        End If

        'Panel1.Controls.Clear()
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        RichTextBox2.Text = ""
        txtNVBatt.Text = 11
    End Sub

    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub btnSimular_Click(sender As Object, e As EventArgs)
        ''receivedData = "RF-" + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "8488FFFF00000097250001000000000000000000000000000000."
        receivedData = "RF-858884888488FFFF00000091FFFF940B0005001500000000000000000000."
        'reporte

        Console.WriteLine(Len(receivedData))
        RichTextBox2.Text &= vbCrLf + receivedData + vbCrLf

        If receivedData <> "" And Len(receivedData) = 64 And Mid(receivedData, 1, 2) = "RF" Then
            'Desealizarformato()
            SnFormat = New DeserializeFormat(receivedData)
            ClasificarCM(SnFormat)
        End If
    End Sub


    Dim FlagLight As Boolean = True

    Private Sub tmrIntermitencias_Tick(sender As Object, e As EventArgs) Handles tmrIntermitencias.Tick
        If FlagLight = True Then
            picSemaforo.Image = Image.FromFile("..\..\img\Red.png")
            picSemaforo.SizeMode = PictureBoxSizeMode.StretchImage
            FlagLight = False
        Else
            picSemaforo.Image = Image.FromFile("..\..\img\TrafficOff.png")
            picSemaforo.SizeMode = PictureBoxSizeMode.StretchImage
            FlagLight = True
        End If
    End Sub

    Private Sub tmrIntermAmarilla_Tick(sender As Object, e As EventArgs) Handles tmrIntermAmarilla.Tick
        If FlagLight = True Then
            picSemaforo.Image = Image.FromFile("..\..\img\Yellow.png")
            picSemaforo.SizeMode = PictureBoxSizeMode.StretchImage
            FlagLight = False
        Else
            picSemaforo.Image = Image.FromFile("..\..\img\TrafficOff.png")
            picSemaforo.SizeMode = PictureBoxSizeMode.StretchImage
            FlagLight = True
        End If
    End Sub

    Private Sub btnStopInterm_Click(sender As Object, e As EventArgs)
        picSemaforo.Image = Image.FromFile("..\..\img\TrafficOff.png")
        picSemaforo.SizeMode = PictureBoxSizeMode.StretchImage
        FlagLight = True

        tmrIntermitencias.Enabled = False
        tmrIntermAmarilla.Enabled = False

    End Sub

    Private Sub btnMac_Click(sender As Object, e As EventArgs)
        Dim Mac As String
        Mac = getMacAddress()
        MessageBox.Show(Mac)
    End Sub

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        'devuelve la mac del ethernet 
        Return nics(0).GetPhysicalAddress.ToString
    End Function

    Private Sub txtNVBatt_TextChanged(sender As Object, e As EventArgs) Handles txtNVBatt.TextChanged
        Try
            Dim EstadoBateria = Double.Parse(txtNVBatt.Text)

            If EstadoBateria > 12.8 Then
                picBattery.BackgroundImage = Image.FromFile("..\..\img\batteryGreen.png")
                picBattery.SizeMode = PictureBoxSizeMode.StretchImage
                txtNVBatt.ForeColor = Color.Lime
            ElseIf EstadoBateria > 12.3 And EstadoBateria <= 12.8 Then
                picBattery.BackgroundImage = Image.FromFile("..\..\img\batteryYellow.png")
                picBattery.SizeMode = PictureBoxSizeMode.StretchImage
                txtNVBatt.ForeColor = Color.Yellow
            ElseIf EstadoBateria > 11.8 And EstadoBateria <= 12.3 Then
                picBattery.BackgroundImage = Image.FromFile("..\..\img\batteryOrange.png")
                picBattery.SizeMode = PictureBoxSizeMode.StretchImage
                txtNVBatt.ForeColor = Color.Orange
            ElseIf EstadoBateria > 1 And EstadoBateria Then
                picBattery.BackgroundImage = Image.FromFile("..\..\img\batteryRed.png")
                picBattery.SizeMode = PictureBoxSizeMode.StretchImage
                txtNVBatt.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MsgBox("DEBE INGRESAR NÚMEROS")
        End Try
    End Sub




    Private Sub nudLight_ValueChanged(sender As Object, e As EventArgs) Handles nudLight.ValueChanged
        Log.Guardar("Envió intensidad de luz  en Sinpatron X:" & posicionX2.PadLeft(2, "0") & " Y:" & posicionY2.PadLeft(2, "0"))
        If nudLight.Value >= 0 And nudLight.Value <= 3 Then
            PositionSn()

            'RichTextBox1.Text &= vbCrLf + "US-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B4230300000000000000000000000000000052." + vbCrLf
            RichTextBox2.Text &= vbCrLf + "" + "Enviado" + vbCrLf
            'formato-X0Y0X1Y1X2Y2FFFFEEXEYECMA1A0D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF.
            data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + (datoEE) + "0000B42303" + (nudLight.Value.ToString()).PadLeft(2, "0") + "000000000000" + (nudLight.Value.ToString()).PadLeft(2, "0") + "0000000000000052."
            ComprobanteDeAcciones(data, "Envió intensidad de luz")
            'Console.WriteLine(data.Length)
            'Console.WriteLine(RichTextBox2.TextLength)
        Else
            nudLight.Value = 0
            MsgBox("Valor no valido")
        End If

        'Para cambiar  la imagen según el valor
        If nudLight.Value = 1 Then
            PictureBox5.Image = Image.FromFile("..\..\img\lightMin.png")
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If nudLight.Value = 2 Then
            PictureBox5.Image = Image.FromFile("..\..\img\lightMid.png")
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If nudLight.Value = 3 Or nudLight.Value = 0 Then
            PictureBox5.Image = Image.FromFile("..\..\img\lightMax.png")
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub


    Private Sub SnPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ServidorConexion.CerrarServidor()
    End Sub
    Private Async Function Comprobar() As Task(Of Boolean)
        'Conexion a la base de datos
        Dim col = ConexioDb.Conexion("sinaptron", False)

        Dim ref = txtPosX2.Text & txtPosY2.Text

        Using cursor = Await col.Find(New BsonDocument).ToCursorAsync
            While (Await cursor.MoveNextAsync())
                For Each doc In cursor.Current
                    If txtPosX2.Text = doc("SnX") And txtPosY2.Text = doc("SnY") Then
                        ExisteRegis = True
                    End If
                Next
            End While
        End Using
        Return ExisteRegis
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Comprobar()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picS9_Click(sender As Object, e As EventArgs) Handles picS9.Click

    End Sub

    Private Sub btnCambiosRemoto_Click(sender As Object, e As EventArgs) Handles btnCambiosRemoto.Click
        'Comprueba que haya internet
        If My.Computer.Network.IsAvailable Then
            'btnCambiosRemoto.Enabled = False
            'btnCambiosRemoto.BackColor = Color.Silver
            Log.SubirCambiosAsync()
        Else
            MsgBox("No es posible hacer cambios porque El internet no esta habilitado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnProgramVerd_Click(sender As Object, e As EventArgs) Handles btnProgramVerd.Click
        ProgramVerdes.Show()
    End Sub

    Private Sub btnHistorialEnergia_Click(sender As Object, e As EventArgs) Handles btnHistorialEnergia.Click
        ' Dim historialEnergia As New HistorialEnergia("")
        ' historialEnergia.Show()
    End Sub
End Class
