Imports System.Data.SqlClient

Public Class clsUsuarios
    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function ConsultarUsuarios() As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("SELECT * FROM Usuarios", mCon)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(0) & " " & data.Item(1))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarUsuarios" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function
End Class
