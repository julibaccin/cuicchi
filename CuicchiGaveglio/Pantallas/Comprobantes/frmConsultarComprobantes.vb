Imports System.Drawing
Imports System.Windows.Forms
Imports CapaDatos

Public Class frmConsultarComprobantes

    Dim Control As New ClsComprobantes()

    Private Sub FrmConsultarComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setearValoresCombo()
    End Sub

    Private Sub Cerrar_Form(sender As Object, e As EventArgs) Handles Me.Closed
        frmPrincipal.LlenarDatos()
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
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Respuesta = Control.ConsultarComprobantes(DComprobantes, ExtraerLetras(cmbTipoComprobanteFiltro.Text),
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

    Public Sub HabilitarDesabilitarCamposSegunTipoComprobante(pTipoComprobante As Integer)
        Dim tComprobante = ExtraerLetras(cmbTipoComprobante.Text)
        If tComprobante = "Efectivo" Then
            DFechaPago.Enabled = False
            txtNumero.Enabled = False
            cmbBanco.Enabled = False
            cmbCompania.Enabled = True
        ElseIf tComprobante = "Recibo" Then
            DFechaPago.Enabled = False
            txtNumero.Enabled = False
            cmbBanco.Enabled = False
            cmbCompania.Enabled = True
        ElseIf tComprobante = "Cheque" Then
            DFechaPago.Enabled = True
            txtNumero.Enabled = True
            cmbBanco.Enabled = True
            cmbCompania.Enabled = False
        ElseIf tComprobante = "Comprobante de Retencion" Then

        ElseIf tComprobante = "Transferencia" Then
            DFechaPago.Enabled = False
            txtNumero.Enabled = False
            cmbBanco.Enabled = True
            cmbCompania.Enabled = True
        End If
    End Sub


    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        SoloImporte(e)
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        SoloNumero(e)
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

    Private Sub txtImporteFiltro_Validated(sender As Object, e As EventArgs) Handles txtImporteFiltro.Validated
        If txtImporteFiltro.Text = "" Then
            txtImporteFiltro.Text = 0
        End If
    End Sub

    Private Sub BtnPreCargar_Click_1(sender As Object, e As EventArgs) Handles btnPreCargar.Click
        If cmbTipoComprobante.Text = "" Or cmbCliente.Text = "" Or txtImporte.Text = "" Then
            MsgBox("Ingrese los campos obligatorios (estan marcados con asterisco)")
            Return
        End If

        Dim tComp = ExtraerNumeros(cmbTipoComprobante.Text)

        If tComp = 1 And (cmbCompania.Text = "") Then
            MsgBox("Falta Ingresar Compañia")
            Return
        ElseIf tComp = 2 And (cmbBanco.Text = "" Or cmbCompania.Text = "") Then
            MsgBox("Falta Ingresar Banco o Compañia")
            Return
        ElseIf tComp = 3 And (txtNumero.Text = "" Or cmbBanco.Text = "") Then
            MsgBox("Falta Ingresar Numero o Banco")
            Return
        ElseIf tComp = 4 And (cmbCompania.Text = "") Then
            MsgBox("Falta Ingresar Compañia")
            Return
        ElseIf tComp = 5 Then
        End If

        Dim listaCombos As New List(Of ComboBox)
        With listaCombos
            .Add(cmbBanco)
            .Add(cmbCompania)
            .Add(cmbCliente)
            .Add(cmbTipoComprobante)
        End With

        If ComprobarSiValorExisteCombo(listaCombos) = 0 Then
            MsgBox("Uno de los combos tiene un valor inexistente")
            Return
        End If

        DPreviaACargar.Rows.Add(cmbTipoComprobante.Text, DFechaIngreso.Value,
                                cmbCliente.Text, cmbCompania.Text, txtImporte.Text,
                                txtNumero.Text, DFechaPago.Value,
                                cmbBanco.Text, txtObservaciones.Text)
        LimpiarCampos()

    End Sub

    Private Sub BtnCargar_Click_1(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim Respuesta As Int16
        If DPreviaACargar.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DPreviaACargar.Rows
                Dim objAlta As New ModeloComprobante
                With objAlta
                    .idTipoComprobante = ExtraerNumeros(Fila.Cells("tipoComprobante").Value)
                    .FIngreso = Fila.Cells("fIngreso").Value
                    .idCliente = ExtraerNumeros(Fila.Cells("Cliente").Value)
                    .IdCompania = If(ExtraerNumeros(Fila.Cells("Compania").Value), 0)
                    .Importe = Fila.Cells("importe").Value
                    .Numero = If(Fila.Cells("numero").Value, "")
                    .FPago = Fila.Cells("fpago").Value
                    .IdBanco = If(ExtraerNumeros(Fila.Cells("Banco").Value), 0)
                    .Obs = If(Fila.Cells("obs").Value, "")
                    .idUsuario = frmLogin.idUsuario
                    .idEstado = 1
                    .idEstadoOperacion = 1
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

    Private Sub BtnCambiarEstado_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
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

    Private Sub DComprobantesBaja_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DComprobantesBaja.CellMouseClick
        EliminarFilaDataGridClickDerecho(e, DComprobantesBaja)
    End Sub

    Private Sub DPreviaACargar_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DPreviaACargar.CellMouseClick
        EliminarFilaDataGridClickDerecho(e, DPreviaACargar)
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
        With DPreviaACargar
            cmbTipoComprobante.Text = .Item("TipoComprobante", e.RowIndex).Value
            cmbCliente.Text = .Item("Cliente", e.RowIndex).Value()
            txtImporte.Text = .Item("Importe", e.RowIndex).Value()
            cmbTipoComprobante.Focus()
        End With
    End Sub
End Class