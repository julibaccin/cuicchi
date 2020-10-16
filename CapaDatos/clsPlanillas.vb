Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsPlanillas
    Inherits Conn

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    'Lectura
    Public Function DevolverPlanillasCliente(pidCliente As Integer) As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim cadena As String = "SELECT f FROM Planillas WHERE idCliente = @idCliente"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idCliente", pidCliente)
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

    Public Function DevolverRecibosDePlanilla(pTabla As DataGridView,
                                              pIdCliente As Integer,
                                              pF As Date) As Integer
        Try
            Dim cadena As String = "select Tomador,Ref,idCompania,Detalle,Patente,FVencimiento,importe From PlanillasComprobantes
                                    WHERE idCliente = @idCliente and f=@f"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idCliente", pIdCliente)
            query.Parameters.AddWithValue("f", pF)
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: DevolverPolizasDePlanilla" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function CrearPlanilla(pidCliente As Integer, pF As Date, pIdUsuario As Integer, pEstadoOperacion As Int16) As Int16
        Try
            Dim cadena As String = "INSERT INTO Planillas (idCliente,f,idUsuario,idEstadoOperacion)
                                    VALUES (@idCliente,@f,@idusuario,@idEstadoOperacion)"
            Dim query As New SqlCommand(cadena, mCon)

            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("f", pF)
            query.Parameters.AddWithValue("idusuario", pIdUsuario)
            query.Parameters.AddWithValue("idEstadoOperacion", pEstadoOperacion)
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

    'Devolver Dinero disponible por comprobante

    Public Function DisponibleXComprobante(pIdAlta As Integer) As ArrayList
        Dim resp As New ArrayList()
        Try
            Dim query As New SqlCommand("paDisponibleXComprobante", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idAlta", pIdAlta)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            Dim res As Boolean = data.Read()
            If res = False Then
                Return resp
            End If
            resp.Add(data.Item("USADO"))
            resp.Add(data.Item("TOTAL"))

            Return resp
        Catch ex As Exception
            MsgBox("Error de sistema: DisponibleXComprobante" & ex.Message)
            Return resp
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function DatosGeneralesPlanilla(pidCliente As Integer, pF As Date) As String

        Dim Respuesta As New ArrayList
        Try
            Dim cadena As String = "SELECT nombreEstadoOperacion FROM Planillas P
                                    INNER JOIN EstadosOperacion EO ON P.idEstadoOperacion = EO.idEstadoOperacion 
                                    WHERE idCliente = @idCliente AND f=@f"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("f", pF)
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

    Public Function CambiarEstadoPlanilla(pidCliente As Integer, pf As Date, pidEstadoOperacion As Int16) As Int16
        Try
            Dim cadena As String = "UPDATE PLANILLAS SET idEstadoOperacion = @idEstadoOperacion WHERE idCliente = @idCliente AND f = @f"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("f", pf)
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

    Public Function AgregarReciboAPlanilla(pidCliente As Integer, pF As Date, pidAlta As Integer,
                                           pTomador As String, pRef As String, pIdCompania As Int64,
                                           pDetalle As String, pPatente As String, pFVencimiento As Date, pImporte As Integer) As Integer
        Try
            Dim cadena As String = "INSERT INTO PlanillasComprobantes (idCliente,f,idAlta,Tomador,Ref,idCompania,Detalle,Patente,FVencimiento,Importe) 
                                    VALUES (@idCliente,@f,@idAlta,@tomador,@ref,@idCompania,@detalle,@patente,@fVencimiento,@importe)"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("f", pF)
            query.Parameters.AddWithValue("idAlta", pidAlta)
            query.Parameters.AddWithValue("tomador", pTomador)
            query.Parameters.AddWithValue("ref", pRef)
            query.Parameters.AddWithValue("idCompania", pIdCompania)
            query.Parameters.AddWithValue("detalle", pDetalle)
            query.Parameters.AddWithValue("patente", pPatente)
            query.Parameters.AddWithValue("fVencimiento", pFVencimiento)
            query.Parameters.AddWithValue("importe", pImporte)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: AgregarReciboAPlanilla" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try
    End Function

    Public Function EliminarPlanillasComprobantes(pidCliente As Integer, pF As Date) As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim cadena1 As String = "SELECT idAlta FROM PlanillasComprobantes WHERE idCliente=@idCliente and f=@f"
            Dim query1 As New SqlCommand(cadena1, mCon)
            query1.Parameters.AddWithValue("idCliente", pidCliente)
            query1.Parameters.AddWithValue("f", pF)

            Dim cadena2 As String = "DELETE FROM PlanillasComprobantes WHERE idCliente = @idCliente and f=@f"
            Dim query2 As New SqlCommand(cadena2, mCon)
            query2.Parameters.AddWithValue("idCliente", pidCliente)
            query2.Parameters.AddWithValue("f", pF)

            mCon.Open()
            Dim data As SqlDataReader = query1.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(0))
            End While
            data.Close()
            query2.ExecuteNonQuery()
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: EliminarPlanillasComprobantes" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function


End Class
