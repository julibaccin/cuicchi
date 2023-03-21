Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEliminarComprobante
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
        Me.btnEliminarAltaComprobante = New System.Windows.Forms.Button()
        Me.txtIdAlta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEliminarAltaComprobante
        '
        Me.btnEliminarAltaComprobante.Location = New System.Drawing.Point(12, 12)
        Me.btnEliminarAltaComprobante.Name = "btnEliminarAltaComprobante"
        Me.btnEliminarAltaComprobante.Size = New System.Drawing.Size(128, 23)
        Me.btnEliminarAltaComprobante.TabIndex = 0
        Me.btnEliminarAltaComprobante.Text = "Eliminar Comprobante"
        Me.btnEliminarAltaComprobante.UseVisualStyleBackColor = True
        '
        'txtIdAlta
        '
        Me.txtIdAlta.Location = New System.Drawing.Point(146, 15)
        Me.txtIdAlta.Name = "txtIdAlta"
        Me.txtIdAlta.Size = New System.Drawing.Size(186, 20)
        Me.txtIdAlta.TabIndex = 2
        '
        'FrmEliminarComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 54)
        Me.Controls.Add(Me.txtIdAlta)
        Me.Controls.Add(Me.btnEliminarAltaComprobante)
        Me.Name = "FrmEliminarComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarAltaComprobante As Button
    Friend WithEvents txtIdAlta As TextBox
End Class
