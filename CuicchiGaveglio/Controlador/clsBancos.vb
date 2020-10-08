Imports System.Data.SqlClient
Imports System.Data
Public Class ClsBancos

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearBanco(pIdBanco As Integer, pNombreBanco As String) As Integer
        Try
            Dim query As New SqlCommand("paCrearBanco", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idBanco", pIdBanco)
            query.Parameters.AddWithValue("nombreBanco", pNombreBanco)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: CrearBanco" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ConsultarBancos() As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("paConsultarBancos", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(0) & " " & data.Item(1))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarBancos" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ModificarBanco(pIdBanco As Integer, pNombreBanco As String) As Integer

        Try
            Dim Respuesta As New Object
            Dim query As New SqlCommand("paModificarBanco", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idBanco", pIdBanco)
            query.Parameters.AddWithValue("nombreBanco", pNombreBanco)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: ModificarBanco" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

End Class
