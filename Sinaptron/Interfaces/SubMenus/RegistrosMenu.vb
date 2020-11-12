Public Class RegistrosMenu
    Private Sub btnHistorialEnergia_Click(sender As Object, e As EventArgs) Handles btnHistorialEnergia.Click
        SnGestion.DistribucionSection(False, 1023)
        SnGestion.openChildForm(SnGestion.PanelChildForm, New HistorialEnergiaTab)
    End Sub

    Private Sub btnEstadoBateria_Click(sender As Object, e As EventArgs) Handles btnEstadoBateria.Click
        If SnGestion.AlertActive Then
            SnGestion.AlertActive = False
            btnEstadoBateria.Enabled = False
            btnEstadoBateria.Iconimage_right = My.Resources.ARROW_DASHBOARD_EXPANDIR
        End If

        SnGestion.DistribucionSection(False, 1023)
        SnGestion.openChildForm(SnGestion.PanelChildForm, New EstadoBateriaSinaptronTab)

        If Application.OpenForms.OfType(Of EstadoBateriaSinaptronTab).Any Then
            EstadoBateriaSinaptronTab.ProcesarModulos(SnGestion.SnFormat, SnGestion.SemaforoEstado)
        Else
        End If
    End Sub

    Private Sub RegistrosMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SnGestion.AlertActive Then
            btnEstadoBateria.Enabled = True
            btnEstadoBateria.Iconimage_right = My.Resources.warning_top
        End If
    End Sub
End Class