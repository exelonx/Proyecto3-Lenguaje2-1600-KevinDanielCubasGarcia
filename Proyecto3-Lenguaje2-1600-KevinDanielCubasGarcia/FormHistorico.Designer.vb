<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistorico
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMetodoPago = New System.Windows.Forms.TextBox()
        Me.txtMembresia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.cDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNomCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(133, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° de Factura"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(10, 37)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtFactura.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del cliente"
        '
        'txtNomCliente
        '
        Me.txtNomCliente.Location = New System.Drawing.Point(10, 80)
        Me.txtNomCliente.Name = "txtNomCliente"
        Me.txtNomCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtNomCliente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(388, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Metodo de Pago:"
        '
        'txtMetodoPago
        '
        Me.txtMetodoPago.Location = New System.Drawing.Point(483, 49)
        Me.txtMetodoPago.Name = "txtMetodoPago"
        Me.txtMetodoPago.Size = New System.Drawing.Size(100, 20)
        Me.txtMetodoPago.TabIndex = 2
        '
        'txtMembresia
        '
        Me.txtMembresia.Location = New System.Drawing.Point(483, 76)
        Me.txtMembresia.Name = "txtMembresia"
        Me.txtMembresia.Size = New System.Drawing.Size(100, 20)
        Me.txtMembresia.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Membresía:"
        '
        'dgvHistorial
        '
        Me.dgvHistorial.AllowUserToAddRows = False
        Me.dgvHistorial.AllowUserToDeleteRows = False
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cDetalle, Me.cPrecio, Me.cDescuento, Me.cImpuesto, Me.cTotal})
        Me.dgvHistorial.Location = New System.Drawing.Point(65, 172)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.Size = New System.Drawing.Size(613, 195)
        Me.dgvHistorial.TabIndex = 5
        '
        'cDetalle
        '
        Me.cDetalle.HeaderText = "Detalle"
        Me.cDetalle.Name = "cDetalle"
        Me.cDetalle.ReadOnly = True
        '
        'cPrecio
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cPrecio.DefaultCellStyle = DataGridViewCellStyle5
        Me.cPrecio.HeaderText = "Precio"
        Me.cPrecio.Name = "cPrecio"
        Me.cPrecio.ReadOnly = True
        '
        'cDescuento
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cDescuento.DefaultCellStyle = DataGridViewCellStyle6
        Me.cDescuento.HeaderText = "Descuento"
        Me.cDescuento.Name = "cDescuento"
        Me.cDescuento.ReadOnly = True
        '
        'cImpuesto
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cImpuesto.DefaultCellStyle = DataGridViewCellStyle7
        Me.cImpuesto.HeaderText = "Impuesto"
        Me.cImpuesto.Name = "cImpuesto"
        Me.cImpuesto.ReadOnly = True
        '
        'cTotal
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cTotal.DefaultCellStyle = DataGridViewCellStyle8
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(558, 383)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 6
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(558, 410)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 7
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(558, 437)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(558, 464)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 9
        '
        'FormHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMembresia)
        Me.Controls.Add(Me.txtMetodoPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormHistorico"
        Me.Text = "FormHistorico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNomCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMetodoPago As TextBox
    Friend WithEvents txtMembresia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents cDetalle As DataGridViewTextBoxColumn
    Friend WithEvents cPrecio As DataGridViewTextBoxColumn
    Friend WithEvents cDescuento As DataGridViewTextBoxColumn
    Friend WithEvents cImpuesto As DataGridViewTextBoxColumn
    Friend WithEvents cTotal As DataGridViewTextBoxColumn
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtTotal As TextBox
End Class
