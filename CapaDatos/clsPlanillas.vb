Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsPlanillas
    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    'Lectura
    Public Function DevolverPlanillasCliente(pidCliente As Integer, pidUsuario As Integer) As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim cadena As String = "SELECT fPlanilla FROM Planillas WHERE idCliente = @idCliente AND idUsuario = @idUsuario"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("idUsuario", pidUsuario)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(0))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: DevolverPlanillasCliente" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function DevolverRecibosDePlanilla(pDataGrid As DataGridView,
                                              pIdPlanilla As Integer) As Int16
        Dim data As New ArrayList()
        Try
            Dim cadena As String = "SELECT Tomador,Ref,Detalle,Patente, FVencimiento as FVencimiento,importe From Comprobantes C
                                    WHERE idPlanilla = @idPlanilla and idTipoComprobante = 4"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idPlanilla", pIdPlanilla)
            mCon.Open()
            Dim adapter As New SqlDataAdapter(query)
            Dim table As New DataTable()
            adapter.Fill(table)
            pDataGrid.DataSource = table
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: DevolverRecibosDePlanilla " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function DevolverPagosDePlanilla(pDataGrid As DataGridView,
                                              pIdPlanilla As Integer) As Int16
        Dim data As New ArrayList()
        Try
            Dim cadena As String = "SELECT 
                                    idtipocomprobante as idtipocomprobante,
                                    C.fingreso as fingreso,
                                    idcliente as idcliente,
                                    idcompania as idcompania,
                                    importe as importe,
                                    numero as numero,
                                    fpago as fpago,
                                    idbanco as idbanco,
                                    obs as Obs 
                                    From Comprobantes C
                                    WHERE idPlanilla = @idPlanilla and idTipoComprobante <> 4"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idPlanilla", pIdPlanilla)
            mCon.Open()
            Dim adapter As New SqlDataAdapter(query)
            Dim table As New DataTable()
            adapter.Fill(table)
            pDataGrid.DataSource = table
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: DevolverPagosDePlanilla " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function DevolverCompaniasdeRecibosDePlanilla(pIdPlanilla As Integer) As ArrayList
        Dim data As New ArrayList()
        Try
            Dim cadena As String = "select nombreCompania From Comprobantes C
                                    INNER JOIN Companias Co ON Co.idCompania = C.IdCompania
                                    WHERE idPlanilla = @idPlanilla AND idTipoComprobante = 4"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idPlanilla", pIdPlanilla)
            mCon.Open()
            Dim comps = query.ExecuteReader()
            While comps.Read()
                data.Add(comps.Item(0))
            End While
            Return data
        Catch ex As Exception
            MsgBox("Error de sistema: DevolverCompaniasdeRecibosDePlanilla" & ex.Message)
            Return data
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function CrearPlanilla(pidCliente As Integer, pF As Integer, pIdUsuario As Integer) As Int16
        Try
            Dim cadena As String = "INSERT INTO Planillas (idCliente,fPlanilla,idUsuario,idEstadoOperacion)
                                    VALUES (@idCliente,@fPlanilla,@idusuario,2)"
            Dim query As New SqlCommand(cadena, mCon)

            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("fPlanilla", pF)
            query.Parameters.AddWithValue("idusuario", pIdUsuario)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: CrearPlanilla" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function DatosGeneralesPlanilla(pIdPlanilla As Integer) As String

        Dim Respuesta As New ArrayList
        Try
            Dim cadena As String = "SELECT nombreEstadoOperacion FROM Planillas P
                                    INNER JOIN EstadosOperacion EO ON P.idEstadoOperacion = EO.idEstadoOperacion 
                                    WHERE idPlanilla = @idPlanilla"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idPlanilla", pIdPlanilla)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Return data.Item(0)
            End While
            Return 0
        Catch ex As Exception
            MsgBox("Error de sistema: DatosGeneralesPlanilla" & ex.Message)
            Return ""
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ObtenerIdPlanilla(pIdCliente As Integer, pfPlanilla As Integer) As Integer

        Dim Respuesta As New ArrayList
        Try
            Dim cadena As String = "SELECT idPlanilla FROM Planillas WHERE idCliente = @idCliente AND
                                    fPlanilla = @fPlanilla"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("IdCliente", pIdCliente)
            query.Parameters.AddWithValue("fPlanilla", pfPlanilla)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Return data.Item(0)
            End While
            Return 0
        Catch ex As Exception
            MsgBox("Error de sistema: DatosGeneralesPlanilla" & ex.Message)
            Return ""
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function CambiarEstadoPlanilla(pidPlanilla As Integer, pidEstadoOperacion As Int16) As Int16
        Try
            Dim cadena As String = "UPDATE PLANILLAS SET idEstadoOperacion = @idEstadoOperacion WHERE idPlanilla = @idPlanilla"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idPlanilla", pidPlanilla)
            query.Parameters.AddWithValue("idEstadoOperacion", pidEstadoOperacion)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: CambiarEstadoPlanilla" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try
    End Function

    Public Function EliminarPlanillasComprobantes(pidPlanilla As Integer) As Integer

        Dim Respuesta As New ArrayList
        Try
            Dim cadena2 As String = "DELETE FROM Comprobantes WHERE idPlanilla = @idPlanilla"
            Dim query2 As New SqlCommand(cadena2, mCon)
            query2.Parameters.AddWithValue("idPlanilla", pidPlanilla)
            mCon.Open()
            query2.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: EliminarPlanillasComprobantes" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function


End Class
