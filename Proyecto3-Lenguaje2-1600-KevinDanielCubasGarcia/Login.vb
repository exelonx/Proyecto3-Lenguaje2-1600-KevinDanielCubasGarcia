Public Class FormLogin
    Dim Ventana As New VentanaEstilo
    Dim validacion As New Validaciones
    Dim user, pass As String
    Public sD As Integer

    Private Sub chkMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarContra.CheckedChanged
        If chkMostrarContra.Checked = True Then
            txtContraseña.PasswordChar = Nothing
        Else
            txtContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        'Evitar que se ingrese espacio en blanco
        validacion.validar(3, e)
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        'Evitar que se ingrese espacio en blanco
        validacion.validar(3, e)
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = "pedrito"
        pass = "clavounclavito"
        Main.Show()
        FormTecnologia.Show()
        FormRopa.Show()
        FormDeporte.Show()
    End Sub

    Private Sub btnValidar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnValidar.MouseMove
        btnValidar.ForeColor = Color.Black
        btnValidar.Height = 35
        btnValidar.Location = New Point(0, 141)
    End Sub

    Private Sub btnValidar_MouseLeave(sender As Object, e As EventArgs) Handles btnValidar.MouseLeave
        btnValidar.ForeColor = Color.White
        btnValidar.Height = 29
        btnValidar.Location = New Point(0, 147)
    End Sub

    Private Sub btnCerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCerrar.MouseMove
        btnCerrar.ForeColor = Color.Black
        btnCerrar.Height = 35
        btnCerrar.Location = New Point(113, 141)
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        btnCerrar.ForeColor = Color.White
        btnCerrar.Height = 29
        btnCerrar.Location = New Point(113, 147)
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If user = txtUsuario.Text And pass = txtContraseña.Text Then
            Main.Show()
            Me.Hide()
            Main.txtNombre.Focus()
        Else
            MessageBox.Show("Usuario y contraseña equivocada.", "Datos erroneos")
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

    Private Sub btnVentanaSalir_MouseMove(sender As Object, e As MouseEventArgs) Handles btnVentanaSalir.MouseMove
        btnVentanaSalir.ForeColor = Color.White
    End Sub

    Private Sub btnVentanaSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnVentanaSalir.MouseLeave
        btnVentanaSalir.ForeColor = Color.Black
    End Sub

    Private Sub btnVentanaSalir_Click(sender As Object, e As EventArgs) Handles btnVentanaSalir.Click
        Close()
    End Sub

    'Botones de cerrar y minimizar
    Private Sub btnVentanaMin_Click(sender As Object, e As EventArgs) Handles btnVentanaMin.Click
        Me.WindowState = FormWindowState.Minimized
        txtUsuario.Focus()
    End Sub
End Class
