Public Class frmReportes
    Dim Control As New ControladorReportes()
    Private Sub BtnReporteMovimientoComprobantes_Click(sender As Object, e As EventArgs) Handles btnReporteMovimientoComprobantes.Click
        Control.MovimientosComprobantes(DData, DTPDesde.Value, DTPHasta.Value)
    End Sub

    Private Sub BtnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        If ExportarExcel(DData, "", New Date()) = 1 Then
            MsgBox("Exportación realizada con éxito")
        End If
    End Sub
End Class