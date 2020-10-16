Imports System.Windows.Forms
Imports CapaDatos

Public Class frmEliminarComprobante

    Dim Control As New ClsComprobantes()

    Private Sub txtIdAlta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdAlta.KeyPress
        SoloNumero(e)
    End Sub
End Class