Public Class frmAltaClientes
    Dim Control As New clsClientes()

    Private Sub FrmAltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreCliente.Focus()
        setearValoresCombo()
    End Sub
    Private Sub BtnCargarCliente_Click(sender As Object, e As EventArgs) Handles btnCargarCliente.Click

        If txtNombreCliente.Text = "" Then
            MsgBox("Ingreso al menos el nombre del cliente", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim NuevoCliente As New ModeloCliente

            With NuevoCliente
                .nombreCliente = txtNombreCliente.Text
                .dni = txtDni.Text
                .telefono = txtTelefono.Text
                .cuit = txtCuit.Text
                .domicilio = txtDomicilio.Text
                .cbu = txtCBU.Text
                .email = txtEmail.Text
            End With

            If Control.CrearCliente(NuevoCliente) = 0 Then
                MsgBox("El Cliente ya existe", MsgBoxStyle.Exclamation, "Error")
                limpiarCampos()
            Else
                MsgBox("Cliente Cargado con exito", vbMsgBoxRight, "Informacion")
                limpiarCampos()
                setearValoresCombo()
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
            End With

            If Control.ModificarCliente(NuevoCliente) = 0 Then
                MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Error")
                limpiarCampos()
            Else
                MsgBox("Cliente Modificado con exito", vbMsgBoxRight, "Informacion")
                limpiarCampos()
                setearValoresCombo()
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
    End Sub
    Private Sub txtBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarCliente.KeyPress
        Control.ConsultarClientes(DClientes, txtBuscarCliente.Text)
    End Sub

    '-----------FUNCIONES------------
    Private Sub limpiarCampos()
        txtNombreCliente.Text = ""
        txtIdCliente.Text = ""
        txtEmail.Text = ""
        txtCBU.Text = ""
        txtCuit.Text = ""
        txtTelefono.Text = ""
        txtDni.Text = ""
        txtDomicilio.Text = ""
    End Sub
    Public Sub setearValoresCombo()

        Dim ControladorClientes As New clsClientes
        ControladorClientes.ConsultarClientes(DClientes, "")

    End Sub

    '-----------VALIDACIONES------------
    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub txtCBU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCBU.KeyPress
        SoloNumero(e)
    End Sub

End Class