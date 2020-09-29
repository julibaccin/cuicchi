Imports System.Windows.Forms

Public Class FrmConsultarPlanillas

    Dim Control As New ClsPlanillas
    Dim Control2 As New ClsComprobantes
    Private Sub FrmConsultarPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboClientes(cmbCliente)
        DFechaPlanillaNueva.Visible = False
    End Sub

    Private Sub CmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        cmbFechaPlanillas.Items.Clear()
        cmbFechaPlanillas.Items.Add("Nueva Planilla")
        Dim respuesta As ArrayList = Control.DevolverPlanillasCliente(ExtraerNumeros(cmbCliente.Text))
        For Each element As Date In respuesta
            cmbFechaPlanillas.Items.Add(element.ToShortDateString)
        Next
        Control2.ConsultarAltaComprobantes(DAltasComprobantes, "", "2020-01-01", "2080-01-01", "", "", "2020-01-01", -999999, ExtraerLetras(cmbCliente.Text), "", "")

        'ACA MIRO SI TIENE SALDO
        Dim ControlSaldo As New ClsSaldos()
        ControlSaldo.DevolverCuentaCliente(DDetalle, ExtraerNumeros(cmbCliente.Text))

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


    'INSERTAR

    Private Sub BtnCargarPlanillaNueva_Click(sender As Object, e As EventArgs) Handles btnCargarPlanillaNueva.Click
        If cmbCliente.Text = "" Then
            MsgBox("Debe ingresar un cliente valido")
            Return
        End If

        Dim resul As MsgBoxResult = MsgBox("Está por cargar una planilla del cliente: " & ExtraerLetras(cmbCliente.Text) & " a la fecha de: " & DFechaPlanillaNueva.Value, MsgBoxStyle.OkCancel)
        If resul <> 1 Then
            Return
        End If

        If Control.CrearPlanilla(ExtraerNumeros(cmbCliente.Text), DFechaPlanillaNueva.Value, frmLogin.idUsuario) = 0 Then
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
        arrayList = Control.DevolverPagosDePoliza(ExtraerNumeros(cmbCliente.Text), cmbFechaPlanillas.Text,
                                      txtPoliza.Text)
        For Each i As String In arrayList
            DPolizasPagos.Rows.Add(i)
        Next
    End Sub

    Private Sub BtnCargarPagosPoliza_Click(sender As Object, e As EventArgs) Handles btnCargarPagosPoliza.Click
        Dim Cliente As Integer = ExtraerNumeros(cmbCliente.Text)
        Dim Fecha As Date = cmbFechaPlanillas.Text
        If Control.AgregarPagoAPoliza(Cliente, Fecha, txtPoliza.Text, txtIdAlta.Text, txtImporteAlta.Text) = 1 Then
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
        Control.DevolverPolizasDePlanilla(DataPlanillasPolizas,
                                          ExtraerNumeros(cmbCliente.Text),
                                          cmbFechaPlanillas.Text)
    End Sub

    Private Sub DAltasComprobantes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DAltasComprobantes.CellContentDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        txtIdAlta.Text = DAltasComprobantes.Item("idAlta", e.RowIndex).Value
    End Sub


    Private Sub BtnCargarPolizas_Click(sender As Object, e As EventArgs) Handles btnCargarPolizas.Click
        Dim Cliente As Integer = ExtraerNumeros(cmbCliente.Text)
        Dim Fecha As Date
        If cmbFechaPlanillas.Text = "Nueva Planilla" Then
            Fecha = "2020-01-01"
        Else
            Fecha = cmbFechaPlanillas.Text
        End If
        For i = 0 To DataPlanillasPolizas.Rows.Count - 2
            Dim Row As DataGridViewRow = DataPlanillasPolizas.Rows(i)

            Control.AgregarPolizaAPlanilla(Cliente, Fecha,
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

    Private Sub BtnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click

    End Sub

    Private Sub FrmConsultarPlanillas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ReiniciarForm()
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
    End Sub

End Class