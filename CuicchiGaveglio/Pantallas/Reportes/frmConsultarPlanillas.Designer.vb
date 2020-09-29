Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultarPlanillas
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
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.DataPlanillasPolizas = New System.Windows.Forms.DataGridView()
        Me.DPolizasPagos = New System.Windows.Forms.DataGridView()
        Me.pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCargarPlanillaNueva = New System.Windows.Forms.Button()
        Me.DFechaPlanillaNueva = New System.Windows.Forms.DateTimePicker()
        Me.btnCargarPagosPoliza = New System.Windows.Forms.Button()
        Me.DAltasComprobantes = New System.Windows.Forms.DataGridView()
        Me.cmbFechaPlanillas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtImporteAlta = New System.Windows.Forms.TextBox()
        Me.txtIdAlta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCargarPolizas = New System.Windows.Forms.Button()
        Me.btnVerReporte = New System.Windows.Forms.Button()
        Me.DDetalle = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DataPlanillasPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DPolizasPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAltasComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLIENTE"
        '
        'cmbCliente
        '
        Me.cmbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(16, 27)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(144, 28)
        Me.cmbCliente.TabIndex = 1
        '
        'DataPlanillasPolizas
        '
        Me.DataPlanillasPolizas.AllowUserToDeleteRows = False
        Me.DataPlanillasPolizas.AllowUserToResizeColumns = False
        Me.DataPlanillasPolizas.AllowUserToResizeRows = False
        Me.DataPlanillasPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPlanillasPolizas.Location = New System.Drawing.Point(180, 27)
        Me.DataPlanillasPolizas.Name = "DataPlanillasPolizas"
        Me.DataPlanillasPolizas.Size = New System.Drawing.Size(708, 191)
        Me.DataPlanillasPolizas.TabIndex = 6
        '
        'DPolizasPagos
        '
        Me.DPolizasPagos.AllowUserToDeleteRows = False
        Me.DPolizasPagos.AllowUserToResizeColumns = False
        Me.DPolizasPagos.AllowUserToResizeRows = False
        Me.DPolizasPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DPolizasPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DPolizasPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pagos})
        Me.DPolizasPagos.Location = New System.Drawing.Point(703, 292)
        Me.DPolizasPagos.Name = "DPolizasPagos"
        Me.DPolizasPagos.Size = New System.Drawing.Size(185, 128)
        Me.DPolizasPagos.TabIndex = 11
        '
        'pagos
        '
        Me.pagos.Frozen = True
        Me.pagos.HeaderText = "Pagos"
        Me.pagos.Name = "pagos"
        Me.pagos.ReadOnly = True
        Me.pagos.Width = 62
        '
        'btnCargarPlanillaNueva
        '
        Me.btnCargarPlanillaNueva.Location = New System.Drawing.Point(16, 196)
        Me.btnCargarPlanillaNueva.Name = "btnCargarPlanillaNueva"
        Me.btnCargarPlanillaNueva.Size = New System.Drawing.Size(144, 22)
        Me.btnCargarPlanillaNueva.TabIndex = 12
        Me.btnCargarPlanillaNueva.Text = "Cargar Planilla Nueva"
        Me.btnCargarPlanillaNueva.UseVisualStyleBackColor = True
        '
        'DFechaPlanillaNueva
        '
        Me.DFechaPlanillaNueva.Location = New System.Drawing.Point(16, 170)
        Me.DFechaPlanillaNueva.Name = "DFechaPlanillaNueva"
        Me.DFechaPlanillaNueva.Size = New System.Drawing.Size(144, 20)
        Me.DFechaPlanillaNueva.TabIndex = 13
        '
        'btnCargarPagosPoliza
        '
        Me.btnCargarPagosPoliza.Location = New System.Drawing.Point(18, 171)
        Me.btnCargarPagosPoliza.Name = "btnCargarPagosPoliza"
        Me.btnCargarPagosPoliza.Size = New System.Drawing.Size(69, 23)
        Me.btnCargarPagosPoliza.TabIndex = 14
        Me.btnCargarPagosPoliza.Text = "Cargar"
        Me.btnCargarPagosPoliza.UseVisualStyleBackColor = True
        '
        'DAltasComprobantes
        '
        Me.DAltasComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DAltasComprobantes.Location = New System.Drawing.Point(18, 39)
        Me.DAltasComprobantes.Name = "DAltasComprobantes"
        Me.DAltasComprobantes.Size = New System.Drawing.Size(663, 128)
        Me.DAltasComprobantes.TabIndex = 15
        '
        'cmbFechaPlanillas
        '
        Me.cmbFechaPlanillas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFechaPlanillas.FormattingEnabled = True
        Me.cmbFechaPlanillas.Location = New System.Drawing.Point(16, 85)
        Me.cmbFechaPlanillas.Name = "cmbFechaPlanillas"
        Me.cmbFechaPlanillas.Size = New System.Drawing.Size(144, 28)
        Me.cmbFechaPlanillas.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "FECHA PLANILLAS"
        '
        'txtPoliza
        '
        Me.txtPoliza.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPoliza.Enabled = False
        Me.txtPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoliza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPoliza.Location = New System.Drawing.Point(124, 7)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(57, 26)
        Me.txtPoliza.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtImporteAlta)
        Me.GroupBox1.Controls.Add(Me.txtIdAlta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DAltasComprobantes)
        Me.GroupBox1.Controls.Add(Me.btnCargarPagosPoliza)
        Me.GroupBox1.Controls.Add(Me.txtPoliza)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 253)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 202)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cargar pago de poliza"
        '
        'txtImporteAlta
        '
        Me.txtImporteAlta.Location = New System.Drawing.Point(241, 171)
        Me.txtImporteAlta.Name = "txtImporteAlta"
        Me.txtImporteAlta.Size = New System.Drawing.Size(82, 20)
        Me.txtImporteAlta.TabIndex = 22
        '
        'txtIdAlta
        '
        Me.txtIdAlta.Enabled = False
        Me.txtIdAlta.Location = New System.Drawing.Point(113, 171)
        Me.txtIdAlta.Name = "txtIdAlta"
        Me.txtIdAlta.Size = New System.Drawing.Size(33, 20)
        Me.txtIdAlta.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Importe utilizado"
        '
        'btnCargarPolizas
        '
        Me.btnCargarPolizas.Location = New System.Drawing.Point(180, 224)
        Me.btnCargarPolizas.Name = "btnCargarPolizas"
        Me.btnCargarPolizas.Size = New System.Drawing.Size(106, 23)
        Me.btnCargarPolizas.TabIndex = 22
        Me.btnCargarPolizas.Text = "Cargar Polizas"
        Me.btnCargarPolizas.UseVisualStyleBackColor = True
        '
        'btnVerReporte
        '
        Me.btnVerReporte.Location = New System.Drawing.Point(292, 224)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnVerReporte.TabIndex = 23
        Me.btnVerReporte.Text = "Ver Reporte"
        Me.btnVerReporte.UseVisualStyleBackColor = True
        '
        'DDetalle
        '
        Me.DDetalle.AllowUserToAddRows = False
        Me.DDetalle.AllowUserToDeleteRows = False
        Me.DDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DDetalle.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DDetalle.Location = New System.Drawing.Point(21, 37)
        Me.DDetalle.Name = "DDetalle"
        Me.DDetalle.Size = New System.Drawing.Size(255, 356)
        Me.DDetalle.TabIndex = 24
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(407, 229)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(911, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 417)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SALDO"
        '
        'FrmConsultarPlanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 471)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnVerReporte)
        Me.Controls.Add(Me.btnCargarPolizas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFechaPlanillas)
        Me.Controls.Add(Me.DFechaPlanillaNueva)
        Me.Controls.Add(Me.btnCargarPlanillaNueva)
        Me.Controls.Add(Me.DPolizasPagos)
        Me.Controls.Add(Me.DataPlanillasPolizas)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultarPlanillas"
        Me.Text = "Planillas"
        CType(Me.DataPlanillasPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DPolizasPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAltasComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents DataPlanillasPolizas As DataGridView
    Friend WithEvents DPolizasPagos As DataGridView
    Friend WithEvents btnCargarPlanillaNueva As Button
    Friend WithEvents DFechaPlanillaNueva As DateTimePicker
    Friend WithEvents btnCargarPagosPoliza As Button
    Friend WithEvents DAltasComprobantes As DataGridView
    Friend WithEvents cmbFechaPlanillas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPoliza As TextBox
    Friend WithEvents pagos As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtImporteAlta As TextBox
    Friend WithEvents txtIdAlta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCargarPolizas As Button
    Friend WithEvents btnVerReporte As Button
    Friend WithEvents DDetalle As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
