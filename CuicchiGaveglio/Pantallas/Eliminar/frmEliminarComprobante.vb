Public Class frmEliminarComprobante

    Dim Control As New clsComprobantes()
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles btnEliminarAltaComprobante.Click
        If txtIdAlta.Text = "" Then
            MsgBox("Ingrese el idAlta que desea eliminar")
        Else
            Control.EliminarMovimiento(txtIdAlta.Text)
            MsgBox("Movimiento Eliminado")
            txtIdAlta.Text = ""
            txtIdAlta.Focus()
        End If
    End Sub

    Private Sub txtIdAlta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdAlta.KeyPress
        SoloNumero(e)
    End Sub
End Class