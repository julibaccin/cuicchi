﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanillas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cCopiarDatos = New System.Windows.Forms.CheckBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbFechaP = New System.Windows.Forms.ComboBox()
        Me.btnCargarPlanillaNueva = New System.Windows.Forms.Button()
        Me.DgPlanillaPolizas = New System.Windows.Forms.DataGridView()
        Me.cmbClienteP = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GrupoComprobantes = New System.Windows.Forms.GroupBox()
        Me.btnPreCargar = New System.Windows.Forms.Button()
        Me.btnCargaCompania = New System.Windows.Forms.Button()
        Me.cmbCompania = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.btnCargaBanco = New System.Windows.Forms.Button()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.DFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.DFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DPreviaACargar = New System.Windows.Forms.DataGridView()
        Me.tipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compania = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DFechaPlanillaNueva = New System.Windows.Forms.DateTimePicker()
        Me.btnCargarPolizas = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbRechazar = New System.Windows.Forms.RadioButton()
        Me.rbAceptar = New System.Windows.Forms.RadioButton()
        Me.btnCambioEstadoPlanilla = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldoCliente = New System.Windows.Forms.TextBox()
        CType(Me.DgPlanillaPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoComprobantes.SuspendLayout()
        CType(Me.DPreviaACargar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cCopiarDatos
        '
        Me.cCopiarDatos.AutoSize = True
        Me.cCopiarDatos.Location = New System.Drawing.Point(11, 95)
        Me.cCopiarDatos.Name = "cCopiarDatos"
        Me.cCopiarDatos.Size = New System.Drawing.Size(87, 17)
        Me.cCopiarDatos.TabIndex = 53
        Me.cCopiarDatos.Text = "Copiar Datos"
        Me.cCopiarDatos.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(490, 232)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 52
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Location = New System.Drawing.Point(860, 225)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(116, 23)
        Me.btnExportarExcel.TabIndex = 51
        Me.btnExportarExcel.Text = "EXPORTAR EXCEL"
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 45)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 13)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "FECHA PLANILLAS"
        '
        'cmbFechaP
        '
        Me.cmbFechaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFechaP.FormattingEnabled = True
        Me.cmbFechaP.Location = New System.Drawing.Point(11, 61)
        Me.cmbFechaP.Name = "cmbFechaP"
        Me.cmbFechaP.Size = New System.Drawing.Size(133, 28)
        Me.cmbFechaP.TabIndex = 47
        '
        'btnCargarPlanillaNueva
        '
        Me.btnCargarPlanillaNueva.Location = New System.Drawing.Point(11, 199)
        Me.btnCargarPlanillaNueva.Name = "btnCargarPlanillaNueva"
        Me.btnCargarPlanillaNueva.Size = New System.Drawing.Size(133, 22)
        Me.btnCargarPlanillaNueva.TabIndex = 45
        Me.btnCargarPlanillaNueva.Text = "Cargar Planilla Nueva"
        Me.btnCargarPlanillaNueva.UseVisualStyleBackColor = True
        '
        'DgPlanillaPolizas
        '
        Me.DgPlanillaPolizas.AllowUserToResizeColumns = False
        Me.DgPlanillaPolizas.AllowUserToResizeRows = False
        Me.DgPlanillaPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPlanillaPolizas.Location = New System.Drawing.Point(150, 38)
        Me.DgPlanillaPolizas.Name = "DgPlanillaPolizas"
        Me.DgPlanillaPolizas.Size = New System.Drawing.Size(826, 183)
        Me.DgPlanillaPolizas.TabIndex = 43
        '
        'cmbClienteP
        '
        Me.cmbClienteP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClienteP.FormattingEnabled = True
        Me.cmbClienteP.Location = New System.Drawing.Point(66, 4)
        Me.cmbClienteP.Name = "cmbClienteP"
        Me.cmbClienteP.Size = New System.Drawing.Size(200, 28)
        Me.cmbClienteP.TabIndex = 42
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 12)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 13)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "CLIENTE"
        '
        'GrupoComprobantes
        '
        Me.GrupoComprobantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrupoComprobantes.Controls.Add(Me.btnPreCargar)
        Me.GrupoComprobantes.Controls.Add(Me.btnCargaCompania)
        Me.GrupoComprobantes.Controls.Add(Me.cmbCompania)
        Me.GrupoComprobantes.Controls.Add(Me.Label4)
        Me.GrupoComprobantes.Controls.Add(Me.cmbTipoComprobante)
        Me.GrupoComprobantes.Controls.Add(Me.btnCargaBanco)
        Me.GrupoComprobantes.Controls.Add(Me.cmbBanco)
        Me.GrupoComprobantes.Controls.Add(Me.txtObservaciones)
        Me.GrupoComprobantes.Controls.Add(Me.txtNumero)
        Me.GrupoComprobantes.Controls.Add(Me.txtImporte)
        Me.GrupoComprobantes.Controls.Add(Me.DFechaPago)
        Me.GrupoComprobantes.Controls.Add(Me.DFechaIngreso)
        Me.GrupoComprobantes.Controls.Add(Me.Label10)
        Me.GrupoComprobantes.Controls.Add(Me.Label8)
        Me.GrupoComprobantes.Controls.Add(Me.Label7)
        Me.GrupoComprobantes.Controls.Add(Me.btnCargar)
        Me.GrupoComprobantes.Controls.Add(Me.Label6)
        Me.GrupoComprobantes.Controls.Add(Me.Label3)
        Me.GrupoComprobantes.Controls.Add(Me.Label9)
        Me.GrupoComprobantes.Controls.Add(Me.DPreviaACargar)
        Me.GrupoComprobantes.Controls.Add(Me.Label12)
        Me.GrupoComprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoComprobantes.Location = New System.Drawing.Point(12, 259)
        Me.GrupoComprobantes.Name = "GrupoComprobantes"
        Me.GrupoComprobantes.Size = New System.Drawing.Size(1100, 261)
        Me.GrupoComprobantes.TabIndex = 54
        Me.GrupoComprobantes.TabStop = False
        Me.GrupoComprobantes.Text = "Ingrese un comprobante"
        '
        'btnPreCargar
        '
        Me.btnPreCargar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPreCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreCargar.Location = New System.Drawing.Point(337, 151)
        Me.btnPreCargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreCargar.Name = "btnPreCargar"
        Me.btnPreCargar.Size = New System.Drawing.Size(104, 31)
        Me.btnPreCargar.TabIndex = 50
        Me.btnPreCargar.Text = "Pre Cargar"
        Me.btnPreCargar.UseVisualStyleBackColor = False
        '
        'btnCargaCompania
        '
        Me.btnCargaCompania.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaCompania.Location = New System.Drawing.Point(88, 169)
        Me.btnCargaCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargaCompania.Name = "btnCargaCompania"
        Me.btnCargaCompania.Size = New System.Drawing.Size(25, 24)
        Me.btnCargaCompania.TabIndex = 47
        Me.btnCargaCompania.Text = "+"
        Me.btnCargaCompania.UseVisualStyleBackColor = False
        '
        'cmbCompania
        '
        Me.cmbCompania.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.FormattingEnabled = True
        Me.cmbCompania.Location = New System.Drawing.Point(357, 102)
        Me.cmbCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(128, 26)
        Me.cmbCompania.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(259, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Compañia"
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoComprobante.FormattingEnabled = True
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(126, 28)
        Me.cmbTipoComprobante.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(128, 26)
        Me.cmbTipoComprobante.TabIndex = 28
        '
        'btnCargaBanco
        '
        Me.btnCargaBanco.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaBanco.Location = New System.Drawing.Point(88, 140)
        Me.btnCargaBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargaBanco.Name = "btnCargaBanco"
        Me.btnCargaBanco.Size = New System.Drawing.Size(27, 26)
        Me.btnCargaBanco.TabIndex = 45
        Me.btnCargaBanco.Text = "+"
        Me.btnCargaBanco.UseVisualStyleBackColor = False
        '
        'cmbBanco
        '
        Me.cmbBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(126, 138)
        Me.cmbBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(128, 26)
        Me.cmbBanco.TabIndex = 41
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(126, 65)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(128, 38)
        Me.txtObservaciones.TabIndex = 42
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(126, 169)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(128, 24)
        Me.txtNumero.TabIndex = 38
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(357, 62)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(128, 24)
        Me.txtImporte.TabIndex = 36
        '
        'DFechaPago
        '
        Me.DFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaPago.Location = New System.Drawing.Point(126, 111)
        Me.DFechaPago.Margin = New System.Windows.Forms.Padding(4)
        Me.DFechaPago.Name = "DFechaPago"
        Me.DFechaPago.Size = New System.Drawing.Size(128, 24)
        Me.DFechaPago.TabIndex = 39
        Me.DFechaPago.Value = New Date(2020, 8, 12, 11, 49, 20, 0)
        '
        'DFechaIngreso
        '
        Me.DFechaIngreso.CustomFormat = ""
        Me.DFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaIngreso.Location = New System.Drawing.Point(357, 25)
        Me.DFechaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.DFechaIngreso.Name = "DFechaIngreso"
        Me.DFechaIngreso.Size = New System.Drawing.Size(128, 24)
        Me.DFechaIngreso.TabIndex = 31
        Me.DFechaIngreso.Value = New Date(2020, 8, 12, 11, 49, 20, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 79)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Observaciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 36)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Tipo Comprobante *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(262, 72)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Importe *"
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(930, 209)
        Me.btnCargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(153, 31)
        Me.btnCargar.TabIndex = 50
        Me.btnCargar.Text = "Cargar Comprobantes"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha Pago"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 150)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Banco"
        '
        'DPreviaACargar
        '
        Me.DPreviaACargar.AllowUserToAddRows = False
        Me.DPreviaACargar.AllowUserToDeleteRows = False
        Me.DPreviaACargar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DPreviaACargar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DPreviaACargar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipoComprobante, Me.FIngreso, Me.Cliente, Me.Compania, Me.importe, Me.numero, Me.FPago, Me.Banco, Me.Obs})
        Me.DPreviaACargar.Location = New System.Drawing.Point(502, 23)
        Me.DPreviaACargar.Name = "DPreviaACargar"
        Me.DPreviaACargar.Size = New System.Drawing.Size(581, 181)
        Me.DPreviaACargar.TabIndex = 49
        '
        'tipoComprobante
        '
        Me.tipoComprobante.HeaderText = "Comprobante"
        Me.tipoComprobante.Name = "tipoComprobante"
        Me.tipoComprobante.ReadOnly = True
        Me.tipoComprobante.Width = 135
        '
        'FIngreso
        '
        Me.FIngreso.HeaderText = "F. Ingreso"
        Me.FIngreso.Name = "FIngreso"
        Me.FIngreso.ReadOnly = True
        Me.FIngreso.Width = 109
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Clientes"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 94
        '
        'Compania
        '
        Me.Compania.HeaderText = "Compañia"
        Me.Compania.Name = "Compania"
        Me.Compania.ReadOnly = True
        Me.Compania.Width = 109
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 90
        '
        'numero
        '
        Me.numero.HeaderText = "Numero"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 93
        '
        'FPago
        '
        Me.FPago.HeaderText = "F. Pago"
        Me.FPago.Name = "FPago"
        Me.FPago.ReadOnly = True
        Me.FPago.Width = 92
        '
        'Banco
        '
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.ReadOnly = True
        Me.Banco.Width = 81
        '
        'Obs
        '
        Me.Obs.HeaderText = "Obs"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Width = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(262, 33)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Fecha Ingreso"
        '
        'DFechaPlanillaNueva
        '
        Me.DFechaPlanillaNueva.CustomFormat = ""
        Me.DFechaPlanillaNueva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaPlanillaNueva.Location = New System.Drawing.Point(11, 172)
        Me.DFechaPlanillaNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.DFechaPlanillaNueva.Name = "DFechaPlanillaNueva"
        Me.DFechaPlanillaNueva.Size = New System.Drawing.Size(99, 20)
        Me.DFechaPlanillaNueva.TabIndex = 55
        Me.DFechaPlanillaNueva.Value = New Date(2020, 8, 12, 11, 49, 20, 0)
        '
        'btnCargarPolizas
        '
        Me.btnCargarPolizas.Location = New System.Drawing.Point(185, 229)
        Me.btnCargarPolizas.Name = "btnCargarPolizas"
        Me.btnCargarPolizas.Size = New System.Drawing.Size(117, 22)
        Me.btnCargarPolizas.TabIndex = 56
        Me.btnCargarPolizas.Text = "Cargar Polizas"
        Me.btnCargarPolizas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRechazar)
        Me.GroupBox1.Controls.Add(Me.rbAceptar)
        Me.GroupBox1.Controls.Add(Me.btnCambioEstadoPlanilla)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(982, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 191)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Planilla"
        '
        'rbRechazar
        '
        Me.rbRechazar.AutoSize = True
        Me.rbRechazar.Location = New System.Drawing.Point(9, 128)
        Me.rbRechazar.Name = "rbRechazar"
        Me.rbRechazar.Size = New System.Drawing.Size(84, 17)
        Me.rbRechazar.TabIndex = 64
        Me.rbRechazar.TabStop = True
        Me.rbRechazar.Text = "RECHAZAR"
        Me.rbRechazar.UseVisualStyleBackColor = True
        '
        'rbAceptar
        '
        Me.rbAceptar.AutoSize = True
        Me.rbAceptar.Location = New System.Drawing.Point(9, 105)
        Me.rbAceptar.Name = "rbAceptar"
        Me.rbAceptar.Size = New System.Drawing.Size(75, 17)
        Me.rbAceptar.TabIndex = 63
        Me.rbAceptar.TabStop = True
        Me.rbAceptar.Text = "ACEPTAR"
        Me.rbAceptar.UseVisualStyleBackColor = True
        '
        'btnCambioEstadoPlanilla
        '
        Me.btnCambioEstadoPlanilla.Location = New System.Drawing.Point(9, 162)
        Me.btnCambioEstadoPlanilla.Name = "btnCambioEstadoPlanilla"
        Me.btnCambioEstadoPlanilla.Size = New System.Drawing.Size(111, 23)
        Me.btnCambioEstadoPlanilla.TabIndex = 62
        Me.btnCambioEstadoPlanilla.Text = "CAMBIAR ESTADO"
        Me.btnCambioEstadoPlanilla.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(69, 58)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(73, 20)
        Me.txtTotal.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Total:"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(69, 24)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(73, 20)
        Me.txtEstado.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Situación Cliente:"
        '
        'txtSaldoCliente
        '
        Me.txtSaldoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSaldoCliente.Enabled = False
        Me.txtSaldoCliente.ForeColor = System.Drawing.Color.Black
        Me.txtSaldoCliente.Location = New System.Drawing.Point(440, 227)
        Me.txtSaldoCliente.Name = "txtSaldoCliente"
        Me.txtSaldoCliente.Size = New System.Drawing.Size(195, 20)
        Me.txtSaldoCliente.TabIndex = 58
        '
        'frmPlanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 532)
        Me.Controls.Add(Me.txtSaldoCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCargarPolizas)
        Me.Controls.Add(Me.DFechaPlanillaNueva)
        Me.Controls.Add(Me.GrupoComprobantes)
        Me.Controls.Add(Me.cCopiarDatos)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmbFechaP)
        Me.Controls.Add(Me.btnCargarPlanillaNueva)
        Me.Controls.Add(Me.DgPlanillaPolizas)
        Me.Controls.Add(Me.cmbClienteP)
        Me.Controls.Add(Me.Label25)
        Me.Name = "frmPlanillas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPlanillas"
        CType(Me.DgPlanillaPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoComprobantes.ResumeLayout(False)
        Me.GrupoComprobantes.PerformLayout()
        CType(Me.DPreviaACargar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cCopiarDatos As Windows.Forms.CheckBox
    Friend WithEvents lblTotal As Windows.Forms.Label
    Friend WithEvents btnExportarExcel As Windows.Forms.Button
    Friend WithEvents Label24 As Windows.Forms.Label
    Friend WithEvents cmbFechaP As Windows.Forms.ComboBox
    Friend WithEvents btnCargarPlanillaNueva As Windows.Forms.Button
    Friend WithEvents DgPlanillaPolizas As Windows.Forms.DataGridView
    Friend WithEvents cmbClienteP As Windows.Forms.ComboBox
    Friend WithEvents Label25 As Windows.Forms.Label
    Friend WithEvents GrupoComprobantes As Windows.Forms.GroupBox
    Friend WithEvents btnPreCargar As Windows.Forms.Button
    Friend WithEvents btnCargaCompania As Windows.Forms.Button
    Friend WithEvents cmbCompania As Windows.Forms.ComboBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents cmbTipoComprobante As Windows.Forms.ComboBox
    Friend WithEvents btnCargaBanco As Windows.Forms.Button
    Friend WithEvents cmbBanco As Windows.Forms.ComboBox
    Friend WithEvents txtObservaciones As Windows.Forms.TextBox
    Friend WithEvents txtNumero As Windows.Forms.TextBox
    Friend WithEvents txtImporte As Windows.Forms.TextBox
    Friend WithEvents DFechaPago As Windows.Forms.DateTimePicker
    Friend WithEvents DFechaIngreso As Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents btnCargar As Windows.Forms.Button
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents DPreviaACargar As Windows.Forms.DataGridView
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents DFechaPlanillaNueva As Windows.Forms.DateTimePicker
    Friend WithEvents btnCargarPolizas As Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents txtTotal As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtEstado As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtSaldoCliente As Windows.Forms.TextBox
    Friend WithEvents btnCambioEstadoPlanilla As Windows.Forms.Button
    Friend WithEvents rbRechazar As Windows.Forms.RadioButton
    Friend WithEvents rbAceptar As Windows.Forms.RadioButton
    Friend WithEvents tipoComprobante As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIngreso As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compania As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPago As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Banco As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Obs As Windows.Forms.DataGridViewTextBoxColumn
End Class