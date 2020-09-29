Imports System.Drawing
Imports System.Windows.Forms

Public Class frmConsultarComprobantes

#Region "PROPIEDADES DE FORMULARIO"
    Dim Control As New ClsComprobantes()
    Dim Control2 As New ClsComprobantes
    Dim Control3 As New ClsPlanillas
#End Region

#Region "COMPARTIDA"

    Private Sub FrmConsultarComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setearValoresCombo()
    End Sub

    Private Sub Cerrar_Form(sender As Object, e As EventArgs) Handles Me.Closed
        ReiniciarForm()
    End Sub

    Public Sub setearValoresCombo()
        DFIngresoHastaFiltro.Value = Date.Now()
        DFIngresoDesdeFiltro.Value = DFIngresoHastaFiltro.Value.AddDays(-30)
        DFechaIngreso.Value = Date.Now()
        DFechaPago.Value = Date.Now()
        txtImporteFiltro.Text = -999999
        LlenarComboTipoComprobantes(cmbTipoComprobanteFiltro)
        LlenarComboClientes(cmbCliente)
        LlenarComboTipoComprobantes(cmbTipoComprobante)
        LlenarComboCompanias(cmbCompania)
        LlenarComboBancos(cmbBanco)
        LlenarComboEstados(cmbEstadosCambioEstado)
        LlenarComboClientes(cmbClienteFiltro)
        LlenarComboCompanias(cmbCompaniaFiltro)
        LlenarComboEstados(cmbEstadoFiltro)
        LlenarComboCompanias(cmbCompaniaCambioEstado)
        LlenarComboClientes(cmbClienteP)

    End Sub

    Public Sub ReiniciarForm()
        cmbCliente.Text = ""
        cmbFechaPlanillas.Items.Clear()
        cmbFechaPlanillas.Text = ""
        DAltasComprobantes.DataSource = Nothing
        DPolizasPagos.DataSource = Nothing
        DataPlanillasPolizas.DataSource = Nothing
        txtIdAlta.Text = ""
        txtPoliza.Text = ""
        txtImporteAlta.Text = ""
        frmPrincipal.LlenarDatos()
    End Sub

#End Region

