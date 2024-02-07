<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opciones
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
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.btnCRUD = New System.Windows.Forms.Button()
        Me.btnTrabajar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirDelProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarElProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInformes
        '
        Me.btnInformes.Location = New System.Drawing.Point(106, 175)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(90, 60)
        Me.btnInformes.TabIndex = 0
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.UseVisualStyleBackColor = True
        Me.btnInformes.Visible = False
        '
        'btnCRUD
        '
        Me.btnCRUD.Location = New System.Drawing.Point(352, 175)
        Me.btnCRUD.Name = "btnCRUD"
        Me.btnCRUD.Size = New System.Drawing.Size(90, 60)
        Me.btnCRUD.TabIndex = 2
        Me.btnCRUD.Text = "CRUD"
        Me.btnCRUD.UseVisualStyleBackColor = True
        Me.btnCRUD.Visible = False
        '
        'btnTrabajar
        '
        Me.btnTrabajar.Location = New System.Drawing.Point(645, 175)
        Me.btnTrabajar.Name = "btnTrabajar"
        Me.btnTrabajar.Size = New System.Drawing.Size(90, 60)
        Me.btnTrabajar.TabIndex = 3
        Me.btnTrabajar.Text = "Trabajar"
        Me.btnTrabajar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirDelProgramaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirDelProgramaToolStripMenuItem
        '
        Me.SalirDelProgramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.CerrarElProgramaToolStripMenuItem})
        Me.SalirDelProgramaToolStripMenuItem.Name = "SalirDelProgramaToolStripMenuItem"
        Me.SalirDelProgramaToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirDelProgramaToolStripMenuItem.Text = "Salir"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'CerrarElProgramaToolStripMenuItem
        '
        Me.CerrarElProgramaToolStripMenuItem.Name = "CerrarElProgramaToolStripMenuItem"
        Me.CerrarElProgramaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarElProgramaToolStripMenuItem.Text = "Cerrar el programa"
        '
        'Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTrabajar)
        Me.Controls.Add(Me.btnCRUD)
        Me.Controls.Add(Me.btnInformes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Opciones"
        Me.Text = "Opciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInformes As Button
    Friend WithEvents btnCRUD As Button
    Friend WithEvents btnTrabajar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirDelProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarElProgramaToolStripMenuItem As ToolStripMenuItem
End Class
