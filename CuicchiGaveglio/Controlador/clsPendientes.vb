Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class clsPendientes
    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function ConsultarPendientes(pfiltro As String, pDataGridView As DataGridView) As Integer

        Try
            Dim cadena As String
            If pfiltro = "COMPROBANTES" Then
                cadena = "SELECT * FROM AltaComprobantes WHERE idEstadoOperacion = 2"
            Else
                cadena = "SELECT * FROM Planillas WHERE idEstadoOperacion = 2"
            End If

            Dim comando As New SqlCommand(cadena, mCon)


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
