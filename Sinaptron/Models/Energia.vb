Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Energia
    Public Shared Sub Guardar(nombre As String, bateria As Double, panel As Double)

        'Conexion a la base de datos
        Dim col = ConexioDb.ConexionRemota("energia")

        Dim doc As New BsonDocument()

        Console.WriteLine("pase")
        doc.Add("nombre", nombre)
        doc.Add("date_created", Format(Date.Now, "dd/MM/yyyy HH:mm:ss tt"))
        doc.Add("bateria", bateria)
        doc.Add("panel", panel)
        doc.Add("date_only", Format(Date.Now, "dd/MM/yyyy"))
        doc.Add("dia", Format(Date.Now, "dd"))
        doc.Add("mes", Format(Date.Now, "MM"))
        doc.Add("año", Format(Date.Now, "yyyy"))
        doc.Add("hora", Format(Date.Now, "HH"))
        doc.Add("minuto", Format(Date.Now, "mm"))
        doc.Add("segundo", Format(Date.Now, "ss"))



        col.InsertOneAsync(doc)

    End Sub
    Public Shared Function Consultar(nombre As String) As List(Of BsonDocument)
        Dim col = ConexioDb.ConexionRemota("energia")

        Dim filter = New BsonDocument("nombre", nombre)

        'Consulta todo
        Dim result = col.Find(filter).ToList
        '.Sort("{date_create: -1}").ToList
        Return result
    End Function

    Public Shared Function ConsultarId(id As String) As List(Of BsonDocument)

        Dim col = ConexioDb.ConexionRemota("energia")

        Dim filter = New BsonDocument("_id", ObjectId.Parse(id))

        'Consulta todo
        Dim result = col.Find(filter).ToList
        Return result
    End Function

    Public Shared Function ConsultarTodo() As List(Of BsonDocument)

        Dim col = ConexioDb.ConexionRemota("energia")

        Dim result = col.Find(New BsonDocument).ToList

        Return result

    End Function

    Public Shared Async Function Editar(prevNombre As String, nombre As String, duracion As Integer) As Task
        'Conexion a la base de datos
        Dim col = ConexioDb.ConexionRemota("energia")



        Dim updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("nombre", prevNombre), Builders(Of BsonDocument).Update.Set(Of String)("duracion", duracion))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("nombre", prevNombre), Builders(Of BsonDocument).Update.Set(Of String)("nombre", nombre))

    End Function
    Public Shared Async Function Eliminar(nombre As String) As Task
        Dim col = ConexioDb.ConexionRemota("energia")

        Dim result = Await col.FindOneAndDeleteAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("nombre", nombre), New FindOneAndDeleteOptions(Of BsonDocument))
    End Function
    'Verfica que no se cree un mismo elmento ya almacenado en la base de datos
    Public Shared Function VerificacionSn(nombre As String) As Boolean

        Dim col = ConexioDb.ConexionRemota("energia")
        'Consulta todo
        Dim result = col.Find(New BsonDocument).ToList
        For Each item In result
            If nombre = item.Item(2).ToString Then
                Return False
                'termina el ciclo
                Exit For
            End If

        Next

        Return True
    End Function
End Class
