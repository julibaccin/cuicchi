Public Class frmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
    End Sub

    Public Sub LlenarDatos()
        lblFecha.Text = DateTime.Today()
        Dim Control As New clsSaldos()
        Control.ConsultarSaldosPorComprobante(DSaldosPorComprobante, "2020-01-01")
        Control.ConsultarChequesProximosAVencer(DChequesProximosAVencer)
    End Sub
    Private Sub BtnAbrirAyuda_Click(sender As Object, e As EventArgs) Handles btnAbrirAyuda.Click
        MsgBox("Para cualquier Consulta/Error comunicarse al 3462-30216 (WhatsApp) - Julian Baccin", MsgBoxStyle.Information, "Ayuda")
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnAltaClientes_Click(sender As Object, e As EventArgs) Handles btnAltaClientes.Click
        frmAltaClientes.ShowDialog()
    End Sub

    Private Sub BtnAltaBancos_Click(sender As Object, e As EventArgs) Handles btnAltaBancos.Click
        frmAltaBancos.ShowDialog()
    End Sub


    Private Sub frmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLogin.Show()
    End Sub

    Private Sub CompañiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompañiasToolStripMenuItem.Click
        frmAltaCompania.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        If lblUsuario.Text = "eliminar" Then
            frmEliminarComprobante.ShowDialog()
        Else
            MsgBox("No tiene permiso para acceder a esta pantalla, ingrese con el usuario: eliminar")
        End If
    End Sub

    Private Sub ComprobantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobantesToolStripMenuItem.Click
        frmConsultarComprobantes.ShowDialog()
    End Sub

    Private Sub PlanillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillasToolStripMenuItem.Click
        frmConsultarPlanillas.ShowDialog()
    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTESToolStripMenuItem.Click
        frmReportes.ShowDialog()
    End Sub
End Class