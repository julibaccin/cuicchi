Imports System.Windows.Forms

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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbUsuarioFiltro = New System.Windows.Forms.TextBox()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtImporteFiltro = New System.Windows.Forms.TextBox()
        Me.DComprobantes = New System.Windows.Forms.DataGridView()
        Me.cmbCompaniaCambioEstado = New System.Windows.Forms.ComboBox()
        Me.txtNumeroFiltro = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtObsBajaCambioEstado = New System.Windows.Forms.TextBox()
        Me.cmbEstadosCambioEstado = New System.Windows.Forms.ComboBox()
        Me.cmbCompaniaFiltro = New System.Windows.Forms.ComboBox()
        Me.cmbEstadoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DComprobantesBaja = New System.Windows.Forms.DataGridView()
        Me.cmbClienteFiltro = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipoComprobanteFiltro = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DFIngresoDesdeFiltro = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DFIngresoHastaFiltro = New System.Windows.Forms.DateTimePicker()
        Me.GrupoComprobantes = New System.Windows.Forms.GroupBox()
        Me.btnPreCargar = New System.Windows.Forms.Button()
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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DPreviaACargar = New System.Windows.Forms.DataGridView()
        Me.TipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compania = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DComprobantesBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoComprobantes.SuspendLayout()
        CType(Me.DPreviaACargar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(673, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 16)
        Me.Label21.TabIndex = 106
        Me.Label21.Text = "USUARIO"
        '
        'cmbUsuarioFiltro
        '
        Me.cmbUsuarioFiltro.Location = New System.Drawing.Point(749, 34)
        Me.cmbUsuarioFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUsuarioFiltro.Name = "cmbUsuarioFiltro"
        Me.cmbUsuarioFiltro.Size = New System.Drawing.Size(95, 20)
        Me.cmbUsuarioFiltro.TabIndex = 105
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCambiarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarEstado.Location = New System.Drawing.Point(1127, 407)
        Me.btnCambiarEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(199, 30)
        Me.btnCambiarEstado.TabIndex = 84
        Me.btnCambiarEstado.Text = "Cambiar Estado"
        Me.btnCambiarEstado.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(853, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(110, 30)
        Me.btnBuscar.TabIndex = 82
        Me.btnBuscar.Text = "ßuscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtImporteFiltro
        '
        Me.txtImporteFiltro.Location = New System.Drawing.Point(158, 36)
        Me.txtImporteFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporteFiltro.Name = "txtImporteFiltro"
        Me.txtImporteFiltro.Size = New System.Drawing.Size(95, 20)
        Me.txtImporteFiltro.TabIndex = 102
        '
        'DComprobantes
        '
        Me.DComprobantes.AllowUserToAddRows = False
        Me.DComprobantes.AllowUserToDeleteRows = False
        Me.DComprobantes.AllowUserToResizeColumns = False
        Me.DComprobantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DComprobantes.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DComprobantes.Location = New System.Drawing.Point(10, 83)
        Me.DComprobantes.Name = "DComprobantes"
        Me.DComprobantes.ReadOnly = True
        Me.DComprobantes.Size = New System.Drawing.Size(1100, 200)
        Me.DComprobantes.TabIndex = 79
        '
        'cmbCompaniaCambioEstado
        '
        Me.cmbCompaniaCambioEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCompaniaCambioEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompaniaCambioEstado.FormattingEnabled = True
        Me.cmbCompaniaCambioEstado.Location = New System.Drawing.Point(1198, 373)
        Me.cmbCompaniaCambioEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCompaniaCambioEstado.Name = "cmbCompaniaCambioEstado"
        Me.cmbCompaniaCambioEstado.Size = New System.Drawing.Size(130, 21)
        Me.cmbCompaniaCambioEstado.TabIndex = 103
        '
        'txtNumeroFiltro
        '
        Me.txtNumeroFiltro.Location = New System.Drawing.Point(158, 12)
        Me.txtNumeroFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroFiltro.Name = "txtNumeroFiltro"
        Me.txtNumeroFiltro.Size = New System.Drawing.Size(95, 20)
        Me.txtNumeroFiltro.TabIndex = 101
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1126, 374)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 16)
        Me.Label22.TabIndex = 104
        Me.Label22.Text = "Compañia"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(86, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 16)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "IMPORTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1126, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Obs. Baja"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(86, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 16)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "NÚMERO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1126, 347)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 16)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Estado"
        '
        'txtObsBajaCambioEstado
        '
        Me.txtObsBajaCambioEstado.Location = New System.Drawing.Point(1198, 305)
        Me.txtObsBajaCambioEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObsBajaCambioEstado.Multiline = True
        Me.txtObsBajaCambioEstado.Name = "txtObsBajaCambioEstado"
        Me.txtObsBajaCambioEstado.Size = New System.Drawing.Size(128, 30)
        Me.txtObsBajaCambioEstado.TabIndex = 92
        '
        'cmbEstadosCambioEstado
        '
        Me.cmbEstadosCambioEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstadosCambioEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstadosCambioEstado.FormattingEnabled = True
        Me.cmbEstadosCambioEstado.Location = New System.Drawing.Point(1198, 342)
        Me.cmbEstadosCambioEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadosCambioEstado.Name = "cmbEstadosCambioEstado"
        Me.cmbEstadosCambioEstado.Size = New System.Drawing.Size(130, 21)
        Me.cmbEstadosCambioEstado.TabIndex = 85
        '
        'cmbCompaniaFiltro
        '
        Me.cmbCompaniaFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCompaniaFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompaniaFiltro.FormattingEnabled = True
        Me.cmbCompaniaFiltro.Location = New System.Drawing.Point(550, 11)
        Me.cmbCompaniaFiltro.Name = "cmbCompaniaFiltro"
        Me.cmbCompaniaFiltro.Size = New System.Drawing.Size(117, 21)
        Me.cmbCompaniaFiltro.TabIndex = 98
        '
        'cmbEstadoFiltro
        '
        Me.cmbEstadoFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstadoFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstadoFiltro.FormattingEnabled = True
        Me.cmbEstadoFiltro.Location = New System.Drawing.Point(550, 33)
        Me.cmbEstadoFiltro.Name = "cmbEstadoFiltro"
        Me.cmbEstadoFiltro.Size = New System.Drawing.Size(117, 21)
        Me.cmbEstadoFiltro.TabIndex = 97
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(466, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "ESTADO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(466, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 16)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "COMPAÑIA"
        '
        'DComprobantesBaja
        '
        Me.DComprobantesBaja.AllowUserToAddRows = False
        Me.DComprobantesBaja.AllowUserToDeleteRows = False
        Me.DComprobantesBaja.AllowUserToResizeColumns = False
        Me.DComprobantesBaja.AllowUserToResizeRows = False
        Me.DComprobantesBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DComprobantesBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DComprobantesBaja.Location = New System.Drawing.Point(10, 305)
        Me.DComprobantesBaja.Name = "DComprobantesBaja"
        Me.DComprobantesBaja.Size = New System.Drawing.Size(1100, 132)
        Me.DComprobantesBaja.TabIndex = 83
        '
        'cmbClienteFiltro
        '
        Me.cmbClienteFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClienteFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClienteFiltro.FormattingEnabled = True
        Me.cmbClienteFiltro.Location = New System.Drawing.Point(324, 12)
        Me.cmbClienteFiltro.Name = "cmbClienteFiltro"
        Me.cmbClienteFiltro.Size = New System.Drawing.Size(136, 21)
        Me.cmbClienteFiltro.TabIndex = 94
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(261, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "CLIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "TIPO"
        '
        'cmbTipoComprobanteFiltro
        '
        Me.cmbTipoComprobanteFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTipoComprobanteFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoComprobanteFiltro.FormattingEnabled = True
        Me.cmbTipoComprobanteFiltro.Location = New System.Drawing.Point(324, 36)
        Me.cmbTipoComprobanteFiltro.Name = "cmbTipoComprobanteFiltro"
        Me.cmbTipoComprobanteFiltro.Size = New System.Drawing.Size(136, 21)
        Me.cmbTipoComprobanteFiltro.TabIndex = 81
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(850, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 16)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "HASTA"
        '
        'DFIngresoDesdeFiltro
        '
        Me.DFIngresoDesdeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFIngresoDesdeFiltro.Location = New System.Drawing.Point(749, 10)
        Me.DFIngresoDesdeFiltro.Name = "DFIngresoDesdeFiltro"
        Me.DFIngresoDesdeFiltro.Size = New System.Drawing.Size(95, 20)
        Me.DFIngresoDesdeFiltro.TabIndex = 86
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(673, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "DESDE:"
        '
        'DFIngresoHastaFiltro
        '
        Me.DFIngresoHastaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFIngresoHastaFiltro.Location = New System.Drawing.Point(910, 11)
        Me.DFIngresoHastaFiltro.Name = "DFIngresoHastaFiltro"
        Me.DFIngresoHastaFiltro.Size = New System.Drawing.Size(101, 20)
        Me.DFIngresoHastaFiltro.TabIndex = 87
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
        Me.GrupoComprobantes.Controls.Add(Me.btnCargar)
        Me.GrupoComprobantes.Controls.Add(Me.Label6)
        Me.GrupoComprobantes.Controls.Add(Me.Label3)
        Me.GrupoComprobantes.Controls.Add(Me.Label9)
        Me.GrupoComprobantes.Controls.Add(Me.DPreviaACargar)
        Me.GrupoComprobantes.Controls.Add(Me.Label11)
        Me.GrupoComprobantes.Controls.Add(Me.Label12)
        Me.GrupoComprobantes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrupoComprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoComprobantes.Location = New System.Drawing.Point(0, 444)
        Me.GrupoComprobantes.Name = "GrupoComprobantes"
        Me.GrupoComprobantes.Size = New System.Drawing.Size(1339, 305)
        Me.GrupoComprobantes.TabIndex = 107
        Me.GrupoComprobantes.TabStop = False
        Me.GrupoComprobantes.Text = "Ingrese un comprobante"
        '
        'btnPreCargar
        '
        Me.btnPreCargar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPreCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreCargar.Location = New System.Drawing.Point(264, 36)
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
        Me.btnCargaCompania.Location = New System.Drawing.Point(93, 236)
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
        Me.cmbCompania.Location = New System.Drawing.Point(126, 234)
        Me.cmbCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(128, 26)
        Me.cmbCompania.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 244)
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
        Me.cmbTipoComprobante.TabIndex = 30
        '
        'btnCargaBanco
        '
        Me.btnCargaBanco.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaBanco.Location = New System.Drawing.Point(91, 143)
        Me.btnCargaBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargaBanco.Name = "btnCargaBanco"
        Me.btnCargaBanco.Size = New System.Drawing.Size(27, 26)
        Me.btnCargaBanco.TabIndex = 45
        Me.btnCargaBanco.Text = "+"
        Me.btnCargaBanco.UseVisualStyleBackColor = False
        '
        'btnCargaCliente
        '
        Me.btnCargaCliente.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargaCliente.Location = New System.Drawing.Point(91, 173)
        Me.btnCargaCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargaCliente.Name = "btnCargaCliente"
        Me.btnCargaCliente.Size = New System.Drawing.Size(27, 26)
        Me.btnCargaCliente.TabIndex = 44
        Me.btnCargaCliente.Text = "+"
        Me.btnCargaCliente.UseVisualStyleBackColor = False
        '
        'cmbBanco
        '
        Me.cmbBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(126, 143)
        Me.cmbBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(128, 26)
        Me.cmbBanco.TabIndex = 34
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(126, 171)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(128, 26)
        Me.cmbCliente.TabIndex = 35
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(126, 200)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(128, 30)
        Me.txtObservaciones.TabIndex = 36
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(126, 87)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(128, 24)
        Me.txtNumero.TabIndex = 32
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(126, 58)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(128, 24)
        Me.txtImporte.TabIndex = 31
        '
        'DFechaPago
        '
        Me.DFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaPago.Location = New System.Drawing.Point(126, 115)
        Me.DFechaPago.Margin = New System.Windows.Forms.Padding(4)
        Me.DFechaPago.Name = "DFechaPago"
        Me.DFechaPago.Size = New System.Drawing.Size(128, 24)
        Me.DFechaPago.TabIndex = 33
        Me.DFechaPago.Value = New Date(2020, 8, 12, 11, 49, 20, 0)
        '
        'DFechaIngreso
        '
        Me.DFechaIngreso.CustomFormat = ""
        Me.DFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaIngreso.Location = New System.Drawing.Point(126, 265)
        Me.DFechaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.DFechaIngreso.Name = "DFechaIngreso"
        Me.DFechaIngreso.Size = New System.Drawing.Size(128, 24)
        Me.DFechaIngreso.TabIndex = 38
        Me.DFechaIngreso.Value = New Date(2020, 8, 12, 11, 49, 20, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 214)
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
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "T. Comprobante *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 66)
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
        Me.btnCargar.Location = New System.Drawing.Point(391, 36)
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
        Me.Label6.Location = New System.Drawing.Point(6, 93)
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
        Me.Label3.Location = New System.Drawing.Point(7, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha Cheque"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 151)
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
        Me.DPreviaACargar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoComprobante, Me.FIngreso, Me.Cliente, Me.Compania, Me.Importe, Me.Numero, Me.Fpago, Me.Banco, Me.Obs})
        Me.DPreviaACargar.Location = New System.Drawing.Point(264, 93)
        Me.DPreviaACargar.Name = "DPreviaACargar"
        Me.DPreviaACargar.Size = New System.Drawing.Size(1063, 196)
        Me.DPreviaACargar.TabIndex = 49
        '
        'TipoComprobante
        '
        Me.TipoComprobante.HeaderText = "Comprobante"
        Me.TipoComprobante.Name = "TipoComprobante"
        Me.TipoComprobante.ReadOnly = True
        Me.TipoComprobante.Width = 135
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
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 90
        '
        'Numero
        '
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        Me.Numero.Width = 93
        '
        'Fpago
        '
        Me.Fpago.HeaderText = "F. Pago"
        Me.Fpago.Name = "Fpago"
        Me.Fpago.ReadOnly = True
        Me.Fpago.Width = 92
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 181)
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
        Me.Label12.Location = New System.Drawing.Point(6, 273)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "F. Ingreso"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.DFIngresoHastaFiltro)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbUsuarioFiltro)
        Me.GroupBox1.Controls.Add(Me.DFIngresoDesdeFiltro)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbTipoComprobanteFiltro)
        Me.GroupBox1.Controls.Add(Me.txtImporteFiltro)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cmbClienteFiltro)
        Me.GroupBox1.Controls.Add(Me.txtNumeroFiltro)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbEstadoFiltro)
        Me.GroupBox1.Controls.Add(Me.cmbCompaniaFiltro)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1339, 77)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTROS"
        '
        'frmConsultarComprobantes
        '
        Me.AcceptButton = Me.btnPreCargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrupoComprobantes)
        Me.Controls.Add(Me.btnCambiarEstado)
        Me.Controls.Add(Me.DComprobantes)
        Me.Controls.Add(Me.cmbCompaniaCambioEstado)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtObsBajaCambioEstado)
        Me.Controls.Add(Me.cmbEstadosCambioEstado)
        Me.Controls.Add(Me.DComprobantesBaja)
        Me.Name = "frmConsultarComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Comprobantes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DComprobantesBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoComprobantes.ResumeLayout(False)
        Me.GrupoComprobantes.PerformLayout()
        CType(Me.DPreviaACargar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents cmbUsuarioFiltro As TextBox
    Friend WithEvents btnCambiarEstado As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtImporteFiltro As TextBox
    Friend WithEvents DComprobantes As DataGridView
    Friend WithEvents cmbCompaniaCambioEstado As ComboBox
    Friend WithEvents txtNumeroFiltro As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtObsBajaCambioEstado As TextBox
    Friend WithEvents cmbEstadosCambioEstado As ComboBox
    Friend WithEvents cmbCompaniaFiltro As ComboBox
    Friend WithEvents cmbEstadoFiltro As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DComprobantesBaja As DataGridView
    Friend WithEvents cmbClienteFiltro As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTipoComprobanteFiltro As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DFIngresoDesdeFiltro As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents DFIngresoHastaFiltro As DateTimePicker
    Friend WithEvents GrupoComprobantes As GroupBox
    Friend WithEvents btnPreCargar As Button
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
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DPreviaACargar As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TipoComprobante As DataGridViewTextBoxColumn
    Friend WithEvents FIngreso As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Compania As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Fpago As DataGridViewTextBoxColumn
    Friend WithEvents Banco As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
