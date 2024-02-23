<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Opciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opciones))
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.btnTrabajar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirDelProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarElProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCRUD = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInformes
        '
        Me.btnInformes.Location = New System.Drawing.Point(3, 3)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(90, 60)
        Me.btnInformes.TabIndex = 3
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.UseVisualStyleBackColor = True
        Me.btnInformes.Visible = False
        '
        'btnTrabajar
        '
        Me.btnTrabajar.Location = New System.Drawing.Point(99, 3)
        Me.btnTrabajar.Name = "btnTrabajar"
        Me.btnTrabajar.Size = New System.Drawing.Size(90, 60)
        Me.btnTrabajar.TabIndex = 1
        Me.btnTrabajar.Text = "Trabajar"
        Me.btnTrabajar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirDelProgramaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1904, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirDelProgramaToolStripMenuItem
        '
        Me.SalirDelProgramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.CerrarElProgramaToolStripMenuItem})
        Me.SalirDelProgramaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirDelProgramaToolStripMenuItem.Name = "SalirDelProgramaToolStripMenuItem"
        Me.SalirDelProgramaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.SalirDelProgramaToolStripMenuItem.Text = "Opciones"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'CerrarElProgramaToolStripMenuItem
        '
        Me.CerrarElProgramaToolStripMenuItem.Name = "CerrarElProgramaToolStripMenuItem"
        Me.CerrarElProgramaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CerrarElProgramaToolStripMenuItem.Text = "Cerrar el programa"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnInformes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnTrabajar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCRUD)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(512, 242)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(292, 70)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'btnCRUD
        '
        Me.btnCRUD.Location = New System.Drawing.Point(195, 3)
        Me.btnCRUD.Name = "btnCRUD"
        Me.btnCRUD.Size = New System.Drawing.Size(90, 60)
        Me.btnCRUD.TabIndex = 3
        Me.btnCRUD.Text = "Crud"
        Me.btnCRUD.UseVisualStyleBackColor = True
        '
        'Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Opciones"
        Me.Text = "Opciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInformes As Button
    Friend WithEvents btnTrabajar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirDelProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarElProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCRUD As Button
End Class
