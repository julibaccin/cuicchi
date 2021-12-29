Imports System.Windows.Forms
Imports CapaDatos

Public Class frmAltaClientes
    ReadOnly Control As New ClsClientes()

    Private Sub FrmAltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreCliente.Focus()
        SeteoInicial()
    End Sub
    Private Sub BtnCargarCliente_Click(sender As Object, e As EventArgs) Handles btnCargarCliente.Click

        If txtNombreCliente.Text = "" Then
            MsgBox("Ingreso al menos el nombre del cliente", MsgBoxStyle.Exclamation, "Error")
        Else

            If cmbCobrador.Text = "" Then
                MsgBox("Falta ingresar cobrador")
                Return
            End If

            Dim NuevoCliente As New ModeloCliente

            With NuevoCliente
                .nombreCliente = txtNombreCliente.Text
                .dni = txtDni.Text
                .telefono = txtTelefono.Text
                .cuit = txtCuit.Text
                .domicilio = txtDomicilio.Text
                .cbu = txtCBU.Text
                .email = txtEmail.Text
                .idcobrador = ExtraerIdCliente(cmbCobrador.Text)
                .obs = txtObs.Text
            End With

            If Control.CrearCliente(NuevoCliente) = 0 Then
                MsgBox("El Cliente ya existe", MsgBoxStyle.Exclamation, "Error")
                limpiarCampos()
            Else
                MsgBox("Cliente Cargado con exito", vbMsgBoxRight, "Informacion")
                limpiarCampos()
                SeteoInicial()
            End If

        End If

    End Sub
    Private Sub BtnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        If txtNombreCliente.Text = "" Then
            MsgBox("Ingreso al menos el id del cliente", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim NuevoCliente As New ModeloCliente

            With NuevoCliente
                .idCliente = ExtraerNumeros(txtIdCliente.Text)
                .nombreCliente = txtNombreCliente.Text
                .dni = txtDni.Text
                .telefono = txtTelefono.Text
                .cuit = txtCuit.Text
                .domicilio = txtDomicilio.Text
                .cbu = txtCBU.Text
                .email = txtEmail.Text
                .idcobrador = ExtraerIdCliente(cmbCobrador.Text)
                .obs = txtObs.Text
            End With

            If Control.ModificarCliente(NuevoCliente) = 0 Then
                MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Error")
                limpiarCampos()
            Else
                MsgBox("Cliente Modificado con exito", vbMsgBoxRight, "Informacion")
                limpiarCampos()
                SeteoInicial()
            End If

        End If
    End Sub
    Private Sub DClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DClientes.CellDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        txtIdCliente.Text = DClientes.Item(0, e.RowIndex).Value
        txtNombreCliente.Text = DClientes.Item(1, e.RowIndex).Value
        txtTelefono.Text = DClientes.Item(2, e.RowIndex).Value
        txtCuit.Text = DClientes.Item(3, e.RowIndex).Value
        txtDni.Text = DClientes.Item(4, e.RowIndex).Value
        txtEmail.Text = DClientes.Item(5, e.RowIndex).Value
        txtDomicilio.Text = DClientes.Item(6, e.RowIndex).Value
        txtCBU.Text = DClientes.Item(7, e.RowIndex).Value
        cmbCobrador.Text = DClientes.Item(8, e.RowIndex).Value
    End Sub
    Private Sub TxtBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarCliente.KeyPress
        Control.ConsultarClientes(DClientes, txtBuscarCliente.Text)
    End Sub

    '-----------FUNCIONES------------
    Private Sub LimpiarCampos()
        txtNombreCliente.Text = ""
        txtIdCliente.Text = ""
        txtEmail.Text = ""
        txtCBU.Text = ""
        txtCuit.Text = ""
        txtTelefono.Text = ""
        txtDni.Text = ""
        txtDomicilio.Text = ""
        cmbCobrador.Text = ""
    End Sub
    Public Sub SeteoInicial()

        'Dim ControladorCobradores As New com()
        LlenarComboCobradores(cmbCobrador)
        Dim ControladorClientes As New ClsClientes()
        ControladorClientes.ConsultarClientes(DClientes, "")


    End Sub

    '-----------VALIDACIONES------------
    Private Sub TxtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtCBU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCBU.KeyPress
        SoloNumero(e)
    End Sub

End Class