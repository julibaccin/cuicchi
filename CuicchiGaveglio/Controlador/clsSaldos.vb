Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsSaldos
    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

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
            MsgBox("Error de sistema: " & ex.Message)
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
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try
    End Function

    Public Function DevolverCuentaCliente(pIdCliente As Integer) As ArrayList
        Dim respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("paDevolverCuentaCliente", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idCliente", pIdCliente)
            mCon.Open()

            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                respuesta.Add(New With {.entro = data.Item(0), .salio = data.Item(1)})
            End While

            Return respuesta

        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return respuesta
        Finally
            mCon.Close()
        End Try
    End Function
End Class
