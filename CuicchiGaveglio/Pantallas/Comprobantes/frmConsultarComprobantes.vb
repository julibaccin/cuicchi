Imports System.Drawing
Imports System.Windows.Forms
Imports CapaDatos

Public Class FrmConsultarComprobantes
    ReadOnly Control As New ClsComprobantes()
    Private Sub FrmConsultarComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetearValoresCombo()
    End Sub
    Private Sub Cerrar_Form(sender As Object, e As EventArgs) Handles Me.Closed
        FrmPrincipal.LlenarDatos()
    End Sub
    Public Sub SetearValoresCombo()
        txtImporteFiltro.Text = "0"
        txtTotalBaja.Text = "0"
        DFIngresoHastaFiltro.Value = New Date(2099, 1, 1)
        DFIngresoDesdeFiltro.Value = New Date(2000, 1, 1)
        DFechaIngreso.Value = Date.Now()
        DFechaPago.Value = Date.Now()
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
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Respuesta = Control.ConsultarComprobantes(DComprobantes, ExtraerLetras(cmbTipoComprobanteFiltro.Text),
                                                          FormatearFecha(DFIngresoDesdeFiltro.Value),
                                                          FormatearFecha(DFIngresoHastaFiltro.Value),
                                                          txtNumeroFiltro.Text, ExtraerLetras(cmbUsuarioFiltro.Text),
                                                          FormatearFecha(Date.Now()),
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
                ' Si el Cheque/Transferencia/Comprobante/Echeq de Retencion están en cartera
            ElseIf (fila.Cells.Item("Tipo_Comprobante").Value = "Cheque" _
                    Or fila.Cells.Item("Tipo_Comprobante").Value = "ECheq" _
                Or fila.Cells.Item("Tipo_Comprobante").Value = "Transferencia") _
                And (fila.Cells.Item("Estado").Value <> "En Cartera" And
                fila.Cells.Item("Estado").Value <> "Rechazado") Then
                fila.DefaultCellStyle.BackColor = Color.LightSalmon
                ' Si el cheque está rechazado/Echeq
            ElseIf (fila.Cells.Item("Tipo_Comprobante").Value = "Cheque" And
                    fila.Cells.Item("Tipo_Comprobante").Value = "ECheq") Or
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
            txtTotalBaja.Text = CDbl(txtTotalBaja.Text) - CDbl(DComprobantesBaja.Item("Importe", e.RowIndex).Value)
            DComprobantesBaja.Rows.Remove(DComprobantesBaja.Rows(e.RowIndex))
        End If

    End Sub
    Private Sub DComprobantes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DComprobantes.CellDoubleClick
        'Aca van a ir las validaciones de que si se encuentra entre los 3 comprobantes y esta
        'en un estado que se pueda dar de baja
        If e.RowIndex = -1 Then
            Return
        End If

        If DComprobantes.Item("Tipo_Comprobante", e.RowIndex).Value = "Cheque" _
           Or DComprobantes.Item("Tipo_Comprobante", e.RowIndex).Value = "ECheq" _
           Or DComprobantes.Item("Tipo_Comprobante", e.RowIndex).Value = "Transferencia" _
           Or DComprobantes.Item("Tipo_Comprobante", e.RowIndex).Value = "Comprobante de Retencion" Then
            CopiarFila(e.RowIndex)
            txtTotalBaja.Text = CDbl(txtTotalBaja.Text) + CDbl(DComprobantes.Item("Importe", e.RowIndex).Value)
        End If
    End Sub
    Public Sub LimpiarCampos()
        txtImporte.Text = ""
        txtNumero.Text = ""
        cmbBanco.Text = ""
        cmbTipoComprobante.Text = ""
        cmbCompania.Text = ""
        cmbTipoComprobante.Focus()
        cmbBanco.Enabled = True
        cmbCompania.Enabled = True
        txtNumero.Enabled = True
        DFechaPago.Enabled = True
    End Sub
    Public Sub HabilitarDesabilitarCamposSegunTipoComprobante()
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
        ElseIf tComprobante = "ECheq" Then
            DFechaPago.Visible = True
            txtNumero.Visible = True
            cmbBanco.Visible = True
            cmbCompania.Visible = True
        ElseIf tComprobante = "Comprobante de Retencion" Then

        ElseIf tComprobante = "Transferencia" Then
            DFechaPago.Visible = True
            txtNumero.Visible = True
            cmbBanco.Visible = True
            cmbCompania.Visible = True
        End If
    End Sub
    Private Sub TxtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        SoloImporte(e)
    End Sub
    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        SoloNumero(e)
    End Sub
    Private Sub CmbTipoComprobante_Validated(sender As Object, e As EventArgs) Handles cmbTipoComprobante.Validated
        If (ExtraerNumeros(cmbTipoComprobante.Text) >= 1 And ExtraerNumeros(cmbTipoComprobante.Text)) <= 6 Or cmbTipoComprobante.Text = "" Then
        Else
            MsgBox("Ingresó un Tipo de Comprobante inexistente")
            cmbTipoComprobante.Text = ""
            cmbTipoComprobante.Focus()
        End If

        HabilitarDesabilitarCamposSegunTipoComprobante()

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
    Private Sub FrmConsultarComprobantes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        BtnBuscar_Click(sender, e)
        CopiarHeader()
    End Sub
    Private Sub TxtImporteFiltro_Validated(sender As Object, e As EventArgs)
        If txtImporteFiltro.Text = "" Then
            txtImporteFiltro.Text = 0
        End If
    End Sub
    Private Sub BtnPreCargar_Click_1(sender As Object, e As EventArgs) Handles btnPreCargar.Click
        If cmbTipoComprobante.Text = "" Or cmbCliente.Text = "" Or txtImporte.Text = "" Then
            MsgBox("Ingrese los campos obligatorios")
            Return
        End If

        Dim tComp = ExtraerNumeros(cmbTipoComprobante.Text)

        If tComp = 1 And (cmbCliente.Text = "") Then 'EFECTIVO
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

        DPreviaACargar.Rows.Add(cmbTipoComprobante.Text, FormatearFecha(DFechaIngreso.Value),
                                cmbCliente.Text,
                                IIf(cmbCompania.Text <> "", cmbCompania.Text, 0),
                                txtImporte.Text,
                                IIf(txtNumero.Visible, txtNumero.Text, ""),
                                IIf(DFechaPago.Visible, FormatearFecha(DFechaPago.Value), 0),
                                IIf(cmbBanco.Visible, ExtraerNumeros(cmbBanco.Text), 0),
                                txtObservaciones.Text)
        'Manejar el total de la precarga
        If tComp <> 4 Then
            If txtTotalPrecarga.Text = "" Then
                txtTotalPrecarga.Text = CDbl(txtImporte.Text)
            Else
                txtTotalPrecarga.Text = CDbl(txtTotalPrecarga.Text) + CDbl(txtImporte.Text)
            End If
        Else
            If txtTotalPrecargaRecibos.Text = "" Then
                txtTotalPrecargaRecibos.Text = CDbl(txtImporte.Text)
            Else
                txtTotalPrecargaRecibos.Text = CDbl(txtTotalPrecargaRecibos.Text) + CDbl(txtImporte.Text)
            End If
        End If

        LimpiarCampos()

    End Sub
    Private Sub BtnCargar_Click_1(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim Respuesta As Int16
        If DPreviaACargar.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DPreviaACargar.Rows
                Dim objAlta As New ModeloComprobante
                With objAlta
                    'SIEMPRE
                    .IdTipoComprobante = ExtraerNumeros(Fila.Cells("tipoComprobante").Value)
                    .FIngreso = Fila.Cells("fIngreso").Value
                    .IdCliente = ExtraerIdCliente(Fila.Cells("Cliente").Value)
                    .Importe = Fila.Cells("importe").Value
                    .IdEstado = 1
                    .IdUsuario = frmLogin.IdUsuario
                    .IdEstadoOperacion = 1
                    'NO SIEMPRE
                    .IdCompania = ExtraerNumeros(Fila.Cells("Compania").Value)
                    .Numero = Fila.Cells("numero").Value
                    .FPago = Fila.Cells("fpago").Value
                    .IdBanco = Fila.Cells("Banco").Value
                    .Obs = Fila.Cells("obs").Value
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
        txtTotalPrecarga.Text = ""
        txtTotalPrecargaRecibos.Text = ""
        LimpiarCampos()
        FrmConsultarComprobantes_Shown(sender, e)
    End Sub
    Private Sub BtnCambiarEstado_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
        If cmbEstadosCambioEstado.Text = "" Then
            MsgBox("Porfavor ingrese un estado")
            Return
        End If

        For Each item As DataGridViewRow In DComprobantesBaja.Rows
            If Control.CambiarEstado(
                                     item.Cells("idAlta").Value,
                                     txtObsBajaCambioEstado.Text,
                                     ExtraerNumeros(cmbEstadosCambioEstado.Text),
                                     ExtraerIdCliente(cmbCompaniaCambioEstado.Text),
                                     frmLogin.IdUsuario
                                     ) = 0 Then
                MsgBox("Ocurrio un error")
                Return
            End If
        Next
        MsgBox("Se dio correctamente de baja")
        DComprobantesBaja.Rows.Clear()
        txtObsBajaCambioEstado.Text = ""
        txtTotalBaja.Text = "0"
        FrmConsultarComprobantes_Shown(sender, e)
    End Sub
    Private Sub DComprobantesBaja_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DComprobantesBaja.CellMouseClick
        txtTotalBaja.Text = CDbl(txtTotalBaja.Text) - EliminarFilaDataGridClickDerecho(e, DComprobantesBaja)
    End Sub
    Private Sub DPreviaACargar_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DPreviaACargar.CellMouseClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim variable = DPreviaACargar.Rows(e.RowIndex).Cells(0).Value.Contains("4")
        Dim resp = EliminarFilaDataGridClickDerecho(e, DPreviaACargar)
        If variable = False Then
            If resp <> 0 Then txtTotalPrecarga.Text = txtTotalPrecarga.Text - resp
        Else
            If resp <> 0 Then txtTotalPrecargaRecibos.Text = txtTotalPrecargaRecibos.Text - resp
        End If
    End Sub
    Private Sub CmbBanco_KeyPress(sender As Object, e As EventArgs) Handles cmbBanco.KeyPress
        SoloNumero(e)
    End Sub
    Private Sub CmbTipoComprobante_KeyPress(sender As Object, e As EventArgs) Handles cmbTipoComprobante.KeyPress
        SoloNumero(e)
    End Sub
    Private Sub CmbEstadosCambioEstado_KeyPress(sender As Object, e As EventArgs) Handles cmbEstadosCambioEstado.KeyPress
        SoloNumero(e)
    End Sub
    Private Sub CmbCompaniaCambioEstado_KeyPress(sender As Object, e As EventArgs) Handles cmbCompaniaCambioEstado.KeyPress
        SoloLetra(e)
    End Sub
    Private Sub CmbCompania_keypress(sender As Object, e As EventArgs) Handles cmbCompania.KeyPress
        SoloLetra(e)
    End Sub
    Private Sub DPreviaACargar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DPreviaACargar.CellContentDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        With DPreviaACargar
            cmbTipoComprobante.Text = .Item("TipoComprobante", e.RowIndex).Value
            cmbCliente.Text = .Item("Cliente", e.RowIndex).Value()
            txtImporte.Text = .Item("Importe", e.RowIndex).Value()
            txtObservaciones.Text = .Item("Obs", e.RowIndex).Value()
            cmbTipoComprobante.Focus()
        End With
    End Sub
End Class