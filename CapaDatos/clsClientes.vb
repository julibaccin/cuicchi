Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsClientes
    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearCliente(pCliente As ModeloCliente) As Int16

        Try
            Dim cadena As String = "INSERT INTO Clientes
            (nombreCliente,dni,telefono,cuit,domicilio,cbu,email,obs,idCobrador) VALUES
			(@nombreCliente,@dni,@telefono,@cuit,@domicilio,@cbu,@email,@obs,@idCobrador);"
            Dim query As New SqlCommand(cadena, mCon)
            With query
                .Parameters.AddWithValue("nombreCliente", pCliente.nombreCliente)
                .Parameters.AddWithValue("dni", pCliente.dni)
                .Parameters.AddWithValue("telefono", pCliente.telefono)
                .Parameters.AddWithValue("cuit", pCliente.cuit)
                .Parameters.AddWithValue("domicilio", pCliente.domicilio)
                .Parameters.AddWithValue("cbu", pCliente.cbu)
                .Parameters.AddWithValue("email", pCliente.email)
                .Parameters.AddWithValue("obs", pCliente.obs)
                .Parameters.AddWithValue("idCobrador", pCliente.idcobrador)
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
        SET nombreCliente= @nombreCliente,dni = @dni, telefono = @telefono, cuit = @cuit, domicilio = @domicilio, cbu = @CBU, email = @email, obs = @obs, idCobrador=@idCobrador WHERE idCliente = @idCliente"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("idCliente", pCliente.idCliente)
            query.Parameters.AddWithValue("nombreCliente", pCliente.nombreCliente)
            query.Parameters.AddWithValue("dni", pCliente.dni)
            query.Parameters.AddWithValue("telefono", pCliente.telefono)
            query.Parameters.AddWithValue("cuit", pCliente.cuit)
            query.Parameters.AddWithValue("domicilio", pCliente.domicilio)
            query.Parameters.AddWithValue("cbu", pCliente.cbu)
            query.Parameters.AddWithValue("email", pCliente.email)
            query.Parameters.AddWithValue("idCobrador", pCliente.idcobrador)
            query.Parameters.AddWithValue("obs", pCliente.obs)
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
            Dim cadena As String = "SELECT idCliente, nombreCliente, telefono, cuit, dni, email, domicilio, cbu, obs, nombreCobrador FROM Clientes INNER JOIN Cobradores C ON Clientes.idCobrador = C.idCobrador WHERE nombreCliente like '%' + @nombreCliente +'%'"

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