#Region "PLANILLA"

    Private Sub CmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClienteP.SelectedIndexChanged
        cmbFechaPlanillas.Items.Clear()
        cmbFechaPlanillas.Items.Add("Nueva Planilla")
        Dim respuesta As ArrayList = Control3.DevolverPlanillasCliente(ExtraerNumeros(cmbClienteP.Text))
        For Each element As Date In respuesta
            cmbFechaPlanillas.Items.Add(element.ToShortDateString)
        Next
        Control2.ConsultarAltaComprobantes(DAltasComprobantes, "", "2020-01-01", "2080-01-01", "", "", "2020-01-01", -999999, ExtraerLetras(cmbCliente.Text), "", "")

        'ACA MIRO SI TIENE SALDO
        Dim ControlSaldo As New ClsSaldos()
        ControlSaldo.DevolverCuentaCliente(DDetalle, ExtraerNumeros(cmbClienteP.Text))

        Dim TotalAPagar As Integer = 0
        Dim TotalPago As Integer = 0
        For Each Row As DataGridViewRow In DDetalle.Rows
            TotalAPagar += Row.Cells(1).Value
            TotalPago += Row.Cells(2).Value
        Next

        Dim Total As Integer = TotalAPagar - TotalPago
        If Total = 0 Then
            lblTotal.Text = "No tiene plata ni a favor, ni en contra"
        ElseIf Total > 0 Then
            lblTotal.Text = "Debe: " & Total & " $"
        ElseIf Total < 0 Then
            lblTotal.Text = "Tiene a favor: " & Total * -1 & " $"
        End If



    End Sub

    Private Sub DataPlanillasPolizas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataPlanillasPolizas.CellMouseClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 _
            Or e.RowIndex = DataPlanillasPolizas.Rows.Count - 1 _
            Or e.Button = MouseButtons.Left Then
            Return
        End If
        Dim filaEliminar As DataGridViewRow = DataPlanillasPolizas.Rows(e.RowIndex)
        DataPlanillasPolizas.Rows.Remove(filaEliminar)
    End Sub

    Private Sub BtnCargarPlanillaNueva_Click(sender As Object, e As EventArgs) Handles btnCargarPlanillaNueva.Click
        If cmbCliente.Text = "" Then
            MsgBox("Debe ingresar un cliente valido")
            Return
        End If

        Dim resul As MsgBoxResult = MsgBox("Está por cargar una planilla del cliente: " & ExtraerLetras(cmbClienteP.Text) & " a la fecha de: " & DFechaPlanillaNueva.Value, MsgBoxStyle.OkCancel)
        If resul <> 1 Then
            Return
        End If

        If Control3.CrearPlanilla(ExtraerNumeros(cmbClienteP.Text), DFechaPlanillaNueva.Value, frmLogin.idUsuario) = 0 Then
            MsgBox("Ya existe una planilla para ese cliente, en esa fecha")
            Return
        End If
        CmbCliente_SelectedIndexChanged(sender, e)
        MsgBox("La planilla se guardó correctamente")
    End Sub

    Private Sub DataPlanillasPolizas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataPlanillasPolizas.CellDoubleClick
        DPolizasPagos.Rows.Clear()
        If e.RowIndex = -1 Then
            Return
        ElseIf IsDBNull(DataPlanillasPolizas.Item("poliza", e.RowIndex).Value) Then
            Return
        End If

        txtPoliza.Text = DataPlanillasPolizas.Item("poliza", e.RowIndex).Value
        Dim arrayList As ArrayList
        arrayList = Control3.DevolverPagosDePoliza(ExtraerNumeros(cmbClienteP.Text), cmbFechaPlanillas.Text,
                                      txtPoliza.Text)
        For Each i As String In arrayList
            DPolizasPagos.Rows.Add(i)
        Next
    End Sub

    Private Sub BtnCargarPagosPoliza_Click(sender As Object, e As EventArgs) Handles btnCargarPagosPoliza.Click
        Dim Cliente As Integer = ExtraerNumeros(cmbClienteP.Text)
        Dim Fecha As Date = cmbFechaPlanillas.Text
        If Control3.AgregarPagoAPoliza(Cliente, Fecha, txtPoliza.Text, txtIdAlta.Text, txtImporteAlta.Text) = 1 Then
            MsgBox("Pago Cargado con Exito")
            txtImporteAlta.Text = ""
            txtIdAlta.Text = ""
        Else
            MsgBox("Ups, Ocurrió un error")
            txtImporteAlta.Text = ""
            txtIdAlta.Text = ""
        End If
    End Sub

    Private Sub CmbFechaPlanillas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFechaPlanillas.SelectedIndexChanged
        If cmbFechaPlanillas.Text = "Nueva Planilla" Then
            DFechaPlanillaNueva.Visible = True
            DataPlanillasPolizas.Visible = False
            Return
        End If
        DataPlanillasPolizas.Visible = True
        DFechaPlanillaNueva.Visible = False
        Control3.DevolverPolizasDePlanilla(DataPlanillasPolizas,
                                          ExtraerNumeros(cmbClienteP.Text),
                                          cmbFechaPlanillas.Text)
    End Sub

    Private Sub DAltasComprobantes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DAltasComprobantes.CellContentDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        txtIdAlta.Text = DAltasComprobantes.Item("idAlta", e.RowIndex).Value
    End Sub

    Private Sub BtnCargarPolizas_Click(sender As Object, e As EventArgs) Handles btnCargarPolizas.Click
        Dim Cliente As Integer = ExtraerNumeros(cmbClienteP.Text)
        Dim Fecha As Date
        If cmbFechaPlanillas.Text = "Nueva Planilla" Then
            Fecha = "2020-01-01"
        Else
            Fecha = cmbFechaPlanillas.Text
        End If
        For i = 0 To DataPlanillasPolizas.Rows.Count - 2
            Dim Row As DataGridViewRow = DataPlanillasPolizas.Rows(i)

            Control3.AgregarPolizaAPlanilla(Cliente, Fecha,
                                       Row.Cells("poliza").Value,
                                       Row.Cells("importe").Value,
                                       Row.Cells("detalle").Value,
                                       Row.Cells("ref").Value,
                                       Row.Cells("titular").Value,
                                       Row.Cells("fVencimiento").Value,
                                       Row.Cells("Patente").Value)
        Next
        MsgBox("Se agregaron correctamente las polizas a la planilla")
    End Sub


