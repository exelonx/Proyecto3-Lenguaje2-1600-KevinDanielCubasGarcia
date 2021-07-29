Public Class FormRopa
    Dim Ventana As New VentanaEstilo
    Dim Validacion As New Validaciones
    Dim productos(5), extras(2) As Integer
    Dim subTotal, impuesto, total As Double

    'Procedimientos
    'Para ingresar los productos al combobox
    Public Sub setProducto(cmb As ComboBox, produc1 As String, produc2 As String, produc3 As String)
        cmb.Items.Clear()
        cmb.Items.Add(produc1)
        cmb.Items.Add(produc2)
        cmb.Items.Add(produc3)
    End Sub

    'Para ingresar los productos al combobox
    Public Sub setProductoTamañoOrTipo(cmb As ComboBox, produc1 As String, produc2 As String, produc3 As String, produc4 As String, produc5 As String)
        cmb.Items.Clear()
        cmb.Items.Add(produc1)
        cmb.Items.Add(produc2)
        cmb.Items.Add(produc3)
        cmb.Items.Add(produc4)
        cmb.Items.Add(produc5)
    End Sub

    'Procedimiento para la seleccion del tipo de ropa por genero
    Public Sub seleccionGenero()
        cmbClasificacion.Text = Nothing
        If rbHombre.Checked = True Then
            setProducto(cmbClasificacion, "Camisas", "Pantalones", "Ropa Interior")
        Else
            setProducto(cmbClasificacion, "Blusas", "Vestidos", "Faldas")
        End If
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

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        validacion.validarCantidad(txtCantidad)
        If txtCantidad.Text <> Nothing Then
            txtPrecio.Text = Format(productos(5) * txtCantidad.Text, "0.00")
        Else
            txtPrecio.Text = Format(0, "0.00")
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        validacion.validar(1, e)
    End Sub

    Private Sub cmbRopa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbRopa.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub cmbTipoCalcetin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTipoCalcetin.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub cmbClasificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbClasificacion.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub rbHombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbHombre.CheckedChanged
        seleccionGenero()
        Ventana.visibilidadInversa(gpxRopa, pbBanner)
        Validacion.setGroupBoxEnabledRB(rbHombre, gpxClasificacion)
        validacion.setGroupBoxEnabledRB(rbHombre, gpxClasificacion)
    End Sub

    Private Sub rbMujer_CheckedChanged(sender As Object, e As EventArgs) Handles rbMujer.CheckedChanged
        seleccionGenero()
        Ventana.visibilidadInversa(gpxRopa, pbBanner)
        Validacion.setGroupBoxEnabledRB(rbMujer, gpxClasificacion)
    End Sub

    Private Sub cmbClasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClasificacion.SelectedIndexChanged
        cmbRopa.Text = Nothing
        Ventana.visibilidad(gpxRopa, pbBanner)
        lbCantidad.Enabled = False
        txtCantidad.Enabled = False
        Select Case cmbClasificacion.SelectedIndex
            Case 0
                If rbHombre.Checked = True Then
                    setProductoTamañoOrTipo(cmbRopa, "Camisa talla S L.200.00", "Camisa talla M L.220.00", "Camisa talla L L.240.00", "Camisa talla XL L.260.00", "Camisa talla XXL L.280.00")
                    setPrecio(200, 220, 240, 260, 280)
                Else
                    setProductoTamañoOrTipo(cmbRopa, "Blusas talla S L.300.00", "Blusas talla M L.330.00", "Blusas talla L L.360.00", "Blusas talla XL L.390.00", "Blusas talla XXL L.410.00")
                    setPrecio(300, 330, 360, 390, 410)
                End If
            Case 1
                If rbHombre.Checked = True Then
                    setProductoTamañoOrTipo(cmbRopa, "Pantalones tela talla 36 680.00", "Pantalones tela talla 38 700.00", "Jeans talla 36 800.00", "Jeans talla 38 820.00", "Pantalones cortos talla 36 500.00")
                    setPrecio(680, 700, 800, 820, 500)
                Else
                    setProductoTamañoOrTipo(cmbRopa, "Vestido de tirantes L.1,500.00", "Vestido de ceremonia L.4,000.00", "Vestido Ablusado L.2,000.00", "Vestido con volantes L.2,500.00", "Vestido de talle bajo L.1,900.00")
                    setPrecio(1500, 4000, 2000, 2500, 1900)
                End If
            Case 2
                If rbHombre.Checked = True Then
                    setProductoTamañoOrTipo(cmbRopa, "Boxer estampado L.345.00", "Boxer sencillo L.200.00", "Boxer briefs L.250.00", "Boxer Trunk L.220.00", "Calzoncillo sencillo L.150.00")
                    setPrecio(345, 200, 250, 220, 150)
                Else
                    setProductoTamañoOrTipo(cmbRopa, "Cosmetiquera RAFFIA CHEBRON L.124.00", "Cartera Cruzada L.199.00", "Monedero para dama 20CM L.79.00", "Bolso hombro cadena L.895.00", "Bandolera hebilla L.1,395.00")
                    setPrecio(124, 199, 79, 895, 1395)
                End If
        End Select
    End Sub

    Private Sub cmbRopa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRopa.SelectedIndexChanged
        If cmbRopa.Text <> Nothing Then
            productos(5) = productos(cmbRopa.SelectedIndex)
        End If
        'Acciones para dar dinamismo al programa
        txtCantidad.Clear()
        If txtCantidad.Text <> Nothing Then
            txtPrecio.Text = Format(productos(5) * txtCantidad.Text, "0.00")
        End If
        'Habilitar txtCantidad
        txtCantidad.Enabled = True
        lbCantidad.Enabled = True
    End Sub

    Private Sub chkCalcetines_CheckedChanged(sender As Object, e As EventArgs) Handles chkCalcetines.CheckedChanged
        validacion.setGroupBoxEnabledCHK(chkCalcetines, gpxTipoCalcetines)
        cmbTipoCalcetin.Text = Nothing
    End Sub

    Private Sub chkPulceras_CheckedChanged(sender As Object, e As EventArgs) Handles chkPulceras.CheckedChanged
        If chkPulceras.Checked = True Then
            extras(1) = 100
        Else
            extras(1) = 0
        End If
        extras(2) = extras(0) + extras(1)
        txtExtras.Text = Format(extras(2), "0.00")
    End Sub

    Private Sub cmbTipoCalcetin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoCalcetin.SelectedIndexChanged
        Select Case cmbTipoCalcetin.SelectedIndex
            Case 0
                extras(0) = 30
            Case 1
                extras(0) = 50
            Case 2
                extras(0) = 60
            Case 3
                extras(0) = 75
            Case 4
                extras(0) = 90
        End Select
        If cmbTipoCalcetin.Text = Nothing Then
            extras(0) = 0
        End If
        extras(2) = extras(0) + extras(1)
        txtExtras.Text = Format(extras(2), "0.00")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'validación
        If rbHombre.Checked = False And rbMujer.Checked = False Then
            MessageBox.Show("Seleccione el tipo ropa", "Faltan Requisitos")
            Exit Sub
        ElseIf cmbClasificacion.Text = Nothing Then
            MessageBox.Show("Clasificación sin seleccionar", "Faltan Requisitos")
            Exit Sub
        ElseIf cmbRopa.Text = Nothing Then
            MessageBox.Show("Ropa sin seleccionar", "Faltan Requisitos")
            Exit Sub
        ElseIf txtCantidad.Text = Nothing Then
            MessageBox.Show("Casilla vacia, ingrese la cantidad", "Faltan Requisitos")
            txtCantidad.Focus()
            Exit Sub
        ElseIf chkCalcetines.Checked = True And cmbTipoCalcetin.Text = Nothing Then
            MessageBox.Show("Tipo de calcetin sin seleccionar", "Faltan Requisitos")
            Exit Sub
        End If
        If chkCalcetines.Checked = False And chkPulceras.Checked = False Then
            txtExtras.Text = Format(0, "0.00")
        End If
        'Calculos
        'SubTotal
        subTotal = (productos(5) * txtCantidad.Text) + extras(2)
        txtSubTotal.Text = Format(subTotal, "0.00")
        'Impuestos
        impuesto = subTotal * 0.15
        txtImpuesto.Text = Format(impuesto, "0.00")
        'Total
        total = subTotal + impuesto
        txtTotal.Text = Format(total, "0.00")
    End Sub

    Private Sub FormRopa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbBanner.Location = New Point(237, 192)
        Me.Size = New Size(795, 445)
    End Sub

    'Ventana personalizada
    Private Sub panelVentana_MouseDown(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseDown
        ventana.setUbicacionMouse(e)
    End Sub

    Private Sub panelVentana_MouseUp(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseUp
        Ventana.clickVentana = False
    End Sub

    Private Sub panelVentana_MouseMove(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseMove
        ventana.ventanaPresionada(Me, e, panelVentana)
    End Sub

    'Botones de cerrar y minimizar
    Private Sub btnVentanaMin_Click(sender As Object, e As EventArgs) Handles btnVentanaMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
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