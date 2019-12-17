Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Log
    Public Shared Sub Guardar(accion As String)
        Try
            'Conexion a la base de datos
            Dim col = ConexioDb.Conexion("logs", False)

            Dim doc As New BsonDocument()
            doc.Add("date_created", Format(Date.Now, "dd/MM/yy HH:mm:ss tt"))
            doc.Add("accion", accion)
            doc.Add("sincronizacion", "pendiente")

            col.InsertOneAsync(doc)
        Catch ex As Exception
            MsgBox("no se pudo conectar con la base de datos")
        End Try

    End Sub
    Public Shared Async Function SubirCambiosAsync() As Task

        Try
            ' Consulta los logs locales
            Dim colLocal = ConexioDb.Conexion("logs", False)
            Dim filter = New BsonDocument("sincronizacion", "pendiente")

            Dim result = colLocal.Find(filter).ToList
            'sI Hay logs pendientes pasa
            If result.Count > 0 Then
                SnPrincipal.btnCambiosRemoto.Enabled = False
                SnPrincipal.btnCambiosRemoto.BackColor = Color.Silver
                'Conexion a la base de datos remota
                Dim col = ConexioDb.Conexion("logs", True)

                'Guarda los logs  consultados localmente en la base de datos remota

                For Each item In result
                    Dim doc As New BsonDocument()
                    doc.Add("date_created", item.Item(1))
                    doc.Add("accion", item.Item(2))
                    doc.Add("sincronizacion", item.Item(3))

                    Await col.InsertOneAsync(doc)

                    'cambia el estado de sincronización de pendiente a completo para evitar subir repetidos
                Next
                colLocal.UpdateManyAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("sincronizacion", "pendiente"), Builders(Of BsonDocument).Update.Set(Of String)("sincronizacion", "completado"))
                MsgBox("Se ha completado la actualización de los datos.")
                SnPrincipal.btnCambiosRemoto.Enabled = True
                SnPrincipal.btnCambiosRemoto.BackColor = Color.ForestGreen

            Else 'no hay nada pendiente
                MsgBox("No hay cambios pendientes por subir")
            End If
            Dim updoneresult


        Catch ex As Exception
            MsgBox("no se pudo conectar con la base de datos")
        End Try
    End Function
End Class
