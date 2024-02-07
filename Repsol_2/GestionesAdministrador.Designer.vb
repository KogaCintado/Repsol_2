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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnVerTodosEmpleados = New System.Windows.Forms.Button()
        Me.btnSeleccionarUnEmpleado = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnVerTodosClientes = New System.Windows.Forms.Button()
        Me.btnVerCliente = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnVerTodosProductos = New System.Windows.Forms.Button()
        Me.btnVerProducto = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEliminarGas = New System.Windows.Forms.Button()
        Me.btnModificarGasolina = New System.Windows.Forms.Button()
        Me.btnVerTodasGasolinas = New System.Windows.Forms.Button()
        Me.btnVerGasolina = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnEliminarProveedor = New System.Windows.Forms.Button()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnVerTodosProveedores = New System.Windows.Forms.Button()
        Me.btnVerProveedor = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnModificarEmpleado)
        Me.Panel1.Controls.Add(Me.btnVerTodosEmpleados)
        Me.Panel1.Controls.Add(Me.btnSeleccionarUnEmpleado)
        Me.Panel1.Location = New System.Drawing.Point(183, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 51)
        Me.Panel1.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(98, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Eliminar Emp"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarEmpleado.TabIndex = 2
        Me.btnModificarEmpleado.Text = "Mod. Emp"
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'btnVerTodosEmpleados
        '
        Me.btnVerTodosEmpleados.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodosEmpleados.Name = "btnVerTodosEmpleados"
        Me.btnVerTodosEmpleados.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodosEmpleados.TabIndex = 1
        Me.btnVerTodosEmpleados.Text = "Ver Todos"
        Me.btnVerTodosEmpleados.UseVisualStyleBackColor = True
        '
        'btnSeleccionarUnEmpleado
        '
        Me.btnSeleccionarUnEmpleado.Location = New System.Drawing.Point(3, 0)
        Me.btnSeleccionarUnEmpleado.Name = "btnSeleccionarUnEmpleado"
        Me.btnSeleccionarUnEmpleado.Size = New System.Drawing.Size(89, 23)
        Me.btnSeleccionarUnEmpleado.TabIndex = 0
        Me.btnSeleccionarUnEmpleado.Text = "Ver Empleado"
        Me.btnSeleccionarUnEmpleado.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEliminarCliente)
        Me.Panel2.Controls.Add(Me.btnModificarCliente)
        Me.Panel2.Controls.Add(Me.btnVerTodosClientes)
        Me.Panel2.Controls.Add(Me.btnVerCliente)
        Me.Panel2.Location = New System.Drawing.Point(183, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 51)
        Me.Panel2.TabIndex = 4
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(98, 25)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarCliente.TabIndex = 3
        Me.btnEliminarCliente.Text = "Eliminar Cli"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarCliente.TabIndex = 2
        Me.btnModificarCliente.Text = "Mod. Cli"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnVerTodosClientes
        '
        Me.btnVerTodosClientes.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodosClientes.Name = "btnVerTodosClientes"
        Me.btnVerTodosClientes.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodosClientes.TabIndex = 1
        Me.btnVerTodosClientes.Text = "Ver Todos"
        Me.btnVerTodosClientes.UseVisualStyleBackColor = True
        '
        'btnVerCliente
        '
        Me.btnVerCliente.Location = New System.Drawing.Point(3, 0)
        Me.btnVerCliente.Name = "btnVerCliente"
        Me.btnVerCliente.Size = New System.Drawing.Size(89, 23)
        Me.btnVerCliente.TabIndex = 0
        Me.btnVerCliente.Text = "Ver Cliente"
        Me.btnVerCliente.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEliminarProducto)
        Me.Panel3.Controls.Add(Me.btnModificarProducto)
        Me.Panel3.Controls.Add(Me.btnVerTodosProductos)
        Me.Panel3.Controls.Add(Me.btnVerProducto)
        Me.Panel3.Location = New System.Drawing.Point(183, 195)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(196, 51)
        Me.Panel3.TabIndex = 5
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(98, 25)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarProducto.TabIndex = 3
        Me.btnEliminarProducto.Text = "Eliminar Prod"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarProducto.TabIndex = 2
        Me.btnModificarProducto.Text = "Mod. Prod"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnVerTodosProductos
        '
        Me.btnVerTodosProductos.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodosProductos.Name = "btnVerTodosProductos"
        Me.btnVerTodosProductos.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodosProductos.TabIndex = 1
        Me.btnVerTodosProductos.Text = "Ver Todos"
        Me.btnVerTodosProductos.UseVisualStyleBackColor = True
        '
        'btnVerProducto
        '
        Me.btnVerProducto.Location = New System.Drawing.Point(3, 0)
        Me.btnVerProducto.Name = "btnVerProducto"
        Me.btnVerProducto.Size = New System.Drawing.Size(89, 23)
        Me.btnVerProducto.TabIndex = 0
        Me.btnVerProducto.Text = "Ver Producto"
        Me.btnVerProducto.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnEliminarGas)
        Me.Panel4.Controls.Add(Me.btnModificarGasolina)
        Me.Panel4.Controls.Add(Me.btnVerTodasGasolinas)
        Me.Panel4.Controls.Add(Me.btnVerGasolina)
        Me.Panel4.Location = New System.Drawing.Point(183, 252)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(196, 51)
        Me.Panel4.TabIndex = 6
        '
        'btnEliminarGas
        '
        Me.btnEliminarGas.Location = New System.Drawing.Point(98, 25)
        Me.btnEliminarGas.Name = "btnEliminarGas"
        Me.btnEliminarGas.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarGas.TabIndex = 3
        Me.btnEliminarGas.Text = "Eliminar Gas"
        Me.btnEliminarGas.UseVisualStyleBackColor = True
        '
        'btnModificarGasolina
        '
        Me.btnModificarGasolina.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarGasolina.Name = "btnModificarGasolina"
        Me.btnModificarGasolina.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarGasolina.TabIndex = 2
        Me.btnModificarGasolina.Text = "Mod. Gas"
        Me.btnModificarGasolina.UseVisualStyleBackColor = True
        '
        'btnVerTodasGasolinas
        '
        Me.btnVerTodasGasolinas.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodasGasolinas.Name = "btnVerTodasGasolinas"
        Me.btnVerTodasGasolinas.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodasGasolinas.TabIndex = 1
        Me.btnVerTodasGasolinas.Text = "Ver Todos"
        Me.btnVerTodasGasolinas.UseVisualStyleBackColor = True
        '
        'btnVerGasolina
        '
        Me.btnVerGasolina.Location = New System.Drawing.Point(3, 0)
        Me.btnVerGasolina.Name = "btnVerGasolina"
        Me.btnVerGasolina.Size = New System.Drawing.Size(89, 23)
        Me.btnVerGasolina.TabIndex = 0
        Me.btnVerGasolina.Text = "Ver Gasolina"
        Me.btnVerGasolina.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnEliminarProveedor)
        Me.Panel5.Controls.Add(Me.btnModificarProveedor)
        Me.Panel5.Controls.Add(Me.btnVerTodosProveedores)
        Me.Panel5.Controls.Add(Me.btnVerProveedor)
        Me.Panel5.Location = New System.Drawing.Point(183, 309)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(196, 51)
        Me.Panel5.TabIndex = 7
        '
        'btnEliminarProveedor
        '
        Me.btnEliminarProveedor.Location = New System.Drawing.Point(98, 25)
        Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
        Me.btnEliminarProveedor.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarProveedor.TabIndex = 3
        Me.btnEliminarProveedor.Text = "Eliminar Prov"
        Me.btnEliminarProveedor.UseVisualStyleBackColor = True
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarProveedor.TabIndex = 2
        Me.btnModificarProveedor.Text = "Mod. Prov"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnVerTodosProveedores
        '
        Me.btnVerTodosProveedores.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodosProveedores.Name = "btnVerTodosProveedores"
        Me.btnVerTodosProveedores.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodosProveedores.TabIndex = 1
        Me.btnVerTodosProveedores.Text = "Ver Todos"
        Me.btnVerTodosProveedores.UseVisualStyleBackColor = True
        '
        'btnVerProveedor
        '
        Me.btnVerProveedor.Location = New System.Drawing.Point(3, 0)
        Me.btnVerProveedor.Name = "btnVerProveedor"
        Me.btnVerProveedor.Size = New System.Drawing.Size(89, 23)
        Me.btnVerProveedor.TabIndex = 0
        Me.btnVerProveedor.Text = "Ver Proveedor"
        Me.btnVerProveedor.UseVisualStyleBackColor = True
        '
        'GestionesAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionesAdministrador"
        Me.Text = "GestionesAdministrador"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnModificarEmpleado As Button
    Friend WithEvents btnVerTodosEmpleados As Button
    Friend WithEvents btnSeleccionarUnEmpleado As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnVerTodosClientes As Button
    Friend WithEvents btnVerCliente As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnVerTodosProductos As Button
    Friend WithEvents btnVerProducto As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnEliminarGas As Button
    Friend WithEvents btnModificarGasolina As Button
    Friend WithEvents btnVerTodasGasolinas As Button
    Friend WithEvents btnVerGasolina As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnVerTodosProveedores As Button
    Friend WithEvents btnVerProveedor As Button
End Class
