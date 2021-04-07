Imports System.Windows.Forms
Imports CapaDatos

Public Class frmAltaCompania

    ReadOnly Control As New ClsCompania
    Private Sub FrmAltaCompania_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCuitCompania.Enabled = False
        txtNombreCompania.Enabled = False
        txtIdCompania.Enabled = False
        Control.ConsultarCompanias(DCompanias)
    End Sub

    Private Sub BtnCargarCompania_Click(sender As Object, e As EventArgs) Handles btnCargarCompania.Click
        Dim Respuesta As Int16
        If txtNombreCompania.Text <> "" Then
            Respuesta = Control.CrearCompania(txtNombreCompania.Text, txtCuitCompania.Text)
        End If
        If Respuesta = 1 Then
            MsgBox("Compañia cargada correctamente")
            Control.ConsultarCompanias(DCompanias)
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub DCompanias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DCompanias.CellDoubleClick
        txtIdCompania.Text = DCompanias.Item("idCompania", e.RowIndex).Value
        txtNombreCompania.Text = DCompanias.Item("nombreCompania", e.RowIndex).Value
        txtCuitCompania.Text = DCompanias.Item("cuitCompania", e.RowIndex).Value
    End Sub

    Private Sub BtnModificarCompania_Click(sender As Object, e As EventArgs) Handles btnModificarCompania.Click
        If txtIdCompania.Text = "" Then
            MsgBox("No Seleccionó ninguna compañia")
        End If

        If Control.ModificarCompania(txtIdCompania.Text, txtNombreCompania.Text, txtCuitCompania.Text) = 1 Then
            MsgBox("Compañia modificada con exito")
            Control.ConsultarCompanias(DCompanias)
        Else
            MsgBox("Error")
        End If

    End Sub

    Private Sub CheckNuevaCompania_CheckedChanged(sender As Object, e As EventArgs) Handles checkNuevaCompania.CheckedChanged
        If checkNuevaCompania.Checked = True Then
            txtCuitCompania.Enabled = True
            txtNombreCompania.Enabled = True
            txtIdCompania.Enabled = True
        Else
            txtCuitCompania.Enabled = False
            txtNombreCompania.Enabled = False
            txtIdCompania.Enabled = False
        End If
    End Sub
End Class