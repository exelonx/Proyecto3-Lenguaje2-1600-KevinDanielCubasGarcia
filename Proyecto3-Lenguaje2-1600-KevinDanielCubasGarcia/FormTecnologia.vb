Public Class FormTecnologia
    Dim ventana As New VentanaEstilo
    Dim validacion As New Validaciones
    Dim preciosBase(3), cantidad As Integer
    Dim precioAccesorio(2, 3), precioAccesorioNeto As Integer
    Dim indexAcces As Integer 'Para situar el arreglo de accesorios al agregar
    Dim calculos(2) As Double '0 = SubTotal, 1 = Impuesto, 2 = Total
    Dim acumST, acumIVA, acumTot As Double 'Acumuladores
    Dim selectPrecio, selectIVA, selectTot 'para hacer decremento a los acumuladores
    Dim antiCloseBug As Boolean 'Para evitar bug al cerrar formulario cuando se trata de evitar de perder información

    'Procedimientos
    Public Sub setDecremento(e As DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            selectPrecio = dgvSalida.Rows(e.RowIndex).Cells(1).Value
            selectIVA = dgvSalida.Rows(e.RowIndex).Cells(2).Value
            selectTot = dgvSalida.Rows(e.RowIndex).Cells(3).Value
        End If
    End Sub

    Public Sub visibilidad(indice As Integer)
        Select Case indice
            Case 0
                gpxProducto.Visible = True
                gpxAccesorios.Visible = True
                PictureBox3.Visible = False
                pbAccesorios.Visible = False
            Case 1
                PictureBox3.Visible = False
                gpxProducto.Visible = True
                gpxAccesorios.Visible = False
                pbAccesorios.Visible = True
        End Select
    End Sub

    Public Sub accesorios(txt1 As String, txt2 As String, txt3 As String)
        chkAcces1.Text = txt1
        chkAcces2.Text = txt2
        chkAcces3.Text = txt3
    End Sub

    Public Sub visibilidad(bool As Boolean)
        'chkAcces2.Visible = bool
        chkAcces3.Visible = bool
        'cmbAcces1.Visible = bool
        cmbAcces2.Visible = bool
        cmbAcces3.Visible = bool
    End Sub

    Public Sub setProducto(cmb As ComboBox, acces1 As String, acces2 As String, acces3 As String)
        cmb.Items.Clear()
        cmb.Items.Add(acces1)
        cmb.Items.Add(acces2)
        cmb.Items.Add(acces3)
    End Sub

    Public Sub seleccionAccesorio(cmb As ComboBox, acces1 As String, acces2 As String)
        cmb.Items.Clear()
        cmb.Items.Add(acces1)
        cmb.Items.Add(acces2)
    End Sub

    Public Sub setPrecio(precioDestino() As Integer, precio1 As Integer, precio2 As Integer, precio3 As Integer)
        Dim precios(3) As Integer
        precios(0) = precio1
        precios(1) = precio2
        precios(2) = precio3
        For i = 0 To 2
            precioDestino(i) = precios(i)
        Next
    End Sub

    Public Sub setPrecioAccesorios(indice As Integer, precioAccesorio(,) As Integer, precio1 As Integer, precio2 As Integer)
        Dim precios(2) As Integer
        precios(0) = precio1
        precios(1) = precio2
        For i = 0 To 2
            precioAccesorio(indice, i) = precios(i)
        Next
    End Sub

    Public Sub reinicioCantidad()
        txtCantidadProducto.Text = Nothing
        txtCantidadProducto.Enabled = False
        lbCantidad.Enabled = False
    End Sub

    Public Sub seleccionProducto()
        If rbComputadoras.Checked = True Then
            'Reinicio de cantidad
            reinicioCantidad()
            validacion.chkClear(chkAcces1, chkAcces2, chkAcces3)
            'Productos
            gpxProducto.Text = "Computadoras"
            cmbProducto.Text = Nothing
            setProducto(cmbProducto, "DELL 15.6/R5 3500U L.19,890.00", "HP PAV 15.6/R3 3250U L.14,490.00", "DELL G3 15.6/i5 10MA L.24,989.00")
            setPrecio(preciosBase, 19890, 14490, 24989) 'Precio Base
            'Accesorios
            accesorios("USB", "Monitores", "Routers")
            seleccionAccesorio(cmbAcces1, "USB SANDISK CRUZER 8GB L.140.00", "USB SANDISK 16GB L.250.00")
            setPrecioAccesorios(0, precioAccesorio, 140, 250) 'Precios accesorios
            seleccionAccesorio(cmbAcces2, "SAMSUNG 22/FULLHD/HDMI L.3,490.00", "HP 27/FULLHD L.6,490.00")
            setPrecioAccesorios(1, precioAccesorio, 3490, 6490) 'Precios accesorios
            seleccionAccesorio(cmbAcces3, "ROUTER MOVIL HUAWEI WIFI 4G-LTE L.1,490.00", "ROUTER HUAWEI WS5200 L.1,689.00")
            setPrecioAccesorios(2, precioAccesorio, 1490, 1689) 'Precios accesorios
            visibilidad(True)
            visibilidad(0)
        ElseIf rbCelulares.Checked = True Then
            'Reinicio de cantidad
            reinicioCantidad()
            gpxProducto.Text = "Celulares"
            cmbProducto.Text = Nothing
            setProducto(cmbProducto, "HUAWEI Y9A 128GB Negro L.9,390.00", "SAMSUNG S21 ULTRA Negro L.34,551.00", "MOTOROLA G8 Power Azul L. 3,689.00")
            setPrecio(preciosBase, 9390, 34551, 3649) 'Precio Base
            'Accesorios
            accesorios("Cargador", "Protector L. 300", "")
            setPrecioAccesorios(0, precioAccesorio, 500, 150) 'Precios accesorios
            seleccionAccesorio(cmbAcces1, "Cargador Original L.500.00", "Cargador Generico L.150.00")
            setPrecioAccesorios(1, precioAccesorio, 300, 0) 'Precios accesorios
            validacion.chkClear(chkAcces1, chkAcces2, chkAcces3)
            visibilidad(False)
            visibilidad(0)
        Else
            'Reinicio de cantidad
            reinicioCantidad()
            gpxProducto.Text = "Solo Accesorios"
            cmbProducto.Text = Nothing
            setProducto(cmbProducto, "USB SANDISK 16GB L.250.00", "Cargador Original L.500.00", "SAMSUNG 22/FULLHD/HDMI L.3,490.00")
            setPrecio(preciosBase, 250, 500, 3490) 'Precio Base
            validacion.chkClear(chkAcces1, chkAcces2, chkAcces3)
            visibilidad(1)
            visibilidad(True)
        End If
    End Sub

    Private Sub FormTecnologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        antiCloseBug = False
        txtAcumulador.Text = Format(0, "0.00")
        PictureBox3.Location = New Point(189, 193)
        pbAccesorios.Location = New Point(333, 193)
        Me.Size = New Size(717, 456)
    End Sub

    Private Sub FormTecnologia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Disminución de contador contfilas
        If antiCloseBug = False Then
            Main.contFilas -= dgvSalida.Rows.Count
        End If
    End Sub

    Private Sub rbConsolas_CheckedChanged(sender As Object, e As EventArgs) Handles rbSoloAccesorios.CheckedChanged
        seleccionProducto()
        indexAcces = 2
    End Sub

    Private Sub cmbProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProducto.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub txtCantidadProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadProducto.KeyPress
        validacion.validar(1, e)
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAcces1.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAcces2.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAcces3.KeyPress
        validacion.validar(2, e)
    End Sub

    Private Sub rbComputadoras_CheckedChanged(sender As Object, e As EventArgs) Handles rbComputadoras.CheckedChanged
        seleccionProducto()
        indexAcces = 0
    End Sub

    Private Sub rbCelulares_CheckedChanged(sender As Object, e As EventArgs) Handles rbCelulares.CheckedChanged
        seleccionProducto()
        indexAcces = 1
    End Sub

    Private Sub chkAcces1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAcces1.CheckedChanged
        validacion.activacionPorCheckBox(chkAcces1, cmbAcces1)
    End Sub

    Private Sub chkAcces2_CheckedChanged(sender As Object, e As EventArgs) Handles chkAcces2.CheckedChanged
        validacion.activacionPorCheckBox(chkAcces2, cmbAcces2)
        If rbCelulares.Checked = True Then
            If chkAcces2.Checked = True Then
                precioAccesorio(1, 3) += precioAccesorio(1, 0)
            Else
                precioAccesorio(1, 3) -= precioAccesorio(1, 0)
            End If
            precioAccesorioNeto = precioAccesorio(0, 3) + precioAccesorio(1, 3)
            txtAccesorios.Text = Format(precioAccesorioNeto, "0.00")
        ElseIf precioAccesorio(1, 3) = 300 Then
            precioAccesorio(1, 3) = 0
            precioAccesorioNeto = precioAccesorio(0, 3) + precioAccesorio(1, 3)
            txtAccesorios.Text = Format(precioAccesorioNeto, "0.00")
        End If
        If precioAccesorio(1, 3) = -300 Then
            precioAccesorio(1, 3) = 0
            precioAccesorioNeto = precioAccesorio(0, 3) + precioAccesorio(1, 3)
            txtAccesorios.Text = Format(precioAccesorioNeto, "0.00")
        End If
    End Sub

    Private Sub chkAcces3_CheckedChanged(sender As Object, e As EventArgs) Handles chkAcces3.CheckedChanged
        validacion.activacionPorCheckBox(chkAcces3, cmbAcces3)
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Validaciones
        If rbCelulares.Checked = False And rbComputadoras.Checked = False And rbSoloAccesorios.Checked = False Then
            MessageBox.Show("Seleccione el tipo de producto tecnologíco", "Faltan Requisitos")
            Exit Sub
        ElseIf cmbProducto.Text = Nothing Then
            MessageBox.Show("Seleccione un producto del tipo de " & gpxProducto.Text, "Faltan Requisitos")
            Exit Sub
        ElseIf txtCantidadProducto.Text = Nothing Then
            MessageBox.Show("Casilla vacia, ingrese la cantidad", "Faltan Requisitos")
            txtCantidadProducto.Focus()
            Exit Sub
        ElseIf (chkAcces1.Checked = True And cmbAcces1.Text = Nothing) Or (rbComputadoras.Checked = True And chkAcces2.Checked = True And cmbAcces2.Text = Nothing) Or (chkAcces3.Checked = True And cmbAcces3.Text = Nothing) Then
            MessageBox.Show("Accesorio sin seleccionar", "Faltan Requisitos")
            Exit Sub
        End If
        If chkAcces1.Checked = False And chkAcces2.Checked = False And chkAcces3.Checked = False Then
            txtAccesorios.Text = Format(0, "0.00")
        End If
        'Calculos
        'SubTotal
        cantidad = txtCantidadProducto.Text
        calculos(0) = (preciosBase(3) * cantidad) + precioAccesorioNeto
        txtSubT.Text = Format(calculos(0), "0.00")
        'Impuesto
        calculos(1) = calculos(0) * 0.15
        txtImpuesto.Text = Format(calculos(1), "0.00")
        'Total
        calculos(2) = calculos(0) + calculos(1)
        txtTotal.Text = Format(calculos(2), "0.00")
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        Select Case cmbProducto.SelectedIndex
            Case 0
                preciosBase(3) = preciosBase(0)
            Case 1
                preciosBase(3) = preciosBase(1)
            Case 2
                preciosBase(3) = preciosBase(2)
        End Select
        txtCantidadProducto.Enabled = True
        lbCantidad.Enabled = True
        If txtCantidadProducto.Text <> Nothing Then
            txtPrecioB.Text = Format(preciosBase(3) * txtCantidadProducto.Text, "0.00")
        End If
    End Sub

    Private Sub txtCantidadProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadProducto.TextChanged
        validacion.validarCantidad(txtCantidadProducto)
        If txtCantidadProducto.Text <> Nothing Then
            txtPrecioB.Text = Format(preciosBase(3) * txtCantidadProducto.Text, "0.00")
        Else
            txtPrecioB.Text = Format(0, "0.00")
        End If

    End Sub

    Private Sub cmbAcces1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcces1.SelectedIndexChanged
        salidaPrecioAccesorios(cmbAcces1, 0)
    End Sub

    Public Sub salidaPrecioAccesorios(cmb As ComboBox, indice As Integer)
        precioAccesorio(indice, 3) -= precioAccesorio(indice, 3)
        Select Case cmb.SelectedIndex
            Case 0
                precioAccesorio(indice, 3) += precioAccesorio(indice, 0)
            Case 1
                precioAccesorio(indice, 3) += precioAccesorio(indice, 1)
        End Select
        precioAccesorioNeto = precioAccesorio(0, 3) + precioAccesorio(1, 3) + precioAccesorio(2, 3)
        txtAccesorios.Text = Format(precioAccesorioNeto, "0.00")
    End Sub

    Private Sub cmbAcces2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcces2.SelectedIndexChanged
        salidaPrecioAccesorios(cmbAcces2, 1)
    End Sub

    Private Sub cmbAcces3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcces3.SelectedIndexChanged
        salidaPrecioAccesorios(cmbAcces3, 2)
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
        'Activar el seguro
        antiCloseBug = True
        Me.Close()
    End Sub

    Private Sub dgvSalida_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalida.CellContentClick
        setDecremento(e)
        btnEliminar.Enabled = Enabled
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nfilas As Integer 'Contador de filas
        If txtTotal.Text = Nothing Then
            MessageBox.Show("Debe calcular primero.", "Faltan Requisitos")
            Exit Sub
        Else
            'Llenado de la matriz
            'Productos
            nfilas = dgvSalida.Rows.Count
            dgvSalida.Rows.Add()
            dgvSalida(0, nfilas).Value = cmbProducto.Text
            dgvSalida(1, nfilas).Value = txtPrecioB.Text
            dgvSalida(2, nfilas).Value = Format(txtPrecioB.Text * 0.15, "0.00")
            dgvSalida(3, nfilas).Value = Format(txtPrecioB.Text + (txtPrecioB.Text * 0.15), "0.00")
            Main.contFilas += 1
            'Extras
            If chkAcces1.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = cmbAcces1.Text
                dgvSalida(1, nfilas).Value = Format(precioAccesorio(indexAcces, 0), "0.00")
                dgvSalida(2, nfilas).Value = Format(precioAccesorio(indexAcces, 0) * 0.15, "0.00")
                dgvSalida(3, nfilas).Value = Format(precioAccesorio(indexAcces, 0) + (precioAccesorio(0, 0) * 0.15), "0.00")
                Main.contFilas += 1
            End If

            If chkAcces2.Checked = True And rbComputadoras.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = cmbAcces2.Text
                dgvSalida(1, nfilas).Value = Format(precioAccesorio(indexAcces, 1), "0.00")
                dgvSalida(2, nfilas).Value = Format(precioAccesorio(indexAcces, 1) * 0.15, "0.00")
                dgvSalida(3, nfilas).Value = Format(precioAccesorio(indexAcces, 1) + (precioAccesorio(1, 0) * 0.15), "0.00")
                Main.contFilas += 1
            End If

            If chkAcces2.Checked = True And rbComputadoras.Checked = False Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = "Protector"
                dgvSalida(1, nfilas).Value = Format(300, "0.00")
                dgvSalida(2, nfilas).Value = Format(300 * 0.15, "0.00")
                dgvSalida(3, nfilas).Value = Format(300 + (300 * 0.15), "0.00")
                Main.contFilas += 1
            End If

            If chkAcces3.Checked = True And rbComputadoras.Checked = True Then
                nfilas = dgvSalida.Rows.Count
                dgvSalida.Rows.Add()
                dgvSalida(0, nfilas).Value = cmbAcces3.Text
                dgvSalida(1, nfilas).Value = Format(precioAccesorio(indexAcces, 2), "0.00")
                dgvSalida(2, nfilas).Value = Format(precioAccesorio(indexAcces, 2) * 0.15, "0.00")
                dgvSalida(3, nfilas).Value = Format(precioAccesorio(indexAcces, 2) + (precioAccesorio(2, 0) * 0.15), "0.00")
                Main.contFilas += 1
            End If

            'Limpieza del formulario
            rbComputadoras.Checked = False
            rbCelulares.Checked = False
            rbSoloAccesorios.Checked = False
            txtCantidadProducto.Clear()
            txtPrecioB.Clear()
            txtAccesorios.Clear()
            txtSubT.Clear()
            txtImpuesto.Clear()
            txtTotal.Clear()
            ventana.visibilidadInversa(gpxProducto, PictureBox3)
            ventana.visibilidadInversa(gpxAccesorios, pbAccesorios)
            'Incrementos de acumuladores
            acumST += calculos(0)
            acumIVA += calculos(1)
            acumTot += calculos(2)
            txtAcumulador.Text = Format(acumTot, "0.00")
            'Activar botones
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnVentanaSalir_MouseMove(sender As Object, e As MouseEventArgs) Handles btnVentanaSalir.MouseMove
        btnVentanaSalir.ForeColor = Color.White
    End Sub

    Private Sub btnVentanaSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnVentanaSalir.MouseLeave
        btnVentanaSalir.ForeColor = Color.Black
    End Sub

    'Ventana personalizada
    Private Sub panelVentana_MouseDown(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseDown
        ventana.setUbicacionMouse(e)
    End Sub

    Private Sub panelVentana_MouseUp(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseUp
        ventana.clickVentana = False
    End Sub

    Private Sub panelVentana_MouseMove(sender As Object, e As MouseEventArgs) Handles panelVentana.MouseMove
        ventana.ventanaPresionada(Me, e, panelVentana)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    'Botones de cerrar y minimizar
    Private Sub btnVentanaMin_Click(sender As Object, e As EventArgs) Handles btnVentanaMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVentanaSalir_Click(sender As Object, e As EventArgs) Handles btnVentanaSalir.Click
        Close()
    End Sub

    'Colores de botones
    'Calcular
    Private Sub btnCalcular_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCalcular.MouseMove
        btnCalcular.ForeColor = Color.White
        btnCalcular.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnCalcular.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonBlanco
        'Tamaño
        btnCalcular.Width = 171
        btnCalcular.Location = New Point(546, 180)
    End Sub

    Private Sub btnCalcular_MouseLeave(sender As Object, e As EventArgs) Handles btnCalcular.MouseLeave
        btnCalcular.ForeColor = Color.Black
        btnCalcular.FlatAppearance.BorderColor = Color.White
        btnCalcular.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.CalcularBotonFixed2
        'Tamaño
        btnCalcular.Width = 161
        btnCalcular.Location = New Point(556, 180)
    End Sub

    'Agregar
    Private Sub btnAgregar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnAgregar.MouseMove
        btnAgregar.ForeColor = Color.White
        btnAgregar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnAgregar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonBlanco
        'Tamaño
        btnAgregar.Width = 171
        btnAgregar.Location = New Point(546, 230)
    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        btnAgregar.ForeColor = Color.Black
        btnAgregar.FlatAppearance.BorderColor = Color.White
        btnAgregar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.AgregarBotonFixed2
        'Tamaño
        btnAgregar.Width = 161
        btnAgregar.Location = New Point(556, 230)
    End Sub

    'Eliminar
    Private Sub btnEliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseMove
        btnEliminar.ForeColor = Color.White
        btnEliminar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnEliminar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Blanco
        'tamaño
        btnEliminar.Width = 171
        btnEliminar.Location = New Point(546, 280)
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.ForeColor = Color.Black
        btnEliminar.FlatAppearance.BorderColor = Color.White
        btnEliminar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.EliminarBoton3Fixed2
        'Tamaño
        btnEliminar.Width = 161
        btnEliminar.Location = New Point(556, 280)
    End Sub

    'Guardar
    Private Sub btnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        btnGuardar.ForeColor = Color.White
        btnGuardar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#181072")
        btnGuardar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Blanco
        'tamaño
        btnGuardar.Width = 171
        btnGuardar.Location = New Point(546, 330)
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.ForeColor = Color.Black
        btnGuardar.FlatAppearance.BorderColor = Color.White
        btnGuardar.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.guardarBoton2Fixed
        'Tamaño
        btnGuardar.Width = 161
        btnGuardar.Location = New Point(556, 330)
    End Sub
End Class