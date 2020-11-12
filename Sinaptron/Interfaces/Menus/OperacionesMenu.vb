Public Class OperacionesMenu
    Private Sub btnFuncionalidad_Click(sender As Object, e As EventArgs) Handles btnFuncionalidad.Click
        SnGestion.DistribucionSection(True, 341)
        SnGestion.openChildForm(SnGestion.PanelChildForm, New FuncionalidadTab())
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        SnGestion.DistribucionSection(True, 341)
        SnGestion.openChildForm(SnGestion.PanelChildForm2, New ConsultasTab())
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        SnGestion.DistribucionSection(True, 341)
        SnGestion.openChildForm(SnGestion.PanelChildForm3, New RegistrosMenu)
        If SnGestion.AlertActive Then
            BunifuFlatButton5.Iconimage_right = Nothing
        End If
    End Sub

    Private Sub OperacionesMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SnGestion.AlertActive Then
            BunifuFlatButton5.Iconimage_right = My.Resources.warning_top
        End If
    End Sub
End Class