Imports System.Data.SqlClient
Imports System.Data
Public Class ClsEstados
    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub
    Public Function ConsultarEstados() As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("paConsultarEstados", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(0) & " " & data.Item(1))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarEstados" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function
End Class
