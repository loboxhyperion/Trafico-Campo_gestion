Imports Bunifu.Framework.UI

Public Class SnGestion
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
    Public SnFormat As DeserializeFormat
    Public SemaforoEstado As String ' Alamcena la seccion para saber en la pantala de estadosinaptron donde va

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

    'guarda un formulario para contenerlo dentro de otro
    Private activeForm As Form = Nothing
    Private Sub SnGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConexionSerial.Configuracion(Conexion)

        DistribucionSection(False, 1023)
        openChildForm(Panel7, New DatosMenu())
        openChildForm(PanelChildForm, New MapaTab())

        If My.Computer.Network.IsAvailable Then
            'WebBrowser1.Navigate("https://www.google.com/maps/place/Corporaci%C3%B3n+de+Ferias+y+Exposiciones+-+Corferias/@4.6282494,-74.0914433,15z/data=!4m5!3m4!1s0x0:0x3f449bb47da9bef3!8m2!3d4.6294899!4d-74.0900271")
        Else
            MsgBox("El internet no esta habilitado", MsgBoxStyle.Critical)
        End If
        'Setup.Iconimage_right = My.Resources.warning
        'cargar progress bar

        ' panel section,  sub menu timerloader
        ' LoaderParameters(True, True, True)
    End Sub

    Private Sub tmrLoader_Tick(sender As Object, e As EventArgs) Handles tmrLoader.Tick
        If progressLoader.Value < 100 Then
            progressLoader.Value += 1
        Else
            ' oculto el panel section,  sub menu y desactivo el timer
            LoaderParameters(False, False, False)
            'Inicializo el progressbar
            progressLoader.Value = 0
        End If

    End Sub
    Private Sub LoaderParameters(MainPanel As Boolean, SubMenu As Boolean, Statetimer As Boolean)
        ' oculto el panel section
        Panel8.Visible = MainPanel
        'oculto el sub menu
        Panel9.Visible = SubMenu
        'desactivo el timer
        tmrLoader.Enabled = Statetimer
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


                    tmrSerialInOut.Enabled = True

                    Conexion.Write("?")
                    Conexion.DiscardInBuffer()

                End If
                Console.WriteLine(comPORT)
            Next
        Catch ex As Exception
            Console.WriteLine("Sin CONEXION")
        End Try
    End Sub

    Private Sub tmrSerialInOut_Tick(sender As Object, e As EventArgs) Handles tmrSerialInOut.Tick
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
                    RichTextBox2.Text &= "Recibido" & vbCrLf
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
            tmrSerialInOut.Enabled = False
            picEstadoPort.BackColor = Color.Red
            ' MessageBox.Show("SE PERDIO LA CONEXION CON LA ANTENA")
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

    'Clasifica la información de acuerdo  al CM 
    Public Sub ClasificarCM(snFormat)
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
                    'txtSnX.Text = CInt("&H" & snFormat.X2)
                    ' txtSnY.Text = CInt("&H" & snFormat.Y2)

                    ' txtNVBatt.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                    Flag1 = False
                    Flag2 = True
                ElseIf Flag2 = True Then
                    'txtNVPanel.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                    Flag2 = False
                    Flag3 = True
                ElseIf Flag3 = True Then
                    'txtStatusE.Text = snFormat.D0
                    Flag3 = False
                End If

            End If
            'Tiempos 

            'Tiempos 
            If snFormat.CM = "B4" And snFormat.A1 = "23" And snFormat.A0 = "FF" Then
                TiempoPre = snFormat.D0

                If Flag1 = True Then
                    ' txtRed.Text = snFormat.D0
                    Flag1 = False
                    If FlagPrevNext = True Then
                        Threading.Thread.Sleep(500)
                        '  SendTiempos("rojo")
                    End If
                    ' Flag5 = True
                ElseIf Flag2 = True Then
                    ' txtAmbar.Text = snFormat.D0
                    Flag2 = False
                    If FlagPrevNext = True Then
                        Threading.Thread.Sleep(500)
                        ' SendTiempos("amarillo")
                    End If
                ElseIf Flag3 = True Then

                    ' txtGreen.Text = snFormat.D0
                    Flag3 = False
                    If FlagPrevNext = True Then
                        Threading.Thread.Sleep(500)
                        ' SendTiempos("verde")
                    End If
                End If
            End If


        End If

    End Sub


    Private Sub ProcesarModulos(snFormat As DeserializeFormat, TipModulo As String)
        '/////////////////////////////////ACCIONES A TOMAR SEGUN LOS MODULOS/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If TipModulo = "Antena" Then

            'txtSnX.Text = CInt("&H" & snFormat.X0)
            'txtSnY.Text = CInt("&H" & snFormat.Y0)
            'txtNVBatt.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
            'txtNVPanel.Text = Format((snFormat.D1 * 10) / VarCalVolt, "0.00")
            'txtStatusE.Text = snFormat.D2

            If snFormat.Y0 = "86" Then
                'Dim estadoSinaptron As New EstadoSinaptron(snFormat, "Sinaptron1")
                SemaforoEstado = "Sinaptron1"
            ElseIf snFormat.Y0 = "87" Then
                ' Dim estadoSinaptron As New EstadoSinaptron(snFormat, "Sinaptron2")
                SemaforoEstado = "Sinaptron2"

            ElseIf snFormat.Y0 = "88" Then
                ' Dim estadoSinaptron As New EstadoSinaptron(snFormat, "Sinaptron3")
                SemaforoEstado = "Sinaptron3"
            End If
            If Application.OpenForms.OfType(Of EstadoBateriaSinaptronTab).Any Then
                EstadoBateriaSinaptronTab.ProcesarModulos(snFormat, SemaforoEstado)
            Else

                ' DistribucionSection(False, 1023)
                'openChildForm(PanelChildForm, New EstadoBateriaSinaptronTab())
                'Dim historialEnergiaTab As New HistorialEnergia("")
                'historialEnergia.Show()
                ' openChildForm(PanelChildForm, New EstadoBateriaSinaptronTab)
                tmrBlinkAlert.Enabled = True
            End If


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

    '------------------------------/////----------------------------------------------------------/////----------------------------------SECTION-TIMERS------------------------------/////----------------------------------------------------------/////---------------------------------------------------------------------------

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Dim FlagAlert As Boolean = True
    Private Sub tmrBlinkAlert_Tick(sender As Object, e As EventArgs) Handles tmrBlinkAlert.Tick
        If FlagAlert Then
            Operacion.Iconimage_right = My.Resources.warning
            FlagAlert = False
        Else
            Operacion.Iconimage_right = My.Resources.warning_top
            FlagAlert = True
        End If
    End Sub
    Public AlertActive As Boolean = False
    Private Sub AlertOff(alerta As BunifuFlatButton)
        AlertActive = True
        alerta.Iconimage_right = Nothing
        tmrBlinkAlert.Enabled = False
    End Sub



    Public Sub DistribucionSection(VisibilidadPanel, WidthPanel)

        PanelChildForm2.Visible = VisibilidadPanel
        PanelChildForm3.Visible = VisibilidadPanel

        PanelChildForm.Width = WidthPanel



    End Sub
    Public Sub DistribucionSection2(VisibilidadPanel, WidthPanel)

        PanelChildForm3.Visible = VisibilidadPanel

        PanelChildForm2.Width = WidthPanel



    End Sub
    'para que funcione este método el formulario que se vaya a traer tiene que tener el mismo tamaño que la ventana donde se va a contener
    'eso sin contar los bordes por lo que primero se debe quitar el formbordestyle del formulario a traer y colocar las medidas del dock donde se va a contener y luego si volver activar el formborderstyle
    Public Sub openChildForm(panelSection As Panel, childForm As Form)
        If activeForm Is Nothing Then
            '   activeForm.Close()
        End If
        activeForm = childForm
        activeForm.TopLevel = False
        activeForm.FormBorderStyle = FormBorderStyle.None
        activeForm.Dock = DockStyle.Fill
        panelSection.Controls.Add(childForm)
        panelSection.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        ' LoaderParameters(True, True, True)
        DistribucionSection(False, 1023)
        openChildForm(Panel7, New DatosMenu())
        openChildForm(PanelChildForm, New MapaTab())
        'PanelVacio()
        ' panel section,  sub menu timerloader

    End Sub
    Private Sub Setup_Click(sender As Object, e As EventArgs) Handles Setup.Click
        DistribucionSection(True, 341)
        'openChildForm(Panel6, New DireccionesMenu)
        openChildForm(Panel7, New SetupMenu)
        PanelVacio()
        ' panel section,  sub menu timerloader
        '  LoaderParameters(True, True, True)
    End Sub
    Private Sub Pruebas_Click(sender As Object, e As EventArgs) Handles Pruebas.Click
        DistribucionSection(True, 341)
        openChildForm(Panel6, New DireccionesMenu)
        openChildForm(Panel7, New PruebasMenu)

        PanelVacio()

        ' panel section,  sub menu timerloader
        ' LoaderParameters(True, True, True)
    End Sub
    Private Sub Operacion_Click(sender As Object, e As EventArgs) Handles Operacion.Click
        If tmrBlinkAlert.Enabled = True Then
            'desactiva las posibles alertas activas
            AlertOff(Operacion)
        End If

        'desactiva las posibles alertas activas
        DistribucionSection(True, 341)
        openChildForm(Panel6, New DireccionesMenu)
        openChildForm(Panel7, New OperacionesMenu)

        PanelVacio()

        ' panel section,  sub menu timerloader
        'LoaderParameters(True, True, True)

    End Sub

    Private Sub PanelVacio()
        'Si es mayor a 1 es que hay un formulario contenedor
        'Por lo que permite borrarlo
        ' For index As Integer = 1 To Panel6.Controls.Count
        'If index > 1 Then
        'PanelChildForm.Controls.RemoveAt(0)
        'End If
        ' Next
        For index As Integer = 1 To PanelChildForm.Controls.Count
            If index > 1 Then
                PanelChildForm.Controls.RemoveAt(0)
            End If
        Next

        For index As Integer = 1 To PanelChildForm2.Controls.Count
            If index > 1 Then
                PanelChildForm2.Controls.RemoveAt(0)
            End If
        Next

        For index As Integer = 1 To PanelChildForm3.Controls.Count
            If index > 1 Then
                PanelChildForm3.Controls.RemoveAt(0)
            End If
        Next
        ' If PanelChildForm.Controls.Count > 1 Then
        'PanelChildForm.Controls.RemoveAt(0)
        ' End If

        ' If PanelChildForm2.Controls.Count > 2 Then
        'PanelChildForm2.Controls.RemoveAt(0)
        ' End If

        'If PanelChildForm3.Controls.Count > 1 Then
        'PanelChildForm3.Controls.RemoveAt(0)
        ' End If

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim TestTrama As String = "RF-848684888486FFFF00000091FFFFC0E60300000000000000000000000052."
        SnFormat = New DeserializeFormat(TestTrama)

        ClasificarCM(SnFormat)
    End Sub


End Class