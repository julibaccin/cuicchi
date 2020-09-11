﻿Public Class frmAltaBancos
    Dim Control As New clsBancos()
    Private Sub limpiarCampos()
        txtNombreBanco.Text = ""
        txtNumeroBanco.Text = ""
        txtNombreBanco.Focus()
    End Sub

    '-----------VALIDACIONES------------
    Private Sub txtNumeroBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroBanco.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub txtBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreBanco.KeyPress
        SoloLetra(e)
    End Sub

    Private Sub BtnCargarBanco_Click_1(sender As Object, e As EventArgs) Handles btnCargarBanco.Click

        If txtNombreBanco.Text = "" Or txtNumeroBanco.Text = "" Then
            MsgBox("Porfavor Complete todos los campos", MsgBoxStyle.Exclamation, "Error")
            limpiarCampos()
        Else

            If Control.CrearBanco(txtNumeroBanco.Text, txtNombreBanco.Text) = 0 Then
                MsgBox("El Banco ya existe", MsgBoxStyle.Exclamation, "Error")
                limpiarCampos()
            Else
                MsgBox("Banco Cargado con exito", vbMsgBoxRight, "Informacion")
                limpiarCampos()
            End If

        End If
    End Sub

    Private Sub BtnModificarBanco_Click(sender As Object, e As EventArgs) Handles btnModificarBanco.Click
        If txtNombreBanco.Text = "" Or txtNumeroBanco.Text = "" Then
            MsgBox("Porfavor Complete todos los campos", MsgBoxStyle.Exclamation, "Error")
            limpiarCampos()
        Else
            If Control.ModificarBanco(txtNumeroBanco.Text, txtNombreBanco.Text) = 1 Then
                MsgBox("Banco Modificado con exito", vbMsgBoxRight, "Informacion")
                limpiarCampos()
            Else
                MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Error")
            End If
        End If
    End Sub

End Class