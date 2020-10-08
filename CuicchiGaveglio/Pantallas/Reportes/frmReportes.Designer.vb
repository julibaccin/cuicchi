<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DData = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.btnReporteMovimientoComprobantes = New System.Windows.Forms.Button()
        CType(Me.DData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DData
        '
        Me.DData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DData.Location = New System.Drawing.Point(137, 132)
        Me.DData.Name = "DData"
        Me.DData.Size = New System.Drawing.Size(565, 263)
        Me.DData.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DTPHasta)
        Me.GroupBox1.Controls.Add(Me.DTPDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(137, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HASTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DESDE"
        '
        'DTPHasta
        '
        Me.DTPHasta.Location = New System.Drawing.Point(249, 36)
        Me.DTPHasta.Name = "DTPHasta"
        Me.DTPHasta.Size = New System.Drawing.Size(103, 20)
        Me.DTPHasta.TabIndex = 1
        '
        'DTPDesde
        '
        Me.DTPDesde.Location = New System.Drawing.Point(70, 36)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(103, 20)
        Me.DTPDesde.TabIndex = 0
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Location = New System.Drawing.Point(137, 405)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(84, 33)
        Me.btnExportarExcel.TabIndex = 3
        Me.btnExportarExcel.Text = "Exportar Excel"
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'btnReporteMovimientoComprobantes
        '
        Me.btnReporteMovimientoComprobantes.Location = New System.Drawing.Point(25, 34)
        Me.btnReporteMovimientoComprobantes.Name = "btnReporteMovimientoComprobantes"
        Me.btnReporteMovimientoComprobantes.Size = New System.Drawing.Size(85, 34)
        Me.btnReporteMovimientoComprobantes.TabIndex = 4
        Me.btnReporteMovimientoComprobantes.Text = "Movimiento Comprobantes"
        Me.btnReporteMovimientoComprobantes.UseVisualStyleBackColor = True
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 450)
        Me.Controls.Add(Me.btnReporteMovimientoComprobantes)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DData)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmReportes"
        Me.Text = "REPORTES"
        CType(Me.DData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents DData As Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnExportarExcel As Windows.Forms.Button
    Friend WithEvents btnReporteMovimientoComprobantes As Windows.Forms.Button
    Friend WithEvents DTPHasta As Windows.Forms.DateTimePicker
    Friend WithEvents DTPDesde As Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
