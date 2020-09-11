<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltaCompania
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnModificarCompania = New System.Windows.Forms.Button()
        Me.btnCargarCompania = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCompania = New System.Windows.Forms.TextBox()
        Me.txtNombreCompania = New System.Windows.Forms.TextBox()
        Me.DCompanias = New System.Windows.Forms.DataGridView()
        Me.txtCuitCompania = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DCompanias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(15, 17)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 31)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cargar Compañia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Id"
        '
        'btnModificarCompania
        '
        Me.btnModificarCompania.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnModificarCompania.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarCompania.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCompania.Location = New System.Drawing.Point(21, 201)
        Me.btnModificarCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificarCompania.Name = "btnModificarCompania"
        Me.btnModificarCompania.Size = New System.Drawing.Size(114, 34)
        Me.btnModificarCompania.TabIndex = 26
        Me.btnModificarCompania.Text = "Modificar"
        Me.btnModificarCompania.UseVisualStyleBackColor = False
        '
        'btnCargarCompania
        '
        Me.btnCargarCompania.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargarCompania.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCargarCompania.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarCompania.Location = New System.Drawing.Point(161, 201)
        Me.btnCargarCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargarCompania.Name = "btnCargarCompania"
        Me.btnCargarCompania.Size = New System.Drawing.Size(114, 34)
        Me.btnCargarCompania.TabIndex = 25
        Me.btnCargarCompania.Text = "Cargar"
        Me.btnCargarCompania.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nombre"
        '
        'txtIdCompania
        '
        Me.txtIdCompania.Enabled = False
        Me.txtIdCompania.Location = New System.Drawing.Point(104, 75)
        Me.txtIdCompania.Name = "txtIdCompania"
        Me.txtIdCompania.Size = New System.Drawing.Size(68, 20)
        Me.txtIdCompania.TabIndex = 28
        '
        'txtNombreCompania
        '
        Me.txtNombreCompania.Location = New System.Drawing.Point(104, 110)
        Me.txtNombreCompania.Name = "txtNombreCompania"
        Me.txtNombreCompania.Size = New System.Drawing.Size(171, 20)
        Me.txtNombreCompania.TabIndex = 29
        '
        'DCompanias
        '
        Me.DCompanias.AllowUserToAddRows = False
        Me.DCompanias.AllowUserToDeleteRows = False
        Me.DCompanias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DCompanias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DCompanias.Location = New System.Drawing.Point(310, 17)
        Me.DCompanias.Name = "DCompanias"
        Me.DCompanias.Size = New System.Drawing.Size(326, 218)
        Me.DCompanias.TabIndex = 30
        '
        'txtCuitCompania
        '
        Me.txtCuitCompania.Location = New System.Drawing.Point(104, 154)
        Me.txtCuitCompania.Name = "txtCuitCompania"
        Me.txtCuitCompania.Size = New System.Drawing.Size(171, 20)
        Me.txtCuitCompania.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "CUIT"
        '
        'frmAltaCompania
        '
        Me.AcceptButton = Me.btnCargarCompania
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 248)
        Me.Controls.Add(Me.txtCuitCompania)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DCompanias)
        Me.Controls.Add(Me.txtNombreCompania)
        Me.Controls.Add(Me.txtIdCompania)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModificarCompania)
        Me.Controls.Add(Me.btnCargarCompania)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmAltaCompania"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Compañia"
        CType(Me.DCompanias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnModificarCompania As Button
    Friend WithEvents btnCargarCompania As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdCompania As TextBox
    Friend WithEvents txtNombreCompania As TextBox
    Friend WithEvents DCompanias As DataGridView
    Friend WithEvents txtCuitCompania As TextBox
    Friend WithEvents Label3 As Label
End Class
