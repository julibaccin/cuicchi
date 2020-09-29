Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClsCompania

    Dim mCon As SqlConnection
    Public Sub New()
        mCon = ObtenerConexion()
    End Sub

    Public Function CrearCompania(pNombreCompania, pCuitCompania) As Integer

        Try
            Dim query As New SqlCommand("paCrearCompania", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("nombreCompania", pNombreCompania)
            query.Parameters.AddWithValue("cuitCompania", pCuitCompania)
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

    Public Function ModificarCompania(pIdCompania, pNombreCompania, pCuitCompania) As Integer

        Try
            Dim query As New SqlCommand("paModificarCompania", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            query.Parameters.AddWithValue("nombreCompania", pNombreCompania)
            query.Parameters.AddWithValue("cuitCompania", pCuitCompania)
            query.Parameters.AddWithValue("idCompania", pIdCompania)
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

    Public Function ConsultarCompanias() As ArrayList

        Dim Respuesta As New ArrayList
        Try
            Dim query As New SqlCommand("paConsultarCompanias", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
            mCon.Open()
            Dim data As SqlDataReader = query.ExecuteReader()
            While data.Read()
                Respuesta.Add(data.Item(1) & " | " & data.Item(0))
            End While
            Return Respuesta

        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message)
            Return Respuesta
        Finally
            mCon.Close()
        End Try

    End Function


    Public Function ConsultarCompanias(pTabla As DataGridView) As Int16

        Try
            Dim query As New SqlCommand("paConsultarCompanias", mCon) With {
                .CommandType = CommandType.StoredProcedure
            }
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

End Class
