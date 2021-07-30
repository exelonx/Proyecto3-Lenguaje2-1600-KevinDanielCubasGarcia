<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.btnVentanaSalir = New System.Windows.Forms.Button()
        Me.btnVentanaMin = New System.Windows.Forms.Button()
        Me.panelVentana = New System.Windows.Forms.Panel()
        Me.chkMostrarContra = New System.Windows.Forms.CheckBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelVentana.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(97, 51)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(97, 84)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseña.TabIndex = 3
        '
        'btnValidar
        '
        Me.btnValidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnValidar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.ForeColor = System.Drawing.Color.White
        Me.btnValidar.Location = New System.Drawing.Point(0, 147)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(113, 29)
        Me.btnValidar.TabIndex = 4
        Me.btnValidar.Text = "Aceptar"
        Me.btnValidar.UseVisualStyleBackColor = False
        '
        'btnVentanaSalir
        '
        Me.btnVentanaSalir.BackColor = System.Drawing.Color.White
        Me.btnVentanaSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVentanaSalir.FlatAppearance.BorderSize = 0
        Me.btnVentanaSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnVentanaSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVentanaSalir.Location = New System.Drawing.Point(185, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 7
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'btnVentanaMin
        '
        Me.btnVentanaMin.BackColor = System.Drawing.Color.White
        Me.btnVentanaMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaMin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVentanaMin.FlatAppearance.BorderSize = 0
        Me.btnVentanaMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaMin.Location = New System.Drawing.Point(144, 0)
        Me.btnVentanaMin.Name = "btnVentanaMin"
        Me.btnVentanaMin.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaMin.TabIndex = 8
        Me.btnVentanaMin.Text = "-"
        Me.btnVentanaMin.UseVisualStyleBackColor = False
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
        Me.panelVentana.Size = New System.Drawing.Size(226, 29)
        Me.panelVentana.TabIndex = 9
        '
        'chkMostrarContra
        '
        Me.chkMostrarContra.AutoSize = True
        Me.chkMostrarContra.Location = New System.Drawing.Point(49, 114)
        Me.chkMostrarContra.Name = "chkMostrarContra"
        Me.chkMostrarContra.Size = New System.Drawing.Size(117, 17)
        Me.chkMostrarContra.TabIndex = 10
        Me.chkMostrarContra.Text = "Mostrar contraseña"
        Me.chkMostrarContra.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(113, 147)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(113, 29)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "pedrito"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "clavounclavito"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.logoDiunsa2_Fixed3
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 29)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(226, 176)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.chkMostrarContra)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelVentana)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.panelVentana.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents btnVentanaSalir As Button
    Friend WithEvents btnVentanaMin As Button
    Friend WithEvents panelVentana As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chkMostrarContra As CheckBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
