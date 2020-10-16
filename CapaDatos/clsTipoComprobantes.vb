Imports System.Data.SqlClient
Imports System.Data
Public Class ClsTipoComprobantes
    Inherits Conn

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function ConsultarTipoComprobantes() As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("SELECT * FROM TipoComprobantes ", mCon)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(0) & " " & data.Item(1))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarTipoComprobantes" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function

End Class
