Imports Gmap.net.WindowsForms
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class snControl
    Dim Latitude As Double
    Dim Longitude As Double
    Dim Markers As GMapOverlay
    Dim SnCreate As Boolean = False
    Dim RemoveLast As Integer

    'Sub New(ByVal lat As Double, ByVal longt As Double, ByVal mark As GMapOverlay, ByVal create As Boolean)
    Sub New(ByVal lat As Double, ByVal longt As Double, ByVal mark As GMapOverlay, ByVal create As Boolean, ByVal value As Integer)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Latitude = lat
        Longitude = longt
        Markers = mark
        SnCreate = create

        txtLat.Text = Latitude
        txtLong.Text = Longitude
        RemoveLast = value
    End Sub

    Private Sub CrearSinap_Click(sender As Object, e As EventArgs) Handles CrearSinap.Click
        SnPrincipal.Panel1.Enabled = True
        If txtSnX.Text <> "" And txtSnY.Text <> "" And txtDir.Text <> "" And txtCall.Text <> "" And txtCarr.Text <> "" Then
            Nodo.Guardar(txtSnX.Text, txtSnY.Text, txtLat.Text, txtLong.Text, txtDir.Text, txtCall.Text, txtCarr.Text)
            SnCreate = True
            Me.Close()
        Else
            MsgBox("Se deben llenar todos los campos")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        SnPrincipal.Panel1.Enabled = True
        Nodo.Editar(txtRef.Text, txtSnX.Text, txtSnY.Text, txtDir.Text, txtCall.Text, txtCarr.Text)
        Me.Close()
    End Sub

    Private Sub EliminarSinap_Click(sender As Object, e As EventArgs) Handles EliminarSinap.Click
        SnPrincipal.Panel1.Enabled = True
        If SnCreate = True Then
            Nodo.Eliminar(txtRef.Text)
            SnPrincipal.Panel1.Enabled = True
            Me.Close()
        End If
    End Sub


    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        SnPrincipal.Panel1.Enabled = True
        Me.Close()
        If SnCreate = False Then

        End If
    End Sub
End Class