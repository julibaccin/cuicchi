Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsClientes

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearCliente(pCliente As ModeloCliente) As Int16

        Try
            Dim query As New SqlCommand("paCrearCliente", mCon)
            With query
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("nombreCliente", pCliente.nombreCliente)
                .Parameters.AddWithValue("dni", pCliente.dni)
                .Parameters.AddWithValue("telefono", pCliente.telefono)
                .Parameters.AddWithValue("cuit", pCliente.cuit)
                .Parameters.AddWithValue("domicilio", pCliente.domicilio)
                .Parameters.AddWithValue("cbu", pCliente.cbu)
                .Parameters.AddWithValue("email", pCliente.email)
            End With
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: CrearCliente" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function ModificarCliente(pCliente As ModeloCliente) As Int16

        Try
            Dim query As New SqlCommand("paModificarCliente", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
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
            MsgBox("Error de sistema: ModificarCliente" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ConsultarClientes(pTabla As DataGridView, pFiltro As String) As Int16

        Try
            Dim query As New SqlCommand("paConsultarClientes", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("nombreCliente", pFiltro)
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarClientes" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ConsultarClientesCombo() As ArrayList
        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("paConsultarClientes", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item("nombreCliente") & " | " & data.Item("idCliente"))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarClientesCombo" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function



End Class
