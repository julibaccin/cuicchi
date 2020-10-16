Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsComprobantes
    Inherits Conn

    Dim mCon As SqlConnection
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
                .AddWithValue("idEstadoOperacion", pAlta.idEstadoOperacion)
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

    Public Function CambiarEstado(pIdAlta As Integer, pObsBaja As String, pIdEstado As Integer, pIdCompania As Integer) As Int16

        Try
            Dim cadena As String = "UPDATE Comprobantes SET idEstado=@idEstado, obsBaja = @obsBaja, idCompania = @idCompania WHERE idAlta = @idAlta"
            Dim query As New SqlCommand(cadena, mCon)
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
            MsgBox("Error de sistema: CambiarEstado" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ConsultarComprobantes(pTabla As DataGridView, pTipoComprobante As String,
                                              pFechaDesde As Date, pFechaHasta As Date,
                                              pNumero As String, pNombreUsuario As String,
                                              pFechaPago As Date, pImporte As Integer,
                                              pNombreCliente As String, pNombreCompania As String,
                                              pNombreEstado As String
                                              ) As Int16

        Try
            Dim cadena As String = "SELECT fIngreso, Clientes.nombreCliente, 
			                        TipoComprobantes.nombreTipoComprobante AS Tipo_Comprobante,
			                        importe, Companias.nombreCompania,
			                        Estados.nombreEstado AS Estado,
			                        fPago, numero, Bancos.nombreBanco,
			                        obs, obsBaja, Usuarios.nombreUsuario, idAlta
		                            FROM Comprobantes C
		        INNER JOIN TipoComprobantes ON C.idTipoComprobante = TipoComprobantes.idTipoComprobante
		        INNER JOIN Clientes ON Clientes.idCliente = C.idCliente
		        INNER JOIN Companias ON Companias.idCompania = C.idCompania
		        INNER JOIN Bancos ON Bancos.idBanco = C.idBanco
		        INNER JOIN Estados ON Estados.idEstado = C.idEstado
		        INNER JOIN Usuarios ON Usuarios.idUsuario = C.idUsuario
		        WHERE 
		            (fIngreso >= @fechaDesde AND fIngreso <= @fechaHasta) AND
		            (numero LIKE '%' + @numero + '%') AND
		            (importe >= @importe) AND
		            (Estados.nombreEstado LIKE '%' + @NombreEstado + '%') AND
		            (Clientes.nombreCliente LIKE '%'+ @NombreCliente +'%' ) AND
		            (Companias.nombreCompania LIKE '%'+ @NombreCompania +'%' ) AND
		            (TipoComprobantes.nombreTipoComprobante LIKE '%'+ @NombreTipoComprobante +'%') AND
		            (Usuarios.nombreUsuario LIKE  '%'+ @NombreUsuario +'%')"

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

End Class
