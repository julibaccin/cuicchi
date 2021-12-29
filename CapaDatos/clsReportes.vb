Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsReportes
    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    'Public Function ReportePlanilla(pidPlanilla As Integer) As DataTable
    '    Dim table As New DataTable
    '    Try
    '        Dim cadena As String = "select Tomador, Ref, nombreCompania, detalle, patente, fVencimiento, importe from Comprobantes C
    '                            INNER JOIN Companias Co ON Co.idCompania = C.idCompania
    '                            WHERE idPlanilla = @idPlanilla"
    '        Dim comando As New SqlCommand(cadena, mCon)
    '        comando.Parameters.AddWithValue("@idPlanilla", pidPlanilla)
    '        Dim adaptador As New SqlDataAdapter(comando)

    '        adaptador.Fill(table)
    '        Return table
    '    Catch ex As Exception
    '        MsgBox("Error de sistema: REPORTES " & ex.Message)
    '        Return table
    '    Finally
    '        mCon.Close()
    '    End Try
    'End Function

    Public Function RecibosPorCompania(pfDesde As Int32, pfHasta As Int32) As DataTable
        Dim table As New DataTable
        Try
            Dim cadena As String =
                $"SELECT 
                CP.nombreCompania Compañia,
                SUM(CASE When importe > 0 Then importe Else 0 END) as Entro,                
                SUM(CASE When importe < 0 Then importe Else 0 END) as Salio, 
                --SUM(IIF(importe > 0 , importe, 0)) Entro,
                --SUM(IIF(importe < 0 , importe, 0)) Salio,
                SUM(importe) Total
                FROM Comprobantes C
                INNER JOIN Companias CP ON C.idCompania = CP.idCompania
                WHERE
                C.idTipoComprobante = 4
                AND fIngreso >= {pfDesde}
                AND fIngreso <= {pfHasta}
                GROUP BY CP.nombreCompania

                UNION

                SELECT 
                'TOTAL GENERAL' as Compañia,
                SUM(CASE When importe > 0 Then importe Else 0 END) as Entro,                
                SUM(CASE When importe < 0 Then importe Else 0 END) as Salio, 
                --SUM(IIF(importe > 0 , importe, 0)) Entro,
                --SUM(IIF(importe < 0 , importe, 0)) Salio,
                SUM(importe) Total
                FROM Comprobantes C
                INNER JOIN Companias CP ON C.idCompania = CP.idCompania
                WHERE
                C.idTipoComprobante = 4
                AND fIngreso >= {pfDesde}
                AND fIngreso <= {pfHasta}
                "

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

    Public Function TotalPorTipoComprobanteEfectivo(pfDesde As Int32, pfHasta As Int32) As DataTable
        Dim table As New DataTable
        Try
            Dim cadena As String =
                $"SELECT 
                TC.nombreTipoComprobante TipoComprobante,
                SUM(CASE When importe > 0 Then importe Else 0 END) as Entro,                
                SUM(CASE When importe < 0 Then importe Else 0 END) as Salio,                
                --SUM(IIF(importe > 0 , importe, 0)) Entro,
                --SUM(IIF(importe < 0 , importe, 0)) Salio,
                SUM(importe) Total
                FROM Comprobantes C
                INNER JOIN TipoComprobantes TC ON C.idTipoComprobante = TC.idTipoComprobante
                WHERE
                C.idTipoComprobante = 1
                AND fIngreso >= {pfDesde}
                AND fIngreso <= {pfHasta}
                GROUP BY  TC.nombreTipoComprobante
                "

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

    Public Function TotalPorTipoComprobanteOtros(pfDesde As Int32, pfHasta As Int32) As DataTable
        Dim table As New DataTable
        Try
            Dim cadena As String =
                $"
                SELECT 
                TC.nombreTipoComprobante TipoComprobante,
				Es.nombreEstado,
                SUM(importe) importe
                FROM Comprobantes C
                INNER JOIN TipoComprobantes TC ON C.idTipoComprobante = TC.idTipoComprobante
				INNER JOIN Estados Es ON C.idEstado = Es.idEstado
                WHERE
                C.idTipoComprobante NOT IN (1,4)
                AND fIngreso >= {pfDesde}
                AND fIngreso <= {pfHasta}
                GROUP BY  TC.nombreTipoComprobante, Es.nombreEstado
                "

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


End Class
