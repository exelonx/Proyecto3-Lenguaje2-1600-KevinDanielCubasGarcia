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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.panelVentana = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVentanaMin = New System.Windows.Forms.Button()
        Me.btnVentanaSalir = New System.Windows.Forms.Button()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gpxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.chkMembresia = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpxPago = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnTecno = New System.Windows.Forms.Button()
        Me.btnRopa = New System.Windows.Forms.Button()
        Me.btnEscOfi = New System.Windows.Forms.Button()
        Me.btnDeporte = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelVentana.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxDatosGenerales.SuspendLayout()
        Me.gpxPago.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelVentana.Size = New System.Drawing.Size(483, 29)
        Me.panelVentana.TabIndex = 0
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
        'btnVentanaMin
        '
        Me.btnVentanaMin.BackColor = System.Drawing.Color.White
        Me.btnVentanaMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnVentanaMin.FlatAppearance.BorderSize = 0
        Me.btnVentanaMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaMin.Location = New System.Drawing.Point(401, 0)
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
        Me.btnVentanaSalir.FlatAppearance.BorderSize = 0
        Me.btnVentanaSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnVentanaSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaSalir.Location = New System.Drawing.Point(442, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 0
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'btnComprar
        '
        Me.btnComprar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnComprar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.ForeColor = System.Drawing.Color.White
        Me.btnComprar.Location = New System.Drawing.Point(0, 177)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(128, 32)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "Facturar"
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'btnHistorial
        '
        Me.btnHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.Color.White
        Me.btnHistorial.Location = New System.Drawing.Point(0, 241)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(128, 32)
        Me.btnHistorial.TabIndex = 5
        Me.btnHistorial.Text = "Ventas en la sesión"
        Me.btnHistorial.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(134, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(342, 153)
        Me.DataGridView1.TabIndex = 6
        '
        'gpxDatosGenerales
        '
        Me.gpxDatosGenerales.Controls.Add(Me.chkMembresia)
        Me.gpxDatosGenerales.Controls.Add(Me.txtNombre)
        Me.gpxDatosGenerales.Controls.Add(Me.txtFactura)
        Me.gpxDatosGenerales.Controls.Add(Me.Label2)
        Me.gpxDatosGenerales.Controls.Add(Me.Label1)
        Me.gpxDatosGenerales.Location = New System.Drawing.Point(134, 35)
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
        'gpxPago
        '
        Me.gpxPago.Controls.Add(Me.RadioButton2)
        Me.gpxPago.Controls.Add(Me.RadioButton1)
        Me.gpxPago.Location = New System.Drawing.Point(365, 36)
        Me.gpxPago.Name = "gpxPago"
        Me.gpxPago.Size = New System.Drawing.Size(111, 103)
        Me.gpxPago.TabIndex = 9
        Me.gpxPago.TabStop = False
        Me.gpxPago.Text = "Metodo de Pago"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(19, 61)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Tarjeta"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 27)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Efectivo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(0, 273)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(128, 32)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(0, 209)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 32)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnTecno
        '
        Me.btnTecno.BackColor = System.Drawing.Color.White
        Me.btnTecno.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Tecnologia_Diunsa_Fixed
        Me.btnTecno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTecno.FlatAppearance.BorderSize = 0
        Me.btnTecno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnTecno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTecno.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTecno.Location = New System.Drawing.Point(0, 29)
        Me.btnTecno.Name = "btnTecno"
        Me.btnTecno.Size = New System.Drawing.Size(128, 32)
        Me.btnTecno.TabIndex = 1
        Me.btnTecno.Text = "Tecnología"
        Me.btnTecno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTecno.UseVisualStyleBackColor = False
        '
        'btnRopa
        '
        Me.btnRopa.BackColor = System.Drawing.Color.White
        Me.btnRopa.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Moda_Diunsa
        Me.btnRopa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRopa.FlatAppearance.BorderSize = 0
        Me.btnRopa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnRopa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRopa.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRopa.Location = New System.Drawing.Point(0, 93)
        Me.btnRopa.Name = "btnRopa"
        Me.btnRopa.Size = New System.Drawing.Size(128, 32)
        Me.btnRopa.TabIndex = 5
        Me.btnRopa.Text = "Ropa"
        Me.btnRopa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRopa.UseVisualStyleBackColor = False
        '
        'btnEscOfi
        '
        Me.btnEscOfi.BackColor = System.Drawing.Color.White
        Me.btnEscOfi.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Oficina_Diunsa_Fixed2
        Me.btnEscOfi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEscOfi.FlatAppearance.BorderSize = 0
        Me.btnEscOfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnEscOfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEscOfi.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscOfi.Location = New System.Drawing.Point(0, 61)
        Me.btnEscOfi.Name = "btnEscOfi"
        Me.btnEscOfi.Size = New System.Drawing.Size(128, 32)
        Me.btnEscOfi.TabIndex = 3
        Me.btnEscOfi.Text = "Oficina"
        Me.btnEscOfi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEscOfi.UseVisualStyleBackColor = False
        '
        'btnDeporte
        '
        Me.btnDeporte.BackColor = System.Drawing.Color.White
        Me.btnDeporte.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Deporte_Diunsa
        Me.btnDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeporte.FlatAppearance.BorderSize = 0
        Me.btnDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeporte.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeporte.Location = New System.Drawing.Point(0, 125)
        Me.btnDeporte.Name = "btnDeporte"
        Me.btnDeporte.Size = New System.Drawing.Size(128, 32)
        Me.btnDeporte.TabIndex = 2
        Me.btnDeporte.Text = "Deporte"
        Me.btnDeporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeporte.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 276)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(483, 305)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.gpxPago)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.btnTecno)
        Me.Controls.Add(Me.btnRopa)
        Me.Controls.Add(Me.btnEscOfi)
        Me.Controls.Add(Me.btnDeporte)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gpxDatosGenerales)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.panelVentana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Menú Principal"
        Me.panelVentana.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxDatosGenerales.ResumeLayout(False)
        Me.gpxDatosGenerales.PerformLayout()
        Me.gpxPago.ResumeLayout(False)
        Me.gpxPago.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelVentana As Panel
    Friend WithEvents btnVentanaMin As Button
    Friend WithEvents btnVentanaSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTecno As Button
    Friend WithEvents btnDeporte As Button
    Friend WithEvents btnRopa As Button
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gpxPago As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnEliminar As Button
End Class
