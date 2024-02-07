<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionesAdministrador
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnGestionUsuarios = New System.Windows.Forms.Button()
        Me.btnGestionClientes = New System.Windows.Forms.Button()
        Me.btnGestionProductos = New System.Windows.Forms.Button()
        Me.btnGestionGasolina = New System.Windows.Forms.Button()
        Me.btnGestionProveedores = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionUsuarios)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionClientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionProductos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionGasolina)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionProveedores)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 78)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(165, 286)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnGestionUsuarios
        '
        Me.btnGestionUsuarios.Location = New System.Drawing.Point(3, 3)
        Me.btnGestionUsuarios.Name = "btnGestionUsuarios"
        Me.btnGestionUsuarios.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionUsuarios.TabIndex = 0
        Me.btnGestionUsuarios.Text = "Gestion Usuarios"
        Me.btnGestionUsuarios.UseVisualStyleBackColor = True
        '
        'btnGestionClientes
        '
        Me.btnGestionClientes.Location = New System.Drawing.Point(3, 60)
        Me.btnGestionClientes.Name = "btnGestionClientes"
        Me.btnGestionClientes.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionClientes.TabIndex = 1
        Me.btnGestionClientes.Text = "Gestion Clientes"
        Me.btnGestionClientes.UseVisualStyleBackColor = True
        '
        'btnGestionProductos
        '
        Me.btnGestionProductos.Location = New System.Drawing.Point(3, 117)
        Me.btnGestionProductos.Name = "btnGestionProductos"
        Me.btnGestionProductos.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionProductos.TabIndex = 2
        Me.btnGestionProductos.Text = "Gestion Productos"
        Me.btnGestionProductos.UseVisualStyleBackColor = True
        '
        'btnGestionGasolina
        '
        Me.btnGestionGasolina.Location = New System.Drawing.Point(3, 174)
        Me.btnGestionGasolina.Name = "btnGestionGasolina"
        Me.btnGestionGasolina.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionGasolina.TabIndex = 3
        Me.btnGestionGasolina.Text = "Gestion Gasolina"
        Me.btnGestionGasolina.UseVisualStyleBackColor = True
        '
        'btnGestionProveedores
        '
        Me.btnGestionProveedores.Location = New System.Drawing.Point(3, 231)
        Me.btnGestionProveedores.Name = "btnGestionProveedores"
        Me.btnGestionProveedores.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionProveedores.TabIndex = 4
        Me.btnGestionProveedores.Text = "Gestion Proveedores"
        Me.btnGestionProveedores.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1904, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'GestionesAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionesAdministrador"
        Me.Text = "GestionesAdministrador"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnGestionUsuarios As Button
    Friend WithEvents btnGestionClientes As Button
    Friend WithEvents btnGestionProductos As Button
    Friend WithEvents btnGestionGasolina As Button
    Friend WithEvents btnGestionProveedores As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
End Class
