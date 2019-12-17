Public Class DeserializeFormat
    Dim _UU As String
    Dim _MINUS As String
    Dim _X0 As String
    Dim _Y0 As String
    Dim _X1 As String
    Dim _Y1 As String
    Dim _X2 As String
    Dim _Y2 As String
    Dim _FF As String
    Dim _FF1 As String
    Dim _EE As String
    Dim _XE As String
    Dim _YE As String
    Dim _CM As String
    Dim _A1 As String
    Dim _A0 As String
    Dim _D0 As Integer
    Dim _D1 As Integer
    Dim _D2 As Integer
    Dim _D3 As Integer
    Dim _D4 As Integer
    Dim _D5 As Integer
    Dim _D6 As Integer
    Dim _D7 As Integer
    Dim _D8 As Integer
    Dim _D9 As Integer
    Dim _DA As Integer
    Dim _DB0 As Integer
    Dim _DC As Integer
    Dim _DD As Integer
    Dim _DE As Integer
    Dim _DF As Integer
    Dim _DOT As String

    Public Sub New(SnFormat As String)
        'Se rellana con datos
        _UU = Mid(SnFormat, 1, 2)
        _MINUS = Mid(SnFormat, 3, 1)
        _X0 = Mid(SnFormat, 4, 2)
        _Y0 = Mid(SnFormat, 6, 2)
        _X1 = Mid(SnFormat, 8, 2)
        _Y1 = Mid(SnFormat, 10, 2)
        _X2 = Mid(SnFormat, 12, 2)
        _Y2 = Mid(SnFormat, 14, 2)
        _FF = Mid(SnFormat, 16, 2)
        _FF1 = Mid(SnFormat, 18, 2)
        _EE = Mid(SnFormat, 20, 2)
        _XE = Mid(SnFormat, 22, 2)
        _YE = Mid(SnFormat, 24, 2)
        _CM = Mid(SnFormat, 26, 2)
        _A1 = Mid(SnFormat, 28, 2)
        _A0 = Mid(SnFormat, 30, 2)
        _D0 = CInt("&H" & Mid(SnFormat, 32, 2))
        _D1 = CInt("&H" & Mid(SnFormat, 34, 2))
        _D2 = CInt("&H" & Mid(SnFormat, 36, 2))
        _D3 = CInt("&H" & Mid(SnFormat, 38, 2))
        _D4 = CInt("&H" & Mid(SnFormat, 40, 2))
        _D5 = CInt("&H" & Mid(SnFormat, 42, 2))
        _D6 = CInt("&H" & Mid(SnFormat, 44, 2))
        _D7 = CInt("&H" & Mid(SnFormat, 46, 2))
        _D8 = CInt("&H" & Mid(SnFormat, 48, 2))
        _D9 = CInt("&H" & Mid(SnFormat, 50, 2))
        _DA = CInt("&H" & Mid(SnFormat, 52, 2))
        _DB0 = CInt("&H" & Mid(SnFormat, 54, 2))
        _DC = CInt("&H" & Mid(SnFormat, 56, 2))
        _DD = CInt("&H" & Mid(SnFormat, 58, 2))
        _DE = CInt("&H" & Mid(SnFormat, 60, 2))
        _DF = CInt("&H" & Mid(SnFormat, 62, 2))
        _DOT = Mid(SnFormat, 64, 1)
    End Sub

    Public Property UU As String
        Get
            Return _UU
        End Get
        Set(value As String)
            _UU = value
        End Set
    End Property

    Public Property MINUS As String
        Get
            Return _MINUS
        End Get
        Set(value As String)
            _MINUS = value
        End Set
    End Property

    Public Property X0 As String
        Get
            Return _X0
        End Get
        Set(value As String)
            _X0 = value
        End Set
    End Property

    Public Property Y0 As String
        Get
            Return _Y0
        End Get
        Set(value As String)
            _Y0 = value
        End Set
    End Property

    Public Property X1 As String
        Get
            Return _X1
        End Get
        Set(value As String)
            _X1 = value
        End Set
    End Property

    Public Property Y1 As String
        Get
            Return _Y1
        End Get
        Set(value As String)
            _Y1 = value
        End Set
    End Property

    Public Property X2 As String
        Get
            Return _X2
        End Get
        Set(value As String)
            _X2 = value
        End Set
    End Property

    Public Property Y2 As String
        Get
            Return _Y2
        End Get
        Set(value As String)
            _Y2 = value
        End Set
    End Property

    Public Property FF As String
        Get
            Return _FF
        End Get
        Set(value As String)
            _FF = value
        End Set
    End Property

    Public Property FF1 As String
        Get
            Return _FF1
        End Get
        Set(value As String)
            _FF1 = value
        End Set
    End Property

    Public Property EE As String
        Get
            Return _EE
        End Get
        Set(value As String)
            _EE = value
        End Set
    End Property

    Public Property XE As String
        Get
            Return _XE
        End Get
        Set(value As String)
            _XE = value
        End Set
    End Property

    Public Property YE As String
        Get
            Return _YE
        End Get
        Set(value As String)
            _YE = value
        End Set
    End Property

    Public Property CM As String
        Get
            Return _CM
        End Get
        Set(value As String)
            _CM = value
        End Set
    End Property

    Public Property A1 As String
        Get
            Return _A1
        End Get
        Set(value As String)
            _A1 = value
        End Set
    End Property

    Public Property A0 As String
        Get
            Return _A0
        End Get
        Set(value As String)
            _A0 = value
        End Set
    End Property

    Public Property D0 As Integer
        Get
            Return _D0
        End Get
        Set(value As Integer)
            _D0 = value
        End Set
    End Property

    Public Property D1 As Integer
        Get
            Return _D1
        End Get
        Set(value As Integer)
            _D1 = value
        End Set
    End Property

    Public Property D2 As Integer
        Get
            Return _D2
        End Get
        Set(value As Integer)
            _D2 = value
        End Set
    End Property

    Public Property D3 As Integer
        Get
            Return _D3
        End Get
        Set(value As Integer)
            _D3 = value
        End Set
    End Property

    Public Property D4 As Integer
        Get
            Return _D4
        End Get
        Set(value As Integer)
            _D4 = value
        End Set
    End Property

    Public Property D5 As Integer
        Get
            Return _D5
        End Get
        Set(value As Integer)
            _D5 = value
        End Set
    End Property

    Public Property D6 As Integer
        Get
            Return _D6
        End Get
        Set(value As Integer)
            _D6 = value
        End Set
    End Property

    Public Property D7 As Integer
        Get
            Return _D7
        End Get
        Set(value As Integer)
            _D7 = value
        End Set
    End Property

    Public Property D8 As Integer
        Get
            Return _D8
        End Get
        Set(value As Integer)
            _D8 = value
        End Set
    End Property

    Public Property D9 As Integer
        Get
            Return _D9
        End Get
        Set(value As Integer)
            _D9 = value
        End Set
    End Property

    Public Property DA As Integer
        Get
            Return _DA
        End Get
        Set(value As Integer)
            _DA = value
        End Set
    End Property

    Public Property DB0 As Integer
        Get
            Return _DB0
        End Get
        Set(value As Integer)
            _DB0 = value
        End Set
    End Property

    Public Property DC As Integer
        Get
            Return _DC
        End Get
        Set(value As Integer)
            _DC = value
        End Set
    End Property

    Public Property DD As Integer
        Get
            Return _DD
        End Get
        Set(value As Integer)
            _DD = value
        End Set
    End Property

    Public Property DE As Integer
        Get
            Return _DE
        End Get
        Set(value As Integer)
            _DE = value
        End Set
    End Property

    Public Property DF As Integer
        Get
            Return _DF
        End Get
        Set(value As Integer)
            _DF = value
        End Set
    End Property

    Public Property DOT As String
        Get
            Return _DOT
        End Get
        Set(value As String)
            _DOT = value
        End Set
    End Property
End Class
