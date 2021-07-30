Public Class Main
    'Nodos
    Dim inicio As Nodo
    Dim actual As Nodo
    'Objetos
    Dim ventana As New VentanaEstilo
    Dim validacion As New Validaciones
    'Variables
    Dim factura As Integer
    Public acumST, acumIVA, acumTot, acumDesc As Double 'Acumuladores
    Dim selectPrecio, selectIVA, selectTot, selectDesc 'para hacer decremento a los acumuladores
    Public indexFila As Integer 'Contador para main
    Public contFilas As Integer 'Contador los demas formularios: 0 = Tecnologia, 1 = Oficina, 2 = Ropa, 3 = Deporte
    Dim candado As Integer 'Sirve de candado para evitar bucle en el checkbox de membresía

    'Variables auxiliares
    Public nFacturaAux As String                  'Este se usara para buscar los datos
    Public metodoPago, membresia, nombre As String
    Public dataGridAux(4, 50) As String   'Almacenara el datagrid en este arreglo
    Public subTAux, descAux, ivaAux, totalAux As Double

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'El nodo al inicio toma el valor de nothing
        inicio = Nothing
        membresia = "Sin Membresía"
        factura = 1
        txtFactura.Text = factura
        txtFactura.Focus()
    End Sub

    'Procedimiento para disminuir acumuladores
    Public Sub setDecremento(e As DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            selectPrecio = dgvMain.Rows(e.RowIndex).Cells(1).Value
            selectDesc = dgvMain.Rows(e.RowIndex).Cells(2).Value
            selectIVA = dgvMain.Rows(e.RowIndex).Cells(3).Value
            selectTot = dgvMain.Rows(e.RowIndex).Cells(4).Value
        End If
    End Sub

    Private Sub chkMembresia_CheckedChanged(sender As Object, e As EventArgs) Handles chkMembresia.CheckedChanged
        'Validando ventanas
        FormDeporte.Close()
        FormRopa.Close()
        FormTecnologia.Close()
        FormEscOfi.Close()
        candado -= 1 'Rompimiento del candado
        If candado = -1 Then
            candado = 0
        End If
        If contFilas = 0 Then
            If chkMembresia.Checked = True Then
                MsgBox("El cliente recibirá 10% de descuento.", vbInformation, "Membresía")
            End If
        ElseIf contFilas > 0 And candado = 0 Then
            If MsgBox("Ya se han agregado artículos, si procede con esta opción se eliminarán TODOS los productos agregados a la lista." + vbCr + "" + vbCr + "¿Desea continuar con esta acción?", vbCritical + vbYesNo, "Alerta") = vbNo Then
                candado = 2 'Se le asigna 2, al realizar el siguiente paso automaticamente bajara a 1, evitando el bucle ya que no queda en 0
                If chkMembresia.Checked = True Then
                    chkMembresia.Checked = False
                Else
                    chkMembresia.Checked = True
                End If
            Else
                If chkMembresia.Checked = True Then
                    MsgBox("El cliente recibirá 10% de descuento.", vbInformation, "Membresía")
                End If
                'Limpieza del contenido
                contFilas = 0
                indexFila = 0
                dgvMain.Rows.Clear()
                acumDesc = 0
                acumIVA = 0
                acumST = 0
                acumTot = 0
                txtDesc.Clear()
                txtIVA.Clear()
                txtSubT.Clear()
                txtTotal.Clear()
            End If
        End If
        If chkMembresia.Checked = True Then
            membresia = "Con Membresía"
        Else
            membresia = "Sin Membresía"
        End If
    End Sub

    'Validaciones
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        validacion.validar(0, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTecno.Click
        FormTecnologia.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        If txtNombre.Text = Nothing Then
            MessageBox.Show("Casilla vacia, ingrese el nombre del cliente.", "Faltan Requisitos")
            txtNombre.Focus()
            Exit Sub
        ElseIf rbEfectivo.Checked = False And rbTarjeta.Checked = False Then
            MessageBox.Show("Seleccione un metodo de pago.", "Faltan Requisitos")
            Exit Sub
        End If
        factura = txtFactura.Text
        nombre = txtNombre.Text
        'el nodo de inicio toma los valores del nuevo nodo creado
        inicio = New Nodo(factura, inicio, nombre, metodoPago, membresia, dgvMain, acumST, acumDesc, acumIVA, acumTot)
        actual = inicio
        'Limpieza
        contFilas = 0
        indexFila = 0
        inicio.contFilas = dgvMain.Rows.Count
        dgvMain.Rows.Clear()
        acumDesc = 0
        acumIVA = 0
        acumST = 0
        acumTot = 0
        txtNombre.Clear()
        txtDesc.Clear()
        txtIVA.Clear()
        txtSubT.Clear()
        txtTotal.Clear()
        rbEfectivo.Checked = False
        rbTarjeta.Checked = False
        chkMembresia.Checked = False
        factura += 1
        txtFactura.Text = factura
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvMain.Rows.Count > 0 Then
            dgvMain.Rows.Remove(dgvMain.CurrentRow)
            contFilas -= 1
            indexFila -= 1
            'Decremento a los acumuladores
            acumST -= selectPrecio
            acumIVA -= selectIVA
            acumTot -= selectTot
            acumDesc -= selectDesc
            txtSubT.Text = Format(acumST, "0.00")
            txtDesc.Text = Format(acumDesc, "0.00")
            txtIVA.Text = Format(acumIVA, "0.00")
            txtTotal.Text = Format(acumTot, "0.00")
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnRopa_Click(sender As Object, e As EventArgs) Handles btnRopa.Click
        FormRopa.Show()
    End Sub

    Private Sub btnDeporte_Click(sender As Object, e As EventArgs) Handles btnDeporte.Click
        FormDeporte.Show()
    End Sub

    Private Sub btnEscOfi_Click(sender As Object, e As EventArgs) Handles btnEscOfi.Click
        FormEscOfi.Show()
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

    'Botones de cerrar y minimizar
    Private Sub btnVentanaMin_Click(sender As Object, e As EventArgs) Handles btnVentanaMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVentanaSalir_Click(sender As Object, e As EventArgs) Handles btnVentanaSalir.Click
        Application.Exit()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnVentanaSalir_MouseMove(sender As Object, e As MouseEventArgs) Handles btnVentanaSalir.MouseMove
        btnVentanaSalir.ForeColor = Color.White
    End Sub

    Private Sub btnVentanaSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnVentanaSalir.MouseLeave
        btnVentanaSalir.ForeColor = Color.Black
    End Sub

    'Colores de botones
    'Boton Tecnologia
    Private Sub btntecno_MouseMove(sender As Object, e As MouseEventArgs) Handles btnTecno.MouseMove
        btnTecno.ForeColor = Color.White
        btnTecno.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Tecnologia_Diunsa_Blanco_Long
        'Tamaño
        btnTecno.Width = 138
    End Sub

    Private Sub btntecno_MouseLeave(sender As Object, e As EventArgs) Handles btnTecno.MouseLeave
        btnTecno.ForeColor = Color.Black
        btnTecno.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Tecnologia_Diunsa_Fixed2
        'Tamaño
        btnTecno.Width = 128
    End Sub

    'Boton Oficina
    Private Sub btnEscOfi_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEscOfi.MouseMove
        btnEscOfi.ForeColor = Color.White
        btnEscOfi.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Oficina_Diunsa_Blanco_Long
        'Tamaño
        btnEscOfi.Width = 138
    End Sub

    Private Sub btnEscOfi_MouseLeave(sender As Object, e As EventArgs) Handles btnEscOfi.MouseLeave
        btnEscOfi.ForeColor = Color.Black
        btnEscOfi.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Oficina2_Diunsa_Fixed2
        'Tamaño
        btnEscOfi.Width = 128
    End Sub

    'Boton Ropa
    Private Sub btnRopa_MouseMove(sender As Object, e As MouseEventArgs) Handles btnRopa.MouseMove
        btnRopa.ForeColor = Color.White
        btnRopa.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Moda_Diunsa_blanco_Long
        'tamaño
        btnRopa.Width = 138
    End Sub

    Private Sub btnRopa_MouseLeave(sender As Object, e As EventArgs) Handles btnRopa.MouseLeave
        btnRopa.ForeColor = Color.Black
        btnRopa.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Moda_Diunsa_Fixed
        'Tamaño
        btnRopa.Width = 128
    End Sub

    'Boton Deporte
    Private Sub btnDeporte_MouseMove(sender As Object, e As MouseEventArgs) Handles btnDeporte.MouseMove
        btnDeporte.ForeColor = Color.White
        btnDeporte.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Deporte_Diunsa_Blanco_Long
        'tamaño
        btnDeporte.Width = 138
    End Sub

    Private Sub rbEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbEfectivo.CheckedChanged
        If rbEfectivo.Checked = True Then
            metodoPago = "Efectivo"
        End If
    End Sub

    Private Sub rbTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles rbTarjeta.CheckedChanged
        If rbTarjeta.Checked = True Then
            metodoPago = "Tarjeta"
        End If
    End Sub

    Private Sub btnDeporte_MouseLeave(sender As Object, e As EventArgs) Handles btnDeporte.MouseLeave
        btnDeporte.ForeColor = Color.Black
        btnDeporte.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Deporte_Diunsa_Fixed2
        'Tamaño
        btnDeporte.Width = 128
    End Sub

    Private Sub dgvMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellContentClick
        setDecremento(e)
        btnEliminar.Enabled = Enabled
        btnEliminar.BackColor = ColorTranslator.FromHtml("#181072")
    End Sub

    Private Sub dgvMain_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvMain.RowsRemoved
        If dgvMain.Rows.Count = 0 Then
            btnFacturar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub dgvMain_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvMain.RowsAdded
        btnFacturar.Enabled = True
        btnFacturar.BackColor = ColorTranslator.FromHtml("#181072")
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim index As Integer
        actual = inicio
        nFacturaAux = InputBox("Ingrese el número de factura.", "Factura")
        While actual IsNot Nothing
            'Si el número de factura ingresado coincide con el número de factura almacenado en la lista procedera a mostrar la información
            If nFacturaAux = actual.nfactura Then
                FormHistorico.Show()
                FormHistorico.txtFactura.Text = actual.nfactura
                FormHistorico.txtNomCliente.Text = actual.nombre
                FormHistorico.txtMembresia.Text = actual.Membresia
                FormHistorico.txtMetodoPago.Text = actual.metodoPago
                FormHistorico.txtSubTotal.Text = actual.st
                FormHistorico.txtDescuento.Text = actual.desc
                FormHistorico.txtImpuesto.Text = actual.iva
                FormHistorico.txtTotal.Text = actual.total
                Do While (index < actual.contFilas)

                    FormHistorico.dgvHistorial.Rows.Add()
                    FormHistorico.dgvHistorial(0, index).Value = actual.dataGridC(0, index)
                    FormHistorico.dgvHistorial(1, index).Value = actual.dataGridC(1, index)
                    FormHistorico.dgvHistorial(2, index).Value = actual.dataGridC(2, index)
                    FormHistorico.dgvHistorial(3, index).Value = actual.dataGridC(3, index)
                    FormHistorico.dgvHistorial(4, index).Value = actual.dataGridC(4, index)
                    index += 1
                Loop
                Exit Sub
            End If
            actual = actual.nodo
        End While
        If actual Is Nothing Then
            MsgBox("Su número de factura no existe.", vbExclamation, "Factura no existe")
        End If
        actual = inicio
    End Sub

    'Boton Facturar
    Private Sub btnfacturar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnFacturar.MouseMove
        btnFacturar.ForeColor = Color.Black
    End Sub

    Private Sub btnfacturar_MouseLeave(sender As Object, e As EventArgs) Handles btnFacturar.MouseLeave
        btnFacturar.ForeColor = Color.White
    End Sub
    'Boton Eliminar
    Private Sub btneliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseMove
        btnEliminar.ForeColor = Color.Black
    End Sub

    Private Sub btneliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.ForeColor = Color.White
    End Sub
    'Boton Sesión
    Private Sub btnhistorial_MouseMove(sender As Object, e As MouseEventArgs) Handles btnHistorial.MouseMove
        btnHistorial.ForeColor = Color.Black
    End Sub

    Private Sub btnhistorial_MouseLeave(sender As Object, e As EventArgs) Handles btnHistorial.MouseLeave
        btnHistorial.ForeColor = Color.White
    End Sub
End Class