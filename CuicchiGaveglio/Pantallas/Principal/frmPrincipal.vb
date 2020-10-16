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
        frmReportes.ShowDialog()
    End Sub

    Private Sub PLANILLASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLANILLASToolStripMenuItem.Click
        frmPlanillas.Show()
    End Sub

    Private Sub COMPROBANTESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles COMPROBANTESToolStripMenuItem1.Click
        frmConsultarComprobantes.Show()
    End Sub

End Class