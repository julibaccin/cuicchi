Imports CapaDatos

Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
    End Sub

    Public Sub LlenarDatos()
        lblFecha.Text = DateTime.Today()
        Dim Control As New ClsSaldos()
        Control.ConsultarPlanillasPendientes(DPendientes)
        Control.ConsultarPlanillasRechazadas(DRechazados)
        Control.ConsultarChequesProximosAVencer(DChequesProximosAVencer)
        If frmLogin.IdRol = 2 Then
            DChequesProximosAVencer.Visible = False
            lblAdvertencias.Visible = False
        Else
            DChequesProximosAVencer.Visible = True
            lblAdvertencias.Visible = True
        End If
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


    Private Sub FrmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLogin.Show()
    End Sub

    Private Sub AltaCompanias(sender As Object, e As EventArgs) Handles CompañiasToolStripMenuItem.Click
        frmAltaCompania.ShowDialog()
    End Sub

    Private Sub EliminarAltas(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        FrmEliminarComprobante.ShowDialog()
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

        FrmPlanillas.FrmConsultarComprobantes_Load(sender, e)
        FrmPlanillas.Show()
        FrmPlanillas.cmbClienteP.Text = DPendientes.Item("Cliente", e.RowIndex).Value & "|" & DPendientes.Item("idCliente", e.RowIndex).Value
        FrmPlanillas.cmbFechaP.Text = DPendientes.Item("Fecha_Planilla", e.RowIndex).Value
        FrmPlanillas.txtIdPlanilla.Text = DPendientes.Item("idPlanilla", e.RowIndex).Value
        FrmPlanillas.cmbFechaPChanged(sender, e)

    End Sub

    Private Sub SQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLToolStripMenuItem.Click
        frmSQL.Show()
    End Sub

    Private Sub DRechazados_CellContentDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DRechazados.CellContentDoubleClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
            Return
        End If

        FrmPlanillas.FrmConsultarComprobantes_Load(sender, e)
        FrmPlanillas.Show()
        FrmPlanillas.cmbClienteP.Text = DRechazados.Item("Cliente", e.RowIndex).Value & "|" & DRechazados.Item("idCliente", e.RowIndex).Value
        FrmPlanillas.cmbFechaP.Text = DRechazados.Item("Fecha_Planilla", e.RowIndex).Value
        FrmPlanillas.txtIdPlanilla.Text = DRechazados.Item("idPlanilla", e.RowIndex).Value
        FrmPlanillas.CmbFechaPChanged(sender, e)
    End Sub

    Private Sub CobradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobradoresToolStripMenuItem.Click
        frmAltaCobradores.ShowDialog()
    End Sub

    Private Sub MODIFICACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICACIONToolStripMenuItem.Click

    End Sub
End Class