Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsSaldos
    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub


    Public Function ConsultarSaldosPorCliente(pIdCliente As Integer) As String
        Try
            Dim cadena As String = "Select  IsNull((Select SUM(importe) From AltaComprobantes WHERE idCliente = @idCliente),0) as IMPORTE_FAVOR,
	    IsNull((Select SUM(importe) From PlanillasPolizas WHERE idCliente = @idCliente),0) as IMPORTE_CONTRA"
            Dim query As New SqlCommand(cadena, mCon)

            query.Parameters.AddWithValue("idCliente", pIdCliente)

            mCon.Open()
            Dim resp = query.ExecuteReader()
            resp.Read()

            Dim total As Integer = resp.Item(0) - resp.Item(1)
            Dim respuesta As String = ""

            If total = 0 Then
                respuesta = "El cliente tiene la cuenta en 0"
            ElseIf total > 0 Then
                respuesta = $"El cliente tiene a favor $ {total}"
            ElseIf total < 0 Then
                respuesta = $"El cliente tiene en contra {total * -1}"
            End If

            Return respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarSaldosPorComprobante" & ex.Message)
            Return ""
        Finally
            mCon.Close()
        End Try
    End Function



    Public Function ConsultarSaldosPorComprobante(pTabla As DataGridView, pFIngreso As Date)
        Try
            Dim query As New SqlCommand("paConsultarSaldosPorComprobante", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("fIngreso", pFIngreso)
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla

            Return 1

        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarSaldosPorComprobante" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try
    End Function

    Public Function ConsultarChequesProximosAVencer(pTabla As DataGridView)
        Try
            Dim query As New SqlCommand("paConsultarChequesProximosAVencer", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla

            Return 1

        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarChequesProximosAVencer" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try
    End Function

End Class
