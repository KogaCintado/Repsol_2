﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gasolina
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gasolina))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNombreGas = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrecioGasAcumulado = New System.Windows.Forms.Label()
        Me.lblPrecioGas = New System.Windows.Forms.Label()
        Me.btnGas95 = New System.Windows.Forms.Button()
        Me.btnGas98 = New System.Windows.Forms.Button()
        Me.btnDieselE = New System.Windows.Forms.Button()
        Me.btnDieselE10 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(210, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1500, 800)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(908, 839)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gasolina:"
        '
        'Timer1
        '
        '
        'lblNombreGas
        '
        Me.lblNombreGas.AutoSize = True
        Me.lblNombreGas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreGas.Location = New System.Drawing.Point(1004, 839)
        Me.lblNombreGas.Name = "lblNombreGas"
        Me.lblNombreGas.Size = New System.Drawing.Size(119, 18)
        Me.lblNombreGas.TabIndex = 2
        Me.lblNombreGas.Text = "BORRARTEXTo"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(1013, 909)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(184, 55)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(908, 865)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Coste:"
        '
        'lblPrecioGasAcumulado
        '
        Me.lblPrecioGasAcumulado.AutoSize = True
        Me.lblPrecioGasAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioGasAcumulado.Location = New System.Drawing.Point(1004, 865)
        Me.lblPrecioGasAcumulado.Name = "lblPrecioGasAcumulado"
        Me.lblPrecioGasAcumulado.Size = New System.Drawing.Size(119, 18)
        Me.lblPrecioGasAcumulado.TabIndex = 5
        Me.lblPrecioGasAcumulado.Text = "BORRARTEXTo"
        '
        'lblPrecioGas
        '
        Me.lblPrecioGas.AutoSize = True
        Me.lblPrecioGas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioGas.Location = New System.Drawing.Point(1163, 839)
        Me.lblPrecioGas.Name = "lblPrecioGas"
        Me.lblPrecioGas.Size = New System.Drawing.Size(119, 18)
        Me.lblPrecioGas.TabIndex = 6
        Me.lblPrecioGas.Text = "BORRARTEXTo"
        '
        'btnGas95
        '
        Me.btnGas95.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGas95.Location = New System.Drawing.Point(226, 37)
        Me.btnGas95.Name = "btnGas95"
        Me.btnGas95.Size = New System.Drawing.Size(349, 768)
        Me.btnGas95.TabIndex = 7
        Me.btnGas95.UseVisualStyleBackColor = True
        '
        'btnGas98
        '
        Me.btnGas98.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGas98.Location = New System.Drawing.Point(604, 37)
        Me.btnGas98.Name = "btnGas98"
        Me.btnGas98.Size = New System.Drawing.Size(349, 768)
        Me.btnGas98.TabIndex = 8
        Me.btnGas98.UseVisualStyleBackColor = True
        '
        'btnDieselE
        '
        Me.btnDieselE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDieselE.Location = New System.Drawing.Point(971, 37)
        Me.btnDieselE.Name = "btnDieselE"
        Me.btnDieselE.Size = New System.Drawing.Size(349, 768)
        Me.btnDieselE.TabIndex = 9
        Me.btnDieselE.UseVisualStyleBackColor = True
        '
        'btnDieselE10
        '
        Me.btnDieselE10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDieselE10.Location = New System.Drawing.Point(1346, 37)
        Me.btnDieselE10.Name = "btnDieselE10"
        Me.btnDieselE10.Size = New System.Drawing.Size(349, 768)
        Me.btnDieselE10.TabIndex = 10
        Me.btnDieselE10.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1310, 827)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(400, 30)
        Me.ProgressBar1.TabIndex = 11
        '
        'Gasolina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDieselE10)
        Me.Controls.Add(Me.btnDieselE)
        Me.Controls.Add(Me.btnGas98)
        Me.Controls.Add(Me.lblPrecioGas)
        Me.Controls.Add(Me.lblPrecioGasAcumulado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNombreGas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGas95)
        Me.Name = "Gasolina"
        Me.Text = "Gasolina"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNombreGas As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrecioGasAcumulado As Label
    Friend WithEvents lblPrecioGas As Label
    Friend WithEvents btnGas95 As Button
    Friend WithEvents btnGas98 As Button
    Friend WithEvents btnDieselE As Button
    Friend WithEvents btnDieselE10 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
