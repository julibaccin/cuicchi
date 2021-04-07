<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaCobradores
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
        Me.btnCargarCobrador = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreCobrador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DCobradores = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        CType(Me.DCobradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCargarCobrador
        '
        Me.btnCargarCobrador.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargarCobrador.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCargarCobrador.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarCobrador.Location = New System.Drawing.Point(18, 163)
        Me.btnCargarCobrador.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargarCobrador.Name = "btnCargarCobrador"
        Me.btnCargarCobrador.Size = New System.Drawing.Size(265, 38)
        Me.btnCargarCobrador.TabIndex = 28
        Me.btnCargarCobrador.Text = "Cargar"
        Me.btnCargarCobrador.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(13, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Cargar Cobrador"
        '
        'txtNombreCobrador
        '
        Me.txtNombreCobrador.Location = New System.Drawing.Point(157, 82)
        Me.txtNombreCobrador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreCobrador.Name = "txtNombreCobrador"
        Me.txtNombreCobrador.Size = New System.Drawing.Size(126, 20)
        Me.txtNombreCobrador.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre Cobrador"
        '
        'DCobradores
        '
        Me.DCobradores.AllowUserToAddRows = False
        Me.DCobradores.AllowUserToDeleteRows = False
        Me.DCobradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DCobradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DCobradores.Location = New System.Drawing.Point(335, 40)
        Me.DCobradores.Name = "DCobradores"
        Me.DCobradores.Size = New System.Drawing.Size(697, 174)
        Me.DCobradores.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(333, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 18)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Filtrar por nombre"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(485, 13)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltro.MaxLength = 8
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(194, 20)
        Me.txtFiltro.TabIndex = 30
        '
        'frmAltaCobradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 241)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.DCobradores)
        Me.Controls.Add(Me.btnCargarCobrador)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNombreCobrador)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmAltaCobradores"
        Me.Text = "frmAltaCobradores"
        CType(Me.DCobradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCargarCobrador As Windows.Forms.Button
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtNombreCobrador As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents DCobradores As Windows.Forms.DataGridView
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txtFiltro As Windows.Forms.TextBox
End Class
