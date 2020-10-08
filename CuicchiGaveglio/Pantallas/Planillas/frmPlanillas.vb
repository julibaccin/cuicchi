Imports System.Windows.Forms

Public Class frmPlanillas

    Dim ComprobantesController As New ClsComprobantes
    Dim PlanillasController As New ClsPlanillas
    Dim SaldosController As New ClsSaldos

    Private Sub FrmConsultarComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setearValoresCombo()
    End Sub

    Public Sub setearValoresCombo()
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
                                            , DFechaPlanillaNueva.Value, 1, frmLogin.idUsuario, 2) = 0 Then
            MsgBox("Ya existe una planilla para ese cliente, en esa fecha")
            Return
        End If
        cmbFechaPChanged(sender, e)
        MsgBox("La planilla se guardó correctamente")
    End Sub

    Private Sub cmbFechaPChanged(sender As Object, e As EventArgs) Handles cmbFechaP.SelectedIndexChanged
        If cmbFechaP.Text = "Nueva Planilla" Then
            DFechaPlanillaNueva.Visible = True
            DgPlanillaPolizas.Visible = False
            Return
        End If
        DgPlanillaPolizas.Visible = True
        DFechaPlanillaNueva.Visible = False


        If cCopiarDatos.Checked = True Then
            Return
        End If

        PlanillasController.DevolverPolizasDePlanilla(DgPlanillaPolizas,
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

        'Inserto todas las altas de comprobantes
        For Each Fila As DataGridViewRow In DPreviaACargar.Rows

            Dim objAlta As New ModeloAltaComprobantes
            With objAlta
                .idTipoComprobante = ExtraerNumeros(Fila.Cells("tipoComprobante").Value)
                .FIngreso = Fila.Cells("fIngreso").Value
                .idCliente = ExtraerNumeros(Fila.Cells("Cliente").Value)
                .idCompania = ExtraerNumeros(Fila.Cells("Compania").Value)
                .Importe = Fila.Cells("importe").Value
                .Numero = Fila.Cells("numero").Value
                .FPago = Fila.Cells("fpago").Value
                .idBanco = ExtraerNumeros(Fila.Cells("Banco").Value)
                .Obs = Fila.Cells("obs").Value
                .idUsuario = frmLogin.idUsuario
                .idEstado = 1
                .idEstadoOperacion = 1
            End With
            Dim idAlta As Integer = ComprobantesController.CrearMovimiento(objAlta)

            If idAlta = 0 Then
                MsgBox("Error")
                Return
            End If

            'Cargo en la tabla PlanillaPagos
            PlanillasController.AgregarPagoAPlanilla(ExtraerNumeros(cmbClienteP.Text), cmbFechaP.Text, idAlta)
        Next

        DPreviaACargar.Rows.Clear()
        MsgBox("Carga Correcta")

        LimpiarCampos()
    End Sub

    Private Sub CargarPolizasAPlanilla(sender As Object, e As EventArgs) Handles btnCargarPolizas.Click

        'Agrega todas las polizas a la planilla correspondiente
        For Each row As DataGridViewRow In DgPlanillaPolizas.Rows
            If row.IsNewRow = True Then
                Exit For
            End If
            PlanillasController.AgregarPolizaAPlanilla(
            ExtraerNumeros(cmbClienteP.Text), cmbFechaP.Text, row.Cells("numeracion").Value,
            row.Cells("tomador").Value, row.Cells("ref").Value, row.Cells("idcompania").Value,
            row.Cells("detalle").Value, row.Cells("patente").Value, row.Cells("fvencimiento").Value,
            row.Cells("importe").Value
            )
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
End Class