Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class frmReportes

    Private Sub BtnReporteMovimientoComprobantes_Click(sender As Object, e As EventArgs) Handles btnReporteMovimientoComprobantes.Click
        Me.RVComprobantes.LocalReport.DataSources.Clear()
        Dim datos As New CapaDatos.clsReportes()
        Dim dataTable As DataTable = datos.MovimientosComprobantes(DfDesde.Value, DfHasta.Value)
        Me.RVComprobantes.LocalReport.DataSources.Add(New ReportDataSource("DSComprobantes", dataTable))

        RVComprobantes.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.RVRecibos.LocalReport.DataSources.Clear()
        Dim datos As New CapaDatos.clsReportes()
        Dim dataTable As DataTable = datos.MovimientosRecibos(DfDesde.Value, DfHasta.Value)
        Dim Pdesde As New ReportParameter("Desde", DfDesde.Value.ToShortDateString())
        Dim Phasta As New ReportParameter("Hasta", DfHasta.Value.ToShortDateString())
        RVRecibos.LocalReport.SetParameters(Pdesde)
        RVRecibos.LocalReport.SetParameters(Phasta)
        Me.RVRecibos.LocalReport.DataSources.Add(New ReportDataSource("DSRecibos", dataTable))

        RVRecibos.RefreshReport()
    End Sub
End Class