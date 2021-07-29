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

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
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

    Private Sub btnVentanaSalir_MouseMove(sender As Object, e As MouseEventArgs) Handles btnVentanaSalir.MouseMove
        btnVentanaSalir.ForeColor = Color.White
    End Sub

    Private Sub btnVentanaSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnVentanaSalir.MouseLeave
        btnVentanaSalir.ForeColor = Color.Black
    End Sub
End Class