<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TarjetaRepsol
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFechaAlta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblFechaAlta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblApellido1)
        Me.Panel1.Controls.Add(Me.lblApellido2)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Location = New System.Drawing.Point(177, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 219)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.Repsol_2.My.Resources.Resources.Repsol_logo
        Me.PictureBox1.Location = New System.Drawing.Point(40, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.AutoSize = True
        Me.lblFechaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAlta.Location = New System.Drawing.Point(100, 179)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(89, 15)
        Me.lblFechaAlta.TabIndex = 3
        Me.lblFechaAlta.Text = "Fecha_de_alta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha de alta:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(211, 37)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(77, 15)
        Me.lblApellido1.TabIndex = 1
        Me.lblApellido1.Text = "0000000000"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(284, 37)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(77, 15)
        Me.lblApellido2.TabIndex = 1
        Me.lblApellido2.Text = "0000000000"
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(13, 12)
        Me.lblId.Name = "lblId"
        Me.lblId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblId.Size = New System.Drawing.Size(43, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "000000"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(211, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "0000000000"
        '
        'TarjetaRepsol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TarjetaRepsol"
        Me.Text = "TarjetaRepsol"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblFechaAlta As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
