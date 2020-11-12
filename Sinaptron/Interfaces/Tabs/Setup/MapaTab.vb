Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class MapaTab
    Dim MarkersCount As Integer = -1
    Private Sub MapaTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Geo Referencia  inicial en este caso Medellín
        GMapControl1.DragButton = MouseButtons.Left
        GMapControl1.MapProvider = GMapProviders.GoogleMap
        GMapControl1.Position = New GMap.NET.PointLatLng(6.242731, -75.56584)
        GMapControl1.MinZoom = 12.9
        GMapControl1.MaxZoom = 18
        GMapControl1.Zoom = 12.9

        'Quita el indicador del centro
        GMapControl1.ShowCenter = False
        ConsultarTodo()
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


    Private Async Function ConsultarTodo() As Task
        Dim result = Nodo.ConsultarTodo()
        For Each item In result
            MarkersCount += 1
            GMapControl1.Refresh()
            GMapControl1.MapProvider = GMapProviders.GoogleMap
            GMapControl1.Position = New PointLatLng(item.Item(4), item.Item(5))

            Dim Point As New PointLatLng(item.Item(4), item.Item(5))
            CreateMarker(Point, item.Item(1))
        Next
    End Function

    Private Async Function ConsultarSnInfo(item As GMapMarker) As Task
        Dim result = Nodo.Consultar(item.Tag)

        Dim local = GMapControl1.FromLatLngToLocal(New PointLatLng(item.Position.Lat, item.Position.Lng))

        Dim snControl As New snControl(result.Item(0).Item(4), result.Item(0).Item(5), item.Overlay, True, MarkersCount, result.Item(0).Item(0).ToString())
        Console.WriteLine("FECHA")
        snControl.Show()
        snControl.Location = New Point(local.X + 20, local.Y - 100)
        snControl.txtRef.Text = result.Item(0).Item(1)
        snControl.txtSnX.Text = result.Item(0).Item(2)
        snControl.txtSnY.Text = result.Item(0).Item(3)
        snControl.txtDir.Text = result.Item(0).Item(6)
        snControl.txtCall.Text = result.Item(0).Item(7)
        snControl.txtCarr.Text = result.Item(0).Item(8)
        'Dim resultado = result.Item(0).Item(10).ToUniversalTime - Date.Now
        'Console.WriteLine(resultado)
        'Console.WriteLine(resultado.Days)
        ' Console.WriteLine(resultado.Hours)


        snControl.btnEditar.Enabled = True
        snControl.EliminarSinap.Enabled = True

    End Function

    Function CreateMarker(point As PointLatLng, ref As String) As GMapOverlay
        'Creating a custom marker
        Dim bmpMarker As Bitmap
        bmpMarker = Image.FromFile("..\..\img\marker.png")
        'Adding Marker
        'Create a Overlay
        Dim markers As New GMapOverlay("markers")



        Dim marker As GMapMarker = New GMarkerGoogle(point, bmpMarker)
        marker.Tag = ref
        ' marker.ToolTipText = $"Latitude: {GMapControl1.Position.Lat},{vbLf} Longitude: {GMapControl1.Position.Lng}"
        'add all available markers to that Overlay
        markers.Markers.Add(marker)
        'markers.Control.Name = "s"
        'Cover map with Overlay
        GMapControl1.Overlays.Add(markers)

        ' Console.WriteLine("son " & GMapControl1.Overlays.Count())
        ' RefreshMap()
        Return markers
    End Function

    Function RefreshMap()
        GMapControl1.Zoom = GMapControl1.Zoom - 1
        GMapControl1.Zoom = GMapControl1.Zoom + 1
    End Function

    Dim snControl2
    Private Sub GMapControl1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseDoubleClick

        GMapControl1.Refresh()
        'Console.WriteLine(e.X & " " & e.Y)
        Dim point = GMapControl1.FromLocalToLatLng(e.X, e.Y)


        'Console.WriteLine("lat:" & point.Lat & " long:" & point.Lng)
        'Console.WriteLine("x:" & local.X & " y:" & local.Y)

        Console.WriteLine(GMapControl1.Zoom)
        GMapControl1.MapProvider = GMapProviders.GoogleMap
        GMapControl1.Position = New PointLatLng(point.Lat, point.Lng)

        GMapControl1.Zoom = 18
        'CreateMarker(point)

        ' GMapControl1.Overlays.Clear()
        ' ConsultarTodo()
        GMapControl1.Enabled = False
        Dim snControl As New snControl(point.Lat, point.Lng, CreateMarker(point, ""), False, MarkersCount, "")
        snControl2 = snControl
        snControl.Show()
        snControl.Location = New Point(e.X - 20, e.Y - 20)
        snControl.CrearSinap.Enabled = True
        RefreshMap()

    End Sub
    Private Sub GMapControl1_OnMarkerClick(item As GMapMarker, e As MouseEventArgs) Handles GMapControl1.OnMarkerClick
        'Console.WriteLine("Prueba de uso")
        GMapControl1.Enabled = False
        'Console.WriteLine(item.Tag)
        'Console.WriteLine(item.Position)
        ConsultarSnInfo(item)
    End Sub
    Private Sub GMapControl1_OnMarkerEnter(item As GMapMarker) Handles GMapControl1.OnMarkerEnter
        item.ToolTipText = $"Latitude: {item.Position.Lat},{vbLf} Longitude: {item.Position.Lng}"
    End Sub

    Private Sub GMapControl1_OnMarkerLeave(item As GMapMarker) Handles GMapControl1.OnMarkerLeave
    End Sub
    Private Sub GMapControl1_OnMapZoomChanged() Handles GMapControl1.OnMapZoomChanged
        'lblZoom.Text = GMapControl1.Zoom
    End Sub

    Private Sub GMapControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseMove
        'Label13.Text = e.X
        'Label14.Text = e.Y
    End Sub

    Private Sub MapaTab_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick

    End Sub
End Class