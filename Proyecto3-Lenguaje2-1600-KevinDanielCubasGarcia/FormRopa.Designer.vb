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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.gpxTipoCalcetines = New System.Windows.Forms.GroupBox()
        Me.cmbTipoCalcetin = New System.Windows.Forms.ComboBox()
        Me.chkPulceras = New System.Windows.Forms.CheckBox()
        Me.chkCalcetines = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbBanner = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbBotones = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAcumulador = New System.Windows.Forms.TextBox()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelVentana.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpxClasificacion.SuspendLayout()
        Me.gpxRopa.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.gpxTipoCalcetines.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBotones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelVentana.Size = New System.Drawing.Size(810, 29)
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
        Me.btnVentanaMin.Location = New System.Drawing.Point(728, 0)
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
        Me.btnVentanaSalir.Location = New System.Drawing.Point(769, 0)
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
        Me.GroupBox4.Controls.Add(Me.dgvSalida)
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
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(649, 405)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(161, 40)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Fixed2
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(649, 280)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 50)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonFixed2
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(649, 230)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(161, 50)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.White
        Me.btnCalcular.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonFixed2
        Me.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(649, 180)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(161, 50)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'dgvSalida
        '
        Me.dgvSalida.AllowUserToAddRows = False
        Me.dgvSalida.AllowUserToDeleteRows = False
        Me.dgvSalida.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.detalle, Me.precio, Me.cImpuesto, Me.cTotal})
        Me.dgvSalida.Location = New System.Drawing.Point(6, 20)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalida.Size = New System.Drawing.Size(413, 132)
        Me.dgvSalida.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.bannerModaDiunsaFixed22
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.txtAcumulador)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 151)
        Me.Panel1.TabIndex = 9
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
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Fixed
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(649, 330)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(161, 50)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        'pbBotones
        '
        Me.pbBotones.BackColor = System.Drawing.Color.White
        Me.pbBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbBotones.Location = New System.Drawing.Point(649, 180)
        Me.pbBotones.Name = "pbBotones"
        Me.pbBotones.Size = New System.Drawing.Size(161, 357)
        Me.pbBotones.TabIndex = 10
        Me.pbBotones.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(694, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Acumulado:"
        '
        'txtAcumulador
        '
        Me.txtAcumulador.Location = New System.Drawing.Point(697, 23)
        Me.txtAcumulador.Name = "txtAcumulador"
        Me.txtAcumulador.ReadOnly = True
        Me.txtAcumulador.Size = New System.Drawing.Size(100, 20)
        Me.txtAcumulador.TabIndex = 1
        Me.txtAcumulador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'detalle
        '
        Me.detalle.HeaderText = "Detalle"
        Me.detalle.Name = "detalle"
        Me.detalle.ReadOnly = True
        '
        'precio
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.precio.DefaultCellStyle = DataGridViewCellStyle1
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'cImpuesto
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cImpuesto.DefaultCellStyle = DataGridViewCellStyle2
        Me.cImpuesto.HeaderText = "Impuesto"
        Me.cImpuesto.Name = "cImpuesto"
        Me.cImpuesto.ReadOnly = True
        '
        'cTotal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        '
        'FormRopa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(810, 537)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.pbBotones)
        Me.Controls.Add(Me.Panel1)
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
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gpxTipoCalcetines.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBotones, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents txtExtras As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents gpxTipoCalcetines As GroupBox
    Friend WithEvents cmbTipoCalcetin As ComboBox
    Friend WithEvents chkPulceras As CheckBox
    Friend WithEvents chkCalcetines As CheckBox
    Friend WithEvents pbBanner As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbBotones As PictureBox
    Friend WithEvents txtAcumulador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cImpuesto As DataGridViewTextBoxColumn
    Friend WithEvents cTotal As DataGridViewTextBoxColumn
End Class
