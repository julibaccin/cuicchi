<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQL
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
        Me.btnEjecutarSQL = New System.Windows.Forms.Button()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.dgwRespuesta = New System.Windows.Forms.DataGridView()
        CType(Me.dgwRespuesta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEjecutarSQL
        '
        Me.btnEjecutarSQL.Location = New System.Drawing.Point(349, 261)
        Me.btnEjecutarSQL.Name = "btnEjecutarSQL"
        Me.btnEjecutarSQL.Size = New System.Drawing.Size(93, 35)
        Me.btnEjecutarSQL.TabIndex = 0
        Me.btnEjecutarSQL.Text = "Ejecutar"
        Me.btnEjecutarSQL.UseVisualStyleBackColor = True
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(12, 22)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(776, 233)
        Me.txtQuery.TabIndex = 1
        '
        'dgwRespuesta
        '
        Me.dgwRespuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwRespuesta.Location = New System.Drawing.Point(12, 313)
        Me.dgwRespuesta.Name = "dgwRespuesta"
        Me.dgwRespuesta.Size = New System.Drawing.Size(776, 300)
        Me.dgwRespuesta.TabIndex = 3
        '
        'frmSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 625)
        Me.Controls.Add(Me.dgwRespuesta)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.btnEjecutarSQL)
        Me.Name = "frmSQL"
        Me.Text = "frmSQL"
        CType(Me.dgwRespuesta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEjecutarSQL As Windows.Forms.Button
    Friend WithEvents txtQuery As Windows.Forms.TextBox
    Friend WithEvents dgwRespuesta As Windows.Forms.DataGridView
End Class