#End Region

#Region "COMPROBANTES"

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Respuesta = Control.ConsultarAltaComprobantes(DComprobantes, ExtraerLetras(cmbTipoComprobanteFiltro.Text),
                                                          DFIngresoDesdeFiltro.Value, DFIngresoHastaFiltro.Value,
                                                          txtNumeroFiltro.Text, ExtraerLetras(cmbUsuarioFiltro.Text), Date.Now(),
                                                          txtImporteFiltro.Text,
                                                          ExtraerLetras(cmbClienteFiltro.Text),
                                                          ExtraerLetras(cmbCompaniaFiltro.Text),
                                                          ExtraerLetras(cmbEstadoFiltro.Text))
        CambiarColorFilas()
    End Sub

    Public Sub CambiarColorFilas()
        'Cambiar los colores de las filas
        For Each fila As DataGridViewRow In DComprobantes.Rows
            ' Si el Efectivo o Recibo Entran (VERDE)
            If (fila.Cells.Item("Tipo_Comprobante").Value = "Efectivo" _
               Or fila.Cells.Item("Tipo_Comprobante").Value = "Recibo") _
               And fila.Cells.Item("Importe").Value > 0 Then
                fila.DefaultCellStyle.BackColor = Color.LightGreen
                ' Si el Efectivo o Recibo Salen (ROJO)
            ElseIf (fila.Cells.Item("Tipo_Comprobante").Value = "Efectivo" _
               Or fila.Cells.Item("Tipo_Comprobante").Value = "Recibo") _
               And fila.Cells.Item("Importe").Value < 0 Then
                fila.DefaultCellStyle.BackColor = Color.LightSalmon
                ' Si el Cheque/Transferencia/Comprobante de Retencion están en cartera
            ElseIf (fila.Cells.Item("Tipo_Comprobante").Value = "Cheque" _
                Or fila.Cells.Item("Tipo_Comprobante").Value = "Transferencia") _
                And (fila.Cells.Item("Estado").Value <> "En Cartera" And
                fila.Cells.Item("Estado").Value <> "Rechazado") Then
                fila.DefaultCellStyle.BackColor = Color.LightSalmon
                ' Si el cheque está rechazado
            ElseIf fila.Cells.Item("Tipo_Comprobante").Value = "Cheque" And
                    fila.Cells.Item("Estado").Value = "Rechazado" Then
                fila.DefaultCellStyle.BackColor = Color.Red
            Else
                fila.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Public Sub CopiarHeader()
        DComprobantesBaja.Columns.Clear()
        Dim CheckColum As New DataGridViewCheckBoxColumn()
        DComprobantesBaja.Columns.Add(CheckColum)
        For Each col As DataGridViewColumn In DComprobantes.Columns
            DComprobantesBaja.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
        Next
    End Sub

    Public Sub CopiarFila(pFila As Int16)
        DComprobantesBaja.Rows.Add(True,
                                   DComprobantes.Rows(pFila).Cells(0).Value,
                                   DComprobantes.Rows(pFila).Cells(1).Value,
                                   DComprobantes.Rows(pFila).Cells(2).Value,
                                   DComprobantes.Rows(pFila).Cells(3).Value,
                                   DComprobantes.Rows(pFila).Cells(4).Value,
                                   DComprobantes.Rows(pFila).Cells(5).Value,
                                   DComprobantes.Rows(pFila).Cells(6).Value,
                                   DComprobantes.Rows(pFila).Cells(7).Value,
                                   DComprobantes.Rows(pFila).Cells(8).Value,
                                   DComprobantes.Rows(pFila).Cells(9).Value,
                                   DComprobantes.Rows(pFila).Cells(10).Value,
                                   DComprobantes.Rows(pFila).Cells(11).Value,
                                   DComprobantes.Rows(pFila).Cells(12).Value)

    End Sub

    Private Sub DComprobantesBaja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DComprobantesBaja.CellContentClick
        If e.ColumnIndex = 0 Then
            DComprobantesBaja.Rows.Remove(DComprobantesBaja.Rows(e.RowIndex))
        End If

    End Sub

    Private Sub DComprobantes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DComprobantes.CellDoubleClick
        'Aca van a ir las validaciones de que si se encuentra entre los 3 comprobantes y esta
        'en un estado que se pueda dar de baja
        If DComprobantes.Item("Tipo_Comprobante", e.RowIndex).Value = "Cheque" Or DComprobantes.Item("Tipo_Comprobante", e.RowIndex).Value = "Transferencia" Or DComprobantes.Item("Tipo_Comprobante", e.RowIndex).Value = "Comprobante de Retencion" Then
            CopiarFila(e.RowIndex)
        End If
    End Sub

    Private Sub BtnPreCargar_Click(sender As Object, e As EventArgs) Handles btnPreCargar.Click
        If cmbTipoComprobante.Text = "" Or cmbCliente.Text = "" Or txtImporte.Text = "" Then
            MsgBox("Ingrese los campos obligatorios (estan marcados con asterisco)")
            Return
        End If

        DPreviaACargar.Rows.Add(True, cmbTipoComprobante.Text, DFechaIngreso.Value,
                                cmbCliente.Text, cmbCompania.Text, txtImporte.Text,
                                txtNumero.Text, DFechaPago.Value,
                                cmbBanco.Text, txtObservaciones.Text)
        LimpiarCampos()
    End Sub

    Public Sub LimpiarCampos()
        txtImporte.Text = ""
        txtNumero.Text = ""
        txtObservaciones.Text = ""
        cmbBanco.Text = ""
        cmbCliente.Text = ""
        cmbTipoComprobante.Text = ""
        cmbCompania.Text = ""
        cmbTipoComprobante.Focus()
        cmbBanco.Enabled = True
        cmbCompania.Enabled = True
        txtNumero.Enabled = True
        DFechaPago.Enabled = True
    End Sub

    Public Sub HabilitarDesabilitarCamposSegunTipoComprobante(pTipoComprobante As Integer)
        If pTipoComprobante = 1 Then
            txtNumero.Enabled = False
            txtNumero.Text = ""
            cmbBanco.Enabled = False
            cmbBanco.Text = ""
            cmbCompania.Enabled = False
            cmbCompania.Text = ""
        Else
            txtNumero.Enabled = True
            cmbBanco.Enabled = True
            cmbCompania.Enabled = True
        End If
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim Respuesta As Int16
        If DPreviaACargar.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DPreviaACargar.Rows
                Dim TipoComprobante = ExtraerNumeros(Fila.Cells(0).Value)

                Dim objAlta As New ModeloAltaComprobantes
                With objAlta
                    .idTipoComprobante = ExtraerNumeros(Fila.Cells(1).Value)
                    .FIngreso = Fila.Cells(2).Value
                    .idCliente = ExtraerNumeros(Fila.Cells(3).Value)
                    .idCompania = ExtraerNumeros(Fila.Cells(4).Value)
                    .Importe = Fila.Cells(5).Value
                    .Numero = Fila.Cells(6).Value
                    .FPago = Fila.Cells(7).Value
                    .idBanco = ExtraerNumeros(Fila.Cells(8).Value)
                    .Obs = Fila.Cells(9).Value
                    .idUsuario = frmLogin.idUsuario
                    .idEstado = 1
                End With
                Respuesta = Control.CrearMovimiento(objAlta)
                If Respuesta = 0 Then
                    MsgBox("Error")
                    Return
                End If
            Next
            DPreviaACargar.Rows.Clear()
            MsgBox("Carga Correcta")
        Else
            MsgBox("No hay nada PreCargado")
        End If
        LimpiarCampos()
        frmConsultarComprobantes_Shown(sender, e)
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        SoloImporte(e)
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub DPreviaACargar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DPreviaACargar.CellContentClick
        If e.ColumnIndex = 0 Then
            DPreviaACargar.Rows.Remove(DPreviaACargar.Rows(e.RowIndex))
            Return
        End If
        cmbTipoComprobante.Text = DPreviaACargar.Item(1, e.RowIndex).Value()
        DFechaIngreso.Value = CDate(DPreviaACargar.Item(2, e.RowIndex).Value())
        cmbCliente.Text = DPreviaACargar.Item(3, e.RowIndex).Value()
        cmbCompania.Text = DPreviaACargar.Item(4, e.RowIndex).Value()
        txtImporte.Text = DPreviaACargar.Item(5, e.RowIndex).Value()
        txtNumero.Text = DPreviaACargar.Item(6, e.RowIndex).Value()
        DFechaPago.Value = CDate(DPreviaACargar.Item(7, e.RowIndex).Value())
        cmbBanco.Text = DPreviaACargar.Item(8, e.RowIndex).Value()
        txtObservaciones.Text = DPreviaACargar.Item(9, e.RowIndex).Value()
        cmbTipoComprobante.Focus()
    End Sub

    Private Sub cmbTipoComprobante_Validated(sender As Object, e As EventArgs) Handles cmbTipoComprobante.Validated
        If (ExtraerNumeros(cmbTipoComprobante.Text) >= 1 And ExtraerNumeros(cmbTipoComprobante.Text)) <= 5 Or cmbTipoComprobante.Text = "" Then
        Else
            MsgBox("Ingresó un Tipo de Comprobante inexistente")
            cmbTipoComprobante.Text = ""
            cmbTipoComprobante.Focus()
        End If

        HabilitarDesabilitarCamposSegunTipoComprobante(Val(cmbTipoComprobante.Text))

    End Sub

    Private Sub BtnCargaCliente_Click(sender As Object, e As EventArgs) Handles btnCargaCliente.Click
        frmAltaClientes.ShowDialog()
    End Sub

    Private Sub BtnCargaCompania_Click(sender As Object, e As EventArgs) Handles btnCargaCompania.Click
        frmAltaCompania.ShowDialog()
    End Sub

    Private Sub BtnCargaBanco_Click(sender As Object, e As EventArgs) Handles btnCargaBanco.Click
        frmAltaBancos.ShowDialog()
    End Sub

    Private Sub frmConsultarComprobantes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        BtnBuscar_Click(sender, e)
        CopiarHeader()
    End Sub

    Private Sub BtnCambioDeEstado_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
        If cmbEstadosCambioEstado.Text = "" Then
            MsgBox("Porfavor ingrese un estado")
            Return
        End If

        For Each item As DataGridViewRow In DComprobantesBaja.Rows
            If Control.CambiarEstado(item.Cells("idAlta").Value, txtObsBajaCambioEstado.Text, ExtraerNumeros(cmbEstadosCambioEstado.Text), ExtraerNumeros(cmbCompaniaCambioEstado.Text)) = 0 Then
                MsgBox("Ocurrio un error")
                Return
            End If
        Next
        MsgBox("Se dio correctamente de baja")
        DComprobantesBaja.Rows.Clear()
        txtObsBajaCambioEstado.Text = ""
        frmConsultarComprobantes_Shown(sender, e)

    End Sub

    Private Sub txtImporteFiltro_Validated(sender As Object, e As EventArgs) Handles txtImporteFiltro.Validated
        If txtImporteFiltro.Text = "" Then
            txtImporteFiltro.Text = 0
        End If
    End Sub

#End Region

End Class