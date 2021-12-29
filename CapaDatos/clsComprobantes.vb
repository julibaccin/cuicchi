Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsComprobantes
    Inherits Conn
    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub
    Public Function CrearMovimiento(pAlta As ModeloComprobante) As Int16

        Try
            Dim cadena As String =
            "INSERT INTO Comprobantes 
            (idTipoComprobante, fIngreso, idCliente, idCompania, obs, numero, idBanco, importe, fPago, idUsuario, idEstado, obsBaja, idEstadoOperacion)
		    VALUES(@idTipoComprobante,@fIngreso,@idCliente,@idCompania,@obs,@numero,@idBanco,@importe,@fPago,@idUsuario,@idEstado,'',@idEstadoOperacion)
            SELECT TOP 1 idAlta From Comprobantes ORDER BY idAlta DESC"
            Dim query As New SqlCommand(cadena, mCon)
            With query.Parameters
                .AddWithValue("idTipoComprobante", pAlta.IdTipoComprobante)
                .AddWithValue("fIngreso", pAlta.FIngreso)
                .AddWithValue("idCliente", pAlta.IdCliente)
                .AddWithValue("idCompania", pAlta.IdCompania)
                .AddWithValue("obs", pAlta.Obs)
                .AddWithValue("importe", pAlta.Importe)
                .AddWithValue("fPago", pAlta.FPago)
                .AddWithValue("idUsuario", pAlta.IdUsuario)
                .AddWithValue("idEstado", pAlta.IdEstado)
                .AddWithValue("numero", pAlta.Numero)
                .AddWithValue("idBanco", pAlta.IdBanco)
                .AddWithValue("idEstadoOperacion", pAlta.IdEstadoOperacion)
            End With

            mCon.Open()
            Dim resp = query.ExecuteReader()
            resp.Read()
            Return resp.Item(0)
        Catch ex As Exception
            MsgBox("Error de sistema: CrearMovimiento" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function CrearMovimientoPlanilla(pAlta As ModeloComprobante) As Int16

        Try
            Dim cadena As String =
            "INSERT INTO Comprobantes 
            (idTipoComprobante, fIngreso, idCliente, idCompania, obs, numero, idBanco, importe, fPago, idUsuario, idEstado, obsBaja, idEstadoOperacion, idPlanilla)
		    VALUES(@idTipoComprobante,@fIngreso,@idCliente,@idCompania,@obs,@numero,@idBanco,@importe,@fPago,@idUsuario,@idEstado,'',@idEstadoOperacion, @idPlanilla)
            SELECT TOP 1 idAlta From Comprobantes ORDER BY idAlta DESC"
            Dim query As New SqlCommand(cadena, mCon)
            With query.Parameters
                .AddWithValue("idTipoComprobante", pAlta.IdTipoComprobante)
                .AddWithValue("fIngreso", pAlta.FIngreso)
                .AddWithValue("idCliente", pAlta.IdCliente)
                .AddWithValue("idCompania", pAlta.IdCompania)
                .AddWithValue("obs", pAlta.Obs)
                .AddWithValue("importe", pAlta.Importe)
                .AddWithValue("fPago", pAlta.FPago)
                .AddWithValue("idUsuario", pAlta.IdUsuario)
                .AddWithValue("idEstado", pAlta.IdEstado)
                .AddWithValue("numero", pAlta.Numero)
                .AddWithValue("idBanco", pAlta.IdBanco)
                .AddWithValue("idEstadoOperacion", pAlta.IdEstadoOperacion)
                .AddWithValue("IdPlanilla", pAlta.IdPlanilla)
            End With

            mCon.Open()
            Dim resp = query.ExecuteReader()
            resp.Read()
            Return resp.Item(0)
        Catch ex As Exception
            MsgBox("Error de sistema: CrearMovimientoPlanilla" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function CrearMovimientoReciboPlanilla(pAlta As ModeloComprobante) As Int16

        Try
            Dim cadena As String =
            "INSERT INTO Comprobantes 
            (idTipoComprobante, fIngreso, idCliente, idCompania, obs, numero,
             idBanco, importe, fPago, idUsuario, idEstado, idEstadoOperacion,
             Tomador, Ref, Detalle, Patente, FVencimiento, idPlanilla)
		    VALUES(@idTipoComprobante, @fIngreso, @idCliente ,@idCompania,@obs,@numero,
             @idBanco,@importe,@fPago, @idUsuario, @idEstado ,@idEstadoOperacion,
             @Tomador, @Ref, @Detalle, @Patente, @FVencimiento, @idPlanilla)
            SELECT TOP 1 idAlta From Comprobantes ORDER BY idAlta DESC"
            Dim query As New SqlCommand(cadena, mCon)
            With query.Parameters
                .AddWithValue("idTipoComprobante", pAlta.IdTipoComprobante)
                .AddWithValue("fIngreso", pAlta.FIngreso)
                .AddWithValue("idCliente", pAlta.IdCliente)
                .AddWithValue("idCompania", pAlta.IdCompania)
                .AddWithValue("obs", pAlta.Obs)
                .AddWithValue("importe", pAlta.Importe)
                .AddWithValue("fPago", pAlta.FPago)
                .AddWithValue("idUsuario", pAlta.IdUsuario)
                .AddWithValue("idEstado", pAlta.IdEstado)
                .AddWithValue("numero", pAlta.Numero)
                .AddWithValue("idBanco", pAlta.IdBanco)
                .AddWithValue("idEstadoOperacion", pAlta.IdEstadoOperacion)
                .AddWithValue("idPlanilla", pAlta.IdPlanilla)
                .AddWithValue("Tomador", pAlta.Tomador)
                .AddWithValue("Ref", pAlta.Ref)
                .AddWithValue("Detalle", pAlta.Detalle)
                .AddWithValue("Patente", pAlta.Patente)
                .AddWithValue("FVencimiento", pAlta.FVencimiento)
            End With

            mCon.Open()
            Dim resp = query.ExecuteReader()
            resp.Read()
            Return resp.Item(0)
        Catch ex As Exception
            MsgBox("Error de sistema: CrearMovimientoReciboPlanilla" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function CambiarEstado(
                                  pIdAlta As Integer,
                                  pObsBaja As String,
                                  pIdEstado As Integer,
                                  pIdCompania As Integer,
                                  pModificadoPorIdUsuario As Integer
                                  ) As Int16

        Try
            Dim cadena As String =
                "
                UPDATE Comprobantes 
                SET 
                idEstado=@idEstado,
                obsBaja = @obsBaja,
                idCompania = @idCompania,
                modificadoPorIdUsuario = @modificadoPorIdUsuario,
                fechaModifico = GETDATE()
                WHERE idAlta = @idAlta
                "
            Dim query As New SqlCommand(cadena, mCon)
            With query.Parameters
                .AddWithValue("idAlta", pIdAlta)
                .AddWithValue("idEstado", pIdEstado)
                .AddWithValue("ObsBaja", pObsBaja)
                .AddWithValue("idCompania", pIdCompania)
                .AddWithValue("modificadoPorIdUsuario", pModificadoPorIdUsuario)
            End With

            mCon.Open()
            query.ExecuteNonQuery()

            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: CambiarEstado" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function CambiarEstadoOperacion(pIdPlanilla As Integer, pidEstadoOperacion As Integer) As Int16

        Try
            Dim cadena As String = "UPDATE Comprobantes SET idEstadoOperacion= @idEstadoOperacion WHERE idPlanilla = @idPlanilla "
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idPlanilla", pIdPlanilla)
            query.Parameters.AddWithValue("idEstadoOperacion", pidEstadoOperacion)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: CambiarEstado" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function ConsultarComprobantes(pTabla As DataGridView, pTipoComprobante As String,
                                              pFechaDesde As Integer, pFechaHasta As Integer,
                                              pNumero As String, pNombreUsuario As String,
                                              pFechaPago As Integer, pImporte As String,
                                              pNombreCliente As String, pNombreCompania As String,
                                              pNombreEstado As String
                                              ) As Int16

        'Ajuste de importe
        Dim condicionImporte = ""
        If pImporte <> 0 Then
            condicionImporte = $"AND (importe = {pImporte.Replace(",", ".")}) "
        End If

        Try
            Dim cadena As String = $"SELECT fIngreso as fIngreso, Clientes.nombreCliente, 
			                        TipoComprobantes.nombreTipoComprobante AS Tipo_Comprobante,
			                        importe, Companias.nombreCompania,
			                        Estados.nombreEstado AS Estado,
			                        fPago, numero, Bancos.nombreBanco,
			                        C.obs, obsBaja, a.nombreUsuario, idAlta,
                                    CASE   
									WHEN C.modificadoPorIdUsuario IS NULL THEN ''   
									ELSE b.nombreUsuario  
									END UsuarioModifico,
                                    FechaModifico fecModificacion
		                            FROM Comprobantes C
		            INNER JOIN TipoComprobantes ON C.idTipoComprobante = TipoComprobantes.idTipoComprobante
		            INNER JOIN Clientes ON Clientes.idCliente = C.idCliente
		            INNER JOIN Companias ON Companias.idCompania = C.idCompania
		            INNER JOIN Bancos ON Bancos.idBanco = C.idBanco
		            INNER JOIN Estados ON Estados.idEstado = C.idEstado
		            INNER JOIN Usuarios a ON a.idUsuario = C.idUsuario
				    LEFT JOIN Usuarios b ON b.idUsuario = C.modificadoPorIdUsuario
		            WHERE
                    fIngreso >= @fechaDesde AND fIngreso <= @fechaHasta 
                    AND (numero LIKE '%' + @numero + '%') 
		            {condicionImporte} 
		            AND (Estados.nombreEstado LIKE '%' + @NombreEstado + '%')
		            AND (Clientes.nombreCliente LIKE '%'+ @NombreCliente +'%' )
		            AND (Companias.nombreCompania LIKE '%'+ @NombreCompania +'%' )
		            AND (TipoComprobantes.nombreTipoComprobante LIKE '%'+ @NombreTipoComprobante +'%')
		            AND (a.nombreUsuario LIKE  '%'+ @NombreUsuario +'%')
                    AND idEstadoOperacion = 1"
            '(fIngreso >= @fechaDesde AND fIngreso <= @fechaHasta) AND
            Dim query As New SqlCommand(cadena, mCon)
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
            MsgBox("Error de sistema: ConsultarComprobantes" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function EliminarComprobante(pIdAlta As Integer) As Int16

        Try
            Dim cadena As String = "DELETE FROM Comprobantes WHERE idAlta=@idAlta"
            Dim query As New SqlCommand(cadena, mCon)
            With query.Parameters
                .AddWithValue("idAlta", pIdAlta)
            End With

            mCon.Open()
            query.ExecuteNonQuery()

            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: EliminarComprobante" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function ConsultarIdCompania(pNombreCompania As String) As Integer

        Try
            Dim aux = ""
            If IsNothing(pNombreCompania) Or pNombreCompania = "" Then
                aux = "N"
            Else
                aux = pNombreCompania
            End If

            Dim cadena As String = "SELECT TOP 1 idCompania FROM Companias WHERE nombreCompania = @nombreCompania "
            Dim query As New SqlCommand(cadena, mCon)
            With query.Parameters
                .AddWithValue("nombreCompania", aux)
            End With

            mCon.Open()
            Dim a = query.ExecuteReader()
            a.Read()

            Return a.Item(0)
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarIdCompania" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
End Class
