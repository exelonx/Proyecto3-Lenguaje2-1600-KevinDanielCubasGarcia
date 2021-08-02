<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInfo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVentanaSalir = New System.Windows.Forms.Button()
        Me.pbE = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnVentanaSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 29)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnVentanaSalir
        '
        Me.btnVentanaSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnVentanaSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaSalir.FlatAppearance.BorderSize = 0
        Me.btnVentanaSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnVentanaSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaSalir.Location = New System.Drawing.Point(370, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 0
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'pbE
        '
        Me.pbE.BackColor = System.Drawing.Color.Transparent
        Me.pbE.Location = New System.Drawing.Point(0, 0)
        Me.pbE.Name = "pbE"
        Me.pbE.Size = New System.Drawing.Size(411, 441)
        Me.pbE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbE.TabIndex = 1
        Me.pbE.TabStop = False
        '
        'FormInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.fondoInfoShadow5Fixed2
        Me.ClientSize = New System.Drawing.Size(411, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInfo"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVentanaSalir As Button
    Friend WithEvents pbE As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
