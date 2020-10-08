Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ControladorReportes
    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function MovimientosComprobantes(pDataGridView As DataGridView, pFD As Date, pFH As Date) As Integer

        Try
            Dim cadena As String = "SELECT * FROM AltaComprobantes WHERE (fIngreso >= @fd AND fIngreso <= @fh) ORDER BY fIngreso, idTipoComprobante"
            Dim comando As New SqlCommand(cadena, mCon)
            comando.Parameters.AddWithValue("fd", pFD)
            comando.Parameters.AddWithValue("fh", pFH)

            Dim adaptador As New SqlDataAdapter(comando)
            Dim table As New DataTable
            adaptador.Fill(table)
            pDataGridView.DataSource = table
            Return 1
        Catch ex As Exception
            MsgBox("Error de sistema: REPORTES " & ex.Message)
            Return 0
        Finally
            mCon.Close()
        End Try

    End Function

End Class
