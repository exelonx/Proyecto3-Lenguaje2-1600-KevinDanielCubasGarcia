<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.panelVentana = New System.Windows.Forms.Panel()
        Me.btnVentanaMin = New System.Windows.Forms.Button()
        Me.btnVentanaSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panelVentana.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelVentana
        '
        Me.panelVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.panelVentana.Controls.Add(Me.PictureBox1)
        Me.panelVentana.Controls.Add(Me.btnVentanaMin)
        Me.panelVentana.Controls.Add(Me.btnVentanaSalir)
        Me.panelVentana.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelVentana.Location = New System.Drawing.Point(0, 0)
        Me.panelVentana.Name = "panelVentana"
        Me.panelVentana.Size = New System.Drawing.Size(440, 29)
        Me.panelVentana.TabIndex = 0
        '
        'btnVentanaMin
        '
        Me.btnVentanaMin.BackColor = System.Drawing.Color.White
        Me.btnVentanaMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnVentanaMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaMin.Location = New System.Drawing.Point(358, 0)
        Me.btnVentanaMin.Name = "btnVentanaMin"
        Me.btnVentanaMin.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaMin.TabIndex = 1
        Me.btnVentanaMin.Text = "-"
        Me.btnVentanaMin.UseVisualStyleBackColor = False
        '
        'btnVentanaSalir
        '
        Me.btnVentanaSalir.BackColor = System.Drawing.Color.White
        Me.btnVentanaSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnVentanaSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaSalir.Location = New System.Drawing.Point(399, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 0
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tecnología"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Deporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(126, 202)
        Me.Panel1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Escolar y Oficina"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 66)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Belleza y Salud"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(0, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Ropa"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.logoDiunsa2_Fixed3
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 29)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnComprar
        '
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.Location = New System.Drawing.Point(302, 206)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(126, 23)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "Facturar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(170, 206)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(126, 23)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Ventas en la sesión"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(0, 179)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(132, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(296, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 232)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.panelVentana)
        Me.Controls.Add(Me.btnComprar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.panelVentana.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelVentana As Panel
    Friend WithEvents btnVentanaMin As Button
    Friend WithEvents btnVentanaSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnComprar As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
