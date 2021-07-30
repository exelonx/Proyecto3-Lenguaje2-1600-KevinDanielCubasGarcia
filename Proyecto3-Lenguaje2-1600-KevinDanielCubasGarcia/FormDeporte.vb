Public Class FormDeporte
    'Objetos
    Dim Ventana As New VentanaEstilo
    Dim Validacion As New Validaciones
    'Variables globales
    Dim productos(5), extras, cantidad As Integer
    Dim subTotal, impuesto, total As Double
    Dim acumST, acumIVA, acumTot As Double 'Acumuladores
    Dim selectPrecio, selectIVA, selectTot 'para hacer decremento a los acumuladores
    Dim antiCloseBug As Boolean 'Para evitar bug al cerrar formulario cuando se trata de evitar de perder información
    Dim cantidadAUX As Integer 'Contador de objetos

    'Procedimientos

    Public Sub setDecremento(e As DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            selectPrecio = dgvSalida.Rows(e.RowIndex).Cells(1).Value
            selectIVA = dgvSalida.Rows(e.RowIndex).Cells(2).Value
            selectTot = dgvSalida.Rows(e.RowIndex).Cells(3).Value
        End If
    End Sub

    Private Sub precioExtra(chk As CheckBox, precio As Integer)
        If chk.Checked = True Then
            extras += precio
        Else
            extras -= precio
        End If
        txtExtras.Text = Format(extras, "0.00")
    End Sub

    'Para acumular
    Public Sub setIncremento(ByRef acumulador1 As Double, ByRef acumulador2 As Double, ByRef acumulador3 As Double, SubT As Double, IVA As Double, Total As Double)
        acumulador1 += SubT
        acumulador2 += IVA
        acumulador3 += Total
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
        If rbBalones.Checked = True Then
            setProducto(cmbProductos, "BALON FUTBOL ADIDAS UNIFORIA L.1,500.00", "BALON FUTBOL MOLTEN VANTAGGIO L.1,200.00", "BALON BALONCESTO WILSON L.2,000.00", "BALON BALONCESTO MOLTEN FIBA L.1,800.00", "BALON VOLEIBOL TRIUMPH L.750.00")
            setPrecio(1500, 1200, 2000, 1800, 750)
        ElseIf rbBicicletas.Checked = True Then
            setProducto(cmbProductos, "BICICLETA DS-3 L.4,490.00", "BICICLETA SUPERBIKE 24 MTB L.1,790.00", "BICICLETA SUPERBIKE 20 MTB L.1,590.00", "BICICLETA SUPERBIKE 26MTB L.1,990.00", "BICICLETA OLIMPIC 8MX NIÑO L.799.00")
            setPrecio(4490, 1790, 1590, 1990, 799)
        Else
            setProducto(cmbProductos, "COLCHONETA YOGA EVERLAST 6MM L.509.00", "CHALECO CON PESO EVERLAST 20KG L.2,154.00", "CHALECO CON PESO EVERLAST 10KG L.1,494.00", "ARO DE PILATES EVERLAST L.474.00", "PESA HEXAGONAL KAISER 10LB L.490.00")
            setPrecio(509, 2154, 1494, 474, 490)
        End If
    End Sub

    Private Sub FormDeporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        antiCloseBug = False
        txtAcumulador.Text = Format(0, "0.00")
        cantidad = 0
        PictureBox3.Location = New Point(199, 192)
        Me.Size = New Size(710, 446)
    End Sub

    Private Sub cmbProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProductos.KeyPress
        Validacion.validar(2, e)
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Validacion.validar(1, e)
    End Sub

    Private Sub chkSuelas_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuelas.CheckedChanged
        precioExtra(chkSuelas, 150)

    End Sub

    Private Sub chkBombaAire_CheckedChanged(sender As Object, e As EventArgs) Handles chkBombaAire.CheckedChanged
        precioExtra(chkBombaAire, 300)
    End Sub

    Private Sub rbBalones_CheckedChanged(sender As Object, e As EventArgs) Handles rbBalones.CheckedChanged
        seleccionProducto()
    End Sub

    Private Sub rbBicicletas_CheckedChanged(sender As Object, e As EventArgs) Handles rbBicicletas.CheckedChanged
        seleccionProducto()
    End Sub

    Private Sub rbAccesorios_CheckedChanged(sender As Object, e As EventArgs) Handles rbAccesorios.CheckedChanged
        seleccionProducto()
    End Sub

    Private Sub chkExtras_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtras.CheckedChanged
        If chkExtras.Checked = True Then
            rbAccesorios.Checked = False
            rbBalones.Checked = False
            rbBicicletas.Checked = False
            txtCantidad.Clear()
            cmbProductos.Items.Clear()
            rbAccesorios.Enabled = False
            rbBalones.Enabled = False
            rbBicicletas.Enabled = False
            Ventana.visibilidadInversa(gpxTipoProducto, PictureBox3)
        Else
            rbAccesorios.Enabled = True
            rbBalones.Enabled = True
            rbBicicletas.Enabled = True
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

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Validacion.validarCantidad(txtCantidad)
        If txtCantidad.Text <> Nothing Then
            cantidad = txtCantidad.Text
            txtPrecio.Text = Format(productos(5) * cantidad, "0.00")
        Else
            cantidad = 0
            txtPrecio.Text = Format(0, "0.00")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Validaciones
        If rbAccesorios.Checked = True And rbBalones.Checked = True And rbBalones.Checked = True And chkExtras.Checked = False Then
            MessageBox.Show("Seleccione el tipo de producto.", "Faltan Requisitos")
            Exit Sub
        ElseIf cmbProductos.Text = Nothing And chkExtras.Checked = False Then
            MessageBox.Show("Producto sin seleccionar.", "Faltan Requisitos")
            Exit Sub
        ElseIf txtCantidad.Text = Nothing And chkExtras.Checked = False Then
            MessageBox.Show("Casilla vacia, ingrese la cantidad.", "Faltan Requisitos")
            txtCantidad.Focus()
            Exit Sub
        ElseIf chkSuelas.Checked = False And chkBombaAire.Checked = False And chkExtras.Checked = True Then
            MessageBox.Show("Seleccione al menos un extra.", "Faltan Requisitos")
            Exit Sub
        End If
        'Calculos
        If chkBombaAire.Checked = False And chkSuelas.Checked = False Then
            txtExtras.Text = Format(0, "0.00")
        End If
        If txtCantidad.Text = Nothing Then
            txtPrecio.Text = Format(0, "0.00")
        End If
        'SubTotal
        subTotal = (productos(5) * cantidad) + extras
        txtSubT.Text = Format(subTotal, "0.00")
        'Impuestos
        impuesto = subTotal * 0.15
        txtImpuesto.Text = Format(impuesto, "0.00")
        'Total
        total = subTotal + impuesto
        txtTotal.Text = Format(total, "0.00")
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvSalida.Rows.Count > 0 Then
            dgvSalida.Rows.Remove(dgvSalida.CurrentRow)
            Main.contFilas -= 1
            'Decremento a los acumuladores
            acumST -= selectPrecio
            acumIVA -= selectIVA
            acumTot -= selectTot
            txtAcumulador.Text = acumTot
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Paso de acumuladores al main
        Main.acumST += Me.acumST
        Main.txtSubT.Text = Format(Main.acumST, "0.00")
        Main.acumIVA += Me.acumIVA
        Main.txtIVA.Text = Format(Main.acumIVA, "0.00")
        Main.acumTot += Me.acumTot
        Main.txtTotal.Text = Format(Main.acumTot, "0.00")
        'DataGridV Deporte al DataGridV Main
        Do While (Main.indexFila < Main.contFilas)
            Dim index As Integer
            Main.dgvMain.Rows.Add()
            Main.dgvMain(0, Main.indexFila).Value = dgvSalida(0, index).Value.ToString
            Main.dgvMain(1, Main.indexFila).Value = dgvSalida(1, index).Value.ToString
            Main.dgvMain(2, Main.indexFila).Value = dgvSalida(2, index).Value.ToString
            Main.dgvMain(3, Main.indexFila).Value = dgvSalida(3, index).Value.ToString
            Main.indexFila += 1
            index += 1
        Loop
        'Manda el número de objetos a la lista
        Main.txtObjetos.Text = Main.contFilas + cantidadAUX
        'Activar el seguro
        antiCloseBug = True
        Me.Close()
    End Sub

    Private Sub dgvSalida_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSalida.RowsRemoved
        If dgvSalida.Rows.Count = 0 Then
            btnGuardar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub dgvSalida_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalida.CellContentClick
        setDecremento(e)
        btnEliminar.Enabled = Enabled
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nfilas As Integer 'Contador de filas
        If txtTotal.Text = Nothing Then
            MessageBox.Show("Debe calcular primero.", "Faltan Requisitos")
            Exit Sub
        Else
            'Llenado de la matriz
            If rbBalones.Checked = True Or rbAccesorios.Checked = True Or rbBicicletas.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = cmbProductos.Text
                dgvSalida(1, nfilas).Value = txtPrecio.Text
                dgvSalida(2, nfilas).Value = Format(txtPrecio.Text * 0.15, "0.00")
                dgvSalida(3, nfilas).Value = Format(txtPrecio.Text + (txtPrecio.Text * 0.15), "0.00")
                Main.contFilas += 1
            End If
            If chkBombaAire.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = "Bomba de aire"
                dgvSalida(1, nfilas).Value = Format(300, "0.00")
                dgvSalida(2, nfilas).Value = Format(300 * 0.15, "0.00")
                dgvSalida(3, nfilas).Value = Format(300 + (300 * 0.15), "0.00")
                Main.contFilas += 1
            End If
            If chkSuelas.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = "Suelas deportivas"
                dgvSalida(1, nfilas).Value = Format(150, "0.00")
                dgvSalida(2, nfilas).Value = Format(150 * 0.15, "0.00")
                dgvSalida(3, nfilas).Value = Format(150 + (150 * 0.15), "0.00")
                Main.contFilas += 1
            End If
            cantidadAUX += txtCantidad.Text
            'Limpieza del formulario
            rbBalones.Checked = False
            rbBicicletas.Checked = False
            rbAccesorios.Checked = False
            chkExtras.Checked = False
            chkBombaAire.Checked = False
            chkSuelas.Checked = False
            txtCantidad.Clear()
            txtPrecio.Clear()
            txtExtras.Clear()
            txtSubT.Clear()
            txtImpuesto.Clear()
            txtTotal.Clear()
            Ventana.visibilidadInversa(gpxTipoProducto, PictureBox3)
            'Incrementos de acumuladores
            acumST += subTotal
            acumIVA += impuesto
            acumTot += total
            txtAcumulador.Text = Format(acumTot, "0.00")
            'Activar botones
            btnGuardar.Enabled = True
        End If
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

    Private Sub FormDeporte_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Disminución de contador contfilas
        If antiCloseBug = False Then
            Main.contFilas -= dgvSalida.Rows.Count
        End If
    End Sub

    'Colores de botones
    'Calcular
    Private Sub btnCalcular_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCalcular.MouseMove
        btnCalcular.ForeColor = Color.White
        btnCalcular.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnCalcular.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonBlanco
        'Tamaño
        btnCalcular.Width = 171
        btnCalcular.Location = New Point(539, 180)
    End Sub

    Private Sub btnCalcular_MouseLeave(sender As Object, e As EventArgs) Handles btnCalcular.MouseLeave
        btnCalcular.ForeColor = Color.Black
        btnCalcular.FlatAppearance.BorderColor = Color.White
        btnCalcular.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonFixed2
        'Tamaño
        btnCalcular.Width = 161
        btnCalcular.Location = New Point(549, 180)
    End Sub

    'Agregar
    Private Sub btnAgregar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnAgregar.MouseMove
        btnAgregar.ForeColor = Color.White
        btnAgregar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnAgregar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonBlanco
        'Tamaño
        btnAgregar.Width = 171
        btnAgregar.Location = New Point(539, 230)
    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        btnAgregar.ForeColor = Color.Black
        btnAgregar.FlatAppearance.BorderColor = Color.White
        btnAgregar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonFixed2
        'Tamaño
        btnAgregar.Width = 161
        btnAgregar.Location = New Point(549, 230)
    End Sub

    'Eliminar
    Private Sub btnEliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseMove
        btnEliminar.ForeColor = Color.White
        btnEliminar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnEliminar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Blanco
        'tamaño
        btnEliminar.Width = 171
        btnEliminar.Location = New Point(539, 280)
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.ForeColor = Color.Black
        btnEliminar.FlatAppearance.BorderColor = Color.White
        btnEliminar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Fixed2
        'Tamaño
        btnEliminar.Width = 161
        btnEliminar.Location = New Point(549, 280)
    End Sub

    'Guardar
    Private Sub btnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        btnGuardar.ForeColor = Color.White
        btnGuardar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnGuardar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Blanco
        'tamaño
        btnGuardar.Width = 171
        btnGuardar.Location = New Point(539, 330)
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.ForeColor = Color.Black
        btnGuardar.FlatAppearance.BorderColor = Color.White
        btnGuardar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Fixed
        'Tamaño
        btnGuardar.Width = 161
        btnGuardar.Location = New Point(549, 330)
    End Sub
End Class