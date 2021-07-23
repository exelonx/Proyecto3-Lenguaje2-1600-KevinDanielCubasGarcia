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
        Me.btnTecno = New System.Windows.Forms.Button()
        Me.btnDeporte = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRopa = New System.Windows.Forms.Button()
        Me.btnBellSal = New System.Windows.Forms.Button()
        Me.btnEscOfi = New System.Windows.Forms.Button()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gpxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.chkMembresia = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelVentana.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxDatosGenerales.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelVentana.Size = New System.Drawing.Size(396, 29)
        Me.panelVentana.TabIndex = 0
        '
        'btnVentanaMin
        '
        Me.btnVentanaMin.BackColor = System.Drawing.Color.White
        Me.btnVentanaMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnVentanaMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaMin.Location = New System.Drawing.Point(314, 0)
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
        Me.btnVentanaSalir.Location = New System.Drawing.Point(355, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 0
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'btnTecno
        '
        Me.btnTecno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTecno.Location = New System.Drawing.Point(0, 0)
        Me.btnTecno.Name = "btnTecno"
        Me.btnTecno.Size = New System.Drawing.Size(126, 23)
        Me.btnTecno.TabIndex = 1
        Me.btnTecno.Text = "Tecnología"
        Me.btnTecno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTecno.UseVisualStyleBackColor = True
        '
        'btnDeporte
        '
        Me.btnDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeporte.Location = New System.Drawing.Point(0, 22)
        Me.btnDeporte.Name = "btnDeporte"
        Me.btnDeporte.Size = New System.Drawing.Size(126, 23)
        Me.btnDeporte.TabIndex = 2
        Me.btnDeporte.Text = "Deporte"
        Me.btnDeporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeporte.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRopa)
        Me.Panel1.Controls.Add(Me.btnBellSal)
        Me.Panel1.Controls.Add(Me.btnEscOfi)
        Me.Panel1.Controls.Add(Me.btnTecno)
        Me.Panel1.Controls.Add(Me.btnDeporte)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(126, 112)
        Me.Panel1.TabIndex = 3
        '
        'btnRopa
        '
        Me.btnRopa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRopa.Location = New System.Drawing.Point(0, 88)
        Me.btnRopa.Name = "btnRopa"
        Me.btnRopa.Size = New System.Drawing.Size(126, 23)
        Me.btnRopa.TabIndex = 5
        Me.btnRopa.Text = "Ropa"
        Me.btnRopa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRopa.UseVisualStyleBackColor = True
        '
        'btnBellSal
        '
        Me.btnBellSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBellSal.Location = New System.Drawing.Point(0, 66)
        Me.btnBellSal.Name = "btnBellSal"
        Me.btnBellSal.Size = New System.Drawing.Size(126, 23)
        Me.btnBellSal.TabIndex = 4
        Me.btnBellSal.Text = "Belleza y Salud"
        Me.btnBellSal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBellSal.UseVisualStyleBackColor = True
        '
        'btnEscOfi
        '
        Me.btnEscOfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEscOfi.Location = New System.Drawing.Point(0, 44)
        Me.btnEscOfi.Name = "btnEscOfi"
        Me.btnEscOfi.Size = New System.Drawing.Size(126, 23)
        Me.btnEscOfi.TabIndex = 3
        Me.btnEscOfi.Text = "Escolar y Oficina"
        Me.btnEscOfi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEscOfi.UseVisualStyleBackColor = True
        '
        'btnComprar
        '
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.Location = New System.Drawing.Point(132, 290)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(126, 23)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "Facturar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Location = New System.Drawing.Point(264, 290)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(126, 23)
        Me.btnHistorial.TabIndex = 5
        Me.btnHistorial.Text = "Ventas en la sesión"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(3, 290)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(126, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(372, 139)
        Me.DataGridView1.TabIndex = 6
        '
        'gpxDatosGenerales
        '
        Me.gpxDatosGenerales.Controls.Add(Me.chkMembresia)
        Me.gpxDatosGenerales.Controls.Add(Me.txtNombre)
        Me.gpxDatosGenerales.Controls.Add(Me.txtFactura)
        Me.gpxDatosGenerales.Controls.Add(Me.Label2)
        Me.gpxDatosGenerales.Controls.Add(Me.Label1)
        Me.gpxDatosGenerales.Location = New System.Drawing.Point(140, 36)
        Me.gpxDatosGenerales.Name = "gpxDatosGenerales"
        Me.gpxDatosGenerales.Size = New System.Drawing.Size(225, 104)
        Me.gpxDatosGenerales.TabIndex = 7
        Me.gpxDatosGenerales.TabStop = False
        Me.gpxDatosGenerales.Text = "Datos Generales"
        '
        'chkMembresia
        '
        Me.chkMembresia.AutoSize = True
        Me.chkMembresia.Location = New System.Drawing.Point(112, 73)
        Me.chkMembresia.Name = "chkMembresia"
        Me.chkMembresia.Size = New System.Drawing.Size(79, 17)
        Me.chkMembresia.TabIndex = 4
        Me.chkMembresia.Text = "Membresía"
        Me.chkMembresia.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(112, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(112, 21)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(43, 20)
        Me.txtFactura.TabIndex = 2
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Factura"
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(396, 318)
        Me.Controls.Add(Me.gpxDatosGenerales)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.panelVentana)
        Me.Controls.Add(Me.btnComprar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.panelVentana.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxDatosGenerales.ResumeLayout(False)
        Me.gpxDatosGenerales.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelVentana As Panel
    Friend WithEvents btnVentanaMin As Button
    Friend WithEvents btnVentanaSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTecno As Button
    Friend WithEvents btnDeporte As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRopa As Button
    Friend WithEvents btnBellSal As Button
    Friend WithEvents btnEscOfi As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnComprar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gpxDatosGenerales As GroupBox
    Friend WithEvents chkMembresia As CheckBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
