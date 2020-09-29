Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsComprobantes

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearMovimiento(pAlta As ModeloAltaComprobantes) As Integer

        Try
            Dim query As New SqlCommand("paCrearAltaComprobante", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            With query.Parameters
                .AddWithValue("idTipoComprobante", pAlta.idTipoComprobante)
                .AddWithValue("fIngreso", pAlta.FIngreso)
                .AddWithValue("idCliente", pAlta.idCliente)
                .AddWithValue("idCompania", pAlta.idCompania)
                .AddWithValue("obs", pAlta.Obs)
                .AddWithValue("importe", pAlta.Importe)
                .AddWithValue("fPago", pAlta.FPago)
                .AddWithValue("idUsuario", pAlta.idUsuario)
                .AddWithValue("idEstado", pAlta.idEstado)
                .AddWithValue("numero", pAlta.Numero)
                .AddWithValue("idBanco", pAlta.idBanco)
            End With

            mCon.Open()
            query.ExecuteNonQuery()

            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function CambiarEstado(pIdAlta As Integer, pObsBaja As String, pIdEstado As Integer, pIdCompania As Integer) As Integer

        Try
            Dim query As New SqlCommand("paModificarEstadoAltaComprobante", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            With query.Parameters
                .AddWithValue("idAlta", pIdAlta)
                .AddWithValue("idEstado", pIdEstado)
                .AddWithValue("ObsBaja", pObsBaja)
                .AddWithValue("idCompania", pIdCompania)
            End With

            mCon.Open()
            query.ExecuteNonQuery()

            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function EliminarMovimiento(pIdAlta As Integer) As Integer

        Try
            Dim query As New SqlCommand("paEliminarAltaComprobante", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            With query.Parameters
                .AddWithValue("idAlta", pIdAlta)
            End With

            mCon.Open()
            query.ExecuteNonQuery()

            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function


    Public Function ConsultarAltaComprobantes(pTabla As DataGridView, pTipoComprobante As String,
                                              pFechaDesde As Date, pFechaHasta As Date,
                                              pNumero As String, pNombreUsuario As String,
                                              pFechaPago As Date, pImporte As Integer,
                                              pNombreCliente As String, pNombreCompania As String,
                                              pNombreEstado As String
                                              ) As Int16

        Try
            Dim query As New SqlCommand("paConsultarComprobantes_FiltrosGenerales", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("NombreTipoComprobante", pTipoComprobante)
            query.Parameters.AddWithValue("fechaDesde", pFechaDesde)
            query.Parameters.AddWithValue("fechaHasta", pFechaHasta)
            query.Parameters.AddWithValue("numero", pNumero)
            query.Parameters.AddWithValue("NombreUsuario", pNombreUsuario)
            query.Parameters.AddWithValue("fPago", pFechaPago)
            query.Parameters.AddWithValue("importe", pImporte)
            query.Parameters.AddWithValue("NombreCliente", pNombreCliente)
            query.Parameters.AddWithValue("NombreCompania", pNombreCompania)
            query.Parameters.AddWithValue("NombreEstado", pNombreEstado)
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
