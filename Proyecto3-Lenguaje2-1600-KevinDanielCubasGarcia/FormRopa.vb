Public Class FormRopa
    '********************************************************Objetos************************************************************
    Dim Ventana As New VentanaEstilo
    Dim Validacion As New Validaciones

    '*******************************************************Variables***********************************************************
    Dim productos(5), extras(2), cantidad As Integer
    Dim subTotal, descuento, impuesto, total As Double
    Dim acumST, acumIVA, acumTot, acumDesc As Double 'Acumuladores
    Dim selectPrecio, selectIVA, selectTot, selectDesc 'para hacer decremento a los acumuladores
    Dim antiCloseBug As Boolean 'Para evitar bug al cerrar formulario cuando se trata de evitar de perder información

    '*******************************************************Funciones***********************************************************
    Public Function getDescuentoUnitario(variable As Double) As Double
        Dim descAux
        If Main.chkMembresia.Checked = True Then
            descAux = variable * 0.1
        Else
            descAux = 0
        End If
        Return descAux
    End Function

    '*************************************************Eventos de Formulario*****************************************************
    Private Sub FormRopa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        antiCloseBug = False
        txtAcumulador.Text = Format(0, "0.00")
        pbBanner.Location = New Point(237, 192)
        Me.Size = New Size(810, 467)
    End Sub

    Private Sub FormRopa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Disminución de contador contfilas
        If antiCloseBug = False Then
            Main.contFilas -= dgvSalida.Rows.Count
        End If
    End Sub

    '****************************************************Procedimientos*********************************************************
    'Procedimiento para disminuir acumuladores
    Public Sub setDecremento(e As DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            selectPrecio = dgvSalida.Rows(e.RowIndex).Cells(1).Value
            selectDesc = dgvSalida.Rows(e.RowIndex).Cells(2).Value
            selectIVA = dgvSalida.Rows(e.RowIndex).Cells(3).Value
            selectTot = dgvSalida.Rows(e.RowIndex).Cells(4).Value
        End If
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

    'Para ingresar los productos al combobox
    Public Sub setProducto(cmb As ComboBox, produc1 As String, produc2 As String, produc3 As String)
        cmb.Items.Clear()
        cmb.Items.Add(produc1)
        cmb.Items.Add(produc2)
        cmb.Items.Add(produc3)
    End Sub

    '*******************************************************CheckBoxs***********************************************************
    Private Sub chkCalcetines_CheckedChanged(sender As Object, e As EventArgs) Handles chkCalcetines.CheckedChanged
        Validacion.setGroupBoxEnabledCHK(chkCalcetines, gpxTipoCalcetines)
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

    '******************************************************TextBoxs*************************************************************
    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Validacion.validarCantidad(txtCantidad)
        If txtCantidad.Text <> Nothing Then
            txtPrecio.Text = Format(productos(5) * txtCantidad.Text, "0.00")
        Else
            txtPrecio.Text = Format(0, "0.00")
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Validacion.validar(1, e)
    End Sub

    '******************************************************ComboBoxs************************************************************
    Private Sub cmbRopa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbRopa.KeyPress
        Validacion.validar(2, e)
    End Sub

    Private Sub cmbTipoCalcetin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTipoCalcetin.KeyPress
        Validacion.validar(2, e)
    End Sub

    Private Sub cmbClasificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbClasificacion.KeyPress
        Validacion.validar(2, e)
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
                    setProductoTamañoOrTipo(cmbRopa, "Pantalones tela talla 36 L.680.00", "Pantalones tela talla 38 L.700.00", "Jeans talla 36 L.800.00", "Jeans talla 38 L.820.00", "Pantalones cortos talla 36 L.500.00")
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

    '****************************************************RadioButton*********************************************************
    Private Sub rbHombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbHombre.CheckedChanged
        seleccionGenero()
        Ventana.visibilidadInversa(gpxRopa, pbBanner)
        Validacion.setGroupBoxEnabledRB(rbHombre, gpxClasificacion)
        Validacion.setGroupBoxEnabledRB(rbHombre, gpxClasificacion)
    End Sub

    Private Sub rbMujer_CheckedChanged(sender As Object, e As EventArgs) Handles rbMujer.CheckedChanged
        seleccionGenero()
        Ventana.visibilidadInversa(gpxRopa, pbBanner)
        Validacion.setGroupBoxEnabledRB(rbMujer, gpxClasificacion)
    End Sub

    '*******************************************************Buttons**********************************************************
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
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
        cantidad = txtCantidad.Text
        'SubTotal
        subTotal = (productos(5) * cantidad) + extras(2)
        txtSubTotal.Text = Format(subTotal, "0.00")
        'Descuento de membresía
        If Main.chkMembresia.Checked = True Then
            descuento = subTotal * 0.1
        Else
            descuento = 0
        End If
        txtDescuento.Text = Format(descuento, "0.00")
        'Impuestos
        impuesto = (subTotal - descuento) * 0.15
        txtImpuesto.Text = Format(impuesto, "0.00")
        'Total
        total = subTotal - descuento + impuesto
        txtTotal.Text = Format(total, "0.00")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvSalida.Rows.Count > 0 Then
            dgvSalida.Rows.Remove(dgvSalida.CurrentRow)
            Main.contFilas -= 1
            'Decremento a los acumuladores
            acumST -= selectPrecio
            acumIVA -= selectIVA
            acumTot -= selectTot
            acumDesc -= selectDesc
            txtAcumulador.Text = Format(acumTot, "0.00")
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nfilas As Integer 'Contador de filas
        If txtTotal.Text = Nothing Then
            MessageBox.Show("Debe calcular primero.", "Faltan Requisitos")
            Exit Sub
        Else
            Dim aux As Double
            aux = productos(5) * cantidad
            'Llenado de la matriz
            nfilas = dgvSalida.Rows.Count
            dgvSalida.Rows.Add()
            dgvSalida(0, nfilas).Value = cmbRopa.Text
            dgvSalida(1, nfilas).Value = Format(aux, "0.00")
            dgvSalida(2, nfilas).Value = Format(getDescuentoUnitario(aux), "0.00")
            dgvSalida(3, nfilas).Value = Format(aux * 0.15, "0.00")
            dgvSalida(4, nfilas).Value = Format(aux - getDescuentoUnitario(aux) + (aux * 0.15), "0.00")
            Main.contFilas += 1
            If chkCalcetines.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = cmbTipoCalcetin.Text
                dgvSalida(1, nfilas).Value = Format(extras(0), "0.00")
                dgvSalida(2, nfilas).Value = Format(getDescuentoUnitario(extras(0)), "0.00")
                dgvSalida(3, nfilas).Value = Format(extras(0) * 0.15, "0.00")
                dgvSalida(4, nfilas).Value = Format(extras(0) - getDescuentoUnitario(extras(0)) + (extras(0) * 0.15), "0.00")
                Main.contFilas += 1
            End If
            If chkPulceras.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = "Pulcera"
                dgvSalida(1, nfilas).Value = Format(100, "0.00")
                dgvSalida(2, nfilas).Value = Format(getDescuentoUnitario(100), "0.00")
                dgvSalida(3, nfilas).Value = Format(100 * 0.15, "0.00")
                dgvSalida(4, nfilas).Value = Format(100 - getDescuentoUnitario(100) + (100 * 0.15), "0.00")
                Main.contFilas += 1
            End If
            'Limpieza del formulario
            rbHombre.Checked = False
            rbMujer.Checked = False
            chkCalcetines.Checked = False
            chkPulceras.Checked = False
            txtCantidad.Clear()
            txtPrecio.Clear()
            txtExtras.Clear()
            txtSubTotal.Clear()
            txtDescuento.Clear()
            txtImpuesto.Clear()
            txtTotal.Clear()
            Ventana.visibilidadInversa(gpxRopa, pbBanner)
            'Incrementos de acumuladores
            acumST += subTotal
            acumDesc += descuento
            acumIVA += impuesto
            acumTot += total
            txtAcumulador.Text = Format(acumTot, "0.00")
            'Activar botones
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Paso de acumuladores al main
        Main.acumST += Me.acumST
        Main.txtSubT.Text = Format(Main.acumST, "0.00")
        Main.acumDesc += Me.acumDesc
        Main.txtDesc.Text = Format(Main.acumDesc, "0.00")
        Main.acumIVA += Me.acumIVA
        Main.txtIVA.Text = Format(Main.acumIVA, "0.00")
        Main.acumTot += Me.acumTot
        Main.txtTotal.Text = Format(Main.acumTot, "0.00")
        'DataGridV Ropa al DataGridV Main
        Do While (Main.indexFila < Main.contFilas)
            Dim index As Integer
            Main.dgvMain.Rows.Add()
            Main.dgvMain(0, Main.indexFila).Value = dgvSalida(0, index).Value.ToString
            Main.dgvMain(1, Main.indexFila).Value = dgvSalida(1, index).Value.ToString
            Main.dgvMain(2, Main.indexFila).Value = dgvSalida(2, index).Value.ToString
            Main.dgvMain(3, Main.indexFila).Value = dgvSalida(3, index).Value.ToString
            Main.dgvMain(4, Main.indexFila).Value = dgvSalida(4, index).Value.ToString
            Main.indexFila += 1
            index += 1
        Loop
        'Activar el seguro
        antiCloseBug = True
        Me.Close()
    End Sub

    '*****************************************************DataGridView**********************************************************
    Private Sub dgvSalida_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSalida.RowsRemoved
        If dgvSalida.Rows.Count = 0 Then
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub dgvSalida_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalida.CellContentClick
        setDecremento(e)
        btnEliminar.Enabled = Enabled
    End Sub

    '****************************************************************************************************************************
    '******************************************************Personalización*******************************************************
    '****************************************************************************************************************************
    Private Sub panelVentana_MouseDown(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseDown
        Ventana.setUbicacionMouse(e)
    End Sub

    Private Sub panelVentana_MouseUp(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseUp
        Ventana.clickVentana = False
    End Sub

    'Colores de botones
    'Calcular
    Private Sub btnCalcular_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCalcular.MouseMove
        btnCalcular.ForeColor = Color.White
        btnCalcular.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnCalcular.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonBlanco
        'Tamaño
        btnCalcular.Width = 171
        btnCalcular.Location = New Point(639, 180)
    End Sub

    Private Sub btnCalcular_MouseLeave(sender As Object, e As EventArgs) Handles btnCalcular.MouseLeave
        btnCalcular.ForeColor = Color.Black
        btnCalcular.FlatAppearance.BorderColor = Color.White
        btnCalcular.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonFixed2
        'Tamaño
        btnCalcular.Width = 161
        btnCalcular.Location = New Point(649, 180)
    End Sub

    'Agregar
    Private Sub btnAgregar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnAgregar.MouseMove
        btnAgregar.ForeColor = Color.White
        btnAgregar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnAgregar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonBlanco
        'Tamaño
        btnAgregar.Width = 171
        btnAgregar.Location = New Point(639, 230)
    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        btnAgregar.ForeColor = Color.Black
        btnAgregar.FlatAppearance.BorderColor = Color.White
        btnAgregar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonFixed2
        'Tamaño
        btnAgregar.Width = 161
        btnAgregar.Location = New Point(649, 230)
    End Sub

    'Eliminar
    Private Sub btnEliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseMove
        btnEliminar.ForeColor = Color.White
        btnEliminar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnEliminar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Blanco
        'tamaño
        btnEliminar.Width = 171
        btnEliminar.Location = New Point(639, 280)
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.ForeColor = Color.Black
        btnEliminar.FlatAppearance.BorderColor = Color.White
        btnEliminar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Fixed2
        'Tamaño
        btnEliminar.Width = 161
        btnEliminar.Location = New Point(649, 280)
    End Sub

    'Guardar
    Private Sub btnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        btnGuardar.ForeColor = Color.White
        btnGuardar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnGuardar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Blanco
        'tamaño
        btnGuardar.Width = 171
        btnGuardar.Location = New Point(639, 330)
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.ForeColor = Color.Black
        btnGuardar.FlatAppearance.BorderColor = Color.White
        btnGuardar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Fixed
        'Tamaño
        btnGuardar.Width = 161
        btnGuardar.Location = New Point(649, 330)
    End Sub

    Private Sub panelVentana_MouseMove(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseMove
        Ventana.ventanaPresionada(Me, e, panelVentana)
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

    'Crear sombras
    Public Sub New()
        InitializeComponent()
        SuspendLayout()
        FormBorderStyle = FormBorderStyle.None
        Const CS_DROPSHADOW As Integer = &H20000
        Ventana.SD = Ventana.SetWindowLong(Handle, -8, Ventana.GetDesktopWindow())
        Ventana.SetClassLong(Handle, -26, Ventana.GetClassLong(Handle, -26) Or CS_DROPSHADOW)
        ResumeLayout(False)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
End Class