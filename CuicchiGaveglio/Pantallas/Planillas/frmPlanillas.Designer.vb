<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPlanillas
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnPreCargar = New System.Windows.Forms.Button()
        Me.DPreviaACargar = New System.Windows.Forms.DataGridView()
        Me.DFechaPlanillaNueva = New System.Windows.Forms.DateTimePicker()
        Me.btnCargarPolizas = New System.Windows.Forms.Button()
        Me.GDatos = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.rbRechazar = New System.Windows.Forms.RadioButton()
        Me.rbAceptar = New System.Windows.Forms.RadioButton()
        Me.txtSaldoCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCambioEstadoPlanilla = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdPlanilla = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalPlanilla = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotalPlanillaPagos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCargar = New System.Windows.Forms.Button()
        CType(Me.DgPlanillaPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DPreviaACargar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cCopiarDatos
        '
        Me.cCopiarDatos.AutoSize = True
        Me.cCopiarDatos.Location = New System.Drawing.Point(315, 33)
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
        Me.btnExportarExcel.Location = New System.Drawing.Point(811, 53)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(53, 23)
        Me.btnExportarExcel.TabIndex = 51
        Me.btnExportarExcel.Text = "EXCEL"
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(167, 5)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 13)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "FECHA PLANILLAS"
        '
        'cmbFechaP
        '
        Me.cmbFechaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFechaP.FormattingEnabled = True
        Me.cmbFechaP.Location = New System.Drawing.Point(167, 26)
        Me.cmbFechaP.Name = "cmbFechaP"
        Me.cmbFechaP.Size = New System.Drawing.Size(133, 28)
        Me.cmbFechaP.TabIndex = 47
        '
        'btnCargarPlanillaNueva
        '
        Me.btnCargarPlanillaNueva.Location = New System.Drawing.Point(873, 26)
        Me.btnCargarPlanillaNueva.Name = "btnCargarPlanillaNueva"
        Me.btnCargarPlanillaNueva.Size = New System.Drawing.Size(133, 29)
        Me.btnCargarPlanillaNueva.TabIndex = 45
        Me.btnCargarPlanillaNueva.Text = "Cargar Planilla Nueva"
        Me.btnCargarPlanillaNueva.UseVisualStyleBackColor = True
        '
        'DgPlanillaPolizas
        '
        Me.DgPlanillaPolizas.AllowUserToResizeColumns = False
        Me.DgPlanillaPolizas.AllowUserToResizeRows = False
        Me.DgPlanillaPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPlanillaPolizas.Location = New System.Drawing.Point(7, 36)
        Me.DgPlanillaPolizas.Name = "DgPlanillaPolizas"
        Me.DgPlanillaPolizas.Size = New System.Drawing.Size(893, 203)
        Me.DgPlanillaPolizas.TabIndex = 43
        '
        'cmbClienteP
        '
        Me.cmbClienteP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClienteP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClienteP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClienteP.FormattingEnabled = True
        Me.cmbClienteP.Location = New System.Drawing.Point(18, 26)
        Me.cmbClienteP.Name = "cmbClienteP"
        Me.cmbClienteP.Size = New System.Drawing.Size(134, 28)
        Me.cmbClienteP.TabIndex = 42
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(19, 5)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 13)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "CLIENTE"
        '
        'btnCargaCompania
        '
        Me.btnCargaCompania.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaCompania.Location = New System.Drawing.Point(1015, 409)
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
        Me.cmbCompania.Location = New System.Drawing.Point(1048, 525)
        Me.cmbCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(128, 21)
        Me.cmbCompania.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(913, 535)
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
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(1048, 353)
        Me.cmbTipoComprobante.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(128, 21)
        Me.cmbTipoComprobante.TabIndex = 30
        '
        'btnCargaBanco
        '
        Me.btnCargaBanco.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaBanco.Location = New System.Drawing.Point(1015, 466)
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
        Me.cmbBanco.Location = New System.Drawing.Point(1048, 466)
        Me.cmbBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(128, 21)
        Me.cmbBanco.TabIndex = 34
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(1048, 494)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(128, 30)
        Me.txtObservaciones.TabIndex = 35
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(1048, 409)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(128, 20)
        Me.txtNumero.TabIndex = 32
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(1048, 383)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(128, 20)
        Me.txtImporte.TabIndex = 31
        '
        'DFechaPago
        '
        Me.DFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaPago.Location = New System.Drawing.Point(1048, 437)
        Me.DFechaPago.Margin = New System.Windows.Forms.Padding(4)
        Me.DFechaPago.Name = "DFechaPago"
        Me.DFechaPago.Size = New System.Drawing.Size(128, 20)
        Me.DFechaPago.TabIndex = 33
        Me.DFechaPago.Value = New Date(2020, 8, 12, 11, 49, 20, 0)
        '
        'DFechaIngreso
        '
        Me.DFechaIngreso.CustomFormat = ""
        Me.DFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaIngreso.Location = New System.Drawing.Point(1048, 553)
        Me.DFechaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.DFechaIngreso.Name = "DFechaIngreso"
        Me.DFechaIngreso.Size = New System.Drawing.Size(128, 20)
        Me.DFechaIngreso.TabIndex = 37
        Me.DFechaIngreso.Value = New Date(2020, 8, 12, 11, 49, 20, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(911, 508)
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
        Me.Label8.Location = New System.Drawing.Point(911, 363)
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
        Me.Label7.Location = New System.Drawing.Point(911, 393)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Importe *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(911, 417)
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
        Me.Label3.Location = New System.Drawing.Point(911, 445)
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
        Me.Label9.Location = New System.Drawing.Point(911, 476)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Banco"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(913, 561)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Fecha Ingreso"
        '
        'btnPreCargar
        '
        Me.btnPreCargar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPreCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreCargar.Location = New System.Drawing.Point(1048, 299)
        Me.btnPreCargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreCargar.Name = "btnPreCargar"
        Me.btnPreCargar.Size = New System.Drawing.Size(126, 27)
        Me.btnPreCargar.TabIndex = 50
        Me.btnPreCargar.Text = "Pre Cargar"
        Me.btnPreCargar.UseVisualStyleBackColor = False
        '
        'DPreviaACargar
        '
        Me.DPreviaACargar.AllowUserToAddRows = False
        Me.DPreviaACargar.AllowUserToDeleteRows = False
        Me.DPreviaACargar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DPreviaACargar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DPreviaACargar.Location = New System.Drawing.Point(7, 279)
        Me.DPreviaACargar.Name = "DPreviaACargar"
        Me.DPreviaACargar.ReadOnly = True
        Me.DPreviaACargar.Size = New System.Drawing.Size(893, 299)
        Me.DPreviaACargar.TabIndex = 49
        '
        'DFechaPlanillaNueva
        '
        Me.DFechaPlanillaNueva.CustomFormat = ""
        Me.DFechaPlanillaNueva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaPlanillaNueva.Location = New System.Drawing.Point(1015, 34)
        Me.DFechaPlanillaNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.DFechaPlanillaNueva.Name = "DFechaPlanillaNueva"
        Me.DFechaPlanillaNueva.Size = New System.Drawing.Size(99, 20)
        Me.DFechaPlanillaNueva.TabIndex = 55
        Me.DFechaPlanillaNueva.Value = New Date(2020, 8, 12, 11, 49, 20, 0)
        '
        'btnCargarPolizas
        '
        Me.btnCargarPolizas.Location = New System.Drawing.Point(150, 12)
        Me.btnCargarPolizas.Name = "btnCargarPolizas"
        Me.btnCargarPolizas.Size = New System.Drawing.Size(115, 23)
        Me.btnCargarPolizas.TabIndex = 56
        Me.btnCargarPolizas.Text = "Confirmar Recibos"
        Me.btnCargarPolizas.UseVisualStyleBackColor = True
        '
        'GDatos
        '
        Me.GDatos.Controls.Add(Me.btnExportarExcel)
        Me.GDatos.Controls.Add(Me.Button1)
        Me.GDatos.Controls.Add(Me.Label19)
        Me.GDatos.Controls.Add(Me.rbRechazar)
        Me.GDatos.Controls.Add(Me.rbAceptar)
        Me.GDatos.Controls.Add(Me.txtSaldoCliente)
        Me.GDatos.Controls.Add(Me.Label2)
        Me.GDatos.Controls.Add(Me.btnCambioEstadoPlanilla)
        Me.GDatos.Controls.Add(Me.txtTotal)
        Me.GDatos.Controls.Add(Me.Label5)
        Me.GDatos.Controls.Add(Me.txtEstado)
        Me.GDatos.Controls.Add(Me.Label1)
        Me.GDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GDatos.Location = New System.Drawing.Point(0, 703)
        Me.GDatos.Name = "GDatos"
        Me.GDatos.Size = New System.Drawing.Size(1198, 90)
        Me.GDatos.TabIndex = 57
        Me.GDatos.TabStop = False
        Me.GDatos.Text = "Datos Planilla"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(747, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(612, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 13)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Exportar Planillas"
        '
        'rbRechazar
        '
        Me.rbRechazar.AutoSize = True
        Me.rbRechazar.Location = New System.Drawing.Point(174, 61)
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
        Me.rbAceptar.Location = New System.Drawing.Point(174, 29)
        Me.rbAceptar.Name = "rbAceptar"
        Me.rbAceptar.Size = New System.Drawing.Size(75, 17)
        Me.rbAceptar.TabIndex = 63
        Me.rbAceptar.TabStop = True
        Me.rbAceptar.Text = "ACEPTAR"
        Me.rbAceptar.UseVisualStyleBackColor = True
        '
        'txtSaldoCliente
        '
        Me.txtSaldoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSaldoCliente.Enabled = False
        Me.txtSaldoCliente.ForeColor = System.Drawing.Color.Black
        Me.txtSaldoCliente.Location = New System.Drawing.Point(705, 19)
        Me.txtSaldoCliente.Name = "txtSaldoCliente"
        Me.txtSaldoCliente.Size = New System.Drawing.Size(195, 20)
        Me.txtSaldoCliente.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(610, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Situación Cliente:"
        '
        'btnCambioEstadoPlanilla
        '
        Me.btnCambioEstadoPlanilla.Location = New System.Drawing.Point(264, 41)
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
        Me.txtTotal.Size = New System.Drawing.Size(87, 20)
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
        Me.txtEstado.Size = New System.Drawing.Size(87, 20)
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
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(825, 249)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 22)
        Me.btnModificar.TabIndex = 59
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtIdPlanilla)
        Me.GroupBox1.Controls.Add(Me.btnCargarPlanillaNueva)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cmbClienteP)
        Me.GroupBox1.Controls.Add(Me.cmbFechaP)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.cCopiarDatos)
        Me.GroupBox1.Controls.Add(Me.DFechaPlanillaNueva)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1198, 58)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1012, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 13)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Fecha nueva planilla"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Id Planilla"
        Me.Label11.Visible = False
        '
        'txtIdPlanilla
        '
        Me.txtIdPlanilla.Enabled = False
        Me.txtIdPlanilla.Location = New System.Drawing.Point(22, 73)
        Me.txtIdPlanilla.Name = "txtIdPlanilla"
        Me.txtIdPlanilla.Size = New System.Drawing.Size(134, 20)
        Me.txtIdPlanilla.TabIndex = 56
        Me.txtIdPlanilla.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(906, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "TOTAL RECIBOS:"
        '
        'txtTotalPlanilla
        '
        Me.txtTotalPlanilla.Enabled = False
        Me.txtTotalPlanilla.Location = New System.Drawing.Point(909, 52)
        Me.txtTotalPlanilla.Name = "txtTotalPlanilla"
        Me.txtTotalPlanilla.Size = New System.Drawing.Size(134, 20)
        Me.txtTotalPlanilla.TabIndex = 63
        Me.txtTotalPlanilla.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "RECIBOS:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 261)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 13)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "COMPROBANTES:"
        '
        'txtTotalPlanillaPagos
        '
        Me.txtTotalPlanillaPagos.Enabled = False
        Me.txtTotalPlanillaPagos.Location = New System.Drawing.Point(909, 304)
        Me.txtTotalPlanillaPagos.Name = "txtTotalPlanillaPagos"
        Me.txtTotalPlanillaPagos.Size = New System.Drawing.Size(134, 20)
        Me.txtTotalPlanillaPagos.TabIndex = 68
        Me.txtTotalPlanillaPagos.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(906, 279)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 13)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "TOTAL PAGOS:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCargar)
        Me.Panel1.Controls.Add(Me.DgPlanillaPolizas)
        Me.Panel1.Controls.Add(Me.btnCargaCompania)
        Me.Panel1.Controls.Add(Me.btnPreCargar)
        Me.Panel1.Controls.Add(Me.cmbCompania)
        Me.Panel1.Controls.Add(Me.txtTotalPlanillaPagos)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.cmbTipoComprobante)
        Me.Panel1.Controls.Add(Me.btnCargaBanco)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.cmbBanco)
        Me.Panel1.Controls.Add(Me.btnCargarPolizas)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.txtImporte)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.DFechaPago)
        Me.Panel1.Controls.Add(Me.txtTotalPlanilla)
        Me.Panel1.Controls.Add(Me.DFechaIngreso)
        Me.Panel1.Controls.Add(Me.DPreviaACargar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 597)
        Me.Panel1.TabIndex = 69
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(150, 254)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(119, 24)
        Me.btnCargar.TabIndex = 69
        Me.btnCargar.Text = "Confirmar Pagos"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'FrmPlanillas
        '
        Me.AcceptButton = Me.btnPreCargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 793)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GDatos)
        Me.Controls.Add(Me.lblTotal)
        Me.Name = "FrmPlanillas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPlanillas"
        CType(Me.DgPlanillaPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DPreviaACargar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GDatos.ResumeLayout(False)
        Me.GDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents DPreviaACargar As Windows.Forms.DataGridView
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents DFechaPlanillaNueva As Windows.Forms.DateTimePicker
    Friend WithEvents btnCargarPolizas As Windows.Forms.Button
    Friend WithEvents GDatos As Windows.Forms.GroupBox
    Friend WithEvents txtTotal As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtEstado As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtSaldoCliente As Windows.Forms.TextBox
    Friend WithEvents btnCambioEstadoPlanilla As Windows.Forms.Button
    Friend WithEvents rbRechazar As Windows.Forms.RadioButton
    Friend WithEvents rbAceptar As Windows.Forms.RadioButton
    Friend WithEvents btnModificar As Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txtIdPlanilla As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txtTotalPlanilla As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents txtTotalPlanillaPagos As Windows.Forms.TextBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnCargar As Windows.Forms.Button
End Class
