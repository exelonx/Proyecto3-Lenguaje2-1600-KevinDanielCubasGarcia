<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRopa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRopa))
        Me.panelVentana = New System.Windows.Forms.Panel()
        Me.btnVentanaMin = New System.Windows.Forms.Button()
        Me.btnVentanaSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gpxClasificacion = New System.Windows.Forms.GroupBox()
        Me.cmbClasificacion = New System.Windows.Forms.ComboBox()
        Me.rbMujer = New System.Windows.Forms.RadioButton()
        Me.rbHombre = New System.Windows.Forms.RadioButton()
        Me.gpxRopa = New System.Windows.Forms.GroupBox()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cmbRopa = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtExtras = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.gpxTipoCalcetines = New System.Windows.Forms.GroupBox()
        Me.cmbTipoCalcetin = New System.Windows.Forms.ComboBox()
        Me.chkPulceras = New System.Windows.Forms.CheckBox()
        Me.chkCalcetines = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbBanner = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelVentana.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpxClasificacion.SuspendLayout()
        Me.gpxRopa.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.gpxTipoCalcetines.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelVentana.Size = New System.Drawing.Size(792, 29)
        Me.panelVentana.TabIndex = 0
        '
        'btnVentanaMin
        '
        Me.btnVentanaMin.BackColor = System.Drawing.Color.White
        Me.btnVentanaMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaMin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVentanaMin.FlatAppearance.BorderSize = 0
        Me.btnVentanaMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaMin.Location = New System.Drawing.Point(710, 0)
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
        Me.btnVentanaSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVentanaSalir.FlatAppearance.BorderSize = 0
        Me.btnVentanaSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnVentanaSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaSalir.Location = New System.Drawing.Point(751, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 0
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gpxClasificacion)
        Me.GroupBox1.Controls.Add(Me.rbMujer)
        Me.GroupBox1.Controls.Add(Me.rbHombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Ropa"
        '
        'gpxClasificacion
        '
        Me.gpxClasificacion.Controls.Add(Me.cmbClasificacion)
        Me.gpxClasificacion.Enabled = False
        Me.gpxClasificacion.Location = New System.Drawing.Point(99, 19)
        Me.gpxClasificacion.Name = "gpxClasificacion"
        Me.gpxClasificacion.Size = New System.Drawing.Size(111, 61)
        Me.gpxClasificacion.TabIndex = 2
        Me.gpxClasificacion.TabStop = False
        Me.gpxClasificacion.Text = "Clasificación"
        '
        'cmbClasificacion
        '
        Me.cmbClasificacion.FormattingEnabled = True
        Me.cmbClasificacion.Location = New System.Drawing.Point(9, 24)
        Me.cmbClasificacion.Name = "cmbClasificacion"
        Me.cmbClasificacion.Size = New System.Drawing.Size(92, 21)
        Me.cmbClasificacion.TabIndex = 0
        '
        'rbMujer
        '
        Me.rbMujer.AutoSize = True
        Me.rbMujer.Location = New System.Drawing.Point(6, 49)
        Me.rbMujer.Name = "rbMujer"
        Me.rbMujer.Size = New System.Drawing.Size(76, 17)
        Me.rbMujer.TabIndex = 1
        Me.rbMujer.Text = "Para Mujer"
        Me.rbMujer.UseVisualStyleBackColor = True
        '
        'rbHombre
        '
        Me.rbHombre.AutoSize = True
        Me.rbHombre.Location = New System.Drawing.Point(6, 26)
        Me.rbHombre.Name = "rbHombre"
        Me.rbHombre.Size = New System.Drawing.Size(87, 17)
        Me.rbHombre.TabIndex = 0
        Me.rbHombre.Text = "Para Hombre"
        Me.rbHombre.UseVisualStyleBackColor = True
        '
        'gpxRopa
        '
        Me.gpxRopa.Controls.Add(Me.lbCantidad)
        Me.gpxRopa.Controls.Add(Me.txtCantidad)
        Me.gpxRopa.Controls.Add(Me.cmbRopa)
        Me.gpxRopa.Location = New System.Drawing.Point(236, 186)
        Me.gpxRopa.Name = "gpxRopa"
        Me.gpxRopa.Size = New System.Drawing.Size(176, 88)
        Me.gpxRopa.TabIndex = 2
        Me.gpxRopa.TabStop = False
        Me.gpxRopa.Text = "Ropa"
        Me.gpxRopa.Visible = False
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Enabled = False
        Me.lbCantidad.Location = New System.Drawing.Point(6, 57)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lbCantidad.TabIndex = 2
        Me.lbCantidad.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(64, 54)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'cmbRopa
        '
        Me.cmbRopa.FormattingEnabled = True
        Me.cmbRopa.Location = New System.Drawing.Point(6, 22)
        Me.cmbRopa.Name = "cmbRopa"
        Me.cmbRopa.Size = New System.Drawing.Size(158, 21)
        Me.cmbRopa.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtExtras)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.txtImpuesto)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.txtPrecio)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 158)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculos"
        '
        'txtExtras
        '
        Me.txtExtras.Location = New System.Drawing.Point(94, 46)
        Me.txtExtras.Name = "txtExtras"
        Me.txtExtras.ReadOnly = True
        Me.txtExtras.Size = New System.Drawing.Size(100, 20)
        Me.txtExtras.TabIndex = 9
        Me.txtExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Extras"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(94, 124)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(94, 98)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.ReadOnly = True
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto.TabIndex = 6
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(94, 72)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 5
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(94, 20)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 4
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Impuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SubTotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Precio"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGuardar)
        Me.GroupBox4.Controls.Add(Me.btnSalir)
        Me.GroupBox4.Controls.Add(Me.btnEliminar)
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Controls.Add(Me.btnCalcular)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(218, 280)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(425, 158)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Salida"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(228, 127)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(154, 127)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(80, 127)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.White
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Location = New System.Drawing.Point(6, 127)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(413, 101)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.gpxTipoCalcetines)
        Me.GroupBox6.Controls.Add(Me.chkPulceras)
        Me.GroupBox6.Controls.Add(Me.chkCalcetines)
        Me.GroupBox6.Location = New System.Drawing.Point(418, 186)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(225, 88)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Extras"
        '
        'gpxTipoCalcetines
        '
        Me.gpxTipoCalcetines.Controls.Add(Me.cmbTipoCalcetin)
        Me.gpxTipoCalcetines.Enabled = False
        Me.gpxTipoCalcetines.Location = New System.Drawing.Point(102, 13)
        Me.gpxTipoCalcetines.Name = "gpxTipoCalcetines"
        Me.gpxTipoCalcetines.Size = New System.Drawing.Size(112, 67)
        Me.gpxTipoCalcetines.TabIndex = 2
        Me.gpxTipoCalcetines.TabStop = False
        Me.gpxTipoCalcetines.Text = "Tipo de Calcetines"
        '
        'cmbTipoCalcetin
        '
        Me.cmbTipoCalcetin.FormattingEnabled = True
        Me.cmbTipoCalcetin.Items.AddRange(New Object() {"Calcetines cortos L.30.00", "Calcetines normales L.50.00", "Calcetines tobilleros L.60.00", "Calcetines largos L.75.00", "Calcetines extra largos L.90.00"})
        Me.cmbTipoCalcetin.Location = New System.Drawing.Point(6, 26)
        Me.cmbTipoCalcetin.Name = "cmbTipoCalcetin"
        Me.cmbTipoCalcetin.Size = New System.Drawing.Size(99, 21)
        Me.cmbTipoCalcetin.TabIndex = 0
        '
        'chkPulceras
        '
        Me.chkPulceras.AutoSize = True
        Me.chkPulceras.Location = New System.Drawing.Point(6, 51)
        Me.chkPulceras.Name = "chkPulceras"
        Me.chkPulceras.Size = New System.Drawing.Size(97, 17)
        Me.chkPulceras.TabIndex = 1
        Me.chkPulceras.Text = "Pulceras L.100"
        Me.chkPulceras.UseVisualStyleBackColor = True
        '
        'chkCalcetines
        '
        Me.chkCalcetines.AutoSize = True
        Me.chkCalcetines.Location = New System.Drawing.Point(6, 27)
        Me.chkCalcetines.Name = "chkCalcetines"
        Me.chkCalcetines.Size = New System.Drawing.Size(75, 17)
        Me.chkCalcetines.TabIndex = 0
        Me.chkCalcetines.Text = "Calcetines"
        Me.chkCalcetines.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(649, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 252)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.bannerModaDiunsa4
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 151)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 233)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'pbBanner
        '
        Me.pbBanner.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.bannerAccesorios
        Me.pbBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBanner.Location = New System.Drawing.Point(236, 444)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(176, 81)
        Me.pbBanner.TabIndex = 7
        Me.pbBanner.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.GuardarIcono
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(380, 123)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(37, 31)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        'FormRopa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 537)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pbBanner)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gpxRopa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panelVentana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRopa"
        Me.Text = "Ropa"
        Me.panelVentana.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpxClasificacion.ResumeLayout(False)
        Me.gpxRopa.ResumeLayout(False)
        Me.gpxRopa.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gpxTipoCalcetines.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelVentana As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVentanaMin As Button
    Friend WithEvents btnVentanaSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gpxRopa As GroupBox
    Friend WithEvents gpxClasificacion As GroupBox
    Friend WithEvents cmbClasificacion As ComboBox
    Friend WithEvents rbMujer As RadioButton
    Friend WithEvents rbHombre As RadioButton
    Friend WithEvents lbCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents cmbRopa As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtExtras As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents gpxTipoCalcetines As GroupBox
    Friend WithEvents cmbTipoCalcetin As ComboBox
    Friend WithEvents chkPulceras As CheckBox
    Friend WithEvents chkCalcetines As CheckBox
    Friend WithEvents pbBanner As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Panel1 As Panel
End Class
