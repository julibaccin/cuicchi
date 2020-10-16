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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btnReporteMovimientoComprobantes = New System.Windows.Forms.Button()
        Me.RVComprobantes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DfDesde = New System.Windows.Forms.DateTimePicker()
        Me.DfHasta = New System.Windows.Forms.DateTimePicker()
        Me.RVRecibos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'btnReporteMovimientoComprobantes
        '
        Me.btnReporteMovimientoComprobantes.Location = New System.Drawing.Point(146, 34)
        Me.btnReporteMovimientoComprobantes.Name = "btnReporteMovimientoComprobantes"
        Me.btnReporteMovimientoComprobantes.Size = New System.Drawing.Size(85, 34)
        Me.btnReporteMovimientoComprobantes.TabIndex = 4
        Me.btnReporteMovimientoComprobantes.Text = "Movimiento Comprobantes"
        Me.btnReporteMovimientoComprobantes.UseVisualStyleBackColor = True
        '
        'RVComprobantes
        '
        Me.RVComprobantes.LocalReport.ReportEmbeddedResource = "CuicchiGaveglio.ReporteComprobantes.rdlc"
        Me.RVComprobantes.Location = New System.Drawing.Point(12, 95)
        Me.RVComprobantes.Name = "RVComprobantes"
        Me.RVComprobantes.ServerReport.BearerToken = Nothing
        Me.RVComprobantes.Size = New System.Drawing.Size(507, 534)
        Me.RVComprobantes.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(715, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Movimiento Recibos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Hasta"
        '
        'DfDesde
        '
        Me.DfDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DfDesde.Location = New System.Drawing.Point(459, 15)
        Me.DfDesde.Name = "DfDesde"
        Me.DfDesde.Size = New System.Drawing.Size(107, 20)
        Me.DfDesde.TabIndex = 9
        '
        'DfHasta
        '
        Me.DfHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DfHasta.Location = New System.Drawing.Point(459, 48)
        Me.DfHasta.Name = "DfHasta"
        Me.DfHasta.Size = New System.Drawing.Size(107, 20)
        Me.DfHasta.TabIndex = 10
        '
        'RVRecibos
        '
        ReportDataSource1.Name = "DSRecibos"
        ReportDataSource1.Value = Nothing
        Me.RVRecibos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVRecibos.LocalReport.ReportEmbeddedResource = "CuicchiGaveglio.ReporteRecibos.rdlc"
        Me.RVRecibos.Location = New System.Drawing.Point(541, 95)
        Me.RVRecibos.Name = "RVRecibos"
        Me.RVRecibos.ServerReport.BearerToken = Nothing
        Me.RVRecibos.Size = New System.Drawing.Size(532, 534)
        Me.RVRecibos.TabIndex = 11
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 650)
        Me.Controls.Add(Me.RVRecibos)
        Me.Controls.Add(Me.DfHasta)
        Me.Controls.Add(Me.DfDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RVComprobantes)
        Me.Controls.Add(Me.btnReporteMovimientoComprobantes)
        Me.Name = "frmReportes"
        Me.Text = "REPORTES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReporteMovimientoComprobantes As Windows.Forms.Button
    Friend WithEvents RVComprobantes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents DfDesde As Windows.Forms.DateTimePicker
    Friend WithEvents DfHasta As Windows.Forms.DateTimePicker
    Friend WithEvents RVRecibos As Microsoft.Reporting.WinForms.ReportViewer
End Class
