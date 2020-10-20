Imports System.Data
Imports System.Windows.Forms
Imports CapaDatos
Imports Microsoft.Reporting.WinForms

Public Class frmPlanillas

    Dim ComprobantesController As New ClsComprobantes
    Dim PlanillasController As New ClsPlanillas
    Dim SaldosController As New ClsSaldos

    Private Sub FrmConsultarComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setearValoresCombo()
    End Sub

    Public Sub setearValoresCombo()
        rbAceptar.Visible = False
        rbRechazar.Visible = False
        btnCambioEstadoPlanilla.Visible = False
        If frmLogin.idRol = 1 Then
            rbAceptar.Visible = True
            rbRechazar.Visible = True
            btnCambioEstadoPlanilla.Visible = True
        Else
            rbAceptar.Visible = False
            rbRechazar.Visible = False
            btnCambioEstadoPlanilla.Visible = False
        End If
        DFechaIngreso.Value = Date.Now()
        DFechaPago.Value = Date.Now()
        DFechaPlanillaNueva.Value = Date.Now()
        LlenarComboClientes(cmbClienteP)
        LlenarComboTipoComprobantes(cmbTipoComprobante)
        LlenarComboCompanias(cmbCompania)
        LlenarComboBancos(cmbBanco)
    End Sub

    Private Sub cmbClientePChanged(sender As Object, e As EventArgs) Handles cmbClienteP.SelectedIndexChanged
        Dim cliente As Integer = ExtraerNumeros(cmbClienteP.Text)

        txtSaldoCliente.Text = SaldosController.ConsultarSaldosPorCliente(cliente)

        cmbFechaP.Items.Clear()
        cmbFechaP.Items.Add("Nueva Planilla")
        Dim respuesta As ArrayList = PlanillasController.DevolverPlanillasCliente(cliente)
        For Each element As Date In respuesta
            cmbFechaP.Items.Add(element.ToShortDateString)
        Next

    End Sub

    Private Sub DataPlanillasPolizas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgPlanillaPolizas.CellMouseClick
        EliminarFilaDataGridClickDerecho(e, DgPlanillaPolizas)
    End Sub

    Private Sub CargarNuevaPlanilla(sender As Object, e As EventArgs) Handles btnCargarPlanillaNueva.Click
        If cmbClienteP.Text = "" Then
            MsgBox("Debe ingresar un cliente valido")
            Return
        End If

        Dim resul As MsgBoxResult = MsgBox("Está por cargar una planilla del cliente: " & ExtraerLetras(cmbClienteP.Text) & " a la fecha de: " & DFechaPlanillaNueva.Value, MsgBoxStyle.OkCancel)
        If resul <> 1 Then
            Return
        End If

        If PlanillasController.CrearPlanilla(ExtraerNumeros(cmbClienteP.Text) _
                                            , DFechaPlanillaNueva.Value, frmLogin.idUsuario, 2) = 0 Then
            MsgBox("Ya existe una planilla para ese cliente, en esa fecha")
            Return
        End If
        cmbFechaPChanged(sender, e)
        cmbClientePChanged(sender, e)
        MsgBox("La planilla se guardó correctamente")
    End Sub

    Private Sub cmbFechaPChanged(sender As Object, e As EventArgs) Handles cmbFechaP.SelectedIndexChanged
        If cmbFechaP.Text = "Nueva Planilla" Then
            DFechaPlanillaNueva.Visible = True
            DgPlanillaPolizas.Visible = False
            txtEstado.Text = ""
            txtTotal.Text = ""
            btnModificar.Visible = False
            Return
        End If
        DgPlanillaPolizas.Visible = True
        DFechaPlanillaNueva.Visible = False


        If cCopiarDatos.Checked = True Then
            Return
        End If

        PlanillasController.DevolverRecibosDePlanilla(DgPlanillaPolizas,
                                          ExtraerNumeros(cmbClienteP.Text),
                                          cmbFechaP.Text)

        txtEstado.Text = PlanillasController.DatosGeneralesPlanilla(ExtraerNumeros(cmbClienteP.Text), cmbFechaP.Text)

        Dim total As Integer = 0
        For Each row As DataGridViewRow In DgPlanillaPolizas.Rows

            If row.IsNewRow = True Then
                Exit For
            End If

            total = total + row.Cells.Item("importe").Value

        Next
        txtTotal.Text = total

        'Mostrar si la planilla está rechazada el boton modificar
        If txtEstado.Text = "RECHAZADO" Then
            btnModificar.Visible = True
        Else
            btnModificar.Visible = False
        End If

    End Sub

    Private Sub PreCargarComprobantesAPlanilla(sender As Object, e As EventArgs) Handles btnPreCargar.Click

        If cmbTipoComprobante.Text = "" Or cmbClienteP.Text = "" Or txtImporte.Text = "" Then
            MsgBox("Ingrese los campos obligatorios (estan marcados con asterisco)")
            Return
        End If

        DPreviaACargar.Rows.Add(cmbTipoComprobante.Text, DFechaIngreso.Value,
                                cmbClienteP.Text, cmbCompania.Text, txtImporte.Text,
                                txtNumero.Text, DFechaPago.Value,
                                cmbBanco.Text, txtObservaciones.Text)
        LimpiarCampos()
    End Sub

    Public Sub LimpiarCampos()
        txtImporte.Text = ""
        txtNumero.Text = ""
        txtObservaciones.Text = ""
        cmbBanco.Text = ""
        cmbTipoComprobante.Text = ""
        cmbCompania.Text = ""
        cmbTipoComprobante.Focus()
        cmbBanco.Enabled = True
        cmbCompania.Enabled = True
        txtNumero.Enabled = True
        DFechaPago.Enabled = True
    End Sub

    Private Sub CargarComprobantesAPlanilla(sender As Object, e As EventArgs) Handles btnCargar.Click

        'Verificar que la planilla exista | y esté aceptada
        If txtEstado.Text = "PENDIENTE" And txtEstado.Text = "" Then
            MsgBox("No se puede ingresar un comprobante a una planilla que todavía no está aceptada")
            Return
        ElseIf txtEstado.Text = "RECHAZADO" Then
            MsgBox("No se puede ingresar un comprobante a una planilla que ha sido rechazada")
            Return
        ElseIf txtEstado.Text = "" Then
            MsgBox("Seleccione una planilla")
            Return
        End If

        If DPreviaACargar.Rows.Count = 0 Then
            MsgBox("No hay nada Pre-Cargado")
            Return
        End If

        'Inserto los comprobantes
        For Each Fila As DataGridViewRow In DPreviaACargar.Rows

            Dim objAlta As New ModeloComprobante
            With objAlta
                .IdTipoComprobante = ExtraerNumeros(Fila.Cells("tipoComprobante").Value)
                .FIngreso = Fila.Cells("fIngreso").Value
                .IdCliente = ExtraerNumeros(Fila.Cells("Cliente").Value)
                .IdCompania = ExtraerNumeros(Fila.Cells("Compania").Value)
                .Importe = Fila.Cells("importe").Value
                .Numero = Fila.Cells("numero").Value
                .FPago = Fila.Cells("fpago").Value
                .IdBanco = ExtraerNumeros(Fila.Cells("Banco").Value)
                .Obs = Fila.Cells("obs").Value
                .IdUsuario = frmLogin.idUsuario
                .IdEstado = 1
                .IdEstadoOperacion = 2
            End With
            Dim idAlta As Integer = ComprobantesController.CrearMovimiento(objAlta)

            If idAlta = 0 Then
                MsgBox("Error")
                Return
            End If



        Next

        DPreviaACargar.Rows.Clear()
        MsgBox("Carga Correcta")

        LimpiarCampos()
    End Sub

    Private Sub CargarRecibosAPlanilla(sender As Object, e As EventArgs) Handles btnCargarPolizas.Click

        Dim idCliente = ExtraerNumeros(cmbClienteP.Text)

        'Agrega todos los recibos y los relaciono
        For Each row As DataGridViewRow In DgPlanillaPolizas.Rows
            If row.IsNewRow = True Then
                Exit For
            End If
            Dim alta As New ModeloComprobante()
            alta.FIngreso = cmbFechaP.Text
            alta.FPago = cmbFechaP.Text
            alta.IdTipoComprobante = 4
            alta.IdCompania = row.Cells("idCompania").Value
            alta.IdUsuario = frmLogin.idUsuario
            alta.Importe = row.Cells("importe").Value
            alta.Obs = ""
            alta.IdCliente = idCliente
            alta.IdEstado = 1
            alta.IdEstadoOperacion = 2
            alta.Numero = ""
            alta.IdBanco = 0

            Dim idAlta As Integer = ComprobantesController.CrearMovimiento(alta)

            PlanillasController.AgregarReciboAPlanilla(idCliente, cmbFechaP.Text, idAlta,
                                                       row.Cells("Tomador").Value, row.Cells("Ref").Value,
                                                       row.Cells("idCompania").Value, row.Cells("Detalle").Value,
                                                       If(IsDBNull(row.Cells("patente").Value) = True, "", row.Cells("patente").Value),
                                                       row.Cells("FVencimiento").Value,
                                                       row.Cells("importe").Value)
        Next


        'Refresco los datos
        cmbFechaPChanged(sender, e)
        MsgBox("Se agregaron correctamente las polizas a la planilla")


    End Sub

    Private Sub CambiarEstadoPlanilla(sender As Object, e As EventArgs) Handles btnCambioEstadoPlanilla.Click

        If cmbFechaP.Text = "" Or cmbFechaP.Text = "Nueva Planilla" Then
            Return
        End If

        Dim idCliente As Integer = ExtraerNumeros(cmbClienteP.Text)
        Dim f As Date = cmbFechaP.Text

        If txtEstado.Text <> "PENDIENTE" Then
            MsgBox("El estado no se puede cambiar 2 veces")
            Return
        End If

        If rbAceptar.Checked = True Then
            PlanillasController.CambiarEstadoPlanilla(idCliente, f, 1)
        Else
            PlanillasController.CambiarEstadoPlanilla(idCliente, f, 3)
        End If

        'Refresco los datos
        cmbFechaPChanged(sender, e)
        MsgBox("El estado se cambió correctamente")
    End Sub

    Private Sub DPreviaACargar_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DPreviaACargar.CellMouseClick
        EliminarFilaDataGridClickDerecho(e, DPreviaACargar)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim idCliente = ExtraerNumeros(cmbClienteP.Text)
        'Cambiar Estado de planilla a pendiente nuevamente
        PlanillasController.CambiarEstadoPlanilla(idCliente, cmbFechaP.Text, 2)
        'Borra todos los comprobantes y los PlanillasComprobantes

        Dim data As ArrayList = PlanillasController.EliminarPlanillasComprobantes(idCliente, cmbFechaP.Text)

        For Each row As Integer In data
            ComprobantesController.EliminarComprobante(row)
        Next

        'Vuelve a cargar
        'Agrega todos los recibos y los relaciono
        For Each row As DataGridViewRow In DgPlanillaPolizas.Rows
            If row.IsNewRow = True Then
                Exit For
            End If
            Dim alta As New ModeloComprobante()
            alta.FIngreso = cmbFechaP.Text
            alta.FPago = cmbFechaP.Text
            alta.IdTipoComprobante = 4
            alta.IdCompania = row.Cells("idCompania").Value
            alta.IdUsuario = frmLogin.idUsuario
            alta.Importe = row.Cells("importe").Value
            alta.Obs = ""
            alta.IdCliente = idCliente
            alta.IdEstado = 1
            alta.IdEstadoOperacion = 2
            alta.Numero = ""
            alta.IdBanco = 0

            Dim idAlta As Integer = ComprobantesController.CrearMovimiento(alta)

            PlanillasController.AgregarReciboAPlanilla(idCliente, cmbFechaP.Text, idAlta,
                                                       row.Cells("Tomador").Value, row.Cells("Ref").Value,
                                                       row.Cells("idCompania").Value, row.Cells("Detalle").Value,
                                                       row.Cells("patente").Value, row.Cells("FVencimiento").Value,
                                                       row.Cells("importe").Value)
        Next


        'Refresco los datos
        cmbFechaPChanged(sender, e)
        MsgBox("Se agregaron correctamente las polizas a la planilla")

    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtImporte_KeyPress(sender As Object, e As EventArgs) Handles txtImporte.KeyPress
        SoloImporte(e)
    End Sub

    Private Sub CmbBanco_KeyPress(sender As Object, e As EventArgs) Handles cmbBanco.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub CmbTipoComprobante_KeyPress(sender As Object, e As EventArgs) Handles cmbTipoComprobante.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub frmPlanillas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmPrincipal.LlenarDatos()
    End Sub

    Private Sub BtnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        ExportarExcel(DgPlanillaPolizas, "", "")
    End Sub

    Private Sub PDF_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmReportes
            .panelReportes.Controls.Clear()
            .reporteActivo = New ReportViewer()
            .panelReportes.Controls.Add(.reporteActivo)
            .reporteActivo.Dock = Windows.Forms.DockStyle.Fill
            .reporteActivo.LocalReport.ReportEmbeddedResource = "CuicchiGaveglio.Planilla.rdlc"
            Dim datos As New CapaDatos.ClsReportes()
            Dim dataTable As DataTable = datos.ReportePlanilla(ExtraerNumeros(cmbClienteP.Text), cmbFechaP.Text)
            Dim Cliente As New ReportParameter("Cliente", ExtraerLetras(cmbClienteP.Text))
            Dim Fecha_Planilla As New ReportParameter("Fecha_Planilla", cmbFechaP.Text)
            .reporteActivo.LocalReport.SetParameters(Cliente)
            .reporteActivo.LocalReport.SetParameters(Fecha_Planilla)
            .reporteActivo.LocalReport.DataSources.Add(New ReportDataSource("DSPlanillas", dataTable))
            .reporteActivo.RefreshReport()
            .Show()
            .reporteActivo.Show()
        End With


    End Sub
End Class