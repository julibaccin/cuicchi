Imports System.Data.SqlClient

Public Class clsLogin

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function Login(pUser, pPass) As Integer

        Try
            Dim query As New SqlCommand("paLogin", mCon)
            query.CommandType = CommandType.StoredProcedure
            query.Parameters.AddWithValue("nombreUsuario", pUser)
            query.Parameters.AddWithValue("pass", pPass)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            If data.HasRows = True Then
                data.Read()
                Return data.Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

End Class
