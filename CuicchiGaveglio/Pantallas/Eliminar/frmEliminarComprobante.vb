Imports System.Windows.Forms
Imports CapaDatos

Public Class FrmEliminarComprobante

    Private Sub TxtIdAlta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdAlta.KeyPress
        SoloNumero(e)
    End Sub
End Class