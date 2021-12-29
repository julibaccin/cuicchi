Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class frmReportes

    Public reporteActivo As ReportViewer

    Private Sub BtnReporteMovimientoComprobantes_Click(sender As Object, e As EventArgs) Handles btnReporteMovimientoComprobantes.Click

        Dim fDesde = DfDesde.Value
        Dim fDesdeEnviar = fDesde.Year.ToString() +
                           IIf(fDesde.Month < 10, "0" + fDesde.Month.ToString(), fDesde.Month).ToString() +
                           IIf(fDesde.Day < 10, "0" + fDesde.Day.ToString(), fDesde.Day).ToString()

        Dim fHasta = DfHasta.Value
        Dim fHastaEnviar = fHasta.Year.ToString() +
                           IIf(fHasta.Month < 10, "0" + fHasta.Month.ToString(), fHasta.Month).ToString() +
                           IIf(fHasta.Day < 10, "0" + fHasta.Day.ToString(), fHasta.Day).ToString()

        panelReportes.Controls.Clear()
        reporteActivo = New ReportViewer()
        panelReportes.Controls.Add(reporteActivo)
        reporteActivo.Dock = Windows.Forms.DockStyle.Fill
        reporteActivo.LocalReport.ReportEmbeddedResource = "CuicchiGaveglio.ReporteComprobantes.rdlc"
        Dim datos As New CapaDatos.ClsReportes()
        Dim dataTableEfectivo As DataTable = datos.TotalPorTipoComprobanteEfectivo(Convert.ToInt32(fDesdeEnviar), Convert.ToInt32(fHastaEnviar))
        Dim dataTableOtros As DataTable = datos.TotalPorTipoComprobanteOtros(Convert.ToInt32(fDesdeEnviar), Convert.ToInt32(fHastaEnviar))
        Dim Pdesde As New ReportParameter("Desde", DfDesde.Value.ToShortDateString())
        Dim Phasta As New ReportParameter("Hasta", DfHasta.Value.ToShortDateString())
        reporteActivo.LocalReport.SetParameters(Pdesde)
        reporteActivo.LocalReport.SetParameters(Phasta)
        reporteActivo.LocalReport.DataSources.Add(New ReportDataSource("DSEfectivo", dataTableEfectivo))
        reporteActivo.LocalReport.DataSources.Add(New ReportDataSource("DSOtros", dataTableOtros))
        reporteActivo.RefreshReport()
        reporteActivo.Show()
    End Sub


    Private Sub BtnRecibos(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fDesde = DfDesde.Value
        Dim fDesdeEnviar = fDesde.Year.ToString() +
                           IIf(fDesde.Month < 10, "0" + fDesde.Month.ToString(), fDesde.Month).ToString() +
                           IIf(fDesde.Day < 10, "0" + fDesde.Day.ToString(), fDesde.Day).ToString()

        Dim fHasta = DfHasta.Value
        Dim fHastaEnviar = fHasta.Year.ToString() +
                           IIf(fHasta.Month < 10, "0" + fHasta.Month.ToString(), fHasta.Month).ToString() +
                           IIf(fHasta.Day < 10, "0" + fHasta.Day.ToString(), fHasta.Day).ToString()

        panelReportes.Controls.Clear()
        reporteActivo = New ReportViewer()
        panelReportes.Controls.Add(reporteActivo)
        reporteActivo.Dock = Windows.Forms.DockStyle.Fill
        reporteActivo.LocalReport.ReportEmbeddedResource = "CuicchiGaveglio.ReporteRecibos.rdlc"
        Dim datos As New CapaDatos.ClsReportes()
        Dim dataTable As DataTable = datos.RecibosPorCompania(Convert.ToInt32(fDesdeEnviar), Convert.ToInt32(fHastaEnviar))
        Dim Pdesde As New ReportParameter("Desde", DfDesde.Value.ToShortDateString())
        Dim Phasta As New ReportParameter("Hasta", DfHasta.Value.ToShortDateString())
        reporteActivo.LocalReport.SetParameters(Pdesde)
        reporteActivo.LocalReport.SetParameters(Phasta)
        reporteActivo.LocalReport.DataSources.Add(New ReportDataSource("DS", dataTable))
        reporteActivo.RefreshReport()
        reporteActivo.Show()
    End Sub

End Class