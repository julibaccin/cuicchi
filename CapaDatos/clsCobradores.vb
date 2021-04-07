Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class clsCobradores

    Inherits Conn

    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearCobrador(pNombreCobrador As String) As Integer
        Try
            Dim cadena As String = "INSERT INTO Cobradores (nombreCobrador) VALUES (@nombreCobrador);"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("nombreCobrador", pNombreCobrador)
            mCon.Open()
            query.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: CrearCobrador" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

    Public Function ConsultarCobradores(pTabla As DataGridView, pFiltro As String) As Int16

        Try
            Dim cadena As String = "SELECT * FROM Cobradores WHERE nombreCobrador like '%' + @nombreCobrador +'%'"
            Dim query As New SqlCommand(cadena, mCon)
            query.Parameters.AddWithValue("nombreCobrador", pFiltro)
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()
            mCon.Open()
            adaptador.SelectCommand = query
            adaptador.Fill(tabla)
            pTabla.DataSource = tabla
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarCobradores" & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function
    Public Function ConsultarCobradoresCombo() As ArrayList

        Dim Respuesta As New ArrayList
        Try

            Dim query As New SqlCommand("SELECT * FROM Cobradores", mCon)
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(1) & " | " & data.Item(0))
            End While
            Return Respuesta
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarCobradoresCombo" & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function

End Class

