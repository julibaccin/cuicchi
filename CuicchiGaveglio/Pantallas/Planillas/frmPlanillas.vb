Imports System.Data
Imports System.Windows.Forms
Imports CapaDatos
Imports Microsoft.Reporting.WinForms

Public Class FrmPlanillas

    ReadOnly ComprobantesController As New ClsComprobantes
    ReadOnly PlanillasController As New ClsPlanillas
    ReadOnly SaldosController As New ClsSaldos

    Public Sub FrmConsultarComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetearValoresCombo()
    End Sub

    Public Sub SetearValoresCombo()

        'MUESTRO CAMBIAR ESTADO SEGUN EL ROL
        If frmLogin.IdRol = 2 Then
            btnCambioEstadoPlanilla.Visible = False
            rbAceptar.Visible = False
            rbRechazar.Visible = False
        ElseIf frmLogin.IdRol = 1 Then
            rbAceptar.Visible = True
            rbRechazar.Visible = True
            btnCambioEstadoPlanilla.Visible = True
        End If

        'SETEO LOS CAMPOS
        cmbClienteP.Text = ""
        cmbFechaP.Text = ""

        'SETEO LAS FECHAS
        DFechaIngreso.Value = Date.Now()
        DFechaPago.Value = Date.Now()
        DFechaPlanillaNueva.Value = Date.Now()

        'LLENO LOS COMBOS
        LlenarComboClientes(cmbClienteP)
        LlenarComboTipoComprobantes(cmbTipoComprobante)
        LlenarComboCompanias(cmbCompania)
        LlenarComboBancos(cmbBanco)

        'QUITO LOS TIPO DE COMPROBANTES RECIBOS
        cmbTipoComprobante.Items.RemoveAt(3)

    End Sub

    'CADA VEZ QUE EL COMBO DE CLIENTES CAMBIA, ACTUALIZO LAS PLANILLAS
    Private Sub CmbClientePChanged(sender As Object, e As EventArgs) Handles cmbClienteP.SelectedIndexChanged

        Dim idcliente As Integer = ExtraerIdCliente(cmbClienteP.Text)

        'SALDO CLIENTE
        txtSaldoCliente.Text = SaldosController.ConsultarSaldosPorCliente(idcliente)

        'TRAIGO LAS PLANILLAS DE ESE CLIENTE
        cmbFechaP.Items.Clear()
        Dim respuesta As ArrayList = PlanillasController.DevolverPlanillasCliente(idcliente, frmLogin.IdUsuario)
        For Each element As Integer In respuesta
            cmbFechaP.Items.Add(element)
        Next

    End Sub

    'SI HACE CLICK DERECHO EN LA PLANILLA DE RECIBOS SE ELIMINA LA FILA
    Private Sub DataPlanillasPolizas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgPlanillaPolizas.CellMouseClick
        Dim resp = EliminarFilaDataGridClickDerecho(e, DgPlanillaPolizas)
        If resp <> 0 Then txtTotalPlanilla.Text = txtTotalPlanilla.Text - resp
    End Sub

    'CARGA UNA NUEVA PLANILLA
    Private Sub CargarNuevaPlanilla(sender As Object, e As EventArgs) Handles btnCargarPlanillaNueva.Click
        'VERIFICO CLIENTE
        If cmbClienteP.Text = "" Then
            MsgBox("Debe ingresar un cliente valido")
            Return
        End If
        'PREGUNTO SI ESTA SEGURO
        Dim resul As MsgBoxResult = MsgBox("Está por cargar una planilla del cliente: " & ExtraerLetras(cmbClienteP.Text) & " a la fecha de: " & DFechaPlanillaNueva.Value, MsgBoxStyle.OkCancel)
        If resul <> 1 Then
            Return
        End If
        'CREO PLANILLA
        If PlanillasController.CrearPlanilla(ExtraerIdCliente(cmbClienteP.Text),
                                             FormatearFecha(DFechaPlanillaNueva.Value),
                                             frmLogin.IdUsuario) = 0 Then
            MsgBox("Ya existe una planilla para ese cliente, en esa fecha")
            Return
        End If

        'SETEO LOS CAMPOS
        FrmConsultarComprobantes_Load(sender, e)

        MsgBox("La planilla se guardó correctamente")

    End Sub

    Public Sub CmbFechaPChanged(sender As Object, e As EventArgs) Handles cmbFechaP.SelectedIndexChanged

        'SETEO LOS TOTALES
        txtTotalPlanilla.Text = 0
        txtTotalPlanillaPagos.Text = 0

        'OBTENGO EL ID DE LA PLANILLA
        Dim idPlanilla = PlanillasController.ObtenerIdPlanilla(ExtraerIdCliente(cmbClienteP.Text), cmbFechaP.Text)
        txtIdPlanilla.Text = idPlanilla

        'SI LOS DATOS ESTAN EN COPIAR COPIO Y RETORNO
        If cCopiarDatos.Checked = True Then
            For Each row As DataGridViewRow In DgPlanillaPolizas.Rows
                txtTotalPlanilla.Text += row.Cells("importe").Value
            Next
            For Each row As DataGridViewRow In DPreviaACargar.Rows
                txtTotalPlanillaPagos.Text += row.Cells("importe").Value
            Next
            Return
        End If

        'BORRO AMBAS GRILLAS
        DgPlanillaPolizas.Columns.Clear()
        DgPlanillaPolizas.DataSource = Nothing
        DPreviaACargar.Columns.Clear()
        DPreviaACargar.DataSource = Nothing

        'LLENO AMBOS GRILLAS
        PlanillasController.DevolverRecibosDePlanilla(DgPlanillaPolizas, txtIdPlanilla.Text)
        PlanillasController.DevolverPagosDePlanilla(DPreviaACargar, txtIdPlanilla.Text)

        'LLENO LOS AMBOS TOTALES
        For Each row As DataGridViewRow In DgPlanillaPolizas.Rows
            If row.IsNewRow = True Then
                Exit For
            End If
            txtTotalPlanilla.Text += row.Cells.Item("importe").Value
        Next
        For Each row As DataGridViewRow In DPreviaACargar.Rows
            txtTotalPlanillaPagos.Text += row.Cells("importe").Value
        Next

        'AGREGO LA COLUMNA COMPAÑIA COMBO
        Dim columCombo As New DataGridViewComboBoxColumn With {
            .HeaderText = "Compañia",
            .Name = "columCombo"
        }
        For Each i As String In cmbCompania.Items
            columCombo.Items.Add(ExtraerLetras(i))
        Next
        DgPlanillaPolizas.Columns.Add(columCombo)

        'SETEO EL VALOR DEL COMBO SEGUN LOS DATOS
        Dim Companias = PlanillasController.DevolverCompaniasdeRecibosDePlanilla(txtIdPlanilla.Text)
        If Companias.Count <> 0 Then
            For i = 0 To Companias.Count - 1
                DgPlanillaPolizas.Item("columCombo", i).Value = Companias.Item(i)
            Next
        End If

        'CARGO EL ESTADO
        txtEstado.Text = PlanillasController.DatosGeneralesPlanilla(txtIdPlanilla.Text)

        'MOSTRAR BOTON MODIFICAR
        If txtEstado.Text = "RECHAZADO" Then
            btnModificar.Visible = True
        Else
            btnModificar.Visible = False
        End If

    End Sub

    Private Sub PreCargarComprobantesAPlanilla(sender As Object, e As EventArgs) Handles btnPreCargar.Click

        'CHEQUEO CAMPOS OBLIGATORIOS Y SELECCION DE PLANTILLA
        If cmbTipoComprobante.Text = "" Or cmbClienteP.Text = "" Or txtImporte.Text = "" Then
            MsgBox("Ingrese los campos obligatorios")
            Return
        End If
        If cmbFechaP.Text = "" Then
            MsgBox("Seleccione una planilla")
            Return
        End If

        'EXTRAIGO TIPO DE COMPROBANTE
        Dim tComp = ExtraerNumeros(cmbTipoComprobante.Text)

        If tComp = 1 And (cmbClienteP.Text = "") Then 'EFECTIVO
            MsgBox("Falta ingresar algun dato")
        ElseIf tComp = 2 And (cmbBanco.Text = "" Or cmbCompania.Text = "") Then 'TRANSFERENCIA
            MsgBox("Falta ingresar algun dato")
            Return
        ElseIf tComp = 3 And (txtNumero.Text = "" Or cmbBanco.Text = "") Then 'CHEQUE
            MsgBox("Falta ingresar algun dato")
            Return
        ElseIf tComp = 4 And (cmbCompania.Text = "" Or ExtraerNumeros(cmbCompania.Text) = "0") Then 'RECIBO
            MsgBox("Falta ingresar algun dato")
            Return
        ElseIf tComp = 5 Then 'COMPROBANTE RETENCION
        ElseIf tComp = 6 And (txtNumero.Text = "" Or cmbBanco.Text = "" Or cmbCompania.Text = "") Then 'ECHEQ
            MsgBox("Falta ingresar algun dato")
            Return
        End If

        'LLENO UNA LISTA CON LOS DATOS QUE TENGA LA GRID PAGOS **********
        Dim list As New List(Of DataGridViewRow)
        If IsNothing(DPreviaACargar.DataSource) = False Then

            For Each a As DataGridViewRow In DPreviaACargar.Rows
                Dim row = New DataGridViewRow()
                For Each b As DataGridViewCell In a.Cells
                    Dim cell = New DataGridViewTextBoxCell()
                    cell.Value = b.Value
                    row.Cells.Add(cell)
                Next
                list.Add(row)
            Next
        End If

        'SACO EL DATASOURCE DE LA GRID DE PAGO
        DPreviaACargar.DataSource = Nothing

        'SI LA GRID NO TIENE COLUMNAS LAS AGREGO
        If DPreviaACargar.Columns.Count < 1 Then
            DPreviaACargar.Columns.Add("idtipoComprobante", "idtipoComprobante")
            DPreviaACargar.Columns.Add("fingreso", "fingreso")
            DPreviaACargar.Columns.Add("idcliente", "idcliente")
            DPreviaACargar.Columns.Add("idcompania", "idcompania")
            DPreviaACargar.Columns.Add("importe", "importe")
            DPreviaACargar.Columns.Add("numero", "numero")
            DPreviaACargar.Columns.Add("fpago", "fpago")
            DPreviaACargar.Columns.Add("idbanco", "idbanco")
            DPreviaACargar.Columns.Add("obs", "obs.")
            'AGREGO LAS COLUMNAS DEL PASO MARCADO *********
            For Each a As DataGridViewRow In list
                DPreviaACargar.Rows.Add(a)
            Next
        End If

        'AGREGO EL NUEVO PAGO
        DPreviaACargar.Rows.Add(cmbTipoComprobante.Text,
                                FormatearFecha(DFechaIngreso.Value),
                                cmbClienteP.Text,
                                IIf(cmbCompania.Text <> "", cmbCompania.Text, 0),
                                txtImporte.Text,
                                IIf(txtNumero.Visible, txtNumero.Text, ""),
                                IIf(DFechaPago.Visible, FormatearFecha(DFechaPago.Value), 0),
                                IIf(cmbBanco.Visible, ExtraerNumeros(cmbBanco.Text), 0),
                                txtObservaciones.Text)

        'ACTUALIZO EL TOTAL DE PAGO
        txtTotalPlanillaPagos.Text = CDbl(txtTotalPlanillaPagos.Text) + CDbl(txtImporte.Text)

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

        If txtIdPlanilla.Text = "" Or txtIdPlanilla.Text = 0 Then
            MessageBox.Show("Seleccione una planilla")
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
                'SIEMPRE
                .IdTipoComprobante = ExtraerNumeros(Fila.Cells("idtipoComprobante").Value)
                .FIngreso = Fila.Cells("fIngreso").Value
                .IdCliente = ExtraerIdCliente(Fila.Cells("idcliente").Value)
                .Importe = Fila.Cells("importe").Value
                .IdEstado = 1
                .IdUsuario = frmLogin.IdUsuario
                .IdEstadoOperacion = 2
                'NO SIEMPRE
                .IdCompania = ExtraerIdCliente(Fila.Cells("idcompania").Value)
                .Numero = Fila.Cells("numero").Value
                .FPago = Fila.Cells("fpago").Value
                .IdBanco = Fila.Cells("idbanco").Value
                .Obs = Fila.Cells("obs").Value
                .IdPlanilla = txtIdPlanilla.Text
            End With
            Dim idAlta As Integer = ComprobantesController.CrearMovimientoPlanilla(objAlta)

            If idAlta = 0 Then
                MsgBox("Error")
                Return
            End If
        Next
        txtTotalPlanillaPagos.Text = ""
        DPreviaACargar.Rows.Clear()
        MsgBox("Carga Correcta")

        LimpiarCampos()
        CmbFechaPChanged(sender, e)
    End Sub

    Private Sub CargarRecibosAPlanilla(sender As Object, e As EventArgs) Handles btnCargarPolizas.Click

        Dim idCliente = ExtraerIdCliente(cmbClienteP.Text)

        'COMPRUEBO QUE ESTEN BIEN LOS DATOS A CARGAR
        For Each row As DataGridViewRow In DgPlanillaPolizas.Rows
            If row.IsNewRow = True Then
                Exit For
            End If
            If ComprobarCargarRecibo(row) = False Then
                MsgBox("Hay uno o más recibos mal cargados.
                        Los campos obligatorios son: Tomador, Ref, Importe, Compañia")
                Return
            End If
        Next

        'CARGO TODOS LOS RECIBOS
        For Each row As DataGridViewRow In DgPlanillaPolizas.Rows
            If IsNothing(row.Cells("Tomador").Value) = False Then
                Dim alta As New ModeloComprobante With {
               .FIngreso = cmbFechaP.Text,
               .IdTipoComprobante = 4,
               .IdCompania = ComprobantesController.ConsultarIdCompania(row.Cells("columcombo").Value),
               .IdUsuario = frmLogin.IdUsuario,
               .Importe = row.Cells("importe").Value,
               .Obs = "",
               .IdCliente = idCliente,
               .IdEstado = 1,
               .IdEstadoOperacion = 2,
               .Numero = "",
               .IdBanco = 0,
               .Tomador = row.Cells("Tomador").Value,
               .Ref = row.Cells("Ref").Value,
               .Detalle = IIf(IsDBNull(row.Cells("detalle").Value) = True, "", row.Cells("detalle").Value), 'este
               .Patente = IIf(IsDBNull(row.Cells("patente").Value) = True, "", row.Cells("patente").Value),
               .FVencimiento = IIf(IsDBNull(row.Cells("FVencimiento").Value) = True, 0, row.Cells("FVencimiento").Value),
               .ObsBaja = row.Cells("importe").Value,
               .IdPlanilla = txtIdPlanilla.Text
           }
                Dim idAlta As Integer = ComprobantesController.CrearMovimientoReciboPlanilla(alta)
            End If
        Next

        'REFRESCO LOS DATOS
        CmbFechaPChanged(sender, e)

        MsgBox("Se agregaron correctamente las polizas a la planilla")

    End Sub

    Private Sub CambiarEstadoPlanilla(sender As Object, e As EventArgs) Handles btnCambioEstadoPlanilla.Click

        If cmbFechaP.Text = "" Or cmbFechaP.Text = "Nueva Planilla" Then
            Return
        End If

        If DgPlanillaPolizas.Rows.Count = 1 Then
            MsgBox("Esta planilla no tiene ningun recibo asociado")
            Return
        End If

        If txtEstado.Text <> "PENDIENTE" Then
            MsgBox("El estado no se puede cambiar 2 veces")
            Return
        End If

        If rbAceptar.Checked = True Then
            PlanillasController.CambiarEstadoPlanilla(txtIdPlanilla.Text, 1)
            ComprobantesController.CambiarEstadoOperacion(txtIdPlanilla.Text, 1)
        Else
            PlanillasController.CambiarEstadoPlanilla(txtIdPlanilla.Text, 3)
            ComprobantesController.CambiarEstadoOperacion(txtIdPlanilla.Text, 3)
        End If

        'Refresco los datos
        CmbFechaPChanged(sender, e)
        MsgBox("El estado se cambió correctamente")
    End Sub

    Private Sub DPreviaACargar_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DPreviaACargar.CellMouseClick
        Dim resp = EliminarFilaDataGridClickDerecho(e, DPreviaACargar)
        If resp <> 0 Then txtTotalPlanillaPagos.Text = txtTotalPlanillaPagos.Text - resp
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'EXTRAIGO ID CLIENTE
        Dim idCliente = ExtraerIdCliente(cmbClienteP.Text)
        'VUELVO A PENDIENTE LA PLANILLA
        PlanillasController.CambiarEstadoPlanilla(txtIdPlanilla.Text, 2)

        'ELIMINO TODOS LOS COMPROBANTES DE LA PLANILLA (PARA LUEGO CARGARLOS NUEVAMENTE)
        PlanillasController.EliminarPlanillasComprobantes(txtIdPlanilla.Text)

        'VUELVO A CARGAR LOS COMPROBANTES

        'CARGO RECIBOS
        For Each row As DataGridViewRow In DgPlanillaPolizas.Rows
            If row.IsNewRow = True Then
                Exit For
            End If

            Dim alta As New ModeloComprobante With {
                .FIngreso = cmbFechaP.Text,
                .FPago = cmbFechaP.Text,
                .IdTipoComprobante = 4,
                .IdCompania = ComprobantesController.ConsultarIdCompania(row.Cells("columCombo").Value),
                .IdUsuario = frmLogin.IdUsuario,
                .Importe = row.Cells("importe").Value,
                .Obs = "",
                .IdCliente = idCliente,
                .IdEstado = 1,
                .IdEstadoOperacion = 2,
                .Numero = "",
                .IdBanco = 0,
                .Tomador = row.Cells("Tomador").Value,
                .Ref = row.Cells("Ref").Value,
                .Detalle = row.Cells("Detalle").Value,
                .Patente = If(IsDBNull(row.Cells("patente").Value) = True, "", row.Cells("patente").Value),
                .FVencimiento = row.Cells("FVencimiento").Value,
                .ObsBaja = row.Cells("importe").Value,
                .IdPlanilla = txtIdPlanilla.Text
            }

            Dim idAlta As Integer = ComprobantesController.CrearMovimientoReciboPlanilla(alta)
            ComprobantesController.CambiarEstadoOperacion(txtIdPlanilla.Text, 2)
        Next

        'CARGO PAGOS
        For Each Fila As DataGridViewRow In DPreviaACargar.Rows

            Dim objAlta As New ModeloComprobante
            With objAlta
                'SIEMPRE
                .IdTipoComprobante = ExtraerNumeros(Fila.Cells("idtipocomprobante").Value)
                .FIngreso = Fila.Cells("fingreso").Value
                .IdCliente = ExtraerIdCliente(Fila.Cells("idcliente").Value)
                .Importe = Fila.Cells("importe").Value
                .IdEstado = 1
                .IdUsuario = frmLogin.IdUsuario
                .IdEstadoOperacion = 2
                'NO SIEMPRE
                .IdCompania = ExtraerIdCliente(Fila.Cells("idcompania").Value)
                .Numero = Fila.Cells("numero").Value
                .FPago = Fila.Cells("fpago").Value
                .IdBanco = Fila.Cells("idbanco").Value
                .Obs = Fila.Cells("obs").Value
                .IdPlanilla = txtIdPlanilla.Text
            End With
            Dim idAlta As Integer = ComprobantesController.CrearMovimientoPlanilla(objAlta)

            If idAlta = 0 Then
                MsgBox("Error")
                Return
            End If
        Next

        LimpiarCampos()

        'REFRESCO DATOS
        CmbFechaPChanged(sender, e)

        MsgBox("Se modificó correctamente la planilla")

    End Sub

    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
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

    Private Sub FrmPlanillas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmPrincipal.LlenarDatos()
    End Sub

    Private Sub BtnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        ExportarExcel(DgPlanillaPolizas)
    End Sub

    Private Sub PDF_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'With frmReportes
        '    .panelReportes.Controls.Clear()
        '    .reporteActivo = New ReportViewer()
        '    .panelReportes.Controls.Add(.reporteActivo)
        '    .reporteActivo.Dock = Windows.Forms.DockStyle.Fill
        '    .reporteActivo.LocalReport.ReportEmbeddedResource = "CuicchiGaveglio.Planilla.rdlc"
        '    Dim datos As New CapaDatos.ClsReportes()
        '    'Dim dataTable As DataTable = datos.ReportePlanilla(ExtraerNumeros(txtIdPlanilla.Text))
        '    Dim Cliente As New ReportParameter("Cliente", ExtraerLetras(cmbClienteP.Text))
        '    Dim Fecha_Planilla As New ReportParameter("Fecha_Planilla", cmbFechaP.Text)
        '    .reporteActivo.LocalReport.SetParameters(Cliente)
        '    .reporteActivo.LocalReport.SetParameters(Fecha_Planilla)
        '    .reporteActivo.LocalReport.DataSources.Add(New ReportDataSource("DSPlanillas", dataTable))
        '    .reporteActivo.RefreshReport()
        '    .Show()
        '    .reporteActivo.Show()
        'End With


    End Sub

    Private Sub CmbTipoComprobante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoComprobante.SelectedIndexChanged
        Dim tComprobante = ExtraerLetras(cmbTipoComprobante.Text)
        If tComprobante = "Efectivo" Then
            DFechaPago.Visible = False
            txtNumero.Visible = False
            cmbBanco.Visible = False
            cmbCompania.Visible = False
        ElseIf tComprobante = "Recibo" Then
            DFechaPago.Visible = False
            txtNumero.Visible = False
            cmbBanco.Visible = False
            cmbCompania.Visible = True
        ElseIf tComprobante = "Cheque" Then
            DFechaPago.Visible = True
            txtNumero.Visible = True
            cmbBanco.Visible = True
            cmbCompania.Visible = False
        ElseIf tComprobante = "Comprobante de Retencion" Then

        ElseIf tComprobante = "Transferencia" Then
            DFechaPago.Visible = True
            txtNumero.Visible = True
            cmbBanco.Visible = True
            cmbCompania.Visible = True
        End If
    End Sub

    Private Sub DPreviaACargar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DPreviaACargar.CellContentDoubleClick
        With DPreviaACargar
            cmbTipoComprobante.Text = .Item("Comprobante", e.RowIndex).Value
            txtImporte.Text = .Item("Importe", e.RowIndex).Value()
            cmbTipoComprobante.Focus()
        End With
    End Sub

    Private Sub DgPlanillaPolizas_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DgPlanillaPolizas.CellValidated
        If DgPlanillaPolizas.Columns(e.ColumnIndex).Name = "importe" Then
            If IsDBNull(DgPlanillaPolizas.Item(e.ColumnIndex, e.RowIndex).Value) Then
                Return
            Else
                txtTotalPlanilla.Text += DgPlanillaPolizas.Item(e.ColumnIndex, e.RowIndex).Value
            End If
        End If
    End Sub

    'VERIFICA LOS CAMPOS OBLIGATORIOS PARA CARGAR UN RECIBO
    Public Function ComprobarCargarRecibo(row As DataGridViewRow) As Boolean
        If IsDBNull(row.Cells("Tomador").Value) Or IsDBNull(row.Cells("Detalle").Value) Or IsDBNull(row.Cells("Importe").Value) Or IsDBNull(row.Cells("columCombo").Value) Then
            Return False
        End If
        Return True
    End Function

End Class