Imports Bunifu.Framework.UI

Public Class InterseccionConfigTab
    'Aprtado para poder enviar los comandos
    Dim comando As New comandos()
    Dim destinoX As String
    Dim destinoY As String
    Dim D0 As String
    ' Apartado para contrar o expandir una seccion
    Dim Accion As String
    Dim icoAccion As BunifuFlatButton
    Dim Seccion As Panel


    Private Sub InterseccionConfigTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Expandir_Contraer_Seccion("Expandir", btnId, PanelId)
    End Sub

    Private Sub Destino()
        destinoX = Hex(Val(txtPosX2.Text)).ToString.PadLeft(2, "0")
        destinoY = Hex(Val(txtPosY2.Text)).ToString.PadLeft(2, "0")
    End Sub
    Private Sub DatoD0(dato As String)
        D0 = Hex(Val(dato)).ToString.PadLeft(2, "0")
    End Sub

    Private Sub Expandir_Contraer_Seccion(Camino As String, IcoButton As BunifuFlatButton, SeccionContainer As Panel)
        Accion = Camino
        icoAccion = IcoButton
        Seccion = SeccionContainer

        ColapazarSeccion.Start()

    End Sub

    Private Sub ColapazarSeccion_Tick(sender As Object, e As EventArgs) Handles ColapazarSeccion.Tick
        Console.WriteLine(Accion)
        If Accion = "Expandir" Then
            icoAccion.Iconimage_right = My.Resources.ARROW_DASHBOARD_CONTRAER
            Seccion.Height += 10
        Else
            icoAccion.Iconimage_right = My.Resources.ARROW_DASHBOARD_EXPANDIR
            Seccion.Height -= 10
        End If
        'cuando llege al tope sea el maximo(expandir) o el minimo(contraer) de evento se detiene el temporizador
        If Seccion.Size = Seccion.MaximumSize Then
            ColapazarSeccion.Stop()
        End If
    End Sub
    Private Sub CambiosMapa_Tick(sender As Object, e As EventArgs) Handles CambiosMapa.Tick
        Me.txtLat.Text = Ubicacion.ObtenerLatitud()
        Me.txtLong.Text = Ubicacion.ObtenerLongitud()
    End Sub


    ' ESTANDO EN LA SECCION DE ID  ////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btnStepUbicacion_Click(sender As Object, e As EventArgs) Handles btnStepUbicacion.Click
        PanelId.Height = 0
        icoAccion.Iconimage_right = My.Resources.ARROW_DASHBOARD_EXPANDIR

        Expandir_Contraer_Seccion("Expandir", btnUbicacion, PanelUbicacion)

        'activa la segunda pestaña
        SnGestion.DistribucionSection2(False, 682)
        SnGestion.openChildForm(SnGestion.PanelChildForm2, New MapaConfig())

        CambiosMapa.Enabled = True
    End Sub

    ' ESTANDO EN LA SECCION DE UBICACION ////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btnBackId_Click(sender As Object, e As EventArgs) Handles btnBackId.Click
        PanelUbicacion.Height = 0
        icoAccion.Iconimage_right = My.Resources.ARROW_DASHBOARD_EXPANDIR

        Expandir_Contraer_Seccion("Expandir", btnId, PanelId)
    End Sub

    Private Sub btnStepDispositivos_Click(sender As Object, e As EventArgs) Handles btnStepDispositivos.Click
        'como ya estan almacenados el icono y la seccion entonces  no hay necesidad de llamar al metodo 
        PanelUbicacion.Height = 0
        icoAccion.Iconimage_right = My.Resources.ARROW_DASHBOARD_EXPANDIR

        Expandir_Contraer_Seccion("Expandir", btnComponentes, PanelDispositivos)
    End Sub

    ' ESTANDO EN LA SECCION DE DISPOSITIVOS ////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btnBackUbicacion_Click(sender As Object, e As EventArgs) Handles btnBackUbicacion.Click
        PanelDispositivos.Height = 0
        icoAccion.Iconimage_right = My.Resources.ARROW_DASHBOARD_EXPANDIR

        Expandir_Contraer_Seccion("Expandir", btnUbicacion, PanelUbicacion)
    End Sub

    Private Sub btnStepMaestroEsclavo_Click(sender As Object, e As EventArgs) Handles btnStepMaestroEsclavo.Click
        PanelDispositivos.Height = 0
        icoAccion.Iconimage_right = My.Resources.ARROW_DASHBOARD_EXPANDIR

        Expandir_Contraer_Seccion("Expandir", btnMaestroEsclavo, PanelMaestroEsclavo)
    End Sub


    '--------------------------------------------------------------------------------------------//
    '--------------------------------------------------------------------------------------------//
    '--------------------------------------------------------------------------------------------//
    'APARTADO DE TIEMPOS
    Private Sub btnSendRojo_Click(sender As Object, e As EventArgs) Handles btnSendRojo.Click
        Destino()
        DatoD0(txtRojo.Text)
        comando.Rojo(destinoX, destinoY, D0)
    End Sub

    Private Sub btnSendAmarillo_Click(sender As Object, e As EventArgs) Handles btnSendAmarillo.Click
        Destino()
        DatoD0(txtAmarillo.Text)
        comando.Rojo(destinoX, destinoY, D0)
    End Sub

    Private Sub btnSendVerde_Click(sender As Object, e As EventArgs) Handles btnSendVerde.Click
        Destino()
        DatoD0(txtVerde.Text)
        comando.Rojo(destinoX, destinoY, D0)
    End Sub





    Private Sub BunifuiOSSwitch1_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuiOSSwitch1.MouseClick
        If BunifuiOSSwitch1.Value = True Then
            BunifuMaterialTextbox10.Visible = True
        Else
            BunifuMaterialTextbox10.Visible = False
        End If

    End Sub

    Private Sub BunifuiOSSwitch2_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuiOSSwitch2.MouseClick
        If BunifuiOSSwitch2.Value = True Then
            BunifuMaterialTextbox1.Visible = True
        Else
            BunifuMaterialTextbox1.Visible = False
        End If
    End Sub

    Private Sub BunifuiOSSwitch3_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuiOSSwitch3.MouseClick
        If BunifuiOSSwitch3.Value = True Then
            BunifuMaterialTextbox2.Visible = True
        Else
            BunifuMaterialTextbox2.Visible = False
        End If
    End Sub

    Private Sub BunifuiOSSwitch4_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuiOSSwitch4.MouseClick
        If BunifuiOSSwitch4.Value = True Then
            BunifuMaterialTextbox3.Visible = True
        Else
            BunifuMaterialTextbox3.Visible = False
        End If
    End Sub

    Private Sub BunifuiOSSwitch5_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuiOSSwitch5.MouseClick
        If BunifuiOSSwitch5.Value = True Then
            BunifuMaterialTextbox4.Visible = True
        Else
            BunifuMaterialTextbox4.Visible = False
        End If
    End Sub

    Private Sub BunifuiOSSwitch6_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuiOSSwitch6.MouseClick
        If BunifuiOSSwitch6.Value = True Then
            BunifuMaterialTextbox5.Visible = True
        Else
            BunifuMaterialTextbox5.Visible = False
        End If
    End Sub

End Class