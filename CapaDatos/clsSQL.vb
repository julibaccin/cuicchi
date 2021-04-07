Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class clsSQL

    Inherits Conn
    ReadOnly mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub


    Public Sub EjecutarSQL(pQuery As String, pTabla As DataGridView)
        Try
            Dim cadena As String = pQuery
            Dim query As New SqlCommand(cadena, mCon)
            Dim adaptador As New SqlDataAdapter()
            Dim tabla As New DataTable()

            mCon.Open()
            If cadena.IndexOf("SELECT") = -1 Then

                adaptador.SelectCommand = query
                adaptador.Fill(tabla)
                pTabla.DataSource = tabla
            Else
                query.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("Error de sistema: ConsultarSaldosPorComprobante" & ex.Message)
        Finally
            mCon.Close()
        End Try
    End Sub

End Class