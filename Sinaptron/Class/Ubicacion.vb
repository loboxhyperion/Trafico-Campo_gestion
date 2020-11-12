Public Class Ubicacion
    Shared _Lat As Double = 0
    Shared _Long As Double = 0
    Public Shared Sub Coordenadas(lat As Double, lng As Double)
        _Lat = lat
        _Long = lng
    End Sub
    Public Shared Function ObtenerLatitud() As Double
        Return _Lat
    End Function
    Public Shared Function ObtenerLongitud() As Double
        Return _Long
    End Function
End Class
