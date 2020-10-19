Imports System.Data.SqlClient
Imports System.Data

Public Class ClsLogin
    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function Login(pUser, pPass) As ArrayList
        Dim respuesta As New ArrayList()
        Try
            Dim cadena As String = "SELECT idUsuario ,idRol FROM Usuarios WHERE nombreUsuario = @nombreUsuario AND pass = @pass"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("nombreUsuario", pUser)
            query.Parameters.AddWithValue("pass", pPass)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            If data.HasRows = True Then
                data.Read()
                respuesta.Add(data.Item("idUsuario"))
                respuesta.Add(data.Item("idRol"))
                Return respuesta
            Else
                Return respuesta
            End If
        Catch ex As Exception
            MsgBox("Error de sistema: Login" & ex.Message)
            Return respuesta
        Finally
            mCon.Close()
        End Try

    End Function

End Class
