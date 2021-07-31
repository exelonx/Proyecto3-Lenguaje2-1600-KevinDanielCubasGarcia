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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.panelVentana = New System.Windows.Forms.Panel()
        Me.btnVentanaMin = New System.Windows.Forms.Button()
        Me.btnVentanaSalir = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMembresia = New System.Windows.Forms.CheckBox()
        Me.gpxPago = New System.Windows.Forms.GroupBox()
        Me.rbTarjeta = New System.Windows.Forms.RadioButton()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSubT = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnTecno = New System.Windows.Forms.Button()
        Me.btnRopa = New System.Windows.Forms.Button()
        Me.btnEscOfi = New System.Windows.Forms.Button()
        Me.btnDeporte = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelVentana.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxDatosGenerales.SuspendLayout()
        Me.gpxPago.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelVentana
        '
        Me.panelVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.panelVentana.Controls.Add(Me.btnInfo)
        Me.panelVentana.Controls.Add(Me.PictureBox1)
        Me.panelVentana.Controls.Add(Me.btnVentanaMin)
        Me.panelVentana.Controls.Add(Me.btnVentanaSalir)
        Me.panelVentana.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelVentana.Location = New System.Drawing.Point(0, 0)
        Me.panelVentana.Name = "panelVentana"
        Me.panelVentana.Size = New System.Drawing.Size(572, 29)
        Me.panelVentana.TabIndex = 0
        '
        'btnVentanaMin
        '
        Me.btnVentanaMin.BackColor = System.Drawing.Color.White
        Me.btnVentanaMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVentanaMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnVentanaMin.FlatAppearance.BorderSize = 0
        Me.btnVentanaMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaMin.Location = New System.Drawing.Point(490, 0)
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
        Me.btnVentanaSalir.Location = New System.Drawing.Point(531, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 0
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'btnFacturar
        '
        Me.btnFacturar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFacturar.Enabled = False
        Me.btnFacturar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnFacturar.FlatAppearance.BorderSize = 0
        Me.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.ForeColor = System.Drawing.Color.White
        Me.btnFacturar.Location = New System.Drawing.Point(0, 263)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(128, 32)
        Me.btnFacturar.TabIndex = 4
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = False
        '
        'btnHistorial
        '
        Me.btnHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnHistorial.FlatAppearance.BorderSize = 0
        Me.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.Color.White
        Me.btnHistorial.Location = New System.Drawing.Point(0, 327)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(128, 32)
        Me.btnHistorial.TabIndex = 5
        Me.btnHistorial.Text = "Ventas en la sesión"
        Me.btnHistorial.UseVisualStyleBackColor = False
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.BackgroundColor = System.Drawing.Color.White
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.detalle, Me.precio, Me.descuento, Me.Impuesto, Me.total})
        Me.dgvMain.Location = New System.Drawing.Point(134, 119)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(426, 159)
        Me.dgvMain.TabIndex = 6
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
        Me.precio.Width = 80
        '
        'descuento
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descuento.DefaultCellStyle = DataGridViewCellStyle2
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Width = 65
        '
        'Impuesto
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Impuesto.DefaultCellStyle = DataGridViewCellStyle3
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.ReadOnly = True
        Me.Impuesto.Width = 60
        '
        'total
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle4
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 75
        '
        'gpxDatosGenerales
        '
        Me.gpxDatosGenerales.Controls.Add(Me.txtNombre)
        Me.gpxDatosGenerales.Controls.Add(Me.txtFactura)
        Me.gpxDatosGenerales.Controls.Add(Me.Label2)
        Me.gpxDatosGenerales.Controls.Add(Me.Label1)
        Me.gpxDatosGenerales.Location = New System.Drawing.Point(134, 35)
        Me.gpxDatosGenerales.Name = "gpxDatosGenerales"
        Me.gpxDatosGenerales.Size = New System.Drawing.Size(225, 78)
        Me.gpxDatosGenerales.TabIndex = 7
        Me.gpxDatosGenerales.TabStop = False
        Me.gpxDatosGenerales.Text = "Datos Generales"
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
        'chkMembresia
        '
        Me.chkMembresia.AutoSize = True
        Me.chkMembresia.Location = New System.Drawing.Point(110, 35)
        Me.chkMembresia.Name = "chkMembresia"
        Me.chkMembresia.Size = New System.Drawing.Size(79, 17)
        Me.chkMembresia.TabIndex = 4
        Me.chkMembresia.Text = "Membresía"
        Me.chkMembresia.UseVisualStyleBackColor = True
        '
        'gpxPago
        '
        Me.gpxPago.Controls.Add(Me.chkMembresia)
        Me.gpxPago.Controls.Add(Me.rbTarjeta)
        Me.gpxPago.Controls.Add(Me.rbEfectivo)
        Me.gpxPago.Location = New System.Drawing.Point(365, 36)
        Me.gpxPago.Name = "gpxPago"
        Me.gpxPago.Size = New System.Drawing.Size(195, 77)
        Me.gpxPago.TabIndex = 9
        Me.gpxPago.TabStop = False
        Me.gpxPago.Text = "Metodo de Pago"
        '
        'rbTarjeta
        '
        Me.rbTarjeta.AutoSize = True
        Me.rbTarjeta.Location = New System.Drawing.Point(19, 47)
        Me.rbTarjeta.Name = "rbTarjeta"
        Me.rbTarjeta.Size = New System.Drawing.Size(58, 17)
        Me.rbTarjeta.TabIndex = 1
        Me.rbTarjeta.TabStop = True
        Me.rbTarjeta.Text = "Tarjeta"
        Me.rbTarjeta.UseVisualStyleBackColor = True
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Location = New System.Drawing.Point(19, 21)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbEfectivo.TabIndex = 0
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(0, 359)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(128, 32)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(0, 295)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 32)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(460, 362)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "IVA:"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(460, 336)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtIVA.TabIndex = 14
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "SubTotal:"
        '
        'txtSubT
        '
        Me.txtSubT.Location = New System.Drawing.Point(460, 284)
        Me.txtSubT.Name = "txtSubT"
        Me.txtSubT.ReadOnly = True
        Me.txtSubT.Size = New System.Drawing.Size(100, 20)
        Me.txtSubT.TabIndex = 16
        Me.txtSubT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(460, 310)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtDesc.TabIndex = 17
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(385, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Descuento:"
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.White
        Me.btnInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Location = New System.Drawing.Point(449, 0)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(41, 29)
        Me.btnInfo.TabIndex = 3
        Me.btnInfo.Text = "?"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnTecno
        '
        Me.btnTecno.BackColor = System.Drawing.Color.White
        Me.btnTecno.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Tecnologia_Diunsa_Fixed2
        Me.btnTecno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTecno.FlatAppearance.BorderSize = 0
        Me.btnTecno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
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
        Me.btnRopa.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Moda_Diunsa_Fixed
        Me.btnRopa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRopa.FlatAppearance.BorderSize = 0
        Me.btnRopa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
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
        Me.btnEscOfi.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Oficina2_Diunsa_Fixed2
        Me.btnEscOfi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEscOfi.FlatAppearance.BorderSize = 0
        Me.btnEscOfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
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
        Me.btnDeporte.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Deporte_Diunsa_Fixed2
        Me.btnDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeporte.FlatAppearance.BorderSize = 0
        Me.btnDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
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
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 362)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
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
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.NuevoLogo_DIUNSA_Color
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(133, 271)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(245, 128)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(572, 391)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtSubT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.gpxPago)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.btnTecno)
        Me.Controls.Add(Me.btnRopa)
        Me.Controls.Add(Me.btnEscOfi)
        Me.Controls.Add(Me.btnDeporte)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gpxDatosGenerales)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.panelVentana)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.panelVentana.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxDatosGenerales.ResumeLayout(False)
        Me.gpxDatosGenerales.PerformLayout()
        Me.gpxPago.ResumeLayout(False)
        Me.gpxPago.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnFacturar As Button
    Friend WithEvents gpxDatosGenerales As GroupBox
    Friend WithEvents chkMembresia As CheckBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gpxPago As GroupBox
    Friend WithEvents rbTarjeta As RadioButton
    Friend WithEvents rbEfectivo As RadioButton
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents dgvMain As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSubT As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents btnInfo As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
