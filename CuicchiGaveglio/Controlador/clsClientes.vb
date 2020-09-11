Imports System.Data.SqlClient

Public Class clsClientes

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearCliente(pCliente As ModeloCliente) As Integer

        Try
            Dim query As New SqlCommand("paCrearCliente", mCon)
            query.CommandType = CommandType.StoredProcedure
            query.Parameters.AddWithValue("nombreCliente", pCliente.nombreCliente)
            query.Parameters.AddWithValue("dni", pCliente.dni)
            query.Parameters.AddWithValue("telefono", pCliente.telefono)
            query.Parameters.AddWithValue("cuit", pCliente.cuit)
            query.Parameters.AddWithValue("domicilio", pCliente.domicilio)
            query.Parameters.AddWithValue("cbu", pCliente.cbu)
            query.Parameters.AddWithValue("email", pCliente.email)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            data.Read()
            Return data.Item(0)
        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function ModificarCliente(pCliente As ModeloCliente) As Integer

        Try
            Dim query As New SqlCommand("paModificarCliente", mCon)
            query.CommandType = CommandType.StoredProcedure
            query.Parameters.AddWithValue("idCliente", pCliente.idCliente)
            query.Parameters.AddWithValue("nombreCliente", pCliente.nombreCliente)
            query.Parameters.AddWithValue("dni", pCliente.dni)
            query.Parameters.AddWithValue("telefono", pCliente.telefono)
            query.Parameters.AddWithValue("cuit", pCliente.cuit)
            query.Parameters.AddWithValue("domicilio", pCliente.domicilio)
            query.Parameters.AddWithValue("cbu", pCliente.cbu)
            query.Parameters.AddWithValue("email", pCliente.email)
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

    Public Function ConsultarClientes(pTabla As DataGridView, pFiltro As String) As Int16

        Try
            Dim query As New SqlCommand("paConsultarClientes", mCon)
            query.CommandType = CommandType.StoredProcedure
            query.Parameters.AddWithValue("nombreCliente", pFiltro)
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

    Public Function ConsultarClientesCombo() As ArrayList
        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("paConsultarClientes", mCon)
            query.CommandType = CommandType.StoredProcedure
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item("nombreCliente") & " | " & data.Item("idCliente"))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function



End Class
