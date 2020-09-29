Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltaClientes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCBU = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnCargarCliente = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.DClientes = New System.Windows.Forms.DataGridView()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(122, 199)
        Me.txtCuit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuit.MaxLength = 11
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(250, 26)
        Me.txtCuit.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 207)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CUIT"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(122, 233)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(250, 26)
        Me.txtDomicilio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 241)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Domicilio"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(122, 165)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(250, 26)
        Me.txtTelefono.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Teléfono"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(122, 131)
        Me.txtDni.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(250, 26)
        Me.txtDni.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DNI"
        '
        'txtCBU
        '
        Me.txtCBU.Location = New System.Drawing.Point(122, 267)
        Me.txtCBU.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCBU.MaxLength = 22
        Me.txtCBU.Name = "txtCBU"
        Me.txtCBU.Size = New System.Drawing.Size(250, 26)
        Me.txtCBU.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 275)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CBU"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 309)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 301)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 26)
        Me.txtEmail.TabIndex = 7
        '
        'btnCargarCliente
        '
        Me.btnCargarCliente.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCargarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCargarCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarCliente.Location = New System.Drawing.Point(258, 335)
        Me.btnCargarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargarCliente.Name = "btnCargarCliente"
        Me.btnCargarCliente.Size = New System.Drawing.Size(114, 34)
        Me.btnCargarCliente.TabIndex = 15
        Me.btnCargarCliente.Text = "Cargar"
        Me.btnCargarCliente.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(16, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cargar Cliente"
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.Location = New System.Drawing.Point(122, 335)
        Me.btnModificarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(114, 34)
        Me.btnModificarCliente.TabIndex = 17
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = False
        '
        'DClientes
        '
        Me.DClientes.AllowUserToAddRows = False
        Me.DClientes.AllowUserToDeleteRows = False
        Me.DClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DClientes.Location = New System.Drawing.Point(389, 56)
        Me.DClientes.Name = "DClientes"
        Me.DClientes.Size = New System.Drawing.Size(697, 313)
        Me.DClientes.TabIndex = 18
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(538, 22)
        Me.txtBuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscarCliente.MaxLength = 8
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(194, 26)
        Me.txtBuscarCliente.TabIndex = 19
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(122, 97)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreCliente.MaxLength = 60
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(250, 26)
        Me.txtNombreCliente.TabIndex = 20
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(122, 56)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdCliente.MaxLength = 8
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(84, 26)
        Me.txtIdCliente.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "idCliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(386, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Filtrar por nombre"
        '
        'frmAltaClientes
        '
        Me.AcceptButton = Me.btnCargarCliente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 379)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtBuscarCliente)
        Me.Controls.Add(Me.DClientes)
        Me.Controls.Add(Me.btnModificarCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCBU)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCargarCliente)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAltaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Clientes"
        CType(Me.DClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnCargarCliente As Button
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCBU As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents DClientes As DataGridView
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
