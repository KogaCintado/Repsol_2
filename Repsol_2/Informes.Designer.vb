<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolevrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnInformesEmpleados = New System.Windows.Forms.Button()
        Me.btnInformesClientes = New System.Windows.Forms.Button()
        Me.btnInformesProductos = New System.Windows.Forms.Button()
        Me.btnInformesGasolinas = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolevrToolStripMenuItem, Me.CerrarSesionToolStripMenuItem, Me.CerrarProgramaToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VolevrToolStripMenuItem
        '
        Me.VolevrToolStripMenuItem.Name = "VolevrToolStripMenuItem"
        Me.VolevrToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VolevrToolStripMenuItem.Text = "Volver"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'CerrarProgramaToolStripMenuItem
        '
        Me.CerrarProgramaToolStripMenuItem.Name = "CerrarProgramaToolStripMenuItem"
        Me.CerrarProgramaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarProgramaToolStripMenuItem.Text = "Cerrar Programa"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1904, 1017)
        Me.CrystalReportViewer1.TabIndex = 2
        '
        'btnInformesEmpleados
        '
        Me.btnInformesEmpleados.Location = New System.Drawing.Point(12, 71)
        Me.btnInformesEmpleados.Name = "btnInformesEmpleados"
        Me.btnInformesEmpleados.Size = New System.Drawing.Size(178, 23)
        Me.btnInformesEmpleados.TabIndex = 3
        Me.btnInformesEmpleados.Text = "Ejecutar Informe Empleados"
        Me.btnInformesEmpleados.UseVisualStyleBackColor = True
        '
        'btnInformesClientes
        '
        Me.btnInformesClientes.Location = New System.Drawing.Point(12, 100)
        Me.btnInformesClientes.Name = "btnInformesClientes"
        Me.btnInformesClientes.Size = New System.Drawing.Size(178, 23)
        Me.btnInformesClientes.TabIndex = 4
        Me.btnInformesClientes.Text = "Ejecutar Informe Clientes"
        Me.btnInformesClientes.UseVisualStyleBackColor = True
        '
        'btnInformesProductos
        '
        Me.btnInformesProductos.Location = New System.Drawing.Point(12, 129)
        Me.btnInformesProductos.Name = "btnInformesProductos"
        Me.btnInformesProductos.Size = New System.Drawing.Size(178, 23)
        Me.btnInformesProductos.TabIndex = 5
        Me.btnInformesProductos.Text = "Ejecutar Informe Productos"
        Me.btnInformesProductos.UseVisualStyleBackColor = True
        '
        'btnInformesGasolinas
        '
        Me.btnInformesGasolinas.Location = New System.Drawing.Point(12, 158)
        Me.btnInformesGasolinas.Name = "btnInformesGasolinas"
        Me.btnInformesGasolinas.Size = New System.Drawing.Size(178, 23)
        Me.btnInformesGasolinas.TabIndex = 6
        Me.btnInformesGasolinas.Text = "Ejecutar Informe Gasolinas"
        Me.btnInformesGasolinas.UseVisualStyleBackColor = True
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.btnInformesGasolinas)
        Me.Controls.Add(Me.btnInformesProductos)
        Me.Controls.Add(Me.btnInformesClientes)
        Me.Controls.Add(Me.btnInformesEmpleados)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Informes"
        Me.Text = "Informes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolevrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnInformesEmpleados As Button
    Friend WithEvents btnInformesClientes As Button
    Friend WithEvents btnInformesProductos As Button
    Friend WithEvents btnInformesGasolinas As Button
End Class
