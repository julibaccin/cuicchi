Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsPlanillas
    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    'Lectura
    Public Function DevolverPlanillasCliente(pidCliente As Integer) As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("paDevolverPlanillasCliente", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idCliente", pidCliente)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(0))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function DevolverPolizasDePlanilla(pTabla As DataGridView,
                                              pIdCliente As Integer,
                                              pF As Date) As Integer
        Try
            Dim query As New SqlCommand("paDevolverPolizasDePlanilla", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
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
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function DevolverPagosDePoliza(pIdCliente As Integer,
                                       pF As Date, pPoliza As Integer) As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("paDevolverPagosDePoliza", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idCliente", pIdCliente)
            query.Parameters.AddWithValue("f", pF)
            query.Parameters.AddWithValue("poliza", pPoliza)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add("IdAlta: " & data.Item(0) & "  Importe: " & data.Item(1))
            End While

            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function


    'Insertar

    Public Function CrearPlanilla(pidCliente As Integer, pF As Date, pIdUsuario As Integer) As Int16
        Try
            Dim query As New SqlCommand("paCrearPlanilla", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("f", pF)
            query.Parameters.AddWithValue("idUsuario", pIdUsuario)
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

    Public Function AgregarPolizaAPlanilla(pidCliente As Integer, pF As Date, pPoliza As Integer,
                                              pImporte As Integer, pDetalle As String,
                                              pRef As String, pTitular As String,
                                              pFVencimiento As Date,
                                              pPatente As String) As Int16
        Try
            Dim query As New SqlCommand("paAgregarPolizaAPlanilla", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("f", pF)
            query.Parameters.AddWithValue("Poliza", pPoliza)
            query.Parameters.AddWithValue("Importe", pImporte)
            query.Parameters.AddWithValue("Detalle", pDetalle)
            query.Parameters.AddWithValue("Ref", pRef)
            query.Parameters.AddWithValue("Titular", pTitular)
            query.Parameters.AddWithValue("fVencimiento", pFVencimiento)
            query.Parameters.AddWithValue("Patente", pPatente)
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

    Public Function AgregarPagoAPoliza(pidCliente As Integer, pF As Date, pPoliza As Integer,
                                         pIdAlta As Integer, pImporteAlta As Integer) As Int16
        Try
            Dim query As New SqlCommand("paAgregarPagoAPoliza", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("idCliente", pidCliente)
            query.Parameters.AddWithValue("f", pF)
            query.Parameters.AddWithValue("Poliza", pPoliza)
            query.Parameters.AddWithValue("idAlta", pIdAlta)
            query.Parameters.AddWithValue("importeAlta", pImporteAlta)
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

End Class
