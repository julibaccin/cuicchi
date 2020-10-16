Imports CapaDatos

Public Class frmLogin


    Private _idRol As Short
    Private _idUsuario As Short

    Property idUsuario As Int16
        Get
            Return _idUsuario
        End Get
        Set
            _idUsuario = Value
        End Set
    End Property

    Property idRol As Short
        Get
            Return _idRol
        End Get
        Set
            _idRol = Value
        End Set
    End Property

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim Control As New ClsLogin()

        If txtUsuario.Text = "" Or txtContrasenia.Text = "" Then
            MsgBox("Ingrese todos los campos", MsgBoxStyle.Exclamation, "Error Login")
            Return
        End If

        Dim Respuesta = Control.Login(txtUsuario.Text, txtContrasenia.Text)
        If Respuesta.Count = 0 Then
            MsgBox("Usuario o Contraseña incorrectos", MsgBoxStyle.Exclamation, "Error Login")
            limpiarCampos()
        Else
            idUsuario = Respuesta(0)
            idRol = Respuesta(1)
            frmPrincipal.lblUsuario.Text = txtUsuario.Text
            limpiarCampos()
            Me.Hide()
            frmPrincipal.Show()
        End If

    End Sub


    Private Sub limpiarCampos()
        txtUsuario.Text = ""
        txtContrasenia.Text = ""
        txtUsuario.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class

