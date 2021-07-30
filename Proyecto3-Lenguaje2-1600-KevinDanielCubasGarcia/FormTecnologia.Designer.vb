<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTecnologia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTecnologia))
        Me.panelVentana = New System.Windows.Forms.Panel()
        Me.btnVentanaMin = New System.Windows.Forms.Button()
        Me.btnVentanaSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSoloAccesorios = New System.Windows.Forms.RadioButton()
        Me.rbCelulares = New System.Windows.Forms.RadioButton()
        Me.rbComputadoras = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtSubT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAccesorios = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecioB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.gpxAccesorios = New System.Windows.Forms.GroupBox()
        Me.cmbAcces3 = New System.Windows.Forms.ComboBox()
        Me.cmbAcces2 = New System.Windows.Forms.ComboBox()
        Me.cmbAcces1 = New System.Windows.Forms.ComboBox()
        Me.chkAcces3 = New System.Windows.Forms.CheckBox()
        Me.chkAcces2 = New System.Windows.Forms.CheckBox()
        Me.chkAcces1 = New System.Windows.Forms.CheckBox()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.txtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.gpxProducto = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pbAccesorios = New System.Windows.Forms.PictureBox()
        Me.pbBotones = New System.Windows.Forms.PictureBox()
        Me.txtAcumulador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelVentana.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxAccesorios.SuspendLayout()
        Me.gpxProducto.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAccesorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelVentana
        '
        Me.panelVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.panelVentana.Controls.Add(Me.btnVentanaMin)
        Me.panelVentana.Controls.Add(Me.btnVentanaSalir)
        Me.panelVentana.Controls.Add(Me.PictureBox1)
        Me.panelVentana.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelVentana.Location = New System.Drawing.Point(0, 0)
        Me.panelVentana.Name = "panelVentana"
        Me.panelVentana.Size = New System.Drawing.Size(717, 29)
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
        Me.btnVentanaMin.Location = New System.Drawing.Point(635, 0)
        Me.btnVentanaMin.Name = "btnVentanaMin"
        Me.btnVentanaMin.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaMin.TabIndex = 2
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
        Me.btnVentanaSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaSalir.Location = New System.Drawing.Point(676, 0)
        Me.btnVentanaSalir.Name = "btnVentanaSalir"
        Me.btnVentanaSalir.Size = New System.Drawing.Size(41, 29)
        Me.btnVentanaSalir.TabIndex = 1
        Me.btnVentanaSalir.Text = "X"
        Me.btnVentanaSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.logoDiunsa2_Fixed3
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 29)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSoloAccesorios)
        Me.GroupBox1.Controls.Add(Me.rbCelulares)
        Me.GroupBox1.Controls.Add(Me.rbComputadoras)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de producto tecnologíco"
        '
        'rbSoloAccesorios
        '
        Me.rbSoloAccesorios.AutoSize = True
        Me.rbSoloAccesorios.Location = New System.Drawing.Point(7, 68)
        Me.rbSoloAccesorios.Name = "rbSoloAccesorios"
        Me.rbSoloAccesorios.Size = New System.Drawing.Size(101, 17)
        Me.rbSoloAccesorios.TabIndex = 2
        Me.rbSoloAccesorios.TabStop = True
        Me.rbSoloAccesorios.Text = "Solo Accesorios"
        Me.rbSoloAccesorios.UseVisualStyleBackColor = True
        '
        'rbCelulares
        '
        Me.rbCelulares.AutoSize = True
        Me.rbCelulares.Location = New System.Drawing.Point(7, 44)
        Me.rbCelulares.Name = "rbCelulares"
        Me.rbCelulares.Size = New System.Drawing.Size(97, 17)
        Me.rbCelulares.TabIndex = 1
        Me.rbCelulares.TabStop = True
        Me.rbCelulares.Text = "Telefonia Móvil"
        Me.rbCelulares.UseVisualStyleBackColor = True
        '
        'rbComputadoras
        '
        Me.rbComputadoras.AutoSize = True
        Me.rbComputadoras.Location = New System.Drawing.Point(7, 20)
        Me.rbComputadoras.Name = "rbComputadoras"
        Me.rbComputadoras.Size = New System.Drawing.Size(139, 17)
        Me.rbComputadoras.TabIndex = 0
        Me.rbComputadoras.TabStop = True
        Me.rbComputadoras.Text = "Computadoras Portatiles"
        Me.rbComputadoras.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtImpuesto)
        Me.GroupBox2.Controls.Add(Me.txtSubT)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtAccesorios)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtPrecioB)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 161)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calculos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Impuesto"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(69, 128)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(94, 20)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(69, 101)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.ReadOnly = True
        Me.txtImpuesto.Size = New System.Drawing.Size(94, 20)
        Me.txtImpuesto.TabIndex = 6
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubT
        '
        Me.txtSubT.Location = New System.Drawing.Point(69, 74)
        Me.txtSubT.Name = "txtSubT"
        Me.txtSubT.ReadOnly = True
        Me.txtSubT.Size = New System.Drawing.Size(94, 20)
        Me.txtSubT.TabIndex = 5
        Me.txtSubT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SubTotal"
        '
        'txtAccesorios
        '
        Me.txtAccesorios.Location = New System.Drawing.Point(69, 47)
        Me.txtAccesorios.Name = "txtAccesorios"
        Me.txtAccesorios.ReadOnly = True
        Me.txtAccesorios.Size = New System.Drawing.Size(94, 20)
        Me.txtAccesorios.TabIndex = 3
        Me.txtAccesorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Accesorios"
        '
        'txtPrecioB
        '
        Me.txtPrecioB.Location = New System.Drawing.Point(69, 21)
        Me.txtPrecioB.Name = "txtPrecioB"
        Me.txtPrecioB.ReadOnly = True
        Me.txtPrecioB.Size = New System.Drawing.Size(94, 20)
        Me.txtPrecioB.TabIndex = 1
        Me.txtPrecioB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio base"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvSalida)
        Me.GroupBox3.Location = New System.Drawing.Point(188, 287)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 161)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Salida"
        '
        'dgvSalida
        '
        Me.dgvSalida.AllowUserToAddRows = False
        Me.dgvSalida.AllowUserToDeleteRows = False
        Me.dgvSalida.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.detalle, Me.precio, Me.impuesto, Me.total})
        Me.dgvSalida.Location = New System.Drawing.Point(6, 20)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalida.Size = New System.Drawing.Size(350, 135)
        Me.dgvSalida.TabIndex = 0
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
        Me.btnEliminar.Location = New System.Drawing.Point(556, 280)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 50)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(556, 416)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(161, 40)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonFixed2
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(556, 229)
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
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(556, 180)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(161, 50)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'gpxAccesorios
        '
        Me.gpxAccesorios.Controls.Add(Me.cmbAcces3)
        Me.gpxAccesorios.Controls.Add(Me.cmbAcces2)
        Me.gpxAccesorios.Controls.Add(Me.cmbAcces1)
        Me.gpxAccesorios.Controls.Add(Me.chkAcces3)
        Me.gpxAccesorios.Controls.Add(Me.chkAcces2)
        Me.gpxAccesorios.Controls.Add(Me.chkAcces1)
        Me.gpxAccesorios.Location = New System.Drawing.Point(332, 186)
        Me.gpxAccesorios.Name = "gpxAccesorios"
        Me.gpxAccesorios.Size = New System.Drawing.Size(218, 94)
        Me.gpxAccesorios.TabIndex = 5
        Me.gpxAccesorios.TabStop = False
        Me.gpxAccesorios.Text = "Accesorios (Opcional)"
        Me.gpxAccesorios.Visible = False
        '
        'cmbAcces3
        '
        Me.cmbAcces3.DropDownWidth = 200
        Me.cmbAcces3.Enabled = False
        Me.cmbAcces3.FormattingEnabled = True
        Me.cmbAcces3.Location = New System.Drawing.Point(85, 66)
        Me.cmbAcces3.Name = "cmbAcces3"
        Me.cmbAcces3.Size = New System.Drawing.Size(121, 21)
        Me.cmbAcces3.TabIndex = 5
        '
        'cmbAcces2
        '
        Me.cmbAcces2.DropDownWidth = 200
        Me.cmbAcces2.Enabled = False
        Me.cmbAcces2.FormattingEnabled = True
        Me.cmbAcces2.Location = New System.Drawing.Point(85, 42)
        Me.cmbAcces2.Name = "cmbAcces2"
        Me.cmbAcces2.Size = New System.Drawing.Size(121, 21)
        Me.cmbAcces2.TabIndex = 4
        '
        'cmbAcces1
        '
        Me.cmbAcces1.DropDownWidth = 200
        Me.cmbAcces1.Enabled = False
        Me.cmbAcces1.FormattingEnabled = True
        Me.cmbAcces1.Location = New System.Drawing.Point(85, 18)
        Me.cmbAcces1.Name = "cmbAcces1"
        Me.cmbAcces1.Size = New System.Drawing.Size(121, 21)
        Me.cmbAcces1.TabIndex = 3
        '
        'chkAcces3
        '
        Me.chkAcces3.AutoSize = True
        Me.chkAcces3.Location = New System.Drawing.Point(7, 68)
        Me.chkAcces3.Name = "chkAcces3"
        Me.chkAcces3.Size = New System.Drawing.Size(63, 17)
        Me.chkAcces3.TabIndex = 2
        Me.chkAcces3.Text = "Routers"
        Me.chkAcces3.UseVisualStyleBackColor = True
        '
        'chkAcces2
        '
        Me.chkAcces2.AutoSize = True
        Me.chkAcces2.Location = New System.Drawing.Point(7, 44)
        Me.chkAcces2.Name = "chkAcces2"
        Me.chkAcces2.Size = New System.Drawing.Size(72, 17)
        Me.chkAcces2.TabIndex = 1
        Me.chkAcces2.Text = "Monitores"
        Me.chkAcces2.UseVisualStyleBackColor = True
        '
        'chkAcces1
        '
        Me.chkAcces1.AutoSize = True
        Me.chkAcces1.Location = New System.Drawing.Point(7, 20)
        Me.chkAcces1.Name = "chkAcces1"
        Me.chkAcces1.Size = New System.Drawing.Size(58, 17)
        Me.chkAcces1.TabIndex = 0
        Me.chkAcces1.Text = "Mouse"
        Me.chkAcces1.UseVisualStyleBackColor = True
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownWidth = 200
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(6, 19)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cmbProducto.TabIndex = 0
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(7, 47)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbCantidad.TabIndex = 1
        Me.lbCantidad.Text = "Cantidad"
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.Location = New System.Drawing.Point(6, 64)
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidadProducto.TabIndex = 2
        '
        'gpxProducto
        '
        Me.gpxProducto.Controls.Add(Me.txtCantidadProducto)
        Me.gpxProducto.Controls.Add(Me.lbCantidad)
        Me.gpxProducto.Controls.Add(Me.cmbProducto)
        Me.gpxProducto.Location = New System.Drawing.Point(188, 186)
        Me.gpxProducto.Name = "gpxProducto"
        Me.gpxProducto.Size = New System.Drawing.Size(138, 94)
        Me.gpxProducto.TabIndex = 4
        Me.gpxProducto.TabStop = False
        Me.gpxProducto.Text = "Computadoras"
        Me.gpxProducto.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.bannerTecnologiaDiunsaFixed2
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(717, 151)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.bannerDiunsa
        Me.PictureBox3.Location = New System.Drawing.Point(14, 454)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(361, 86)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(556, 330)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(161, 50)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'pbAccesorios
        '
        Me.pbAccesorios.BackgroundImage = Global.Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.bannerAccesorios1
        Me.pbAccesorios.Location = New System.Drawing.Point(382, 455)
        Me.pbAccesorios.Name = "pbAccesorios"
        Me.pbAccesorios.Size = New System.Drawing.Size(218, 86)
        Me.pbAccesorios.TabIndex = 8
        Me.pbAccesorios.TabStop = False
        Me.pbAccesorios.Visible = False
        '
        'pbBotones
        '
        Me.pbBotones.BackColor = System.Drawing.Color.White
        Me.pbBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbBotones.Location = New System.Drawing.Point(556, 180)
        Me.pbBotones.Name = "pbBotones"
        Me.pbBotones.Size = New System.Drawing.Size(161, 369)
        Me.pbBotones.TabIndex = 10
        Me.pbBotones.TabStop = False
        '
        'txtAcumulador
        '
        Me.txtAcumulador.Location = New System.Drawing.Point(605, 49)
        Me.txtAcumulador.Name = "txtAcumulador"
        Me.txtAcumulador.ReadOnly = True
        Me.txtAcumulador.Size = New System.Drawing.Size(100, 20)
        Me.txtAcumulador.TabIndex = 11
        Me.txtAcumulador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(602, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Acumulado:"
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
        'impuesto
        '
        Me.impuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.impuesto.DefaultCellStyle = DataGridViewCellStyle2
        Me.impuesto.HeaderText = "Impuesto"
        Me.impuesto.Name = "impuesto"
        Me.impuesto.ReadOnly = True
        Me.impuesto.Width = 75
        '
        'total
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle3
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'FormTecnologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(717, 549)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAcumulador)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.pbBotones)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.gpxProducto)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panelVentana)
        Me.Controls.Add(Me.pbAccesorios)
        Me.Controls.Add(Me.gpxAccesorios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTecnologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tecnología"
        Me.panelVentana.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxAccesorios.ResumeLayout(False)
        Me.gpxAccesorios.PerformLayout()
        Me.gpxProducto.ResumeLayout(False)
        Me.gpxProducto.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAccesorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelVentana As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVentanaMin As Button
    Friend WithEvents btnVentanaSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbSoloAccesorios As RadioButton
    Friend WithEvents rbCelulares As RadioButton
    Friend WithEvents rbComputadoras As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPrecioB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents gpxAccesorios As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtSubT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAccesorios As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents cmbAcces3 As ComboBox
    Friend WithEvents cmbAcces2 As ComboBox
    Friend WithEvents cmbAcces1 As ComboBox
    Friend WithEvents chkAcces3 As CheckBox
    Friend WithEvents chkAcces2 As CheckBox
    Friend WithEvents chkAcces1 As CheckBox
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents lbCantidad As Label
    Friend WithEvents txtCantidadProducto As TextBox
    Friend WithEvents gpxProducto As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pbAccesorios As PictureBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents pbBotones As PictureBox
    Friend WithEvents txtAcumulador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents impuesto As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
