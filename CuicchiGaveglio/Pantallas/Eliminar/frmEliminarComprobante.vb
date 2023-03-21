Imports System.Windows.Forms
Imports CapaDatos

Public Class FrmEliminarComprobante
    ReadOnly Control As New ClsComprobantes()
    Private Sub TxtIdAlta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdAlta.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub btnEliminarAltaComprobante_Click(sender As Object, e As EventArgs) Handles btnEliminarAltaComprobante.Click
        Dim response = Control.EliminarComprobante(txtIdAlta.Text)
        If (response = 1) Then
            MsgBox("Comprobante eliminado con exito")
        End If
    End Sub
End Class