Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsClientes
    Inherits Conn

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearCliente(pCliente As ModeloCliente) As Int16

        Try
            Dim cadena As String = "INSERT INTO Clientes(nombreCliente,dni,telefono,cuit,domicilio,cbu,email) VALUES
			(@nombreCliente,@dni,@telefono,@cuit,@domicilio,@cbu,@email);"
            Dim query As New SqlCommand(cadena, mCon)
            With query
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
            Dim cadena As String = "UPDATE Clientes 
        SET nombreCliente= @nombreCliente,dni = @dni, telefono = @telefono, cuit = @cuit, domicilio = @domicilio, cbu = @CBU, email = @email WHERE idCliente = @idCliente"
            Dim query As New SqlCommand(cadena, mCon)
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
            Dim cadena As String = "SELECT * FROM Clientes WHERE nombreCliente like '%' + @nombreCliente +'%'"
            Dim query As New SqlCommand(cadena, mCon)
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
            Dim cadena As String = "SELECT nombreCliente, idCliente FROM Clientes"
            Dim query As New SqlCommand(cadena, mCon)
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
