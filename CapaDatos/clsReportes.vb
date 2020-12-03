Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsReportes
    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function ReportePlanilla(pidCliente As Integer, pf As Date) As DataTable
        Dim table As New DataTable
        Try
            Dim cadena As String = "select Tomador, Ref, nombreCompania, detalle, patente, fVencimiento, importe from PlanillasComprobantes PC
                                INNER JOIN Companias C ON PC.idCompania = C.idCompania
                                WHERE idCliente = @idCliente AND f = @f"
            Dim comando As New SqlCommand(cadena, mCon)
            comando.Parameters.AddWithValue("@idCliente", pidCliente)
            comando.Parameters.AddWithValue("@f", pf)
            Dim adaptador As New SqlDataAdapter(comando)

            adaptador.Fill(table)
            Return table
        Catch ex As Exception
            MsgBox("Error de sistema: REPORTES " & ex.Message)
            Return table
        Finally
            mCon.Close()
        End Try
    End Function
    Public Function MovimientosComprobantes(pfDesde As Date, pfHasta As Date) As DataTable
        Dim table As New DataTable
        Try
            Dim cadena As String = "select nombreTipoComprobante as COMPROBANTE,
		                            SUM(IIF(importe > 0 , importe, 0)) as ENTRO,
		                            SUM(IIF(importe < 0 , importe, 0)) as SALIO,
		                            SUM(importe) as TOTAL 
                                    from Comprobantes C
                                    INNER JOIN TipoComprobantes TC ON C.idTipoComprobante = TC.idTipoComprobante
                                    where C.idTipoComprobante != 4 AND fIngreso between @fDesde and @fHasta
                                    group by TC.nombreTipoComprobante"
            Dim comando As New SqlCommand(cadena, mCon)
            comando.Parameters.AddWithValue("@fDesde", pfDesde)
            comando.Parameters.AddWithValue("@fHasta", pfHasta)
            Dim adaptador As New SqlDataAdapter(comando)

            adaptador.Fill(table)
            Return table
        Catch ex As Exception
            MsgBox("Error de sistema: REPORTES " & ex.Message)
            Return table
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function MovimientosRecibos(pfDesde As Date, pfHasta As Date) As DataTable
        Dim table As New DataTable
        Try
            Dim cadena As String = "select nombreCompania as COMPANIA,
		                            SUM(IIF(importe > 0 , importe, 0)) as ENTRO,
		                            SUM(IIF(importe < 0 , importe, 0)) as SALIO,
		                            SUM(importe) as TOTAL 
                                    from Comprobantes C
                                    INNER JOIN Companias Com ON C.idCompania = Com.idCompania
                                    where idTipoComprobante = 4 AND fIngreso between @fDesde and @fHasta
                                    group by nombreCompania"
            Dim comando As New SqlCommand(cadena, mCon)
            comando.Parameters.AddWithValue("@fDesde", pfDesde)
            comando.Parameters.AddWithValue("@fHasta", pfHasta)
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(table)
            Return table
        Catch ex As Exception
            MsgBox("Error de sistema: REPORTES " & ex.Message)
            Return table
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function TotalGeneralComprobantes() As DataTable
        Dim table As New DataTable
        Try
            Dim cadena As String = "select nombreTipoComprobante as COMPROBANTE,
		                            SUM(IIF(importe > 0 , importe, 0)) as ENTRO,
		                            SUM(IIF(importe < 0 , importe, 0)) as SALIO,
		                            SUM(importe) as TOTAL 
                                    from Comprobantes C
                                    INNER JOIN TipoComprobantes TC ON C.idTipoComprobante = TC.idTipoComprobante
                                    where C.idTipoComprobante != 4
                                    group by TC.nombreTipoComprobante"
            Dim comando As New SqlCommand(cadena, mCon)
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(table)
            Return table
        Catch ex As Exception
            MsgBox("Error de sistema: REPORTES " & ex.Message)
            Return table
        Finally
            mCon.Close()
        End Try
    End Function
    Public Function TotalGeneralRecibos() As DataTable
        Dim table As New DataTable
        Try
            Dim cadena As String = "select nombreCompania as COMPANIA,
		                            SUM(IIF(importe > 0 , importe, 0)) as ENTRO,
		                            SUM(IIF(importe < 0 , importe, 0)) as SALIO,
		                            SUM(importe) as TOTAL 
                                    from Comprobantes C
                                    INNER JOIN Companias Com ON C.idCompania = Com.idCompania
                                    where idTipoComprobante = 4
                                    group by nombreCompania"
            Dim comando As New SqlCommand(cadena, mCon)
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(table)
            Return table
        Catch ex As Exception
            MsgBox("Error de sistema: TotalGeneralRecibos " & ex.Message)
            Return table
        Finally
            mCon.Close()
        End Try
    End Function

End Class
