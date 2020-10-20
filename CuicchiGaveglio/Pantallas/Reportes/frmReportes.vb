Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class frmReportes

    Public reporteActivo As ReportViewer

    Private Sub BtnReporteMovimientoComprobantes_Click(sender As Object, e As EventArgs) Handles btnReporteMovimientoComprobantes.Click
        panelReportes.Controls.Clear()
        reporteActivo = New ReportViewer()
        panelReportes.Controls.Add(reporteActivo)
        reporteActivo.Dock = Windows.Forms.DockStyle.Fill
        reporteActivo.LocalReport.ReportEmbeddedResource = "CuicchiGaveglio.ReporteComprobantes.rdlc"
        Dim datos As New CapaDatos.ClsReportes()
        Dim dataTable As DataTable = datos.MovimientosComprobantes(DfDesde.Value, DfHasta.Value)
        Dim Pdesde As New ReportParameter("Desde", DfDesde.Value.ToShortDateString())
        Dim Phasta As New ReportParameter("Hasta", DfHasta.Value.ToShortDateString())
        Dim Ptotalgeneral As New ReportParameter("Total_General", 50000)
        reporteActivo.LocalReport.SetParameters(Pdesde)
        reporteActivo.LocalReport.SetParameters(Phasta)
        reporteActivo.LocalReport.SetParameters(Ptotalgeneral)
        reporteActivo.LocalReport.DataSources.Add(New ReportDataSource("DSComprobantes", dataTable))
        reporteActivo.RefreshReport()
        reporteActivo.Show()
    End Sub


    Private Sub btnRecibos(sender As Object, e As EventArgs) Handles Button1.Click
        panelReportes.Controls.Clear()
        reporteActivo = New ReportViewer()
        panelReportes.Controls.Add(reporteActivo)
        reporteActivo.Dock = Windows.Forms.DockStyle.Fill
        reporteActivo.LocalReport.ReportEmbeddedResource = "CuicchiGaveglio.ReporteRecibos.rdlc"
        Dim datos As New CapaDatos.ClsReportes()
        Dim dataTable As DataTable = datos.MovimientosRecibos(DfDesde.Value, DfHasta.Value)
        Dim Pdesde As New ReportParameter("Desde", DfDesde.Value.ToShortDateString())
        Dim Phasta As New ReportParameter("Hasta", DfHasta.Value.ToShortDateString())
        Dim Ptotalgeneral As New ReportParameter("Total_General", 50000)
        reporteActivo.LocalReport.SetParameters(Pdesde)
        reporteActivo.LocalReport.SetParameters(Phasta)
        reporteActivo.LocalReport.SetParameters(Ptotalgeneral)
        reporteActivo.LocalReport.DataSources.Add(New ReportDataSource("DSRecibos", dataTable))
        reporteActivo.RefreshReport()
        reporteActivo.Show()
    End Sub

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class