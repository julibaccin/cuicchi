Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsSaldos
    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub


    Public Function ConsultarSaldosPorCliente(pIdCliente As Integer) As String
        Try
            Dim cadena As String = "
        SELECT isNull((SELECT SUM(importe) FROM Comprobantes WHERE idCliente = @idCliente AND idTipoComprobante != 4),0) as FAVOR,
	   isNull((SELECT SUM(importe) FROM Comprobantes WHERE idCliente = @idCliente AND idTipoComprobante = 4 AND importe > 0),0) as CONTRA"
            Dim query As New SqlCommand(cadena, mCon)

            query.Parameters.AddWithValue("idCliente", pIdCliente)

            mCon.Open()
            Dim resp = query.ExecuteReader()
            resp.Read()

            Dim total As Integer = resp.Item(0) - resp.Item(1)
            Dim respuesta As String = ""

            If resp.Item(1) = 0 Then
                respuesta = "El cliente no tiene ninguna planilla cargada"
                Return respuesta
            End If

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



    Public Function ConsultarPlanillasPendientes(pTabla As DataGridView)
        Try
            Dim cadena As String = "SELECT U.nombreUsuario as USUARIO,C.nombreCliente as CLIENTE, P.fPlanilla as FECHA_PLANILLA, P.idCliente, idPlanilla FROM Planillas P
                                    INNER JOIN Clientes C ON P.idCliente = C.idCliente
                                    INNER JOIN Usuarios U ON P.idUsuario = U.idUsuario 
                                    WHERE idEstadoOperacion = 2 
									AND idPlanilla IN (SELECT idPlanilla FROM Comprobantes WHERE idPlanilla is not null AND idTipoComprobante = 4 GROUP BY idPlanilla)
                                    AND idPlanilla IN (SELECT idPlanilla FROM Comprobantes WHERE idPlanilla is not null AND idTipoComprobante <> 4 GROUP BY idPlanilla)"
            Dim query As New SqlCommand(cadena, mCon)
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
            Dim cadena = "SELECT numero as Numero_Cheque, DATEADD(DAY,30,CONVERT(dateTIME,convert(char(8),CONVERT(VARCHAR(8),fPago)))) as Fecha_de_Vencimiento from Comprobantes AC
                          INNER JOIN Estados ON AC.idEstado = Estados.idEstado
                          WHERE (idTipoComprobante = 3 and AC.idEstado = 1) AND DATEDIFF(DAY, GETDATE(), DATEADD(DAY,30,CONVERT(dateTIME,convert(char(8),CONVERT(VARCHAR(8),fPago))))) <= 5"
            Dim query As New SqlCommand(cadena, mCon)
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla

            Return 1

        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarChequesProximosAVencer: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try
    End Function

    Public Function ConsultarPlanillasRechazadas(pTabla As DataGridView)
        Try
            Dim cadena As String = "SELECT C.nombreCliente as CLIENTE, P.fPlanilla as FECHA_PLANILLA, P.idCliente, idPlanilla FROM Planillas P
                                    INNER JOIN Clientes C ON P.idCliente = C.idCliente 
                                    WHERE idEstadoOperacion = 3"
            Dim query As New SqlCommand(cadena, mCon)
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

End Class
