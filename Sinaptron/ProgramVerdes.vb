Imports System.IO
Imports Newtonsoft.Json

Public Class ProgramVerdes
    Dim posicionX0 As String
    Dim posicionY0 As String
    Dim posicionX1 As String
    Dim posicionY1 As String
    Dim posicionX2 As String
    Dim posicionY2 As String
    Dim datoADR1 As String
    Dim datoADR0 As String
    Dim ValVerde1 As String
    Dim data As String

    Dim Interdata As String
    Dim Interseccion As Interseccion1 = New Interseccion1() 'almacena todos los datos generales 
    Dim Flagin As Boolean = False

    Private Sub ProgramVerdes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'si el archivo
        If File.Exists("..\..\Intersecciones\Programacion.json") Then

            'almacena el texto leido de tipo json en una variable string 
            Interdata = My.Computer.FileSystem.ReadAllText("..\..\Intersecciones\Programacion.json")

            'pasa Los datos string que estan en  json 
            'y los almacena en un objeto de la clase o modelo 
            Interseccion = JsonConvert.DeserializeObject(Of Interseccion1)(Interdata)

            'MessageBox.Show(Interdata)
            'Relleno los datos de los fields

            txtCentralX.Text = Interseccion.CetralX
            txtCentralY.Text = Interseccion.CetralY
            txtAdr1.Text = Interseccion.Adr1
            txtAdr0.Text = Interseccion.Adr0

            'INTERSECCIÓN 1
            txtDir1X.Text = Interseccion.Dir1X
            txtDir1Y.Text = Interseccion.Dir1Y
            txtDes1X.Text = Interseccion.Dest1X
            txtDes1Y.Text = Interseccion.Dest1Y
            txtV1.Text = Interseccion.V1
            txtDes2X.Text = Interseccion.Dest2X
            txtDes2Y.Text = Interseccion.Dest2Y
            txtV2.Text = Interseccion.V2


            'INTERSECCIÓN 2
            txtDir2X.Text = Interseccion.Dir2X
            txtDir2Y.Text = Interseccion.Dir2Y
            txtDes3X.Text = Interseccion.Dest3X
            txtDes3Y.Text = Interseccion.Dest3Y
            txtV3.Text = Interseccion.V3
            txtDes4X.Text = Interseccion.Dest4X
            txtDes4Y.Text = Interseccion.Dest4Y
            txtV4.Text = Interseccion.V4
            txtDes5X.Text = Interseccion.Dest5X
            txtDes5Y.Text = Interseccion.Dest5Y
            txtV5.Text = Interseccion.V5
            txtDes6X.Text = Interseccion.Dest6X
            txtDes6Y.Text = Interseccion.Dest6Y
            txtV6.Text = Interseccion.V6

            'INTERSECCIÓN 3
            txtDir3X.Text = Interseccion.Dir3X
            txtDir3Y.Text = Interseccion.Dir3Y
            txtDes7X.Text = Interseccion.Dest7X
            txtDes7Y.Text = Interseccion.Dest7Y
            txtV7.Text = Interseccion.V7
            txtDes8X.Text = Interseccion.Dest8X
            txtDes8Y.Text = Interseccion.Dest8Y
            txtV8.Text = Interseccion.V8
            txtDes9X.Text = Interseccion.Dest9X
            txtDes9Y.Text = Interseccion.Dest9Y
            txtV9.Text = Interseccion.V9

            Flagin = True

        Else
            Console.WriteLine("no existe el archivo")
        End If
    End Sub

    'INTERSECCIÓN 1---------------------------------------------------------------------------------------------------------------------------------------------------------------
    ' -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub BtnV1_Click(sender As Object, e As EventArgs) Handles BtnV1.Click
        SemaforoInfo(txtDir1X.Text, txtDir1Y.Text, txtDes1X.Text, txtDes1Y.Text, txtV1.Text)
    End Sub

    Private Sub btnV2_Click(sender As Object, e As EventArgs) Handles btnV2.Click
        SemaforoInfo(txtDir1X.Text, txtDir1Y.Text, txtDes2X.Text, txtDes2Y.Text, txtV2.Text)
    End Sub


    'INTERSECCIÓN 2---------------------------------------------------------------------------------------------------------------------------------------------------------------
    ' -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub btnV3_Click(sender As Object, e As EventArgs) Handles btnV3.Click
        SemaforoInfo(txtDir2X.Text, txtDir2Y.Text, txtDes3X.Text, txtDes3Y.Text, txtV3.Text)
    End Sub

    Private Sub btnV4_Click(sender As Object, e As EventArgs) Handles btnV4.Click
        SemaforoInfo(txtDir2X.Text, txtDir2Y.Text, txtDes4X.Text, txtDes4Y.Text, txtV4.Text)
    End Sub

    Private Sub btnV5_Click(sender As Object, e As EventArgs) Handles btnV5.Click
        SemaforoInfo(txtDir2X.Text, txtDir2Y.Text, txtDes5X.Text, txtDes5Y.Text, txtV5.Text)
    End Sub

    Private Sub btnV6_Click(sender As Object, e As EventArgs) Handles btnV6.Click
        SemaforoInfo(txtDir2X.Text, txtDir2Y.Text, txtDes6X.Text, txtDes6Y.Text, txtV6.Text)
    End Sub

    'INTERSECCIÓN 3---------------------------------------------------------------------------------------------------------------------------------------------------------------
    ' -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub btnV7_Click(sender As Object, e As EventArgs) Handles btnV7.Click
        SemaforoInfo(txtDir3X.Text, txtDir3Y.Text, txtDes7X.Text, txtDes7Y.Text, txtV7.Text)
    End Sub

    Private Sub btnV8_Click(sender As Object, e As EventArgs) Handles btnV8.Click
        SemaforoInfo(txtDir3X.Text, txtDir3Y.Text, txtDes8X.Text, txtDes8Y.Text, txtV8.Text)
    End Sub

    Private Sub btnV9_Click(sender As Object, e As EventArgs) Handles btnV9.Click
        SemaforoInfo(txtDir3X.Text, txtDir3Y.Text, txtDes9X.Text, txtDes9Y.Text, txtV9.Text)
    End Sub

    Private Sub SemaforoInfo(RutaX As String, RutaY As String, DestinoX As String, DestinoY As String, TVerde As String)

        posicionX0 = Hex(Val(txtCentralX.Text))
        posicionY0 = Hex(Val(txtCentralY.Text))

        posicionX1 = Hex(Val(RutaX))
        posicionY1 = Hex(Val(RutaY))

        posicionX2 = Hex(Val(DestinoX))
        posicionY2 = Hex(Val(DestinoY))

        datoADR1 = txtAdr1.Text
        datoADR0 = txtAdr0.Text

        ValVerde1 = Hex(Val(TVerde))

        data = "-" + posicionX0.PadLeft(2, "0") + posicionY0.PadLeft(2, "0") + posicionX1.PadLeft(2, "0") + posicionY1.PadLeft(2, "0") + posicionX2.PadLeft(2, "0") + posicionY2.PadLeft(2, "0") + "FFFF" + "00" + "0000B4" + datoADR1.PadLeft(2, "0") + datoADR0.PadLeft(2, "0") + ValVerde1.PadLeft(2, "0") + "000000000000" + "00" + "0000000000000052."
        Console.WriteLine(data)
        SnPrincipal.Conexion.DiscardOutBuffer()
        SnPrincipal.Conexion.Write(data)

    End Sub
    'Cambio en el Texto
    Private Sub txtCentralX_TextChanged(sender As Object, e As EventArgs) Handles txtCentralX.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtCentralY_TextChanged(sender As Object, e As EventArgs) Handles txtCentralY.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtAdr1_TextChanged(sender As Object, e As EventArgs) Handles txtAdr1.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtAdr0_TextChanged(sender As Object, e As EventArgs) Handles txtAdr0.TextChanged
        GuardarCambiosField()
    End Sub

    'INTERSECCIÓN 1//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub txtDir1X_TextChanged(sender As Object, e As EventArgs) Handles txtDir1X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDir1Y_TextChanged(sender As Object, e As EventArgs) Handles txtDir1Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes1X_TextChanged(sender As Object, e As EventArgs) Handles txtDes1X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes1Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes1Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV1_TextChanged(sender As Object, e As EventArgs) Handles txtV1.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes2X_TextChanged(sender As Object, e As EventArgs) Handles txtDes2X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes2Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes2Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV2_TextChanged(sender As Object, e As EventArgs) Handles txtV2.TextChanged
        GuardarCambiosField()
    End Sub

    'INTERSECCIÓN 2//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub txtDir2X_TextChanged(sender As Object, e As EventArgs) Handles txtDir2X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDir2Y_TextChanged(sender As Object, e As EventArgs) Handles txtDir2Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes3X_TextChanged(sender As Object, e As EventArgs) Handles txtDes3X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes3Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes3Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV3_TextChanged(sender As Object, e As EventArgs) Handles txtV3.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes4X_TextChanged(sender As Object, e As EventArgs) Handles txtDes4X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes4Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes4Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV4_TextChanged(sender As Object, e As EventArgs) Handles txtV4.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes5X_TextChanged(sender As Object, e As EventArgs) Handles txtDes5X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes5Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes5Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV5_TextChanged(sender As Object, e As EventArgs) Handles txtV5.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes6X_TextChanged(sender As Object, e As EventArgs) Handles txtDes6X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes6Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes6Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV6_TextChanged(sender As Object, e As EventArgs) Handles txtV6.TextChanged
        GuardarCambiosField()
    End Sub

    'INTERSECCIÓN 3//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub txtDir3X_TextChanged(sender As Object, e As EventArgs) Handles txtDir3X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDir3Y_TextChanged(sender As Object, e As EventArgs) Handles txtDir3Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes7X_TextChanged(sender As Object, e As EventArgs) Handles txtDes7X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes7Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes7Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV7_TextChanged(sender As Object, e As EventArgs) Handles txtV7.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes8X_TextChanged(sender As Object, e As EventArgs) Handles txtDes8X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes8Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes8Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV8_TextChanged(sender As Object, e As EventArgs) Handles txtV8.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes9X_TextChanged(sender As Object, e As EventArgs) Handles txtDes9X.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtDes9Y_TextChanged(sender As Object, e As EventArgs) Handles txtDes9Y.TextChanged
        GuardarCambiosField()
    End Sub

    Private Sub txtV9_TextChanged(sender As Object, e As EventArgs) Handles txtV9.TextChanged
        GuardarCambiosField()
    End Sub


    Private Sub GuardarCambiosField()
        If (Flagin) Then
            SaveDataInterseccion(txtCentralX.Text, txtCentralY.Text, txtAdr1.Text, txtAdr0.Text, txtDir1X.Text, txtDir1Y.Text, txtDes1X.Text, txtDes1Y.Text, txtV1.Text, txtDes2X.Text, txtDes2Y.Text, txtV2.Text,
                                   txtDir2X.Text, txtDir2Y.Text, txtDes3X.Text, txtDes3Y.Text, txtV3.Text, txtDes4X.Text, txtDes4Y.Text, txtV4.Text, txtDes5X.Text, txtDes5Y.Text, txtV5.Text, txtDes6X.Text, txtDes6Y.Text, txtV6.Text,
                                  txtDir3X.Text, txtDir3Y.Text, txtDes7X.Text, txtDes7Y.Text, txtV7.Text, txtDes8X.Text, txtDes8Y.Text, txtV8.Text, txtDes9X.Text, txtDes9Y.Text, txtV9.Text)
        End If


    End Sub


End Class