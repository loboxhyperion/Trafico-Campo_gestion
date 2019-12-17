Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System
Imports System.Text.RegularExpressions

Imports MongoDB.Driver.GridFS
Imports MongoDB.Driver.Linq

Public Class DataBaseForm
    Dim _NOMBRE As String
    Private Sub DataBaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ejecuta el servidor
        ServidorConexion.AbrirServidor()
    End Sub
End Class