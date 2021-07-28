Public Class FormEscOfi
    'Objetos
    Dim Ventana As New VentanaEstilo
    Dim validacion As New Validaciones
    'Variables globales
    Dim productos(5), extras, cantidad As Integer
    Dim subTotal, impuesto, total As Double
    Private Sub FormDeporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cantidad = 0
        PictureBox3.Location = New Point(184, 192)
        Me.Size = New Size(689, 435)
    End Sub

    'Procedimientos
    Private Sub precioExtra(chk As CheckBox, precio As Integer)
        If chk.Checked = True Then
            extras += precio
        Else
            extras -= precio
        End If
        txtExtras.Text = Format(extras, "0.00")
    End Sub

    'Para ingresar los productos al combobox
    Public Sub setProducto(cmb As ComboBox, produc1 As String, produc2 As String, produc3 As String, produc4 As String, produc5 As String)
        cmb.Items.Clear()
        cmb.Items.Add(produc1)
        cmb.Items.Add(produc2)
        cmb.Items.Add(produc3)
        cmb.Items.Add(produc4)
        cmb.Items.Add(produc5)
    End Sub

    'Procedimiento para asignar precios en la seleccion de producto
    Public Sub setPrecio(precio1 As Integer, precio2 As Integer, precio3 As Integer, precio4 As Integer, precio5 As Integer)
        Dim aux(4) As Integer
        aux(0) = precio1
        aux(1) = precio2
        aux(2) = precio3
        aux(3) = precio4
        aux(4) = precio5
        For i = 0 To 4
            productos(i) = aux(i)
        Next
    End Sub

    Public Sub seleccionProducto()
        cmbProductos.Text = Nothing
        Ventana.visibilidad(gpxTipoProducto, PictureBox3)
        lbCantidad.Enabled = False
        txtCantidad.Enabled = False
        If rbSillas.Checked = True Then
            setProducto(cmbProductos, "SILLA PARA OFICINA SENCILLA L.690.00", "SILLA GLOBAL FURNITURE L.2,599.00", "SILLA EJECUTIVA L.5,099.00", "SILLA GAMER L.7,500.00", "SILLA GERENCIAL MESH L.3,999.00")
            setPrecio(690, 2599, 5099, 7500, 3999)
        Else
            setProducto(cmbProductos, "BOLIGRAFO TECH3 NEGRO L.2,059.00", "BOLIGRAFO STRATFORD CROMO L.979.00", "BOLIGRAFO KIZOKU TINTA ACEITE NEGRO L.239.00", "LAPIZ TINTA NEGRO/ROJO SENCILLO L.7.00", "LAPIZ CARBON L.5.00")
            setPrecio(509, 2154, 1494, 474, 490)
        End If
    End Sub

    'Ventana personalizada
    Private Sub panelVentana_MouseDown(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseDown
        Ventana.setUbicacionMouse(e)
    End Sub

    Private Sub panelVentana_MouseUp(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseUp
        Ventana.clickVentana = False
    End Sub

    Private Sub panelVentana_MouseMove(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseMove
        Ventana.ventanaPresionada(Me, e, panelVentana)
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        validacion.validar(1, e)
    End Sub

    Private Sub cmbProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProductos.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub rbSillas_CheckedChanged(sender As Object, e As EventArgs) Handles rbSillas.CheckedChanged
        seleccionProducto()
    End Sub

    Private Sub rbLapices_CheckedChanged(sender As Object, e As EventArgs) Handles rbLapices.CheckedChanged
        seleccionProducto()
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        validacion.validarCantidad(txtCantidad)
        If txtCantidad.Text <> Nothing Then
            cantidad = txtCantidad.Text
            txtPrecio.Text = Format(productos(5) * cantidad, "0.00")
        Else
            cantidad = 0
            txtPrecio.Text = Format(0, "0.00")
        End If
    End Sub

    Private Sub chkExtras_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtras.CheckedChanged
        If chkExtras.Checked = True Then
            rbSillas.Checked = False
            rbLapices.Checked = False
            txtCantidad.Clear()
            cmbProductos.Items.Clear()
            rbSillas.Enabled = False
            rbLapices.Enabled = False
            Ventana.visibilidadInversa(gpxTipoProducto, PictureBox3)
        Else
            rbSillas.Enabled = True
            rbLapices.Enabled = True
        End If
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        If cmbProductos.Text <> Nothing Then
            productos(5) = productos(cmbProductos.SelectedIndex)
            'Acciones para dar dinamismo al programa
            txtCantidad.Clear()
            If txtCantidad.Text <> Nothing Then
                cantidad = txtCantidad.Text
                txtPrecio.Text = Format(productos(5) * cantidad, "0.00")
            End If
            'Habilitar txtCantidad
            txtCantidad.Enabled = True
            lbCantidad.Enabled = True
        End If
    End Sub

    Private Sub chkPapel_CheckedChanged(sender As Object, e As EventArgs) Handles chkPapel.CheckedChanged
        precioExtra(chkPapel, 150)
    End Sub

    Private Sub chkSacapuntas_CheckedChanged(sender As Object, e As EventArgs) Handles chkSacapuntas.CheckedChanged
        precioExtra(chkSacapuntas, 10)
    End Sub

    Private Sub chkBorrador_CheckedChanged(sender As Object, e As EventArgs) Handles chkBorrador.CheckedChanged
        precioExtra(chkBorrador, 5)
    End Sub

    'Botones de cerrar y minimizar
    Private Sub btnVentanaMin_Click(sender As Object, e As EventArgs) Handles btnVentanaMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVentanaSalir_Click(sender As Object, e As EventArgs) Handles btnVentanaSalir.Click
        Close()
    End Sub

    Private Sub btnVentanaSalir_MouseMove(sender As Object, e As MouseEventArgs) Handles btnVentanaSalir.MouseMove
        btnVentanaSalir.ForeColor = Color.White
    End Sub

    Private Sub btnVentanaSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnVentanaSalir.MouseLeave
        btnVentanaSalir.ForeColor = Color.Black
    End Sub
End Class