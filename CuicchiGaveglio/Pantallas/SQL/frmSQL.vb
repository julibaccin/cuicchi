Public Class frmSQL
    Private Sub btnEjecutarSQL_Click(sender As Object, e As EventArgs) Handles btnEjecutarSQL.Click
        Dim a = New CapaDatos.clsSQL()
        a.EjecutarSQL(txtQuery.Text, dgwRespuesta)
    End Sub
End Class