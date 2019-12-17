Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Nodo
    Public Shared Sub Guardar(SnX As String, Sny As String, Latitude As Double, Longitude As Double, Dir As String, Calle As String, Carr As String)

        'Conexion a la base de datos
        Dim col = ConexioDb.Conexion("sinaptron", False)

        Dim doc As New BsonDocument()

        Dim ref = SnX & Sny

        doc.Add("Ref", ref)
        doc.Add("SnX", SnX)
        doc.Add("SnY", Sny)
        doc.Add("Lat", Latitude)
        doc.Add("Long", Longitude)
        doc.Add("Direccion", Dir)
        doc.Add("Calle", Calle)
        doc.Add("Carrera", Carr)

        col.InsertOneAsync(doc)

    End Sub
    Public Shared Sub Consultar()

    End Sub
    Public Shared Sub ConsultarTodo()

    End Sub
    Public Shared Async Function Editar(prevRef As String, SnX1 As String, SnY As String, Dir As String, Calle As String, Carr As String) As Task
        'Conexion a la base de datos
        Dim col = ConexioDb.Conexion("sinaptron", False)

        'below code will update one record of the data
        Dim ref = SnX1 & SnY



        Dim updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("SnX", SnX1))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("SnY", SnY))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("Direccion", Dir))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("Calle", Calle))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("Carrera", Carr))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("Ref", ref))

    End Function
    Public Shared Async Function Eliminar(ref As String) As Task
        Dim col = ConexioDb.Conexion("sinaptron", False)

        Dim result = Await col.FindOneAndDeleteAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", ref), New FindOneAndDeleteOptions(Of BsonDocument))
    End Function
End Class
