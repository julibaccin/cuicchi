Imports CapaDatos

Public Class frmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
    End Sub

    Public Sub LlenarDatos()
        lblFecha.Text = DateTime.Today()
        Dim Control As New ClsSaldos()
        Control.ConsultarPlanillasPendientes(DPendientes)
        Control.ConsultarPlanillasRechazadas(DRechazados)
        Control.ConsultarChequesProximosAVencer(DChequesProximosAVencer)
    End Sub
    Private Sub Ayuda(sender As Object, e As EventArgs) Handles btnAbrirAyuda.Click
        MsgBox("Para cualquier Consulta/Error comunicarse al 3462-30216 (WhatsApp) - Julian Baccin", MsgBoxStyle.Information, "Ayuda")
    End Sub

    Private Sub CerrarSesion(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub AltaClientes(sender As Object, e As EventArgs) Handles btnAltaClientes.Click
        frmAltaClientes.ShowDialog()
    End Sub

    Private Sub AltaBancos(sender As Object, e As EventArgs) Handles btnAltaBancos.Click
        frmAltaBancos.ShowDialog()
    End Sub


    Private Sub frmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLogin.Show()
    End Sub

    Private Sub AltaCompanias(sender As Object, e As EventArgs) Handles CompañiasToolStripMenuItem.Click
        frmAltaCompania.ShowDialog()
    End Sub

    Private Sub EliminarAltas(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        If lblUsuario.Text = "eliminar" Then
            frmEliminarComprobante.ShowDialog()
        Else
            MsgBox("No tiene permiso para acceder a esta pantalla, ingrese con el usuario: eliminar")
        End If
    End Sub


    Private Sub Reportes(sender As Object, e As EventArgs) Handles REPORTESToolStripMenuItem.Click
        If frmLogin.idRol = 2 Then
            Return
        End If
        frmReportes.ShowDialog()
    End Sub

    Private Sub PLANILLASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLANILLASToolStripMenuItem.Click
        frmPlanillas.Show()
    End Sub

    Private Sub COMPROBANTESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles COMPROBANTESToolStripMenuItem1.Click
        If frmLogin.idRol = 2 Then
            Return
        End If
        frmConsultarComprobantes.Show()
    End Sub

    Private Sub DPendientes_CellContentDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DPendientes.CellContentDoubleClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
            Return
        End If

        frmPlanillas.FrmConsultarComprobantes_Load(sender, e)
        frmPlanillas.cmbClienteP.Text = DPendientes.Item("Cliente", e.RowIndex).Value & "|" & DPendientes.Item("idCliente", e.RowIndex).Value
        frmPlanillas.cmbFechaP.Text = DPendientes.Item("Fecha_Planilla", e.RowIndex).Value
        frmPlanillas.cmbFechaPChanged(sender, e)
        frmPlanillas.Show()
    End Sub
End Class