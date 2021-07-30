Public Class Main
    Dim ventana As New VentanaEstilo
    Dim validacion As New Validaciones
    Dim factura As Integer
    Public acumST, acumIVA, acumTot As Double
    Public indexFila As Integer 'Contador para main
    Public contFilas As Integer 'Contador los demas formularios: 0 = Tecnologia, 1 = Oficina, 2 = Ropa, 3 = Deporte

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        factura = 1
        txtFactura.Text = factura
        txtFactura.Focus()
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
            Exit Sub
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
        btnEscOfi.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Oficina_Diunsa_Blanco_long
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

    Private Sub btnDeporte_MouseLeave(sender As Object, e As EventArgs) Handles btnDeporte.MouseLeave
        btnDeporte.ForeColor = Color.Black
        btnDeporte.BackgroundImage = Proyecto3_Lenguaje2_1600_KevinDanielCubasGarcia.My.Resources.Resources.Deporte_Diunsa_Fixed2
        'Tamaño
        btnDeporte.Width = 128
    End Sub

    'Boton Facturar
    Private Sub btnfacturar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnfacturar.MouseMove
        btnFacturar.ForeColor = Color.Black
    End Sub

    Private Sub btnfacturar_MouseLeave(sender As Object, e As EventArgs) Handles btnFacturar.MouseLeave
        btnFacturar.ForeColor = Color.White
    End Sub
    'Boton Eliminar
    'Boton Sesión
End Class