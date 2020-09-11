Imports System.Data.SqlClient
Imports CuicchiGaveglio.My
Module mdlConexion

    Public Function ObtenerConexion() As SqlConnection
        Dim mConexion As New SqlConnection(MySettings.Default.CadenaConexion)
        Return mConexion
    End Function


End Module
