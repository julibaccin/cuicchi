Imports System.Data.SqlClient
Imports System.IO

Public MustInherit Class Conn
    Public Function ObtenerConexion() As SqlConnection
        Try
            Dim archivo As New StreamReader("./dbConfig.txt")
            Dim cadenaConexion = archivo.ReadLine()
            archivo.Dispose()
            Return New SqlConnection(cadenaConexion)
        Catch ex As Exception
            MsgBox("Error ObtenerConexion: " + ex.Message)
            Return New SqlConnection()
        End Try

    End Function
End Class
