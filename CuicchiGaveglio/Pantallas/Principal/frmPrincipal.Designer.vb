Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.lblComun = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAbrirAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAltaClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAltaBancos = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompañiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLANILLASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPROBANTESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliiminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DSaldosPorComprobante = New System.Windows.Forms.DataGridView()
        Me.lblAdvertencias = New System.Windows.Forms.Label()
        Me.DChequesProximosAVencer = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.PENDIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DSaldosPorComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DChequesProximosAVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblComun
        '
        Me.lblComun.AutoSize = True
        Me.lblComun.BackColor = System.Drawing.Color.Transparent
        Me.lblComun.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblComun.Location = New System.Drawing.Point(67, 52)
        Me.lblComun.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComun.Name = "lblComun"
        Me.lblComun.Size = New System.Drawing.Size(70, 18)
        Me.lblComun.TabIndex = 3
        Me.lblComun.Text = "Usuario: "
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(145, 80)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(56, 18)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Label1"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUsuario.Location = New System.Drawing.Point(145, 52)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 18)
        Me.lblUsuario.TabIndex = 9
        Me.lblUsuario.Text = "Nombre"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAbrirAyuda, Me.btnCerrarSesion})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.SistemaToolStripMenuItem.Text = "SISTEMA"
        '
        'btnAbrirAyuda
        '
        Me.btnAbrirAyuda.Name = "btnAbrirAyuda"
        Me.btnAbrirAyuda.Size = New System.Drawing.Size(174, 26)
        Me.btnAbrirAyuda.Text = "Ayuda"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(174, 26)
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAltaClientes, Me.btnAltaBancos, Me.CompañiasToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(65, 25)
        Me.AltaToolStripMenuItem.Text = "ALTAS"
        '
        'btnAltaClientes
        '
        Me.btnAltaClientes.Name = "btnAltaClientes"
        Me.btnAltaClientes.Size = New System.Drawing.Size(158, 26)
        Me.btnAltaClientes.Text = "Clientes"
        '
        'btnAltaBancos
        '
        Me.btnAltaBancos.Name = "btnAltaBancos"
        Me.btnAltaBancos.Size = New System.Drawing.Size(158, 26)
        Me.btnAltaBancos.Text = "Bancos"
        '
        'CompañiasToolStripMenuItem
        '
        Me.CompañiasToolStripMenuItem.Name = "CompañiasToolStripMenuItem"
        Me.CompañiasToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.CompañiasToolStripMenuItem.Text = "Compañias"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(107, 26)
        Me.AltaToolStripMenuItem1.Text = "Alta"
        '
        'ComprobantesToolStripMenuItem
        '
        Me.ComprobantesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PLANILLASToolStripMenuItem, Me.COMPROBANTESToolStripMenuItem1})
        Me.ComprobantesToolStripMenuItem.Name = "ComprobantesToolStripMenuItem"
        Me.ComprobantesToolStripMenuItem.Size = New System.Drawing.Size(145, 25)
        Me.ComprobantesToolStripMenuItem.Text = "COMPROBANTES"
        '
        'PLANILLASToolStripMenuItem
        '
        Me.PLANILLASToolStripMenuItem.Name = "PLANILLASToolStripMenuItem"
        Me.PLANILLASToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.PLANILLASToolStripMenuItem.Text = "PLANILLAS"
        '
        'COMPROBANTESToolStripMenuItem1
        '
        Me.COMPROBANTESToolStripMenuItem1.Name = "COMPROBANTESToolStripMenuItem1"
        Me.COMPROBANTESToolStripMenuItem1.Size = New System.Drawing.Size(203, 26)
        Me.COMPROBANTESToolStripMenuItem1.Text = "COMPROBANTES"
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        '
        'EliiminarToolStripMenuItem
        '
        Me.EliiminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1})
        Me.EliiminarToolStripMenuItem.Name = "EliiminarToolStripMenuItem"
        Me.EliiminarToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.EliiminarToolStripMenuItem.Text = "ELIMINAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(67, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha:"
        '
        'DSaldosPorComprobante
        '
        Me.DSaldosPorComprobante.AllowUserToAddRows = False
        Me.DSaldosPorComprobante.AllowUserToDeleteRows = False
        Me.DSaldosPorComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DSaldosPorComprobante.BackgroundColor = System.Drawing.Color.White
        Me.DSaldosPorComprobante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DSaldosPorComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DSaldosPorComprobante.Location = New System.Drawing.Point(12, 62)
        Me.DSaldosPorComprobante.Name = "DSaldosPorComprobante"
        Me.DSaldosPorComprobante.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DSaldosPorComprobante.Size = New System.Drawing.Size(403, 196)
        Me.DSaldosPorComprobante.TabIndex = 15
        '
        'lblAdvertencias
        '
        Me.lblAdvertencias.AutoSize = True
        Me.lblAdvertencias.BackColor = System.Drawing.Color.Transparent
        Me.lblAdvertencias.ForeColor = System.Drawing.Color.Maroon
        Me.lblAdvertencias.Location = New System.Drawing.Point(12, 271)
        Me.lblAdvertencias.Name = "lblAdvertencias"
        Me.lblAdvertencias.Size = New System.Drawing.Size(259, 18)
        Me.lblAdvertencias.TabIndex = 17
        Me.lblAdvertencias.Text = "CHEQUES PROXIMOS A VENCER"
        '
        'DChequesProximosAVencer
        '
        Me.DChequesProximosAVencer.AllowUserToAddRows = False
        Me.DChequesProximosAVencer.AllowUserToDeleteRows = False
        Me.DChequesProximosAVencer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DChequesProximosAVencer.BackgroundColor = System.Drawing.Color.White
        Me.DChequesProximosAVencer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DChequesProximosAVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DChequesProximosAVencer.GridColor = System.Drawing.Color.White
        Me.DChequesProximosAVencer.Location = New System.Drawing.Point(15, 292)
        Me.DChequesProximosAVencer.Name = "DChequesProximosAVencer"
        Me.DChequesProximosAVencer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DChequesProximosAVencer.Size = New System.Drawing.Size(400, 119)
        Me.DChequesProximosAVencer.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "SALDOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CuicchiGaveglio.My.Resources.Resources.fondo
        Me.PictureBox1.Location = New System.Drawing.Point(425, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 196)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.lblComun)
        Me.GroupBox1.Location = New System.Drawing.Point(425, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 119)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sesión:"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 175)
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.BackColor = System.Drawing.Color.White
        Me.MenuPrincipal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ComprobantesToolStripMenuItem, Me.REPORTESToolStripMenuItem, Me.AltaToolStripMenuItem, Me.EliiminarToolStripMenuItem, Me.PENDIENTESToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuPrincipal.Size = New System.Drawing.Size(719, 31)
        Me.MenuPrincipal.TabIndex = 11
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'PENDIENTESToolStripMenuItem
        '
        Me.PENDIENTESToolStripMenuItem.Name = "PENDIENTESToolStripMenuItem"
        Me.PENDIENTESToolStripMenuItem.Size = New System.Drawing.Size(111, 25)
        Me.PENDIENTESToolStripMenuItem.Text = "PENDIENTES"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 426)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DChequesProximosAVencer)
        Me.Controls.Add(Me.lblAdvertencias)
        Me.Controls.Add(Me.DSaldosPorComprobante)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuicchi Gaveglio"
        CType(Me.DSaldosPorComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DChequesProximosAVencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblComun As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAbrirAyuda As ToolStripMenuItem
    Friend WithEvents btnCerrarSesion As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAltaClientes As ToolStripMenuItem
    Friend WithEvents btnAltaBancos As ToolStripMenuItem
    Friend WithEvents ComprobantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents CompañiasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliiminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DSaldosPorComprobante As DataGridView
    Friend WithEvents lblAdvertencias As Label
    Friend WithEvents DChequesProximosAVencer As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents REPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents PLANILLASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPROBANTESToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PENDIENTESToolStripMenuItem As ToolStripMenuItem
End Class
