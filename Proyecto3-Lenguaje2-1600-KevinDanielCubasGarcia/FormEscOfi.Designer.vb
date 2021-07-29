<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEscOfi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEscOfi))
        Me.panelVentana = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVentanaMin = New System.Windows.Forms.Button()
        Me.btnVentanaSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkExtras = New System.Windows.Forms.CheckBox()
        Me.rbLapices = New System.Windows.Forms.RadioButton()
        Me.rbSillas = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtSubT = New System.Windows.Forms.TextBox()
        Me.txtExtras = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuestoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.gpxTipoProducto = New System.Windows.Forms.GroupBox()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkBorrador = New System.Windows.Forms.CheckBox()
        Me.chkSacapuntas = New System.Windows.Forms.CheckBox()
        Me.chkPapel = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAcumulador = New System.Windows.Forms.TextBox()
        Me.panelVentana.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxTipoProducto.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.panelVentana.Size = New System.Drawing.Size(689, 29)
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
        Me.btnVentanaMin.FlatAppearance.BorderSize = 0
        Me.btnVentanaMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaMin.Location = New System.Drawing.Point(607, 0)
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
        Me.btnVentanaSalir.FlatAppearance.BorderSize = 0
        Me.btnVentanaSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnVentanaSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaSalir.Location = New System.Drawing.Point(648, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 0
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkExtras)
        Me.GroupBox1.Controls.Add(Me.rbLapices)
        Me.GroupBox1.Controls.Add(Me.rbSillas)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 81)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de productos"
        '
        'chkExtras
        '
        Me.chkExtras.AutoSize = True
        Me.chkExtras.Location = New System.Drawing.Point(80, 26)
        Me.chkExtras.Name = "chkExtras"
        Me.chkExtras.Size = New System.Drawing.Size(79, 17)
        Me.chkExtras.TabIndex = 2
        Me.chkExtras.Text = "Solo Extras"
        Me.chkExtras.UseVisualStyleBackColor = True
        '
        'rbLapices
        '
        Me.rbLapices.AutoSize = True
        Me.rbLapices.Location = New System.Drawing.Point(5, 48)
        Me.rbLapices.Name = "rbLapices"
        Me.rbLapices.Size = New System.Drawing.Size(121, 17)
        Me.rbLapices.TabIndex = 1
        Me.rbLapices.TabStop = True
        Me.rbLapices.Text = "Bolígrafos y Lapices"
        Me.rbLapices.UseVisualStyleBackColor = True
        '
        'rbSillas
        '
        Me.rbSillas.AutoSize = True
        Me.rbSillas.Location = New System.Drawing.Point(6, 25)
        Me.rbSillas.Name = "rbSillas"
        Me.rbSillas.Size = New System.Drawing.Size(49, 17)
        Me.rbSillas.TabIndex = 0
        Me.rbSillas.TabStop = True
        Me.rbSillas.Text = "Sillas"
        Me.rbSillas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtImpuesto)
        Me.GroupBox2.Controls.Add(Me.txtSubT)
        Me.GroupBox2.Controls.Add(Me.txtExtras)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 154)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calculos"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(59, 123)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(59, 97)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.ReadOnly = True
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto.TabIndex = 8
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubT
        '
        Me.txtSubT.Location = New System.Drawing.Point(59, 71)
        Me.txtSubT.Name = "txtSubT"
        Me.txtSubT.ReadOnly = True
        Me.txtSubT.Size = New System.Drawing.Size(100, 20)
        Me.txtSubT.TabIndex = 7
        Me.txtSubT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtExtras
        '
        Me.txtExtras.Location = New System.Drawing.Point(59, 45)
        Me.txtExtras.Name = "txtExtras"
        Me.txtExtras.ReadOnly = True
        Me.txtExtras.Size = New System.Drawing.Size(100, 20)
        Me.txtExtras.TabIndex = 6
        Me.txtExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(59, 19)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 5
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Impuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SubTotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Extras"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvSalida)
        Me.GroupBox3.Location = New System.Drawing.Point(184, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(338, 154)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Salida"
        '
        'dgvSalida
        '
        Me.dgvSalida.AllowUserToAddRows = False
        Me.dgvSalida.AllowUserToDeleteRows = False
        Me.dgvSalida.AllowUserToOrderColumns = True
        Me.dgvSalida.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.detalle, Me.precio, Me.impuestoC, Me.totalC})
        Me.dgvSalida.Location = New System.Drawing.Point(7, 20)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.ReadOnly = True
        Me.dgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalida.Size = New System.Drawing.Size(325, 128)
        Me.dgvSalida.TabIndex = 0
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
        'impuestoC
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.impuestoC.DefaultCellStyle = DataGridViewCellStyle2
        Me.impuestoC.HeaderText = "Impuesto"
        Me.impuestoC.Name = "impuestoC"
        Me.impuestoC.ReadOnly = True
        '
        'totalC
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.totalC.DefaultCellStyle = DataGridViewCellStyle3
        Me.totalC.HeaderText = "Total"
        Me.totalC.Name = "totalC"
        Me.totalC.ReadOnly = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(528, 393)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(161, 40)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'gpxTipoProducto
        '
        Me.gpxTipoProducto.Controls.Add(Me.lbCantidad)
        Me.gpxTipoProducto.Controls.Add(Me.txtCantidad)
        Me.gpxTipoProducto.Controls.Add(Me.cmbProductos)
        Me.gpxTipoProducto.Location = New System.Drawing.Point(184, 186)
        Me.gpxTipoProducto.Name = "gpxTipoProducto"
        Me.gpxTipoProducto.Size = New System.Drawing.Size(175, 81)
        Me.gpxTipoProducto.TabIndex = 11
        Me.gpxTipoProducto.TabStop = False
        Me.gpxTipoProducto.Text = "Productos"
        Me.gpxTipoProducto.Visible = False
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Enabled = False
        Me.lbCantidad.Location = New System.Drawing.Point(7, 51)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lbCantidad.TabIndex = 2
        Me.lbCantidad.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(65, 48)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(7, 21)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(158, 21)
        Me.cmbProductos.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkBorrador)
        Me.GroupBox5.Controls.Add(Me.chkSacapuntas)
        Me.GroupBox5.Controls.Add(Me.chkPapel)
        Me.GroupBox5.Location = New System.Drawing.Point(365, 186)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(157, 81)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Extras"
        '
        'chkBorrador
        '
        Me.chkBorrador.AutoSize = True
        Me.chkBorrador.Location = New System.Drawing.Point(6, 55)
        Me.chkBorrador.Name = "chkBorrador"
        Me.chkBorrador.Size = New System.Drawing.Size(150, 17)
        Me.chkBorrador.TabIndex = 2
        Me.chkBorrador.Text = "Borrador              L.    5.00"
        Me.chkBorrador.UseVisualStyleBackColor = True
        '
        'chkSacapuntas
        '
        Me.chkSacapuntas.AutoSize = True
        Me.chkSacapuntas.Location = New System.Drawing.Point(6, 37)
        Me.chkSacapuntas.Name = "chkSacapuntas"
        Me.chkSacapuntas.Size = New System.Drawing.Size(149, 17)
        Me.chkSacapuntas.TabIndex = 1
        Me.chkSacapuntas.Text = "Sacapuntas        L.  10.00"
        Me.chkSacapuntas.UseVisualStyleBackColor = True
        '
        'chkPapel
        '
        Me.chkPapel.AutoSize = True
        Me.chkPapel.Location = New System.Drawing.Point(6, 19)
        Me.chkPapel.Name = "chkPapel"
        Me.chkPapel.Size = New System.Drawing.Size(148, 17)
        Me.chkPapel.TabIndex = 0
        Me.chkPapel.Text = "Resma de papel L.150.00"
        Me.chkPapel.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.bannerAccesorios1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(184, 434)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 75)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Fixed
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(528, 330)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(161, 50)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Fixed2
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(528, 280)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 50)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonFixed2
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(528, 230)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(161, 50)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.White
        Me.btnCalcular.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonFixed2
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.Black
        Me.btnCalcular.Location = New System.Drawing.Point(528, 180)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(161, 50)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(528, 180)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 365)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.bannerOficinaDiunsa
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtAcumulador)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(689, 151)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(574, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Acumulado:"
        '
        'txtAcumulador
        '
        Me.txtAcumulador.Location = New System.Drawing.Point(577, 23)
        Me.txtAcumulador.Name = "txtAcumulador"
        Me.txtAcumulador.ReadOnly = True
        Me.txtAcumulador.Size = New System.Drawing.Size(100, 20)
        Me.txtAcumulador.TabIndex = 0
        '
        'FormEscOfi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 545)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gpxTipoProducto)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelVentana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEscOfi"
        Me.Text = "FormEscOfi"
        Me.panelVentana.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxTipoProducto.ResumeLayout(False)
        Me.gpxTipoProducto.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelVentana As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVentanaMin As Button
    Friend WithEvents btnVentanaSalir As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbLapices As RadioButton
    Friend WithEvents rbSillas As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkExtras As CheckBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents gpxTipoProducto As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtSubT As TextBox
    Friend WithEvents txtExtras As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents chkBorrador As CheckBox
    Friend WithEvents chkSacapuntas As CheckBox
    Friend WithEvents chkPapel As CheckBox
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents impuestoC As DataGridViewTextBoxColumn
    Friend WithEvents totalC As DataGridViewTextBoxColumn
    Friend WithEvents txtAcumulador As TextBox
    Friend WithEvents Label6 As Label
    Public WithEvents dgvSalida As DataGridView
End Class
