Public Class Permisos
    Dim _Rol As String
    Public Sub New(permiso As String)
        Rol = permiso
    End Sub

    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
        End Set
    End Property
End Class
