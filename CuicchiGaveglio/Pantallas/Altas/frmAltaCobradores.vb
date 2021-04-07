Imports System.Windows.Forms
Imports CapaDatos
Public Class frmAltaCobradores

    ReadOnly Control As New clsCobradores()

    Private Sub BtnCargarCliente_Click(sender As Object, e As EventArgs) Handles btnCargarCobrador.Click

        If txtNombreCobrador.Text = "" Then
            MsgBox("Ingreso nombre cobrador", MsgBoxStyle.Exclamation, "Error")
        Else

            Control.CrearCobrador(txtNombreCobrador.Text)
            MsgBox("Cobrador Cargado con exito", vbMsgBoxRight, "Informacion")
            txtNombreCobrador.Text = ""
            frmAltaCobradores_Load(sender, e)
        End If

    End Sub

    Private Sub frmAltaCobradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.ConsultarCobradores(DCobradores, "")
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        Control.ConsultarCobradores(DCobradores, txtFiltro.Text)
    End Sub
End Class

