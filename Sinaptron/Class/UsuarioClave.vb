Imports MongoDB.Bson

Public Class UsuarioClave
    Shared _Usuario As BsonDocument

    Public Shared Sub EnviarUsuario(Usuario As BsonDocument)
        _Usuario = Usuario
    End Sub
    Public Shared Function ObtenerUsuario() As BsonDocument
        Return _Usuario
    End Function

End Class
