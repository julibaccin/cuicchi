Imports System.Data.SqlClient
Public Class clsSaldos
    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function ConsultarSaldosPorComprobante(pTabla As DataGridView, pFIngreso As Date)
        Try
            Dim query As New SqlCommand("paConsultarSaldosPorComprobante", mCon)
            query.CommandType = CommandType.StoredProcedure
            query.Parameters.AddWithValue("fIngreso", pFIngreso)
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla

            Return 1

        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try
    End Function

    Public Function ConsultarChequesProximosAVencer(pTabla As DataGridView)
        Try
            Dim query As New SqlCommand("paConsultarChequesProximosAVencer", mCon)
            query.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla

            Return 1

        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try
    End Function

End Class
