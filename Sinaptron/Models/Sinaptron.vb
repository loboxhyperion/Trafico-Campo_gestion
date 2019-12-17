Public Class Sinaptron
    Dim _Id As Integer 'Id
    Dim _Ref As String 'referencia
    Dim _SnX As Integer 'Sinpatron X del Hardware
    Dim _SnY As Integer 'Sinpatron Y del Hardware
    Dim _Lat As Integer 'Posición X en mapa del programa
    Dim _Longt As Integer 'Posición Y en mapa del programa
    Dim _Dir As String 'Dirección
    Dim _Calle As String
    Dim _Carrera As String

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Ref As String
        Get
            Return _Ref
        End Get
        Set(value As String)
            _Ref = value
        End Set
    End Property

    Public Property SnX As Integer
        Get
            Return _SnX
        End Get
        Set(value As Integer)
            _SnX = value
        End Set
    End Property

    Public Property SnY As Integer
        Get
            Return _SnY
        End Get
        Set(value As Integer)
            _SnY = value
        End Set
    End Property

    Public Property Lat As Integer
        Get
            Return _Lat
        End Get
        Set(value As Integer)
            _Lat = value
        End Set
    End Property

    Public Property Longt As Integer
        Get
            Return _Longt
        End Get
        Set(value As Integer)
            _Longt = value
        End Set
    End Property

    Public Property Dir As String
        Get
            Return _Dir
        End Get
        Set(value As String)
            _Dir = value
        End Set
    End Property

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(value As String)
            _Calle = value
        End Set
    End Property

    Public Property Carrera As String
        Get
            Return _Carrera
        End Get
        Set(value As String)
            _Carrera = value
        End Set
    End Property
End Class
