<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultarComprobantes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DComprobantes = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipoComprobanteFiltro = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DComprobantesBaja = New System.Windows.Forms.DataGridView()
        Me.btnCargaCompania = New System.Windows.Forms.Button()
        Me.cmbCompania = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.btnCargaBanco = New System.Windows.Forms.Button()
        Me.btnCargaCliente = New System.Windows.Forms.Button()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GrupoComprobantes = New System.Windows.Forms.GroupBox()
        Me.btnPreCargar = New System.Windows.Forms.Button()
        Me.DPreviaACargar = New System.Windows.Forms.DataGridView()
        Me.CheckColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColTipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColClientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCompania = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.DFIngresoDesdeFiltro = New System.Windows.Forms.DateTimePicker()
        Me.DFIngresoHastaFiltro = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtObsBajaCambioEstado = New System.Windows.Forms.TextBox()
        Me.cmbEstadosCambioEstado = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbClienteFiltro = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbEstadoFiltro = New System.Windows.Forms.ComboBox()
        Me.cmbCompaniaFiltro = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbUsuarioFiltro = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNumeroFiltro = New System.Windows.Forms.TextBox()
        Me.txtImporteFiltro = New System.Windows.Forms.TextBox()
        Me.cmbCompaniaCambioEstado = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DComprobantesBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoComprobantes.SuspendLayout()
        CType(Me.DPreviaACargar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtros:"
        '
        'DComprobantes
        '
        Me.DComprobantes.AllowUserToAddRows = False
        Me.DComprobantes.AllowUserToDeleteRows = False
        Me.DComprobantes.AllowUserToResizeColumns = False
        Me.DComprobantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DComprobantes.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DComprobantes.Location = New System.Drawing.Point(12, 101)
        Me.DComprobantes.Name = "DComprobantes"
        Me.DComprobantes.ReadOnly = True
        Me.DComprobantes.Size = New System.Drawing.Size(960, 335)
        Me.DComprobantes.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tipo Comprobante"
        '
        'cmbTipoComprobanteFiltro
        '
        Me.cmbTipoComprobanteFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoComprobanteFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoComprobanteFiltro.FormattingEnabled = True
        Me.cmbTipoComprobanteFiltro.Location = New System.Drawing.Point(221, 6)
        Me.cmbTipoComprobanteFiltro.Name = "cmbTipoComprobanteFiltro"
        Me.cmbTipoComprobanteFiltro.Size = New System.Drawing.Size(193, 21)
        Me.cmbTipoComprobanteFiltro.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(11, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 42)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "OK"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DComprobantesBaja
        '
        Me.DComprobantesBaja.AllowUserToAddRows = False
        Me.DComprobantesBaja.AllowUserToDeleteRows = False
        Me.DComprobantesBaja.AllowUserToResizeColumns = False
        Me.DComprobantesBaja.AllowUserToResizeRows = False
        Me.DComprobantesBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DComprobantesBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DComprobantesBaja.Location = New System.Drawing.Point(11, 453)
        Me.DComprobantesBaja.Name = "DComprobantesBaja"
        Me.DComprobantesBaja.Size = New System.Drawing.Size(589, 178)
        Me.DComprobantesBaja.TabIndex = 14
        '
        'btnCargaCompania
        '
        Me.btnCargaCompania.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaCompania.Location = New System.Drawing.Point(120, 152)
        Me.btnCargaCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargaCompania.Name = "btnCargaCompania"
        Me.btnCargaCompania.Size = New System.Drawing.Size(32, 28)
        Me.btnCargaCompania.TabIndex = 47
        Me.btnCargaCompania.Text = "+"
        Me.btnCargaCompania.UseVisualStyleBackColor = False
        '
        'cmbCompania
        '
        Me.cmbCompania.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.FormattingEnabled = True
        Me.cmbCompania.Location = New System.Drawing.Point(167, 156)
        Me.cmbCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(191, 26)
        Me.cmbCompania.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 164)
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
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(167, 53)
        Me.cmbTipoComprobante.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(191, 26)
        Me.cmbTipoComprobante.TabIndex = 28
        '
        'btnCargaBanco
        '
        Me.btnCargaBanco.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaBanco.Location = New System.Drawing.Point(119, 303)
        Me.btnCargaBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargaBanco.Name = "btnCargaBanco"
        Me.btnCargaBanco.Size = New System.Drawing.Size(33, 26)
        Me.btnCargaBanco.TabIndex = 45
        Me.btnCargaBanco.Text = "+"
        Me.btnCargaBanco.UseVisualStyleBackColor = False
        '
        'btnCargaCliente
        '
        Me.btnCargaCliente.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaCliente.Location = New System.Drawing.Point(119, 116)
        Me.btnCargaCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargaCliente.Name = "btnCargaCliente"
        Me.btnCargaCliente.Size = New System.Drawing.Size(32, 28)
        Me.btnCargaCliente.TabIndex = 44
        Me.btnCargaCliente.Text = "+"
        Me.btnCargaCliente.UseVisualStyleBackColor = False
        '
        'cmbBanco
        '
        Me.cmbBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(167, 303)
        Me.cmbBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(191, 26)
        Me.cmbBanco.TabIndex = 41
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(167, 118)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(191, 26)
        Me.cmbCliente.TabIndex = 32
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(167, 346)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(191, 61)
        Me.txtObservaciones.TabIndex = 42
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(167, 228)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(128, 24)
        Me.txtNumero.TabIndex = 38
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(167, 194)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(128, 24)
        Me.txtImporte.TabIndex = 36
        '
        'DFechaPago
        '
        Me.DFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaPago.Location = New System.Drawing.Point(167, 267)
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
        Me.DFechaIngreso.Location = New System.Drawing.Point(167, 86)
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
        Me.Label10.Location = New System.Drawing.Point(23, 346)
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
        Me.Label8.Location = New System.Drawing.Point(23, 61)
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
        Me.Label7.Location = New System.Drawing.Point(23, 200)
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
        Me.Label6.Location = New System.Drawing.Point(23, 234)
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
        Me.Label3.Location = New System.Drawing.Point(23, 272)
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
        Me.Label9.Location = New System.Drawing.Point(23, 313)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Banco"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 128)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Clientes *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 92)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Fecha Ingreso"
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
        Me.GrupoComprobantes.Controls.Add(Me.btnCargaCliente)
        Me.GrupoComprobantes.Controls.Add(Me.cmbBanco)
        Me.GrupoComprobantes.Controls.Add(Me.cmbCliente)
        Me.GrupoComprobantes.Controls.Add(Me.txtObservaciones)
        Me.GrupoComprobantes.Controls.Add(Me.txtNumero)
        Me.GrupoComprobantes.Controls.Add(Me.txtImporte)
        Me.GrupoComprobantes.Controls.Add(Me.DFechaPago)
        Me.GrupoComprobantes.Controls.Add(Me.DFechaIngreso)
        Me.GrupoComprobantes.Controls.Add(Me.Label10)
        Me.GrupoComprobantes.Controls.Add(Me.Label8)
        Me.GrupoComprobantes.Controls.Add(Me.Label7)
        Me.GrupoComprobantes.Controls.Add(Me.Label6)
        Me.GrupoComprobantes.Controls.Add(Me.Label3)
        Me.GrupoComprobantes.Controls.Add(Me.Label9)
        Me.GrupoComprobantes.Controls.Add(Me.Label11)
        Me.GrupoComprobantes.Controls.Add(Me.Label12)
        Me.GrupoComprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoComprobantes.Location = New System.Drawing.Point(993, 12)
        Me.GrupoComprobantes.Name = "GrupoComprobantes"
        Me.GrupoComprobantes.Size = New System.Drawing.Size(365, 424)
        Me.GrupoComprobantes.TabIndex = 48
        Me.GrupoComprobantes.TabStop = False
        Me.GrupoComprobantes.Text = "Ingrese un comprobante"
        '
        'btnPreCargar
        '
        Me.btnPreCargar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPreCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreCargar.Location = New System.Drawing.Point(26, 376)
        Me.btnPreCargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreCargar.Name = "btnPreCargar"
        Me.btnPreCargar.Size = New System.Drawing.Size(104, 31)
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
        Me.DPreviaACargar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckColumn, Me.ColTipoComprobante, Me.ColFechaIngreso, Me.ColClientes, Me.ColCompania, Me.ColImporte, Me.ColNumero, Me.ColFechaPago, Me.ColBanco, Me.ColObservaciones})
        Me.DPreviaACargar.Location = New System.Drawing.Point(623, 453)
        Me.DPreviaACargar.Name = "DPreviaACargar"
        Me.DPreviaACargar.Size = New System.Drawing.Size(735, 205)
        Me.DPreviaACargar.TabIndex = 49
        '
        'CheckColumn
        '
        Me.CheckColumn.Frozen = True
        Me.CheckColumn.HeaderText = ""
        Me.CheckColumn.Name = "CheckColumn"
        Me.CheckColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CheckColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CheckColumn.Width = 19
        '
        'ColTipoComprobante
        '
        Me.ColTipoComprobante.Frozen = True
        Me.ColTipoComprobante.HeaderText = "Comprobante"
        Me.ColTipoComprobante.Name = "ColTipoComprobante"
        Me.ColTipoComprobante.ReadOnly = True
        Me.ColTipoComprobante.Width = 95
        '
        'ColFechaIngreso
        '
        Me.ColFechaIngreso.Frozen = True
        Me.ColFechaIngreso.HeaderText = "F. Ingreso"
        Me.ColFechaIngreso.Name = "ColFechaIngreso"
        Me.ColFechaIngreso.ReadOnly = True
        Me.ColFechaIngreso.Width = 79
        '
        'ColClientes
        '
        Me.ColClientes.Frozen = True
        Me.ColClientes.HeaderText = "Clientes"
        Me.ColClientes.Name = "ColClientes"
        Me.ColClientes.ReadOnly = True
        Me.ColClientes.Width = 69
        '
        'ColCompania
        '
        Me.ColCompania.Frozen = True
        Me.ColCompania.HeaderText = "Compañia"
        Me.ColCompania.Name = "ColCompania"
        Me.ColCompania.ReadOnly = True
        Me.ColCompania.Width = 79
        '
        'ColImporte
        '
        Me.ColImporte.Frozen = True
        Me.ColImporte.HeaderText = "Importe"
        Me.ColImporte.Name = "ColImporte"
        Me.ColImporte.ReadOnly = True
        Me.ColImporte.Width = 67
        '
        'ColNumero
        '
        Me.ColNumero.Frozen = True
        Me.ColNumero.HeaderText = "Numero"
        Me.ColNumero.Name = "ColNumero"
        Me.ColNumero.ReadOnly = True
        Me.ColNumero.Width = 69
        '
        'ColFechaPago
        '
        Me.ColFechaPago.Frozen = True
        Me.ColFechaPago.HeaderText = "F. Pago"
        Me.ColFechaPago.Name = "ColFechaPago"
        Me.ColFechaPago.ReadOnly = True
        Me.ColFechaPago.Width = 69
        '
        'ColBanco
        '
        Me.ColBanco.Frozen = True
        Me.ColBanco.HeaderText = "Banco"
        Me.ColBanco.Name = "ColBanco"
        Me.ColBanco.ReadOnly = True
        Me.ColBanco.Width = 63
        '
        'ColObservaciones
        '
        Me.ColObservaciones.Frozen = True
        Me.ColObservaciones.HeaderText = "Obs"
        Me.ColObservaciones.Name = "ColObservaciones"
        Me.ColObservaciones.ReadOnly = True
        Me.ColObservaciones.Width = 51
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(623, 665)
        Me.btnCargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(201, 29)
        Me.btnCargar.TabIndex = 50
        Me.btnCargar.Text = "Cargar Comprobantes"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCambiarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarEstado.Location = New System.Drawing.Point(17, 646)
        Me.btnCambiarEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(138, 49)
        Me.btnCambiarEstado.TabIndex = 51
        Me.btnCambiarEstado.Text = "Cambiar Estado"
        Me.btnCambiarEstado.UseVisualStyleBackColor = False
        '
        'DFIngresoDesdeFiltro
        '
        Me.DFIngresoDesdeFiltro.Location = New System.Drawing.Point(221, 32)
        Me.DFIngresoDesdeFiltro.Name = "DFIngresoDesdeFiltro"
        Me.DFIngresoDesdeFiltro.Size = New System.Drawing.Size(193, 20)
        Me.DFIngresoDesdeFiltro.TabIndex = 53
        '
        'DFIngresoHastaFiltro
        '
        Me.DFIngresoHastaFiltro.Location = New System.Drawing.Point(221, 58)
        Me.DFIngresoHastaFiltro.Name = "DFIngresoHastaFiltro"
        Me.DFIngresoHastaFiltro.Size = New System.Drawing.Size(193, 20)
        Me.DFIngresoHastaFiltro.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(91, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 16)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Desde (F.Ingreso)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(91, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 16)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Hasta (F.Ingreso)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 655)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Obs. Baja"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(374, 650)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 16)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Estado"
        '
        'txtObsBajaCambioEstado
        '
        Me.txtObsBajaCambioEstado.Location = New System.Drawing.Point(236, 651)
        Me.txtObsBajaCambioEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObsBajaCambioEstado.Multiline = True
        Me.txtObsBajaCambioEstado.Name = "txtObsBajaCambioEstado"
        Me.txtObsBajaCambioEstado.Size = New System.Drawing.Size(128, 48)
        Me.txtObsBajaCambioEstado.TabIndex = 59
        '
        'cmbEstadosCambioEstado
        '
        Me.cmbEstadosCambioEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstadosCambioEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstadosCambioEstado.FormattingEnabled = True
        Me.cmbEstadosCambioEstado.Location = New System.Drawing.Point(451, 650)
        Me.cmbEstadosCambioEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadosCambioEstado.Name = "cmbEstadosCambioEstado"
        Me.cmbEstadosCambioEstado.Size = New System.Drawing.Size(130, 21)
        Me.cmbEstadosCambioEstado.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(435, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 16)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Estado"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(435, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Compañia"
        '
        'cmbClienteFiltro
        '
        Me.cmbClienteFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClienteFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClienteFiltro.FormattingEnabled = True
        Me.cmbClienteFiltro.Location = New System.Drawing.Point(516, 4)
        Me.cmbClienteFiltro.Name = "cmbClienteFiltro"
        Me.cmbClienteFiltro.Size = New System.Drawing.Size(193, 21)
        Me.cmbClienteFiltro.TabIndex = 61
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(435, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 16)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Cliente"
        '
        'cmbEstadoFiltro
        '
        Me.cmbEstadoFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstadoFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstadoFiltro.FormattingEnabled = True
        Me.cmbEstadoFiltro.Location = New System.Drawing.Point(516, 57)
        Me.cmbEstadoFiltro.Name = "cmbEstadoFiltro"
        Me.cmbEstadoFiltro.Size = New System.Drawing.Size(193, 21)
        Me.cmbEstadoFiltro.TabIndex = 66
        '
        'cmbCompaniaFiltro
        '
        Me.cmbCompaniaFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCompaniaFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompaniaFiltro.FormattingEnabled = True
        Me.cmbCompaniaFiltro.Location = New System.Drawing.Point(516, 29)
        Me.cmbCompaniaFiltro.Name = "cmbCompaniaFiltro"
        Me.cmbCompaniaFiltro.Size = New System.Drawing.Size(193, 21)
        Me.cmbCompaniaFiltro.TabIndex = 67
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(757, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 16)
        Me.Label19.TabIndex = 71
        Me.Label19.Text = "Importe"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(757, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "Numero"
        '
        'cmbUsuarioFiltro
        '
        Me.cmbUsuarioFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUsuarioFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUsuarioFiltro.FormattingEnabled = True
        Me.cmbUsuarioFiltro.Location = New System.Drawing.Point(838, 2)
        Me.cmbUsuarioFiltro.Name = "cmbUsuarioFiltro"
        Me.cmbUsuarioFiltro.Size = New System.Drawing.Size(128, 21)
        Me.cmbUsuarioFiltro.TabIndex = 69
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(757, 7)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 16)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "Usuario"
        '
        'txtNumeroFiltro
        '
        Me.txtNumeroFiltro.Location = New System.Drawing.Point(838, 30)
        Me.txtNumeroFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroFiltro.Name = "txtNumeroFiltro"
        Me.txtNumeroFiltro.Size = New System.Drawing.Size(128, 20)
        Me.txtNumeroFiltro.TabIndex = 72
        '
        'txtImporteFiltro
        '
        Me.txtImporteFiltro.Location = New System.Drawing.Point(838, 58)
        Me.txtImporteFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporteFiltro.Name = "txtImporteFiltro"
        Me.txtImporteFiltro.Size = New System.Drawing.Size(128, 20)
        Me.txtImporteFiltro.TabIndex = 73
        '
        'cmbCompaniaCambioEstado
        '
        Me.cmbCompaniaCambioEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCompaniaCambioEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompaniaCambioEstado.FormattingEnabled = True
        Me.cmbCompaniaCambioEstado.Location = New System.Drawing.Point(451, 674)
        Me.cmbCompaniaCambioEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCompaniaCambioEstado.Name = "cmbCompaniaCambioEstado"
        Me.cmbCompaniaCambioEstado.Size = New System.Drawing.Size(130, 21)
        Me.cmbCompaniaCambioEstado.TabIndex = 74
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(374, 679)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 16)
        Me.Label22.TabIndex = 75
        Me.Label22.Text = "Compañia"
        '
        'frmConsultarComprobantes
        '
        Me.AcceptButton = Me.btnPreCargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.cmbCompaniaCambioEstado)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtImporteFiltro)
        Me.Controls.Add(Me.txtNumeroFiltro)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmbUsuarioFiltro)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmbCompaniaFiltro)
        Me.Controls.Add(Me.cmbEstadoFiltro)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbClienteFiltro)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmbEstadosCambioEstado)
        Me.Controls.Add(Me.txtObsBajaCambioEstado)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DFIngresoHastaFiltro)
        Me.Controls.Add(Me.DFIngresoDesdeFiltro)
        Me.Controls.Add(Me.btnCambiarEstado)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.DPreviaACargar)
        Me.Controls.Add(Me.GrupoComprobantes)
        Me.Controls.Add(Me.DComprobantesBaja)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbTipoComprobanteFiltro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DComprobantes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConsultarComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Comprobantes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DComprobantesBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoComprobantes.ResumeLayout(False)
        Me.GrupoComprobantes.PerformLayout()
        CType(Me.DPreviaACargar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DComprobantes As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTipoComprobanteFiltro As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DComprobantesBaja As DataGridView
    Friend WithEvents btnCargaCompania As Button
    Friend WithEvents cmbCompania As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTipoComprobante As ComboBox
    Friend WithEvents btnCargaBanco As Button
    Friend WithEvents btnCargaCliente As Button
    Friend WithEvents cmbBanco As ComboBox
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents DFechaPago As DateTimePicker
    Friend WithEvents DFechaIngreso As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GrupoComprobantes As GroupBox
    Friend WithEvents DPreviaACargar As DataGridView
    Friend WithEvents btnPreCargar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnCambiarEstado As Button
    Friend WithEvents CheckColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ColTipoComprobante As DataGridViewTextBoxColumn
    Friend WithEvents ColFechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents ColClientes As DataGridViewTextBoxColumn
    Friend WithEvents ColCompania As DataGridViewTextBoxColumn
    Friend WithEvents ColImporte As DataGridViewTextBoxColumn
    Friend WithEvents ColNumero As DataGridViewTextBoxColumn
    Friend WithEvents ColFechaPago As DataGridViewTextBoxColumn
    Friend WithEvents ColBanco As DataGridViewTextBoxColumn
    Friend WithEvents ColObservaciones As DataGridViewTextBoxColumn
    Friend WithEvents DFIngresoDesdeFiltro As DateTimePicker
    Friend WithEvents DFIngresoHastaFiltro As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtObsBajaCambioEstado As TextBox
    Friend WithEvents cmbEstadosCambioEstado As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbClienteFiltro As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbEstadoFiltro As ComboBox
    Friend WithEvents cmbCompaniaFiltro As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbUsuarioFiltro As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNumeroFiltro As TextBox
    Friend WithEvents txtImporteFiltro As TextBox
    Friend WithEvents cmbCompaniaCambioEstado As ComboBox
    Friend WithEvents Label22 As Label
End Class
