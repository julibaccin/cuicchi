Imports System.Data.SqlClient
Imports CapaDatos.My

Public MustInherit Class Conn
    Public Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(MySettings.Default.CadenaConexion)
    End Function
End Class
