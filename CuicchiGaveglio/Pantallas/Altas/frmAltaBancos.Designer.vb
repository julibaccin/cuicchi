Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltaBancos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreBanco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumeroBanco = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnModificarBanco = New System.Windows.Forms.Button()
        Me.btnCargarBanco = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Banco"
        '
        'txtNombreBanco
        '
        Me.txtNombreBanco.Location = New System.Drawing.Point(161, 104)
        Me.txtNombreBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreBanco.Name = "txtNombreBanco"
        Me.txtNombreBanco.Size = New System.Drawing.Size(274, 26)
        Me.txtNombreBanco.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número Banco"
        '
        'txtNumeroBanco
        '
        Me.txtNumeroBanco.Location = New System.Drawing.Point(161, 64)
        Me.txtNumeroBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroBanco.Name = "txtNumeroBanco"
        Me.txtNumeroBanco.Size = New System.Drawing.Size(126, 26)
        Me.txtNumeroBanco.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(17, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cargar Banco"
        '
        'btnModificarBanco
        '
        Me.btnModificarBanco.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnModificarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarBanco.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarBanco.Location = New System.Drawing.Point(22, 148)
        Me.btnModificarBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificarBanco.Name = "btnModificarBanco"
        Me.btnModificarBanco.Size = New System.Drawing.Size(114, 34)
        Me.btnModificarBanco.TabIndex = 19
        Me.btnModificarBanco.Text = "Modificar"
        Me.btnModificarBanco.UseVisualStyleBackColor = False
        '
        'btnCargarBanco
        '
        Me.btnCargarBanco.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCargarBanco.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarBanco.Location = New System.Drawing.Point(161, 148)
        Me.btnCargarBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargarBanco.Name = "btnCargarBanco"
        Me.btnCargarBanco.Size = New System.Drawing.Size(114, 34)
        Me.btnCargarBanco.TabIndex = 21
        Me.btnCargarBanco.Text = "Cargar"
        Me.btnCargarBanco.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 36)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Solo podrá modificar el nombre del banco, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "según el número que ingrese"
        '
        'frmAltaBancos
        '
        Me.AcceptButton = Me.btnCargarBanco
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 258)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCargarBanco)
        Me.Controls.Add(Me.btnModificarBanco)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNumeroBanco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreBanco)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAltaBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Bancos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreBanco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumeroBanco As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModificarBanco As Button
    Friend WithEvents btnCargarBanco As Button
    Friend WithEvents Label3 As Label
End Class
