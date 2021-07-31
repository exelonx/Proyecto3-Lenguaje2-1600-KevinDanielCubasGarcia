Public Class FormEscOfi
    '********************************************************Objetos************************************************************
    Dim Ventana As New VentanaEstilo
    Dim validacion As New Validaciones

    '*******************************************************Variables***********************************************************
    Dim productos(5), extras, cantidad As Integer
    Dim subTotal, descuento, impuesto, total As Double
    Dim acumST, acumIVA, acumTot, acumDesc As Double 'Acumuladores
    Dim selectPrecio, selectIVA, selectTot, selectDesc 'para hacer decremento a los acumuladores
    Dim antiCloseBug As Boolean 'Para evitar bug al cerrar formulario cuando se trata de evitar de perder información

    '*************************************************Eventos de Formulario*****************************************************
    Private Sub FormDeporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        antiCloseBug = False
        txtAcumulador.Text = Format(0, "0.00")
        cantidad = 0
        PictureBox3.Location = New Point(184, 192)
        Me.Size = New Size(689, 459)
    End Sub

    Private Sub FormEscOfi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Disminución de contador contfilas
        If antiCloseBug = False Then
            Main.contFilas -= dgvSalida.Rows.Count
        End If
    End Sub

    '******************************************************Funciones************************************************************
    Public Function getDescuentoUnitario(variable As Double) As Double
        Dim descAux
        If Main.chkMembresia.Checked = True Then
            descAux = variable * 0.1
        Else
            descAux = 0
        End If
        Return descAux
    End Function

    '****************************************************Procedimientos*********************************************************
    Public Sub setDecremento(e As DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            selectPrecio = dgvSalida.Rows(e.RowIndex).Cells(1).Value
            selectDesc = dgvSalida.Rows(e.RowIndex).Cells(2).Value
            selectIVA = dgvSalida.Rows(e.RowIndex).Cells(3).Value
            selectTot = dgvSalida.Rows(e.RowIndex).Cells(4).Value
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
            setProducto(cmbProductos, "BOLIGRAFO TECH3 NEGRO L.2,059.00", "BOLIGRAFO STRATFORD CROMO L.979.00", "BOLIGRAFO KIZOKU TINTA NEGRO L.239.00", "LAPIZ TINTA NEGRO/ROJO SENCILLO L.7.00", "LAPIZ CARBON L.5.00")
            setPrecio(2059, 979, 239, 7, 5)
        End If
    End Sub

    '******************************************************CheckBoxs************************************************************
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

    Private Sub chkPapel_CheckedChanged(sender As Object, e As EventArgs) Handles chkPapel.CheckedChanged
        precioExtra(chkPapel, 150)
    End Sub

    Private Sub chkSacapuntas_CheckedChanged(sender As Object, e As EventArgs) Handles chkSacapuntas.CheckedChanged
        precioExtra(chkSacapuntas, 10)
    End Sub

    Private Sub chkBorrador_CheckedChanged(sender As Object, e As EventArgs) Handles chkBorrador.CheckedChanged
        precioExtra(chkBorrador, 5)
    End Sub

    '******************************************************TextBoxs*************************************************************
    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        validacion.validarCantidad(txtCantidad)
        If txtCantidad.Text <> Nothing Then
            txtPrecio.Text = Format(productos(5) * txtCantidad.Text, "0.00")
        Else
            cantidad = 0
            txtPrecio.Text = Format(0, "0.00")
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        validacion.validar(1, e)
    End Sub

    '******************************************************ComboBoxs************************************************************
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

    Private Sub cmbProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProductos.KeyPress
        validacion.validar(2, e)
    End Sub

    '*****************************************************RadioButton***********************************************************
    Private Sub rbSillas_CheckedChanged(sender As Object, e As EventArgs) Handles rbSillas.CheckedChanged
        seleccionProducto()
    End Sub

    Private Sub rbLapices_CheckedChanged(sender As Object, e As EventArgs) Handles rbLapices.CheckedChanged
        seleccionProducto()
    End Sub

    '*******************************************************Buttons*************************************************************
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Validaciones
        If rbSillas.Checked = True And rbLapices.Checked = True And chkExtras.Checked = False Then
            MessageBox.Show("Seleccione el tipo de producto.", "Faltan Requisitos")
            Exit Sub
        ElseIf cmbProductos.Text = Nothing And chkExtras.Checked = False Then
            MessageBox.Show("Producto sin seleccionar.", "Faltan Requisitos")
            Exit Sub
        ElseIf txtCantidad.Text = Nothing And chkExtras.Checked = False Then
            MessageBox.Show("Casilla vacia, ingrese la cantidad.", "Faltan Requisitos")
            txtCantidad.Focus()
            Exit Sub
        ElseIf chkPapel.Checked = False And chkBorrador.Checked = False And chkSacapuntas.Checked = False And chkExtras.Checked = True Then
            MessageBox.Show("Seleccione al menos un extra.", "Faltan Requisitos")
            Exit Sub
        End If
        If chkPapel.Checked = False And chkBorrador.Checked = False And chkSacapuntas.Checked = False Then
            txtExtras.Text = Format(0, "0.00")
        End If
        'Calculos
        If txtCantidad.Text = Nothing Then
            txtPrecio.Text = Format(0, "0.00")
        End If
        cantidad = txtCantidad.Text
        'SubTotal
        subTotal = (productos(5) * cantidad) + extras
        txtSubT.Text = Format(subTotal, "0.00")
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nfilas As Integer 'Contador de filas
        If txtTotal.Text = Nothing Then
            MessageBox.Show("Debe calcular primero.", "Faltan Requisitos")
            Exit Sub
        Else
            'Llenado de la matriz
            'Productos
            Dim aux As Double
            aux = productos(5) * cantidad
            If rbSillas.Checked = True Or rbLapices.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = cmbProductos.Text
                dgvSalida(1, nfilas).Value = Format(aux, "0.00")
                dgvSalida(2, nfilas).Value = Format(getDescuentoUnitario(aux), "0.00")
                dgvSalida(3, nfilas).Value = Format(aux * 0.15, "0.00")
                dgvSalida(4, nfilas).Value = Format(aux - getDescuentoUnitario(aux) + (aux * 0.15), "0.00")
                Main.contFilas += 1
            End If
            If chkPapel.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = "Resma de Papel"
                dgvSalida(1, nfilas).Value = Format(150, "0.00")
                dgvSalida(2, nfilas).Value = Format(getDescuentoUnitario(150), "0.00")
                dgvSalida(3, nfilas).Value = Format(150 * 0.15, "0.00")
                dgvSalida(4, nfilas).Value = Format(150 - getDescuentoUnitario(150) + (150 * 0.15), "0.00")
                Main.contFilas += 1
            End If
            If chkSacapuntas.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = "Sacapuntas"
                dgvSalida(1, nfilas).Value = Format(10, "0.00")
                dgvSalida(2, nfilas).Value = Format(getDescuentoUnitario(10), "0.00")
                dgvSalida(3, nfilas).Value = Format(10 * 0.15, "0.00")
                dgvSalida(4, nfilas).Value = Format(10 - getDescuentoUnitario(10) + (10 * 0.15), "0.00")
                Main.contFilas += 1
            End If
            If chkBorrador.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = "Borrador"
                dgvSalida(1, nfilas).Value = Format(5, "0.00")
                dgvSalida(2, nfilas).Value = Format(getDescuentoUnitario(5), "0.00")
                dgvSalida(3, nfilas).Value = Format(5 * 0.15, "0.00")
                dgvSalida(4, nfilas).Value = Format(5 - getDescuentoUnitario(5) + (5 * 0.15), "0.00")
                Main.contFilas += 1
            End If
            'Limpieza del formulario
            rbSillas.Checked = False
            rbLapices.Checked = False
            chkExtras.Checked = False
            chkPapel.Checked = False
            chkSacapuntas.Checked = False
            chkBorrador.Checked = False
            txtCantidad.Clear()
            txtPrecio.Clear()
            txtExtras.Clear()
            txtSubT.Clear()
            txtDescuento.Clear()
            txtImpuesto.Clear()
            txtTotal.Clear()
            Ventana.visibilidadInversa(gpxTipoProducto, PictureBox3)
            'Incrementos de acumuladores
            acumST += subTotal
            acumIVA += impuesto
            acumTot += total
            acumDesc += descuento
            txtAcumulador.Text = acumTot
            'Activar botones
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
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
        'DataGridV Oficina al DataGridV Main
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

    '***************************************************************************************************************************
    '****************************************************Personalización********************************************************
    '***************************************************************************************************************************
    Private Sub panelVentana_MouseDown(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseDown
        Ventana.setUbicacionMouse(e)
    End Sub

    Private Sub panelVentana_MouseUp(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseUp
        Ventana.clickVentana = False
    End Sub

    Private Sub panelVentana_MouseMove(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseMove
        Ventana.ventanaPresionada(Me, e, panelVentana)
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

    'Colores de botones
    'Calcular
    Private Sub btnCalcular_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCalcular.MouseMove
        btnCalcular.ForeColor = Color.White
        btnCalcular.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnCalcular.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonBlanco
        'Tamaño
        btnCalcular.Width = 171
        btnCalcular.Location = New Point(518, 180)
    End Sub

    Private Sub btnCalcular_MouseLeave(sender As Object, e As EventArgs) Handles btnCalcular.MouseLeave
        btnCalcular.ForeColor = Color.Black
        btnCalcular.FlatAppearance.BorderColor = Color.White
        btnCalcular.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonFixed2
        'Tamaño
        btnCalcular.Width = 161
        btnCalcular.Location = New Point(528, 180)
    End Sub

    'Agregar
    Private Sub btnAgregar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnAgregar.MouseMove
        btnAgregar.ForeColor = Color.White
        btnAgregar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnAgregar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonBlanco
        'Tamaño
        btnAgregar.Width = 171
        btnAgregar.Location = New Point(518, 230)
    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        btnAgregar.ForeColor = Color.Black
        btnAgregar.FlatAppearance.BorderColor = Color.White
        btnAgregar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonFixed2
        'Tamaño
        btnAgregar.Width = 161
        btnAgregar.Location = New Point(528, 230)
    End Sub

    'Eliminar
    Private Sub btnEliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseMove
        btnEliminar.ForeColor = Color.White
        btnEliminar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnEliminar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Blanco
        'tamaño
        btnEliminar.Width = 171
        btnEliminar.Location = New Point(518, 280)
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.ForeColor = Color.Black
        btnEliminar.FlatAppearance.BorderColor = Color.White
        btnEliminar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Fixed2
        'Tamaño
        btnEliminar.Width = 161
        btnEliminar.Location = New Point(528, 280)
    End Sub

    'Guardar
    Private Sub btnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        btnGuardar.ForeColor = Color.White
        btnGuardar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnGuardar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Blanco
        'tamaño
        btnGuardar.Width = 171
        btnGuardar.Location = New Point(518, 330)
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.ForeColor = Color.Black
        btnGuardar.FlatAppearance.BorderColor = Color.White
        btnGuardar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Fixed
        'Tamaño
        btnGuardar.Width = 161
        btnGuardar.Location = New Point(528, 330)
    End Sub
End Class