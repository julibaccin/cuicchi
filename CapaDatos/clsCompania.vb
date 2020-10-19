Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsCompania
    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearCompania(pNombreCompania, pCuitCompania) As Int16

        Try
            Dim cadena As String = "INSERT INTO Companias (nombreCompania,cuitCompania) VALUES (@nombreCompania,@cuitCompania)"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("nombreCompania", pNombreCompania)
            query.Parameters.AddWithValue("cuitCompania", pCuitCompania)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: CrearCompania" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ModificarCompania(pIdCompania, pNombreCompania, pCuitCompania) As Int16

        Try
            Dim cadena As String = "UPDATE Companias SET nombreCompania = @nombreCompania, cuitCompania = @cuitCompania WHERE idCompania = @idCompania"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("nombreCompania", pNombreCompania)
            query.Parameters.AddWithValue("cuitCompania", pCuitCompania)
            query.Parameters.AddWithValue("idCompania", pIdCompania)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: ModificarCompania" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ConsultarCompanias() As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("SELECT * FROM Companias", mCon)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(1) & " | " & data.Item(0))
            End While
            Return Respuesta

        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarCompanias" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function


    Public Function ConsultarCompanias(pTabla As DataGridView) As Int16

        Try
            Dim query As New SqlCommand("SELECT * FROM Companias", mCon)
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarCompanias" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

End Class
