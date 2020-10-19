<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportes
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
        Me.btnReporteMovimientoComprobantes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DfDesde = New System.Windows.Forms.DateTimePicker()
        Me.DfHasta = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.panelReportes = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReporteMovimientoComprobantes
        '
        Me.btnReporteMovimientoComprobantes.BackColor = System.Drawing.Color.White
        Me.btnReporteMovimientoComprobantes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReporteMovimientoComprobantes.Location = New System.Drawing.Point(0, 34)
        Me.btnReporteMovimientoComprobantes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReporteMovimientoComprobantes.Name = "btnReporteMovimientoComprobantes"
        Me.btnReporteMovimientoComprobantes.Size = New System.Drawing.Size(200, 34)
        Me.btnReporteMovimientoComprobantes.TabIndex = 4
        Me.btnReporteMovimientoComprobantes.TabStop = False
        Me.btnReporteMovimientoComprobantes.Text = "Movimiento Comprobantes"
        Me.btnReporteMovimientoComprobantes.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.TabStop = False
        Me.Button1.Text = "Movimiento Recibos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Hasta"
        '
        'DfDesde
        '
        Me.DfDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DfDesde.Location = New System.Drawing.Point(155, 21)
        Me.DfDesde.Name = "DfDesde"
        Me.DfDesde.Size = New System.Drawing.Size(107, 20)
        Me.DfDesde.TabIndex = 9
        '
        'DfHasta
        '
        Me.DfHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DfHasta.Location = New System.Drawing.Point(155, 48)
        Me.DfHasta.Name = "DfHasta"
        Me.DfHasta.Size = New System.Drawing.Size(107, 20)
        Me.DfHasta.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.btnReporteMovimientoComprobantes)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 579)
        Me.Panel1.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DfHasta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DfDesde)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(200, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 79)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTROS"
        '
        'panelReportes
        '
        Me.panelReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReportes.Location = New System.Drawing.Point(200, 79)
        Me.panelReportes.Name = "panelReportes"
        Me.panelReportes.Size = New System.Drawing.Size(542, 500)
        Me.panelReportes.TabIndex = 14
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 579)
        Me.Controls.Add(Me.panelReportes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReportes"
        Me.Text = "REPORTES"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReporteMovimientoComprobantes As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents DfDesde As Windows.Forms.DateTimePicker
    Friend WithEvents DfHasta As Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents panelReportes As Windows.Forms.Panel
End Class
